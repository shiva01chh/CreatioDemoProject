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

	#region Class: IntegrationSystemSchema

	/// <exclude/>
	public class IntegrationSystemSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public IntegrationSystemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public IntegrationSystemSchema(IntegrationSystemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public IntegrationSystemSchema(IntegrationSystemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
			RealUId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
			Name = "IntegrationSystem";
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
			column.ModifiedInSchemaUId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
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
			return new IntegrationSystem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new IntegrationSystem_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new IntegrationSystemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new IntegrationSystemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f"));
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationSystem

	/// <summary>
	/// Integration system.
	/// </summary>
	public class IntegrationSystem : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public IntegrationSystem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "IntegrationSystem";
		}

		public IntegrationSystem(IntegrationSystem source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new IntegrationSystem_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("IntegrationSystemDeleted", e);
			Inserting += (s, e) => ThrowEvent("IntegrationSystemInserting", e);
			Validating += (s, e) => ThrowEvent("IntegrationSystemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new IntegrationSystem(this);
		}

		#endregion

	}

	#endregion

	#region Class: IntegrationSystem_CrtBaseEventsProcess

	/// <exclude/>
	public partial class IntegrationSystem_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : IntegrationSystem
	{

		public IntegrationSystem_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "IntegrationSystem_CrtBaseEventsProcess";
			SchemaUId = new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("673fd68f-fe84-465a-a2d3-ff7bd824b22f");
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

	#region Class: IntegrationSystem_CrtBaseEventsProcess

	/// <exclude/>
	public class IntegrationSystem_CrtBaseEventsProcess : IntegrationSystem_CrtBaseEventsProcess<IntegrationSystem>
	{

		public IntegrationSystem_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: IntegrationSystem_CrtBaseEventsProcess

	public partial class IntegrationSystem_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: IntegrationSystemEventsProcess

	/// <exclude/>
	public class IntegrationSystemEventsProcess : IntegrationSystem_CrtBaseEventsProcess
	{

		public IntegrationSystemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

