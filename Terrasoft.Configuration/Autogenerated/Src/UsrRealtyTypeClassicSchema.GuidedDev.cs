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

	#region Class: UsrRealtyTypeClassicSchema

	/// <exclude/>
	public class UsrRealtyTypeClassicSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrRealtyTypeClassicSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyTypeClassicSchema(UsrRealtyTypeClassicSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyTypeClassicSchema(UsrRealtyTypeClassicSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be");
			RealUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be");
			Name = "UsrRealtyTypeClassic";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0f92a6a3-60ec-935b-95d3-5592523589c1")) == null) {
				Columns.Add(CreateUsrCodeColumn());
			}
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be");
			return column;
		}

		protected virtual EntitySchemaColumn CreateUsrCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("0f92a6a3-60ec-935b-95d3-5592523589c1"),
				Name = @"UsrCode",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be"),
				ModifiedInSchemaUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be"),
				CreatedInPackageId = new Guid("3f1455c5-ba81-4ca6-a1a3-af2bb6e68111"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Sequence,
					SequencePrefix = "R",
					SequenceNumberOfChars = 2
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new UsrRealtyTypeClassic(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyTypeClassic_GuidedDevEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyTypeClassicSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyTypeClassicSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyTypeClassic

	/// <summary>
	/// Realty type (Classic).
	/// </summary>
	public class UsrRealtyTypeClassic : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrRealtyTypeClassic(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyTypeClassic";
		}

		public UsrRealtyTypeClassic(UsrRealtyTypeClassic source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string UsrCode {
			get {
				return GetTypedColumnValue<string>("UsrCode");
			}
			set {
				SetColumnValue("UsrCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyTypeClassic_GuidedDevEventsProcess(UserConnection);
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
			return new UsrRealtyTypeClassic(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyTypeClassic_GuidedDevEventsProcess

	/// <exclude/>
	public partial class UsrRealtyTypeClassic_GuidedDevEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyTypeClassic
	{

		public UsrRealtyTypeClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyTypeClassic_GuidedDevEventsProcess";
			SchemaUId = new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0105ee7e-619b-45ea-a1d4-d67e5a33e6be");
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

	#region Class: UsrRealtyTypeClassic_GuidedDevEventsProcess

	/// <exclude/>
	public class UsrRealtyTypeClassic_GuidedDevEventsProcess : UsrRealtyTypeClassic_GuidedDevEventsProcess<UsrRealtyTypeClassic>
	{

		public UsrRealtyTypeClassic_GuidedDevEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyTypeClassic_GuidedDevEventsProcess

	public partial class UsrRealtyTypeClassic_GuidedDevEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyTypeClassicEventsProcess

	/// <exclude/>
	public class UsrRealtyTypeClassicEventsProcess : UsrRealtyTypeClassic_GuidedDevEventsProcess
	{

		public UsrRealtyTypeClassicEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

