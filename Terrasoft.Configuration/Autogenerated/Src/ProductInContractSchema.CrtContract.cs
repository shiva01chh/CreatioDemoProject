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

	#region Class: ProductInContractSchema

	/// <exclude/>
	public class ProductInContractSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProductInContractSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductInContractSchema(ProductInContractSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductInContractSchema(ProductInContractSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a");
			RealUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a");
			Name = "ProductInContract";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5fa83551-0fe2-6602-6050-572e07b02df4")) == null) {
				Columns.Add(CreateContractColumn());
			}
			if (Columns.FindByUId(new Guid("efcd93e3-71a8-8f47-018d-2901d4c996bd")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("222a11ae-cffc-23a0-de38-0282a0760a5c")) == null) {
				Columns.Add(CreateCurrencyColumn());
			}
			if (Columns.FindByUId(new Guid("ebe30865-2f9c-3180-a5a1-40e7fec69251")) == null) {
				Columns.Add(CreateTotalColumn());
			}
			if (Columns.FindByUId(new Guid("57ed9400-0efb-fab1-ad16-932a5227add7")) == null) {
				Columns.Add(CreateDiscountAmountColumn());
			}
			if (Columns.FindByUId(new Guid("8444d3f6-b27c-5aaa-4177-e96be916168e")) == null) {
				Columns.Add(CreateDiscountPercentColumn());
			}
			if (Columns.FindByUId(new Guid("3706a696-b414-45d1-971d-691dbfe3cf70")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("8cd5448f-3a69-c094-e653-d927b3d4d61b")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("40fc21e1-b803-379c-6e3b-a6c78d20d620")) == null) {
				Columns.Add(CreateUnitOfMeasureColumn());
			}
			if (Columns.FindByUId(new Guid("279d274b-b589-db71-4c9d-2116ce558ccf")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5fa83551-0fe2-6602-6050-572e07b02df4"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("efcd93e3-71a8-8f47-018d-2901d4c996bd"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateCurrencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("222a11ae-cffc-23a0-de38-0282a0760a5c"),
				Name = @"Currency",
				ReferenceSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateTotalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ebe30865-2f9c-3180-a5a1-40e7fec69251"),
				Name = @"Total",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("57ed9400-0efb-fab1-ad16-932a5227add7"),
				Name = @"DiscountAmount",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8444d3f6-b27c-5aaa-4177-e96be916168e"),
				Name = @"DiscountPercent",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("3706a696-b414-45d1-971d-691dbfe3cf70"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8cd5448f-3a69-c094-e653-d927b3d4d61b"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateUnitOfMeasureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("40fc21e1-b803-379c-6e3b-a6c78d20d620"),
				Name = @"UnitOfMeasure",
				ReferenceSchemaUId = new Guid("38f2220e-7085-494d-b4c9-396666b6327b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("279d274b-b589-db71-4c9d-2116ce558ccf"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				ModifiedInSchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"),
				CreatedInPackageId = new Guid("75cfd642-84c8-4c3b-b7a7-376107064097")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductInContract(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductInContract_CrtContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductInContractSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductInContractSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductInContract

	/// <summary>
	/// Product in contract.
	/// </summary>
	public class ProductInContract : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProductInContract(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductInContract";
		}

		public ProductInContract(ProductInContract source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
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

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
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
		/// Total.
		/// </summary>
		public Decimal Total {
			get {
				return GetTypedColumnValue<Decimal>("Total");
			}
			set {
				SetColumnValue("Total", value);
			}
		}

		/// <summary>
		/// Discount amount.
		/// </summary>
		public Decimal DiscountAmount {
			get {
				return GetTypedColumnValue<Decimal>("DiscountAmount");
			}
			set {
				SetColumnValue("DiscountAmount", value);
			}
		}

		/// <summary>
		/// Discount, %.
		/// </summary>
		public Decimal DiscountPercent {
			get {
				return GetTypedColumnValue<Decimal>("DiscountPercent");
			}
			set {
				SetColumnValue("DiscountPercent", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
			}
		}

		/// <exclude/>
		public Guid UnitOfMeasureId {
			get {
				return GetTypedColumnValue<Guid>("UnitOfMeasureId");
			}
			set {
				SetColumnValue("UnitOfMeasureId", value);
				_unitOfMeasure = null;
			}
		}

		/// <exclude/>
		public string UnitOfMeasureName {
			get {
				return GetTypedColumnValue<string>("UnitOfMeasureName");
			}
			set {
				SetColumnValue("UnitOfMeasureName", value);
				if (_unitOfMeasure != null) {
					_unitOfMeasure.Name = value;
				}
			}
		}

		private Unit _unitOfMeasure;
		/// <summary>
		/// Unit of measure.
		/// </summary>
		public Unit UnitOfMeasure {
			get {
				return _unitOfMeasure ??
					(_unitOfMeasure = LookupColumnEntities.GetEntity("UnitOfMeasure") as Unit);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal Quantity {
			get {
				return GetTypedColumnValue<Decimal>("Quantity");
			}
			set {
				SetColumnValue("Quantity", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductInContract_CrtContractEventsProcess(UserConnection);
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
			return new ProductInContract(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductInContract_CrtContractEventsProcess

	/// <exclude/>
	public partial class ProductInContract_CrtContractEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProductInContract
	{

		public ProductInContract_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductInContract_CrtContractEventsProcess";
			SchemaUId = new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7282bb3d-b183-4087-bed8-2252d0534b1a");
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

	#region Class: ProductInContract_CrtContractEventsProcess

	/// <exclude/>
	public class ProductInContract_CrtContractEventsProcess : ProductInContract_CrtContractEventsProcess<ProductInContract>
	{

		public ProductInContract_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductInContract_CrtContractEventsProcess

	public partial class ProductInContract_CrtContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductInContractEventsProcess

	/// <exclude/>
	public class ProductInContractEventsProcess : ProductInContract_CrtContractEventsProcess
	{

		public ProductInContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

