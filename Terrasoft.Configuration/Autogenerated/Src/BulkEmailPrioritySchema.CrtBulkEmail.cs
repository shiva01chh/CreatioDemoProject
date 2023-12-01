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

	#region Class: BulkEmailPrioritySchema

	/// <exclude/>
	public class BulkEmailPrioritySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BulkEmailPrioritySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailPrioritySchema(BulkEmailPrioritySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailPrioritySchema(BulkEmailPrioritySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569");
			RealUId = new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569");
			Name = "BulkEmailPriority";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("067d31ac-4d52-9be5-612d-dd8e228ceaa9")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("067d31ac-4d52-9be5-612d-dd8e228ceaa9"),
				Name = @"Priority",
				CreatedInSchemaUId = new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569"),
				ModifiedInSchemaUId = new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569"),
				CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailPriority(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailPriority_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailPrioritySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailPrioritySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailPriority

	/// <summary>
	/// Bulk email priority.
	/// </summary>
	public class BulkEmailPriority : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BulkEmailPriority(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailPriority";
		}

		public BulkEmailPriority(BulkEmailPriority source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Priority.
		/// </summary>
		public int Priority {
			get {
				return GetTypedColumnValue<int>("Priority");
			}
			set {
				SetColumnValue("Priority", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailPriority_CrtBulkEmailEventsProcess(UserConnection);
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
			return new BulkEmailPriority(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailPriority_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailPriority_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailPriority
	{

		public BulkEmailPriority_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailPriority_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5c382e01-49bd-8855-4a42-dc1d5b4d4569");
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

	#region Class: BulkEmailPriority_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailPriority_CrtBulkEmailEventsProcess : BulkEmailPriority_CrtBulkEmailEventsProcess<BulkEmailPriority>
	{

		public BulkEmailPriority_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailPriority_CrtBulkEmailEventsProcess

	public partial class BulkEmailPriority_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailPriorityEventsProcess

	/// <exclude/>
	public class BulkEmailPriorityEventsProcess : BulkEmailPriority_CrtBulkEmailEventsProcess
	{

		public BulkEmailPriorityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

