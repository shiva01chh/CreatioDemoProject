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

	#region Class: CaseLifecycleSchema

	/// <exclude/>
	public class CaseLifecycleSchema : Terrasoft.Configuration.CaseLifecycle_CrtSLM_TerrasoftSchema
	{

		#region Constructors: Public

		public CaseLifecycleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseLifecycleSchema(CaseLifecycleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseLifecycleSchema(CaseLifecycleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_CaseLifecycle_CreatedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("66b2ba77-5d12-4752-ba4b-33e03efc2e22");
			index.Name = "IX_CaseLifecycle_CreatedOn";
			index.CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			index.ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			index.CreatedInPackageId = new Guid("257e6d26-f107-468c-8558-d77af0cbc8ac");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("df737bbc-8103-75e8-cdb5-892c25a4dc36"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				ModifiedInSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf"),
				CreatedInPackageId = new Guid("257e6d26-f107-468c-8558-d77af0cbc8ac"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("eb075ee7-4ffc-4c9d-822a-65bab75ae764");
			Name = "CaseLifecycle";
			ParentSchemaUId = new Guid("9e784f54-ca3c-4052-81da-c3eb95cabfaf");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1769840a-0346-4e19-9860-08f03aee638f")) == null) {
				Columns.Add(CreateSupportLevelColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1769840a-0346-4e19-9860-08f03aee638f"),
				Name = @"SupportLevel",
				ReferenceSchemaUId = new Guid("4c2e1b60-ee12-4846-a38e-04204de6fb14"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("eb075ee7-4ffc-4c9d-822a-65bab75ae764"),
				ModifiedInSchemaUId = new Guid("eb075ee7-4ffc-4c9d-822a-65bab75ae764"),
				CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_CaseLifecycle_CreatedOnIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseLifecycle(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseLifecycle_CrtSLMITILServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseLifecycleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseLifecycleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb075ee7-4ffc-4c9d-822a-65bab75ae764"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseLifecycle

	/// <summary>
	/// Case Lifecycle.
	/// </summary>
	public class CaseLifecycle : Terrasoft.Configuration.CaseLifecycle_CrtSLM_Terrasoft
	{

		#region Constructors: Public

		public CaseLifecycle(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseLifecycle";
		}

		public CaseLifecycle(CaseLifecycle source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SupportLevelId");
			}
			set {
				SetColumnValue("SupportLevelId", value);
				_supportLevel = null;
			}
		}

		/// <exclude/>
		public string SupportLevelName {
			get {
				return GetTypedColumnValue<string>("SupportLevelName");
			}
			set {
				SetColumnValue("SupportLevelName", value);
				if (_supportLevel != null) {
					_supportLevel.Name = value;
				}
			}
		}

		private RoleInServiceTeam _supportLevel;
		/// <summary>
		/// Support line.
		/// </summary>
		public RoleInServiceTeam SupportLevel {
			get {
				return _supportLevel ??
					(_supportLevel = LookupColumnEntities.GetEntity("SupportLevel") as RoleInServiceTeam);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseLifecycle_CrtSLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseLifecycleDeleted", e);
			Deleting += (s, e) => ThrowEvent("CaseLifecycleDeleting", e);
			Inserted += (s, e) => ThrowEvent("CaseLifecycleInserted", e);
			Inserting += (s, e) => ThrowEvent("CaseLifecycleInserting", e);
			Saved += (s, e) => ThrowEvent("CaseLifecycleSaved", e);
			Saving += (s, e) => ThrowEvent("CaseLifecycleSaving", e);
			Validating += (s, e) => ThrowEvent("CaseLifecycleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseLifecycle(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseLifecycle_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public partial class CaseLifecycle_CrtSLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.CaseLifecycle_CrtSLMEventsProcess<TEntity> where TEntity : CaseLifecycle
	{

		public CaseLifecycle_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseLifecycle_CrtSLMITILServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eb075ee7-4ffc-4c9d-822a-65bab75ae764");
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

	#region Class: CaseLifecycle_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public class CaseLifecycle_CrtSLMITILServiceEventsProcess : CaseLifecycle_CrtSLMITILServiceEventsProcess<CaseLifecycle>
	{

		public CaseLifecycle_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseLifecycle_CrtSLMITILServiceEventsProcess

	public partial class CaseLifecycle_CrtSLMITILServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseLifecycleEventsProcess

	/// <exclude/>
	public class CaseLifecycleEventsProcess : CaseLifecycle_CrtSLMITILServiceEventsProcess
	{

		public CaseLifecycleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

