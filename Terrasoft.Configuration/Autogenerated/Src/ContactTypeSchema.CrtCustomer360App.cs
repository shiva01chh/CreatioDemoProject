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

	#region Class: ContactTypeSchema

	/// <exclude/>
	public class ContactTypeSchema : Terrasoft.Configuration.ContactType_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactTypeSchema(ContactTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactTypeSchema(ContactTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("eb11e6a6-239a-42d5-809b-2db7f8974caa");
			Name = "ContactType";
			ParentSchemaUId = new Guid("0b5ff414-e00a-4115-af0c-fe872e826f07");
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
				UId = new Guid("fa1cc2fc-6b0e-adce-0b00-336c3e6f585f"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("eb11e6a6-239a-42d5-809b-2db7f8974caa"),
				ModifiedInSchemaUId = new Guid("eb11e6a6-239a-42d5-809b-2db7f8974caa"),
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
			return new ContactType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactType_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb11e6a6-239a-42d5-809b-2db7f8974caa"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactType

	/// <summary>
	/// Contact type.
	/// </summary>
	public class ContactType : Terrasoft.Configuration.ContactType_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactType";
		}

		public ContactType(ContactType source)
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
			var process = new ContactType_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new ContactType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactType_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class ContactType_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.ContactType_CrtBaseEventsProcess<TEntity> where TEntity : ContactType
	{

		public ContactType_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactType_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eb11e6a6-239a-42d5-809b-2db7f8974caa");
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

	#region Class: ContactType_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class ContactType_CrtCustomer360AppEventsProcess : ContactType_CrtCustomer360AppEventsProcess<ContactType>
	{

		public ContactType_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactType_CrtCustomer360AppEventsProcess

	public partial class ContactType_CrtCustomer360AppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ContactTypeEventsProcess

	/// <exclude/>
	public class ContactTypeEventsProcess : ContactType_CrtCustomer360AppEventsProcess
	{

		public ContactTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

