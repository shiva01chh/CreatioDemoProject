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

	#region Class: AdAccountSchema

	/// <exclude/>
	public class AdAccountSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AdAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdAccountSchema(AdAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdAccountSchema(AdAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc");
			RealUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc");
			Name = "AdAccount";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b40e1a0d-7a24-e44f-12cf-92dfe5040ad2")) == null) {
				Columns.Add(CreateAccountIdColumn());
			}
			if (Columns.FindByUId(new Guid("4ef9c64f-e4da-f4b6-5803-fb86c7bc8748")) == null) {
				Columns.Add(CreateConnectionStatusColumn());
			}
			if (Columns.FindByUId(new Guid("7225fa95-9ea6-067d-7b85-258830cf8e71")) == null) {
				Columns.Add(CreateAdPlatformColumn());
			}
			if (Columns.FindByUId(new Guid("b9a03363-3524-4de9-b7c4-2f5fccfbed7c")) == null) {
				Columns.Add(CreateAdAccountUrlColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccountIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("b40e1a0d-7a24-e44f-12cf-92dfe5040ad2"),
				Name = @"AccountId",
				CreatedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				ModifiedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateConnectionStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4ef9c64f-e4da-f4b6-5803-fb86c7bc8748"),
				Name = @"ConnectionStatus",
				ReferenceSchemaUId = new Guid("78a7290c-b94f-4b21-ae98-5967c6529b62"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				ModifiedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateAdPlatformColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7225fa95-9ea6-067d-7b85-258830cf8e71"),
				Name = @"AdPlatform",
				ReferenceSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				ModifiedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateAdAccountUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("WebText")) {
				UId = new Guid("b9a03363-3524-4de9-b7c4-2f5fccfbed7c"),
				Name = @"AdAccountUrl",
				CreatedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				ModifiedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				CreatedInPackageId = new Guid("413dbe1d-a3ad-4fed-bd99-919cc6d22ad2")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("5d6df963-0347-a67a-f6a3-149bd7b9c39a"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				ModifiedInSchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdAccount_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc"));
		}

		#endregion

	}

	#endregion

	#region Class: AdAccount

	/// <summary>
	/// Ad account.
	/// </summary>
	public class AdAccount : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AdAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdAccount";
		}

		public AdAccount(AdAccount source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Account Id.
		/// </summary>
		public string AccountId {
			get {
				return GetTypedColumnValue<string>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
			}
		}

		/// <exclude/>
		public Guid ConnectionStatusId {
			get {
				return GetTypedColumnValue<Guid>("ConnectionStatusId");
			}
			set {
				SetColumnValue("ConnectionStatusId", value);
				_connectionStatus = null;
			}
		}

		/// <exclude/>
		public string ConnectionStatusName {
			get {
				return GetTypedColumnValue<string>("ConnectionStatusName");
			}
			set {
				SetColumnValue("ConnectionStatusName", value);
				if (_connectionStatus != null) {
					_connectionStatus.Name = value;
				}
			}
		}

		private AdAccountConnectionState _connectionStatus;
		/// <summary>
		/// Connection status.
		/// </summary>
		public AdAccountConnectionState ConnectionStatus {
			get {
				return _connectionStatus ??
					(_connectionStatus = LookupColumnEntities.GetEntity("ConnectionStatus") as AdAccountConnectionState);
			}
		}

		/// <exclude/>
		public Guid AdPlatformId {
			get {
				return GetTypedColumnValue<Guid>("AdPlatformId");
			}
			set {
				SetColumnValue("AdPlatformId", value);
				_adPlatform = null;
			}
		}

		/// <exclude/>
		public string AdPlatformName {
			get {
				return GetTypedColumnValue<string>("AdPlatformName");
			}
			set {
				SetColumnValue("AdPlatformName", value);
				if (_adPlatform != null) {
					_adPlatform.Name = value;
				}
			}
		}

		private AdPlatform _adPlatform;
		/// <summary>
		/// Platform.
		/// </summary>
		public AdPlatform AdPlatform {
			get {
				return _adPlatform ??
					(_adPlatform = LookupColumnEntities.GetEntity("AdPlatform") as AdPlatform);
			}
		}

		/// <summary>
		/// Ad account link.
		/// </summary>
		/// <remarks>
		/// Link to ad account in ad platform.
		/// </remarks>
		public string AdAccountUrl {
			get {
				return GetTypedColumnValue<string>("AdAccountUrl");
			}
			set {
				SetColumnValue("AdAccountUrl", value);
			}
		}

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdAccount_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdAccount_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdAccount_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AdAccount
	{

		public AdAccount_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdAccount_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e80e87aa-bdcf-4b46-92aa-ecefca3d0ddc");
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

	#region Class: AdAccount_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdAccount_CrtDigitalAdsAppEventsProcess : AdAccount_CrtDigitalAdsAppEventsProcess<AdAccount>
	{

		public AdAccount_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdAccount_CrtDigitalAdsAppEventsProcess

	public partial class AdAccount_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdAccountEventsProcess

	/// <exclude/>
	public class AdAccountEventsProcess : AdAccount_CrtDigitalAdsAppEventsProcess
	{

		public AdAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

