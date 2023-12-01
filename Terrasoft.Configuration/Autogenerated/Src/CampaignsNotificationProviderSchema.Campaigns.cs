﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignsNotificationProviderSchema

	/// <exclude/>
	public class CampaignsNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignsNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignsNotificationProviderSchema(CampaignsNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1154c473-4560-40b2-8b51-051821ed0959");
			Name = "CampaignsNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("778edd87-bcdc-4892-9faf-df9d3be5dfc9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,118,129,254,15,156,10,20,54,22,200,219,107,156,26,112,147,52,240,150,54,65,236,108,15,109,81,48,210,57,225,166,175,145,84,6,175,232,255,190,227,151,76,202,146,236,62,108,125,104,76,242,126,247,125,199,163,10,154,131,168,104,2,100,13,156,83,81,110,100,124,94,22,27,246,88,115,42,89,89,188,124,241,245,229,139,81,45,88,241,24,144,112,136,47,222,206,154,163,213,86,72,200,113,63,203,32,81,56,17,95,65,1,156,37,179,30,120,27,139,107,220,121,197,225,17,209,228,60,163,66,156,146,115,154,87,148,61,22,226,67,41,217,134,37,90,165,91,94,62,179,20,184,6,76,167,83,114,38,234,60,167,124,59,183,107,135,34,133,135,34,149,133,197,14,53,245,96,85,253,144,177,132,36,74,236,176,84,114,74,222,82,1,93,71,39,100,217,173,231,72,249,176,177,237,29,131,44,69,227,110,57,123,166,18,180,25,163,202,44,72,130,174,147,68,72,174,60,115,117,119,115,127,251,229,195,226,253,37,121,67,34,159,119,52,235,5,57,242,198,138,200,184,118,244,10,138,212,168,96,215,206,215,10,205,235,68,150,92,105,165,61,97,149,50,94,25,244,199,248,94,0,71,22,133,137,59,169,131,229,68,177,25,157,146,7,116,217,184,117,68,180,87,190,125,135,168,11,166,145,24,179,51,99,236,9,41,31,254,64,118,115,82,81,142,169,44,129,139,64,164,183,29,136,235,243,5,138,170,128,75,6,45,79,180,211,76,111,92,241,178,174,72,129,2,226,134,198,79,42,103,148,139,166,38,215,90,140,30,65,218,95,35,14,178,230,133,23,107,29,90,165,104,163,109,167,244,38,33,143,86,224,3,18,246,202,239,150,220,231,167,247,32,159,74,147,196,165,196,0,64,234,210,216,46,73,249,140,229,142,250,145,231,146,165,100,145,166,216,27,234,188,16,227,21,168,22,65,132,254,99,163,50,50,43,163,80,108,40,199,209,29,228,172,72,81,243,232,132,68,203,52,154,196,11,49,214,63,134,8,205,98,205,114,176,0,127,99,8,136,169,41,105,34,27,65,205,161,119,48,132,191,0,145,112,86,233,242,52,28,130,157,22,212,101,122,96,155,219,236,16,229,211,171,64,90,196,154,201,108,223,46,108,169,171,228,9,114,218,162,190,44,36,147,91,115,100,182,91,64,191,236,196,10,164,68,219,132,98,130,28,151,57,125,132,93,24,220,106,230,87,113,79,248,127,41,89,177,166,15,25,28,19,254,107,216,200,155,26,107,86,161,180,45,139,20,221,124,95,48,137,178,111,134,194,182,20,151,127,213,52,107,129,66,34,43,101,137,125,200,74,104,92,219,193,125,85,235,6,19,114,111,199,174,87,113,27,132,46,190,91,225,7,99,79,251,93,248,238,251,37,116,71,203,18,143,190,83,232,80,232,125,212,253,177,65,215,53,143,178,53,195,238,184,171,30,29,135,116,150,96,230,229,69,188,40,210,150,37,190,178,235,109,5,126,96,173,65,38,165,227,91,119,3,140,253,122,22,82,196,109,30,205,249,50,157,28,50,48,184,232,151,197,166,36,87,32,239,32,41,121,218,62,25,27,189,58,238,46,243,119,78,210,230,200,232,252,27,205,106,112,23,214,232,170,70,95,50,83,109,179,102,39,94,243,45,154,134,87,92,55,250,99,83,160,159,241,146,172,165,227,96,29,107,155,126,1,127,147,61,125,157,224,145,238,45,56,74,244,73,48,189,231,243,137,161,126,91,166,219,1,98,191,23,58,136,85,17,81,86,59,187,111,210,77,31,40,13,149,189,189,102,122,45,243,243,36,192,239,218,220,128,90,123,29,209,233,246,30,132,112,218,29,84,194,23,238,183,158,99,176,62,189,207,71,143,11,86,123,253,219,92,206,126,98,30,190,157,15,141,48,139,170,2,157,243,122,138,32,229,6,103,73,125,77,147,77,201,73,194,129,170,54,224,121,79,145,200,39,172,112,173,125,207,216,161,119,244,232,165,217,190,137,44,211,104,190,64,21,0,20,227,205,155,232,154,9,121,182,158,35,22,96,30,77,231,78,118,124,54,213,96,127,132,9,91,11,182,39,55,78,104,38,174,146,44,3,151,193,142,31,118,24,51,55,204,246,183,189,155,161,227,212,159,29,58,142,237,237,112,78,237,29,223,79,210,195,63,152,16,252,208,118,70,235,78,87,173,208,1,224,186,217,224,31,81,103,242,216,56,116,231,96,43,44,253,157,42,114,30,54,225,15,226,164,101,153,182,34,66,126,43,201,177,105,207,145,218,29,119,197,213,13,201,174,141,222,105,195,186,70,254,227,218,166,229,39,15,244,176,160,45,205,124,36,75,7,96,170,80,3,106,222,36,202,0,202,203,166,16,253,48,220,59,91,105,22,98,133,75,176,195,12,118,90,63,83,78,254,4,37,19,205,252,145,68,95,34,252,127,103,195,142,168,42,43,124,180,152,54,118,171,126,95,80,73,247,175,8,237,230,240,34,80,54,237,247,243,70,219,254,86,189,27,175,188,142,167,149,193,247,35,163,25,251,7,110,173,86,90,187,120,229,182,199,225,237,102,28,20,191,43,121,78,229,56,250,20,125,253,233,219,167,232,148,124,253,249,27,206,16,104,254,73,139,227,241,21,232,167,183,158,81,34,213,24,65,27,19,79,231,3,229,216,93,34,134,7,182,64,134,163,9,45,18,56,80,45,118,154,194,106,209,14,196,247,170,217,105,34,99,9,32,56,85,113,172,179,204,56,137,109,136,247,60,38,63,152,51,242,250,181,247,150,142,117,119,68,157,126,133,237,56,18,225,77,53,25,162,77,107,192,76,193,174,217,164,138,158,99,66,22,168,207,88,109,79,118,92,62,182,165,216,132,29,41,110,186,188,82,245,197,3,129,110,35,0,59,177,14,181,111,63,230,177,117,213,125,199,151,138,161,215,231,32,193,17,175,206,35,159,157,123,79,149,30,156,255,50,81,56,111,61,136,59,234,153,58,44,179,185,239,28,241,5,94,194,172,80,233,231,118,222,241,50,247,193,205,193,255,242,186,251,47,158,119,163,248,247,39,224,16,70,22,65,215,56,40,222,240,158,55,135,74,214,120,93,162,162,88,185,130,102,10,53,158,76,26,150,250,101,179,20,119,64,125,13,246,216,108,104,38,160,133,106,59,97,57,200,33,172,42,172,74,42,108,29,120,31,125,92,227,12,171,230,232,166,232,127,110,29,154,72,92,99,243,95,30,221,253,110,121,89,212,57,112,245,229,224,108,239,201,53,87,237,47,120,181,54,221,207,125,83,107,157,43,148,24,79,250,70,104,187,231,111,233,29,252,247,47,129,38,18,75,40,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1154c473-4560-40b2-8b51-051821ed0959"));
		}

		#endregion

	}

	#endregion

}
