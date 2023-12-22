﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLScoringEntityPredictorSchema

	/// <exclude/>
	public class MLScoringEntityPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLScoringEntityPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLScoringEntityPredictorSchema(MLScoringEntityPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3b65463-960f-481c-bae3-a3def7879767");
			Name = "MLScoringEntityPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("53963cb6-da9d-462c-9472-5893a2d88bd3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,75,111,219,56,16,62,187,64,255,195,192,123,113,128,64,190,167,142,14,105,186,129,1,123,215,216,184,189,20,61,48,210,40,230,86,162,4,146,114,235,53,242,223,119,134,148,172,135,31,85,139,246,82,95,44,82,223,60,248,205,55,67,41,145,161,41,68,132,176,70,173,133,201,19,27,188,205,85,34,159,75,45,172,204,85,176,92,188,126,181,127,253,106,84,26,169,158,225,113,103,44,102,111,122,107,50,73,83,140,24,111,130,7,84,168,101,212,96,222,230,26,187,171,224,79,17,217,92,75,52,205,126,59,62,33,86,58,143,208,152,110,50,167,208,203,69,48,87,22,117,66,135,96,119,4,153,78,167,48,51,101,150,9,189,11,171,245,99,68,241,200,80,102,69,138,25,42,235,28,66,158,16,18,17,34,141,201,237,120,190,92,188,83,86,218,221,74,99,44,57,197,241,52,4,161,226,30,232,240,122,191,254,187,180,47,4,10,234,176,211,94,92,54,20,169,201,43,227,229,226,78,24,236,5,217,87,201,145,175,130,221,193,244,140,245,137,252,60,246,227,61,38,162,76,237,157,84,49,57,154,216,93,129,121,50,57,198,95,93,195,95,84,114,184,133,229,130,168,53,214,4,85,112,34,252,137,152,89,147,229,213,167,139,46,15,206,102,157,188,195,225,190,139,242,41,149,17,68,169,48,134,192,21,170,151,42,220,192,73,182,122,81,201,221,222,85,125,244,135,198,103,174,41,197,182,186,100,168,185,129,149,11,229,1,125,93,184,141,185,146,86,138,84,254,135,6,4,40,252,2,146,82,23,138,90,130,196,97,55,216,174,253,185,92,89,38,238,52,193,33,206,180,31,104,86,8,45,50,80,68,209,237,184,52,168,41,79,229,155,102,28,174,41,14,239,65,116,216,12,102,83,103,225,28,84,140,157,139,63,121,223,241,7,93,247,87,68,229,19,17,57,233,111,115,95,143,94,42,246,80,197,158,192,46,155,84,187,2,181,165,94,189,225,103,75,182,24,95,224,243,1,173,113,180,21,190,232,192,194,1,25,83,203,201,68,162,190,196,208,86,164,37,30,150,235,65,78,26,155,162,206,14,242,45,141,7,66,195,67,41,99,104,169,111,30,195,109,232,138,204,111,38,151,116,250,230,50,45,75,180,155,60,30,200,73,85,39,3,126,120,49,59,166,192,136,143,18,243,17,191,238,134,234,198,129,189,92,188,93,91,36,71,232,44,143,49,245,104,247,120,25,29,11,43,60,88,42,234,44,224,245,101,139,194,159,139,248,96,253,173,133,249,60,14,249,9,44,61,194,23,105,55,208,64,0,191,90,45,192,217,155,99,191,26,109,169,149,233,115,70,4,105,52,52,135,90,12,181,161,39,138,222,153,15,181,31,30,92,143,168,183,50,194,21,19,231,233,187,166,142,90,50,51,254,154,241,44,93,179,223,209,232,222,167,77,165,152,25,203,14,175,33,127,250,151,98,133,142,25,54,189,167,255,213,17,7,112,76,75,213,106,35,159,121,85,58,206,19,39,62,100,229,146,230,150,83,222,161,43,47,203,201,51,99,32,161,105,201,162,122,150,91,84,212,234,54,218,240,240,210,72,17,226,193,51,233,251,213,178,144,198,142,195,187,126,188,111,104,198,41,120,185,0,227,203,49,68,200,191,66,104,77,225,106,133,125,83,89,124,222,222,245,115,208,215,41,33,193,220,89,156,87,146,151,18,131,42,209,157,85,233,79,150,154,11,57,80,110,143,98,139,245,72,239,246,36,13,10,64,119,19,253,26,141,121,223,243,216,27,248,85,251,22,24,162,25,140,255,113,185,214,67,179,55,85,58,151,236,113,197,183,57,93,32,76,64,231,194,197,248,3,223,58,230,116,209,221,165,83,167,94,213,181,59,147,122,169,213,37,219,10,221,188,242,17,232,99,138,111,171,150,130,58,33,169,152,57,125,25,96,88,121,24,237,235,36,122,33,188,2,224,197,161,94,92,201,71,141,156,248,128,58,104,142,233,192,245,25,125,157,26,112,13,217,96,38,232,124,205,73,251,185,255,128,178,90,205,248,187,11,170,33,116,136,138,96,144,128,78,85,180,21,199,19,196,222,252,147,139,58,175,190,118,223,159,169,101,21,161,93,203,222,55,17,237,186,23,237,223,255,125,69,156,58,88,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3b65463-960f-481c-bae3-a3def7879767"));
		}

		#endregion

	}

	#endregion

}

