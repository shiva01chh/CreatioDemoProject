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

	#region Class: BulkEmailResponseDetailsSchema

	/// <exclude/>
	public class BulkEmailResponseDetailsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailResponseDetailsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailResponseDetailsSchema(BulkEmailResponseDetailsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailResponseDetailsSchema(BulkEmailResponseDetailsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6");
			RealUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6");
			Name = "BulkEmailResponseDetails";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateDetailsColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8eb110ca-dcb9-0dcb-9d78-b2a9a82206f8")) == null) {
				Columns.Add(CreateReasonColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3df81df4-afc8-34c4-b1ba-33ba3e34835c"),
				Name = @"Details",
				CreatedInSchemaUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6"),
				ModifiedInSchemaUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				IsMultiLineText = true,
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8eb110ca-dcb9-0dcb-9d78-b2a9a82206f8"),
				Name = @"Reason",
				ReferenceSchemaUId = new Guid("88d071ae-5126-4004-aa4e-c2b9af022640"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6"),
				ModifiedInSchemaUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6"),
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
			return new BulkEmailResponseDetails(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmailResponseDetails_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailResponseDetailsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailResponseDetailsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailResponseDetails

	/// <summary>
	/// Bulk email response details.
	/// </summary>
	public class BulkEmailResponseDetails : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailResponseDetails(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailResponseDetails";
		}

		public BulkEmailResponseDetails(BulkEmailResponseDetails source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Details.
		/// </summary>
		public string Details {
			get {
				return GetTypedColumnValue<string>("Details");
			}
			set {
				SetColumnValue("Details", value);
			}
		}

		/// <exclude/>
		public Guid ReasonId {
			get {
				return GetTypedColumnValue<Guid>("ReasonId");
			}
			set {
				SetColumnValue("ReasonId", value);
				_reason = null;
			}
		}

		/// <exclude/>
		public string ReasonName {
			get {
				return GetTypedColumnValue<string>("ReasonName");
			}
			set {
				SetColumnValue("ReasonName", value);
				if (_reason != null) {
					_reason.Name = value;
				}
			}
		}

		private BulkEmailResponseReason _reason;
		/// <summary>
		/// Reason.
		/// </summary>
		public BulkEmailResponseReason Reason {
			get {
				return _reason ??
					(_reason = LookupColumnEntities.GetEntity("Reason") as BulkEmailResponseReason);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailResponseDetails_CrtBulkEmailEventsProcess(UserConnection);
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
			return new BulkEmailResponseDetails(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailResponseDetails_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BulkEmailResponseDetails_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailResponseDetails
	{

		public BulkEmailResponseDetails_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailResponseDetails_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6d344486-2829-43f9-9f2a-58971b80b8d6");
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

	#region Class: BulkEmailResponseDetails_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailResponseDetails_CrtBulkEmailEventsProcess : BulkEmailResponseDetails_CrtBulkEmailEventsProcess<BulkEmailResponseDetails>
	{

		public BulkEmailResponseDetails_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailResponseDetails_CrtBulkEmailEventsProcess

	public partial class BulkEmailResponseDetails_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BulkEmailResponseDetailsEventsProcess

	/// <exclude/>
	public class BulkEmailResponseDetailsEventsProcess : BulkEmailResponseDetails_CrtBulkEmailEventsProcess
	{

		public BulkEmailResponseDetailsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

