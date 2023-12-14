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

	#region Class: Activity_CrtContract_TerrasoftSchema

	/// <exclude/>
	public class Activity_CrtContract_TerrasoftSchema : Terrasoft.Configuration.Activity_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CrtContract_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CrtContract_TerrasoftSchema(Activity_CrtContract_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CrtContract_TerrasoftSchema(Activity_CrtContract_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4");
			Name = "Activity_CrtContract_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("35a1e95b-1cfe-4e66-8afa-90d42fa38092");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8b9e6930-54d2-4533-ab94-865a0c5d7db7")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8b9e6930-54d2-4533-ab94-865a0c5d7db7"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"),
				ModifiedInSchemaUId = new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"),
				CreatedInPackageId = new Guid("35a1e95b-1cfe-4e66-8afa-90d42fa38092")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CrtContract_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_CrtContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_CrtContract_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CrtContract_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtContract_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CrtContract_Terrasoft : Terrasoft.Configuration.Activity_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public Activity_CrtContract_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CrtContract_Terrasoft";
		}

		public Activity_CrtContract_Terrasoft(Activity_CrtContract_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CrtContractEventsProcess(UserConnection);
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
			return new Activity_CrtContract_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CrtContractEventsProcess

	/// <exclude/>
	public partial class Activity_CrtContractEventsProcess<TEntity> : Terrasoft.Configuration.Activity_OpportunityEventsProcess<TEntity> where TEntity : Activity_CrtContract_Terrasoft
	{

		public Activity_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CrtContractEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0980553d-2d8c-48cc-86cb-7c9dcf593ba4");
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

	#region Class: Activity_CrtContractEventsProcess

	/// <exclude/>
	public class Activity_CrtContractEventsProcess : Activity_CrtContractEventsProcess<Activity_CrtContract_Terrasoft>
	{

		public Activity_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

