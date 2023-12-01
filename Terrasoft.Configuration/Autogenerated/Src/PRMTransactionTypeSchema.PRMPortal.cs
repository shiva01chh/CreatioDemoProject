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

	#region Class: PRMTransactionTypeSchema

	/// <exclude/>
	public class PRMTransactionTypeSchema : Terrasoft.Configuration.PRMTransactionType_PRMBase_TerrasoftSchema
	{

		#region Constructors: Public

		public PRMTransactionTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PRMTransactionTypeSchema(PRMTransactionTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PRMTransactionTypeSchema(PRMTransactionTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8ca17c55-cf11-4d35-854d-006bbb260ca2");
			Name = "PRMTransactionType";
			ParentSchemaUId = new Guid("49361e32-f6a5-4eb0-b0b2-7e13b1e2ed30");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0fffc5a3-cd85-4e12-bfdb-f47322f14e3d");
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
			return new PRMTransactionType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PRMTransactionType_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PRMTransactionTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PRMTransactionTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ca17c55-cf11-4d35-854d-006bbb260ca2"));
		}

		#endregion

	}

	#endregion

	#region Class: PRMTransactionType

	/// <summary>
	/// Type of transaction.
	/// </summary>
	public class PRMTransactionType : Terrasoft.Configuration.PRMTransactionType_PRMBase_Terrasoft
	{

		#region Constructors: Public

		public PRMTransactionType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PRMTransactionType";
		}

		public PRMTransactionType(PRMTransactionType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PRMTransactionType_PRMPortalEventsProcess(UserConnection);
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
			return new PRMTransactionType(this);
		}

		#endregion

	}

	#endregion

	#region Class: PRMTransactionType_PRMPortalEventsProcess

	/// <exclude/>
	public partial class PRMTransactionType_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.PRMTransactionType_PRMBaseEventsProcess<TEntity> where TEntity : PRMTransactionType
	{

		public PRMTransactionType_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PRMTransactionType_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ca17c55-cf11-4d35-854d-006bbb260ca2");
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

	#region Class: PRMTransactionType_PRMPortalEventsProcess

	/// <exclude/>
	public class PRMTransactionType_PRMPortalEventsProcess : PRMTransactionType_PRMPortalEventsProcess<PRMTransactionType>
	{

		public PRMTransactionType_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PRMTransactionType_PRMPortalEventsProcess

	public partial class PRMTransactionType_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PRMTransactionTypeEventsProcess

	/// <exclude/>
	public class PRMTransactionTypeEventsProcess : PRMTransactionType_PRMPortalEventsProcess
	{

		public PRMTransactionTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

