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

	#region Class: SysPrcElMIHistoryLogSchema

	/// <exclude/>
	public class SysPrcElMIHistoryLogSchema : Terrasoft.Configuration.SysPrcElMILogSchema
	{

		#region Constructors: Public

		public SysPrcElMIHistoryLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcElMIHistoryLogSchema(SysPrcElMIHistoryLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcElMIHistoryLogSchema(SysPrcElMIHistoryLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
			RealUId = new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
			Name = "SysPrcElMIHistoryLog";
			ParentSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIteratorElementColumn() {
			EntitySchemaColumn column = base.CreateIteratorElementColumn();
			column.IsCascade = false;
			column.ModifiedInSchemaUId = new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
			return column;
		}

		protected override EntitySchemaColumn CreatePartitionKeyColumn() {
			EntitySchemaColumn column = base.CreatePartitionKeyColumn();
			column.IsIndexed = false;
			column.ModifiedInSchemaUId = new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcElMIHistoryLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcElMIHistoryLog_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcElMIHistoryLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcElMIHistoryLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("648f3478-08c4-4399-942a-eb0e10f692bd"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMIHistoryLog

	/// <summary>
	/// Process element multi-instance history log.
	/// </summary>
	public class SysPrcElMIHistoryLog : Terrasoft.Configuration.SysPrcElMILog
	{

		#region Constructors: Public

		public SysPrcElMIHistoryLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcElMIHistoryLog";
		}

		public SysPrcElMIHistoryLog(SysPrcElMIHistoryLog source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcElMIHistoryLog_CrtBaseEventsProcess(UserConnection);
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
			return new SysPrcElMIHistoryLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMIHistoryLog_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysPrcElMIHistoryLog_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.SysPrcElMILog_CrtBaseEventsProcess<TEntity> where TEntity : SysPrcElMIHistoryLog
	{

		public SysPrcElMIHistoryLog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcElMIHistoryLog_CrtBaseEventsProcess";
			SchemaUId = new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("648f3478-08c4-4399-942a-eb0e10f692bd");
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

	#region Class: SysPrcElMIHistoryLog_CrtBaseEventsProcess

	/// <exclude/>
	public class SysPrcElMIHistoryLog_CrtBaseEventsProcess : SysPrcElMIHistoryLog_CrtBaseEventsProcess<SysPrcElMIHistoryLog>
	{

		public SysPrcElMIHistoryLog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcElMIHistoryLog_CrtBaseEventsProcess

	public partial class SysPrcElMIHistoryLog_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysPrcElMIHistoryLogEventsProcess

	/// <exclude/>
	public class SysPrcElMIHistoryLogEventsProcess : SysPrcElMIHistoryLog_CrtBaseEventsProcess
	{

		public SysPrcElMIHistoryLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

