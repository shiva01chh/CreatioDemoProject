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

	#region Class: LeadInQualifyStatus_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class LeadInQualifyStatus_CrtLead_TerrasoftSchema : Terrasoft.Configuration.BaseEntityInStageSchema
	{

		#region Constructors: Public

		public LeadInQualifyStatus_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadInQualifyStatus_CrtLead_TerrasoftSchema(LeadInQualifyStatus_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadInQualifyStatus_CrtLead_TerrasoftSchema(LeadInQualifyStatus_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			RealUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			Name = "LeadInQualifyStatus_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("86cb4c67-4231-4904-be40-b9019d87311d");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f9fafc40-d3f4-4cb9-84c5-854e0eeffd97");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c206c35e-5504-4e34-905b-d59ab54f754e")) == null) {
				Columns.Add(CreateLeadColumn());
			}
			if (Columns.FindByUId(new Guid("e02b4e41-afa4-4124-9d4d-ba9b1ddf14a0")) == null) {
				Columns.Add(CreateQualifyStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c206c35e-5504-4e34-905b-d59ab54f754e"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				ModifiedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifyStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e02b4e41-afa4-4124-9d4d-ba9b1ddf14a0"),
				Name = @"QualifyStatus",
				ReferenceSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				ModifiedInSchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LeadInQualifyStatus_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadInQualifyStatus_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadInQualifyStatus_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadInQualifyStatus_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_CrtLead_Terrasoft

	/// <summary>
	/// Stage in lead.
	/// </summary>
	public class LeadInQualifyStatus_CrtLead_Terrasoft : Terrasoft.Configuration.BaseEntityInStage
	{

		#region Constructors: Public

		public LeadInQualifyStatus_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadInQualifyStatus_CrtLead_Terrasoft";
		}

		public LeadInQualifyStatus_CrtLead_Terrasoft(LeadInQualifyStatus_CrtLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		/// <exclude/>
		public Guid QualifyStatusId {
			get {
				return GetTypedColumnValue<Guid>("QualifyStatusId");
			}
			set {
				SetColumnValue("QualifyStatusId", value);
				_qualifyStatus = null;
			}
		}

		/// <exclude/>
		public string QualifyStatusName {
			get {
				return GetTypedColumnValue<string>("QualifyStatusName");
			}
			set {
				SetColumnValue("QualifyStatusName", value);
				if (_qualifyStatus != null) {
					_qualifyStatus.Name = value;
				}
			}
		}

		private QualifyStatus _qualifyStatus;
		/// <summary>
		/// Lead stage.
		/// </summary>
		public QualifyStatus QualifyStatus {
			get {
				return _qualifyStatus ??
					(_qualifyStatus = LookupColumnEntities.GetEntity("QualifyStatus") as QualifyStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadInQualifyStatus_CrtLeadEventsProcess(UserConnection);
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
			return new LeadInQualifyStatus_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadInQualifyStatus_CrtLeadEventsProcess

	/// <exclude/>
	public partial class LeadInQualifyStatus_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInStage_CrtBaseEventsProcess<TEntity> where TEntity : LeadInQualifyStatus_CrtLead_Terrasoft
	{

		public LeadInQualifyStatus_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadInQualifyStatus_CrtLeadEventsProcess";
			SchemaUId = new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("071aba13-b2b4-4050-aa8f-dab49a65b4b1");
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

	#region Class: LeadInQualifyStatus_CrtLeadEventsProcess

	/// <exclude/>
	public class LeadInQualifyStatus_CrtLeadEventsProcess : LeadInQualifyStatus_CrtLeadEventsProcess<LeadInQualifyStatus_CrtLead_Terrasoft>
	{

		public LeadInQualifyStatus_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadInQualifyStatus_CrtLeadEventsProcess

	public partial class LeadInQualifyStatus_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

