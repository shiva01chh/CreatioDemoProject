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

	#region Class: SysPrcElHistoryLogSchema

	/// <exclude/>
	public class SysPrcElHistoryLogSchema : Terrasoft.Configuration.SysBasePrcElLogSchema
	{

		#region Constructors: Public

		public SysPrcElHistoryLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcElHistoryLogSchema(SysPrcElHistoryLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcElHistoryLogSchema(SysPrcElHistoryLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb76fc02-2956-4749-98f9-562581bceeb7");
			RealUId = new Guid("eb76fc02-2956-4749-98f9-562581bceeb7");
			Name = "SysPrcElHistoryLog";
			ParentSchemaUId = new Guid("293f3c3a-0dfb-4677-aa00-ac2a2628eaab");
			ExtendParent = false;
			CreatedInPackageId = new Guid("db484552-1edf-492e-83ab-076c107943f4");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("baa00dd8-03a7-4a3b-8818-9b2bc6c5e240")) == null) {
				Columns.Add(CreateSysProcessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("baa00dd8-03a7-4a3b-8818-9b2bc6c5e240"),
				Name = @"SysProcess",
				ReferenceSchemaUId = new Guid("c8cd120d-c91b-4104-bad0-88b1b892a49d"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("eb76fc02-2956-4749-98f9-562581bceeb7"),
				ModifiedInSchemaUId = new Guid("eb76fc02-2956-4749-98f9-562581bceeb7"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcElHistoryLog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcElHistoryLog_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcElHistoryLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcElHistoryLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb76fc02-2956-4749-98f9-562581bceeb7"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElHistoryLog

	/// <summary>
	/// System process element log history.
	/// </summary>
	public class SysPrcElHistoryLog : Terrasoft.Configuration.SysBasePrcElLog
	{

		#region Constructors: Public

		public SysPrcElHistoryLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcElHistoryLog";
		}

		public SysPrcElHistoryLog(SysPrcElHistoryLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysProcessId {
			get {
				return GetTypedColumnValue<Guid>("SysProcessId");
			}
			set {
				SetColumnValue("SysProcessId", value);
				_sysProcess = null;
			}
		}

		/// <exclude/>
		public string SysProcessName {
			get {
				return GetTypedColumnValue<string>("SysProcessName");
			}
			set {
				SetColumnValue("SysProcessName", value);
				if (_sysProcess != null) {
					_sysProcess.Name = value;
				}
			}
		}

		private SysPrcHistoryLog _sysProcess;
		/// <summary>
		/// Process instance.
		/// </summary>
		public SysPrcHistoryLog SysProcess {
			get {
				return _sysProcess ??
					(_sysProcess = LookupColumnEntities.GetEntity("SysProcess") as SysPrcHistoryLog);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcElHistoryLog_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPrcElHistoryLogDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPrcElHistoryLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElHistoryLog_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysPrcElHistoryLog_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.SysBasePrcElLog_CrtBaseEventsProcess<TEntity> where TEntity : SysPrcElHistoryLog
	{

		public SysPrcElHistoryLog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcElHistoryLog_CrtBaseEventsProcess";
			SchemaUId = new Guid("eb76fc02-2956-4749-98f9-562581bceeb7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eb76fc02-2956-4749-98f9-562581bceeb7");
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

	#region Class: SysPrcElHistoryLog_CrtBaseEventsProcess

	/// <exclude/>
	public class SysPrcElHistoryLog_CrtBaseEventsProcess : SysPrcElHistoryLog_CrtBaseEventsProcess<SysPrcElHistoryLog>
	{

		public SysPrcElHistoryLog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcElHistoryLog_CrtBaseEventsProcess

	public partial class SysPrcElHistoryLog_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysPrcElHistoryLogEventsProcess

	/// <exclude/>
	public class SysPrcElHistoryLogEventsProcess : SysPrcElHistoryLog_CrtBaseEventsProcess
	{

		public SysPrcElHistoryLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

