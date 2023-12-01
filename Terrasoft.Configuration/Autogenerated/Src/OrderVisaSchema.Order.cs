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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: OrderVisaSchema

	/// <exclude/>
	public class OrderVisaSchema : Terrasoft.Configuration.OrderVisa_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderVisaSchema(OrderVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderVisaSchema(OrderVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("698fdf83-6699-408c-abd2-22b9484f93f0");
			Name = "OrderVisa";
			ParentSchemaUId = new Guid("5ebe74ce-17ca-4c68-97e6-8e25e01e47c5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8");
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
			return new OrderVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderVisa_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("698fdf83-6699-408c-abd2-22b9484f93f0"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisa

	/// <summary>
	/// Order approval.
	/// </summary>
	public class OrderVisa : Terrasoft.Configuration.OrderVisa_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderVisa";
		}

		public OrderVisa(OrderVisa source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderVisa_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("OrderVisaInserting", e);
			Validating += (s, e) => ThrowEvent("OrderVisaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderVisa_OrderEventsProcess

	/// <exclude/>
	public partial class OrderVisa_OrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderVisa_CrtOrderEventsProcess<TEntity> where TEntity : OrderVisa
	{

		public OrderVisa_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderVisa_OrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("698fdf83-6699-408c-abd2-22b9484f93f0");
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

	#region Class: OrderVisa_OrderEventsProcess

	/// <exclude/>
	public class OrderVisa_OrderEventsProcess : OrderVisa_OrderEventsProcess<OrderVisa>
	{

		public OrderVisa_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: OrderVisaEventsProcess

	/// <exclude/>
	public class OrderVisaEventsProcess : OrderVisa_OrderEventsProcess
	{

		public OrderVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

