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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CurrencyRate_PRMPortal_TerrasoftSchema

	/// <exclude/>
	public class CurrencyRate_PRMPortal_TerrasoftSchema : Terrasoft.Configuration.CurrencyRate_CrtUIv2_TerrasoftSchema
	{

		#region Constructors: Public

		public CurrencyRate_PRMPortal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CurrencyRate_PRMPortal_TerrasoftSchema(CurrencyRate_PRMPortal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CurrencyRate_PRMPortal_TerrasoftSchema(CurrencyRate_PRMPortal_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("43248feb-f6c3-42e6-b4f5-1be1fa15d8c0");
			Name = "CurrencyRate_PRMPortal_Terrasoft";
			ParentSchemaUId = new Guid("e14c6037-56bb-4724-95b6-3dc29d7f6b4f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5dec8cf0-d427-4401-87b1-204c8e96d1d4");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CurrencyRate_PRMPortal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CurrencyRate_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CurrencyRate_PRMPortal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CurrencyRate_PRMPortal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("43248feb-f6c3-42e6-b4f5-1be1fa15d8c0"));
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_PRMPortal_Terrasoft

	/// <summary>
	/// Exchange rate.
	/// </summary>
	public class CurrencyRate_PRMPortal_Terrasoft : Terrasoft.Configuration.CurrencyRate_CrtUIv2_Terrasoft
	{

		#region Constructors: Public

		public CurrencyRate_PRMPortal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CurrencyRate_PRMPortal_Terrasoft";
		}

		public CurrencyRate_PRMPortal_Terrasoft(CurrencyRate_PRMPortal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CurrencyRate_PRMPortalEventsProcess(UserConnection);
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
			return new CurrencyRate_PRMPortal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: CurrencyRate_PRMPortalEventsProcess

	/// <exclude/>
	public partial class CurrencyRate_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.CurrencyRate_CrtUIv2EventsProcess<TEntity> where TEntity : CurrencyRate_PRMPortal_Terrasoft
	{

		public CurrencyRate_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CurrencyRate_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("43248feb-f6c3-42e6-b4f5-1be1fa15d8c0");
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

	#region Class: CurrencyRate_PRMPortalEventsProcess

	/// <exclude/>
	public class CurrencyRate_PRMPortalEventsProcess : CurrencyRate_PRMPortalEventsProcess<CurrencyRate_PRMPortal_Terrasoft>
	{

		public CurrencyRate_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CurrencyRate_PRMPortalEventsProcess

	public partial class CurrencyRate_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

