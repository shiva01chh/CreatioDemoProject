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

	#region Class: LeadInFolder_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class LeadInFolder_CrtLead_TerrasoftSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public LeadInFolder_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadInFolder_CrtLead_TerrasoftSchema(LeadInFolder_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadInFolder_CrtLead_TerrasoftSchema(LeadInFolder_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e");
			RealUId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e");
			Name = "LeadInFolder_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1a9580bf-9f81-4cae-a427-babd43f5bdf1")) == null) {
				Columns.Add(CreateLeadColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1a9580bf-9f81-4cae-a427-babd43f5bdf1"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e"),
				ModifiedInSchemaUId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadInFolder_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadInFolder_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadInFolder_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadInFolder_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadInFolder_CrtLead_Terrasoft

	/// <summary>
	/// Lead in folder.
	/// </summary>
	public class LeadInFolder_CrtLead_Terrasoft : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public LeadInFolder_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadInFolder_CrtLead_Terrasoft";
		}

		public LeadInFolder_CrtLead_Terrasoft(LeadInFolder_CrtLead_Terrasoft source)
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
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadInFolder_CrtLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("LeadInFolder_CrtLead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadInFolder_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadInFolder_CrtLeadEventsProcess

	/// <exclude/>
	public partial class LeadInFolder_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtBaseEventsProcess<TEntity> where TEntity : LeadInFolder_CrtLead_Terrasoft
	{

		public LeadInFolder_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadInFolder_CrtLeadEventsProcess";
			SchemaUId = new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9fd3b56f-95f5-4bbd-adae-81a9a175940e");
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

	#region Class: LeadInFolder_CrtLeadEventsProcess

	/// <exclude/>
	public class LeadInFolder_CrtLeadEventsProcess : LeadInFolder_CrtLeadEventsProcess<LeadInFolder_CrtLead_Terrasoft>
	{

		public LeadInFolder_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadInFolder_CrtLeadEventsProcess

	public partial class LeadInFolder_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

