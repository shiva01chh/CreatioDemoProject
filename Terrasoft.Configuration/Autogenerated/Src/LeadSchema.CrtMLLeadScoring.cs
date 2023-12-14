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

	#region Class: Lead_CrtMLLeadScoring_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtMLLeadScoring_TerrasoftSchema : Terrasoft.Configuration.Lead_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_CrtMLLeadScoring_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtMLLeadScoring_TerrasoftSchema(Lead_CrtMLLeadScoring_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtMLLeadScoring_TerrasoftSchema(Lead_CrtMLLeadScoring_TerrasoftSchema source)
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
			RealUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			Name = "Lead_CrtMLLeadScoring_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f3735b14-5953-4b62-b5cd-23c5e4860a14")) == null) {
				Columns.Add(CreatePredictiveScoreColumn());
			}
			if (Columns.FindByUId(new Guid("311e6ef0-7dad-4996-91ff-77977f17c2c4")) == null) {
				Columns.Add(CreateMovedToFinalStateOnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePredictiveScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f3735b14-5953-4b62-b5cd-23c5e4860a14"),
				Name = @"PredictiveScore",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0")
			};
		}

		protected virtual EntitySchemaColumn CreateMovedToFinalStateOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("311e6ef0-7dad-4996-91ff-77977f17c2c4"),
				Name = @"MovedToFinalStateOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("df23d829-9c8a-49c6-b4a6-b034981357c1")
			};
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
			return new Lead_CrtMLLeadScoring_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtMLLeadScoringEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtMLLeadScoring_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtMLLeadScoring_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtMLLeadScoring_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtMLLeadScoring_Terrasoft : Terrasoft.Configuration.Lead_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public Lead_CrtMLLeadScoring_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtMLLeadScoring_Terrasoft";
		}

		public Lead_CrtMLLeadScoring_Terrasoft(Lead_CrtMLLeadScoring_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Predictive score.
		/// </summary>
		public int PredictiveScore {
			get {
				return GetTypedColumnValue<int>("PredictiveScore");
			}
			set {
				SetColumnValue("PredictiveScore", value);
			}
		}

		/// <summary>
		/// Date of transfer to the final state.
		/// </summary>
		public DateTime MovedToFinalStateOn {
			get {
				return GetTypedColumnValue<DateTime>("MovedToFinalStateOn");
			}
			set {
				SetColumnValue("MovedToFinalStateOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtMLLeadScoringEventsProcess(UserConnection);
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
			return new Lead_CrtMLLeadScoring_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtMLLeadScoringEventsProcess

	/// <exclude/>
	public partial class Lead_CrtMLLeadScoringEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CrtLeadEventsProcess<TEntity> where TEntity : Lead_CrtMLLeadScoring_Terrasoft
	{

		public Lead_CrtMLLeadScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtMLLeadScoringEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
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

	#region Class: Lead_CrtMLLeadScoringEventsProcess

	/// <exclude/>
	public class Lead_CrtMLLeadScoringEventsProcess : Lead_CrtMLLeadScoringEventsProcess<Lead_CrtMLLeadScoring_Terrasoft>
	{

		public Lead_CrtMLLeadScoringEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_CrtMLLeadScoringEventsProcess

	public partial class Lead_CrtMLLeadScoringEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

