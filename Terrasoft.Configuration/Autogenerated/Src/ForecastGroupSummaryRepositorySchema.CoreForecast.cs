﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastGroupSummaryRepositorySchema

	/// <exclude/>
	public class ForecastGroupSummaryRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastGroupSummaryRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastGroupSummaryRepositorySchema(ForecastGroupSummaryRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2dfdff3f-28f6-4076-b72f-116a96a6cf01");
			Name = "ForecastGroupSummaryRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,77,111,227,54,16,61,123,129,253,15,132,219,131,140,26,58,236,113,243,133,52,181,93,3,233,110,26,167,233,161,40,10,70,26,219,44,36,82,33,169,44,12,195,255,189,195,15,201,164,100,59,238,230,224,128,212,204,155,55,195,55,67,114,90,130,170,104,6,228,9,164,164,74,44,117,122,39,248,146,173,106,73,53,19,60,157,10,9,25,85,250,249,211,199,15,219,143,31,6,181,98,124,69,22,27,165,161,188,232,172,209,181,40,32,51,126,42,157,1,7,201,178,158,205,61,227,175,251,205,48,108,89,10,126,248,139,132,99,251,233,132,107,166,25,168,163,6,83,154,105,33,157,5,218,252,32,97,133,252,200,93,65,149,250,76,154,244,102,82,212,213,162,46,75,42,55,143,80,9,197,208,105,99,61,254,250,5,150,180,46,244,207,140,231,136,159,232,77,5,98,153,204,27,215,158,215,243,167,209,152,124,193,202,146,43,50,180,192,195,209,223,8,84,213,47,5,203,72,102,34,191,19,152,236,153,29,32,53,216,90,98,109,46,83,6,69,142,201,60,72,246,70,53,184,143,149,91,16,91,160,205,34,91,67,73,127,175,65,110,240,144,234,146,147,127,86,38,178,91,92,120,60,224,185,131,140,241,81,17,74,203,218,212,209,68,177,105,248,32,46,165,211,201,36,127,40,144,136,193,157,52,72,29,45,199,100,254,128,66,17,121,144,125,213,217,24,155,88,131,182,226,142,116,96,159,117,54,70,214,254,51,121,161,10,146,110,184,30,120,223,157,108,201,238,116,73,126,3,189,22,231,215,124,202,10,109,88,52,237,65,102,160,39,234,213,151,202,150,205,153,36,141,165,233,65,178,12,22,174,6,131,16,218,159,164,132,37,72,224,25,184,245,184,31,158,128,122,197,164,44,2,158,164,233,146,214,201,153,205,246,98,240,202,253,113,184,237,0,167,230,203,46,221,134,172,210,192,241,129,234,245,110,120,97,163,132,234,66,48,140,159,222,230,185,91,39,167,99,143,28,194,27,149,72,50,19,50,87,8,16,197,124,180,219,243,92,221,164,79,226,158,41,157,140,200,205,13,225,240,141,152,213,229,172,102,249,117,210,199,177,129,16,204,24,190,123,68,137,169,217,30,194,17,248,94,132,144,64,122,47,86,44,163,197,87,20,162,157,177,136,215,221,90,224,33,101,58,253,42,157,123,16,252,127,120,223,242,220,185,179,37,73,60,3,51,221,53,101,92,37,166,72,233,164,172,244,102,212,72,163,161,137,5,46,197,27,132,38,23,145,129,99,130,7,106,82,76,239,36,160,232,231,234,75,93,20,94,197,239,156,176,135,219,245,216,33,136,208,54,98,210,99,117,40,168,11,247,39,211,235,7,42,17,25,23,170,109,161,178,162,146,41,193,159,112,96,167,147,215,154,22,190,135,6,167,233,141,73,91,44,28,54,151,226,229,95,60,79,212,19,138,237,22,175,22,67,45,74,32,60,29,67,47,228,235,13,113,251,87,134,167,35,179,181,151,73,18,245,118,191,135,67,237,232,90,242,72,195,246,195,46,158,57,111,130,229,228,64,156,227,3,133,156,49,75,250,67,167,55,80,162,214,108,163,223,152,151,195,132,102,235,100,221,108,205,241,250,39,87,215,205,177,250,65,20,125,222,15,146,147,19,40,242,73,251,211,199,106,106,175,94,119,248,42,102,146,62,211,162,134,189,202,6,70,85,174,88,234,148,180,143,240,109,36,49,216,17,40,20,156,129,250,157,218,29,28,33,112,248,123,147,101,67,206,201,118,20,10,232,140,43,78,104,236,0,200,27,193,249,37,193,25,33,37,203,241,241,72,95,10,184,131,162,48,47,129,178,93,77,165,40,157,116,18,247,143,48,164,212,84,220,76,213,204,248,92,217,123,58,61,230,106,125,28,127,99,222,78,127,244,51,159,240,161,169,77,149,252,229,98,243,245,55,64,120,9,89,233,144,159,200,112,158,15,227,198,50,160,113,67,245,242,235,235,31,131,250,203,27,175,241,100,177,6,208,68,153,95,124,206,76,120,93,226,17,96,38,151,238,101,115,237,223,28,106,206,151,194,191,101,2,163,248,89,115,221,54,169,89,169,49,57,218,192,97,33,81,86,77,29,99,106,158,84,72,160,27,32,194,116,165,121,127,50,96,52,11,109,194,57,235,199,216,160,243,234,59,0,124,240,210,116,58,141,111,219,163,143,165,179,103,104,183,11,3,252,88,12,104,120,162,55,220,110,188,105,247,240,239,63,214,166,180,73,75,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2dfdff3f-28f6-4076-b72f-116a96a6cf01"));
		}

		#endregion

	}

	#endregion

}

