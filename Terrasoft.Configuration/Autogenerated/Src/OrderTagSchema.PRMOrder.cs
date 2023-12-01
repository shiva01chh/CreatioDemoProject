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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: OrderTagSchema

	/// <exclude/>
	public class OrderTagSchema : Terrasoft.Configuration.OrderTag_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderTagSchema(OrderTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderTagSchema(OrderTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a343584a-e75d-4273-ae5e-d1e5ef7d6a4b");
			Name = "OrderTag";
			ParentSchemaUId = new Guid("765c4500-20c0-452a-9b54-ab5cbb32cf28");
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
			return new OrderTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderTag_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a343584a-e75d-4273-ae5e-d1e5ef7d6a4b"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderTag

	/// <summary>
	/// Orders section tag.
	/// </summary>
	public class OrderTag : Terrasoft.Configuration.OrderTag_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderTag";
		}

		public OrderTag(OrderTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderTag_PRMOrderEventsProcess(UserConnection);
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
			return new OrderTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderTag_PRMOrderEventsProcess

	/// <exclude/>
	public partial class OrderTag_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderTag_CrtOrderEventsProcess<TEntity> where TEntity : OrderTag
	{

		public OrderTag_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderTag_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a343584a-e75d-4273-ae5e-d1e5ef7d6a4b");
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

	#region Class: OrderTag_PRMOrderEventsProcess

	/// <exclude/>
	public class OrderTag_PRMOrderEventsProcess : OrderTag_PRMOrderEventsProcess<OrderTag>
	{

		public OrderTag_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderTag_PRMOrderEventsProcess

	public partial class OrderTag_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OrderTagEventsProcess

	/// <exclude/>
	public class OrderTagEventsProcess : OrderTag_PRMOrderEventsProcess
	{

		public OrderTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

