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

	#region Class: VwMobileSysSchemaSchema

	/// <exclude/>
	public class VwMobileSysSchemaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwMobileSysSchemaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwMobileSysSchemaSchema(VwMobileSysSchemaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwMobileSysSchemaSchema(VwMobileSysSchemaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95c3f0b4-158b-44dc-8877-f342363022ca");
			RealUId = new Guid("95c3f0b4-158b-44dc-8877-f342363022ca");
			Name = "VwMobileSysSchema";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b65e6f51-e44a-4dfb-b0a0-020aebe079c4");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("49a2f994-327c-47c3-8fd7-885166a425c2")) == null) {
				Columns.Add(CreateNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("49a2f994-327c-47c3-8fd7-885166a425c2"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("95c3f0b4-158b-44dc-8877-f342363022ca"),
				ModifiedInSchemaUId = new Guid("95c3f0b4-158b-44dc-8877-f342363022ca"),
				CreatedInPackageId = new Guid("b65e6f51-e44a-4dfb-b0a0-020aebe079c4")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwMobileSysSchema(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwMobileSysSchema_CrtESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwMobileSysSchemaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwMobileSysSchemaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95c3f0b4-158b-44dc-8877-f342363022ca"));
		}

		#endregion

	}

	#endregion

	#region Class: VwMobileSysSchema

	/// <summary>
	/// View of schemas (Mobile).
	/// </summary>
	public class VwMobileSysSchema : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwMobileSysSchema(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwMobileSysSchema";
		}

		public VwMobileSysSchema(VwMobileSysSchema source)
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
			var process = new VwMobileSysSchema_CrtESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwMobileSysSchemaDeleted", e);
			Validating += (s, e) => ThrowEvent("VwMobileSysSchemaValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwMobileSysSchema(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwMobileSysSchema_CrtESNEventsProcess

	/// <exclude/>
	public partial class VwMobileSysSchema_CrtESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwMobileSysSchema
	{

		public VwMobileSysSchema_CrtESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwMobileSysSchema_CrtESNEventsProcess";
			SchemaUId = new Guid("95c3f0b4-158b-44dc-8877-f342363022ca");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95c3f0b4-158b-44dc-8877-f342363022ca");
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

	#region Class: VwMobileSysSchema_CrtESNEventsProcess

	/// <exclude/>
	public class VwMobileSysSchema_CrtESNEventsProcess : VwMobileSysSchema_CrtESNEventsProcess<VwMobileSysSchema>
	{

		public VwMobileSysSchema_CrtESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwMobileSysSchema_CrtESNEventsProcess

	public partial class VwMobileSysSchema_CrtESNEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwMobileSysSchemaEventsProcess

	/// <exclude/>
	public class VwMobileSysSchemaEventsProcess : VwMobileSysSchema_CrtESNEventsProcess
	{

		public VwMobileSysSchemaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

