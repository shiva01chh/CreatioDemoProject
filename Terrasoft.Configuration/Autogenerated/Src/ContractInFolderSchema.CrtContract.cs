﻿namespace Terrasoft.Configuration
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

	#region Class: ContractInFolderSchema

	/// <exclude/>
	public class ContractInFolderSchema : Terrasoft.Configuration.BaseItemInFolderSchema
	{

		#region Constructors: Public

		public ContractInFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContractInFolderSchema(ContractInFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContractInFolderSchema(ContractInFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a");
			RealUId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a");
			Name = "ContractInFolder";
			ParentSchemaUId = new Guid("4f63bafb-e9e7-4082-b92e-66b97c14017c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c31ca2a9-f302-4ca7-ad70-594448f77a42")) == null) {
				Columns.Add(CreateContractColumn());
			}
		}

		protected override EntitySchemaColumn CreateFolderColumn() {
			EntitySchemaColumn column = base.CreateFolderColumn();
			column.ReferenceSchemaUId = new Guid("c145cbc3-6481-49a7-86a9-d855c1e8982b");
			column.ColumnValueName = @"FolderId";
			column.DisplayColumnValueName = @"FolderName";
			column.ModifiedInSchemaUId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContractColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c31ca2a9-f302-4ca7-ad70-594448f77a42"),
				Name = @"Contract",
				ReferenceSchemaUId = new Guid("897be3e4-0333-467d-88e2-b7a945c0d810"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a"),
				ModifiedInSchemaUId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a"),
				CreatedInPackageId = new Guid("1401a881-7126-4c81-86f8-4e9e355b0669")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContractInFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContractInFolder_CrtContractEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContractInFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContractInFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a"));
		}

		#endregion

	}

	#endregion

	#region Class: ContractInFolder

	/// <summary>
	/// Contract in folder.
	/// </summary>
	public class ContractInFolder : Terrasoft.Configuration.BaseItemInFolder
	{

		#region Constructors: Public

		public ContractInFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContractInFolder";
		}

		public ContractInFolder(ContractInFolder source)
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
		/// Договоры.
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
			var process = new ContractInFolder_CrtContractEventsProcess(UserConnection);
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
			return new ContractInFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContractInFolder_CrtContractEventsProcess

	/// <exclude/>
	public partial class ContractInFolder_CrtContractEventsProcess<TEntity> : Terrasoft.Configuration.BaseItemInFolder_CrtBaseEventsProcess<TEntity> where TEntity : ContractInFolder
	{

		public ContractInFolder_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContractInFolder_CrtContractEventsProcess";
			SchemaUId = new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8c2a7b51-4a87-4c2b-8bc5-02d66f767c8a");
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

	#region Class: ContractInFolder_CrtContractEventsProcess

	/// <exclude/>
	public class ContractInFolder_CrtContractEventsProcess : ContractInFolder_CrtContractEventsProcess<ContractInFolder>
	{

		public ContractInFolder_CrtContractEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContractInFolder_CrtContractEventsProcess

	public partial class ContractInFolder_CrtContractEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContractInFolderEventsProcess

	/// <exclude/>
	public class ContractInFolderEventsProcess : ContractInFolder_CrtContractEventsProcess
	{

		public ContractInFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

