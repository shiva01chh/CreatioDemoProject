namespace Terrasoft.Configuration
{
	using System;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Common.ServiceRouting;

	#region Class: PortalEmailMessageService

	/// <summary>
	/// Service for working with portal email messages.
	/// </summary>
	[ServiceContract]
	[SspServiceRoute]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class PortalEmailMessageService : BaseService
	{

		#region Methods: Private

		private Select GetPortalEmailMessageSelect(Guid caseMessageHistoryId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseMessageHistory");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var primaryKeyFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				esq.RootSchema.GetPrimaryColumnName(), caseMessageHistoryId);
			esq.Filters.Add(primaryKeyFilter);
			var caseMessageHistorySelect = esq.GetSelectQuery(UserConnection);
			caseMessageHistorySelect.Column("PEM", "Recipient");
			caseMessageHistorySelect.Column("PEM", "Sender");
			caseMessageHistorySelect.Column("PEM", "MessageTypeId");
			caseMessageHistorySelect.Column("C", "PhotoId");
			caseMessageHistorySelect
				.InnerJoin("PortalEmailMessage").As("PEM")
					.On("PEM", "CaseMessageHistoryId")
					.IsEqual("CaseMessageHistory", "Id")
				.InnerJoin("Activity").As("A")
					.On("A", "Id")
					.IsEqual("CaseMessageHistory", "RecordId")
				.LeftOuterJoin("Contact").As("C")
					.On("C", "Id")
					.IsEqual("A", "SenderContactId");
			return caseMessageHistorySelect;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets portal email message connected to <paramref name="caseMessageHistoryId"/>
		/// </summary>
		/// <param name="caseMessageHistoryId">CaseMessageHistory identifier.</param>
		/// <returns>Portal email message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		public PortalEmailMessageServiceResponse GetPortalEmailMessage(Guid caseMessageHistoryId) {
			Select select = GetPortalEmailMessageSelect(caseMessageHistoryId);
			select.ExecuteSingleRecord(reader => new PortalEmailMessageServiceResponse {
				MessageTypeId = reader.GetColumnValue<Guid>("MessageTypeId"),
				Recipient = reader.GetColumnValue<string>("Recipient"),
				Sender = reader.GetColumnValue<string>("Sender"),
				SenderContactImageId = reader.GetColumnValue<Guid>("PhotoId")
			}, out PortalEmailMessageServiceResponse portalEmailMessage);
			return portalEmailMessage;
		}

		#endregion

	}

	#endregion

	#region PortalEmailMessageResponse

	/// <summary>
	/// Represents response with information about portal email messages.
	/// </summary>
	[DataContract]
	public class PortalEmailMessageServiceResponse
	{
		/// <summary>
		/// Email sender.
		/// </summary>
		[DataMember(Name = "sender")]
		public string Sender { get; set; }

		/// <summary>
		/// Email recipient.
		/// </summary>
		[DataMember(Name = "recipient")]
		public string Recipient { get; set; }

		/// <summary>
		/// Email message type identifier.
		/// </summary>
		[DataMember(Name = "messageTypeId")]
		public Guid MessageTypeId { get; set; }

		/// <summary>
		/// Photo identifier of email sender contact.
		/// </summary>
		[DataMember(Name = "senderContactImageId")]
		public Guid SenderContactImageId { get; set; }
	}

	#endregion

}





