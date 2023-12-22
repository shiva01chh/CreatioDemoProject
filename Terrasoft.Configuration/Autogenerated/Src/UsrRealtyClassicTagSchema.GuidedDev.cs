namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrRealtyClassicTagSchema

	/// <exclude/>
	public class UsrRealtyClassicTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicTagSchema(UsrRealtyClassicTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicTagSchema(UsrRealtyClassicTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2720abef-9239-47bc-8135-90af4076dbae");
			RealUId = new Guid("2720abef-9239-47bc-8135-90af4076dbae");
			Name = "UsrRealtyClassicTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
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
			return new UsrRealtyClassicTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassicTag_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2720abef-9239-47bc-8135-90af4076dbae"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicTag

	/// <summary>
	/// Realty (Classic UI) section tag.
	/// </summary>
	public class UsrRealtyClassicTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public UsrRealtyClassicTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicTag";
		}

		public UsrRealtyClassicTag(UsrRealtyClassicTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyClassicTag_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassicTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicTag_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassicTag_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : UsrRealtyClassicTag
	{

		public UsrRealtyClassicTag_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassicTag_GuidedDevEventsProcess";
			SchemaUId = new Guid("2720abef-9239-47bc-8135-90af4076dbae");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2720abef-9239-47bc-8135-90af4076dbae");
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

	#region Class: UsrRealtyClassicTag_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicTag_GuidedDevEventsProcess : UsrRealtyClassicTag_GuidedDevEventsProcess<UsrRealtyClassicTag>
	{

		public UsrRealtyClassicTag_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassicTag_GuidedDevEventsProcess

	public partial class UsrRealtyClassicTag_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicTagEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicTagEventsProcess : UsrRealtyClassicTag_GuidedDevEventsProcess
	{

		public UsrRealtyClassicTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

