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

	#region Class: Product_CrtProductBase_TerrasoftSchema

	/// <exclude/>
	public class Product_CrtProductBase_TerrasoftSchema : Terrasoft.Configuration.Product_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Product_CrtProductBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Product_CrtProductBase_TerrasoftSchema(Product_CrtProductBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Product_CrtProductBase_TerrasoftSchema(Product_CrtProductBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			Name = "Product_CrtProductBase_Terrasoft";
			ParentSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreatePictureColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3f6a282b-4d25-4f87-b63a-4a192abd19f6")) == null) {
				Columns.Add(CreateIsArchiveColumn());
			}
			if (Columns.FindByUId(new Guid("a9f5e0b2-07d6-8524-d43e-ceebb2641658")) == null) {
				Columns.Add(CreateShortDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("cfe90d40-8300-a5c6-7ed7-8164594f7d44")) == null) {
				Columns.Add(CreateBenefitsColumn());
			}
		}

		protected override EntitySchemaColumn CreateUnitColumn() {
			EntitySchemaColumn column = base.CreateUnitColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultUnit"
			};
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateTaxColumn() {
			EntitySchemaColumn column = base.CreateTaxColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Settings,
				ValueSource = @"DefaultTax"
			};
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateActiveColumn() {
			EntitySchemaColumn column = base.CreateActiveColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected override EntitySchemaColumn CreateProductSourceColumn() {
			EntitySchemaColumn column = base.CreateProductSourceColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
			column.CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePictureColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("3da5d5e7-908f-4cb2-81af-aa137eabb041"),
				Name = @"Picture",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			};
		}

		protected virtual EntitySchemaColumn CreateIsArchiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3f6a282b-4d25-4f87-b63a-4a192abd19f6"),
				Name = @"IsArchive",
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("a08eefe5-e3d9-4a0c-8558-f93b596572d7")
			};
		}

		protected virtual EntitySchemaColumn CreateShortDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a9f5e0b2-07d6-8524-d43e-ceebb2641658"),
				Name = @"ShortDescription",
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("7c452590-fed4-4749-94d1-1e9f0af597a3")
			};
		}

		protected virtual EntitySchemaColumn CreateBenefitsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("cfe90d40-8300-a5c6-7ed7-8164594f7d44"),
				Name = @"Benefits",
				CreatedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				ModifiedInSchemaUId = new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"),
				CreatedInPackageId = new Guid("7c452590-fed4-4749-94d1-1e9f0af597a3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Product_CrtProductBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Product_CrtProductBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Product_CrtProductBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Product_CrtProductBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893"));
		}

		#endregion

	}

	#endregion

	#region Class: Product_CrtProductBase_Terrasoft

	/// <summary>
	/// Product.
	/// </summary>
	public class Product_CrtProductBase_Terrasoft : Terrasoft.Configuration.Product_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Product_CrtProductBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Product_CrtProductBase_Terrasoft";
		}

		public Product_CrtProductBase_Terrasoft(Product_CrtProductBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PictureId {
			get {
				return GetTypedColumnValue<Guid>("PictureId");
			}
			set {
				SetColumnValue("PictureId", value);
				_picture = null;
			}
		}

		/// <exclude/>
		public string PictureName {
			get {
				return GetTypedColumnValue<string>("PictureName");
			}
			set {
				SetColumnValue("PictureName", value);
				if (_picture != null) {
					_picture.Name = value;
				}
			}
		}

		private SysImage _picture;
		/// <summary>
		/// Image.
		/// </summary>
		public SysImage Picture {
			get {
				return _picture ??
					(_picture = LookupColumnEntities.GetEntity("Picture") as SysImage);
			}
		}

		/// <summary>
		/// Inactive.
		/// </summary>
		public bool IsArchive {
			get {
				return GetTypedColumnValue<bool>("IsArchive");
			}
			set {
				SetColumnValue("IsArchive", value);
			}
		}

		/// <summary>
		/// Short Description.
		/// </summary>
		public string ShortDescription {
			get {
				return GetTypedColumnValue<string>("ShortDescription");
			}
			set {
				SetColumnValue("ShortDescription", value);
			}
		}

		/// <summary>
		/// Benefits.
		/// </summary>
		public string Benefits {
			get {
				return GetTypedColumnValue<string>("Benefits");
			}
			set {
				SetColumnValue("Benefits", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Product_CrtProductBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Product_CrtProductBase_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Product_CrtProductBase_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("Product_CrtProductBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Product_CrtProductBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Product_CrtProductBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Product_CrtProductBaseEventsProcess

	/// <exclude/>
	public partial class Product_CrtProductBaseEventsProcess<TEntity> : Terrasoft.Configuration.Product_CrtBaseEventsProcess<TEntity> where TEntity : Product_CrtProductBase_Terrasoft
	{

		public Product_CrtProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Product_CrtProductBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8f3e9f02-7d38-42e3-9363-21bb922a4893");
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

	#region Class: Product_CrtProductBaseEventsProcess

	/// <exclude/>
	public class Product_CrtProductBaseEventsProcess : Product_CrtProductBaseEventsProcess<Product_CrtProductBase_Terrasoft>
	{

		public Product_CrtProductBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Product_CrtProductBaseEventsProcess

	public partial class Product_CrtProductBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

