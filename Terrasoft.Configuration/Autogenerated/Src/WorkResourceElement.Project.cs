namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: WorkResourceElement_ProjectEventsProcess

	public partial class WorkResourceElement_ProjectEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void LaborPlanWorkResourceElementUpdate(Guid projectId, Guid projectResourceElementId, decimal planningWork) {
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var workResourceElementSchema = entitySchemaManager.GetInstanceByName("WorkResourceElement");
			var esq = new EntitySchemaQuery(entitySchemaManager, "WorkResourceElement");
			var esqIdColumn = esq.AddColumn("Id");
			var esqPlanningWorkColumn = esq.AddColumn("PlanningWork");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Project", projectId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ProjectResourceElement", projectResourceElementId));
			var entities = esq.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				foreach(var entity in entities) {
					var elementId = entity.GetTypedColumnValue<Guid>(esqIdColumn.Name);
					var work = entity.GetTypedColumnValue<decimal>(esqPlanningWorkColumn.Name);
					if (work < planningWork || (IsWorkResourceDeleted && projectResourceElementId == ProjectResourceElementId)) {
						var entityToSave = workResourceElementSchema.CreateEntity(UserConnection);
						if (entityToSave.FetchFromDB(workResourceElementSchema.GetPrimaryColumnName(), elementId)) {
							entityToSave.SetColumnValue("PlanningWork", planningWork);
							entityToSave.Save();
						}
					}
				}
			} else {
			//	var esqProjectRes = new EntitySchemaQuery(entitySchemaManager, "ProjectResourceElement");
			//	var esqExternalRateColumn = esqProjectRes.AddColumn("ExternalRate");
			//	var esqInternalRateColumn = esqProjectRes.AddColumn("InternalRate");
			//	var projectResourceEntity = esqProjectRes.GetEntity(UserConnection, projectResourceElementId);
			//	if (projectResourceEntity != null) {
			//		var externalRate = projectResourceEntity.GetTypedColumnValue<decimal>(esqExternalRateColumn.Name);
			//		var internalRate = projectResourceEntity.GetTypedColumnValue<decimal>(esqInternalRateColumn.Name);
					var newEntity = workResourceElementSchema.CreateEntity(UserConnection);
					newEntity.SetDefColumnValues();
					newEntity.SetColumnValue("ProjectId", projectId);
					newEntity.SetColumnValue("ProjectResourceElementId", projectResourceElementId);
			//		newEntity.SetColumnValue("ExternalRate", externalRate);
			//		newEntity.SetColumnValue("InternalRate", internalRate);
					newEntity.SetColumnValue("PlanningWork", planningWork);
					newEntity.Save(); 
			//	}
			}
		}

		public virtual bool OnWorkResourceElementSaved(Guid elementId, Guid prjctId) {
			if (elementId != null && elementId != Guid.Empty) {
				var esqProject = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Project");
				var parentProjectIdColumn = esqProject.AddColumn("ParentProject.Id");
				var projectEntryTypeIdColumn = esqProject.AddColumn("ParentProject.ProjectEntryType.Id");
				var parentProjectId = Guid.Empty;
				var projectEntryTypeId = Guid.Empty;
				
				var project = esqProject.GetEntity(UserConnection, prjctId);
				if (project == null) {
					return true;
				}
				parentProjectId = project.GetTypedColumnValue<Guid>(parentProjectIdColumn.Name);
				projectEntryTypeId = project.GetTypedColumnValue<Guid>(projectEntryTypeIdColumn.Name);
				var planCollection = new Dictionary<Guid, decimal>();
				var esqManhour = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "WorkResourceElement");
				var planColumn = esqManhour.AddColumn("PlanningWork");
				var projectResourceColumn = esqManhour.AddColumn("ProjectResourceElement.Id");
				var projectManhourFilter = esqManhour.CreateFilterWithParameters(FilterComparisonType.Equal,
					"Project.ParentProject", parentProjectId);
				esqManhour.Filters.Add(projectManhourFilter);
				var manhourEntities = esqManhour.GetEntityCollection(UserConnection);
				if (manhourEntities.Count > 0) {
					foreach(var manhourEntity in manhourEntities) {
						var plan = manhourEntity.GetTypedColumnValue<decimal>(planColumn.Name);
						var projectResourceId = manhourEntity.GetTypedColumnValue<Guid>(projectResourceColumn.Name);
						if (planCollection.ContainsKey(projectResourceId)) {
							planCollection[projectResourceId] += plan;
						} else {
							planCollection.Add(projectResourceId, plan);
						}
					}
				}
				if (projectEntryTypeId == new Guid("6B4928D7-456A-4ACD-A863-3361D46B7649")) {
					var projectService = ClassFactory.Get<ProjectService.ProjectService>(
						new ConstructorArgument("userConnection", UserConnection));
					projectService.UpdateProjectResource(parentProjectId);
				} else {
					foreach(var plan in planCollection) {
						LaborPlanWorkResourceElementUpdate(parentProjectId, plan.Key, plan.Value); 
					}
				}
			}
			return true;
		}

		#endregion

	}

	#endregion

}

