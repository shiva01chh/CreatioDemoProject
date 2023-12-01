﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PriceListServiceSchema

	/// <exclude/>
	public class PriceListServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PriceListServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PriceListServiceSchema(PriceListServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b25d600-d510-46c6-a171-b6799f68c197");
			Name = "PriceListService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,111,26,49,16,61,111,164,252,135,41,185,128,132,204,61,33,84,36,85,162,84,77,131,66,170,28,80,15,102,119,32,86,88,123,59,182,169,80,213,255,222,177,157,93,118,73,68,57,177,207,111,102,222,155,15,45,75,180,149,204,17,158,144,72,90,179,114,226,218,232,149,90,123,146,78,25,125,122,242,231,244,36,243,86,233,53,204,119,214,97,121,113,240,45,230,72,91,149,227,189,41,112,115,244,81,76,115,167,182,49,237,113,222,51,46,247,132,182,48,66,113,35,115,103,72,161,253,136,193,129,204,42,203,118,129,143,94,235,114,143,198,59,230,48,153,233,103,132,107,150,6,215,27,105,237,57,204,136,9,223,148,117,111,220,200,89,124,193,149,244,27,215,138,199,159,1,159,219,234,61,150,0,238,167,35,86,29,177,169,173,190,163,99,21,21,247,97,169,54,202,237,30,241,151,87,132,37,106,103,251,237,143,208,12,184,132,255,132,4,150,120,3,138,65,40,82,249,229,70,229,144,7,31,239,108,192,57,92,73,139,141,169,44,204,183,241,126,143,238,197,20,193,125,204,17,61,103,163,209,8,198,214,151,165,164,221,164,6,110,209,165,220,16,146,67,234,181,204,115,227,181,19,240,100,204,43,172,200,148,53,52,4,181,2,247,130,132,160,44,104,211,138,29,214,41,249,89,131,11,145,202,165,224,74,146,211,72,246,69,85,141,144,209,161,146,49,179,100,9,154,87,249,178,247,86,238,174,232,77,166,233,47,168,130,219,164,86,10,73,140,71,145,187,15,37,116,158,180,157,52,93,106,177,199,163,250,53,208,23,15,21,166,147,104,207,51,91,240,82,221,233,173,121,197,126,234,29,15,172,55,123,152,63,245,134,16,134,130,214,221,24,42,165,99,156,169,247,104,173,92,99,130,196,87,107,244,16,174,76,177,155,187,221,6,59,148,6,21,207,36,171,10,139,216,166,236,145,207,213,104,139,199,147,198,53,168,247,224,214,171,34,140,171,241,216,143,72,211,169,1,196,21,200,182,146,160,170,57,51,149,191,34,113,254,120,13,233,232,118,130,179,140,239,102,93,206,164,175,241,55,112,83,172,35,31,104,83,90,251,176,153,253,158,183,72,252,160,49,15,125,235,37,7,217,143,14,58,24,92,212,213,179,138,120,47,247,58,185,250,129,30,209,177,177,119,144,82,164,113,193,97,150,79,151,80,164,171,141,198,7,73,197,231,67,94,130,207,143,151,236,106,23,215,158,136,157,6,84,76,187,106,254,166,219,57,67,93,164,219,138,223,9,237,130,140,241,239,31,30,233,91,80,138,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b25d600-d510-46c6-a171-b6799f68c197"));
		}

		#endregion

	}

	#endregion

}
