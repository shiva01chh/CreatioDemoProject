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

	#region Class: AddressType_SSP_TerrasoftSchema

	/// <exclude/>
	public class AddressType_SSP_TerrasoftSchema : Terrasoft.Configuration.AddressType_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public AddressType_SSP_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AddressType_SSP_TerrasoftSchema(AddressType_SSP_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AddressType_SSP_TerrasoftSchema(AddressType_SSP_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("797de413-d31b-43ae-b5fa-fd9f41059208");
			Name = "AddressType_SSP_Terrasoft";
			ParentSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
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
			return new AddressType_SSP_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AddressType_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AddressType_SSP_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AddressType_SSP_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("797de413-d31b-43ae-b5fa-fd9f41059208"));
		}

		#endregion

	}

	#endregion

	#region Class: AddressType_SSP_Terrasoft

	/// <summary>
	/// Address type.
	/// </summary>
	public class AddressType_SSP_Terrasoft : Terrasoft.Configuration.AddressType_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public AddressType_SSP_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AddressType_SSP_Terrasoft";
		}

		public AddressType_SSP_Terrasoft(AddressType_SSP_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AddressType_SSPEventsProcess(UserConnection);
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
			return new AddressType_SSP_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AddressType_SSPEventsProcess

	/// <exclude/>
	public partial class AddressType_SSPEventsProcess<TEntity> : Terrasoft.Configuration.AddressType_CrtBaseEventsProcess<TEntity> where TEntity : AddressType_SSP_Terrasoft
	{

		public AddressType_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AddressType_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("797de413-d31b-43ae-b5fa-fd9f41059208");
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

	#region Class: AddressType_SSPEventsProcess

	/// <exclude/>
	public class AddressType_SSPEventsProcess : AddressType_SSPEventsProcess<AddressType_SSP_Terrasoft>
	{

		public AddressType_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AddressType_SSPEventsProcess

	public partial class AddressType_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

