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

	#region Class: LeadMedium_CrtTouchPoint_TerrasoftSchema

	/// <exclude/>
	public class LeadMedium_CrtTouchPoint_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public LeadMedium_CrtTouchPoint_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LeadMedium_CrtTouchPoint_TerrasoftSchema(LeadMedium_CrtTouchPoint_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LeadMedium_CrtTouchPoint_TerrasoftSchema(LeadMedium_CrtTouchPoint_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			RealUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			Name = "LeadMedium_CrtTouchPoint_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6cdbb516-9811-46ca-a4f8-441ae8e11086");
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
			return new LeadMedium_CrtTouchPoint_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new LeadMedium_CrtTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new LeadMedium_CrtTouchPoint_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LeadMedium_CrtTouchPoint_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"));
		}

		#endregion

	}

	#endregion

	#region Class: LeadMedium_CrtTouchPoint_Terrasoft

	/// <summary>
	/// Channel.
	/// </summary>
	public class LeadMedium_CrtTouchPoint_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public LeadMedium_CrtTouchPoint_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LeadMedium_CrtTouchPoint_Terrasoft";
		}

		public LeadMedium_CrtTouchPoint_Terrasoft(LeadMedium_CrtTouchPoint_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LeadMedium_CrtTouchPointEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("LeadMedium_CrtTouchPoint_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("LeadMedium_CrtTouchPoint_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LeadMedium_CrtTouchPoint_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	/// <exclude/>
	public partial class LeadMedium_CrtTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : LeadMedium_CrtTouchPoint_Terrasoft
	{

		public LeadMedium_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LeadMedium_CrtTouchPointEventsProcess";
			SchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c");
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

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	/// <exclude/>
	public class LeadMedium_CrtTouchPointEventsProcess : LeadMedium_CrtTouchPointEventsProcess<LeadMedium_CrtTouchPoint_Terrasoft>
	{

		public LeadMedium_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LeadMedium_CrtTouchPointEventsProcess

	public partial class LeadMedium_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

