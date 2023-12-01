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

	#region Class: CampaignParticipantInfoSchema

	/// <exclude/>
	public class CampaignParticipantInfoSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignParticipantInfoSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignParticipantInfoSchema(CampaignParticipantInfoSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignParticipantInfoSchema(CampaignParticipantInfoSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8");
			RealUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8");
			Name = "CampaignParticipantInfo";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e01ce84d-206d-40b3-84a4-687d38df10e1")) == null) {
				Columns.Add(CreateCampaignParticipantIdColumn());
			}
			if (Columns.FindByUId(new Guid("1f5b75c4-e0a4-4563-ac87-2bb6200bb759")) == null) {
				Columns.Add(CreateLinkedEntityIdColumn());
			}
			if (Columns.FindByUId(new Guid("6223c286-f860-40e7-9140-c086b422a4b1")) == null) {
				Columns.Add(CreateEntityObjectColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignParticipantIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e01ce84d-206d-40b3-84a4-687d38df10e1"),
				Name = @"CampaignParticipantId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				ModifiedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateLinkedEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("1f5b75c4-e0a4-4563-ac87-2bb6200bb759"),
				Name = @"LinkedEntityId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				ModifiedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6223c286-f860-40e7-9140-c086b422a4b1"),
				Name = @"EntityObject",
				ReferenceSchemaUId = new Guid("c82db13a-7f77-4085-b3ef-91c5420fd417"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				ModifiedInSchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignParticipantInfo(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignParticipantInfo_CrtCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignParticipantInfoSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignParticipantInfoSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipantInfo

	/// <summary>
	/// CampaignParticipantInfo.
	/// </summary>
	public class CampaignParticipantInfo : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignParticipantInfo(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignParticipantInfo";
		}

		public CampaignParticipantInfo(CampaignParticipantInfo source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Campaign participant.
		/// </summary>
		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
			}
		}

		/// <summary>
		/// Linked entity.
		/// </summary>
		public Guid LinkedEntityId {
			get {
				return GetTypedColumnValue<Guid>("LinkedEntityId");
			}
			set {
				SetColumnValue("LinkedEntityId", value);
			}
		}

		/// <exclude/>
		public Guid EntityObjectId {
			get {
				return GetTypedColumnValue<Guid>("EntityObjectId");
			}
			set {
				SetColumnValue("EntityObjectId", value);
				_entityObject = null;
			}
		}

		/// <exclude/>
		public string EntityObjectTitle {
			get {
				return GetTypedColumnValue<string>("EntityObjectTitle");
			}
			set {
				SetColumnValue("EntityObjectTitle", value);
				if (_entityObject != null) {
					_entityObject.Title = value;
				}
			}
		}

		private VwEntityObjects _entityObject;
		/// <summary>
		/// Linked entity object.
		/// </summary>
		public VwEntityObjects EntityObject {
			get {
				return _entityObject ??
					(_entityObject = LookupColumnEntities.GetEntity("EntityObject") as VwEntityObjects);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignParticipantInfo_CrtCampaignEventsProcess(UserConnection);
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
			return new CampaignParticipantInfo(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipantInfo_CrtCampaignEventsProcess

	/// <exclude/>
	public partial class CampaignParticipantInfo_CrtCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignParticipantInfo
	{

		public CampaignParticipantInfo_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignParticipantInfo_CrtCampaignEventsProcess";
			SchemaUId = new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("19aa0bd2-80bc-406b-8ada-9a8acea053e8");
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

	#region Class: CampaignParticipantInfo_CrtCampaignEventsProcess

	/// <exclude/>
	public class CampaignParticipantInfo_CrtCampaignEventsProcess : CampaignParticipantInfo_CrtCampaignEventsProcess<CampaignParticipantInfo>
	{

		public CampaignParticipantInfo_CrtCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignParticipantInfo_CrtCampaignEventsProcess

	public partial class CampaignParticipantInfo_CrtCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignParticipantInfoEventsProcess

	/// <exclude/>
	public class CampaignParticipantInfoEventsProcess : CampaignParticipantInfo_CrtCampaignEventsProcess
	{

		public CampaignParticipantInfoEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

