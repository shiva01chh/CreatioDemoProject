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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,81,79,219,48,16,126,14,18,255,193,10,47,169,84,185,239,43,32,65,215,77,108,43,32,194,198,67,197,131,235,92,139,69,98,123,103,167,44,155,248,239,179,19,167,77,211,174,139,212,168,190,251,252,125,159,239,206,145,172,0,163,25,7,242,8,136,204,168,165,165,19,37,151,98,85,34,179,66,201,211,147,63,167,39,81,105,132,92,145,180,50,22,138,113,111,189,139,223,203,166,128,107,193,97,166,50,200,143,38,233,19,44,142,3,174,184,21,235,158,74,215,118,81,252,43,131,112,40,238,4,183,187,92,126,30,212,220,129,44,50,110,159,125,236,202,232,91,176,14,166,157,242,66,228,194,86,15,240,179,20,8,5,72,107,146,238,194,219,36,23,228,63,91,60,138,134,64,54,240,34,186,92,228,130,19,158,51,99,200,4,43,109,213,10,153,126,17,60,56,34,31,200,53,51,208,174,124,75,162,249,157,134,166,230,93,191,209,220,157,234,70,174,213,43,36,51,176,47,42,115,134,226,251,187,244,49,30,146,107,149,85,169,173,114,111,210,193,102,96,12,91,193,38,74,159,156,168,134,108,232,121,34,239,16,140,253,164,176,96,118,103,67,19,162,95,140,146,67,242,224,230,71,73,3,199,113,254,152,158,117,52,26,145,115,83,22,5,195,234,178,13,156,117,31,210,251,67,58,161,51,242,113,154,210,13,207,168,79,116,174,25,178,130,72,55,212,23,177,118,197,124,83,152,197,151,91,190,142,20,61,31,213,232,237,102,4,91,162,52,1,62,220,181,117,214,91,182,107,71,211,238,243,68,161,147,198,162,31,181,207,126,10,228,26,208,66,118,31,236,252,96,121,9,73,0,180,30,7,77,75,35,177,36,33,69,111,204,109,153,231,119,56,45,180,173,146,13,176,69,70,141,106,80,162,53,106,92,103,222,235,247,154,33,225,245,36,133,161,249,10,149,107,206,206,93,157,49,233,186,132,244,74,235,20,172,117,60,102,30,207,204,234,187,1,108,237,186,130,79,122,52,241,243,248,184,217,190,238,214,180,119,133,96,84,137,28,82,171,208,201,59,83,94,207,25,147,192,189,43,250,164,240,181,254,38,185,75,178,3,29,111,73,220,29,86,24,198,204,49,72,120,35,223,20,103,185,248,205,22,185,195,123,87,73,79,169,25,235,40,138,15,221,48,119,59,226,61,6,67,251,103,159,254,226,160,235,218,53,218,180,110,103,60,8,214,236,11,170,183,218,141,175,199,3,44,1,65,114,216,236,74,186,190,7,221,126,133,129,40,118,171,223,52,173,95,79,250,168,194,9,3,69,243,97,75,246,122,126,143,106,45,50,192,80,161,126,47,219,116,178,175,186,55,103,7,121,233,84,214,241,237,120,118,142,228,95,238,247,238,47,126,247,249,11,121,171,66,13,115,6,0,0 };
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

