﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Base64ImageParserSchema

	/// <exclude/>
	public class Base64ImageParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Base64ImageParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Base64ImageParserSchema(Base64ImageParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a054bae-c208-4613-b7dd-5bfbbe846b88");
			Name = "Base64ImageParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,77,111,211,64,16,61,187,82,255,195,224,94,28,97,28,14,136,67,218,4,68,84,68,36,66,171,58,130,3,2,105,235,140,157,149,252,165,217,117,219,80,245,191,51,187,235,117,66,27,84,9,114,72,186,31,239,205,123,243,177,173,69,133,170,21,25,194,10,137,132,106,114,157,204,155,58,151,69,71,66,203,166,78,150,66,150,178,46,142,143,238,143,143,130,78,241,159,144,110,149,198,234,244,209,58,89,225,157,78,174,176,232,74,65,231,119,45,161,82,76,160,248,30,223,60,33,44,120,5,243,82,40,53,129,15,66,225,219,55,139,74,20,120,41,72,33,217,75,227,241,24,206,84,87,85,130,182,179,126,125,133,134,9,107,173,32,51,88,200,27,130,150,49,38,242,167,213,242,179,37,57,47,177,226,59,160,154,142,216,140,222,8,13,228,145,184,6,161,224,218,134,4,165,201,32,101,173,27,24,66,34,66,70,152,79,195,103,178,144,236,233,14,199,179,196,19,140,247,68,183,221,117,41,179,94,236,19,159,48,129,197,1,243,129,201,238,46,73,156,54,45,216,242,4,46,73,222,8,141,54,61,65,235,22,144,153,115,239,100,41,43,92,109,91,76,81,80,182,185,20,90,35,213,48,133,247,97,244,238,108,250,115,45,180,152,140,164,9,54,254,46,94,253,250,241,50,60,253,43,151,83,150,82,198,248,208,34,45,240,89,132,215,176,139,238,208,247,175,31,78,93,222,227,208,245,65,112,130,245,218,217,236,215,189,231,37,234,77,179,54,142,109,254,220,225,227,134,176,27,156,157,27,36,238,7,189,65,47,99,168,181,45,23,52,57,136,26,172,118,174,52,8,216,145,253,71,169,159,214,218,237,112,55,138,10,106,30,165,105,168,40,11,103,169,235,194,125,21,220,109,153,211,157,156,141,45,224,48,222,229,123,182,176,13,224,56,140,205,127,214,13,50,31,204,251,169,185,229,105,80,93,150,241,128,230,93,25,67,195,17,232,86,42,132,186,43,203,167,250,8,117,71,181,154,93,185,95,208,212,161,225,125,158,47,23,165,66,38,244,12,182,141,220,124,92,55,77,9,43,218,218,9,136,250,50,114,246,24,222,233,253,185,113,9,28,129,157,144,192,101,115,106,149,218,174,12,44,145,84,150,103,205,39,54,166,59,98,141,17,83,38,169,22,220,47,223,164,222,68,67,135,199,144,218,152,243,166,98,31,82,113,6,47,104,45,107,81,46,138,186,33,156,243,197,145,143,26,220,8,226,30,43,248,89,51,177,241,150,159,165,2,239,162,131,179,23,187,195,139,214,148,69,37,41,7,41,145,75,131,35,167,42,232,205,86,61,152,25,29,53,151,80,103,27,163,120,148,124,21,101,215,187,8,246,204,189,112,216,100,161,190,112,2,46,232,188,106,245,54,242,76,62,128,241,237,65,131,5,31,214,205,99,31,184,167,251,216,80,37,116,116,112,152,99,120,76,239,153,184,161,181,121,116,167,166,110,252,242,183,37,255,35,137,118,252,177,167,183,42,7,244,80,66,78,227,94,157,7,23,177,39,246,136,7,251,227,190,93,39,13,245,182,55,30,14,190,44,110,247,207,77,222,51,159,223,153,66,145,21,246,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a054bae-c208-4613-b7dd-5bfbbe846b88"));
		}

		#endregion

	}

	#endregion

}

