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

	#region Class: QueuePrioritySchema

	/// <exclude/>
	public class QueuePrioritySchema : Terrasoft.Configuration.BaseValueLookupSchema
	{

		#region Constructors: Public

		public QueuePrioritySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueuePrioritySchema(QueuePrioritySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueuePrioritySchema(QueuePrioritySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65");
			RealUId = new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65");
			Name = "QueuePriority";
			ParentSchemaUId = new Guid("04f67f0c-0a27-4616-987e-60e378854b0f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4");
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
			return new QueuePriority(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new QueuePriority_OperatorSingleWindowEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QueuePrioritySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueuePrioritySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65"));
		}

		#endregion

	}

	#endregion

	#region Class: QueuePriority

	/// <summary>
	/// Agent desktop queue priority.
	/// </summary>
	public class QueuePriority : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public QueuePriority(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueuePriority";
		}

		public QueuePriority(QueuePriority source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QueuePriority_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("QueuePriorityDeleted", e);
			Validating += (s, e) => ThrowEvent("QueuePriorityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueuePriority(this);
		}

		#endregion

	}

	#endregion

	#region Class: QueuePriority_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public partial class QueuePriority_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseValueLookup_CrtBaseEventsProcess<TEntity> where TEntity : QueuePriority
	{

		public QueuePriority_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueuePriority_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65");
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

	#region Class: QueuePriority_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueuePriority_OperatorSingleWindowEventsProcess : QueuePriority_OperatorSingleWindowEventsProcess<QueuePriority>
	{

		public QueuePriority_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueuePriority_OperatorSingleWindowEventsProcess

	public partial class QueuePriority_OperatorSingleWindowEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: QueuePriorityEventsProcess

	/// <exclude/>
	public class QueuePriorityEventsProcess : QueuePriority_OperatorSingleWindowEventsProcess
	{

		public QueuePriorityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

