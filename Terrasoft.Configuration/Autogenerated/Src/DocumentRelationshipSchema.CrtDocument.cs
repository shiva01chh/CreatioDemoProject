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

	#region Class: DocumentRelationshipSchema

	/// <exclude/>
	public class DocumentRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DocumentRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DocumentRelationshipSchema(DocumentRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DocumentRelationshipSchema(DocumentRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			RealUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			Name = "DocumentRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dbbc32c7-bce6-455f-9003-ea928b705dc7")) == null) {
				Columns.Add(CreateDocumentAColumn());
			}
			if (Columns.FindByUId(new Guid("ed6b9265-f38d-4097-bb04-834186dbd51f")) == null) {
				Columns.Add(CreateDocumentBColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDocumentAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dbbc32c7-bce6-455f-9003-ea928b705dc7"),
				Name = @"DocumentA",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				ModifiedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c")
			};
		}

		protected virtual EntitySchemaColumn CreateDocumentBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ed6b9265-f38d-4097-bb04-834186dbd51f"),
				Name = @"DocumentB",
				ReferenceSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				ModifiedInSchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2"),
				CreatedInPackageId = new Guid("93f2b0e4-b421-42dc-86e5-35e5b932239c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DocumentRelationship(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DocumentRelationship_CrtDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DocumentRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DocumentRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("779e5db8-6738-4148-8e68-c235ba046df2"));
		}

		#endregion

	}

	#endregion

	#region Class: DocumentRelationship

	/// <summary>
	/// Document relationships.
	/// </summary>
	public class DocumentRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DocumentRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DocumentRelationship";
		}

		public DocumentRelationship(DocumentRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DocumentAId {
			get {
				return GetTypedColumnValue<Guid>("DocumentAId");
			}
			set {
				SetColumnValue("DocumentAId", value);
				_documentA = null;
			}
		}

		/// <exclude/>
		public string DocumentANumber {
			get {
				return GetTypedColumnValue<string>("DocumentANumber");
			}
			set {
				SetColumnValue("DocumentANumber", value);
				if (_documentA != null) {
					_documentA.Number = value;
				}
			}
		}

		private Document _documentA;
		/// <summary>
		/// Document.
		/// </summary>
		public Document DocumentA {
			get {
				return _documentA ??
					(_documentA = LookupColumnEntities.GetEntity("DocumentA") as Document);
			}
		}

		/// <exclude/>
		public Guid DocumentBId {
			get {
				return GetTypedColumnValue<Guid>("DocumentBId");
			}
			set {
				SetColumnValue("DocumentBId", value);
				_documentB = null;
			}
		}

		/// <exclude/>
		public string DocumentBNumber {
			get {
				return GetTypedColumnValue<string>("DocumentBNumber");
			}
			set {
				SetColumnValue("DocumentBNumber", value);
				if (_documentB != null) {
					_documentB.Number = value;
				}
			}
		}

		private Document _documentB;
		/// <summary>
		/// Connected document.
		/// </summary>
		public Document DocumentB {
			get {
				return _documentB ??
					(_documentB = LookupColumnEntities.GetEntity("DocumentB") as Document);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DocumentRelationship_CrtDocumentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DocumentRelationshipDeleted", e);
			Validating += (s, e) => ThrowEvent("DocumentRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DocumentRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: DocumentRelationship_CrtDocumentEventsProcess

	/// <exclude/>
	public partial class DocumentRelationship_CrtDocumentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DocumentRelationship
	{

		public DocumentRelationship_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DocumentRelationship_CrtDocumentEventsProcess";
			SchemaUId = new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("779e5db8-6738-4148-8e68-c235ba046df2");
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

	#region Class: DocumentRelationship_CrtDocumentEventsProcess

	/// <exclude/>
	public class DocumentRelationship_CrtDocumentEventsProcess : DocumentRelationship_CrtDocumentEventsProcess<DocumentRelationship>
	{

		public DocumentRelationship_CrtDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DocumentRelationship_CrtDocumentEventsProcess

	public partial class DocumentRelationship_CrtDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DocumentRelationshipEventsProcess

	/// <exclude/>
	public class DocumentRelationshipEventsProcess : DocumentRelationship_CrtDocumentEventsProcess
	{

		public DocumentRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

