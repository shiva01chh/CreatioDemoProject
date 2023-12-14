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

	#region Class: UsrRealtyVisitFreedomUISchema

	/// <exclude/>
	public class UsrRealtyVisitFreedomUISchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrRealtyVisitFreedomUISchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyVisitFreedomUISchema(UsrRealtyVisitFreedomUISchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyVisitFreedomUISchema(UsrRealtyVisitFreedomUISchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a");
			RealUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a");
			Name = "UsrRealtyVisitFreedomUI";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5fb65403-de75-695d-8755-a02f8ccebc47")) == null) {
				Columns.Add(CreateUsrParentRealtyColumn());
			}
			if (Columns.FindByUId(new Guid("d7e5265c-06fc-2747-c6dc-043168ed4b9f")) == null) {
				Columns.Add(CreateUsrVisitDateTimeColumn());
			}
			if (Columns.FindByUId(new Guid("d4f0981e-dbc1-96c6-8df3-084c28c4863b")) == null) {
				Columns.Add(CreateUsrCommentColumn());
			}
			if (Columns.FindByUId(new Guid("db268c26-c962-c1af-6bed-b9b3c0829058")) == null) {
				Columns.Add(CreateUsrManagerColumn());
			}
			if (Columns.FindByUId(new Guid("1339102b-94a6-ccd2-8168-922cee96f188")) == null) {
				Columns.Add(CreateUsrPotentialCustomerColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrParentRealtyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5fb65403-de75-695d-8755-a02f8ccebc47"),
				Name = @"UsrParentRealty",
				ReferenceSchemaUId = new Guid("08eba176-3fe4-437d-9aef-027416ba50c0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				ModifiedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateUsrVisitDateTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("d7e5265c-06fc-2747-c6dc-043168ed4b9f"),
				Name = @"UsrVisitDateTime",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				ModifiedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUsrCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d4f0981e-dbc1-96c6-8df3-084c28c4863b"),
				Name = @"UsrComment",
				CreatedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				ModifiedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("db268c26-c962-c1af-6bed-b9b3c0829058"),
				Name = @"UsrManager",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				ModifiedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUsrPotentialCustomerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1339102b-94a6-ccd2-8168-922cee96f188"),
				Name = @"UsrPotentialCustomer",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
				ModifiedInSchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"),
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
			return new UsrRealtyVisitFreedomUI(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyVisitFreedomUISchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyVisitFreedomUISchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyVisitFreedomUI

	/// <summary>
	/// Realty visit (FreedomUI).
	/// </summary>
	public class UsrRealtyVisitFreedomUI : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrRealtyVisitFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyVisitFreedomUI";
		}

		public UsrRealtyVisitFreedomUI(UsrRealtyVisitFreedomUI source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid UsrParentRealtyId {
			get {
				return GetTypedColumnValue<Guid>("UsrParentRealtyId");
			}
			set {
				SetColumnValue("UsrParentRealtyId", value);
				_usrParentRealty = null;
			}
		}

		/// <exclude/>
		public string UsrParentRealtyUsrName {
			get {
				return GetTypedColumnValue<string>("UsrParentRealtyUsrName");
			}
			set {
				SetColumnValue("UsrParentRealtyUsrName", value);
				if (_usrParentRealty != null) {
					_usrParentRealty.UsrName = value;
				}
			}
		}

		private UsrRealtyFreedomUI _usrParentRealty;
		/// <summary>
		/// Parent realty.
		/// </summary>
		public UsrRealtyFreedomUI UsrParentRealty {
			get {
				return _usrParentRealty ??
					(_usrParentRealty = LookupColumnEntities.GetEntity("UsrParentRealty") as UsrRealtyFreedomUI);
			}
		}

		/// <summary>
		/// Visit date and time.
		/// </summary>
		public DateTime UsrVisitDateTime {
			get {
				return GetTypedColumnValue<DateTime>("UsrVisitDateTime");
			}
			set {
				SetColumnValue("UsrVisitDateTime", value);
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

		/// <exclude/>
		public Guid UsrPotentialCustomerId {
			get {
				return GetTypedColumnValue<Guid>("UsrPotentialCustomerId");
			}
			set {
				SetColumnValue("UsrPotentialCustomerId", value);
				_usrPotentialCustomer = null;
			}
		}

		/// <exclude/>
		public string UsrPotentialCustomerName {
			get {
				return GetTypedColumnValue<string>("UsrPotentialCustomerName");
			}
			set {
				SetColumnValue("UsrPotentialCustomerName", value);
				if (_usrPotentialCustomer != null) {
					_usrPotentialCustomer.Name = value;
				}
			}
		}

		private Contact _usrPotentialCustomer;
		/// <summary>
		/// Potential customer.
		/// </summary>
		public Contact UsrPotentialCustomer {
			get {
				return _usrPotentialCustomer ??
					(_usrPotentialCustomer = LookupColumnEntities.GetEntity("UsrPotentialCustomer") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection);
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
			return new UsrRealtyVisitFreedomUI(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public partial class UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrRealtyVisitFreedomUI
	{

		public UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess";
			SchemaUId = new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a275f51-36f4-4a1d-8da2-fd270cc1411a");
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

	#region Class: UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess : UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess<UsrRealtyVisitFreedomUI>
	{

		public UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess

	public partial class UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyVisitFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyVisitFreedomUIEventsProcess : UsrRealtyVisitFreedomUI_UsrRealtyFreedomUIEventsProcess
	{

		public UsrRealtyVisitFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

