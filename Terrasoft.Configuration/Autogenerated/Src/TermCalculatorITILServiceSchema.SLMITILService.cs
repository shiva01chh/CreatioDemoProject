﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorITILServiceSchema

	/// <exclude/>
	public class TermCalculatorITILServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorITILServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorITILServiceSchema(TermCalculatorITILServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b39bbd0b-1c65-4417-bf62-1ca79d96bd6f");
			Name = "TermCalculatorITILService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,93,111,218,48,20,125,78,165,254,7,143,74,85,144,80,126,64,25,171,90,90,42,164,118,99,131,109,143,147,155,92,192,82,226,80,199,97,66,83,255,251,174,99,7,108,147,164,84,211,250,82,124,125,63,206,61,231,218,113,89,48,190,34,243,93,33,33,27,158,159,149,214,50,122,100,252,101,111,91,128,16,180,200,151,50,26,231,2,90,204,209,61,151,76,50,40,112,255,252,140,211,12,138,13,141,193,241,226,75,182,42,5,149,44,231,231,103,127,148,95,112,33,96,133,75,50,78,105,81,92,41,239,108,76,211,184,76,169,204,197,116,49,125,156,131,216,178,24,42,231,77,249,156,178,152,196,202,183,221,149,248,105,48,82,23,219,87,155,48,72,19,44,55,19,108,75,165,78,30,108,244,130,152,52,51,26,75,242,171,56,44,134,141,110,83,222,228,239,88,77,224,5,240,68,215,119,193,32,47,133,20,101,140,72,21,164,170,71,83,74,247,219,218,105,248,29,203,97,56,135,88,113,74,74,103,57,32,15,37,75,136,213,193,52,113,109,83,148,122,111,195,190,114,193,228,110,154,244,137,42,30,92,145,103,90,64,232,39,245,98,237,176,63,85,220,220,46,72,70,46,128,161,237,226,176,84,249,62,128,108,222,11,189,54,28,20,253,42,235,107,55,205,51,145,111,64,168,9,85,186,231,18,251,129,164,150,212,44,53,19,46,40,221,212,10,164,134,94,152,31,175,93,161,126,99,167,230,176,71,201,254,189,143,55,191,2,182,36,161,61,155,228,195,136,240,50,77,107,13,130,64,128,44,5,247,7,88,237,152,170,58,137,39,192,168,106,35,186,207,54,114,119,148,75,21,240,115,108,169,168,181,184,17,43,128,12,184,68,29,57,252,182,27,240,6,181,63,60,0,240,131,163,9,200,120,61,17,121,118,119,235,162,235,31,0,57,173,143,142,0,28,64,118,50,241,218,165,129,123,174,27,141,157,170,184,174,111,201,227,223,23,109,58,29,157,152,127,17,204,133,232,136,230,108,189,173,158,227,222,164,160,135,187,65,74,31,76,55,49,167,81,88,11,28,4,93,23,195,19,200,117,222,250,53,168,142,117,251,181,116,218,21,91,183,171,200,135,226,197,112,93,125,49,119,243,120,13,25,253,90,130,216,121,68,71,182,195,19,229,116,5,98,64,122,77,72,122,70,20,252,144,168,79,51,75,198,121,90,102,252,51,126,134,177,24,150,140,110,18,99,11,123,211,164,215,143,212,150,142,81,187,19,150,74,16,133,242,10,213,122,44,0,155,215,214,159,76,174,103,84,160,191,114,9,181,113,156,103,27,42,88,145,243,197,110,131,31,255,151,146,166,22,54,236,186,231,95,210,253,255,86,174,98,96,224,202,80,151,211,28,18,208,255,52,23,40,167,54,35,35,169,230,218,159,113,132,40,10,249,69,220,193,146,150,169,12,77,54,51,115,38,155,57,213,228,218,24,84,98,133,207,48,253,131,166,37,124,84,211,240,41,180,21,233,227,11,229,112,106,135,239,29,210,253,167,75,71,28,110,174,124,139,111,45,150,28,102,22,31,13,152,142,10,156,211,122,2,219,238,146,125,47,151,151,141,119,64,116,200,165,92,27,46,29,67,205,27,193,214,193,244,34,90,80,116,22,215,149,175,91,124,245,174,126,198,68,30,29,109,47,6,163,194,17,235,199,175,178,61,219,223,240,165,139,79,56,88,48,60,108,88,230,137,113,219,20,218,11,61,4,133,126,10,19,81,237,36,71,27,53,167,78,102,51,221,181,13,71,185,238,203,47,216,154,118,120,210,8,236,21,109,42,127,7,146,178,212,2,209,168,55,130,122,15,162,122,18,26,107,52,76,204,113,207,183,187,153,121,135,134,30,79,131,118,150,91,103,64,219,108,19,90,240,239,47,51,41,76,206,50,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b39bbd0b-1c65-4417-bf62-1ca79d96bd6f"));
		}

		#endregion

	}

	#endregion

}

