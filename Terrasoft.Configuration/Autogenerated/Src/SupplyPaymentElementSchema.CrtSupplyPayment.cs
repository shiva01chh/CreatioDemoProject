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

	#region Class: SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.SupplyPaymentSchema
	{

		#region Constructors: Public

		public SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("3bd175a6-d977-41b0-9091-566ad73135f7");
			index.Name = "IeY97HvuWyT8xw8jpwkpEpPnhiUs";
			index.CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn idIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f208c25-99a7-4192-a03e-fcb48d4a9abc"),
				ColumnUId = new Guid("ae0e45ca-c495-4fe7-a39d-3ab7278e1617"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(idIndexColumn);
			EntitySchemaIndexColumn typeIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("6ff85e23-059a-44f7-b128-f5e452ca9c05"),
				ColumnUId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(typeIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			RealUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			Name = "SupplyPaymentElement_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("72478c19-2ca7-4043-849a-98b8a98379b8")) == null) {
				Columns.Add(CreateDatePlanColumn());
			}
			if (Columns.FindByUId(new Guid("eba7d360-42b7-462d-a77a-9a88bc0341eb")) == null) {
				Columns.Add(CreateDateFactColumn());
			}
			if (Columns.FindByUId(new Guid("0a3324bb-55c8-4791-b51f-409cfedc6fe2")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("8db4ebad-d676-40ac-8794-e7595b45a380")) == null) {
				Columns.Add(CreateAmountPlanColumn());
			}
			if (Columns.FindByUId(new Guid("17e30b16-182b-49de-b2eb-f3e22b748da4")) == null) {
				Columns.Add(CreateAmountFactColumn());
			}
			if (Columns.FindByUId(new Guid("bffa49c8-f12c-4d40-b2d0-872ff5affd26")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("b96f2cd9-fee2-4165-85da-7941232abaa8")) == null) {
				Columns.Add(CreateOrderColumn());
			}
			if (Columns.FindByUId(new Guid("0466d76c-ac6c-4404-ab86-769840c37023")) == null) {
				Columns.Add(CreatePreviousElementColumn());
			}
			if (Columns.FindByUId(new Guid("e220d88e-6cd0-40c1-9b5a-4a2f460c48d2")) == null) {
				Columns.Add(CreateInvoiceColumn());
			}
			if (Columns.FindByUId(new Guid("d72b2f87-802a-4608-b41c-9d271ba1fd0b")) == null) {
				Columns.Add(CreatePrimaryAmountPlanColumn());
			}
			if (Columns.FindByUId(new Guid("9f4daaf1-654c-4f57-9200-73d27570bde0")) == null) {
				Columns.Add(CreatePrimaryAmountFactColumn());
			}
			if (Columns.FindByUId(new Guid("d0235de8-8f51-44ff-98f3-a8f701a34931")) == null) {
				Columns.Add(CreateProductsColumn());
			}
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel;
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateDelayTypeColumn() {
			EntitySchemaColumn column = base.CreateDelayTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"6fc58059-9c4a-4481-8775-bbadf4a4ad51"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreateDelayColumn() {
			EntitySchemaColumn column = base.CreateDelayColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"0"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected override EntitySchemaColumn CreatePercentageColumn() {
			EntitySchemaColumn column = base.CreatePercentageColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"0"
			};
			column.ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDatePlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("72478c19-2ca7-4043-849a-98b8a98379b8"),
				Name = @"DatePlan",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDateFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("eba7d360-42b7-462d-a77a-9a88bc0341eb"),
				Name = @"DateFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0a3324bb-55c8-4791-b51f-409cfedc6fe2"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("270f817e-6b26-499c-8a5a-61d02846ee36"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"b801edd0-33f8-45ed-aee8-2e26307b0456"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateAmountPlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("8db4ebad-d676-40ac-8794-e7595b45a380"),
				Name = @"AmountPlan",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("17e30b16-182b-49de-b2eb-f3e22b748da4"),
				Name = @"AmountFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bffa49c8-f12c-4d40-b2d0-872ff5affd26"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b96f2cd9-fee2-4165-85da-7941232abaa8"),
				Name = @"Order",
				ReferenceSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("34a51039-9d1e-4b9d-bbef-f6018add0691"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0466d76c-ac6c-4404-ab86-769840c37023"),
				Name = @"PreviousElement",
				ReferenceSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateInvoiceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e220d88e-6cd0-40c1-9b5a-4a2f460c48d2"),
				Name = @"Invoice",
				ReferenceSchemaUId = new Guid("bfb313dd-bb55-4e1b-8e42-3d346e0da7c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountPlanColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("d72b2f87-802a-4608-b41c-9d271ba1fd0b"),
				Name = @"PrimaryAmountPlan",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreatePrimaryAmountFactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("9f4daaf1-654c-4f57-9200-73d27570bde0"),
				Name = @"PrimaryAmountFact",
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("d9ceb238-704d-4d40-8dc8-6e1f79ab2ddb")
			};
		}

		protected virtual EntitySchemaColumn CreateProductsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("d0235de8-8f51-44ff-98f3-a8f701a34931"),
				Name = @"Products",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				ModifiedInSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIeY97HvuWyT8xw8jpwkpEpPnhiUsIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentElement_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentElement_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentElement_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Installment plan: new entry.
	/// </summary>
	public class SupplyPaymentElement_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.SupplyPayment
	{

		#region Constructors: Public

		public SupplyPaymentElement_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentElement_CrtSupplyPayment_Terrasoft";
		}

		public SupplyPaymentElement_CrtSupplyPayment_Terrasoft(SupplyPaymentElement_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Due date.
		/// </summary>
		public DateTime DatePlan {
			get {
				return GetTypedColumnValue<DateTime>("DatePlan");
			}
			set {
				SetColumnValue("DatePlan", value);
			}
		}

		/// <summary>
		/// Actual date.
		/// </summary>
		public DateTime DateFact {
			get {
				return GetTypedColumnValue<DateTime>("DateFact");
			}
			set {
				SetColumnValue("DateFact", value);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private SupplyPaymentState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public SupplyPaymentState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as SupplyPaymentState);
			}
		}

		/// <summary>
		/// Expected amount.
		/// </summary>
		public Decimal AmountPlan {
			get {
				return GetTypedColumnValue<Decimal>("AmountPlan");
			}
			set {
				SetColumnValue("AmountPlan", value);
			}
		}

		/// <summary>
		/// Actual amount.
		/// </summary>
		public Decimal AmountFact {
			get {
				return GetTypedColumnValue<Decimal>("AmountFact");
			}
			set {
				SetColumnValue("AmountFact", value);
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private OrderProduct _product;
		/// <summary>
		/// Product.
		/// </summary>
		/// <remarks>
		/// Deprecated.
		/// </remarks>
		public OrderProduct Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as OrderProduct);
			}
		}

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

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid PreviousElementId {
			get {
				return GetTypedColumnValue<Guid>("PreviousElementId");
			}
			set {
				SetColumnValue("PreviousElementId", value);
				_previousElement = null;
			}
		}

		/// <exclude/>
		public string PreviousElementName {
			get {
				return GetTypedColumnValue<string>("PreviousElementName");
			}
			set {
				SetColumnValue("PreviousElementName", value);
				if (_previousElement != null) {
					_previousElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _previousElement;
		/// <summary>
		/// Previous entry.
		/// </summary>
		public SupplyPaymentElement PreviousElement {
			get {
				return _previousElement ??
					(_previousElement = LookupColumnEntities.GetEntity("PreviousElement") as SupplyPaymentElement);
			}
		}

		/// <exclude/>
		public Guid InvoiceId {
			get {
				return GetTypedColumnValue<Guid>("InvoiceId");
			}
			set {
				SetColumnValue("InvoiceId", value);
				_invoice = null;
			}
		}

		/// <exclude/>
		public string InvoiceNumber {
			get {
				return GetTypedColumnValue<string>("InvoiceNumber");
			}
			set {
				SetColumnValue("InvoiceNumber", value);
				if (_invoice != null) {
					_invoice.Number = value;
				}
			}
		}

		private Invoice _invoice;
		/// <summary>
		/// Invoice.
		/// </summary>
		public Invoice Invoice {
			get {
				return _invoice ??
					(_invoice = LookupColumnEntities.GetEntity("Invoice") as Invoice);
			}
		}

		/// <summary>
		/// Expected amount, base currency.
		/// </summary>
		public Decimal PrimaryAmountPlan {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountPlan");
			}
			set {
				SetColumnValue("PrimaryAmountPlan", value);
			}
		}

		/// <summary>
		/// Actual amount, base currency.
		/// </summary>
		public Decimal PrimaryAmountFact {
			get {
				return GetTypedColumnValue<Decimal>("PrimaryAmountFact");
			}
			set {
				SetColumnValue("PrimaryAmountFact", value);
			}
		}

		/// <summary>
		/// Products.
		/// </summary>
		public string Products {
			get {
				return GetTypedColumnValue<string>("Products");
			}
			set {
				SetColumnValue("Products", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentElement_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentElement_CrtSupplyPayment_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("SupplyPaymentElement_CrtSupplyPayment_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentElement_CrtSupplyPayment_TerrasoftSaving", e);
			Updated += (s, e) => ThrowEvent("SupplyPaymentElement_CrtSupplyPayment_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentElement_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentElement_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentElement_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPayment_PassportEventsProcess<TEntity> where TEntity : SupplyPaymentElement_CrtSupplyPayment_Terrasoft
	{

		public SupplyPaymentElement_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentElement_CrtSupplyPaymentEventsProcess";
			SchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool DoNotUpdateLinkedElements {
			get;
			set;
		}

		public virtual bool NeedToUpdateInvoice {
			get;
			set;
		}

		public virtual bool NeedToUpdateOrderPaymentAmount {
			get;
			set;
		}

		public virtual bool IsInvoiceExists {
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

	#region Class: SupplyPaymentElement_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentElement_CrtSupplyPaymentEventsProcess : SupplyPaymentElement_CrtSupplyPaymentEventsProcess<SupplyPaymentElement_CrtSupplyPayment_Terrasoft>
	{

		public SupplyPaymentElement_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

