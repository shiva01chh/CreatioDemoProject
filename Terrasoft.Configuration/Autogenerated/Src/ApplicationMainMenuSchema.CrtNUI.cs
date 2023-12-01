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

	#region Class: ApplicationMainMenuSchema

	/// <exclude/>
	public class ApplicationMainMenuSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ApplicationMainMenuSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ApplicationMainMenuSchema(ApplicationMainMenuSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ApplicationMainMenuSchema(ApplicationMainMenuSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c");
			RealUId = new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c");
			Name = "ApplicationMainMenu";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("75bbbcbc-a644-4f87-8cb2-79b9c99efa95");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e09771b7-3233-41be-97a8-0f3b373a8939")) == null) {
				Columns.Add(CreateIntroPageUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIntroPageUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e09771b7-3233-41be-97a8-0f3b373a8939"),
				Name = @"IntroPageUId",
				CreatedInSchemaUId = new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c"),
				ModifiedInSchemaUId = new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c"),
				CreatedInPackageId = new Guid("75bbbcbc-a644-4f87-8cb2-79b9c99efa95")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ApplicationMainMenu(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ApplicationMainMenu_CrtNUIEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ApplicationMainMenuSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ApplicationMainMenuSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c"));
		}

		#endregion

	}

	#endregion

	#region Class: ApplicationMainMenu

	/// <summary>
	/// Main menu.
	/// </summary>
	public class ApplicationMainMenu : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ApplicationMainMenu(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ApplicationMainMenu";
		}

		public ApplicationMainMenu(ApplicationMainMenu source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique Id for main menu page.
		/// </summary>
		public Guid IntroPageUId {
			get {
				return GetTypedColumnValue<Guid>("IntroPageUId");
			}
			set {
				SetColumnValue("IntroPageUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ApplicationMainMenu_CrtNUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ApplicationMainMenuDeleted", e);
			Validating += (s, e) => ThrowEvent("ApplicationMainMenuValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ApplicationMainMenu(this);
		}

		#endregion

	}

	#endregion

	#region Class: ApplicationMainMenu_CrtNUIEventsProcess

	/// <exclude/>
	public partial class ApplicationMainMenu_CrtNUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : ApplicationMainMenu
	{

		public ApplicationMainMenu_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ApplicationMainMenu_CrtNUIEventsProcess";
			SchemaUId = new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3cbba84a-82e6-40b6-8a79-2b0457c9af0c");
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

	#region Class: ApplicationMainMenu_CrtNUIEventsProcess

	/// <exclude/>
	public class ApplicationMainMenu_CrtNUIEventsProcess : ApplicationMainMenu_CrtNUIEventsProcess<ApplicationMainMenu>
	{

		public ApplicationMainMenu_CrtNUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ApplicationMainMenu_CrtNUIEventsProcess

	public partial class ApplicationMainMenu_CrtNUIEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: ApplicationMainMenuEventsProcess

	/// <exclude/>
	public class ApplicationMainMenuEventsProcess : ApplicationMainMenu_CrtNUIEventsProcess
	{

		public ApplicationMainMenuEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

