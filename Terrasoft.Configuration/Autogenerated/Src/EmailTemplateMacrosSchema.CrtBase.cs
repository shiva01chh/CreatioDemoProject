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

	#region Class: EmailTemplateMacros_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class EmailTemplateMacros_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public EmailTemplateMacros_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplateMacros_CrtBase_TerrasoftSchema(EmailTemplateMacros_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplateMacros_CrtBase_TerrasoftSchema(EmailTemplateMacros_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			RealUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			Name = "EmailTemplateMacros_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b1d7018a-8f0d-4913-91b0-93331066fbac")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("af1e4ae4-76c6-47fc-b98c-592541d69d3d")) == null) {
				Columns.Add(CreateParentColumn());
			}
			if (Columns.FindByUId(new Guid("331466e8-84a2-407b-aea7-b51166d84f37")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("68e1ebb9-eaec-4373-a26c-a806d808b5a4")) == null) {
				Columns.Add(CreateAccountCommunicationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("675f0417-546f-4be1-b2f0-52c00d759191")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("9c0bdcfe-57bc-4af6-8b70-4d3d711cb95a")) == null) {
				Columns.Add(CreateIsInactiveColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			column.CreatedInPackageId = new Guid("b58d2c33-e1a2-4365-b7e9-3120dc2c01fc");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b1d7018a-8f0d-4913-91b0-93331066fbac"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateParentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("af1e4ae4-76c6-47fc-b98c-592541d69d3d"),
				Name = @"Parent",
				ReferenceSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("331466e8-84a2-407b-aea7-b51166d84f37"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountCommunicationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("68e1ebb9-eaec-4373-a26c-a806d808b5a4"),
				Name = @"AccountCommunicationType",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("675f0417-546f-4be1-b2f0-52c00d759191"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInactiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9c0bdcfe-57bc-4af6-8b70-4d3d711cb95a"),
				Name = @"IsInactive",
				CreatedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				ModifiedInSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"),
				CreatedInPackageId = new Guid("1f1eb0dc-e274-47d3-beeb-4d9125c29451")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailTemplateMacros_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailTemplateMacros_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTemplateMacros_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplateMacros_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros_CrtBase_Terrasoft

	/// <summary>
	/// Message template macro.
	/// </summary>
	public class EmailTemplateMacros_CrtBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public EmailTemplateMacros_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplateMacros_CrtBase_Terrasoft";
		}

		public EmailTemplateMacros_CrtBase_Terrasoft(EmailTemplateMacros_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <exclude/>
		public Guid ParentId {
			get {
				return GetTypedColumnValue<Guid>("ParentId");
			}
			set {
				SetColumnValue("ParentId", value);
				_parent = null;
			}
		}

		/// <exclude/>
		public string ParentName {
			get {
				return GetTypedColumnValue<string>("ParentName");
			}
			set {
				SetColumnValue("ParentName", value);
				if (_parent != null) {
					_parent.Name = value;
				}
			}
		}

		private EmailTemplateMacros _parent;
		/// <summary>
		/// Parent.
		/// </summary>
		public EmailTemplateMacros Parent {
			get {
				return _parent ??
					(_parent = LookupColumnEntities.GetEntity("Parent") as EmailTemplateMacros);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <exclude/>
		public Guid AccountCommunicationTypeId {
			get {
				return GetTypedColumnValue<Guid>("AccountCommunicationTypeId");
			}
			set {
				SetColumnValue("AccountCommunicationTypeId", value);
				_accountCommunicationType = null;
			}
		}

		/// <exclude/>
		public string AccountCommunicationTypeName {
			get {
				return GetTypedColumnValue<string>("AccountCommunicationTypeName");
			}
			set {
				SetColumnValue("AccountCommunicationTypeName", value);
				if (_accountCommunicationType != null) {
					_accountCommunicationType.Name = value;
				}
			}
		}

		private CommunicationType _accountCommunicationType;
		/// <summary>
		/// Account communication option type.
		/// </summary>
		public CommunicationType AccountCommunicationType {
			get {
				return _accountCommunicationType ??
					(_accountCommunicationType = LookupColumnEntities.GetEntity("AccountCommunicationType") as CommunicationType);
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

		/// <summary>
		/// Inactive.
		/// </summary>
		public bool IsInactive {
			get {
				return GetTypedColumnValue<bool>("IsInactive");
			}
			set {
				SetColumnValue("IsInactive", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplateMacros_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("EmailTemplateMacros_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplateMacros_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros_CrtBaseEventsProcess

	/// <exclude/>
	public partial class EmailTemplateMacros_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailTemplateMacros_CrtBase_Terrasoft
	{

		public EmailTemplateMacros_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateMacros_CrtBaseEventsProcess";
			SchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
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

	#region Class: EmailTemplateMacros_CrtBaseEventsProcess

	/// <exclude/>
	public class EmailTemplateMacros_CrtBaseEventsProcess : EmailTemplateMacros_CrtBaseEventsProcess<EmailTemplateMacros_CrtBase_Terrasoft>
	{

		public EmailTemplateMacros_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateMacros_CrtBaseEventsProcess

	public partial class EmailTemplateMacros_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

