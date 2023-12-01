namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Social;

	#region Class: SocialAccountSchema

	/// <exclude/>
	public class SocialAccountSchema : Terrasoft.Configuration.SocialAccount_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public SocialAccountSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialAccountSchema(SocialAccountSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialAccountSchema(SocialAccountSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677");
			Name = "SocialAccount";
			ParentSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff");
			ExtendParent = true;
			CreatedInPackageId = new Guid("8298d0d1-46ab-4733-8a57-2f1bece9f07b");
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
			return new SocialAccount(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new SocialAccount_FacebookIntegrationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SocialAccountSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialAccountSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount

	/// <summary>
	/// Accounts in external resources.
	/// </summary>
	public class SocialAccount : Terrasoft.Configuration.SocialAccount_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public SocialAccount(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialAccount";
		}

		public SocialAccount(SocialAccount source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialAccount_FacebookIntegrationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SocialAccountDeleted", e);
			Validating += (s, e) => ThrowEvent("SocialAccountValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialAccount(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	/// <exclude/>
	public partial class SocialAccount_FacebookIntegrationEventsProcess<TEntity> : Terrasoft.Configuration.SocialAccount_CrtBaseEventsProcess<TEntity> where TEntity : SocialAccount
	{

		public SocialAccount_FacebookIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialAccount_FacebookIntegrationEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dc63baee-1910-4c5c-a44c-248f2e0ba677");
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

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	/// <exclude/>
	public class SocialAccount_FacebookIntegrationEventsProcess : SocialAccount_FacebookIntegrationEventsProcess<SocialAccount>
	{

		public SocialAccount_FacebookIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialAccount_FacebookIntegrationEventsProcess

	public partial class SocialAccount_FacebookIntegrationEventsProcess<TEntity>
	{

		#region Methods: Public

		public override bool OnSocialAccountSaved(ProcessExecutingContext context) {
			SocialNetwork socialNetwork = GetSocialNetworkType();
			if (socialNetwork.Equals(SocialNetwork.Facebook)) {
				return true;
			}
			return base.OnSocialAccountSaved(context);
		}

		#endregion

	}

	#endregion


	#region Class: SocialAccountEventsProcess

	/// <exclude/>
	public class SocialAccountEventsProcess : SocialAccount_FacebookIntegrationEventsProcess
	{

		public SocialAccountEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

