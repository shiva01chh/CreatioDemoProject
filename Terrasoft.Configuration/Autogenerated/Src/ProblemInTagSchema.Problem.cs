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

	#region Class: ProblemInTagSchema

	/// <exclude/>
	public class ProblemInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public ProblemInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProblemInTagSchema(ProblemInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProblemInTagSchema(ProblemInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
			RealUId = new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
			Name = "ProblemInTag";
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
			column.ReferenceSchemaUId = new Guid("3d1d8536-1620-46b0-b6b9-c663c78a5184");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityNumber";
			column.ModifiedInSchemaUId = new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProblemInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProblemInTag_ProblemEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProblemInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProblemInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf"));
		}

		#endregion

	}

	#endregion

	#region Class: ProblemInTag

	/// <summary>
	/// Problems section record tag.
	/// </summary>
	public class ProblemInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public ProblemInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProblemInTag";
		}

		public ProblemInTag(ProblemInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProblemInTag_ProblemEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProblemInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProblemInTag_ProblemEventsProcess

	/// <exclude/>
	public partial class ProblemInTag_ProblemEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtBaseEventsProcess<TEntity> where TEntity : ProblemInTag
	{

		public ProblemInTag_ProblemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProblemInTag_ProblemEventsProcess";
			SchemaUId = new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("86ce1cc5-4cc6-41b4-9fa1-2a717962adcf");
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

	#region Class: ProblemInTag_ProblemEventsProcess

	/// <exclude/>
	public class ProblemInTag_ProblemEventsProcess : ProblemInTag_ProblemEventsProcess<ProblemInTag>
	{

		public ProblemInTag_ProblemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProblemInTag_ProblemEventsProcess

	public partial class ProblemInTag_ProblemEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: ProblemInTagEventsProcess

	/// <exclude/>
	public class ProblemInTagEventsProcess : ProblemInTag_ProblemEventsProcess
	{

		public ProblemInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

