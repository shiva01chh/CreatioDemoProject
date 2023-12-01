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

	#region Class: AccountCategorySchema

	/// <exclude/>
	public class AccountCategorySchema : Terrasoft.Configuration.AccountCategory_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountCategorySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountCategorySchema(AccountCategorySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountCategorySchema(AccountCategorySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("94da7497-06f6-4b20-9553-2f00c72ca983");
			Name = "AccountCategory";
			ParentSchemaUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665");
			ExtendParent = true;
			CreatedInPackageId = new Guid("fc4aecd3-2015-46dd-9cce-abee4c701856");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColorColumn() {
			base.InitializePrimaryColorColumn();
			PrimaryColorColumn = CreateColorColumn();
			if (Columns.FindByUId(PrimaryColorColumn.UId) == null) {
				Columns.Add(PrimaryColorColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("a3f1ee04-bd5b-dd93-9f49-95c394bff4b9"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("94da7497-06f6-4b20-9553-2f00c72ca983"),
				ModifiedInSchemaUId = new Guid("94da7497-06f6-4b20-9553-2f00c72ca983"),
				CreatedInPackageId = new Guid("fc4aecd3-2015-46dd-9cce-abee4c701856")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AccountCategory(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountCategory_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountCategorySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountCategorySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94da7497-06f6-4b20-9553-2f00c72ca983"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory

	/// <summary>
	/// Category of Account.
	/// </summary>
	public class AccountCategory : Terrasoft.Configuration.AccountCategory_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AccountCategory(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountCategory";
		}

		public AccountCategory(AccountCategory source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountCategory_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new AccountCategory(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountCategory_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class AccountCategory_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.AccountCategory_CrtBaseEventsProcess<TEntity> where TEntity : AccountCategory
	{

		public AccountCategory_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountCategory_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("94da7497-06f6-4b20-9553-2f00c72ca983");
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

	#region Class: AccountCategory_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class AccountCategory_CrtCustomer360AppEventsProcess : AccountCategory_CrtCustomer360AppEventsProcess<AccountCategory>
	{

		public AccountCategory_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountCategory_CrtCustomer360AppEventsProcess

	public partial class AccountCategory_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountCategoryEventsProcess

	/// <exclude/>
	public class AccountCategoryEventsProcess : AccountCategory_CrtCustomer360AppEventsProcess
	{

		public AccountCategoryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

