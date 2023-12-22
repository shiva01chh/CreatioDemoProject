﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OperatorSessionRepositorySchema

	/// <exclude/>
	public class OperatorSessionRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OperatorSessionRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OperatorSessionRepositorySchema(OperatorSessionRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26246f71-a336-431c-a755-aa8f74c8da9c");
			Name = "OperatorSessionRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad806488-98f4-482b-bb58-5e43a394961e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,109,111,219,54,16,254,236,2,253,15,172,7,116,50,96,40,223,155,196,67,234,36,133,129,166,233,234,116,253,88,48,18,29,115,147,73,135,164,18,120,69,254,251,142,111,18,245,106,57,93,135,13,88,63,69,52,121,119,188,123,238,185,59,150,225,13,145,91,156,16,116,67,132,192,146,175,84,60,231,108,69,239,114,129,21,229,44,190,222,48,154,172,49,99,36,139,175,136,148,248,142,178,187,151,47,190,189,124,49,202,37,252,137,150,59,169,200,230,184,246,13,82,178,140,36,90,132,140,223,17,70,4,77,26,123,222,83,118,95,46,134,22,108,54,156,181,255,34,72,215,122,124,193,20,85,148,72,216,0,91,126,18,228,14,180,163,121,134,165,124,131,174,183,4,110,196,197,18,238,0,203,159,200,150,75,10,223,59,179,249,232,232,8,157,200,124,179,193,98,55,115,223,229,22,180,226,2,61,114,241,135,86,250,72,213,26,113,39,13,73,43,46,246,50,142,2,33,219,252,54,163,9,74,180,1,221,250,209,55,99,65,105,47,120,76,97,166,192,230,143,130,62,96,69,236,239,117,19,205,194,117,205,14,36,147,53,217,96,196,32,174,113,113,42,52,106,180,181,66,81,162,245,32,169,132,190,212,87,94,53,111,105,196,124,0,41,232,20,141,107,182,143,143,157,197,132,165,214,232,234,13,46,41,201,210,65,230,159,72,2,134,8,178,58,29,127,150,68,192,213,153,197,204,248,104,134,168,241,67,178,239,30,130,224,148,179,108,135,170,18,208,215,188,242,125,60,204,140,249,26,43,127,221,57,6,47,60,199,146,134,16,244,53,169,47,237,241,161,65,129,200,19,216,174,61,105,144,212,115,131,5,3,228,227,140,254,73,36,98,228,177,176,24,241,85,120,187,78,16,194,45,59,46,103,86,182,88,224,141,1,213,233,184,234,214,241,76,187,93,131,201,45,196,39,71,102,183,245,140,205,128,78,181,81,45,102,85,217,19,244,6,169,53,149,81,117,121,106,110,216,240,113,109,215,100,162,19,107,52,122,250,239,121,173,113,56,49,64,156,121,59,36,50,11,37,44,255,62,151,79,91,176,107,148,57,111,142,106,89,5,236,208,72,51,189,171,1,119,216,152,56,216,23,49,233,194,254,21,81,107,62,140,64,62,17,149,11,38,209,125,78,28,77,43,208,101,201,204,208,161,163,69,126,251,59,216,231,216,177,47,102,194,10,156,45,218,161,96,74,204,206,178,227,175,90,39,64,224,228,200,31,10,201,160,177,19,205,129,31,20,169,5,230,66,222,71,222,183,15,88,32,34,239,193,85,26,140,13,1,81,205,247,113,184,227,10,51,124,71,196,180,135,201,39,54,54,160,33,6,199,234,107,27,177,80,168,243,13,139,23,242,44,123,196,59,185,36,186,108,131,13,192,62,164,60,113,150,166,118,99,52,246,130,21,22,234,28,110,52,158,196,215,34,37,226,156,138,2,20,213,133,248,156,200,4,130,13,149,198,74,180,14,211,151,61,222,151,163,160,24,173,104,166,32,93,110,119,101,221,197,44,69,57,244,41,140,202,53,73,195,50,60,36,27,65,241,248,176,16,247,100,167,183,105,145,150,41,138,104,74,64,206,138,18,81,205,78,135,142,7,78,83,168,147,250,90,206,157,111,119,254,108,212,132,14,216,59,69,239,114,56,83,42,243,168,209,209,177,146,164,142,82,164,191,45,212,236,234,23,232,87,62,106,3,136,222,18,217,69,232,176,192,40,42,57,187,217,109,161,115,186,207,113,54,69,99,232,203,52,61,140,167,161,158,0,55,237,122,22,242,67,158,101,246,183,2,30,23,44,181,224,152,12,10,177,70,188,79,86,157,198,94,255,208,136,30,18,132,198,97,192,1,220,34,60,105,86,6,5,209,186,224,3,121,172,37,118,84,11,151,139,159,83,21,166,124,107,194,66,14,13,72,119,232,172,149,135,241,219,157,78,242,104,111,254,91,49,117,173,110,245,180,221,26,23,104,187,169,206,67,78,110,171,192,120,73,212,57,89,89,234,248,13,103,57,145,209,190,253,193,230,200,35,18,130,83,193,228,33,34,138,192,184,40,79,139,32,28,100,72,157,245,166,141,0,205,115,33,0,48,218,94,29,24,247,169,55,223,80,136,204,164,95,31,126,32,209,254,92,1,179,76,137,3,54,69,169,6,33,144,87,89,242,184,248,89,30,202,133,110,187,28,207,26,36,88,206,112,186,11,246,27,161,109,241,203,61,105,1,4,147,1,227,184,75,202,168,46,177,16,231,83,193,127,199,151,92,92,64,171,16,121,58,56,157,185,29,38,91,100,65,47,64,251,205,36,217,23,131,227,134,36,19,81,35,203,59,14,206,105,86,76,131,248,159,120,9,179,182,250,231,132,250,243,29,208,241,140,56,173,220,193,31,166,43,20,213,44,122,117,138,188,218,248,138,90,105,222,91,246,10,169,155,210,193,248,136,50,53,9,5,199,203,252,86,9,156,168,154,216,73,124,195,21,206,64,96,174,204,172,60,234,179,253,220,105,0,171,189,50,111,241,83,237,214,26,192,43,156,73,79,52,79,251,209,12,158,134,46,54,113,88,41,32,241,195,72,223,55,106,207,66,122,119,151,23,160,218,16,114,82,3,127,80,219,59,138,120,217,250,117,119,137,173,205,88,133,220,226,57,79,117,59,230,231,118,179,104,214,42,103,207,178,204,210,186,21,82,48,114,87,63,98,186,143,6,249,150,61,156,78,152,186,35,218,139,68,31,22,62,111,53,159,201,224,105,197,214,96,230,87,120,49,249,252,27,155,130,10,190,206,44,24,4,145,121,166,58,160,115,203,121,230,46,237,53,44,152,157,100,7,181,14,225,160,134,194,121,75,179,98,99,254,210,49,42,2,218,136,165,38,159,170,8,152,65,160,167,3,93,200,102,185,139,182,201,111,151,222,246,151,240,88,108,0,7,250,65,153,249,51,170,86,218,22,179,218,29,16,238,171,194,173,152,74,250,160,244,158,227,84,182,78,240,218,28,157,225,43,193,55,224,80,46,160,139,26,92,40,191,3,16,125,182,4,99,124,27,78,42,251,75,207,118,117,147,36,232,18,159,221,68,214,140,116,33,40,197,131,224,80,207,144,246,80,67,204,158,137,47,137,74,214,151,16,129,243,183,5,64,138,186,230,226,172,231,129,234,205,125,221,91,152,82,109,143,77,221,154,230,184,194,166,214,250,109,223,57,161,122,91,138,244,7,189,138,179,7,76,51,124,155,237,145,162,115,118,86,122,167,56,53,158,184,146,232,82,35,68,236,158,155,4,239,235,197,243,186,121,252,147,113,149,219,23,12,106,57,125,128,63,234,215,62,92,132,62,216,231,130,195,37,54,164,132,14,25,252,222,179,239,153,211,37,182,73,50,72,38,255,60,22,176,133,73,110,243,254,108,115,28,216,5,223,98,57,56,201,43,178,102,29,15,195,181,172,109,60,190,153,14,88,219,90,113,86,212,201,216,97,254,210,70,247,96,249,180,183,171,168,144,176,157,151,130,156,205,176,84,75,223,76,183,40,128,177,94,72,117,45,96,80,195,80,175,124,59,208,202,236,161,172,87,182,72,216,72,255,82,82,83,176,167,53,139,52,117,205,154,115,217,196,37,209,155,255,83,166,191,188,249,71,79,156,101,200,202,42,154,5,137,50,42,213,144,7,206,30,104,27,17,181,98,100,129,253,30,126,57,9,183,207,116,212,161,159,60,51,102,20,15,212,81,219,251,134,244,15,193,253,221,137,221,22,85,203,126,85,70,252,101,77,4,137,184,30,13,121,108,117,235,177,70,155,55,96,134,126,231,102,232,196,14,135,141,142,51,253,225,243,199,188,85,115,187,207,27,245,191,74,42,61,3,197,119,54,133,206,245,77,26,216,235,96,211,14,232,255,86,196,172,14,208,67,95,39,254,209,119,189,128,189,91,199,176,254,198,28,92,156,90,6,245,65,48,51,189,255,241,212,108,142,47,54,91,181,43,186,157,242,232,96,254,56,243,148,22,246,26,90,211,171,246,94,58,52,183,163,219,10,37,61,187,6,53,240,243,29,165,71,95,167,165,210,160,215,175,209,115,139,139,14,64,173,93,30,181,216,243,137,108,248,3,49,86,21,143,69,141,183,172,230,57,255,228,129,8,204,71,94,252,240,115,163,206,87,228,182,232,5,225,106,239,172,236,106,117,17,214,194,127,127,1,12,26,20,16,249,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26246f71-a336-431c-a755-aa8f74c8da9c"));
		}

		#endregion

	}

	#endregion

}

