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

	#region Class: DuplicatesRuleInTagSchema

	/// <exclude/>
	public class DuplicatesRuleInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public DuplicatesRuleInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DuplicatesRuleInTagSchema(DuplicatesRuleInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DuplicatesRuleInTagSchema(DuplicatesRuleInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
			RealUId = new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
			Name = "DuplicatesRuleInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cddb02cf-8a8b-4af9-b5f2-4f81a4f916c1");
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
			column.ReferenceSchemaUId = new Guid("655501e6-0dd8-48a2-91ad-1d67671dfc00");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("f9838ef2-f0f9-448c-b968-e36103b33919");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityName";
			column.ModifiedInSchemaUId = new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DuplicatesRuleInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DuplicatesRuleInTag_CrtDeduplicationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DuplicatesRuleInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DuplicatesRuleInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859"));
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRuleInTag

	/// <summary>
	/// "Duplicates rule" in tag.
	/// </summary>
	public class DuplicatesRuleInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public DuplicatesRuleInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DuplicatesRuleInTag";
		}

		public DuplicatesRuleInTag(DuplicatesRuleInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DuplicatesRuleInTag_CrtDeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DuplicatesRuleInTagDeleted", e);
			Validating += (s, e) => ThrowEvent("DuplicatesRuleInTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DuplicatesRuleInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesRuleInTag_CrtDeduplicationEventsProcess

	/// <exclude/>
	public partial class DuplicatesRuleInTag_CrtDeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtBaseEventsProcess<TEntity> where TEntity : DuplicatesRuleInTag
	{

		public DuplicatesRuleInTag_CrtDeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DuplicatesRuleInTag_CrtDeduplicationEventsProcess";
			SchemaUId = new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4da3a6b0-60f6-48c5-90d2-53f30089a859");
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

	#region Class: DuplicatesRuleInTag_CrtDeduplicationEventsProcess

	/// <exclude/>
	public class DuplicatesRuleInTag_CrtDeduplicationEventsProcess : DuplicatesRuleInTag_CrtDeduplicationEventsProcess<DuplicatesRuleInTag>
	{

		public DuplicatesRuleInTag_CrtDeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DuplicatesRuleInTag_CrtDeduplicationEventsProcess

	public partial class DuplicatesRuleInTag_CrtDeduplicationEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DuplicatesRuleInTagEventsProcess

	/// <exclude/>
	public class DuplicatesRuleInTagEventsProcess : DuplicatesRuleInTag_CrtDeduplicationEventsProcess
	{

		public DuplicatesRuleInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

