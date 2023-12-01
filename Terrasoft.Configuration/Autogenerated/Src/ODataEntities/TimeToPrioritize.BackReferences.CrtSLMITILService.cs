namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: TimeToPrioritize

	/// <exclude/>
	public class TimeToPrioritize : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public TimeToPrioritize(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TimeToPrioritize";
		}

		public TimeToPrioritize(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "TimeToPrioritize";
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

		/// <exclude/>
		public Guid CasePriorityId {
			get {
				return GetTypedColumnValue<Guid>("CasePriorityId");
			}
			set {
				SetColumnValue("CasePriorityId", value);
				_casePriority = null;
			}
		}

		/// <exclude/>
		public string CasePriorityName {
			get {
				return GetTypedColumnValue<string>("CasePriorityName");
			}
			set {
				SetColumnValue("CasePriorityName", value);
				if (_casePriority != null) {
					_casePriority.Name = value;
				}
			}
		}

		private CasePriority _casePriority;
		/// <summary>
		/// Case priority.
		/// </summary>
		public CasePriority CasePriority {
			get {
				return _casePriority ??
					(_casePriority = new CasePriority(LookupColumnEntities.GetEntity("CasePriority")));
			}
		}

		/// <exclude/>
		public Guid ReactionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("ReactionTimeUnitId");
			}
			set {
				SetColumnValue("ReactionTimeUnitId", value);
				_reactionTimeUnit = null;
			}
		}

		/// <exclude/>
		public string ReactionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("ReactionTimeUnitName");
			}
			set {
				SetColumnValue("ReactionTimeUnitName", value);
				if (_reactionTimeUnit != null) {
					_reactionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _reactionTimeUnit;
		/// <summary>
		/// Response time unit.
		/// </summary>
		public TimeUnit ReactionTimeUnit {
			get {
				return _reactionTimeUnit ??
					(_reactionTimeUnit = new TimeUnit(LookupColumnEntities.GetEntity("ReactionTimeUnit")));
			}
		}

		/// <summary>
		/// Response time value.
		/// </summary>
		public int ReactionTimeValue {
			get {
				return GetTypedColumnValue<int>("ReactionTimeValue");
			}
			set {
				SetColumnValue("ReactionTimeValue", value);
			}
		}

		/// <exclude/>
		public Guid SolutionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("SolutionTimeUnitId");
			}
			set {
				SetColumnValue("SolutionTimeUnitId", value);
				_solutionTimeUnit = null;
			}
		}

		/// <exclude/>
		public string SolutionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("SolutionTimeUnitName");
			}
			set {
				SetColumnValue("SolutionTimeUnitName", value);
				if (_solutionTimeUnit != null) {
					_solutionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _solutionTimeUnit;
		/// <summary>
		/// Resolution time unit.
		/// </summary>
		public TimeUnit SolutionTimeUnit {
			get {
				return _solutionTimeUnit ??
					(_solutionTimeUnit = new TimeUnit(LookupColumnEntities.GetEntity("SolutionTimeUnit")));
			}
		}

		/// <summary>
		/// Resolution time value.
		/// </summary>
		public int SolutionTimeValue {
			get {
				return GetTypedColumnValue<int>("SolutionTimeValue");
			}
			set {
				SetColumnValue("SolutionTimeValue", value);
			}
		}

		/// <exclude/>
		public Guid ServiceInServicePactId {
			get {
				return GetTypedColumnValue<Guid>("ServiceInServicePactId");
			}
			set {
				SetColumnValue("ServiceInServicePactId", value);
				_serviceInServicePact = null;
			}
		}

		/// <exclude/>
		public string ServiceInServicePactConcatName {
			get {
				return GetTypedColumnValue<string>("ServiceInServicePactConcatName");
			}
			set {
				SetColumnValue("ServiceInServicePactConcatName", value);
				if (_serviceInServicePact != null) {
					_serviceInServicePact.ConcatName = value;
				}
			}
		}

		private ServiceInServicePact _serviceInServicePact;
		/// <summary>
		/// Service in service pact.
		/// </summary>
		public ServiceInServicePact ServiceInServicePact {
			get {
				return _serviceInServicePact ??
					(_serviceInServicePact = new ServiceInServicePact(LookupColumnEntities.GetEntity("ServiceInServicePact")));
			}
		}

		#endregion

	}

	#endregion

}

