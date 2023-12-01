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

	#region Class: Contact_CrtTouchPointInC360_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtTouchPointInC360_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtTouchPointInC360_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtTouchPointInC360_TerrasoftSchema(Contact_CrtTouchPointInC360_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtTouchPointInC360_TerrasoftSchema(Contact_CrtTouchPointInC360_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5");
			Name = "Contact_CrtTouchPointInC360_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1ee66641-e6d5-42b1-a431-5006d76dad6e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4d9b669e-d355-c283-637b-a90b6452e893")) == null) {
				Columns.Add(CreateCustomerNeedColumn());
			}
			if (Columns.FindByUId(new Guid("19ed80da-496c-1194-5432-f444dfa29d30")) == null) {
				Columns.Add(CreateChannelColumn());
			}
			if (Columns.FindByUId(new Guid("d49f0330-5f3f-e03c-9f03-3a820095fb7c")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("a4119c49-add4-d08a-aa49-4fbd15e90b50")) == null) {
				Columns.Add(CreateRegisterMethodColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCustomerNeedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4d9b669e-d355-c283-637b-a90b6452e893"),
				Name = @"CustomerNeed",
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				ModifiedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				CreatedInPackageId = new Guid("1ee66641-e6d5-42b1-a431-5006d76dad6e")
			};
		}

		protected virtual EntitySchemaColumn CreateChannelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("19ed80da-496c-1194-5432-f444dfa29d30"),
				Name = @"Channel",
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				ModifiedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				CreatedInPackageId = new Guid("1ee66641-e6d5-42b1-a431-5006d76dad6e")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d49f0330-5f3f-e03c-9f03-3a820095fb7c"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				ModifiedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				CreatedInPackageId = new Guid("1ee66641-e6d5-42b1-a431-5006d76dad6e")
			};
		}

		protected virtual EntitySchemaColumn CreateRegisterMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a4119c49-add4-d08a-aa49-4fbd15e90b50"),
				Name = @"RegisterMethod",
				ReferenceSchemaUId = new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				ModifiedInSchemaUId = new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"),
				CreatedInPackageId = new Guid("1ee66641-e6d5-42b1-a431-5006d76dad6e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtTouchPointInC360_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtTouchPointInC360EventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtTouchPointInC360_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtTouchPointInC360_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtTouchPointInC360_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtTouchPointInC360_Terrasoft : Terrasoft.Configuration.Contact_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtTouchPointInC360_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtTouchPointInC360_Terrasoft";
		}

		public Contact_CrtTouchPointInC360_Terrasoft(Contact_CrtTouchPointInC360_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CustomerNeedId {
			get {
				return GetTypedColumnValue<Guid>("CustomerNeedId");
			}
			set {
				SetColumnValue("CustomerNeedId", value);
				_customerNeed = null;
			}
		}

		/// <exclude/>
		public string CustomerNeedName {
			get {
				return GetTypedColumnValue<string>("CustomerNeedName");
			}
			set {
				SetColumnValue("CustomerNeedName", value);
				if (_customerNeed != null) {
					_customerNeed.Name = value;
				}
			}
		}

		private LeadType _customerNeed;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType CustomerNeed {
			get {
				return _customerNeed ??
					(_customerNeed = LookupColumnEntities.GetEntity("CustomerNeed") as LeadType);
			}
		}

		/// <exclude/>
		public Guid ChannelId {
			get {
				return GetTypedColumnValue<Guid>("ChannelId");
			}
			set {
				SetColumnValue("ChannelId", value);
				_channel = null;
			}
		}

		/// <exclude/>
		public string ChannelName {
			get {
				return GetTypedColumnValue<string>("ChannelName");
			}
			set {
				SetColumnValue("ChannelName", value);
				if (_channel != null) {
					_channel.Name = value;
				}
			}
		}

		private LeadMedium _channel;
		/// <summary>
		/// Channel.
		/// </summary>
		public LeadMedium Channel {
			get {
				return _channel ??
					(_channel = LookupColumnEntities.GetEntity("Channel") as LeadMedium);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private LeadSource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public LeadSource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as LeadSource);
			}
		}

		/// <exclude/>
		public Guid RegisterMethodId {
			get {
				return GetTypedColumnValue<Guid>("RegisterMethodId");
			}
			set {
				SetColumnValue("RegisterMethodId", value);
				_registerMethod = null;
			}
		}

		/// <exclude/>
		public string RegisterMethodName {
			get {
				return GetTypedColumnValue<string>("RegisterMethodName");
			}
			set {
				SetColumnValue("RegisterMethodName", value);
				if (_registerMethod != null) {
					_registerMethod.Name = value;
				}
			}
		}

		private RegisterMethod _registerMethod;
		/// <summary>
		/// Registration method.
		/// </summary>
		public RegisterMethod RegisterMethod {
			get {
				return _registerMethod ??
					(_registerMethod = LookupColumnEntities.GetEntity("RegisterMethod") as RegisterMethod);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtTouchPointInC360EventsProcess(UserConnection);
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
			return new Contact_CrtTouchPointInC360_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtTouchPointInC360EventsProcess

	/// <exclude/>
	public partial class Contact_CrtTouchPointInC360EventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtCustomer360AppEventsProcess<TEntity> where TEntity : Contact_CrtTouchPointInC360_Terrasoft
	{

		public Contact_CrtTouchPointInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtTouchPointInC360EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a95929a3-c41c-46f0-8188-9686d65e9cc5");
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

	#region Class: Contact_CrtTouchPointInC360EventsProcess

	/// <exclude/>
	public class Contact_CrtTouchPointInC360EventsProcess : Contact_CrtTouchPointInC360EventsProcess<Contact_CrtTouchPointInC360_Terrasoft>
	{

		public Contact_CrtTouchPointInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtTouchPointInC360EventsProcess

	public partial class Contact_CrtTouchPointInC360EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

