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

	#region Class: VwInvoiceProductSchema

	/// <exclude/>
	public class VwInvoiceProductSchema : Terrasoft.Configuration.InvoiceProductSchema
	{

		#region Constructors: Public

		public VwInvoiceProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwInvoiceProductSchema(VwInvoiceProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwInvoiceProductSchema(VwInvoiceProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e048d6ec-0878-4123-a706-85d0326289a4");
			RealUId = new Guid("e048d6ec-0878-4123-a706-85d0326289a4");
			Name = "VwInvoiceProduct";
			ParentSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new VwInvoiceProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwInvoiceProduct_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwInvoiceProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwInvoiceProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e048d6ec-0878-4123-a706-85d0326289a4"));
		}

		#endregion

	}

	#endregion

	#region Class: VwInvoiceProduct

	/// <summary>
	/// Product in invoice (view).
	/// </summary>
	public class VwInvoiceProduct : Terrasoft.Configuration.InvoiceProduct
	{

		#region Constructors: Public

		public VwInvoiceProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwInvoiceProduct";
		}

		public VwInvoiceProduct(VwInvoiceProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwInvoiceProduct_InvoiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("VwInvoiceProductSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwInvoiceProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwInvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public partial class VwInvoiceProduct_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceProduct_PassportEventsProcess<TEntity> where TEntity : VwInvoiceProduct
	{

		public VwInvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwInvoiceProduct_InvoiceEventsProcess";
			SchemaUId = new Guid("e048d6ec-0878-4123-a706-85d0326289a4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e048d6ec-0878-4123-a706-85d0326289a4");
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

	#region Class: VwInvoiceProduct_InvoiceEventsProcess

	/// <exclude/>
	public class VwInvoiceProduct_InvoiceEventsProcess : VwInvoiceProduct_InvoiceEventsProcess<VwInvoiceProduct>
	{

		public VwInvoiceProduct_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwInvoiceProduct_InvoiceEventsProcess

	public partial class VwInvoiceProduct_InvoiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwInvoiceProductEventsProcess

	/// <exclude/>
	public class VwInvoiceProductEventsProcess : VwInvoiceProduct_InvoiceEventsProcess
	{

		public VwInvoiceProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

