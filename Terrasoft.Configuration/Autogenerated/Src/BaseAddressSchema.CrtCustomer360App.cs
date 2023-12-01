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

	#region Class: BaseAddressSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseAddressSchema : Terrasoft.Configuration.BaseAddress_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public BaseAddressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseAddressSchema(BaseAddressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseAddressSchema(BaseAddressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("77d7cf2b-42c7-4be0-9e11-0058145972a2");
			Name = "BaseAddress";
			ParentSchemaUId = new Guid("400e8687-9616-480d-9d81-61de0235cc86");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c306f334-b3c9-4e98-9644-0ec16cd9a358");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cd784f1b-c816-3621-f111-bb9026662172")) == null) {
				Columns.Add(CreateFullAddressColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFullAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("cd784f1b-c816-3621-f111-bb9026662172"),
				Name = @"FullAddress",
				CreatedInSchemaUId = new Guid("77d7cf2b-42c7-4be0-9e11-0058145972a2"),
				ModifiedInSchemaUId = new Guid("77d7cf2b-42c7-4be0-9e11-0058145972a2"),
				CreatedInPackageId = new Guid("c306f334-b3c9-4e98-9644-0ec16cd9a358"),
				IsFormatValidated = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BaseAddress(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseAddress_CrtCustomer360AppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseAddressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseAddressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77d7cf2b-42c7-4be0-9e11-0058145972a2"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseAddress

	/// <summary>
	/// Base address.
	/// </summary>
	public class BaseAddress : Terrasoft.Configuration.BaseAddress_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public BaseAddress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseAddress";
		}

		public BaseAddress(BaseAddress source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Full address.
		/// </summary>
		public string FullAddress {
			get {
				return GetTypedColumnValue<string>("FullAddress");
			}
			set {
				SetColumnValue("FullAddress", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseAddress_CrtCustomer360AppEventsProcess(UserConnection);
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
			return new BaseAddress(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseAddress_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public partial class BaseAddress_CrtCustomer360AppEventsProcess<TEntity> : Terrasoft.Configuration.BaseAddress_CrtBaseEventsProcess<TEntity> where TEntity : BaseAddress
	{

		public BaseAddress_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseAddress_CrtCustomer360AppEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("77d7cf2b-42c7-4be0-9e11-0058145972a2");
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

	#region Class: BaseAddress_CrtCustomer360AppEventsProcess

	/// <exclude/>
	public class BaseAddress_CrtCustomer360AppEventsProcess : BaseAddress_CrtCustomer360AppEventsProcess<BaseAddress>
	{

		public BaseAddress_CrtCustomer360AppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: BaseAddressEventsProcess

	/// <exclude/>
	public class BaseAddressEventsProcess : BaseAddress_CrtCustomer360AppEventsProcess
	{

		public BaseAddressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

