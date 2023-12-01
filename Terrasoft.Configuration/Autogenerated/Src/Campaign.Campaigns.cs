namespace Terrasoft.Configuration
{
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;

	#region Class: Campaign_CampaignsEventsProcess

	public partial class Campaign_CampaignsEventsProcess<TEntity>
	{

		#region Properties: Public

		public virtual string NodesSchemaName { get; set; }

		public virtual string ConnectorsSchemaName { get; set; }

		public virtual string DiagramStorageColumnName { get; set; }

		#endregion

		#region Methods: Public

		public virtual bool DiagramSavedMethod(ProcessExecutingContext  context) {
			if (GetCampaignType() == CampaignConsts.OldCampaignTypeId) {
				SaveDiagram();
			}
			return true;
		}

		public virtual bool DiagramLoadedMethod(ProcessExecutingContext context) {
			if (GetCampaignType() == CampaignConsts.OldCampaignTypeId) {
				LoadDiagram();
			}
			return true;
		}

		public virtual void LoadDiagram() {}

		public virtual EntityCollection LoadNodes(Guid recordId, DiagramElementMap map) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(map.SchemaName);
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			IEntitySchemaQueryFilterItem filter = 
				esq.CreateFilterWithParameters(FilterComparisonType.Equal, map.ReferenceColumnValueName, recordId);
			esq.Filters.Add(filter);
			return esq.GetEntityCollection(UserConnection);
		}

		public virtual EntityCollection LoadConnectors(Guid recordId, DiagramElementMap nodesMap, DiagramElementMap connectorsMap) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(connectorsMap.SchemaName);
			var esq = new EntitySchemaQuery(schema);
			esq.AddAllSchemaColumns();
			var filters = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"[" + nodesMap.SchemaName + ":Id:SourceStep]." + nodesMap.ReferenceColumnValueName, recordId));
			filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"[" + nodesMap.SchemaName + ":Id:TargetStep]." + nodesMap.ReferenceColumnValueName, recordId));
			esq.Filters.Add(filters);
			return esq.GetEntityCollection(UserConnection);
		}

		public virtual JArray BuildConfig(EntityCollection entityCollection, DiagramElementMap map) {
			JArray jArray = new JArray();
			return jArray;
		}

		public virtual void SaveDiagram() {}

		public virtual void SaveConnectors(Guid parentId, JToken connectors) {}

		public virtual void SaveNodes(Guid parentId, JToken nodes) {}

		public virtual List<Guid> SaveItems(Guid parentId, JToken nodes, DiagramElementMap map) {
			List<Guid> records = new List<Guid>();
			return records;
		}

		public virtual DiagramElementMap GetConnectorsMap() {
			return new DiagramElementMap(ConnectorsSchemaName, new DiagramElementMapPointer[] {
				new DiagramElementMapPointer("labels..text", "Title", typeof(String)),
				new DiagramElementMapPointer("sourceNode", "SourceStepId", typeof(Guid)),
				new DiagramElementMapPointer("targetNode", "TargetStepId", typeof(Guid))
			});
		}

		public virtual DiagramElementMap GetNodesMap() {
			return new DiagramElementMap(NodesSchemaName, new DiagramElementMapPointer[] {
				new DiagramElementMapPointer("labels..text", "Title", typeof(String)),
				new DiagramElementMapPointer("stepType", "TypeId", typeof(Guid)),
				new DiagramElementMapPointer("addInfo.RecordId", "RecordId", typeof(Guid))
			}, "Campaign");
		}

		public virtual JToken FindTargetNode(JToken nodes, JToken connectors, JToken connector) {
			return null;
		}

		public virtual JToken FindItemByProperty(JToken items, string propertyName, string propertyValue, DiagramElementMap map) {
			return null;
		}

		public virtual List<string> GetCheckedConnectors(Dictionary<string, Guid> connectorsToCheck) {
			List<string> result = new List<string>();
			return result;
		}

		public virtual void UpdateBulkEmail(Guid bulkEmailId, string launchOption, string startDate) {}

		public virtual void UpdateReferences(string schemaNames, Guid campaignId, List<Guid> records) {}

		#endregion

	}

	#endregion

}

