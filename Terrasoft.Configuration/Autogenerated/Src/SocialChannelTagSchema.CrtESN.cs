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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: SocialChannelTagSchema

	/// <exclude/>
	public class SocialChannelTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public SocialChannelTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialChannelTagSchema(SocialChannelTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialChannelTagSchema(SocialChannelTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9b2ff8c-09f7-4577-a961-ac4b87c1ea19");
			RealUId = new Guid("a9b2ff8c-09f7-4577-a961-ac4b87c1ea19");
			Name = "SocialChannelTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("323cd82b-b42c-461b-a2e0-e7cefd565455");
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
			return new SocialChannelTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialChannelTag_CrtESNEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialChannelTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialChannelTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9b2ff8c-09f7-4577-a961-ac4b87c1ea19"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialChannelTag

	/// <summary>
	/// Feed section tag.
	/// </summary>
	public class SocialChannelTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public SocialChannelTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialChannelTag";
		}

		public SocialChannelTag(SocialChannelTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialChannelTag_CrtESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialChannelTagDeleted", e);
			Validating += (s, e) => ThrowEvent("SocialChannelTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialChannelTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialChannelTag_CrtESNEventsProcess

	/// <exclude/>
	public partial class SocialChannelTag_CrtESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : SocialChannelTag
	{

		public SocialChannelTag_CrtESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialChannelTag_CrtESNEventsProcess";
			SchemaUId = new Guid("a9b2ff8c-09f7-4577-a961-ac4b87c1ea19");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a9b2ff8c-09f7-4577-a961-ac4b87c1ea19");
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

	#region Class: SocialChannelTag_CrtESNEventsProcess

	/// <exclude/>
	public class SocialChannelTag_CrtESNEventsProcess : SocialChannelTag_CrtESNEventsProcess<SocialChannelTag>
	{

		public SocialChannelTag_CrtESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialChannelTag_CrtESNEventsProcess

	public partial class SocialChannelTag_CrtESNEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SocialChannelTagEventsProcess

	/// <exclude/>
	public class SocialChannelTagEventsProcess : SocialChannelTag_CrtESNEventsProcess
	{

		public SocialChannelTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

