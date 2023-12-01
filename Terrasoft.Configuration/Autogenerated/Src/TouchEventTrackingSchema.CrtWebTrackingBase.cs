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

	#region Class: TouchEventTrackingSchema

	/// <exclude/>
	public class TouchEventTrackingSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public TouchEventTrackingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchEventTrackingSchema(TouchEventTrackingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchEventTrackingSchema(TouchEventTrackingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a");
			RealUId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a");
			Name = "TouchEventTracking";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("92121521-5e62-2a7e-8509-5f9ad609536d")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("92121521-5e62-2a7e-8509-5f9ad609536d"),
				Name = @"Code",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a"),
				ModifiedInSchemaUId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a"),
				CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TouchEventTracking(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchEventTracking_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchEventTrackingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchEventTrackingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b8e1d2fb-7852-4843-815b-a547470f412a"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchEventTracking

	/// <summary>
	/// Touch event tracking system.
	/// </summary>
	public class TouchEventTracking : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public TouchEventTracking(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchEventTracking";
		}

		public TouchEventTracking(TouchEventTracking source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchEventTracking_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchEventTracking(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchEventTracking_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchEventTracking_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : TouchEventTracking
	{

		public TouchEventTracking_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchEventTracking_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("b8e1d2fb-7852-4843-815b-a547470f412a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b8e1d2fb-7852-4843-815b-a547470f412a");
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

	#region Class: TouchEventTracking_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchEventTracking_CrtWebTrackingBaseEventsProcess : TouchEventTracking_CrtWebTrackingBaseEventsProcess<TouchEventTracking>
	{

		public TouchEventTracking_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchEventTracking_CrtWebTrackingBaseEventsProcess

	public partial class TouchEventTracking_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchEventTrackingEventsProcess

	/// <exclude/>
	public class TouchEventTrackingEventsProcess : TouchEventTracking_CrtWebTrackingBaseEventsProcess
	{

		public TouchEventTrackingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

