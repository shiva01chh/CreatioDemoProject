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

	#region Class: OpportunityProductInterest_CrtOpportunity_TerrasoftSchema

	/// <exclude/>
	public class OpportunityProductInterest_CrtOpportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public OpportunityProductInterest_CrtOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OpportunityProductInterest_CrtOpportunity_TerrasoftSchema(OpportunityProductInterest_CrtOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OpportunityProductInterest_CrtOpportunity_TerrasoftSchema(OpportunityProductInterest_CrtOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			RealUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			Name = "OpportunityProductInterest_CrtOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a95a4e48-7891-4394-bebc-94a52d2c83db")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
			if (Columns.FindByUId(new Guid("31fb834c-0d66-4272-a002-92f7ee99dcc4")) == null) {
				Columns.Add(CreateProductColumn());
			}
			if (Columns.FindByUId(new Guid("c8aebeb1-1cfa-40e0-9d13-9e5a833a7af8")) == null) {
				Columns.Add(CreateQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("b7a9f0bb-fc54-4767-bb31-e282f72fa1a0")) == null) {
				Columns.Add(CreateOfferDateColumn());
			}
			if (Columns.FindByUId(new Guid("0d863985-10fd-4b5d-9135-c20b1522f626")) == null) {
				Columns.Add(CreateOfferResultColumn());
			}
			if (Columns.FindByUId(new Guid("9b6e7c1d-1407-474b-925a-e50da9f36419")) == null) {
				Columns.Add(CreateCommentColumn());
			}
			if (Columns.FindByUId(new Guid("8b1b514f-1ad8-46af-a324-5a9096a066dc")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("329a1823-df3b-4846-a6fb-c5f9fc259993")) == null) {
				Columns.Add(CreateAmountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a95a4e48-7891-4394-bebc-94a52d2c83db"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("31fb834c-0d66-4272-a002-92f7ee99dcc4"),
				Name = @"Product",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c8aebeb1-1cfa-40e0-9d13-9e5a833a7af8"),
				Name = @"Quantity",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOfferDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("b7a9f0bb-fc54-4767-bb31-e282f72fa1a0"),
				Name = @"OfferDate",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDate")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOfferResultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0d863985-10fd-4b5d-9135-c20b1522f626"),
				Name = @"OfferResult",
				ReferenceSchemaUId = new Guid("801a201c-7040-4489-a705-5896b20d2f52"),
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("9b6e7c1d-1407-474b-925a-e50da9f36419"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8b1b514f-1ad8-46af-a324-5a9096a066dc"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("329a1823-df3b-4846-a6fb-c5f9fc259993"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				ModifiedInSchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OpportunityProductInterest_CrtOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OpportunityProductInterest_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OpportunityProductInterest_CrtOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OpportunityProductInterest_CrtOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860"));
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_CrtOpportunity_Terrasoft

	/// <summary>
	/// Opportunity product.
	/// </summary>
	public class OpportunityProductInterest_CrtOpportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public OpportunityProductInterest_CrtOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityProductInterest_CrtOpportunity_Terrasoft";
		}

		public OpportunityProductInterest_CrtOpportunity_Terrasoft(OpportunityProductInterest_CrtOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		/// <exclude/>
		public Guid ProductId {
			get {
				return GetTypedColumnValue<Guid>("ProductId");
			}
			set {
				SetColumnValue("ProductId", value);
				_product = null;
			}
		}

		/// <exclude/>
		public string ProductName {
			get {
				return GetTypedColumnValue<string>("ProductName");
			}
			set {
				SetColumnValue("ProductName", value);
				if (_product != null) {
					_product.Name = value;
				}
			}
		}

		private Product _product;
		/// <summary>
		/// Product.
		/// </summary>
		public Product Product {
			get {
				return _product ??
					(_product = LookupColumnEntities.GetEntity("Product") as Product);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public Decimal Quantity {
			get {
				return GetTypedColumnValue<Decimal>("Quantity");
			}
			set {
				SetColumnValue("Quantity", value);
			}
		}

		/// <summary>
		/// Quoted on.
		/// </summary>
		public DateTime OfferDate {
			get {
				return GetTypedColumnValue<DateTime>("OfferDate");
			}
			set {
				SetColumnValue("OfferDate", value);
			}
		}

		/// <exclude/>
		public Guid OfferResultId {
			get {
				return GetTypedColumnValue<Guid>("OfferResultId");
			}
			set {
				SetColumnValue("OfferResultId", value);
				_offerResult = null;
			}
		}

		/// <exclude/>
		public string OfferResultName {
			get {
				return GetTypedColumnValue<string>("OfferResultName");
			}
			set {
				SetColumnValue("OfferResultName", value);
				if (_offerResult != null) {
					_offerResult.Name = value;
				}
			}
		}

		private PropositionResult _offerResult;
		/// <summary>
		/// Interest.
		/// </summary>
		public PropositionResult OfferResult {
			get {
				return _offerResult ??
					(_offerResult = LookupColumnEntities.GetEntity("OfferResult") as PropositionResult);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OpportunityProductInterest_CrtOpportunityEventsProcess(UserConnection);
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
			return new OpportunityProductInterest_CrtOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OpportunityProductInterest_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OpportunityProductInterest_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : OpportunityProductInterest_CrtOpportunity_Terrasoft
	{

		public OpportunityProductInterest_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityProductInterest_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a5657e6b-342d-4104-8ab8-aab37ef29860");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OpportunityId {
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

	#region Class: OpportunityProductInterest_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OpportunityProductInterest_CrtOpportunityEventsProcess : OpportunityProductInterest_CrtOpportunityEventsProcess<OpportunityProductInterest_CrtOpportunity_Terrasoft>
	{

		public OpportunityProductInterest_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

