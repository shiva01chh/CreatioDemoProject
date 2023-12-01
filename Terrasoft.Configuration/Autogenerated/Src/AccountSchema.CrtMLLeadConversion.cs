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
	public class AccountSchema : Terrasoft.Configuration.Account_CrtCustomer360App_TerrasoftSchema
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

		#region Methods: Private

		private EntitySchemaIndex CreateIAccountAlternativeNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("ebe37f22-d03b-4ff5-85ab-b19cfd41de7b");
			index.Name = "IAccountAlternativeName";
			index.CreatedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b");
			index.ModifiedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b");
			index.CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			EntitySchemaIndexColumn alternativeNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("58081ad2-6e01-4b09-8a7f-d6e550fd4d71"),
				ColumnUId = new Guid("e36ae687-347d-4bf7-b260-90129862e357"),
				CreatedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b"),
				ModifiedInSchemaUId = new Guid("b9b0db9a-65de-4b97-aece-47ffe851884b"),
				CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(alternativeNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("02ea6590-09d5-47c0-9fd1-af8ff16cf814");
			Name = "Account";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("9025b0c2-d769-4cf8-b9b1-67afd440e08f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ce154785-3dc3-631a-b1a1-91f8c28300fd")) == null) {
				Columns.Add(CreateLeadConversionScoreColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadConversionScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ce154785-3dc3-631a-b1a1-91f8c28300fd"),
				Name = @"LeadConversionScore",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("02ea6590-09d5-47c0-9fd1-af8ff16cf814"),
				ModifiedInSchemaUId = new Guid("02ea6590-09d5-47c0-9fd1-af8ff16cf814"),
				CreatedInPackageId = new Guid("9025b0c2-d769-4cf8-b9b1-67afd440e08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIAccountAlternativeNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Account(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_CrtMLLeadConversionEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("02ea6590-09d5-47c0-9fd1-af8ff16cf814"));
		}

		#endregion

	}

	#endregion

	#region Class: Account

	/// <summary>
	/// Account.
	/// </summary>
	public class Account : Terrasoft.Configuration.Account_CrtCustomer360App_Terrasoft
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
		/// Lead conversion score.
		/// </summary>
		public int LeadConversionScore {
			get {
				return GetTypedColumnValue<int>("LeadConversionScore");
			}
			set {
				SetColumnValue("LeadConversionScore", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_CrtMLLeadConversionEventsProcess(UserConnection);
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

	#region Class: Account_CrtMLLeadConversionEventsProcess

	/// <exclude/>
	public partial class Account_CrtMLLeadConversionEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtCustomer360AppEventsProcess<TEntity> where TEntity : Account
	{

		public Account_CrtMLLeadConversionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_CrtMLLeadConversionEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("02ea6590-09d5-47c0-9fd1-af8ff16cf814");
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

	#region Class: Account_CrtMLLeadConversionEventsProcess

	/// <exclude/>
	public class Account_CrtMLLeadConversionEventsProcess : Account_CrtMLLeadConversionEventsProcess<Account>
	{

		public Account_CrtMLLeadConversionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_CrtMLLeadConversionEventsProcess

	public partial class Account_CrtMLLeadConversionEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountEventsProcess

	/// <exclude/>
	public class AccountEventsProcess : Account_CrtMLLeadConversionEventsProcess
	{

		public AccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

