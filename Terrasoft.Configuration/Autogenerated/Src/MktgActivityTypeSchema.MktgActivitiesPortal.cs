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

	#region Class: MktgActivityTypeSchema

	/// <exclude/>
	public class MktgActivityTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MktgActivityTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MktgActivityTypeSchema(MktgActivityTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MktgActivityTypeSchema(MktgActivityTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("13f1c29e-a68f-45c8-96c4-ad29b60ee5c2");
			RealUId = new Guid("13f1c29e-a68f-45c8-96c4-ad29b60ee5c2");
			Name = "MktgActivityType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("12438ade-fc27-4c74-b597-0ce1b90fa1ec");
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
			return new MktgActivityType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MktgActivityType_MktgActivitiesPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MktgActivityTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MktgActivityTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13f1c29e-a68f-45c8-96c4-ad29b60ee5c2"));
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityType

	/// <summary>
	/// Marketing activity type.
	/// </summary>
	public class MktgActivityType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MktgActivityType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MktgActivityType";
		}

		public MktgActivityType(MktgActivityType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MktgActivityType_MktgActivitiesPortalEventsProcess(UserConnection);
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
			return new MktgActivityType(this);
		}

		#endregion

	}

	#endregion

	#region Class: MktgActivityType_MktgActivitiesPortalEventsProcess

	/// <exclude/>
	public partial class MktgActivityType_MktgActivitiesPortalEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : MktgActivityType
	{

		public MktgActivityType_MktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MktgActivityType_MktgActivitiesPortalEventsProcess";
			SchemaUId = new Guid("13f1c29e-a68f-45c8-96c4-ad29b60ee5c2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("13f1c29e-a68f-45c8-96c4-ad29b60ee5c2");
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

	#region Class: MktgActivityType_MktgActivitiesPortalEventsProcess

	/// <exclude/>
	public class MktgActivityType_MktgActivitiesPortalEventsProcess : MktgActivityType_MktgActivitiesPortalEventsProcess<MktgActivityType>
	{

		public MktgActivityType_MktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MktgActivityType_MktgActivitiesPortalEventsProcess

	public partial class MktgActivityType_MktgActivitiesPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: MktgActivityTypeEventsProcess

	/// <exclude/>
	public class MktgActivityTypeEventsProcess : MktgActivityType_MktgActivitiesPortalEventsProcess
	{

		public MktgActivityTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

