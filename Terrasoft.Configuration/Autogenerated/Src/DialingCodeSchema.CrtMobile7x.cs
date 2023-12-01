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

	#region Class: DialingCodeSchema

	/// <exclude/>
	public class DialingCodeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DialingCodeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DialingCodeSchema(DialingCodeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DialingCodeSchema(DialingCodeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb");
			RealUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb");
			Name = "DialingCode";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("42d46b9b-0e9b-4c59-9e77-931ed51c08eb");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fdc4f839-6087-4e06-bb9e-df2553a3982b")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("6df29689-2903-4191-bef6-220db36e5f61")) == null) {
				Columns.Add(CreateCodeColumn());
			}
			if (Columns.FindByUId(new Guid("0613d360-4478-444a-a787-de3dbb1b0659")) == null) {
				Columns.Add(CreateTrunkPrefixColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fdc4f839-6087-4e06-bb9e-df2553a3982b"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				ModifiedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				CreatedInPackageId = new Guid("42d46b9b-0e9b-4c59-9e77-931ed51c08eb")
			};
		}

		protected virtual EntitySchemaColumn CreateCodeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("6df29689-2903-4191-bef6-220db36e5f61"),
				Name = @"Code",
				CreatedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				ModifiedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				CreatedInPackageId = new Guid("42d46b9b-0e9b-4c59-9e77-931ed51c08eb")
			};
		}

		protected virtual EntitySchemaColumn CreateTrunkPrefixColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("0613d360-4478-444a-a787-de3dbb1b0659"),
				Name = @"TrunkPrefix",
				CreatedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				ModifiedInSchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"),
				CreatedInPackageId = new Guid("42d46b9b-0e9b-4c59-9e77-931ed51c08eb")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DialingCode(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DialingCode_CrtMobile7xEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DialingCodeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DialingCodeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb"));
		}

		#endregion

	}

	#endregion

	#region Class: DialingCode

	/// <summary>
	/// Dialing code.
	/// </summary>
	public class DialingCode : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DialingCode(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DialingCode";
		}

		public DialingCode(DialingCode source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		/// <summary>
		/// Code.
		/// </summary>
		public string Code {
			get {
				return GetTypedColumnValue<string>("Code");
			}
			set {
				SetColumnValue("Code", value);
			}
		}

		/// <summary>
		/// Trunk prefix.
		/// </summary>
		public string TrunkPrefix {
			get {
				return GetTypedColumnValue<string>("TrunkPrefix");
			}
			set {
				SetColumnValue("TrunkPrefix", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DialingCode_CrtMobile7xEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DialingCodeDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DialingCode(this);
		}

		#endregion

	}

	#endregion

	#region Class: DialingCode_CrtMobile7xEventsProcess

	/// <exclude/>
	public partial class DialingCode_CrtMobile7xEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DialingCode
	{

		public DialingCode_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DialingCode_CrtMobile7xEventsProcess";
			SchemaUId = new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a3c82b18-b34d-40ff-9339-f5ab2b2315cb");
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

	#region Class: DialingCode_CrtMobile7xEventsProcess

	/// <exclude/>
	public class DialingCode_CrtMobile7xEventsProcess : DialingCode_CrtMobile7xEventsProcess<DialingCode>
	{

		public DialingCode_CrtMobile7xEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DialingCode_CrtMobile7xEventsProcess

	public partial class DialingCode_CrtMobile7xEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: DialingCodeEventsProcess

	/// <exclude/>
	public class DialingCodeEventsProcess : DialingCode_CrtMobile7xEventsProcess
	{

		public DialingCodeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

