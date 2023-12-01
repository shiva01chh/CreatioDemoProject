﻿namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: DeadlineCalcSchemas_Calendar_TerrasoftSchema

	/// <exclude/>
	public class DeadlineCalcSchemas_Calendar_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DeadlineCalcSchemas_Calendar_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DeadlineCalcSchemas_Calendar_TerrasoftSchema(DeadlineCalcSchemas_Calendar_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DeadlineCalcSchemas_Calendar_TerrasoftSchema(DeadlineCalcSchemas_Calendar_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			RealUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			Name = "DeadlineCalcSchemas_Calendar_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a82c1524-401e-435b-b432-05726f44d614")) == null) {
				Columns.Add(CreateDefaultColumn());
			}
			if (Columns.FindByUId(new Guid("a1a913a4-20ba-49bd-b142-0ce75abb64f7")) == null) {
				Columns.Add(CreateAlternativeRuleColumn());
			}
			if (Columns.FindByUId(new Guid("259b670f-a523-4e81-b1d2-f7c2448d6e3c")) == null) {
				Columns.Add(CreateHandlerColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a82c1524-401e-435b-b432-05726f44d614"),
				Name = @"Default",
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b")
			};
		}

		protected virtual EntitySchemaColumn CreateAlternativeRuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a1a913a4-20ba-49bd-b142-0ce75abb64f7"),
				Name = @"AlternativeRule",
				ReferenceSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b")
			};
		}

		protected virtual EntitySchemaColumn CreateHandlerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("259b670f-a523-4e81-b1d2-f7c2448d6e3c"),
				Name = @"Handler",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DeadlineCalcSchemas_Calendar_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DeadlineCalcSchemas_CalendarEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DeadlineCalcSchemas_Calendar_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DeadlineCalcSchemas_Calendar_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"));
		}

		#endregion

	}

	#endregion

	#region Class: DeadlineCalcSchemas_Calendar_Terrasoft

	/// <summary>
	/// Case deadline calculation schemas.
	/// </summary>
	public class DeadlineCalcSchemas_Calendar_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DeadlineCalcSchemas_Calendar_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DeadlineCalcSchemas_Calendar_Terrasoft";
		}

		public DeadlineCalcSchemas_Calendar_Terrasoft(DeadlineCalcSchemas_Calendar_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Default.
		/// </summary>
		public bool Default {
			get {
				return GetTypedColumnValue<bool>("Default");
			}
			set {
				SetColumnValue("Default", value);
			}
		}

		/// <exclude/>
		public Guid AlternativeRuleId {
			get {
				return GetTypedColumnValue<Guid>("AlternativeRuleId");
			}
			set {
				SetColumnValue("AlternativeRuleId", value);
				_alternativeRule = null;
			}
		}

		/// <exclude/>
		public string AlternativeRuleName {
			get {
				return GetTypedColumnValue<string>("AlternativeRuleName");
			}
			set {
				SetColumnValue("AlternativeRuleName", value);
				if (_alternativeRule != null) {
					_alternativeRule.Name = value;
				}
			}
		}

		private DeadlineCalcSchemas _alternativeRule;
		/// <summary>
		/// Alternative schema.
		/// </summary>
		public DeadlineCalcSchemas AlternativeRule {
			get {
				return _alternativeRule ??
					(_alternativeRule = LookupColumnEntities.GetEntity("AlternativeRule") as DeadlineCalcSchemas);
			}
		}

		/// <summary>
		/// Handler.
		/// </summary>
		public string Handler {
			get {
				return GetTypedColumnValue<string>("Handler");
			}
			set {
				SetColumnValue("Handler", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DeadlineCalcSchemas_CalendarEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DeadlineCalcSchemas_Calendar_TerrasoftDeleted", e);
			Validating += (s, e) => ThrowEvent("DeadlineCalcSchemas_Calendar_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeadlineCalcSchemas_Calendar_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: DeadlineCalcSchemas_CalendarEventsProcess

	/// <exclude/>
	public partial class DeadlineCalcSchemas_CalendarEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : DeadlineCalcSchemas_Calendar_Terrasoft
	{

		public DeadlineCalcSchemas_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeadlineCalcSchemas_CalendarEventsProcess";
			SchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: DeadlineCalcSchemas_CalendarEventsProcess

	/// <exclude/>
	public class DeadlineCalcSchemas_CalendarEventsProcess : DeadlineCalcSchemas_CalendarEventsProcess<DeadlineCalcSchemas_Calendar_Terrasoft>
	{

		public DeadlineCalcSchemas_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeadlineCalcSchemas_CalendarEventsProcess

	public partial class DeadlineCalcSchemas_CalendarEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

