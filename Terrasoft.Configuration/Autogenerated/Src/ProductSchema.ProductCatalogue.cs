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

	#region Class: Product_ProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class Product_ProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.Product_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_ProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_ProductCatalogue_TerrasoftSchema(Product_ProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_ProductCatalogue_TerrasoftSchema(Product_ProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("51a694af-050b-4609-8757-e1dfaab9273d");
			Name = "Product_ProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_ProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_ProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_ProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51a694af-050b-4609-8757-e1dfaab9273d"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogue_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_ProductCatalogue_Terrasoft : Terrasoft.Configuration.Product_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public Product_ProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_ProductCatalogue_Terrasoft";
		}

		public Product_ProductCatalogue_Terrasoft(Product_ProductCatalogue_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Product_ProductCatalogue_TerrasoftSaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_ProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class Product_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.Product_CrtProductCatalogueEventsProcess<TEntity> where TEntity : Product_ProductCatalogue_Terrasoft
	{

		public Product_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_ProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("51a694af-050b-4609-8757-e1dfaab9273d");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b;
		public ProcessFlowElement EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b {
			get {
				return _eventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b ?? (_eventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b",
					SchemaElementUId = new Guid("5fadd88f-4b88-4895-9ed1-fc20dc773a3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_c57abdd6488142989fa866b5d4b6bf92;
		public ProcessFlowElement StartMessage3_c57abdd6488142989fa866b5d4b6bf92 {
			get {
				return _startMessage3_c57abdd6488142989fa866b5d4b6bf92 ?? (_startMessage3_c57abdd6488142989fa866b5d4b6bf92 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_c57abdd6488142989fa866b5d4b6bf92",
					SchemaElementUId = new Guid("c57abdd6-4881-4298-9fa8-66b5d4b6bf92"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setPrices;
		public ProcessScriptTask SetPrices {
			get {
				return _setPrices ?? (_setPrices = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetPrices",
					SchemaElementUId = new Guid("af2d7489-c4f3-4fcc-acb7-5355cbf65e3c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetPricesExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b };
			FlowElements[StartMessage3_c57abdd6488142989fa866b5d4b6bf92.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_c57abdd6488142989fa866b5d4b6bf92 };
			FlowElements[SetPrices.SchemaElementUId] = new Collection<ProcessFlowElement> { SetPrices };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b":
						break;
					case "StartMessage3_c57abdd6488142989fa866b5d4b6bf92":
						e.Context.QueueTasks.Enqueue("SetPrices");
						break;
					case "SetPrices":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_c57abdd6488142989fa866b5d4b6bf92");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_5fadd88f4b8848959ed1fc20dc773a3b":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_c57abdd6488142989fa866b5d4b6bf92":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_c57abdd6488142989fa866b5d4b6bf92";
					result = StartMessage3_c57abdd6488142989fa866b5d4b6bf92.Execute(context);
					break;
				case "SetPrices":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetPrices";
					result = SetPrices.Execute(context, SetPricesExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool SetPricesExecute(ProcessExecutingContext context) {
			var productPriceHelper = Terrasoft.Core.Factories.ClassFactory.Get<Terrasoft.Configuration.ProductPriceHelper>(
				new Terrasoft.Core.Factories.ConstructorArgument("userConnection", UserConnection));
			productPriceHelper.SetPriceInBasePriceList(Entity);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Product_ProductCatalogue_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_c57abdd6488142989fa866b5d4b6bf92")) {
							context.QueueTasks.Enqueue("StartMessage3_c57abdd6488142989fa866b5d4b6bf92");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Product_ProductCatalogueEventsProcess

	/// <exclude/>
	public class Product_ProductCatalogueEventsProcess : Product_ProductCatalogueEventsProcess<Product_ProductCatalogue_Terrasoft>
	{

		public Product_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_ProductCatalogueEventsProcess

	public partial class Product_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

