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

	#region Class: OrderFolder_Order_TerrasoftSchema

	/// <exclude/>
	public class OrderFolder_Order_TerrasoftSchema : Terrasoft.Configuration.OrderFolder_CrtOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderFolder_Order_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderFolder_Order_TerrasoftSchema(OrderFolder_Order_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderFolder_Order_TerrasoftSchema(OrderFolder_Order_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			Name = "OrderFolder_Order_Terrasoft";
			ParentSchemaUId = new Guid("4a8e2437-fc34-4f24-9d41-92da7c4a20ae");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e8c4bc03-2f14-47b7-8005-47fab57cc1b8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateSearchDataColumn() {
			EntitySchemaColumn column = base.CreateSearchDataColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderFolder_Order_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderFolder_OrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderFolder_Order_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderFolder_Order_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderFolder_Order_Terrasoft

	/// <summary>
	/// Orders folder.
	/// </summary>
	public class OrderFolder_Order_Terrasoft : Terrasoft.Configuration.OrderFolder_CrtOrder_Terrasoft
	{

		#region Constructors: Public

		public OrderFolder_Order_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderFolder_Order_Terrasoft";
		}

		public OrderFolder_Order_Terrasoft(OrderFolder_Order_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderFolder_OrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderFolder_Order_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderFolder_Order_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OrderFolder_Order_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderFolder_Order_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderFolder_OrderEventsProcess

	/// <exclude/>
	public partial class OrderFolder_OrderEventsProcess<TEntity> : Terrasoft.Configuration.OrderFolder_CrtOrderEventsProcess<TEntity> where TEntity : OrderFolder_Order_Terrasoft
	{

		public OrderFolder_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderFolder_OrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3c405a2b-3a79-4425-81a9-473d4c427d2b");
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

	#region Class: OrderFolder_OrderEventsProcess

	/// <exclude/>
	public class OrderFolder_OrderEventsProcess : OrderFolder_OrderEventsProcess<OrderFolder_Order_Terrasoft>
	{

		public OrderFolder_OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

