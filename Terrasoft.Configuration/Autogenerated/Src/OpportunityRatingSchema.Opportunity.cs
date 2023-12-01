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

	#region Class: OpportunityRatingSchema

	/// <exclude/>
	public class OpportunityRatingSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OpportunityRatingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityRatingSchema(OpportunityRatingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityRatingSchema(OpportunityRatingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("116f6a65-b667-4229-962e-69e11efb2641");
			RealUId = new Guid("116f6a65-b667-4229-962e-69e11efb2641");
			Name = "OpportunityRating";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new OpportunityRating(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityRating_OpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityRatingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityRatingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("116f6a65-b667-4229-962e-69e11efb2641"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityRating

	/// <summary>
	/// Priority of opportunity.
	/// </summary>
	public class OpportunityRating : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OpportunityRating(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityRating";
		}

		public OpportunityRating(OpportunityRating source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityRating_OpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityRatingDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityRatingDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityRatingInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityRatingInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityRatingSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityRatingSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityRatingValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityRating(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityRating_OpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityRating_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OpportunityRating
	{

		public OpportunityRating_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityRating_OpportunityEventsProcess";
			SchemaUId = new Guid("116f6a65-b667-4229-962e-69e11efb2641");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("116f6a65-b667-4229-962e-69e11efb2641");
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

	#region Class: OpportunityRating_OpportunityEventsProcess

	/// <exclude/>
	public class OpportunityRating_OpportunityEventsProcess : OpportunityRating_OpportunityEventsProcess<OpportunityRating>
	{

		public OpportunityRating_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityRating_OpportunityEventsProcess

	public partial class OpportunityRating_OpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityRatingEventsProcess

	/// <exclude/>
	public class OpportunityRatingEventsProcess : OpportunityRating_OpportunityEventsProcess
	{

		public OpportunityRatingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

