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

	#region Class: ProductFolderSchema

	/// <exclude/>
	public class ProductFolderSchema : Terrasoft.Configuration.ProductFolder_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ProductFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductFolderSchema(ProductFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductFolderSchema(ProductFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2b904806-96bf-4c41-8e4f-646138412be7");
			Name = "ProductFolder";
			ParentSchemaUId = new Guid("4c1f5748-24fe-4226-bd13-df099094c0e5");
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
			return new ProductFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductFolder_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b904806-96bf-4c41-8e4f-646138412be7"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductFolder

	/// <summary>
	/// Product folder.
	/// </summary>
	public class ProductFolder : Terrasoft.Configuration.ProductFolder_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ProductFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductFolder";
		}

		public ProductFolder(ProductFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductFolder_PRMOrderEventsProcess(UserConnection);
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
			return new ProductFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductFolder_PRMOrderEventsProcess

	/// <exclude/>
	public partial class ProductFolder_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.ProductFolder_CrtBaseEventsProcess<TEntity> where TEntity : ProductFolder
	{

		public ProductFolder_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductFolder_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2b904806-96bf-4c41-8e4f-646138412be7");
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

	#region Class: ProductFolder_PRMOrderEventsProcess

	/// <exclude/>
	public class ProductFolder_PRMOrderEventsProcess : ProductFolder_PRMOrderEventsProcess<ProductFolder>
	{

		public ProductFolder_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProductFolder_PRMOrderEventsProcess

	public partial class ProductFolder_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProductFolderEventsProcess

	/// <exclude/>
	public class ProductFolderEventsProcess : ProductFolder_PRMOrderEventsProcess
	{

		public ProductFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

