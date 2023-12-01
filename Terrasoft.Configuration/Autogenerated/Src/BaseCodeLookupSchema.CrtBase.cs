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

	#region Class: BaseCodeLookupSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseCodeLookupSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BaseCodeLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseCodeLookupSchema(BaseCodeLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseCodeLookupSchema(BaseCodeLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			RealUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			Name = "BaseCodeLookup";
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
			if (Columns.FindByUId(new Guid("13aad544-ec30-4e76-a373-f0cff3202e24")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("13aad544-ec30-4e76-a373-f0cff3202e24"),
				Name = @"Code",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2"),
				ModifiedInSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2"),
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
			return new BaseCodeLookup(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseCodeLookup_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseCodeLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseCodeLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseCodeLookup

	/// <summary>
	/// Base lookup with code.
	/// </summary>
	public class BaseCodeLookup : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BaseCodeLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseCodeLookup";
		}

		public BaseCodeLookup(BaseCodeLookup source)
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
			var process = new BaseCodeLookup_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseCodeLookupDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseCodeLookupDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseCodeLookupInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseCodeLookupInserting", e);
			Saved += (s, e) => ThrowEvent("BaseCodeLookupSaved", e);
			Saving += (s, e) => ThrowEvent("BaseCodeLookupSaving", e);
			Validating += (s, e) => ThrowEvent("BaseCodeLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseCodeLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseCodeLookup_CrtBaseEventsProcess

	/// <exclude/>
	public partial class BaseCodeLookup_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BaseCodeLookup
	{

		public BaseCodeLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseCodeLookup_CrtBaseEventsProcess";
			SchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
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

	#region Class: BaseCodeLookup_CrtBaseEventsProcess

	/// <exclude/>
	public class BaseCodeLookup_CrtBaseEventsProcess : BaseCodeLookup_CrtBaseEventsProcess<BaseCodeLookup>
	{

		public BaseCodeLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseCodeLookup_CrtBaseEventsProcess

	public partial class BaseCodeLookup_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BaseCodeLookupEventsProcess

	/// <exclude/>
	public class BaseCodeLookupEventsProcess : BaseCodeLookup_CrtBaseEventsProcess
	{

		public BaseCodeLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

