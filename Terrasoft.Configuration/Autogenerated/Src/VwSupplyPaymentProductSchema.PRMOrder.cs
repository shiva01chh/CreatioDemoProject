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

	#region Class: VwSupplyPaymentProductSchema

	/// <exclude/>
	public class VwSupplyPaymentProductSchema : Terrasoft.Configuration.VwSupplyPaymentProduct_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSupplyPaymentProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSupplyPaymentProductSchema(VwSupplyPaymentProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSupplyPaymentProductSchema(VwSupplyPaymentProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("08087540-73bb-41b9-8232-73a76719041e");
			Name = "VwSupplyPaymentProduct";
			ParentSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e575b496-539f-4b26-8ba5-4be2dab7e3d9");
			IsDBView = true;
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
			return new VwSupplyPaymentProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSupplyPaymentProduct_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSupplyPaymentProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSupplyPaymentProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08087540-73bb-41b9-8232-73a76719041e"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSupplyPaymentProduct

	/// <summary>
	/// Products available in the installment plan.
	/// </summary>
	public class VwSupplyPaymentProduct : Terrasoft.Configuration.VwSupplyPaymentProduct_Passport_Terrasoft
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSupplyPaymentProduct";
		}

		public VwSupplyPaymentProduct(VwSupplyPaymentProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSupplyPaymentProduct_PRMOrderEventsProcess(UserConnection);
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
			return new VwSupplyPaymentProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSupplyPaymentProduct_PRMOrderEventsProcess

	/// <exclude/>
	public partial class VwSupplyPaymentProduct_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.VwSupplyPaymentProduct_PassportEventsProcess<TEntity> where TEntity : VwSupplyPaymentProduct
	{

		public VwSupplyPaymentProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSupplyPaymentProduct_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("08087540-73bb-41b9-8232-73a76719041e");
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

	#region Class: VwSupplyPaymentProduct_PRMOrderEventsProcess

	/// <exclude/>
	public class VwSupplyPaymentProduct_PRMOrderEventsProcess : VwSupplyPaymentProduct_PRMOrderEventsProcess<VwSupplyPaymentProduct>
	{

		public VwSupplyPaymentProduct_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSupplyPaymentProduct_PRMOrderEventsProcess

	public partial class VwSupplyPaymentProduct_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSupplyPaymentProductEventsProcess

	/// <exclude/>
	public class VwSupplyPaymentProductEventsProcess : VwSupplyPaymentProduct_PRMOrderEventsProcess
	{

		public VwSupplyPaymentProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

