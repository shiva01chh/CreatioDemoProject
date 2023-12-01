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

	#region Class: PortalMessageTypeSchema

	/// <exclude/>
	public class PortalMessageTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public PortalMessageTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalMessageTypeSchema(PortalMessageTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalMessageTypeSchema(PortalMessageTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c");
			RealUId = new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c");
			Name = "PortalMessageType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("761cfd91-bc98-408a-bd46-c0d06c3eba85");
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
			return new PortalMessageType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PortalMessageType_PortalMessageEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PortalMessageTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalMessageTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessageType

	/// <summary>
	/// Portal message type.
	/// </summary>
	public class PortalMessageType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public PortalMessageType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalMessageType";
		}

		public PortalMessageType(PortalMessageType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalMessageType_PortalMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PortalMessageTypeDeleted", e);
			Validating += (s, e) => ThrowEvent("PortalMessageTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalMessageType(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessageType_PortalMessageEventsProcess

	/// <exclude/>
	public partial class PortalMessageType_PortalMessageEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : PortalMessageType
	{

		public PortalMessageType_PortalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalMessageType_PortalMessageEventsProcess";
			SchemaUId = new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c");
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

	#region Class: PortalMessageType_PortalMessageEventsProcess

	/// <exclude/>
	public class PortalMessageType_PortalMessageEventsProcess : PortalMessageType_PortalMessageEventsProcess<PortalMessageType>
	{

		public PortalMessageType_PortalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalMessageType_PortalMessageEventsProcess

	public partial class PortalMessageType_PortalMessageEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PortalMessageTypeEventsProcess

	/// <exclude/>
	public class PortalMessageTypeEventsProcess : PortalMessageType_PortalMessageEventsProcess
	{

		public PortalMessageTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

