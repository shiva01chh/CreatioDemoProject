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

	#region Class: CalendarSchema

	/// <exclude/>
	public class CalendarSchema : Terrasoft.Configuration.Calendar_Calendar_TerrasoftSchema
	{

		#region Constructors: Public

		public CalendarSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CalendarSchema(CalendarSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CalendarSchema(CalendarSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6ae193e1-dcfe-4fe7-aeaa-b8b288a109dd");
			Name = "Calendar";
			ParentSchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64");
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
			return new Calendar(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Calendar_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CalendarSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CalendarSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ae193e1-dcfe-4fe7-aeaa-b8b288a109dd"));
		}

		#endregion

	}

	#endregion

	#region Class: Calendar

	/// <summary>
	/// Calendar.
	/// </summary>
	public class Calendar : Terrasoft.Configuration.Calendar_Calendar_Terrasoft
	{

		#region Constructors: Public

		public Calendar(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Calendar";
		}

		public Calendar(Calendar source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Calendar_SSPEventsProcess(UserConnection);
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
			return new Calendar(this);
		}

		#endregion

	}

	#endregion

	#region Class: Calendar_SSPEventsProcess

	/// <exclude/>
	public partial class Calendar_SSPEventsProcess<TEntity> : Terrasoft.Configuration.Calendar_CalendarEventsProcess<TEntity> where TEntity : Calendar
	{

		public Calendar_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Calendar_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6ae193e1-dcfe-4fe7-aeaa-b8b288a109dd");
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

	#region Class: Calendar_SSPEventsProcess

	/// <exclude/>
	public class Calendar_SSPEventsProcess : Calendar_SSPEventsProcess<Calendar>
	{

		public Calendar_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Calendar_SSPEventsProcess

	public partial class Calendar_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CalendarEventsProcess

	/// <exclude/>
	public class CalendarEventsProcess : Calendar_SSPEventsProcess
	{

		public CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

