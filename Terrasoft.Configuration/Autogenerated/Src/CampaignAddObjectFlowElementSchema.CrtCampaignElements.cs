﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAddObjectFlowElementSchema

	/// <exclude/>
	public class CampaignAddObjectFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAddObjectFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAddObjectFlowElementSchema(CampaignAddObjectFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e915065-b5c6-459b-95b6-ef0f890a7489");
			Name = "CampaignAddObjectFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("279db9e2-5b1e-4ae7-af81-571fcca6f075");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,91,111,219,54,20,126,118,129,254,7,174,221,131,12,24,114,159,151,11,144,56,118,17,172,73,179,186,221,30,134,61,208,210,145,205,141,34,85,146,114,98,4,249,239,59,188,72,162,36,59,24,134,230,41,164,206,229,59,23,126,231,88,208,18,116,69,51,32,95,65,41,170,101,97,210,133,20,5,219,214,138,26,38,197,219,55,207,111,223,76,106,205,196,150,172,15,218,64,121,214,158,99,21,5,233,130,150,21,101,91,113,82,224,230,250,228,167,165,48,204,48,208,40,128,34,239,21,108,209,55,89,112,170,245,47,164,49,124,149,231,159,55,127,67,102,86,92,62,46,57,148,32,140,147,159,207,231,228,92,215,101,73,213,225,50,156,151,79,144,213,134,110,56,16,154,231,68,58,69,2,94,139,80,67,178,96,53,109,12,204,35,11,85,189,225,44,35,153,5,240,170,127,210,193,187,166,26,22,170,62,134,113,242,236,112,182,129,221,129,217,201,28,67,123,80,108,79,13,248,175,149,63,16,151,140,3,249,8,230,30,30,253,33,153,18,91,135,201,100,79,21,1,119,181,206,118,80,82,114,65,190,105,80,88,51,129,78,209,182,79,101,248,122,71,5,221,130,74,209,212,173,208,134,138,12,174,15,247,88,243,196,75,217,127,167,103,173,97,209,184,67,171,177,147,116,161,0,129,5,40,125,127,65,189,85,77,215,96,110,160,88,72,94,151,226,119,202,107,208,201,72,6,77,92,229,37,19,95,216,118,103,52,122,43,40,215,224,165,20,152,90,137,14,139,187,125,233,103,104,47,89,78,86,140,115,196,97,104,102,34,111,137,130,162,201,160,143,97,70,180,81,182,231,178,88,216,134,62,35,31,107,52,20,238,111,243,56,201,153,147,106,19,145,54,153,112,215,58,93,49,145,135,84,142,204,134,112,161,205,71,12,207,219,157,69,78,143,5,184,145,146,19,159,245,174,7,22,101,213,52,225,146,247,66,68,31,6,35,212,195,128,194,185,162,202,176,140,85,84,12,130,140,11,222,111,55,31,194,43,41,110,85,103,3,12,105,79,225,129,154,221,40,88,103,215,107,135,124,38,145,185,8,253,200,178,19,30,221,127,1,91,225,204,64,30,36,130,27,163,14,33,216,81,87,165,107,186,135,196,181,93,16,126,65,70,48,217,142,36,203,167,12,42,219,218,4,158,154,100,77,154,71,254,73,110,237,131,90,42,37,213,74,170,146,154,68,96,201,101,145,188,198,18,83,132,252,52,139,189,187,110,114,61,232,237,79,126,126,247,16,87,9,11,242,220,43,219,203,187,6,103,252,74,186,119,51,104,160,99,189,130,21,94,246,18,183,82,178,252,36,229,63,117,213,227,23,238,174,150,250,59,130,64,200,36,102,148,223,106,80,67,10,56,70,57,24,108,72,203,24,200,180,205,234,113,30,8,41,185,221,10,28,13,55,76,87,156,30,60,147,160,132,81,53,248,60,248,116,180,96,83,116,114,197,185,71,209,180,149,149,142,8,174,96,220,128,66,43,157,150,127,100,43,247,225,15,102,118,88,5,4,142,7,157,248,203,133,196,186,42,166,165,248,122,168,112,82,125,175,41,15,8,79,135,152,70,252,58,35,35,178,237,220,123,31,218,130,79,60,186,8,46,132,169,216,3,220,86,17,99,228,190,0,199,41,153,21,36,105,44,224,211,169,113,88,93,92,144,15,109,242,173,7,156,254,26,203,133,14,60,71,166,161,167,251,125,114,47,205,10,245,243,246,101,220,121,181,35,145,77,204,78,201,71,223,54,141,116,18,188,28,107,96,43,120,36,127,195,136,26,204,157,191,134,153,49,184,63,63,252,101,179,98,203,147,71,52,117,238,67,186,76,254,91,153,166,161,168,35,250,234,123,10,207,245,255,58,28,89,143,252,186,150,253,49,113,53,60,216,24,31,49,228,15,13,106,204,191,211,232,137,6,102,122,15,34,247,235,207,201,93,72,26,176,70,252,247,225,82,23,109,117,248,34,178,90,41,187,126,21,72,178,237,86,199,144,16,21,221,218,255,211,214,196,124,104,227,220,183,158,190,244,111,66,22,241,124,212,228,113,199,112,10,236,168,38,27,0,65,42,37,51,108,95,200,211,243,121,163,232,137,54,160,37,114,143,187,44,203,1,221,27,178,10,254,3,208,99,123,91,120,84,126,228,158,38,228,142,6,104,157,51,112,171,91,232,30,175,122,21,174,195,101,187,102,21,200,154,212,14,50,191,198,120,13,76,205,200,76,143,9,170,193,244,9,138,233,175,112,56,235,164,218,217,28,73,184,54,137,100,152,14,252,228,152,213,74,14,23,153,225,210,18,77,252,254,170,18,172,90,38,251,105,96,182,5,63,249,86,229,120,129,188,29,244,214,134,154,90,39,61,75,179,118,75,199,216,237,34,108,116,251,123,37,154,187,110,172,123,253,206,251,203,152,181,16,250,45,254,20,178,163,129,227,172,200,147,100,13,150,139,167,81,89,252,164,156,78,95,121,3,254,182,127,137,119,248,247,47,73,240,122,197,152,13,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEntitySettingsNotFoundLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEntitySettingsNotFoundLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c85cecc2-5bdc-4ee4-adb7-91414bf90d85"),
				Name = "EntitySettingsNotFound",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("7e915065-b5c6-459b-95b6-ef0f890a7489"),
				ModifiedInSchemaUId = new Guid("7e915065-b5c6-459b-95b6-ef0f890a7489")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e915065-b5c6-459b-95b6-ef0f890a7489"));
		}

		#endregion

	}

	#endregion

}

