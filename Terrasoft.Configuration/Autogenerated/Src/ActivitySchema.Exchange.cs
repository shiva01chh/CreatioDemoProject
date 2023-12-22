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

	#region Class: Activity_Exchange_TerrasoftSchema

	/// <exclude/>
	public class Activity_Exchange_TerrasoftSchema : Terrasoft.Configuration.Activity_CrtUIv2_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Exchange_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Exchange_TerrasoftSchema(Activity_Exchange_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Exchange_TerrasoftSchema(Activity_Exchange_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124");
			Name = "Activity_Exchange_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("024c7e3b-9ce7-4ec6-aaf5-bdedd07ac300")) == null) {
				Columns.Add(CreateUserEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("be1d624b-b774-40ab-85cc-9364dacd6199")) == null) {
				Columns.Add(CreateLocationColumn());
			}
			if (Columns.FindByUId(new Guid("3a15a3c6-e7e4-06da-c667-5561e5f9cd1d")) == null) {
				Columns.Add(CreateRemoteCreatedOnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUserEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("024c7e3b-9ce7-4ec6-aaf5-bdedd07ac300"),
				Name = @"UserEmailAddress",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				ModifiedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			};
		}

		protected virtual EntitySchemaColumn CreateLocationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("be1d624b-b774-40ab-85cc-9364dacd6199"),
				Name = @"Location",
				CreatedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				ModifiedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				CreatedInPackageId = new Guid("e8870aad-3989-43c9-a61d-2b65ea5ccd7e"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateRemoteCreatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("3a15a3c6-e7e4-06da-c667-5561e5f9cd1d"),
				Name = @"RemoteCreatedOn",
				CreatedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				ModifiedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				CreatedInPackageId = new Guid("8a00da25-07f7-4151-9d04-d68d4b9a467a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Exchange_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_ExchangeEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_Exchange_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Exchange_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Exchange_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Exchange_Terrasoft : Terrasoft.Configuration.Activity_CrtUIv2_Terrasoft
	{

		#region Constructors: Public

		public Activity_Exchange_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Exchange_Terrasoft";
		}

		public Activity_Exchange_Terrasoft(Activity_Exchange_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// User email.
		/// </summary>
		public string UserEmailAddress {
			get {
				return GetTypedColumnValue<string>("UserEmailAddress");
			}
			set {
				SetColumnValue("UserEmailAddress", value);
			}
		}

		/// <summary>
		/// Location.
		/// </summary>
		public string Location {
			get {
				return GetTypedColumnValue<string>("Location");
			}
			set {
				SetColumnValue("Location", value);
			}
		}

		/// <summary>
		/// Remote calendar created on.
		/// </summary>
		public DateTime RemoteCreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("RemoteCreatedOn");
			}
			set {
				SetColumnValue("RemoteCreatedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_ExchangeEventsProcess(UserConnection);
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
			return new Activity_Exchange_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_ExchangeEventsProcess

	/// <exclude/>
	public partial class Activity_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CrtUIv2EventsProcess<TEntity> where TEntity : Activity_Exchange_Terrasoft
	{

		public Activity_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_ExchangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124");
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

	#region Class: Activity_ExchangeEventsProcess

	/// <exclude/>
	public class Activity_ExchangeEventsProcess : Activity_ExchangeEventsProcess<Activity_Exchange_Terrasoft>
	{

		public Activity_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_ExchangeEventsProcess

	public partial class Activity_ExchangeEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool DoCollectEmailParticipants() {
			return Entity.GetTypedColumnValue<Guid>("TypeId") == Terrasoft.Configuration.ActivityConsts.EmailTypeUId
			|| Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId;
		}

		public virtual void SynchronizeParticipants() {
			if (string.IsNullOrEmpty(Entity.Sender) && string.IsNullOrEmpty(Entity.Recepient)) {
				return;
			}
			if (Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId) {
				var recepientsEmails = (List<string>)RecepientsEmails;
				Dictionary<Guid, string> contactDictionary = ContactUtilities.GetContactsByEmails(UserConnection, recepientsEmails);
				if (contactDictionary.Count > 0) {
					var participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
					foreach (var contactId in contactDictionary.Keys) {
						AddActivityParticipantToInsertedValues(
							contactId,
							new Dictionary<string, object> {
								{"RoleId", participantRoles["Participant"]}
							},
							false
						);
					}
					var insertedValues = InsertedValues as Dictionary<Guid, object>;
					if (insertedValues != null) {
						UpdateContactAndAccountByParticipant(insertedValues.Keys.ToList());
					}
				}
				Entity.SetColumnValue("Sender", string.Empty);
				Entity.SetColumnValue("Recepient", string.Empty);
			}
		}

		public virtual void UpdateContactAndAccountByParticipant(List<Guid> participants) {
			if (!Entity.GetIsColumnValueLoaded("ContactId") || !Entity.GetIsColumnValueLoaded("AccountId") 
					|| !Entity.GetIsColumnValueLoaded("OwnerId")) {
				return;
			}
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			if ((contactId != Guid.Empty) || (accountId != Guid.Empty)) {
				return;
			}
			if (!IsNew) {
				var existingParticipantIds = new List<Guid>();
				Select selectExistedParticipants =
					new Select(UserConnection).Column("ParticipantId")
						.From("ActivityParticipant")
						.Where("ActivityId")
						.IsEqual(Column.Parameter(Entity.Id)) as Select;
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (
						var reader = selectExistedParticipants.ExecuteReader(dbExecutor)) {
						while (reader.Read()) {
							existingParticipantIds.Add(reader.GetColumnValue<Guid>("ParticipantId"));
						}
					}
				}
				participants = participants.Union(existingParticipantIds).ToList();
			}
			int participantsCount = participants.Count();
			if ((participantsCount > 2) || (participantsCount == 0)) {
				return;
			}
			var ownerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			if ((participantsCount == 2) && !participants.Contains(ownerId)) {
				return;
			}
			contactId = participants.FirstOrDefault(participantId => participantId != ownerId);
			if (contactId == Guid.Empty) {
				return;
			}
			var update =
				new Update(UserConnection, "Activity").Set("ContactId", Column.Const(contactId))
					.Set("AccountId", 
						new Select(UserConnection).Column("AccountId")
							.From("Contact")
							.Where("Id").IsEqual(Column.Const(contactId)) as Select)
					.Where("Id").IsEqual(Column.Const(Entity.Id)) as Update;
			update.Execute();
		}

		public override bool OnActivitySaved(ProcessExecutingContext context) {
			SynchronizeParticipants();
			return base.OnActivitySaved(context);
		}

		#endregion

	}

	#endregion

}

