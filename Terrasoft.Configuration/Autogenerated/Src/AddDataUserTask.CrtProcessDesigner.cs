﻿namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: AddDataUserTask

	/// <exclude/>
	public partial class AddDataUserTask
	{

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			RecordId = Guid.Empty;
			if (EntitySchemaId.Equals(Guid.Empty)) {
				return true;
			}
			if (FilterEntitySchemaId != Guid.Empty) {
				EntityCollection filterResultEntityCollection =
					GetFilterResultEntityCollection(out Dictionary<string, string> entityColumnMap);
				foreach (Entity filterResultEntity in filterResultEntityCollection) {
					Entity newEntity = GetNewEntity();
					if (newEntity == null) {
						return true;
					}
					FillRowWithDataByFilter(newEntity, filterResultEntity, entityColumnMap);
					newEntity.Save(false);
				}
			} else {
				Entity newEntity = GetNewEntity();
				if (newEntity == null) {
					return true;
				}
				FillRowWithData(newEntity);
				newEntity.Save(false);
				RecordId = newEntity.PrimaryColumnValue;
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual EntityCollection GetFilterResultEntityCollection(out Dictionary<string,
				string> entityColumnMap) {
			entityColumnMap = null;
			if (FilterEntitySchemaId.Equals(Guid.Empty)) {
				return null;
			}
			EntitySchema entitySchema = GetEntitySchema(FilterEntitySchemaId);
			if (entitySchema == null) {
				return null;
			}
			var entitySchemaQuery = new EntitySchemaQuery(entitySchema) {
				UseAdminRights = false
			};
			if (RecordDefValues.FetchMetaPathes == null || RecordDefValues.FetchMetaPathes.Count == 0) {
				entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			} else {
				entityColumnMap = new Dictionary<string, string>();
				foreach (var columnValue in RecordDefValues.FetchMetaPathes)  {
					string columnPath = entitySchema.GetSchemaColumnPathByMetaPath(columnValue.Value);
					EntitySchemaQueryColumn queryColumn = entitySchemaQuery.AddColumn(columnPath);
					entityColumnMap[columnValue.Value] = queryColumn.Name;
				}
			}
			if (!FilterEntitySchemaId.Equals(Guid.Empty) && DataSourceFilters.IsNotNullOrEmpty()) {
				ProcessUserTaskUtilities.SpecifyESQFilters(UserConnection, this, entitySchema, entitySchemaQuery,
					DataSourceFilters);
			}
			return entitySchemaQuery.GetEntityCollection(UserConnection);
		}

		public virtual EntitySchema GetEntitySchema(Guid entitySchemaId) {
			return UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaId);
		}

		public virtual Entity GetNewEntity() {
			EntitySchema entitySchema = GetEntitySchema(EntitySchemaId);
			Entity newEntity = entitySchema.CreateEntity(UserConnection);
			newEntity.SetDefColumnValues();
			newEntity.UseAdminRights = false;
			return newEntity;
		}

		public virtual void FillRowWithDataByFilter(Entity entity, Entity filterEntity,
				Dictionary<string, string> entityColumnMap) {
			FillRowWithData(entity);
			foreach (var columnValue in RecordDefValues.FetchMetaPathes) {
				EntitySchemaColumn column = entity.Schema.GetSchemaColumnByMetaPath(columnValue.Key);
				EntitySchemaColumn filterColumn =
					filterEntity.Schema.GetSchemaColumnByPath(entityColumnMap[columnValue.Value]);
				object filterValue = filterEntity.GetColumnValue(filterColumn);
				if (filterValue == null)
					continue;
				if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(filterValue, column.DataValueType)) {
					continue;
				}
				entity.SetColumnValue(column, filterValue);
			}
		}

		public virtual void FillRowWithData(Entity entity) {
			foreach(var columnValue in RecordDefValues.Values) {
				EntitySchemaColumn column = entity.Schema.GetSchemaColumnByMetaPath(columnValue.Key);
				object value = columnValue.Value;
				if (ProcessUserTaskUtilities.GetIsEmptyLookupOrDateTimeValue(value, column.DataValueType)) {
					continue;
				}
				entity.SetColumnValue(column, value);
			}
		}

		#endregion

	}

	#endregion

	#region Class: AddDataUserTaskSchemaExtension

	/// <exclude/>
	public class AddDataUserTaskSchemaExtension : ProcessUserTaskSchemaExtension
	{

		#region Methods: Private

		private static EntitySchemaManager GetEntitySchemaManager(BaseProcessSchema baseProcessSchema) {
			return (EntitySchemaManager)baseProcessSchema.SchemaManagerProvider.GetManager(nameof(EntitySchemaManager));
		}

		private static EntitySchema FindEntitySchema(ProcessSchemaUserTask schemaElement, Guid entitySchemaUId) {
			var baseProcessSchema = (BaseProcessSchema)schemaElement.ParentMetaSchema;
			EntitySchemaManager entitySchemaManager = GetEntitySchemaManager(baseProcessSchema);
			return entitySchemaManager.FindInstanceByUId(entitySchemaUId);
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc cref="ProcessUserTaskSchemaExtension.AnalyzePackageDependencies"/>
		public override void AnalyzePackageDependencies(ProcessSchemaUserTask schemaElement,
				IProcessSchemaPackageDependencyReporter dependencyReporter) {
			base.AnalyzePackageDependencies(schemaElement, dependencyReporter);
			ProcessSchemaParameterCollection parameters = schemaElement.Parameters;
			ProcessSchemaParameter filterEntitySchemaIdParameter = parameters.GetByName("FilterEntitySchemaId");
			Guid.TryParse(filterEntitySchemaIdParameter.SourceValue.Value, out Guid entitySchemaUId);
			string reasonSource = $"{schemaElement.Name}.{filterEntitySchemaIdParameter.Name}";
			dependencyReporter.ReportSchemaDependency(entitySchemaUId, nameof(EntitySchemaManager), reasonSource);
			ProcessSchemaParameter recordDefValuesParameter = parameters.GetByName("RecordDefValues");
			ProcessSchemaParameterValue sourceValue = recordDefValuesParameter.SourceValue;
			if (sourceValue.Value.IsNullOrEmpty()) {
				return;
			}
			EntityColumnMappingCollection mappingCollection = EntityColumnMappingCollection.DeserializeValue(
				sourceValue);
			reasonSource = $"{schemaElement.Name}.{recordDefValuesParameter.Name}";
			var mappingColumns = mappingCollection
				.Where(mapping => mapping.Value.Source == ProcessSchemaParameterValueSource.EntityMapping)
				.Select(mapping => mapping.Value.Value);
			var columnsLocator = SchemaColumnsLocator.CreateFromMetaPaths(mappingColumns);
			dependencyReporter.ReportSchemaColumnsDependency(entitySchemaUId, columnsLocator, reasonSource);
		}

		#endregion

	}

	#endregion

}
