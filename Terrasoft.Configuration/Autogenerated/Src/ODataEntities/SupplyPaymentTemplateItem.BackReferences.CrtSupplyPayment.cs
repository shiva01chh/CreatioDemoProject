namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: SupplyPaymentTemplateItem

	/// <exclude/>
	public class SupplyPaymentTemplateItem : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentTemplateItem";
		}

		public SupplyPaymentTemplateItem(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "SupplyPaymentTemplateItem";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemCollectionByPreviousElement {
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
		/// Position.
		/// </summary>
		public int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
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

		private SupplyPaymentType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public SupplyPaymentType Type {
			get {
				return _type ??
					(_type = new SupplyPaymentType(LookupColumnEntities.GetEntity("Type")));
			}
		}

		/// <exclude/>
		public Guid DelayTypeId {
			get {
				return GetTypedColumnValue<Guid>("DelayTypeId");
			}
			set {
				SetColumnValue("DelayTypeId", value);
				_delayType = null;
			}
		}

		/// <exclude/>
		public string DelayTypeName {
			get {
				return GetTypedColumnValue<string>("DelayTypeName");
			}
			set {
				SetColumnValue("DelayTypeName", value);
				if (_delayType != null) {
					_delayType.Name = value;
				}
			}
		}

		private SupplyPaymentDelay _delayType;
		/// <summary>
		/// Deferment type.
		/// </summary>
		public SupplyPaymentDelay DelayType {
			get {
				return _delayType ??
					(_delayType = new SupplyPaymentDelay(LookupColumnEntities.GetEntity("DelayType")));
			}
		}

		/// <summary>
		/// Deferment (days).
		/// </summary>
		public int Delay {
			get {
				return GetTypedColumnValue<int>("Delay");
			}
			set {
				SetColumnValue("Delay", value);
			}
		}

		/// <summary>
		/// Percentage, %.
		/// </summary>
		public Decimal Percentage {
			get {
				return GetTypedColumnValue<Decimal>("Percentage");
			}
			set {
				SetColumnValue("Percentage", value);
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

		/// <exclude/>
		public Guid PreviousElementId {
			get {
				return GetTypedColumnValue<Guid>("PreviousElementId");
			}
			set {
				SetColumnValue("PreviousElementId", value);
				_previousElement = null;
			}
		}

		/// <exclude/>
		public string PreviousElementName {
			get {
				return GetTypedColumnValue<string>("PreviousElementName");
			}
			set {
				SetColumnValue("PreviousElementName", value);
				if (_previousElement != null) {
					_previousElement.Name = value;
				}
			}
		}

		private SupplyPaymentTemplateItem _previousElement;
		/// <summary>
		/// Previous entry.
		/// </summary>
		public SupplyPaymentTemplateItem PreviousElement {
			get {
				return _previousElement ??
					(_previousElement = new SupplyPaymentTemplateItem(LookupColumnEntities.GetEntity("PreviousElement")));
			}
		}

		/// <exclude/>
		public Guid SupplyPaymentTemplateId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentTemplateId");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateId", value);
				_supplyPaymentTemplate = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentTemplateName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentTemplateName");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateName", value);
				if (_supplyPaymentTemplate != null) {
					_supplyPaymentTemplate.Name = value;
				}
			}
		}

		private SupplyPaymentTemplate _supplyPaymentTemplate;
		/// <summary>
		/// Installment plan template.
		/// </summary>
		public SupplyPaymentTemplate SupplyPaymentTemplate {
			get {
				return _supplyPaymentTemplate ??
					(_supplyPaymentTemplate = new SupplyPaymentTemplate(LookupColumnEntities.GetEntity("SupplyPaymentTemplate")));
			}
		}

		#endregion

	}

	#endregion

}

