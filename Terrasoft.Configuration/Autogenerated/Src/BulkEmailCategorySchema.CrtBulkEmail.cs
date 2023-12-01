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

	#region Class: BulkEmailCategorySchema

	/// <exclude/>
	public class BulkEmailCategorySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BulkEmailCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailCategorySchema(BulkEmailCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailCategorySchema(BulkEmailCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454");
			RealUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454");
			Name = "BulkEmailCategory";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d6fec08a-2746-46b6-a96c-0a31e271957f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5fa358ab-b8b9-4a1b-9724-cd920cfa894a")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5fa358ab-b8b9-4a1b-9724-cd920cfa894a"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454"),
				ModifiedInSchemaUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailCategory_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13cffa88-d296-4202-8bee-d023d51a8454"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailCategory

	/// <summary>
	/// Email category.
	/// </summary>
	public class BulkEmailCategory : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BulkEmailCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailCategory";
		}

		public BulkEmailCategory(BulkEmailCategory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailCategory_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailCategoryDeleted", e);
			Validating += (s, e) => ThrowEvent("BulkEmailCategoryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailCategory_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailCategory_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailCategory
	{

		public BulkEmailCategory_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailCategory_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("13cffa88-d296-4202-8bee-d023d51a8454");
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

	#region Class: BulkEmailCategory_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailCategory_CrtBulkEmailEventsProcess : BulkEmailCategory_CrtBulkEmailEventsProcess<BulkEmailCategory>
	{

		public BulkEmailCategory_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailCategory_CrtBulkEmailEventsProcess

	public partial class BulkEmailCategory_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailCategoryEventsProcess

	/// <exclude/>
	public class BulkEmailCategoryEventsProcess : BulkEmailCategory_CrtBulkEmailEventsProcess
	{

		public BulkEmailCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

