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

	#region Class: CasePriority_CrtCaseManagmentObject_TerrasoftSchema

	/// <exclude/>
	public class CasePriority_CrtCaseManagmentObject_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CasePriority_CrtCaseManagmentObject_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CasePriority_CrtCaseManagmentObject_TerrasoftSchema(CasePriority_CrtCaseManagmentObject_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CasePriority_CrtCaseManagmentObject_TerrasoftSchema(CasePriority_CrtCaseManagmentObject_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			RealUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			Name = "CasePriority_CrtCaseManagmentObject_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateImageColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("49e05c9f-1241-4bc7-aafd-cd48592c8d6a")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			column.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("49e05c9f-1241-4bc7-aafd-cd48592c8d6a"),
				Name = @"Priority",
				CreatedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			};
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("469c1088-a13d-49cc-90ff-f663e094b1ad"),
				Name = @"Image",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				ModifiedInSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				CreatedInPackageId = new Guid("475d20ed-7132-487d-a9d1-4fadc0bc9049")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CasePriority_CrtCaseManagmentObject_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CasePriority_CrtCaseManagmentObjectEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CasePriority_CrtCaseManagmentObject_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CasePriority_CrtCaseManagmentObject_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"));
		}

		#endregion

	}

	#endregion

	#region Class: CasePriority_CrtCaseManagmentObject_Terrasoft

	/// <summary>
	/// Lookup - Case priority.
	/// </summary>
	public class CasePriority_CrtCaseManagmentObject_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CasePriority_CrtCaseManagmentObject_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CasePriority_CrtCaseManagmentObject_Terrasoft";
		}

		public CasePriority_CrtCaseManagmentObject_Terrasoft(CasePriority_CrtCaseManagmentObject_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Priority.
		/// </summary>
		public int Priority {
			get {
				return GetTypedColumnValue<int>("Priority");
			}
			set {
				SetColumnValue("Priority", value);
			}
		}

		/// <exclude/>
		public Guid ImageId {
			get {
				return GetTypedColumnValue<Guid>("ImageId");
			}
			set {
				SetColumnValue("ImageId", value);
				_image = null;
			}
		}

		/// <exclude/>
		public string ImageName {
			get {
				return GetTypedColumnValue<string>("ImageName");
			}
			set {
				SetColumnValue("ImageName", value);
				if (_image != null) {
					_image.Name = value;
				}
			}
		}

		private SysImage _image;
		/// <summary>
		/// Icon.
		/// </summary>
		public SysImage Image {
			get {
				return _image ??
					(_image = LookupColumnEntities.GetEntity("Image") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CasePriority_CrtCaseManagmentObjectEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CasePriority_CrtCaseManagmentObject_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("CasePriority_CrtCaseManagmentObject_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("CasePriority_CrtCaseManagmentObject_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CasePriority_CrtCaseManagmentObject_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CasePriority_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public partial class CasePriority_CrtCaseManagmentObjectEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : CasePriority_CrtCaseManagmentObject_Terrasoft
	{

		public CasePriority_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CasePriority_CrtCaseManagmentObjectEventsProcess";
			SchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
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

	#region Class: CasePriority_CrtCaseManagmentObjectEventsProcess

	/// <exclude/>
	public class CasePriority_CrtCaseManagmentObjectEventsProcess : CasePriority_CrtCaseManagmentObjectEventsProcess<CasePriority_CrtCaseManagmentObject_Terrasoft>
	{

		public CasePriority_CrtCaseManagmentObjectEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CasePriority_CrtCaseManagmentObjectEventsProcess

	public partial class CasePriority_CrtCaseManagmentObjectEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

