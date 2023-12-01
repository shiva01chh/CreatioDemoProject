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

	#region Class: Document_CrtContractDocument_TerrasoftSchema

	/// <exclude/>
	public class Document_CrtContractDocument_TerrasoftSchema : Terrasoft.Configuration.Document_CrtDocument_TerrasoftSchema
	{

		#region Constructors: Public

		public Document_CrtContractDocument_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Document_CrtContractDocument_TerrasoftSchema(Document_CrtContractDocument_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Document_CrtContractDocument_TerrasoftSchema(Document_CrtContractDocument_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("05ec5c8c-fd85-418e-8d4a-95cd4f8b1f77");
			Name = "Document_CrtContractDocument_Terrasoft";
			ParentSchemaUId = new Guid("8b33b6b2-19f7-4222-9161-b4054b3fbb09");
			ExtendParent = true;
			CreatedInPackageId = new Guid("7f2d0fd0-8147-4292-af7e-8927e24f9683");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2eb5cfde-2a75-43fa-a3d0-cbea861f2a81")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2eb5cfde-2a75-43fa-a3d0-cbea861f2a81"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("05ec5c8c-fd85-418e-8d4a-95cd4f8b1f77"),
				ModifiedInSchemaUId = new Guid("05ec5c8c-fd85-418e-8d4a-95cd4f8b1f77"),
				CreatedInPackageId = new Guid("7f2d0fd0-8147-4292-af7e-8927e24f9683")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Document_CrtContractDocument_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Document_CrtContractDocumentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Document_CrtContractDocument_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Document_CrtContractDocument_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("05ec5c8c-fd85-418e-8d4a-95cd4f8b1f77"));
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtContractDocument_Terrasoft

	/// <summary>
	/// Document.
	/// </summary>
	public class Document_CrtContractDocument_Terrasoft : Terrasoft.Configuration.Document_CrtDocument_Terrasoft
	{

		#region Constructors: Public

		public Document_CrtContractDocument_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Document_CrtContractDocument_Terrasoft";
		}

		public Document_CrtContractDocument_Terrasoft(Document_CrtContractDocument_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ContractId {
			get {
				return GetTypedColumnValue<Guid>("ContractId");
			}
			set {
				SetColumnValue("ContractId", value);
				_contract = null;
			}
		}

		/// <exclude/>
		public string ContractNumber {
			get {
				return GetTypedColumnValue<string>("ContractNumber");
			}
			set {
				SetColumnValue("ContractNumber", value);
				if (_contract != null) {
					_contract.Number = value;
				}
			}
		}

		private Contract _contract;
		/// <summary>
		/// Contract.
		/// </summary>
		public Contract Contract {
			get {
				return _contract ??
					(_contract = LookupColumnEntities.GetEntity("Contract") as Contract);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Document_CrtContractDocumentEventsProcess(UserConnection);
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
			return new Document_CrtContractDocument_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Document_CrtContractDocumentEventsProcess

	/// <exclude/>
	public partial class Document_CrtContractDocumentEventsProcess<TEntity> : Terrasoft.Configuration.Document_CrtDocumentEventsProcess<TEntity> where TEntity : Document_CrtContractDocument_Terrasoft
	{

		public Document_CrtContractDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Document_CrtContractDocumentEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("05ec5c8c-fd85-418e-8d4a-95cd4f8b1f77");
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

	#region Class: Document_CrtContractDocumentEventsProcess

	/// <exclude/>
	public class Document_CrtContractDocumentEventsProcess : Document_CrtContractDocumentEventsProcess<Document_CrtContractDocument_Terrasoft>
	{

		public Document_CrtContractDocumentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Document_CrtContractDocumentEventsProcess

	public partial class Document_CrtContractDocumentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

