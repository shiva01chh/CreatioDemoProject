namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthResourceListenerSchema

	/// <exclude/>
	public class OAuthResourceListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthResourceListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthResourceListenerSchema(OAuthResourceListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2");
			Name = "OAuthResourceListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,75,143,218,72,16,62,19,41,255,161,229,189,24,9,153,85,142,51,128,68,24,146,32,101,118,162,64,118,15,81,14,61,118,1,157,181,187,173,238,54,25,118,196,127,223,234,151,177,29,216,25,20,69,138,180,92,140,219,245,252,234,171,234,226,180,0,85,210,20,200,10,164,164,74,172,117,50,19,124,205,54,149,164,154,9,158,220,77,43,189,125,245,251,203,23,143,47,95,244,42,197,248,134,44,247,74,67,113,221,121,71,189,60,135,212,40,169,228,45,112,144,44,61,202,52,205,23,133,224,167,191,72,72,230,92,51,205,64,61,41,144,204,119,192,245,73,57,27,243,130,107,216,248,36,110,86,119,207,146,155,63,164,80,154,127,40,141,242,191,73,216,224,11,153,229,84,169,43,98,197,63,130,18,149,76,225,61,195,164,49,73,43,248,217,6,181,183,17,133,15,241,50,221,66,65,255,64,132,201,152,68,45,229,168,255,5,181,202,234,62,103,41,73,141,245,211,198,201,21,121,77,21,216,111,211,146,205,40,34,140,30,123,143,214,235,49,62,132,92,203,42,213,66,98,152,31,172,89,39,225,93,156,52,30,247,209,252,61,154,143,57,124,35,55,204,150,142,202,253,104,181,47,97,64,208,34,162,53,65,41,83,249,94,239,145,104,60,23,235,24,3,89,130,220,129,172,209,234,15,72,244,94,164,52,103,255,208,251,28,150,86,83,37,193,225,71,140,18,93,154,195,185,148,66,222,130,82,116,3,201,159,52,175,32,34,135,193,25,251,152,22,55,132,218,25,104,159,240,21,100,5,63,233,194,120,56,96,38,7,15,28,240,204,97,215,6,242,22,244,86,100,6,67,201,118,84,131,7,209,189,16,12,44,164,180,224,107,65,222,130,110,28,189,145,162,112,52,136,221,131,128,125,4,252,118,84,18,233,101,61,41,156,0,54,139,54,144,103,216,64,85,193,109,200,163,128,126,100,68,163,254,245,119,38,110,152,42,115,186,191,192,82,67,163,105,144,30,83,64,67,134,10,221,60,93,252,61,239,170,153,131,171,92,175,29,203,137,8,189,220,7,41,74,144,166,121,189,167,6,233,92,152,53,237,130,83,164,69,100,82,138,176,236,211,178,68,50,219,78,157,166,41,86,216,23,22,75,107,31,7,151,148,4,93,73,222,204,203,158,63,191,244,66,35,147,32,11,197,247,175,68,32,37,37,203,128,236,4,203,200,106,43,197,183,154,149,177,11,155,128,37,159,218,244,201,120,66,180,17,177,121,182,250,239,168,84,75,95,63,55,182,70,107,15,135,67,50,82,85,81,32,122,147,112,240,142,242,44,71,120,29,31,200,146,238,48,112,48,99,41,169,117,134,93,165,81,73,37,45,8,199,66,141,35,133,49,128,140,38,118,150,17,247,150,140,134,86,228,180,6,68,147,213,22,48,22,0,146,74,88,143,163,213,213,217,153,109,227,154,174,113,26,88,7,83,185,193,42,14,39,132,225,4,163,28,41,152,10,174,41,227,6,76,189,133,224,208,166,64,50,170,105,43,22,63,222,218,149,185,227,11,174,12,205,248,38,22,247,95,177,120,62,141,1,113,238,95,195,26,131,170,253,19,8,45,58,219,66,250,247,140,242,91,202,113,120,44,177,137,92,109,173,182,111,25,51,48,147,166,139,96,27,26,61,229,225,31,19,63,10,250,78,200,9,116,219,171,221,128,103,135,138,159,38,206,198,252,1,210,74,131,191,19,226,216,242,109,145,57,25,51,61,89,10,127,73,90,98,187,37,211,44,11,230,226,134,47,28,164,126,106,124,82,199,89,43,120,157,201,225,34,158,89,246,255,106,68,235,84,250,7,152,102,131,129,208,185,222,189,91,124,238,16,100,59,148,16,89,156,2,102,86,212,45,30,77,102,149,148,198,98,133,32,99,150,74,25,117,166,140,5,106,166,138,219,73,224,1,59,130,211,156,80,59,216,26,24,214,62,255,139,240,14,255,159,199,118,111,191,67,245,11,8,114,3,57,232,255,35,69,22,124,135,171,74,86,115,164,193,140,26,19,202,221,5,81,223,156,134,31,92,104,130,74,5,211,200,146,75,249,16,76,95,200,136,39,71,87,115,1,89,226,182,137,188,57,46,31,237,49,82,111,127,94,206,25,240,215,100,225,214,51,191,5,124,183,206,197,29,31,131,206,250,28,54,88,179,20,132,179,144,114,115,253,11,107,206,241,34,62,91,142,216,135,212,98,246,25,116,63,149,88,251,159,218,111,181,135,95,254,114,177,145,194,143,220,47,157,165,199,157,182,15,241,204,252,254,5,25,18,221,152,173,14,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceRegisteringErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceModifyingErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateResourceDeletingErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e03aaebb-193b-8726-710a-929627d6b105"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceRegisteringErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("21597b70-844d-8f8f-62df-ff422643519c"),
				Name = "ResourceRegisteringErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceModifyingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("592cb685-553c-4598-8deb-f17e38c2101e"),
				Name = "ResourceModifyingErrorMessage",
				CreatedInPackageId = new Guid("1cbe3766-af85-4075-b77c-3de2d413d0be"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateResourceDeletingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("12e7cc28-c036-6369-e37b-184500b360e6"),
				Name = "ResourceDeletingErrorMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"),
				ModifiedInSchemaUId = new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5df6ce04-ddc6-56cc-e05b-a60552c68db2"));
		}

		#endregion

	}

	#endregion

}

