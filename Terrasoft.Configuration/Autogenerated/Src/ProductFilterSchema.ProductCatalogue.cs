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

	#region Class: ProductFilterSchema

	/// <exclude/>
	public class ProductFilterSchema : Terrasoft.Configuration.ProductFilter_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductFilterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductFilterSchema(ProductFilterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductFilterSchema(ProductFilterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("94f0d498-5a3c-42c2-8759-aff82536ae6b");
			Name = "ProductFilter";
			ParentSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
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
			return new ProductFilter(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductFilter_ProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductFilterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductFilterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94f0d498-5a3c-42c2-8759-aff82536ae6b"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter

	/// <summary>
	/// Product filter.
	/// </summary>
	public class ProductFilter : Terrasoft.Configuration.ProductFilter_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductFilter";
		}

		public ProductFilter(ProductFilter source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductFilter_ProductCatalogueEventsProcess(UserConnection);
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
			return new ProductFilter(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductFilter_ProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.ProductFilter_CrtProductCatalogueEventsProcess<TEntity> where TEntity : ProductFilter
	{

		public ProductFilter_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductFilter_ProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("94f0d498-5a3c-42c2-8759-aff82536ae6b");
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

	#region Class: ProductFilter_ProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductFilter_ProductCatalogueEventsProcess : ProductFilter_ProductCatalogueEventsProcess<ProductFilter>
	{

		public ProductFilter_ProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: ProductFilterEventsProcess

	/// <exclude/>
	public class ProductFilterEventsProcess : ProductFilter_ProductCatalogueEventsProcess
	{

		public ProductFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

