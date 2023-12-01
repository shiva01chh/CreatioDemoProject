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

	#region Class: OpportunitySourceSchema

	/// <exclude/>
	public class OpportunitySourceSchema : Terrasoft.Configuration.OpportunitySource_CrtOpportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OpportunitySourceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunitySourceSchema(OpportunitySourceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunitySourceSchema(OpportunitySourceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ee7784af-32b5-4ff7-8f5b-a4d8c7218019");
			Name = "OpportunitySource";
			ParentSchemaUId = new Guid("6f66df29-03a2-41b3-9cde-021eeeedfcb0");
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
			return new OpportunitySource(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunitySource_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunitySourceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunitySourceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee7784af-32b5-4ff7-8f5b-a4d8c7218019"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunitySource

	/// <summary>
	/// Source.
	/// </summary>
	public class OpportunitySource : Terrasoft.Configuration.OpportunitySource_CrtOpportunity_Terrasoft
	{

		#region Constructors: Public

		public OpportunitySource(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunitySource";
		}

		public OpportunitySource(OpportunitySource source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunitySource_PRMPortalEventsProcess(UserConnection);
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
			return new OpportunitySource(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunitySource_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OpportunitySource_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OpportunitySource_CrtOpportunityEventsProcess<TEntity> where TEntity : OpportunitySource
	{

		public OpportunitySource_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunitySource_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ee7784af-32b5-4ff7-8f5b-a4d8c7218019");
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

	#region Class: OpportunitySource_PRMPortalEventsProcess

	/// <exclude/>
	public class OpportunitySource_PRMPortalEventsProcess : OpportunitySource_PRMPortalEventsProcess<OpportunitySource>
	{

		public OpportunitySource_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunitySource_PRMPortalEventsProcess

	public partial class OpportunitySource_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunitySourceEventsProcess

	/// <exclude/>
	public class OpportunitySourceEventsProcess : OpportunitySource_PRMPortalEventsProcess
	{

		public OpportunitySourceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

