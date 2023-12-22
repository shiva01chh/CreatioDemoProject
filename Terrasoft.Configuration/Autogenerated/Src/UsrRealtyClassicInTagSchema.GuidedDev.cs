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

	#region Class: UsrRealtyClassicInTagSchema

	/// <exclude/>
	public class UsrRealtyClassicInTagSchema : Terrasoft.Configuration.BaseEntityInTagSchema
	{

		#region Constructors: Public

		public UsrRealtyClassicInTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyClassicInTagSchema(UsrRealtyClassicInTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyClassicInTagSchema(UsrRealtyClassicInTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
			RealUId = new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
			Name = "UsrRealtyClassicInTag";
			ParentSchemaUId = new Guid("5894a2b0-51d5-419a-82bb-238674634270");
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

		protected override EntitySchemaColumn CreateTagColumn() {
			EntitySchemaColumn column = base.CreateTagColumn();
			column.ReferenceSchemaUId = new Guid("2720abef-9239-47bc-8135-90af4076dbae");
			column.ColumnValueName = @"TagId";
			column.DisplayColumnValueName = @"TagName";
			column.ModifiedInSchemaUId = new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
			return column;
		}

		protected override EntitySchemaColumn CreateEntityColumn() {
			EntitySchemaColumn column = base.CreateEntityColumn();
			column.ReferenceSchemaUId = new Guid("de8f9179-235a-4c48-8601-cc1eae75b99b");
			column.ColumnValueName = @"EntityId";
			column.DisplayColumnValueName = @"EntityUsrName";
			column.ModifiedInSchemaUId = new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyClassicInTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyClassicInTag_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyClassicInTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyClassicInTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efdbcc70-76d6-4193-9a79-41af9661d442"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicInTag

	/// <summary>
	/// Realty (Classic UI) section record tag.
	/// </summary>
	public class UsrRealtyClassicInTag : Terrasoft.Configuration.BaseEntityInTag
	{

		#region Constructors: Public

		public UsrRealtyClassicInTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyClassicInTag";
		}

		public UsrRealtyClassicInTag(UsrRealtyClassicInTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyClassicInTag_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyClassicInTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyClassicInTag_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyClassicInTag_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityInTag_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyClassicInTag
	{

		public UsrRealtyClassicInTag_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyClassicInTag_GuidedDevEventsProcess";
			SchemaUId = new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("efdbcc70-76d6-4193-9a79-41af9661d442");
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

	#region Class: UsrRealtyClassicInTag_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicInTag_GuidedDevEventsProcess : UsrRealtyClassicInTag_GuidedDevEventsProcess<UsrRealtyClassicInTag>
	{

		public UsrRealtyClassicInTag_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyClassicInTag_GuidedDevEventsProcess

	public partial class UsrRealtyClassicInTag_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyClassicInTagEventsProcess

	/// <exclude/>
	public class UsrRealtyClassicInTagEventsProcess : UsrRealtyClassicInTag_GuidedDevEventsProcess
	{

		public UsrRealtyClassicInTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

