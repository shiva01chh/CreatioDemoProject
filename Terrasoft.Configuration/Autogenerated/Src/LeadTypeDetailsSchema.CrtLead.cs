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

	#region Class: LeadTypeDetailsSchema

	/// <exclude/>
	public class LeadTypeDetailsSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadTypeDetailsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadTypeDetailsSchema(LeadTypeDetailsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadTypeDetailsSchema(LeadTypeDetailsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b");
			RealUId = new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b");
			Name = "LeadTypeDetails";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("220af5cc-764d-46b3-96f6-cd9d8d9d1750");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
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
			return new LeadTypeDetails(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadTypeDetails_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadTypeDetailsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadTypeDetailsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeDetails

	/// <summary>
	/// Lead type details.
	/// </summary>
	public class LeadTypeDetails : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadTypeDetails(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadTypeDetails";
		}

		public LeadTypeDetails(LeadTypeDetails source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadTypeDetails_CrtLeadEventsProcess(UserConnection);
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
			return new LeadTypeDetails(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadTypeDetails_CrtLeadEventsProcess

	/// <exclude/>
	public partial class LeadTypeDetails_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadTypeDetails
	{

		public LeadTypeDetails_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadTypeDetails_CrtLeadEventsProcess";
			SchemaUId = new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b");
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

	#region Class: LeadTypeDetails_CrtLeadEventsProcess

	/// <exclude/>
	public class LeadTypeDetails_CrtLeadEventsProcess : LeadTypeDetails_CrtLeadEventsProcess<LeadTypeDetails>
	{

		public LeadTypeDetails_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadTypeDetails_CrtLeadEventsProcess

	public partial class LeadTypeDetails_CrtLeadEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: LeadTypeDetailsEventsProcess

	/// <exclude/>
	public class LeadTypeDetailsEventsProcess : LeadTypeDetails_CrtLeadEventsProcess
	{

		public LeadTypeDetailsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

