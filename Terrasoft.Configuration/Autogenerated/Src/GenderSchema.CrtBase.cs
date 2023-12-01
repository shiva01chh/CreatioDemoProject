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

	#region Class: Gender_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class Gender_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public Gender_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Gender_CrtBase_TerrasoftSchema(Gender_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Gender_CrtBase_TerrasoftSchema(Gender_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120");
			RealUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120");
			Name = "Gender_CrtBase_Terrasoft";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new Gender_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Gender_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Gender_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Gender_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120"));
		}

		#endregion

	}

	#endregion

	#region Class: Gender_CrtBase_Terrasoft

	/// <summary>
	/// Gender.
	/// </summary>
	public class Gender_CrtBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Gender_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Gender_CrtBase_Terrasoft";
		}

		public Gender_CrtBase_Terrasoft(Gender_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Gender_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Gender_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Gender_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Gender_CrtBaseEventsProcess

	/// <exclude/>
	public partial class Gender_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : Gender_CrtBase_Terrasoft
	{

		public Gender_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Gender_CrtBaseEventsProcess";
			SchemaUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120");
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

	#region Class: Gender_CrtBaseEventsProcess

	/// <exclude/>
	public class Gender_CrtBaseEventsProcess : Gender_CrtBaseEventsProcess<Gender_CrtBase_Terrasoft>
	{

		public Gender_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Gender_CrtBaseEventsProcess

	public partial class Gender_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

