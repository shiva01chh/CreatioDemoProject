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

	#region Class: WarehouseSchema

	/// <exclude/>
	public class WarehouseSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public WarehouseSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WarehouseSchema(WarehouseSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WarehouseSchema(WarehouseSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3");
			RealUId = new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3");
			Name = "Warehouse";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
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
			return new Warehouse(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Warehouse_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WarehouseSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WarehouseSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3"));
		}

		#endregion

	}

	#endregion

	#region Class: Warehouse

	/// <summary>
	/// Warehouse.
	/// </summary>
	public class Warehouse : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Warehouse(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Warehouse";
		}

		public Warehouse(Warehouse source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Warehouse_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("WarehouseDeleted", e);
			Inserting += (s, e) => ThrowEvent("WarehouseInserting", e);
			Validating += (s, e) => ThrowEvent("WarehouseValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Warehouse(this);
		}

		#endregion

	}

	#endregion

	#region Class: Warehouse_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class Warehouse_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : Warehouse
	{

		public Warehouse_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Warehouse_CrtProductCatalogueEventsProcess";
			SchemaUId = new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("70daff1b-1b40-4ac3-9c93-cd76e1835fe3");
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

	#region Class: Warehouse_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class Warehouse_CrtProductCatalogueEventsProcess : Warehouse_CrtProductCatalogueEventsProcess<Warehouse>
	{

		public Warehouse_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Warehouse_CrtProductCatalogueEventsProcess

	public partial class Warehouse_CrtProductCatalogueEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WarehouseEventsProcess

	/// <exclude/>
	public class WarehouseEventsProcess : Warehouse_CrtProductCatalogueEventsProcess
	{

		public WarehouseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

