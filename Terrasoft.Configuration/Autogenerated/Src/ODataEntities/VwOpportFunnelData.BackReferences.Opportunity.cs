namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: VwOpportFunnelData

	/// <exclude/>
	public class VwOpportFunnelData : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwOpportFunnelData(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwOpportFunnelData";
		}

		public VwOpportFunnelData(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "VwOpportFunnelData";
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

		/// <exclude/>
		public Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = new Opportunity(LookupColumnEntities.GetEntity("Opportunity")));
			}
		}

		/// <exclude/>
		public Guid fStageId {
			get {
				return GetTypedColumnValue<Guid>("fStageId");
			}
			set {
				SetColumnValue("fStageId", value);
				_fStage = null;
			}
		}

		/// <exclude/>
		public string fStageName {
			get {
				return GetTypedColumnValue<string>("fStageName");
			}
			set {
				SetColumnValue("fStageName", value);
				if (_fStage != null) {
					_fStage.Name = value;
				}
			}
		}

		private OpportunityStage _fStage;
		/// <summary>
		/// Previous stage.
		/// </summary>
		public OpportunityStage fStage {
			get {
				return _fStage ??
					(_fStage = new OpportunityStage(LookupColumnEntities.GetEntity("fStage")));
			}
		}

		/// <summary>
		/// Previous stage number.
		/// </summary>
		public int fStageNumber {
			get {
				return GetTypedColumnValue<int>("fStageNumber");
			}
			set {
				SetColumnValue("fStageNumber", value);
			}
		}

		/// <summary>
		/// Previous stage start date.
		/// </summary>
		public DateTime fStartDate {
			get {
				return GetTypedColumnValue<DateTime>("fStartDate");
			}
			set {
				SetColumnValue("fStartDate", value);
			}
		}

		/// <summary>
		/// Previous stage end date.
		/// </summary>
		public DateTime fDueDate {
			get {
				return GetTypedColumnValue<DateTime>("fDueDate");
			}
			set {
				SetColumnValue("fDueDate", value);
			}
		}

		/// <summary>
		/// Previous stage created on.
		/// </summary>
		public DateTime fCreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("fCreatedOn");
			}
			set {
				SetColumnValue("fCreatedOn", value);
			}
		}

		/// <exclude/>
		public Guid lStageId {
			get {
				return GetTypedColumnValue<Guid>("lStageId");
			}
			set {
				SetColumnValue("lStageId", value);
				_lStage = null;
			}
		}

		/// <exclude/>
		public string lStageName {
			get {
				return GetTypedColumnValue<string>("lStageName");
			}
			set {
				SetColumnValue("lStageName", value);
				if (_lStage != null) {
					_lStage.Name = value;
				}
			}
		}

		private OpportunityStage _lStage;
		/// <summary>
		/// Next stage.
		/// </summary>
		public OpportunityStage lStage {
			get {
				return _lStage ??
					(_lStage = new OpportunityStage(LookupColumnEntities.GetEntity("lStage")));
			}
		}

		/// <summary>
		/// Next stage number.
		/// </summary>
		public int lStageNumber {
			get {
				return GetTypedColumnValue<int>("lStageNumber");
			}
			set {
				SetColumnValue("lStageNumber", value);
			}
		}

		/// <summary>
		/// Next stage start date.
		/// </summary>
		public DateTime lStartDate {
			get {
				return GetTypedColumnValue<DateTime>("lStartDate");
			}
			set {
				SetColumnValue("lStartDate", value);
			}
		}

		/// <summary>
		/// Next stage end date.
		/// </summary>
		public DateTime lDueDate {
			get {
				return GetTypedColumnValue<DateTime>("lDueDate");
			}
			set {
				SetColumnValue("lDueDate", value);
			}
		}

		/// <summary>
		/// Next stage created on.
		/// </summary>
		public DateTime lCreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("lCreatedOn");
			}
			set {
				SetColumnValue("lCreatedOn", value);
			}
		}

		/// <summary>
		/// Stage conversion checkbox.
		/// </summary>
		public int IsInStageConversion {
			get {
				return GetTypedColumnValue<int>("IsInStageConversion");
			}
			set {
				SetColumnValue("IsInStageConversion", value);
			}
		}

		#endregion

	}

	#endregion

}

