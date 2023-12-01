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

	#region Class: ProcessInModulesSchema

	/// <exclude/>
	public class ProcessInModulesSchema : Terrasoft.Configuration.ProcessInModules_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ProcessInModulesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProcessInModulesSchema(ProcessInModulesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProcessInModulesSchema(ProcessInModulesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2");
			Name = "ProcessInModules";
			ParentSchemaUId = new Guid("60c0cee6-ecb8-4987-bb4a-053bc314ee8d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("aadb966f-e2f2-4239-b56f-51ba5fdf0533")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("18fd508a-8e32-454d-bd8a-82a9d4028ace")) == null) {
				Columns.Add(CreateParameterUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("aadb966f-e2f2-4239-b56f-51ba5fdf0533"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				ModifiedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				CreatedInPackageId = new Guid("35c77563-f7ec-4c0b-91e3-f2665bae1236")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("18fd508a-8e32-454d-bd8a-82a9d4028ace"),
				Name = @"ParameterUId",
				CreatedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				ModifiedInSchemaUId = new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProcessInModules(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProcessInModules_CrtWizards7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProcessInModulesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProcessInModulesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2"));
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInModules

	/// <summary>
	/// Business processes in sections.
	/// </summary>
	/// <remarks>
	/// Business processes in sections.
	/// </remarks>
	public class ProcessInModules : Terrasoft.Configuration.ProcessInModules_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ProcessInModules(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProcessInModules";
		}

		public ProcessInModules(ProcessInModules source)
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

		/// <summary>
		/// Parameter.
		/// </summary>
		public Guid ParameterUId {
			get {
				return GetTypedColumnValue<Guid>("ParameterUId");
			}
			set {
				SetColumnValue("ParameterUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProcessInModules_CrtWizards7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProcessInModulesDeleted", e);
			Validating += (s, e) => ThrowEvent("ProcessInModulesValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProcessInModules(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInModules_CrtWizards7xEventsProcess

	/// <exclude/>
	public partial class ProcessInModules_CrtWizards7xEventsProcess<TEntity> : Terrasoft.Configuration.ProcessInModules_CrtBaseEventsProcess<TEntity> where TEntity : ProcessInModules
	{

		public ProcessInModules_CrtWizards7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProcessInModules_CrtWizards7xEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3659dc70-dc3e-437f-a4bc-d9a4f9f2b8d2");
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

	#region Class: ProcessInModules_CrtWizards7xEventsProcess

	/// <exclude/>
	public class ProcessInModules_CrtWizards7xEventsProcess : ProcessInModules_CrtWizards7xEventsProcess<ProcessInModules>
	{

		public ProcessInModules_CrtWizards7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProcessInModules_CrtWizards7xEventsProcess

	public partial class ProcessInModules_CrtWizards7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ProcessInModulesEventsProcess

	/// <exclude/>
	public class ProcessInModulesEventsProcess : ProcessInModules_CrtWizards7xEventsProcess
	{

		public ProcessInModulesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

