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

	#region Class: SysPrcElMILogSchema

	/// <exclude/>
	public class SysPrcElMILogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPrcElMILogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPrcElMILogSchema(SysPrcElMILogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPrcElMILogSchema(SysPrcElMILogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			RealUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			Name = "SysPrcElMILog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			if (Columns.FindByUId(new Guid("b788f8e4-0aed-4f5f-b65a-7202fcaec1b6")) == null) {
				Columns.Add(CreateIteratorElementColumn());
			}
			if (Columns.FindByUId(new Guid("0ebca3d7-31cf-450c-b731-4e86ce1c81c0")) == null) {
				Columns.Add(CreateIterationNumberColumn());
			}
			if (Columns.FindByUId(new Guid("82084063-988c-aa0d-440b-1e3d8ffed292")) == null) {
				Columns.Add(CreatePartitionKeyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIteratorElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b788f8e4-0aed-4f5f-b65a-7202fcaec1b6"),
				Name = @"IteratorElement",
				ReferenceSchemaUId = new Guid("ff6c1cb5-16bf-4f8c-adc8-64c0b7762151"),
				IsIndexed = true,
				IsWeakReference = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				ModifiedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f")
			};
		}

		protected virtual EntitySchemaColumn CreateIterationNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0ebca3d7-31cf-450c-b731-4e86ce1c81c0"),
				Name = @"IterationNumber",
				CreatedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				ModifiedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f")
			};
		}

		protected virtual EntitySchemaColumn CreatePartitionKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("82084063-988c-aa0d-440b-1e3d8ffed292"),
				Name = @"PartitionKey",
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				ModifiedInSchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				IsNullable = false,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPrcElMILog(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPrcElMILog_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPrcElMILogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPrcElMILogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMILog

	/// <summary>
	/// Process multi-instance element log.
	/// </summary>
	public class SysPrcElMILog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPrcElMILog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPrcElMILog";
		}

		public SysPrcElMILog(SysPrcElMILog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid IteratorElementId {
			get {
				return GetTypedColumnValue<Guid>("IteratorElementId");
			}
			set {
				SetColumnValue("IteratorElementId", value);
				_iteratorElement = null;
			}
		}

		/// <exclude/>
		public string IteratorElementCaption {
			get {
				return GetTypedColumnValue<string>("IteratorElementCaption");
			}
			set {
				SetColumnValue("IteratorElementCaption", value);
				if (_iteratorElement != null) {
					_iteratorElement.Caption = value;
				}
			}
		}

		private SysProcessElementLog _iteratorElement;
		/// <summary>
		/// IteratorElement.
		/// </summary>
		public SysProcessElementLog IteratorElement {
			get {
				return _iteratorElement ??
					(_iteratorElement = LookupColumnEntities.GetEntity("IteratorElement") as SysProcessElementLog);
			}
		}

		/// <summary>
		/// IterationNumber.
		/// </summary>
		public int IterationNumber {
			get {
				return GetTypedColumnValue<int>("IterationNumber");
			}
			set {
				SetColumnValue("IterationNumber", value);
			}
		}

		/// <summary>
		/// Partition key.
		/// </summary>
		public DateTime PartitionKey {
			get {
				return GetTypedColumnValue<DateTime>("PartitionKey");
			}
			set {
				SetColumnValue("PartitionKey", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPrcElMILog_CrtBaseEventsProcess(UserConnection);
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
			return new SysPrcElMILog(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPrcElMILog_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysPrcElMILog_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysPrcElMILog
	{

		public SysPrcElMILog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPrcElMILog_CrtBaseEventsProcess";
			SchemaUId = new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6972f5f1-c1ae-424d-9c78-c66029e5bb1d");
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

	#region Class: SysPrcElMILog_CrtBaseEventsProcess

	/// <exclude/>
	public class SysPrcElMILog_CrtBaseEventsProcess : SysPrcElMILog_CrtBaseEventsProcess<SysPrcElMILog>
	{

		public SysPrcElMILog_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPrcElMILog_CrtBaseEventsProcess

	public partial class SysPrcElMILog_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysPrcElMILogEventsProcess

	/// <exclude/>
	public class SysPrcElMILogEventsProcess : SysPrcElMILog_CrtBaseEventsProcess
	{

		public SysPrcElMILogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

