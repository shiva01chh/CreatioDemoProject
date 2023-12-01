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

	#region Class: SysCodeLookupSchema

	/// <exclude/>
	[IsVirtual]
	public class SysCodeLookupSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysCodeLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysCodeLookupSchema(SysCodeLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysCodeLookupSchema(SysCodeLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			RealUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			Name = "SysCodeLookup";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			if (Columns.FindByUId(new Guid("4d58b7b5-8dc5-4b61-b2d4-ad41c862a17e")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Text")) {
				UId = new Guid("4d58b7b5-8dc5-4b61-b2d4-ad41c862a17e"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14"),
				ModifiedInSchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysCodeLookup(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysCodeLookup_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysCodeLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysCodeLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28699730-9cf0-4702-87a9-c64d612e4b14"));
		}

		#endregion

	}

	#endregion

	#region Class: SysCodeLookup

	/// <summary>
	/// Lookup with code.
	/// </summary>
	public class SysCodeLookup : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysCodeLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysCodeLookup";
		}

		public SysCodeLookup(SysCodeLookup source)
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
			var process = new SysCodeLookup_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysCodeLookupDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysCodeLookupDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysCodeLookupInserted", e);
			Inserting += (s, e) => ThrowEvent("SysCodeLookupInserting", e);
			Saved += (s, e) => ThrowEvent("SysCodeLookupSaved", e);
			Saving += (s, e) => ThrowEvent("SysCodeLookupSaving", e);
			Validating += (s, e) => ThrowEvent("SysCodeLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysCodeLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysCodeLookup_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysCodeLookup_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysCodeLookup
	{

		public SysCodeLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysCodeLookup_CrtBaseEventsProcess";
			SchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
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

	#region Class: SysCodeLookup_CrtBaseEventsProcess

	/// <exclude/>
	public class SysCodeLookup_CrtBaseEventsProcess : SysCodeLookup_CrtBaseEventsProcess<SysCodeLookup>
	{

		public SysCodeLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysCodeLookup_CrtBaseEventsProcess

	public partial class SysCodeLookup_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysCodeLookupEventsProcess

	/// <exclude/>
	public class SysCodeLookupEventsProcess : SysCodeLookup_CrtBaseEventsProcess
	{

		public SysCodeLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

