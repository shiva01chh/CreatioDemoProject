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

	#region Class: LeadInTagSchema

	/// <exclude/>
	public class LeadInTagSchema : Terrasoft.Configuration.LeadInTag_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadInTagSchema(LeadInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadInTagSchema(LeadInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("96d7f171-6290-4c54-b32b-0d8f2e23252f");
			Name = "LeadInTag";
			ParentSchemaUId = new Guid("b82de9e2-1c9c-4da1-8c8e-69b279e74bc0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0fffc5a3-cd85-4e12-bfdb-f47322f14e3d");
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
			return new LeadInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadInTag_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96d7f171-6290-4c54-b32b-0d8f2e23252f"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadInTag

	/// <summary>
	/// Leads section record tag.
	/// </summary>
	public class LeadInTag : Terrasoft.Configuration.LeadInTag_Lead_Terrasoft
	{

		#region Constructors: Public

		public LeadInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadInTag";
		}

		public LeadInTag(LeadInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadInTag_PRMPortalEventsProcess(UserConnection);
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
			return new LeadInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadInTag_PRMPortalEventsProcess

	/// <exclude/>
	public partial class LeadInTag_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.LeadInTag_LeadEventsProcess<TEntity> where TEntity : LeadInTag
	{

		public LeadInTag_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadInTag_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("96d7f171-6290-4c54-b32b-0d8f2e23252f");
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

	#region Class: LeadInTag_PRMPortalEventsProcess

	/// <exclude/>
	public class LeadInTag_PRMPortalEventsProcess : LeadInTag_PRMPortalEventsProcess<LeadInTag>
	{

		public LeadInTag_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadInTag_PRMPortalEventsProcess

	public partial class LeadInTag_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadInTagEventsProcess

	/// <exclude/>
	public class LeadInTagEventsProcess : LeadInTag_PRMPortalEventsProcess
	{

		public LeadInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

