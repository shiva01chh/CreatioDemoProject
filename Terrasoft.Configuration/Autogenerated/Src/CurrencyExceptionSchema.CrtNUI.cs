namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrencyExceptionSchema

	/// <exclude/>
	public class CurrencyExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrencyExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrencyExceptionSchema(CurrencyExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf");
			Name = "CurrencyException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,77,111,226,48,16,61,83,169,255,97,148,238,1,36,148,220,41,229,130,218,110,165,182,91,181,104,15,123,51,97,0,239,38,118,214,118,160,180,234,127,223,177,243,65,32,1,202,110,43,45,18,2,59,243,241,102,60,239,57,130,197,168,19,22,34,140,80,41,166,229,212,248,67,41,166,124,150,42,102,184,20,254,48,85,10,69,184,186,124,14,49,177,59,167,39,175,167,39,173,84,115,49,131,167,149,54,24,159,151,235,161,140,99,41,104,77,59,103,10,103,100,14,195,136,105,221,131,50,142,82,82,221,161,214,108,134,95,49,74,80,57,235,32,8,160,175,211,56,102,106,53,200,215,15,74,46,248,4,53,164,134,71,220,172,32,70,51,151,19,13,83,169,96,41,213,47,155,114,201,205,28,208,6,165,199,46,42,200,41,152,57,66,152,103,244,139,240,65,37,62,23,6,149,96,17,104,67,117,134,16,90,148,123,65,182,108,217,101,85,119,25,148,30,129,228,11,102,208,21,81,171,194,109,60,162,73,149,208,16,201,144,69,252,133,141,35,164,172,202,130,55,114,19,186,95,6,9,182,163,244,19,166,88,12,130,14,236,194,211,70,42,50,247,6,143,168,101,170,66,27,208,237,248,253,192,217,53,187,85,16,60,57,0,247,180,237,13,110,235,192,172,125,61,150,202,42,25,244,131,226,159,125,148,164,227,136,58,152,55,50,15,112,141,166,218,196,17,198,73,68,109,106,223,20,136,159,50,192,5,240,110,225,216,136,177,3,174,249,173,5,83,89,195,182,194,194,5,8,92,194,237,182,111,187,140,238,213,230,216,235,186,144,173,47,94,205,77,251,175,141,48,222,252,239,44,74,209,235,156,59,215,172,9,141,128,252,145,204,17,100,182,111,217,124,156,161,152,100,3,100,87,244,205,246,171,219,187,153,115,47,205,149,76,197,164,194,196,29,196,25,209,244,99,97,69,92,96,6,184,166,95,37,151,2,150,115,20,37,55,128,248,37,12,159,114,84,48,145,68,53,33,13,209,139,178,0,77,165,201,226,204,153,160,131,82,182,207,165,141,70,211,200,171,124,24,54,233,84,67,14,61,184,79,163,232,155,186,140,19,83,149,22,75,178,42,205,72,139,104,46,210,144,142,209,114,205,5,207,91,215,76,182,27,193,13,183,39,71,56,153,27,10,78,17,152,8,75,89,232,107,36,109,80,56,189,240,118,226,243,130,65,86,194,39,19,178,56,134,155,137,55,24,214,143,100,195,57,239,236,78,204,123,168,117,157,242,9,172,115,117,220,244,246,96,204,52,182,183,136,186,102,76,197,62,167,223,91,209,249,173,121,61,32,138,73,182,40,4,162,198,182,109,173,56,162,144,195,178,176,87,209,233,227,239,18,170,186,114,212,58,158,187,108,201,65,166,99,254,149,84,49,51,237,38,88,27,189,221,37,15,71,138,195,131,157,19,164,59,237,150,114,17,175,126,167,44,210,63,80,201,203,103,243,113,106,145,20,89,32,162,52,86,34,208,37,130,23,202,244,126,61,216,3,118,45,16,71,171,194,199,106,194,97,140,255,163,72,212,156,203,19,203,174,250,178,170,29,55,124,213,117,225,238,186,193,30,13,58,220,163,247,115,57,191,141,243,183,128,13,216,93,144,227,159,24,26,112,136,58,112,164,124,117,183,163,101,97,214,162,246,207,146,214,252,206,243,41,181,103,130,151,91,126,190,230,29,62,225,191,23,65,87,81,237,112,222,33,141,59,222,156,220,142,253,252,1,42,248,14,21,213,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCurrencyNotFoundExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateCurrencyParameterLessOrEqualsZeroExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCurrencyNotFoundExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a74da309-e90a-4cbe-9b82-2327571ebd4e"),
				Name = "CurrencyNotFoundExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"),
				ModifiedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateCurrencyParameterLessOrEqualsZeroExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("47fc8d47-9788-470a-afd5-51c6e1736e59"),
				Name = "CurrencyParameterLessOrEqualsZeroExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"),
				ModifiedInSchemaUId = new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28996e92-7c7b-4a20-a9f3-7bfa09f7eaaf"));
		}

		#endregion

	}

	#endregion

}

