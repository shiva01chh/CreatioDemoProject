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

	#region Class: Lead_Lead_TerrasoftSchema

	/// <exclude/>
	public class Lead_Lead_TerrasoftSchema : Terrasoft.Configuration.Lead_CrtLead_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_Lead_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_Lead_TerrasoftSchema(Lead_Lead_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_Lead_TerrasoftSchema(Lead_Lead_TerrasoftSchema source)
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
			RealUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10");
			Name = "Lead_Lead_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a3200694-9a9a-42a6-824f-870d5b03e255")) == null) {
				Columns.Add(CreateAccountCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("6a7045c5-ab82-4bf9-a929-9ac065c69343")) == null) {
				Columns.Add(CreateAccountOwnershipColumn());
			}
			if (Columns.FindByUId(new Guid("76b846c6-6af5-40c2-9576-5c5dbc0d6200")) == null) {
				Columns.Add(CreateAddressColumn());
			}
			if (Columns.FindByUId(new Guid("66852a75-b22e-4390-a8df-49814cdb0131")) == null) {
				Columns.Add(CreateAddressTypeColumn());
			}
			if (Columns.FindByUId(new Guid("718683e1-7d00-48d6-ad3f-c882ee2ce79f")) == null) {
				Columns.Add(CreateAnnualRevenueColumn());
			}
			if (Columns.FindByUId(new Guid("ee7282d6-232b-449f-bf7b-1bd2e1f36a58")) == null) {
				Columns.Add(CreateDearColumn());
			}
			if (Columns.FindByUId(new Guid("89a00df1-3d34-4a63-b34c-2978dcf7e0ae")) == null) {
				Columns.Add(CreateDoNotUseEmailColumn());
			}
			if (Columns.FindByUId(new Guid("1e8e0db1-0507-47eb-97c7-ceb789403aad")) == null) {
				Columns.Add(CreateDoNotUseFaxColumn());
			}
			if (Columns.FindByUId(new Guid("54067cf3-13f5-42d1-8af9-90c6bddc7773")) == null) {
				Columns.Add(CreateDoNotUseMailColumn());
			}
			if (Columns.FindByUId(new Guid("7c2e8e89-aba1-46b1-b386-83480927dd78")) == null) {
				Columns.Add(CreateDoNotUsePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("48a0c461-b224-4faf-8ede-ce36d53af43e")) == null) {
				Columns.Add(CreateDoNotUseSMSColumn());
			}
			if (Columns.FindByUId(new Guid("49508aa7-fa69-4ce3-aa4d-1eeb2c9d73a5")) == null) {
				Columns.Add(CreateEmployeesNumberColumn());
			}
			if (Columns.FindByUId(new Guid("75485248-dedd-4fa5-ace4-787e2d097627")) == null) {
				Columns.Add(CreateFaxColumn());
			}
			if (Columns.FindByUId(new Guid("4d0cc359-3e5f-481c-b8aa-117ca6b24c06")) == null) {
				Columns.Add(CreateFullJobTitleColumn());
			}
			if (Columns.FindByUId(new Guid("257a1321-f45d-4868-bf44-e9f2297661d3")) == null) {
				Columns.Add(CreateGenderColumn());
			}
			if (Columns.FindByUId(new Guid("2edaf1d4-f64e-4351-aa6b-c81a7ebfc108")) == null) {
				Columns.Add(CreateIndustryColumn());
			}
			if (Columns.FindByUId(new Guid("243f2974-3fa5-4b78-93e9-7fc8c1bc2749")) == null) {
				Columns.Add(CreateInformationSourceColumn());
			}
			if (Columns.FindByUId(new Guid("aa8c19b4-a8fb-4284-b969-8f15630a25ec")) == null) {
				Columns.Add(CreateJobColumn());
			}
			if (Columns.FindByUId(new Guid("9b279c76-0213-4f51-acd6-3936e1069bd4")) == null) {
				Columns.Add(CreateLeadTypeStatusColumn());
			}
			if (Columns.FindByUId(new Guid("016f2995-d657-4704-a9a0-cd4deeca83b9")) == null) {
				Columns.Add(CreateNextActualizationDateColumn());
			}
			if (Columns.FindByUId(new Guid("9fb3dc53-b29b-46e2-ba98-ae587bf61fb2")) == null) {
				Columns.Add(CreateQualificationProcessIdColumn());
			}
			if (Columns.FindByUId(new Guid("dce30e38-3b37-40b3-b9f5-08b790d93420")) == null) {
				Columns.Add(CreateRegionColumn());
			}
			if (Columns.FindByUId(new Guid("087fc72c-7115-4275-965c-c100b7eabba1")) == null) {
				Columns.Add(CreateRegisterMethodColumn());
			}
			if (Columns.FindByUId(new Guid("279fe3e0-79c0-4f80-ba0f-f56df245f49c")) == null) {
				Columns.Add(CreateRemindToOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("11b61c8f-5920-4f71-8df0-d68b54efc8db")) == null) {
				Columns.Add(CreateShowDistributionPageColumn());
			}
			if (Columns.FindByUId(new Guid("afdaca14-10c0-4767-b1f4-ed06946d37eb")) == null) {
				Columns.Add(CreateTitleColumn());
			}
			if (Columns.FindByUId(new Guid("e1f35c38-67f2-4da3-a3f6-d4294aada246")) == null) {
				Columns.Add(CreateZipColumn());
			}
			if (Columns.FindByUId(new Guid("85e56029-bf1f-46b8-9293-a6395e7f00f9")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("865eb25f-3941-423f-a4c0-c7834368a7af")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("4258b690-fe71-4b7a-8278-f0a7b9dd4780")) == null) {
				Columns.Add(CreateCityColumn());
			}
			if (Columns.FindByUId(new Guid("94a3a853-08cb-485f-89f4-182878a5aaeb")) == null) {
				Columns.Add(CreateBusinesPhoneColumn());
			}
			if (Columns.FindByUId(new Guid("d79b4d09-4791-4993-952b-e097088b55c6")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("fee32d81-7e24-4a34-91c7-3083e4d4938f")) == null) {
				Columns.Add(CreateEmailColumn());
			}
			if (Columns.FindByUId(new Guid("40fef1d9-f9d9-4246-a90f-389e256aacd4")) == null) {
				Columns.Add(CreateMobilePhoneColumn());
			}
			if (Columns.FindByUId(new Guid("e753916c-14d1-4213-bb77-9334d5e6bf7f")) == null) {
				Columns.Add(CreateWebsiteColumn());
			}
		}

		protected override EntitySchemaColumn CreateQualifyStatusColumn() {
			EntitySchemaColumn column = base.CreateQualifyStatusColumn();
			column.ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10");
			return column;
		}

		protected virtual EntitySchemaColumn CreateAccountCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3200694-9a9a-42a6-824f-870d5b03e255"),
				Name = @"AccountCategory",
				ReferenceSchemaUId = new Guid("a6ff9860-2b37-4da2-9537-5cd6cedf9665"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountOwnershipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6a7045c5-ab82-4bf9-a929-9ac065c69343"),
				Name = @"AccountOwnership",
				ReferenceSchemaUId = new Guid("ce243c2c-b7d3-4dc4-b474-ab24c677801b"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("76b846c6-6af5-40c2-9576-5c5dbc0d6200"),
				Name = @"Address",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateAddressTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66852a75-b22e-4390-a8df-49814cdb0131"),
				Name = @"AddressType",
				ReferenceSchemaUId = new Guid("50837bfc-43ff-466b-94bb-de0847eecd1b"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateAnnualRevenueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("718683e1-7d00-48d6-ad3f-c882ee2ce79f"),
				Name = @"AnnualRevenue",
				ReferenceSchemaUId = new Guid("24d201f8-5f03-47f3-9e7b-1c967c11d7b9"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateDearColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ee7282d6-232b-449f-bf7b-1bd2e1f36a58"),
				Name = @"Dear",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("89a00df1-3d34-4a63-b34c-2978dcf7e0ae"),
				Name = @"DoNotUseEmail",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseFaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1e8e0db1-0507-47eb-97c7-ceb789403aad"),
				Name = @"DoNotUseFax",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseMailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("54067cf3-13f5-42d1-8af9-90c6bddc7773"),
				Name = @"DoNotUseMail",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUsePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7c2e8e89-aba1-46b1-b386-83480927dd78"),
				Name = @"DoNotUsePhone",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseSMSColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("48a0c461-b224-4faf-8ede-ce36d53af43e"),
				Name = @"DoNotUseSMS",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateEmployeesNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("49508aa7-fa69-4ce3-aa4d-1eeb2c9d73a5"),
				Name = @"EmployeesNumber",
				ReferenceSchemaUId = new Guid("ccf7d7bf-b4b7-4eb3-a191-3f47d6c4ee8d"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateFaxColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("75485248-dedd-4fa5-ace4-787e2d097627"),
				Name = @"Fax",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateFullJobTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4d0cc359-3e5f-481c-b8aa-117ca6b24c06"),
				Name = @"FullJobTitle",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateGenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("257a1321-f45d-4868-bf44-e9f2297661d3"),
				Name = @"Gender",
				ReferenceSchemaUId = new Guid("0bc5d826-8e8f-48cd-b087-30b33d133120"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateIndustryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2edaf1d4-f64e-4351-aa6b-c81a7ebfc108"),
				Name = @"Industry",
				ReferenceSchemaUId = new Guid("95de3d3b-b909-40d9-a3fa-e80d38ec208e"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateInformationSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("243f2974-3fa5-4b78-93e9-7fc8c1bc2749"),
				Name = @"InformationSource",
				ReferenceSchemaUId = new Guid("d3e76dcb-eb9f-494b-b5d9-0643e5418beb"),
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateJobColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("aa8c19b4-a8fb-4284-b969-8f15630a25ec"),
				Name = @"Job",
				ReferenceSchemaUId = new Guid("c82ab6f0-0e36-4376-9ab3-c583d714b7b6"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateLeadTypeStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9b279c76-0213-4f51-acd6-3936e1069bd4"),
				Name = @"LeadTypeStatus",
				ReferenceSchemaUId = new Guid("2df1cc86-627c-4d7c-ad1f-0de8eebab40c"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"5b3d1046-fc16-45c8-a5a1-298dfc857546"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNextActualizationDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("016f2995-d657-4704-a9a0-cd4deeca83b9"),
				Name = @"NextActualizationDate",
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateQualificationProcessIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9fb3dc53-b29b-46e2-ba98-ae587bf61fb2"),
				Name = @"QualificationProcessId",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dce30e38-3b37-40b3-b9f5-08b790d93420"),
				Name = @"Region",
				ReferenceSchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateRegisterMethodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("087fc72c-7115-4275-965c-c100b7eabba1"),
				Name = @"RegisterMethod",
				ReferenceSchemaUId = new Guid("5e1ccd88-7f69-456e-af1a-915ffacb033d"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"240ab9c6-4d7c-4688-b380-af44dd147d7a"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRemindToOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("279fe3e0-79c0-4f80-ba0f-f56df245f49c"),
				Name = @"RemindToOwner",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateShowDistributionPageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("11b61c8f-5920-4f71-8df0-d68b54efc8db"),
				Name = @"ShowDistributionPage",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("afdaca14-10c0-4767-b1f4-ed06946d37eb"),
				Name = @"Title",
				ReferenceSchemaUId = new Guid("e3c92284-1491-4438-986f-4bf5dbe4b847"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateZipColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("e1f35c38-67f2-4da3-a3f6-d4294aada246"),
				Name = @"Zip",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("85e56029-bf1f-46b8-9293-a6395e7f00f9"),
				Name = @"Account",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("865eb25f-3941-423f-a4c0-c7834368a7af"),
				Name = @"Contact",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4258b690-fe71-4b7a-8278-f0a7b9dd4780"),
				Name = @"City",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateBusinesPhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("94a3a853-08cb-485f-89f4-182878a5aaeb"),
				Name = @"BusinesPhone",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d79b4d09-4791-4993-952b-e097088b55c6"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fee32d81-7e24-4a34-91c7-3083e4d4938f"),
				Name = @"Email",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateMobilePhoneColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("40fef1d9-f9d9-4246-a90f-389e256aacd4"),
				Name = @"MobilePhone",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				IsSensitiveData = true
			};
		}

		protected virtual EntitySchemaColumn CreateWebsiteColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e753916c-14d1-4213-bb77-9334d5e6bf7f"),
				Name = @"Website",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				ModifiedInSchemaUId = new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06")
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
			return new Lead_Lead_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_LeadEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_Lead_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_Lead_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_Lead_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_Lead_Terrasoft : Terrasoft.Configuration.Lead_CrtLead_Terrasoft
	{

		#region Constructors: Public

		public Lead_Lead_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_Lead_Terrasoft";
		}

		public Lead_Lead_Terrasoft(Lead_Lead_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid AccountCategoryId {
			get {
				return GetTypedColumnValue<Guid>("AccountCategoryId");
			}
			set {
				SetColumnValue("AccountCategoryId", value);
				_accountCategory = null;
			}
		}

		/// <exclude/>
		public string AccountCategoryName {
			get {
				return GetTypedColumnValue<string>("AccountCategoryName");
			}
			set {
				SetColumnValue("AccountCategoryName", value);
				if (_accountCategory != null) {
					_accountCategory.Name = value;
				}
			}
		}

		private AccountCategory _accountCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public AccountCategory AccountCategory {
			get {
				return _accountCategory ??
					(_accountCategory = LookupColumnEntities.GetEntity("AccountCategory") as AccountCategory);
			}
		}

		/// <exclude/>
		public Guid AccountOwnershipId {
			get {
				return GetTypedColumnValue<Guid>("AccountOwnershipId");
			}
			set {
				SetColumnValue("AccountOwnershipId", value);
				_accountOwnership = null;
			}
		}

		/// <exclude/>
		public string AccountOwnershipName {
			get {
				return GetTypedColumnValue<string>("AccountOwnershipName");
			}
			set {
				SetColumnValue("AccountOwnershipName", value);
				if (_accountOwnership != null) {
					_accountOwnership.Name = value;
				}
			}
		}

		private AccountOwnership _accountOwnership;
		/// <summary>
		/// Business entity.
		/// </summary>
		public AccountOwnership AccountOwnership {
			get {
				return _accountOwnership ??
					(_accountOwnership = LookupColumnEntities.GetEntity("AccountOwnership") as AccountOwnership);
			}
		}

		/// <summary>
		/// Address.
		/// </summary>
		public string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		/// <exclude/>
		public Guid AddressTypeId {
			get {
				return GetTypedColumnValue<Guid>("AddressTypeId");
			}
			set {
				SetColumnValue("AddressTypeId", value);
				_addressType = null;
			}
		}

		/// <exclude/>
		public string AddressTypeName {
			get {
				return GetTypedColumnValue<string>("AddressTypeName");
			}
			set {
				SetColumnValue("AddressTypeName", value);
				if (_addressType != null) {
					_addressType.Name = value;
				}
			}
		}

		private AddressType _addressType;
		/// <summary>
		/// Address type.
		/// </summary>
		public AddressType AddressType {
			get {
				return _addressType ??
					(_addressType = LookupColumnEntities.GetEntity("AddressType") as AddressType);
			}
		}

		/// <exclude/>
		public Guid AnnualRevenueId {
			get {
				return GetTypedColumnValue<Guid>("AnnualRevenueId");
			}
			set {
				SetColumnValue("AnnualRevenueId", value);
				_annualRevenue = null;
			}
		}

		/// <exclude/>
		public string AnnualRevenueName {
			get {
				return GetTypedColumnValue<string>("AnnualRevenueName");
			}
			set {
				SetColumnValue("AnnualRevenueName", value);
				if (_annualRevenue != null) {
					_annualRevenue.Name = value;
				}
			}
		}

		private AccountAnnualRevenue _annualRevenue;
		/// <summary>
		/// Annual revenue.
		/// </summary>
		public AccountAnnualRevenue AnnualRevenue {
			get {
				return _annualRevenue ??
					(_annualRevenue = LookupColumnEntities.GetEntity("AnnualRevenue") as AccountAnnualRevenue);
			}
		}

		/// <summary>
		/// Recipient's name.
		/// </summary>
		public string Dear {
			get {
				return GetTypedColumnValue<string>("Dear");
			}
			set {
				SetColumnValue("Dear", value);
			}
		}

		/// <summary>
		/// Do not use email.
		/// </summary>
		public bool DoNotUseEmail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseEmail");
			}
			set {
				SetColumnValue("DoNotUseEmail", value);
			}
		}

		/// <summary>
		/// Do not use fax.
		/// </summary>
		public bool DoNotUseFax {
			get {
				return GetTypedColumnValue<bool>("DoNotUseFax");
			}
			set {
				SetColumnValue("DoNotUseFax", value);
			}
		}

		/// <summary>
		/// Do not use mail.
		/// </summary>
		public bool DoNotUseMail {
			get {
				return GetTypedColumnValue<bool>("DoNotUseMail");
			}
			set {
				SetColumnValue("DoNotUseMail", value);
			}
		}

		/// <summary>
		/// Do not use phone.
		/// </summary>
		public bool DoNotUsePhone {
			get {
				return GetTypedColumnValue<bool>("DoNotUsePhone");
			}
			set {
				SetColumnValue("DoNotUsePhone", value);
			}
		}

		/// <summary>
		/// Do not use SMS.
		/// </summary>
		public bool DoNotUseSMS {
			get {
				return GetTypedColumnValue<bool>("DoNotUseSMS");
			}
			set {
				SetColumnValue("DoNotUseSMS", value);
			}
		}

		/// <exclude/>
		public Guid EmployeesNumberId {
			get {
				return GetTypedColumnValue<Guid>("EmployeesNumberId");
			}
			set {
				SetColumnValue("EmployeesNumberId", value);
				_employeesNumber = null;
			}
		}

		/// <exclude/>
		public string EmployeesNumberName {
			get {
				return GetTypedColumnValue<string>("EmployeesNumberName");
			}
			set {
				SetColumnValue("EmployeesNumberName", value);
				if (_employeesNumber != null) {
					_employeesNumber.Name = value;
				}
			}
		}

		private AccountEmployeesNumber _employeesNumber;
		/// <summary>
		/// No. of employees.
		/// </summary>
		public AccountEmployeesNumber EmployeesNumber {
			get {
				return _employeesNumber ??
					(_employeesNumber = LookupColumnEntities.GetEntity("EmployeesNumber") as AccountEmployeesNumber);
			}
		}

		/// <summary>
		/// Fax.
		/// </summary>
		public string Fax {
			get {
				return GetTypedColumnValue<string>("Fax");
			}
			set {
				SetColumnValue("Fax", value);
			}
		}

		/// <summary>
		/// Full job title.
		/// </summary>
		public string FullJobTitle {
			get {
				return GetTypedColumnValue<string>("FullJobTitle");
			}
			set {
				SetColumnValue("FullJobTitle", value);
			}
		}

		/// <exclude/>
		public Guid GenderId {
			get {
				return GetTypedColumnValue<Guid>("GenderId");
			}
			set {
				SetColumnValue("GenderId", value);
				_gender = null;
			}
		}

		/// <exclude/>
		public string GenderName {
			get {
				return GetTypedColumnValue<string>("GenderName");
			}
			set {
				SetColumnValue("GenderName", value);
				if (_gender != null) {
					_gender.Name = value;
				}
			}
		}

		private Gender _gender;
		/// <summary>
		/// Gender.
		/// </summary>
		public Gender Gender {
			get {
				return _gender ??
					(_gender = LookupColumnEntities.GetEntity("Gender") as Gender);
			}
		}

		/// <exclude/>
		public Guid IndustryId {
			get {
				return GetTypedColumnValue<Guid>("IndustryId");
			}
			set {
				SetColumnValue("IndustryId", value);
				_industry = null;
			}
		}

		/// <exclude/>
		public string IndustryName {
			get {
				return GetTypedColumnValue<string>("IndustryName");
			}
			set {
				SetColumnValue("IndustryName", value);
				if (_industry != null) {
					_industry.Name = value;
				}
			}
		}

		private AccountIndustry _industry;
		/// <summary>
		/// Industry.
		/// </summary>
		public AccountIndustry Industry {
			get {
				return _industry ??
					(_industry = LookupColumnEntities.GetEntity("Industry") as AccountIndustry);
			}
		}

		/// <exclude/>
		public Guid InformationSourceId {
			get {
				return GetTypedColumnValue<Guid>("InformationSourceId");
			}
			set {
				SetColumnValue("InformationSourceId", value);
				_informationSource = null;
			}
		}

		/// <exclude/>
		public string InformationSourceName {
			get {
				return GetTypedColumnValue<string>("InformationSourceName");
			}
			set {
				SetColumnValue("InformationSourceName", value);
				if (_informationSource != null) {
					_informationSource.Name = value;
				}
			}
		}

		private InformationSource _informationSource;
		/// <summary>
		/// Information source.
		/// </summary>
		public InformationSource InformationSource {
			get {
				return _informationSource ??
					(_informationSource = LookupColumnEntities.GetEntity("InformationSource") as InformationSource);
			}
		}

		/// <exclude/>
		public Guid JobId {
			get {
				return GetTypedColumnValue<Guid>("JobId");
			}
			set {
				SetColumnValue("JobId", value);
				_job = null;
			}
		}

		/// <exclude/>
		public string JobName {
			get {
				return GetTypedColumnValue<string>("JobName");
			}
			set {
				SetColumnValue("JobName", value);
				if (_job != null) {
					_job.Name = value;
				}
			}
		}

		private Job _job;
		/// <summary>
		/// Job title.
		/// </summary>
		public Job Job {
			get {
				return _job ??
					(_job = LookupColumnEntities.GetEntity("Job") as Job);
			}
		}

		/// <exclude/>
		public Guid LeadTypeStatusId {
			get {
				return GetTypedColumnValue<Guid>("LeadTypeStatusId");
			}
			set {
				SetColumnValue("LeadTypeStatusId", value);
				_leadTypeStatus = null;
			}
		}

		/// <exclude/>
		public string LeadTypeStatusName {
			get {
				return GetTypedColumnValue<string>("LeadTypeStatusName");
			}
			set {
				SetColumnValue("LeadTypeStatusName", value);
				if (_leadTypeStatus != null) {
					_leadTypeStatus.Name = value;
				}
			}
		}

		private LeadTypeStatus _leadTypeStatus;
		/// <summary>
		/// Need maturity.
		/// </summary>
		public LeadTypeStatus LeadTypeStatus {
			get {
				return _leadTypeStatus ??
					(_leadTypeStatus = LookupColumnEntities.GetEntity("LeadTypeStatus") as LeadTypeStatus);
			}
		}

		/// <summary>
		/// Next actualization date.
		/// </summary>
		public DateTime NextActualizationDate {
			get {
				return GetTypedColumnValue<DateTime>("NextActualizationDate");
			}
			set {
				SetColumnValue("NextActualizationDate", value);
			}
		}

		/// <summary>
		/// QualificationProcessId.
		/// </summary>
		/// <remarks>
		/// Id. in SysProcessData table.
		/// </remarks>
		public Guid QualificationProcessId {
			get {
				return GetTypedColumnValue<Guid>("QualificationProcessId");
			}
			set {
				SetColumnValue("QualificationProcessId", value);
			}
		}

		/// <exclude/>
		public Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// State/province.
		/// </summary>
		public Region Region {
			get {
				return _region ??
					(_region = LookupColumnEntities.GetEntity("Region") as Region);
			}
		}

		/// <exclude/>
		public Guid RegisterMethodId {
			get {
				return GetTypedColumnValue<Guid>("RegisterMethodId");
			}
			set {
				SetColumnValue("RegisterMethodId", value);
				_registerMethod = null;
			}
		}

		/// <exclude/>
		public string RegisterMethodName {
			get {
				return GetTypedColumnValue<string>("RegisterMethodName");
			}
			set {
				SetColumnValue("RegisterMethodName", value);
				if (_registerMethod != null) {
					_registerMethod.Name = value;
				}
			}
		}

		private LeadRegisterMethod _registerMethod;
		/// <summary>
		/// Registration method.
		/// </summary>
		public LeadRegisterMethod RegisterMethod {
			get {
				return _registerMethod ??
					(_registerMethod = LookupColumnEntities.GetEntity("RegisterMethod") as LeadRegisterMethod);
			}
		}

		/// <summary>
		/// Remind owner.
		/// </summary>
		public bool RemindToOwner {
			get {
				return GetTypedColumnValue<bool>("RemindToOwner");
			}
			set {
				SetColumnValue("RemindToOwner", value);
			}
		}

		/// <summary>
		/// Display distribution page.
		/// </summary>
		public bool ShowDistributionPage {
			get {
				return GetTypedColumnValue<bool>("ShowDistributionPage");
			}
			set {
				SetColumnValue("ShowDistributionPage", value);
			}
		}

		/// <exclude/>
		public Guid TitleId {
			get {
				return GetTypedColumnValue<Guid>("TitleId");
			}
			set {
				SetColumnValue("TitleId", value);
				_title = null;
			}
		}

		/// <exclude/>
		public string TitleName {
			get {
				return GetTypedColumnValue<string>("TitleName");
			}
			set {
				SetColumnValue("TitleName", value);
				if (_title != null) {
					_title.Name = value;
				}
			}
		}

		private ContactSalutationType _title;
		/// <summary>
		/// Salutation.
		/// </summary>
		public ContactSalutationType Title {
			get {
				return _title ??
					(_title = LookupColumnEntities.GetEntity("Title") as ContactSalutationType);
			}
		}

		/// <summary>
		/// ZIP/postal code.
		/// </summary>
		public string Zip {
			get {
				return GetTypedColumnValue<string>("Zip");
			}
			set {
				SetColumnValue("Zip", value);
			}
		}

		/// <summary>
		/// Account name.
		/// </summary>
		public string Account {
			get {
				return GetTypedColumnValue<string>("Account");
			}
			set {
				SetColumnValue("Account", value);
			}
		}

		/// <summary>
		/// Contact name.
		/// </summary>
		public string Contact {
			get {
				return GetTypedColumnValue<string>("Contact");
			}
			set {
				SetColumnValue("Contact", value);
			}
		}

		/// <exclude/>
		public Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public City City {
			get {
				return _city ??
					(_city = LookupColumnEntities.GetEntity("City") as City);
			}
		}

		/// <summary>
		/// Business phone.
		/// </summary>
		public string BusinesPhone {
			get {
				return GetTypedColumnValue<string>("BusinesPhone");
			}
			set {
				SetColumnValue("BusinesPhone", value);
			}
		}

		/// <exclude/>
		public Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <summary>
		/// Mobile phone.
		/// </summary>
		public string MobilePhone {
			get {
				return GetTypedColumnValue<string>("MobilePhone");
			}
			set {
				SetColumnValue("MobilePhone", value);
			}
		}

		/// <summary>
		/// Web.
		/// </summary>
		public string Website {
			get {
				return GetTypedColumnValue<string>("Website");
			}
			set {
				SetColumnValue("Website", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_Lead_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_Lead_TerrasoftInserted", e);
			Inserting += (s, e) => ThrowEvent("Lead_Lead_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Lead_Lead_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Lead_Lead_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Lead_Lead_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_Lead_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_LeadEventsProcess

	/// <exclude/>
	public partial class Lead_LeadEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CrtLeadEventsProcess<TEntity> where TEntity : Lead_Lead_Terrasoft
	{

		public Lead_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_LeadEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2f9261d3-9ce2-46fd-9582-2fc26fa27c10");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3;
		public ProcessFlowElement EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3 {
			get {
				return _eventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3 ?? (_eventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3",
					SchemaElementUId = new Guid("630a9f65-10bb-4e5f-b862-bac11e7f69f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_67972ae3e66342d0862d0dd3febbe694;
		public ProcessFlowElement StartMessage3_67972ae3e66342d0862d0dd3febbe694 {
			get {
				return _startMessage3_67972ae3e66342d0862d0dd3febbe694 ?? (_startMessage3_67972ae3e66342d0862d0dd3febbe694 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_67972ae3e66342d0862d0dd3febbe694",
					SchemaElementUId = new Guid("67972ae3-e663-42d0-862d-0dd3febbe694"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_f54686cb1e384464983aca1cc8edc9f1;
		public ProcessScriptTask ScriptTask3_f54686cb1e384464983aca1cc8edc9f1 {
			get {
				return _scriptTask3_f54686cb1e384464983aca1cc8edc9f1 ?? (_scriptTask3_f54686cb1e384464983aca1cc8edc9f1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_f54686cb1e384464983aca1cc8edc9f1",
					SchemaElementUId = new Guid("f54686cb-1e38-4464-983a-ca1cc8edc9f1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_f54686cb1e384464983aca1cc8edc9f1Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_3706ad88d43f42dbaa278f84d217f11b;
		public ProcessFlowElement EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b {
			get {
				return _eventSubProcess4_3706ad88d43f42dbaa278f84d217f11b ?? (_eventSubProcess4_3706ad88d43f42dbaa278f84d217f11b = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b",
					SchemaElementUId = new Guid("3706ad88-d43f-42db-aa27-8f84d217f11b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage4_138ec9872db945468d0bb10ab63d0c95;
		public ProcessFlowElement StartMessage4_138ec9872db945468d0bb10ab63d0c95 {
			get {
				return _startMessage4_138ec9872db945468d0bb10ab63d0c95 ?? (_startMessage4_138ec9872db945468d0bb10ab63d0c95 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4_138ec9872db945468d0bb10ab63d0c95",
					SchemaElementUId = new Guid("138ec987-2db9-4546-8d0b-b10ab63d0c95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_92a166a193864109bc8ca1b3e1187053;
		public ProcessScriptTask ScriptTask4_92a166a193864109bc8ca1b3e1187053 {
			get {
				return _scriptTask4_92a166a193864109bc8ca1b3e1187053 ?? (_scriptTask4_92a166a193864109bc8ca1b3e1187053 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_92a166a193864109bc8ca1b3e1187053",
					SchemaElementUId = new Guid("92a166a1-9386-4109-bc8c-a1b3e1187053"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_92a166a193864109bc8ca1b3e1187053Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d;
		public ProcessFlowElement EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d {
			get {
				return _eventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d ?? (_eventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d",
					SchemaElementUId = new Guid("1db2f2da-e8ab-4d6d-96c1-79398768dc4d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage5_37682a93668c49d2af13632daf7b1329;
		public ProcessFlowElement StartMessage5_37682a93668c49d2af13632daf7b1329 {
			get {
				return _startMessage5_37682a93668c49d2af13632daf7b1329 ?? (_startMessage5_37682a93668c49d2af13632daf7b1329 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5_37682a93668c49d2af13632daf7b1329",
					SchemaElementUId = new Guid("37682a93-668c-49d2-af13-632daf7b1329"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask5_75d763b802ae4996a61a2f938afec580;
		public ProcessScriptTask ScriptTask5_75d763b802ae4996a61a2f938afec580 {
			get {
				return _scriptTask5_75d763b802ae4996a61a2f938afec580 ?? (_scriptTask5_75d763b802ae4996a61a2f938afec580 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask5_75d763b802ae4996a61a2f938afec580",
					SchemaElementUId = new Guid("75d763b8-02ae-4996-a61a-2f938afec580"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask5_75d763b802ae4996a61a2f938afec580Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3 };
			FlowElements[StartMessage3_67972ae3e66342d0862d0dd3febbe694.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_67972ae3e66342d0862d0dd3febbe694 };
			FlowElements[ScriptTask3_f54686cb1e384464983aca1cc8edc9f1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_f54686cb1e384464983aca1cc8edc9f1 };
			FlowElements[EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b };
			FlowElements[StartMessage4_138ec9872db945468d0bb10ab63d0c95.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4_138ec9872db945468d0bb10ab63d0c95 };
			FlowElements[ScriptTask4_92a166a193864109bc8ca1b3e1187053.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_92a166a193864109bc8ca1b3e1187053 };
			FlowElements[EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d };
			FlowElements[StartMessage5_37682a93668c49d2af13632daf7b1329.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5_37682a93668c49d2af13632daf7b1329 };
			FlowElements[ScriptTask5_75d763b802ae4996a61a2f938afec580.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask5_75d763b802ae4996a61a2f938afec580 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3":
						break;
					case "StartMessage3_67972ae3e66342d0862d0dd3febbe694":
						e.Context.QueueTasks.Enqueue("ScriptTask3_f54686cb1e384464983aca1cc8edc9f1");
						break;
					case "ScriptTask3_f54686cb1e384464983aca1cc8edc9f1":
						break;
					case "EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b":
						break;
					case "StartMessage4_138ec9872db945468d0bb10ab63d0c95":
						e.Context.QueueTasks.Enqueue("ScriptTask4_92a166a193864109bc8ca1b3e1187053");
						break;
					case "ScriptTask4_92a166a193864109bc8ca1b3e1187053":
						break;
					case "EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d":
						break;
					case "StartMessage5_37682a93668c49d2af13632daf7b1329":
						e.Context.QueueTasks.Enqueue("ScriptTask5_75d763b802ae4996a61a2f938afec580");
						break;
					case "ScriptTask5_75d763b802ae4996a61a2f938afec580":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_67972ae3e66342d0862d0dd3febbe694");
			ActivatedEventElements.Add("StartMessage4_138ec9872db945468d0bb10ab63d0c95");
			ActivatedEventElements.Add("StartMessage5_37682a93668c49d2af13632daf7b1329");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_630a9f6510bb4e5fb862bac11e7f69f3":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_67972ae3e66342d0862d0dd3febbe694":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_67972ae3e66342d0862d0dd3febbe694";
					result = StartMessage3_67972ae3e66342d0862d0dd3febbe694.Execute(context);
					break;
				case "ScriptTask3_f54686cb1e384464983aca1cc8edc9f1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_f54686cb1e384464983aca1cc8edc9f1";
					result = ScriptTask3_f54686cb1e384464983aca1cc8edc9f1.Execute(context, ScriptTask3_f54686cb1e384464983aca1cc8edc9f1Execute);
					break;
				case "EventSubProcess4_3706ad88d43f42dbaa278f84d217f11b":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage4_138ec9872db945468d0bb10ab63d0c95":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4_138ec9872db945468d0bb10ab63d0c95";
					result = StartMessage4_138ec9872db945468d0bb10ab63d0c95.Execute(context);
					break;
				case "ScriptTask4_92a166a193864109bc8ca1b3e1187053":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_92a166a193864109bc8ca1b3e1187053";
					result = ScriptTask4_92a166a193864109bc8ca1b3e1187053.Execute(context, ScriptTask4_92a166a193864109bc8ca1b3e1187053Execute);
					break;
				case "EventSubProcess5_1db2f2dae8ab4d6d96c179398768dc4d":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage5_37682a93668c49d2af13632daf7b1329":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5_37682a93668c49d2af13632daf7b1329";
					result = StartMessage5_37682a93668c49d2af13632daf7b1329.Execute(context);
					break;
				case "ScriptTask5_75d763b802ae4996a61a2f938afec580":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask5_75d763b802ae4996a61a2f938afec580";
					result = ScriptTask5_75d763b802ae4996a61a2f938afec580.Execute(context, ScriptTask5_75d763b802ae4996a61a2f938afec580Execute);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_f54686cb1e384464983aca1cc8edc9f1Execute(ProcessExecutingContext context) {
			LeadSaved();
			return true;
		}

		public virtual bool ScriptTask4_92a166a193864109bc8ca1b3e1187053Execute(ProcessExecutingContext context) {
			LeadSavingMethod();
			return true;
		}

		public virtual bool ScriptTask5_75d763b802ae4996a61a2f938afec580Execute(ProcessExecutingContext context) {
			LeadInserted();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Lead_Lead_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage3_67972ae3e66342d0862d0dd3febbe694")) {
							context.QueueTasks.Enqueue("StartMessage3_67972ae3e66342d0862d0dd3febbe694");
						}
						break;
					case "Lead_Lead_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage4_138ec9872db945468d0bb10ab63d0c95")) {
							context.QueueTasks.Enqueue("StartMessage4_138ec9872db945468d0bb10ab63d0c95");
						}
						break;
					case "Lead_Lead_TerrasoftInserted":
							if (ActivatedEventElements.Contains("StartMessage5_37682a93668c49d2af13632daf7b1329")) {
							context.QueueTasks.Enqueue("StartMessage5_37682a93668c49d2af13632daf7b1329");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_LeadEventsProcess

	/// <exclude/>
	public class Lead_LeadEventsProcess : Lead_LeadEventsProcess<Lead_Lead_Terrasoft>
	{

		public Lead_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

