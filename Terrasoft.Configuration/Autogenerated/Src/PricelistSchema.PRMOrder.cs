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

	#region Class: PricelistSchema

	/// <exclude/>
	public class PricelistSchema : Terrasoft.Configuration.Pricelist_CrtProductCatalogue_TerrasoftSchema
	{

		#region Constructors: Public

		public PricelistSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PricelistSchema(PricelistSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PricelistSchema(PricelistSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("56829f24-bc59-4bca-951d-5c7fdbceb827");
			Name = "Pricelist";
			ParentSchemaUId = new Guid("036f6f5b-838d-4187-9749-b54c8539c076");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e575b496-539f-4b26-8ba5-4be2dab7e3d9");
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
			return new Pricelist(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Pricelist_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PricelistSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PricelistSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56829f24-bc59-4bca-951d-5c7fdbceb827"));
		}

		#endregion

	}

	#endregion

	#region Class: Pricelist

	/// <summary>
	/// Price list.
	/// </summary>
	public class Pricelist : Terrasoft.Configuration.Pricelist_CrtProductCatalogue_Terrasoft
	{

		#region Constructors: Public

		public Pricelist(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Pricelist";
		}

		public Pricelist(Pricelist source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Pricelist_PRMOrderEventsProcess(UserConnection);
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
			return new Pricelist(this);
		}

		#endregion

	}

	#endregion

	#region Class: Pricelist_PRMOrderEventsProcess

	/// <exclude/>
	public partial class Pricelist_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.Pricelist_CrtProductCatalogueEventsProcess<TEntity> where TEntity : Pricelist
	{

		public Pricelist_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Pricelist_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("56829f24-bc59-4bca-951d-5c7fdbceb827");
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

	#region Class: Pricelist_PRMOrderEventsProcess

	/// <exclude/>
	public class Pricelist_PRMOrderEventsProcess : Pricelist_PRMOrderEventsProcess<Pricelist>
	{

		public Pricelist_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Pricelist_PRMOrderEventsProcess

	public partial class Pricelist_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: PricelistEventsProcess

	/// <exclude/>
	public class PricelistEventsProcess : Pricelist_PRMOrderEventsProcess
	{

		public PricelistEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

