﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUtilServiceSchema

	/// <exclude/>
	public class ActivityUtilServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUtilServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUtilServiceSchema(ActivityUtilServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36eb2d98-0288-472e-8f9b-081ca92707b0");
			Name = "ActivityUtilService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("001f780a-b0ba-4542-8b43-34f1695d65bb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,87,75,143,219,54,16,62,59,64,254,3,225,92,180,128,33,95,138,30,18,199,192,102,83,47,28,116,31,176,119,147,195,34,7,218,26,59,204,74,164,74,82,94,56,69,255,123,103,72,217,122,250,217,20,40,80,95,108,145,223,60,248,205,204,39,90,242,4,76,202,231,192,30,64,107,110,212,194,134,87,74,46,196,50,211,220,10,37,95,191,250,243,245,171,78,102,132,92,178,233,218,88,72,222,213,158,195,241,93,99,105,146,73,43,18,8,167,160,5,143,197,15,231,170,129,194,221,149,152,195,141,138,32,222,187,25,94,206,173,88,29,118,18,126,129,89,1,216,113,162,112,36,98,120,76,99,197,163,118,172,134,240,55,76,223,10,48,59,1,35,62,183,74,239,64,96,22,136,74,146,114,182,109,187,155,220,39,42,179,136,65,48,194,223,104,88,98,150,236,42,230,198,188,101,238,228,194,174,31,173,136,115,184,131,245,251,125,54,48,89,146,112,189,30,230,207,132,65,40,51,30,199,230,228,130,45,148,102,47,74,63,83,22,47,194,126,67,51,192,61,13,139,247,221,141,247,110,127,24,110,156,246,75,94,159,62,194,130,103,177,45,37,10,95,105,125,106,210,230,154,95,64,178,173,70,122,220,218,165,73,111,193,226,113,83,228,126,230,210,155,192,31,153,208,144,128,180,38,40,63,80,9,217,123,118,192,132,80,97,190,16,93,80,144,52,155,197,98,158,159,182,133,175,183,236,3,55,176,37,175,67,13,189,165,249,6,236,55,21,33,209,247,206,139,227,182,65,174,91,184,210,192,45,176,1,49,199,36,206,77,65,31,117,20,82,200,52,204,149,142,194,173,139,126,221,199,32,229,154,39,185,245,119,163,100,197,195,176,236,251,83,125,23,253,11,105,44,151,115,8,7,125,231,168,240,171,193,102,90,154,225,225,236,152,136,144,70,177,16,160,209,205,198,142,28,61,221,165,224,71,164,92,194,206,19,54,236,88,174,212,51,4,158,44,172,81,247,254,110,250,208,237,177,15,42,90,79,237,58,166,186,33,236,6,140,225,75,216,174,134,95,52,79,83,136,122,228,167,67,69,3,99,71,74,39,220,86,12,252,82,72,71,238,177,9,10,146,146,6,246,227,92,229,55,165,191,206,68,148,215,167,124,104,55,197,235,160,206,36,171,19,127,193,92,75,116,86,92,179,5,62,79,32,85,70,224,124,175,49,186,155,67,63,238,235,240,26,236,96,84,65,12,3,103,138,31,9,47,12,137,51,86,103,4,190,212,203,140,26,54,232,102,56,143,184,33,97,78,220,34,107,143,149,133,139,139,119,149,232,99,34,152,78,20,222,194,11,125,7,57,96,182,182,240,244,149,69,220,114,202,75,201,21,104,27,142,180,74,168,191,127,253,101,106,53,206,120,80,63,93,248,17,13,106,49,60,51,99,185,80,232,137,18,47,232,242,202,72,91,65,181,131,122,121,118,189,6,127,225,45,246,91,30,161,234,61,188,231,26,57,184,82,113,150,72,66,81,239,108,69,231,160,197,103,30,103,100,210,8,184,121,24,71,173,62,30,148,229,49,1,127,7,185,68,197,107,241,48,21,63,160,213,150,122,31,19,200,121,185,129,4,139,140,204,2,79,130,168,32,178,30,112,157,250,186,53,226,248,157,86,163,207,160,13,73,80,139,85,190,85,152,21,13,23,250,2,17,44,168,58,204,83,163,15,99,204,253,246,227,157,23,206,191,95,58,127,29,214,56,194,159,33,102,62,149,118,41,43,237,29,37,100,216,251,255,15,193,170,9,85,193,19,171,82,250,83,68,234,191,164,81,197,209,206,87,168,154,31,255,147,116,166,42,86,37,200,73,82,213,234,190,64,156,164,95,13,63,39,105,87,201,250,95,84,174,82,148,163,117,171,100,115,166,106,117,188,86,181,10,214,86,174,222,128,140,252,149,205,61,251,213,218,98,237,234,76,29,71,35,69,65,119,222,153,9,196,62,77,239,110,189,232,169,217,119,236,248,29,119,97,36,177,44,52,149,123,103,53,24,221,49,203,183,204,123,173,80,170,232,31,197,17,23,77,55,252,164,156,59,180,215,37,130,229,157,129,14,54,239,84,130,119,43,18,99,220,164,177,188,79,247,7,163,246,56,33,24,193,91,131,17,246,96,48,139,157,85,214,244,227,227,90,215,147,221,166,146,110,155,117,127,100,131,147,115,66,56,130,87,131,9,156,174,124,252,246,71,90,249,73,56,33,88,110,209,140,87,12,85,125,12,142,26,130,250,229,119,231,32,184,25,240,237,191,243,111,226,230,245,157,110,219,249,140,73,105,92,199,235,147,250,143,134,103,79,214,60,127,62,175,249,248,246,202,217,210,128,149,251,232,217,117,42,164,116,103,149,174,65,130,198,168,224,160,94,179,74,149,59,179,28,69,224,159,90,11,255,42,220,228,122,162,162,193,246,93,222,42,53,197,171,126,223,48,86,51,200,164,192,11,221,121,229,135,252,157,221,82,252,210,235,252,200,68,98,165,158,179,148,205,221,37,225,60,98,138,91,200,30,122,42,87,149,163,218,210,173,225,231,111,136,192,125,34,24,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36eb2d98-0288-472e-8f9b-081ca92707b0"));
		}

		#endregion

	}

	#endregion

}
