﻿namespace Terrasoft.Configuration
{

	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
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

	#region Class: Case_CMDB_TerrasoftSchema

	/// <exclude/>
	public class Case_CMDB_TerrasoftSchema : Terrasoft.Configuration.Case_SLM_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_CMDB_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_CMDB_TerrasoftSchema(Case_CMDB_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_CMDB_TerrasoftSchema(Case_CMDB_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_RegisteredOn_DescIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ed6688c-3e02-47af-9124-e38e20904716");
			index.Name = "IX_RegisteredOn_Desc";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			EntitySchemaIndexColumn registeredOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aa03e37c-3527-4b5c-a16c-53fbc178b41e"),
				ColumnUId = new Guid("c91a9a6f-008d-4b2e-83d5-03868ad68c99"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(registeredOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_SolutionOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ad0ba05-3b32-4561-8bfc-870aee9c951c");
			index.Name = "IX_SolutionOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn solutionProvidedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f3631c8-b14e-4591-a25a-b9207401cfa2"),
				ColumnUId = new Guid("81552f0a-fd92-4865-9533-f4c3ab2861a7"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionProvidedOnIndexColumn);
			EntitySchemaIndexColumn solutionDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5de35510-255d-4f3f-8119-9a3f9b8082f5"),
				ColumnUId = new Guid("624839d1-3bd0-45e0-95d1-28326703f19c"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionDateIndexColumn);
			EntitySchemaIndexColumn solutionOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8dab4368-f988-43de-a48e-bbf238fc3237"),
				ColumnUId = new Guid("0fa66efc-d2d0-47b9-abab-9e3ad2ea82d3"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(solutionOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_ResponseOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("8d002ad1-0715-4bdc-aa5e-8be1a5e39381");
			index.Name = "IX_ResponseOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn respondedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("14abc9af-1b98-4ee2-b236-3a9576b1770f"),
				ColumnUId = new Guid("02612dc8-7243-4acb-b0bd-abbd19e24136"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(respondedOnIndexColumn);
			EntitySchemaIndexColumn responseDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c3226bd5-beb9-48ea-9383-30fb120d4f4d"),
				ColumnUId = new Guid("25280121-c075-441f-b4f8-feeb6cc7ca38"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(responseDateIndexColumn);
			EntitySchemaIndexColumn responseOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a4aaaa1e-d84e-48a2-84ac-04c35a6fad1e"),
				ColumnUId = new Guid("1ed4e080-0bf8-4f4f-97e8-b3e22f3240a0"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(responseOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_SubjectIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e675ceca-ff2f-44c2-bd1a-f2c1af261cba");
			index.Name = "IDX_Subject";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5");
			EntitySchemaIndexColumn subjectIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5f164afe-e5a5-40a6-9e32-b7f83656bba8"),
				ColumnUId = new Guid("ffe8526d-044f-4222-a1ef-fca83a0772d8"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(subjectIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_Case_ClosureDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("d267b3d7-4418-405e-8b61-3a8f35fe1939");
			index.Name = "IX_Case_ClosureDate";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("83c7162c-a733-41b6-a4b1-9ea92dffedc5");
			EntitySchemaIndexColumn closureDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("e63e63fb-2458-b93e-02cc-2f47d80e613c"),
				ColumnUId = new Guid("e12191ff-2811-430d-aeca-7a4435e4b1b9"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("83c7162c-a733-41b6-a4b1-9ea92dffedc5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(closureDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646");
			Name = "Case_CMDB_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7c5530e9-ca8e-4fa7-b4b1-c88631206e5a")) == null) {
				Columns.Add(CreateConfItemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateConfItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7c5530e9-ca8e-4fa7-b4b1-c88631206e5a"),
				Name = @"ConfItem",
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"),
				ModifiedInSchemaUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_RegisteredOn_DescIndex());
			Indexes.Add(CreateIX_SolutionOverdue_AttributesIndex());
			Indexes.Add(CreateIX_ResponseOverdue_AttributesIndex());
			Indexes.Add(CreateIDX_SubjectIndex());
			Indexes.Add(CreateIX_Case_ClosureDateIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_CMDB_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Case_CMDBEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Case_CMDB_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_CMDB_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDB_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_CMDB_Terrasoft : Terrasoft.Configuration.Case_SLM_Terrasoft
	{

		#region Constructors: Public

		public Case_CMDB_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_CMDB_Terrasoft";
		}

		public Case_CMDB_Terrasoft(Case_CMDB_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ConfItemId {
			get {
				return GetTypedColumnValue<Guid>("ConfItemId");
			}
			set {
				SetColumnValue("ConfItemId", value);
				_confItem = null;
			}
		}

		/// <exclude/>
		public string ConfItemName {
			get {
				return GetTypedColumnValue<string>("ConfItemName");
			}
			set {
				SetColumnValue("ConfItemName", value);
				if (_confItem != null) {
					_confItem.Name = value;
				}
			}
		}

		private ConfItem _confItem;
		/// <summary>
		/// Configuration item.
		/// </summary>
		public ConfItem ConfItem {
			get {
				return _confItem ??
					(_confItem = LookupColumnEntities.GetEntity("ConfItem") as ConfItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_CMDBEventsProcess(UserConnection);
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
			return new Case_CMDB_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDBEventsProcess

	/// <exclude/>
	public partial class Case_CMDBEventsProcess<TEntity> : Terrasoft.Configuration.Case_SLMEventsProcess<TEntity> where TEntity : Case_CMDB_Terrasoft
	{

		public Case_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_CMDBEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a439b26c-6979-4109-baf8-bfe15dccf646");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid NewConfItemId {
			get;
			set;
		}

		public virtual Guid OldConfItemId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessActualizeConfItems;
		public ProcessFlowElement EventSubProcessActualizeConfItems {
			get {
				return _eventSubProcessActualizeConfItems ?? (_eventSubProcessActualizeConfItems = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessActualizeConfItems",
					SchemaElementUId = new Guid("800820ad-6447-4406-aaf9-af1d8723226b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1CaseSaved;
		public ProcessFlowElement StartMessage1CaseSaved {
			get {
				return _startMessage1CaseSaved ?? (_startMessage1CaseSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1CaseSaved",
					SchemaElementUId = new Guid("388e2043-3f5b-48b7-8b6f-65f0298c0812"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actulizeConfItemsInCaseScriptTask;
		public ProcessScriptTask ActulizeConfItemsInCaseScriptTask {
			get {
				return _actulizeConfItemsInCaseScriptTask ?? (_actulizeConfItemsInCaseScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActulizeConfItemsInCaseScriptTask",
					SchemaElementUId = new Guid("e3939498-7c63-4e6d-aba2-3ec3520c41d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActulizeConfItemsInCaseScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6_87c55d06709945cebad19986c51848e9;
		public ProcessFlowElement EventSubProcess6_87c55d06709945cebad19986c51848e9 {
			get {
				return _eventSubProcess6_87c55d06709945cebad19986c51848e9 ?? (_eventSubProcess6_87c55d06709945cebad19986c51848e9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6_87c55d06709945cebad19986c51848e9",
					SchemaElementUId = new Guid("87c55d06-7099-45ce-bad1-9986c51848e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_2e318f1741a743a9af1d63d61473ccb0;
		public ProcessFlowElement StartMessage3_2e318f1741a743a9af1d63d61473ccb0 {
			get {
				return _startMessage3_2e318f1741a743a9af1d63d61473ccb0 ?? (_startMessage3_2e318f1741a743a9af1d63d61473ccb0 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_2e318f1741a743a9af1d63d61473ccb0",
					SchemaElementUId = new Guid("2e318f17-41a7-43a9-af1d-63d61473ccb0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8_b02327163d5c40bcac65a748da3958cb;
		public ProcessScriptTask ScriptTask8_b02327163d5c40bcac65a748da3958cb {
			get {
				return _scriptTask8_b02327163d5c40bcac65a748da3958cb ?? (_scriptTask8_b02327163d5c40bcac65a748da3958cb = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8_b02327163d5c40bcac65a748da3958cb",
					SchemaElementUId = new Guid("b0232716-3d5c-40bc-ac65-a748da3958cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8_b02327163d5c40bcac65a748da3958cbExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessActualizeConfItems.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessActualizeConfItems };
			FlowElements[StartMessage1CaseSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1CaseSaved };
			FlowElements[ActulizeConfItemsInCaseScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActulizeConfItemsInCaseScriptTask };
			FlowElements[EventSubProcess6_87c55d06709945cebad19986c51848e9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6_87c55d06709945cebad19986c51848e9 };
			FlowElements[StartMessage3_2e318f1741a743a9af1d63d61473ccb0.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_2e318f1741a743a9af1d63d61473ccb0 };
			FlowElements[ScriptTask8_b02327163d5c40bcac65a748da3958cb.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8_b02327163d5c40bcac65a748da3958cb };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessActualizeConfItems":
						break;
					case "StartMessage1CaseSaved":
						e.Context.QueueTasks.Enqueue("ActulizeConfItemsInCaseScriptTask");
						break;
					case "ActulizeConfItemsInCaseScriptTask":
						break;
					case "EventSubProcess6_87c55d06709945cebad19986c51848e9":
						break;
					case "StartMessage3_2e318f1741a743a9af1d63d61473ccb0":
						e.Context.QueueTasks.Enqueue("ScriptTask8_b02327163d5c40bcac65a748da3958cb");
						break;
					case "ScriptTask8_b02327163d5c40bcac65a748da3958cb":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1CaseSaved");
			ActivatedEventElements.Add("StartMessage3_2e318f1741a743a9af1d63d61473ccb0");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessActualizeConfItems":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1CaseSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1CaseSaved";
					result = StartMessage1CaseSaved.Execute(context);
					break;
				case "ActulizeConfItemsInCaseScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActulizeConfItemsInCaseScriptTask";
					result = ActulizeConfItemsInCaseScriptTask.Execute(context, ActulizeConfItemsInCaseScriptTaskExecute);
					break;
				case "EventSubProcess6_87c55d06709945cebad19986c51848e9":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_2e318f1741a743a9af1d63d61473ccb0":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_2e318f1741a743a9af1d63d61473ccb0";
					result = StartMessage3_2e318f1741a743a9af1d63d61473ccb0.Execute(context);
					break;
				case "ScriptTask8_b02327163d5c40bcac65a748da3958cb":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8_b02327163d5c40bcac65a748da3958cb";
					result = ScriptTask8_b02327163d5c40bcac65a748da3958cb.Execute(context, ScriptTask8_b02327163d5c40bcac65a748da3958cbExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ActulizeConfItemsInCaseScriptTaskExecute(ProcessExecutingContext context) {
			ActulizeConfItemsInCase();
			return true;
		}

		public virtual bool ScriptTask8_b02327163d5c40bcac65a748da3958cbExecute(ProcessExecutingContext context) {
			if (!UserConnection.GetIsFeatureEnabled("UseCaseInCaseOldFunc")) {
				SetProcessParameters();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CaseSaved":
							if (ActivatedEventElements.Contains("StartMessage1CaseSaved")) {
							context.QueueTasks.Enqueue("StartMessage1CaseSaved");
						}
						break;
					case "CaseSaving":
							if (ActivatedEventElements.Contains("StartMessage3_2e318f1741a743a9af1d63d61473ccb0")) {
							context.QueueTasks.Enqueue("StartMessage3_2e318f1741a743a9af1d63d61473ccb0");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDBEventsProcess

	/// <exclude/>
	public class Case_CMDBEventsProcess : Case_CMDBEventsProcess<Case_CMDB_Terrasoft>
	{

		public Case_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

