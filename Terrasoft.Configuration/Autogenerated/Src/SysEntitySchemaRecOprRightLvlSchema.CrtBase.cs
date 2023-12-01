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

	#region Class: SysEntitySchemaRecOprRightLvlSchema

	/// <exclude/>
	public class SysEntitySchemaRecOprRightLvlSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecOprRightLvlSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntitySchemaRecOprRightLvlSchema(SysEntitySchemaRecOprRightLvlSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntitySchemaRecOprRightLvlSchema(SysEntitySchemaRecOprRightLvlSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			RealUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			Name = "SysEntitySchemaRecOprRightLvl";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
			DesignLocalizationSchemaName = @"SysEntitySchRecOprRightLvlLcz";
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("595b0778-9ac6-4789-b297-438c8a68f445")) == null) {
				Columns.Add(CreateValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			return column;
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("595b0778-9ac6-4789-b297-438c8a68f445"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e"),
				ModifiedInSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntitySchemaRecOprRightLvl(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysEntitySchemaRecOprRightLvlSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntitySchemaRecOprRightLvlSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecOprRightLvl

	/// <summary>
	/// Operation Permission.
	/// </summary>
	public class SysEntitySchemaRecOprRightLvl : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysEntitySchemaRecOprRightLvl(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntitySchemaRecOprRightLvl";
		}

		public SysEntitySchemaRecOprRightLvl(SysEntitySchemaRecOprRightLvl source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Value.
		/// </summary>
		public int Value {
			get {
				return GetTypedColumnValue<int>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlDeleted", e);
			Deleting += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntitySchemaRecOprRightLvlValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaRecOprRightLvl(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : SysEntitySchemaRecOprRightLvl
	{

		public SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess";
			SchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e");
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

	#region Class: SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess : SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess<SysEntitySchemaRecOprRightLvl>
	{

		public SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess

	public partial class SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysEntitySchemaRecOprRightLvlEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecOprRightLvlEventsProcess : SysEntitySchemaRecOprRightLvl_CrtBaseEventsProcess
	{

		public SysEntitySchemaRecOprRightLvlEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

