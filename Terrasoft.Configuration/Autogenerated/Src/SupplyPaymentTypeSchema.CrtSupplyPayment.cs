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

	#region Class: SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091");
			RealUId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091");
			Name = "SupplyPaymentType_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
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
			return new SupplyPaymentType_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentType_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentType_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9876301-ffbc-4389-a53a-19413e3bd091"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentType_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Installment plan item type.
	/// </summary>
	public class SupplyPaymentType_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SupplyPaymentType_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentType_CrtSupplyPayment_Terrasoft";
		}

		public SupplyPaymentType_CrtSupplyPayment_Terrasoft(SupplyPaymentType_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentType_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentType_CrtSupplyPayment_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SupplyPaymentType_CrtSupplyPayment_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentType_CrtSupplyPayment_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentType_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentType_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentType_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SupplyPaymentType_CrtSupplyPayment_Terrasoft
	{

		public SupplyPaymentType_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentType_CrtSupplyPaymentEventsProcess";
			SchemaUId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f9876301-ffbc-4389-a53a-19413e3bd091");
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

	#region Class: SupplyPaymentType_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentType_CrtSupplyPaymentEventsProcess : SupplyPaymentType_CrtSupplyPaymentEventsProcess<SupplyPaymentType_CrtSupplyPayment_Terrasoft>
	{

		public SupplyPaymentType_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentType_CrtSupplyPaymentEventsProcess

	public partial class SupplyPaymentType_CrtSupplyPaymentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

