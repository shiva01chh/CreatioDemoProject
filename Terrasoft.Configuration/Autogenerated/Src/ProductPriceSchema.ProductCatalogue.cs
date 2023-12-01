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

	#region Class: ProductPrice_ProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductPrice_ProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.ProductPrice_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductPrice_ProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductPrice_ProductCatalogue_TerrasoftSchema(ProductPrice_ProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductPrice_ProductCatalogue_TerrasoftSchema(ProductPrice_ProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f");
			Name = "ProductPrice_ProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("80d7a7d4-dc00-406c-908d-df0ae7330359");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateCurrencyColumn() {
			EntitySchemaColumn column = base.CreateCurrencyColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"PrimaryCurrency"
			};
			column.ModifiedInSchemaUId = new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultTax"
			};
			column.ModifiedInSchemaUId = new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f");
			return column;
		}

		protected override EntitySchemaColumn CreatePriceListColumn() {
			EntitySchemaColumn column = base.CreatePriceListColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"BasePriceList"
			};
			column.ModifiedInSchemaUId = new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductPrice_ProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductPrice_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductPrice_ProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductPrice_ProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogue_Terrasoft

	/// <summary>
	/// Product price.
	/// </summary>
	public class ProductPrice_ProductCatalogue_Terrasoft : Terrasoft.Configuration.ProductPrice_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductPrice_ProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductPrice_ProductCatalogue_Terrasoft";
		}

		public ProductPrice_ProductCatalogue_Terrasoft(ProductPrice_ProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductPrice_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("ProductPrice_ProductCatalogue_TerrasoftSaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductPrice_ProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductPrice_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.ProductPrice_CrtProductCatalogueEventsProcess<TEntity> where TEntity : ProductPrice_ProductCatalogue_Terrasoft
	{

		public ProductPrice_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductPrice_ProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e35edf5a-f837-47c9-8bff-880fceb03f4f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_cca63a14c7df43018186618338a215ba;
		public ProcessFlowElement EventSubProcess3_cca63a14c7df43018186618338a215ba {
			get {
				return _eventSubProcess3_cca63a14c7df43018186618338a215ba ?? (_eventSubProcess3_cca63a14c7df43018186618338a215ba = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_cca63a14c7df43018186618338a215ba",
					SchemaElementUId = new Guid("cca63a14-c7df-4301-8186-618338a215ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_1f1ecfdc71f44b04b87c78b6b8d73508;
		public ProcessFlowElement StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508 {
			get {
				return _startMessage3_1f1ecfdc71f44b04b87c78b6b8d73508 ?? (_startMessage3_1f1ecfdc71f44b04b87c78b6b8d73508 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508",
					SchemaElementUId = new Guid("1f1ecfdc-71f4-4b04-b87c-78b6b8d73508"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actulizePriceInProduct;
		public ProcessScriptTask ActulizePriceInProduct {
			get {
				return _actulizePriceInProduct ?? (_actulizePriceInProduct = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActulizePriceInProduct",
					SchemaElementUId = new Guid("b619bbf7-cb4a-4965-828f-43280316506a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActulizePriceInProductExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_cca63a14c7df43018186618338a215ba.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_cca63a14c7df43018186618338a215ba };
			FlowElements[StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508 };
			FlowElements[ActulizePriceInProduct.SchemaElementUId] = new Collection<ProcessFlowElement> { ActulizePriceInProduct };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_cca63a14c7df43018186618338a215ba":
						break;
					case "StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508":
						e.Context.QueueTasks.Enqueue("ActulizePriceInProduct");
						break;
					case "ActulizePriceInProduct":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_cca63a14c7df43018186618338a215ba":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508";
					result = StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508.Execute(context);
					break;
				case "ActulizePriceInProduct":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActulizePriceInProduct";
					result = ActulizePriceInProduct.Execute(context, ActulizePriceInProductExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ActulizePriceInProductExecute(ProcessExecutingContext context) {
			var productPriceHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.ProductPriceHelper>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			productPriceHelper.SetPriceInProduct(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProductPrice_ProductCatalogue_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508")) {
							context.QueueTasks.Enqueue("StartMessage3_1f1ecfdc71f44b04b87c78b6b8d73508");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductPrice_ProductCatalogueEventsProcess : ProductPrice_ProductCatalogueEventsProcess<ProductPrice_ProductCatalogue_Terrasoft>
	{

		public ProductPrice_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductPrice_ProductCatalogueEventsProcess

	public partial class ProductPrice_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

