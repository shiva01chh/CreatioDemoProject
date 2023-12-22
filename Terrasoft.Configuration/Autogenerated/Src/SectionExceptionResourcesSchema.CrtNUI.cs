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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,77,10,131,64,12,133,215,10,222,33,224,222,217,151,210,141,244,2,173,23,136,49,234,208,249,145,137,210,63,122,247,58,90,193,85,179,122,73,30,188,239,57,180,44,3,18,67,197,33,160,248,118,44,74,239,90,221,77,1,71,237,93,150,190,179,52,201,3,119,243,2,165,65,145,3,92,153,226,239,252,32,30,162,184,176,248,41,16,75,150,206,102,165,20,28,101,178,22,195,243,244,219,171,94,11,172,38,32,223,48,8,245,108,113,214,110,68,237,4,140,39,52,250,133,181,97,152,145,4,59,22,104,125,0,52,6,238,62,220,6,19,41,209,53,32,107,58,240,22,47,197,150,170,118,177,195,84,27,77,64,17,249,31,113,18,11,126,22,242,156,93,179,54,205,210,229,178,159,47,254,116,158,220,43,1,0,0 };
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

