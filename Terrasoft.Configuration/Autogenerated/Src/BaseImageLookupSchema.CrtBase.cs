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

	#region Class: BaseImageLookupSchema

	/// <exclude/>
	[IsVirtual]
	public class BaseImageLookupSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BaseImageLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BaseImageLookupSchema(BaseImageLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BaseImageLookupSchema(BaseImageLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087");
			RealUId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087");
			Name = "BaseImageLookup";
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
			if (Columns.FindByUId(new Guid("7a8944fa-b3f0-46dc-8f51-f6b0706106f8")) == null) {
				Columns.Add(CreateImageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("7a8944fa-b3f0-46dc-8f51-f6b0706106f8"),
				Name = @"Image",
				CreatedInSchemaUId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087"),
				ModifiedInSchemaUId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087"),
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
			return new BaseImageLookup(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BaseImageLookup_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BaseImageLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BaseImageLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087"));
		}

		#endregion

	}

	#endregion

	#region Class: BaseImageLookup

	/// <summary>
	/// Base lookup with image.
	/// </summary>
	public class BaseImageLookup : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BaseImageLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BaseImageLookup";
		}

		public BaseImageLookup(BaseImageLookup source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BaseImageLookup_CrtBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BaseImageLookupDeleted", e);
			Deleting += (s, e) => ThrowEvent("BaseImageLookupDeleting", e);
			Inserted += (s, e) => ThrowEvent("BaseImageLookupInserted", e);
			Inserting += (s, e) => ThrowEvent("BaseImageLookupInserting", e);
			Saved += (s, e) => ThrowEvent("BaseImageLookupSaved", e);
			Saving += (s, e) => ThrowEvent("BaseImageLookupSaving", e);
			Validating += (s, e) => ThrowEvent("BaseImageLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseImageLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: BaseImageLookup_CrtBaseEventsProcess

	/// <exclude/>
	public partial class BaseImageLookup_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : BaseImageLookup
	{

		public BaseImageLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseImageLookup_CrtBaseEventsProcess";
			SchemaUId = new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b4a781bd-bacd-4ba1-a16b-48c09a21f087");
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

	#region Class: BaseImageLookup_CrtBaseEventsProcess

	/// <exclude/>
	public class BaseImageLookup_CrtBaseEventsProcess : BaseImageLookup_CrtBaseEventsProcess<BaseImageLookup>
	{

		public BaseImageLookup_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseImageLookup_CrtBaseEventsProcess

	public partial class BaseImageLookup_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BaseImageLookupEventsProcess

	/// <exclude/>
	public class BaseImageLookupEventsProcess : BaseImageLookup_CrtBaseEventsProcess
	{

		public BaseImageLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

