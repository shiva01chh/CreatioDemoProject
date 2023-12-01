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

	#region Class: SysProcessStatusSchema

	/// <exclude/>
	public class SysProcessStatusSchema : Terrasoft.Configuration.SysProcessStatus_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public SysProcessStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysProcessStatusSchema(SysProcessStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysProcessStatusSchema(SysProcessStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("dede0e01-a067-4b71-b452-02735303a1ee");
			Name = "SysProcessStatus";
			ParentSchemaUId = new Guid("dc1e2217-9af0-4216-935b-ace805adc929");
			ExtendParent = true;
			CreatedInPackageId = new Guid("667fe825-207f-46da-8fb7-a082f81fd079");
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
			return new SysProcessStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysProcessStatus_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysProcessStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysProcessStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dede0e01-a067-4b71-b452-02735303a1ee"));
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessStatus

	/// <summary>
	/// Process status.
	/// </summary>
	public class SysProcessStatus : Terrasoft.Configuration.SysProcessStatus_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public SysProcessStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysProcessStatus";
		}

		public SysProcessStatus(SysProcessStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysProcessStatus_PRMPortalEventsProcess(UserConnection);
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
			return new SysProcessStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysProcessStatus_PRMPortalEventsProcess

	/// <exclude/>
	public partial class SysProcessStatus_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.SysProcessStatus_CrtBaseEventsProcess<TEntity> where TEntity : SysProcessStatus
	{

		public SysProcessStatus_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysProcessStatus_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dede0e01-a067-4b71-b452-02735303a1ee");
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

	#region Class: SysProcessStatus_PRMPortalEventsProcess

	/// <exclude/>
	public class SysProcessStatus_PRMPortalEventsProcess : SysProcessStatus_PRMPortalEventsProcess<SysProcessStatus>
	{

		public SysProcessStatus_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysProcessStatus_PRMPortalEventsProcess

	public partial class SysProcessStatus_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysProcessStatusEventsProcess

	/// <exclude/>
	public class SysProcessStatusEventsProcess : SysProcessStatus_PRMPortalEventsProcess
	{

		public SysProcessStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

