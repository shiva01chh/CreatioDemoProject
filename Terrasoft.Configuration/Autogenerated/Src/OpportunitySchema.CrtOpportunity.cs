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

	#region Class: Opportunity_CrtOpportunity_TerrasoftSchema

	/// <exclude/>
	public class Opportunity_CrtOpportunity_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public Opportunity_CrtOpportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Opportunity_CrtOpportunity_TerrasoftSchema(Opportunity_CrtOpportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Opportunity_CrtOpportunity_TerrasoftSchema(Opportunity_CrtOpportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIDX_OpportunityTitleIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("538d5288-c406-4b69-8f00-7b42c02cbdf3");
			index.Name = "IDX_OpportunityTitle";
			index.CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			index.CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13");
			EntitySchemaIndexColumn titleIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7a45b5d6-7ce5-4417-8995-a0f6d21a272b"),
				ColumnUId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(titleIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			RealUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			Name = "Opportunity_CrtOpportunity_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
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
			PrimaryDisplayColumn = CreateTitleColumn();
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
			if (Columns.FindByUId(new Guid("2b2e93bb-c5ac-4478-9e31-306c5bd5ceeb")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("797ac352-4979-4d28-906f-82feb6dbc9dc")) == null) {
				Columns.Add(CreateStageColumn());
			}
			if (Columns.FindByUId(new Guid("c8f5d6d7-aa99-4295-ade0-4ff6e840655f")) == null) {
				Columns.Add(CreateDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("d979bca9-13c3-463b-b279-641c0c51f9df")) == null) {
				Columns.Add(CreateCloseReasonColumn());
			}
			if (Columns.FindByUId(new Guid("975de813-489f-495b-98ab-e56a8a527e77")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("fae41c1b-a153-43df-852a-17ab3e608c18")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("c4eab4ef-2c91-43b5-b2a1-df5e60f6c3cd")) == null) {
				Columns.Add(CreateMoodColumn());
			}
			if (Columns.FindByUId(new Guid("3aab3a22-ded6-41a6-98bb-4bc7ca20bb06")) == null) {
				Columns.Add(CreateIsPrimaryColumn());
			}
			if (Columns.FindByUId(new Guid("75ad358c-8d9c-4bbb-83d5-2d9f60d3b7c3")) == null) {
				Columns.Add(CreatePartnerColumn());
			}
			if (Columns.FindByUId(new Guid("4348809e-6f05-426c-8802-958ffe90b176")) == null) {
				Columns.Add(CreateBudgetColumn());
			}
			if (Columns.FindByUId(new Guid("bc62f730-7e4a-4578-953c-1cd9ac58a2b2")) == null) {
				Columns.Add(CreateProbabilityColumn());
			}
			if (Columns.FindByUId(new Guid("63c0fc1f-ac41-4497-96be-c27201994072")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("6c76d697-8138-47fc-897c-1f3820c45893")) == null) {
				Columns.Add(CreateSourceColumn());
			}
			if (Columns.FindByUId(new Guid("15f0f091-e66f-42db-807b-f4c2ad6337b6")) == null) {
				Columns.Add(CreateResponsibleDepartmentColumn());
			}
			if (Columns.FindByUId(new Guid("19429c25-e5dc-4a77-ab74-69bbec821ce4")) == null) {
				Columns.Add(CreateWeaknessesColumn());
			}
			if (Columns.FindByUId(new Guid("9295050c-1727-416a-949d-4684e2b61e3b")) == null) {
				Columns.Add(CreateStrengthColumn());
			}
			if (Columns.FindByUId(new Guid("d1cf610a-dc34-447b-b637-9970dc4f1b7e")) == null) {
				Columns.Add(CreateTacticColumn());
			}
			if (Columns.FindByUId(new Guid("7d2e418f-2cac-4b0c-823c-9f431027ce56")) == null) {
				Columns.Add(CreateCheckDateColumn());
			}
			if (Columns.FindByUId(new Guid("65715559-fa3f-4781-be93-5f3920b3e8f4")) == null) {
				Columns.Add(CreateProcessIdColumn());
			}
			if (Columns.FindByUId(new Guid("f460aa34-e072-4804-aa46-f886e60a3852")) == null) {
				Columns.Add(CreateWinnerColumn());
			}
			if (Columns.FindByUId(new Guid("64a05bfa-350d-4dbf-bfd8-fb579a74f39e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("cf5dc330-48e7-48ac-8b86-06ffb1ae0391")) == null) {
				Columns.Add(CreateCompletenessColumn());
			}
			if (Columns.FindByUId(new Guid("f22a9cf5-213a-427f-aed7-ef864ffff2dd")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("e07a14cb-fda3-753a-605e-0ef09c1af240")) == null) {
				Columns.Add(CreateMoodValueColumn());
			}
			if (Columns.FindByUId(new Guid("9ecd00e7-8bc5-4f52-b361-477831d42559")) == null) {
				Columns.Add(CreateByProcessColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("790563cf-fd14-4d5d-a5fd-b6eddb10d6d3"),
				Name = @"Title",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2b2e93bb-c5ac-4478-9e31-306c5bd5ceeb"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("85fe0df7-a970-4717-8f7b-8caba783906b"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateStageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("797ac352-4979-4d28-906f-82feb6dbc9dc"),
				Name = @"Stage",
				ReferenceSchemaUId = new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"c2067b11-0ee0-df11-971b-001d60e938c6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c8f5d6d7-aa99-4295-ade0-4ff6e840655f"),
				Name = @"DueDate",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCloseReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d979bca9-13c3-463b-b279-641c0c51f9df"),
				Name = @"CloseReason",
				ReferenceSchemaUId = new Guid("27ba43e5-6280-4458-855d-3c7118f678d7"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("684553a7-a59d-46fa-af4b-fc76e9fe3694"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("975de813-489f-495b-98ab-e56a8a527e77"),
				Name = @"Notes",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4b95e3ff-fd52-4ae1-b0a5-2c5103ff15a7"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fae41c1b-a153-43df-852a-17ab3e608c18"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("98f95046-8a53-4d6d-be56-91d68e624e6a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateMoodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c4eab4ef-2c91-43b5-b2a1-df5e60f6c3cd"),
				Name = @"Mood",
				ReferenceSchemaUId = new Guid("c8b8800f-c6ca-4b8b-962b-e79307b5d95e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				IsSimpleLookup = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"a9f89fe0-dd26-4b96-8736-471d72c428d5"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsPrimaryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("3aab3a22-ded6-41a6-98bb-4bc7ca20bb06"),
				Name = @"IsPrimary",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePartnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("75ad358c-8d9c-4bbb-83d5-2d9f60d3b7c3"),
				Name = @"Partner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateBudgetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("4348809e-6f05-426c-8802-958ffe90b176"),
				Name = @"Budget",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateProbabilityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("bc62f730-7e4a-4578-953c-1cd9ac58a2b2"),
				Name = @"Probability",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("63c0fc1f-ac41-4497-96be-c27201994072"),
				Name = @"Amount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c76d697-8138-47fc-897c-1f3820c45893"),
				Name = @"Source",
				ReferenceSchemaUId = new Guid("6f66df29-03a2-41b3-9cde-021eeeedfcb0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateResponsibleDepartmentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("15f0f091-e66f-42db-807b-f4c2ad6337b6"),
				Name = @"ResponsibleDepartment",
				ReferenceSchemaUId = new Guid("5d8456b4-15e0-4de5-b0e5-afb10f6795c0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateWeaknessesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("19429c25-e5dc-4a77-ab74-69bbec821ce4"),
				Name = @"Weaknesses",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateStrengthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("9295050c-1727-416a-949d-4684e2b61e3b"),
				Name = @"Strength",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateTacticColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d1cf610a-dc34-447b-b637-9970dc4f1b7e"),
				Name = @"Tactic",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateCheckDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("7d2e418f-2cac-4b0c-823c-9f431027ce56"),
				Name = @"CheckDate",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5d4440f3-755f-4128-9701-bb9585b17c33")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("65715559-fa3f-4781-be93-5f3920b3e8f4"),
				Name = @"ProcessId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("8faebbb4-6032-45a8-ace5-f8b3ded3b01d")
			};
		}

		protected virtual EntitySchemaColumn CreateWinnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f460aa34-e072-4804-aa46-f886e60a3852"),
				Name = @"Winner",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("00444c93-d7ec-4107-babc-79df871f5d21")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("64a05bfa-350d-4dbf-bfd8-fb579a74f39e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("847c168f-46d2-4935-ba54-2d351061d222")
			};
		}

		protected virtual EntitySchemaColumn CreateCompletenessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("cf5dc330-48e7-48ac-8b86-06ffb1ae0391"),
				Name = @"Completeness",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("2e81487b-ecb4-48b5-b3e6-cfc1669b881f")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f22a9cf5-213a-427f-aed7-ef864ffff2dd"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("331ebe45-2152-452a-9e4b-d72e7bcbf340"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateMoodValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e07a14cb-fda3-753a-605e-0ef09c1af240"),
				Name = @"MoodValue",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"45"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateByProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9ecd00e7-8bc5-4f52-b361-477831d42559"),
				Name = @"ByProcess",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				ModifiedInSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				CreatedInPackageId = new Guid("5ef32b22-5119-483b-953d-678c3fffad13")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIDX_OpportunityTitleIndex());
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Opportunity_CrtOpportunity_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Opportunity_CrtOpportunityEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Opportunity_CrtOpportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Opportunity_CrtOpportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtOpportunity_Terrasoft

	/// <summary>
	/// Opportunity.
	/// </summary>
	public class Opportunity_CrtOpportunity_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Opportunity_CrtOpportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Opportunity_CrtOpportunity_Terrasoft";
		}

		public Opportunity_CrtOpportunity_Terrasoft(Opportunity_CrtOpportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private OpportunityType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public OpportunityType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as OpportunityType);
			}
		}

		/// <exclude/>
		public Guid StageId {
			get {
				return GetTypedColumnValue<Guid>("StageId");
			}
			set {
				SetColumnValue("StageId", value);
				_stage = null;
			}
		}

		/// <exclude/>
		public string StageName {
			get {
				return GetTypedColumnValue<string>("StageName");
			}
			set {
				SetColumnValue("StageName", value);
				if (_stage != null) {
					_stage.Name = value;
				}
			}
		}

		private OpportunityStage _stage;
		/// <summary>
		/// Stage.
		/// </summary>
		public OpportunityStage Stage {
			get {
				return _stage ??
					(_stage = LookupColumnEntities.GetEntity("Stage") as OpportunityStage);
			}
		}

		/// <summary>
		/// Closed on.
		/// </summary>
		public DateTime DueDate {
			get {
				return GetTypedColumnValue<DateTime>("DueDate");
			}
			set {
				SetColumnValue("DueDate", value);
			}
		}

		/// <exclude/>
		public Guid CloseReasonId {
			get {
				return GetTypedColumnValue<Guid>("CloseReasonId");
			}
			set {
				SetColumnValue("CloseReasonId", value);
				_closeReason = null;
			}
		}

		/// <exclude/>
		public string CloseReasonName {
			get {
				return GetTypedColumnValue<string>("CloseReasonName");
			}
			set {
				SetColumnValue("CloseReasonName", value);
				if (_closeReason != null) {
					_closeReason.Name = value;
				}
			}
		}

		private OpportunityCloseReason _closeReason;
		/// <summary>
		/// Reason for closing.
		/// </summary>
		public OpportunityCloseReason CloseReason {
			get {
				return _closeReason ??
					(_closeReason = LookupColumnEntities.GetEntity("CloseReason") as OpportunityCloseReason);
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

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private OpportunityCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public OpportunityCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as OpportunityCategory);
			}
		}

		/// <exclude/>
		public Guid MoodId {
			get {
				return GetTypedColumnValue<Guid>("MoodId");
			}
			set {
				SetColumnValue("MoodId", value);
				_mood = null;
			}
		}

		/// <exclude/>
		public string MoodName {
			get {
				return GetTypedColumnValue<string>("MoodName");
			}
			set {
				SetColumnValue("MoodName", value);
				if (_mood != null) {
					_mood.Name = value;
				}
			}
		}

		private OpportunityMood _mood;
		/// <summary>
		/// Mood.
		/// </summary>
		public OpportunityMood Mood {
			get {
				return _mood ??
					(_mood = LookupColumnEntities.GetEntity("Mood") as OpportunityMood);
			}
		}

		/// <summary>
		/// New customer.
		/// </summary>
		public bool IsPrimary {
			get {
				return GetTypedColumnValue<bool>("IsPrimary");
			}
			set {
				SetColumnValue("IsPrimary", value);
			}
		}

		/// <exclude/>
		public Guid PartnerId {
			get {
				return GetTypedColumnValue<Guid>("PartnerId");
			}
			set {
				SetColumnValue("PartnerId", value);
				_partner = null;
			}
		}

		/// <exclude/>
		public string PartnerName {
			get {
				return GetTypedColumnValue<string>("PartnerName");
			}
			set {
				SetColumnValue("PartnerName", value);
				if (_partner != null) {
					_partner.Name = value;
				}
			}
		}

		private Account _partner;
		/// <summary>
		/// Partner.
		/// </summary>
		public Account Partner {
			get {
				return _partner ??
					(_partner = LookupColumnEntities.GetEntity("Partner") as Account);
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
		/// Probability, %.
		/// </summary>
		public int Probability {
			get {
				return GetTypedColumnValue<int>("Probability");
			}
			set {
				SetColumnValue("Probability", value);
			}
		}

		/// <summary>
		/// Opportunity amount.
		/// </summary>
		public Decimal Amount {
			get {
				return GetTypedColumnValue<Decimal>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <exclude/>
		public Guid SourceId {
			get {
				return GetTypedColumnValue<Guid>("SourceId");
			}
			set {
				SetColumnValue("SourceId", value);
				_source = null;
			}
		}

		/// <exclude/>
		public string SourceName {
			get {
				return GetTypedColumnValue<string>("SourceName");
			}
			set {
				SetColumnValue("SourceName", value);
				if (_source != null) {
					_source.Name = value;
				}
			}
		}

		private OpportunitySource _source;
		/// <summary>
		/// Source.
		/// </summary>
		public OpportunitySource Source {
			get {
				return _source ??
					(_source = LookupColumnEntities.GetEntity("Source") as OpportunitySource);
			}
		}

		/// <exclude/>
		public Guid ResponsibleDepartmentId {
			get {
				return GetTypedColumnValue<Guid>("ResponsibleDepartmentId");
			}
			set {
				SetColumnValue("ResponsibleDepartmentId", value);
				_responsibleDepartment = null;
			}
		}

		/// <exclude/>
		public string ResponsibleDepartmentName {
			get {
				return GetTypedColumnValue<string>("ResponsibleDepartmentName");
			}
			set {
				SetColumnValue("ResponsibleDepartmentName", value);
				if (_responsibleDepartment != null) {
					_responsibleDepartment.Name = value;
				}
			}
		}

		private OpportunityDepartment _responsibleDepartment;
		/// <summary>
		/// Division.
		/// </summary>
		public OpportunityDepartment ResponsibleDepartment {
			get {
				return _responsibleDepartment ??
					(_responsibleDepartment = LookupColumnEntities.GetEntity("ResponsibleDepartment") as OpportunityDepartment);
			}
		}

		/// <summary>
		/// Our weaknesses.
		/// </summary>
		public string Weaknesses {
			get {
				return GetTypedColumnValue<string>("Weaknesses");
			}
			set {
				SetColumnValue("Weaknesses", value);
			}
		}

		/// <summary>
		/// Our strengths.
		/// </summary>
		public string Strength {
			get {
				return GetTypedColumnValue<string>("Strength");
			}
			set {
				SetColumnValue("Strength", value);
			}
		}

		/// <summary>
		/// Sales tactics.
		/// </summary>
		public string Tactic {
			get {
				return GetTypedColumnValue<string>("Tactic");
			}
			set {
				SetColumnValue("Tactic", value);
			}
		}

		/// <summary>
		/// Verified on.
		/// </summary>
		public DateTime CheckDate {
			get {
				return GetTypedColumnValue<DateTime>("CheckDate");
			}
			set {
				SetColumnValue("CheckDate", value);
			}
		}

		/// <summary>
		/// Process Id.
		/// </summary>
		public Guid ProcessId {
			get {
				return GetTypedColumnValue<Guid>("ProcessId");
			}
			set {
				SetColumnValue("ProcessId", value);
			}
		}

		/// <exclude/>
		public Guid WinnerId {
			get {
				return GetTypedColumnValue<Guid>("WinnerId");
			}
			set {
				SetColumnValue("WinnerId", value);
				_winner = null;
			}
		}

		/// <exclude/>
		public string WinnerName {
			get {
				return GetTypedColumnValue<string>("WinnerName");
			}
			set {
				SetColumnValue("WinnerName", value);
				if (_winner != null) {
					_winner.Name = value;
				}
			}
		}

		private Account _winner;
		/// <summary>
		/// Winner.
		/// </summary>
		public Account Winner {
			get {
				return _winner ??
					(_winner = LookupColumnEntities.GetEntity("Winner") as Account);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Completeness.
		/// </summary>
		public int Completeness {
			get {
				return GetTypedColumnValue<int>("Completeness");
			}
			set {
				SetColumnValue("Completeness", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Manager's mood value.
		/// </summary>
		public int MoodValue {
			get {
				return GetTypedColumnValue<int>("MoodValue");
			}
			set {
				SetColumnValue("MoodValue", value);
			}
		}

		/// <summary>
		/// By process.
		/// </summary>
		public bool ByProcess {
			get {
				return GetTypedColumnValue<bool>("ByProcess");
			}
			set {
				SetColumnValue("ByProcess", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Opportunity_CrtOpportunityEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftDeleting", e);
			Inserted += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Opportunity_CrtOpportunity_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Opportunity_CrtOpportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Opportunity_CrtOpportunityEventsProcess

	/// <exclude/>
	public partial class Opportunity_CrtOpportunityEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Opportunity_CrtOpportunity_Terrasoft
	{

		public Opportunity_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Opportunity_CrtOpportunityEventsProcess";
			SchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid StageOldValue {
			get;
			set;
		}

		public virtual bool IsStageChanged {
			get;
			set;
		}

		public virtual bool NeedSynchronizeCompetitor {
			get;
			set;
		}

		public virtual bool IsOwnerChanged {
			get;
			set;
		}

		public virtual Guid CampaignId {
			get;
			set;
		}

		public virtual Guid CampaignOldValue {
			get;
			set;
		}

		public virtual bool IsNewStageEnd {
			get;
			set;
		}

		public virtual Guid OldOwnerId {
			get;
			set;
		}

		public virtual bool IsTacticChanged {
			get;
			set;
		}

		public virtual bool CanGenerateAnniversaryReminding {
			get;
			set;
		}

		public virtual Object EntityChangedColumns {
			get;
			set;
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

	#region Class: Opportunity_CrtOpportunityEventsProcess

	/// <exclude/>
	public class Opportunity_CrtOpportunityEventsProcess : Opportunity_CrtOpportunityEventsProcess<Opportunity_CrtOpportunity_Terrasoft>
	{

		public Opportunity_CrtOpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

