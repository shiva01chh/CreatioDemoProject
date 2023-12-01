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

	#region Class: DeleteDataUserTask

	/// <exclude/>
	public partial class DeleteDataUserTask
	{

		#region Methods: Private

		private static void ThrowExceptionIfEmptyFilters(EntitySchemaQueryFilterCollection filters) {
			var message = new LocalizableString("Terrasoft.Core",
				"ProcessSchemaDeleteDataUserTask.Exception.DeleteDataWithEmptyFilter");
			ProcessUserTaskUtilities.ThrowExceptionIfEmptyFilters(filters, message);
		}

		private static void DeleteEntities(EntityCollection entities) {
			while (entities.Count > 0) {
				Entity entity = entities.First.Value;
				entity.UseAdminRights = false;
				entities.RemoveFirst();
				entity.Delete();
			}
		}

		private static EntitySchemaQuery GetEntitySchemaQuery(EntitySchemaManager entitySchemaManager,
				EntitySchema entitySchema) {
			return new EntitySchemaQuery(entitySchemaManager, entitySchema.Name) {
				UseAdminRights = false,
				IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks
			};
		}

		private void DeleteEntities(EntitySchemaManager entitySchemaManager, EntitySchema entitySchema) {
			EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema);
			esq.AddAllSchemaColumns();
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			EntitySchemaQueryFilterCollection filters = esq.Filters;
			ThrowExceptionIfEmptyFilters(filters);
			EntityCollection entities = esq.GetEntityCollection(UserConnection);
			DeleteEntities(entities);
		}

		private void DeleteEntitiesByChunks(EntitySchemaManager entitySchemaManager, EntitySchema entitySchema) {
			EntitySchemaQuery esq = GetEntitySchemaQuery(entitySchemaManager, entitySchema);
			string primaryColumnName = entitySchema.PrimaryColumn.Name;
			esq.AddColumn(primaryColumnName);
			ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, esq, DataSourceFilters);
			EntitySchemaQueryFilterCollection filters = esq.Filters;
			ThrowExceptionIfEmptyFilters(filters);
			Select select = esq.GetSelectQuery(UserConnection);
			var entityIds = new List<object>();
			select.ExecuteReader(dataReader => {
				Guid id = dataReader.GetColumnValue<Guid>(primaryColumnName);
				entityIds.Add(id);
			});
			DeleteEntities(entitySchemaManager, entitySchema, entityIds);
		}

		private void DeleteEntities(EntitySchemaManager entitySchemaManager, EntitySchema entitySchema,
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
				DeleteEntities(entities);
				esq.ResetSelectQuery();
				filters.Clear();
			}
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override bool InternalExecute(ProcessExecutingContext context) {
			EntitySchemaId.CheckArgumentEmpty(nameof(EntitySchemaId));
			EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
			EntitySchema entitySchema = entitySchemaManager.GetInstanceByUId(EntitySchemaId);
			if (GlobalAppSettings.FeatureUseEntityCollectionChunksInProcessUserTask) {
				DeleteEntitiesByChunks(entitySchemaManager, entitySchema);
			} else {
				DeleteEntities(entitySchemaManager, entitySchema);
			}
			return true;
		}

		#endregion

	}

	#endregion

}
