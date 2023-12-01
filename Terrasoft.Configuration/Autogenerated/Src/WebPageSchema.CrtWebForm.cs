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

	#region Class: WebPageSchema

	/// <exclude/>
	public class WebPageSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public WebPageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public WebPageSchema(WebPageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public WebPageSchema(WebPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7");
			RealUId = new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7");
			Name = "WebPage";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("562f1acd-62c8-4466-b19f-73d792872a6e");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2454256d-32cb-b06c-f89d-ea59662a6feb")) == null) {
				Columns.Add(CreateUrlColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2454256d-32cb-b06c-f89d-ea59662a6feb"),
				Name = @"Url",
				CreatedInSchemaUId = new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7"),
				ModifiedInSchemaUId = new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7"),
				CreatedInPackageId = new Guid("562f1acd-62c8-4466-b19f-73d792872a6e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new WebPage(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new WebPage_CrtWebFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new WebPageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new WebPageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7"));
		}

		#endregion

	}

	#endregion

	#region Class: WebPage

	/// <summary>
	/// Web page.
	/// </summary>
	public class WebPage : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public WebPage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "WebPage";
		}

		public WebPage(WebPage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Page URL.
		/// </summary>
		public string Url {
			get {
				return GetTypedColumnValue<string>("Url");
			}
			set {
				SetColumnValue("Url", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new WebPage_CrtWebFormEventsProcess(UserConnection);
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
			return new WebPage(this);
		}

		#endregion

	}

	#endregion

	#region Class: WebPage_CrtWebFormEventsProcess

	/// <exclude/>
	public partial class WebPage_CrtWebFormEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : WebPage
	{

		public WebPage_CrtWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "WebPage_CrtWebFormEventsProcess";
			SchemaUId = new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7f41275e-3fa6-46ab-98cb-ad5172ed5eb7");
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

	#region Class: WebPage_CrtWebFormEventsProcess

	/// <exclude/>
	public class WebPage_CrtWebFormEventsProcess : WebPage_CrtWebFormEventsProcess<WebPage>
	{

		public WebPage_CrtWebFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: WebPage_CrtWebFormEventsProcess

	public partial class WebPage_CrtWebFormEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: WebPageEventsProcess

	/// <exclude/>
	public class WebPageEventsProcess : WebPage_CrtWebFormEventsProcess
	{

		public WebPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

