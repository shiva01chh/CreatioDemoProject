﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchPredictionJobSchema

	/// <exclude/>
	public class MLBatchPredictionJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchPredictionJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchPredictionJobSchema(MLBatchPredictionJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2b6e42ee-2181-4aef-b68c-e8d939cc8db2");
			Name = "MLBatchPredictionJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,89,235,111,227,54,18,255,236,2,253,31,88,245,128,149,81,175,178,247,237,176,155,24,200,58,201,194,173,157,4,141,115,253,112,119,40,104,137,182,217,202,162,74,82,201,186,134,255,247,27,190,36,234,101,39,189,235,61,208,0,73,44,106,56,156,25,206,227,55,227,12,111,137,200,113,76,208,130,112,142,5,91,201,104,194,178,21,93,23,28,75,202,178,104,62,251,242,139,253,151,95,12,10,65,179,53,122,216,9,73,182,31,26,207,176,37,77,73,172,232,69,244,137,100,132,211,184,69,179,32,159,101,181,56,97,156,212,159,234,231,54,222,221,224,88,50,78,137,168,214,215,41,91,226,244,253,251,9,219,110,65,206,25,91,175,97,185,122,239,43,4,28,174,62,246,190,186,231,44,38,66,180,4,0,250,175,57,89,195,3,154,102,146,240,21,216,233,61,154,206,103,31,177,140,55,247,156,36,84,235,252,45,91,106,226,188,88,166,52,70,212,209,246,145,14,246,154,188,100,62,39,114,195,18,241,30,221,107,6,230,229,217,217,25,58,23,197,118,139,249,110,236,22,172,164,68,160,249,12,109,89,66,82,49,66,43,198,209,243,134,198,27,180,84,135,161,188,60,13,137,13,43,210,4,45,9,34,159,73,92,72,146,68,37,239,179,38,243,243,28,115,188,69,25,184,196,69,80,8,194,193,30,153,185,213,96,252,8,207,40,46,23,162,243,51,77,173,55,63,49,154,56,209,46,211,116,174,229,10,31,107,28,80,157,225,240,195,171,180,252,31,80,178,181,89,11,54,77,130,177,214,247,141,64,52,33,153,164,43,74,248,241,141,43,154,130,131,92,97,137,131,241,164,16,146,109,145,89,66,146,161,148,225,4,37,240,78,107,220,212,245,56,227,138,78,41,178,192,226,103,171,146,132,143,232,153,202,154,217,32,28,57,70,122,191,232,189,78,173,219,241,171,28,161,79,5,108,176,230,24,33,33,185,138,177,74,75,116,129,178,34,77,71,138,247,96,62,83,75,247,45,73,81,91,120,187,207,185,202,215,36,75,76,192,232,231,131,137,207,250,162,139,168,73,138,5,196,83,111,164,254,237,138,172,112,145,202,143,52,75,64,216,80,238,114,194,86,97,103,188,14,135,255,168,98,59,86,140,59,249,34,200,12,240,239,90,187,32,227,163,151,6,63,24,82,72,156,73,21,254,156,62,97,73,204,251,220,60,40,119,20,210,25,21,56,220,67,114,101,9,228,212,7,34,37,172,137,91,184,123,48,85,48,159,233,203,106,156,105,200,231,52,131,184,16,193,135,94,206,213,142,239,137,0,203,136,25,93,145,246,17,157,100,87,120,167,89,119,220,82,169,230,13,37,105,210,167,35,24,64,130,113,57,193,9,203,210,29,154,66,50,71,63,166,240,231,2,193,199,57,206,240,26,162,234,19,145,42,203,19,30,130,36,193,176,166,76,185,215,154,97,6,113,4,158,255,227,214,123,184,48,126,97,106,201,78,177,59,175,81,143,195,30,95,235,200,212,71,212,208,241,243,152,67,16,19,125,25,224,240,36,180,7,153,18,99,130,197,124,30,161,227,137,18,237,117,220,60,97,142,126,41,8,223,169,168,32,207,150,127,216,12,69,231,5,193,80,239,26,68,112,133,97,224,251,4,73,238,178,96,4,110,151,22,219,44,186,87,81,79,32,80,67,79,164,168,73,63,116,220,126,216,16,78,194,0,178,222,48,154,138,235,95,10,156,134,71,57,77,147,161,185,167,129,22,62,50,225,65,66,179,120,168,219,207,38,30,125,236,101,150,60,224,39,98,188,172,203,122,39,236,102,178,205,111,73,55,214,224,141,240,133,100,156,151,159,46,16,248,78,249,194,40,172,80,196,50,37,219,5,164,146,81,71,181,179,119,8,62,194,165,242,8,96,162,254,45,232,150,68,143,50,190,101,207,134,8,208,3,56,115,204,120,34,46,87,43,162,46,0,72,223,153,151,18,238,223,136,55,40,165,137,172,32,161,53,75,238,238,205,228,222,177,219,224,111,81,166,189,247,233,58,55,91,177,225,167,41,208,55,23,117,74,128,78,69,38,29,249,97,212,97,94,199,204,24,171,233,97,160,98,105,25,75,216,140,32,43,97,167,101,15,40,214,149,50,188,92,175,33,84,129,252,250,115,76,114,91,231,220,149,14,84,74,137,174,57,135,59,251,83,112,167,178,197,190,161,217,193,217,30,61,131,167,35,81,196,170,10,174,192,47,118,149,198,8,103,9,18,96,194,68,23,105,45,24,218,27,197,166,201,33,176,190,55,128,147,173,46,114,195,221,253,30,244,95,45,201,52,91,49,16,228,119,145,161,51,192,234,97,4,62,172,31,111,24,111,20,141,215,20,124,103,92,186,66,161,159,109,163,5,223,169,79,238,8,143,123,147,93,9,29,88,33,145,10,18,189,48,44,175,141,19,89,240,204,172,250,70,180,235,42,106,157,182,131,65,43,161,76,82,130,179,187,66,42,111,74,90,245,235,4,76,117,202,65,80,38,80,229,22,108,70,159,84,232,122,245,87,213,145,191,226,180,104,39,227,147,53,117,132,222,254,217,186,136,50,159,127,194,133,122,85,55,128,175,186,178,18,212,50,29,47,119,43,197,23,132,186,41,178,56,82,43,151,9,68,229,46,124,91,49,28,153,151,147,130,115,0,169,46,241,132,67,47,51,249,213,229,138,164,164,85,93,92,17,184,225,108,27,214,176,64,208,168,15,19,168,198,166,208,168,50,49,3,239,13,235,194,14,91,185,206,156,168,82,93,87,161,208,230,105,80,142,209,187,122,96,55,194,201,210,29,144,47,169,114,49,237,8,245,24,75,12,109,48,244,108,124,120,49,20,96,82,199,237,145,142,6,92,68,32,185,33,94,13,161,219,28,170,5,92,6,124,86,17,172,222,174,225,166,50,160,209,133,4,41,80,250,210,78,38,175,138,79,48,86,127,17,91,105,150,208,65,217,119,199,123,135,102,43,180,128,189,197,169,118,200,248,165,24,183,107,165,167,29,108,115,116,229,70,82,102,231,152,147,213,69,96,71,4,183,76,78,221,70,146,148,41,28,218,36,156,189,145,208,82,64,206,171,44,104,176,184,178,221,81,187,149,103,141,77,106,176,183,133,158,40,151,128,95,154,56,29,216,213,138,187,206,117,185,95,219,95,140,215,42,211,93,242,181,141,44,13,247,121,161,88,195,98,161,52,13,155,198,239,41,114,22,169,83,221,47,196,196,130,114,79,180,104,193,30,52,77,56,132,143,143,121,14,96,204,139,159,26,248,133,236,12,106,134,62,51,147,127,219,230,88,214,30,71,117,181,90,89,186,78,237,231,44,93,4,181,17,122,238,25,130,247,150,213,123,222,242,154,225,151,174,51,91,237,252,155,70,123,207,2,135,168,94,248,78,7,239,255,231,196,197,118,163,206,133,127,203,0,198,94,91,149,57,3,167,96,91,169,159,160,189,213,240,172,74,145,202,161,190,154,207,30,37,77,69,52,217,144,248,231,41,84,68,254,68,99,242,200,83,213,117,52,206,59,82,204,218,188,46,115,250,29,217,189,130,197,116,70,69,217,205,25,124,51,182,215,213,134,55,16,53,53,164,82,194,148,14,218,166,12,230,80,112,0,130,21,222,236,109,235,32,76,123,207,47,245,240,224,252,160,179,239,169,245,137,157,146,84,208,215,67,188,229,1,30,226,5,49,182,24,114,205,223,165,126,68,44,142,21,24,72,148,35,167,4,129,40,42,185,72,230,238,189,26,66,149,126,177,127,7,216,22,17,7,111,7,141,70,207,9,212,9,115,79,120,23,164,118,42,54,16,44,40,48,92,190,65,144,12,138,237,18,98,0,42,89,110,163,208,162,78,8,220,125,159,113,77,43,210,0,192,127,244,49,163,35,176,227,198,111,31,238,110,223,130,16,20,167,244,87,149,83,95,58,126,116,124,166,10,92,80,200,202,182,132,33,145,147,88,201,100,250,18,120,147,49,137,136,154,15,40,174,231,241,88,129,244,243,179,120,12,69,134,211,53,205,224,133,113,7,123,246,179,51,46,100,121,8,46,223,182,191,255,196,179,19,147,76,51,0,136,128,18,101,237,107,1,15,148,24,208,130,132,5,244,232,205,36,101,69,98,147,160,184,188,159,66,10,123,227,108,1,84,253,152,196,102,243,127,243,220,245,95,30,129,148,209,235,114,71,127,12,219,234,224,245,162,218,248,32,159,73,26,174,89,236,43,30,39,18,126,5,29,78,220,10,244,30,237,75,168,193,250,65,71,202,54,3,157,190,102,184,167,93,245,116,177,76,234,214,51,230,251,1,243,172,52,95,211,48,232,25,11,5,108,117,212,117,6,28,210,214,65,20,218,135,216,87,184,156,49,212,133,233,41,174,222,44,254,171,134,144,237,113,12,112,191,241,103,247,215,96,113,53,36,143,30,23,55,127,81,205,238,199,157,36,194,227,89,179,110,127,25,107,22,176,35,67,162,87,56,158,43,28,47,243,188,63,88,57,248,239,167,180,14,128,250,234,212,230,124,181,182,191,119,134,228,190,50,58,126,217,118,188,96,154,114,0,32,96,72,85,50,254,35,87,152,187,73,185,8,198,234,139,163,234,185,19,227,43,211,185,105,200,9,171,77,175,140,115,130,220,231,166,28,64,185,93,254,4,175,199,222,41,254,80,107,197,161,72,147,44,222,189,116,166,213,247,13,212,8,189,243,18,162,199,246,162,103,76,83,237,71,251,62,166,7,3,33,132,194,16,191,18,206,34,164,171,84,172,58,214,52,181,96,67,193,199,103,154,166,14,57,2,116,12,148,123,46,213,151,66,34,134,220,80,0,169,107,12,187,82,164,7,195,79,12,11,187,33,120,171,243,58,62,163,62,17,133,61,3,107,242,57,154,195,33,120,77,154,252,78,236,116,57,180,34,131,170,131,116,69,205,80,82,104,208,112,20,156,43,204,223,57,201,86,201,23,171,169,180,61,243,193,26,155,155,194,238,30,111,1,119,125,95,180,235,168,138,6,182,10,59,191,115,29,105,124,57,170,252,243,244,100,174,235,11,97,189,6,63,255,4,135,94,101,243,231,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b6e42ee-2181-4aef-b68c-e8d939cc8db2"));
		}

		#endregion

	}

	#endregion

}

