namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CaseRuleInStage

	/// <exclude/>
	public class CaseRuleInStage : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CaseRuleInStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseRuleInStage";
		}

		public CaseRuleInStage(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CaseRuleInStage";
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

		/// <summary>
		/// Active.
		/// </summary>
		public bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		/// <exclude/>
		public Guid CaseRuleHandlerId {
			get {
				return GetTypedColumnValue<Guid>("CaseRuleHandlerId");
			}
			set {
				SetColumnValue("CaseRuleHandlerId", value);
				_caseRuleHandler = null;
			}
		}

		/// <exclude/>
		public string CaseRuleHandlerName {
			get {
				return GetTypedColumnValue<string>("CaseRuleHandlerName");
			}
			set {
				SetColumnValue("CaseRuleHandlerName", value);
				if (_caseRuleHandler != null) {
					_caseRuleHandler.Name = value;
				}
			}
		}

		private CaseRuleHandler _caseRuleHandler;
		/// <summary>
		/// Case rule handler.
		/// </summary>
		public CaseRuleHandler CaseRuleHandler {
			get {
				return _caseRuleHandler ??
					(_caseRuleHandler = new CaseRuleHandler(LookupColumnEntities.GetEntity("CaseRuleHandler")));
			}
		}

		/// <exclude/>
		public Guid CaseNextStatusId {
			get {
				return GetTypedColumnValue<Guid>("CaseNextStatusId");
			}
			set {
				SetColumnValue("CaseNextStatusId", value);
				_caseNextStatus = null;
			}
		}

		/// <exclude/>
		public string CaseNextStatusName {
			get {
				return GetTypedColumnValue<string>("CaseNextStatusName");
			}
			set {
				SetColumnValue("CaseNextStatusName", value);
				if (_caseNextStatus != null) {
					_caseNextStatus.Name = value;
				}
			}
		}

		private CaseNextStatus _caseNextStatus;
		/// <summary>
		/// Case next status.
		/// </summary>
		public CaseNextStatus CaseNextStatus {
			get {
				return _caseNextStatus ??
					(_caseNextStatus = new CaseNextStatus(LookupColumnEntities.GetEntity("CaseNextStatus")));
			}
		}

		#endregion

	}

	#endregion

}

