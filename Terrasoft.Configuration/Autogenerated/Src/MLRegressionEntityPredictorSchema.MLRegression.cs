﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLRegressionEntityPredictorSchema

	/// <exclude/>
	public class MLRegressionEntityPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLRegressionEntityPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLRegressionEntityPredictorSchema(MLRegressionEntityPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7403bef1-8736-4cee-aa53-a71b6b7f8596");
			Name = "MLRegressionEntityPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("97d940bd-1454-46d7-84c7-92245c2594a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,77,111,218,64,16,61,83,169,255,97,68,47,32,33,115,79,136,15,105,218,8,9,90,212,144,94,170,30,54,222,1,182,197,107,119,119,77,74,81,254,123,103,119,109,252,1,49,164,106,47,141,34,197,94,191,249,122,243,102,54,146,197,168,83,22,33,204,81,41,166,147,133,9,222,38,114,33,150,153,98,70,36,50,152,78,94,191,218,189,126,213,201,180,144,75,184,219,106,131,241,101,227,157,76,214,107,140,44,94,7,183,40,81,137,232,0,51,17,242,71,121,248,54,81,88,127,11,222,179,200,36,74,160,46,207,171,73,17,98,166,146,8,181,174,103,72,104,194,15,135,67,24,233,44,142,153,218,134,249,251,39,92,42,130,19,6,68,156,174,49,70,105,156,9,36,11,2,35,66,164,112,113,213,29,79,39,239,164,17,102,59,83,200,133,77,162,59,12,129,73,222,0,237,63,239,230,31,51,243,68,160,160,136,60,172,132,254,114,131,11,150,173,205,181,144,156,138,232,153,109,138,201,162,119,24,165,63,128,15,196,63,92,193,116,66,37,105,163,131,50,101,170,245,129,82,158,147,113,255,107,171,215,189,191,17,79,50,178,9,95,228,55,37,19,17,65,180,102,90,19,190,4,54,146,133,11,250,122,205,52,54,206,139,160,228,106,231,58,209,121,163,112,105,73,118,161,51,139,209,23,48,115,97,60,160,217,43,119,48,150,194,8,182,22,191,80,3,3,137,143,32,200,156,73,146,38,117,203,172,176,218,140,150,60,109,235,92,49,193,62,212,176,25,107,148,50,197,98,144,68,210,85,55,211,168,40,85,233,245,219,13,231,20,202,158,65,180,63,12,70,67,103,225,28,228,132,181,164,208,187,175,185,132,122,132,62,49,249,64,60,246,154,199,118,202,58,79,57,135,40,185,167,177,206,41,117,47,69,101,104,72,46,236,179,33,91,228,45,172,222,162,209,142,188,212,183,29,172,108,64,112,154,4,177,16,168,218,72,218,176,117,134,251,215,249,89,78,74,155,180,200,14,146,13,77,49,161,225,54,19,28,42,250,27,115,184,10,93,171,237,151,222,9,177,94,182,51,51,69,179,74,248,153,180,228,173,210,224,215,140,37,72,167,24,217,106,184,173,242,231,246,92,245,56,176,23,141,183,171,74,229,0,29,39,28,215,30,237,30,219,209,156,25,230,193,66,166,153,1,251,222,110,145,250,186,136,15,43,193,57,211,223,187,161,125,2,67,143,240,40,204,10,74,8,224,79,163,24,56,123,125,232,87,161,201,148,212,77,206,136,32,106,14,45,162,10,67,85,232,145,190,251,13,81,56,176,43,235,14,213,70,68,56,179,140,121,222,6,52,80,83,75,137,223,237,158,158,129,117,216,233,220,248,124,169,7,35,109,20,53,108,0,201,195,55,10,18,58,74,172,233,13,253,157,29,20,15,135,124,228,99,214,217,48,5,143,138,165,41,114,107,75,187,210,234,112,34,180,25,61,31,46,132,157,139,8,79,151,206,137,175,59,111,124,174,218,158,111,172,171,101,156,111,176,251,49,31,84,163,245,131,247,66,105,243,81,229,59,189,215,191,172,204,126,187,98,61,249,26,22,180,146,173,110,151,98,131,146,22,138,137,86,118,81,42,140,18,197,207,94,126,47,23,164,165,168,27,94,55,227,157,144,165,27,146,233,4,180,111,252,57,179,242,47,180,92,74,164,16,241,73,241,58,73,228,119,220,94,194,199,180,10,227,147,234,41,248,203,117,253,236,32,188,88,205,47,18,98,145,197,105,209,221,177,13,22,215,71,125,248,105,35,1,186,91,239,223,40,205,251,30,115,111,224,223,170,55,206,57,202,65,254,201,229,90,108,231,198,250,170,221,233,135,125,223,36,116,89,89,2,106,151,59,242,207,246,134,211,199,21,224,46,184,34,245,65,177,247,26,233,84,55,80,90,247,154,111,161,138,132,106,97,10,143,97,238,161,179,43,2,55,66,192,147,251,158,111,169,82,73,182,28,21,148,69,149,23,109,94,149,239,76,105,224,97,119,209,10,99,102,43,42,107,107,100,254,7,90,170,12,225,255,46,161,146,208,191,160,155,99,237,172,4,240,204,88,55,207,205,255,145,38,230,17,170,77,108,252,159,69,167,244,75,63,191,1,76,25,58,1,50,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7403bef1-8736-4cee-aa53-a71b6b7f8596"));
		}

		#endregion

	}

	#endregion

}

