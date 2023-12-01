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

	#region Class: ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema

	/// <exclude/>
	public class ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema(ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema(ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			RealUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			Name = "ServiceInServicePact_CrtSLMITILService7x_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateConcatNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("73bba5cd-b107-4ae3-a065-9b9eb56cca89")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("a533502e-52b0-4824-9af7-9d62aaabdd96")) == null) {
				Columns.Add(CreateServicePactColumn());
			}
			if (Columns.FindByUId(new Guid("00c2bb07-f824-475c-88ae-6eee6e5fdd4c")) == null) {
				Columns.Add(CreateReactionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("ca97e260-8487-40a3-8ae1-cbf99852eb86")) == null) {
				Columns.Add(CreateReactionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("f9b77e37-01b7-4c8b-9298-5e6da858b3a2")) == null) {
				Columns.Add(CreateSolutionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("b4b2684c-d092-4ebb-b0f2-38c76dd70fe1")) == null) {
				Columns.Add(CreateSolutionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("088918cb-b8d4-4c12-a1eb-18fdd3ea9a69")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("9f68699f-3e58-4b1f-a1db-0bc70316b1db")) == null) {
				Columns.Add(CreateCalendarColumn());
			}
			if (Columns.FindByUId(new Guid("061013ea-f57e-4057-b3ab-3f7468100b79")) == null) {
				Columns.Add(CreateReactionTimeColumn());
			}
			if (Columns.FindByUId(new Guid("32599881-5e55-4180-aadb-9a1e8dfaf5c4")) == null) {
				Columns.Add(CreateSolutionTimeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("73bba5cd-b107-4ae3-a065-9b9eb56cca89"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateServicePactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a533502e-52b0-4824-9af7-9d62aaabdd96"),
				Name = @"ServicePact",
				ReferenceSchemaUId = new Guid("595ddbda-31ce-4cca-9bdd-862257ceaf23"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("00c2bb07-f824-475c-88ae-6eee6e5fdd4c"),
				Name = @"ReactionTimeValue",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ca97e260-8487-40a3-8ae1-cbf99852eb86"),
				Name = @"ReactionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f9b77e37-01b7-4c8b-9298-5e6da858b3a2"),
				Name = @"SolutionTimeValue",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b4b2684c-d092-4ebb-b0f2-38c76dd70fe1"),
				Name = @"SolutionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("088918cb-b8d4-4c12-a1eb-18fdd3ea9a69"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("4fcd6c56-2c34-4f37-9c39-35dd78cc6c0a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateCalendarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9f68699f-3e58-4b1f-a1db-0bc70316b1db"),
				Name = @"Calendar",
				ReferenceSchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("061013ea-f57e-4057-b3ab-3f7468100b79"),
				Name = @"ReactionTime",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("32599881-5e55-4180-aadb-9a1e8dfaf5c4"),
				Name = @"SolutionTime",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateConcatNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("aa82d8fc-c4d5-4cfe-9659-565656f5e80a"),
				Name = @"ConcatName",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceInServicePact_CrtSLMITILService7x_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceInServicePact_CrtSLMITILService7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceInServicePact_CrtSLMITILService7x_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_CrtSLMITILService7x_Terrasoft

	/// <summary>
	/// Service in service agreement.
	/// </summary>
	public class ServiceInServicePact_CrtSLMITILService7x_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ServiceInServicePact_CrtSLMITILService7x_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceInServicePact_CrtSLMITILService7x_Terrasoft";
		}

		public ServiceInServicePact_CrtSLMITILService7x_Terrasoft(ServiceInServicePact_CrtSLMITILService7x_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service.
		/// </summary>
		public ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
			}
		}

		/// <exclude/>
		public Guid ServicePactId {
			get {
				return GetTypedColumnValue<Guid>("ServicePactId");
			}
			set {
				SetColumnValue("ServicePactId", value);
				_servicePact = null;
			}
		}

		/// <exclude/>
		public string ServicePactName {
			get {
				return GetTypedColumnValue<string>("ServicePactName");
			}
			set {
				SetColumnValue("ServicePactName", value);
				if (_servicePact != null) {
					_servicePact.Name = value;
				}
			}
		}

		private ServicePact _servicePact;
		/// <summary>
		/// Service agreement.
		/// </summary>
		public ServicePact ServicePact {
			get {
				return _servicePact ??
					(_servicePact = LookupColumnEntities.GetEntity("ServicePact") as ServicePact);
			}
		}

		/// <summary>
		/// Response time value.
		/// </summary>
		public int ReactionTimeValue {
			get {
				return GetTypedColumnValue<int>("ReactionTimeValue");
			}
			set {
				SetColumnValue("ReactionTimeValue", value);
			}
		}

		/// <exclude/>
		public Guid ReactionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("ReactionTimeUnitId");
			}
			set {
				SetColumnValue("ReactionTimeUnitId", value);
				_reactionTimeUnit = null;
			}
		}

		/// <exclude/>
		public string ReactionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("ReactionTimeUnitName");
			}
			set {
				SetColumnValue("ReactionTimeUnitName", value);
				if (_reactionTimeUnit != null) {
					_reactionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _reactionTimeUnit;
		/// <summary>
		/// Response time unit.
		/// </summary>
		public TimeUnit ReactionTimeUnit {
			get {
				return _reactionTimeUnit ??
					(_reactionTimeUnit = LookupColumnEntities.GetEntity("ReactionTimeUnit") as TimeUnit);
			}
		}

		/// <summary>
		/// Resolution time value.
		/// </summary>
		public int SolutionTimeValue {
			get {
				return GetTypedColumnValue<int>("SolutionTimeValue");
			}
			set {
				SetColumnValue("SolutionTimeValue", value);
			}
		}

		/// <exclude/>
		public Guid SolutionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("SolutionTimeUnitId");
			}
			set {
				SetColumnValue("SolutionTimeUnitId", value);
				_solutionTimeUnit = null;
			}
		}

		/// <exclude/>
		public string SolutionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("SolutionTimeUnitName");
			}
			set {
				SetColumnValue("SolutionTimeUnitName", value);
				if (_solutionTimeUnit != null) {
					_solutionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _solutionTimeUnit;
		/// <summary>
		/// Resolution time unit.
		/// </summary>
		public TimeUnit SolutionTimeUnit {
			get {
				return _solutionTimeUnit ??
					(_solutionTimeUnit = LookupColumnEntities.GetEntity("SolutionTimeUnit") as TimeUnit);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ServiceStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public ServiceStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ServiceStatus);
			}
		}

		/// <exclude/>
		public Guid CalendarId {
			get {
				return GetTypedColumnValue<Guid>("CalendarId");
			}
			set {
				SetColumnValue("CalendarId", value);
				_calendar = null;
			}
		}

		/// <exclude/>
		public string CalendarName {
			get {
				return GetTypedColumnValue<string>("CalendarName");
			}
			set {
				SetColumnValue("CalendarName", value);
				if (_calendar != null) {
					_calendar.Name = value;
				}
			}
		}

		private Calendar _calendar;
		/// <summary>
		/// Calendar.
		/// </summary>
		public Calendar Calendar {
			get {
				return _calendar ??
					(_calendar = LookupColumnEntities.GetEntity("Calendar") as Calendar);
			}
		}

		/// <summary>
		/// Response time.
		/// </summary>
		public string ReactionTime {
			get {
				return GetTypedColumnValue<string>("ReactionTime");
			}
			set {
				SetColumnValue("ReactionTime", value);
			}
		}

		/// <summary>
		/// Resolution time.
		/// </summary>
		public string SolutionTime {
			get {
				return GetTypedColumnValue<string>("SolutionTime");
			}
			set {
				SetColumnValue("SolutionTime", value);
			}
		}

		/// <summary>
		/// ServiseAndServiseInServicePactName.
		/// </summary>
		public string ConcatName {
			get {
				return GetTypedColumnValue<string>("ConcatName");
			}
			set {
				SetColumnValue("ConcatName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceInServicePact_CrtSLMITILService7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ServiceInServicePact_CrtSLMITILService7x_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceInServicePact_CrtSLMITILService7x_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_CrtSLMITILService7xEventsProcess

	/// <exclude/>
	public partial class ServiceInServicePact_CrtSLMITILService7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ServiceInServicePact_CrtSLMITILService7x_Terrasoft
	{

		public ServiceInServicePact_CrtSLMITILService7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceInServicePact_CrtSLMITILService7xEventsProcess";
			SchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
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

	#region Class: ServiceInServicePact_CrtSLMITILService7xEventsProcess

	/// <exclude/>
	public class ServiceInServicePact_CrtSLMITILService7xEventsProcess : ServiceInServicePact_CrtSLMITILService7xEventsProcess<ServiceInServicePact_CrtSLMITILService7x_Terrasoft>
	{

		public ServiceInServicePact_CrtSLMITILService7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

