﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseRestClientSchema

	/// <exclude/>
	public class BaseRestClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseRestClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseRestClientSchema(BaseRestClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1463351c-0bcb-4ebc-9d61-c3c3180e0d31");
			Name = "BaseRestClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9af1fba8-e20e-442c-aa2d-7a413d186e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,221,111,219,54,16,127,118,129,254,15,172,10,20,50,22,200,123,40,134,33,137,61,36,169,219,120,104,62,96,169,232,67,81,20,148,116,118,84,200,162,70,82,113,188,34,255,251,142,20,41,81,82,226,36,192,242,16,155,199,251,230,221,239,206,5,221,128,40,105,2,36,2,206,169,96,43,25,156,177,98,149,173,43,78,101,198,138,215,175,126,189,126,53,170,68,86,172,73,184,19,18,54,71,189,115,176,184,26,144,46,65,14,104,17,220,13,137,203,170,144,217,6,130,16,120,70,243,236,95,109,179,229,186,132,173,100,133,246,234,111,177,231,66,249,124,11,92,2,23,45,143,27,17,7,164,227,205,91,14,107,180,64,206,114,42,196,33,57,165,2,150,32,228,89,158,65,33,53,71,89,197,121,150,16,26,11,201,105,34,73,162,56,123,140,199,209,12,57,127,105,254,70,229,199,12,242,20,117,94,243,236,150,74,168,47,203,250,64,80,153,114,233,7,135,127,42,84,115,1,242,134,165,71,143,241,136,18,99,3,19,177,203,242,69,0,199,80,11,72,84,158,200,143,170,115,126,68,95,76,69,150,156,84,242,198,220,191,133,34,173,125,86,39,55,132,107,206,74,204,98,6,42,12,157,135,90,226,219,98,93,96,10,63,80,73,47,96,19,3,255,174,237,212,153,138,25,203,73,88,37,9,96,158,84,177,140,70,235,250,249,71,35,97,190,220,63,67,143,113,119,126,151,64,169,162,185,64,125,116,13,79,168,116,131,113,67,169,51,172,159,131,73,76,15,164,54,57,230,216,207,229,39,144,93,138,63,54,166,57,200,138,63,148,236,151,56,241,120,77,132,40,188,172,203,194,55,164,138,231,95,33,198,158,184,205,18,176,110,220,82,78,176,162,25,39,83,35,26,204,55,165,220,213,105,177,15,48,37,146,87,80,211,36,223,25,89,45,108,106,15,89,252,115,41,75,180,96,204,142,187,199,224,140,3,250,231,119,189,168,85,142,184,229,97,133,196,78,136,118,37,160,66,143,150,37,190,161,238,222,201,79,172,91,207,176,103,43,226,191,49,222,46,196,101,149,231,87,92,123,237,183,101,57,182,17,182,218,207,129,166,216,203,193,73,154,250,158,226,97,220,96,131,119,224,20,180,117,234,190,13,178,182,181,108,66,197,103,53,7,213,78,190,149,80,172,241,78,130,74,152,131,79,193,188,72,88,170,156,253,18,125,252,51,64,225,83,197,228,119,180,142,77,31,237,139,174,43,64,222,189,235,181,62,121,131,73,251,52,143,188,97,236,134,97,58,4,11,205,86,99,155,111,98,5,186,65,78,43,218,6,27,234,43,223,73,237,168,230,14,190,242,12,223,86,199,126,64,126,63,168,179,16,124,134,98,221,230,211,38,212,124,56,38,13,54,245,109,214,128,229,154,107,253,91,58,34,250,155,43,98,253,124,32,58,174,107,0,197,10,216,146,208,168,82,36,191,163,215,13,177,3,157,218,160,226,15,148,88,196,230,69,218,218,105,154,186,7,182,195,232,239,9,150,117,114,67,124,236,133,6,155,72,211,149,163,1,94,77,9,4,230,187,81,216,246,230,138,230,2,154,78,210,30,20,88,53,53,229,254,69,136,226,192,243,100,50,33,199,162,218,108,40,223,205,44,33,4,73,116,163,16,234,246,15,89,177,6,9,130,70,120,210,151,62,46,41,199,210,42,112,61,152,122,57,91,103,133,55,251,172,62,130,227,137,190,122,152,179,196,89,185,101,60,245,102,215,230,91,135,223,32,253,45,203,82,229,223,169,237,99,139,123,218,208,129,5,70,171,204,166,90,85,234,183,239,68,50,221,164,112,34,78,77,3,159,132,103,139,69,211,185,250,212,182,174,214,73,126,35,222,161,135,255,27,157,117,202,91,40,81,32,166,253,33,138,205,172,19,65,196,212,224,255,227,125,168,61,242,123,166,199,238,12,120,244,17,44,236,110,244,211,61,55,231,157,222,247,102,203,142,18,114,125,21,70,19,132,143,125,217,93,186,26,108,134,59,106,109,98,123,208,52,37,67,224,217,23,228,252,14,146,10,231,217,121,20,93,147,45,196,47,45,47,156,51,109,128,120,24,150,88,221,42,2,153,116,203,72,28,58,200,100,169,78,236,145,117,198,153,164,238,252,140,89,186,179,208,163,144,223,25,189,138,243,200,157,247,15,3,187,171,97,76,254,34,10,55,108,181,124,0,97,214,88,184,138,127,226,154,128,123,98,79,224,144,164,176,162,85,46,253,232,233,234,49,225,218,2,82,154,246,229,212,230,163,182,253,112,130,76,90,250,83,209,73,17,238,87,18,89,132,1,94,117,111,151,115,224,161,185,180,64,106,153,157,253,91,207,108,3,217,120,53,47,170,77,115,137,3,226,105,185,133,96,184,32,66,132,63,11,134,130,181,135,214,29,244,177,235,159,93,93,172,126,87,42,110,71,9,94,157,86,89,174,102,137,225,112,167,234,182,195,168,231,37,206,156,184,29,52,173,3,205,239,22,52,185,61,32,242,38,179,38,239,221,82,18,49,34,137,193,144,23,60,187,169,211,255,251,221,219,129,55,88,113,7,211,240,41,112,235,174,204,207,238,248,142,148,55,235,105,217,3,106,189,21,189,183,195,119,245,54,240,214,37,227,235,62,123,147,175,169,93,34,210,212,223,127,92,92,6,135,58,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1463351c-0bcb-4ebc-9d61-c3c3180e0d31"));
		}

		#endregion

	}

	#endregion

}

