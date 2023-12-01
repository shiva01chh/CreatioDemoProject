﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastRowRepositorySchema

	/// <exclude/>
	public class ForecastRowRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastRowRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastRowRepositorySchema(ForecastRowRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("564f6d57-a285-4c87-9965-c47412021027");
			Name = "ForecastRowRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,91,111,219,54,20,126,118,129,253,7,66,29,6,25,112,149,117,47,5,114,113,209,56,78,97,160,151,44,73,187,135,162,40,104,137,178,185,74,162,75,82,113,141,44,255,125,135,55,137,146,37,219,89,187,62,52,33,117,206,119,14,207,157,76,129,115,34,86,56,38,232,150,112,142,5,75,101,52,97,69,74,23,37,199,146,178,34,186,100,156,196,88,200,143,127,252,242,228,254,151,39,131,82,208,98,129,22,25,155,227,236,248,120,194,242,28,136,222,176,197,2,182,79,170,239,55,27,33,73,222,94,3,116,150,145,88,225,138,232,53,41,8,167,241,22,205,27,90,124,171,55,125,181,148,168,238,47,156,244,237,71,23,231,189,159,166,133,164,146,18,209,75,112,137,99,201,184,161,0,154,167,156,44,64,117,52,43,36,225,41,24,237,24,205,156,121,174,217,250,154,172,152,160,192,176,209,212,71,71,71,232,84,148,121,142,249,102,108,215,87,156,221,209,132,8,148,19,185,100,137,64,146,161,5,145,136,22,41,227,185,54,56,74,57,203,81,106,97,17,103,235,200,129,29,121,104,171,114,158,209,24,24,173,42,189,154,12,148,211,182,148,209,27,183,75,130,74,65,56,138,89,81,24,183,68,21,241,81,155,250,148,19,89,242,66,140,65,0,130,67,128,241,82,74,120,116,122,228,62,40,202,15,128,55,169,224,80,107,121,175,78,123,130,132,250,239,65,91,169,91,179,9,39,88,130,153,224,244,8,23,9,50,18,124,169,63,170,231,235,146,38,86,76,56,60,217,161,202,107,112,143,4,67,101,20,188,193,82,173,18,77,196,46,5,86,152,227,28,21,144,90,103,129,88,18,34,131,177,115,14,210,107,237,111,80,72,19,118,243,197,58,9,129,145,102,210,120,200,203,201,45,78,119,178,230,25,103,211,162,204,9,199,243,140,156,170,243,142,213,97,194,27,173,129,214,99,132,12,188,201,120,43,100,167,53,174,73,206,238,136,54,194,124,3,118,136,14,181,3,77,2,235,144,67,181,159,51,150,89,121,161,246,22,77,148,106,3,19,55,79,73,145,152,116,236,77,77,195,171,147,124,83,37,199,163,115,84,165,104,66,50,34,9,186,55,88,15,149,51,225,7,227,201,97,233,185,79,155,29,121,106,141,222,35,94,57,226,64,39,96,190,16,193,216,122,123,77,229,18,121,69,99,150,232,84,115,59,179,164,215,79,146,151,4,209,20,17,173,79,40,134,104,137,5,154,19,82,32,81,198,49,17,34,45,179,108,99,205,150,140,80,138,51,65,16,131,52,226,107,42,72,191,159,187,140,116,165,148,16,72,233,190,223,255,147,12,11,113,140,250,113,122,221,190,199,65,145,117,130,13,10,109,25,56,28,23,59,188,31,43,101,118,234,162,156,174,108,224,212,135,216,91,17,174,122,210,49,186,210,32,59,114,241,210,235,17,42,74,231,144,151,90,86,210,29,14,86,43,157,75,77,191,31,90,150,43,137,114,137,165,118,122,250,19,116,216,86,96,48,208,70,105,186,248,16,191,247,245,192,79,23,36,197,101,38,207,105,145,64,159,15,229,102,69,88,26,238,241,249,112,132,222,129,151,209,25,10,44,127,48,252,188,3,173,83,250,80,179,52,34,162,147,14,245,13,19,163,67,107,71,103,16,113,122,7,45,206,248,116,101,22,72,72,104,35,49,56,10,39,172,128,60,157,193,248,134,50,24,225,160,209,156,33,88,188,197,5,134,5,140,104,242,141,222,62,237,212,108,172,59,103,141,107,58,203,23,23,19,122,105,155,73,203,109,123,3,222,65,182,230,135,47,101,99,93,119,170,83,90,64,113,161,50,97,49,58,242,35,109,207,60,162,40,7,106,2,59,27,119,128,195,55,8,73,75,53,184,195,89,73,162,201,146,196,95,95,241,5,116,214,66,190,131,58,23,170,218,10,238,111,66,15,141,105,6,131,22,42,24,88,227,152,175,58,214,31,30,97,34,206,36,224,168,236,50,86,178,75,107,250,75,223,242,222,225,238,221,0,213,242,141,201,181,71,156,177,33,160,62,98,3,181,255,132,206,169,179,6,140,151,2,95,68,115,163,107,18,129,152,20,122,32,171,74,143,25,169,120,93,170,59,186,160,214,104,124,187,135,205,80,53,45,219,171,108,123,125,166,25,7,237,51,160,151,47,81,184,181,121,102,42,150,185,96,108,84,162,157,246,9,26,135,5,89,35,136,32,1,125,87,145,59,199,132,65,51,180,130,17,106,199,224,112,79,250,189,53,215,144,158,58,97,10,206,77,188,36,57,254,179,36,160,54,232,57,21,223,66,208,68,221,150,132,254,162,74,228,208,198,207,29,230,136,136,111,112,60,165,243,22,127,43,71,34,159,192,214,156,145,143,106,66,8,0,35,208,79,57,84,163,192,37,178,204,139,104,38,94,101,107,188,17,55,68,93,41,65,164,26,75,12,135,141,118,96,60,233,8,63,171,61,156,229,166,18,101,38,204,114,150,184,147,88,136,253,10,71,151,208,5,102,224,28,92,196,228,124,243,97,150,132,10,38,82,168,93,210,239,24,8,122,149,36,32,222,88,223,140,224,194,104,160,227,100,150,116,14,230,163,14,135,192,17,71,38,135,205,161,136,71,225,59,70,217,208,10,82,151,117,26,227,236,61,84,21,108,75,82,123,235,6,208,98,25,189,42,146,147,45,118,208,61,84,107,115,121,50,187,127,193,44,121,85,141,68,161,83,62,135,49,137,10,86,220,66,131,140,166,223,74,156,141,182,52,52,234,15,204,17,97,202,82,35,237,12,238,87,19,200,132,83,54,255,27,44,15,125,102,56,252,233,138,4,58,207,32,105,172,205,247,139,152,9,85,11,205,183,48,184,130,126,195,146,224,177,108,46,203,77,20,59,246,222,16,189,38,41,225,4,66,203,208,235,88,237,14,3,180,39,4,84,110,114,146,26,28,240,121,163,220,168,10,100,96,91,2,219,109,205,28,22,134,255,208,195,130,116,135,19,58,65,46,22,115,184,8,64,134,128,168,95,131,10,21,98,89,243,64,25,182,153,142,238,219,26,63,160,130,73,160,40,139,36,176,45,198,76,39,209,148,115,198,67,11,236,218,143,92,170,225,83,21,156,153,36,249,59,38,47,21,231,244,123,76,86,74,229,22,249,131,159,222,213,25,246,166,171,33,19,123,108,95,225,249,121,87,113,215,38,243,98,166,254,26,192,112,21,52,194,97,127,217,222,119,71,248,255,31,82,252,137,222,189,167,216,195,251,182,114,206,62,123,124,73,213,49,31,120,19,168,53,146,197,183,1,15,200,70,132,205,58,243,177,59,124,13,71,116,67,228,133,243,200,71,213,250,69,216,34,192,119,196,109,185,158,98,190,216,126,228,241,250,126,219,53,144,254,199,71,25,107,82,77,209,63,159,9,127,46,179,37,181,151,216,34,55,169,189,2,220,230,123,207,167,249,10,76,218,96,175,25,28,208,101,107,24,20,246,26,80,23,6,90,76,72,150,213,249,14,68,205,102,220,44,77,110,101,60,58,211,204,208,102,27,65,208,74,72,131,168,70,149,182,172,97,67,147,118,229,217,210,68,116,104,80,203,110,103,125,13,209,85,182,117,161,216,170,206,6,201,171,48,154,172,1,89,211,108,13,13,77,75,169,193,193,205,10,189,48,186,15,176,181,128,107,183,25,211,222,80,232,180,58,20,67,175,46,85,13,161,126,179,111,39,147,178,203,20,199,203,144,66,221,117,243,239,192,96,235,30,168,246,21,144,106,187,137,151,43,86,90,160,95,31,160,5,106,198,102,158,25,148,189,73,245,233,253,92,48,245,202,20,6,47,162,231,47,208,63,182,54,34,42,80,66,86,202,56,48,196,71,170,232,28,250,198,100,238,248,46,93,187,94,33,155,35,162,126,220,58,52,251,31,243,216,101,197,168,223,251,147,88,83,90,211,105,202,250,85,101,55,147,71,216,201,175,125,115,32,132,166,29,246,38,36,248,114,234,231,100,87,45,87,81,105,223,11,223,23,213,140,18,92,184,45,59,8,24,40,175,105,182,120,154,49,14,8,150,161,138,230,86,12,143,80,199,65,188,25,71,97,180,166,155,45,183,219,145,66,201,20,182,230,181,174,112,74,188,222,218,178,252,227,234,98,87,53,250,57,245,80,41,159,154,63,53,156,161,31,25,170,149,75,119,24,181,61,37,27,153,158,18,164,85,115,172,58,7,84,35,131,161,19,140,195,196,227,223,7,205,31,247,194,139,243,233,119,18,151,224,17,148,212,191,118,76,36,162,228,228,226,188,222,130,251,135,243,126,205,24,221,72,204,229,45,199,133,192,150,202,13,164,96,116,75,62,80,115,46,24,93,34,170,78,210,58,66,52,129,73,85,158,192,183,49,250,29,126,60,123,86,201,81,113,38,208,111,219,60,159,40,122,134,158,127,142,76,102,84,50,109,16,186,209,92,248,64,108,173,70,29,175,254,182,179,102,132,46,192,217,183,52,39,209,7,25,191,99,235,10,213,48,123,99,80,45,200,179,132,250,211,44,237,52,69,61,104,11,187,99,217,161,46,199,203,74,71,15,235,26,78,58,199,241,215,78,52,61,234,55,128,118,188,160,117,61,24,235,61,248,247,47,193,114,211,64,248,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("564f6d57-a285-4c87-9965-c47412021027"));
		}

		#endregion

	}

	#endregion

}

