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

	#region Class: HeaderPropertySchema

	/// <exclude/>
	public class HeaderPropertySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public HeaderPropertySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public HeaderPropertySchema(HeaderPropertySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public HeaderPropertySchema(HeaderPropertySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab");
			RealUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab");
			Name = "HeaderProperty";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d875cf44-2089-4c90-a894-025355d0d9a7");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("be0380b3-8214-4a8c-ab26-deea32aec690")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("bce02a0c-905a-45bd-99dd-c347de4a28b7")) == null) {
				Columns.Add(CreateHandlerColumn());
			}
			if (Columns.FindByUId(new Guid("59da2781-0bcf-42da-a7ef-535b038212dd")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("15047d04-3de4-9711-9e22-d02ac5ee2a10")) == null) {
				Columns.Add(CreateExcludedEmailAdressesColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("be0380b3-8214-4a8c-ab26-deea32aec690"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				ModifiedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				CreatedInPackageId = new Guid("d875cf44-2089-4c90-a894-025355d0d9a7")
			};
		}

		protected virtual EntitySchemaColumn CreateHandlerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("bce02a0c-905a-45bd-99dd-c347de4a28b7"),
				Name = @"Handler",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				ModifiedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				CreatedInPackageId = new Guid("d875cf44-2089-4c90-a894-025355d0d9a7")
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("59da2781-0bcf-42da-a7ef-535b038212dd"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				ModifiedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				CreatedInPackageId = new Guid("d875cf44-2089-4c90-a894-025355d0d9a7"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateExcludedEmailAdressesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("15047d04-3de4-9711-9e22-d02ac5ee2a10"),
				Name = @"ExcludedEmailAdresses",
				CreatedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				ModifiedInSchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"),
				CreatedInPackageId = new Guid("5e56df18-a9c1-41f6-9851-b62ebaeb3ee7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new HeaderProperty(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new HeaderProperty_CrtJunkFilterEventsProcess(userConnection);
		}

		public override object Clone() {
			return new HeaderPropertySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new HeaderPropertySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab"));
		}

		#endregion

	}

	#endregion

	#region Class: HeaderProperty

	/// <summary>
	/// Header Property.
	/// </summary>
	public class HeaderProperty : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public HeaderProperty(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "HeaderProperty";
		}

		public HeaderProperty(HeaderProperty source)
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
		/// Handler.
		/// </summary>
		public string Handler {
			get {
				return GetTypedColumnValue<string>("Handler");
			}
			set {
				SetColumnValue("Handler", value);
			}
		}

		/// <summary>
		/// Is Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Excluded email addresses.
		/// </summary>
		/// <remarks>
		/// Email addresses to which the rule will not be applied.
		/// </remarks>
		public string ExcludedEmailAdresses {
			get {
				return GetTypedColumnValue<string>("ExcludedEmailAdresses");
			}
			set {
				SetColumnValue("ExcludedEmailAdresses", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new HeaderProperty_CrtJunkFilterEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("HeaderPropertyDeleted", e);
			Validating += (s, e) => ThrowEvent("HeaderPropertyValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new HeaderProperty(this);
		}

		#endregion

	}

	#endregion

	#region Class: HeaderProperty_CrtJunkFilterEventsProcess

	/// <exclude/>
	public partial class HeaderProperty_CrtJunkFilterEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : HeaderProperty
	{

		public HeaderProperty_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "HeaderProperty_CrtJunkFilterEventsProcess";
			SchemaUId = new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("eabaec62-08cb-41b9-8466-4e93dbaa27ab");
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

	#region Class: HeaderProperty_CrtJunkFilterEventsProcess

	/// <exclude/>
	public class HeaderProperty_CrtJunkFilterEventsProcess : HeaderProperty_CrtJunkFilterEventsProcess<HeaderProperty>
	{

		public HeaderProperty_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: HeaderProperty_CrtJunkFilterEventsProcess

	public partial class HeaderProperty_CrtJunkFilterEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: HeaderPropertyEventsProcess

	/// <exclude/>
	public class HeaderPropertyEventsProcess : HeaderProperty_CrtJunkFilterEventsProcess
	{

		public HeaderPropertyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

