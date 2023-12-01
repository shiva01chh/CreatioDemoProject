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

	#region Class: Lead_CoreLeadOpportunity_TerrasoftSchema

	/// <exclude/>
	public class Lead_CoreLeadOpportunity_TerrasoftSchema : Terrasoft.Configuration.Lead_WebLeadForm_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CoreLeadOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CoreLeadOpportunity_TerrasoftSchema(Lead_CoreLeadOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CoreLeadOpportunity_TerrasoftSchema(Lead_CoreLeadOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107");
			Name = "Lead_CoreLeadOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b1a963da-a78f-4fae-8e9e-52d870dd0ef3");
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CoreLeadOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CoreLeadOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CoreLeadOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CoreLeadOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunity_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CoreLeadOpportunity_Terrasoft : Terrasoft.Configuration.Lead_WebLeadForm_Terrasoft
	{

		#region Constructors: Public

		public Lead_CoreLeadOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CoreLeadOpportunity_Terrasoft";
		}

		public Lead_CoreLeadOpportunity_Terrasoft(Lead_CoreLeadOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CoreLeadOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Lead_CoreLeadOpportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CoreLeadOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	/// <exclude/>
	public partial class Lead_CoreLeadOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Lead_WebLeadFormEventsProcess<TEntity> where TEntity : Lead_CoreLeadOpportunity_Terrasoft
	{

		public Lead_CoreLeadOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CoreLeadOpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("601457d2-f86e-4ee0-bdf2-eeb9ef04a107");
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

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	/// <exclude/>
	public class Lead_CoreLeadOpportunityEventsProcess : Lead_CoreLeadOpportunityEventsProcess<Lead_CoreLeadOpportunity_Terrasoft>
	{

		public Lead_CoreLeadOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CoreLeadOpportunityEventsProcess

	public partial class Lead_CoreLeadOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

