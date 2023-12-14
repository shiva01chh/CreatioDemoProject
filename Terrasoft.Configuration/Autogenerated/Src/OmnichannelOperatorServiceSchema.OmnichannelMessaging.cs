﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelOperatorServiceSchema

	/// <exclude/>
	public class OmnichannelOperatorServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelOperatorServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelOperatorServiceSchema(OmnichannelOperatorServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a9cd048-ad82-4077-bdad-9bf3f31c7c8a");
			Name = "OmnichannelOperatorService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad806488-98f4-482b-bb58-5e43a394961e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,75,111,219,56,16,62,187,64,255,3,225,238,65,6,2,249,94,199,46,28,167,45,188,104,154,54,201,162,135,32,88,208,210,216,209,86,150,92,146,114,226,6,249,239,59,195,135,44,74,182,149,102,31,40,22,155,67,16,205,12,135,195,143,223,60,164,100,124,9,114,197,35,96,87,32,4,151,249,92,133,147,60,155,39,139,66,112,149,228,89,120,190,204,146,232,150,103,25,164,225,25,72,201,23,73,182,120,249,226,225,229,139,78,33,241,79,246,17,238,84,158,233,149,191,202,60,27,148,138,203,141,84,176,172,63,163,251,52,133,136,124,203,240,61,100,32,146,168,97,115,81,100,42,89,66,120,137,90,158,38,223,117,40,13,43,212,174,147,8,206,242,24,210,131,202,112,140,251,173,219,157,132,95,96,214,48,184,130,123,181,21,86,97,18,176,75,142,62,80,183,92,86,247,218,165,117,59,95,228,133,66,27,52,70,243,87,2,22,24,37,155,164,92,202,215,172,2,254,249,10,240,70,114,97,87,105,235,126,191,207,142,101,177,92,114,177,25,217,231,79,34,95,39,49,72,198,153,52,166,108,158,11,118,151,139,175,20,201,93,162,110,89,190,117,203,114,235,87,134,206,97,191,226,241,218,110,135,156,80,130,71,234,134,100,99,185,250,8,10,79,177,66,72,103,73,154,168,205,5,124,43,18,1,75,200,148,12,170,15,132,43,27,178,150,37,100,21,90,65,220,211,155,156,194,156,23,169,170,128,4,36,95,21,179,52,137,88,68,248,28,128,135,189,102,39,92,66,9,86,135,248,250,20,116,21,87,112,129,41,129,236,52,24,55,64,214,130,11,88,9,144,20,122,9,32,147,180,150,9,187,56,44,215,86,241,196,115,113,197,171,104,182,159,168,26,18,158,203,75,79,7,79,25,113,199,156,212,236,115,6,203,25,8,189,139,219,70,42,65,52,152,20,66,96,244,218,247,132,174,200,172,234,44,64,13,144,55,154,240,157,206,35,253,126,52,48,188,130,44,54,240,217,231,86,44,39,60,186,125,46,150,17,173,253,251,177,172,133,212,6,214,251,34,137,217,111,152,70,211,152,61,176,18,27,102,33,217,187,46,201,20,211,37,7,38,183,92,201,73,142,229,236,135,28,124,72,164,58,166,221,71,236,20,83,34,82,16,107,79,63,228,196,94,245,7,46,21,45,30,71,17,172,208,209,41,177,244,25,126,154,148,241,125,180,50,229,93,2,105,140,84,249,36,168,22,91,70,172,204,3,115,55,116,198,51,190,0,193,126,207,125,193,96,151,241,37,246,35,244,140,4,202,101,130,207,155,237,178,134,106,112,56,56,44,155,184,82,37,240,212,0,235,207,134,73,136,136,75,37,1,170,16,89,227,32,88,12,27,162,55,111,88,6,119,117,151,1,49,15,233,157,153,110,217,107,230,100,59,30,251,53,173,241,54,151,12,15,41,107,103,104,24,180,159,102,223,213,156,129,186,205,247,18,103,157,99,142,126,46,160,0,121,154,16,85,103,216,41,2,203,89,140,72,243,245,200,164,114,100,40,108,50,186,103,15,158,204,89,224,236,216,112,88,45,27,229,188,131,113,75,37,67,175,36,155,161,2,66,202,5,231,171,179,230,130,125,163,96,202,88,232,4,67,13,13,37,225,103,79,151,239,185,99,237,38,114,230,211,88,162,135,26,57,112,116,50,90,121,178,113,170,192,63,159,245,133,221,31,176,236,177,160,230,20,171,148,183,71,121,134,78,227,0,97,5,217,202,18,183,195,227,193,171,236,116,188,118,65,72,138,34,162,137,3,111,84,87,152,3,189,97,154,37,74,79,128,56,208,16,134,9,174,230,25,246,247,124,142,198,0,44,18,48,31,118,9,218,43,193,51,57,7,55,1,116,251,163,61,109,195,150,181,253,195,67,208,195,54,59,195,241,33,176,152,60,254,243,17,174,184,224,75,150,225,56,62,236,22,30,39,186,35,186,79,22,149,130,240,184,175,173,71,207,61,158,207,57,230,111,87,158,189,46,126,248,161,84,109,187,88,164,47,77,189,254,244,84,72,66,77,97,231,183,76,214,177,237,185,70,45,49,69,75,142,42,72,183,141,80,8,123,125,102,163,1,217,219,241,184,239,28,235,57,195,248,193,3,122,195,198,53,206,242,211,108,157,127,133,192,156,27,179,180,251,233,252,242,170,123,196,104,150,5,169,222,229,98,201,21,202,209,212,20,19,48,34,253,170,116,196,78,242,120,115,169,54,41,120,38,165,52,252,34,248,106,5,177,245,118,164,243,204,157,227,176,239,222,77,11,23,188,169,18,111,163,218,222,29,239,117,29,114,67,152,173,98,109,190,2,91,21,84,217,99,76,53,171,150,38,116,229,115,48,156,108,213,225,52,174,84,65,186,142,169,116,59,237,168,131,91,229,219,123,172,82,114,154,149,117,118,119,61,164,122,239,123,221,86,190,114,224,108,12,59,59,11,176,7,0,153,237,222,209,214,71,28,106,21,213,225,183,247,52,136,81,186,192,125,111,219,125,237,206,91,237,16,245,149,46,233,26,180,179,28,180,85,38,196,33,91,128,78,167,191,152,101,213,226,228,90,101,119,132,47,254,54,127,34,66,136,146,200,237,211,44,81,207,76,84,98,220,255,201,234,39,171,185,87,147,168,181,57,231,231,200,219,122,166,152,128,189,93,253,68,57,218,30,96,80,75,135,29,137,232,108,173,105,99,246,219,14,125,187,178,241,95,79,67,172,19,146,113,61,43,154,215,218,120,251,205,5,167,133,121,254,148,254,54,169,45,252,175,145,94,191,240,182,189,176,143,8,75,51,117,59,189,212,6,94,191,218,130,59,220,255,54,66,213,123,156,166,53,103,46,7,108,250,20,169,178,201,243,180,240,220,114,111,226,206,87,52,104,151,65,85,153,134,254,195,113,28,7,123,210,211,115,30,108,155,84,227,203,194,16,221,135,117,233,145,181,222,145,64,104,109,222,96,232,217,217,249,223,25,180,145,39,114,118,101,37,64,3,155,189,86,179,243,67,131,182,219,165,9,175,242,75,93,188,130,158,237,146,189,221,89,134,40,85,115,236,103,162,250,51,136,110,11,54,13,15,230,198,149,190,230,83,152,21,11,250,254,82,222,179,1,231,164,72,210,24,106,108,244,84,85,206,126,133,141,52,54,215,55,236,129,85,59,172,174,146,142,89,246,147,243,69,145,130,68,124,170,118,4,42,98,138,111,149,19,35,24,103,241,52,70,2,37,243,4,4,25,95,65,10,11,236,237,86,47,41,55,186,143,59,152,143,209,16,245,41,40,239,253,120,205,211,2,154,173,100,188,90,33,64,230,102,9,146,107,92,120,51,240,147,5,241,207,226,224,151,238,3,234,30,95,179,110,207,137,8,103,244,181,6,161,202,127,26,192,249,236,15,244,29,232,253,122,251,217,85,97,98,149,104,181,119,28,35,245,133,40,163,159,63,1,251,119,125,61,69,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a9cd048-ad82-4077-bdad-9bf3f31c7c8a"));
		}

		#endregion

	}

	#endregion

}

