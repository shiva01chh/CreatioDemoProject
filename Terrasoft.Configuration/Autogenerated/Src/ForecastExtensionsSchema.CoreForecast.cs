﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastExtensionsSchema

	/// <exclude/>
	public class ForecastExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastExtensionsSchema(ForecastExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("37600005-73d0-4dab-84da-b6cf0e99d1be");
			Name = "ForecastExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,91,111,219,54,20,126,118,129,254,7,206,123,152,140,122,202,176,167,161,73,92,164,142,211,186,75,147,44,118,58,12,69,31,100,137,142,181,73,148,75,82,73,180,34,255,125,231,240,38,74,190,38,3,134,5,1,44,145,231,202,243,157,11,197,162,156,138,101,20,83,50,165,156,71,162,152,203,112,88,176,121,122,91,242,72,166,5,11,207,10,78,227,72,200,79,63,191,124,241,237,229,139,78,41,82,118,75,46,232,189,44,152,34,255,32,128,234,60,101,95,15,55,237,214,27,147,74,72,154,183,223,65,99,150,209,24,213,137,109,123,225,59,202,40,79,227,21,154,166,118,179,56,165,15,178,94,244,221,203,115,223,166,246,78,203,228,13,231,178,158,128,211,77,235,225,136,201,84,166,84,236,36,8,71,119,148,201,205,116,103,81,44,11,190,65,210,205,56,252,157,206,192,82,201,139,76,132,215,84,20,37,143,233,251,136,37,25,229,138,5,254,191,231,244,22,124,32,195,44,18,226,53,25,46,74,246,151,208,238,105,130,131,131,3,114,36,202,60,143,120,53,48,239,87,188,184,75,19,42,200,146,23,75,202,209,84,50,47,56,137,93,128,72,140,130,192,160,208,138,56,240,100,44,203,89,150,198,36,70,157,109,149,8,172,21,165,106,225,29,149,130,128,22,129,191,114,65,73,30,61,144,101,196,1,183,18,28,2,237,37,131,7,2,22,105,245,228,107,73,121,21,58,129,7,109,137,71,119,81,86,82,247,58,125,142,204,90,132,241,42,101,146,124,140,30,174,156,144,161,150,113,69,249,111,200,171,252,37,223,200,45,149,135,232,203,33,121,124,249,98,127,167,83,38,224,196,241,168,203,156,25,3,159,230,226,14,9,107,29,26,43,158,161,102,81,14,181,61,232,60,26,64,81,150,104,76,41,175,90,248,178,37,100,244,32,41,19,152,201,138,106,29,200,110,100,154,169,44,32,212,17,43,148,205,141,12,177,13,91,66,66,110,90,136,173,211,170,129,214,50,239,116,122,169,99,177,228,233,93,36,169,229,79,51,29,192,180,72,112,87,177,118,62,99,117,184,210,25,80,5,221,113,210,237,125,81,27,206,4,142,25,57,78,86,142,170,243,184,89,139,216,168,96,238,89,33,90,186,198,35,86,230,148,71,179,140,30,249,214,14,26,182,139,61,45,1,157,160,140,238,176,164,109,131,177,223,253,110,210,213,66,136,139,193,71,42,23,96,227,107,114,165,228,237,74,10,76,6,149,146,128,10,94,228,94,241,217,150,14,42,183,9,131,212,60,238,214,28,221,1,38,134,46,144,190,160,163,3,69,191,137,29,75,150,102,53,134,232,165,85,54,78,101,201,153,208,90,150,0,107,73,147,166,30,75,225,229,157,129,176,31,90,255,121,58,24,224,65,232,242,9,111,65,115,211,19,223,111,212,88,99,100,143,232,208,122,86,12,23,52,254,235,132,223,130,20,38,47,202,44,11,208,209,98,30,212,52,189,222,161,225,82,142,110,225,80,58,12,117,82,128,71,170,182,170,170,40,0,141,186,10,30,147,64,239,245,140,192,221,133,243,192,30,242,106,73,210,202,176,92,197,198,95,172,83,160,3,150,122,31,35,185,8,135,20,106,10,187,13,124,167,145,40,232,129,220,21,243,140,245,119,17,183,241,61,246,131,54,193,64,94,50,224,145,34,240,52,26,54,29,81,195,121,104,240,223,233,108,7,245,210,228,233,172,34,105,34,28,144,199,115,179,131,171,36,226,148,208,124,41,43,242,35,49,184,113,140,170,13,151,156,67,60,72,69,193,114,144,100,88,101,181,164,251,166,134,102,185,166,203,66,164,48,98,84,221,129,173,32,220,173,109,207,14,45,97,12,149,202,177,194,200,0,131,205,60,133,208,238,195,59,5,123,161,168,26,118,101,190,39,98,115,146,237,155,76,182,66,194,193,219,6,97,44,13,228,34,21,100,124,213,58,4,210,62,149,190,10,116,199,23,250,174,76,65,164,115,190,79,112,129,248,14,217,196,75,231,36,112,116,225,88,96,250,92,242,17,198,53,232,89,34,139,162,182,102,152,127,157,177,190,240,62,57,133,50,62,77,115,26,222,200,248,162,184,15,255,0,16,24,68,62,250,184,220,45,17,204,234,89,220,110,68,237,181,197,31,28,96,138,173,149,20,115,215,161,137,154,37,204,164,177,47,244,196,130,82,217,29,216,144,16,245,190,29,47,37,84,2,40,110,204,22,243,27,129,227,154,91,120,30,84,176,142,120,208,248,132,174,232,106,115,101,125,213,56,153,160,129,218,204,62,185,105,152,66,154,150,217,168,170,138,162,68,65,69,209,254,129,38,53,245,87,99,182,70,99,208,146,83,23,38,117,194,24,123,93,155,240,156,1,1,209,39,183,28,65,67,206,138,72,54,86,27,21,202,137,8,157,99,59,195,174,10,63,244,59,154,101,38,200,81,28,23,60,193,129,71,22,53,0,148,115,63,192,8,167,124,131,7,31,17,68,164,127,239,93,145,254,11,88,248,204,202,208,238,96,232,60,220,140,162,154,134,36,5,204,171,172,144,48,179,198,84,247,120,235,40,129,139,23,137,35,70,102,48,3,68,115,154,85,136,142,68,85,108,28,172,34,125,177,221,6,201,89,81,100,250,232,27,24,25,41,93,208,58,39,160,230,169,152,52,53,44,129,200,231,145,113,227,127,134,83,204,68,99,31,122,120,158,230,41,182,245,26,183,167,111,113,29,186,161,191,212,4,179,47,4,59,246,57,101,183,114,1,82,212,92,48,229,37,139,161,112,6,218,253,112,90,76,212,240,30,244,66,77,216,72,152,85,49,131,21,251,118,102,16,156,94,46,200,2,58,89,196,227,69,69,244,76,77,82,73,115,225,95,164,213,108,107,211,168,38,135,169,90,130,129,226,137,233,179,21,242,78,250,117,113,175,26,247,191,110,177,239,173,68,125,39,24,131,115,3,229,121,107,99,21,180,234,188,87,27,107,203,68,31,168,139,166,72,8,45,163,247,228,60,21,114,173,25,65,175,198,69,202,18,250,0,12,63,29,174,168,117,172,19,125,224,218,5,101,163,219,66,29,126,130,184,13,36,22,86,81,203,244,55,248,57,109,20,197,139,192,109,192,77,241,120,96,27,127,203,157,240,36,73,2,116,104,141,47,150,165,163,242,6,44,241,36,154,244,238,152,206,21,41,204,175,154,31,142,50,138,51,252,137,12,212,97,244,194,154,65,75,120,52,110,116,212,254,171,87,102,164,104,14,187,45,163,119,38,65,99,230,245,198,67,131,250,37,36,21,188,171,26,169,138,190,94,174,196,82,95,80,247,5,127,187,17,224,53,172,124,74,51,176,253,12,199,81,215,129,246,153,69,215,140,190,207,185,247,105,240,215,19,218,56,9,182,23,117,61,118,214,102,219,68,49,223,36,204,249,253,74,43,64,67,215,77,191,122,181,171,67,138,10,204,74,235,219,33,89,152,223,99,253,221,68,127,134,84,19,228,209,102,174,65,160,241,131,32,6,75,193,146,18,217,236,237,49,104,71,169,223,30,158,250,59,248,185,209,119,1,33,3,238,218,71,123,13,157,85,146,126,254,98,55,222,194,27,230,138,182,46,60,163,18,114,209,80,54,143,9,91,18,244,3,32,30,177,184,192,25,39,188,153,158,253,130,254,154,54,225,137,180,101,5,166,123,45,165,53,218,55,101,174,12,250,117,208,67,69,175,67,31,52,38,120,115,190,214,60,189,37,225,126,98,68,97,53,244,212,224,13,248,195,229,236,79,56,198,158,250,66,127,74,225,96,211,40,195,105,161,101,206,97,45,193,124,228,1,70,16,224,145,133,170,202,28,25,137,131,160,6,153,215,54,173,32,195,7,18,218,154,143,140,23,32,192,41,90,21,240,8,19,19,196,133,4,56,227,44,21,210,161,56,61,227,204,212,153,216,228,169,29,130,42,172,181,219,7,147,96,111,194,9,197,36,53,87,33,175,46,27,157,136,66,84,99,8,66,72,49,91,17,193,139,19,206,163,42,104,214,70,167,125,103,85,156,96,85,20,44,90,138,5,76,146,9,134,16,102,106,183,176,40,178,4,39,133,57,129,187,155,72,103,251,215,65,43,226,189,146,176,99,26,176,196,77,178,102,141,186,43,160,202,128,185,19,67,139,248,48,151,103,187,68,154,74,251,238,99,172,207,227,136,252,203,113,147,145,124,7,13,29,242,200,5,191,185,29,54,196,29,59,129,30,6,214,127,126,212,171,205,69,181,6,127,255,0,199,188,80,140,19,27,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37600005-73d0-4dab-84da-b6cf0e99d1be"));
		}

		#endregion

	}

	#endregion

}

