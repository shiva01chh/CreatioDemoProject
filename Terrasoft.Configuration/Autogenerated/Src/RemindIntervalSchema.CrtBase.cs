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

	#region Class: RemindIntervalSchema

	/// <exclude/>
	public class RemindIntervalSchema : Terrasoft.Configuration.BaseValueLookupSchema
	{

		#region Constructors: Public

		public RemindIntervalSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RemindIntervalSchema(RemindIntervalSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RemindIntervalSchema(RemindIntervalSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			RealUId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			Name = "RemindInterval";
			ParentSchemaUId = new Guid("04f67f0c-0a27-4616-987e-60e378854b0f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RemindInterval(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RemindInterval_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RemindIntervalSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RemindIntervalSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d036711d-8369-44ca-af27-99f79cb28c1d"));
		}

		#endregion

	}

	#endregion

	#region Class: RemindInterval

	/// <summary>
	/// Interval of notifications.
	/// </summary>
	public class RemindInterval : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public RemindInterval(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RemindInterval";
		}

		public RemindInterval(RemindInterval source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RemindInterval_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RemindIntervalDeleted", e);
			Deleting += (s, e) => ThrowEvent("RemindIntervalDeleting", e);
			Inserted += (s, e) => ThrowEvent("RemindIntervalInserted", e);
			Inserting += (s, e) => ThrowEvent("RemindIntervalInserting", e);
			Saved += (s, e) => ThrowEvent("RemindIntervalSaved", e);
			Saving += (s, e) => ThrowEvent("RemindIntervalSaving", e);
			Validating += (s, e) => ThrowEvent("RemindIntervalValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RemindInterval(this);
		}

		#endregion

	}

	#endregion

	#region Class: RemindInterval_CrtBaseEventsProcess

	/// <exclude/>
	public partial class RemindInterval_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseValueLookup_CrtBaseEventsProcess<TEntity> where TEntity : RemindInterval
	{

		public RemindInterval_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RemindInterval_CrtBaseEventsProcess";
			SchemaUId = new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d036711d-8369-44ca-af27-99f79cb28c1d");
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

	#region Class: RemindInterval_CrtBaseEventsProcess

	/// <exclude/>
	public class RemindInterval_CrtBaseEventsProcess : RemindInterval_CrtBaseEventsProcess<RemindInterval>
	{

		public RemindInterval_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RemindInterval_CrtBaseEventsProcess

	public partial class RemindInterval_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RemindIntervalEventsProcess

	/// <exclude/>
	public class RemindIntervalEventsProcess : RemindInterval_CrtBaseEventsProcess
	{

		public RemindIntervalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

