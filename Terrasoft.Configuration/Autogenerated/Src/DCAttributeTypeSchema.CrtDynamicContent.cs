namespace Terrasoft.Configuration
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

	#region Class: DCAttributeTypeSchema

	/// <exclude/>
	public class DCAttributeTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DCAttributeTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DCAttributeTypeSchema(DCAttributeTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DCAttributeTypeSchema(DCAttributeTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a91af0f-7bb9-4ea5-b999-d317ff6bf247");
			RealUId = new Guid("1a91af0f-7bb9-4ea5-b999-d317ff6bf247");
			Name = "DCAttributeType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9f77887e-50a7-49c4-86e4-3ef2d36a21a8");
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
			return new DCAttributeType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DCAttributeType_CrtDynamicContentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DCAttributeTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DCAttributeTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a91af0f-7bb9-4ea5-b999-d317ff6bf247"));
		}

		#endregion

	}

	#endregion

	#region Class: DCAttributeType

	/// <summary>
	/// DCAttributeType.
	/// </summary>
	public class DCAttributeType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DCAttributeType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DCAttributeType";
		}

		public DCAttributeType(DCAttributeType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DCAttributeType_CrtDynamicContentEventsProcess(UserConnection);
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
			return new DCAttributeType(this);
		}

		#endregion

	}

	#endregion

	#region Class: DCAttributeType_CrtDynamicContentEventsProcess

	/// <exclude/>
	public partial class DCAttributeType_CrtDynamicContentEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : DCAttributeType
	{

		public DCAttributeType_CrtDynamicContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DCAttributeType_CrtDynamicContentEventsProcess";
			SchemaUId = new Guid("1a91af0f-7bb9-4ea5-b999-d317ff6bf247");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1a91af0f-7bb9-4ea5-b999-d317ff6bf247");
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

	#region Class: DCAttributeType_CrtDynamicContentEventsProcess

	/// <exclude/>
	public class DCAttributeType_CrtDynamicContentEventsProcess : DCAttributeType_CrtDynamicContentEventsProcess<DCAttributeType>
	{

		public DCAttributeType_CrtDynamicContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DCAttributeType_CrtDynamicContentEventsProcess

	public partial class DCAttributeType_CrtDynamicContentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DCAttributeTypeEventsProcess

	/// <exclude/>
	public class DCAttributeTypeEventsProcess : DCAttributeType_CrtDynamicContentEventsProcess
	{

		public DCAttributeTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

