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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: OpportunityTagSchema

	/// <exclude/>
	public class OpportunityTagSchema : Terrasoft.Configuration.OpportunityTag_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunityTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityTagSchema(OpportunityTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityTagSchema(OpportunityTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d4e111a9-c509-42f3-bf67-37ce311a5087");
			Name = "OpportunityTag";
			ParentSchemaUId = new Guid("7e18476b-185f-406b-b415-b942b35b4c0b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("580620fc-064a-4cdc-95d9-80175a4d3b0d");
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
			return new OpportunityTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityTag_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4e111a9-c509-42f3-bf67-37ce311a5087"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTag

	/// <summary>
	/// Opportunities section tag.
	/// </summary>
	public class OpportunityTag : Terrasoft.Configuration.OpportunityTag_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunityTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityTag";
		}

		public OpportunityTag(OpportunityTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityTag_PRMPortalEventsProcess(UserConnection);
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
			return new OpportunityTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityTag_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OpportunityTag_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OpportunityTag_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunityTag
	{

		public OpportunityTag_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityTag_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d4e111a9-c509-42f3-bf67-37ce311a5087");
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

	#region Class: OpportunityTag_PRMPortalEventsProcess

	/// <exclude/>
	public class OpportunityTag_PRMPortalEventsProcess : OpportunityTag_PRMPortalEventsProcess<OpportunityTag>
	{

		public OpportunityTag_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityTag_PRMPortalEventsProcess

	public partial class OpportunityTag_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityTagEventsProcess

	/// <exclude/>
	public class OpportunityTagEventsProcess : OpportunityTag_PRMPortalEventsProcess
	{

		public OpportunityTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

