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

	#region Class: SysPackageResourceChecksumSchema

	/// <exclude/>
	public class SysPackageResourceChecksumSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysPackageResourceChecksumSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPackageResourceChecksumSchema(SysPackageResourceChecksumSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPackageResourceChecksumSchema(SysPackageResourceChecksumSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIPackageSchemaCultureIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bd1b296c-10df-4e8b-bece-9c2f9594f98a");
			index.Name = "IPackageSchemaCulture";
			index.CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f");
			index.ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f");
			index.CreatedInPackageId = new Guid("2edc5c83-f3cb-4c2f-af15-29fa964d8f29");
			EntitySchemaIndexColumn sysPackageIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("23bb31be-3bac-2f0f-046d-272cd23eae3c"),
				ColumnUId = new Guid("d8c017d5-4f8c-4aea-bc26-764d500decb5"),
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("2edc5c83-f3cb-4c2f-af15-29fa964d8f29"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysPackageIdIndexColumn);
			EntitySchemaIndexColumn sysSchemaIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("e20ce6de-6592-69bf-fde3-4126536feeca"),
				ColumnUId = new Guid("e1cc29fa-e2c8-4dad-8d82-eaae34b53d01"),
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("2edc5c83-f3cb-4c2f-af15-29fa964d8f29"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysSchemaIdIndexColumn);
			EntitySchemaIndexColumn sysCultureIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("d88e8fae-ca11-edf1-dbaa-2237dd56d5f1"),
				ColumnUId = new Guid("e5cc5694-1164-4375-bf56-759d983a6d53"),
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("2edc5c83-f3cb-4c2f-af15-29fa964d8f29"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysCultureIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b33f0732-9f59-4542-a647-57391279d18f");
			RealUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f");
			Name = "SysPackageResourceChecksum";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d8c017d5-4f8c-4aea-bc26-764d500decb5")) == null) {
				Columns.Add(CreateSysPackageColumn());
			}
			if (Columns.FindByUId(new Guid("e1cc29fa-e2c8-4dad-8d82-eaae34b53d01")) == null) {
				Columns.Add(CreateSysSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("31fa5f97-33b1-4b71-9f3b-7639cad3e9d5")) == null) {
				Columns.Add(CreateSysSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("bb479219-57bf-42dc-ae05-225a6dba4693")) == null) {
				Columns.Add(CreateResourceManagerColumn());
			}
			if (Columns.FindByUId(new Guid("e5cc5694-1164-4375-bf56-759d983a6d53")) == null) {
				Columns.Add(CreateSysCultureColumn());
			}
			if (Columns.FindByUId(new Guid("3d762101-073a-4bb7-908e-98cc94417933")) == null) {
				Columns.Add(CreateIsChangedColumn());
			}
			if (Columns.FindByUId(new Guid("62b97e53-3ddf-4d91-9dcb-bc603c4282a8")) == null) {
				Columns.Add(CreateChecksumColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysPackageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d8c017d5-4f8c-4aea-bc26-764d500decb5"),
				Name = @"SysPackage",
				ReferenceSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e1cc29fa-e2c8-4dad-8d82-eaae34b53d01"),
				Name = @"SysSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("31fa5f97-33b1-4b71-9f3b-7639cad3e9d5"),
				Name = @"SysSchemaName",
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateResourceManagerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("bb479219-57bf-42dc-ae05-225a6dba4693"),
				Name = @"ResourceManager",
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysCultureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e5cc5694-1164-4375-bf56-759d983a6d53"),
				Name = @"SysCulture",
				ReferenceSchemaUId = new Guid("ffc193e1-04bc-472b-bdc0-3333d1df84e4"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChangedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3d762101-073a-4bb7-908e-98cc94417933"),
				Name = @"IsChanged",
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateChecksumColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("62b97e53-3ddf-4d91-9dcb-bc603c4282a8"),
				Name = @"Checksum",
				CreatedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				ModifiedInSchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIPackageSchemaCultureIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPackageResourceChecksum(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysPackageResourceChecksum_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysPackageResourceChecksumSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPackageResourceChecksumSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b33f0732-9f59-4542-a647-57391279d18f"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageResourceChecksum

	/// <summary>
	/// Checksum of package resources.
	/// </summary>
	public class SysPackageResourceChecksum : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysPackageResourceChecksum(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPackageResourceChecksum";
		}

		public SysPackageResourceChecksum(SysPackageResourceChecksum source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SysPackageId {
			get {
				return GetTypedColumnValue<Guid>("SysPackageId");
			}
			set {
				SetColumnValue("SysPackageId", value);
				_sysPackage = null;
			}
		}

		/// <exclude/>
		public string SysPackageName {
			get {
				return GetTypedColumnValue<string>("SysPackageName");
			}
			set {
				SetColumnValue("SysPackageName", value);
				if (_sysPackage != null) {
					_sysPackage.Name = value;
				}
			}
		}

		private SysPackage _sysPackage;
		/// <summary>
		/// Package.
		/// </summary>
		public SysPackage SysPackage {
			get {
				return _sysPackage ??
					(_sysPackage = LookupColumnEntities.GetEntity("SysPackage") as SysPackage);
			}
		}

		/// <exclude/>
		public Guid SysSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaId");
			}
			set {
				SetColumnValue("SysSchemaId", value);
				_sysSchema = null;
			}
		}

		/// <exclude/>
		public string SysSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysSchemaCaption");
			}
			set {
				SetColumnValue("SysSchemaCaption", value);
				if (_sysSchema != null) {
					_sysSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysSchema;
		/// <summary>
		/// Schema.
		/// </summary>
		public SysSchema SysSchema {
			get {
				return _sysSchema ??
					(_sysSchema = LookupColumnEntities.GetEntity("SysSchema") as SysSchema);
			}
		}

		/// <summary>
		/// Schema name.
		/// </summary>
		public string SysSchemaName {
			get {
				return GetTypedColumnValue<string>("SysSchemaName");
			}
			set {
				SetColumnValue("SysSchemaName", value);
			}
		}

		/// <summary>
		/// Resource manager name.
		/// </summary>
		public string ResourceManager {
			get {
				return GetTypedColumnValue<string>("ResourceManager");
			}
			set {
				SetColumnValue("ResourceManager", value);
			}
		}

		/// <exclude/>
		public Guid SysCultureId {
			get {
				return GetTypedColumnValue<Guid>("SysCultureId");
			}
			set {
				SetColumnValue("SysCultureId", value);
				_sysCulture = null;
			}
		}

		/// <exclude/>
		public string SysCultureName {
			get {
				return GetTypedColumnValue<string>("SysCultureName");
			}
			set {
				SetColumnValue("SysCultureName", value);
				if (_sysCulture != null) {
					_sysCulture.Name = value;
				}
			}
		}

		private SysCulture _sysCulture;
		/// <summary>
		/// Culture.
		/// </summary>
		public SysCulture SysCulture {
			get {
				return _sysCulture ??
					(_sysCulture = LookupColumnEntities.GetEntity("SysCulture") as SysCulture);
			}
		}

		/// <summary>
		/// Is Changed.
		/// </summary>
		public bool IsChanged {
			get {
				return GetTypedColumnValue<bool>("IsChanged");
			}
			set {
				SetColumnValue("IsChanged", value);
			}
		}

		/// <summary>
		/// Checksum.
		/// </summary>
		public string Checksum {
			get {
				return GetTypedColumnValue<string>("Checksum");
			}
			set {
				SetColumnValue("Checksum", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPackageResourceChecksum_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysPackageResourceChecksumDeleted", e);
			Validating += (s, e) => ThrowEvent("SysPackageResourceChecksumValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackageResourceChecksum(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPackageResourceChecksum_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysPackageResourceChecksum_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysPackageResourceChecksum
	{

		public SysPackageResourceChecksum_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPackageResourceChecksum_CrtBaseEventsProcess";
			SchemaUId = new Guid("b33f0732-9f59-4542-a647-57391279d18f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b33f0732-9f59-4542-a647-57391279d18f");
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

	#region Class: SysPackageResourceChecksum_CrtBaseEventsProcess

	/// <exclude/>
	public class SysPackageResourceChecksum_CrtBaseEventsProcess : SysPackageResourceChecksum_CrtBaseEventsProcess<SysPackageResourceChecksum>
	{

		public SysPackageResourceChecksum_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPackageResourceChecksum_CrtBaseEventsProcess

	public partial class SysPackageResourceChecksum_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysPackageResourceChecksumEventsProcess

	/// <exclude/>
	public class SysPackageResourceChecksumEventsProcess : SysPackageResourceChecksum_CrtBaseEventsProcess
	{

		public SysPackageResourceChecksumEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

