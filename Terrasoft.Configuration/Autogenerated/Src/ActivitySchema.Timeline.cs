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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_Timeline_TerrasoftSchema

	/// <exclude/>
	public class Activity_Timeline_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtUIv2_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Timeline_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Timeline_TerrasoftSchema(Activity_Timeline_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Timeline_TerrasoftSchema(Activity_Timeline_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a3051093-ea10-4d7e-823c-d86d710ab8d9");
			Name = "Activity_Timeline_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0f0b57ce-3155-4876-a7bb-8a901e434b75");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
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
			return new Activity_Timeline_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_TimelineEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_Timeline_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Timeline_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3051093-ea10-4d7e-823c-d86d710ab8d9"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Timeline_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Timeline_Terrasoft : Terrasoft.Configuration.Activity_CrtUIv2_Terrasoft
	{

		#region Constructors: Public

		public Activity_Timeline_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Timeline_Terrasoft";
		}

		public Activity_Timeline_Terrasoft(Activity_Timeline_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_TimelineEventsProcess(UserConnection);
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
			return new Activity_Timeline_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_TimelineEventsProcess

	/// <exclude/>
	public partial class Activity_TimelineEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtUIv2EventsProcess<TEntity> where TEntity : Activity_Timeline_Terrasoft
	{

		public Activity_TimelineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_TimelineEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a3051093-ea10-4d7e-823c-d86d710ab8d9");
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

	#region Class: Activity_TimelineEventsProcess

	/// <exclude/>
	public class Activity_TimelineEventsProcess : Activity_TimelineEventsProcess<Activity_Timeline_Terrasoft>
	{

		public Activity_TimelineEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_TimelineEventsProcess

	public partial class Activity_TimelineEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

