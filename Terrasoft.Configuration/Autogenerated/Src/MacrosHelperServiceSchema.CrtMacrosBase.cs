﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosHelperServiceSchema

	/// <exclude/>
	public class MacrosHelperServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosHelperServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosHelperServiceSchema(MacrosHelperServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f11c38bc-163a-4783-b903-5b016339927b");
			Name = "MacrosHelperService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,25,219,110,219,54,244,217,5,250,15,132,246,34,3,134,3,236,49,137,93,180,169,211,121,75,154,32,73,155,135,96,24,104,233,216,225,70,93,70,82,105,221,32,255,190,195,139,36,202,150,229,203,134,162,203,75,164,195,115,191,83,78,105,2,50,167,17,144,59,16,130,202,108,174,134,103,89,58,103,139,66,80,197,178,244,245,171,231,215,175,122,133,100,233,130,220,46,165,130,228,100,229,125,120,11,226,137,69,112,153,197,192,59,15,135,247,48,235,70,120,27,41,246,100,228,174,225,221,20,169,98,9,104,124,70,57,251,214,142,117,150,113,14,145,62,146,195,15,144,34,110,84,227,248,38,38,137,79,237,159,8,216,4,31,78,80,5,197,64,182,35,120,94,27,126,82,140,183,162,161,11,58,164,215,167,165,95,110,178,66,33,14,34,35,250,79,2,22,200,157,156,113,42,229,49,185,164,145,200,228,47,192,115,16,14,221,160,61,184,23,84,73,9,26,169,223,53,236,61,204,105,193,149,199,22,12,252,86,230,107,176,183,50,255,8,10,21,201,209,154,25,227,76,45,111,224,239,130,9,72,32,85,50,244,95,116,224,200,136,108,33,209,88,67,7,136,251,90,72,94,204,56,139,72,164,77,105,179,132,28,147,119,84,66,101,87,239,217,216,86,249,224,156,1,143,209,9,215,66,103,140,53,188,119,116,116,68,78,101,145,36,84,44,199,37,96,154,74,69,83,228,152,205,241,16,128,68,2,230,163,192,151,249,249,231,224,104,76,212,50,135,97,197,230,200,231,147,91,41,68,0,141,179,148,47,73,147,154,252,145,120,239,39,78,83,72,99,171,108,83,115,12,139,84,162,136,84,38,180,254,198,15,29,234,159,161,76,5,146,176,237,102,56,103,109,179,197,122,190,133,48,236,19,93,237,189,94,195,28,140,110,10,95,200,7,158,205,40,247,169,194,190,206,225,222,203,247,84,222,64,114,42,104,66,82,236,93,163,192,215,52,24,91,134,228,209,188,14,79,143,12,102,59,97,33,65,96,40,82,219,46,130,241,39,124,39,81,5,104,16,119,184,108,37,17,124,117,6,228,83,67,6,105,138,220,228,236,149,84,66,140,21,54,163,21,70,126,20,54,37,221,181,200,144,157,110,94,187,149,12,246,57,221,101,49,116,58,246,155,194,119,65,211,133,238,50,88,226,231,84,39,244,18,195,215,93,65,45,52,88,61,124,13,120,226,251,189,133,166,13,102,253,185,0,69,70,227,86,166,228,205,27,18,182,30,216,28,111,97,26,54,157,223,183,57,223,147,29,66,70,228,137,242,2,234,176,116,5,230,18,212,99,102,27,89,166,80,6,196,246,252,225,106,38,51,14,10,194,192,162,16,38,73,12,185,128,8,221,24,15,116,14,152,184,96,71,90,233,70,56,249,148,133,188,21,139,194,244,223,97,96,154,46,70,193,9,33,79,76,168,130,114,242,158,25,187,48,76,167,31,10,134,124,175,102,127,34,198,152,172,51,9,177,109,233,121,5,122,12,46,63,98,21,13,136,166,193,174,24,101,34,158,198,3,227,154,222,5,147,234,212,210,78,211,121,54,118,25,173,159,101,153,244,2,84,33,210,102,223,108,209,59,244,101,85,98,26,12,253,236,255,55,78,155,202,179,66,8,148,167,3,110,207,38,95,209,146,14,223,205,178,140,147,141,116,225,193,126,216,204,114,147,225,173,85,140,238,148,4,181,142,64,74,212,26,247,163,156,163,27,118,237,172,37,254,187,44,94,6,227,59,247,134,70,199,203,238,206,90,18,222,22,38,149,60,90,105,33,221,228,54,228,183,209,35,36,84,7,62,24,155,189,107,73,164,1,25,172,93,56,76,227,138,210,102,14,97,177,62,153,179,109,163,65,215,116,65,23,160,57,92,184,231,78,98,27,69,57,190,94,115,54,62,124,69,123,59,71,222,13,174,224,184,19,232,209,119,122,84,178,106,102,92,7,149,14,115,249,124,207,212,227,13,160,224,8,98,67,130,218,148,85,235,135,211,22,234,202,129,11,215,128,52,202,188,142,131,43,246,210,185,238,181,246,21,246,189,216,46,153,161,62,233,151,41,222,165,187,40,31,92,255,221,140,234,150,141,94,89,14,216,112,99,136,235,177,70,96,29,132,76,11,206,45,157,170,230,67,143,205,245,16,240,135,46,118,137,245,245,134,44,214,64,165,73,150,71,109,58,86,236,199,76,77,146,92,45,195,126,141,212,107,215,169,50,180,197,138,103,114,225,59,212,243,238,203,137,227,250,226,254,151,190,27,222,161,152,170,196,70,45,106,235,198,234,35,133,141,92,88,15,116,165,126,21,234,117,67,250,39,171,106,184,252,57,76,147,42,249,254,51,101,34,93,137,168,4,174,218,224,54,114,244,29,1,142,217,246,188,197,133,107,99,105,31,239,85,21,178,139,139,118,147,180,217,59,157,194,86,92,80,39,207,11,193,121,24,61,146,112,242,53,130,220,44,149,80,165,109,197,160,62,28,145,146,190,133,251,156,162,75,237,241,139,63,211,74,212,93,214,211,122,11,218,118,29,186,177,253,177,217,96,201,151,71,16,224,230,43,86,145,112,61,144,204,150,68,61,2,19,118,35,147,187,142,62,129,55,85,144,56,185,202,203,168,3,108,238,252,85,71,195,27,132,162,184,98,104,243,177,21,90,245,112,109,174,166,111,179,197,63,92,97,220,205,55,3,255,182,222,123,184,135,217,52,125,202,254,194,11,134,93,100,70,36,184,190,186,189,11,240,82,33,152,151,64,129,201,25,251,138,135,58,39,111,213,146,235,35,228,113,137,33,194,246,81,65,135,247,130,230,57,184,77,237,198,90,117,158,137,132,170,6,129,5,13,127,149,89,58,32,165,109,221,120,110,73,218,120,83,242,231,85,149,224,173,120,70,169,210,229,101,90,62,81,97,124,233,153,94,6,197,47,25,221,137,177,231,95,9,215,140,201,27,55,206,134,6,64,142,91,169,78,252,188,221,54,79,125,45,6,13,238,131,138,249,164,177,182,250,176,178,82,187,22,183,50,199,19,76,32,198,153,30,1,252,199,79,248,134,182,223,49,251,47,181,220,114,106,250,81,253,223,148,195,70,11,246,168,143,169,187,132,254,198,148,9,137,123,28,181,221,105,245,156,169,209,195,182,164,13,38,9,101,188,242,164,155,46,110,157,6,255,12,69,212,242,60,206,97,93,104,22,81,143,238,246,90,88,221,68,117,124,244,204,241,197,152,217,184,196,88,157,101,188,72,210,207,58,189,79,45,221,56,12,204,29,165,157,153,155,157,251,241,43,175,46,142,165,222,246,154,223,1,52,249,84,158,3,197,100,134,73,74,103,28,226,48,64,28,119,129,141,99,102,174,213,252,90,151,15,222,72,133,12,250,222,136,221,177,211,248,139,198,218,50,208,18,183,106,7,104,186,121,176,131,237,122,103,71,203,235,245,51,40,191,117,188,236,215,29,247,213,185,187,65,174,108,12,22,186,2,220,254,93,220,21,141,253,60,254,158,42,234,247,155,109,159,162,43,226,222,243,198,150,237,42,195,187,36,182,119,94,35,252,18,146,25,136,80,91,175,123,88,117,93,109,244,12,115,187,42,93,82,127,218,170,62,63,109,157,34,78,37,221,224,247,213,197,92,187,27,218,184,162,170,195,118,136,70,119,171,211,96,119,189,252,161,219,170,89,99,131,63,72,55,71,123,80,8,85,213,227,90,130,88,55,192,14,197,14,207,108,91,140,135,166,182,155,66,199,164,241,3,214,26,243,142,212,255,145,163,90,54,255,195,212,147,205,235,90,171,134,171,87,186,189,34,108,32,248,247,15,155,253,201,186,135,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f11c38bc-163a-4783-b903-5b016339927b"));
		}

		#endregion

	}

	#endregion

}

