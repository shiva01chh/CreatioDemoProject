namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: EducationActivity

	/// <exclude/>
	public class EducationActivity : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public EducationActivity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EducationActivity";
		}

		public EducationActivity(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "EducationActivity";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Certificate> CertificateCollectionByEducationActivity {
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
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <exclude/>
		public Guid EducationActivityTypeId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityTypeId");
			}
			set {
				SetColumnValue("EducationActivityTypeId", value);
				_educationActivityType = null;
			}
		}

		/// <exclude/>
		public string EducationActivityTypeName {
			get {
				return GetTypedColumnValue<string>("EducationActivityTypeName");
			}
			set {
				SetColumnValue("EducationActivityTypeName", value);
				if (_educationActivityType != null) {
					_educationActivityType.Name = value;
				}
			}
		}

		private EduActivityType _educationActivityType;
		/// <summary>
		/// Type.
		/// </summary>
		public EduActivityType EducationActivityType {
			get {
				return _educationActivityType ??
					(_educationActivityType = new EduActivityType(LookupColumnEntities.GetEntity("EducationActivityType")));
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
		/// Cost.
		/// </summary>
		public Decimal Cost {
			get {
				return GetTypedColumnValue<Decimal>("Cost");
			}
			set {
				SetColumnValue("Cost", value);
			}
		}

		/// <summary>
		/// Event date.
		/// </summary>
		public DateTime Date {
			get {
				return GetTypedColumnValue<DateTime>("Date");
			}
			set {
				SetColumnValue("Date", value);
			}
		}

		/// <exclude/>
		public Guid EducationActivityResultId {
			get {
				return GetTypedColumnValue<Guid>("EducationActivityResultId");
			}
			set {
				SetColumnValue("EducationActivityResultId", value);
				_educationActivityResult = null;
			}
		}

		/// <exclude/>
		public string EducationActivityResultName {
			get {
				return GetTypedColumnValue<string>("EducationActivityResultName");
			}
			set {
				SetColumnValue("EducationActivityResultName", value);
				if (_educationActivityResult != null) {
					_educationActivityResult.Name = value;
				}
			}
		}

		private EduActivityResult _educationActivityResult;
		/// <summary>
		/// Result .
		/// </summary>
		public EduActivityResult EducationActivityResult {
			get {
				return _educationActivityResult ??
					(_educationActivityResult = new EduActivityResult(LookupColumnEntities.GetEntity("EducationActivityResult")));
			}
		}

		/// <exclude/>
		public Guid StatusOfActivityId {
			get {
				return GetTypedColumnValue<Guid>("StatusOfActivityId");
			}
			set {
				SetColumnValue("StatusOfActivityId", value);
				_statusOfActivity = null;
			}
		}

		/// <exclude/>
		public string StatusOfActivityName {
			get {
				return GetTypedColumnValue<string>("StatusOfActivityName");
			}
			set {
				SetColumnValue("StatusOfActivityName", value);
				if (_statusOfActivity != null) {
					_statusOfActivity.Name = value;
				}
			}
		}

		private EduActivityStatus _statusOfActivity;
		/// <summary>
		/// Status.
		/// </summary>
		public EduActivityStatus StatusOfActivity {
			get {
				return _statusOfActivity ??
					(_statusOfActivity = new EduActivityStatus(LookupColumnEntities.GetEntity("StatusOfActivity")));
			}
		}

		/// <exclude/>
		public Guid PaymentMethodId {
			get {
				return GetTypedColumnValue<Guid>("PaymentMethodId");
			}
			set {
				SetColumnValue("PaymentMethodId", value);
				_paymentMethod = null;
			}
		}

		/// <exclude/>
		public string PaymentMethodName {
			get {
				return GetTypedColumnValue<string>("PaymentMethodName");
			}
			set {
				SetColumnValue("PaymentMethodName", value);
				if (_paymentMethod != null) {
					_paymentMethod.Name = value;
				}
			}
		}

		private PaymentMethod _paymentMethod;
		/// <summary>
		/// Payment method.
		/// </summary>
		public PaymentMethod PaymentMethod {
			get {
				return _paymentMethod ??
					(_paymentMethod = new PaymentMethod(LookupColumnEntities.GetEntity("PaymentMethod")));
			}
		}

		#endregion

	}

	#endregion

}

