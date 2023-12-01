namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.WebService;

	#region Class: Campaign_CrtCampaignEventsProcess

	public partial class Campaign_CrtCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void OnCampaignInserting() {
			var campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId == Guid.Empty) {
				Entity.SetColumnValue("CampaignSchemaUId", null);
			}
		}

		public virtual bool IsColumnValueChanged(string columnName) {
			return Entity.GetIsColumnValueLoaded(columnName) && 
				Entity.GetChangedColumnValues().Any(_ => _.Name == columnName);
		}

		public virtual Guid GetCampaignSchemaUId() {
			Guid campaignSchemaUId = Guid.Empty;
			if (Entity.GetIsColumnValueLoaded("CampaignSchemaUId")) {
				campaignSchemaUId = Entity.GetTypedColumnValue<Guid>("CampaignSchemaUId");
			}
			return campaignSchemaUId;
		}

		public virtual Guid GetCampaignType() {
			Guid typeId = Guid.Empty;
			if (Entity.Schema.Columns.Any(_ => _.Name == "Type") && Entity.GetIsColumnValueLoaded("TypeId")) {
				typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			}
			return typeId;
		}

		public virtual void DeleteCampaignSchema() {
			Guid campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId.IsEmpty()) {
				return;
			}
			var campaignSchemaManager = (CampaignSchemaManager)UserConnection.GetSchemaManager("CampaignSchemaManager");
			var item = campaignSchemaManager.FindItemByUId(campaignSchemaUId);
			if (item == null) {
				return;
			}
			campaignSchemaManager.RemoveItemByUId(campaignSchemaUId, UserConnection);
		}

		public virtual void UnlinkCampaignSchemaElements() {
			Guid campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId.IsEmpty()) {
				return;
			}
			var campaignSchemaManager = (CampaignSchemaManager)UserConnection.GetSchemaManager("CampaignSchemaManager");
			try {
				Terrasoft.Core.Campaign.CampaignSchema schema = campaignSchemaManager.GetSchemaInstance(campaignSchemaUId);
				if (schema == null) {
					return;
				}
				CampaignEventFacade.Delete(UserConnection, schema);
			} catch (Exception e) {
				return;
			}
		}

		public virtual void OnCampaignInserted() {
			var campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId == Guid.Empty) {
				Entity.SetColumnValue("CampaignSchemaUId", null);
				return;
			}
			try {
				CampaignEventFacade.Copy(UserConnection, Entity.Id, campaignSchemaUId);
			} catch (Exception e) {
				RemoveCampaignFromDb(Entity.Id);
				throw;
			}
		}

		public virtual void RemoveCampaignFromDb(Guid entityId) {
			new Delete(UserConnection)
				.From("Campaign")
				.Where("Id").IsEqual(Column.Parameter(entityId))
				.Execute();
		}

		#endregion

	}

	#endregion

}

