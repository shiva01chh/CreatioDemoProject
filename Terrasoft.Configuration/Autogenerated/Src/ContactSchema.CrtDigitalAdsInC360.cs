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

	#region Class: Contact_CrtDigitalAdsInC360_TerrasoftSchema

	/// <exclude/>
	public class Contact_CrtDigitalAdsInC360_TerrasoftSchema : Terrasoft.Configuration.Contact_PRMPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_CrtDigitalAdsInC360_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_CrtDigitalAdsInC360_TerrasoftSchema(Contact_CrtDigitalAdsInC360_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_CrtDigitalAdsInC360_TerrasoftSchema(Contact_CrtDigitalAdsInC360_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("fbb0369e-af5f-484e-bb62-ba08c5b82a69");
			Name = "Contact_CrtDigitalAdsInC360_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("322f308b-f9f2-f233-35bd-78e1abee1215")) == null) {
				Columns.Add(CreateAdCampaignColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAdCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("322f308b-f9f2-f233-35bd-78e1abee1215"),
				Name = @"AdCampaign",
				ReferenceSchemaUId = new Guid("0b416432-4385-432a-94ad-c30262cd14da"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fbb0369e-af5f-484e-bb62-ba08c5b82a69"),
				ModifiedInSchemaUId = new Guid("fbb0369e-af5f-484e-bb62-ba08c5b82a69"),
				CreatedInPackageId = new Guid("1f624e01-f284-4287-8a23-f115d1bf140b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_CrtDigitalAdsInC360_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_CrtDigitalAdsInC360EventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_CrtDigitalAdsInC360_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_CrtDigitalAdsInC360_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fbb0369e-af5f-484e-bb62-ba08c5b82a69"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtDigitalAdsInC360_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_CrtDigitalAdsInC360_Terrasoft : Terrasoft.Configuration.Contact_PRMPortal_Terrasoft
	{

		#region Constructors: Public

		public Contact_CrtDigitalAdsInC360_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_CrtDigitalAdsInC360_Terrasoft";
		}

		public Contact_CrtDigitalAdsInC360_Terrasoft(Contact_CrtDigitalAdsInC360_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AdCampaignId {
			get {
				return GetTypedColumnValue<Guid>("AdCampaignId");
			}
			set {
				SetColumnValue("AdCampaignId", value);
				_adCampaign = null;
			}
		}

		/// <exclude/>
		public string AdCampaignCampaignName {
			get {
				return GetTypedColumnValue<string>("AdCampaignCampaignName");
			}
			set {
				SetColumnValue("AdCampaignCampaignName", value);
				if (_adCampaign != null) {
					_adCampaign.CampaignName = value;
				}
			}
		}

		private AdCampaign _adCampaign;
		/// <summary>
		/// Ad campaign.
		/// </summary>
		public AdCampaign AdCampaign {
			get {
				return _adCampaign ??
					(_adCampaign = LookupColumnEntities.GetEntity("AdCampaign") as AdCampaign);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_CrtDigitalAdsInC360EventsProcess(UserConnection);
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
			return new Contact_CrtDigitalAdsInC360_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public partial class Contact_CrtDigitalAdsInC360EventsProcess<TEntity> : Terrasoft.Configuration.Contact_PRMPortalEventsProcess<TEntity> where TEntity : Contact_CrtDigitalAdsInC360_Terrasoft
	{

		public Contact_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_CrtDigitalAdsInC360EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fbb0369e-af5f-484e-bb62-ba08c5b82a69");
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

	#region Class: Contact_CrtDigitalAdsInC360EventsProcess

	/// <exclude/>
	public class Contact_CrtDigitalAdsInC360EventsProcess : Contact_CrtDigitalAdsInC360EventsProcess<Contact_CrtDigitalAdsInC360_Terrasoft>
	{

		public Contact_CrtDigitalAdsInC360EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_CrtDigitalAdsInC360EventsProcess

	public partial class Contact_CrtDigitalAdsInC360EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

