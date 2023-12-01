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

	#region Class: ProductUnitSchema

	/// <exclude/>
	public class ProductUnitSchema : Terrasoft.Configuration.ProductUnit_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductUnitSchema(ProductUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductUnitSchema(ProductUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("32d246c3-c14c-49ab-91d4-d409591a4aee");
			Name = "ProductUnit";
			ParentSchemaUId = new Guid("34e3e6a8-32c0-4451-9565-c295a9d8a089");
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
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductUnit(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductUnit_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32d246c3-c14c-49ab-91d4-d409591a4aee"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductUnit

	/// <summary>
	/// Product unit of measure.
	/// </summary>
	public class ProductUnit : Terrasoft.Configuration.ProductUnit_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public ProductUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductUnit";
		}

		public ProductUnit(ProductUnit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductUnit_PRMOrderEventsProcess(UserConnection);
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
			return new ProductUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductUnit_PRMOrderEventsProcess

	/// <exclude/>
	public partial class ProductUnit_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.ProductUnit_CrtProductCatalogueEventsProcess<TEntity> where TEntity : ProductUnit
	{

		public ProductUnit_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductUnit_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("32d246c3-c14c-49ab-91d4-d409591a4aee");
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

	#region Class: ProductUnit_PRMOrderEventsProcess

	/// <exclude/>
	public class ProductUnit_PRMOrderEventsProcess : ProductUnit_PRMOrderEventsProcess<ProductUnit>
	{

		public ProductUnit_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductUnit_PRMOrderEventsProcess

	public partial class ProductUnit_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductUnitEventsProcess

	/// <exclude/>
	public class ProductUnitEventsProcess : ProductUnit_PRMOrderEventsProcess
	{

		public ProductUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

