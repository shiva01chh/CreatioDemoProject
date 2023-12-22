namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactCommunicationEventListenerSchema

	/// <exclude/>
	public class ContactCommunicationEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactCommunicationEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactCommunicationEventListenerSchema(ContactCommunicationEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47");
			Name = "ContactCommunicationEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,203,110,219,48,16,60,59,64,254,129,81,47,20,96,8,61,231,5,228,225,4,6,146,212,168,146,246,80,244,64,75,107,155,133,68,186,124,56,73,131,252,123,150,164,44,83,137,28,215,7,195,36,119,134,59,187,195,181,96,53,232,37,43,128,220,131,82,76,203,153,201,46,164,152,241,185,85,204,112,41,246,247,94,246,247,6,86,115,49,39,249,179,54,80,31,181,235,24,82,215,82,244,159,40,216,182,159,93,158,111,61,26,9,195,13,7,189,51,32,27,173,64,152,79,226,158,12,40,193,170,7,13,106,123,212,21,43,140,84,225,62,140,249,162,96,142,226,201,69,197,180,62,36,88,17,131,1,78,165,21,188,240,133,241,215,222,112,172,136,0,229,65,191,124,74,207,157,3,154,23,11,168,217,29,150,153,156,144,164,143,40,73,127,35,120,105,167,21,47,72,225,46,220,125,223,33,57,103,26,122,238,67,166,23,159,76,43,225,22,204,66,150,40,98,162,248,138,25,8,167,203,176,32,83,41,43,114,13,102,172,227,58,117,46,166,215,150,151,164,8,41,141,203,33,9,17,66,64,225,142,137,237,44,83,226,252,50,24,172,152,34,26,42,220,68,221,2,30,73,238,23,244,93,180,143,29,12,176,9,86,24,154,140,203,164,217,202,174,148,172,105,130,150,59,43,107,46,30,4,55,237,209,207,5,40,160,235,98,58,76,134,249,255,181,172,162,23,178,178,181,200,38,76,97,197,81,16,109,243,78,215,232,51,81,122,108,147,194,253,243,18,62,35,112,106,93,76,150,231,147,52,37,76,55,74,142,90,153,16,59,204,11,65,201,65,59,186,15,10,107,32,47,88,197,212,49,23,230,148,166,1,169,192,88,37,250,192,7,39,228,171,143,121,109,58,9,162,12,205,220,214,89,239,157,166,177,193,71,114,133,254,230,37,144,149,196,230,125,19,57,91,161,235,169,156,254,113,29,209,200,8,106,72,130,129,206,97,134,79,192,219,232,76,205,53,129,117,15,167,232,177,172,197,174,65,144,70,210,61,1,202,165,129,42,13,65,155,128,34,118,146,43,227,184,196,232,0,203,208,119,110,171,12,53,255,193,42,11,199,206,108,167,174,63,31,112,73,115,47,159,17,218,71,139,101,115,96,215,58,13,244,3,1,118,92,27,156,22,53,227,149,115,67,163,177,233,67,160,126,141,242,110,108,243,159,217,182,78,220,72,239,58,125,195,211,125,62,27,77,7,59,158,97,244,2,223,61,162,29,90,192,73,254,92,135,54,10,91,140,74,238,108,61,5,21,203,240,104,140,226,37,195,9,137,52,126,38,134,121,233,201,142,199,113,206,190,190,151,18,191,69,11,106,61,239,248,184,30,181,140,46,169,14,61,62,67,255,59,98,185,146,42,230,167,30,16,89,225,32,38,108,43,17,4,17,252,115,211,108,14,205,8,186,145,248,12,249,63,54,173,32,247,231,239,166,81,246,29,180,180,170,192,83,169,16,54,108,166,83,239,216,238,140,221,100,72,146,15,236,104,54,165,164,186,13,57,100,190,210,235,202,14,204,66,201,199,48,24,243,9,222,139,136,194,64,44,124,244,84,192,210,119,190,81,145,70,141,237,31,13,97,183,187,137,123,241,231,13,89,161,232,10,241,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e4acc0dc-d8bb-0687-baa4-abd07ca5eb85"),
				Name = "ErrorMessage",
				CreatedInPackageId = new Guid("9cc3d920-8a68-437c-9367-c8131a0a7723"),
				CreatedInSchemaUId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47"),
				ModifiedInSchemaUId = new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6c1be4d-3981-4ba8-9ed8-474f0e090c47"));
		}

		#endregion

	}

	#endregion

}

