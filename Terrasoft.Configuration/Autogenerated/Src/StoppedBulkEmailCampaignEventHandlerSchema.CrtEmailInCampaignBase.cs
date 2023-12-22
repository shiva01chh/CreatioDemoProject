namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StoppedBulkEmailCampaignEventHandlerSchema

	/// <exclude/>
	public class StoppedBulkEmailCampaignEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StoppedBulkEmailCampaignEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StoppedBulkEmailCampaignEventHandlerSchema(StoppedBulkEmailCampaignEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d");
			Name = "StoppedBulkEmailCampaignEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,77,79,219,64,16,189,35,241,31,166,225,98,75,209,166,103,2,145,8,13,96,9,20,164,208,114,168,122,216,120,39,201,10,123,237,238,174,3,41,244,191,119,252,137,157,77,2,82,125,137,178,243,177,239,205,204,155,85,60,70,147,242,16,225,1,181,230,38,89,88,118,153,168,133,92,102,154,91,153,168,227,163,215,227,35,160,47,51,82,45,97,182,49,22,227,161,123,68,81,81,132,97,30,98,216,53,42,212,50,220,229,118,43,213,239,206,121,251,222,56,78,212,94,163,70,118,201,227,148,203,229,167,124,216,100,141,202,222,112,37,34,212,135,2,190,141,59,214,252,172,206,49,11,87,24,115,56,135,110,230,174,153,162,203,248,19,141,75,162,15,151,17,55,230,20,102,54,73,83,20,227,44,122,154,196,92,70,117,84,27,87,29,154,102,243,72,134,96,144,71,40,32,204,19,124,42,30,78,97,215,241,152,27,236,67,48,85,181,241,7,143,164,224,22,251,229,117,249,215,178,142,113,65,252,102,124,141,165,249,181,134,213,102,117,135,118,149,8,226,117,175,229,154,82,181,125,210,242,8,230,73,18,193,53,18,12,83,64,126,148,118,53,179,220,102,198,187,206,164,248,249,11,230,53,155,242,56,16,4,115,162,178,24,53,159,71,120,150,123,141,0,115,135,64,24,31,94,223,239,200,63,185,0,239,203,119,131,154,70,84,149,195,70,179,102,3,115,133,148,77,227,68,229,89,132,215,27,191,95,147,164,61,31,222,222,154,164,44,32,108,169,221,120,190,147,62,255,52,82,34,5,11,30,25,28,118,205,127,187,127,215,92,83,195,242,153,167,1,81,248,12,179,226,143,215,197,231,211,144,101,202,122,138,132,150,44,188,6,24,11,132,239,179,43,157,196,142,201,247,93,88,236,113,133,26,247,100,9,148,71,234,203,98,197,238,185,38,15,139,218,120,77,17,119,101,187,80,194,205,85,183,100,95,70,167,119,84,65,110,42,218,67,183,56,5,2,83,208,167,10,149,165,98,147,23,12,51,139,179,144,71,92,159,73,101,71,158,191,21,91,181,160,29,62,130,175,45,167,86,35,220,25,116,199,137,38,164,33,73,5,241,118,40,220,20,63,206,64,84,72,74,43,187,138,146,231,73,132,49,233,204,176,233,226,97,147,226,217,29,215,79,104,105,111,20,217,43,43,81,98,213,48,188,192,249,8,94,88,215,141,42,215,101,227,178,88,39,82,64,173,218,106,19,20,177,158,3,178,41,53,113,163,58,59,108,59,76,183,107,157,7,175,28,181,150,105,118,168,152,198,156,68,188,67,54,119,228,71,244,104,238,13,21,103,220,157,148,27,174,69,197,33,23,252,65,223,177,70,254,68,214,64,108,137,175,255,190,22,134,59,182,130,75,226,128,188,63,22,54,189,138,134,47,177,44,196,109,248,103,102,53,129,162,134,100,141,8,63,179,159,253,190,11,161,215,110,231,84,17,88,157,79,70,29,222,219,166,215,109,32,187,16,162,154,11,218,46,129,90,36,94,133,181,15,91,219,190,178,223,226,26,35,246,200,181,162,91,246,14,222,9,42,81,110,250,195,203,191,120,168,218,46,131,193,0,206,76,22,199,92,111,70,221,227,178,8,6,56,137,57,47,10,216,21,183,32,13,104,46,13,189,115,243,226,221,129,176,130,93,233,12,12,61,68,130,109,221,48,112,175,168,30,205,66,42,211,214,35,230,74,100,183,144,246,149,162,195,232,35,14,84,156,6,255,186,169,123,77,205,228,205,101,31,131,175,1,254,47,116,183,139,141,185,107,42,142,219,223,63,146,27,70,69,9,10,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateStoppedEmailOnStartingCampaignLocalizableString());
			LocalizableStrings.Add(CreateActiveEmailsOnStoppedCampaignMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateStoppedEmailOnStartingCampaignLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("648f590e-70c3-a25b-fff8-a0b67cd53c49"),
				Name = "StoppedEmailOnStartingCampaign",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"),
				ModifiedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateActiveEmailsOnStoppedCampaignMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("aa1b197a-4713-f78b-4c1e-2b5e403d60c6"),
				Name = "ActiveEmailsOnStoppedCampaignMessage",
				CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb"),
				CreatedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"),
				ModifiedInSchemaUId = new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("750ec918-cad6-4585-94ac-d3ec62f1b68d"));
		}

		#endregion

	}

	#endregion

}

