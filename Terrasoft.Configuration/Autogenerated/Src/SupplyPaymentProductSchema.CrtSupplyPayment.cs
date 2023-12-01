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

	#region Class: SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIEAmEqf7ATV6vIrwdnL77pY1qU8Index() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("91b1eed5-16d3-464e-a42f-16d2d62f4ada");
			index.Name = "IEAmEqf7ATV6vIrwdnL77pY1qU8";
			index.CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			index.ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			index.CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			EntitySchemaIndexColumn productIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("f3c008c4-8798-4f49-98ab-9e3a2bbd46a7"),
				ColumnUId = new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(productIdIndexColumn);
			EntitySchemaIndexColumn quantityIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0dc5296c-4960-4d49-a4ee-3553cb79be2f"),
				ColumnUId = new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(quantityIndexColumn);
			EntitySchemaIndexColumn supplyPaymentElementIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2deb8eea-7eed-4518-9339-6e788109f78a"),
				ColumnUId = new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba"),
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(supplyPaymentElementIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			RealUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			Name = "SupplyPaymentProduct_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("731b8372-cfda-441c-ba9f-f6659d7d51e1")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba")) == null) {
				Columns.Add(CreateSupplyPaymentElementColumn());
			}
			if (Columns.FindByUId(new Guid("df43e248-5619-4045-a7e0-6b6a29e9aad4")) == null) {
				Columns.Add(CreateBaseQuantityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ef3a26c-3aad-4cc7-9d86-6c8d152d26aa"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("1132d571-ee72-46ad-914f-4fb17dae6acd"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("731b8372-cfda-441c-ba9f-f6659d7d51e1"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("756bee7d-e59a-4e5c-a609-ab1475b575ba"),
				Name = @"SupplyPaymentElement",
				ReferenceSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("fb295fc3-2fbd-4310-9f4f-726412c4ea00")
			};
		}

		protected virtual EntitySchemaColumn CreateBaseQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float3")) {
				UId = new Guid("df43e248-5619-4045-a7e0-6b6a29e9aad4"),
				Name = @"BaseQuantity",
				CreatedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				ModifiedInSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				CreatedInPackageId = new Guid("efb45740-c35a-47f4-babf-491965306264")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIEAmEqf7ATV6vIrwdnL77pY1qU8Index());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentProduct_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentProduct_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentProduct_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentProduct_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Installment plan products.
	/// </summary>
	public class SupplyPaymentProduct_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SupplyPaymentProduct_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentProduct_CrtSupplyPayment_Terrasoft";
		}

		public SupplyPaymentProduct_CrtSupplyPayment_Terrasoft(SupplyPaymentProduct_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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
		public OrderProduct Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as OrderProduct);
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

		/// <exclude/>
		public Guid SupplyPaymentElementId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentElementId");
			}
			set {
				SetColumnValue("SupplyPaymentElementId", value);
				_supplyPaymentElement = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentElementName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentElementName");
			}
			set {
				SetColumnValue("SupplyPaymentElementName", value);
				if (_supplyPaymentElement != null) {
					_supplyPaymentElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _supplyPaymentElement;
		/// <summary>
		/// Installment plan element.
		/// </summary>
		public SupplyPaymentElement SupplyPaymentElement {
			get {
				return _supplyPaymentElement ??
					(_supplyPaymentElement = LookupColumnEntities.GetEntity("SupplyPaymentElement") as SupplyPaymentElement);
			}
		}

		/// <summary>
		/// Base quantity.
		/// </summary>
		public Decimal BaseQuantity {
			get {
				return GetTypedColumnValue<Decimal>("BaseQuantity");
			}
			set {
				SetColumnValue("BaseQuantity", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentProduct_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentProduct_CrtSupplyPayment_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("SupplyPaymentProduct_CrtSupplyPayment_TerrasoftDeleting", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentProduct_CrtSupplyPayment_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentProduct_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentProduct_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentProduct_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SupplyPaymentProduct_CrtSupplyPayment_Terrasoft
	{

		public SupplyPaymentProduct_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentProduct_CrtSupplyPaymentEventsProcess";
			SchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c");
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

	#region Class: SupplyPaymentProduct_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentProduct_CrtSupplyPaymentEventsProcess : SupplyPaymentProduct_CrtSupplyPaymentEventsProcess<SupplyPaymentProduct_CrtSupplyPayment_Terrasoft>
	{

		public SupplyPaymentProduct_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentProduct_CrtSupplyPaymentEventsProcess

	public partial class SupplyPaymentProduct_CrtSupplyPaymentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

