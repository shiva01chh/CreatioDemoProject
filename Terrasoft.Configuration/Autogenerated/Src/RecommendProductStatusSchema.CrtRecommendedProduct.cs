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

	#region Class: RecommendProductStatusSchema

	/// <exclude/>
	public class RecommendProductStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public RecommendProductStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RecommendProductStatusSchema(RecommendProductStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RecommendProductStatusSchema(RecommendProductStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51c10720-9723-446f-b9da-c6b2278536f0");
			RealUId = new Guid("51c10720-9723-446f-b9da-c6b2278536f0");
			Name = "RecommendProductStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("71f4d1a5-c473-436e-a8c5-51ffc5f2dc8e");
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
			return new RecommendProductStatus(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RecommendProductStatus_CrtRecommendedProductEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RecommendProductStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RecommendProductStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51c10720-9723-446f-b9da-c6b2278536f0"));
		}

		#endregion

	}

	#endregion

	#region Class: RecommendProductStatus

	/// <summary>
	/// Recommended product status.
	/// </summary>
	public class RecommendProductStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public RecommendProductStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RecommendProductStatus";
		}

		public RecommendProductStatus(RecommendProductStatus source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RecommendProductStatus_CrtRecommendedProductEventsProcess(UserConnection);
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
			return new RecommendProductStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: RecommendProductStatus_CrtRecommendedProductEventsProcess

	/// <exclude/>
	public partial class RecommendProductStatus_CrtRecommendedProductEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : RecommendProductStatus
	{

		public RecommendProductStatus_CrtRecommendedProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RecommendProductStatus_CrtRecommendedProductEventsProcess";
			SchemaUId = new Guid("51c10720-9723-446f-b9da-c6b2278536f0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("51c10720-9723-446f-b9da-c6b2278536f0");
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

	#region Class: RecommendProductStatus_CrtRecommendedProductEventsProcess

	/// <exclude/>
	public class RecommendProductStatus_CrtRecommendedProductEventsProcess : RecommendProductStatus_CrtRecommendedProductEventsProcess<RecommendProductStatus>
	{

		public RecommendProductStatus_CrtRecommendedProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RecommendProductStatus_CrtRecommendedProductEventsProcess

	public partial class RecommendProductStatus_CrtRecommendedProductEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RecommendProductStatusEventsProcess

	/// <exclude/>
	public class RecommendProductStatusEventsProcess : RecommendProductStatus_CrtRecommendedProductEventsProcess
	{

		public RecommendProductStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

