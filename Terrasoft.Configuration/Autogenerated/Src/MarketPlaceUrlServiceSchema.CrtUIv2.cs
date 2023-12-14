﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketPlaceUrlServiceSchema

	/// <exclude/>
	public class MarketPlaceUrlServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketPlaceUrlServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketPlaceUrlServiceSchema(MarketPlaceUrlServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("003d20ad-2312-4bfc-9001-554beaef8041");
			Name = "MarketPlaceUrlService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,86,223,111,219,54,16,126,118,129,254,15,156,7,20,18,96,200,121,216,83,227,36,72,189,181,243,182,196,70,108,47,15,193,80,208,210,217,33,74,137,26,73,185,48,2,255,239,59,74,164,68,73,142,219,98,121,8,204,227,253,248,238,190,187,163,50,154,130,202,105,12,100,5,82,82,37,182,58,154,138,108,203,118,133,164,154,137,236,237,155,151,183,111,6,133,98,217,142,44,15,74,67,122,217,57,71,247,160,123,178,37,200,61,139,225,78,36,192,207,94,70,183,177,102,251,50,212,121,189,71,216,244,20,80,134,74,74,161,241,82,83,13,141,130,159,77,154,250,190,253,27,249,138,133,132,232,35,141,181,144,12,212,41,13,19,183,246,139,247,79,22,41,86,78,75,52,252,199,200,110,85,142,149,65,181,28,179,219,48,206,244,225,1,254,45,152,132,20,50,173,2,255,96,82,36,87,228,27,38,70,43,178,130,36,52,65,242,98,195,89,76,98,78,149,34,119,84,126,1,189,224,200,230,90,114,11,137,188,39,31,168,2,123,26,145,217,3,208,100,158,241,131,95,55,242,82,166,49,248,89,194,14,101,228,35,3,158,168,247,100,33,13,53,80,93,230,213,129,40,45,77,53,62,23,146,175,32,205,185,145,93,145,172,224,37,209,125,53,5,114,90,112,93,200,179,106,113,161,180,72,65,206,146,70,171,132,4,89,82,161,106,67,92,72,145,131,212,72,208,43,48,103,191,107,157,35,81,166,94,160,116,197,231,129,124,254,218,21,93,126,151,93,95,114,117,109,204,6,125,135,228,230,134,4,39,196,87,100,106,120,178,199,232,19,232,201,233,96,215,65,24,254,72,250,101,19,216,44,170,134,176,85,93,123,20,189,148,104,119,160,237,175,129,4,228,36,107,243,136,200,63,113,177,161,252,54,207,151,160,53,58,81,81,187,175,156,110,201,226,224,104,254,31,251,145,167,133,148,216,178,107,143,252,215,1,120,74,8,160,180,17,89,6,177,89,10,145,231,41,178,90,209,61,110,173,118,252,83,8,234,134,234,69,30,143,87,243,95,231,109,20,94,3,34,136,225,197,176,31,224,53,50,16,45,6,45,12,119,13,27,53,158,147,99,25,132,228,133,180,113,159,214,179,217,120,53,26,185,12,27,196,161,77,172,51,108,222,169,74,166,61,101,205,225,178,203,226,121,44,77,19,212,88,190,23,95,107,103,20,221,110,250,191,248,207,145,116,7,250,89,124,107,169,225,76,98,190,127,83,206,18,148,38,94,198,46,133,181,100,100,111,238,241,199,165,147,68,43,121,152,74,64,147,0,85,71,56,119,236,79,150,37,209,237,70,9,94,152,50,137,66,215,102,97,101,103,27,207,73,111,106,109,231,249,216,134,184,17,130,91,128,51,117,187,167,140,211,13,135,19,16,247,84,18,89,45,20,172,82,111,187,68,13,82,139,196,24,176,198,37,26,109,41,87,182,230,213,219,23,84,78,85,142,173,110,20,130,122,113,85,162,208,6,52,91,205,201,112,139,185,129,107,123,15,2,150,233,208,121,139,204,19,84,168,169,121,2,39,228,151,139,139,208,155,60,87,37,207,193,143,145,237,237,198,241,120,76,38,170,72,83,138,43,214,9,16,175,169,29,217,10,233,119,61,249,202,18,92,24,81,109,55,238,26,78,42,100,234,122,253,240,151,109,159,104,50,118,66,163,245,52,199,21,93,126,217,248,223,5,131,39,44,219,44,219,139,47,16,84,48,177,34,195,197,124,185,26,150,141,227,205,199,176,98,219,131,133,42,31,68,114,88,234,67,89,72,244,116,135,207,56,221,65,45,141,30,37,205,115,72,70,101,245,28,243,66,166,84,183,12,42,81,244,135,18,217,136,56,198,206,235,149,95,28,157,45,219,67,232,250,49,151,34,193,141,104,88,13,221,231,197,128,109,137,189,143,102,234,30,31,249,185,252,45,205,245,33,240,181,27,117,71,190,247,57,224,136,47,123,22,121,123,100,250,121,65,37,77,17,180,245,92,33,14,214,254,150,234,63,71,35,31,225,200,123,45,188,153,72,91,91,16,35,116,215,131,15,192,218,105,124,232,93,211,99,182,63,157,76,183,237,56,36,239,222,157,24,236,142,82,61,75,174,42,237,251,42,250,224,72,0,39,183,171,90,127,117,185,169,58,146,152,234,248,185,243,18,55,106,103,94,61,148,150,23,230,239,63,124,136,6,97,62,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("003d20ad-2312-4bfc-9001-554beaef8041"));
		}

		#endregion

	}

	#endregion

}

