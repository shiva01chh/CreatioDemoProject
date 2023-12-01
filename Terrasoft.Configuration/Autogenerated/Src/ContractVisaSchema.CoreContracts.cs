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

	#region Class: ContractVisaSchema

	/// <exclude/>
	public class ContractVisaSchema : Terrasoft.Configuration.ContractVisa_CrtContract_TerrasoftSchema
	{

		#region Constructors: Public

		public ContractVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractVisaSchema(ContractVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractVisaSchema(ContractVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("35ce7128-8db2-49e2-a785-33e1546abd0b");
			Name = "ContractVisa";
			ParentSchemaUId = new Guid("e2edcaf0-4bec-418f-9c13-b1e07e7244c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContractVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContractVisa_CoreContractsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35ce7128-8db2-49e2-a785-33e1546abd0b"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa

	/// <summary>
	/// Contract approval.
	/// </summary>
	public class ContractVisa : Terrasoft.Configuration.ContractVisa_CrtContract_Terrasoft
	{

		#region Constructors: Public

		public ContractVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContractVisa";
		}

		public ContractVisa(ContractVisa source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContractVisa_CoreContractsEventsProcess(UserConnection);
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
			return new ContractVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContractVisa_CoreContractsEventsProcess

	/// <exclude/>
	public partial class ContractVisa_CoreContractsEventsProcess<TEntity> : Terrasoft.Configuration.ContractVisa_CrtContractEventsProcess<TEntity> where TEntity : ContractVisa
	{

		public ContractVisa_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractVisa_CoreContractsEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("35ce7128-8db2-49e2-a785-33e1546abd0b");
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

	#region Class: ContractVisa_CoreContractsEventsProcess

	/// <exclude/>
	public class ContractVisa_CoreContractsEventsProcess : ContractVisa_CoreContractsEventsProcess<ContractVisa>
	{

		public ContractVisa_CoreContractsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: ContractVisaEventsProcess

	/// <exclude/>
	public class ContractVisaEventsProcess : ContractVisa_CoreContractsEventsProcess
	{

		public ContractVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

