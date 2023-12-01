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

	#region Class: SpecificationSchema

	/// <exclude/>
	public class SpecificationSchema : Terrasoft.Configuration.Specification_CrtSpecification_TerrasoftSchema
	{

		#region Constructors: Public

		public SpecificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SpecificationSchema(SpecificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SpecificationSchema(SpecificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("2defd4c8-5e12-4b8c-98f4-517013fe4775");
			Name = "Specification";
			ParentSchemaUId = new Guid("ec3cebc4-ea18-40ea-9b0f-e348570481ef");
			ExtendParent = true;
			CreatedInPackageId = new Guid("10676561-1f93-46bf-90be-fe5cd67025e0");
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
			return new Specification(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Specification_PRMPortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new SpecificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SpecificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2defd4c8-5e12-4b8c-98f4-517013fe4775"));
		}

		#endregion

	}

	#endregion

	#region Class: Specification

	/// <summary>
	/// Specification.
	/// </summary>
	public class Specification : Terrasoft.Configuration.Specification_CrtSpecification_Terrasoft
	{

		#region Constructors: Public

		public Specification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Specification";
		}

		public Specification(Specification source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Specification_PRMPortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SpecificationDeleted", e);
			Validating += (s, e) => ThrowEvent("SpecificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Specification(this);
		}

		#endregion

	}

	#endregion

	#region Class: Specification_PRMPortalEventsProcess

	/// <exclude/>
	public partial class Specification_PRMPortalEventsProcess<TEntity> : Terrasoft.Configuration.Specification_CrtSpecificationEventsProcess<TEntity> where TEntity : Specification
	{

		public Specification_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Specification_PRMPortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2defd4c8-5e12-4b8c-98f4-517013fe4775");
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

	#region Class: Specification_PRMPortalEventsProcess

	/// <exclude/>
	public class Specification_PRMPortalEventsProcess : Specification_PRMPortalEventsProcess<Specification>
	{

		public Specification_PRMPortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Specification_PRMPortalEventsProcess

	public partial class Specification_PRMPortalEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: SpecificationEventsProcess

	/// <exclude/>
	public class SpecificationEventsProcess : Specification_PRMPortalEventsProcess
	{

		public SpecificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

