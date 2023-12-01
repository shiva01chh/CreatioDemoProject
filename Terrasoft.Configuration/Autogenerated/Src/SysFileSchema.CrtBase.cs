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

	#region Class: SysFile_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class SysFile_CrtBase_TerrasoftSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public SysFile_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysFile_CrtBase_TerrasoftSchema(SysFile_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysFile_CrtBase_TerrasoftSchema(SysFile_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a");
			RealUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a");
			Name = "SysFile_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			RightSchemaName = @"SystemFileRight";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("789fa023-8511-adc3-cb3d-4c1e67c6db5a")) == null) {
				Columns.Add(CreateRecordSchemaNameColumn());
			}
			if (Columns.FindByUId(new Guid("5d2bc4fd-dcd0-2e6a-d194-76812388ad13")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRecordSchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("789fa023-8511-adc3-cb3d-4c1e67c6db5a"),
				Name = @"RecordSchemaName",
				CreatedInSchemaUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a"),
				ModifiedInSchemaUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5d2bc4fd-dcd0-2e6a-d194-76812388ad13"),
				Name = @"RecordId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a"),
				ModifiedInSchemaUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysFile_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysFile_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysFile_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysFile_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a"));
		}

		#endregion

	}

	#endregion

	#region Class: SysFile_CrtBase_Terrasoft

	/// <summary>
	/// Uploaded file.
	/// </summary>
	public class SysFile_CrtBase_Terrasoft : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public SysFile_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysFile_CrtBase_Terrasoft";
		}

		public SysFile_CrtBase_Terrasoft(SysFile_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Record schema name.
		/// </summary>
		public string RecordSchemaName {
			get {
				return GetTypedColumnValue<string>("RecordSchemaName");
			}
			set {
				SetColumnValue("RecordSchemaName", value);
			}
		}

		/// <summary>
		/// Record Id.
		/// </summary>
		public Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysFile_CrtBaseEventsProcess(UserConnection);
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
			return new SysFile_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysFile_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysFile_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : SysFile_CrtBase_Terrasoft
	{

		public SysFile_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysFile_CrtBaseEventsProcess";
			SchemaUId = new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("70ec5d9f-a55e-4f5c-8f59-30d2c5149c4a");
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

	#region Class: SysFile_CrtBaseEventsProcess

	/// <exclude/>
	public class SysFile_CrtBaseEventsProcess : SysFile_CrtBaseEventsProcess<SysFile_CrtBase_Terrasoft>
	{

		public SysFile_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysFile_CrtBaseEventsProcess

	public partial class SysFile_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

