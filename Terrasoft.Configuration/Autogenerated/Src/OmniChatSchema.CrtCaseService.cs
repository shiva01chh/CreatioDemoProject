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

	#region Class: OmniChat_CrtCaseService_TerrasoftSchema

	/// <exclude/>
	public class OmniChat_CrtCaseService_TerrasoftSchema : Terrasoft.Configuration.OmniChat_OmnichannelMessaging_TerrasoftSchema
	{

		#region Constructors: Public

		public OmniChat_CrtCaseService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OmniChat_CrtCaseService_TerrasoftSchema(OmniChat_CrtCaseService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OmniChat_CrtCaseService_TerrasoftSchema(OmniChat_CrtCaseService_TerrasoftSchema source)
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
			RealUId = new Guid("a84f47b6-cd3c-c88d-a912-836fcc39653a");
			Name = "OmniChat_CrtCaseService_Terrasoft";
			ParentSchemaUId = new Guid("af1f685c-315b-4b44-a957-c5094417a57a");
			ExtendParent = true;
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f0df491d-5d4d-a931-d796-8d95880c95c6")) == null) {
				Columns.Add(CreateCaseColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f0df491d-5d4d-a931-d796-8d95880c95c6"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a84f47b6-cd3c-c88d-a912-836fcc39653a"),
				ModifiedInSchemaUId = new Guid("a84f47b6-cd3c-c88d-a912-836fcc39653a"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
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
			return new OmniChat_CrtCaseService_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OmniChat_CrtCaseServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OmniChat_CrtCaseService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OmniChat_CrtCaseService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a84f47b6-cd3c-c88d-a912-836fcc39653a"));
		}

		#endregion

	}

	#endregion

	#region Class: OmniChat_CrtCaseService_Terrasoft

	/// <summary>
	/// Chat.
	/// </summary>
	public class OmniChat_CrtCaseService_Terrasoft : Terrasoft.Configuration.OmniChat_OmnichannelMessaging_Terrasoft
	{

		#region Constructors: Public

		public OmniChat_CrtCaseService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OmniChat_CrtCaseService_Terrasoft";
		}

		public OmniChat_CrtCaseService_Terrasoft(OmniChat_CrtCaseService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		/// <remarks>
		/// Case connected to chat.
		/// </remarks>
		public Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OmniChat_CrtCaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("OmniChat_CrtCaseService_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OmniChat_CrtCaseService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OmniChat_CrtCaseServiceEventsProcess

	/// <exclude/>
	public partial class OmniChat_CrtCaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.OmniChat_OmnichannelMessagingEventsProcess<TEntity> where TEntity : OmniChat_CrtCaseService_Terrasoft
	{

		public OmniChat_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OmniChat_CrtCaseServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a84f47b6-cd3c-c88d-a912-836fcc39653a");
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

	#region Class: OmniChat_CrtCaseServiceEventsProcess

	/// <exclude/>
	public class OmniChat_CrtCaseServiceEventsProcess : OmniChat_CrtCaseServiceEventsProcess<OmniChat_CrtCaseService_Terrasoft>
	{

		public OmniChat_CrtCaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OmniChat_CrtCaseServiceEventsProcess

	public partial class OmniChat_CrtCaseServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

