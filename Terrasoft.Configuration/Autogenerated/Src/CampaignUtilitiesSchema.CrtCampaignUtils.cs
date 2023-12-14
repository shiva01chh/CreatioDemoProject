﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignUtilitiesSchema

	/// <exclude/>
	public class CampaignUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignUtilitiesSchema(CampaignUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91f9be1e-5ab9-414b-864c-bdbff6a5ead5");
			Name = "CampaignUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,109,111,219,54,16,254,236,2,253,15,92,138,1,118,227,200,14,28,244,67,252,2,36,105,26,20,75,218,160,238,54,12,65,48,208,210,217,230,42,145,10,73,165,113,211,252,247,29,41,74,162,100,57,203,130,200,177,200,187,231,94,30,222,241,194,105,2,42,165,33,144,175,32,37,85,98,169,131,51,193,151,108,149,73,170,153,224,193,25,77,82,202,86,124,14,242,158,133,240,250,213,227,235,87,157,76,49,190,34,171,88,44,104,124,124,124,38,146,4,37,47,197,106,133,203,227,114,127,190,81,26,146,230,59,226,199,49,132,6,92,5,23,192,65,178,112,75,230,146,241,59,92,196,229,55,18,86,40,74,206,98,170,212,49,41,220,249,93,179,152,105,6,202,10,165,217,34,102,33,81,26,125,14,73,104,68,219,36,59,143,86,186,196,252,192,32,142,16,244,90,178,123,170,33,223,76,243,151,2,76,2,141,4,143,55,228,35,198,71,254,142,241,99,74,240,235,21,229,116,5,18,35,208,38,112,144,221,189,70,170,246,122,99,103,14,120,148,91,172,155,191,150,34,5,105,92,67,23,108,4,249,254,96,48,32,19,149,37,9,149,155,89,177,240,198,254,16,247,188,41,94,73,195,104,80,2,12,124,132,122,130,108,40,230,49,92,118,58,43,208,238,91,71,130,206,36,183,97,142,237,202,147,249,124,122,198,175,121,138,217,85,100,146,82,73,19,9,75,194,241,72,77,247,120,150,44,64,238,13,102,132,113,45,200,74,138,44,85,36,231,184,41,107,55,231,236,7,40,148,223,17,128,93,177,122,117,3,179,107,161,144,221,123,48,118,0,105,32,249,70,48,25,88,233,118,101,207,226,236,156,134,235,220,63,162,214,34,139,35,178,0,146,190,20,53,79,152,154,157,96,245,108,136,88,22,145,134,66,74,172,44,193,35,19,49,102,224,249,160,39,131,2,168,68,134,7,100,54,134,122,162,63,89,55,78,55,23,214,74,247,112,216,39,28,190,27,47,111,110,201,35,121,135,239,71,67,242,212,35,211,25,185,121,215,63,186,125,94,123,216,208,31,29,245,201,104,100,158,2,99,116,52,236,143,70,246,41,177,254,18,25,9,41,71,54,129,224,31,90,132,254,3,164,80,38,86,101,140,185,148,229,252,195,93,70,99,151,155,227,255,231,19,190,154,223,210,33,244,113,132,62,226,115,91,29,21,63,89,245,179,158,195,180,153,194,29,231,99,159,88,114,148,19,174,168,233,185,186,96,75,210,117,225,76,208,149,159,63,61,153,224,18,248,74,175,201,116,74,134,189,70,29,249,113,60,121,5,229,3,182,233,157,227,30,72,186,136,33,248,2,41,80,221,197,20,108,153,236,5,95,133,61,119,221,94,19,219,147,157,103,73,183,87,183,114,79,37,185,203,4,118,30,76,193,180,32,106,176,109,97,92,201,75,72,40,227,145,113,184,80,248,245,63,20,84,22,235,188,46,166,45,17,21,14,188,36,176,206,82,72,98,9,99,136,53,28,227,159,73,229,17,190,238,239,151,193,117,60,195,55,236,118,127,223,65,60,213,50,236,9,61,147,187,138,218,195,22,106,45,173,46,23,53,118,45,108,48,23,82,123,96,46,20,147,154,208,94,152,246,24,98,56,158,189,15,76,42,221,221,146,188,166,210,227,233,109,77,191,198,154,229,186,210,198,32,245,153,200,124,146,15,124,200,183,187,8,172,248,107,165,174,130,120,9,121,38,167,126,28,205,147,200,5,63,79,82,189,249,131,198,25,168,194,223,43,170,215,193,21,227,221,50,136,54,91,227,130,147,157,190,30,246,219,12,108,159,176,42,87,7,211,93,105,121,170,101,246,26,100,136,231,23,167,0,85,103,113,254,141,165,127,174,89,12,221,7,211,178,30,76,200,30,101,189,96,14,102,0,42,118,15,234,155,45,217,251,165,97,46,56,225,184,239,157,200,166,51,91,242,105,138,51,72,119,184,163,99,152,136,176,3,106,163,218,214,41,61,10,26,200,14,166,86,158,22,41,176,242,216,120,14,200,161,41,215,89,94,182,7,7,190,215,200,25,86,40,217,119,58,248,221,247,170,36,53,255,98,230,210,16,9,125,89,111,68,187,78,205,157,148,173,208,107,141,96,236,141,57,141,113,45,95,109,44,54,166,210,207,139,127,144,80,245,158,41,45,217,34,211,66,90,169,230,192,100,222,49,10,141,109,75,17,120,208,192,149,1,73,64,175,69,164,136,201,162,200,145,72,84,64,153,25,188,128,242,39,162,182,145,119,219,141,243,194,136,155,126,119,12,113,165,6,158,158,242,58,207,56,187,203,112,2,138,144,107,182,100,32,21,89,108,118,206,55,122,13,152,203,152,218,169,73,33,19,6,2,202,217,234,165,99,157,139,127,111,54,23,25,158,178,202,155,34,49,104,170,204,13,188,96,202,67,168,252,20,147,239,12,143,133,31,13,229,81,233,105,62,0,50,78,210,252,112,171,221,163,222,123,102,255,121,193,16,140,98,229,76,84,250,88,166,169,49,215,213,57,171,112,38,23,25,139,250,196,124,222,220,206,60,54,202,10,212,107,166,220,126,97,165,191,13,128,21,56,115,150,139,50,51,165,45,36,94,146,16,185,52,76,11,223,62,155,229,211,77,222,134,204,164,242,5,19,34,240,2,9,62,225,217,196,254,82,151,120,8,108,255,220,170,35,99,193,63,173,104,96,235,95,175,160,173,171,184,56,92,129,246,11,183,242,46,93,89,113,102,188,59,213,183,214,107,185,176,76,44,187,146,235,123,157,74,17,130,82,16,185,186,41,174,158,97,75,83,115,51,71,173,44,221,213,80,155,62,12,110,217,140,80,207,87,40,251,91,37,133,18,53,118,236,221,209,101,152,100,250,13,186,135,189,250,68,144,179,153,59,123,74,53,214,214,180,120,205,21,91,35,114,96,165,87,245,75,51,56,137,162,124,47,248,13,54,253,26,252,22,9,157,246,148,237,79,235,106,174,247,215,155,121,75,183,109,237,173,184,102,126,254,5,115,27,87,48,154,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91f9be1e-5ab9-414b-864c-bdbff6a5ead5"));
		}

		#endregion

	}

	#endregion

}

