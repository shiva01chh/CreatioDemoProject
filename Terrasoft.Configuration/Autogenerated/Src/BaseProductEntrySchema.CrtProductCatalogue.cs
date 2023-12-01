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

	#region Class: BaseProductEntrySchema

	/// <exclude/>
	[IsVirtual]
	public class BaseProductEntrySchema : Terrasoft.Configuration.BaseProductEntry_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public BaseProductEntrySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseProductEntrySchema(BaseProductEntrySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseProductEntrySchema(BaseProductEntrySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1");
			Name = "BaseProductEntry";
			ParentSchemaUId = new Guid("04802832-e447-4188-a324-f2d1ca6efcc4");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e71dceda-9b0f-4509-aa10-f479aa69a9eb")) == null) {
				Columns.Add(CreatePriceListColumn());
			}
		}

		protected override EntitySchemaColumn CreateQuantityColumn() {
			EntitySchemaColumn column = base.CreateQuantityColumn();
			column.ModifiedInSchemaUId = new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1");
			column.CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePriceListColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e71dceda-9b0f-4509-aa10-f479aa69a9eb"),
				Name = @"PriceList",
				ReferenceSchemaUId = new Guid("036f6f5b-838d-4187-9749-b54c8539c076"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1"),
				ModifiedInSchemaUId = new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1"),
				CreatedInPackageId = new Guid("d4cfcde0-bd2a-4719-a4df-63ed38689467")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseProductEntry(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseProductEntry_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseProductEntrySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseProductEntrySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry

	/// <summary>
	/// Base product in item.
	/// </summary>
	public class BaseProductEntry : Terrasoft.Configuration.BaseProductEntry_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public BaseProductEntry(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseProductEntry";
		}

		public BaseProductEntry(BaseProductEntry source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PriceListId {
			get {
				return GetTypedColumnValue<Guid>("PriceListId");
			}
			set {
				SetColumnValue("PriceListId", value);
				_priceList = null;
			}
		}

		/// <exclude/>
		public string PriceListName {
			get {
				return GetTypedColumnValue<string>("PriceListName");
			}
			set {
				SetColumnValue("PriceListName", value);
				if (_priceList != null) {
					_priceList.Name = value;
				}
			}
		}

		private Pricelist _priceList;
		/// <summary>
		/// Price list.
		/// </summary>
		public Pricelist PriceList {
			get {
				return _priceList ??
					(_priceList = LookupColumnEntities.GetEntity("PriceList") as Pricelist);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseProductEntry_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseProductEntryDeleted", e);
			Inserting += (s, e) => ThrowEvent("BaseProductEntryInserting", e);
			Validating += (s, e) => ThrowEvent("BaseProductEntryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseProductEntry(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseProductEntry_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class BaseProductEntry_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseProductEntry_CrtBaseEventsProcess<TEntity> where TEntity : BaseProductEntry
	{

		public BaseProductEntry_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseProductEntry_CrtProductCatalogueEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8d805e9b-e297-402a-847f-cbe300ea06b1");
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

	#region Class: BaseProductEntry_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class BaseProductEntry_CrtProductCatalogueEventsProcess : BaseProductEntry_CrtProductCatalogueEventsProcess<BaseProductEntry>
	{

		public BaseProductEntry_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseProductEntry_CrtProductCatalogueEventsProcess

	public partial class BaseProductEntry_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BaseProductEntryEventsProcess

	/// <exclude/>
	public class BaseProductEntryEventsProcess : BaseProductEntry_CrtProductCatalogueEventsProcess
	{

		public BaseProductEntryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

