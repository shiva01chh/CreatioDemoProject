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

	#region Class: AccountEnrichedDataSchema

	/// <exclude/>
	public class AccountEnrichedDataSchema : Terrasoft.Configuration.BaseEnrichedDataSchema
	{

		#region Constructors: Public

		public AccountEnrichedDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountEnrichedDataSchema(AccountEnrichedDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountEnrichedDataSchema(AccountEnrichedDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			RealUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			Name = "AccountEnrichedData";
			ParentSchemaUId = new Guid("a06e4cd4-ea74-48da-9c77-b37d20d162db");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("62d98a27-2a9c-4161-a0ab-81d268290488")) == null) {
				Columns.Add(CreateAccountColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("62d98a27-2a9c-4161-a0ab-81d268290488"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1"),
				ModifiedInSchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1"),
				CreatedInPackageId = new Guid("8f65d303-02ac-4efc-966c-086ff392449b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountEnrichedData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountEnrichedData_EnrichmentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountEnrichedDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountEnrichedDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData

	/// <summary>
	/// Unprocessed enriched Account data.
	/// </summary>
	public class AccountEnrichedData : Terrasoft.Configuration.BaseEnrichedData
	{

		#region Constructors: Public

		public AccountEnrichedData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountEnrichedData";
		}

		public AccountEnrichedData(AccountEnrichedData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountEnrichedData_EnrichmentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountEnrichedDataDeleted", e);
			Validating += (s, e) => ThrowEvent("AccountEnrichedDataValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountEnrichedData(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountEnrichedData_EnrichmentEventsProcess

	/// <exclude/>
	public partial class AccountEnrichedData_EnrichmentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEnrichedData_EnrichmentEventsProcess<TEntity> where TEntity : AccountEnrichedData
	{

		public AccountEnrichedData_EnrichmentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountEnrichedData_EnrichmentEventsProcess";
			SchemaUId = new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9c192887-0e45-497d-bd95-58fed2b91bf1");
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

	#region Class: AccountEnrichedData_EnrichmentEventsProcess

	/// <exclude/>
	public class AccountEnrichedData_EnrichmentEventsProcess : AccountEnrichedData_EnrichmentEventsProcess<AccountEnrichedData>
	{

		public AccountEnrichedData_EnrichmentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountEnrichedData_EnrichmentEventsProcess

	public partial class AccountEnrichedData_EnrichmentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountEnrichedDataEventsProcess

	/// <exclude/>
	public class AccountEnrichedDataEventsProcess : AccountEnrichedData_EnrichmentEventsProcess
	{

		public AccountEnrichedDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

