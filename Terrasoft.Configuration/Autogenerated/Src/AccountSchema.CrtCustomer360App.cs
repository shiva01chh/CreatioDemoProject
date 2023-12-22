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

	#region Class: Account_CrtCustomer360App_TerrasoftSchema

	/// <exclude/>
	public class Account_CrtCustomer360App_TerrasoftSchema : Terrasoft.Configuration.Account_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public Account_CrtCustomer360App_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Account_CrtCustomer360App_TerrasoftSchema(Account_CrtCustomer360App_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Account_CrtCustomer360App_TerrasoftSchema(Account_CrtCustomer360App_TerrasoftSchema source)
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
			RealUId = new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
			Name = "Account_CrtCustomer360App_Terrasoft";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c3352ad7-734f-4d78-b5df-7bf53f0975cc");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreatePhoneColumn() {
			EntitySchemaColumn column = base.CreatePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
			return column;
		}

		protected override EntitySchemaColumn CreateAdditionalPhoneColumn() {
			EntitySchemaColumn column = base.CreateAdditionalPhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
			return column;
		}

		protected override EntitySchemaColumn CreateFaxColumn() {
			EntitySchemaColumn column = base.CreateFaxColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
			return column;
		}

		protected override EntitySchemaColumn CreateWebColumn() {
			EntitySchemaColumn column = base.CreateWebColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("WebText");
			column.ModifiedInSchemaUId = new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
			return column;
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
			return new Account_CrtCustomer360App_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Account_CrtCustomer360App_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Account_CrtCustomer360App_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e"));
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtCustomer360App_Terrasoft

	/// <summary>
	/// Account.
	/// </summary>
	public class Account_CrtCustomer360App_Terrasoft : Terrasoft.Configuration.Account_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public Account_CrtCustomer360App_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account_CrtCustomer360App_Terrasoft";
		}

		public Account_CrtCustomer360App_Terrasoft(Account_CrtCustomer360App_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new Account_CrtCustomer360App_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class Account_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtProductCatalogueEventsProcess<TEntity> where TEntity : Account_CrtCustomer360App_Terrasoft
	{

		public Account_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2b4c6a55-4d52-4505-8e3c-f105d913136e");
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

	#region Class: Account_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class Account_CrtCustomer360AppEventsProcess : Account_CrtCustomer360AppEventsProcess<Account_CrtCustomer360App_Terrasoft>
	{

		public Account_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_CrtCustomer360AppEventsProcess

	public partial class Account_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

