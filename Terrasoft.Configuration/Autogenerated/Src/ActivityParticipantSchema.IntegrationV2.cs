﻿namespace Terrasoft.Configuration
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

	#region Class: ActivityParticipantSchema

	/// <exclude/>
	public class ActivityParticipantSchema : Terrasoft.Configuration.ActivityParticipant_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ActivityParticipantSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityParticipantSchema(ActivityParticipantSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityParticipantSchema(ActivityParticipantSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("7850e041-8afe-4604-903f-4afd7c5feb6f");
			Name = "ActivityParticipant";
			ParentSchemaUId = new Guid("1aa6373c-1122-403d-9e75-9bffdf6bdcae");
			ExtendParent = true;
			CreatedInPackageId = new Guid("53a64f50-911e-4e24-83fd-d5af8c28bfa3");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateInviteParticipantColumn() {
			EntitySchemaColumn column = base.CreateInviteParticipantColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("7850e041-8afe-4604-903f-4afd7c5feb6f");
			return column;
		}

		protected override EntitySchemaColumn CreateInviteResponseColumn() {
			EntitySchemaColumn column = base.CreateInviteResponseColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("7850e041-8afe-4604-903f-4afd7c5feb6f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityParticipant(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ActivityParticipant_IntegrationV2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new ActivityParticipantSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityParticipantSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7850e041-8afe-4604-903f-4afd7c5feb6f"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipant

	/// <summary>
	/// Activity participant.
	/// </summary>
	public class ActivityParticipant : Terrasoft.Configuration.ActivityParticipant_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ActivityParticipant(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityParticipant";
		}

		public ActivityParticipant(ActivityParticipant source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityParticipant_IntegrationV2EventsProcess(UserConnection);
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
			return new ActivityParticipant(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityParticipant_IntegrationV2EventsProcess

	/// <exclude/>
	public partial class ActivityParticipant_IntegrationV2EventsProcess<TEntity> : Terrasoft.Configuration.ActivityParticipant_CrtBaseEventsProcess<TEntity> where TEntity : ActivityParticipant
	{

		public ActivityParticipant_IntegrationV2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityParticipant_IntegrationV2EventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7850e041-8afe-4604-903f-4afd7c5feb6f");
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

	#region Class: ActivityParticipant_IntegrationV2EventsProcess

	/// <exclude/>
	public class ActivityParticipant_IntegrationV2EventsProcess : ActivityParticipant_IntegrationV2EventsProcess<ActivityParticipant>
	{

		public ActivityParticipant_IntegrationV2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityParticipant_IntegrationV2EventsProcess

	public partial class ActivityParticipant_IntegrationV2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ActivityParticipantEventsProcess

	/// <exclude/>
	public class ActivityParticipantEventsProcess : ActivityParticipant_IntegrationV2EventsProcess
	{

		public ActivityParticipantEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

