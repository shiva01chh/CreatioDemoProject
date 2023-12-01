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
	using Terrasoft.Configuration;
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

	#region Class: InvoiceFileSchema

	/// <exclude/>
	public class InvoiceFileSchema : Terrasoft.Configuration.InvoiceFile_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceFileSchema(InvoiceFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceFileSchema(InvoiceFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0a159f66-0538-44ae-bebd-6f0427882256");
			Name = "InvoiceFile";
			ParentSchemaUId = new Guid("e7d51836-a27a-4e52-979c-29d114414085");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceFile_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a159f66-0538-44ae-bebd-6f0427882256"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFile

	/// <summary>
	/// File and link of invoice.
	/// </summary>
	public class InvoiceFile : Terrasoft.Configuration.InvoiceFile_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceFile";
		}

		public InvoiceFile(InvoiceFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceFile_InvoiceEventsProcess(UserConnection);
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
			return new InvoiceFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceFile_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceFile_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceFile_CrtInvoiceEventsProcess<TEntity> where TEntity : InvoiceFile
	{

		public InvoiceFile_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceFile_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0a159f66-0538-44ae-bebd-6f0427882256");
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

	#region Class: InvoiceFile_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceFile_InvoiceEventsProcess : InvoiceFile_InvoiceEventsProcess<InvoiceFile>
	{

		public InvoiceFile_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: InvoiceFileEventsProcess

	/// <exclude/>
	public class InvoiceFileEventsProcess : InvoiceFile_InvoiceEventsProcess
	{

		public InvoiceFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

