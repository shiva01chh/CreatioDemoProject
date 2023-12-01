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

	#region Class: OperatorRoutingRulesSchema

	/// <exclude/>
	public class OperatorRoutingRulesSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OperatorRoutingRulesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OperatorRoutingRulesSchema(OperatorRoutingRulesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OperatorRoutingRulesSchema(OperatorRoutingRulesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2");
			RealUId = new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2");
			Name = "OperatorRoutingRules";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e6990794-bd9f-43f8-bd6a-a6c664242e6b")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e6990794-bd9f-43f8-bd6a-a6c664242e6b"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2"),
				ModifiedInSchemaUId = new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2"),
				CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OperatorRoutingRules(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OperatorRoutingRules_OmnichannelMessagingEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OperatorRoutingRulesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OperatorRoutingRulesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2"));
		}

		#endregion

	}

	#endregion

	#region Class: OperatorRoutingRules

	/// <summary>
	/// Rules for routing chat queue operators.
	/// </summary>
	public class OperatorRoutingRules : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OperatorRoutingRules(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OperatorRoutingRules";
		}

		public OperatorRoutingRules(OperatorRoutingRules source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OperatorRoutingRules_OmnichannelMessagingEventsProcess(UserConnection);
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
			return new OperatorRoutingRules(this);
		}

		#endregion

	}

	#endregion

	#region Class: OperatorRoutingRules_OmnichannelMessagingEventsProcess

	/// <exclude/>
	public partial class OperatorRoutingRules_OmnichannelMessagingEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OperatorRoutingRules
	{

		public OperatorRoutingRules_OmnichannelMessagingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OperatorRoutingRules_OmnichannelMessagingEventsProcess";
			SchemaUId = new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b50aefe5-94b9-49a4-bdba-d91846c5d2c2");
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

	#region Class: OperatorRoutingRules_OmnichannelMessagingEventsProcess

	/// <exclude/>
	public class OperatorRoutingRules_OmnichannelMessagingEventsProcess : OperatorRoutingRules_OmnichannelMessagingEventsProcess<OperatorRoutingRules>
	{

		public OperatorRoutingRules_OmnichannelMessagingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OperatorRoutingRules_OmnichannelMessagingEventsProcess

	public partial class OperatorRoutingRules_OmnichannelMessagingEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OperatorRoutingRulesEventsProcess

	/// <exclude/>
	public class OperatorRoutingRulesEventsProcess : OperatorRoutingRules_OmnichannelMessagingEventsProcess
	{

		public OperatorRoutingRulesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

