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

	#region Class: CompetitorProductSchema

	/// <exclude/>
	public class CompetitorProductSchema : Terrasoft.Configuration.CompetitorProduct_CrtBase_TerrasoftSchema
	{

		#region Constructors: Public

		public CompetitorProductSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CompetitorProductSchema(CompetitorProductSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CompetitorProductSchema(CompetitorProductSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d8d9c874-6190-4076-b8fb-716d0ae6e550");
			Name = "CompetitorProduct";
			ParentSchemaUId = new Guid("a90cf5af-917c-4b33-8eee-832906dbe6d5");
			ExtendParent = true;
			CreatedInPackageId = new Guid("667fe825-207f-46da-8fb7-a082f81fd079");
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
			return new CompetitorProduct(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CompetitorProduct_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CompetitorProductSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CompetitorProductSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8d9c874-6190-4076-b8fb-716d0ae6e550"));
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct

	/// <summary>
	/// Competitor product.
	/// </summary>
	public class CompetitorProduct : Terrasoft.Configuration.CompetitorProduct_CrtBase_Terrasoft
	{

		#region Constructors: Public

		public CompetitorProduct(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CompetitorProduct";
		}

		public CompetitorProduct(CompetitorProduct source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CompetitorProduct_PRMPortalEventsProcess(UserConnection);
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
			return new CompetitorProduct(this);
		}

		#endregion

	}

	#endregion

	#region Class: CompetitorProduct_PRMPortalEventsProcess

	/// <exclude/>
	public partial class CompetitorProduct_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.CompetitorProduct_CrtBaseEventsProcess<TEntity> where TEntity : CompetitorProduct
	{

		public CompetitorProduct_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CompetitorProduct_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d8d9c874-6190-4076-b8fb-716d0ae6e550");
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

	#region Class: CompetitorProduct_PRMPortalEventsProcess

	/// <exclude/>
	public class CompetitorProduct_PRMPortalEventsProcess : CompetitorProduct_PRMPortalEventsProcess<CompetitorProduct>
	{

		public CompetitorProduct_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CompetitorProduct_PRMPortalEventsProcess

	public partial class CompetitorProduct_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: CompetitorProductEventsProcess

	/// <exclude/>
	public class CompetitorProductEventsProcess : CompetitorProduct_PRMPortalEventsProcess
	{

		public CompetitorProductEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

