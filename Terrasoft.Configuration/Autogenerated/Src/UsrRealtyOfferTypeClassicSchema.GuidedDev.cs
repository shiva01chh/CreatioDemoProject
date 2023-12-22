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

	#region Class: UsrRealtyOfferTypeClassicSchema

	/// <exclude/>
	public class UsrRealtyOfferTypeClassicSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrRealtyOfferTypeClassicSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyOfferTypeClassicSchema(UsrRealtyOfferTypeClassicSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyOfferTypeClassicSchema(UsrRealtyOfferTypeClassicSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a");
			RealUId = new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a");
			Name = "UsrRealtyOfferTypeClassic";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyOfferTypeClassic(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyOfferTypeClassic_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyOfferTypeClassicSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyOfferTypeClassicSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyOfferTypeClassic

	/// <summary>
	/// Realty offer type (Classic UI).
	/// </summary>
	public class UsrRealtyOfferTypeClassic : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrRealtyOfferTypeClassic(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyOfferTypeClassic";
		}

		public UsrRealtyOfferTypeClassic(UsrRealtyOfferTypeClassic source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyOfferTypeClassic_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyOfferTypeClassic(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyOfferTypeClassic_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyOfferTypeClassic_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyOfferTypeClassic
	{

		public UsrRealtyOfferTypeClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyOfferTypeClassic_GuidedDevEventsProcess";
			SchemaUId = new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("414d23ab-aa07-4f1c-8c3e-8b981f52765a");
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

	#region Class: UsrRealtyOfferTypeClassic_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyOfferTypeClassic_GuidedDevEventsProcess : UsrRealtyOfferTypeClassic_GuidedDevEventsProcess<UsrRealtyOfferTypeClassic>
	{

		public UsrRealtyOfferTypeClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyOfferTypeClassic_GuidedDevEventsProcess

	public partial class UsrRealtyOfferTypeClassic_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyOfferTypeClassicEventsProcess

	/// <exclude/>
	public class UsrRealtyOfferTypeClassicEventsProcess : UsrRealtyOfferTypeClassic_GuidedDevEventsProcess
	{

		public UsrRealtyOfferTypeClassicEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

