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

	#region Class: LinkPreviewDataSchema

	/// <exclude/>
	public class LinkPreviewDataSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LinkPreviewDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LinkPreviewDataSchema(LinkPreviewDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LinkPreviewDataSchema(LinkPreviewDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419");
			RealUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419");
			Name = "LinkPreviewData";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUrlColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d6071aec-7191-4873-899c-d8f39a38587a")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("3efa32f9-ac88-4e8f-af4b-152f309400a3")) == null) {
				Columns.Add(CreateDataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d6071aec-7191-4873-899c-d8f39a38587a"),
				Name = @"EntityId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				ModifiedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("3efa32f9-ac88-4e8f-af4b-152f309400a3"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				ModifiedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			};
		}

		protected virtual EntitySchemaColumn CreateUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("7df19a69-086a-4937-8159-569a2d69ce86"),
				Name = @"Url",
				CreatedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				ModifiedInSchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"),
				CreatedInPackageId = new Guid("5bdc21ce-6c09-4da3-b22d-c3e4fd10c6a0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LinkPreviewData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LinkPreviewData_LinkPreviewEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LinkPreviewDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LinkPreviewDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419"));
		}

		#endregion

	}

	#endregion

	#region Class: LinkPreviewData

	/// <summary>
	/// Link preview data.
	/// </summary>
	public class LinkPreviewData : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LinkPreviewData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LinkPreviewData";
		}

		public LinkPreviewData(LinkPreviewData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Entity id.
		/// </summary>
		public Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		/// <summary>
		/// Url.
		/// </summary>
		public string Url {
			get {
				return GetTypedColumnValue<string>("Url");
			}
			set {
				SetColumnValue("Url", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LinkPreviewData_LinkPreviewEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LinkPreviewDataDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LinkPreviewData(this);
		}

		#endregion

	}

	#endregion

	#region Class: LinkPreviewData_LinkPreviewEventsProcess

	/// <exclude/>
	public partial class LinkPreviewData_LinkPreviewEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LinkPreviewData
	{

		public LinkPreviewData_LinkPreviewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LinkPreviewData_LinkPreviewEventsProcess";
			SchemaUId = new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1d051f81-f49b-43c0-bc92-59cbc1b70419");
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

	#region Class: LinkPreviewData_LinkPreviewEventsProcess

	/// <exclude/>
	public class LinkPreviewData_LinkPreviewEventsProcess : LinkPreviewData_LinkPreviewEventsProcess<LinkPreviewData>
	{

		public LinkPreviewData_LinkPreviewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LinkPreviewData_LinkPreviewEventsProcess

	public partial class LinkPreviewData_LinkPreviewEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LinkPreviewDataEventsProcess

	/// <exclude/>
	public class LinkPreviewDataEventsProcess : LinkPreviewData_LinkPreviewEventsProcess
	{

		public LinkPreviewDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

