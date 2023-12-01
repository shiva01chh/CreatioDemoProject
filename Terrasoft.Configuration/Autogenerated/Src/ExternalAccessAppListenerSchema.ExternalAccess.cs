namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExternalAccessAppListenerSchema

	/// <exclude/>
	public class ExternalAccessAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExternalAccessAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExternalAccessAppListenerSchema(ExternalAccessAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df");
			Name = "ExternalAccessAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,109,111,219,54,16,254,236,2,253,15,172,182,15,52,144,40,77,155,118,70,155,122,112,83,57,53,208,151,32,90,218,15,195,48,208,212,217,225,38,145,30,73,121,75,131,252,247,30,69,73,53,101,41,29,6,204,95,44,30,143,119,207,61,247,66,74,86,128,217,48,14,228,23,208,154,25,181,178,241,153,146,43,177,46,53,179,66,201,56,249,199,130,150,44,159,113,14,198,92,48,254,39,91,195,195,7,183,15,31,140,74,35,228,154,164,55,198,66,241,178,93,239,26,42,10,37,251,119,52,12,201,67,255,131,90,111,94,15,110,205,25,183,74,11,48,125,26,159,97,121,15,48,183,251,214,218,77,60,91,26,171,209,14,66,112,102,80,245,7,13,107,92,145,179,156,25,243,130,132,188,204,54,155,119,2,121,144,160,43,229,163,163,35,114,42,228,53,104,97,51,197,143,166,40,219,148,203,92,112,194,221,249,225,227,228,5,193,85,178,5,105,27,209,107,102,144,241,209,109,101,185,197,49,23,144,103,8,228,66,139,45,179,224,55,55,126,65,140,69,246,56,209,192,50,37,243,27,114,94,138,140,252,14,129,211,148,95,67,193,174,22,25,121,69,36,252,93,233,208,104,254,116,242,108,146,156,60,63,76,102,79,39,135,39,199,79,146,195,217,252,100,118,248,228,241,241,241,252,241,228,167,227,201,44,137,198,47,107,44,32,51,15,39,196,246,30,236,181,26,4,87,129,57,7,27,114,112,174,153,196,180,209,43,3,26,75,64,66,69,62,41,131,229,129,63,28,6,178,200,198,196,213,227,104,180,101,154,24,200,81,23,99,162,105,245,53,118,177,249,79,26,26,27,87,103,70,88,14,185,161,81,237,127,145,69,141,124,174,85,65,163,16,101,116,64,34,96,173,202,103,204,48,80,39,65,185,59,26,47,76,242,87,201,114,138,70,203,66,198,23,76,99,139,161,5,186,135,217,145,136,54,60,94,236,51,224,165,133,20,235,49,135,75,224,74,103,212,165,15,43,226,213,148,248,175,24,73,243,118,63,177,188,132,83,199,197,52,64,126,64,84,105,137,163,97,221,8,107,55,26,108,169,229,55,113,37,189,11,19,211,161,30,189,133,18,186,203,243,53,182,9,110,89,140,203,135,164,16,169,239,14,223,128,55,14,238,233,226,237,190,222,148,214,160,58,118,240,124,143,85,103,102,33,177,162,37,7,26,70,179,163,253,115,156,162,54,130,252,53,10,65,71,191,17,102,58,161,245,5,191,85,88,88,103,72,180,69,250,11,33,51,204,196,92,233,48,253,20,167,130,155,24,57,255,146,86,95,31,48,187,13,43,247,86,46,198,214,195,167,143,70,172,8,237,106,99,79,150,121,222,152,174,3,246,234,119,45,119,221,154,66,39,161,157,206,248,174,211,94,57,236,158,117,149,91,108,236,13,29,223,227,212,29,124,132,19,63,5,107,49,122,227,114,83,213,34,237,246,105,167,111,234,228,124,80,86,172,4,175,70,123,34,217,50,135,12,59,103,197,114,3,247,185,237,105,250,182,232,61,177,253,179,164,11,106,175,7,135,232,104,173,255,43,86,234,162,200,192,112,45,54,117,182,221,216,121,167,56,203,197,23,23,167,47,151,14,162,248,18,140,42,53,199,93,165,241,94,221,163,109,231,98,136,14,188,251,31,163,61,171,38,190,13,10,242,46,174,114,18,237,116,153,110,74,250,202,138,92,88,188,28,251,154,245,114,79,107,250,173,227,186,91,113,167,89,246,216,118,12,180,187,254,86,167,67,119,80,203,238,172,196,171,67,247,149,242,89,169,53,222,138,174,133,220,27,193,34,238,69,86,147,210,174,241,216,64,38,107,205,180,92,254,1,189,154,173,202,155,32,143,59,89,245,41,31,239,78,143,239,223,128,213,173,239,55,251,94,5,205,179,64,109,241,17,34,178,122,14,125,148,117,195,164,150,105,75,155,23,65,51,39,185,255,111,72,251,238,212,234,111,198,202,54,100,239,113,133,181,23,5,113,253,7,168,137,204,254,39,160,104,121,0,102,135,126,47,13,133,149,12,127,95,1,107,159,39,2,235,10,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateExternalAccessSessionStartedMessageLocalizableString());
			LocalizableStrings.Add(CreateExternalAccessSessionEndedMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateExternalAccessSessionStartedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("400920bc-ccb5-41e3-ac22-d74e0dc85be5"),
				Name = "ExternalAccessSessionStartedMessage",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"),
				ModifiedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateExternalAccessSessionEndedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7f54a547-ff83-45e6-9501-b0794feebae8"),
				Name = "ExternalAccessSessionEndedMessage",
				CreatedInPackageId = new Guid("c3c7809d-fee0-4b66-8bb6-9b3983c2cffd"),
				CreatedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"),
				ModifiedInSchemaUId = new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("22d9fa35-9564-4de9-b89c-b84ecaec99df"));
		}

		#endregion

	}

	#endregion

}

