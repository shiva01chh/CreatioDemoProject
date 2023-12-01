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

	#region Class: ServiceEngineerSchema

	/// <exclude/>
	public class ServiceEngineerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ServiceEngineerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceEngineerSchema(ServiceEngineerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceEngineerSchema(ServiceEngineerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			RealUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			Name = "ServiceEngineer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("929f87ac-5314-4b35-9d8c-725f55c9caec")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("64ee0d0a-cae1-41d9-992f-706e9156a790")) == null) {
				Columns.Add(CreateEngineerColumn());
			}
			if (Columns.FindByUId(new Guid("cd8535dd-d62a-4723-a8bc-8f9efa79e26c")) == null) {
				Columns.Add(CreateSupportLevelColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("929f87ac-5314-4b35-9d8c-725f55c9caec"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected virtual EntitySchemaColumn CreateEngineerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("64ee0d0a-cae1-41d9-992f-706e9156a790"),
				Name = @"Engineer",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected virtual EntitySchemaColumn CreateSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cd8535dd-d62a-4723-a8bc-8f9efa79e26c"),
				Name = @"SupportLevel",
				ReferenceSchemaUId = new Guid("4c2e1b60-ee12-4846-a38e-04204de6fb14"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceEngineer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceEngineer_CrtSLMITILServiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceEngineerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceEngineerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceEngineer

	/// <summary>
	/// Service team member.
	/// </summary>
	public class ServiceEngineer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ServiceEngineer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceEngineer";
		}

		public ServiceEngineer(ServiceEngineer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service.
		/// </summary>
		public ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
			}
		}

		/// <exclude/>
		public Guid EngineerId {
			get {
				return GetTypedColumnValue<Guid>("EngineerId");
			}
			set {
				SetColumnValue("EngineerId", value);
				_engineer = null;
			}
		}

		/// <exclude/>
		public string EngineerName {
			get {
				return GetTypedColumnValue<string>("EngineerName");
			}
			set {
				SetColumnValue("EngineerName", value);
				if (_engineer != null) {
					_engineer.Name = value;
				}
			}
		}

		private SysAdminUnit _engineer;
		/// <summary>
		/// Member/team.
		/// </summary>
		public SysAdminUnit Engineer {
			get {
				return _engineer ??
					(_engineer = LookupColumnEntities.GetEntity("Engineer") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid SupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SupportLevelId");
			}
			set {
				SetColumnValue("SupportLevelId", value);
				_supportLevel = null;
			}
		}

		/// <exclude/>
		public string SupportLevelName {
			get {
				return GetTypedColumnValue<string>("SupportLevelName");
			}
			set {
				SetColumnValue("SupportLevelName", value);
				if (_supportLevel != null) {
					_supportLevel.Name = value;
				}
			}
		}

		private RoleInServiceTeam _supportLevel;
		/// <summary>
		/// Support line.
		/// </summary>
		public RoleInServiceTeam SupportLevel {
			get {
				return _supportLevel ??
					(_supportLevel = LookupColumnEntities.GetEntity("SupportLevel") as RoleInServiceTeam);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceEngineer_CrtSLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ServiceEngineerDeleted", e);
			Deleting += (s, e) => ThrowEvent("ServiceEngineerDeleting", e);
			Inserted += (s, e) => ThrowEvent("ServiceEngineerInserted", e);
			Inserting += (s, e) => ThrowEvent("ServiceEngineerInserting", e);
			Saved += (s, e) => ThrowEvent("ServiceEngineerSaved", e);
			Saving += (s, e) => ThrowEvent("ServiceEngineerSaving", e);
			Validating += (s, e) => ThrowEvent("ServiceEngineerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceEngineer(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceEngineer_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public partial class ServiceEngineer_CrtSLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ServiceEngineer
	{

		public ServiceEngineer_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceEngineer_CrtSLMITILServiceEventsProcess";
			SchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
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

	#region Class: ServiceEngineer_CrtSLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceEngineer_CrtSLMITILServiceEventsProcess : ServiceEngineer_CrtSLMITILServiceEventsProcess<ServiceEngineer>
	{

		public ServiceEngineer_CrtSLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceEngineer_CrtSLMITILServiceEventsProcess

	public partial class ServiceEngineer_CrtSLMITILServiceEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ServiceEngineerEventsProcess

	/// <exclude/>
	public class ServiceEngineerEventsProcess : ServiceEngineer_CrtSLMITILServiceEventsProcess
	{

		public ServiceEngineerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

