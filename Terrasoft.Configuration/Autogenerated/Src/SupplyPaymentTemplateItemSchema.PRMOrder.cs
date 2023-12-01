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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SupplyPaymentTemplateItemSchema

	/// <exclude/>
	public class SupplyPaymentTemplateItemSchema : Terrasoft.Configuration.SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentTemplateItemSchema(SupplyPaymentTemplateItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentTemplateItemSchema(SupplyPaymentTemplateItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("44376ef8-2bce-4e7d-ad5c-af2b4f52bd70");
			Name = "SupplyPaymentTemplateItem";
			ParentSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e575b496-539f-4b26-8ba5-4be2dab7e3d9");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysSupplyPaymTemplItemLcz";
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
			return new SupplyPaymentTemplateItem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentTemplateItem_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentTemplateItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentTemplateItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("44376ef8-2bce-4e7d-ad5c-af2b4f52bd70"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem

	/// <summary>
	/// Installment plan template item.
	/// </summary>
	public class SupplyPaymentTemplateItem : Terrasoft.Configuration.SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentTemplateItem";
		}

		public SupplyPaymentTemplateItem(SupplyPaymentTemplateItem source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentTemplateItem_PRMOrderEventsProcess(UserConnection);
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
			return new SupplyPaymentTemplateItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_PRMOrderEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentTemplateItem_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess<TEntity> where TEntity : SupplyPaymentTemplateItem
	{

		public SupplyPaymentTemplateItem_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentTemplateItem_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("44376ef8-2bce-4e7d-ad5c-af2b4f52bd70");
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

	#region Class: SupplyPaymentTemplateItem_PRMOrderEventsProcess

	/// <exclude/>
	public class SupplyPaymentTemplateItem_PRMOrderEventsProcess : SupplyPaymentTemplateItem_PRMOrderEventsProcess<SupplyPaymentTemplateItem>
	{

		public SupplyPaymentTemplateItem_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_PRMOrderEventsProcess

	public partial class SupplyPaymentTemplateItem_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SupplyPaymentTemplateItemEventsProcess

	/// <exclude/>
	public class SupplyPaymentTemplateItemEventsProcess : SupplyPaymentTemplateItem_PRMOrderEventsProcess
	{

		public SupplyPaymentTemplateItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

