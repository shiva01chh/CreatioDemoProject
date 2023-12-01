namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class AddCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignAudienceElementHandlerSchema(AddCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4");
			Name = "AddCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,91,111,211,72,20,126,14,18,255,225,16,94,28,41,114,180,111,136,38,145,10,155,208,74,129,34,90,232,3,218,135,169,125,146,140,214,158,201,206,140,67,3,234,127,231,204,205,177,221,36,5,180,121,203,185,126,243,157,155,5,43,81,111,88,134,112,131,74,49,45,151,38,125,43,197,146,175,42,197,12,151,226,249,179,31,207,159,245,42,205,197,10,174,119,218,96,73,250,162,192,204,42,117,250,14,5,42,158,157,117,109,22,92,252,247,72,120,131,247,102,47,108,38,84,152,158,27,163,248,93,101,80,31,53,121,203,202,13,227,43,241,164,65,58,219,162,48,23,76,228,5,170,189,181,181,137,38,215,217,26,75,6,19,104,59,182,213,228,74,206,163,209,8,198,186,42,75,166,118,211,240,159,56,50,140,11,13,37,154,181,204,53,44,165,130,146,36,86,106,115,157,231,57,156,87,57,71,65,220,98,129,37,1,210,192,5,100,49,85,140,60,106,132,222,84,119,5,207,64,35,43,48,135,172,96,90,219,72,17,85,12,56,243,241,194,3,225,53,188,97,26,79,27,13,225,242,74,68,147,47,172,224,57,51,72,25,127,184,39,246,94,42,92,81,65,237,187,180,81,85,102,164,210,175,225,163,131,227,45,2,180,39,209,36,3,176,29,211,235,97,75,252,129,26,141,216,126,135,230,102,183,193,100,144,90,129,45,77,239,33,32,64,145,123,16,109,68,239,61,193,4,70,241,173,195,236,208,248,63,176,149,60,135,91,197,13,206,121,97,80,133,151,145,227,165,88,202,228,4,47,177,40,17,238,150,81,1,81,107,182,10,56,23,217,247,107,106,73,177,162,152,21,38,143,159,51,132,190,79,122,203,205,250,131,36,234,114,110,51,223,50,101,91,160,63,56,171,3,111,91,176,222,215,105,180,75,144,206,165,42,153,73,66,250,97,132,70,221,184,177,62,33,80,187,55,83,170,68,231,181,7,179,12,161,83,245,160,94,224,22,139,52,96,29,52,43,209,226,54,182,202,92,22,57,42,157,92,206,68,85,162,98,119,5,142,79,176,59,173,123,62,242,203,151,144,188,136,194,244,92,236,146,65,84,245,20,154,74,9,255,202,135,154,180,165,79,73,52,45,36,203,3,0,247,208,58,118,32,102,141,217,191,65,63,187,231,180,107,132,174,11,166,135,49,80,163,30,65,226,11,231,139,72,105,230,92,196,52,77,77,210,246,247,53,251,131,94,113,81,78,247,138,235,228,78,85,31,189,163,137,109,8,229,255,91,102,23,181,93,230,198,200,127,100,202,240,140,111,152,48,71,11,77,155,16,89,182,134,196,18,29,148,118,241,117,237,92,33,104,211,169,108,253,55,51,118,21,207,68,38,115,59,15,159,111,230,175,232,180,152,55,59,58,7,145,128,212,99,11,76,121,111,55,9,97,181,68,51,242,171,155,81,24,110,118,126,94,28,151,159,53,42,226,94,248,243,53,72,247,1,206,14,97,186,96,122,223,28,142,252,11,44,54,168,82,215,113,215,143,237,146,125,192,97,35,206,16,58,137,67,54,55,19,7,210,213,20,245,142,175,182,184,190,66,168,135,253,240,252,250,66,149,134,240,96,238,245,221,51,231,4,159,220,100,106,48,107,132,130,38,11,228,146,140,16,33,83,184,156,244,79,182,70,127,52,173,175,29,176,238,45,76,235,156,163,110,210,241,134,41,86,130,32,22,39,125,207,104,127,26,243,132,162,83,71,105,195,40,96,58,30,57,243,189,183,223,38,122,186,8,120,51,41,8,45,117,250,9,48,227,81,244,242,163,17,152,1,185,165,47,12,158,35,252,242,222,107,182,95,136,158,28,248,240,240,175,136,133,246,201,131,48,157,23,242,91,244,77,175,150,246,96,62,49,132,201,224,247,78,105,227,174,31,44,123,92,7,250,200,119,140,220,127,199,52,110,91,10,126,36,80,215,187,251,27,237,42,16,210,214,192,47,188,99,117,255,122,165,200,33,249,107,240,79,227,99,195,173,166,171,250,115,37,105,222,234,26,203,228,48,229,45,186,7,191,69,227,31,220,170,104,108,119,243,188,190,91,117,136,219,53,42,76,238,97,50,133,23,247,233,126,206,125,152,238,141,61,16,172,113,187,90,90,191,174,143,164,58,145,41,172,249,3,177,78,117,18,73,157,130,126,63,1,145,179,185,25,57,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderWithNoConditionWarningLocalizableString());
			LocalizableStrings.Add(CreateFolderNotFoundErrorLocalizableString());
			LocalizableStrings.Add(CreateFilterWithNoConditionWarningLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7244310a-84bf-404b-baa6-2bae953fbbc1"),
				Name = "FolderWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFolderNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f6c3f61f-5296-4d52-bc90-ce76168b921f"),
				Name = "FolderNotFoundError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFilterWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b77bcf38-2f18-445a-8f83-e2935ae6e184"),
				Name = "FilterWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"));
		}

		#endregion

	}

	#endregion

}

