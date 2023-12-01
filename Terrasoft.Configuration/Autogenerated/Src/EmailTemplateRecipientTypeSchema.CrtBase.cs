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

	#region Class: EmailTemplateRecipientTypeSchema

	/// <exclude/>
	public class EmailTemplateRecipientTypeSchema : Terrasoft.Configuration.SysCodeLookupSchema
	{

		#region Constructors: Public

		public EmailTemplateRecipientTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplateRecipientTypeSchema(EmailTemplateRecipientTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplateRecipientTypeSchema(EmailTemplateRecipientTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
			RealUId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
			Name = "EmailTemplateRecipientType";
			ParentSchemaUId = new Guid("28699730-9cf0-4702-87a9-c64d612e4b14");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysEmailTemplRecipientTypeLcz";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
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
			return new EmailTemplateRecipientType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailTemplateRecipientType_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTemplateRecipientTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplateRecipientTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1505d4af-661b-4548-8682-4233d07e7aca"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateRecipientType

	/// <summary>
	/// Types of recipients in email message template.
	/// </summary>
	public class EmailTemplateRecipientType : Terrasoft.Configuration.SysCodeLookup
	{

		#region Constructors: Public

		public EmailTemplateRecipientType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplateRecipientType";
		}

		public EmailTemplateRecipientType(EmailTemplateRecipientType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplateRecipientType_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailTemplateRecipientTypeDeleted", e);
			Inserting += (s, e) => ThrowEvent("EmailTemplateRecipientTypeInserting", e);
			Validating += (s, e) => ThrowEvent("EmailTemplateRecipientTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplateRecipientType(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateRecipientType_CrtBaseEventsProcess

	/// <exclude/>
	public partial class EmailTemplateRecipientType_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.SysCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailTemplateRecipientType
	{

		public EmailTemplateRecipientType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateRecipientType_CrtBaseEventsProcess";
			SchemaUId = new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1505d4af-661b-4548-8682-4233d07e7aca");
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

	#region Class: EmailTemplateRecipientType_CrtBaseEventsProcess

	/// <exclude/>
	public class EmailTemplateRecipientType_CrtBaseEventsProcess : EmailTemplateRecipientType_CrtBaseEventsProcess<EmailTemplateRecipientType>
	{

		public EmailTemplateRecipientType_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateRecipientType_CrtBaseEventsProcess

	public partial class EmailTemplateRecipientType_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailTemplateRecipientTypeEventsProcess

	/// <exclude/>
	public class EmailTemplateRecipientTypeEventsProcess : EmailTemplateRecipientType_CrtBaseEventsProcess
	{

		public EmailTemplateRecipientTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

