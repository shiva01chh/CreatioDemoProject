﻿namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: LevelPartnershipParam

	/// <exclude/>
	public class LevelPartnershipParam : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public LevelPartnershipParam(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LevelPartnershipParam";
		}

		public LevelPartnershipParam(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "LevelPartnershipParam";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

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
		/// CreatedOn.
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
		/// CreatedBy.
		/// </summary>
		public Contact CreatedBy {
			get {
				return _createdBy ??
					(_createdBy = new Contact(LookupColumnEntities.GetEntity("CreatedBy")));
			}
		}

		/// <summary>
		/// ModifiedOn.
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
		/// ModifiedBy.
		/// </summary>
		public Contact ModifiedBy {
			get {
				return _modifiedBy ??
					(_modifiedBy = new Contact(LookupColumnEntities.GetEntity("ModifiedBy")));
			}
		}

		/// <summary>
		/// ProcessListeners.
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
		/// Value (string).
		/// </summary>
		public string StringValue {
			get {
				return GetTypedColumnValue<string>("StringValue");
			}
			set {
				SetColumnValue("StringValue", value);
			}
		}

		/// <summary>
		/// Value (integer).
		/// </summary>
		public int IntValue {
			get {
				return GetTypedColumnValue<int>("IntValue");
			}
			set {
				SetColumnValue("IntValue", value);
			}
		}

		/// <summary>
		/// Value (decimal).
		/// </summary>
		public Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Value (Boolean).
		/// </summary>
		public bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Feature.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = new Specification(LookupColumnEntities.GetEntity("Specification")));
			}
		}

		/// <exclude/>
		public Guid ListItemValueId {
			get {
				return GetTypedColumnValue<Guid>("ListItemValueId");
			}
			set {
				SetColumnValue("ListItemValueId", value);
				_listItemValue = null;
			}
		}

		/// <exclude/>
		public string ListItemValueName {
			get {
				return GetTypedColumnValue<string>("ListItemValueName");
			}
			set {
				SetColumnValue("ListItemValueName", value);
				if (_listItemValue != null) {
					_listItemValue.Name = value;
				}
			}
		}

		private SpecificationListItem _listItemValue;
		/// <summary>
		/// Value (drop-down list).
		/// </summary>
		public SpecificationListItem ListItemValue {
			get {
				return _listItemValue ??
					(_listItemValue = new SpecificationListItem(LookupColumnEntities.GetEntity("ListItemValue")));
			}
		}

		/// <exclude/>
		public Guid ParameterTypeId {
			get {
				return GetTypedColumnValue<Guid>("ParameterTypeId");
			}
			set {
				SetColumnValue("ParameterTypeId", value);
				_parameterType = null;
			}
		}

		/// <exclude/>
		public string ParameterTypeName {
			get {
				return GetTypedColumnValue<string>("ParameterTypeName");
			}
			set {
				SetColumnValue("ParameterTypeName", value);
				if (_parameterType != null) {
					_parameterType.Name = value;
				}
			}
		}

		private ParameterType _parameterType;
		/// <summary>
		/// Parameter Type.
		/// </summary>
		public ParameterType ParameterType {
			get {
				return _parameterType ??
					(_parameterType = new ParameterType(LookupColumnEntities.GetEntity("ParameterType")));
			}
		}

		/// <exclude/>
		public Guid PartnerParamCategoryId {
			get {
				return GetTypedColumnValue<Guid>("PartnerParamCategoryId");
			}
			set {
				SetColumnValue("PartnerParamCategoryId", value);
				_partnerParamCategory = null;
			}
		}

		/// <exclude/>
		public string PartnerParamCategoryName {
			get {
				return GetTypedColumnValue<string>("PartnerParamCategoryName");
			}
			set {
				SetColumnValue("PartnerParamCategoryName", value);
				if (_partnerParamCategory != null) {
					_partnerParamCategory.Name = value;
				}
			}
		}

		private PartnerParamCategory _partnerParamCategory;
		/// <summary>
		/// Partner Param Category.
		/// </summary>
		public PartnerParamCategory PartnerParamCategory {
			get {
				return _partnerParamCategory ??
					(_partnerParamCategory = new PartnerParamCategory(LookupColumnEntities.GetEntity("PartnerParamCategory")));
			}
		}

		/// <summary>
		/// Score.
		/// </summary>
		public int Score {
			get {
				return GetTypedColumnValue<int>("Score");
			}
			set {
				SetColumnValue("Score", value);
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
		/// StartDate.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// DueDate.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid PartnerLevelId {
			get {
				return GetTypedColumnValue<Guid>("PartnerLevelId");
			}
			set {
				SetColumnValue("PartnerLevelId", value);
				_partnerLevel = null;
			}
		}

		/// <exclude/>
		public string PartnerLevelName {
			get {
				return GetTypedColumnValue<string>("PartnerLevelName");
			}
			set {
				SetColumnValue("PartnerLevelName", value);
				if (_partnerLevel != null) {
					_partnerLevel.Name = value;
				}
			}
		}

		private PartnerLevel _partnerLevel;
		/// <summary>
		/// Partner Level.
		/// </summary>
		public PartnerLevel PartnerLevel {
			get {
				return _partnerLevel ??
					(_partnerLevel = new PartnerLevel(LookupColumnEntities.GetEntity("PartnerLevel")));
			}
		}

		/// <exclude/>
		public Guid ParameterValueTypeId {
			get {
				return GetTypedColumnValue<Guid>("ParameterValueTypeId");
			}
			set {
				SetColumnValue("ParameterValueTypeId", value);
				_parameterValueType = null;
			}
		}

		/// <exclude/>
		public string ParameterValueTypeName {
			get {
				return GetTypedColumnValue<string>("ParameterValueTypeName");
			}
			set {
				SetColumnValue("ParameterValueTypeName", value);
				if (_parameterValueType != null) {
					_parameterValueType.Name = value;
				}
			}
		}

		private SpecificationType _parameterValueType;
		/// <summary>
		/// Parameter value type.
		/// </summary>
		public SpecificationType ParameterValueType {
			get {
				return _parameterValueType ??
					(_parameterValueType = new SpecificationType(LookupColumnEntities.GetEntity("ParameterValueType")));
			}
		}

		/// <summary>
		/// Value (GUID).
		/// </summary>
		public Guid GuidValue {
			get {
				return GetTypedColumnValue<Guid>("GuidValue");
			}
			set {
				SetColumnValue("GuidValue", value);
			}
		}

		#endregion

	}

	#endregion

}

