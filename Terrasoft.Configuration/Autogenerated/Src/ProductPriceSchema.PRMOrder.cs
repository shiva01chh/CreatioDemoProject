﻿namespace Terrasoft.Configuration
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

	#region Class: ProductPriceSchema

	/// <exclude/>
	public class ProductPriceSchema : Terrasoft.Configuration.ProductPrice_ProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductPriceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductPriceSchema(ProductPriceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductPriceSchema(ProductPriceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c63e97c9-4809-412f-985d-faf9dc0b8802");
			Name = "ProductPrice";
			ParentSchemaUId = new Guid("dd9a991c-01a6-44f1-b1ae-ebaf75800ee3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e575b496-539f-4b26-8ba5-4be2dab7e3d9");
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
			return new ProductPrice(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductPrice_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductPriceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductPriceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c63e97c9-4809-412f-985d-faf9dc0b8802"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice

	/// <summary>
	/// Product price.
	/// </summary>
	public class ProductPrice : Terrasoft.Configuration.ProductPrice_ProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductPrice(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductPrice";
		}

		public ProductPrice(ProductPrice source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductPrice_PRMOrderEventsProcess(UserConnection);
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
			return new ProductPrice(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductPrice_PRMOrderEventsProcess

	/// <exclude/>
	public partial class ProductPrice_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.ProductPrice_ProductCatalogueEventsProcess<TEntity> where TEntity : ProductPrice
	{

		public ProductPrice_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductPrice_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c63e97c9-4809-412f-985d-faf9dc0b8802");
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

	#region Class: ProductPrice_PRMOrderEventsProcess

	/// <exclude/>
	public class ProductPrice_PRMOrderEventsProcess : ProductPrice_PRMOrderEventsProcess<ProductPrice>
	{

		public ProductPrice_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductPrice_PRMOrderEventsProcess

	public partial class ProductPrice_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductPriceEventsProcess

	/// <exclude/>
	public class ProductPriceEventsProcess : ProductPrice_PRMOrderEventsProcess
	{

		public ProductPriceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

