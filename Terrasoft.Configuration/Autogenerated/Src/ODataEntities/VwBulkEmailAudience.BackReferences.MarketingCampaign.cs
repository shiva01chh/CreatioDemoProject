namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwBulkEmailAudience

	/// <exclude/>
	public class VwBulkEmailAudience : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwBulkEmailAudience(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwBulkEmailAudience";
		}

		public VwBulkEmailAudience(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwBulkEmailAudience";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Bulk email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = new BulkEmail(LookupColumnEntities.GetEntity("BulkEmail")));
			}
		}

		/// <exclude/>
		public Guid BulkEmailResponseId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailResponseId");
			}
			set {
				SetColumnValue("BulkEmailResponseId", value);
				_bulkEmailResponse = null;
			}
		}

		/// <exclude/>
		public string BulkEmailResponseName {
			get {
				return GetTypedColumnValue<string>("BulkEmailResponseName");
			}
			set {
				SetColumnValue("BulkEmailResponseName", value);
				if (_bulkEmailResponse != null) {
					_bulkEmailResponse.Name = value;
				}
			}
		}

		private BulkEmailResponse _bulkEmailResponse;
		/// <summary>
		/// Response.
		/// </summary>
		public BulkEmailResponse BulkEmailResponse {
			get {
				return _bulkEmailResponse ??
					(_bulkEmailResponse = new BulkEmailResponse(LookupColumnEntities.GetEntity("BulkEmailResponse")));
			}
		}

		/// <summary>
		/// Clicks.
		/// </summary>
		public int Clicks {
			get {
				return GetTypedColumnValue<int>("Clicks");
			}
			set {
				SetColumnValue("Clicks", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = new Contact(LookupColumnEntities.GetEntity("Contact")));
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

		/// <summary>
		/// Email.
		/// </summary>
		public string EmailAddress {
			get {
				return GetTypedColumnValue<string>("EmailAddress");
			}
			set {
				SetColumnValue("EmailAddress", value);
			}
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
		/// Is sent.
		/// </summary>
		public bool IsSent {
			get {
				return GetTypedColumnValue<bool>("IsSent");
			}
			set {
				SetColumnValue("IsSent", value);
			}
		}

		/// <exclude/>
		public Guid LinkedEntityId {
			get {
				return GetTypedColumnValue<Guid>("LinkedEntityId");
			}
			set {
				SetColumnValue("LinkedEntityId", value);
				_linkedEntity = null;
			}
		}

		/// <exclude/>
		public string LinkedEntityName {
			get {
				return GetTypedColumnValue<string>("LinkedEntityName");
			}
			set {
				SetColumnValue("LinkedEntityName", value);
				if (_linkedEntity != null) {
					_linkedEntity.Name = value;
				}
			}
		}

		private Contact _linkedEntity;
		/// <summary>
		/// Extended entity.
		/// </summary>
		public Contact LinkedEntity {
			get {
				return _linkedEntity ??
					(_linkedEntity = new Contact(LookupColumnEntities.GetEntity("LinkedEntity")));
			}
		}

		/// <summary>
		/// Opens.
		/// </summary>
		public int Opens {
			get {
				return GetTypedColumnValue<int>("Opens");
			}
			set {
				SetColumnValue("Opens", value);
			}
		}

		/// <exclude/>
		public Guid ReplicaId {
			get {
				return GetTypedColumnValue<Guid>("ReplicaId");
			}
			set {
				SetColumnValue("ReplicaId", value);
				_replica = null;
			}
		}

		/// <exclude/>
		public string ReplicaCaption {
			get {
				return GetTypedColumnValue<string>("ReplicaCaption");
			}
			set {
				SetColumnValue("ReplicaCaption", value);
				if (_replica != null) {
					_replica.Caption = value;
				}
			}
		}

		private DCReplica _replica;
		/// <summary>
		/// Dynamic content replica.
		/// </summary>
		public DCReplica Replica {
			get {
				return _replica ??
					(_replica = new DCReplica(LookupColumnEntities.GetEntity("Replica")));
			}
		}

		/// <summary>
		/// Session.
		/// </summary>
		public Guid SessionId {
			get {
				return GetTypedColumnValue<Guid>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		/// <summary>
		/// Modified on.
		/// </summary>
		/// <remarks>
		/// Modified on.
		/// </remarks>
		public DateTime ModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("ModifiedOn");
			}
			set {
				SetColumnValue("ModifiedOn", value);
			}
		}

		/// <summary>
		/// Sending ESP.
		/// </summary>
		public string ProviderName {
			get {
				return GetTypedColumnValue<string>("ProviderName");
			}
			set {
				SetColumnValue("ProviderName", value);
			}
		}

		/// <exclude/>
		public Guid ResponseDetailsId {
			get {
				return GetTypedColumnValue<Guid>("ResponseDetailsId");
			}
			set {
				SetColumnValue("ResponseDetailsId", value);
				_responseDetails = null;
			}
		}

		/// <exclude/>
		public string ResponseDetailsDetails {
			get {
				return GetTypedColumnValue<string>("ResponseDetailsDetails");
			}
			set {
				SetColumnValue("ResponseDetailsDetails", value);
				if (_responseDetails != null) {
					_responseDetails.Details = value;
				}
			}
		}

		private BulkEmailResponseDetails _responseDetails;
		/// <summary>
		/// Reason details.
		/// </summary>
		public BulkEmailResponseDetails ResponseDetails {
			get {
				return _responseDetails ??
					(_responseDetails = new BulkEmailResponseDetails(LookupColumnEntities.GetEntity("ResponseDetails")));
			}
		}

		/// <exclude/>
		public Guid ResponseReasonId {
			get {
				return GetTypedColumnValue<Guid>("ResponseReasonId");
			}
			set {
				SetColumnValue("ResponseReasonId", value);
				_responseReason = null;
			}
		}

		/// <exclude/>
		public string ResponseReasonName {
			get {
				return GetTypedColumnValue<string>("ResponseReasonName");
			}
			set {
				SetColumnValue("ResponseReasonName", value);
				if (_responseReason != null) {
					_responseReason.Name = value;
				}
			}
		}

		private BulkEmailResponseReason _responseReason;
		/// <summary>
		/// Response reason.
		/// </summary>
		public BulkEmailResponseReason ResponseReason {
			get {
				return _responseReason ??
					(_responseReason = new BulkEmailResponseReason(LookupColumnEntities.GetEntity("ResponseReason")));
			}
		}

		#endregion

	}

	#endregion

}

