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

	#region Class: AccountBillingInfoSchema

	/// <exclude/>
	public class AccountBillingInfoSchema : Terrasoft.Configuration.AccountBillingInfo_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountBillingInfoSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountBillingInfoSchema(AccountBillingInfoSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("93153f13-9302-4f77-8038-eb2a8a00f5f0");
			Name = "AccountBillingInfo";
			ParentSchemaUId = new Guid("4f0e44ce-343c-45b6-ae14-ff0533d4add9");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4cca8abe-7999-40c8-9746-0eb1d0302ebc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new AccountBillingInfo(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountBillingInfo_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountBillingInfoSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountBillingInfoSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93153f13-9302-4f77-8038-eb2a8a00f5f0"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo

	/// <summary>
	/// Banking details.
	/// </summary>
	public class AccountBillingInfo : Terrasoft.Configuration.AccountBillingInfo_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountBillingInfo(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountBillingInfo";
		}

		public AccountBillingInfo(AccountBillingInfo source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountBillingInfo_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new AccountBillingInfo(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountBillingInfo_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class AccountBillingInfo_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.AccountBillingInfo_CrtBaseEventsProcess<TEntity> where TEntity : AccountBillingInfo
	{

		public AccountBillingInfo_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountBillingInfo_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93153f13-9302-4f77-8038-eb2a8a00f5f0");
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

	#region Class: AccountBillingInfo_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class AccountBillingInfo_CrtCustomer360AppEventsProcess : AccountBillingInfo_CrtCustomer360AppEventsProcess<AccountBillingInfo>
	{

		public AccountBillingInfo_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountBillingInfo_CrtCustomer360AppEventsProcess

	public partial class AccountBillingInfo_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountBillingInfoEventsProcess

	/// <exclude/>
	public class AccountBillingInfoEventsProcess : AccountBillingInfo_CrtCustomer360AppEventsProcess
	{

		public AccountBillingInfoEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

