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

	#region Class: JunkFilterTypeOfFieldSchema

	/// <exclude/>
	public class JunkFilterTypeOfFieldSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public JunkFilterTypeOfFieldSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public JunkFilterTypeOfFieldSchema(JunkFilterTypeOfFieldSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public JunkFilterTypeOfFieldSchema(JunkFilterTypeOfFieldSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e");
			RealUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e");
			Name = "JunkFilterTypeOfField";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3df7b9b4-11dd-4530-b431-1bbd3c171eb9")) == null) {
				Columns.Add(CreateCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3df7b9b4-11dd-4530-b431-1bbd3c171eb9"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e"),
				ModifiedInSchemaUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e"),
				CreatedInPackageId = new Guid("59955e0a-90db-4796-8f0c-f9403b7d622f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new JunkFilterTypeOfField(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new JunkFilterTypeOfField_CrtJunkFilterEventsProcess(userConnection);
		}

		public override object Clone() {
			return new JunkFilterTypeOfFieldSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new JunkFilterTypeOfFieldSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e"));
		}

		#endregion

	}

	#endregion

	#region Class: JunkFilterTypeOfField

	/// <summary>
	/// Type of field value "Email address or Domain".
	/// </summary>
	public class JunkFilterTypeOfField : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public JunkFilterTypeOfField(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "JunkFilterTypeOfField";
		}

		public JunkFilterTypeOfField(JunkFilterTypeOfField source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new JunkFilterTypeOfField_CrtJunkFilterEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("JunkFilterTypeOfFieldDeleted", e);
			Validating += (s, e) => ThrowEvent("JunkFilterTypeOfFieldValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new JunkFilterTypeOfField(this);
		}

		#endregion

	}

	#endregion

	#region Class: JunkFilterTypeOfField_CrtJunkFilterEventsProcess

	/// <exclude/>
	public partial class JunkFilterTypeOfField_CrtJunkFilterEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : JunkFilterTypeOfField
	{

		public JunkFilterTypeOfField_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "JunkFilterTypeOfField_CrtJunkFilterEventsProcess";
			SchemaUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e");
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

	#region Class: JunkFilterTypeOfField_CrtJunkFilterEventsProcess

	/// <exclude/>
	public class JunkFilterTypeOfField_CrtJunkFilterEventsProcess : JunkFilterTypeOfField_CrtJunkFilterEventsProcess<JunkFilterTypeOfField>
	{

		public JunkFilterTypeOfField_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: JunkFilterTypeOfField_CrtJunkFilterEventsProcess

	public partial class JunkFilterTypeOfField_CrtJunkFilterEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: JunkFilterTypeOfFieldEventsProcess

	/// <exclude/>
	public class JunkFilterTypeOfFieldEventsProcess : JunkFilterTypeOfField_CrtJunkFilterEventsProcess
	{

		public JunkFilterTypeOfFieldEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

