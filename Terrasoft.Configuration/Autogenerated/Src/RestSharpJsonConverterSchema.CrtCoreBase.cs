﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RestSharpJsonConverterSchema

	/// <exclude/>
	public class RestSharpJsonConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RestSharpJsonConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RestSharpJsonConverterSchema(RestSharpJsonConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baa08fd9-35c6-4edc-b127-d90ddc4b16e2");
			Name = "RestSharpJsonConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,77,111,218,64,16,61,19,41,255,97,148,94,64,162,246,61,16,46,33,109,169,26,18,5,218,251,218,30,240,70,246,174,181,59,14,162,136,255,222,217,181,177,77,19,82,170,32,89,172,231,227,205,155,55,179,86,34,71,91,136,24,97,137,198,8,171,87,20,220,106,181,146,235,210,8,146,90,93,94,236,46,47,122,165,149,106,13,139,173,37,204,217,159,101,24,59,167,13,190,162,66,35,227,81,19,51,199,13,177,195,225,124,183,90,157,116,184,42,47,104,8,141,109,99,158,208,210,34,21,166,120,195,20,76,209,114,41,145,201,223,111,231,4,139,35,55,7,124,50,184,102,150,112,155,9,107,175,219,72,87,191,41,239,35,195,48,132,177,45,243,92,152,237,164,126,111,225,64,168,4,146,78,121,88,105,211,194,65,156,73,84,4,145,176,152,0,215,107,91,133,76,70,134,49,131,26,243,167,139,112,201,177,54,134,53,100,212,207,225,1,215,235,13,122,5,211,229,3,108,36,165,48,21,36,238,49,143,28,5,34,35,163,146,208,122,54,133,209,5,91,83,62,103,78,5,206,162,20,33,17,132,14,63,23,116,40,57,14,59,125,21,101,148,201,152,9,179,32,39,244,128,107,152,181,173,15,97,214,213,157,33,118,94,176,70,219,71,79,132,36,178,192,143,70,190,48,129,42,160,168,94,192,129,183,120,11,36,98,190,246,148,121,7,107,164,17,236,225,6,20,110,78,70,185,2,61,86,7,191,248,94,191,29,100,184,129,215,198,96,102,117,107,29,250,212,118,249,234,66,63,164,165,241,145,14,147,186,74,207,185,23,44,190,90,223,169,50,111,252,253,129,119,239,43,192,121,153,101,191,68,86,98,135,202,43,91,48,91,43,109,208,37,236,71,181,140,168,146,74,201,119,100,245,67,171,252,60,209,177,84,41,75,66,137,142,33,156,120,169,171,169,90,79,18,158,180,166,187,12,115,183,146,85,11,78,82,127,176,245,97,127,54,216,188,249,62,124,24,170,157,193,199,177,120,10,196,253,45,183,5,30,86,198,30,246,230,74,20,5,135,250,219,20,62,243,72,175,254,161,245,61,82,170,147,255,23,186,89,204,190,142,158,221,101,230,191,65,221,155,65,42,141,130,206,70,181,159,167,7,31,237,146,134,39,22,124,112,174,28,75,232,220,206,241,114,210,159,185,75,205,79,193,223,31,4,83,31,222,97,213,201,175,120,57,148,67,94,80,235,124,22,207,191,228,173,172,199,70,111,227,223,31,242,44,57,9,118,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baa08fd9-35c6-4edc-b127-d90ddc4b16e2"));
		}

		#endregion

	}

	#endregion

}
