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

	#region Class: SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema

	/// <exclude/>
	public class SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema : Terrasoft.Configuration.SupplyPaymentSchema
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema(SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			RealUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			Name = "SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft";
			ParentSchemaUId = new Guid("980a8f16-f64b-4446-8894-4637063d3818");
			ExtendParent = false;
			CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysSupplyPaymTemplItemLcz";
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a475fc53-6351-463d-955a-da01d88603a1")) == null) {
				Columns.Add(CreatePreviousElementColumn());
			}
			if (Columns.FindByUId(new Guid("3952ea59-baa1-477e-accf-77267f1ba3c2")) == null) {
				Columns.Add(CreateSupplyPaymentTemplateColumn());
			}
		}

		protected override EntitySchemaColumn CreateDelayTypeColumn() {
			EntitySchemaColumn column = base.CreateDelayTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"b664126f-211f-44a1-acd8-6d9d8a1601c7"
			};
			column.ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("874f79e7-3065-426d-af73-7db36c904b2f"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreatePreviousElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a475fc53-6351-463d-955a-da01d88603a1"),
				Name = @"PreviousElement",
				ReferenceSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentTemplateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3952ea59-baa1-477e-accf-77267f1ba3c2"),
				Name = @"SupplyPaymentTemplate",
				ReferenceSchemaUId = new Guid("69262e8a-b4fc-4a03-bab9-5720e19291ef"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				ModifiedInSchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"),
				CreatedInPackageId = new Guid("95c2c84b-bfbc-40cb-9e93-5fad29a6591d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d"));
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft

	/// <summary>
	/// Installment plan template item.
	/// </summary>
	public class SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft : Terrasoft.Configuration.SupplyPayment
	{

		#region Constructors: Public

		public SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft";
		}

		public SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft(SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <exclude/>
		public Guid PreviousElementId {
			get {
				return GetTypedColumnValue<Guid>("PreviousElementId");
			}
			set {
				SetColumnValue("PreviousElementId", value);
				_previousElement = null;
			}
		}

		/// <exclude/>
		public string PreviousElementName {
			get {
				return GetTypedColumnValue<string>("PreviousElementName");
			}
			set {
				SetColumnValue("PreviousElementName", value);
				if (_previousElement != null) {
					_previousElement.Name = value;
				}
			}
		}

		private SupplyPaymentTemplateItem _previousElement;
		/// <summary>
		/// Previous entry.
		/// </summary>
		public SupplyPaymentTemplateItem PreviousElement {
			get {
				return _previousElement ??
					(_previousElement = LookupColumnEntities.GetEntity("PreviousElement") as SupplyPaymentTemplateItem);
			}
		}

		/// <exclude/>
		public Guid SupplyPaymentTemplateId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentTemplateId");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateId", value);
				_supplyPaymentTemplate = null;
			}
		}

		/// <exclude/>
		public string SupplyPaymentTemplateName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentTemplateName");
			}
			set {
				SetColumnValue("SupplyPaymentTemplateName", value);
				if (_supplyPaymentTemplate != null) {
					_supplyPaymentTemplate.Name = value;
				}
			}
		}

		private SupplyPaymentTemplate _supplyPaymentTemplate;
		/// <summary>
		/// Installment plan template.
		/// </summary>
		public SupplyPaymentTemplate SupplyPaymentTemplate {
			get {
				return _supplyPaymentTemplate ??
					(_supplyPaymentTemplate = LookupColumnEntities.GetEntity("SupplyPaymentTemplate") as SupplyPaymentTemplate);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftDeleted", e);
			Saving += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("SupplyPaymentTemplateItem_CrtSupplyPayment_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public partial class SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess<TEntity> : Terrasoft.Configuration.SupplyPayment_PassportEventsProcess<TEntity> where TEntity : SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft
	{

		public SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess";
			SchemaUId = new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e526a71f-add3-459d-9c56-b9ad9d88547d");
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

	#region Class: SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess

	/// <exclude/>
	public class SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess : SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess<SupplyPaymentTemplateItem_CrtSupplyPayment_Terrasoft>
	{

		public SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess

	public partial class SupplyPaymentTemplateItem_CrtSupplyPaymentEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

