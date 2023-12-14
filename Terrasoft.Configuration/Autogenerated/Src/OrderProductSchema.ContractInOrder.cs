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

	#region Class: OrderProduct_ContractInOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_ContractInOrder_TerrasoftSchema : Terrasoft.Configuration.OrderProduct_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderProduct_ContractInOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_ContractInOrder_TerrasoftSchema(OrderProduct_ContractInOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_ContractInOrder_TerrasoftSchema(OrderProduct_ContractInOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3e122dc6-b034-4ad1-b055-80dfcc862f3e");
			Name = "OrderProduct_ContractInOrder_Terrasoft";
			ParentSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("143ed6c8-334b-4846-a5dc-2c0b65e53c84");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new OrderProduct_ContractInOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_ContractInOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_ContractInOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_ContractInOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e122dc6-b034-4ad1-b055-80dfcc862f3e"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ContractInOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_ContractInOrder_Terrasoft : Terrasoft.Configuration.OrderProduct_Passport_Terrasoft
	{

		#region Constructors: Public

		public OrderProduct_ContractInOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_ContractInOrder_Terrasoft";
		}

		public OrderProduct_ContractInOrder_Terrasoft(OrderProduct_ContractInOrder_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_ContractInOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("OrderProduct_ContractInOrder_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("OrderProduct_ContractInOrder_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_ContractInOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_ContractInOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_ContractInOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_ContractInOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderProduct_PassportEventsProcess<TEntity> where TEntity : OrderProduct_ContractInOrder_Terrasoft
	{

		public OrderProduct_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_ContractInOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3e122dc6-b034-4ad1-b055-80dfcc862f3e");
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

	#region Class: OrderProduct_ContractInOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_ContractInOrderEventsProcess : OrderProduct_ContractInOrderEventsProcess<OrderProduct_ContractInOrder_Terrasoft>
	{

		public OrderProduct_ContractInOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

