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

	#region Class: Lead_CrtLeadOppMgmtApp_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtLeadOppMgmtApp_TerrasoftSchema : Terrasoft.Configuration.Lead_WebLeadForm_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CrtLeadOppMgmtApp_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtLeadOppMgmtApp_TerrasoftSchema(Lead_CrtLeadOppMgmtApp_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtLeadOppMgmtApp_TerrasoftSchema(Lead_CrtLeadOppMgmtApp_TerrasoftSchema source)
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
			RealUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e");
			Name = "Lead_CrtLeadOppMgmtApp_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6e828642-ee6e-4ea6-9469-ffeca865fc72");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("33cf5522-8fdc-4d80-ae7a-07c96cefebca")) == null) {
				Columns.Add(CreateSalesChannelColumn());
			}
			if (Columns.FindByUId(new Guid("7cfff438-9ee8-4272-816d-5deb7d0c9d36")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("76f6dc65-474e-d9fa-990f-74f5a7666598")) == null) {
				Columns.Add(CreateProductSuggestionsColumn());
			}
			if (Columns.FindByUId(new Guid("99db8dd8-bdda-bf88-e07c-997323825bbc")) == null) {
				Columns.Add(CreateBusinessCaseColumn());
			}
			if (Columns.FindByUId(new Guid("81a25675-e691-e8d9-6475-ecf536a60919")) == null) {
				Columns.Add(CreateClosingDetailsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSalesChannelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("33cf5522-8fdc-4d80-ae7a-07c96cefebca"),
				Name = @"SalesChannel",
				ReferenceSchemaUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				ModifiedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				CreatedInPackageId = new Guid("0fde497a-a2c4-49cc-b252-fa33342eb65c"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"3c3865f2-ada4-480c-ac91-e2d39c5bbaf9"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7cfff438-9ee8-4272-816d-5deb7d0c9d36"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				ModifiedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3")
			};
		}

		protected virtual EntitySchemaColumn CreateProductSuggestionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("76f6dc65-474e-d9fa-990f-74f5a7666598"),
				Name = @"ProductSuggestions",
				CreatedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				ModifiedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				CreatedInPackageId = new Guid("b57f0923-97ad-4ee8-8a57-36c03d15acf5"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateBusinessCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("99db8dd8-bdda-bf88-e07c-997323825bbc"),
				Name = @"BusinessCase",
				CreatedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				ModifiedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				CreatedInPackageId = new Guid("b57f0923-97ad-4ee8-8a57-36c03d15acf5"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateClosingDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("81a25675-e691-e8d9-6475-ecf536a60919"),
				Name = @"ClosingDetails",
				CreatedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				ModifiedInSchemaUId = new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"),
				CreatedInPackageId = new Guid("3c209e29-b321-47ed-99ea-a5265dc0773f"),
				IsFormatValidated = true
			};
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
			return new Lead_CrtLeadOppMgmtApp_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtLeadOppMgmtAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtLeadOppMgmtApp_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtLeadOppMgmtApp_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadOppMgmtApp_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtLeadOppMgmtApp_Terrasoft : Terrasoft.Configuration.Lead_WebLeadForm_Terrasoft
	{

		#region Constructors: Public

		public Lead_CrtLeadOppMgmtApp_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtLeadOppMgmtApp_Terrasoft";
		}

		public Lead_CrtLeadOppMgmtApp_Terrasoft(Lead_CrtLeadOppMgmtApp_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SalesChannelId {
			get {
				return GetTypedColumnValue<Guid>("SalesChannelId");
			}
			set {
				SetColumnValue("SalesChannelId", value);
				_salesChannel = null;
			}
		}

		/// <exclude/>
		public string SalesChannelName {
			get {
				return GetTypedColumnValue<string>("SalesChannelName");
			}
			set {
				SetColumnValue("SalesChannelName", value);
				if (_salesChannel != null) {
					_salesChannel.Name = value;
				}
			}
		}

		private OpportunityType _salesChannel;
		/// <summary>
		/// Sales channel.
		/// </summary>
		public OpportunityType SalesChannel {
			get {
				return _salesChannel ??
					(_salesChannel = LookupColumnEntities.GetEntity("SalesChannel") as OpportunityType);
			}
		}

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		/// <summary>
		/// Product suggestions.
		/// </summary>
		public string ProductSuggestions {
			get {
				return GetTypedColumnValue<string>("ProductSuggestions");
			}
			set {
				SetColumnValue("ProductSuggestions", value);
			}
		}

		/// <summary>
		/// Business case.
		/// </summary>
		public string BusinessCase {
			get {
				return GetTypedColumnValue<string>("BusinessCase");
			}
			set {
				SetColumnValue("BusinessCase", value);
			}
		}

		/// <summary>
		/// Closing details.
		/// </summary>
		public string ClosingDetails {
			get {
				return GetTypedColumnValue<string>("ClosingDetails");
			}
			set {
				SetColumnValue("ClosingDetails", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtLeadOppMgmtAppEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CrtLeadOppMgmtApp_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public partial class Lead_CrtLeadOppMgmtAppEventsProcess<TEntity> : Terrasoft.Configuration.Lead_WebLeadFormEventsProcess<TEntity> where TEntity : Lead_CrtLeadOppMgmtApp_Terrasoft
	{

		public Lead_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtLeadOppMgmtAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("408b733a-332d-4fc7-a91d-6b37ecb1472e");
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

	#region Class: Lead_CrtLeadOppMgmtAppEventsProcess

	/// <exclude/>
	public class Lead_CrtLeadOppMgmtAppEventsProcess : Lead_CrtLeadOppMgmtAppEventsProcess<Lead_CrtLeadOppMgmtApp_Terrasoft>
	{

		public Lead_CrtLeadOppMgmtAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CrtLeadOppMgmtAppEventsProcess

	public partial class Lead_CrtLeadOppMgmtAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

