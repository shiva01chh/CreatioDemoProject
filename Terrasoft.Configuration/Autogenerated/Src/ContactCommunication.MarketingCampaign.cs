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
	using Terrasoft.Configuration;
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

	#region Class: ContactCommunication_MarketingCampaignEventsProcess

	public partial class ContactCommunication_MarketingCampaignEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void UpdateEmailValue(Guid contactId) {
			var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			contactESQ.AddColumn("Email");
			var contact = contactESQ.GetEntity(UserConnection, contactId);
			string currentValue = contact.GetTypedColumnValue<string>("Email");
			if (currentValue.IsNullOrWhiteSpace()) {
				KeyValuePair<string, bool> kvp = GetActualContactEmail(contactId);
				var columnValues = new Dictionary<string, object> {
					{ "Email", kvp.Key },
					{ "IsNonActualEmail", kvp.Value }
				};
				var synchronizer = GetCommunicationSynchronizer();
				synchronizer.SetParentEntityColumnValues(columnValues);
			}
		}

		public override void SetNewContactCommunication() {
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId").ToString();
			bool isCurrentTypeEmail = communicationTypeId.Equals(CommunicationTypeConsts.EmailId);
			bool isOldTypeEmail = OldCommunicationTypeId.ToString().Equals(CommunicationTypeConsts.EmailId);
			if (GetIsCommonBehaviorEnabled()) {
				base.OnCommunicationSaved();
				if (isCurrentTypeEmail || isOldTypeEmail) {
					bool isCanEdit = GetCanEditColumn("Contact", "Email");
					if (!isCanEdit) {
						return;
					}
					UpdateEmailValue(contactId);
				}
			} else {
				var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
				contactESQ.AddAllSchemaColumns();
				var contact = contactESQ.GetEntity(UserConnection, contactId);
				if (contact != null) {
					var number = Entity.GetTypedColumnValue<string>("Number");
					var socialColumnValue = Entity.GetTypedColumnValue<string>("SocialMediaId");
					var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
					var columnNames = GetColumnNameByCommunicationType(new Guid(communicationTypeId));
					var typeColumnName = columnNames["TypeColumnName"];
					var socialColumnName = columnNames["SocialColumnName"];
					if (!typeColumnName.Equals(string.Empty)) {
						bool isCanEdit = GetCanEditColumn("Contact", typeColumnName);
						if (!isCanEdit) {
							return;
						}
						bool isCurrentTypeWeb = communicationTypeId.Equals(CommunicationTypeConsts.WebId);
						bool isNotEmailOrWeb = !isCurrentTypeEmail && !isCurrentTypeWeb;
						if (!(isCurrentTypeEmail || isOldTypeEmail) && !isNotEmailOrWeb) {
							return;
						}
						string currentContactCommunicationValue = contact.GetTypedColumnValue<string>(typeColumnName);
						var update = new Update(UserConnection, "Contact") as Update;
						if (isCurrentTypeEmail || isOldTypeEmail) {
							KeyValuePair<string, bool> kvp = GetActualContactEmail(contactId);
							if (!currentContactCommunicationValue.Equals(kvp.Key)) {
								update.Set("Email", Column.Parameter(kvp.Key));
							}
							update.Set("IsNonActualEmail", Column.Parameter(kvp.Value));
						}
						if (isNotEmailOrWeb) {
							if (!currentContactCommunicationValue.Equals(number) && isPrimary) {
								update.Set(typeColumnName, Column.Parameter(number));
								if (!socialColumnName.Equals(string.Empty)) {
									update.Set(socialColumnName, Column.Parameter(socialColumnValue));
								}
							} else if (!isOldTypeEmail) {
								return;
							}
						}
						update.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow));
						update.Where("Id").IsEqual(Column.Parameter(contactId));
						update.Execute();
					}
				}
			}
		}

		public override void ClearOldContactCommunication() {
			if (Entity.GetIsColumnValueLoaded("NonActual")) {
				bool nonActual = Entity.GetTypedColumnValue<bool>("NonActual");
				if (!nonActual) {
					Entity.SetColumnValue("NonActualReasonId", null);
					Entity.SetColumnValue("DateSetNonActual", null);
				} else {
					bool typeChanged = Entity.GetChangedColumnValues().Any(column => column.Name == "CommunicationTypeId");
					if (typeChanged) {
						Entity.SetColumnValue("NonActualReasonId", MarketingConsts.ManuallyNonActualReasonId);
					}
				}
			}
			OldCommunicationTypeId = Entity.GetTypedOldColumnValue<Guid>("CommunicationTypeId");
			base.ClearOldContactCommunication();
		}

		public override void OnContactCommunicationDeleted() {
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId").ToString();
			if (GetIsCommonBehaviorEnabled()) {
				base.OnCommunicationDeleted();
				if (isPrimary && communicationTypeId.Equals(CommunicationTypeConsts.EmailId)) {
					UpdateEmailValue(contactId);
				}
			} else {
				string contactCommunicationValue = string.Empty;
				var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
				EntitySchemaQueryColumn communicationColumn = null;
				EntitySchemaQueryColumn communicationIdColumn = null;
				var columnNames = GetColumnNameByCommunicationType(new Guid(communicationTypeId));
				var typeColumnName = columnNames["TypeColumnName"];
				var socialColumnName = columnNames["SocialColumnName"];
				if (typeColumnName.Equals(string.Empty)) {
					return;
				}
				var number = Entity.GetTypedColumnValue<string>("Number");
				communicationColumn = contactESQ.AddColumn(typeColumnName);
				if (!socialColumnName.IsNullOrEmpty()) {
					communicationIdColumn = contactESQ.AddColumn(socialColumnName);
				}
				contactESQ.AddAllSchemaColumns();
				var contactEntity = contactESQ.GetEntity(UserConnection, contactId);
				if (contactEntity != null) {
					var value = contactEntity.GetTypedColumnValue<string>(communicationColumn.Name);
					if (value.Equals(number)) {
						if (communicationTypeId.Equals(CommunicationTypeConsts.EmailId)) {
							KeyValuePair<string, bool> kvp = GetActualContactEmail(contactId);
							contactCommunicationValue = kvp.Key;
							contactEntity.SetColumnValue("IsNonActualEmail", kvp.Value);
						}
						if (isPrimary) {
							contactEntity.SetColumnValue(communicationColumn.Name, contactCommunicationValue);
							if (communicationIdColumn != null) {
								contactEntity.SetColumnValue(communicationIdColumn.Name, string.Empty);
							}
						}
						contactEntity.Save();
					}
				}
			}
		}

		public virtual KeyValuePair<string, bool> GetActualContactEmail(Guid contactId) {
			KeyValuePair<string, bool> result = new KeyValuePair<string, bool>(string.Empty, false);
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactCommunication");
			esq.RowCount = 1;
			EntitySchemaQueryColumn nonActualColumn = esq.AddColumn("NonActual").OrderByAsc(1);
			esq.AddColumn("CreatedOn").OrderByDesc(2);
			EntitySchemaQueryColumn numberColumn = esq.AddColumn("Number");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "CommunicationType", 
				CommunicationTypeConsts.EmailId));
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			foreach (Entity entity in entityCollection) {
				return new KeyValuePair<string, bool>(entity.GetTypedColumnValue<string>(numberColumn.Name), 
					 entity.GetTypedColumnValue<bool>(nonActualColumn.Name));
			}
			return result;
		}

		public override void OnContactCommunicationSaving() {
			if (!GetIsCommonBehaviorEnabled()) {
				if (Entity.GetTypedColumnValue<bool>("NonActual")) {
					Entity.SetColumnValue("IsCreatedBySynchronization", false);
				}
			}
			base.OnContactCommunicationSaving();
		}

		#endregion

	}

	#endregion

}

