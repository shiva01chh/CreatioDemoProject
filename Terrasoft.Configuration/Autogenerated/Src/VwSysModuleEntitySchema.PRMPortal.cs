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

	#region Class: VwSysModuleEntitySchema

	/// <exclude/>
	public class VwSysModuleEntitySchema : Terrasoft.Configuration.VwSysModuleEntity_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSysModuleEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysModuleEntitySchema(VwSysModuleEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysModuleEntitySchema(VwSysModuleEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("39c44f57-57a2-4c50-a054-106eadf202e3");
			Name = "VwSysModuleEntity";
			ParentSchemaUId = new Guid("a2d407a1-cda4-4344-ac71-88a4e2bf9c28");
			ExtendParent = true;
			CreatedInPackageId = new Guid("667fe825-207f-46da-8fb7-a082f81fd079");
			IsDBView = true;
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
			return new VwSysModuleEntity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysModuleEntity_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysModuleEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysModuleEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("39c44f57-57a2-4c50-a054-106eadf202e3"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntity

	/// <summary>
	/// Section object (view).
	/// </summary>
	public class VwSysModuleEntity : Terrasoft.Configuration.VwSysModuleEntity_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwSysModuleEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysModuleEntity";
		}

		public VwSysModuleEntity(VwSysModuleEntity source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysModuleEntity_PRMPortalEventsProcess(UserConnection);
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
			return new VwSysModuleEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysModuleEntity_PRMPortalEventsProcess

	/// <exclude/>
	public partial class VwSysModuleEntity_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.VwSysModuleEntity_CrtBaseEventsProcess<TEntity> where TEntity : VwSysModuleEntity
	{

		public VwSysModuleEntity_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysModuleEntity_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("39c44f57-57a2-4c50-a054-106eadf202e3");
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

	#region Class: VwSysModuleEntity_PRMPortalEventsProcess

	/// <exclude/>
	public class VwSysModuleEntity_PRMPortalEventsProcess : VwSysModuleEntity_PRMPortalEventsProcess<VwSysModuleEntity>
	{

		public VwSysModuleEntity_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysModuleEntity_PRMPortalEventsProcess

	public partial class VwSysModuleEntity_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysModuleEntityEventsProcess

	/// <exclude/>
	public class VwSysModuleEntityEventsProcess : VwSysModuleEntity_PRMPortalEventsProcess
	{

		public VwSysModuleEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

