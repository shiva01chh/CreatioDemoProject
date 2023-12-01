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

	#region Class: BrandSchema

	/// <exclude/>
	public class BrandSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BrandSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BrandSchema(BrandSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BrandSchema(BrandSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
			RealUId = new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
			Name = "Brand";
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
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Brand(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Brand_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BrandSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BrandSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd"));
		}

		#endregion

	}

	#endregion

	#region Class: Brand

	/// <summary>
	/// Brand.
	/// </summary>
	public class Brand : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Brand(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Brand";
		}

		public Brand(Brand source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Brand_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BrandDeleted", e);
			Deleting += (s, e) => ThrowEvent("BrandDeleting", e);
			Inserted += (s, e) => ThrowEvent("BrandInserted", e);
			Inserting += (s, e) => ThrowEvent("BrandInserting", e);
			Saved += (s, e) => ThrowEvent("BrandSaved", e);
			Saving += (s, e) => ThrowEvent("BrandSaving", e);
			Validating += (s, e) => ThrowEvent("BrandValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Brand(this);
		}

		#endregion

	}

	#endregion

	#region Class: Brand_CrtBaseEventsProcess

	/// <exclude/>
	public partial class Brand_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : Brand
	{

		public Brand_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Brand_CrtBaseEventsProcess";
			SchemaUId = new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fddaa2c5-f6e7-4199-a5ea-8217948ce1bd");
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

	#region Class: Brand_CrtBaseEventsProcess

	/// <exclude/>
	public class Brand_CrtBaseEventsProcess : Brand_CrtBaseEventsProcess<Brand>
	{

		public Brand_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Brand_CrtBaseEventsProcess

	public partial class Brand_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BrandEventsProcess

	/// <exclude/>
	public class BrandEventsProcess : Brand_CrtBaseEventsProcess
	{

		public BrandEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

