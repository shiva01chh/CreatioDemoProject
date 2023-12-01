namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: InvoiceVisaSchema

	/// <exclude/>
	public class InvoiceVisaSchema : Terrasoft.Configuration.InvoiceVisa_CrtInvoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceVisaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceVisaSchema(InvoiceVisaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceVisaSchema(InvoiceVisaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("afd81377-07de-4ff5-84ed-d15fd1dc68ee");
			Name = "InvoiceVisa";
			ParentSchemaUId = new Guid("ec034d19-5185-497d-9066-29f2973037f1");
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
			return new InvoiceVisa(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new InvoiceVisa_InvoiceEventsProcess(userConnection);
		}

		public override object Clone() {
			return new InvoiceVisaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceVisaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afd81377-07de-4ff5-84ed-d15fd1dc68ee"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa

	/// <summary>
	/// Invoice approval .
	/// </summary>
	public class InvoiceVisa : Terrasoft.Configuration.InvoiceVisa_CrtInvoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceVisa(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceVisa";
		}

		public InvoiceVisa(InvoiceVisa source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceVisa_InvoiceEventsProcess(UserConnection);
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
			return new InvoiceVisa(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceVisa_InvoiceEventsProcess

	/// <exclude/>
	public partial class InvoiceVisa_InvoiceEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceVisa_CrtInvoiceEventsProcess<TEntity> where TEntity : InvoiceVisa
	{

		public InvoiceVisa_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceVisa_InvoiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("afd81377-07de-4ff5-84ed-d15fd1dc68ee");
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

	#region Class: InvoiceVisa_InvoiceEventsProcess

	/// <exclude/>
	public class InvoiceVisa_InvoiceEventsProcess : InvoiceVisa_InvoiceEventsProcess<InvoiceVisa>
	{

		public InvoiceVisa_InvoiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion


	#region Class: InvoiceVisaEventsProcess

	/// <exclude/>
	public class InvoiceVisaEventsProcess : InvoiceVisa_InvoiceEventsProcess
	{

		public InvoiceVisaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

