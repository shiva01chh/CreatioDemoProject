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

	#region Class: TouchActionType_CrtWebTrackingBase_TerrasoftSchema

	/// <exclude/>
	public class TouchActionType_CrtWebTrackingBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public TouchActionType_CrtWebTrackingBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchActionType_CrtWebTrackingBase_TerrasoftSchema(TouchActionType_CrtWebTrackingBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchActionType_CrtWebTrackingBase_TerrasoftSchema(TouchActionType_CrtWebTrackingBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9");
			RealUId = new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9");
			Name = "TouchActionType_CrtWebTrackingBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("02115f37-84dc-464a-87f1-bcad70c08759");
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
			return new TouchActionType_CrtWebTrackingBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchActionType_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchActionType_CrtWebTrackingBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchActionType_CrtWebTrackingBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchActionType_CrtWebTrackingBase_Terrasoft

	/// <summary>
	/// Web action type.
	/// </summary>
	public class TouchActionType_CrtWebTrackingBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public TouchActionType_CrtWebTrackingBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchActionType_CrtWebTrackingBase_Terrasoft";
		}

		public TouchActionType_CrtWebTrackingBase_Terrasoft(TouchActionType_CrtWebTrackingBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchActionType_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchActionType_CrtWebTrackingBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchActionType_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchActionType_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : TouchActionType_CrtWebTrackingBase_Terrasoft
	{

		public TouchActionType_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchActionType_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("480fa5f1-106f-4df5-9e1a-987204c8e9e9");
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

	#region Class: TouchActionType_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchActionType_CrtWebTrackingBaseEventsProcess : TouchActionType_CrtWebTrackingBaseEventsProcess<TouchActionType_CrtWebTrackingBase_Terrasoft>
	{

		public TouchActionType_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchActionType_CrtWebTrackingBaseEventsProcess

	public partial class TouchActionType_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

