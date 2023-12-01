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

	#region Class: RegisterMethodSchema

	/// <exclude/>
	public class RegisterMethodSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public RegisterMethodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RegisterMethodSchema(RegisterMethodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RegisterMethodSchema(RegisterMethodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e");
			RealUId = new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e");
			Name = "RegisterMethod";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0e74fb48-a0ce-4417-b434-af5bdf82876e");
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
			return new RegisterMethod(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new RegisterMethod_CrtTouchPointEventsProcess(userConnection);
		}

		public override object Clone() {
			return new RegisterMethodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RegisterMethodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e"));
		}

		#endregion

	}

	#endregion

	#region Class: RegisterMethod

	/// <summary>
	/// Registration method.
	/// </summary>
	public class RegisterMethod : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public RegisterMethod(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RegisterMethod";
		}

		public RegisterMethod(RegisterMethod source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RegisterMethod_CrtTouchPointEventsProcess(UserConnection);
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
			return new RegisterMethod(this);
		}

		#endregion

	}

	#endregion

	#region Class: RegisterMethod_CrtTouchPointEventsProcess

	/// <exclude/>
	public partial class RegisterMethod_CrtTouchPointEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : RegisterMethod
	{

		public RegisterMethod_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RegisterMethod_CrtTouchPointEventsProcess";
			SchemaUId = new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("39351852-e9f3-4e9a-8fe5-34fac385654e");
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

	#region Class: RegisterMethod_CrtTouchPointEventsProcess

	/// <exclude/>
	public class RegisterMethod_CrtTouchPointEventsProcess : RegisterMethod_CrtTouchPointEventsProcess<RegisterMethod>
	{

		public RegisterMethod_CrtTouchPointEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RegisterMethod_CrtTouchPointEventsProcess

	public partial class RegisterMethod_CrtTouchPointEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: RegisterMethodEventsProcess

	/// <exclude/>
	public class RegisterMethodEventsProcess : RegisterMethod_CrtTouchPointEventsProcess
	{

		public RegisterMethodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

