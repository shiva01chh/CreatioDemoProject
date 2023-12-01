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

	#region Class: VwSystemUsersSchema

	/// <exclude/>
	public class VwSystemUsersSchema : Terrasoft.Configuration.VwSystemUsers_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public VwSystemUsersSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSystemUsersSchema(VwSystemUsersSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSystemUsersSchema(VwSystemUsersSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("4eca11f0-1408-49b0-b4bc-206d5b6acdf1");
			Name = "VwSystemUsers";
			ParentSchemaUId = new Guid("333b1380-a40f-4972-9650-f3a51ead1a45");
			ExtendParent = true;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = true;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSystemUsers(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwSystemUsers_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwSystemUsersSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSystemUsersSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4eca11f0-1408-49b0-b4bc-206d5b6acdf1"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSystemUsers

	/// <summary>
	/// System users (view).
	/// </summary>
	public class VwSystemUsers : Terrasoft.Configuration.VwSystemUsers_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public VwSystemUsers(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSystemUsers";
		}

		public VwSystemUsers(VwSystemUsers source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSystemUsers_PRMOrderEventsProcess(UserConnection);
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
			return new VwSystemUsers(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSystemUsers_PRMOrderEventsProcess

	/// <exclude/>
	public partial class VwSystemUsers_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.VwSystemUsers_CrtBaseEventsProcess<TEntity> where TEntity : VwSystemUsers
	{

		public VwSystemUsers_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSystemUsers_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4eca11f0-1408-49b0-b4bc-206d5b6acdf1");
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

	#region Class: VwSystemUsers_PRMOrderEventsProcess

	/// <exclude/>
	public class VwSystemUsers_PRMOrderEventsProcess : VwSystemUsers_PRMOrderEventsProcess<VwSystemUsers>
	{

		public VwSystemUsers_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSystemUsers_PRMOrderEventsProcess

	public partial class VwSystemUsers_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: VwSystemUsersEventsProcess

	/// <exclude/>
	public class VwSystemUsersEventsProcess : VwSystemUsers_PRMOrderEventsProcess
	{

		public VwSystemUsersEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

