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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,75,14,131,48,12,68,215,68,226,14,150,216,147,125,85,117,131,122,129,150,11,24,99,32,106,72,80,12,234,79,189,123,19,104,165,174,234,213,216,30,105,222,56,28,89,38,36,134,154,67,64,241,221,92,86,222,117,166,95,2,206,198,187,92,61,115,149,21,129,251,184,64,101,81,100,7,103,166,244,59,222,136,167,36,78,44,126,9,196,146,171,104,214,90,195,94,150,113,196,112,63,124,246,122,48,2,155,9,200,183,12,66,3,143,24,181,155,209,56,1,235,9,173,121,96,99,25,34,146,96,207,2,157,15,128,214,194,213,135,203,100,19,37,186,22,100,75,7,254,198,75,249,77,213,63,177,211,210,88,67,64,9,249,31,113,150,10,190,86,242,130,93,187,53,205,213,122,137,243,6,41,192,79,24,34,1,0,0 };
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

