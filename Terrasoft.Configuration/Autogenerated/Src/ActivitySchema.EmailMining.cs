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
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Web;
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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_EmailMining_TerrasoftSchema

	/// <exclude/>
	public class Activity_EmailMining_TerrasoftSchema : Terrasoft.Configuration.Activity_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_EmailMining_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_EmailMining_TerrasoftSchema(Activity_EmailMining_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_EmailMining_TerrasoftSchema(Activity_EmailMining_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			Name = "Activity_EmailMining_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("c1529436-dee9-4290-84f1-87386440a2b1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ace5b35d-0166-48ca-b2d4-20add837dbbd")) == null) {
				Columns.Add(CreateEnrchEmailDataColumn());
			}
			if (Columns.FindByUId(new Guid("1c44eeca-97e9-4a02-a9a7-fff0eb8a4afb")) == null) {
				Columns.Add(CreateEnrichStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEnrchEmailDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ace5b35d-0166-48ca-b2d4-20add837dbbd"),
				Name = @"EnrchEmailData",
				ReferenceSchemaUId = new Guid("26d5f6ad-8525-4ceb-b3e5-af8fdf2964f6"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("c1529436-dee9-4290-84f1-87386440a2b1")
			};
		}

		protected virtual EntitySchemaColumn CreateEnrichStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("1c44eeca-97e9-4a02-a9a7-fff0eb8a4afb"),
				Name = @"EnrichStatus",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("bae6174e-6d8e-4782-b180-300a95031ded")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_EmailMining_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_EmailMiningEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_EmailMining_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_EmailMining_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a8f2187-7621-4d4b-904d-af660770442d"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_EmailMining_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_EmailMining_Terrasoft : Terrasoft.Configuration.Activity_SSP_Terrasoft
	{

		#region Constructors: Public

		public Activity_EmailMining_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_EmailMining_Terrasoft";
		}

		public Activity_EmailMining_Terrasoft(Activity_EmailMining_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EnrchEmailDataId {
			get {
				return GetTypedColumnValue<Guid>("EnrchEmailDataId");
			}
			set {
				SetColumnValue("EnrchEmailDataId", value);
				_enrchEmailData = null;
			}
		}

		/// <exclude/>
		public string EnrchEmailDataHash {
			get {
				return GetTypedColumnValue<string>("EnrchEmailDataHash");
			}
			set {
				SetColumnValue("EnrchEmailDataHash", value);
				if (_enrchEmailData != null) {
					_enrchEmailData.Hash = value;
				}
			}
		}

		private EnrchEmailData _enrchEmailData;
		/// <summary>
		/// Parsed e-mail.
		/// </summary>
		public EnrchEmailData EnrchEmailData {
			get {
				return _enrchEmailData ??
					(_enrchEmailData = LookupColumnEntities.GetEntity("EnrchEmailData") as EnrchEmailData);
			}
		}

		/// <summary>
		/// Enrichment status.
		/// </summary>
		public string EnrichStatus {
			get {
				return GetTypedColumnValue<string>("EnrichStatus");
			}
			set {
				SetColumnValue("EnrichStatus", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_EmailMiningEventsProcess(UserConnection);
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
			return new Activity_EmailMining_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_EmailMiningEventsProcess

	/// <exclude/>
	public partial class Activity_EmailMiningEventsProcess<TEntity> : Terrasoft.Configuration.Activity_SSPEventsProcess<TEntity> where TEntity : Activity_EmailMining_Terrasoft
	{

		public Activity_EmailMiningEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_EmailMiningEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
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

	#region Class: Activity_EmailMiningEventsProcess

	/// <exclude/>
	public class Activity_EmailMiningEventsProcess : Activity_EmailMiningEventsProcess<Activity_EmailMining_Terrasoft>
	{

		public Activity_EmailMiningEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_EmailMiningEventsProcess

	public partial class Activity_EmailMiningEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

