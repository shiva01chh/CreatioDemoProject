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

	#region Class: SysDcmSchemaInSettingsSchema

	/// <exclude/>
	public class SysDcmSchemaInSettingsSchema : Terrasoft.Configuration.SysDcmSchemaInSettings_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public SysDcmSchemaInSettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysDcmSchemaInSettingsSchema(SysDcmSchemaInSettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysDcmSchemaInSettingsSchema(SysDcmSchemaInSettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("82ae30ec-f9dc-45dc-a053-df05062935dc");
			Name = "SysDcmSchemaInSettings";
			ParentSchemaUId = new Guid("91b4bc57-8490-442f-9036-62eaefe28ef0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2b000645-6072-461d-8963-11edfee86881");
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
			return new SysDcmSchemaInSettings(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysDcmSchemaInSettings_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysDcmSchemaInSettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysDcmSchemaInSettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82ae30ec-f9dc-45dc-a053-df05062935dc"));
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSchemaInSettings

	/// <summary>
	/// SysDcmSchemaInSettings.
	/// </summary>
	public class SysDcmSchemaInSettings : Terrasoft.Configuration.SysDcmSchemaInSettings_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public SysDcmSchemaInSettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysDcmSchemaInSettings";
		}

		public SysDcmSchemaInSettings(SysDcmSchemaInSettings source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysDcmSchemaInSettings_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysDcmSchemaInSettingsDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysDcmSchemaInSettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysDcmSchemaInSettings_PRMPortalEventsProcess

	/// <exclude/>
	public partial class SysDcmSchemaInSettings_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.SysDcmSchemaInSettings_CrtBaseEventsProcess<TEntity> where TEntity : SysDcmSchemaInSettings
	{

		public SysDcmSchemaInSettings_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysDcmSchemaInSettings_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("82ae30ec-f9dc-45dc-a053-df05062935dc");
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

	#region Class: SysDcmSchemaInSettings_PRMPortalEventsProcess

	/// <exclude/>
	public class SysDcmSchemaInSettings_PRMPortalEventsProcess : SysDcmSchemaInSettings_PRMPortalEventsProcess<SysDcmSchemaInSettings>
	{

		public SysDcmSchemaInSettings_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysDcmSchemaInSettings_PRMPortalEventsProcess

	public partial class SysDcmSchemaInSettings_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysDcmSchemaInSettingsEventsProcess

	/// <exclude/>
	public class SysDcmSchemaInSettingsEventsProcess : SysDcmSchemaInSettings_PRMPortalEventsProcess
	{

		public SysDcmSchemaInSettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

