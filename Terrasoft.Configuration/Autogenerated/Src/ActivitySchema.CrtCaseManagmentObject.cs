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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CrtCaseManagmentObject_TerrasoftSchema

	/// <exclude/>
	public class Activity_CrtCaseManagmentObject_TerrasoftSchema : Terrasoft.Configuration.Activity_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CrtCaseManagmentObject_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CrtCaseManagmentObject_TerrasoftSchema(Activity_CrtCaseManagmentObject_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CrtCaseManagmentObject_TerrasoftSchema(Activity_CrtCaseManagmentObject_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			Name = "Activity_CrtCaseManagmentObject_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateStartDateColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeOwnerAdminUnitColumn() {
			base.InitializeOwnerAdminUnitColumn();
			OwnerAdminUnitColumn = CreateOwnerRoleColumn();
			if (Columns.FindByUId(OwnerAdminUnitColumn.UId) == null) {
				Columns.Add(OwnerAdminUnitColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("47c4dc47-8529-4d0e-a6fa-f298bb20cd13")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("1b3d86ae-616d-49c5-b738-63b2a25c9607")) == null) {
				Columns.Add(CreateServiceProcessedColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("47c4dc47-8529-4d0e-a6fa-f298bb20cd13"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1"),
				ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceProcessedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1b3d86ae-616d-49c5-b738-63b2a25c9607"),
				Name = @"ServiceProcessed",
				CreatedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1"),
				ModifiedInSchemaUId = new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CrtCaseManagmentObject_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CrtCaseManagmentObjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CrtCaseManagmentObject_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CrtCaseManagmentObject_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtCaseManagmentObject_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CrtCaseManagmentObject_Terrasoft : Terrasoft.Configuration.Activity_Lead_Terrasoft
	{

		#region Constructors: Public

		public Activity_CrtCaseManagmentObject_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CrtCaseManagmentObject_Terrasoft";
		}

		public Activity_CrtCaseManagmentObject_Terrasoft(Activity_CrtCaseManagmentObject_Terrasoft source)
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
		public Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <summary>
		/// Service processed.
		/// </summary>
		public bool ServiceProcessed {
			get {
				return GetTypedColumnValue<bool>("ServiceProcessed");
			}
			set {
				SetColumnValue("ServiceProcessed", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CrtCaseManagmentObjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftUpdated", e);
			Validating += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftValidating", e);
			DefColumnValuesSet += (s, e) => ThrowEvent("Activity_CrtCaseManagmentObject_TerrasoftDefColumnValuesSet", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CrtCaseManagmentObject_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public partial class Activity_CrtCaseManagmentObjectEventsProcess<TEntity> : Terrasoft.Configuration.Activity_LeadEventsProcess<TEntity> where TEntity : Activity_CrtCaseManagmentObject_Terrasoft
	{

		public Activity_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CrtCaseManagmentObjectEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("050a4134-36bf-4710-bfe7-4c3477a8e9e1");
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

	#region Class: Activity_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public class Activity_CrtCaseManagmentObjectEventsProcess : Activity_CrtCaseManagmentObjectEventsProcess<Activity_CrtCaseManagmentObject_Terrasoft>
	{

		public Activity_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

