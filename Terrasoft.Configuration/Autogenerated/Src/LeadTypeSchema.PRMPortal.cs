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

	#region Class: LeadTypeSchema

	/// <exclude/>
	public class LeadTypeSchema : Terrasoft.Configuration.LeadType_CrtTouchPoint_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadTypeSchema(LeadTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadTypeSchema(LeadTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2977e204-ae9f-41d0-97ff-9f1569355818");
			Name = "LeadType";
			ParentSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888");
			ExtendParent = true;
			CreatedInPackageId = new Guid("10676561-1f93-46bf-90be-fe5cd67025e0");
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
			return new LeadType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadType_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2977e204-ae9f-41d0-97ff-9f1569355818"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadType

	/// <summary>
	/// Lead type.
	/// </summary>
	public class LeadType : Terrasoft.Configuration.LeadType_CrtTouchPoint_Terrasoft
	{

		#region Constructors: Public

		public LeadType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadType";
		}

		public LeadType(LeadType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadType_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadType(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadType_PRMPortalEventsProcess

	/// <exclude/>
	public partial class LeadType_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.LeadType_CrtTouchPointEventsProcess<TEntity> where TEntity : LeadType
	{

		public LeadType_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadType_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2977e204-ae9f-41d0-97ff-9f1569355818");
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

	#region Class: LeadType_PRMPortalEventsProcess

	/// <exclude/>
	public class LeadType_PRMPortalEventsProcess : LeadType_PRMPortalEventsProcess<LeadType>
	{

		public LeadType_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadType_PRMPortalEventsProcess

	public partial class LeadType_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadTypeEventsProcess

	/// <exclude/>
	public class LeadTypeEventsProcess : LeadType_PRMPortalEventsProcess
	{

		public LeadTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

