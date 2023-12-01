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

	#region Class: AccountTypeSchema

	/// <exclude/>
	public class AccountTypeSchema : Terrasoft.Configuration.AccountType_CrtCustomer360App_TerrasoftSchema
	{

		#region Constructors: Public

		public AccountTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AccountTypeSchema(AccountTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AccountTypeSchema(AccountTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6a0ed21f-92a1-4e78-8884-219e2a9e96ff");
			Name = "AccountType";
			ParentSchemaUId = new Guid("3ae4a2bb-d3dc-48bf-8271-9ca91dcdeba1");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6ffc9a98-f80d-4502-b20f-130286444518");
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
			return new AccountType(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new AccountType_PRMBaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new AccountTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AccountTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a0ed21f-92a1-4e78-8884-219e2a9e96ff"));
		}

		#endregion

	}

	#endregion

	#region Class: AccountType

	/// <summary>
	/// Account type.
	/// </summary>
	public class AccountType : Terrasoft.Configuration.AccountType_CrtCustomer360App_Terrasoft
	{

		#region Constructors: Public

		public AccountType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AccountType";
		}

		public AccountType(AccountType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AccountType_PRMBaseEventsProcess(UserConnection);
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
			return new AccountType(this);
		}

		#endregion

	}

	#endregion

	#region Class: AccountType_PRMBaseEventsProcess

	/// <exclude/>
	public partial class AccountType_PRMBaseEventsProcess<TEntity> : Terrasoft.Configuration.AccountType_CrtCustomer360AppEventsProcess<TEntity> where TEntity : AccountType
	{

		public AccountType_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AccountType_PRMBaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6a0ed21f-92a1-4e78-8884-219e2a9e96ff");
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

	#region Class: AccountType_PRMBaseEventsProcess

	/// <exclude/>
	public class AccountType_PRMBaseEventsProcess : AccountType_PRMBaseEventsProcess<AccountType>
	{

		public AccountType_PRMBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AccountType_PRMBaseEventsProcess

	public partial class AccountType_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: AccountTypeEventsProcess

	/// <exclude/>
	public class AccountTypeEventsProcess : AccountType_PRMBaseEventsProcess
	{

		public AccountTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

