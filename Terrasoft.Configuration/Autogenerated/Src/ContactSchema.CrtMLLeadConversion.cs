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

	#region Class: Contact_CrtMLLeadConversion_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtMLLeadConversion_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtTouchPointInC360_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtMLLeadConversion_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtMLLeadConversion_TerrasoftSchema(Contact_CrtMLLeadConversion_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtMLLeadConversion_TerrasoftSchema(Contact_CrtMLLeadConversion_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5c017eda-4814-4b75-ab70-ec320a300730");
			Name = "Contact_CrtMLLeadConversion_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
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
			if (Columns.FindByUId(new Guid("ef892d2f-eebd-6e64-7acc-02f7e3f981af")) == null) {
				Columns.Add(CreateLeadConversionScoreColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadConversionScoreColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ef892d2f-eebd-6e64-7acc-02f7e3f981af"),
				Name = @"LeadConversionScore",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("5c017eda-4814-4b75-ab70-ec320a300730"),
				ModifiedInSchemaUId = new Guid("5c017eda-4814-4b75-ab70-ec320a300730"),
				CreatedInPackageId = new Guid("9025b0c2-d769-4cf8-b9b1-67afd440e08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtMLLeadConversion_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtMLLeadConversionEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtMLLeadConversion_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtMLLeadConversion_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c017eda-4814-4b75-ab70-ec320a300730"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtMLLeadConversion_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtMLLeadConversion_Terrasoft : Terrasoft.Configuration.Contact_CrtTouchPointInC360_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtMLLeadConversion_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtMLLeadConversion_Terrasoft";
		}

		public Contact_CrtMLLeadConversion_Terrasoft(Contact_CrtMLLeadConversion_Terrasoft source)
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
			var process = new Contact_CrtMLLeadConversionEventsProcess(UserConnection);
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
			return new Contact_CrtMLLeadConversion_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtMLLeadConversionEventsProcess

	/// <exclude/>
	public partial class Contact_CrtMLLeadConversionEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtTouchPointInC360EventsProcess<TEntity> where TEntity : Contact_CrtMLLeadConversion_Terrasoft
	{

		public Contact_CrtMLLeadConversionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtMLLeadConversionEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5c017eda-4814-4b75-ab70-ec320a300730");
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

	#region Class: Contact_CrtMLLeadConversionEventsProcess

	/// <exclude/>
	public class Contact_CrtMLLeadConversionEventsProcess : Contact_CrtMLLeadConversionEventsProcess<Contact_CrtMLLeadConversion_Terrasoft>
	{

		public Contact_CrtMLLeadConversionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtMLLeadConversionEventsProcess

	public partial class Contact_CrtMLLeadConversionEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

