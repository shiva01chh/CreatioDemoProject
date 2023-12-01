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
	using System.Security;
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
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: ServiceItemTagSchema

	/// <exclude/>
	public class ServiceItemTagSchema : Terrasoft.Configuration.BaseTagSchema
	{

		#region Constructors: Public

		public ServiceItemTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceItemTagSchema(ServiceItemTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceItemTagSchema(ServiceItemTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98");
			RealUId = new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98");
			Name = "ServiceItemTag";
			ParentSchemaUId = new Guid("9e3f203c-e905-4de5-9468-335b193f2439");
			ExtendParent = false;
			CreatedInPackageId = new Guid("dfe2c6b5-61e8-4e57-95ae-a3c34fa0908f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateTypeColumn() {
			EntitySchemaColumn column = base.CreateTypeColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.Const,
				ValueSource = @"8d7f6d6c-4ca5-4b43-bdd9-a5e01a582260"
			};
			column.ModifiedInSchemaUId = new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceItemTag(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ServiceItemTag_CrtSLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ServiceItemTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceItemTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItemTag

	/// <summary>
	/// Services section tag.
	/// </summary>
	public class ServiceItemTag : Terrasoft.Configuration.BaseTag
	{

		#region Constructors: Public

		public ServiceItemTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceItemTag";
		}

		public ServiceItemTag(ServiceItemTag source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceItemTag_CrtSLMEventsProcess(UserConnection);
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
			return new ServiceItemTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItemTag_CrtSLMEventsProcess

	/// <exclude/>
	public partial class ServiceItemTag_CrtSLMEventsProcess<TEntity> : Terrasoft.Configuration.BaseTag_SSPEventsProcess<TEntity> where TEntity : ServiceItemTag
	{

		public ServiceItemTag_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceItemTag_CrtSLMEventsProcess";
			SchemaUId = new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c2e89258-8c9d-4973-ac4b-6ee99e078d98");
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

	#region Class: ServiceItemTag_CrtSLMEventsProcess

	/// <exclude/>
	public class ServiceItemTag_CrtSLMEventsProcess : ServiceItemTag_CrtSLMEventsProcess<ServiceItemTag>
	{

		public ServiceItemTag_CrtSLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceItemTag_CrtSLMEventsProcess

	public partial class ServiceItemTag_CrtSLMEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void CheckTagTypeAndGrantAdditionalRights() {
			base.CheckTagTypeAndGrantAdditionalRights();
			Guid typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (typeId == TSConfiguration.TagConsts.PublicTagTypeUId) {
				UserConnection.DBSecurityEngine.SetEntitySchemaRecordRightLevel(TSConfiguration.BaseConsts.PortalUsersSysAdminUnitUId, 
						Entity.Schema, Entity.PrimaryColumnValue, SchemaRecordRightLevels.All); 
			}
		}

		#endregion

	}

	#endregion


	#region Class: ServiceItemTagEventsProcess

	/// <exclude/>
	public class ServiceItemTagEventsProcess : ServiceItemTag_CrtSLMEventsProcess
	{

		public ServiceItemTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

