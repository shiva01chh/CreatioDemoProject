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

	#region Class: EmailSendStatusSchema

	/// <exclude/>
	public class EmailSendStatusSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public EmailSendStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailSendStatusSchema(EmailSendStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailSendStatusSchema(EmailSendStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644");
			RealUId = new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644");
			Name = "EmailSendStatus";
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailSendStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailSendStatus_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailSendStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailSendStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailSendStatus

	/// <summary>
	/// Email Status.
	/// </summary>
	public class EmailSendStatus : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public EmailSendStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailSendStatus";
		}

		public EmailSendStatus(EmailSendStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailSendStatus_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EmailSendStatusDeleted", e);
			Deleting += (s, e) => ThrowEvent("EmailSendStatusDeleting", e);
			Inserted += (s, e) => ThrowEvent("EmailSendStatusInserted", e);
			Inserting += (s, e) => ThrowEvent("EmailSendStatusInserting", e);
			Saved += (s, e) => ThrowEvent("EmailSendStatusSaved", e);
			Saving += (s, e) => ThrowEvent("EmailSendStatusSaving", e);
			Validating += (s, e) => ThrowEvent("EmailSendStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailSendStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailSendStatus_CrtBaseEventsProcess

	/// <exclude/>
	public partial class EmailSendStatus_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : EmailSendStatus
	{

		public EmailSendStatus_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailSendStatus_CrtBaseEventsProcess";
			SchemaUId = new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3f1789f-fb2d-436f-a590-93667c0e8644");
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

	#region Class: EmailSendStatus_CrtBaseEventsProcess

	/// <exclude/>
	public class EmailSendStatus_CrtBaseEventsProcess : EmailSendStatus_CrtBaseEventsProcess<EmailSendStatus>
	{

		public EmailSendStatus_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailSendStatus_CrtBaseEventsProcess

	public partial class EmailSendStatus_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: EmailSendStatusEventsProcess

	/// <exclude/>
	public class EmailSendStatusEventsProcess : EmailSendStatus_CrtBaseEventsProcess
	{

		public EmailSendStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

