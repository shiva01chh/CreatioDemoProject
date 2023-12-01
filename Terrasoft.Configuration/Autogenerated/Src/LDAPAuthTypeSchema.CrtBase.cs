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

	#region Class: LDAPAuthTypeSchema

	/// <exclude/>
	public class LDAPAuthTypeSchema : Terrasoft.Configuration.BaseValueLookupSchema
	{

		#region Constructors: Public

		public LDAPAuthTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LDAPAuthTypeSchema(LDAPAuthTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LDAPAuthTypeSchema(LDAPAuthTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			RealUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			Name = "LDAPAuthType";
			ParentSchemaUId = new Guid("04f67f0c-0a27-4616-987e-60e378854b0f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LDAPAuthType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LDAPAuthType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LDAPAuthTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LDAPAuthTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f37c41d-9573-4c01-9d4d-41949787839d"));
		}

		#endregion

	}

	#endregion

	#region Class: LDAPAuthType

	/// <summary>
	/// LDAP authentication type.
	/// </summary>
	public class LDAPAuthType : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public LDAPAuthType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LDAPAuthType";
		}

		public LDAPAuthType(LDAPAuthType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LDAPAuthType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LDAPAuthTypeDeleted", e);
			Inserting += (s, e) => ThrowEvent("LDAPAuthTypeInserting", e);
			Validating += (s, e) => ThrowEvent("LDAPAuthTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LDAPAuthType(this);
		}

		#endregion

	}

	#endregion

	#region Class: LDAPAuthType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class LDAPAuthType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseValueLookup_CrtBaseEventsProcess<TEntity> where TEntity : LDAPAuthType
	{

		public LDAPAuthType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LDAPAuthType_CrtBaseEventsProcess";
			SchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
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

	#region Class: LDAPAuthType_CrtBaseEventsProcess

	/// <exclude/>
	public class LDAPAuthType_CrtBaseEventsProcess : LDAPAuthType_CrtBaseEventsProcess<LDAPAuthType>
	{

		public LDAPAuthType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LDAPAuthType_CrtBaseEventsProcess

	public partial class LDAPAuthType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LDAPAuthTypeEventsProcess

	/// <exclude/>
	public class LDAPAuthTypeEventsProcess : LDAPAuthType_CrtBaseEventsProcess
	{

		public LDAPAuthTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

