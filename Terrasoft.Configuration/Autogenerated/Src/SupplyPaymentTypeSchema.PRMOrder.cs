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

	#region Class: SupplyPaymentTypeSchema

	/// <exclude/>
	public class SupplyPaymentTypeSchema : Terrasoft.Configuration.SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentTypeSchema(SupplyPaymentTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentTypeSchema(SupplyPaymentTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5ca69d3f-d9a8-4148-ab01-250e088319f6");
			Name = "SupplyPaymentType";
			ParentSchemaUId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
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
			return new SupplyPaymentType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentType_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ca69d3f-d9a8-4148-ab01-250e088319f6"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentType

	/// <summary>
	/// Installment plan item type.
	/// </summary>
	public class SupplyPaymentType : Terrasoft.Configuration.SupplyPaymentType_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public SupplyPaymentType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentType";
		}

		public SupplyPaymentType(SupplyPaymentType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentType_PRMOrderEventsProcess(UserConnection);
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
			return new SupplyPaymentType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentType_PRMOrderEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentType_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPaymentType_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : SupplyPaymentType
	{

		public SupplyPaymentType_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentType_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ca69d3f-d9a8-4148-ab01-250e088319f6");
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

	#region Class: SupplyPaymentType_PRMOrderEventsProcess

	/// <exclude/>
	public class SupplyPaymentType_PRMOrderEventsProcess : SupplyPaymentType_PRMOrderEventsProcess<SupplyPaymentType>
	{

		public SupplyPaymentType_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentType_PRMOrderEventsProcess

	public partial class SupplyPaymentType_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SupplyPaymentTypeEventsProcess

	/// <exclude/>
	public class SupplyPaymentTypeEventsProcess : SupplyPaymentType_PRMOrderEventsProcess
	{

		public SupplyPaymentTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

