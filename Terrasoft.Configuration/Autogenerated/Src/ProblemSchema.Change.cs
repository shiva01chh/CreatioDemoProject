namespace Terrasoft.Configuration
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

	#region Class: ProblemSchema

	/// <exclude/>
	public class ProblemSchema : Terrasoft.Configuration.Problem_Problem_TerrasoftSchema
	{

		#region Constructors: Public

		public ProblemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProblemSchema(ProblemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProblemSchema(ProblemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Problem_NumberIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("7983b389-f994-4206-97ca-7a67505cf4a9");
			index.Name = "IX_Problem_Number";
			index.CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22");
			EntitySchemaIndexColumn numberIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a3fb0b94-9156-d274-d462-467531fe4743"),
				ColumnUId = new Guid("574a4f31-52cd-4a5c-b8a1-2da99b212660"),
				CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(numberIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_Problem_RegisteredOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("068325c5-baef-4451-a682-d35f48074cb2");
			index.Name = "IX_Problem_RegisteredOn";
			index.CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22");
			EntitySchemaIndexColumn registeredOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8876bf2e-a4b0-7be9-3c37-29ed09c855c9"),
				ColumnUId = new Guid("f980bbae-7e0c-41fd-95b0-5022a732930a"),
				CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(registeredOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_Problem_CreatedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("4f8d6f42-4dba-4468-9dda-9f38f96a8207");
			index.Name = "IX_Problem_CreatedOn";
			index.CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			index.CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("fd8619d5-65f6-020b-ab08-4afb632f86fc"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				ModifiedInSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0d9b6870-0c0e-4f0b-b0a5-857342223e2e");
			Name = "Problem";
			ParentSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4b2eb4ab-1abd-4116-abf8-c944d7d82ece");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e2139c27-ea75-4281-a489-8dff2f312395")) == null) {
				Columns.Add(CreateChangeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateChangeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2139c27-ea75-4281-a489-8dff2f312395"),
				Name = @"Change",
				ReferenceSchemaUId = new Guid("de5c8d59-d372-407d-8c09-f0523e057e40"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0d9b6870-0c0e-4f0b-b0a5-857342223e2e"),
				ModifiedInSchemaUId = new Guid("0d9b6870-0c0e-4f0b-b0a5-857342223e2e"),
				CreatedInPackageId = new Guid("4b2eb4ab-1abd-4116-abf8-c944d7d82ece")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Problem_NumberIndex());
			Indexes.Add(CreateIX_Problem_RegisteredOnIndex());
			Indexes.Add(CreateIX_Problem_CreatedOnIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Problem(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Problem_ChangeEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ProblemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProblemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d9b6870-0c0e-4f0b-b0a5-857342223e2e"));
		}

		#endregion

	}

	#endregion

	#region Class: Problem

	/// <summary>
	/// Problem.
	/// </summary>
	public class Problem : Terrasoft.Configuration.Problem_Problem_Terrasoft
	{

		#region Constructors: Public

		public Problem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Problem";
		}

		public Problem(Problem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ChangeId {
			get {
				return GetTypedColumnValue<Guid>("ChangeId");
			}
			set {
				SetColumnValue("ChangeId", value);
				_change = null;
			}
		}

		/// <exclude/>
		public string ChangeNumber {
			get {
				return GetTypedColumnValue<string>("ChangeNumber");
			}
			set {
				SetColumnValue("ChangeNumber", value);
				if (_change != null) {
					_change.Number = value;
				}
			}
		}

		private Change _change;
		/// <summary>
		/// Change.
		/// </summary>
		public Change Change {
			get {
				return _change ??
					(_change = LookupColumnEntities.GetEntity("Change") as Change);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Problem_ChangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProblemDeleted", e);
			Validating += (s, e) => ThrowEvent("ProblemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Problem(this);
		}

		#endregion

	}

	#endregion

	#region Class: Problem_ChangeEventsProcess

	/// <exclude/>
	public partial class Problem_ChangeEventsProcess<TEntity> : Terrasoft.Configuration.Problem_ProblemEventsProcess<TEntity> where TEntity : Problem
	{

		public Problem_ChangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Problem_ChangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("0d9b6870-0c0e-4f0b-b0a5-857342223e2e");
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

	#region Class: Problem_ChangeEventsProcess

	/// <exclude/>
	public class Problem_ChangeEventsProcess : Problem_ChangeEventsProcess<Problem>
	{

		public Problem_ChangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Problem_ChangeEventsProcess

	public partial class Problem_ChangeEventsProcess<TEntity>
	{

		#region Methods: Public

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		#endregion

	}

	#endregion


	#region Class: ProblemEventsProcess

	/// <exclude/>
	public class ProblemEventsProcess : Problem_ChangeEventsProcess
	{

		public ProblemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

