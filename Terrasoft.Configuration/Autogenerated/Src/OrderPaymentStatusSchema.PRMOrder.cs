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

	#region Class: OrderPaymentStatusSchema

	/// <exclude/>
	public class OrderPaymentStatusSchema : Terrasoft.Configuration.OrderPaymentStatus_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderPaymentStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderPaymentStatusSchema(OrderPaymentStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderPaymentStatusSchema(OrderPaymentStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0bffcdd8-d173-4178-9944-cd80fbff23b9");
			Name = "OrderPaymentStatus";
			ParentSchemaUId = new Guid("c121173e-9034-4066-aede-682a4ce8fa88");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c09bcc89-cd4a-49df-a8fa-3a15879bc3c5");
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
			return new OrderPaymentStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderPaymentStatus_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderPaymentStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderPaymentStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bffcdd8-d173-4178-9944-cd80fbff23b9"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderPaymentStatus

	/// <summary>
	/// Order payment status.
	/// </summary>
	public class OrderPaymentStatus : Terrasoft.Configuration.OrderPaymentStatus_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderPaymentStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderPaymentStatus";
		}

		public OrderPaymentStatus(OrderPaymentStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderPaymentStatus_PRMOrderEventsProcess(UserConnection);
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
			return new OrderPaymentStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderPaymentStatus_PRMOrderEventsProcess

	/// <exclude/>
	public partial class OrderPaymentStatus_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderPaymentStatus_CrtOrderEventsProcess<TEntity> where TEntity : OrderPaymentStatus
	{

		public OrderPaymentStatus_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderPaymentStatus_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0bffcdd8-d173-4178-9944-cd80fbff23b9");
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

	#region Class: OrderPaymentStatus_PRMOrderEventsProcess

	/// <exclude/>
	public class OrderPaymentStatus_PRMOrderEventsProcess : OrderPaymentStatus_PRMOrderEventsProcess<OrderPaymentStatus>
	{

		public OrderPaymentStatus_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderPaymentStatus_PRMOrderEventsProcess

	public partial class OrderPaymentStatus_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OrderPaymentStatusEventsProcess

	/// <exclude/>
	public class OrderPaymentStatusEventsProcess : OrderPaymentStatus_PRMOrderEventsProcess
	{

		public OrderPaymentStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

