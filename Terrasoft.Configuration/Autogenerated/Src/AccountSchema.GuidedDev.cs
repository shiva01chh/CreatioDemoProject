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

	#region Class: AccountSchema

	/// <exclude/>
	public class AccountSchema : Terrasoft.Configuration.Account_CrtMLLeadConversion_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountSchema(AccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountSchema(AccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e5388aa4-01f6-46a7-8a2d-51b7e65f8b75");
			Name = "Account";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("29083ec1-9a95-efbf-4e70-d19f7812a6e9")) == null) {
				Columns.Add(CreateUsrWebsiteCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUsrWebsiteCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("29083ec1-9a95-efbf-4e70-d19f7812a6e9"),
				Name = @"UsrWebsiteCode",
				CreatedInSchemaUId = new Guid("e5388aa4-01f6-46a7-8a2d-51b7e65f8b75"),
				ModifiedInSchemaUId = new Guid("e5388aa4-01f6-46a7-8a2d-51b7e65f8b75"),
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
			return new Account(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5388aa4-01f6-46a7-8a2d-51b7e65f8b75"));
		}

		#endregion

	}

	#endregion

	#region Class: Account

	/// <summary>
	/// Account.
	/// </summary>
	public class Account : Terrasoft.Configuration.Account_CrtMLLeadConversion_Terrasoft
	{

		#region Constructors: Public

		public Account(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account";
		}

		public Account(Account source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Websiite code.
		/// </summary>
		public int UsrWebsiteCode {
			get {
				return GetTypedColumnValue<int>("UsrWebsiteCode");
			}
			set {
				SetColumnValue("UsrWebsiteCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_GuidedDevEventsProcess(UserConnection);
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
			return new Account(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_GuidedDevEventsProcess

	/// <exclude/>
	public partial class Account_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtMLLeadConversionEventsProcess<TEntity> where TEntity : Account
	{

		public Account_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_GuidedDevEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e5388aa4-01f6-46a7-8a2d-51b7e65f8b75");
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

	#region Class: Account_GuidedDevEventsProcess

	/// <exclude/>
	public class Account_GuidedDevEventsProcess : Account_GuidedDevEventsProcess<Account>
	{

		public Account_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_GuidedDevEventsProcess

	public partial class Account_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountEventsProcess

	/// <exclude/>
	public class AccountEventsProcess : Account_GuidedDevEventsProcess
	{

		public AccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

