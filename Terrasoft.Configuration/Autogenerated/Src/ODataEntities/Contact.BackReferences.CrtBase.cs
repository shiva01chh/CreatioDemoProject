﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: Contact

	/// <exclude/>
	public class Contact : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public Contact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact";
		}

		public Contact(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "Contact";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SysPrcElHistoryLog> SysPrcElHistoryLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwBulkEmailAudience> VwBulkEmailAudienceCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSSPSysAdminUnit> VwSSPSysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OmniChatFile> OmniChatFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Change> ChangeCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Change> ChangeCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<CampaignParticipant> CampaignParticipantCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContractVisa> ContractVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<QuickDialUserSettings> QuickDialUserSettingsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwMandrillRecipientV2> VwMandrillRecipientV2CollectionByLinkedEntity {
			get;
			set;
		}

		public IEnumerable<RecommendedProduct> RecommendedProductCollectionByContact {
			get;
			set;
		}

		public IEnumerable<BETArchiveFirstGeneration> BETArchiveFirstGenerationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CaseLifecycle> CaseLifecycleCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<BulkEmailSubscription> BulkEmailSubscriptionCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OmnichannelMessageFile> OmnichannelMessageFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OrderVisa> OrderVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<InvoiceVisa> InvoiceVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByElementOwner {
			get;
			set;
		}

		public IEnumerable<ServicePactFile> ServicePactFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByContactB {
			get;
			set;
		}

		public IEnumerable<CampaignParticipantOp> CampaignParticipantOpCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByQualifiedContact {
			get;
			set;
		}

		public IEnumerable<VwSysAdminUnit> VwSysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysPrcHistoryLog> SysPrcHistoryLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<FeedFile> FeedFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<EventFile> EventFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Product> ProductCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByOrganizer {
			get;
			set;
		}

		public IEnumerable<Document> DocumentCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ConfItemFile> ConfItemFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwAccountRelationship> VwAccountRelationshipCollectionByRelatedContact {
			get;
			set;
		}

		public IEnumerable<ServicePact> ServicePactCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<CaseFile> CaseFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwBulkEmailClickedLink> VwBulkEmailClickedLinkCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EventTarget> EventTargetCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Case> CaseCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Case> CaseCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactCorrespondence> ContactCorrespondenceCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Account> AccountCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Problem> ProblemCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Employee> EmployeeCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ServiceItemFile> ServiceItemFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysWorkspace> SysWorkspaceCollectionByBuildODataStartedBy {
			get;
			set;
		}

		public IEnumerable<SysProcessLog> SysProcessLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ContactInternalRate> ContactInternalRateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CampaignPlannerFile> CampaignPlannerFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ExternalAccessRequestLog> ExternalAccessRequestLogCollectionByRequestedBy {
			get;
			set;
		}

		public IEnumerable<LeadQualification> LeadQualificationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionBySalesOwner {
			get;
			set;
		}

		public IEnumerable<SysProfileData> SysProfileDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<BulkEmailRecipientMacro> BulkEmailRecipientMacroCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Order> OrderCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<LocationHistory> LocationHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Favorites> FavoritesCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysRegistrationData> SysRegistrationDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Certificate> CertificateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<VwQueueItem> VwQueueItemCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Account> AccountCollectionByPrimaryContact {
			get;
			set;
		}

		public IEnumerable<ServicePact> ServicePactCollectionByServiceProviderContact {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByPartnerOwner {
			get;
			set;
		}

		public IEnumerable<SiteEventTypeFile> SiteEventTypeFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Contact> ContactCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwBulkEmailAudience> VwBulkEmailAudienceCollectionByLinkedEntity {
			get;
			set;
		}

		public IEnumerable<VwContactDuplicate> VwContactDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<ContractFile> ContractFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ServiceObject> ServiceObjectCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactsProductInterest> ContactsProductInterestCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactDuplicate> ContactDuplicateCollectionByEntity1 {
			get;
			set;
		}

		public IEnumerable<EsnNotificationSettings> EsnNotificationSettingsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CampaignQueue> CampaignQueueCollectionByContact {
			get;
			set;
		}

		public IEnumerable<PartnershipFile> PartnershipFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<BulkEmailTarget> BulkEmailTargetCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactExternalRate> ContactExternalRateCollectionByContact {
			get;
			set;
		}

		public IEnumerable<BulkEmailSplitFile> BulkEmailSplitFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Event> EventCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Case> CaseCollectionByHolder {
			get;
			set;
		}

		public IEnumerable<EducationActivity> EducationActivityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OmniChat> OmniChatCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Reminding> RemindingCollectionByContact {
			get;
			set;
		}

		public IEnumerable<BETArchiveSecondGeneration> BETArchiveSecondGenerationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwSspAdminUnit> VwSspAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSysProcessElementLog> VwSysProcessElementLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwAnniversary> VwAnniversaryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysOperationAuditArch> SysOperationAuditArchCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByContactB {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByContact {
			get;
			set;
		}

		public IEnumerable<DayOff> DayOffCollectionByContact {
			get;
			set;
		}

		public IEnumerable<MktgActivity> MktgActivityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<CampaignFile> CampaignFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<OrderFile> OrderFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<AccountFile> AccountFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<OpportunityParticipant> OpportunityParticipantCollectionByContact {
			get;
			set;
		}

		public IEnumerable<File> FileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ConfItemUser> ConfItemUserCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactInTag> ContactInTagCollectionByEntity {
			get;
			set;
		}

		public IEnumerable<ContactAnniversary> ContactAnniversaryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwContactDuplicate> VwContactDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<ContactCareer> ContactCareerCollectionByContact {
			get;
			set;
		}

		public IEnumerable<BulkEmailFile> BulkEmailFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SysProcessData> SysProcessDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwMandrillRecipient> VwMandrillRecipientCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactFile> ContactFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByChiefAccountant {
			get;
			set;
		}

		public IEnumerable<BulkEmail> BulkEmailCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwSiteEvent> VwSiteEventCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ProblemFile> ProblemFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Employee> EmployeeCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Relationship> RelationshipCollectionByContactA {
			get;
			set;
		}

		public IEnumerable<EnrchRejectedData> EnrchRejectedDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwVisa> VwVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<InvoiceFile> InvoiceFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwProcessLibFile> VwProcessLibFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingCollectionByContact {
			get;
			set;
		}

		public IEnumerable<WebServiceV2File> WebServiceV2FileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ConfItem> ConfItemCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<WebFormData> WebFormDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<WSysAccount> WSysAccountCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwBulkEmailTarget> VwBulkEmailTargetCollectionByContact {
			get;
			set;
		}

		public IEnumerable<GeneratedWebFormFile> GeneratedWebFormFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Lead> LeadCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionBySenderContact {
			get;
			set;
		}

		public IEnumerable<ExternalAccessFile> ExternalAccessFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwModuleHistory> VwModuleHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ReleaseFile> ReleaseFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<ActivityParticipant> ActivityParticipantCollectionByParticipant {
			get;
			set;
		}

		public IEnumerable<EventTeam> EventTeamCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactAddress> ContactAddressCollectionByContact {
			get;
			set;
		}

		public IEnumerable<AccountOrganizationChart> AccountOrganizationChartCollectionByManager {
			get;
			set;
		}

		public IEnumerable<VwSysProcessLog> VwSysProcessLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwMandrillRecipientV2> VwMandrillRecipientV2CollectionByContact {
			get;
			set;
		}

		public IEnumerable<SamlResponse> SamlResponseCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwContactRelationship> VwContactRelationshipCollectionByRelatedContact {
			get;
			set;
		}

		public IEnumerable<EnrchFoundContact> EnrchFoundContactCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Call> CallCollectionByContact {
			get;
			set;
		}

		public IEnumerable<FormSubmit> FormSubmitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Invoice> InvoiceCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<QueueItem> QueueItemCollectionByOperator {
			get;
			set;
		}

		public IEnumerable<VwQueueItem> VwQueueItemCollectionByOperator {
			get;
			set;
		}

		public IEnumerable<VwServiceRecepients> VwServiceRecepientsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<QueueOperator> QueueOperatorCollectionByOperator {
			get;
			set;
		}

		public IEnumerable<VwSysProcessFile> VwSysProcessFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<BulkEmailSplitTarget> BulkEmailSplitTargetCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Touch> TouchCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OpportunityDepartment> OpportunityDepartmentCollectionBySalesDirector {
			get;
			set;
		}

		public IEnumerable<Opportunity> OpportunityCollectionByDecisionMaker {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OAuth20AppFile> OAuth20AppFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Like> LikeCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EmailTemplateFile> EmailTemplateFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysProcessElementLog> SysProcessElementLogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ContactFile> ContactFileCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwGroupSysAdminUnit> VwGroupSysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysApproval> SysApprovalCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<VwRelationship> VwRelationshipCollectionByContactA {
			get;
			set;
		}

		public IEnumerable<VwRemindings> VwRemindingsCollectionByContact {
			get;
			set;
		}

		public IEnumerable<OpportunityContact> OpportunityContactCollectionByContact {
			get;
			set;
		}

		public IEnumerable<DocumentFile> DocumentFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<GeneratedWebForm> GeneratedWebFormCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ActivityFile> ActivityFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Problem> ProblemCollectionByAuthor {
			get;
			set;
		}

		public IEnumerable<MktgActivityFile> MktgActivityFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<CallFile> CallFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysAdminUnit> SysAdminUnitCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwSysProcessMILog> VwSysProcessMILogCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<PortalMessageFile> PortalMessageFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysProcessElementData> SysProcessElementDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<EmployeeFile> EmployeeFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ContentBlockFile> ContentBlockFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ESNNotification> ESNNotificationCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<LeadInQualifyStatus> LeadInQualifyStatusCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<AccountBillingInfo> AccountBillingInfoCollectionByAccountManager {
			get;
			set;
		}

		public IEnumerable<BulkEmailSplit> BulkEmailSplitCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OpportunityVisa> OpportunityVisaCollectionBySetBy {
			get;
			set;
		}

		public IEnumerable<EnrchProcessedData> EnrchProcessedDataCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactInFolder> ContactInFolderCollectionByContact {
			get;
			set;
		}

		public IEnumerable<EmailMessageData> EmailMessageDataCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Campaign> CampaignCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ChangeFile> ChangeFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ProductFile> ProductFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<VwSystemUsers> VwSystemUsersCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CampaignSignal> CampaignSignalCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Contract> ContractCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<Project> ProjectCollectionByContact {
			get;
			set;
		}

		public IEnumerable<MailboxSettingsFile> MailboxSettingsFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<FileLead> FileLeadCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SocialMention> SocialMentionCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactDuplicate> ContactDuplicateCollectionByEntity2 {
			get;
			set;
		}

		public IEnumerable<VwContactModuleHistory> VwContactModuleHistoryCollectionByContact {
			get;
			set;
		}

		public IEnumerable<KnowledgeBaseFile> KnowledgeBaseFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ExternalAccess> ExternalAccessCollectionByGrantor {
			get;
			set;
		}

		public IEnumerable<Comment> CommentCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CTISearchResult> CTISearchResultCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ContactCommunication> ContactCommunicationCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysFile> SysFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysProcessFile> SysProcessFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<SysOperationAudit> SysOperationAuditCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<TrackingProject> TrackingProjectCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<SiteEvent> SiteEventCollectionByContact {
			get;
			set;
		}

		public IEnumerable<ProjectFile> ProjectFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<MLModelFile> MLModelFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<ProjectResourceElement> ProjectResourceElementCollectionByContact {
			get;
			set;
		}

		public IEnumerable<CampaignTarget> CampaignTargetCollectionByContact {
			get;
			set;
		}

		public IEnumerable<Activity> ActivityCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<ContactIdentity> ContactIdentityCollectionByContact {
			get;
			set;
		}

		public IEnumerable<VwRemindingsCount> VwRemindingsCountCollectionByContact {
			get;
			set;
		}

		public IEnumerable<SysGridPageView> SysGridPageViewCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<OpportunityFile> OpportunityFileCollectionByLockedBy {
			get;
			set;
		}

		public IEnumerable<CampaignPlanner> CampaignPlannerCollectionByOwner {
			get;
			set;
		}

		public IEnumerable<VwProcessDashboard> VwProcessDashboardCollectionByProcessOwner {
			get;
			set;
		}

		public IEnumerable<ServiceItem> ServiceItemCollectionByOwner {
			get;
			set;
		}

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Full name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = new Contact(LookupColumnEntities.GetEntity("Owner")));
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid CreatedById {
			get {
				return GetTypedColumnValue<Guid>("CreatedById");
			}
			set {
				SetColumnValue("CreatedById", value);
				_createdBy = null;
			}
		}

		/// <exclude/>
		public string CreatedByName {
			get {
				return GetTypedColumnValue<string>("CreatedByName");
			}
			set {
				SetColumnValue("CreatedByName", value);
				if (_createdBy != null) {
					_createdBy.Name = value;
				}
			}
		}

		private Contact _createdBy;
		/// <summary>
		/// Created by.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <exclude/>
		public Guid ModifiedById {
			get {
				return GetTypedColumnValue<Guid>("ModifiedById");
			}
			set {
				SetColumnValue("ModifiedById", value);
				_modifiedBy = null;
			}
		}

		/// <exclude/>
		public string ModifiedByName {
			get {
				return GetTypedColumnValue<string>("ModifiedByName");
			}
			set {
				SetColumnValue("ModifiedByName", value);
				if (_modifiedBy != null) {
					_modifiedBy.Name = value;
				}
			}
		}

		private Contact _modifiedBy;
		/// <summary>
		/// Modified by.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// Active processes.
		/// </summary>
		public int ProcessListeners {
			get {
				return GetTypedColumnValue<int>("ProcessListeners");
			}
			set {
				SetColumnValue("ProcessListeners", value);
			}
		}

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string Dear {
			get {
				return GetTypedColumnValue<string>("Dear");
			}
			set {
				SetColumnValue("Dear", value);
			}
		}

		/// <exclude/>
		public Guid SalutationTypeId {
			get {
				return GetTypedColumnValue<Guid>("SalutationTypeId");
			}
			set {
				SetColumnValue("SalutationTypeId", value);
				_salutationType = null;
			}
		}

		/// <exclude/>
		public string SalutationTypeName {
			get {
				return GetTypedColumnValue<string>("SalutationTypeName");
			}
			set {
				SetColumnValue("SalutationTypeName", value);
				if (_salutationType != null) {
					_salutationType.Name = value;
				}
			}
		}

		private ContactSalutationType _salutationType;
		/// <summary>
		/// Title.
		/// </summary>
		public ContactSalutationType SalutationType {
			get {
				return _salutationType ??
					(_salutationType = new ContactSalutationType(LookupColumnEntities.GetEntity("SalutationType")));
			}
		}

		/// <exclude/>
		public Guid GenderId {
			get {
				return GetTypedColumnValue<Guid>("GenderId");
			}
			set {
				SetColumnValue("GenderId", value);
				_gender = null;
			}
		}

		/// <exclude/>
		public string GenderName {
			get {
				return GetTypedColumnValue<string>("GenderName");
			}
			set {
				SetColumnValue("GenderName", value);
				if (_gender != null) {
					_gender.Name = value;
				}
			}
		}

		private Gender _gender;
		/// <summary>
		/// Gender.
		/// </summary>
		public Gender Gender {
			get {
				return _gender ??
					(_gender = new Gender(LookupColumnEntities.GetEntity("Gender")));
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = new Account(LookupColumnEntities.GetEntity("Account")));
			}
		}

		/// <exclude/>
		public Guid DecisionRoleId {
			get {
				return GetTypedColumnValue<Guid>("DecisionRoleId");
			}
			set {
				SetColumnValue("DecisionRoleId", value);
				_decisionRole = null;
			}
		}

		/// <exclude/>
		public string DecisionRoleName {
			get {
				return GetTypedColumnValue<string>("DecisionRoleName");
			}
			set {
				SetColumnValue("DecisionRoleName", value);
				if (_decisionRole != null) {
					_decisionRole.Name = value;
				}
			}
		}

		private ContactDecisionRole _decisionRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole DecisionRole {
			get {
				return _decisionRole ??
					(_decisionRole = new ContactDecisionRole(LookupColumnEntities.GetEntity("DecisionRole")));
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private ContactType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ContactType Type {
			get {
				return _type ??
					(_type = new ContactType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid JobId {
			get {
				return GetTypedColumnValue<Guid>("JobId");
			}
			set {
				SetColumnValue("JobId", value);
				_job = null;
			}
		}

		/// <exclude/>
		public string JobName {
			get {
				return GetTypedColumnValue<string>("JobName");
			}
			set {
				SetColumnValue("JobName", value);
				if (_job != null) {
					_job.Name = value;
				}
			}
		}

		private Job _job;
		/// <summary>
		/// Job title.
		/// </summary>
		public Job Job {
			get {
				return _job ??
					(_job = new Job(LookupColumnEntities.GetEntity("Job")));
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string JobTitle {
			get {
				return GetTypedColumnValue<string>("JobTitle");
			}
			set {
				SetColumnValue("JobTitle", value);
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Department _department;
		/// <summary>
		/// Department.
		/// </summary>
		public Department Department {
			get {
				return _department ??
					(_department = new Department(LookupColumnEntities.GetEntity("Department")));
			}
		}

		/// <summary>
		/// Birth date.
		/// </summary>
		public DateTime BirthDate {
			get {
				return GetTypedColumnValue<DateTime>("BirthDate");
			}
			set {
				SetColumnValue("BirthDate", value);
			}
		}

		/// <summary>
		/// Business phone.
		/// </summary>
		public string Phone {
			get {
				return GetTypedColumnValue<string>("Phone");
			}
			set {
				SetColumnValue("Phone", value);
			}
		}

		/// <summary>
		/// Mobile phone.
		/// </summary>
		public string MobilePhone {
			get {
				return GetTypedColumnValue<string>("MobilePhone");
			}
			set {
				SetColumnValue("MobilePhone", value);
			}
		}

		/// <summary>
		/// Home phone.
		/// </summary>
		public string HomePhone {
			get {
				return GetTypedColumnValue<string>("HomePhone");
			}
			set {
				SetColumnValue("HomePhone", value);
			}
		}

		/// <summary>
		/// Skype.
		/// </summary>
		public string Skype {
			get {
				return GetTypedColumnValue<string>("Skype");
			}
			set {
				SetColumnValue("Skype", value);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <exclude/>
		public Guid AddressTypeId {
			get {
				return GetTypedColumnValue<Guid>("AddressTypeId");
			}
			set {
				SetColumnValue("AddressTypeId", value);
				_addressType = null;
			}
		}

		/// <exclude/>
		public string AddressTypeName {
			get {
				return GetTypedColumnValue<string>("AddressTypeName");
			}
			set {
				SetColumnValue("AddressTypeName", value);
				if (_addressType != null) {
					_addressType.Name = value;
				}
			}
		}

		private AddressType _addressType;
		/// <summary>
		/// Address type.
		/// </summary>
		public AddressType AddressType {
			get {
				return _addressType ??
					(_addressType = new AddressType(LookupColumnEntities.GetEntity("AddressType")));
			}
		}

		/// <summary>
		/// Address.
		/// </summary>
		public string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		/// <exclude/>
		public Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public City City {
			get {
				return _city ??
					(_city = new City(LookupColumnEntities.GetEntity("City")));
			}
		}

		/// <exclude/>
		public Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// State/province.
		/// </summary>
		public Region Region {
			get {
				return _region ??
					(_region = new Region(LookupColumnEntities.GetEntity("Region")));
			}
		}

		/// <summary>
		/// ZIP/postal code.
		/// </summary>
		public string Zip {
			get {
				return GetTypedColumnValue<string>("Zip");
			}
			set {
				SetColumnValue("Zip", value);
			}
		}

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = new Country(LookupColumnEntities.GetEntity("Country")));
			}
		}

		/// <summary>
		/// Do not use email.
		/// </summary>
		public bool DoNotUseEmail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseEmail");
			}
			set {
				SetColumnValue("DoNotUseEmail", value);
			}
		}

		/// <summary>
		/// Do not use phone.
		/// </summary>
		public bool DoNotUseCall {
			get {
				return GetTypedColumnValue<bool>("DoNotUseCall");
			}
			set {
				SetColumnValue("DoNotUseCall", value);
			}
		}

		/// <summary>
		/// Do not use fax.
		/// </summary>
		public bool DoNotUseFax {
			get {
				return GetTypedColumnValue<bool>("DoNotUseFax");
			}
			set {
				SetColumnValue("DoNotUseFax", value);
			}
		}

		/// <summary>
		/// Do not use SMS.
		/// </summary>
		public bool DoNotUseSms {
			get {
				return GetTypedColumnValue<bool>("DoNotUseSms");
			}
			set {
				SetColumnValue("DoNotUseSms", value);
			}
		}

		/// <summary>
		/// Do not use mail.
		/// </summary>
		public bool DoNotUseMail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseMail");
			}
			set {
				SetColumnValue("DoNotUseMail", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <summary>
		/// Facebook.
		/// </summary>
		public string Facebook {
			get {
				return GetTypedColumnValue<string>("Facebook");
			}
			set {
				SetColumnValue("Facebook", value);
			}
		}

		/// <summary>
		/// LinkedIn.
		/// </summary>
		public string LinkedIn {
			get {
				return GetTypedColumnValue<string>("LinkedIn");
			}
			set {
				SetColumnValue("LinkedIn", value);
			}
		}

		/// <summary>
		/// Twitter.
		/// </summary>
		public string Twitter {
			get {
				return GetTypedColumnValue<string>("Twitter");
			}
			set {
				SetColumnValue("Twitter", value);
			}
		}

		/// <summary>
		/// FacebookId.
		/// </summary>
		public string FacebookId {
			get {
				return GetTypedColumnValue<string>("FacebookId");
			}
			set {
				SetColumnValue("FacebookId", value);
			}
		}

		/// <summary>
		/// LinkedInId.
		/// </summary>
		public string LinkedInId {
			get {
				return GetTypedColumnValue<string>("LinkedInId");
			}
			set {
				SetColumnValue("LinkedInId", value);
			}
		}

		/// <summary>
		/// TwitterId.
		/// </summary>
		public string TwitterId {
			get {
				return GetTypedColumnValue<string>("TwitterId");
			}
			set {
				SetColumnValue("TwitterId", value);
			}
		}

		/// <exclude/>
		public Guid TwitterAFDAId {
			get {
				return GetTypedColumnValue<Guid>("TwitterAFDAId");
			}
			set {
				SetColumnValue("TwitterAFDAId", value);
				_twitterAFDA = null;
			}
		}

		/// <exclude/>
		public string TwitterAFDALogin {
			get {
				return GetTypedColumnValue<string>("TwitterAFDALogin");
			}
			set {
				SetColumnValue("TwitterAFDALogin", value);
				if (_twitterAFDA != null) {
					_twitterAFDA.Login = value;
				}
			}
		}

		private SocialAccount _twitterAFDA;
		/// <summary>
		/// Twitter Account for Data Access.
		/// </summary>
		/// <remarks>
		/// Twitter Account for Data Access.
		/// </remarks>
		public SocialAccount TwitterAFDA {
			get {
				return _twitterAFDA ??
					(_twitterAFDA = new SocialAccount(LookupColumnEntities.GetEntity("TwitterAFDA")));
			}
		}

		/// <exclude/>
		public Guid FacebookAFDAId {
			get {
				return GetTypedColumnValue<Guid>("FacebookAFDAId");
			}
			set {
				SetColumnValue("FacebookAFDAId", value);
				_facebookAFDA = null;
			}
		}

		/// <exclude/>
		public string FacebookAFDALogin {
			get {
				return GetTypedColumnValue<string>("FacebookAFDALogin");
			}
			set {
				SetColumnValue("FacebookAFDALogin", value);
				if (_facebookAFDA != null) {
					_facebookAFDA.Login = value;
				}
			}
		}

		private SocialAccount _facebookAFDA;
		/// <summary>
		/// Facebook Account for Data Access.
		/// </summary>
		/// <remarks>
		/// Facebook Account for Data Access.
		/// </remarks>
		public SocialAccount FacebookAFDA {
			get {
				return _facebookAFDA ??
					(_facebookAFDA = new SocialAccount(LookupColumnEntities.GetEntity("FacebookAFDA")));
			}
		}

		/// <exclude/>
		public Guid LinkedInAFDAId {
			get {
				return GetTypedColumnValue<Guid>("LinkedInAFDAId");
			}
			set {
				SetColumnValue("LinkedInAFDAId", value);
				_linkedInAFDA = null;
			}
		}

		/// <exclude/>
		public string LinkedInAFDALogin {
			get {
				return GetTypedColumnValue<string>("LinkedInAFDALogin");
			}
			set {
				SetColumnValue("LinkedInAFDALogin", value);
				if (_linkedInAFDA != null) {
					_linkedInAFDA.Login = value;
				}
			}
		}

		private SocialAccount _linkedInAFDA;
		/// <summary>
		/// LinkedIn Account for Data Access.
		/// </summary>
		/// <remarks>
		/// LinkedIn Account for Data Access.
		/// </remarks>
		public SocialAccount LinkedInAFDA {
			get {
				return _linkedInAFDA ??
					(_linkedInAFDA = new SocialAccount(LookupColumnEntities.GetEntity("LinkedInAFDA")));
			}
		}

		/// <exclude/>
		public Guid PhotoId {
			get {
				return GetTypedColumnValue<Guid>("PhotoId");
			}
			set {
				SetColumnValue("PhotoId", value);
				_photo = null;
			}
		}

		/// <exclude/>
		public string PhotoName {
			get {
				return GetTypedColumnValue<string>("PhotoName");
			}
			set {
				SetColumnValue("PhotoName", value);
				if (_photo != null) {
					_photo.Name = value;
				}
			}
		}

		private SysImage _photo;
		/// <summary>
		/// Photo.
		/// </summary>
		public SysImage Photo {
			get {
				return _photo ??
					(_photo = new SysImage(LookupColumnEntities.GetEntity("Photo")));
			}
		}

		/// <summary>
		/// GPS N.
		/// </summary>
		public string GPSN {
			get {
				return GetTypedColumnValue<string>("GPSN");
			}
			set {
				SetColumnValue("GPSN", value);
			}
		}

		/// <summary>
		/// GPS E.
		/// </summary>
		public string GPSE {
			get {
				return GetTypedColumnValue<string>("GPSE");
			}
			set {
				SetColumnValue("GPSE", value);
			}
		}

		/// <summary>
		/// Last name.
		/// </summary>
		public string Surname {
			get {
				return GetTypedColumnValue<string>("Surname");
			}
			set {
				SetColumnValue("Surname", value);
			}
		}

		/// <summary>
		/// First name.
		/// </summary>
		public string GivenName {
			get {
				return GetTypedColumnValue<string>("GivenName");
			}
			set {
				SetColumnValue("GivenName", value);
			}
		}

		/// <summary>
		/// Middle name.
		/// </summary>
		public string MiddleName {
			get {
				return GetTypedColumnValue<string>("MiddleName");
			}
			set {
				SetColumnValue("MiddleName", value);
			}
		}

		/// <summary>
		/// Confirmed.
		/// </summary>
		public bool Confirmed {
			get {
				return GetTypedColumnValue<bool>("Confirmed");
			}
			set {
				SetColumnValue("Confirmed", value);
			}
		}

		/// <summary>
		/// Invalid email.
		/// </summary>
		public bool IsNonActualEmail {
			get {
				return GetTypedColumnValue<bool>("IsNonActualEmail");
			}
			set {
				SetColumnValue("IsNonActualEmail", value);
			}
		}

		/// <summary>
		/// Data entry compliance.
		/// </summary>
		public int Completeness {
			get {
				return GetTypedColumnValue<int>("Completeness");
			}
			set {
				SetColumnValue("Completeness", value);
			}
		}

		/// <exclude/>
		public Guid LanguageId {
			get {
				return GetTypedColumnValue<Guid>("LanguageId");
			}
			set {
				SetColumnValue("LanguageId", value);
				_language = null;
			}
		}

		/// <exclude/>
		public string LanguageName {
			get {
				return GetTypedColumnValue<string>("LanguageName");
			}
			set {
				SetColumnValue("LanguageName", value);
				if (_language != null) {
					_language.Name = value;
				}
			}
		}

		private SysLanguage _language;
		/// <summary>
		/// Preferred language.
		/// </summary>
		public SysLanguage Language {
			get {
				return _language ??
					(_language = new SysLanguage(LookupColumnEntities.GetEntity("Language")));
			}
		}

		/// <summary>
		/// Age.
		/// </summary>
		public int Age {
			get {
				return GetTypedColumnValue<int>("Age");
			}
			set {
				SetColumnValue("Age", value);
			}
		}

		/// <summary>
		/// IsEmailConfirmed.
		/// </summary>
		/// <remarks>
		/// Is Email Confirmed.
		/// </remarks>
		public bool IsEmailConfirmed {
			get {
				return GetTypedColumnValue<bool>("IsEmailConfirmed");
			}
			set {
				SetColumnValue("IsEmailConfirmed", value);
			}
		}

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
					(_adCampaign = new AdCampaign(LookupColumnEntities.GetEntity("AdCampaign")));
			}
		}

		/// <exclude/>
		public Guid CustomerNeedId {
			get {
				return GetTypedColumnValue<Guid>("CustomerNeedId");
			}
			set {
				SetColumnValue("CustomerNeedId", value);
				_customerNeed = null;
			}
		}

		/// <exclude/>
		public string CustomerNeedName {
			get {
				return GetTypedColumnValue<string>("CustomerNeedName");
			}
			set {
				SetColumnValue("CustomerNeedName", value);
				if (_customerNeed != null) {
					_customerNeed.Name = value;
				}
			}
		}

		private LeadType _customerNeed;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType CustomerNeed {
			get {
				return _customerNeed ??
					(_customerNeed = new LeadType(LookupColumnEntities.GetEntity("CustomerNeed")));
			}
		}

		/// <exclude/>
		public Guid ChannelId {
			get {
				return GetTypedColumnValue<Guid>("ChannelId");
			}
			set {
				SetColumnValue("ChannelId", value);
				_channel = null;
			}
		}

		/// <exclude/>
		public string ChannelName {
			get {
				return GetTypedColumnValue<string>("ChannelName");
			}
			set {
				SetColumnValue("ChannelName", value);
				if (_channel != null) {
					_channel.Name = value;
				}
			}
		}

		private LeadMedium _channel;
		/// <summary>
		/// Channel.
		/// </summary>
		public LeadMedium Channel {
			get {
				return _channel ??
					(_channel = new LeadMedium(LookupColumnEntities.GetEntity("Channel")));
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private LeadSource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public LeadSource Source {
			get {
				return _source ??
					(_source = new LeadSource(LookupColumnEntities.GetEntity("Source")));
			}
		}

		/// <exclude/>
		public Guid RegisterMethodId {
			get {
				return GetTypedColumnValue<Guid>("RegisterMethodId");
			}
			set {
				SetColumnValue("RegisterMethodId", value);
				_registerMethod = null;
			}
		}

		/// <exclude/>
		public string RegisterMethodName {
			get {
				return GetTypedColumnValue<string>("RegisterMethodName");
			}
			set {
				SetColumnValue("RegisterMethodName", value);
				if (_registerMethod != null) {
					_registerMethod.Name = value;
				}
			}
		}

		private RegisterMethod _registerMethod;
		/// <summary>
		/// Registration method.
		/// </summary>
		public RegisterMethod RegisterMethod {
			get {
				return _registerMethod ??
					(_registerMethod = new RegisterMethod(LookupColumnEntities.GetEntity("RegisterMethod")));
			}
		}

		/// <summary>
		/// Lead conversion score.
		/// </summary>
		public int LeadConversionScore {
			get {
				return GetTypedColumnValue<int>("LeadConversionScore");
			}
			set {
				SetColumnValue("LeadConversionScore", value);
			}
		}

		#endregion

	}

	#endregion

}

