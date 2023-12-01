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

	#region Class: CaseRuleHandlerSchema

	/// <exclude/>
	public class CaseRuleHandlerSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CaseRuleHandlerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseRuleHandlerSchema(CaseRuleHandlerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseRuleHandlerSchema(CaseRuleHandlerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3");
			RealUId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3");
			Name = "CaseRuleHandler";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c6b41787-b1ab-445b-9637-b4eeff7591c4")) == null) {
				Columns.Add(CreateClassNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c6b41787-b1ab-445b-9637-b4eeff7591c4"),
				Name = @"ClassName",
				CreatedInSchemaUId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3"),
				ModifiedInSchemaUId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseRuleHandler(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseRuleHandler_CaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseRuleHandlerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseRuleHandlerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseRuleHandler

	/// <summary>
	/// Handlers for case terms actions.
	/// </summary>
	public class CaseRuleHandler : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CaseRuleHandler(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseRuleHandler";
		}

		public CaseRuleHandler(CaseRuleHandler source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Class name.
		/// </summary>
		public string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseRuleHandler_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseRuleHandlerDeleted", e);
			Validating += (s, e) => ThrowEvent("CaseRuleHandlerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseRuleHandler(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseRuleHandler_CaseEventsProcess

	/// <exclude/>
	public partial class CaseRuleHandler_CaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : CaseRuleHandler
	{

		public CaseRuleHandler_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseRuleHandler_CaseEventsProcess";
			SchemaUId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3");
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

	#region Class: CaseRuleHandler_CaseEventsProcess

	/// <exclude/>
	public class CaseRuleHandler_CaseEventsProcess : CaseRuleHandler_CaseEventsProcess<CaseRuleHandler>
	{

		public CaseRuleHandler_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseRuleHandler_CaseEventsProcess

	public partial class CaseRuleHandler_CaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseRuleHandlerEventsProcess

	/// <exclude/>
	public class CaseRuleHandlerEventsProcess : CaseRuleHandler_CaseEventsProcess
	{

		public CaseRuleHandlerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

