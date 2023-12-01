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

	#region Class: SysMsgUserStateIconSchema

	/// <exclude/>
	public class SysMsgUserStateIconSchema : Terrasoft.Configuration.BaseImageLookupSchema
	{

		#region Constructors: Public

		public SysMsgUserStateIconSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMsgUserStateIconSchema(SysMsgUserStateIconSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMsgUserStateIconSchema(SysMsgUserStateIconSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("14169d59-d673-4d47-a481-2b98bec51aec");
			RealUId = new Guid("14169d59-d673-4d47-a481-2b98bec51aec");
			Name = "SysMsgUserStateIcon";
			ParentSchemaUId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cc180df9-46d6-42d1-9563-e9510396b77b");
			IsDBView = false;
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
			return new SysMsgUserStateIcon(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMsgUserStateIcon_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMsgUserStateIconSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMsgUserStateIconSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14169d59-d673-4d47-a481-2b98bec51aec"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateIcon

	/// <summary>
	/// User status icon while messaging.
	/// </summary>
	public class SysMsgUserStateIcon : Terrasoft.Configuration.BaseImageLookup
	{

		#region Constructors: Public

		public SysMsgUserStateIcon(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMsgUserStateIcon";
		}

		public SysMsgUserStateIcon(SysMsgUserStateIcon source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMsgUserStateIcon_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysMsgUserStateIconDeleted", e);
			Validating += (s, e) => ThrowEvent("SysMsgUserStateIconValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMsgUserStateIcon(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMsgUserStateIcon_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysMsgUserStateIcon_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseImageLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysMsgUserStateIcon
	{

		public SysMsgUserStateIcon_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMsgUserStateIcon_CrtBaseEventsProcess";
			SchemaUId = new Guid("14169d59-d673-4d47-a481-2b98bec51aec");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("14169d59-d673-4d47-a481-2b98bec51aec");
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

	#region Class: SysMsgUserStateIcon_CrtBaseEventsProcess

	/// <exclude/>
	public class SysMsgUserStateIcon_CrtBaseEventsProcess : SysMsgUserStateIcon_CrtBaseEventsProcess<SysMsgUserStateIcon>
	{

		public SysMsgUserStateIcon_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMsgUserStateIcon_CrtBaseEventsProcess

	public partial class SysMsgUserStateIcon_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysMsgUserStateIconEventsProcess

	/// <exclude/>
	public class SysMsgUserStateIconEventsProcess : SysMsgUserStateIcon_CrtBaseEventsProcess
	{

		public SysMsgUserStateIconEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

