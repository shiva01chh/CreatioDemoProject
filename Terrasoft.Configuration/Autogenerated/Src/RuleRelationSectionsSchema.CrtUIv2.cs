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

	#region Class: RuleRelationSectionsSchema

	/// <exclude/>
	public class RuleRelationSectionsSchema : Terrasoft.Configuration.LookupSchema
	{

		#region Constructors: Public

		public RuleRelationSectionsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RuleRelationSectionsSchema(RuleRelationSectionsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RuleRelationSectionsSchema(RuleRelationSectionsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			RealUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			Name = "RuleRelationSections";
			ParentSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84");
			ExtendParent = false;
			CreatedInPackageId = new Guid("324e2ed3-507d-49c0-9940-71ebe071d56d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b2e3a06a-cb04-4642-8735-e116e955de07")) == null) {
				Columns.Add(CreateSectionSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSectionSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b2e3a06a-cb04-4642-8735-e116e955de07"),
				Name = @"SectionSchemaUId",
				CreatedInSchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"),
				ModifiedInSchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"),
				CreatedInPackageId = new Guid("324e2ed3-507d-49c0-9940-71ebe071d56d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RuleRelationSections(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RuleRelationSections_CrtUIv2EventsProcess(userConnection);
		}

		public override object Clone() {
			return new RuleRelationSectionsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RuleRelationSectionsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6"));
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelationSections

	/// <summary>
	/// Sections that can be connected to emails.
	/// </summary>
	public class RuleRelationSections : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public RuleRelationSections(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RuleRelationSections";
		}

		public RuleRelationSections(RuleRelationSections source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SectionSchemaUId.
		/// </summary>
		public Guid SectionSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SectionSchemaUId");
			}
			set {
				SetColumnValue("SectionSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RuleRelationSections_CrtUIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("RuleRelationSectionsDeleted", e);
			Validating += (s, e) => ThrowEvent("RuleRelationSectionsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new RuleRelationSections(this);
		}

		#endregion

	}

	#endregion

	#region Class: RuleRelationSections_CrtUIv2EventsProcess

	/// <exclude/>
	public partial class RuleRelationSections_CrtUIv2EventsProcess<TEntity> : Terrasoft.Configuration.Lookup_CrtBaseEventsProcess<TEntity> where TEntity : RuleRelationSections
	{

		public RuleRelationSections_CrtUIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RuleRelationSections_CrtUIv2EventsProcess";
			SchemaUId = new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("adc2e665-7f74-49ee-a3d1-d63482aec3f6");
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

	#region Class: RuleRelationSections_CrtUIv2EventsProcess

	/// <exclude/>
	public class RuleRelationSections_CrtUIv2EventsProcess : RuleRelationSections_CrtUIv2EventsProcess<RuleRelationSections>
	{

		public RuleRelationSections_CrtUIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RuleRelationSections_CrtUIv2EventsProcess

	public partial class RuleRelationSections_CrtUIv2EventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RuleRelationSectionsEventsProcess

	/// <exclude/>
	public class RuleRelationSectionsEventsProcess : RuleRelationSections_CrtUIv2EventsProcess
	{

		public RuleRelationSectionsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

