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

	#region Class: SysFileContentStorageSchema

	/// <exclude/>
	public class SysFileContentStorageSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysFileContentStorageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysFileContentStorageSchema(SysFileContentStorageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysFileContentStorageSchema(SysFileContentStorageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732");
			RealUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732");
			Name = "SysFileContentStorage";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1285498e-b393-128d-bfb3-1c3dd30abec8")) == null) {
				Columns.Add(CreateTypeNameColumn());
			}
			if (Columns.FindByUId(new Guid("6e11e069-7ddf-04f5-d460-d61ec3a7e3de")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("1285498e-b393-128d-bfb3-1c3dd30abec8"),
				Name = @"TypeName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732"),
				ModifiedInSchemaUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732"),
				CreatedInPackageId = new Guid("07376563-30e5-48fd-8d5f-c37f73bbc55d")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6e11e069-7ddf-04f5-d460-d61ec3a7e3de"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732"),
				ModifiedInSchemaUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732"),
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysFileContentStorage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysFileContentStorage_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysFileContentStorageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysFileContentStorageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732"));
		}

		#endregion

	}

	#endregion

	#region Class: SysFileContentStorage

	/// <summary>
	/// File content storages.
	/// </summary>
	public class SysFileContentStorage : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysFileContentStorage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysFileContentStorage";
		}

		public SysFileContentStorage(SysFileContentStorage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Storage type name.
		/// </summary>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
			}
		}

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
			var process = new SysFileContentStorage_CrtBaseEventsProcess(UserConnection);
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
			return new SysFileContentStorage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysFileContentStorage_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysFileContentStorage_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysFileContentStorage
	{

		public SysFileContentStorage_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysFileContentStorage_CrtBaseEventsProcess";
			SchemaUId = new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7ef214db-a12c-6ef8-7951-c90f6cfe7732");
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

	#region Class: SysFileContentStorage_CrtBaseEventsProcess

	/// <exclude/>
	public class SysFileContentStorage_CrtBaseEventsProcess : SysFileContentStorage_CrtBaseEventsProcess<SysFileContentStorage>
	{

		public SysFileContentStorage_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysFileContentStorage_CrtBaseEventsProcess

	public partial class SysFileContentStorage_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysFileContentStorageEventsProcess

	/// <exclude/>
	public class SysFileContentStorageEventsProcess : SysFileContentStorage_CrtBaseEventsProcess
	{

		public SysFileContentStorageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

