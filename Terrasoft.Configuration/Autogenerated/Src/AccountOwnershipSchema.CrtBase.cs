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

	#region Class: AccountOwnershipSchema

	/// <exclude/>
	public class AccountOwnershipSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AccountOwnershipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountOwnershipSchema(AccountOwnershipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountOwnershipSchema(AccountOwnershipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			RealUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			Name = "AccountOwnership";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
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
			if (Columns.FindByUId(new Guid("bd9ec46e-6371-466e-87ec-1adf995e47c7")) == null) {
				Columns.Add(CreateCountryColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bd9ec46e-6371-466e-87ec-1adf995e47c7"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"),
				ModifiedInSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountOwnership(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountOwnership_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountOwnershipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountOwnershipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnership

	/// <summary>
	/// Business entity.
	/// </summary>
	public class AccountOwnership : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AccountOwnership(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountOwnership";
		}

		public AccountOwnership(AccountOwnership source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountOwnership_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("AccountOwnershipDeleted", e);
			Deleting += (s, e) => ThrowEvent("AccountOwnershipDeleting", e);
			Inserted += (s, e) => ThrowEvent("AccountOwnershipInserted", e);
			Inserting += (s, e) => ThrowEvent("AccountOwnershipInserting", e);
			Saved += (s, e) => ThrowEvent("AccountOwnershipSaved", e);
			Saving += (s, e) => ThrowEvent("AccountOwnershipSaving", e);
			Validating += (s, e) => ThrowEvent("AccountOwnershipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AccountOwnership(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountOwnership_CrtBaseEventsProcess

	/// <exclude/>
	public partial class AccountOwnership_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : AccountOwnership
	{

		public AccountOwnership_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountOwnership_CrtBaseEventsProcess";
			SchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b");
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

	#region Class: AccountOwnership_CrtBaseEventsProcess

	/// <exclude/>
	public class AccountOwnership_CrtBaseEventsProcess : AccountOwnership_CrtBaseEventsProcess<AccountOwnership>
	{

		public AccountOwnership_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountOwnership_CrtBaseEventsProcess

	public partial class AccountOwnership_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountOwnershipEventsProcess

	/// <exclude/>
	public class AccountOwnershipEventsProcess : AccountOwnership_CrtBaseEventsProcess
	{

		public AccountOwnershipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

