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

	#region Class: SysSettingsRightsSchema

	/// <exclude/>
	public class SysSettingsRightsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSettingsRightsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSettingsRightsSchema(SysSettingsRightsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSettingsRightsSchema(SysSettingsRightsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIvyrY7L49OyjFyuk8DRTHSArtTcIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("aa3a7a07-c9ce-4d54-9559-af4332e6d0b3");
			index.Name = "IvyrY7L49OyjFyuk8DRTHSArtTc";
			index.CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			index.ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			index.CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			EntitySchemaIndexColumn sysSettingsCodeIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2598d90e-4593-4bf1-8593-13facdd63a16"),
				ColumnUId = new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0"),
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sysSettingsCodeIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			RealUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			Name = "SysSettingsRights";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0")) == null) {
				Columns.Add(CreateSysSettingsCodeColumn());
			}
			if (Columns.FindByUId(new Guid("9f37604b-7361-4e21-9abf-8c357922d9a0")) == null) {
				Columns.Add(CreateReadOperationCodeColumn());
			}
			if (Columns.FindByUId(new Guid("d92aec3b-cfd9-40c2-b613-b71690edbeb8")) == null) {
				Columns.Add(CreateReadWriteOperationCodeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysSettingsCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("5e6eb364-6b37-4993-bafe-8688c8f83fa0"),
				Name = @"SysSettingsCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected virtual EntitySchemaColumn CreateReadOperationCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("9f37604b-7361-4e21-9abf-8c357922d9a0"),
				Name = @"ReadOperationCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected virtual EntitySchemaColumn CreateReadWriteOperationCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d92aec3b-cfd9-40c2-b613-b71690edbeb8"),
				Name = @"ReadWriteOperationCode",
				CreatedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				ModifiedInSchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"),
				CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIvyrY7L49OyjFyuk8DRTHSArtTcIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSettingsRights(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SysSettingsRights_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SysSettingsRightsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSettingsRightsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsRights

	/// <summary>
	/// SysSettingsRights.
	/// </summary>
	public class SysSettingsRights : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSettingsRights(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSettingsRights";
		}

		public SysSettingsRights(SysSettingsRights source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SysSettingsCode.
		/// </summary>
		public string SysSettingsCode {
			get {
				return GetTypedColumnValue<string>("SysSettingsCode");
			}
			set {
				SetColumnValue("SysSettingsCode", value);
			}
		}

		/// <summary>
		/// ReadOperationCode.
		/// </summary>
		public string ReadOperationCode {
			get {
				return GetTypedColumnValue<string>("ReadOperationCode");
			}
			set {
				SetColumnValue("ReadOperationCode", value);
			}
		}

		/// <summary>
		/// ReadWriteOperationCode.
		/// </summary>
		public string ReadWriteOperationCode {
			get {
				return GetTypedColumnValue<string>("ReadWriteOperationCode");
			}
			set {
				SetColumnValue("ReadWriteOperationCode", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSettingsRights_CrtBaseEventsProcess(UserConnection);
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
			return new SysSettingsRights(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSettingsRights_CrtBaseEventsProcess

	/// <exclude/>
	public partial class SysSettingsRights_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysSettingsRights
	{

		public SysSettingsRights_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSettingsRights_CrtBaseEventsProcess";
			SchemaUId = new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5eb3ec0a-6c9b-493c-8b35-8c82d0fbe93c");
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

	#region Class: SysSettingsRights_CrtBaseEventsProcess

	/// <exclude/>
	public class SysSettingsRights_CrtBaseEventsProcess : SysSettingsRights_CrtBaseEventsProcess<SysSettingsRights>
	{

		public SysSettingsRights_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSettingsRights_CrtBaseEventsProcess

	public partial class SysSettingsRights_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SysSettingsRightsEventsProcess

	/// <exclude/>
	public class SysSettingsRightsEventsProcess : SysSettingsRights_CrtBaseEventsProcess
	{

		public SysSettingsRightsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

