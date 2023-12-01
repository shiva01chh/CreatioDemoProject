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

	#region Class: ContactAddress_SSP_TerrasoftSchema

	/// <exclude/>
	public class ContactAddress_SSP_TerrasoftSchema : Terrasoft.Configuration.ContactAddress_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactAddress_SSP_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAddress_SSP_TerrasoftSchema(ContactAddress_SSP_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAddress_SSP_TerrasoftSchema(ContactAddress_SSP_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0839a4b5-5677-40b2-a950-f0d55e2ce68b");
			Name = "ContactAddress_SSP_Terrasoft";
			ParentSchemaUId = new Guid("d54d2218-61c8-413a-a1b7-5748c7e25f56");
			ExtendParent = true;
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
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
			return new ContactAddress_SSP_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAddress_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAddress_SSP_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAddress_SSP_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0839a4b5-5677-40b2-a950-f0d55e2ce68b"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_SSP_Terrasoft

	/// <summary>
	/// Contact address.
	/// </summary>
	public class ContactAddress_SSP_Terrasoft : Terrasoft.Configuration.ContactAddress_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public ContactAddress_SSP_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAddress_SSP_Terrasoft";
		}

		public ContactAddress_SSP_Terrasoft(ContactAddress_SSP_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAddress_SSPEventsProcess(UserConnection);
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
			return new ContactAddress_SSP_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAddress_SSPEventsProcess

	/// <exclude/>
	public partial class ContactAddress_SSPEventsProcess<TEntity> : Terrasoft.Configuration.ContactAddress_CrtBaseEventsProcess<TEntity> where TEntity : ContactAddress_SSP_Terrasoft
	{

		public ContactAddress_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAddress_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0839a4b5-5677-40b2-a950-f0d55e2ce68b");
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

	#region Class: ContactAddress_SSPEventsProcess

	/// <exclude/>
	public class ContactAddress_SSPEventsProcess : ContactAddress_SSPEventsProcess<ContactAddress_SSP_Terrasoft>
	{

		public ContactAddress_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactAddress_SSPEventsProcess

	public partial class ContactAddress_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

}

