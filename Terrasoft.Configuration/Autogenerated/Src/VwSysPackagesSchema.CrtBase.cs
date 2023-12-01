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

	#region Class: VwSysPackagesSchema

	/// <exclude/>
	public class VwSysPackagesSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSysPackagesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysPackagesSchema(VwSysPackagesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysPackagesSchema(VwSysPackagesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916");
			RealUId = new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916");
			Name = "VwSysPackages";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("1234f32b-eaf1-4f76-b06d-73277e6c9746");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("19feb774-4458-4375-b47e-49a26f0d5548"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916"),
				ModifiedInSchemaUId = new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916"),
				CreatedInPackageId = new Guid("1234f32b-eaf1-4f76-b06d-73277e6c9746")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysPackages(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSysPackages_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSysPackagesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysPackagesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysPackages

	/// <summary>
	/// Packages (view).
	/// </summary>
	public class VwSysPackages : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSysPackages(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysPackages";
		}

		public VwSysPackages(VwSysPackages source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysPackages_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysPackagesDeleted", e);
			Validating += (s, e) => ThrowEvent("VwSysPackagesValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysPackages(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysPackages_CrtBaseEventsProcess

	/// <exclude/>
	public partial class VwSysPackages_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwSysPackages
	{

		public VwSysPackages_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysPackages_CrtBaseEventsProcess";
			SchemaUId = new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95c5a559-0f91-4d4f-b0b3-62d226875916");
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

	#region Class: VwSysPackages_CrtBaseEventsProcess

	/// <exclude/>
	public class VwSysPackages_CrtBaseEventsProcess : VwSysPackages_CrtBaseEventsProcess<VwSysPackages>
	{

		public VwSysPackages_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysPackages_CrtBaseEventsProcess

	public partial class VwSysPackages_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSysPackagesEventsProcess

	/// <exclude/>
	public class VwSysPackagesEventsProcess : VwSysPackages_CrtBaseEventsProcess
	{

		public VwSysPackagesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

