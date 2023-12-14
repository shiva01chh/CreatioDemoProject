namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionExceptionResourcesSchema

	/// <exclude/>
	public class SectionExceptionResourcesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionExceptionResourcesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionExceptionResourcesSchema(SectionExceptionResourcesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1");
			Name = "SectionExceptionResources";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,75,14,131,48,12,68,215,32,229,14,150,216,195,190,170,186,65,189,64,203,5,140,49,16,53,36,81,76,212,159,122,247,18,104,165,174,234,213,216,30,105,222,88,156,88,60,18,67,195,33,160,184,126,46,107,103,123,61,196,128,179,118,86,229,79,149,103,69,224,97,89,160,54,40,178,131,51,83,250,29,111,196,62,137,19,139,139,129,88,84,190,152,171,170,130,189,196,105,194,112,63,124,246,102,212,2,155,9,200,117,12,66,35,79,184,104,59,163,182,2,198,17,26,253,192,214,48,44,72,130,3,11,244,46,0,26,3,87,23,46,222,36,74,180,29,200,150,14,252,141,151,242,155,90,253,196,250,216,26,77,64,9,249,31,113,150,10,190,86,242,130,109,183,53,85,249,122,73,243,6,63,209,125,112,35,1,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSectionNotFoundByIdTplLocalizableString());
			LocalizableStrings.Add(CreateWorkplaceNotFoundByIdTplLocalizableString());
			LocalizableStrings.Add(CreateEntityNotAllowedForSSPTplLocalizableString());
			LocalizableStrings.Add(CreateWorkplaceCreateFailedLocalizableString());
			LocalizableStrings.Add(CreateWorkplaceSectionTypeNotMatchLocalizableString());
			LocalizableStrings.Add(CreateSectionNotSspTypeTplLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSectionNotFoundByIdTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f01bcb74-e302-4b6e-9150-8ecf83c08c88"),
				Name = "SectionNotFoundByIdTpl",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWorkplaceNotFoundByIdTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5aa54c95-c48e-49ee-90c4-e020e313e093"),
				Name = "WorkplaceNotFoundByIdTpl",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEntityNotAllowedForSSPTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f341ba5c-75ac-4bd7-99b0-4a9e2a1729ea"),
				Name = "EntityNotAllowedForSSPTpl",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWorkplaceCreateFailedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ddbc7ab7-59d9-433c-88df-543bba74a3f1"),
				Name = "WorkplaceCreateFailed",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateWorkplaceSectionTypeNotMatchLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("09d7c38b-e8ab-4c98-85f0-1122edff1cb5"),
				Name = "WorkplaceSectionTypeNotMatch",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSectionNotSspTypeTplLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7b27fa27-0b26-45c9-b8bc-bcb375d08e95"),
				Name = "SectionNotSspTypeTpl",
				CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1"),
				CreatedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"),
				ModifiedInSchemaUId = new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff29964e-7106-4780-912f-9d1f5161f3f1"));
		}

		#endregion

	}

	#endregion

}

