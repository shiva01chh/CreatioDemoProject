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

	#region Class: MobileDataSchema

	/// <exclude/>
	public class MobileDataSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MobileDataSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MobileDataSchema(MobileDataSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MobileDataSchema(MobileDataSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			RealUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			Name = "MobileData";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateKeyColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5abe3cba-c37e-419a-b178-c20952efbea0")) == null) {
				Columns.Add(CreateDataColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			column.CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9");
			return column;
		}

		protected virtual EntitySchemaColumn CreateKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c92ba8ae-e05b-4362-9e54-3625712f777d"),
				Name = @"Key",
				CreatedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945"),
				ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945"),
				CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9")
			};
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("5abe3cba-c37e-419a-b178-c20952efbea0"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945"),
				ModifiedInSchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945"),
				CreatedInPackageId = new Guid("e2c2008c-7396-45cb-8401-7d26d5ad26d9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MobileData(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MobileData_CrtMobile7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MobileDataSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MobileDataSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7dc1463c-4366-451d-abf2-41ce4375f945"));
		}

		#endregion

	}

	#endregion

	#region Class: MobileData

	/// <summary>
	/// Mobile application data.
	/// </summary>
	public class MobileData : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MobileData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MobileData";
		}

		public MobileData(MobileData source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Key.
		/// </summary>
		public string Key {
			get {
				return GetTypedColumnValue<string>("Key");
			}
			set {
				SetColumnValue("Key", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MobileData_CrtMobile7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MobileDataDeleted", e);
			Inserting += (s, e) => ThrowEvent("MobileDataInserting", e);
			Validating += (s, e) => ThrowEvent("MobileDataValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MobileData(this);
		}

		#endregion

	}

	#endregion

	#region Class: MobileData_CrtMobile7xEventsProcess

	/// <exclude/>
	public partial class MobileData_CrtMobile7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : MobileData
	{

		public MobileData_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MobileData_CrtMobile7xEventsProcess";
			SchemaUId = new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7dc1463c-4366-451d-abf2-41ce4375f945");
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

	#region Class: MobileData_CrtMobile7xEventsProcess

	/// <exclude/>
	public class MobileData_CrtMobile7xEventsProcess : MobileData_CrtMobile7xEventsProcess<MobileData>
	{

		public MobileData_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MobileData_CrtMobile7xEventsProcess

	public partial class MobileData_CrtMobile7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MobileDataEventsProcess

	/// <exclude/>
	public class MobileDataEventsProcess : MobileData_CrtMobile7xEventsProcess
	{

		public MobileDataEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

