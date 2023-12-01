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

	#region Class: OppContactRole_CrtOpportunity_TerrasoftSchema

	/// <exclude/>
	public class OppContactRole_CrtOpportunity_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public OppContactRole_CrtOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public OppContactRole_CrtOpportunity_TerrasoftSchema(OppContactRole_CrtOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public OppContactRole_CrtOpportunity_TerrasoftSchema(OppContactRole_CrtOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			RealUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			Name = "OppContactRole_CrtOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			column.CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new OppContactRole_CrtOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new OppContactRole_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new OppContactRole_CrtOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new OppContactRole_CrtOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7"));
		}

		#endregion

	}

	#endregion

	#region Class: OppContactRole_CrtOpportunity_Terrasoft

	/// <summary>
	/// Contact's role in opportunity.
	/// </summary>
	public class OppContactRole_CrtOpportunity_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public OppContactRole_CrtOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "OppContactRole_CrtOpportunity_Terrasoft";
		}

		public OppContactRole_CrtOpportunity_Terrasoft(OppContactRole_CrtOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new OppContactRole_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("OppContactRole_CrtOpportunity_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("OppContactRole_CrtOpportunity_TerrasoftInserting", e);
			Validating += (s, e) => ThrowEvent("OppContactRole_CrtOpportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new OppContactRole_CrtOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: OppContactRole_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class OppContactRole_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : OppContactRole_CrtOpportunity_Terrasoft
	{

		public OppContactRole_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppContactRole_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a85932a3-30a5-49d7-9627-7f749a055ab7");
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

	#region Class: OppContactRole_CrtOpportunityEventsProcess

	/// <exclude/>
	public class OppContactRole_CrtOpportunityEventsProcess : OppContactRole_CrtOpportunityEventsProcess<OppContactRole_CrtOpportunity_Terrasoft>
	{

		public OppContactRole_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: OppContactRole_CrtOpportunityEventsProcess

	public partial class OppContactRole_CrtOpportunityEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

