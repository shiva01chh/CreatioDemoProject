namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: OpportunityStage

	/// <exclude/>
	public class OpportunityStage : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public OpportunityStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OpportunityStage";
		}

		public OpportunityStage(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "OpportunityStage";
			this.CopyEntityLookupProperties(source);
		}

		#endregion

		#region Properties: Public

		public IEnumerable<Opportunity> OpportunityCollectionByStage {
			get;
			set;
		}

		public IEnumerable<OpportunityInStage> OpportunityInStageCollectionByStage {
			get;
			set;
		}

		public IEnumerable<OppStageDecoupling> OppStageDecouplingCollectionByAvailableStage {
			get;
			set;
		}

		public IEnumerable<OppStageDecoupling> OppStageDecouplingCollectionByCurrentStage {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionByfStage {
			get;
			set;
		}

		public IEnumerable<VwOpportFunnelData> VwOpportFunnelDataCollectionBylStage {
			get;
			set;
		}

		public IEnumerable<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisCollectionByStage {
			get;
			set;
		}

		public IEnumerable<VwOpportunityInStage> VwOpportunityInStageCollectionByStage {
			get;
			set;
		}

		public IEnumerable<VwPortalOpportunity> VwPortalOpportunityCollectionByStage {
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

		/// <summary>
		/// Final.
		/// </summary>
		public bool End {
			get {
				return GetTypedColumnValue<bool>("End");
			}
			set {
				SetColumnValue("End", value);
			}
		}

		/// <summary>
		/// Successful.
		/// </summary>
		public bool Successful {
			get {
				return GetTypedColumnValue<bool>("Successful");
			}
			set {
				SetColumnValue("Successful", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
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
		/// Maximum probability.
		/// </summary>
		public int MaxProbability {
			get {
				return GetTypedColumnValue<int>("MaxProbability");
			}
			set {
				SetColumnValue("MaxProbability", value);
			}
		}

		/// <summary>
		/// Period for planning the next step, days.
		/// </summary>
		public int NextStepTerm {
			get {
				return GetTypedColumnValue<int>("NextStepTerm");
			}
			set {
				SetColumnValue("NextStepTerm", value);
			}
		}

		/// <summary>
		/// Show in funnel.
		/// </summary>
		public bool ShowInFunnel {
			get {
				return GetTypedColumnValue<bool>("ShowInFunnel");
			}
			set {
				SetColumnValue("ShowInFunnel", value);
			}
		}

		/// <summary>
		/// Color.
		/// </summary>
		public string Color {
			get {
				return GetTypedColumnValue<string>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Show in progress bar.
		/// </summary>
		public bool ShowInProgressBar {
			get {
				return GetTypedColumnValue<bool>("ShowInProgressBar");
			}
			set {
				SetColumnValue("ShowInProgressBar", value);
			}
		}

		#endregion

	}

	#endregion

}

