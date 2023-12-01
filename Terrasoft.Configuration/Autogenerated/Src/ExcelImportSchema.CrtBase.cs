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

	#region Class: ExcelImportSchema

	/// <exclude/>
	public class ExcelImportSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ExcelImportSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ExcelImportSchema(ExcelImportSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ExcelImportSchema(ExcelImportSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("85811a1d-f704-4381-b169-eeb0ca280754");
			RealUId = new Guid("85811a1d-f704-4381-b169-eeb0ca280754");
			Name = "ExcelImport";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ExcelImport(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ExcelImport_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ExcelImportSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ExcelImportSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("85811a1d-f704-4381-b169-eeb0ca280754"));
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImport

	/// <summary>
	/// Excel import.
	/// </summary>
	public class ExcelImport : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ExcelImport(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ExcelImport";
		}

		public ExcelImport(ExcelImport source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ExcelImport_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ExcelImportDeleted", e);
			Deleting += (s, e) => ThrowEvent("ExcelImportDeleting", e);
			Inserted += (s, e) => ThrowEvent("ExcelImportInserted", e);
			Inserting += (s, e) => ThrowEvent("ExcelImportInserting", e);
			Saved += (s, e) => ThrowEvent("ExcelImportSaved", e);
			Saving += (s, e) => ThrowEvent("ExcelImportSaving", e);
			Validating += (s, e) => ThrowEvent("ExcelImportValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ExcelImport(this);
		}

		#endregion

	}

	#endregion

	#region Class: ExcelImport_CrtBaseEventsProcess

	/// <exclude/>
	public partial class ExcelImport_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ExcelImport
	{

		public ExcelImport_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ExcelImport_CrtBaseEventsProcess";
			SchemaUId = new Guid("85811a1d-f704-4381-b169-eeb0ca280754");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("85811a1d-f704-4381-b169-eeb0ca280754");
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

	#region Class: ExcelImport_CrtBaseEventsProcess

	/// <exclude/>
	public class ExcelImport_CrtBaseEventsProcess : ExcelImport_CrtBaseEventsProcess<ExcelImport>
	{

		public ExcelImport_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ExcelImport_CrtBaseEventsProcess

	public partial class ExcelImport_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ExcelImportEventsProcess

	/// <exclude/>
	public class ExcelImportEventsProcess : ExcelImport_CrtBaseEventsProcess
	{

		public ExcelImportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

