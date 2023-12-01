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

	#region Class: ServiceInServicePactSchema

	/// <exclude/>
	public class ServiceInServicePactSchema : Terrasoft.Configuration.ServiceInServicePact_SLMITILService_TerrasoftSchema
	{

		#region Constructors: Public

		public ServiceInServicePactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceInServicePactSchema(ServiceInServicePactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceInServicePactSchema(ServiceInServicePactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d3c665c6-0527-4aa6-ac2c-74b020e57280");
			Name = "ServiceInServicePact";
			ParentSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6aa9e6de-1a3c-48fa-9713-10ac295cdb76");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
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
			return new ServiceInServicePact(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceInServicePact_CrtCaseManagementAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceInServicePactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceInServicePactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3c665c6-0527-4aa6-ac2c-74b020e57280"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact

	/// <summary>
	/// Service in service agreement.
	/// </summary>
	public class ServiceInServicePact : Terrasoft.Configuration.ServiceInServicePact_SLMITILService_Terrasoft
	{

		#region Constructors: Public

		public ServiceInServicePact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceInServicePact";
		}

		public ServiceInServicePact(ServiceInServicePact source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceInServicePact_CrtCaseManagementAppEventsProcess(UserConnection);
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
			return new ServiceInServicePact(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_CrtCaseManagementAppEventsProcess

	/// <exclude/>
	public partial class ServiceInServicePact_CrtCaseManagementAppEventsProcess<TEntity> : Terrasoft.Configuration.ServiceInServicePact_SLMITILServiceEventsProcess<TEntity> where TEntity : ServiceInServicePact
	{

		public ServiceInServicePact_CrtCaseManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceInServicePact_CrtCaseManagementAppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d3c665c6-0527-4aa6-ac2c-74b020e57280");
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

	#region Class: ServiceInServicePact_CrtCaseManagementAppEventsProcess

	/// <exclude/>
	public class ServiceInServicePact_CrtCaseManagementAppEventsProcess : ServiceInServicePact_CrtCaseManagementAppEventsProcess<ServiceInServicePact>
	{

		public ServiceInServicePact_CrtCaseManagementAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceInServicePact_CrtCaseManagementAppEventsProcess

	public partial class ServiceInServicePact_CrtCaseManagementAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ServiceInServicePactEventsProcess

	/// <exclude/>
	public class ServiceInServicePactEventsProcess : ServiceInServicePact_CrtCaseManagementAppEventsProcess
	{

		public ServiceInServicePactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

