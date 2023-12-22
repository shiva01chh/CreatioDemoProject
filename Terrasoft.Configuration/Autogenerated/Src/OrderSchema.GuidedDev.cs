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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Passport;
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

	#region Class: OrderSchema

	/// <exclude/>
	public class OrderSchema : Terrasoft.Configuration.Order_PRMOrder_TerrasoftSchema
	{

		#region Constructors: Public

		public OrderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OrderSchema(OrderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OrderSchema(OrderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c2482014-f01a-41a0-aee4-88fa7d22a140");
			Name = "Order";
			ParentSchemaUId = new Guid("80294582-06b5-4faa-a85f-3323e5536b71");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d0a4b864-933f-47ac-851c-5106b3ed815e")) == null) {
				Columns.Add(CreateUsrCommentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d0a4b864-933f-47ac-851c-5106b3ed815e"),
				Name = @"UsrComment",
				CreatedInSchemaUId = new Guid("c2482014-f01a-41a0-aee4-88fa7d22a140"),
				ModifiedInSchemaUId = new Guid("c2482014-f01a-41a0-aee4-88fa7d22a140"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Order(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Order_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OrderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OrderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2482014-f01a-41a0-aee4-88fa7d22a140"));
		}

		#endregion

	}

	#endregion

	#region Class: Order

	/// <summary>
	/// Order.
	/// </summary>
	public class Order : Terrasoft.Configuration.Order_PRMOrder_Terrasoft
	{

		#region Constructors: Public

		public Order(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Order";
		}

		public Order(Order source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Comment.
		/// </summary>
		public string UsrComment {
			get {
				return GetTypedColumnValue<string>("UsrComment");
			}
			set {
				SetColumnValue("UsrComment", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Order_GuidedDevEventsProcess(UserConnection);
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
			return new Order(this);
		}

		#endregion

	}

	#endregion

	#region Class: Order_GuidedDevEventsProcess

	/// <exclude/>
	public partial class Order_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.Order_PRMOrderEventsProcess<TEntity> where TEntity : Order
	{

		public Order_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Order_GuidedDevEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2482014-f01a-41a0-aee4-88fa7d22a140");
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

	#region Class: Order_GuidedDevEventsProcess

	/// <exclude/>
	public class Order_GuidedDevEventsProcess : Order_GuidedDevEventsProcess<Order>
	{

		public Order_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Order_GuidedDevEventsProcess

	public partial class Order_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: OrderEventsProcess

	/// <exclude/>
	public class OrderEventsProcess : Order_GuidedDevEventsProcess
	{

		public OrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

