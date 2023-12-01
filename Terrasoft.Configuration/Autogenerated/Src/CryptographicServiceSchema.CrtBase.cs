namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CryptographicServiceSchema

	/// <exclude/>
	public class CryptographicServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CryptographicServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CryptographicServiceSchema(CryptographicServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378");
			Name = "CryptographicService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,81,79,219,48,16,126,14,18,255,193,10,47,169,84,185,239,43,32,65,215,77,108,43,32,194,198,67,197,131,155,92,75,68,98,123,103,167,44,155,248,239,59,39,78,155,166,93,23,169,81,125,247,249,251,62,223,157,35,69,1,70,139,4,216,35,32,10,163,150,150,79,148,92,102,171,18,133,205,148,60,61,249,115,122,18,148,38,147,43,22,87,198,66,49,238,173,119,241,123,217,24,112,157,37,48,83,41,228,71,147,252,9,22,199,1,87,137,205,214,61,149,174,237,162,248,87,6,225,80,156,4,183,187,40,63,247,106,116,32,139,34,177,207,46,118,101,244,45,88,130,105,82,94,100,121,102,171,7,248,89,102,8,5,72,107,162,238,194,217,100,23,236,63,91,28,138,251,64,58,112,34,186,92,228,89,194,146,92,24,195,38,88,105,171,86,40,244,75,150,120,71,236,3,187,22,6,218,149,107,73,48,191,211,208,212,188,235,55,152,211,169,110,228,90,189,66,52,3,251,162,82,50,20,222,223,197,143,225,144,93,171,180,138,109,149,59,147,4,155,129,49,98,5,155,40,127,34,81,13,233,208,241,4,206,33,24,251,73,97,33,236,206,134,38,196,191,24,37,135,236,129,230,71,73,3,199,113,238,152,142,117,52,26,177,115,83,22,133,192,234,178,13,156,117,31,214,251,195,58,161,51,246,113,26,243,13,207,168,79,116,174,5,138,130,73,26,234,139,80,83,49,223,20,166,225,229,150,175,35,197,207,71,53,122,187,25,193,150,40,141,135,15,119,109,157,245,150,237,154,104,218,125,142,200,119,210,88,116,163,246,217,77,129,92,3,90,72,239,189,157,31,34,47,33,242,128,214,227,160,105,105,144,45,153,79,241,27,115,91,230,249,29,78,11,109,171,104,3,108,145,65,163,234,149,120,141,26,215,153,247,250,189,22,200,146,122,146,252,208,124,133,138,154,179,115,87,103,66,82,151,144,95,105,29,131,181,196,99,230,225,204,172,190,27,192,214,46,21,124,210,163,9,159,199,199,205,246,117,183,166,157,43,4,163,74,76,32,182,10,73,158,76,57,61,50,38,33,113,174,248,147,194,215,250,155,68,151,100,7,58,222,146,208,29,86,232,199,140,24,36,188,177,111,42,17,121,246,91,44,114,194,59,87,81,79,169,25,235,32,8,15,221,48,186,29,225,30,131,225,253,179,79,127,37,160,235,218,53,218,188,110,103,56,240,214,236,11,170,183,218,141,171,199,3,44,1,65,38,176,217,21,117,125,15,186,253,242,3,81,236,86,191,105,90,191,158,252,81,249,19,122,138,230,195,22,237,245,252,30,213,58,75,1,125,133,250,189,108,211,209,190,234,222,156,29,228,229,83,89,199,183,227,217,57,146,123,209,239,221,93,124,122,254,2,255,45,90,139,106,6,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCryptoServiceKeyExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCryptoServiceKeyExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7264c8f8-6a12-42f2-b6d0-3a6bc04b2a99"),
				Name = "CryptoServiceKeyExceptionMessage",
				CreatedInPackageId = new Guid("55f82158-5486-4bb7-b202-c8f84f805cfa"),
				CreatedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"),
				ModifiedInSchemaUId = new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba8f2b10-80c4-416c-92db-1fe39960f378"));
		}

		#endregion

	}

	#endregion

}

