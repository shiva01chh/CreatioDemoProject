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

	#region Class: OmniChatSchema

	/// <exclude/>
	public class OmniChatSchema : Terrasoft.Configuration.OmniChat_CrtCaseService_TerrasoftSchema
	{

		#region Constructors: Public

		public OmniChatSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OmniChatSchema(OmniChatSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OmniChatSchema(OmniChatSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_OmniChat_ModifiedOn_DESCIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("7743e95f-27d2-45c1-a986-01ef6e06157d");
			index.Name = "IX_OmniChat_ModifiedOn_DESC";
			index.CreatedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			index.ModifiedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			index.CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8b94bc86-9c8f-3b4b-a07d-069c04711bdf"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a"),
				ModifiedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a"),
				CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_OmniChat_CreatedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("0a96b90f-b92d-4b84-abef-7abc160b40f5");
			index.Name = "IX_OmniChat_CreatedOn";
			index.CreatedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			index.ModifiedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			index.CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("1a21e225-d777-369e-ab4d-6cba32070fb8"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a"),
				ModifiedInSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a"),
				CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a2e60687-655a-4a73-b0d6-8e88f01f170f");
			Name = "OmniChat";
			ParentSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("21174400-e09d-7cfb-7f05-9e660c07844c")) == null) {
				Columns.Add(CreateLeadColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("21174400-e09d-7cfb-7f05-9e660c07844c"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a2e60687-655a-4a73-b0d6-8e88f01f170f"),
				ModifiedInSchemaUId = new Guid("a2e60687-655a-4a73-b0d6-8e88f01f170f"),
				CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_OmniChat_ModifiedOn_DESCIndex());
			Indexes.Add(CreateIX_OmniChat_CreatedOnIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OmniChat(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OmniChat_CrtSocialLeadGenEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OmniChatSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OmniChatSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2e60687-655a-4a73-b0d6-8e88f01f170f"));
		}

		#endregion

	}

	#endregion

	#region Class: OmniChat

	/// <summary>
	/// Chat.
	/// </summary>
	public class OmniChat : Terrasoft.Configuration.OmniChat_CrtCaseService_Terrasoft
	{

		#region Constructors: Public

		public OmniChat(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OmniChat";
		}

		public OmniChat(OmniChat source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		/// <remarks>
		/// Lead connected to the chat.
		/// </remarks>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OmniChat_CrtSocialLeadGenEventsProcess(UserConnection);
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
			return new OmniChat(this);
		}

		#endregion

	}

	#endregion

	#region Class: OmniChat_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public partial class OmniChat_CrtSocialLeadGenEventsProcess<TEntity> : Terrasoft.Configuration.OmniChat_CrtCaseServiceEventsProcess<TEntity> where TEntity : OmniChat
	{

		public OmniChat_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OmniChat_CrtSocialLeadGenEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a2e60687-655a-4a73-b0d6-8e88f01f170f");
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

	#region Class: OmniChat_CrtSocialLeadGenEventsProcess

	/// <exclude/>
	public class OmniChat_CrtSocialLeadGenEventsProcess : OmniChat_CrtSocialLeadGenEventsProcess<OmniChat>
	{

		public OmniChat_CrtSocialLeadGenEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OmniChat_CrtSocialLeadGenEventsProcess

	public partial class OmniChat_CrtSocialLeadGenEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OmniChatEventsProcess

	/// <exclude/>
	public class OmniChatEventsProcess : OmniChat_CrtSocialLeadGenEventsProcess
	{

		public OmniChatEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

