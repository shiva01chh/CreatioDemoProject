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

	#region Class: BulkEmailLaunchOptionSchema

	/// <exclude/>
	public class BulkEmailLaunchOptionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BulkEmailLaunchOptionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailLaunchOptionSchema(BulkEmailLaunchOptionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailLaunchOptionSchema(BulkEmailLaunchOptionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7");
			RealUId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7");
			Name = "BulkEmailLaunchOption";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("00791caf-e9bc-4b15-94ee-4564257ba4c1")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("00791caf-e9bc-4b15-94ee-4564257ba4c1"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7"),
				ModifiedInSchemaUId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailLaunchOption(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailLaunchOption_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailLaunchOptionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailLaunchOptionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailLaunchOption

	/// <summary>
	/// Bulk email run mode.
	/// </summary>
	public class BulkEmailLaunchOption : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BulkEmailLaunchOption(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailLaunchOption";
		}

		public BulkEmailLaunchOption(BulkEmailLaunchOption source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private BulkEmailCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public BulkEmailCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as BulkEmailCategory);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailLaunchOption_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailLaunchOptionDeleted", e);
			Validating += (s, e) => ThrowEvent("BulkEmailLaunchOptionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailLaunchOption(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailLaunchOption_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailLaunchOption_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailLaunchOption
	{

		public BulkEmailLaunchOption_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailLaunchOption_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7");
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

	#region Class: BulkEmailLaunchOption_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailLaunchOption_CrtBulkEmailEventsProcess : BulkEmailLaunchOption_CrtBulkEmailEventsProcess<BulkEmailLaunchOption>
	{

		public BulkEmailLaunchOption_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailLaunchOption_CrtBulkEmailEventsProcess

	public partial class BulkEmailLaunchOption_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailLaunchOptionEventsProcess

	/// <exclude/>
	public class BulkEmailLaunchOptionEventsProcess : BulkEmailLaunchOption_CrtBulkEmailEventsProcess
	{

		public BulkEmailLaunchOptionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

