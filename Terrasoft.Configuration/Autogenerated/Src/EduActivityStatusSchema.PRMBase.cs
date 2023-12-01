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

	#region Class: EduActivityStatusSchema

	/// <exclude/>
	public class EduActivityStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EduActivityStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EduActivityStatusSchema(EduActivityStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EduActivityStatusSchema(EduActivityStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb");
			RealUId = new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb");
			Name = "EduActivityStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f43a6760-9275-4070-90a5-eacccad59d8c");
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
			return new EduActivityStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EduActivityStatus_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EduActivityStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EduActivityStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb"));
		}

		#endregion

	}

	#endregion

	#region Class: EduActivityStatus

	/// <summary>
	/// Status of education activity.
	/// </summary>
	public class EduActivityStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EduActivityStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EduActivityStatus";
		}

		public EduActivityStatus(EduActivityStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EduActivityStatus_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EduActivityStatusDeleted", e);
			Validating += (s, e) => ThrowEvent("EduActivityStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EduActivityStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: EduActivityStatus_PRMBaseEventsProcess

	/// <exclude/>
	public partial class EduActivityStatus_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : EduActivityStatus
	{

		public EduActivityStatus_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EduActivityStatus_PRMBaseEventsProcess";
			SchemaUId = new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5c102754-283e-43e1-8529-fb0c1a7facbb");
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

	#region Class: EduActivityStatus_PRMBaseEventsProcess

	/// <exclude/>
	public class EduActivityStatus_PRMBaseEventsProcess : EduActivityStatus_PRMBaseEventsProcess<EduActivityStatus>
	{

		public EduActivityStatus_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EduActivityStatus_PRMBaseEventsProcess

	public partial class EduActivityStatus_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EduActivityStatusEventsProcess

	/// <exclude/>
	public class EduActivityStatusEventsProcess : EduActivityStatus_PRMBaseEventsProcess
	{

		public EduActivityStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

