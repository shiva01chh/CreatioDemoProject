namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OAuthClientAppListenerSchema

	/// <exclude/>
	public class OAuthClientAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OAuthClientAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OAuthClientAppListenerSchema(OAuthClientAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3");
			Name = "OAuthClientAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,88,91,111,219,54,20,126,118,129,254,7,194,123,145,1,67,233,246,152,196,6,92,39,237,12,52,77,23,59,235,67,209,7,70,58,182,185,201,148,67,82,110,211,192,255,125,135,55,137,146,101,199,233,208,109,192,250,226,136,60,119,126,231,227,97,57,93,129,92,211,4,200,12,132,160,50,159,171,120,156,243,57,91,20,130,42,150,243,248,122,84,168,229,47,175,94,190,120,124,249,162,83,72,198,23,100,250,32,21,172,206,26,223,168,151,101,144,104,37,25,191,5,14,130,37,149,76,104,126,181,202,121,251,142,128,125,235,241,37,87,76,49,144,79,10,196,151,27,224,170,85,206,228,50,225,10,22,46,185,139,217,245,81,114,151,95,19,88,235,191,80,26,229,127,18,176,192,15,50,206,168,148,167,196,136,143,51,134,110,71,235,245,59,134,213,192,236,141,228,39,19,213,131,9,201,111,68,211,100,9,43,250,30,75,79,6,164,91,215,238,246,62,163,218,186,184,203,88,66,18,109,127,143,121,114,74,94,83,9,102,115,180,102,99,138,197,71,159,157,71,227,183,10,17,79,67,137,34,81,185,192,72,63,24,187,86,194,249,104,183,30,245,208,254,29,218,143,56,124,33,23,204,28,43,21,15,231,179,135,53,244,9,154,196,138,13,81,74,163,162,211,121,36,10,215,243,121,132,145,76,65,108,64,148,21,235,245,73,247,93,158,208,140,125,163,119,25,76,141,166,140,75,143,24,131,169,241,175,148,167,25,110,93,10,145,139,43,144,146,46,32,254,157,102,5,116,201,182,191,199,11,102,199,53,228,54,186,198,79,121,116,178,57,111,117,161,61,108,49,159,173,171,31,240,212,150,176,94,207,43,80,203,60,213,165,20,108,67,21,184,90,218,15,82,102,53,225,243,252,6,238,11,144,138,188,5,85,91,127,35,242,149,133,69,100,127,8,152,31,95,204,13,21,120,242,90,193,65,196,110,99,79,41,93,253,20,251,172,88,113,19,247,185,63,136,174,22,237,246,206,74,3,2,82,38,48,221,91,145,29,105,225,166,210,8,13,209,234,136,142,183,53,170,41,133,230,108,98,147,244,72,67,99,39,30,154,144,134,110,110,37,136,163,205,76,3,149,208,20,147,35,141,158,39,138,124,151,231,25,26,153,56,225,221,116,46,64,38,130,25,240,29,25,80,160,177,107,174,194,15,90,211,253,215,10,43,11,150,206,184,42,168,175,109,223,237,20,82,229,43,87,165,10,80,253,80,15,109,58,144,237,23,168,103,183,147,113,83,252,86,48,20,171,195,198,201,92,114,221,144,58,28,95,120,183,49,173,31,105,120,194,78,162,66,39,147,182,42,159,62,147,199,26,204,77,11,119,182,182,154,2,84,33,248,78,65,205,230,182,222,180,155,156,165,100,44,0,255,54,100,120,3,50,47,68,2,19,110,115,138,222,22,40,80,89,74,251,196,172,8,47,135,11,58,214,138,96,72,81,251,12,27,91,52,140,187,19,110,119,220,48,227,51,171,75,197,83,192,227,152,7,48,147,209,62,209,128,236,3,84,152,164,14,105,148,129,105,157,42,237,125,241,208,13,184,8,26,149,54,101,195,190,48,70,49,102,90,100,170,178,29,29,93,68,144,190,51,44,129,218,11,245,183,2,196,67,163,102,113,40,112,69,57,50,190,232,187,59,215,123,246,13,184,99,203,150,148,36,230,199,114,141,188,143,71,169,107,105,100,132,146,76,38,59,202,111,88,166,16,191,136,99,4,187,203,213,174,145,129,133,180,54,102,97,103,215,63,50,181,252,64,5,118,32,126,200,200,46,226,180,180,166,136,249,156,107,50,137,47,239,11,154,97,2,19,111,178,219,39,120,189,131,11,67,155,180,122,82,199,25,53,60,215,18,173,198,53,199,88,193,130,205,20,79,170,41,218,14,73,54,39,81,211,6,222,183,133,134,247,128,252,236,143,206,55,101,83,244,211,171,207,173,108,169,225,50,140,124,249,99,205,77,206,225,150,64,38,129,28,240,59,12,220,90,214,37,43,123,227,59,228,236,76,8,77,228,120,120,76,113,116,66,181,126,115,82,243,163,82,215,49,84,167,109,232,184,194,201,116,182,164,252,154,67,3,239,245,249,195,229,213,81,75,145,127,169,24,161,116,86,14,55,145,203,162,94,136,127,63,209,247,249,143,201,47,96,145,35,70,178,92,97,78,144,122,214,113,159,36,199,81,81,176,212,81,253,76,199,80,57,116,69,3,51,20,202,69,143,12,134,228,233,48,75,241,179,99,131,11,70,239,147,147,19,114,46,139,213,10,39,234,161,95,48,3,48,72,215,29,68,179,104,74,64,63,28,226,82,231,164,169,116,190,214,132,65,56,182,198,160,43,49,6,60,166,161,121,109,16,251,21,159,159,24,145,118,13,232,14,103,75,192,88,0,72,34,96,62,232,206,78,247,62,171,76,92,163,57,242,136,113,48,18,11,217,37,39,67,194,240,133,65,57,62,33,147,156,43,202,184,174,166,90,130,119,104,82,32,41,85,180,22,139,123,126,212,143,230,154,79,56,130,83,105,148,230,119,127,224,233,185,52,250,142,233,95,195,28,131,42,253,19,240,77,62,94,66,242,231,152,114,203,241,83,228,12,123,184,70,59,152,176,92,117,7,196,205,222,61,43,97,5,246,95,77,110,166,187,109,99,63,253,76,138,195,200,125,200,30,196,181,241,173,186,115,209,252,26,95,103,166,79,139,44,107,145,245,163,94,160,98,23,6,135,30,21,238,53,225,184,254,43,36,133,2,247,66,140,34,3,239,182,16,38,169,213,211,15,43,150,192,71,129,19,28,194,71,223,118,118,24,105,6,129,207,172,214,170,84,121,187,109,156,79,2,86,15,102,250,254,110,32,177,223,60,198,196,20,16,179,170,213,140,221,170,15,33,135,0,7,105,59,222,234,112,175,224,86,59,115,84,110,30,249,211,80,107,204,148,213,187,1,31,150,186,197,131,124,3,13,17,78,98,223,7,215,67,147,110,109,200,13,231,219,3,6,183,45,156,214,224,178,219,53,182,191,33,89,67,103,255,1,26,107,240,200,33,30,123,38,129,249,92,127,0,127,57,208,149,30,158,13,186,127,132,92,246,16,137,137,26,190,151,75,218,64,182,231,226,188,128,12,212,255,241,234,52,137,255,80,228,149,30,158,141,60,55,100,253,205,255,253,121,14,222,110,96,133,5,170,225,13,111,149,35,113,214,152,230,236,106,125,17,215,244,191,191,0,179,60,15,136,65,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateClientApplicationHandlingErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateConnectionErrorMessageLocalizableString());
			LocalizableStrings.Add(CreateNoDefaultResourceMessageLocalizableString());
			LocalizableStrings.Add(CreateMoreThanOneDefaultResourceMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateClientApplicationHandlingErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2cf8bb31-6290-cc97-742e-64fed171040b"),
				Name = "ClientApplicationHandlingErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateConnectionErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3fb4a54a-87f4-40b3-82c2-9d506b6413b6"),
				Name = "ConnectionErrorMessage",
				CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoDefaultResourceMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("645c2e6f-5960-4a83-98b7-9400582df07a"),
				Name = "NoDefaultResourceMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMoreThanOneDefaultResourceMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c3610e85-9aca-45f0-b034-d6dfbee46312"),
				Name = "MoreThanOneDefaultResourceMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"),
				ModifiedInSchemaUId = new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("15d94d7f-ad83-ec8e-ed13-e1079bfecbe3"));
		}

		#endregion

	}

	#endregion

}

