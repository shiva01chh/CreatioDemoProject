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

	#region Class: SupplyPayment_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	[IsVirtual]
	public class SupplyPayment_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SupplyPayment_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPayment_CrtSupplyPayment_TerrasoftSchema(SupplyPayment_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPayment_CrtSupplyPayment_TerrasoftSchema(SupplyPayment_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			RealUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			Name = "SupplyPayment_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			if (Columns.FindByUId(new Guid("f5e69141-5900-4800-93b7-6c06ca1e991d")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a3d987f5-d9a8-4016-b260-ee47be3c60b8")) == null) {
				Columns.Add(CreateDelayTypeColumn());
			}
			if (Columns.FindByUId(new Guid("e361f1d8-b6cb-47f5-9496-6347f6499848")) == null) {
				Columns.Add(CreateDelayColumn());
			}
			if (Columns.FindByUId(new Guid("c28a0bba-c826-48dd-8a58-0b80b4f55dee")) == null) {
				Columns.Add(CreatePercentageColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			column.CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f5e69141-5900-4800-93b7-6c06ca1e991d"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dd703360-9b62-47fe-abb5-2f3ff6a57911"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("f9876301-ffbc-4389-a53a-19413e3bd091"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDelayTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3d987f5-d9a8-4016-b260-ee47be3c60b8"),
				Name = @"DelayType",
				ReferenceSchemaUId = new Guid("180c1fb4-d61b-4aca-b6b3-e1fae4eaab1b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDelayColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e361f1d8-b6cb-47f5-9496-6347f6499848"),
				Name = @"Delay",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c28a0bba-c826-48dd-8a58-0b80b4f55dee"),
				Name = @"Percentage",
				CreatedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				ModifiedInSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818"),
				CreatedInPackageId = new Guid("f50b1877-37f3-4844-90b8-f493542cdd8d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPayment_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPayment_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPayment_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPayment_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("980a8f16-f64b-4446-8894-4637063d3818"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Installment plan.
	/// </summary>
	public class SupplyPayment_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SupplyPayment_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPayment_CrtSupplyPayment_Terrasoft";
		}

		public SupplyPayment_CrtSupplyPayment_Terrasoft(SupplyPayment_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SupplyPaymentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public SupplyPaymentType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SupplyPaymentType);
			}
		}

		/// <exclude/>
		public Guid DelayTypeId {
			get {
				return GetTypedColumnValue<Guid>("DelayTypeId");
			}
			set {
				SetColumnValue("DelayTypeId", value);
				_delayType = null;
			}
		}

		/// <exclude/>
		public string DelayTypeName {
			get {
				return GetTypedColumnValue<string>("DelayTypeName");
			}
			set {
				SetColumnValue("DelayTypeName", value);
				if (_delayType != null) {
					_delayType.Name = value;
				}
			}
		}

		private SupplyPaymentDelay _delayType;
		/// <summary>
		/// Deferment type.
		/// </summary>
		public SupplyPaymentDelay DelayType {
			get {
				return _delayType ??
					(_delayType = LookupColumnEntities.GetEntity("DelayType") as SupplyPaymentDelay);
			}
		}

		/// <summary>
		/// Deferment (days).
		/// </summary>
		public int Delay {
			get {
				return GetTypedColumnValue<int>("Delay");
			}
			set {
				SetColumnValue("Delay", value);
			}
		}

		/// <summary>
		/// Percentage, %.
		/// </summary>
		public Decimal Percentage {
			get {
				return GetTypedColumnValue<Decimal>("Percentage");
			}
			set {
				SetColumnValue("Percentage", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPayment_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPayment_CrtSupplyPayment_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("SupplyPayment_CrtSupplyPayment_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("SupplyPayment_CrtSupplyPayment_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SupplyPayment_CrtSupplyPayment_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPayment_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPayment_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class SupplyPayment_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SupplyPayment_CrtSupplyPayment_Terrasoft
	{

		public SupplyPayment_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPayment_CrtSupplyPaymentEventsProcess";
			SchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool DoNotCheckCascadeCycle {
			get;
			set;
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

	#region Class: SupplyPayment_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPayment_CrtSupplyPaymentEventsProcess : SupplyPayment_CrtSupplyPaymentEventsProcess<SupplyPayment_CrtSupplyPayment_Terrasoft>
	{

		public SupplyPayment_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

