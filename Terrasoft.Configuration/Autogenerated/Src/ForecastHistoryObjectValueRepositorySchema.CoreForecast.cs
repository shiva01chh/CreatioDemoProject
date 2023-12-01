﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHistoryObjectValueRepositorySchema

	/// <exclude/>
	public class ForecastHistoryObjectValueRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHistoryObjectValueRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHistoryObjectValueRepositorySchema(ForecastHistoryObjectValueRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8bf41205-64fb-b91a-75e3-582cedcc0025");
			Name = "ForecastHistoryObjectValueRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,90,91,111,212,56,20,126,30,164,253,15,102,86,66,25,49,74,209,62,210,11,106,75,219,157,21,208,46,5,246,1,33,148,38,158,78,150,76,28,108,7,90,1,255,125,143,111,137,237,196,153,76,41,59,47,163,36,231,124,62,62,247,147,184,76,214,152,85,73,138,209,27,76,105,194,200,146,199,199,164,92,230,215,53,77,120,78,202,248,148,80,156,38,140,191,251,227,183,7,223,126,123,48,169,89,94,94,163,203,91,198,241,122,215,187,6,214,162,192,169,224,99,241,25,46,49,205,211,14,205,243,132,39,157,155,47,242,242,115,123,211,150,101,189,38,101,255,19,138,67,247,227,231,71,193,71,167,73,202,9,205,49,107,41,96,195,140,51,180,191,81,7,231,87,255,194,238,222,37,69,141,95,227,148,208,76,114,38,37,23,96,0,247,59,197,215,64,143,142,139,132,177,167,200,176,253,153,51,88,242,214,225,174,8,203,197,77,201,183,179,179,131,246,88,189,94,39,244,246,64,95,27,102,180,82,220,136,72,118,244,69,240,35,42,151,135,63,131,19,27,152,29,11,231,253,115,188,76,234,130,31,229,101,6,27,141,248,109,133,201,50,90,244,236,231,168,46,62,29,102,217,121,133,213,158,103,115,244,10,124,3,148,50,213,226,79,103,31,182,131,60,195,124,35,92,85,95,21,121,138,82,161,176,81,250,66,79,209,226,178,76,42,182,34,124,142,198,236,100,14,203,76,54,201,7,52,223,164,41,90,27,10,211,210,90,56,11,152,242,66,202,169,40,180,204,99,164,141,222,50,76,1,169,84,65,129,106,231,114,222,96,152,29,137,216,64,204,186,152,33,17,115,147,137,203,24,31,175,112,250,233,144,94,215,107,92,242,87,117,81,68,37,104,23,236,224,210,205,102,187,146,219,70,12,243,58,235,106,78,79,254,125,111,7,138,200,145,126,223,145,95,18,252,208,154,197,101,166,148,235,106,250,130,18,48,3,135,144,4,61,211,252,75,194,177,86,180,186,64,158,16,222,229,55,116,141,249,46,218,102,17,203,152,126,232,201,27,111,86,24,45,77,252,153,237,160,76,104,175,225,177,227,204,119,9,71,33,206,133,22,150,141,144,248,37,230,43,146,133,116,242,2,188,110,175,147,143,14,16,56,117,159,67,138,135,44,58,205,11,46,117,7,185,13,45,173,11,227,102,95,18,10,178,137,20,14,118,20,241,209,193,248,187,198,224,214,14,175,114,2,138,121,77,203,126,166,72,97,206,108,111,24,177,145,30,160,75,37,156,198,179,164,86,9,81,36,241,18,127,13,129,70,38,30,36,123,124,114,131,211,154,195,195,36,195,52,162,242,15,237,31,104,212,137,134,140,33,153,68,199,240,148,227,14,162,102,50,209,242,195,213,133,6,232,219,117,7,9,133,86,88,8,191,81,34,34,189,154,22,80,175,34,246,219,133,211,123,88,100,160,17,197,6,5,153,67,125,174,215,165,164,219,59,171,115,208,200,116,145,77,103,115,69,124,82,242,156,223,110,100,81,229,50,54,212,138,64,100,119,131,243,60,103,85,145,220,74,158,32,22,36,87,168,31,13,154,205,211,69,124,141,151,219,9,215,48,116,177,46,160,43,33,217,88,32,69,221,69,81,119,198,162,168,7,93,148,97,21,101,56,205,215,73,209,160,248,202,81,62,215,231,94,58,76,6,34,120,99,42,80,246,49,221,71,7,230,176,200,19,17,109,211,21,249,184,92,165,211,93,155,201,164,204,134,136,125,92,50,151,36,132,123,89,95,73,1,27,214,148,125,100,159,13,190,147,159,132,227,171,141,122,101,86,41,102,50,209,106,143,6,247,48,71,50,4,226,67,166,98,97,59,222,97,239,21,160,195,20,119,90,109,96,153,123,193,239,137,236,59,225,116,98,231,78,40,125,161,124,39,160,78,16,222,9,197,148,243,30,156,83,74,214,198,16,221,238,208,118,242,116,133,215,73,99,187,193,133,27,244,5,184,55,253,139,228,101,228,97,31,227,162,104,6,145,70,62,111,13,39,36,103,241,121,233,222,209,81,160,215,130,197,216,201,231,58,41,126,94,39,173,212,170,192,189,76,110,160,160,225,70,74,21,191,78,2,26,212,137,147,31,90,121,207,195,230,115,56,134,124,124,203,77,135,163,100,18,31,150,217,150,242,116,156,115,75,105,66,206,125,23,89,58,113,187,165,44,161,184,87,178,248,126,39,220,97,186,121,9,79,84,205,102,220,236,159,21,166,56,178,252,161,194,229,81,65,210,79,99,19,56,248,33,199,217,121,175,6,23,236,76,250,46,141,212,211,248,34,161,64,32,110,216,205,189,120,179,129,103,13,27,8,65,127,98,117,88,85,14,103,173,24,199,5,97,88,109,74,223,132,10,169,2,200,110,107,85,231,126,145,92,227,228,170,192,58,192,212,163,57,234,105,220,243,37,138,206,10,114,149,20,135,85,117,137,57,135,242,204,98,168,168,231,203,37,204,41,167,152,167,43,64,19,69,251,251,119,7,32,86,183,117,19,177,15,21,25,4,54,253,67,43,141,19,221,241,37,161,92,115,60,84,28,122,131,207,116,101,7,181,65,47,116,116,27,98,131,82,74,205,252,28,34,81,122,188,72,248,202,168,239,169,135,126,200,210,13,165,121,134,60,245,254,176,187,110,214,62,8,246,94,158,13,156,217,5,102,255,77,29,152,48,204,120,117,119,229,210,2,59,92,149,3,17,182,230,182,174,209,47,70,108,209,69,246,210,250,193,220,145,39,126,77,190,178,99,82,151,124,102,203,47,163,94,217,229,228,166,162,152,49,49,29,167,164,204,114,225,4,234,137,191,151,174,151,161,103,200,246,75,237,34,226,53,37,63,82,73,37,232,112,150,55,161,167,189,40,239,159,124,104,27,212,204,248,39,8,229,186,64,227,185,241,105,78,25,111,89,154,221,152,129,64,117,201,241,201,186,226,183,173,45,28,109,189,16,47,101,5,185,200,20,68,190,201,57,167,146,33,154,53,230,24,35,203,43,124,163,69,153,116,228,232,95,209,54,143,16,159,84,242,149,175,238,201,221,117,206,213,179,72,216,32,100,239,121,171,51,109,122,141,40,102,239,99,35,83,228,217,124,174,77,33,214,148,78,210,166,229,105,42,41,26,129,167,115,79,197,102,98,215,49,89,57,34,11,253,43,243,190,33,102,51,145,150,200,157,240,93,62,32,175,162,33,143,238,207,20,67,141,209,216,49,173,51,113,173,179,241,51,87,59,203,73,174,213,47,157,182,238,121,198,184,159,166,254,127,155,84,78,235,50,141,193,212,129,46,72,141,161,118,107,243,75,135,10,187,59,119,87,184,143,41,226,190,134,8,221,220,245,107,172,93,235,5,84,6,72,128,114,69,21,82,86,115,214,212,96,187,95,51,23,139,204,116,109,131,205,242,216,134,189,211,36,58,117,197,188,56,154,245,247,112,34,205,63,116,24,212,226,139,140,233,142,176,155,228,117,178,26,47,251,144,163,46,202,206,6,188,202,216,8,52,115,234,116,87,114,243,166,237,30,37,15,6,234,102,177,27,105,92,177,149,8,218,252,103,148,212,21,180,158,63,153,195,182,196,9,228,176,45,81,2,170,217,18,165,207,53,156,146,183,177,241,13,198,158,120,35,218,20,42,8,128,13,21,140,217,21,204,122,215,61,84,132,76,154,29,202,21,189,25,117,84,190,27,76,71,242,37,98,48,5,88,219,246,231,10,79,139,95,8,104,105,81,2,83,153,20,111,171,12,238,233,116,111,190,129,44,78,202,122,141,169,232,59,250,62,156,232,175,14,70,189,226,59,86,146,174,80,212,126,37,65,121,233,83,201,90,95,203,213,116,173,87,75,123,106,110,220,100,108,37,50,225,9,195,67,51,110,117,135,93,1,235,41,76,201,215,18,207,188,81,127,196,107,156,16,166,225,81,150,80,251,212,253,175,210,128,249,48,20,217,137,98,200,76,139,18,180,196,61,51,13,126,219,157,163,237,172,40,204,147,203,85,180,121,212,146,126,20,64,26,228,100,219,110,161,109,246,114,46,62,135,19,42,85,102,218,121,3,35,228,95,56,4,145,197,74,228,64,7,44,79,118,183,113,59,197,246,248,177,214,191,218,162,122,139,205,162,62,239,233,118,9,61,206,99,180,220,83,225,93,87,236,157,252,7,188,209,162,239,5,236,201,158,97,52,235,163,86,47,88,215,183,195,88,131,64,126,101,8,195,152,26,217,11,227,151,169,48,140,223,227,56,48,163,181,237,12,106,178,189,48,78,182,239,121,170,152,179,212,152,101,252,74,146,107,111,178,62,169,49,53,43,251,109,72,227,120,94,224,55,14,218,250,117,67,251,171,226,208,244,37,250,175,237,173,180,36,7,232,9,122,244,8,141,222,91,255,206,236,148,182,249,0,194,166,243,18,48,165,55,31,224,57,105,143,78,12,28,93,10,28,164,144,119,42,97,84,36,78,165,236,79,77,40,79,15,78,253,3,25,123,59,146,176,159,79,139,51,61,208,233,216,38,214,167,53,100,10,7,209,127,73,194,30,44,13,45,168,57,99,160,138,218,141,56,125,112,211,22,61,225,233,153,58,111,101,226,96,176,51,216,128,246,208,71,251,49,96,211,51,240,181,49,134,100,163,45,185,194,24,204,120,41,254,6,77,103,119,237,96,118,121,37,94,223,192,101,135,79,245,133,236,160,181,13,84,34,35,217,222,142,121,108,89,125,131,25,97,219,205,89,19,33,41,146,98,143,120,91,235,14,121,161,51,86,238,135,174,238,241,169,48,167,77,53,235,156,185,9,159,249,233,190,241,239,15,123,117,215,189,41,239,193,239,63,46,172,91,70,38,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8bf41205-64fb-b91a-75e3-582cedcc0025"));
		}

		#endregion

	}

	#endregion

}
