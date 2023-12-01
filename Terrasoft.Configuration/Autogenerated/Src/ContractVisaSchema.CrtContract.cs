namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContractVisa_CrtContract_TerrasoftSchema

	/// <exclude/>
	public class ContractVisa_CrtContract_TerrasoftSchema : Terrasoft.Configuration.BaseVisaSchema
	{

		#region Constructors: Public

		public ContractVisa_CrtContract_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractVisa_CrtContract_TerrasoftSchema(ContractVisa_CrtContract_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractVisa_CrtContract_TerrasoftSchema(ContractVisa_CrtContract_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			RealUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			Name = "ContractVisa_CrtContract_Terrasoft";
			ParentSchemaUId = new Guid("5fa90d0d-64eb-4f52-8d3d-c51fa6443b66");
			ExtendParent = false;
			CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe0dfac8-c69e-4744-b030-d6998935c904")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe0dfac8-c69e-4744-b030-d6998935c904"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				ModifiedInSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"),
				CreatedInPackageId = new Guid("26258d2f-5eb6-4391-98b9-20659e44f505")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContractVisa_CrtContract_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContractVisa_CrtContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractVisa_CrtContract_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractVisa_CrtContract_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa_CrtContract_Terrasoft

	/// <summary>
	/// Contract approval.
	/// </summary>
	public class ContractVisa_CrtContract_Terrasoft : Terrasoft.Configuration.BaseVisa
	{

		#region Constructors: Public

		public ContractVisa_CrtContract_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContractVisa_CrtContract_Terrasoft";
		}

		public ContractVisa_CrtContract_Terrasoft(ContractVisa_CrtContract_Terrasoft source)
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
			var process = new ContractVisa_CrtContractEventsProcess(UserConnection);
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
			return new ContractVisa_CrtContract_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa_CrtContractEventsProcess

	/// <exclude/>
	public partial class ContractVisa_CrtContractEventsProcess<TEntity> : Terrasoft.Configuration.BaseVisa_CrtProcessDesignerEventsProcess<TEntity> where TEntity : ContractVisa_CrtContract_Terrasoft
	{

		public ContractVisa_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractVisa_CrtContractEventsProcess";
			SchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private LocalizableString _popupBodyTemplateWithoutDate;
		public LocalizableString PopupBodyTemplateWithoutDate {
			get {
				return _popupBodyTemplateWithoutDate ?? (_popupBodyTemplateWithoutDate = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.PopupBodyTemplateWithoutDate.Value"));
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

	#region Class: ContractVisa_CrtContractEventsProcess

	/// <exclude/>
	public class ContractVisa_CrtContractEventsProcess : ContractVisa_CrtContractEventsProcess<ContractVisa_CrtContract_Terrasoft>
	{

		public ContractVisa_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

