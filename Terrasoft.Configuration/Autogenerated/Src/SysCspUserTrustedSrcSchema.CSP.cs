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

	#region Class: SysCspUserTrustedSrcSchema

	/// <exclude/>
	public class SysCspUserTrustedSrcSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysCspUserTrustedSrcSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysCspUserTrustedSrcSchema(SysCspUserTrustedSrcSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysCspUserTrustedSrcSchema(SysCspUserTrustedSrcSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb");
			RealUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb");
			Name = "SysCspUserTrustedSrc";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dbae63b3-eab2-4127-8e3e-deebbfbf14cd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			TrackChangesSchemaName = @"SysCspUserTrustedSrcLog";
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateSourceColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5d3a4b62-1fe1-91d2-9d12-ea6fed370cea")) == null) {
				Columns.Add(CreateActiveColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8ce3c720-3800-3340-ab7f-3709bc15adfe"),
				Name = @"Source",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb"),
				ModifiedInSchemaUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb"),
				CreatedInPackageId = new Guid("f6147369-2235-4333-9a9c-5ab3c877b226"),
				IsTrackChangesInDB = true
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5d3a4b62-1fe1-91d2-9d12-ea6fed370cea"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb"),
				ModifiedInSchemaUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb"),
				CreatedInPackageId = new Guid("f6147369-2235-4333-9a9c-5ab3c877b226"),
				IsTrackChangesInDB = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysCspUserTrustedSrc(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysCspUserTrustedSrc_CSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysCspUserTrustedSrcSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysCspUserTrustedSrcSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb"));
		}

		#endregion

	}

	#endregion

	#region Class: SysCspUserTrustedSrc

	/// <summary>
	/// Trusted source of content.
	/// </summary>
	public class SysCspUserTrustedSrc : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysCspUserTrustedSrc(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysCspUserTrustedSrc";
		}

		public SysCspUserTrustedSrc(SysCspUserTrustedSrc source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Source URL.
		/// </summary>
		public string Source {
			get {
				return GetTypedColumnValue<string>("Source");
			}
			set {
				SetColumnValue("Source", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysCspUserTrustedSrc_CSPEventsProcess(UserConnection);
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
			return new SysCspUserTrustedSrc(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysCspUserTrustedSrc_CSPEventsProcess

	/// <exclude/>
	public partial class SysCspUserTrustedSrc_CSPEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysCspUserTrustedSrc
	{

		public SysCspUserTrustedSrc_CSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysCspUserTrustedSrc_CSPEventsProcess";
			SchemaUId = new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c42f486b-5b2e-4a87-832b-da62372fadeb");
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

	#region Class: SysCspUserTrustedSrc_CSPEventsProcess

	/// <exclude/>
	public class SysCspUserTrustedSrc_CSPEventsProcess : SysCspUserTrustedSrc_CSPEventsProcess<SysCspUserTrustedSrc>
	{

		public SysCspUserTrustedSrc_CSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysCspUserTrustedSrc_CSPEventsProcess

	public partial class SysCspUserTrustedSrc_CSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysCspUserTrustedSrcEventsProcess

	/// <exclude/>
	public class SysCspUserTrustedSrcEventsProcess : SysCspUserTrustedSrc_CSPEventsProcess
	{

		public SysCspUserTrustedSrcEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

