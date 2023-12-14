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

	#region Class: Contact_PRMPortal_TerrasoftSchema

	/// <exclude/>
	public class Contact_PRMPortal_TerrasoftSchema : Terrasoft.Configuration.Contact_CrtTouchPointInC360_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_PRMPortal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_PRMPortal_TerrasoftSchema(Contact_PRMPortal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_PRMPortal_TerrasoftSchema(Contact_PRMPortal_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("93fa5cb6-90a1-4852-9b0a-f8ce32e1de0d");
			Name = "Contact_PRMPortal_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("be64f413-e46e-44a8-8668-e024a58440fd");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_PRMPortal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Contact_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Contact_PRMPortal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_PRMPortal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93fa5cb6-90a1-4852-9b0a-f8ce32e1de0d"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_PRMPortal_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_PRMPortal_Terrasoft : Terrasoft.Configuration.Contact_CrtTouchPointInC360_Terrasoft
	{

		#region Constructors: Public

		public Contact_PRMPortal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_PRMPortal_Terrasoft";
		}

		public Contact_PRMPortal_Terrasoft(Contact_PRMPortal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_PRMPortalEventsProcess(UserConnection);
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
			return new Contact_PRMPortal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_PRMPortalEventsProcess

	/// <exclude/>
	public partial class Contact_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.Contact_CrtTouchPointInC360EventsProcess<TEntity> where TEntity : Contact_PRMPortal_Terrasoft
	{

		public Contact_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93fa5cb6-90a1-4852-9b0a-f8ce32e1de0d");
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

	#region Class: Contact_PRMPortalEventsProcess

	/// <exclude/>
	public class Contact_PRMPortalEventsProcess : Contact_PRMPortalEventsProcess<Contact_PRMPortal_Terrasoft>
	{

		public Contact_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_PRMPortalEventsProcess

	public partial class Contact_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

