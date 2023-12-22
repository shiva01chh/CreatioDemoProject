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

	#region Class: UsrGoldRateSchema

	/// <exclude/>
	public class UsrGoldRateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public UsrGoldRateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrGoldRateSchema(UsrGoldRateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrGoldRateSchema(UsrGoldRateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937");
			RealUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937");
			Name = "UsrGoldRate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bc47b682-09d2-0690-acb5-094a7f105462")) == null) {
				Columns.Add(CreateUsrRateColumn());
			}
			if (Columns.FindByUId(new Guid("9effbee0-b32d-a4bc-b1e5-9f52fc37143a")) == null) {
				Columns.Add(CreateUsrWeightColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrRateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("bc47b682-09d2-0690-acb5-094a7f105462"),
				Name = @"UsrRate",
				CreatedInSchemaUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937"),
				ModifiedInSchemaUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937"),
				CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430")
			};
		}

		protected virtual EntitySchemaColumn CreateUsrWeightColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9effbee0-b32d-a4bc-b1e5-9f52fc37143a"),
				Name = @"UsrWeight",
				CreatedInSchemaUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937"),
				ModifiedInSchemaUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937"),
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
			return new UsrGoldRate(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrGoldRate_UsrRealtyFreedomUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrGoldRateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrGoldRateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrGoldRate

	/// <summary>
	/// Gold rate.
	/// </summary>
	public class UsrGoldRate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public UsrGoldRate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrGoldRate";
		}

		public UsrGoldRate(UsrGoldRate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Rate,  AMD.
		/// </summary>
		public string UsrRate {
			get {
				return GetTypedColumnValue<string>("UsrRate");
			}
			set {
				SetColumnValue("UsrRate", value);
			}
		}

		/// <summary>
		/// Weight,g.
		/// </summary>
		public int UsrWeight {
			get {
				return GetTypedColumnValue<int>("UsrWeight");
			}
			set {
				SetColumnValue("UsrWeight", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrGoldRate_UsrRealtyFreedomUIEventsProcess(UserConnection);
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
			return new UsrGoldRate(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrGoldRate_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public partial class UsrGoldRate_UsrRealtyFreedomUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : UsrGoldRate
	{

		public UsrGoldRate_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrGoldRate_UsrRealtyFreedomUIEventsProcess";
			SchemaUId = new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4a158754-07ad-4bf4-aa8e-5e62d9210937");
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

	#region Class: UsrGoldRate_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrGoldRate_UsrRealtyFreedomUIEventsProcess : UsrGoldRate_UsrRealtyFreedomUIEventsProcess<UsrGoldRate>
	{

		public UsrGoldRate_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrGoldRate_UsrRealtyFreedomUIEventsProcess

	public partial class UsrGoldRate_UsrRealtyFreedomUIEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: UsrGoldRateEventsProcess

	/// <exclude/>
	public class UsrGoldRateEventsProcess : UsrGoldRate_UsrRealtyFreedomUIEventsProcess
	{

		public UsrGoldRateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

