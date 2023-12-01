namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: ForecastSheet

	/// <exclude/>
	public class ForecastSheet : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public ForecastSheet(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastSheet";
		}

		public ForecastSheet(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "ForecastSheet";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<AccountForecast> AccountForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ContactForecast> ContactForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ForecastColumn> ForecastColumnCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ForecastHistoryCell> ForecastHistoryCellCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ForecastHistoryRow> ForecastHistoryRowCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ForecastSnapshot> ForecastSnapshotCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<LeadTypeForecast> LeadTypeForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<OppDepartmentForecast> OppDepartmentForecastCollectionBySheet {
			get;
			set;
		}

		public IEnumerable<ProductForecast> ProductForecastCollectionBySheet {
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

		/// <exclude/>
		public Guid PeriodTypeId {
			get {
				return GetTypedColumnValue<Guid>("PeriodTypeId");
			}
			set {
				SetColumnValue("PeriodTypeId", value);
				_periodType = null;
			}
		}

		/// <exclude/>
		public string PeriodTypeName {
			get {
				return GetTypedColumnValue<string>("PeriodTypeName");
			}
			set {
				SetColumnValue("PeriodTypeName", value);
				if (_periodType != null) {
					_periodType.Name = value;
				}
			}
		}

		private PeriodType _periodType;
		/// <summary>
		/// Period type.
		/// </summary>
		public PeriodType PeriodType {
			get {
				return _periodType ??
					(_periodType = new PeriodType(LookupColumnEntities.GetEntity("PeriodType")));
			}
		}

		/// <exclude/>
		public Guid ForecastEntityId {
			get {
				return GetTypedColumnValue<Guid>("ForecastEntityId");
			}
			set {
				SetColumnValue("ForecastEntityId", value);
				_forecastEntity = null;
			}
		}

		/// <exclude/>
		public string ForecastEntityTitle {
			get {
				return GetTypedColumnValue<string>("ForecastEntityTitle");
			}
			set {
				SetColumnValue("ForecastEntityTitle", value);
				if (_forecastEntity != null) {
					_forecastEntity.Title = value;
				}
			}
		}

		private VwEntityObjects _forecastEntity;
		/// <summary>
		/// Forecast entity.
		/// </summary>
		public VwEntityObjects ForecastEntity {
			get {
				return _forecastEntity ??
					(_forecastEntity = new VwEntityObjects(LookupColumnEntities.GetEntity("ForecastEntity")));
			}
		}

		/// <summary>
		/// UId of schema that contains forecast data.
		/// </summary>
		public Guid ForecastEntityInCellUId {
			get {
				return GetTypedColumnValue<Guid>("ForecastEntityInCellUId");
			}
			set {
				SetColumnValue("ForecastEntityInCellUId", value);
			}
		}

		/// <summary>
		/// Forecast setting.
		/// </summary>
		public string Setting {
			get {
				return GetTypedColumnValue<string>("Setting");
			}
			set {
				SetColumnValue("Setting", value);
			}
		}

		/// <summary>
		/// The last culculation DateTime.
		/// </summary>
		public DateTime LastCalculationDateTime {
			get {
				return GetTypedColumnValue<DateTime>("LastCalculationDateTime");
			}
			set {
				SetColumnValue("LastCalculationDateTime", value);
			}
		}

		#endregion

	}

	#endregion

}

