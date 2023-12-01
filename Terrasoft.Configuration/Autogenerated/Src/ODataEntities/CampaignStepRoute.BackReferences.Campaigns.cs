namespace Terrasoft.Configuration.OData
{

	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities.Extensions;

	#region Class: CampaignStepRoute

	/// <exclude/>
	public class CampaignStepRoute : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CampaignStepRoute(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignStepRoute";
		}

		public CampaignStepRoute(Terrasoft.Core.Entities.Entity source)
			: base(source) {
			SchemaName = "CampaignStepRoute";
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
		/// JSON.
		/// </summary>
		public string JSON {
			get {
				return GetTypedColumnValue<string>("JSON");
			}
			set {
				SetColumnValue("JSON", value);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public Guid SourceStepId {
			get {
				return GetTypedColumnValue<Guid>("SourceStepId");
			}
			set {
				SetColumnValue("SourceStepId", value);
				_sourceStep = null;
			}
		}

		/// <exclude/>
		public string SourceStepTitle {
			get {
				return GetTypedColumnValue<string>("SourceStepTitle");
			}
			set {
				SetColumnValue("SourceStepTitle", value);
				if (_sourceStep != null) {
					_sourceStep.Title = value;
				}
			}
		}

		private CampaignStep _sourceStep;
		/// <summary>
		/// Initial step.
		/// </summary>
		public CampaignStep SourceStep {
			get {
				return _sourceStep ??
					(_sourceStep = new CampaignStep(LookupColumnEntities.GetEntity("SourceStep")));
			}
		}

		/// <exclude/>
		public Guid TargetStepId {
			get {
				return GetTypedColumnValue<Guid>("TargetStepId");
			}
			set {
				SetColumnValue("TargetStepId", value);
				_targetStep = null;
			}
		}

		/// <exclude/>
		public string TargetStepTitle {
			get {
				return GetTypedColumnValue<string>("TargetStepTitle");
			}
			set {
				SetColumnValue("TargetStepTitle", value);
				if (_targetStep != null) {
					_targetStep.Title = value;
				}
			}
		}

		private CampaignStep _targetStep;
		/// <summary>
		/// Final step.
		/// </summary>
		public CampaignStep TargetStep {
			get {
				return _targetStep ??
					(_targetStep = new CampaignStep(LookupColumnEntities.GetEntity("TargetStep")));
			}
		}

		#endregion

	}

	#endregion

}

