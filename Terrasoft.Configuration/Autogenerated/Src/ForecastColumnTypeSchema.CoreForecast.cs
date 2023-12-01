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

	#region Class: ForecastColumnTypeSchema

	/// <exclude/>
	public class ForecastColumnTypeSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public ForecastColumnTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastColumnTypeSchema(ForecastColumnTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastColumnTypeSchema(ForecastColumnTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173");
			RealUId = new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173");
			Name = "ForecastColumnType";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
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
			return new ForecastColumnType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastColumnType_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastColumnTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastColumnTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastColumnType

	/// <summary>
	/// Forecast column type.
	/// </summary>
	public class ForecastColumnType : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public ForecastColumnType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastColumnType";
		}

		public ForecastColumnType(ForecastColumnType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastColumnType_CoreForecastEventsProcess(UserConnection);
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
			return new ForecastColumnType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastColumnType_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastColumnType_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_CrtBaseEventsProcess<TEntity> where TEntity : ForecastColumnType
	{

		public ForecastColumnType_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastColumnType_CoreForecastEventsProcess";
			SchemaUId = new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("afa4fe55-a6da-4b54-b24b-ad6c53b5b173");
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

	#region Class: ForecastColumnType_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastColumnType_CoreForecastEventsProcess : ForecastColumnType_CoreForecastEventsProcess<ForecastColumnType>
	{

		public ForecastColumnType_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastColumnType_CoreForecastEventsProcess

	public partial class ForecastColumnType_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ForecastColumnTypeEventsProcess

	/// <exclude/>
	public class ForecastColumnTypeEventsProcess : ForecastColumnType_CoreForecastEventsProcess
	{

		public ForecastColumnTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

