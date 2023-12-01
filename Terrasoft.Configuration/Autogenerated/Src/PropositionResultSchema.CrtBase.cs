﻿namespace Terrasoft.Configuration
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

	#region Class: PropositionResult_CrtBase_TerrasoftSchema

	/// <exclude/>
	public class PropositionResult_CrtBase_TerrasoftSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public PropositionResult_CrtBase_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PropositionResult_CrtBase_TerrasoftSchema(PropositionResult_CrtBase_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PropositionResult_CrtBase_TerrasoftSchema(PropositionResult_CrtBase_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("801a201c-7040-4489-a705-5896b20d2f52");
			RealUId = new Guid("801a201c-7040-4489-a705-5896b20d2f52");
			Name = "PropositionResult_CrtBase_Terrasoft";
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
			return new PropositionResult_CrtBase_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PropositionResult_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PropositionResult_CrtBase_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PropositionResult_CrtBase_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("801a201c-7040-4489-a705-5896b20d2f52"));
		}

		#endregion

	}

	#endregion

	#region Class: PropositionResult_CrtBase_Terrasoft

	/// <summary>
	/// Quote Result.
	/// </summary>
	public class PropositionResult_CrtBase_Terrasoft : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public PropositionResult_CrtBase_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PropositionResult_CrtBase_Terrasoft";
		}

		public PropositionResult_CrtBase_Terrasoft(PropositionResult_CrtBase_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PropositionResult_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("PropositionResult_CrtBase_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PropositionResult_CrtBase_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: PropositionResult_CrtBaseEventsProcess

	/// <exclude/>
	public partial class PropositionResult_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : PropositionResult_CrtBase_Terrasoft
	{

		public PropositionResult_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PropositionResult_CrtBaseEventsProcess";
			SchemaUId = new Guid("801a201c-7040-4489-a705-5896b20d2f52");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("801a201c-7040-4489-a705-5896b20d2f52");
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

	#region Class: PropositionResult_CrtBaseEventsProcess

	/// <exclude/>
	public class PropositionResult_CrtBaseEventsProcess : PropositionResult_CrtBaseEventsProcess<PropositionResult_CrtBase_Terrasoft>
	{

		public PropositionResult_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PropositionResult_CrtBaseEventsProcess

	public partial class PropositionResult_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

