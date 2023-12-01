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

	#region Class: SysEntitySchemaColRightLevelSchema

	/// <exclude/>
	public class SysEntitySchemaColRightLevelSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysEntitySchemaColRightLevelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntitySchemaColRightLevelSchema(SysEntitySchemaColRightLevelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntitySchemaColRightLevelSchema(SysEntitySchemaColRightLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
			RealUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
			Name = "SysEntitySchemaColRightLevel";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysEntitySchColRightLevelLcz";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5f3c9105-49c9-4b00-9db4-13e50ead38c4")) == null) {
				Columns.Add(CreateValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5f3c9105-49c9-4b00-9db4-13e50ead38c4"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0"),
				ModifiedInSchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0"),
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
			return new SysEntitySchemaColRightLevel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntitySchemaColRightLevel_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntitySchemaColRightLevelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntitySchemaColRightLevelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaColRightLevel

	/// <summary>
	/// Column permission.
	/// </summary>
	public class SysEntitySchemaColRightLevel : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysEntitySchemaColRightLevel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntitySchemaColRightLevel";
		}

		public SysEntitySchemaColRightLevel(SysEntitySchemaColRightLevel source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Value.
		/// </summary>
		public int Value {
			get {
				return GetTypedColumnValue<int>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntitySchemaColRightLevel_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntitySchemaColRightLevelValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaColRightLevel(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaColRightLevel_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysEntitySchemaColRightLevel_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysEntitySchemaColRightLevel
	{

		public SysEntitySchemaColRightLevel_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaColRightLevel_CrtBaseEventsProcess";
			SchemaUId = new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f77c0b8d-14db-43fc-b3ad-db3c815140a0");
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

	#region Class: SysEntitySchemaColRightLevel_CrtBaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaColRightLevel_CrtBaseEventsProcess : SysEntitySchemaColRightLevel_CrtBaseEventsProcess<SysEntitySchemaColRightLevel>
	{

		public SysEntitySchemaColRightLevel_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaColRightLevel_CrtBaseEventsProcess

	public partial class SysEntitySchemaColRightLevel_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckCanManageLookups() {
		}

		#endregion

	}

	#endregion


	#region Class: SysEntitySchemaColRightLevelEventsProcess

	/// <exclude/>
	public class SysEntitySchemaColRightLevelEventsProcess : SysEntitySchemaColRightLevel_CrtBaseEventsProcess
	{

		public SysEntitySchemaColRightLevelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

