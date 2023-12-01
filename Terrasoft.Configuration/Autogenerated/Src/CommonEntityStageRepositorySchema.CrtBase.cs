﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommonEntityStageRepositorySchema

	/// <exclude/>
	public class CommonEntityStageRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommonEntityStageRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommonEntityStageRepositorySchema(CommonEntityStageRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2dd3d0ba-5e09-482c-bce8-b2a08f638144");
			Name = "CommonEntityStageRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,223,111,218,48,16,126,78,165,254,15,183,246,37,72,85,120,167,128,180,2,109,145,246,163,27,221,94,166,61,152,228,2,158,18,155,218,14,136,85,253,223,119,182,3,164,9,169,168,180,74,85,185,227,238,124,223,231,251,206,21,44,71,189,98,49,194,35,42,197,180,76,77,52,146,34,229,139,66,49,195,165,56,63,123,62,63,11,10,205,197,2,102,91,109,48,191,174,217,20,159,101,24,219,96,29,221,161,64,197,227,70,204,152,25,214,112,126,226,226,233,224,28,201,60,151,162,106,43,140,198,55,53,199,45,139,141,84,28,117,205,63,35,47,30,124,85,52,237,254,104,34,12,55,190,24,133,92,42,92,16,10,24,101,76,235,94,217,208,204,176,5,218,246,93,72,183,219,133,190,46,242,156,169,237,176,180,93,4,36,20,2,177,20,70,81,135,209,46,180,91,139,237,107,68,150,105,9,177,194,116,112,209,66,122,180,63,244,2,186,54,245,215,140,88,101,25,255,203,230,25,254,38,199,170,152,103,60,134,216,118,90,111,20,122,80,105,58,120,118,141,239,193,61,40,185,66,101,65,247,224,193,85,241,223,215,145,57,199,29,26,13,82,129,182,127,25,172,89,86,32,112,145,240,152,250,36,58,55,75,52,75,164,239,29,5,92,83,67,82,99,2,27,110,150,176,33,32,251,202,221,122,233,190,43,182,55,1,250,241,208,168,2,251,221,120,8,60,109,45,121,13,210,30,185,225,26,175,108,78,74,116,186,164,202,89,135,210,37,79,115,41,51,152,234,89,17,199,168,117,90,100,96,167,58,8,22,104,174,45,56,59,32,193,203,169,68,208,249,144,112,189,202,216,214,83,114,58,204,199,55,82,27,93,107,163,44,201,99,31,255,211,145,223,222,119,153,116,87,240,4,30,152,66,97,220,20,76,147,74,142,251,80,203,187,68,145,248,217,32,203,251,170,174,54,93,56,233,108,221,17,223,113,37,53,39,1,110,91,53,98,127,125,158,213,136,159,116,26,101,80,251,84,72,137,94,116,69,203,187,151,243,63,120,186,148,106,34,216,9,103,140,41,43,50,115,99,135,86,44,66,179,93,161,76,195,169,239,254,208,120,191,150,62,236,116,90,100,118,20,55,73,238,168,191,81,182,169,71,18,62,221,115,97,183,90,77,145,229,225,111,28,27,254,208,168,168,128,240,235,23,138,87,230,149,95,3,247,92,219,216,25,26,39,89,79,241,44,94,98,206,252,210,233,184,169,8,122,48,103,26,195,122,141,35,241,126,160,142,140,79,21,215,103,218,12,50,177,144,20,95,51,131,37,38,111,120,65,222,179,138,34,233,21,41,114,17,150,197,3,133,166,80,2,252,185,83,162,136,137,24,35,31,164,163,91,186,206,155,237,23,122,188,194,35,24,253,250,156,54,138,219,248,14,124,24,128,40,178,172,77,2,45,24,164,33,66,48,217,161,40,77,144,107,218,224,60,193,198,14,30,41,36,156,95,221,8,223,42,153,251,251,11,39,149,1,223,65,173,167,186,151,100,224,110,35,106,41,227,243,189,156,105,87,134,71,153,220,213,15,108,193,232,213,246,27,248,14,232,185,54,143,164,136,196,167,184,13,211,183,87,51,124,55,173,190,151,151,234,221,37,229,155,191,95,80,77,214,38,149,225,250,86,32,9,137,58,242,206,195,127,21,19,253,180,31,139,53,163,37,161,159,118,244,180,69,159,202,12,149,138,62,38,37,252,255,129,153,10,190,107,183,146,143,126,254,1,212,146,168,116,134,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2dd3d0ba-5e09-482c-bce8-b2a08f638144"));
		}

		#endregion

	}

	#endregion

}
