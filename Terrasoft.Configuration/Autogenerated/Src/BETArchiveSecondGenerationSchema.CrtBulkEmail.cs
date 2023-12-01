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

	#region Class: BETArchiveSecondGenerationSchema

	/// <exclude/>
	public class BETArchiveSecondGenerationSchema : Terrasoft.Configuration.BulkEmailTargetSchema
	{

		#region Constructors: Public

		public BETArchiveSecondGenerationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BETArchiveSecondGenerationSchema(BETArchiveSecondGenerationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BETArchiveSecondGenerationSchema(BETArchiveSecondGenerationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIXBETSGContactIdResponseIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("eb0d4871-38c9-4db9-995f-7a034207b9f3");
			index.Name = "IXBETSGContactIdResponseId";
			index.CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			index.ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			index.CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("082a97bd-6875-3f7c-ff80-9f8049de0da2"),
				ColumnUId = new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a"),
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			EntitySchemaIndexColumn bulkEmailResponseIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("efc97fe8-19e8-ad2d-d395-3bc7ffebb9d0"),
				ColumnUId = new Guid("91b87361-603a-4602-b7dc-09b46423343e"),
				CreatedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				ModifiedInSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailResponseIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2b493b1-f941-bde6-ab76-a91a22d2dbfd");
			RealUId = new Guid("e2b493b1-f941-bde6-ab76-a91a22d2dbfd");
			Name = "BETArchiveSecondGeneration";
			ParentSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIXBETSGContactIdResponseIdIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BETArchiveSecondGeneration(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BETArchiveSecondGeneration_CrtBulkEmailEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BETArchiveSecondGenerationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BETArchiveSecondGenerationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2b493b1-f941-bde6-ab76-a91a22d2dbfd"));
		}

		#endregion

	}

	#endregion

	#region Class: BETArchiveSecondGeneration

	/// <summary>
	/// BETArchiveSecondGeneration.
	/// </summary>
	public class BETArchiveSecondGeneration : Terrasoft.Configuration.BulkEmailTarget
	{

		#region Constructors: Public

		public BETArchiveSecondGeneration(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BETArchiveSecondGeneration";
		}

		public BETArchiveSecondGeneration(BETArchiveSecondGeneration source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BETArchiveSecondGeneration_CrtBulkEmailEventsProcess(UserConnection);
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
			return new BETArchiveSecondGeneration(this);
		}

		#endregion

	}

	#endregion

	#region Class: BETArchiveSecondGeneration_CrtBulkEmailEventsProcess

	/// <exclude/>
	public partial class BETArchiveSecondGeneration_CrtBulkEmailEventsProcess<TEntity> : Terrasoft.Configuration.BulkEmailTarget_CrtBulkEmailEventsProcess<TEntity> where TEntity : BETArchiveSecondGeneration
	{

		public BETArchiveSecondGeneration_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BETArchiveSecondGeneration_CrtBulkEmailEventsProcess";
			SchemaUId = new Guid("e2b493b1-f941-bde6-ab76-a91a22d2dbfd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e2b493b1-f941-bde6-ab76-a91a22d2dbfd");
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

	#region Class: BETArchiveSecondGeneration_CrtBulkEmailEventsProcess

	/// <exclude/>
	public class BETArchiveSecondGeneration_CrtBulkEmailEventsProcess : BETArchiveSecondGeneration_CrtBulkEmailEventsProcess<BETArchiveSecondGeneration>
	{

		public BETArchiveSecondGeneration_CrtBulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BETArchiveSecondGeneration_CrtBulkEmailEventsProcess

	public partial class BETArchiveSecondGeneration_CrtBulkEmailEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion


	#region Class: BETArchiveSecondGenerationEventsProcess

	/// <exclude/>
	public class BETArchiveSecondGenerationEventsProcess : BETArchiveSecondGeneration_CrtBulkEmailEventsProcess
	{

		public BETArchiveSecondGenerationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

