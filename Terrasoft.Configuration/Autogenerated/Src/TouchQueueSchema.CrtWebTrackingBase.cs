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

	#region Class: TouchQueueSchema

	/// <exclude/>
	public class TouchQueueSchema : Terrasoft.Configuration.BaseTaskQueueSchema
	{

		#region Constructors: Public

		public TouchQueueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TouchQueueSchema(TouchQueueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TouchQueueSchema(TouchQueueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32");
			RealUId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32");
			Name = "TouchQueue";
			ParentSchemaUId = new Guid("de97f161-117b-49b0-b08a-38ae2a77cdd1");
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
			if (Columns.FindByUId(new Guid("ab62a7a4-2d7b-fcd0-517b-b4c0d597b26b")) == null) {
				Columns.Add(CreateHashCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateHashCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("HashText")) {
				UId = new Guid("ab62a7a4-2d7b-fcd0-517b-b4c0d597b26b"),
				Name = @"HashCode",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32"),
				ModifiedInSchemaUId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32"),
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
			return new TouchQueue(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new TouchQueue_CrtWebTrackingBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TouchQueueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TouchQueueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32"));
		}

		#endregion

	}

	#endregion

	#region Class: TouchQueue

	/// <summary>
	/// Touch points tasks queue.
	/// </summary>
	public class TouchQueue : Terrasoft.Configuration.BaseTaskQueue
	{

		#region Constructors: Public

		public TouchQueue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TouchQueue";
		}

		public TouchQueue(TouchQueue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// HashCode.
		/// </summary>
		public string HashCode {
			get {
				return GetTypedColumnValue<string>("HashCode");
			}
			set {
				SetColumnValue("HashCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TouchQueue_CrtWebTrackingBaseEventsProcess(UserConnection);
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
			return new TouchQueue(this);
		}

		#endregion

	}

	#endregion

	#region Class: TouchQueue_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public partial class TouchQueue_CrtWebTrackingBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseTaskQueue_CrtMarketingBaseEventsProcess<TEntity> where TEntity : TouchQueue
	{

		public TouchQueue_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TouchQueue_CrtWebTrackingBaseEventsProcess";
			SchemaUId = new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8e06adb6-61a3-48e5-ad4e-908b3909fc32");
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

	#region Class: TouchQueue_CrtWebTrackingBaseEventsProcess

	/// <exclude/>
	public class TouchQueue_CrtWebTrackingBaseEventsProcess : TouchQueue_CrtWebTrackingBaseEventsProcess<TouchQueue>
	{

		public TouchQueue_CrtWebTrackingBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TouchQueue_CrtWebTrackingBaseEventsProcess

	public partial class TouchQueue_CrtWebTrackingBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TouchQueueEventsProcess

	/// <exclude/>
	public class TouchQueueEventsProcess : TouchQueue_CrtWebTrackingBaseEventsProcess
	{

		public TouchQueueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

