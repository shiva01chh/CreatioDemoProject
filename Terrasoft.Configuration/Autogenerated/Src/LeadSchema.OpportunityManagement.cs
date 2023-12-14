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

	#region Class: Lead_OpportunityManagement_TerrasoftSchema

	/// <exclude/>
	public class Lead_OpportunityManagement_TerrasoftSchema : Terrasoft.Configuration.Lead_MarketingCampaign_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_OpportunityManagement_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_OpportunityManagement_TerrasoftSchema(Lead_OpportunityManagement_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_OpportunityManagement_TerrasoftSchema(Lead_OpportunityManagement_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8f3d9893-fb05-4273-be29-d09312d380e6");
			Name = "Lead_OpportunityManagement_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.UsageType = EntitySchemaColumnUsageType.General;
			column.ModifiedInSchemaUId = new Guid("8f3d9893-fb05-4273-be29-d09312d380e6");
			column.CreatedInPackageId = new Guid("1800af83-2123-40e8-b79f-0e68449a9687");
			return column;
		}

		protected override EntitySchemaColumn CreateSaleTypeColumn() {
			EntitySchemaColumn column = base.CreateSaleTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"Opportunity"
			};
			column.ModifiedInSchemaUId = new Guid("8f3d9893-fb05-4273-be29-d09312d380e6");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_OpportunityManagement_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_OpportunityManagementEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_OpportunityManagement_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_OpportunityManagement_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f3d9893-fb05-4273-be29-d09312d380e6"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_OpportunityManagement_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_OpportunityManagement_Terrasoft : Terrasoft.Configuration.Lead_MarketingCampaign_Terrasoft
	{

		#region Constructors: Public

		public Lead_OpportunityManagement_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_OpportunityManagement_Terrasoft";
		}

		public Lead_OpportunityManagement_Terrasoft(Lead_OpportunityManagement_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_OpportunityManagementEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_OpportunityManagement_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_OpportunityManagement_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Lead_OpportunityManagement_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Lead_OpportunityManagement_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Lead_OpportunityManagement_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_OpportunityManagement_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_OpportunityManagementEventsProcess

	/// <exclude/>
	public partial class Lead_OpportunityManagementEventsProcess<TEntity> : Terrasoft.Configuration.Lead_MarketingCampaignEventsProcess<TEntity> where TEntity : Lead_OpportunityManagement_Terrasoft
	{

		public Lead_OpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_OpportunityManagementEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f3d9893-fb05-4273-be29-d09312d380e6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_OpportunityManagementEventsProcess

	/// <exclude/>
	public class Lead_OpportunityManagementEventsProcess : Lead_OpportunityManagementEventsProcess<Lead_OpportunityManagement_Terrasoft>
	{

		public Lead_OpportunityManagementEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_OpportunityManagementEventsProcess

	public partial class Lead_OpportunityManagementEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

