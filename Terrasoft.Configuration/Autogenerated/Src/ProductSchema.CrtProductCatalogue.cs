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

	#region Class: Product_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class Product_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.Product_ProductBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_CrtProductCatalogue_TerrasoftSchema(Product_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_CrtProductCatalogue_TerrasoftSchema(Product_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
			Name = "Product_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("84c5953d-e261-449e-9189-8fac859db36d")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("bc105fcf-3068-4525-9c22-efc1942262cd")) == null) {
				Columns.Add(CreateTradeMarkColumn());
			}
			if (Columns.FindByUId(new Guid("a1f91e7a-b322-de8c-9482-373b7cf109e1")) == null) {
				Columns.Add(CreateGeneralConditionsColumn());
			}
		}

		protected override EntitySchemaColumn CreateCurrencyColumn() {
			EntitySchemaColumn column = base.CreateCurrencyColumn();
			column.ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
			return column;
		}

		protected override EntitySchemaColumn CreateOwnerColumn() {
			EntitySchemaColumn column = base.CreateOwnerColumn();
			column.ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
			return column;
		}

		protected override EntitySchemaColumn CreateProductSourceColumn() {
			EntitySchemaColumn column = base.CreateProductSourceColumn();
			column.ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("84c5953d-e261-449e-9189-8fac859db36d"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected virtual EntitySchemaColumn CreateTradeMarkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc105fcf-3068-4525-9c22-efc1942262cd"),
				Name = @"TradeMark",
				ReferenceSchemaUId = new Guid("d1084b21-51c3-4fb4-b8b8-158895fbdebc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected virtual EntitySchemaColumn CreateGeneralConditionsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1f91e7a-b322-de8c-9482-373b7cf109e1"),
				Name = @"GeneralConditions",
				CreatedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				ModifiedInSchemaUId = new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"),
				CreatedInPackageId = new Guid("6a5e4b1f-f47c-4cd7-9331-5bb1381386bb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.Product_ProductBase_Terrasoft
	{

		#region Constructors: Public

		public Product_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_CrtProductCatalogue_Terrasoft";
		}

		public Product_CrtProductCatalogue_Terrasoft(Product_CrtProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private ProductCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public ProductCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as ProductCategory);
			}
		}

		/// <exclude/>
		public Guid TradeMarkId {
			get {
				return GetTypedColumnValue<Guid>("TradeMarkId");
			}
			set {
				SetColumnValue("TradeMarkId", value);
				_tradeMark = null;
			}
		}

		/// <exclude/>
		public string TradeMarkName {
			get {
				return GetTypedColumnValue<string>("TradeMarkName");
			}
			set {
				SetColumnValue("TradeMarkName", value);
				if (_tradeMark != null) {
					_tradeMark.Name = value;
				}
			}
		}

		private TradeMark _tradeMark;
		/// <summary>
		/// Brand.
		/// </summary>
		public TradeMark TradeMark {
			get {
				return _tradeMark ??
					(_tradeMark = LookupColumnEntities.GetEntity("TradeMark") as TradeMark);
			}
		}

		/// <summary>
		/// General conditions.
		/// </summary>
		public string GeneralConditions {
			get {
				return GetTypedColumnValue<string>("GeneralConditions");
			}
			set {
				SetColumnValue("GeneralConditions", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Product_CrtProductCatalogue_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Product_CrtProductCatalogue_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("Product_CrtProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class Product_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.Product_ProductBaseEventsProcess<TEntity> where TEntity : Product_CrtProductCatalogue_Terrasoft
	{

		public Product_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_CrtProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2e35eeb-1d87-4ce0-b885-c3a8c6c23bd2");
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

	#region Class: Product_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class Product_CrtProductCatalogueEventsProcess : Product_CrtProductCatalogueEventsProcess<Product_CrtProductCatalogue_Terrasoft>
	{

		public Product_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_CrtProductCatalogueEventsProcess

	public partial class Product_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

