﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchDtoSchema

	/// <exclude/>
	public class GlobalSearchDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchDtoSchema(GlobalSearchDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd70210c-7d4d-40b5-b6b0-8dc41428dcb8");
			Name = "GlobalSearchDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,223,79,219,48,16,126,6,137,255,225,84,94,64,66,233,59,43,149,160,80,196,52,58,212,86,123,65,60,184,206,181,53,36,113,102,95,24,29,218,255,190,179,211,54,41,13,45,41,211,80,37,226,31,223,221,119,231,239,206,78,68,140,54,21,18,97,136,198,8,171,199,20,116,116,50,86,147,204,8,82,58,9,174,35,61,18,209,0,133,145,211,75,210,7,251,175,7,251,123,153,85,201,4,6,51,75,24,127,121,51,102,124,20,161,116,96,27,92,99,130,70,201,181,61,253,44,33,21,99,48,224,85,17,169,223,222,87,177,171,135,191,136,225,142,205,87,91,94,40,88,246,50,229,208,207,74,226,173,14,49,10,46,5,9,166,78,70,72,98,0,67,154,205,38,180,108,22,199,194,204,218,243,113,31,83,131,22,19,178,96,125,76,192,195,148,125,33,144,134,81,26,7,11,96,179,132,188,47,27,127,224,137,52,27,69,74,130,140,132,181,112,145,198,121,126,250,11,83,167,112,33,44,46,134,188,255,213,19,90,99,228,39,114,44,184,124,0,137,39,76,130,229,214,50,135,156,196,45,198,35,52,71,61,62,55,56,131,6,105,253,212,56,118,140,22,148,84,66,48,228,89,112,231,180,183,55,65,151,12,254,176,243,143,63,27,152,12,53,137,8,198,58,75,66,78,139,212,38,180,181,184,48,186,138,140,51,186,3,155,174,50,150,64,177,92,216,78,136,47,76,204,64,130,47,180,56,185,159,25,154,89,13,130,14,219,53,58,94,231,216,155,175,236,66,243,155,98,150,122,204,11,136,32,13,142,207,26,107,130,184,98,181,211,172,209,108,179,55,75,34,145,88,39,177,33,79,173,114,118,62,91,239,120,105,131,51,177,33,146,121,52,53,171,131,75,3,208,59,216,94,33,39,176,172,235,81,132,219,235,37,39,158,151,73,117,10,114,207,110,180,154,8,75,198,181,133,171,229,242,150,19,172,178,173,194,74,155,55,225,14,182,164,142,178,56,249,33,162,12,237,170,213,75,229,91,34,167,171,149,59,56,1,61,122,228,62,217,134,78,9,180,131,79,95,175,185,141,237,62,243,255,247,15,109,232,150,96,159,86,139,152,76,12,78,124,23,255,47,202,57,47,252,109,233,174,195,89,138,190,115,228,180,234,244,51,70,86,42,195,155,220,165,189,58,28,199,38,106,117,85,6,157,59,204,187,84,252,234,206,124,36,203,128,106,240,241,251,215,59,104,199,77,239,38,163,197,137,163,241,231,196,77,129,6,83,97,82,30,203,72,177,114,78,64,164,41,127,89,40,248,128,32,206,192,40,35,228,131,37,226,92,216,74,117,173,202,135,47,229,92,63,37,159,167,133,199,160,152,182,193,77,49,40,36,118,200,170,115,26,191,51,154,249,17,115,58,133,59,239,98,153,231,150,74,166,140,164,80,75,104,182,215,143,172,175,53,93,69,24,227,198,124,125,208,88,111,249,126,251,180,41,206,45,118,181,137,197,63,160,229,202,153,227,251,64,161,28,98,18,230,57,93,77,48,91,96,91,153,36,109,214,83,188,46,229,142,65,166,111,151,215,235,219,11,185,226,224,221,109,44,248,161,195,132,178,212,66,136,99,145,69,196,245,224,169,115,199,146,58,116,177,240,179,208,189,65,223,41,145,121,220,85,14,142,142,231,177,151,179,193,21,228,197,44,125,239,106,62,178,229,198,71,242,113,139,52,213,97,125,181,45,233,28,229,183,141,187,116,22,188,12,71,110,18,31,29,83,124,102,61,23,5,240,221,239,118,160,227,13,244,120,150,127,252,247,23,86,151,170,124,72,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd70210c-7d4d-40b5-b6b0-8dc41428dcb8"));
		}

		#endregion

	}

	#endregion

}

