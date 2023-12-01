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

	#region Class: StageBaseSchema

	/// <exclude/>
	[IsVirtual]
	public class StageBaseSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public StageBaseSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public StageBaseSchema(StageBaseSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public StageBaseSchema(StageBaseSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0");
			RealUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0");
			Name = "StageBase";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3b198fb6-968b-4a44-a709-bb3aee6eb088")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("5dbf4105-95e5-4343-b4d3-e1310810649d")) == null) {
				Columns.Add(CreateEndColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3b198fb6-968b-4a44-a709-bb3aee6eb088"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0"),
				ModifiedInSchemaUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected virtual EntitySchemaColumn CreateEndColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5dbf4105-95e5-4343-b4d3-e1310810649d"),
				Name = @"End",
				CreatedInSchemaUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0"),
				ModifiedInSchemaUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0"),
				CreatedInPackageId = new Guid("7e406f3f-0514-4d14-a20b-c3a59a45194f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new StageBase(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new StageBase_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new StageBaseSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new StageBaseSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0"));
		}

		#endregion

	}

	#endregion

	#region Class: StageBase

	/// <summary>
	/// Stage lookup base.
	/// </summary>
	public class StageBase : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public StageBase(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "StageBase";
		}

		public StageBase(StageBase source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Stage number.
		/// </summary>
		public int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Is final stage.
		/// </summary>
		public bool End {
			get {
				return GetTypedColumnValue<bool>("End");
			}
			set {
				SetColumnValue("End", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new StageBase_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("StageBaseDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new StageBase(this);
		}

		#endregion

	}

	#endregion

	#region Class: StageBase_CrtBaseEventsProcess

	/// <exclude/>
	public partial class StageBase_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : StageBase
	{

		public StageBase_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "StageBase_CrtBaseEventsProcess";
			SchemaUId = new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("abfca35d-0bd5-4433-aaed-bfaa10d109a0");
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

	#region Class: StageBase_CrtBaseEventsProcess

	/// <exclude/>
	public class StageBase_CrtBaseEventsProcess : StageBase_CrtBaseEventsProcess<StageBase>
	{

		public StageBase_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: StageBase_CrtBaseEventsProcess

	public partial class StageBase_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: StageBaseEventsProcess

	/// <exclude/>
	public class StageBaseEventsProcess : StageBase_CrtBaseEventsProcess
	{

		public StageBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

