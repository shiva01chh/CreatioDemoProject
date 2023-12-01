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

	#region Class: Account_SSP_TerrasoftSchema

	/// <exclude/>
	public class Account_SSP_TerrasoftSchema : Terrasoft.Configuration.Account_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public Account_SSP_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Account_SSP_TerrasoftSchema(Account_SSP_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Account_SSP_TerrasoftSchema(Account_SSP_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("29598bf5-fe89-4d65-baff-ef7a194f7661");
			Name = "Account_SSP_Terrasoft";
			ParentSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			ExtendParent = true;
			CreatedInPackageId = new Guid("dcea5dd7-bf2c-4316-8f37-0f60ebf486d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Account_SSP_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Account_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Account_SSP_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Account_SSP_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29598bf5-fe89-4d65-baff-ef7a194f7661"));
		}

		#endregion

	}

	#endregion

	#region Class: Account_SSP_Terrasoft

	/// <summary>
	/// Account.
	/// </summary>
	public class Account_SSP_Terrasoft : Terrasoft.Configuration.Account_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public Account_SSP_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Account_SSP_Terrasoft";
		}

		public Account_SSP_Terrasoft(Account_SSP_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Account_SSPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Account_SSP_TerrasoftDeleted", e);
			Inserting += (s, e) => ThrowEvent("Account_SSP_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Account_SSP_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Account_SSP_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Account_SSP_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Account_SSP_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Account_SSPEventsProcess

	/// <exclude/>
	public partial class Account_SSPEventsProcess<TEntity> : Terrasoft.Configuration.Account_CrtBaseEventsProcess<TEntity> where TEntity : Account_SSP_Terrasoft
	{

		public Account_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Account_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("29598bf5-fe89-4d65-baff-ef7a194f7661");
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

	#region Class: Account_SSPEventsProcess

	/// <exclude/>
	public class Account_SSPEventsProcess : Account_SSPEventsProcess<Account_SSP_Terrasoft>
	{

		public Account_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Account_SSPEventsProcess

	public partial class Account_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

