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

	#region Class: EmailTypeSchema

	/// <exclude/>
	public class EmailTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public EmailTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTypeSchema(EmailTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTypeSchema(EmailTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			RealUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			Name = "EmailType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
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
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailType

	/// <summary>
	/// Message type.
	/// </summary>
	public class EmailType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public EmailType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailType";
		}

		public EmailType(EmailType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("EmailTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("EmailTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("EmailTypeInserting", e);
			Saved += (s, e) => ThrowEvent("EmailTypeSaved", e);
			Saving += (s, e) => ThrowEvent("EmailTypeSaving", e);
			Validating += (s, e) => ThrowEvent("EmailTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailType(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class EmailType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailType
	{

		public EmailType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailType_CrtBaseEventsProcess";
			SchemaUId = new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4b276ad6-71c1-4b9a-be9d-379edc60012f");
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

	#region Class: EmailType_CrtBaseEventsProcess

	/// <exclude/>
	public class EmailType_CrtBaseEventsProcess : EmailType_CrtBaseEventsProcess<EmailType>
	{

		public EmailType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailType_CrtBaseEventsProcess

	public partial class EmailType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailTypeEventsProcess

	/// <exclude/>
	public class EmailTypeEventsProcess : EmailType_CrtBaseEventsProcess
	{

		public EmailTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

