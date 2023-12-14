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

	#region Class: UsrRealtyFreedomUISchema

	/// <exclude/>
	public class UsrRealtyFreedomUISchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrRealtyFreedomUISchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyFreedomUISchema(UsrRealtyFreedomUISchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyFreedomUISchema(UsrRealtyFreedomUISchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0");
			RealUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0");
			Name = "UsrRealtyFreedomUI";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			if (Columns.FindByUId(new Guid("b2e16a86-0df2-19a0-f239-02e5fa37d3a5")) == null) {
				Columns.Add(CreateUsrAreaColumn());
			}
			if (Columns.FindByUId(new Guid("52e3a0d8-0da1-c612-7237-9788c9e349cc")) == null) {
				Columns.Add(CreateUsrPriceUSDColumn());
			}
			if (Columns.FindByUId(new Guid("80a3aa53-2cb9-9453-37fe-9b3bad048f84")) == null) {
				Columns.Add(CreateUsrManagerColumn());
			}
			if (Columns.FindByUId(new Guid("f56e7ce3-27f3-d590-4e14-8f16c27bbe27")) == null) {
				Columns.Add(CreateUsrCommentColumn());
			}
			if (Columns.FindByUId(new Guid("0021c4b2-143e-d7c5-1e0b-6279aac2ef87")) == null) {
				Columns.Add(CreateUsrOfferTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6901d3ec-1413-d9ce-8a9d-85a761f58496")) == null) {
				Columns.Add(CreateUsrTypeColumn());
			}
			if (Columns.FindByUId(new Guid("09cebc3c-5dab-089c-ef91-b8a50f0bd0eb")) == null) {
				Columns.Add(CreateUsrCityColumn());
			}
			if (Columns.FindByUId(new Guid("b415fd29-da6e-a227-6aa6-b490dcacfa69")) == null) {
				Columns.Add(CreateUsrCountryColumn());
			}
			if (Columns.FindByUId(new Guid("0027b03e-871e-c25a-3c56-e5cad4461588")) == null) {
				Columns.Add(CreateUsrCommissionUSDColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("668be146-29df-41f6-8964-f31667eefc52"),
				Name = @"UsrName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("6f71e54c-1960-40c9-94f6-073fd67699ab")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrAreaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("b2e16a86-0df2-19a0-f239-02e5fa37d3a5"),
				Name = @"UsrArea",
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrPriceUSDColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("52e3a0d8-0da1-c612-7237-9788c9e349cc"),
				Name = @"UsrPriceUSD",
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("80a3aa53-2cb9-9453-37fe-9b3bad048f84"),
				Name = @"UsrManager",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f56e7ce3-27f3-d590-4e14-8f16c27bbe27"),
				Name = @"UsrComment",
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsFormatValidated = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrOfferTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0021c4b2-143e-d7c5-1e0b-6279aac2ef87"),
				Name = @"UsrOfferType",
				ReferenceSchemaUId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6901d3ec-1413-d9ce-8a9d-85a761f58496"),
				Name = @"UsrType",
				ReferenceSchemaUId = new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("09cebc3c-5dab-089c-ef91-b8a50f0bd0eb"),
				Name = @"UsrCity",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b415fd29-da6e-a227-6aa6-b490dcacfa69"),
				Name = @"UsrCountry",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCommissionUSDColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("0027b03e-871e-c25a-3c56-e5cad4461588"),
				Name = @"UsrCommissionUSD",
				CreatedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				ModifiedInSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyFreedomUI(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyFreedomUISchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyFreedomUISchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyFreedomUI

	/// <summary>
	/// Realty (Freedom UI).
	/// </summary>
	public class UsrRealtyFreedomUI : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrRealtyFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyFreedomUI";
		}

		public UsrRealtyFreedomUI(UsrRealtyFreedomUI source)
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
		/// Area, sqft.
		/// </summary>
		public Decimal UsrArea {
			get {
				return GetTypedColumnValue<Decimal>("UsrArea");
			}
			set {
				SetColumnValue("UsrArea", value);
			}
		}

		/// <summary>
		/// Price USD.
		/// </summary>
		public Decimal UsrPriceUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrPriceUSD");
			}
			set {
				SetColumnValue("UsrPriceUSD", value);
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

		private UsrRealtyOfferTypeFreedomUI _usrOfferType;
		/// <summary>
		/// Offer type.
		/// </summary>
		public UsrRealtyOfferTypeFreedomUI UsrOfferType {
			get {
				return _usrOfferType ??
					(_usrOfferType = LookupColumnEntities.GetEntity("UsrOfferType") as UsrRealtyOfferTypeFreedomUI);
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

		private UsrRealtyTypeFreedomUI _usrType;
		/// <summary>
		/// Type.
		/// </summary>
		public UsrRealtyTypeFreedomUI UsrType {
			get {
				return _usrType ??
					(_usrType = LookupColumnEntities.GetEntity("UsrType") as UsrRealtyTypeFreedomUI);
			}
		}

		/// <exclude/>
		public Guid UsrCityId {
			get {
				return GetTypedColumnValue<Guid>("UsrCityId");
			}
			set {
				SetColumnValue("UsrCityId", value);
				_usrCity = null;
			}
		}

		/// <exclude/>
		public string UsrCityName {
			get {
				return GetTypedColumnValue<string>("UsrCityName");
			}
			set {
				SetColumnValue("UsrCityName", value);
				if (_usrCity != null) {
					_usrCity.Name = value;
				}
			}
		}

		private City _usrCity;
		/// <summary>
		/// City.
		/// </summary>
		public City UsrCity {
			get {
				return _usrCity ??
					(_usrCity = LookupColumnEntities.GetEntity("UsrCity") as City);
			}
		}

		/// <exclude/>
		public Guid UsrCountryId {
			get {
				return GetTypedColumnValue<Guid>("UsrCountryId");
			}
			set {
				SetColumnValue("UsrCountryId", value);
				_usrCountry = null;
			}
		}

		/// <exclude/>
		public string UsrCountryName {
			get {
				return GetTypedColumnValue<string>("UsrCountryName");
			}
			set {
				SetColumnValue("UsrCountryName", value);
				if (_usrCountry != null) {
					_usrCountry.Name = value;
				}
			}
		}

		private Country _usrCountry;
		/// <summary>
		/// Country.
		/// </summary>
		public Country UsrCountry {
			get {
				return _usrCountry ??
					(_usrCountry = LookupColumnEntities.GetEntity("UsrCountry") as Country);
			}
		}

		/// <summary>
		/// Commission, USD.
		/// </summary>
		public Decimal UsrCommissionUSD {
			get {
				return GetTypedColumnValue<Decimal>("UsrCommissionUSD");
			}
			set {
				SetColumnValue("UsrCommissionUSD", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection);
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
			return new UsrRealtyFreedomUI(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public partial class UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrRealtyFreedomUI
	{

		public UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess";
			SchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("08eba176-3fe4-437d-9aef-027416ba50c0");
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

	#region Class: UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess : UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess<UsrRealtyFreedomUI>
	{

		public UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess

	public partial class UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyFreedomUIEventsProcess : UsrRealtyFreedomUI_UsrRealtyFreedomUIEventsProcess
	{

		public UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

