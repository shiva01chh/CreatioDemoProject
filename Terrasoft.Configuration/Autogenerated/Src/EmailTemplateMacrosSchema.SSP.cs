namespace Terrasoft.Configuration
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

	#region Class: EmailTemplateMacros_SSP_TerrasoftSchema

	/// <exclude/>
	public class EmailTemplateMacros_SSP_TerrasoftSchema : Terrasoft.Configuration.EmailTemplateMacros_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailTemplateMacros_SSP_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplateMacros_SSP_TerrasoftSchema(EmailTemplateMacros_SSP_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplateMacros_SSP_TerrasoftSchema(EmailTemplateMacros_SSP_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6fdf871c-b594-42a5-b617-3d14f4b313a7");
			Name = "EmailTemplateMacros_SSP_Terrasoft";
			ParentSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			ExtendParent = true;
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
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
			return new EmailTemplateMacros_SSP_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EmailTemplateMacros_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EmailTemplateMacros_SSP_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplateMacros_SSP_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fdf871c-b594-42a5-b617-3d14f4b313a7"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros_SSP_Terrasoft

	/// <summary>
	/// Message template macro.
	/// </summary>
	public class EmailTemplateMacros_SSP_Terrasoft : Terrasoft.Configuration.EmailTemplateMacros_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public EmailTemplateMacros_SSP_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplateMacros_SSP_Terrasoft";
		}

		public EmailTemplateMacros_SSP_Terrasoft(EmailTemplateMacros_SSP_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplateMacros_SSPEventsProcess(UserConnection);
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
			return new EmailTemplateMacros_SSP_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros_SSPEventsProcess

	/// <exclude/>
	public partial class EmailTemplateMacros_SSPEventsProcess<TEntity> : Terrasoft.Configuration.EmailTemplateMacros_CrtBaseEventsProcess<TEntity> where TEntity : EmailTemplateMacros_SSP_Terrasoft
	{

		public EmailTemplateMacros_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateMacros_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6fdf871c-b594-42a5-b617-3d14f4b313a7");
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

	#region Class: EmailTemplateMacros_SSPEventsProcess

	/// <exclude/>
	public class EmailTemplateMacros_SSPEventsProcess : EmailTemplateMacros_SSPEventsProcess<EmailTemplateMacros_SSP_Terrasoft>
	{

		public EmailTemplateMacros_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateMacros_SSPEventsProcess

	public partial class EmailTemplateMacros_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

