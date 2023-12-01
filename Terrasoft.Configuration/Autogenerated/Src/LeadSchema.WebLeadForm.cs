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

	#region Class: Lead_WebLeadForm_TerrasoftSchema

	/// <exclude/>
	public class Lead_WebLeadForm_TerrasoftSchema : Terrasoft.Configuration.Lead_CrtLeadWebForm_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_WebLeadForm_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_WebLeadForm_TerrasoftSchema(Lead_WebLeadForm_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_WebLeadForm_TerrasoftSchema(Lead_WebLeadForm_TerrasoftSchema source)
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
			RealUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			Name = "Lead_WebLeadForm_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			IsDBView = false;
			UseDenyRecordRights = false;
			ShowInAdvancedMode = true;
			UseLiveEditing = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dc75275f-426d-4f50-a4ec-dc7296c7d1cd")) == null) {
				Columns.Add(CreateCountryStrColumn());
			}
			if (Columns.FindByUId(new Guid("eef401ef-dda7-4ba1-8a29-6adf42a527fb")) == null) {
				Columns.Add(CreateRegionStrColumn());
			}
			if (Columns.FindByUId(new Guid("a5f6978f-18e4-47c6-938d-9390b9386db6")) == null) {
				Columns.Add(CreateCityStrColumn());
			}
			if (Columns.FindByUId(new Guid("f904f43e-672c-42f8-a5ed-e484d6d799ce")) == null) {
				Columns.Add(CreateQualifiedColumn());
			}
			if (Columns.FindByUId(new Guid("2917b3c0-75e0-41d3-be64-764da1f5369a")) == null) {
				Columns.Add(CreateSaleParticipantColumn());
			}
			if (Columns.FindByUId(new Guid("6e8ab674-b580-4620-912a-78cdc93ddc7f")) == null) {
				Columns.Add(CreateQualifiedPercentColumn());
			}
			if (Columns.FindByUId(new Guid("35c9d777-642d-455a-8011-0bf9fdf797fd")) == null) {
				Columns.Add(CreateSalePercentColumn());
			}
			if (Columns.FindByUId(new Guid("63835aed-0d82-40d3-b102-75140767b1e5")) == null) {
				Columns.Add(CreateBpmSessionIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateNotesColumn() {
			EntitySchemaColumn column = base.CreateNotesColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateLeadNameColumn() {
			EntitySchemaColumn column = base.CreateLeadNameColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCommentaryColumn() {
			EntitySchemaColumn column = base.CreateCommentaryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateQualifiedContactColumn() {
			EntitySchemaColumn column = base.CreateQualifiedContactColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateQualifiedAccountColumn() {
			EntitySchemaColumn column = base.CreateQualifiedAccountColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateContactColumn() {
			EntitySchemaColumn column = base.CreateContactColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateTitleColumn() {
			EntitySchemaColumn column = base.CreateTitleColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateFullJobTitleColumn() {
			EntitySchemaColumn column = base.CreateFullJobTitleColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateInformationSourceColumn() {
			EntitySchemaColumn column = base.CreateInformationSourceColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateIndustryColumn() {
			EntitySchemaColumn column = base.CreateIndustryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAnnualRevenueColumn() {
			EntitySchemaColumn column = base.CreateAnnualRevenueColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateEmployeesNumberColumn() {
			EntitySchemaColumn column = base.CreateEmployeesNumberColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateBusinesPhoneColumn() {
			EntitySchemaColumn column = base.CreateBusinesPhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateMobilePhoneColumn() {
			EntitySchemaColumn column = base.CreateMobilePhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateEmailColumn() {
			EntitySchemaColumn column = base.CreateEmailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateFaxColumn() {
			EntitySchemaColumn column = base.CreateFaxColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateWebsiteColumn() {
			EntitySchemaColumn column = base.CreateWebsiteColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressTypeColumn() {
			EntitySchemaColumn column = base.CreateAddressTypeColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCountryColumn() {
			EntitySchemaColumn column = base.CreateCountryColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateRegionColumn() {
			EntitySchemaColumn column = base.CreateRegionColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateCityColumn() {
			EntitySchemaColumn column = base.CreateCityColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateZipColumn() {
			EntitySchemaColumn column = base.CreateZipColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateAddressColumn() {
			EntitySchemaColumn column = base.CreateAddressColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseEmailColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseEmailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUsePhoneColumn() {
			EntitySchemaColumn column = base.CreateDoNotUsePhoneColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseFaxColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseFaxColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseSMSColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseSMSColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected override EntitySchemaColumn CreateDoNotUseMailColumn() {
			EntitySchemaColumn column = base.CreateDoNotUseMailColumn();
			column.ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
			column.CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCountryStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dc75275f-426d-4f50-a4ec-dc7296c7d1cd"),
				Name = @"CountryStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("eef401ef-dda7-4ba1-8a29-6adf42a527fb"),
				Name = @"RegionStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateCityStrColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a5f6978f-18e4-47c6-938d-9390b9386db6"),
				Name = @"CityStr",
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f904f43e-672c-42f8-a5ed-e484d6d799ce"),
				Name = @"Qualified",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateSaleParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2917b3c0-75e0-41d3-be64-764da1f5369a"),
				Name = @"SaleParticipant",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateQualifiedPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("6e8ab674-b580-4620-912a-78cdc93ddc7f"),
				Name = @"QualifiedPercent",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateSalePercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("35c9d777-642d-455a-8011-0bf9fdf797fd"),
				Name = @"SalePercent",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("e3031532-a059-4130-8d2e-6bdf35a52945")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("63835aed-0d82-40d3-b102-75140767b1e5"),
				Name = @"BpmSessionId",
				CreatedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				ModifiedInSchemaUId = new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"),
				CreatedInPackageId = new Guid("a604af94-e112-445c-b72d-ae1a2a5d6178")
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
			return new Lead_WebLeadForm_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Lead_WebLeadFormEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Lead_WebLeadForm_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_WebLeadForm_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2eaad242-2409-4730-b249-bf36a3be9e23"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_WebLeadForm_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_WebLeadForm_Terrasoft : Terrasoft.Configuration.Lead_CrtLeadWebForm_Terrasoft
	{

		#region Constructors: Public

		public Lead_WebLeadForm_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_WebLeadForm_Terrasoft";
		}

		public Lead_WebLeadForm_Terrasoft(Lead_WebLeadForm_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Country (string).
		/// </summary>
		public string CountryStr {
			get {
				return GetTypedColumnValue<string>("CountryStr");
			}
			set {
				SetColumnValue("CountryStr", value);
			}
		}

		/// <summary>
		/// State/province (string).
		/// </summary>
		public string RegionStr {
			get {
				return GetTypedColumnValue<string>("RegionStr");
			}
			set {
				SetColumnValue("RegionStr", value);
			}
		}

		/// <summary>
		/// City (string).
		/// </summary>
		public string CityStr {
			get {
				return GetTypedColumnValue<string>("CityStr");
			}
			set {
				SetColumnValue("CityStr", value);
			}
		}

		/// <summary>
		/// Qualified.
		/// </summary>
		public int Qualified {
			get {
				return GetTypedColumnValue<int>("Qualified");
			}
			set {
				SetColumnValue("Qualified", value);
			}
		}

		/// <summary>
		/// Opportunity participant.
		/// </summary>
		public int SaleParticipant {
			get {
				return GetTypedColumnValue<int>("SaleParticipant");
			}
			set {
				SetColumnValue("SaleParticipant", value);
			}
		}

		/// <summary>
		/// % of qualified.
		/// </summary>
		public Decimal QualifiedPercent {
			get {
				return GetTypedColumnValue<Decimal>("QualifiedPercent");
			}
			set {
				SetColumnValue("QualifiedPercent", value);
			}
		}

		/// <summary>
		/// % of opportunities.
		/// </summary>
		public Decimal SalePercent {
			get {
				return GetTypedColumnValue<Decimal>("SalePercent");
			}
			set {
				SetColumnValue("SalePercent", value);
			}
		}

		/// <summary>
		/// BpmSessionId.
		/// </summary>
		public Guid BpmSessionId {
			get {
				return GetTypedColumnValue<Guid>("BpmSessionId");
			}
			set {
				SetColumnValue("BpmSessionId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_WebLeadFormEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftDeleted", e);
			Inserted += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftInserted", e);
			Saved += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Lead_WebLeadForm_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_WebLeadForm_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_WebLeadFormEventsProcess

	/// <exclude/>
	public partial class Lead_WebLeadFormEventsProcess<TEntity> : Terrasoft.Configuration.Lead_CrtLeadWebFormEventsProcess<TEntity> where TEntity : Lead_WebLeadForm_Terrasoft
	{

		public Lead_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_WebLeadFormEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("2eaad242-2409-4730-b249-bf36a3be9e23");
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

	#region Class: Lead_WebLeadFormEventsProcess

	/// <exclude/>
	public class Lead_WebLeadFormEventsProcess : Lead_WebLeadFormEventsProcess<Lead_WebLeadForm_Terrasoft>
	{

		public Lead_WebLeadFormEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

