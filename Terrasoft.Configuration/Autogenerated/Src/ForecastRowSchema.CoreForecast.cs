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

	#region Class: ForecastRowSchema

	/// <exclude/>
	public class ForecastRowSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ForecastRowSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ForecastRowSchema(ForecastRowSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ForecastRowSchema(ForecastRowSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01");
			RealUId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01");
			Name = "ForecastRow";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			if (Columns.FindByUId(new Guid("3eccb7be-b83a-3119-3f61-fd27a976083d")) == null) {
				Columns.Add(CreateDeletedOnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDeletedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("3eccb7be-b83a-3119-3f61-fd27a976083d"),
				Name = @"DeletedOn",
				CreatedInSchemaUId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01"),
				ModifiedInSchemaUId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01"),
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ForecastRow(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ForecastRow_CoreForecastEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ForecastRowSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ForecastRowSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01"));
		}

		#endregion

	}

	#endregion

	#region Class: ForecastRow

	/// <summary>
	/// Forecast row.
	/// </summary>
	public class ForecastRow : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ForecastRow(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ForecastRow";
		}

		public ForecastRow(ForecastRow source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Deleted on.
		/// </summary>
		public DateTime DeletedOn {
			get {
				return GetTypedColumnValue<DateTime>("DeletedOn");
			}
			set {
				SetColumnValue("DeletedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ForecastRow_CoreForecastEventsProcess(UserConnection);
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
			return new ForecastRow(this);
		}

		#endregion

	}

	#endregion

	#region Class: ForecastRow_CoreForecastEventsProcess

	/// <exclude/>
	public partial class ForecastRow_CoreForecastEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ForecastRow
	{

		public ForecastRow_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ForecastRow_CoreForecastEventsProcess";
			SchemaUId = new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("01fb1058-f049-48ab-96fb-cbe5989efe01");
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

	#region Class: ForecastRow_CoreForecastEventsProcess

	/// <exclude/>
	public class ForecastRow_CoreForecastEventsProcess : ForecastRow_CoreForecastEventsProcess<ForecastRow>
	{

		public ForecastRow_CoreForecastEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ForecastRow_CoreForecastEventsProcess

	public partial class ForecastRow_CoreForecastEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ForecastRowEventsProcess

	/// <exclude/>
	public class ForecastRowEventsProcess : ForecastRow_CoreForecastEventsProcess
	{

		public ForecastRowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

