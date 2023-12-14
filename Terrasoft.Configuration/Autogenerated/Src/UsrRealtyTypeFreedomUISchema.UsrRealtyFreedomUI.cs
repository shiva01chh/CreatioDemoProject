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

	#region Class: UsrRealtyTypeFreedomUISchema

	/// <exclude/>
	public class UsrRealtyTypeFreedomUISchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public UsrRealtyTypeFreedomUISchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public UsrRealtyTypeFreedomUISchema(UsrRealtyTypeFreedomUISchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public UsrRealtyTypeFreedomUISchema(UsrRealtyTypeFreedomUISchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df");
			RealUId = new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df");
			Name = "UsrRealtyTypeFreedomUI";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("312277fe-48cb-483e-a2cc-4c788b7ed430");
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
			return new UsrRealtyTypeFreedomUI(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new UsrRealtyTypeFreedomUISchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new UsrRealtyTypeFreedomUISchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df"));
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyTypeFreedomUI

	/// <summary>
	/// Realty type (FreedomUi).
	/// </summary>
	public class UsrRealtyTypeFreedomUI : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public UsrRealtyTypeFreedomUI(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "UsrRealtyTypeFreedomUI";
		}

		public UsrRealtyTypeFreedomUI(UsrRealtyTypeFreedomUI source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection);
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
			return new UsrRealtyTypeFreedomUI(this);
		}

		#endregion

	}

	#endregion

	#region Class: UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public partial class UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : UsrRealtyTypeFreedomUI
	{

		public UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess";
			SchemaUId = new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("38cfc984-cb4b-49f0-be25-2866a91fc9df");
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

	#region Class: UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess : UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<UsrRealtyTypeFreedomUI>
	{

		public UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess

	public partial class UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: UsrRealtyTypeFreedomUIEventsProcess

	/// <exclude/>
	public class UsrRealtyTypeFreedomUIEventsProcess : UsrRealtyTypeFreedomUI_UsrRealtyFreedomUIEventsProcess
	{

		public UsrRealtyTypeFreedomUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

