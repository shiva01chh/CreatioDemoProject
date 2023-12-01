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

	#region Class: FileSecurityExcludedUriSchema

	/// <exclude/>
	public class FileSecurityExcludedUriSchema : Terrasoft.Configuration.LookupSchema
	{

		#region Constructors: Public

		public FileSecurityExcludedUriSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FileSecurityExcludedUriSchema(FileSecurityExcludedUriSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FileSecurityExcludedUriSchema(FileSecurityExcludedUriSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
			RealUId = new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
			Name = "FileSecurityExcludedUri";
			ParentSchemaUId = new Guid("2aecdb97-990e-4c17-96f4-240ca6531c84");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FileSecurityExcludedUri(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new FileSecurityExcludedUri_CrtBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new FileSecurityExcludedUriSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FileSecurityExcludedUriSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b275e5b-ddac-402c-a984-23aa103544d7"));
		}

		#endregion

	}

	#endregion

	#region Class: FileSecurityExcludedUri

	/// <summary>
	/// File Security Excluded Uri.
	/// </summary>
	public class FileSecurityExcludedUri : Terrasoft.Configuration.Lookup
	{

		#region Constructors: Public

		public FileSecurityExcludedUri(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FileSecurityExcludedUri";
		}

		public FileSecurityExcludedUri(FileSecurityExcludedUri source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FileSecurityExcludedUri_CrtBaseEventsProcess(UserConnection);
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
			return new FileSecurityExcludedUri(this);
		}

		#endregion

	}

	#endregion

	#region Class: FileSecurityExcludedUri_CrtBaseEventsProcess

	/// <exclude/>
	public partial class FileSecurityExcludedUri_CrtBaseEventsProcess<TEntity> : Terrasoft.Configuration.Lookup_CrtBaseEventsProcess<TEntity> where TEntity : FileSecurityExcludedUri
	{

		public FileSecurityExcludedUri_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileSecurityExcludedUri_CrtBaseEventsProcess";
			SchemaUId = new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8b275e5b-ddac-402c-a984-23aa103544d7");
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

	#region Class: FileSecurityExcludedUri_CrtBaseEventsProcess

	/// <exclude/>
	public class FileSecurityExcludedUri_CrtBaseEventsProcess : FileSecurityExcludedUri_CrtBaseEventsProcess<FileSecurityExcludedUri>
	{

		public FileSecurityExcludedUri_CrtBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FileSecurityExcludedUri_CrtBaseEventsProcess

	public partial class FileSecurityExcludedUri_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: FileSecurityExcludedUriEventsProcess

	/// <exclude/>
	public class FileSecurityExcludedUriEventsProcess : FileSecurityExcludedUri_CrtBaseEventsProcess
	{

		public FileSecurityExcludedUriEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

