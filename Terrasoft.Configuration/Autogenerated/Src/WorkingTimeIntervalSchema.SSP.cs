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

	#region Class: WorkingTimeIntervalSchema

	/// <exclude/>
	public class WorkingTimeIntervalSchema : Terrasoft.Configuration.WorkingTimeInterval_Calendar_TerrasoftSchema
	{

		#region Constructors: Public

		public WorkingTimeIntervalSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WorkingTimeIntervalSchema(WorkingTimeIntervalSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WorkingTimeIntervalSchema(WorkingTimeIntervalSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("91c231df-16f8-4765-b4df-00bdd310ea00");
			Name = "WorkingTimeInterval";
			ParentSchemaUId = new Guid("3c971b13-45b1-49f4-af05-db8566668def");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
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
			return new WorkingTimeInterval(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WorkingTimeInterval_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WorkingTimeIntervalSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WorkingTimeIntervalSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91c231df-16f8-4765-b4df-00bdd310ea00"));
		}

		#endregion

	}

	#endregion

	#region Class: WorkingTimeInterval

	/// <summary>
	/// Working time intervals.
	/// </summary>
	public class WorkingTimeInterval : Terrasoft.Configuration.WorkingTimeInterval_Calendar_Terrasoft
	{

		#region Constructors: Public

		public WorkingTimeInterval(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WorkingTimeInterval";
		}

		public WorkingTimeInterval(WorkingTimeInterval source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WorkingTimeInterval_SSPEventsProcess(UserConnection);
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
			return new WorkingTimeInterval(this);
		}

		#endregion

	}

	#endregion

	#region Class: WorkingTimeInterval_SSPEventsProcess

	/// <exclude/>
	public partial class WorkingTimeInterval_SSPEventsProcess<TEntity> : Terrasoft.Configuration.WorkingTimeInterval_CalendarEventsProcess<TEntity> where TEntity : WorkingTimeInterval
	{

		public WorkingTimeInterval_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WorkingTimeInterval_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("91c231df-16f8-4765-b4df-00bdd310ea00");
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

	#region Class: WorkingTimeInterval_SSPEventsProcess

	/// <exclude/>
	public class WorkingTimeInterval_SSPEventsProcess : WorkingTimeInterval_SSPEventsProcess<WorkingTimeInterval>
	{

		public WorkingTimeInterval_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WorkingTimeInterval_SSPEventsProcess

	public partial class WorkingTimeInterval_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WorkingTimeIntervalEventsProcess

	/// <exclude/>
	public class WorkingTimeIntervalEventsProcess : WorkingTimeInterval_SSPEventsProcess
	{

		public WorkingTimeIntervalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

