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

	#region Class: ProductFilter_CrtProductCatalogue_TerrasoftSchema

	/// <exclude/>
	public class ProductFilter_CrtProductCatalogue_TerrasoftSchema : Terrasoft.Configuration.BaseEntityWithPositionSchema
	{

		#region Constructors: Public

		public ProductFilter_CrtProductCatalogue_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProductFilter_CrtProductCatalogue_TerrasoftSchema(ProductFilter_CrtProductCatalogue_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProductFilter_CrtProductCatalogue_TerrasoftSchema(ProductFilter_CrtProductCatalogue_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			RealUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			Name = "ProductFilter_CrtProductCatalogue_Terrasoft";
			ParentSchemaUId = new Guid("73d33bed-4682-45cb-ad25-a29b5ab88c96");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
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
			if (Columns.FindByUId(new Guid("8bd08717-6b65-4a00-80d9-79635a65686e")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("a6202f2a-1d22-43a9-8317-d13d5ef8e23d")) == null) {
				Columns.Add(CreateSpecificationColumn());
			}
			if (Columns.FindByUId(new Guid("1afcdffa-6c83-453b-8a1d-4b4c33e892b5")) == null) {
				Columns.Add(CreateColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("94385fd4-8ada-4588-bddb-54237940630d")) == null) {
				Columns.Add(CreateReferenceSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("8037dbff-8c5b-4098-abac-11f636bae1fe")) == null) {
				Columns.Add(CreateColumnCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("16ac06f7-cf6b-4c69-996b-4b10b986c633")) == null) {
				Columns.Add(CreateProductTypeColumn());
			}
			if (Columns.FindByUId(new Guid("04e82d78-89c8-4a9e-b24b-7520f5ec54cf")) == null) {
				Columns.Add(CreateColumnDataValueTypeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected override EntitySchemaColumn CreatePositionColumn() {
			EntitySchemaColumn column = base.CreatePositionColumn();
			column.ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			column.CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("7c08467c-87c4-4147-af83-37665a501f97"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8bd08717-6b65-4a00-80d9-79635a65686e"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("54ab3775-a12e-418d-a6ad-9365d00a53a9"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateSpecificationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a6202f2a-1d22-43a9-8317-d13d5ef8e23d"),
				Name = @"Specification",
				ReferenceSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("1afcdffa-6c83-453b-8a1d-4b4c33e892b5"),
				Name = @"ColumnPath",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateReferenceSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("94385fd4-8ada-4588-bddb-54237940630d"),
				Name = @"ReferenceSchemaName",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("8037dbff-8c5b-4098-abac-11f636bae1fe"),
				Name = @"ColumnCaption",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("16ac06f7-cf6b-4c69-996b-4b10b986c633"),
				Name = @"ProductType",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnDataValueTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("04e82d78-89c8-4a9e-b24b-7520f5ec54cf"),
				Name = @"ColumnDataValueType",
				CreatedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				ModifiedInSchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"),
				CreatedInPackageId = new Guid("e502d56a-e797-4315-8a0b-0fab9b8f01ab")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProductFilter_CrtProductCatalogue_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ProductFilter_CrtProductCatalogueEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProductFilter_CrtProductCatalogue_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProductFilter_CrtProductCatalogue_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb"));
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter_CrtProductCatalogue_Terrasoft

	/// <summary>
	/// Product filter.
	/// </summary>
	public class ProductFilter_CrtProductCatalogue_Terrasoft : Terrasoft.Configuration.BaseEntityWithPosition
	{

		#region Constructors: Public

		public ProductFilter_CrtProductCatalogue_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProductFilter_CrtProductCatalogue_Terrasoft";
		}

		public ProductFilter_CrtProductCatalogue_Terrasoft(ProductFilter_CrtProductCatalogue_Terrasoft source)
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
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private ProductFilterType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public ProductFilterType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ProductFilterType);
			}
		}

		/// <exclude/>
		public Guid SpecificationId {
			get {
				return GetTypedColumnValue<Guid>("SpecificationId");
			}
			set {
				SetColumnValue("SpecificationId", value);
				_specification = null;
			}
		}

		/// <exclude/>
		public string SpecificationName {
			get {
				return GetTypedColumnValue<string>("SpecificationName");
			}
			set {
				SetColumnValue("SpecificationName", value);
				if (_specification != null) {
					_specification.Name = value;
				}
			}
		}

		private Specification _specification;
		/// <summary>
		/// Feature.
		/// </summary>
		public Specification Specification {
			get {
				return _specification ??
					(_specification = LookupColumnEntities.GetEntity("Specification") as Specification);
			}
		}

		/// <summary>
		/// Column path.
		/// </summary>
		public string ColumnPath {
			get {
				return GetTypedColumnValue<string>("ColumnPath");
			}
			set {
				SetColumnValue("ColumnPath", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public string ReferenceSchemaName {
			get {
				return GetTypedColumnValue<string>("ReferenceSchemaName");
			}
			set {
				SetColumnValue("ReferenceSchemaName", value);
			}
		}

		/// <summary>
		/// Product field.
		/// </summary>
		public string ColumnCaption {
			get {
				return GetTypedColumnValue<string>("ColumnCaption");
			}
			set {
				SetColumnValue("ColumnCaption", value);
			}
		}

		/// <exclude/>
		public Guid ProductTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeId");
			}
			set {
				SetColumnValue("ProductTypeId", value);
				_productType = null;
			}
		}

		/// <exclude/>
		public string ProductTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeName");
			}
			set {
				SetColumnValue("ProductTypeName", value);
				if (_productType != null) {
					_productType.Name = value;
				}
			}
		}

		private ProductType _productType;
		/// <summary>
		/// Product type.
		/// </summary>
		public ProductType ProductType {
			get {
				return _productType ??
					(_productType = LookupColumnEntities.GetEntity("ProductType") as ProductType);
			}
		}

		/// <summary>
		/// Column data type.
		/// </summary>
		public int ColumnDataValueType {
			get {
				return GetTypedColumnValue<int>("ColumnDataValueType");
			}
			set {
				SetColumnValue("ColumnDataValueType", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProductFilter_CrtProductCatalogueEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ProductFilter_CrtProductCatalogue_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProductFilter_CrtProductCatalogue_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProductFilter_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public partial class ProductFilter_CrtProductCatalogueEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityWithPosition_CrtBaseEventsProcess<TEntity> where TEntity : ProductFilter_CrtProductCatalogue_Terrasoft
	{

		public ProductFilter_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProductFilter_CrtProductCatalogueEventsProcess";
			SchemaUId = new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1762c40d-54a2-4312-a93a-d3f48c958fcb");
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

	#region Class: ProductFilter_CrtProductCatalogueEventsProcess

	/// <exclude/>
	public class ProductFilter_CrtProductCatalogueEventsProcess : ProductFilter_CrtProductCatalogueEventsProcess<ProductFilter_CrtProductCatalogue_Terrasoft>
	{

		public ProductFilter_CrtProductCatalogueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

