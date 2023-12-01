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

	#region Class: InvoiceFolderSchema

	/// <exclude/>
	public class InvoiceFolderSchema : Terrasoft.Configuration.InvoiceFolder_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceFolderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceFolderSchema(InvoiceFolderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceFolderSchema(InvoiceFolderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("bb8b3bdb-f588-4a45-890d-17bbb856b560");
			Name = "InvoiceFolder";
			ParentSchemaUId = new Guid("23fef840-9ef8-4a5b-b558-7dae5b7ff672");
			ExtendParent = true;
			CreatedInPackageId = new Guid("0831ed7d-04c4-455d-af2c-3fdb5376a294");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = false;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateFolderTypeColumn() {
			EntitySchemaColumn column = base.CreateFolderTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"9dc5f6e6-2a61-4de8-a059-de30f4e74f24"
			};
			column.ModifiedInSchemaUId = new Guid("bb8b3bdb-f588-4a45-890d-17bbb856b560");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceFolder(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceFolder_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceFolderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceFolderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb8b3bdb-f588-4a45-890d-17bbb856b560"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFolder

	/// <summary>
	/// Invoice folder.
	/// </summary>
	public class InvoiceFolder : Terrasoft.Configuration.InvoiceFolder_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceFolder(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceFolder";
		}

		public InvoiceFolder(InvoiceFolder source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceFolder_InvoiceEventsProcess(UserConnection);
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
			return new InvoiceFolder(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFolder_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceFolder_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceFolder_CrtInvoiceEventsProcess<TEntity> where TEntity : InvoiceFolder
	{

		public InvoiceFolder_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceFolder_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bb8b3bdb-f588-4a45-890d-17bbb856b560");
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

	#region Class: InvoiceFolder_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceFolder_InvoiceEventsProcess : InvoiceFolder_InvoiceEventsProcess<InvoiceFolder>
	{

		public InvoiceFolder_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: InvoiceFolderEventsProcess

	/// <exclude/>
	public class InvoiceFolderEventsProcess : InvoiceFolder_InvoiceEventsProcess
	{

		public InvoiceFolderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

