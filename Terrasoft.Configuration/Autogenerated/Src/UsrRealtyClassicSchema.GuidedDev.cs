namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrRealtyClassicSchema

	/// <exclude/>
	public class UsrRealtyClassicSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrRealtyClassicSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicSchema(UsrRealtyClassicSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicSchema(UsrRealtyClassicSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b");
			RealUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b");
			Name = "UsrRealtyClassic";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateUsrNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3186b36f-13ee-4a75-b76f-e64b605b8a12")) == null) {
				Columns.Add(CreateUsrNotesColumn());
			}
			if (Columns.FindByUId(new Guid("62953e6b-9b3f-4bdd-aba5-2670711c1f43")) == null) {
				Columns.Add(CreateUsrPriceUSDColumn());
			}
			if (Columns.FindByUId(new Guid("66fc8e97-200c-48f9-bf9d-8f87a2dbe4b7")) == null) {
				Columns.Add(CreateUsrAreaColumn());
			}
			if (Columns.FindByUId(new Guid("4394faaf-05fb-412d-b7ec-8a479e230f30")) == null) {
				Columns.Add(CreateUsrTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a2c6b528-71c3-4fa2-be44-448072180673")) == null) {
				Columns.Add(CreateUsrOfferTypeColumn());
			}
			if (Columns.FindByUId(new Guid("f6b143c5-c9c3-447c-8498-a9eebd81374f")) == null) {
				Columns.Add(CreateUsrManagerColumn());
			}
			if (Columns.FindByUId(new Guid("1eaeb327-02c6-4ec0-b75b-c77f4a32a0df")) == null) {
				Columns.Add(CreateUsrCommentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("86f4a7ef-0b82-4096-a548-f63f97427d11"),
				Name = @"UsrName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3186b36f-13ee-4a75-b76f-e64b605b8a12"),
				Name = @"UsrNotes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrPriceUSDColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("62953e6b-9b3f-4bdd-aba5-2670711c1f43"),
				Name = @"UsrPriceUSD",
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrAreaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("66fc8e97-200c-48f9-bf9d-8f87a2dbe4b7"),
				Name = @"UsrArea",
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4394faaf-05fb-412d-b7ec-8a479e230f30"),
				Name = @"UsrType",
				ReferenceSchemaUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrOfferTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a2c6b528-71c3-4fa2-be44-448072180673"),
				Name = @"UsrOfferType",
				ReferenceSchemaUId = new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f6b143c5-c9c3-447c-8498-a9eebd81374f"),
				Name = @"UsrManager",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1eaeb327-02c6-4ec0-b75b-c77f4a32a0df"),
				Name = @"UsrComment",
				CreatedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				ModifiedInSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyClassic(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassic_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassic

	/// <summary>
	/// Realty (Classic UI).
	/// </summary>
	public class UsrRealtyClassic : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrRealtyClassic(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassic";
		}

		public UsrRealtyClassic(UsrRealtyClassic source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string UsrName {
			get {
				return GetTypedColumnValue<string>("UsrName");
			}
			set {
				SetColumnValue("UsrName", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string UsrNotes {
			get {
				return GetTypedColumnValue<string>("UsrNotes");
			}
			set {
				SetColumnValue("UsrNotes", value);
			}
		}

		/// <summary>
		/// Price, USD.
		/// </summary>
		public Decimal UsrPriceUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrPriceUSD");
			}
			set {
				SetColumnValue("UsrPriceUSD", value);
			}
		}

		/// <summary>
		/// Area, sq ft.
		/// </summary>
		public Decimal UsrArea {
			get {
				return GetTypedColumnValue<Decimal>("UsrArea");
			}
			set {
				SetColumnValue("UsrArea", value);
			}
		}

		/// <exclude/>
		public Guid UsrTypeId {
			get {
				return GetTypedColumnValue<Guid>("UsrTypeId");
			}
			set {
				SetColumnValue("UsrTypeId", value);
				_usrType = null;
			}
		}

		/// <exclude/>
		public string UsrTypeName {
			get {
				return GetTypedColumnValue<string>("UsrTypeName");
			}
			set {
				SetColumnValue("UsrTypeName", value);
				if (_usrType != null) {
					_usrType.Name = value;
				}
			}
		}

		private UsrRealtyTypeClassic _usrType;
		/// <summary>
		/// Type.
		/// </summary>
		public UsrRealtyTypeClassic UsrType {
			get {
				return _usrType ??
					(_usrType = LookupColumnEntities.GetEntity("UsrType") as UsrRealtyTypeClassic);
			}
		}

		/// <exclude/>
		public Guid UsrOfferTypeId {
			get {
				return GetTypedColumnValue<Guid>("UsrOfferTypeId");
			}
			set {
				SetColumnValue("UsrOfferTypeId", value);
				_usrOfferType = null;
			}
		}

		/// <exclude/>
		public string UsrOfferTypeName {
			get {
				return GetTypedColumnValue<string>("UsrOfferTypeName");
			}
			set {
				SetColumnValue("UsrOfferTypeName", value);
				if (_usrOfferType != null) {
					_usrOfferType.Name = value;
				}
			}
		}

		private UsrRealtyOfferTypeClassic _usrOfferType;
		/// <summary>
		/// Offer type.
		/// </summary>
		public UsrRealtyOfferTypeClassic UsrOfferType {
			get {
				return _usrOfferType ??
					(_usrOfferType = LookupColumnEntities.GetEntity("UsrOfferType") as UsrRealtyOfferTypeClassic);
			}
		}

		/// <exclude/>
		public Guid UsrManagerId {
			get {
				return GetTypedColumnValue<Guid>("UsrManagerId");
			}
			set {
				SetColumnValue("UsrManagerId", value);
				_usrManager = null;
			}
		}

		/// <exclude/>
		public string UsrManagerName {
			get {
				return GetTypedColumnValue<string>("UsrManagerName");
			}
			set {
				SetColumnValue("UsrManagerName", value);
				if (_usrManager != null) {
					_usrManager.Name = value;
				}
			}
		}

		private Contact _usrManager;
		/// <summary>
		/// Manager.
		/// </summary>
		public Contact UsrManager {
			get {
				return _usrManager ??
					(_usrManager = LookupColumnEntities.GetEntity("UsrManager") as Contact);
			}
		}

		/// <summary>
		/// Comment.
		/// </summary>
		public string UsrComment {
			get {
				return GetTypedColumnValue<string>("UsrComment");
			}
			set {
				SetColumnValue("UsrComment", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyClassic_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassic(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassic_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassic_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrRealtyClassic
	{

		public UsrRealtyClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassic_GuidedDevEventsProcess";
			SchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b");
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

	#region Class: UsrRealtyClassic_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassic_GuidedDevEventsProcess : UsrRealtyClassic_GuidedDevEventsProcess<UsrRealtyClassic>
	{

		public UsrRealtyClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassic_GuidedDevEventsProcess

	public partial class UsrRealtyClassic_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicEventsProcess : UsrRealtyClassic_GuidedDevEventsProcess
	{

		public UsrRealtyClassicEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

