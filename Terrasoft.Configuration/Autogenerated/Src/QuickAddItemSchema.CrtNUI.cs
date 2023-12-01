namespace Terrasoft.Configuration
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

	#region Class: QuickAddItem_CrtNUI_TerrasoftSchema

	/// <exclude/>
	public class QuickAddItem_CrtNUI_TerrasoftSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public QuickAddItem_CrtNUI_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QuickAddItem_CrtNUI_TerrasoftSchema(QuickAddItem_CrtNUI_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QuickAddItem_CrtNUI_TerrasoftSchema(QuickAddItem_CrtNUI_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf");
			RealUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf");
			Name = "QuickAddItem_CrtNUI_Terrasoft";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("87481597-f1f5-4b71-8cab-7ffc3c010af8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d9954173-2af2-050b-f6b0-999f372996d5")) == null) {
				Columns.Add(CreateEntitySchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("e8648c9e-cfda-a903-3b1c-47645506a285")) == null) {
				Columns.Add(CreateQuickAddMenuSettingsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d9954173-2af2-050b-f6b0-999f372996d5"),
				Name = @"EntitySchemaName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf"),
				ModifiedInSchemaUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf"),
				CreatedInPackageId = new Guid("87481597-f1f5-4b71-8cab-7ffc3c010af8")
			};
		}

		protected virtual EntitySchemaColumn CreateQuickAddMenuSettingsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e8648c9e-cfda-a903-3b1c-47645506a285"),
				Name = @"QuickAddMenuSettings",
				ReferenceSchemaUId = new Guid("4aa8a1e1-77b5-421c-9e74-303810fbc561"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf"),
				ModifiedInSchemaUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf"),
				CreatedInPackageId = new Guid("87481597-f1f5-4b71-8cab-7ffc3c010af8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QuickAddItem_CrtNUI_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new QuickAddItem_CrtNUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new QuickAddItem_CrtNUI_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QuickAddItem_CrtNUI_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf"));
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddItem_CrtNUI_Terrasoft

	/// <summary>
	/// Quick add records menu.
	/// </summary>
	public class QuickAddItem_CrtNUI_Terrasoft : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public QuickAddItem_CrtNUI_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QuickAddItem_CrtNUI_Terrasoft";
		}

		public QuickAddItem_CrtNUI_Terrasoft(QuickAddItem_CrtNUI_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object code.
		/// </summary>
		public string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		/// <exclude/>
		public Guid QuickAddMenuSettingsId {
			get {
				return GetTypedColumnValue<Guid>("QuickAddMenuSettingsId");
			}
			set {
				SetColumnValue("QuickAddMenuSettingsId", value);
				_quickAddMenuSettings = null;
			}
		}

		/// <exclude/>
		public string QuickAddMenuSettingsName {
			get {
				return GetTypedColumnValue<string>("QuickAddMenuSettingsName");
			}
			set {
				SetColumnValue("QuickAddMenuSettingsName", value);
				if (_quickAddMenuSettings != null) {
					_quickAddMenuSettings.Name = value;
				}
			}
		}

		private QuickAddMenuSettings _quickAddMenuSettings;
		/// <summary>
		/// Group of quick add menu.
		/// </summary>
		public QuickAddMenuSettings QuickAddMenuSettings {
			get {
				return _quickAddMenuSettings ??
					(_quickAddMenuSettings = LookupColumnEntities.GetEntity("QuickAddMenuSettings") as QuickAddMenuSettings);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QuickAddItem_CrtNUIEventsProcess(UserConnection);
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
			return new QuickAddItem_CrtNUI_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: QuickAddItem_CrtNUIEventsProcess

	/// <exclude/>
	public partial class QuickAddItem_CrtNUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_CrtBaseEventsProcess<TEntity> where TEntity : QuickAddItem_CrtNUI_Terrasoft
	{

		public QuickAddItem_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QuickAddItem_CrtNUIEventsProcess";
			SchemaUId = new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bfb1b574-dfc8-4ee5-9ad2-a7fc8c1f5cdf");
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

	#region Class: QuickAddItem_CrtNUIEventsProcess

	/// <exclude/>
	public class QuickAddItem_CrtNUIEventsProcess : QuickAddItem_CrtNUIEventsProcess<QuickAddItem_CrtNUI_Terrasoft>
	{

		public QuickAddItem_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QuickAddItem_CrtNUIEventsProcess

	public partial class QuickAddItem_CrtNUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

