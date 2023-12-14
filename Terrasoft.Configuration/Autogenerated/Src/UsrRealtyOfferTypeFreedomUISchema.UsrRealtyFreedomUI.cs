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

	#region Class: UsrRealtyOfferTypeFreedomUISchema

	/// <exclude/>
	public class UsrRealtyOfferTypeFreedomUISchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrRealtyOfferTypeFreedomUISchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyOfferTypeFreedomUISchema(UsrRealtyOfferTypeFreedomUISchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyOfferTypeFreedomUISchema(UsrRealtyOfferTypeFreedomUISchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135");
			RealUId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135");
			Name = "UsrRealtyOfferTypeFreedomUI";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			if (Columns.FindByUId(new Guid("ee0db629-2bb0-72ea-6cc4-5847e83d3962")) == null) {
				Columns.Add(CreateUsrCommissionPercentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrCommissionPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ee0db629-2bb0-72ea-6cc4-5847e83d3962"),
				Name = @"UsrCommissionPercent",
				CreatedInSchemaUId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135"),
				ModifiedInSchemaUId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135"),
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
			return new UsrRealtyOfferTypeFreedomUI(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyOfferTypeFreedomUISchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyOfferTypeFreedomUISchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyOfferTypeFreedomUI

	/// <summary>
	/// Realty offer type (FreedomUI).
	/// </summary>
	public class UsrRealtyOfferTypeFreedomUI : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrRealtyOfferTypeFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyOfferTypeFreedomUI";
		}

		public UsrRealtyOfferTypeFreedomUI(UsrRealtyOfferTypeFreedomUI source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Commission percent from 0 to 100 .
		/// </summary>
		public Decimal UsrCommissionPercent {
			get {
				return GetTypedColumnValue<Decimal>("UsrCommissionPercent");
			}
			set {
				SetColumnValue("UsrCommissionPercent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection);
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
			return new UsrRealtyOfferTypeFreedomUI(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public partial class UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyOfferTypeFreedomUI
	{

		public UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess";
			SchemaUId = new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("15e39dd6-156f-4db1-987d-8a5e0e573135");
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

	#region Class: UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess : UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<UsrRealtyOfferTypeFreedomUI>
	{

		public UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	public partial class UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyOfferTypeFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyOfferTypeFreedomUIEventsProcess : UsrRealtyOfferTypeFreedomUI_UsrRealtyFreedomUIEventsProcess
	{

		public UsrRealtyOfferTypeFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

