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

	#region Class: Lead_PRMBase_TerrasoftSchema

	/// <exclude/>
	public class Lead_PRMBase_TerrasoftSchema : Terrasoft.Configuration.Lead_CrtLeadOppMgmtApp_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_PRMBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_PRMBase_TerrasoftSchema(Lead_PRMBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_PRMBase_TerrasoftSchema(Lead_PRMBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406");
			Name = "Lead_PRMBase_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("693f56bf-b9bb-4f39-bca2-1b307f60cca5")) == null) {
				Columns.Add(CreatePartnerColumn());
			}
			if (Columns.FindByUId(new Guid("becf8a84-8327-4864-97d3-209b2a7dc67e")) == null) {
				Columns.Add(CreatePartnerOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("215eb46b-7973-42c0-bb8f-8b011a8fbd67")) == null) {
				Columns.Add(CreatePartnerTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePartnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("693f56bf-b9bb-4f39-bca2-1b307f60cca5"),
				Name = @"Partner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("becf8a84-8327-4864-97d3-209b2a7dc67e"),
				Name = @"PartnerOwner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3")
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("215eb46b-7973-42c0-bb8f-8b011a8fbd67"),
				Name = @"PartnerType",
				ReferenceSchemaUId = new Guid("43cadf79-8d33-4697-8344-ec24fa905332"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				ModifiedInSchemaUId = new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"),
				CreatedInPackageId = new Guid("c753c9c2-3fc1-46be-9c9c-b15f50a19487")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_PRMBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_PRMBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_PRMBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMBase_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_PRMBase_Terrasoft : Terrasoft.Configuration.Lead_CrtLeadOppMgmtApp_Terrasoft
	{

		#region Constructors: Public

		public Lead_PRMBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_PRMBase_Terrasoft";
		}

		public Lead_PRMBase_Terrasoft(Lead_PRMBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PartnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerId");
			}
			set {
				SetColumnValue("PartnerId", value);
				_partner = null;
			}
		}

		/// <exclude/>
		public string PartnerName {
			get {
				return GetTypedColumnValue<string>("PartnerName");
			}
			set {
				SetColumnValue("PartnerName", value);
				if (_partner != null) {
					_partner.Name = value;
				}
			}
		}

		private Account _partner;
		/// <summary>
		/// Partner.
		/// </summary>
		public Account Partner {
			get {
				return _partner ??
					(_partner = LookupColumnEntities.GetEntity("Partner") as Account);
			}
		}

		/// <exclude/>
		public Guid PartnerOwnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerOwnerId");
			}
			set {
				SetColumnValue("PartnerOwnerId", value);
				_partnerOwner = null;
			}
		}

		/// <exclude/>
		public string PartnerOwnerName {
			get {
				return GetTypedColumnValue<string>("PartnerOwnerName");
			}
			set {
				SetColumnValue("PartnerOwnerName", value);
				if (_partnerOwner != null) {
					_partnerOwner.Name = value;
				}
			}
		}

		private Contact _partnerOwner;
		/// <summary>
		/// Partner's deal owner.
		/// </summary>
		public Contact PartnerOwner {
			get {
				return _partnerOwner ??
					(_partnerOwner = LookupColumnEntities.GetEntity("PartnerOwner") as Contact);
			}
		}

		/// <exclude/>
		public Guid PartnerTypeId {
			get {
				return GetTypedColumnValue<Guid>("PartnerTypeId");
			}
			set {
				SetColumnValue("PartnerTypeId", value);
				_partnerType = null;
			}
		}

		/// <exclude/>
		public string PartnerTypeName {
			get {
				return GetTypedColumnValue<string>("PartnerTypeName");
			}
			set {
				SetColumnValue("PartnerTypeName", value);
				if (_partnerType != null) {
					_partnerType.Name = value;
				}
			}
		}

		private PartnerType _partnerType;
		/// <summary>
		/// Partner type.
		/// </summary>
		public PartnerType PartnerType {
			get {
				return _partnerType ??
					(_partnerType = LookupColumnEntities.GetEntity("PartnerType") as PartnerType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_PRMBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Lead_PRMBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_PRMBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_PRMBaseEventsProcess

	/// <exclude/>
	public partial class Lead_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CrtLeadOppMgmtAppEventsProcess<TEntity> where TEntity : Lead_PRMBase_Terrasoft
	{

		public Lead_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_PRMBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("55020fdb-b605-40c2-ac32-4aa3e46c5406");
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

	#region Class: Lead_PRMBaseEventsProcess

	/// <exclude/>
	public class Lead_PRMBaseEventsProcess : Lead_PRMBaseEventsProcess<Lead_PRMBase_Terrasoft>
	{

		public Lead_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

