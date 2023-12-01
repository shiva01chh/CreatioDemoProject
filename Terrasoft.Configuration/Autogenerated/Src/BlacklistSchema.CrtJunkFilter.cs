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

	#region Class: BlacklistSchema

	/// <exclude/>
	public class BlacklistSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BlacklistSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BlacklistSchema(BlacklistSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BlacklistSchema(BlacklistSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			RealUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			Name = "Blacklist";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("19b4b42d-72f0-465a-80b3-599a54ede88f")) == null) {
				Columns.Add(CreateTypeOfFieldColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeOfFieldColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("19b4b42d-72f0-465a-80b3-599a54ede88f"),
				Name = @"TypeOfField",
				ReferenceSchemaUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"),
				ModifiedInSchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"),
				CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Blacklist(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Blacklist_CrtJunkFilterEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BlacklistSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BlacklistSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"));
		}

		#endregion

	}

	#endregion

	#region Class: Blacklist

	/// <summary>
	/// Blacklist of email addresses and domains for case registration.
	/// </summary>
	public class Blacklist : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Blacklist(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Blacklist";
		}

		public Blacklist(Blacklist source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeOfFieldId {
			get {
				return GetTypedColumnValue<Guid>("TypeOfFieldId");
			}
			set {
				SetColumnValue("TypeOfFieldId", value);
				_typeOfField = null;
			}
		}

		/// <exclude/>
		public string TypeOfFieldName {
			get {
				return GetTypedColumnValue<string>("TypeOfFieldName");
			}
			set {
				SetColumnValue("TypeOfFieldName", value);
				if (_typeOfField != null) {
					_typeOfField.Name = value;
				}
			}
		}

		private JunkFilterTypeOfField _typeOfField;
		/// <summary>
		/// Type of field.
		/// </summary>
		public JunkFilterTypeOfField TypeOfField {
			get {
				return _typeOfField ??
					(_typeOfField = LookupColumnEntities.GetEntity("TypeOfField") as JunkFilterTypeOfField);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Blacklist_CrtJunkFilterEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BlacklistDeleted", e);
			Validating += (s, e) => ThrowEvent("BlacklistValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Blacklist(this);
		}

		#endregion

	}

	#endregion

	#region Class: Blacklist_CrtJunkFilterEventsProcess

	/// <exclude/>
	public partial class Blacklist_CrtJunkFilterEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_CrtBaseEventsProcess<TEntity> where TEntity : Blacklist
	{

		public Blacklist_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Blacklist_CrtJunkFilterEventsProcess";
			SchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
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

	#region Class: Blacklist_CrtJunkFilterEventsProcess

	/// <exclude/>
	public class Blacklist_CrtJunkFilterEventsProcess : Blacklist_CrtJunkFilterEventsProcess<Blacklist>
	{

		public Blacklist_CrtJunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Blacklist_CrtJunkFilterEventsProcess

	public partial class Blacklist_CrtJunkFilterEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BlacklistEventsProcess

	/// <exclude/>
	public class BlacklistEventsProcess : Blacklist_CrtJunkFilterEventsProcess
	{

		public BlacklistEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

