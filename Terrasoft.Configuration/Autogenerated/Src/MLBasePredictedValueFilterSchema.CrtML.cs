﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBasePredictedValueFilterSchema

	/// <exclude/>
	public class MLBasePredictedValueFilterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBasePredictedValueFilterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBasePredictedValueFilterSchema(MLBasePredictedValueFilterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("483dda1b-7930-4626-9dc7-57f2d131894d");
			Name = "MLBasePredictedValueFilter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55d0c38a-eaf5-44ed-bcf3-8e3362908804");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,223,79,219,48,16,126,46,18,255,195,41,123,1,169,36,239,208,230,97,21,76,149,218,13,13,182,119,55,185,164,150,28,59,178,29,80,134,246,191,239,206,166,165,73,161,163,82,173,248,124,63,62,127,223,157,181,104,208,181,162,64,120,68,107,133,51,149,79,23,70,87,178,238,172,240,210,232,116,189,58,63,123,57,63,155,116,78,234,26,30,122,231,177,185,217,239,107,101,54,66,93,95,47,76,211,144,243,202,212,53,153,223,206,15,179,178,199,251,39,22,63,178,167,183,218,75,47,209,189,231,176,94,165,75,237,209,86,132,159,29,200,229,139,197,154,80,195,66,9,231,174,97,189,250,42,28,222,91,44,101,225,177,252,45,84,135,119,82,81,76,240,206,178,12,102,174,107,26,97,251,252,117,207,1,80,146,173,135,173,208,165,66,11,149,177,128,140,163,135,74,162,42,161,141,9,185,16,185,144,145,51,50,182,39,46,144,238,50,103,7,169,219,110,163,100,1,5,227,58,9,107,242,18,160,237,111,114,199,21,233,42,247,214,120,100,239,120,60,134,30,12,143,91,4,69,18,160,77,247,62,135,32,38,237,46,9,56,79,242,22,96,81,148,70,171,30,150,36,29,240,127,206,235,90,104,193,89,190,161,95,133,124,23,201,122,149,92,222,188,66,67,93,70,116,67,168,4,177,69,203,106,29,193,125,43,252,203,161,165,14,211,24,249,27,109,95,160,70,127,3,142,150,191,167,139,81,144,243,182,43,188,177,92,46,208,123,130,154,165,166,54,18,74,254,65,7,2,52,62,131,164,120,161,169,243,77,5,158,136,155,57,68,40,44,86,243,228,61,125,30,208,147,62,73,150,71,13,63,32,56,88,90,97,69,3,154,70,107,158,116,131,251,37,57,75,196,54,40,246,198,116,150,133,136,168,80,236,147,143,59,228,98,196,216,176,192,37,240,172,78,38,35,167,249,200,141,167,105,242,31,130,215,232,183,166,252,12,183,11,161,20,41,251,188,69,61,156,19,141,100,246,6,54,200,138,178,250,155,126,55,60,180,217,79,203,103,136,140,137,35,129,241,123,192,219,145,127,97,84,215,232,64,220,119,50,36,57,175,59,173,227,225,43,128,147,105,44,186,78,249,88,118,140,252,40,208,162,239,172,118,249,172,200,169,53,113,150,21,57,92,129,172,162,63,52,162,63,160,130,120,9,44,77,1,21,61,57,87,64,81,149,160,79,14,163,220,187,100,7,93,241,36,173,239,132,130,141,49,10,126,104,106,201,174,29,246,200,197,109,228,63,50,52,165,49,15,239,210,136,140,105,124,31,101,37,139,240,200,255,12,151,132,120,215,93,11,197,250,192,23,57,209,46,209,58,52,6,27,253,254,1,183,103,228,253,93,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("483dda1b-7930-4626-9dc7-57f2d131894d"));
		}

		#endregion

	}

	#endregion

}
