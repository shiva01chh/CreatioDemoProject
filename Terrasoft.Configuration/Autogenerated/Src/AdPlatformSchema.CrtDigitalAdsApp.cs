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

	#region Class: AdPlatformSchema

	/// <exclude/>
	public class AdPlatformSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public AdPlatformSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AdPlatformSchema(AdPlatformSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AdPlatformSchema(AdPlatformSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183");
			RealUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183");
			Name = "AdPlatform";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fac15864-8dc1-eafa-dce5-c13b43dcef8f")) == null) {
				Columns.Add(CreateColorColumn());
			}
			if (Columns.FindByUId(new Guid("f8e2fcb0-fc55-2b82-1fd4-399dc82f39ea")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateColorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Color")) {
				UId = new Guid("fac15864-8dc1-eafa-dce5-c13b43dcef8f"),
				Name = @"Color",
				CreatedInSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				ModifiedInSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				CreatedInPackageId = new Guid("01d151ef-0da1-4080-b7c8-4c4fad1e484b")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f8e2fcb0-fc55-2b82-1fd4-399dc82f39ea"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				ModifiedInSchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"),
				CreatedInPackageId = new Guid("aff5ba3a-c200-440e-a328-1d1fc9b538d0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AdPlatform(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AdPlatform_CrtDigitalAdsAppEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AdPlatformSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AdPlatformSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183"));
		}

		#endregion

	}

	#endregion

	#region Class: AdPlatform

	/// <summary>
	/// Ad platform.
	/// </summary>
	public class AdPlatform : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public AdPlatform(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AdPlatform";
		}

		public AdPlatform(AdPlatform source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Color.
		/// </summary>
		public Color Color {
			get {
				return GetTypedColumnValue<Color>("Color");
			}
			set {
				SetColumnValue("Color", value);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AdPlatform_CrtDigitalAdsAppEventsProcess(UserConnection);
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
			return new AdPlatform(this);
		}

		#endregion

	}

	#endregion

	#region Class: AdPlatform_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public partial class AdPlatform_CrtDigitalAdsAppEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : AdPlatform
	{

		public AdPlatform_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AdPlatform_CrtDigitalAdsAppEventsProcess";
			SchemaUId = new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("57abc67c-e4ca-4dad-b9c7-1fd34e68b183");
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

	#region Class: AdPlatform_CrtDigitalAdsAppEventsProcess

	/// <exclude/>
	public class AdPlatform_CrtDigitalAdsAppEventsProcess : AdPlatform_CrtDigitalAdsAppEventsProcess<AdPlatform>
	{

		public AdPlatform_CrtDigitalAdsAppEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AdPlatform_CrtDigitalAdsAppEventsProcess

	public partial class AdPlatform_CrtDigitalAdsAppEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AdPlatformEventsProcess

	/// <exclude/>
	public class AdPlatformEventsProcess : AdPlatform_CrtDigitalAdsAppEventsProcess
	{

		public AdPlatformEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

