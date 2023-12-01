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

	#region Class: DayOfWeekSchema

	/// <exclude/>
	public class DayOfWeekSchema : Terrasoft.Configuration.DayOfWeek_CalendarBase_TerrasoftSchema
	{

		#region Constructors: Public

		public DayOfWeekSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DayOfWeekSchema(DayOfWeekSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DayOfWeekSchema(DayOfWeekSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b62b845a-40a7-4dfb-8500-1c65ef586ff0");
			Name = "DayOfWeek";
			ParentSchemaUId = new Guid("95592cd1-f2aa-4d34-a109-aa046cd5bbd5");
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
			return new DayOfWeek(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DayOfWeek_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DayOfWeekSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DayOfWeekSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b62b845a-40a7-4dfb-8500-1c65ef586ff0"));
		}

		#endregion

	}

	#endregion

	#region Class: DayOfWeek

	/// <summary>
	/// Day of the week.
	/// </summary>
	public class DayOfWeek : Terrasoft.Configuration.DayOfWeek_CalendarBase_Terrasoft
	{

		#region Constructors: Public

		public DayOfWeek(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DayOfWeek";
		}

		public DayOfWeek(DayOfWeek source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DayOfWeek_SSPEventsProcess(UserConnection);
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
			return new DayOfWeek(this);
		}

		#endregion

	}

	#endregion

	#region Class: DayOfWeek_SSPEventsProcess

	/// <exclude/>
	public partial class DayOfWeek_SSPEventsProcess<TEntity> : Terrasoft.Configuration.DayOfWeek_CalendarBaseEventsProcess<TEntity> where TEntity : DayOfWeek
	{

		public DayOfWeek_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DayOfWeek_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b62b845a-40a7-4dfb-8500-1c65ef586ff0");
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

	#region Class: DayOfWeek_SSPEventsProcess

	/// <exclude/>
	public class DayOfWeek_SSPEventsProcess : DayOfWeek_SSPEventsProcess<DayOfWeek>
	{

		public DayOfWeek_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DayOfWeek_SSPEventsProcess

	public partial class DayOfWeek_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DayOfWeekEventsProcess

	/// <exclude/>
	public class DayOfWeekEventsProcess : DayOfWeek_SSPEventsProcess
	{

		public DayOfWeekEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

