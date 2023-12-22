﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CreatioMarketplaceApiClientSchema

	/// <exclude/>
	public class CreatioMarketplaceApiClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CreatioMarketplaceApiClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CreatioMarketplaceApiClientSchema(CreatioMarketplaceApiClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9baed6a9-abcb-4f7c-9b33-4963fb2174df");
			Name = "CreatioMarketplaceApiClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50f552a9-0668-454a-8ecf-9cb468aabd1f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,223,111,219,54,16,126,118,129,254,15,55,109,8,100,32,80,222,219,186,131,235,57,131,31,210,20,181,215,61,20,197,64,75,103,155,139,68,106,36,149,196,40,246,191,239,40,145,158,40,83,110,27,4,72,120,191,239,227,119,71,9,86,161,174,89,142,176,65,165,152,150,59,147,45,164,216,241,125,163,152,225,82,188,124,241,245,229,139,73,163,185,216,195,250,168,13,86,217,230,160,144,21,36,120,61,170,201,54,76,63,232,255,245,253,224,85,37,69,92,163,112,76,158,205,235,186,228,121,91,145,206,230,91,109,20,203,187,195,29,83,15,104,234,146,122,24,245,190,37,99,169,56,70,43,90,163,122,228,121,95,103,125,156,116,157,31,176,98,48,139,216,103,129,201,192,251,168,215,104,12,29,53,249,182,53,4,168,102,61,3,242,36,223,207,191,225,142,53,165,121,199,133,5,48,53,199,26,229,46,93,81,227,189,14,231,53,95,148,28,133,153,78,191,144,83,221,108,9,21,200,75,166,53,44,8,123,138,29,179,134,87,48,22,136,162,124,109,11,152,252,172,112,79,165,81,181,66,27,38,140,126,5,31,20,127,100,6,59,125,221,29,32,183,122,160,27,104,155,141,37,13,128,121,79,12,35,12,146,168,101,242,218,229,70,81,116,233,195,90,110,57,150,197,88,33,150,107,82,148,71,248,67,163,162,170,5,182,148,128,191,154,224,252,141,20,109,187,170,177,4,161,60,45,160,46,77,7,238,5,88,211,65,226,48,239,20,236,228,76,38,131,114,8,139,179,250,38,147,127,47,23,121,135,230,32,71,129,160,235,50,84,233,163,228,5,208,8,202,167,213,110,37,30,89,201,139,53,50,149,31,62,226,63,13,106,147,6,61,212,129,14,116,255,228,75,231,59,72,3,133,157,195,133,44,48,91,233,247,77,89,222,171,101,85,155,99,58,133,171,43,56,51,188,229,37,218,219,31,26,251,232,19,99,107,5,129,79,208,211,47,159,115,172,45,46,233,47,201,146,155,3,42,96,117,77,172,43,16,164,130,29,5,5,97,57,85,53,84,246,150,186,175,49,231,59,142,69,50,109,161,180,88,158,0,245,16,173,28,39,221,60,252,142,230,79,220,6,178,212,151,21,176,247,142,9,182,167,18,116,76,56,27,82,45,163,184,49,247,212,85,118,190,88,116,184,102,58,92,98,201,108,232,85,59,152,57,190,59,90,88,211,239,155,61,151,90,161,105,148,8,243,101,109,4,12,97,24,180,52,253,49,122,246,230,231,230,230,6,222,112,65,23,200,77,33,115,184,121,219,155,42,166,143,34,7,251,74,188,9,89,185,58,113,86,211,54,124,11,27,117,164,206,135,54,105,7,212,119,19,250,26,22,22,184,178,108,183,239,70,62,160,128,252,76,50,131,162,91,194,158,10,33,165,23,7,204,31,230,106,223,84,132,147,101,108,106,121,72,75,58,156,29,7,248,165,65,12,29,58,251,1,67,117,112,154,197,25,27,243,244,253,43,247,119,22,134,114,119,238,43,73,40,46,65,215,222,155,62,96,241,9,149,38,60,252,40,141,46,0,248,105,6,130,32,56,205,178,75,151,57,187,15,76,17,54,134,162,125,78,156,75,242,165,173,37,18,172,55,182,241,140,126,147,252,72,86,239,19,79,235,181,253,212,67,28,117,77,79,131,125,102,220,63,51,96,79,140,15,174,38,91,62,99,222,24,156,91,66,167,202,211,237,140,92,14,80,185,253,155,230,10,170,1,159,231,250,190,83,116,253,117,182,91,41,203,83,246,117,147,211,55,135,253,154,240,146,204,137,122,198,248,204,181,209,247,162,55,23,61,7,31,226,234,202,131,231,2,157,96,251,196,74,42,63,235,102,174,61,164,201,112,244,146,107,144,205,120,7,211,83,248,209,30,185,246,95,15,222,52,77,59,193,116,52,170,125,67,164,9,158,145,96,175,217,71,228,210,34,241,132,57,135,209,73,174,59,253,50,138,96,4,215,235,216,6,90,21,113,99,248,21,190,213,33,125,162,217,155,239,232,120,97,231,146,148,126,251,63,255,1,33,28,209,225,195,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9baed6a9-abcb-4f7c-9b33-4963fb2174df"));
		}

		#endregion

	}

	#endregion

}

