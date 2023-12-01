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

	#region Class: PortalSchemaAccessListSchema

	/// <exclude/>
	public class PortalSchemaAccessListSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PortalSchemaAccessListSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalSchemaAccessListSchema(PortalSchemaAccessListSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalSchemaAccessListSchema(PortalSchemaAccessListSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7");
			RealUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7");
			Name = "PortalSchemaAccessList";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateAccessEntitySchemaNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("632e7352-e04d-40d0-8563-ad12348dca7e")) == null) {
				Columns.Add(CreateSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccessEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("0cb38aee-c8a8-46ce-8a30-37a75353fd3b"),
				Name = @"AccessEntitySchemaName",
				CreatedInSchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"),
				ModifiedInSchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("632e7352-e04d-40d0-8563-ad12348dca7e"),
				Name = @"SchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"),
				ModifiedInSchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PortalSchemaAccessList(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PortalSchemaAccessList_CrtNUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PortalSchemaAccessListSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalSchemaAccessListSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalSchemaAccessList

	/// <summary>
	/// List of schema fields for portal access.
	/// </summary>
	public class PortalSchemaAccessList : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PortalSchemaAccessList(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalSchemaAccessList";
		}

		public PortalSchemaAccessList(PortalSchemaAccessList source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Schema name.
		/// </summary>
		public string AccessEntitySchemaName {
			get {
				return GetTypedColumnValue<string>("AccessEntitySchemaName");
			}
			set {
				SetColumnValue("AccessEntitySchemaName", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public Guid SchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SchemaUId");
			}
			set {
				SetColumnValue("SchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalSchemaAccessList_CrtNUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PortalSchemaAccessListDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalSchemaAccessList(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalSchemaAccessList_CrtNUIEventsProcess

	/// <exclude/>
	public partial class PortalSchemaAccessList_CrtNUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PortalSchemaAccessList
	{

		public PortalSchemaAccessList_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalSchemaAccessList_CrtNUIEventsProcess";
			SchemaUId = new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b5bda4b9-d2bf-4b39-8ba5-1883ac2583a7");
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

	#region Class: PortalSchemaAccessList_CrtNUIEventsProcess

	/// <exclude/>
	public class PortalSchemaAccessList_CrtNUIEventsProcess : PortalSchemaAccessList_CrtNUIEventsProcess<PortalSchemaAccessList>
	{

		public PortalSchemaAccessList_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalSchemaAccessList_CrtNUIEventsProcess

	public partial class PortalSchemaAccessList_CrtNUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PortalSchemaAccessListEventsProcess

	/// <exclude/>
	public class PortalSchemaAccessListEventsProcess : PortalSchemaAccessList_CrtNUIEventsProcess
	{

		public PortalSchemaAccessListEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

