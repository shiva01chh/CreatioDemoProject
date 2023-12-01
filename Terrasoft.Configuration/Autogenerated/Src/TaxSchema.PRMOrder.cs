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

	#region Class: TaxSchema

	/// <exclude/>
	public class TaxSchema : Terrasoft.Configuration.Tax_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public TaxSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TaxSchema(TaxSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TaxSchema(TaxSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1241f15c-9dee-4644-9b0c-e20a98ad9a83");
			Name = "Tax";
			ParentSchemaUId = new Guid("a32b5f57-0ef1-4d3d-a6ef-a6de2113fbe0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ef9e3a4b-870b-42cf-a5ab-6aac623cd0fe");
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
			return new Tax(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Tax_PRMOrderEventsProcess(userConnection);
		}

		public override object Clone() {
			return new TaxSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TaxSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1241f15c-9dee-4644-9b0c-e20a98ad9a83"));
		}

		#endregion

	}

	#endregion

	#region Class: Tax

	/// <summary>
	/// Tax.
	/// </summary>
	public class Tax : Terrasoft.Configuration.Tax_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Tax(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Tax";
		}

		public Tax(Tax source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Tax_PRMOrderEventsProcess(UserConnection);
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
			return new Tax(this);
		}

		#endregion

	}

	#endregion

	#region Class: Tax_PRMOrderEventsProcess

	/// <exclude/>
	public partial class Tax_PRMOrderEventsProcess<TEntity> : Terrasoft.Configuration.Tax_CrtBaseEventsProcess<TEntity> where TEntity : Tax
	{

		public Tax_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Tax_PRMOrderEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1241f15c-9dee-4644-9b0c-e20a98ad9a83");
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

	#region Class: Tax_PRMOrderEventsProcess

	/// <exclude/>
	public class Tax_PRMOrderEventsProcess : Tax_PRMOrderEventsProcess<Tax>
	{

		public Tax_PRMOrderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Tax_PRMOrderEventsProcess

	public partial class Tax_PRMOrderEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: TaxEventsProcess

	/// <exclude/>
	public class TaxEventsProcess : Tax_PRMOrderEventsProcess
	{

		public TaxEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

