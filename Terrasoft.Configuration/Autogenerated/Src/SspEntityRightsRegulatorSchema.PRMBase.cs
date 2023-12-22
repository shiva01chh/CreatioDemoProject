﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspEntityRightsRegulatorSchema

	/// <exclude/>
	public class SspEntityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspEntityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspEntityRightsRegulatorSchema(SspEntityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e98ae8a4-6d29-4f42-a417-d516acb01055");
			Name = "SspEntityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,109,111,219,54,16,254,236,2,253,15,156,7,100,10,224,200,73,11,100,203,242,2,36,177,19,24,88,27,47,78,187,143,1,35,157,45,1,18,233,145,148,61,175,200,127,47,95,36,89,148,40,199,105,147,98,203,135,54,34,143,119,207,221,61,119,60,134,224,20,248,28,7,128,238,128,49,204,233,84,248,151,148,76,227,89,198,176,136,41,121,251,230,203,219,55,157,140,199,100,134,38,43,46,32,61,46,191,171,71,210,148,18,247,14,131,182,117,219,82,171,212,224,66,110,201,205,159,25,204,164,28,186,76,48,231,191,163,9,159,15,137,136,197,234,54,158,69,130,223,194,44,75,176,160,76,203,246,251,125,116,194,179,52,197,108,117,150,127,235,115,61,180,140,226,32,66,49,71,41,38,120,6,8,180,18,196,32,160,44,68,76,43,243,11,21,253,138,142,121,246,144,196,1,10,148,154,13,214,59,95,52,130,18,238,85,12,73,40,241,142,89,188,192,2,204,230,220,124,72,171,56,164,36,89,161,235,44,14,209,61,101,51,76,226,127,117,60,100,180,207,195,52,38,159,72,44,70,33,58,69,4,150,90,204,235,14,174,142,222,15,46,47,142,246,14,47,6,191,238,13,174,14,14,246,142,46,222,157,239,237,239,31,12,14,247,135,71,239,127,187,60,236,238,30,59,13,125,226,192,100,220,9,4,202,8,186,207,172,111,247,25,46,152,202,203,189,9,213,36,136,32,197,31,37,115,142,115,79,129,132,198,217,220,57,19,168,182,16,121,53,8,54,130,94,97,173,110,108,23,41,38,118,58,53,196,50,48,14,23,58,13,172,82,206,1,191,211,121,180,179,245,1,68,68,91,211,245,64,105,130,238,216,234,26,196,205,146,0,147,46,42,103,70,161,167,243,71,213,218,40,236,33,154,9,180,94,153,76,198,70,170,112,193,94,149,200,148,172,63,76,231,98,101,208,79,32,145,206,32,174,255,251,51,3,182,202,243,111,54,188,90,12,118,245,161,252,71,22,77,146,165,196,235,142,194,174,189,113,197,104,234,117,63,47,37,234,146,89,53,145,191,34,96,224,117,165,106,129,3,161,52,248,35,62,252,59,195,137,103,212,170,154,229,194,203,61,221,181,79,159,19,73,206,42,111,239,86,115,104,192,112,42,188,192,28,244,111,220,87,81,105,42,177,77,117,48,207,99,97,2,86,137,148,63,252,7,130,76,192,68,146,40,129,91,93,214,39,42,192,103,158,34,52,48,116,122,102,84,153,79,95,38,211,64,249,140,147,12,114,81,29,61,147,200,90,14,141,65,6,34,99,164,182,135,126,106,164,242,177,149,64,50,11,55,149,114,47,56,52,199,76,52,88,100,201,149,44,178,86,95,142,69,46,2,109,230,78,65,155,49,101,2,39,231,65,64,51,226,36,207,24,51,89,119,2,152,87,186,89,230,245,73,246,184,137,179,161,103,22,170,127,36,87,236,76,217,92,177,243,181,29,87,70,252,35,64,120,71,7,64,86,50,176,192,185,161,137,76,99,89,164,189,156,37,73,88,46,21,28,201,77,87,165,149,225,170,40,218,217,177,191,159,7,236,154,97,34,94,15,89,125,127,51,178,5,149,214,52,162,15,234,114,151,89,53,119,143,65,198,45,118,228,216,204,165,176,198,85,43,10,57,125,76,36,69,152,148,25,18,169,16,252,9,136,97,229,34,49,164,185,149,244,40,172,253,1,11,72,188,154,49,195,162,198,173,212,43,237,247,144,67,107,169,206,63,79,18,186,148,21,162,157,203,121,245,109,80,135,97,44,126,52,84,87,154,20,163,95,47,75,87,148,5,48,144,149,46,96,19,88,183,239,45,39,110,230,96,70,85,95,165,187,215,156,135,214,33,218,54,67,175,11,83,165,250,127,0,211,40,222,2,232,163,123,222,108,206,110,122,0,53,155,245,151,128,94,208,188,3,158,79,251,136,78,145,136,202,151,192,148,50,213,134,16,38,186,153,89,125,251,23,94,92,208,126,169,188,95,215,126,50,87,215,28,34,210,131,211,110,225,65,247,108,20,170,223,167,177,188,85,108,131,203,136,114,40,176,44,227,36,65,15,128,130,8,147,25,132,254,73,95,107,115,43,151,240,198,197,69,234,50,144,99,85,22,140,98,249,202,129,120,1,122,179,112,158,84,176,108,54,39,163,178,149,57,17,97,97,236,37,21,207,218,13,229,15,134,69,204,132,188,223,77,123,48,41,50,220,169,206,73,213,86,177,110,72,197,205,51,94,79,79,197,205,83,46,21,189,35,158,34,207,117,123,217,199,237,147,59,59,249,16,210,54,187,213,14,183,76,110,5,132,142,235,142,178,101,27,69,250,216,0,95,153,9,190,11,123,85,188,138,61,9,111,90,224,59,122,119,67,218,237,192,227,139,85,229,242,191,82,132,249,91,200,165,59,48,163,203,11,214,223,205,211,198,94,188,250,148,201,13,101,87,190,122,75,214,44,183,170,183,245,107,185,114,164,70,214,218,43,187,229,129,157,191,204,54,87,215,90,240,121,165,245,45,48,75,201,90,57,185,192,182,212,210,83,112,245,63,173,165,164,35,192,215,127,219,194,197,95,182,144,160,154,7,213,102,243,252,42,50,196,64,113,201,193,205,188,85,247,66,100,104,155,55,154,182,163,5,23,203,57,222,106,253,210,141,13,60,44,173,84,137,215,214,243,74,225,45,154,245,75,61,9,106,13,62,103,208,119,14,218,142,230,90,155,143,204,170,189,168,215,170,63,95,1,131,249,166,150,9,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e98ae8a4-6d29-4f42-a417-d516acb01055"));
		}

		#endregion

	}

	#endregion

}

