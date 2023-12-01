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

	#region Class: SysWorkplaceSchema

	/// <exclude/>
	public class SysWorkplaceSchema : Terrasoft.Configuration.SysWorkplace_CrtNUI_TerrasoftSchema
	{

		#region Constructors: Public

		public SysWorkplaceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysWorkplaceSchema(SysWorkplaceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysWorkplaceSchema(SysWorkplaceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("008aec22-5e64-45aa-a333-88a586ab0216");
			Name = "SysWorkplace";
			ParentSchemaUId = new Guid("f54121e1-d75d-42e0-b790-bc8aa0bb216c");
			ExtendParent = true;
			CreatedInPackageId = new Guid("25822d5f-097b-4b24-b0f2-6524204c151c");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d3a42fb5-39c6-09fc-54d1-5071e61f145e")) == null) {
				Columns.Add(CreateHomePageUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateHomePageUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("d3a42fb5-39c6-09fc-54d1-5071e61f145e"),
				Name = @"HomePageUId",
				CreatedInSchemaUId = new Guid("008aec22-5e64-45aa-a333-88a586ab0216"),
				ModifiedInSchemaUId = new Guid("008aec22-5e64-45aa-a333-88a586ab0216"),
				CreatedInPackageId = new Guid("25822d5f-097b-4b24-b0f2-6524204c151c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysWorkplace(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysWorkplace_HomePageEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysWorkplaceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysWorkplaceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("008aec22-5e64-45aa-a333-88a586ab0216"));
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkplace

	/// <summary>
	/// User's workplace.
	/// </summary>
	public class SysWorkplace : Terrasoft.Configuration.SysWorkplace_CrtNUI_Terrasoft
	{

		#region Constructors: Public

		public SysWorkplace(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysWorkplace";
		}

		public SysWorkplace(SysWorkplace source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Home page schema identifier.
		/// </summary>
		public Guid HomePageUId {
			get {
				return GetTypedColumnValue<Guid>("HomePageUId");
			}
			set {
				SetColumnValue("HomePageUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysWorkplace_HomePageEventsProcess(UserConnection);
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
			return new SysWorkplace(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysWorkplace_HomePageEventsProcess

	/// <exclude/>
	public partial class SysWorkplace_HomePageEventsProcess<TEntity> : Terrasoft.Configuration.SysWorkplace_CrtNUIEventsProcess<TEntity> where TEntity : SysWorkplace
	{

		public SysWorkplace_HomePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysWorkplace_HomePageEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("008aec22-5e64-45aa-a333-88a586ab0216");
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

	#region Class: SysWorkplace_HomePageEventsProcess

	/// <exclude/>
	public class SysWorkplace_HomePageEventsProcess : SysWorkplace_HomePageEventsProcess<SysWorkplace>
	{

		public SysWorkplace_HomePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysWorkplace_HomePageEventsProcess

	public partial class SysWorkplace_HomePageEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysWorkplaceEventsProcess

	/// <exclude/>
	public class SysWorkplaceEventsProcess : SysWorkplace_HomePageEventsProcess
	{

		public SysWorkplaceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

