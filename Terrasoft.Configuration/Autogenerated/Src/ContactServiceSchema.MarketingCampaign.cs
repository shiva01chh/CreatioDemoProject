namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactServiceSchema

	/// <exclude/>
	public class ContactServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactServiceSchema(ContactServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a");
			Name = "ContactService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,77,111,218,64,16,61,59,82,254,195,136,92,64,66,230,158,4,34,130,26,149,74,36,81,0,229,128,170,106,177,199,100,213,253,112,118,214,84,168,234,127,239,236,218,16,130,92,202,201,251,102,230,237,155,183,51,24,161,145,74,145,33,44,208,57,65,182,240,233,196,154,66,110,42,39,188,180,230,242,226,247,229,69,82,145,52,27,152,239,200,163,78,231,232,182,50,195,153,205,81,221,156,11,166,227,204,203,109,164,57,159,247,138,235,143,132,15,33,12,179,24,173,99,57,199,175,28,110,152,11,38,74,16,93,3,235,244,34,243,13,83,204,88,53,135,16,114,28,251,30,176,49,149,143,232,153,168,100,41,107,169,164,223,189,224,123,37,29,106,52,158,186,199,135,160,7,134,240,159,146,144,149,54,64,222,11,151,148,213,90,201,12,178,160,236,68,24,92,195,189,32,60,200,76,130,161,135,94,158,157,45,209,121,137,220,208,115,36,137,141,36,165,11,206,225,9,215,87,84,156,13,63,178,22,180,246,40,25,12,6,112,75,149,214,194,237,70,123,96,106,200,11,195,90,108,209,202,152,30,42,7,199,165,77,87,173,26,90,193,216,90,178,65,15,195,81,187,74,184,187,131,110,123,100,8,6,127,181,242,118,151,132,142,3,6,179,48,76,189,222,77,188,135,206,221,51,132,173,80,21,198,204,63,181,53,87,104,242,218,246,230,220,188,193,12,253,155,205,79,30,160,213,199,23,212,118,139,4,133,18,27,120,180,134,7,188,18,10,10,103,245,94,56,8,147,31,190,195,244,86,70,102,113,7,254,97,114,68,74,225,132,6,195,219,56,236,20,82,121,116,212,25,61,212,31,224,45,16,42,140,124,145,55,189,29,196,130,246,122,158,80,158,215,121,246,134,90,44,167,121,103,84,127,2,11,121,175,16,100,30,18,10,201,175,126,76,179,122,98,215,162,206,227,229,73,86,188,132,83,179,181,63,177,91,219,196,198,118,158,159,230,139,78,31,150,78,46,80,151,42,204,41,163,115,244,181,31,95,180,144,138,56,225,222,230,187,185,223,169,16,102,158,25,18,137,13,30,208,244,213,137,178,196,188,31,95,51,236,19,146,127,176,78,11,255,169,160,134,210,111,100,77,159,159,128,74,107,8,207,231,197,165,220,207,239,214,202,28,78,212,117,201,187,240,111,211,152,221,135,230,124,98,94,175,25,233,214,165,89,150,57,183,222,132,198,180,51,217,196,58,236,30,40,79,185,234,89,76,146,214,105,172,103,244,24,140,72,248,253,5,129,137,235,139,165,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingUpdateMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingUpdateMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dcc3279a-ae13-4ada-8127-1557b79bc092"),
				Name = "RemindingUpdateMessage",
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc"),
				CreatedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"),
				ModifiedInSchemaUId = new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("892cbfbe-997b-4ab9-8be0-cc1b1284bb2a"));
		}

		#endregion

	}

	#endregion

}

