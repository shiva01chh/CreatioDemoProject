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

	#region Class: GlobalDuplicateSearchStatusSchema

	/// <exclude/>
	public class GlobalDuplicateSearchStatusSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public GlobalDuplicateSearchStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public GlobalDuplicateSearchStatusSchema(GlobalDuplicateSearchStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public GlobalDuplicateSearchStatusSchema(GlobalDuplicateSearchStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a");
			RealUId = new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a");
			Name = "GlobalDuplicateSearchStatus";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysGlobalDuplSearchStatusLcz";
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
			return new GlobalDuplicateSearchStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new GlobalDuplicateSearchStatus_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new GlobalDuplicateSearchStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new GlobalDuplicateSearchStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a"));
		}

		#endregion

	}

	#endregion

	#region Class: GlobalDuplicateSearchStatus

	/// <summary>
	/// Global Duplicates Search Status.
	/// </summary>
	public class GlobalDuplicateSearchStatus : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public GlobalDuplicateSearchStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "GlobalDuplicateSearchStatus";
		}

		public GlobalDuplicateSearchStatus(GlobalDuplicateSearchStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new GlobalDuplicateSearchStatus_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusDeleted", e);
			Deleting += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusDeleting", e);
			Inserted += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusInserted", e);
			Inserting += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusInserting", e);
			Saved += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusSaved", e);
			Saving += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusSaving", e);
			Validating += (s, e) => ThrowEvent("GlobalDuplicateSearchStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new GlobalDuplicateSearchStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: GlobalDuplicateSearchStatus_CrtBaseEventsProcess

	/// <exclude/>
	public partial class GlobalDuplicateSearchStatus_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : GlobalDuplicateSearchStatus
	{

		public GlobalDuplicateSearchStatus_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "GlobalDuplicateSearchStatus_CrtBaseEventsProcess";
			SchemaUId = new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1792d230-c5c1-4c80-917d-857bf9681e7a");
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

	#region Class: GlobalDuplicateSearchStatus_CrtBaseEventsProcess

	/// <exclude/>
	public class GlobalDuplicateSearchStatus_CrtBaseEventsProcess : GlobalDuplicateSearchStatus_CrtBaseEventsProcess<GlobalDuplicateSearchStatus>
	{

		public GlobalDuplicateSearchStatus_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: GlobalDuplicateSearchStatus_CrtBaseEventsProcess

	public partial class GlobalDuplicateSearchStatus_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: GlobalDuplicateSearchStatusEventsProcess

	/// <exclude/>
	public class GlobalDuplicateSearchStatusEventsProcess : GlobalDuplicateSearchStatus_CrtBaseEventsProcess
	{

		public GlobalDuplicateSearchStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

