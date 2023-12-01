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

	#region Class: Case_SLM_TerrasoftSchema

	/// <exclude/>
	public class Case_SLM_TerrasoftSchema : Terrasoft.Configuration.Case_CrtPortal_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_SLM_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_SLM_TerrasoftSchema(Case_SLM_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_SLM_TerrasoftSchema(Case_SLM_TerrasoftSchema source)
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
			RealUId = new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc");
			Name = "Case_SLM_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
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
			column.ModifiedInSchemaUId = new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc");
			return column;
		}

		protected override EntitySchemaColumn CreatePriorityColumn() {
			EntitySchemaColumn column = base.CreatePriorityColumn();
			column.ModifiedInSchemaUId = new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc");
			return column;
		}

		protected override EntitySchemaColumn CreateOriginColumn() {
			EntitySchemaColumn column = base.CreateOriginColumn();
			column.ModifiedInSchemaUId = new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc");
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
			return new Case_SLM_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Case_SLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Case_SLM_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_SLM_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLM_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_SLM_Terrasoft : Terrasoft.Configuration.Case_CrtPortal_Terrasoft
	{

		#region Constructors: Public

		public Case_SLM_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_SLM_Terrasoft";
		}

		public Case_SLM_Terrasoft(Case_SLM_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_SLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Case_SLM_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_SLM_TerrasoftSaving", e);
			SaveError += (s, e) => ThrowEvent("Case_SLM_TerrasoftSaveError", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_SLM_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMEventsProcess

	/// <exclude/>
	public partial class Case_SLMEventsProcess<TEntity> : Terrasoft.Configuration.Case_CrtPortalEventsProcess<TEntity> where TEntity : Case_SLM_Terrasoft
	{

		public Case_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_SLMEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("dec4d0e6-6ead-48e6-8d94-344df962bbbc");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid ClosedCaseLifeCycleId {
			get;
			set;
		}

		public virtual bool NeedSaveLifecycle {
			get;
			set;
		}

		public virtual Guid CreatedCaseLifecycleId {
			get;
			set;
		}

		public virtual bool StatusChanged {
			get;
			set;
		}

		public virtual bool IsNew {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess6_8e268c12b2734172be4c47b6485e0b24;
		public ProcessFlowElement EventSubProcess6_8e268c12b2734172be4c47b6485e0b24 {
			get {
				return _eventSubProcess6_8e268c12b2734172be4c47b6485e0b24 ?? (_eventSubProcess6_8e268c12b2734172be4c47b6485e0b24 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6_8e268c12b2734172be4c47b6485e0b24",
					SchemaElementUId = new Guid("8e268c12-b273-4172-be4c-47b6485e0b24"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sLM_CaseSavingStartMessage;
		public ProcessFlowElement SLM_CaseSavingStartMessage {
			get {
				return _sLM_CaseSavingStartMessage ?? (_sLM_CaseSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SLM_CaseSavingStartMessage",
					SchemaElementUId = new Guid("da64639c-abff-4790-a382-d6dcfcea0a1d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask8_cc8b58ab6f544f2bb509c957112ab6cc;
		public ProcessScriptTask ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc {
			get {
				return _scriptTask8_cc8b58ab6f544f2bb509c957112ab6cc ?? (_scriptTask8_cc8b58ab6f544f2bb509c957112ab6cc = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc",
					SchemaElementUId = new Guid("cc8b58ab-6f54-4f2b-b509-c957112ab6cc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask8_cc8b58ab6f544f2bb509c957112ab6ccExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask9_7d41c348574e4710bbaa97d91ced94a2;
		public ProcessScriptTask ScriptTask9_7d41c348574e4710bbaa97d91ced94a2 {
			get {
				return _scriptTask9_7d41c348574e4710bbaa97d91ced94a2 ?? (_scriptTask9_7d41c348574e4710bbaa97d91ced94a2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask9_7d41c348574e4710bbaa97d91ced94a2",
					SchemaElementUId = new Guid("7d41c348-574e-4710-bbaa-97d91ced94a2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask9_7d41c348574e4710bbaa97d91ced94a2Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask10_74673f7095934bc6a5c37dad569b2515;
		public ProcessScriptTask ScriptTask10_74673f7095934bc6a5c37dad569b2515 {
			get {
				return _scriptTask10_74673f7095934bc6a5c37dad569b2515 ?? (_scriptTask10_74673f7095934bc6a5c37dad569b2515 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask10_74673f7095934bc6a5c37dad569b2515",
					SchemaElementUId = new Guid("74673f70-9593-4bc6-a5c3-7dad569b2515"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask10_74673f7095934bc6a5c37dad569b2515Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1_01d47548f54a4613a44f193fec711568;
		public ProcessThrowMessageEvent IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568 {
			get {
				return _intermediateThrowMessage1_01d47548f54a4613a44f193fec711568 ?? (_intermediateThrowMessage1_01d47548f54a4613a44f193fec711568 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568",
					SchemaElementUId = new Guid("01d47548-f54a-4613-a44f-193fec711568"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SLM_CaseSavingIntermediateThrowMessage",
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway5_14deb0136a544446bd6804c868506f7f;
		public ProcessExclusiveGateway ExclusiveGateway5_14deb0136a544446bd6804c868506f7f {
			get {
				return _exclusiveGateway5_14deb0136a544446bd6804c868506f7f ?? (_exclusiveGateway5_14deb0136a544446bd6804c868506f7f = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway5_14deb0136a544446bd6804c868506f7f",
					SchemaElementUId = new Guid("14deb013-6a54-4446-bd68-04c868506f7f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway5_14deb0136a544446bd6804c868506f7f.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent2_8b4c8ed538024019a80f752b09cd767a;
		public ProcessTerminateEvent TerminateEvent2_8b4c8ed538024019a80f752b09cd767a {
			get {
				return _terminateEvent2_8b4c8ed538024019a80f752b09cd767a ?? (_terminateEvent2_8b4c8ed538024019a80f752b09cd767a = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent2_8b4c8ed538024019a80f752b09cd767a",
					SchemaElementUId = new Guid("8b4c8ed5-3802-4019-a80f-752b09cd767a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess7_ff559f0c25374808a567f63bedc150c6;
		public ProcessFlowElement EventSubProcess7_ff559f0c25374808a567f63bedc150c6 {
			get {
				return _eventSubProcess7_ff559f0c25374808a567f63bedc150c6 ?? (_eventSubProcess7_ff559f0c25374808a567f63bedc150c6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess7_ff559f0c25374808a567f63bedc150c6",
					SchemaElementUId = new Guid("ff559f0c-2537-4808-a567-f63bedc150c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage9_5969a30d831943f69a75f184230e2fe9;
		public ProcessFlowElement StartMessage9_5969a30d831943f69a75f184230e2fe9 {
			get {
				return _startMessage9_5969a30d831943f69a75f184230e2fe9 ?? (_startMessage9_5969a30d831943f69a75f184230e2fe9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage9_5969a30d831943f69a75f184230e2fe9",
					SchemaElementUId = new Guid("5969a30d-8319-43f6-9a75-f184230e2fe9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask11_5a7aabfcbb03475a842943beaf4d8596;
		public ProcessScriptTask ScriptTask11_5a7aabfcbb03475a842943beaf4d8596 {
			get {
				return _scriptTask11_5a7aabfcbb03475a842943beaf4d8596 ?? (_scriptTask11_5a7aabfcbb03475a842943beaf4d8596 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask11_5a7aabfcbb03475a842943beaf4d8596",
					SchemaElementUId = new Guid("5a7aabfc-bb03-475a-8429-43beaf4d8596"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask11_5a7aabfcbb03475a842943beaf4d8596Execute,
				});
			}
		}

		private ProcessScriptTask _scriptTask12_a94d1f8d4d0f44d29473fa2543bb6314;
		public ProcessScriptTask ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314 {
			get {
				return _scriptTask12_a94d1f8d4d0f44d29473fa2543bb6314 ?? (_scriptTask12_a94d1f8d4d0f44d29473fa2543bb6314 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314",
					SchemaElementUId = new Guid("a94d1f8d-4d0f-44d2-9473-fa2543bb6314"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _sLM_CaseSavedIntermediateThrowMessage;
		public ProcessThrowMessageEvent SLM_CaseSavedIntermediateThrowMessage {
			get {
				return _sLM_CaseSavedIntermediateThrowMessage ?? (_sLM_CaseSavedIntermediateThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SLM_CaseSavedIntermediateThrowMessage",
					SchemaElementUId = new Guid("68e43122-b8db-4486-ae2e-fc944e71b8ae"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaved",
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b;
		public ProcessExclusiveGateway ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b {
			get {
				return _exclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b ?? (_exclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b",
					SchemaElementUId = new Guid("b3c8442d-cb03-4be7-b540-cb71b6dd519b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f;
		public ProcessTerminateEvent TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f {
			get {
				return _terminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f ?? (_terminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f",
					SchemaElementUId = new Guid("49bc9884-1b8a-4d82-b873-5b3b4acf2f1f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess8_a872219dc8d241ea8800451ea251f5e8;
		public ProcessFlowElement EventSubProcess8_a872219dc8d241ea8800451ea251f5e8 {
			get {
				return _eventSubProcess8_a872219dc8d241ea8800451ea251f5e8 ?? (_eventSubProcess8_a872219dc8d241ea8800451ea251f5e8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8_a872219dc8d241ea8800451ea251f5e8",
					SchemaElementUId = new Guid("a872219d-c8d2-41ea-8800-451ea251f5e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage10_60f4958b34e940788ce83baf3474405e;
		public ProcessFlowElement StartMessage10_60f4958b34e940788ce83baf3474405e {
			get {
				return _startMessage10_60f4958b34e940788ce83baf3474405e ?? (_startMessage10_60f4958b34e940788ce83baf3474405e = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage10_60f4958b34e940788ce83baf3474405e",
					SchemaElementUId = new Guid("60f4958b-34e9-4078-8ce8-3baf3474405e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask13_98981b6b93b84ead8fbfa00a0a643c17;
		public ProcessScriptTask ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17 {
			get {
				return _scriptTask13_98981b6b93b84ead8fbfa00a0a643c17 ?? (_scriptTask13_98981b6b93b84ead8fbfa00a0a643c17 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17",
					SchemaElementUId = new Guid("98981b6b-93b8-4ead-8fbf-a00a0a643c17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff;
		public ProcessThrowMessageEvent IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff {
			get {
				return _intermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff ?? (_intermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff",
					SchemaElementUId = new Guid("f75ee7d4-5acc-4f13-aa87-898f7e98a9ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaved",
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194;
		public ProcessExclusiveGateway ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194 {
			get {
				return _exclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194 ?? (_exclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194",
					SchemaElementUId = new Guid("aa0fd3b5-7aa5-4fbd-9cc6-bb082cc4e194"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent3_2dbd4e6c77d540a0a5100c3f66024830;
		public ProcessTerminateEvent TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830 {
			get {
				return _terminateEvent3_2dbd4e6c77d540a0a5100c3f66024830 ?? (_terminateEvent3_2dbd4e6c77d540a0a5100c3f66024830 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830",
					SchemaElementUId = new Guid("2dbd4e6c-77d5-40a0-a510-0c3f66024830"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6f;
		public ProcessConditionalFlow ConditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6f {
			get {
				return _conditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6f ?? (_conditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6f = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6f",
					SchemaElementUId = new Guid("6e6328c8-73a5-4789-8613-b4d2d16acd6f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47e;
		public ProcessConditionalFlow ConditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47e {
			get {
				return _conditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47e ?? (_conditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47e = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47e",
					SchemaElementUId = new Guid("625c2810-e2a0-4790-a78d-261d17a8b47e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39c;
		public ProcessConditionalFlow ConditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39c {
			get {
				return _conditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39c ?? (_conditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39c = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39c",
					SchemaElementUId = new Guid("7e64a88f-f25d-473f-bff5-4091c982c39c"),
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
			FlowElements[EventSubProcess6_8e268c12b2734172be4c47b6485e0b24.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6_8e268c12b2734172be4c47b6485e0b24 };
			FlowElements[SLM_CaseSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavingStartMessage };
			FlowElements[ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc };
			FlowElements[ScriptTask9_7d41c348574e4710bbaa97d91ced94a2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask9_7d41c348574e4710bbaa97d91ced94a2 };
			FlowElements[ScriptTask10_74673f7095934bc6a5c37dad569b2515.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask10_74673f7095934bc6a5c37dad569b2515 };
			FlowElements[IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568 };
			FlowElements[ExclusiveGateway5_14deb0136a544446bd6804c868506f7f.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway5_14deb0136a544446bd6804c868506f7f };
			FlowElements[TerminateEvent2_8b4c8ed538024019a80f752b09cd767a.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent2_8b4c8ed538024019a80f752b09cd767a };
			FlowElements[EventSubProcess7_ff559f0c25374808a567f63bedc150c6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess7_ff559f0c25374808a567f63bedc150c6 };
			FlowElements[StartMessage9_5969a30d831943f69a75f184230e2fe9.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage9_5969a30d831943f69a75f184230e2fe9 };
			FlowElements[ScriptTask11_5a7aabfcbb03475a842943beaf4d8596.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask11_5a7aabfcbb03475a842943beaf4d8596 };
			FlowElements[ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314 };
			FlowElements[SLM_CaseSavedIntermediateThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavedIntermediateThrowMessage };
			FlowElements[ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b };
			FlowElements[TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f };
			FlowElements[EventSubProcess8_a872219dc8d241ea8800451ea251f5e8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8_a872219dc8d241ea8800451ea251f5e8 };
			FlowElements[StartMessage10_60f4958b34e940788ce83baf3474405e.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage10_60f4958b34e940788ce83baf3474405e };
			FlowElements[ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17 };
			FlowElements[IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff };
			FlowElements[ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194 };
			FlowElements[TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess6_8e268c12b2734172be4c47b6485e0b24":
						break;
					case "SLM_CaseSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway5_14deb0136a544446bd6804c868506f7f");
						break;
					case "ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc":
						e.Context.QueueTasks.Enqueue("ScriptTask9_7d41c348574e4710bbaa97d91ced94a2");
						break;
					case "ScriptTask9_7d41c348574e4710bbaa97d91ced94a2":
						e.Context.QueueTasks.Enqueue("ScriptTask10_74673f7095934bc6a5c37dad569b2515");
						break;
					case "ScriptTask10_74673f7095934bc6a5c37dad569b2515":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568");
						break;
					case "IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568":
						break;
					case "ExclusiveGateway5_14deb0136a544446bd6804c868506f7f":
						if (ConditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6fExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent2_8b4c8ed538024019a80f752b09cd767a");
						break;
					case "TerminateEvent2_8b4c8ed538024019a80f752b09cd767a":
						break;
					case "EventSubProcess7_ff559f0c25374808a567f63bedc150c6":
						break;
					case "StartMessage9_5969a30d831943f69a75f184230e2fe9":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b");
						break;
					case "ScriptTask11_5a7aabfcbb03475a842943beaf4d8596":
						e.Context.QueueTasks.Enqueue("ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314");
						break;
					case "ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314":
						e.Context.QueueTasks.Enqueue("SLM_CaseSavedIntermediateThrowMessage");
						break;
					case "SLM_CaseSavedIntermediateThrowMessage":
						break;
					case "ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b":
						if (ConditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39cExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask11_5a7aabfcbb03475a842943beaf4d8596");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f");
						break;
					case "TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f":
						break;
					case "EventSubProcess8_a872219dc8d241ea8800451ea251f5e8":
						break;
					case "StartMessage10_60f4958b34e940788ce83baf3474405e":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194");
						break;
					case "ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff");
						break;
					case "IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff":
						break;
					case "ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194":
						if (ConditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47eExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17");
							break;
						}
						e.Context.QueueTasks.Enqueue("TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830");
						break;
					case "TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalSequenceFlow6_6e6328c873a547898613b4d2d16acd6fExpressionExecute() {
			return Convert.ToBoolean(UserConnection.GetIsFeatureEnabled("UseCaseInSLMOldFunc"));
		}

		private bool ConditionalSequenceFlow8_625c2810e2a04790a78d261d17a8b47eExpressionExecute() {
			return Convert.ToBoolean(UserConnection.GetIsFeatureEnabled("UseCaseInSLMOldFunc"));
		}

		private bool ConditionalSequenceFlow10_7e64a88ff25d473fbff54091c982c39cExpressionExecute() {
			return Convert.ToBoolean(UserConnection.GetIsFeatureEnabled("UseCaseInSLMOldFunc"));
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SLM_CaseSavingStartMessage");
			ActivatedEventElements.Add("StartMessage9_5969a30d831943f69a75f184230e2fe9");
			ActivatedEventElements.Add("StartMessage10_60f4958b34e940788ce83baf3474405e");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess6_8e268c12b2734172be4c47b6485e0b24":
					context.QueueTasks.Dequeue();
					break;
				case "SLM_CaseSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SLM_CaseSavingStartMessage";
					result = SLM_CaseSavingStartMessage.Execute(context);
					break;
				case "ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc";
					result = ScriptTask8_cc8b58ab6f544f2bb509c957112ab6cc.Execute(context, ScriptTask8_cc8b58ab6f544f2bb509c957112ab6ccExecute);
					break;
				case "ScriptTask9_7d41c348574e4710bbaa97d91ced94a2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask9_7d41c348574e4710bbaa97d91ced94a2";
					result = ScriptTask9_7d41c348574e4710bbaa97d91ced94a2.Execute(context, ScriptTask9_7d41c348574e4710bbaa97d91ced94a2Execute);
					break;
				case "ScriptTask10_74673f7095934bc6a5c37dad569b2515":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask10_74673f7095934bc6a5c37dad569b2515";
					result = ScriptTask10_74673f7095934bc6a5c37dad569b2515.Execute(context, ScriptTask10_74673f7095934bc6a5c37dad569b2515Execute);
					break;
				case "IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage1_01d47548f54a4613a44f193fec711568.Execute(context);
					break;
				case "ExclusiveGateway5_14deb0136a544446bd6804c868506f7f":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway5_14deb0136a544446bd6804c868506f7f";
					result = ExclusiveGateway5_14deb0136a544446bd6804c868506f7f.Execute(context);
					break;
				case "TerminateEvent2_8b4c8ed538024019a80f752b09cd767a":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess7_ff559f0c25374808a567f63bedc150c6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage9_5969a30d831943f69a75f184230e2fe9":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage9_5969a30d831943f69a75f184230e2fe9";
					result = StartMessage9_5969a30d831943f69a75f184230e2fe9.Execute(context);
					break;
				case "ScriptTask11_5a7aabfcbb03475a842943beaf4d8596":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask11_5a7aabfcbb03475a842943beaf4d8596";
					result = ScriptTask11_5a7aabfcbb03475a842943beaf4d8596.Execute(context, ScriptTask11_5a7aabfcbb03475a842943beaf4d8596Execute);
					break;
				case "ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314";
					result = ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314.Execute(context, ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314Execute);
					break;
				case "SLM_CaseSavedIntermediateThrowMessage":
					context.QueueTasks.Dequeue();
					result = SLM_CaseSavedIntermediateThrowMessage.Execute(context);
					break;
				case "ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b";
					result = ExclusiveGateway7_b3c8442dcb034be7b540cb71b6dd519b.Execute(context);
					break;
				case "TerminateEvent4_49bc98841b8a4d82b8735b3b4acf2f1f":
					context.QueueTasks.Dequeue();
					break;
				case "EventSubProcess8_a872219dc8d241ea8800451ea251f5e8":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage10_60f4958b34e940788ce83baf3474405e":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage10_60f4958b34e940788ce83baf3474405e";
					result = StartMessage10_60f4958b34e940788ce83baf3474405e.Execute(context);
					break;
				case "ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17";
					result = ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17.Execute(context, ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17Execute);
					break;
				case "IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessage3_f75ee7d45acc4f13aa87898f7e98a9ff.Execute(context);
					break;
				case "ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194";
					result = ExclusiveGateway6_aa0fd3b57aa54fbd9cc6bb082cc4e194.Execute(context);
					break;
				case "TerminateEvent3_2dbd4e6c77d540a0a5100c3f66024830":
					context.QueueTasks.Dequeue();
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask8_cc8b58ab6f544f2bb509c957112ab6ccExecute(ProcessExecutingContext context) {
			StatusChanged = CheckIsStatusChanged();
			IsNew = Entity.GetTypedOldColumnValue<Guid>("Id") == Guid.Empty;
			return true;
		}

		public virtual bool ScriptTask9_7d41c348574e4710bbaa97d91ced94a2Execute(ProcessExecutingContext context) {
			UpdateResponse();
			UpdateSolution();
			UpdateClosureDate();
			CalculateTerms();
			return true;
		}

		public virtual bool ScriptTask10_74673f7095934bc6a5c37dad569b2515Execute(ProcessExecutingContext context) {
			NeedSaveLifecycle = GetIsNeedToLogLifecycle();
			if (NeedSaveLifecycle) {
				SaveLifecycle();
			}
			return true;
		}

		public virtual bool ScriptTask11_5a7aabfcbb03475a842943beaf4d8596Execute(ProcessExecutingContext context) {
			if (NeedSaveLifecycle) {
				LogChangedColumns();
			}
			return true;
		}

		public virtual bool ScriptTask12_a94d1f8d4d0f44d29473fa2543bb6314Execute(ProcessExecutingContext context) {
			NotifyUser();
			return true;
		}

		public virtual bool ScriptTask13_98981b6b93b84ead8fbfa00a0a643c17Execute(ProcessExecutingContext context) {
			var delete = new Delete(UserConnection).From("CaseLifecycle")
			.Where("Id")
				.IsEqual(Column.Parameter(CreatedCaseLifecycleId));
			delete.Execute();
			var instance = UserConnection.EntitySchemaManager.GetInstanceByName("CaseLifecycle");
			var caseLifecycle = instance.CreateEntity(UserConnection);
			if (caseLifecycle.FetchFromDB(ClosedCaseLifeCycleId)) {
				caseLifecycle.SetColumnValue("EndDate", null);
				caseLifecycle.SetColumnValue("StateDurationInMinutes", null);
				caseLifecycle.SetColumnValue("StateDurationInHours", null);
				caseLifecycle.SetColumnValue("StateDurationInDays", null);
				caseLifecycle.Save();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_SLM_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SLM_CaseSavingStartMessage")) {
							context.QueueTasks.Enqueue("SLM_CaseSavingStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Case_SLM_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage9_5969a30d831943f69a75f184230e2fe9")) {
							context.QueueTasks.Enqueue("StartMessage9_5969a30d831943f69a75f184230e2fe9");
						}
						break;
					case "Case_SLM_TerrasoftSaveError":
							if (ActivatedEventElements.Contains("StartMessage10_60f4958b34e940788ce83baf3474405e")) {
							context.QueueTasks.Enqueue("StartMessage10_60f4958b34e940788ce83baf3474405e");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMEventsProcess

	/// <exclude/>
	public class Case_SLMEventsProcess : Case_SLMEventsProcess<Case_SLM_Terrasoft>
	{

		public Case_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

