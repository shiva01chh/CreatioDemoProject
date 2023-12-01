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

	#region Class: OrderInTagSchema

	/// <exclude/>
	public class OrderInTagSchema : Terrasoft.Configuration.OrderInTag_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderInTagSchema(OrderInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderInTagSchema(OrderInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b4d8a6ee-16b5-4ff3-a1c7-89b69cfe1feb");
			Name = "OrderInTag";
			ParentSchemaUId = new Guid("f4330954-fa69-408f-a489-ef87b1daf153");
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
			return new OrderInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderInTag_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4d8a6ee-16b5-4ff3-a1c7-89b69cfe1feb"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderInTag

	/// <summary>
	/// Orders section record tag.
	/// </summary>
	public class OrderInTag : Terrasoft.Configuration.OrderInTag_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderInTag";
		}

		public OrderInTag(OrderInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderInTag_PRMOrderEventsProcess(UserConnection);
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
			return new OrderInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderInTag_PRMOrderEventsProcess

	/// <exclude/>
	public partial class OrderInTag_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderInTag_CrtOrderEventsProcess<TEntity> where TEntity : OrderInTag
	{

		public OrderInTag_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderInTag_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b4d8a6ee-16b5-4ff3-a1c7-89b69cfe1feb");
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

	#region Class: OrderInTag_PRMOrderEventsProcess

	/// <exclude/>
	public class OrderInTag_PRMOrderEventsProcess : OrderInTag_PRMOrderEventsProcess<OrderInTag>
	{

		public OrderInTag_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OrderInTag_PRMOrderEventsProcess

	public partial class OrderInTag_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OrderInTagEventsProcess

	/// <exclude/>
	public class OrderInTagEventsProcess : OrderInTag_PRMOrderEventsProcess
	{

		public OrderInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

