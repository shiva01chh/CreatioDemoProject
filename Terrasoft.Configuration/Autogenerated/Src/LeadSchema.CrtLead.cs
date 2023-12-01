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

	#region Class: Lead_CrtLead_TerrasoftSchema

	/// <exclude/>
	public class Lead_CrtLead_TerrasoftSchema : Terrasoft.Configuration.BaseEntityNotesSchema
	{

		#region Constructors: Public

		public Lead_CrtLead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_CrtLead_TerrasoftSchema(Lead_CrtLead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_CrtLead_TerrasoftSchema(Lead_CrtLead_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			RealUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			Name = "Lead_CrtLead_Terrasoft";
			ParentSchemaUId = new Guid("a22b1e79-7fc1-4fe5-aba0-538e9df96f17");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateLeadNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeOwnerColumn() {
			base.InitializeOwnerColumn();
			OwnerColumn = CreateOwnerColumn();
			if (Columns.FindByUId(OwnerColumn.UId) == null) {
				Columns.Add(OwnerColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9ad7b70c-f7cb-4877-8186-16c8dea584fa")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("3875ae0d-ca52-4134-81df-2f67a88a3e78")) == null) {
				Columns.Add(CreateCommentaryColumn());
			}
			if (Columns.FindByUId(new Guid("ad490d58-054a-4d85-9246-dd8466eb3983")) == null) {
				Columns.Add(CreateQualifiedContactColumn());
			}
			if (Columns.FindByUId(new Guid("32949ae4-ff13-48f5-9f5d-45a74558ea55")) == null) {
				Columns.Add(CreateQualifiedAccountColumn());
			}
			if (Columns.FindByUId(new Guid("5c696704-62e8-4503-86bf-ed66c3dd63d5")) == null) {
				Columns.Add(CreateLeadTypeColumn());
			}
			if (Columns.FindByUId(new Guid("1970ed4a-c0ea-4d9d-97ab-68bc7ccc324a")) == null) {
				Columns.Add(CreateLeadDisqualifyReasonColumn());
			}
			if (Columns.FindByUId(new Guid("c7fb190e-51d8-4c65-a5db-c3714d3b0af7")) == null) {
				Columns.Add(CreateDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("4a577f44-6cf7-40d0-b1f8-81c2cf6539d1")) == null) {
				Columns.Add(CreateDecisionRoleColumn());
			}
			if (Columns.FindByUId(new Guid("bc0c2d60-5a3d-4840-aa4e-c60ea776e206")) == null) {
				Columns.Add(CreateQualifyStatusColumn());
			}
			if (Columns.FindByUId(new Guid("5c0fa796-b083-4126-ace9-cfddc25539a0")) == null) {
				Columns.Add(CreateSalesOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("882bf1d7-3d1f-4208-80ca-bf913c8d4f2f")) == null) {
				Columns.Add(CreateBudgetColumn());
			}
			if (Columns.FindByUId(new Guid("4c3a6f1b-99d3-4baf-8954-076274d0675c")) == null) {
				Columns.Add(CreateDecisionDateColumn());
			}
			if (Columns.FindByUId(new Guid("52e9a4db-31fd-4cec-8ad5-4f07143c900c")) == null) {
				Columns.Add(CreateLeadSourceColumn());
			}
			if (Columns.FindByUId(new Guid("6af59dc9-8eda-4550-b30a-00db9126349c")) == null) {
				Columns.Add(CreateLeadMediumColumn());
			}
			if (Columns.FindByUId(new Guid("99289843-7e55-eeee-ef5c-1ab3b2d0f0c2")) == null) {
				Columns.Add(CreateGroupColumn());
			}
			if (Columns.FindByUId(new Guid("d64963de-2282-a543-b1f1-c4f5d8705837")) == null) {
				Columns.Add(CreateLeadTypeDetailsColumn());
			}
			if (Columns.FindByUId(new Guid("efc32501-4c3a-4500-8fa4-1d70c6bf26f9")) == null) {
				Columns.Add(CreateMeetingDateColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateLeadNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				Name = @"LeadName",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9ad7b70c-f7cb-4877-8186-16c8dea584fa"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("8afb33a4-8b82-4325-a15b-44a8b4ccd7f3"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"bd3511f8-f36b-1410-4493-1c6f65e16a07"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCommentaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3875ae0d-ca52-4134-81df-2f67a88a3e78"),
				Name = @"Commentary",
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ad490d58-054a-4d85-9246-dd8466eb3983"),
				Name = @"QualifiedContact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("32949ae4-ff13-48f5-9f5d-45a74558ea55"),
				Name = @"QualifiedAccount",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5c696704-62e8-4503-86bf-ed66c3dd63d5"),
				Name = @"LeadType",
				ReferenceSchemaUId = new Guid("e0dbeb22-4932-4eee-a8f2-a247a5fce888"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateLeadDisqualifyReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1970ed4a-c0ea-4d9d-97ab-68bc7ccc324a"),
				Name = @"LeadDisqualifyReason",
				ReferenceSchemaUId = new Guid("086904b2-10a7-4156-bb21-c23a98228ace"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c7fb190e-51d8-4c65-a5db-c3714d3b0af7"),
				Name = @"Department",
				ReferenceSchemaUId = new Guid("7a269220-a657-4b5f-bfb4-ebe596e419d8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4a577f44-6cf7-40d0-b1f8-81c2cf6539d1"),
				Name = @"DecisionRole",
				ReferenceSchemaUId = new Guid("54aa771f-fba6-4d76-9239-bff3f00ee3e5"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateQualifyStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bc0c2d60-5a3d-4840-aa4e-c60ea776e206"),
				Name = @"QualifyStatus",
				ReferenceSchemaUId = new Guid("22341cd1-5b33-4c40-9011-6f7693ef6e44"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"DefaultLeadStage"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("52817348-4c01-4015-a766-cb10c7b554c8"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSalesOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5c0fa796-b083-4126-ace9-cfddc25539a0"),
				Name = @"SalesOwner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2")
			};
		}

		protected virtual EntitySchemaColumn CreateBudgetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("882bf1d7-3d1f-4208-80ca-bf913c8d4f2f"),
				Name = @"Budget",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("4261e5b6-ac7c-4768-a57f-7066cca089f2")
			};
		}

		protected virtual EntitySchemaColumn CreateDecisionDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("4c3a6f1b-99d3-4baf-8954-076274d0675c"),
				Name = @"DecisionDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("ed05a91d-cec9-4c5e-a904-603ee0a7a7cf")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("52e9a4db-31fd-4cec-8ad5-4f07143c900c"),
				Name = @"LeadSource",
				ReferenceSchemaUId = new Guid("533025a5-cb29-46d5-935a-7e12616d69b6"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("f66d94dc-fe0c-4783-80ca-eecdef787525"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateLeadMediumColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6af59dc9-8eda-4550-b30a-00db9126349c"),
				Name = @"LeadMedium",
				ReferenceSchemaUId = new Guid("308ef8cd-4f4f-4898-9b3d-36ab9af01f5c"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("f66d94dc-fe0c-4783-80ca-eecdef787525"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("99289843-7e55-eeee-ef5c-1ab3b2d0f0c2"),
				Name = @"Group",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("f8929573-48e9-4a59-b8b5-0cdb301981ee")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadTypeDetailsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d64963de-2282-a543-b1f1-c4f5d8705837"),
				Name = @"LeadTypeDetails",
				ReferenceSchemaUId = new Guid("0e0b34a6-c7db-472e-ad08-d5eaeb7e356b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("220af5cc-764d-46b3-96f6-cd9d8d9d1750"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"5a9a1f1a-a07a-432c-a159-b8b96f0aa127"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateMeetingDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("efc32501-4c3a-4500-8fa4-1d70c6bf26f9"),
				Name = @"MeetingDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("51a0fc55-ce4f-a533-0340-b70a0c04b905")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_CrtLead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_CrtLeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_CrtLead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_CrtLead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLead_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_CrtLead_Terrasoft : Terrasoft.Configuration.BaseEntityNotes
	{

		#region Constructors: Public

		public Lead_CrtLead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_CrtLead_Terrasoft";
		}

		public Lead_CrtLead_Terrasoft(Lead_CrtLead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Lead.
		/// </summary>
		public string LeadName {
			get {
				return GetTypedColumnValue<string>("LeadName");
			}
			set {
				SetColumnValue("LeadName", value);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private LeadStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public LeadStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as LeadStatus);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Commentary {
			get {
				return GetTypedColumnValue<string>("Commentary");
			}
			set {
				SetColumnValue("Commentary", value);
			}
		}

		/// <exclude/>
		public Guid QualifiedContactId {
			get {
				return GetTypedColumnValue<Guid>("QualifiedContactId");
			}
			set {
				SetColumnValue("QualifiedContactId", value);
				_qualifiedContact = null;
			}
		}

		/// <exclude/>
		public string QualifiedContactName {
			get {
				return GetTypedColumnValue<string>("QualifiedContactName");
			}
			set {
				SetColumnValue("QualifiedContactName", value);
				if (_qualifiedContact != null) {
					_qualifiedContact.Name = value;
				}
			}
		}

		private Contact _qualifiedContact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact QualifiedContact {
			get {
				return _qualifiedContact ??
					(_qualifiedContact = LookupColumnEntities.GetEntity("QualifiedContact") as Contact);
			}
		}

		/// <exclude/>
		public Guid QualifiedAccountId {
			get {
				return GetTypedColumnValue<Guid>("QualifiedAccountId");
			}
			set {
				SetColumnValue("QualifiedAccountId", value);
				_qualifiedAccount = null;
			}
		}

		/// <exclude/>
		public string QualifiedAccountName {
			get {
				return GetTypedColumnValue<string>("QualifiedAccountName");
			}
			set {
				SetColumnValue("QualifiedAccountName", value);
				if (_qualifiedAccount != null) {
					_qualifiedAccount.Name = value;
				}
			}
		}

		private Account _qualifiedAccount;
		/// <summary>
		/// Account.
		/// </summary>
		public Account QualifiedAccount {
			get {
				return _qualifiedAccount ??
					(_qualifiedAccount = LookupColumnEntities.GetEntity("QualifiedAccount") as Account);
			}
		}

		/// <exclude/>
		public Guid LeadTypeId {
			get {
				return GetTypedColumnValue<Guid>("LeadTypeId");
			}
			set {
				SetColumnValue("LeadTypeId", value);
				_leadType = null;
			}
		}

		/// <exclude/>
		public string LeadTypeName {
			get {
				return GetTypedColumnValue<string>("LeadTypeName");
			}
			set {
				SetColumnValue("LeadTypeName", value);
				if (_leadType != null) {
					_leadType.Name = value;
				}
			}
		}

		private LeadType _leadType;
		/// <summary>
		/// Customer need.
		/// </summary>
		public LeadType LeadType {
			get {
				return _leadType ??
					(_leadType = LookupColumnEntities.GetEntity("LeadType") as LeadType);
			}
		}

		/// <exclude/>
		public Guid LeadDisqualifyReasonId {
			get {
				return GetTypedColumnValue<Guid>("LeadDisqualifyReasonId");
			}
			set {
				SetColumnValue("LeadDisqualifyReasonId", value);
				_leadDisqualifyReason = null;
			}
		}

		/// <exclude/>
		public string LeadDisqualifyReasonName {
			get {
				return GetTypedColumnValue<string>("LeadDisqualifyReasonName");
			}
			set {
				SetColumnValue("LeadDisqualifyReasonName", value);
				if (_leadDisqualifyReason != null) {
					_leadDisqualifyReason.Name = value;
				}
			}
		}

		private LeadDisqualifyReason _leadDisqualifyReason;
		/// <summary>
		/// Disqualification reason.
		/// </summary>
		public LeadDisqualifyReason LeadDisqualifyReason {
			get {
				return _leadDisqualifyReason ??
					(_leadDisqualifyReason = LookupColumnEntities.GetEntity("LeadDisqualifyReason") as LeadDisqualifyReason);
			}
		}

		/// <exclude/>
		public Guid DepartmentId {
			get {
				return GetTypedColumnValue<Guid>("DepartmentId");
			}
			set {
				SetColumnValue("DepartmentId", value);
				_department = null;
			}
		}

		/// <exclude/>
		public string DepartmentName {
			get {
				return GetTypedColumnValue<string>("DepartmentName");
			}
			set {
				SetColumnValue("DepartmentName", value);
				if (_department != null) {
					_department.Name = value;
				}
			}
		}

		private Department _department;
		/// <summary>
		/// Department.
		/// </summary>
		public Department Department {
			get {
				return _department ??
					(_department = LookupColumnEntities.GetEntity("Department") as Department);
			}
		}

		/// <exclude/>
		public Guid DecisionRoleId {
			get {
				return GetTypedColumnValue<Guid>("DecisionRoleId");
			}
			set {
				SetColumnValue("DecisionRoleId", value);
				_decisionRole = null;
			}
		}

		/// <exclude/>
		public string DecisionRoleName {
			get {
				return GetTypedColumnValue<string>("DecisionRoleName");
			}
			set {
				SetColumnValue("DecisionRoleName", value);
				if (_decisionRole != null) {
					_decisionRole.Name = value;
				}
			}
		}

		private ContactDecisionRole _decisionRole;
		/// <summary>
		/// Role.
		/// </summary>
		public ContactDecisionRole DecisionRole {
			get {
				return _decisionRole ??
					(_decisionRole = LookupColumnEntities.GetEntity("DecisionRole") as ContactDecisionRole);
			}
		}

		/// <exclude/>
		public Guid QualifyStatusId {
			get {
				return GetTypedColumnValue<Guid>("QualifyStatusId");
			}
			set {
				SetColumnValue("QualifyStatusId", value);
				_qualifyStatus = null;
			}
		}

		/// <exclude/>
		public string QualifyStatusName {
			get {
				return GetTypedColumnValue<string>("QualifyStatusName");
			}
			set {
				SetColumnValue("QualifyStatusName", value);
				if (_qualifyStatus != null) {
					_qualifyStatus.Name = value;
				}
			}
		}

		private QualifyStatus _qualifyStatus;
		/// <summary>
		/// Lead stage.
		/// </summary>
		public QualifyStatus QualifyStatus {
			get {
				return _qualifyStatus ??
					(_qualifyStatus = LookupColumnEntities.GetEntity("QualifyStatus") as QualifyStatus);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <exclude/>
		public Guid SalesOwnerId {
			get {
				return GetTypedColumnValue<Guid>("SalesOwnerId");
			}
			set {
				SetColumnValue("SalesOwnerId", value);
				_salesOwner = null;
			}
		}

		/// <exclude/>
		public string SalesOwnerName {
			get {
				return GetTypedColumnValue<string>("SalesOwnerName");
			}
			set {
				SetColumnValue("SalesOwnerName", value);
				if (_salesOwner != null) {
					_salesOwner.Name = value;
				}
			}
		}

		private Contact _salesOwner;
		/// <summary>
		/// Opportunity owner.
		/// </summary>
		public Contact SalesOwner {
			get {
				return _salesOwner ??
					(_salesOwner = LookupColumnEntities.GetEntity("SalesOwner") as Contact);
			}
		}

		/// <summary>
		/// Budget.
		/// </summary>
		public Decimal Budget {
			get {
				return GetTypedColumnValue<Decimal>("Budget");
			}
			set {
				SetColumnValue("Budget", value);
			}
		}

		/// <summary>
		/// Decision date.
		/// </summary>
		public DateTime DecisionDate {
			get {
				return GetTypedColumnValue<DateTime>("DecisionDate");
			}
			set {
				SetColumnValue("DecisionDate", value);
			}
		}

		/// <exclude/>
		public Guid LeadSourceId {
			get {
				return GetTypedColumnValue<Guid>("LeadSourceId");
			}
			set {
				SetColumnValue("LeadSourceId", value);
				_leadSource = null;
			}
		}

		/// <exclude/>
		public string LeadSourceName {
			get {
				return GetTypedColumnValue<string>("LeadSourceName");
			}
			set {
				SetColumnValue("LeadSourceName", value);
				if (_leadSource != null) {
					_leadSource.Name = value;
				}
			}
		}

		private LeadSource _leadSource;
		/// <summary>
		/// Source.
		/// </summary>
		public LeadSource LeadSource {
			get {
				return _leadSource ??
					(_leadSource = LookupColumnEntities.GetEntity("LeadSource") as LeadSource);
			}
		}

		/// <exclude/>
		public Guid LeadMediumId {
			get {
				return GetTypedColumnValue<Guid>("LeadMediumId");
			}
			set {
				SetColumnValue("LeadMediumId", value);
				_leadMedium = null;
			}
		}

		/// <exclude/>
		public string LeadMediumName {
			get {
				return GetTypedColumnValue<string>("LeadMediumName");
			}
			set {
				SetColumnValue("LeadMediumName", value);
				if (_leadMedium != null) {
					_leadMedium.Name = value;
				}
			}
		}

		private LeadMedium _leadMedium;
		/// <summary>
		/// Channel.
		/// </summary>
		public LeadMedium LeadMedium {
			get {
				return _leadMedium ??
					(_leadMedium = LookupColumnEntities.GetEntity("LeadMedium") as LeadMedium);
			}
		}

		/// <exclude/>
		public Guid GroupId {
			get {
				return GetTypedColumnValue<Guid>("GroupId");
			}
			set {
				SetColumnValue("GroupId", value);
				_group = null;
			}
		}

		/// <exclude/>
		public string GroupName {
			get {
				return GetTypedColumnValue<string>("GroupName");
			}
			set {
				SetColumnValue("GroupName", value);
				if (_group != null) {
					_group.Name = value;
				}
			}
		}

		private SysAdminUnit _group;
		/// <summary>
		/// Assignees group.
		/// </summary>
		public SysAdminUnit Group {
			get {
				return _group ??
					(_group = LookupColumnEntities.GetEntity("Group") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public Guid LeadTypeDetailsId {
			get {
				return GetTypedColumnValue<Guid>("LeadTypeDetailsId");
			}
			set {
				SetColumnValue("LeadTypeDetailsId", value);
				_leadTypeDetails = null;
			}
		}

		/// <exclude/>
		public string LeadTypeDetailsName {
			get {
				return GetTypedColumnValue<string>("LeadTypeDetailsName");
			}
			set {
				SetColumnValue("LeadTypeDetailsName", value);
				if (_leadTypeDetails != null) {
					_leadTypeDetails.Name = value;
				}
			}
		}

		private LeadTypeDetails _leadTypeDetails;
		/// <summary>
		/// Lead type.
		/// </summary>
		public LeadTypeDetails LeadTypeDetails {
			get {
				return _leadTypeDetails ??
					(_leadTypeDetails = LookupColumnEntities.GetEntity("LeadTypeDetails") as LeadTypeDetails);
			}
		}

		/// <summary>
		/// Meeting date and time.
		/// </summary>
		public DateTime MeetingDate {
			get {
				return GetTypedColumnValue<DateTime>("MeetingDate");
			}
			set {
				SetColumnValue("MeetingDate", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_CrtLeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("Lead_CrtLead_TerrasoftInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_CrtLead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadEventsProcess

	/// <exclude/>
	public partial class Lead_CrtLeadEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntityNotes_CrtBaseEventsProcess<TEntity> where TEntity : Lead_CrtLead_Terrasoft
	{

		public Lead_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_CrtLeadEventsProcess";
			SchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a;
		public ProcessFlowElement EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a {
			get {
				return _eventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a ?? (_eventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a",
					SchemaElementUId = new Guid("06862dd3-facc-4a4d-82f3-d88d28611a9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_a8b5ea40a7b0430aa047b00a92dc9f97;
		public ProcessFlowElement StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97 {
			get {
				return _startMessage3_a8b5ea40a7b0430aa047b00a92dc9f97 ?? (_startMessage3_a8b5ea40a7b0430aa047b00a92dc9f97 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97",
					SchemaElementUId = new Guid("a8b5ea40-a7b0-430a-a047-b00a92dc9f97"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a;
		public ProcessScriptTask ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a {
			get {
				return _scriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a ?? (_scriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a",
					SchemaElementUId = new Guid("6f8b145d-5aa3-4e2b-bbf3-5422dd6b6b9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9aExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a };
			FlowElements[StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97 };
			FlowElements[ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a":
						break;
					case "StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97":
						e.Context.QueueTasks.Enqueue("ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a");
						break;
					case "ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_06862dd3facc4a4d82f3d88d28611a9a":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97";
					result = StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97.Execute(context);
					break;
				case "ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a";
					result = ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9a.Execute(context, ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9aExecute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_6f8b145d5aa34e2bbbf35422dd6b6b9aExecute(ProcessExecutingContext context) {
			LeadInserting();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Lead_CrtLead_TerrasoftInserting":
							if (ActivatedEventElements.Contains("StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97")) {
							context.QueueTasks.Enqueue("StartMessage3_a8b5ea40a7b0430aa047b00a92dc9f97");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_CrtLeadEventsProcess

	/// <exclude/>
	public class Lead_CrtLeadEventsProcess : Lead_CrtLeadEventsProcess<Lead_CrtLead_Terrasoft>
	{

		public Lead_CrtLeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

