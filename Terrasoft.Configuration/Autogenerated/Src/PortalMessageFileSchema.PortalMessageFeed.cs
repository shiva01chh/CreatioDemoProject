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
	using Terrasoft.Configuration;
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

	#region Class: PortalMessageFileSchema

	/// <exclude/>
	public class PortalMessageFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public PortalMessageFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalMessageFileSchema(PortalMessageFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalMessageFileSchema(PortalMessageFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_PortalMessageFile_CreatedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("803fefac-8b24-4753-af56-0a520f0453f2");
			index.Name = "IX_PortalMessageFile_CreatedOn";
			index.CreatedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
			index.ModifiedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
			index.CreatedInPackageId = new Guid("32031062-b6bd-4fa4-a14f-d8d66f99305f");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("f1ae622e-a091-5a41-abb6-ce5cbd9497f1"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996"),
				ModifiedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996"),
				CreatedInPackageId = new Guid("32031062-b6bd-4fa4-a14f-d8d66f99305f"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
			RealUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
			Name = "PortalMessageFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cab85636-6266-4f93-8b0b-9dac20f5b8d8");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f9baa4fa-e177-4765-95f6-393d923c0283")) == null) {
				Columns.Add(CreatePortalMessageColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePortalMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f9baa4fa-e177-4765-95f6-393d923c0283"),
				Name = @"PortalMessage",
				ReferenceSchemaUId = new Guid("36fb7666-f45c-48f7-be50-178c7adbe3c0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996"),
				ModifiedInSchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996"),
				CreatedInPackageId = new Guid("cab85636-6266-4f93-8b0b-9dac20f5b8d8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_PortalMessageFile_CreatedOnIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PortalMessageFile(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new PortalMessageFile_PortalMessageFeedEventsProcess(userConnection);
		}

		public override object Clone() {
			return new PortalMessageFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalMessageFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessageFile

	/// <summary>
	/// Portal message file.
	/// </summary>
	public class PortalMessageFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public PortalMessageFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalMessageFile";
		}

		public PortalMessageFile(PortalMessageFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid PortalMessageId {
			get {
				return GetTypedColumnValue<Guid>("PortalMessageId");
			}
			set {
				SetColumnValue("PortalMessageId", value);
				_portalMessage = null;
			}
		}

		private PortalMessage _portalMessage;
		/// <summary>
		/// Portal message.
		/// </summary>
		public PortalMessage PortalMessage {
			get {
				return _portalMessage ??
					(_portalMessage = LookupColumnEntities.GetEntity("PortalMessage") as PortalMessage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalMessageFile_PortalMessageFeedEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PortalMessageFileDeleted", e);
			Updated += (s, e) => ThrowEvent("PortalMessageFileUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalMessageFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessageFile_PortalMessageFeedEventsProcess

	/// <exclude/>
	public partial class PortalMessageFile_PortalMessageFeedEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : PortalMessageFile
	{

		public PortalMessageFile_PortalMessageFeedEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalMessageFile_PortalMessageFeedEventsProcess";
			SchemaUId = new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("55c1fe71-17a1-4bd2-a4b2-7799ccaac996");
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

	#region Class: PortalMessageFile_PortalMessageFeedEventsProcess

	/// <exclude/>
	public class PortalMessageFile_PortalMessageFeedEventsProcess : PortalMessageFile_PortalMessageFeedEventsProcess<PortalMessageFile>
	{

		public PortalMessageFile_PortalMessageFeedEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalMessageFile_PortalMessageFeedEventsProcess

	public partial class PortalMessageFile_PortalMessageFeedEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void OnFileSaved() {
			base.OnFileSaved();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				var url = Entity.GetTypedColumnValue<string>("Name").Trim();
				if (IsURLValid(url)) {
					LinkPreview linkPreview = new LinkPreview();
					LinkPreviewInfo linkPreviewInfo = linkPreview.GetWebPageLinkPreview(url);
					if (linkPreviewInfo != null) {
						LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
						linkPreviewProvider.SaveLinkPreviewInfo(linkPreviewInfo, Entity.PrimaryColumnValue);
					}
				}
			}
		}

		public override void OnFileDeleted() {
			base.OnFileDeleted();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		public override void OnFileUpdated() {
			base.OnFileUpdated();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			string oldUrl = (string)Entity.GetColumnOldValue("Name");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId && IsURLValid(oldUrl)) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		#endregion

	}

	#endregion


	#region Class: PortalMessageFileEventsProcess

	/// <exclude/>
	public class PortalMessageFileEventsProcess : PortalMessageFile_PortalMessageFeedEventsProcess
	{

		public PortalMessageFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

