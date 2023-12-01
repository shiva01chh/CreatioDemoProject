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

	#region Class: ProductCatalogueLevelSchema

	/// <exclude/>
	public class ProductCatalogueLevelSchema : Terrasoft.Configuration.ProductCatalogueLevel_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductCatalogueLevelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductCatalogueLevelSchema(ProductCatalogueLevelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductCatalogueLevelSchema(ProductCatalogueLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("036f12ca-d0e4-4668-912a-fc1d84d92f9f");
			Name = "ProductCatalogueLevel";
			ParentSchemaUId = new Guid("dd60b9fc-c62f-4edc-b44f-37465de2e45b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("80d7a7d4-dc00-406c-908d-df0ae7330359");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new ProductCatalogueLevel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductCatalogueLevel_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductCatalogueLevelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductCatalogueLevelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("036f12ca-d0e4-4668-912a-fc1d84d92f9f"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel

	/// <summary>
	/// Product catalog level.
	/// </summary>
	public class ProductCatalogueLevel : Terrasoft.Configuration.ProductCatalogueLevel_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductCatalogueLevel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductCatalogueLevel";
		}

		public ProductCatalogueLevel(ProductCatalogueLevel source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("ProductCatalogueLevelDeleting", e);
			Inserting += (s, e) => ThrowEvent("ProductCatalogueLevelInserting", e);
			Saving += (s, e) => ThrowEvent("ProductCatalogueLevelSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductCatalogueLevel(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductCatalogueLevel_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.ProductCatalogueLevel_CrtProductCatalogueEventsProcess<TEntity> where TEntity : ProductCatalogueLevel
	{

		public ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductCatalogueLevel_ProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("036f12ca-d0e4-4668-912a-fc1d84d92f9f");
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

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevel_ProductCatalogueEventsProcess : ProductCatalogueLevel_ProductCatalogueEventsProcess<ProductCatalogueLevel>
	{

		public ProductCatalogueLevel_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductCatalogueLevel_ProductCatalogueEventsProcess

	public partial class ProductCatalogueLevel_ProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductCatalogueLevelEventsProcess

	/// <exclude/>
	public class ProductCatalogueLevelEventsProcess : ProductCatalogueLevel_ProductCatalogueEventsProcess
	{

		public ProductCatalogueLevelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

