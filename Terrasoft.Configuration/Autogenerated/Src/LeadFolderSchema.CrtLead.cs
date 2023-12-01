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

	#region Class: LeadFolder_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class LeadFolder_CrtLead_TerrasoftSchema : Terrasoft.Configuration.BaseFolderSchema
	{

		#region Constructors: Public

		public LeadFolder_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadFolder_CrtLead_TerrasoftSchema(LeadFolder_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadFolder_CrtLead_TerrasoftSchema(LeadFolder_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			RealUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			Name = "LeadFolder_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("d602bf96-d029-4b07-9755-63c8f5cb5ed5");
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
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ReferenceSchemaUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			column.ColumnValueName = @"ParentId";
			column.DisplayColumnValueName = @"ParentName";
			column.ModifiedInSchemaUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadFolder_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadFolder_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadFolder_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadFolder_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48847f5c-6429-400f-abb8-0a753473b5d8"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadFolder_CrtLead_Terrasoft

	/// <summary>
	/// Lead folder.
	/// </summary>
	public class LeadFolder_CrtLead_Terrasoft : Terrasoft.Configuration.BaseFolder
	{

		#region Constructors: Public

		public LeadFolder_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadFolder_CrtLead_Terrasoft";
		}

		public LeadFolder_CrtLead_Terrasoft(LeadFolder_CrtLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private LeadFolder _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public LeadFolder Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as LeadFolder);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadFolder_CrtLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("LeadFolder_CrtLead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadFolder_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadFolder_CrtLeadEventsProcess

	/// <exclude/>
	public partial class LeadFolder_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseFolder_CrtBaseEventsProcess<TEntity> where TEntity : LeadFolder_CrtLead_Terrasoft
	{

		public LeadFolder_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadFolder_CrtLeadEventsProcess";
			SchemaUId = new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("48847f5c-6429-400f-abb8-0a753473b5d8");
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

	#region Class: LeadFolder_CrtLeadEventsProcess

	/// <exclude/>
	public class LeadFolder_CrtLeadEventsProcess : LeadFolder_CrtLeadEventsProcess<LeadFolder_CrtLead_Terrasoft>
	{

		public LeadFolder_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadFolder_CrtLeadEventsProcess

	public partial class LeadFolder_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
			return;
		}

		#endregion

	}

	#endregion

}

