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

	#region Class: CaseInTagSchema

	/// <exclude/>
	public class CaseInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public CaseInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseInTagSchema(CaseInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseInTagSchema(CaseInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
			RealUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
			Name = "CaseInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("d074735f-8494-4e8b-ba88-a6b4d75e6d57");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityNumber";
			column.ModifiedInSchemaUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CaseInTag_CrtCaseManagmentObjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CaseInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseInTag

	/// <summary>
	/// Cases section record tag.
	/// </summary>
	public class CaseInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public CaseInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseInTag";
		}

		public CaseInTag(CaseInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseInTag_CrtCaseManagmentObjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CaseInTagDeleted", e);
			Validating += (s, e) => ThrowEvent("CaseInTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseInTag_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public partial class CaseInTag_CrtCaseManagmentObjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtBaseEventsProcess<TEntity> where TEntity : CaseInTag
	{

		public CaseInTag_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseInTag_CrtCaseManagmentObjectEventsProcess";
			SchemaUId = new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dc94bd2f-5505-48bc-8c67-4d2b7ea79be5");
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

	#region Class: CaseInTag_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public class CaseInTag_CrtCaseManagmentObjectEventsProcess : CaseInTag_CrtCaseManagmentObjectEventsProcess<CaseInTag>
	{

		public CaseInTag_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseInTag_CrtCaseManagmentObjectEventsProcess

	public partial class CaseInTag_CrtCaseManagmentObjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CaseInTagEventsProcess

	/// <exclude/>
	public class CaseInTagEventsProcess : CaseInTag_CrtCaseManagmentObjectEventsProcess
	{

		public CaseInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

