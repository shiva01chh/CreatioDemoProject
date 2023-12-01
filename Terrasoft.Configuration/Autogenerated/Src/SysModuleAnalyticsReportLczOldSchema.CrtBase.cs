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

	#region Class: SysModuleAnalyticsReportLczOldSchema

	/// <exclude/>
	public class SysModuleAnalyticsReportLczOldSchema : Terrasoft.Configuration.BaseLczEntitySchema
	{

		#region Constructors: Public

		public SysModuleAnalyticsReportLczOldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysModuleAnalyticsReportLczOldSchema(SysModuleAnalyticsReportLczOldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysModuleAnalyticsReportLczOldSchema(SysModuleAnalyticsReportLczOldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083");
			RealUId = new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083");
			Name = "SysModuleAnalyticsReportLczOld";
			ParentSchemaUId = new Guid("b7cd8e8f-a017-4f73-b1fe-efb9e938e1d2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateRecordColumn() {
			EntitySchemaColumn column = base.CreateRecordColumn();
			column.ReferenceSchemaUId = new Guid("4198031e-41e4-461d-b124-f3ba771757c8");
			column.ColumnValueName = @"RecordId";
			column.DisplayColumnValueName = @"RecordCaption";
			column.ModifiedInSchemaUId = new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysModuleAnalyticsReportLczOld(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysModuleAnalyticsReportLczOldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysModuleAnalyticsReportLczOldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083"));
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleAnalyticsReportLczOld

	/// <summary>
	/// SysModuleAnalytics localization table.
	/// </summary>
	public class SysModuleAnalyticsReportLczOld : Terrasoft.Configuration.BaseLczEntity
	{

		#region Constructors: Public

		public SysModuleAnalyticsReportLczOld(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysModuleAnalyticsReportLczOld";
		}

		public SysModuleAnalyticsReportLczOld(SysModuleAnalyticsReportLczOld source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysModuleAnalyticsReportLczOldDeleted", e);
			Inserting += (s, e) => ThrowEvent("SysModuleAnalyticsReportLczOldInserting", e);
			Validating += (s, e) => ThrowEvent("SysModuleAnalyticsReportLczOldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleAnalyticsReportLczOld(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLczEntity_CrtBaseEventsProcess<TEntity> where TEntity : SysModuleAnalyticsReportLczOld
	{

		public SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess";
			SchemaUId = new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01909bb4-ae8c-4d3a-b199-079364f6a083");
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

	#region Class: SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess

	/// <exclude/>
	public class SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess : SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess<SysModuleAnalyticsReportLczOld>
	{

		public SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess

	public partial class SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysModuleAnalyticsReportLczOldEventsProcess

	/// <exclude/>
	public class SysModuleAnalyticsReportLczOldEventsProcess : SysModuleAnalyticsReportLczOld_CrtBaseEventsProcess
	{

		public SysModuleAnalyticsReportLczOldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

