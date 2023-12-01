namespace Terrasoft.Configuration
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

	#region Class: Case_Case_TerrasoftSchema

	/// <exclude/>
	public class Case_Case_TerrasoftSchema : Terrasoft.Configuration.Case_CrtCaseManagmentObject_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_Case_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_Case_TerrasoftSchema(Case_Case_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_Case_TerrasoftSchema(Case_Case_TerrasoftSchema source)
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
			RealUId = new Guid("238fd3b5-9014-4057-a655-8dfbc820a743");
			Name = "Case_Case_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = true;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("238fd3b5-9014-4057-a655-8dfbc820a743");
			return column;
		}

		protected override EntitySchemaColumn CreatePriorityColumn() {
			EntitySchemaColumn column = base.CreatePriorityColumn();
			column.ModifiedInSchemaUId = new Guid("238fd3b5-9014-4057-a655-8dfbc820a743");
			return column;
		}

		protected override EntitySchemaColumn CreateOriginColumn() {
			EntitySchemaColumn column = base.CreateOriginColumn();
			column.ModifiedInSchemaUId = new Guid("238fd3b5-9014-4057-a655-8dfbc820a743");
			return column;
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
			return new Case_Case_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Case_CaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Case_Case_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_Case_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("238fd3b5-9014-4057-a655-8dfbc820a743"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_Case_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_Case_Terrasoft : Terrasoft.Configuration.Case_CrtCaseManagmentObject_Terrasoft
	{

		#region Constructors: Public

		public Case_Case_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_Case_Terrasoft";
		}

		public Case_Case_Terrasoft(Case_Case_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("Case_Case_TerrasoftInserting", e);
			Saving += (s, e) => ThrowEvent("Case_Case_TerrasoftSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_Case_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_CaseEventsProcess

	/// <exclude/>
	public partial class Case_CaseEventsProcess<TEntity> : Terrasoft.Configuration.Case_CrtCaseManagmentObjectEventsProcess<TEntity> where TEntity : Case_Case_Terrasoft
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Case_CaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("2950e9c2-93b7-455c-811a-97a647b6babb");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Case_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_CaseEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("238fd3b5-9014-4057-a655-8dfbc820a743");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb;
		public ProcessFlowElement EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb {
			get {
				return _eventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb ?? (_eventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb",
					SchemaElementUId = new Guid("e9b46f5a-d3a1-4965-a56a-332f29a6bfeb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseSaving;
		public ProcessFlowElement CaseSaving {
			get {
				return _caseSaving ?? (_caseSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseSaving",
					SchemaElementUId = new Guid("4c4c60a1-2c37-4f75-8182-34d6bb493f97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_59172719002445b1a1206226f545deed;
		public ProcessScriptTask ScriptTask3_59172719002445b1a1206226f545deed {
			get {
				return _scriptTask3_59172719002445b1a1206226f545deed ?? (_scriptTask3_59172719002445b1a1206226f545deed = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_59172719002445b1a1206226f545deed",
					SchemaElementUId = new Guid("59172719-0024-45b1-a120-6226f545deed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_59172719002445b1a1206226f545deedExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc;
		public ProcessFlowElement EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc {
			get {
				return _eventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc ?? (_eventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc",
					SchemaElementUId = new Guid("31c0f16f-9057-4ac4-8eea-60051fe8d9cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseInserting;
		public ProcessFlowElement CaseInserting {
			get {
				return _caseInserting ?? (_caseInserting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseInserting",
					SchemaElementUId = new Guid("ac5e99ce-864a-43db-a337-86faa8995a0d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_4f266438e2264953b9832eef7078a01a;
		public ProcessScriptTask ScriptTask4_4f266438e2264953b9832eef7078a01a {
			get {
				return _scriptTask4_4f266438e2264953b9832eef7078a01a ?? (_scriptTask4_4f266438e2264953b9832eef7078a01a = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_4f266438e2264953b9832eef7078a01a",
					SchemaElementUId = new Guid("4f266438-e226-4953-b983-2eef7078a01a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_4f266438e2264953b9832eef7078a01aExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4;
		public ProcessExclusiveGateway ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4 {
			get {
				return _exclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4 ?? (_exclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4",
					SchemaElementUId = new Guid("eeb11eeb-d7ee-4e4a-a96f-2501e46bc5f4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9;
		public ProcessExclusiveGateway ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9 {
			get {
				return _exclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9 ?? (_exclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9",
					SchemaElementUId = new Guid("c5a69514-ccb4-45b9-927e-4d2165cf34e9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9;
		public ProcessTerminateEvent TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9 {
			get {
				return _terminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9 ?? (_terminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9",
					SchemaElementUId = new Guid("dc52e47a-9fec-4b83-8494-d41f6bb2fae9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f;
		public ProcessScriptTask ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f {
			get {
				return _scriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f ?? (_scriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f",
					SchemaElementUId = new Guid("7ec25dca-49b1-4acb-bf93-0b1d62f6cf8f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8fExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask6_e7baaca435cc41f280597ed7d8f24d7c;
		public ProcessScriptTask ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c {
			get {
				return _scriptTask6_e7baaca435cc41f280597ed7d8f24d7c ?? (_scriptTask6_e7baaca435cc41f280597ed7d8f24d7c = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c",
					SchemaElementUId = new Guid("e7baaca4-35cc-41f2-8059-7ed7d8f24d7c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask6_e7baaca435cc41f280597ed7d8f24d7cExecute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask7_d3304acdbdb04ba0a1d260ca294d35d7;
		public ProcessScriptTask ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7 {
			get {
				return _scriptTask7_d3304acdbdb04ba0a1d260ca294d35d7 ?? (_scriptTask7_d3304acdbdb04ba0a1d260ca294d35d7 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7",
					SchemaElementUId = new Guid("d3304acd-bdb0-4ba0-a1d2-60ca294d35d7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7Execute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6;
		public ProcessConditionalFlow ConditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6 {
			get {
				return _conditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6 ?? (_conditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6",
					SchemaElementUId = new Guid("4abad818-d7a8-43a7-ba7e-586e7fe424d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2;
		public ProcessConditionalFlow ConditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2 {
			get {
				return _conditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2 ?? (_conditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2",
					SchemaElementUId = new Guid("98a32baf-e1c8-4283-a854-92f207af86b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb };
			FlowElements[CaseSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSaving };
			FlowElements[ScriptTask3_59172719002445b1a1206226f545deed.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_59172719002445b1a1206226f545deed };
			FlowElements[EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc };
			FlowElements[CaseInserting.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseInserting };
			FlowElements[ScriptTask4_4f266438e2264953b9832eef7078a01a.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_4f266438e2264953b9832eef7078a01a };
			FlowElements[ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4 };
			FlowElements[ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9 };
			FlowElements[TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9 };
			FlowElements[ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f };
			FlowElements[ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb":
						break;
					case "CaseSaving":
						e.Context.QueueTasks.Enqueue("ScriptTask3_59172719002445b1a1206226f545deed");
						break;
					case "ScriptTask3_59172719002445b1a1206226f545deed":
						break;
					case "EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc":
						break;
					case "CaseInserting":
						e.Context.QueueTasks.Enqueue("ScriptTask4_4f266438e2264953b9832eef7078a01a");
						break;
					case "ScriptTask4_4f266438e2264953b9832eef7078a01a":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4");
						break;
					case "ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4":
						if (ConditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9");
						break;
					case "ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9":
						if (ConditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c");
						break;
					case "TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9":
						break;
					case "ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7");
						break;
					case "ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow2_4abad818d7a843a7ba7e586e7fe424d6ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		private bool ConditionalSequenceFlow4_98a32bafe1c84283a85492f207af86b2ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.CurrentUser.ConnectionType != UserType.SSP);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CaseSaving");
			ActivatedEventElements.Add("CaseInserting");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4_e9b46f5ad3a14965a56a332f29a6bfeb":
					context.QueueTasks.Dequeue();
					break;
				case "CaseSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSaving";
					result = CaseSaving.Execute(context);
					break;
				case "ScriptTask3_59172719002445b1a1206226f545deed":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_59172719002445b1a1206226f545deed";
					result = ScriptTask3_59172719002445b1a1206226f545deed.Execute(context, ScriptTask3_59172719002445b1a1206226f545deedExecute);
					break;
				case "EventSubProcess5_31c0f16f90574ac48eea60051fe8d9cc":
					context.QueueTasks.Dequeue();
					break;
				case "CaseInserting":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseInserting";
					result = CaseInserting.Execute(context);
					break;
				case "ScriptTask4_4f266438e2264953b9832eef7078a01a":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_4f266438e2264953b9832eef7078a01a";
					result = ScriptTask4_4f266438e2264953b9832eef7078a01a.Execute(context, ScriptTask4_4f266438e2264953b9832eef7078a01aExecute);
					break;
				case "ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4";
					result = ExclusiveGateway3_eeb11eebd7ee4e4aa96f2501e46bc5f4.Execute(context);
					break;
				case "ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9";
					result = ExclusiveGateway4_c5a69514ccb445b9927e4d2165cf34e9.Execute(context);
					break;
				case "TerminateEvent1_dc52e47a9fec4b838494d41f6bb2fae9":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f";
					result = ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8f.Execute(context, ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8fExecute);
					break;
				case "ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c";
					result = ScriptTask6_e7baaca435cc41f280597ed7d8f24d7c.Execute(context, ScriptTask6_e7baaca435cc41f280597ed7d8f24d7cExecute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7";
					result = ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7.Execute(context, ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_59172719002445b1a1206226f545deedExecute(ProcessExecutingContext context) {
			if(IsStatusChanged(Entity) && UserConnection.GetIsFeatureEnabled("CaseRuleApplier")) {
				CaseRuleApplier ruleApplier = new CaseRuleApplier(UserConnection);
				ruleApplier.Execute(Entity);
			}
			return true;
		}

		public virtual bool ScriptTask4_4f266438e2264953b9832eef7078a01aExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("UseCaseInCaseOldFunc")) {
				if (string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Symptoms"))) {
					var subject = Entity.GetTypedColumnValue<string>("Subject");
					Entity.SetColumnValue("Symptoms", subject);
				}
			}
			return true;
			
		}

		public virtual bool ScriptTask5_7ec25dca49b14acbbf930b1d62f6cf8fExecute(ProcessExecutingContext context) {
			Entity.Schema.Name = "Case";
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool ScriptTask6_e7baaca435cc41f280597ed7d8f24d7cExecute(ProcessExecutingContext context) {
			Entity.Schema.Name = "Case";
			string code = string.Empty;
			var systemUserConnection = UserConnection.AppConnection.SystemUserConnection;
			var generateNumberUserTask = 
				new Terrasoft.Core.Process.Configuration.GenerateSequenseNumberUserTask(systemUserConnection);
			generateNumberUserTask.EntitySchema = Entity.Schema;
			generateNumberUserTask.UId = Guid.NewGuid();
			generateNumberUserTask.Owner = this;
			generateNumberUserTask.Name = "SetPortalNumberScriptTaskExecute";
			code = generateNumberUserTask.GenerateSequenseNumber(Entity.Schema, systemUserConnection);
			if(!string.IsNullOrEmpty(code)) {
				Entity.SetColumnValue("Number", code);
			}
			if (UserConnection.GetIsFeatureEnabled("UseCaseInCaseOldFunc")) {
				SetPortalCaseSubject();
			}
			return true;
		}

		public virtual bool ScriptTask7_d3304acdbdb04ba0a1d260ca294d35d7Execute(ProcessExecutingContext context) {
			string code = string.Empty;
			code = GenerateNumberUserTask.ResultCode;
			if(!string.IsNullOrEmpty(code)) {
				Entity.SetColumnValue("Number", code);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_Case_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CaseSaving")) {
							context.QueueTasks.Enqueue("CaseSaving");
						}
						break;
					case "Case_Case_TerrasoftInserting":
							if (ActivatedEventElements.Contains("CaseInserting")) {
							context.QueueTasks.Enqueue("CaseInserting");
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

	#region Class: Case_CaseEventsProcess

	/// <exclude/>
	public class Case_CaseEventsProcess : Case_CaseEventsProcess<Case_Case_Terrasoft>
	{

		public Case_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

