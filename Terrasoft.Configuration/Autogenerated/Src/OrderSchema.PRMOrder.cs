﻿namespace Terrasoft.Configuration
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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Passport;
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

	#region Class: OrderSchema

	/// <exclude/>
	public class OrderSchema : Terrasoft.Configuration.Order_Passport_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderSchema(OrderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderSchema(OrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			Name = "Order";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override EntitySchemaColumn CreateDateColumn() {
			EntitySchemaColumn column = base.CreateDateColumn();
			column.IsTrackChangesInDB = false;
			column.ModifiedInSchemaUId = new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693"));
		}

		#endregion

	}

	#endregion

	#region Class: Order

	/// <summary>
	/// Order.
	/// </summary>
	public class Order : Terrasoft.Configuration.Order_Passport_Terrasoft
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order";
		}

		public Order(Order source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_PRMOrderEventsProcess(UserConnection);
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
			return new Order(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_PRMOrderEventsProcess

	/// <exclude/>
	public partial class Order_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.Order_PassportEventsProcess<TEntity> where TEntity : Order
	{

		public Order_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c1f6301f-aced-4265-bb12-97c4e4fa1693");
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

	#region Class: Order_PRMOrderEventsProcess

	/// <exclude/>
	public class Order_PRMOrderEventsProcess : Order_PRMOrderEventsProcess<Order>
	{

		public Order_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_PRMOrderEventsProcess

	public partial class Order_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void UpdateProductAmounts() {
			base.UpdateProductAmounts();
			if (NeedFinRecalc) {
				var orderAmountHelper = ClassFactory.Get<Terrasoft.Configuration.Passport.OrderAmountHelper>(new ConstructorArgument("userConnection", UserConnection));
				orderAmountHelper.UpdateAmountsByOrderId(Entity.GetTypedColumnValue<Guid>("Id"));
			}
		}

		#endregion

	}

	#endregion


	#region Class: OrderEventsProcess

	/// <exclude/>
	public class OrderEventsProcess : Order_PRMOrderEventsProcess
	{

		public OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

