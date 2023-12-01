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

	#region Class: Contact_CrtBulkEmail_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtBulkEmail_TerrasoftSchema : Terrasoft.Configuration.Contact_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtBulkEmail_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtBulkEmail_TerrasoftSchema(Contact_CrtBulkEmail_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtBulkEmail_TerrasoftSchema(Contact_CrtBulkEmail_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateI84ciI9ljAEY9JBteoJcHEeIc1KUIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("606284af-5c43-4e46-b7d4-a01d00ffe9bc");
			index.Name = "I84ciI9ljAEY9JBteoJcHEeIc1KU";
			index.CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			index.ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			index.CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7");
			EntitySchemaIndexColumn emailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("72478faa-6bb8-4b94-8e73-064baf7d1017"),
				ColumnUId = new Guid("dbf202ec-c444-479b-bcf4-d8e5b1863201"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(emailIndexColumn);
			EntitySchemaIndexColumn doNotUseEmailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("437041e4-308e-4f07-8bf3-edd30fa9cc9c"),
				ColumnUId = new Guid("1b1d8f33-4d26-4353-a1ed-07e11fc82112"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(doNotUseEmailIndexColumn);
			EntitySchemaIndexColumn isNonActualEmailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3fd12b70-0a1c-4bc7-92c5-c165ddfc5ebe"),
				ColumnUId = new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(isNonActualEmailIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			Name = "Contact_CrtBulkEmail_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ad50bca2-4b1b-4d20-9ed9-9c5500cdd145");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee")) == null) {
				Columns.Add(CreateIsNonActualEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsNonActualEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee"),
				Name = @"IsNonActualEmail",
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("ad50bca2-4b1b-4d20-9ed9-9c5500cdd145")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateI84ciI9ljAEY9JBteoJcHEeIc1KUIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtBulkEmail_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtBulkEmail_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtBulkEmail_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtBulkEmail_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtBulkEmail_Terrasoft : Terrasoft.Configuration.Contact_Lead_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtBulkEmail_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtBulkEmail_Terrasoft";
		}

		public Contact_CrtBulkEmail_Terrasoft(Contact_CrtBulkEmail_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Invalid email.
		/// </summary>
		public bool IsNonActualEmail {
			get {
				return GetTypedColumnValue<bool>("IsNonActualEmail");
			}
			set {
				SetColumnValue("IsNonActualEmail", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtBulkEmailEventsProcess(UserConnection);
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
			return new Contact_CrtBulkEmail_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class Contact_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.Contact_LeadEventsProcess<TEntity> where TEntity : Contact_CrtBulkEmail_Terrasoft
	{

		public Contact_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtBulkEmailEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
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

	#region Class: Contact_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class Contact_CrtBulkEmailEventsProcess : Contact_CrtBulkEmailEventsProcess<Contact_CrtBulkEmail_Terrasoft>
	{

		public Contact_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtBulkEmailEventsProcess

	public partial class Contact_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

