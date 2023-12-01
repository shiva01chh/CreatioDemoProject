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

	#region Class: OppContactMotivatorSchema

	/// <exclude/>
	public class OppContactMotivatorSchema : Terrasoft.Configuration.OppContactMotivator_Opportunity_TerrasoftSchema
	{

		#region Constructors: Public

		public OppContactMotivatorSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OppContactMotivatorSchema(OppContactMotivatorSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OppContactMotivatorSchema(OppContactMotivatorSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c8126f44-5d66-4de8-b1ab-e37add1d4778");
			Name = "OppContactMotivator";
			ParentSchemaUId = new Guid("9f22a125-ab73-43ed-a5fa-b1b9d7bdbdc3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("02f719bb-5aa1-4d13-b1db-a18a9d8adf61");
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
			return new OppContactMotivator(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OppContactMotivator_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OppContactMotivatorSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OppContactMotivatorSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8126f44-5d66-4de8-b1ab-e37add1d4778"));
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivator

	/// <summary>
	/// Decision-making factor of the contact.
	/// </summary>
	public class OppContactMotivator : Terrasoft.Configuration.OppContactMotivator_Opportunity_Terrasoft
	{

		#region Constructors: Public

		public OppContactMotivator(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OppContactMotivator";
		}

		public OppContactMotivator(OppContactMotivator source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OppContactMotivator_PRMPortalEventsProcess(UserConnection);
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
			return new OppContactMotivator(this);
		}

		#endregion

	}

	#endregion

	#region Class: OppContactMotivator_PRMPortalEventsProcess

	/// <exclude/>
	public partial class OppContactMotivator_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.OppContactMotivator_OpportunityEventsProcess<TEntity> where TEntity : OppContactMotivator
	{

		public OppContactMotivator_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppContactMotivator_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c8126f44-5d66-4de8-b1ab-e37add1d4778");
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

	#region Class: OppContactMotivator_PRMPortalEventsProcess

	/// <exclude/>
	public class OppContactMotivator_PRMPortalEventsProcess : OppContactMotivator_PRMPortalEventsProcess<OppContactMotivator>
	{

		public OppContactMotivator_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OppContactMotivator_PRMPortalEventsProcess

	public partial class OppContactMotivator_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OppContactMotivatorEventsProcess

	/// <exclude/>
	public class OppContactMotivatorEventsProcess : OppContactMotivator_PRMPortalEventsProcess
	{

		public OppContactMotivatorEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

