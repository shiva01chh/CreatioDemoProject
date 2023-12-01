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

	#region Class: CampaignSignalEntitySchema

	/// <exclude/>
	public class CampaignSignalEntitySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignSignalEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignSignalEntitySchema(CampaignSignalEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignSignalEntitySchema(CampaignSignalEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14");
			RealUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14");
			Name = "CampaignSignalEntity";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("cb0d808c-9578-43ce-bd5f-c4165469e1af")) == null) {
				Columns.Add(CreateContactColumnColumn());
			}
			if (Columns.FindByUId(new Guid("42413318-7c2f-490b-9691-a232bfad9080")) == null) {
				Columns.Add(CreateEntityObjectColumn());
			}
			if (Columns.FindByUId(new Guid("3fae5b5e-6814-4295-a9c9-7cdf4509f814")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("cb0d808c-9578-43ce-bd5f-c4165469e1af"),
				Name = @"ContactColumn",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				ModifiedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("42413318-7c2f-490b-9691-a232bfad9080"),
				Name = @"EntityObject",
				ReferenceSchemaUId = new Guid("c82db13a-7f77-4085-b3ef-91c5420fd417"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				ModifiedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("3fae5b5e-6814-4295-a9c9-7cdf4509f814"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				ModifiedInSchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
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
			return new CampaignSignalEntity(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CampaignSignalEntity_CrtCampaignElementsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignSignalEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignSignalEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignSignalEntity

	/// <summary>
	/// Entity settings for campaign signal.
	/// </summary>
	public class CampaignSignalEntity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignSignalEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignSignalEntity";
		}

		public CampaignSignalEntity(CampaignSignalEntity source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Path to Contact.
		/// </summary>
		public string ContactColumn {
			get {
				return GetTypedColumnValue<string>("ContactColumn");
			}
			set {
				SetColumnValue("ContactColumn", value);
			}
		}

		/// <exclude/>
		public Guid EntityObjectId {
			get {
				return GetTypedColumnValue<Guid>("EntityObjectId");
			}
			set {
				SetColumnValue("EntityObjectId", value);
				_entityObject = null;
			}
		}

		/// <exclude/>
		public string EntityObjectTitle {
			get {
				return GetTypedColumnValue<string>("EntityObjectTitle");
			}
			set {
				SetColumnValue("EntityObjectTitle", value);
				if (_entityObject != null) {
					_entityObject.Title = value;
				}
			}
		}

		private VwEntityObjects _entityObject;
		/// <summary>
		/// Entity object.
		/// </summary>
		public VwEntityObjects EntityObject {
			get {
				return _entityObject ??
					(_entityObject = LookupColumnEntities.GetEntity("EntityObject") as VwEntityObjects);
			}
		}

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignSignalEntity_CrtCampaignElementsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignSignalEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignSignalEntity_CrtCampaignElementsEventsProcess

	/// <exclude/>
	public partial class CampaignSignalEntity_CrtCampaignElementsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignSignalEntity
	{

		public CampaignSignalEntity_CrtCampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignSignalEntity_CrtCampaignElementsEventsProcess";
			SchemaUId = new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9cfc5a8a-fcc9-4634-a7a9-84500c8ccb14");
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

	#region Class: CampaignSignalEntity_CrtCampaignElementsEventsProcess

	/// <exclude/>
	public class CampaignSignalEntity_CrtCampaignElementsEventsProcess : CampaignSignalEntity_CrtCampaignElementsEventsProcess<CampaignSignalEntity>
	{

		public CampaignSignalEntity_CrtCampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignSignalEntity_CrtCampaignElementsEventsProcess

	public partial class CampaignSignalEntity_CrtCampaignElementsEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CampaignSignalEntityEventsProcess

	/// <exclude/>
	public class CampaignSignalEntityEventsProcess : CampaignSignalEntity_CrtCampaignElementsEventsProcess
	{

		public CampaignSignalEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

