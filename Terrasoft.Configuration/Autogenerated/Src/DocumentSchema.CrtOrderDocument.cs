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

	#region Class: Document_CrtOrderDocument_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtOrderDocument_TerrasoftSchema : Terrasoft.Configuration.Document_CrtContractDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_CrtOrderDocument_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtOrderDocument_TerrasoftSchema(Document_CrtOrderDocument_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtOrderDocument_TerrasoftSchema(Document_CrtOrderDocument_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e80415d7-73fb-43c9-bd98-0ba9c0fc62be");
			Name = "Document_CrtOrderDocument_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5d9b28ba-4fc6-47b4-a9dc-af73da976584");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("722a29cd-767f-419a-8208-ab455f88217d")) == null) {
				Columns.Add(CreateOrderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("722a29cd-767f-419a-8208-ab455f88217d"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e80415d7-73fb-43c9-bd98-0ba9c0fc62be"),
				ModifiedInSchemaUId = new Guid("e80415d7-73fb-43c9-bd98-0ba9c0fc62be"),
				CreatedInPackageId = new Guid("5d9b28ba-4fc6-47b4-a9dc-af73da976584")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtOrderDocument_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtOrderDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtOrderDocument_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtOrderDocument_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e80415d7-73fb-43c9-bd98-0ba9c0fc62be"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtOrderDocument_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtOrderDocument_Terrasoft : Terrasoft.Configuration.Document_CrtContractDocument_Terrasoft
	{

		#region Constructors: Public

		public Document_CrtOrderDocument_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtOrderDocument_Terrasoft";
		}

		public Document_CrtOrderDocument_Terrasoft(Document_CrtOrderDocument_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OrderId {
			get {
				return GetTypedColumnValue<Guid>("OrderId");
			}
			set {
				SetColumnValue("OrderId", value);
				_order = null;
			}
		}

		/// <exclude/>
		public string OrderNumber {
			get {
				return GetTypedColumnValue<string>("OrderNumber");
			}
			set {
				SetColumnValue("OrderNumber", value);
				if (_order != null) {
					_order.Number = value;
				}
			}
		}

		private Order _order;
		/// <summary>
		/// Order.
		/// </summary>
		public Order Order {
			get {
				return _order ??
					(_order = LookupColumnEntities.GetEntity("Order") as Order);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtOrderDocumentEventsProcess(UserConnection);
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
			return new Document_CrtOrderDocument_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtOrderDocumentEventsProcess

	/// <exclude/>
	public partial class Document_CrtOrderDocumentEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtContractDocumentEventsProcess<TEntity> where TEntity : Document_CrtOrderDocument_Terrasoft
	{

		public Document_CrtOrderDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtOrderDocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e80415d7-73fb-43c9-bd98-0ba9c0fc62be");
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

	#region Class: Document_CrtOrderDocumentEventsProcess

	/// <exclude/>
	public class Document_CrtOrderDocumentEventsProcess : Document_CrtOrderDocumentEventsProcess<Document_CrtOrderDocument_Terrasoft>
	{

		public Document_CrtOrderDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_CrtOrderDocumentEventsProcess

	public partial class Document_CrtOrderDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

