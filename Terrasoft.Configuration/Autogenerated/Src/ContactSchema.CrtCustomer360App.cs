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
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_CrtCustomer360App_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtCustomer360App_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtBulkEmail_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtCustomer360App_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtCustomer360App_TerrasoftSchema(Contact_CrtCustomer360App_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtCustomer360App_TerrasoftSchema(Contact_CrtCustomer360App_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			Name = "Contact_CrtCustomer360App_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6ee8d7b1-3226-4f2d-bb21-2207f8a78f18");
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
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateMobilePhoneColumn() {
			EntitySchemaColumn column = base.CreateMobilePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateHomePhoneColumn() {
			EntitySchemaColumn column = base.CreateHomePhoneColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("PhoneText");
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateEmailColumn() {
			EntitySchemaColumn column = base.CreateEmailColumn();
			column.DataValueType = DataValueTypeManager.GetInstanceByName("EmailText");
			column.IsFormatValidated = true;
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseFaxColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseFaxColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateConfirmedColumn() {
			EntitySchemaColumn column = base.CreateConfirmedColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override EntitySchemaColumn CreateLanguageColumn() {
			EntitySchemaColumn column = base.CreateLanguageColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultMessageLanguage"
			};
			column.ModifiedInSchemaUId = new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtCustomer360App_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtCustomer360App_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtCustomer360App_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtCustomer360App_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtCustomer360App_Terrasoft : Terrasoft.Configuration.Contact_CrtBulkEmail_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtCustomer360App_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtCustomer360App_Terrasoft";
		}

		public Contact_CrtCustomer360App_Terrasoft(Contact_CrtCustomer360App_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new Contact_CrtCustomer360App_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class Contact_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtBulkEmailEventsProcess<TEntity> where TEntity : Contact_CrtCustomer360App_Terrasoft
	{

		public Contact_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("89e464d5-1089-44c2-a04b-96f7a93e555e");
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

	#region Class: Contact_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class Contact_CrtCustomer360AppEventsProcess : Contact_CrtCustomer360AppEventsProcess<Contact_CrtCustomer360App_Terrasoft>
	{

		public Contact_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtCustomer360AppEventsProcess

	public partial class Contact_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

