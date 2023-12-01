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

	#region Class: LandingTypeSchema

	/// <exclude/>
	public class LandingTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LandingTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LandingTypeSchema(LandingTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LandingTypeSchema(LandingTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2");
			RealUId = new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2");
			Name = "LandingType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fc0e3e3b-059a-41c0-ac9d-be82e0250c11");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0f72e9b0-1c5b-4c79-915b-c3496f2b9752")) == null) {
				Columns.Add(CreateSchemaUidColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSchemaUidColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f72e9b0-1c5b-4c79-915b-c3496f2b9752"),
				Name = @"SchemaUid",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2"),
				ModifiedInSchemaUId = new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2"),
				CreatedInPackageId = new Guid("fc0e3e3b-059a-41c0-ac9d-be82e0250c11")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LandingType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LandingType_CrtWebFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LandingTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LandingTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2"));
		}

		#endregion

	}

	#endregion

	#region Class: LandingType

	/// <summary>
	/// Landing type.
	/// </summary>
	public class LandingType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LandingType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LandingType";
		}

		public LandingType(LandingType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SchemaUidId {
			get {
				return GetTypedColumnValue<Guid>("SchemaUidId");
			}
			set {
				SetColumnValue("SchemaUidId", value);
				_schemaUid = null;
			}
		}

		/// <exclude/>
		public string SchemaUidCaption {
			get {
				return GetTypedColumnValue<string>("SchemaUidCaption");
			}
			set {
				SetColumnValue("SchemaUidCaption", value);
				if (_schemaUid != null) {
					_schemaUid.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _schemaUid;
		/// <summary>
		/// Object.
		/// </summary>
		public VwSysSchemaInfo SchemaUid {
			get {
				return _schemaUid ??
					(_schemaUid = LookupColumnEntities.GetEntity("SchemaUid") as VwSysSchemaInfo);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LandingType_CrtWebFormEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LandingTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("LandingTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LandingType(this);
		}

		#endregion

	}

	#endregion

	#region Class: LandingType_CrtWebFormEventsProcess

	/// <exclude/>
	public partial class LandingType_CrtWebFormEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LandingType
	{

		public LandingType_CrtWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LandingType_CrtWebFormEventsProcess";
			SchemaUId = new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e14fd334-ae5c-4fa5-970c-56c2f8ef33c2");
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

	#region Class: LandingType_CrtWebFormEventsProcess

	/// <exclude/>
	public class LandingType_CrtWebFormEventsProcess : LandingType_CrtWebFormEventsProcess<LandingType>
	{

		public LandingType_CrtWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LandingType_CrtWebFormEventsProcess

	public partial class LandingType_CrtWebFormEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LandingTypeEventsProcess

	/// <exclude/>
	public class LandingTypeEventsProcess : LandingType_CrtWebFormEventsProcess
	{

		public LandingTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

