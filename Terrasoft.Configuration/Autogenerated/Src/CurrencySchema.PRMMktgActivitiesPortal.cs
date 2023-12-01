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
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CurrencySchema

	/// <exclude/>
	public class CurrencySchema : Terrasoft.Configuration.Currency_PRMPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public CurrencySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CurrencySchema(CurrencySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CurrencySchema(CurrencySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0cacdb7e-97d5-4888-9691-4fb0956eada8");
			Name = "Currency";
			ParentSchemaUId = new Guid("2d36aca6-5b8c-4122-9648-baf3b7f8256d");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4e15e06f-c041-4f32-96e5-36c4e75dc6e5");
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
			return new Currency(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Currency_PRMMktgActivitiesPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CurrencySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CurrencySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cacdb7e-97d5-4888-9691-4fb0956eada8"));
		}

		#endregion

	}

	#endregion

	#region Class: Currency

	/// <summary>
	/// Currency.
	/// </summary>
	public class Currency : Terrasoft.Configuration.Currency_PRMPortal_Terrasoft
	{

		#region Constructors: Public

		public Currency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Currency";
		}

		public Currency(Currency source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Currency_PRMMktgActivitiesPortalEventsProcess(UserConnection);
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
			return new Currency(this);
		}

		#endregion

	}

	#endregion

	#region Class: Currency_PRMMktgActivitiesPortalEventsProcess

	/// <exclude/>
	public partial class Currency_PRMMktgActivitiesPortalEventsProcess<TEntity> : Terrasoft.Configuration.Currency_PRMPortalEventsProcess<TEntity> where TEntity : Currency
	{

		public Currency_PRMMktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Currency_PRMMktgActivitiesPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0cacdb7e-97d5-4888-9691-4fb0956eada8");
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

	#region Class: Currency_PRMMktgActivitiesPortalEventsProcess

	/// <exclude/>
	public class Currency_PRMMktgActivitiesPortalEventsProcess : Currency_PRMMktgActivitiesPortalEventsProcess<Currency>
	{

		public Currency_PRMMktgActivitiesPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Currency_PRMMktgActivitiesPortalEventsProcess

	public partial class Currency_PRMMktgActivitiesPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CurrencyEventsProcess

	/// <exclude/>
	public class CurrencyEventsProcess : Currency_PRMMktgActivitiesPortalEventsProcess
	{

		public CurrencyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

