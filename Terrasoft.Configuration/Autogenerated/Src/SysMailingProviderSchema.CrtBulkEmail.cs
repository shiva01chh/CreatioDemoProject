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

	#region Class: SysMailingProviderSchema

	/// <exclude/>
	public class SysMailingProviderSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysMailingProviderSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysMailingProviderSchema(SysMailingProviderSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysMailingProviderSchema(SysMailingProviderSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2");
			RealUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2");
			Name = "SysMailingProvider";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9fbc0634-e51a-4fee-a79c-112088e2c191");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8c3fc898-0860-4199-97e2-ec3216fcd025")) == null) {
				Columns.Add(CreateClassNameColumn());
			}
			if (Columns.FindByUId(new Guid("39435ad6-34da-413e-b86a-87ca56055b51")) == null) {
				Columns.Add(CreateConfigFactoryClassNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a6b6be32-cf64-4bdd-89ae-a2727bb9208b"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				ModifiedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				CreatedInPackageId = new Guid("9fbc0634-e51a-4fee-a79c-112088e2c191")
			};
		}

		protected virtual EntitySchemaColumn CreateClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("8c3fc898-0860-4199-97e2-ec3216fcd025"),
				Name = @"ClassName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				ModifiedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				CreatedInPackageId = new Guid("9fbc0634-e51a-4fee-a79c-112088e2c191")
			};
		}

		protected virtual EntitySchemaColumn CreateConfigFactoryClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("39435ad6-34da-413e-b86a-87ca56055b51"),
				Name = @"ConfigFactoryClassName",
				CreatedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				ModifiedInSchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"),
				CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysMailingProvider(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysMailingProvider_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysMailingProviderSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysMailingProviderSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2"));
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingProvider

	/// <summary>
	/// Mailing provider.
	/// </summary>
	public class SysMailingProvider : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysMailingProvider(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysMailingProvider";
		}

		public SysMailingProvider(SysMailingProvider source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Class name.
		/// </summary>
		public string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		/// <summary>
		/// The name of the factory class configuration.
		/// </summary>
		public string ConfigFactoryClassName {
			get {
				return GetTypedColumnValue<string>("ConfigFactoryClassName");
			}
			set {
				SetColumnValue("ConfigFactoryClassName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysMailingProvider_CrtBulkEmailEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SysMailingProviderDeleted", e);
			Validating += (s, e) => ThrowEvent("SysMailingProviderValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysMailingProvider(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysMailingProvider_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class SysMailingProvider_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysMailingProvider
	{

		public SysMailingProvider_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysMailingProvider_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c650470d-0201-49dc-bcfb-c9744d7de1f2");
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

	#region Class: SysMailingProvider_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class SysMailingProvider_CrtBulkEmailEventsProcess : SysMailingProvider_CrtBulkEmailEventsProcess<SysMailingProvider>
	{

		public SysMailingProvider_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysMailingProvider_CrtBulkEmailEventsProcess

	public partial class SysMailingProvider_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysMailingProviderEventsProcess

	/// <exclude/>
	public class SysMailingProviderEventsProcess : SysMailingProvider_CrtBulkEmailEventsProcess
	{

		public SysMailingProviderEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

