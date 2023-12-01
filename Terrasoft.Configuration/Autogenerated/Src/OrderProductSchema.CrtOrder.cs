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

	#region Class: OrderProduct_CrtOrder_TerrasoftSchema

	/// <exclude/>
	public class OrderProduct_CrtOrder_TerrasoftSchema : Terrasoft.Configuration.BaseProductEntrySchema
	{

		#region Constructors: Public

		public OrderProduct_CrtOrder_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderProduct_CrtOrder_TerrasoftSchema(OrderProduct_CrtOrder_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderProduct_CrtOrder_TerrasoftSchema(OrderProduct_CrtOrder_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			RealUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			Name = "OrderProduct_CrtOrder_Terrasoft";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5d990ae6-2f01-4ab2-ae31-d384e6070ec3")) == null) {
				Columns.Add(CreateOrderColumn());
			}
			if (Columns.FindByUId(new Guid("d39634bd-ec70-4b48-964d-47d0c052a47a")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("727aff73-e56f-401b-af5f-4a4d3a28c235")) == null) {
				Columns.Add(CreateCurrencyRateColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateProductColumn() {
			EntitySchemaColumn column = base.CreateProductColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateCustomProductColumn() {
			EntitySchemaColumn column = base.CreateCustomProductColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDeliveryDateColumn() {
			EntitySchemaColumn column = base.CreateDeliveryDateColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateQuantityColumn() {
			EntitySchemaColumn column = base.CreateQuantityColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.IsSimpleLookup = true;
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryPriceColumn() {
			EntitySchemaColumn column = base.CreatePrimaryPriceColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceColumn() {
			EntitySchemaColumn column = base.CreatePriceColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateAmountColumn() {
			EntitySchemaColumn column = base.CreateAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountAmountColumn() {
			EntitySchemaColumn column = base.CreateDiscountAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountPercentColumn() {
			EntitySchemaColumn column = base.CreateDiscountPercentColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.IsSimpleLookup = true;
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTaxAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxAmountColumn() {
			EntitySchemaColumn column = base.CreateTaxAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreatePrimaryTotalAmountColumn() {
			EntitySchemaColumn column = base.CreatePrimaryTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateTotalAmountColumn() {
			EntitySchemaColumn column = base.CreateTotalAmountColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateDiscountTaxColumn() {
			EntitySchemaColumn column = base.CreateDiscountTaxColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			column.CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5d990ae6-2f01-4ab2-ae31-d384e6070ec3"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("dd9fef59-5c55-4ab9-987f-84fb816c4cbb")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d39634bd-ec70-4b48-964d-47d0c052a47a"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("6439b666-7603-43a5-90d0-7ee1e44814cf")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float8")) {
				UId = new Guid("727aff73-e56f-401b-af5f-4a4d3a28c235"),
				Name = @"CurrencyRate",
				CreatedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				ModifiedInSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				CreatedInPackageId = new Guid("6439b666-7603-43a5-90d0-7ee1e44814cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OrderProduct_CrtOrder_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OrderProduct_CrtOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderProduct_CrtOrder_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderProduct_CrtOrder_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"));
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_CrtOrder_Terrasoft

	/// <summary>
	/// Product in order.
	/// </summary>
	public class OrderProduct_CrtOrder_Terrasoft : Terrasoft.Configuration.BaseProductEntry
	{

		#region Constructors: Public

		public OrderProduct_CrtOrder_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OrderProduct_CrtOrder_Terrasoft";
		}

		public OrderProduct_CrtOrder_Terrasoft(OrderProduct_CrtOrder_Terrasoft source)
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

		/// <exclude/>
		public Guid CurrencyId {
			get {
				return GetTypedColumnValue<Guid>("CurrencyId");
			}
			set {
				SetColumnValue("CurrencyId", value);
				_currency = null;
			}
		}

		/// <exclude/>
		public string CurrencyName {
			get {
				return GetTypedColumnValue<string>("CurrencyName");
			}
			set {
				SetColumnValue("CurrencyName", value);
				if (_currency != null) {
					_currency.Name = value;
				}
			}
		}

		private Currency _currency;
		/// <summary>
		/// Currency.
		/// </summary>
		public Currency Currency {
			get {
				return _currency ??
					(_currency = LookupColumnEntities.GetEntity("Currency") as Currency);
			}
		}

		/// <summary>
		/// Exchange rate.
		/// </summary>
		public Decimal CurrencyRate {
			get {
				return GetTypedColumnValue<Decimal>("CurrencyRate");
			}
			set {
				SetColumnValue("CurrencyRate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OrderProduct_CrtOrderEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OrderProduct_CrtOrder_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OrderProduct_CrtOrder_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OrderProduct_CrtOrder_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OrderProduct_CrtOrder_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OrderProduct_CrtOrderEventsProcess

	/// <exclude/>
	public partial class OrderProduct_CrtOrderEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_CrtProductCatalogueEventsProcess<TEntity> where TEntity : OrderProduct_CrtOrder_Terrasoft
	{

		public OrderProduct_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OrderProduct_CrtOrderEventsProcess";
			SchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedUpdateOrderAmount {
			get;
			set;
		}

		public virtual bool IsProductDeleted {
			get;
			set;
		}

		public virtual Object ChangedColumnValues {
			get;
			set;
		}

		public virtual bool NeedRecalcPrimaryValues {
			get;
			set;
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

	#region Class: OrderProduct_CrtOrderEventsProcess

	/// <exclude/>
	public class OrderProduct_CrtOrderEventsProcess : OrderProduct_CrtOrderEventsProcess<OrderProduct_CrtOrder_Terrasoft>
	{

		public OrderProduct_CrtOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

