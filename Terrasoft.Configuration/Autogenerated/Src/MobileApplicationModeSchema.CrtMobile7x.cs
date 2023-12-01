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

	#region Class: MobileApplicationModeSchema

	/// <exclude/>
	public class MobileApplicationModeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MobileApplicationModeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MobileApplicationModeSchema(MobileApplicationModeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MobileApplicationModeSchema(MobileApplicationModeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			RealUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			Name = "MobileApplicationMode";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			column.CreatedInPackageId = new Guid("e30c1ce8-20e8-4007-a817-82094f89b177");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MobileApplicationMode(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MobileApplicationMode_CrtMobile7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MobileApplicationModeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MobileApplicationModeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05"));
		}

		#endregion

	}

	#endregion

	#region Class: MobileApplicationMode

	/// <summary>
	/// Mobile application operation mode.
	/// </summary>
	public class MobileApplicationMode : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MobileApplicationMode(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MobileApplicationMode";
		}

		public MobileApplicationMode(MobileApplicationMode source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MobileApplicationMode_CrtMobile7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MobileApplicationModeDeleted", e);
			Inserting += (s, e) => ThrowEvent("MobileApplicationModeInserting", e);
			Validating += (s, e) => ThrowEvent("MobileApplicationModeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MobileApplicationMode(this);
		}

		#endregion

	}

	#endregion

	#region Class: MobileApplicationMode_CrtMobile7xEventsProcess

	/// <exclude/>
	public partial class MobileApplicationMode_CrtMobile7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : MobileApplicationMode
	{

		public MobileApplicationMode_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MobileApplicationMode_CrtMobile7xEventsProcess";
			SchemaUId = new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("29cfc01f-6908-4cb4-81cc-1a3bef657a05");
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

	#region Class: MobileApplicationMode_CrtMobile7xEventsProcess

	/// <exclude/>
	public class MobileApplicationMode_CrtMobile7xEventsProcess : MobileApplicationMode_CrtMobile7xEventsProcess<MobileApplicationMode>
	{

		public MobileApplicationMode_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MobileApplicationMode_CrtMobile7xEventsProcess

	public partial class MobileApplicationMode_CrtMobile7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MobileApplicationModeEventsProcess

	/// <exclude/>
	public class MobileApplicationModeEventsProcess : MobileApplicationMode_CrtMobile7xEventsProcess
	{

		public MobileApplicationModeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

