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
	using Terrasoft.Configuration.PRM;
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

	#region Class: FundSchema

	/// <exclude/>
	public class FundSchema : Terrasoft.Configuration.Fund_PRMBase_TerrasoftSchema
	{

		#region Constructors: Public

		public FundSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FundSchema(FundSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FundSchema(FundSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fb594840-a962-4ff1-920f-ee851f95ab3a");
			Name = "Fund";
			ParentSchemaUId = new Guid("9a734110-378e-4108-9383-726930984f2e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("be128478-78b2-4e0c-970c-9dfa8eab194e");
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
			return new Fund(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Fund_PRMMktgActivitiesPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FundSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FundSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb594840-a962-4ff1-920f-ee851f95ab3a"));
		}

		#endregion

	}

	#endregion

	#region Class: Fund

	/// <summary>
	/// Fund.
	/// </summary>
	public class Fund : Terrasoft.Configuration.Fund_PRMBase_Terrasoft
	{

		#region Constructors: Public

		public Fund(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Fund";
		}

		public Fund(Fund source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Fund_PRMMktgActivitiesPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("FundDeleted", e);
			Validating += (s, e) => ThrowEvent("FundValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Fund(this);
		}

		#endregion

	}

	#endregion

	#region Class: Fund_PRMMktgActivitiesPortalEventsProcess

	/// <exclude/>
	public partial class Fund_PRMMktgActivitiesPortalEventsProcess<TEntity> : Terrasoft.Configuration.Fund_PRMBaseEventsProcess<TEntity> where TEntity : Fund
	{

		public Fund_PRMMktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Fund_PRMMktgActivitiesPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fb594840-a962-4ff1-920f-ee851f95ab3a");
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

	#region Class: Fund_PRMMktgActivitiesPortalEventsProcess

	/// <exclude/>
	public class Fund_PRMMktgActivitiesPortalEventsProcess : Fund_PRMMktgActivitiesPortalEventsProcess<Fund>
	{

		public Fund_PRMMktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Fund_PRMMktgActivitiesPortalEventsProcess

	public partial class Fund_PRMMktgActivitiesPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FundEventsProcess

	/// <exclude/>
	public class FundEventsProcess : Fund_PRMMktgActivitiesPortalEventsProcess
	{

		public FundEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

