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

	#region Class: InvoicePaymentStatusSchema

	/// <exclude/>
	public class InvoicePaymentStatusSchema : Terrasoft.Configuration.InvoicePaymentStatus_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoicePaymentStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoicePaymentStatusSchema(InvoicePaymentStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoicePaymentStatusSchema(InvoicePaymentStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("885d9772-2452-460d-a415-5bba5bcd7cd4");
			Name = "InvoicePaymentStatus";
			ParentSchemaUId = new Guid("4a75f63d-e1b2-453b-a19d-fe614c158861");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
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
			return new InvoicePaymentStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoicePaymentStatus_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoicePaymentStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoicePaymentStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("885d9772-2452-460d-a415-5bba5bcd7cd4"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus

	/// <summary>
	/// Invoice payment status.
	/// </summary>
	public class InvoicePaymentStatus : Terrasoft.Configuration.InvoicePaymentStatus_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoicePaymentStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoicePaymentStatus";
		}

		public InvoicePaymentStatus(InvoicePaymentStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoicePaymentStatus_PRMPortalEventsProcess(UserConnection);
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
			return new InvoicePaymentStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoicePaymentStatus_PRMPortalEventsProcess

	/// <exclude/>
	public partial class InvoicePaymentStatus_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.InvoicePaymentStatus_CrtInvoiceEventsProcess<TEntity> where TEntity : InvoicePaymentStatus
	{

		public InvoicePaymentStatus_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoicePaymentStatus_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("885d9772-2452-460d-a415-5bba5bcd7cd4");
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

	#region Class: InvoicePaymentStatus_PRMPortalEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatus_PRMPortalEventsProcess : InvoicePaymentStatus_PRMPortalEventsProcess<InvoicePaymentStatus>
	{

		public InvoicePaymentStatus_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoicePaymentStatus_PRMPortalEventsProcess

	public partial class InvoicePaymentStatus_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: InvoicePaymentStatusEventsProcess

	/// <exclude/>
	public class InvoicePaymentStatusEventsProcess : InvoicePaymentStatus_PRMPortalEventsProcess
	{

		public InvoicePaymentStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

