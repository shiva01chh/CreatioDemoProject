namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: ChangeDataUserTask

	/// <exclude/>
	public partial class ChangeDataUserTask
	{

		#region Methods: Private

		private static void ThrowExceptionIfEmptyFilters(EntitySchemaQueryFilterCollection filters) {
			var message = new LocalizableString("Terrasoft.Core",
				"ProcessSchemaChangeDataUserTask.Exception.ChangeDataWithEmptyFilter");
			ProcessUserTaskUtilities.ThrowExceptionIfEmptyFilters(filters, message);
		}

		private static EntitySchemaQuery GetEntitySchemaQuery(EntitySchemaManager entitySchemaManager,
				EntitySchema entitySchema) {
			return new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = false,
				IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks
			};
		}

		private void UpdateEntities(EntitySchema entitySchema) {
			EntitySchemaQuery esq = GetEntitySchemaQuery(UserConnection.EntitySchemaManager, entitySchema);
			esq.AddAllSchemaColumns();
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
				EntitySchemaQueryFilterCollection filters = esq.Filters;
				ThrowExceptionIfEmptyFilters(filters);
			}
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			UpdateEntityCollection(entityCollection, entitySchema);
		}

		private void UpdateEntity(EntitySchema entitySchema, Entity entity) {
			string GetDebugInfo(Entity source) {
				var info = new System.Text.StringBuilder();
				try {
					info.Append(source.SchemaName);
					info.Append($" ({source.Schema.PrimaryColumn.Name}: [{source.PrimaryColumnValue}])");
				} catch (Exception) { }
				return info.ToString();
			}
			try {
				foreach (KeyValuePair<string, object> columnValue in RecordColumnValues.Values) {
					EntitySchemaColumn column = entitySchema.GetSchemaColumnByMetaPath(columnValue.Key);
					object value = columnValue.Value;
					if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
						value = null;
					}
					entity.SetColumnValue(column, value);
				}
				entity.UseAdminRights = false;
				entity.Save(false);
			} catch (Exception e) {
				string debugInfo = GetDebugInfo(entity);
				Log.Error($"An error occurred during process element {this} when updating an entity {debugInfo}", e);
			}
		}

		private void UpdateEntitiesByChunks(EntitySchema entitySchema) {
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema);
			string primaryColumnName = entitySchema.PrimaryColumn.Name;
			esq.AddColumn(primaryColumnName);
			if (IsMatchConditions) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
				EntitySchemaQueryFilterCollection filters = esq.Filters;
				ThrowExceptionIfEmptyFilters(filters);
			}
			IList<object> entityIds = GetEntityIds(esq, primaryColumnName);
			UpdateEntities(entitySchemaManager, entitySchema, entityIds);
		}

		private IList<object> GetEntityIds(EntitySchemaQuery esq, string primaryColumnName) {
			Select select = esq.GetSelectQuery(UserConnection);
			var entityIds = new List<object>();
			select.ExecuteReader(dataReader => {
				Guid id = dataReader.GetColumnValue<Guid>(primaryColumnName);
				entityIds.Add(id);
			});
			return entityIds;
		}

		private void UpdateEntities(EntitySchemaManager entitySchemaManager, EntitySchema entitySchema,
				IList<object> entityIds) {
			EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema);
			esq.AddAllSchemaColumns();
			string primaryColumnName = entitySchema.PrimaryColumn.Name;
			EntitySchemaQueryFilterCollection filters = esq.Filters;
			IEnumerable<IEnumerable<object>> chunks = entityIds.SplitOnChunks(100);
			foreach (IEnumerable<object> chunk in chunks) {
				IEntitySchemaQueryFilterItem filter = esq
					.CreateFilterWithParameters(FilterComparisonType.Equal, primaryColumnName, chunk);
				filters.Add(filter);
				EntityCollection entities = esq.GetEntityCollection(UserConnection);
				UpdateEntityCollection(entities, entitySchema);
				esq.ResetSelectQuery();
				filters.Clear();
			}
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (EntitySchemaUId.IsEmpty()) {
				return false;
			}
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(EntitySchemaUId);
			if (RecordColumnValues.Values.Count == 0) {
				return true;
			}
			if (GlobalAppSettings.FeatureUseEntityCollectionChunksInProcessUserTask) {
				UpdateEntitiesByChunks(entitySchema);
			} else {
				UpdateEntities(entitySchema);
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void UpdateFiltersRightExprMetaDataByParameterValue(Process process,
				DataSourceFilterCollection filters) {
			foreach (IDataSourceFilterItem filter in filters) {
				if (filter is DataSourceFilterCollection dataSourceFilterCollection) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourceFilterCollection);
					continue;
				}
				var dataSourceFilter = (DataSourceFilter)filter;
				DataSourceFilterExpression rightExpression = dataSourceFilter.RightExpression;
				if (rightExpression?.Type != DataSourceFilterExpressionType.Custom) {
					continue;
				}
				rightExpression.Type = DataSourceFilterExpressionType.Parameter;
				if (rightExpression.Parameters.Count == 2) {
					DataSourceFilterExpressionParametersCollection parameters = rightExpression.Parameters;
					object metaPath = parameters[1].Value;
					parameters[1].Value = process.GetParameterValueByMetaPath((string)metaPath);
					parameters.RemoveAt(0);
				}
				if (dataSourceFilter.SubFilters?.Count > 0) {
					UpdateFiltersRightExprMetaDataByParameterValue(process, dataSourceFilter.SubFilters);
				}
			}
		}

		public virtual void UpdateEntityCollection(EntityCollection entityCollection, EntitySchema entitySchema) {
			foreach (Entity entity in entityCollection) {
				UpdateEntity(entitySchema, entity);
			}
		}

		#endregion

	}

	#endregion

}
