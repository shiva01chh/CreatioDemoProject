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

	#region Class: ConfigItemCategorySchema

	/// <exclude/>
	public class ConfigItemCategorySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ConfigItemCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ConfigItemCategorySchema(ConfigItemCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ConfigItemCategorySchema(ConfigItemCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			RealUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			Name = "ConfigItemCategory";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			column.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ConfigItemCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ConfigItemCategory_CMDBEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ConfigItemCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ConfigItemCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c"));
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemCategory

	/// <summary>
	/// CI category.
	/// </summary>
	public class ConfigItemCategory : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ConfigItemCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConfigItemCategory";
		}

		public ConfigItemCategory(ConfigItemCategory source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ConfigItemCategory_CMDBEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ConfigItemCategoryDeleted", e);
			Inserting += (s, e) => ThrowEvent("ConfigItemCategoryInserting", e);
			Validating += (s, e) => ThrowEvent("ConfigItemCategoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConfigItemCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemCategory_CMDBEventsProcess

	/// <exclude/>
	public partial class ConfigItemCategory_CMDBEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : ConfigItemCategory
	{

		public ConfigItemCategory_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfigItemCategory_CMDBEventsProcess";
			SchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c");
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

	#region Class: ConfigItemCategory_CMDBEventsProcess

	/// <exclude/>
	public class ConfigItemCategory_CMDBEventsProcess : ConfigItemCategory_CMDBEventsProcess<ConfigItemCategory>
	{

		public ConfigItemCategory_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfigItemCategory_CMDBEventsProcess

	public partial class ConfigItemCategory_CMDBEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ConfigItemCategoryEventsProcess

	/// <exclude/>
	public class ConfigItemCategoryEventsProcess : ConfigItemCategory_CMDBEventsProcess
	{

		public ConfigItemCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

