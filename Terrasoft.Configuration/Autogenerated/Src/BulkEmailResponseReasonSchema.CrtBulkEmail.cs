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

	#region Class: BulkEmailResponseReasonSchema

	/// <exclude/>
	public class BulkEmailResponseReasonSchema : Terrasoft.Configuration.LookupSchema
	{

		#region Constructors: Public

		public BulkEmailResponseReasonSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailResponseReasonSchema(BulkEmailResponseReasonSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailResponseReasonSchema(BulkEmailResponseReasonSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640");
			RealUId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640");
			Name = "BulkEmailResponseReason";
			ParentSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5a0b3f9a-9009-5104-9927-1d4fece7345d")) == null) {
				Columns.Add(CreateCountToSetIsNonActualEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCountToSetIsNonActualEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5a0b3f9a-9009-5104-9927-1d4fece7345d"),
				Name = @"CountToSetIsNonActualEmail",
				CreatedInSchemaUId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640"),
				ModifiedInSchemaUId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailResponseReason(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailResponseReason_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailResponseReasonSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailResponseReasonSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88d071ae-5126-4004-aa4e-c2b9af022640"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailResponseReason

	/// <summary>
	/// Reasons for setting the isNonActualEmail flag.
	/// </summary>
	public class BulkEmailResponseReason : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public BulkEmailResponseReason(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailResponseReason";
		}

		public BulkEmailResponseReason(BulkEmailResponseReason source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number of retries to set IsNonActualEmail.
		/// </summary>
		public int CountToSetIsNonActualEmail {
			get {
				return GetTypedColumnValue<int>("CountToSetIsNonActualEmail");
			}
			set {
				SetColumnValue("CountToSetIsNonActualEmail", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailResponseReason_CrtBulkEmailEventsProcess(UserConnection);
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
			return new BulkEmailResponseReason(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailResponseReason_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailResponseReason_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.Lookup_CrtBaseEventsProcess<TEntity> where TEntity : BulkEmailResponseReason
	{

		public BulkEmailResponseReason_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailResponseReason_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("88d071ae-5126-4004-aa4e-c2b9af022640");
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

	#region Class: BulkEmailResponseReason_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailResponseReason_CrtBulkEmailEventsProcess : BulkEmailResponseReason_CrtBulkEmailEventsProcess<BulkEmailResponseReason>
	{

		public BulkEmailResponseReason_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailResponseReason_CrtBulkEmailEventsProcess

	public partial class BulkEmailResponseReason_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailResponseReasonEventsProcess

	/// <exclude/>
	public class BulkEmailResponseReasonEventsProcess : BulkEmailResponseReason_CrtBulkEmailEventsProcess
	{

		public BulkEmailResponseReasonEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

