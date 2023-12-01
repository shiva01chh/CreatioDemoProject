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

	#region Class: LeadSourceSchema

	/// <exclude/>
	public class LeadSourceSchema : Terrasoft.Configuration.LeadSource_CrtTouchPoint_TerrasoftSchema
	{

		#region Constructors: Public

		public LeadSourceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadSourceSchema(LeadSourceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadSourceSchema(LeadSourceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("50da16d1-eded-4e58-adc2-082493bcc46d");
			Name = "LeadSource";
			ParentSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6");
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
			return new LeadSource(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadSource_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadSourceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadSourceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50da16d1-eded-4e58-adc2-082493bcc46d"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadSource

	/// <summary>
	/// Source.
	/// </summary>
	public class LeadSource : Terrasoft.Configuration.LeadSource_CrtTouchPoint_Terrasoft
	{

		#region Constructors: Public

		public LeadSource(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadSource";
		}

		public LeadSource(LeadSource source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadSource_PRMPortalEventsProcess(UserConnection);
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
			return new LeadSource(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadSource_PRMPortalEventsProcess

	/// <exclude/>
	public partial class LeadSource_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.LeadSource_CrtTouchPointEventsProcess<TEntity> where TEntity : LeadSource
	{

		public LeadSource_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadSource_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("50da16d1-eded-4e58-adc2-082493bcc46d");
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

	#region Class: LeadSource_PRMPortalEventsProcess

	/// <exclude/>
	public class LeadSource_PRMPortalEventsProcess : LeadSource_PRMPortalEventsProcess<LeadSource>
	{

		public LeadSource_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadSource_PRMPortalEventsProcess

	public partial class LeadSource_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadSourceEventsProcess

	/// <exclude/>
	public class LeadSourceEventsProcess : LeadSource_PRMPortalEventsProcess
	{

		public LeadSourceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

