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

	#region Class: OpportunityChannelSchema

	/// <exclude/>
	public class OpportunityChannelSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OpportunityChannelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityChannelSchema(OpportunityChannelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityChannelSchema(OpportunityChannelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
			RealUId = new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
			Name = "OpportunityChannel";
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

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
			column.CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityChannel(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityChannel_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityChannelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityChannelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityChannel

	/// <summary>
	/// Sales channel.
	/// </summary>
	public class OpportunityChannel : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OpportunityChannel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityChannel";
		}

		public OpportunityChannel(OpportunityChannel source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityChannel_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OpportunityChannelDeleted", e);
			Deleting += (s, e) => ThrowEvent("OpportunityChannelDeleting", e);
			Inserted += (s, e) => ThrowEvent("OpportunityChannelInserted", e);
			Inserting += (s, e) => ThrowEvent("OpportunityChannelInserting", e);
			Saved += (s, e) => ThrowEvent("OpportunityChannelSaved", e);
			Saving += (s, e) => ThrowEvent("OpportunityChannelSaving", e);
			Validating += (s, e) => ThrowEvent("OpportunityChannelValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OpportunityChannel(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityChannel_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityChannel_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OpportunityChannel
	{

		public OpportunityChannel_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityChannel_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba7ed306-8352-47fe-8dd0-e8c40d3ab8f3");
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

	#region Class: OpportunityChannel_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityChannel_CrtOpportunityEventsProcess : OpportunityChannel_CrtOpportunityEventsProcess<OpportunityChannel>
	{

		public OpportunityChannel_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OpportunityChannel_CrtOpportunityEventsProcess

	public partial class OpportunityChannel_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OpportunityChannelEventsProcess

	/// <exclude/>
	public class OpportunityChannelEventsProcess : OpportunityChannel_CrtOpportunityEventsProcess
	{

		public OpportunityChannelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

