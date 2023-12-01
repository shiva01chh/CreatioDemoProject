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

	#region Class: SysWidgetDashboardSchema

	/// <exclude/>
	public class SysWidgetDashboardSchema : Terrasoft.Configuration.SysDashboardSchema
	{

		#region Constructors: Public

		public SysWidgetDashboardSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysWidgetDashboardSchema(SysWidgetDashboardSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysWidgetDashboardSchema(SysWidgetDashboardSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1");
			RealUId = new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1");
			Name = "SysWidgetDashboard";
			ParentSchemaUId = new Guid("873fa71c-3434-43e7-93cb-6f77e1191e11");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateCaptionColumn() {
			EntitySchemaColumn column = base.CreateCaptionColumn();
			column.RequirementType = EntitySchemaColumnRequirementType.None;
			column.ModifiedInSchemaUId = new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysWidgetDashboard(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysWidgetDashboard_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysWidgetDashboardSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysWidgetDashboardSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1"));
		}

		#endregion

	}

	#endregion

	#region Class: SysWidgetDashboard

	/// <summary>
	/// Widget dashboard.
	/// </summary>
	public class SysWidgetDashboard : Terrasoft.Configuration.SysDashboard
	{

		#region Constructors: Public

		public SysWidgetDashboard(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysWidgetDashboard";
		}

		public SysWidgetDashboard(SysWidgetDashboard source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysWidgetDashboard_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysWidgetDashboardDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysWidgetDashboard(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysWidgetDashboard_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysWidgetDashboard_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.SysDashboard_CrtPortalEventsProcess<TEntity> where TEntity : SysWidgetDashboard
	{

		public SysWidgetDashboard_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysWidgetDashboard_CrtBaseEventsProcess";
			SchemaUId = new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e21c1b43-38cd-4bc0-935f-2ea27cd399e1");
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

	#region Class: SysWidgetDashboard_CrtBaseEventsProcess

	/// <exclude/>
	public class SysWidgetDashboard_CrtBaseEventsProcess : SysWidgetDashboard_CrtBaseEventsProcess<SysWidgetDashboard>
	{

		public SysWidgetDashboard_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysWidgetDashboard_CrtBaseEventsProcess

	public partial class SysWidgetDashboard_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysWidgetDashboardEventsProcess

	/// <exclude/>
	public class SysWidgetDashboardEventsProcess : SysWidgetDashboard_CrtBaseEventsProcess
	{

		public SysWidgetDashboardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

