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

	#region Class: MailBoxTypeSchema

	/// <exclude/>
	public class MailBoxTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MailBoxTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailBoxTypeSchema(MailBoxTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailBoxTypeSchema(MailBoxTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9b1d778-a1d2-4d8b-890a-8e9ab069c9ae");
			RealUId = new Guid("a9b1d778-a1d2-4d8b-890a-8e9ab069c9ae");
			Name = "MailBoxType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
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
			return new MailBoxType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailBoxType_CrtSLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailBoxTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailBoxTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9b1d778-a1d2-4d8b-890a-8e9ab069c9ae"));
		}

		#endregion

	}

	#endregion

	#region Class: MailBoxType

	/// <summary>
	/// Mailbox type.
	/// </summary>
	public class MailBoxType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MailBoxType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailBoxType";
		}

		public MailBoxType(MailBoxType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailBoxType_CrtSLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailBoxTypeDeleted", e);
			Deleting += (s, e) => ThrowEvent("MailBoxTypeDeleting", e);
			Inserted += (s, e) => ThrowEvent("MailBoxTypeInserted", e);
			Inserting += (s, e) => ThrowEvent("MailBoxTypeInserting", e);
			Saved += (s, e) => ThrowEvent("MailBoxTypeSaved", e);
			Saving += (s, e) => ThrowEvent("MailBoxTypeSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailBoxType(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailBoxType_CrtSLMEventsProcess

	/// <exclude/>
	public partial class MailBoxType_CrtSLMEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : MailBoxType
	{

		public MailBoxType_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailBoxType_CrtSLMEventsProcess";
			SchemaUId = new Guid("a9b1d778-a1d2-4d8b-890a-8e9ab069c9ae");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a9b1d778-a1d2-4d8b-890a-8e9ab069c9ae");
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

	#region Class: MailBoxType_CrtSLMEventsProcess

	/// <exclude/>
	public class MailBoxType_CrtSLMEventsProcess : MailBoxType_CrtSLMEventsProcess<MailBoxType>
	{

		public MailBoxType_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailBoxType_CrtSLMEventsProcess

	public partial class MailBoxType_CrtSLMEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MailBoxTypeEventsProcess

	/// <exclude/>
	public class MailBoxTypeEventsProcess : MailBoxType_CrtSLMEventsProcess
	{

		public MailBoxTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

