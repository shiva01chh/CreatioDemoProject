﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AudienceMacroDataSourceSchema

	/// <exclude/>
	public class AudienceMacroDataSourceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AudienceMacroDataSourceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AudienceMacroDataSourceSchema(AudienceMacroDataSourceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be891925-d6a7-cb43-0fa0-d901c94a7c9d");
			Name = "AudienceMacroDataSource";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,79,219,64,16,61,27,137,255,176,74,47,142,20,89,244,74,196,1,76,64,145,10,162,9,180,135,170,170,22,123,72,86,56,187,102,63,2,105,197,127,239,236,174,191,29,67,91,53,151,200,227,241,123,111,222,204,206,114,186,1,149,211,4,200,45,72,73,149,120,208,81,44,248,3,91,25,73,53,19,252,240,224,215,225,65,96,20,227,43,178,220,41,13,155,105,245,220,252,68,194,80,60,154,113,205,52,3,133,9,152,242,65,194,10,113,73,156,81,165,142,201,169,73,25,240,4,174,104,34,197,57,213,116,41,140,76,192,165,230,230,62,99,9,73,108,230,112,98,240,203,37,215,192,130,43,77,185,70,240,27,201,182,84,123,176,32,247,15,36,177,239,9,227,154,124,54,32,119,103,84,39,235,37,251,9,228,132,124,60,58,58,154,22,104,192,83,15,216,70,191,96,144,165,67,208,18,104,42,120,182,35,119,10,36,234,224,144,88,15,201,15,211,122,126,135,194,21,32,77,162,133,180,68,206,132,130,199,27,50,96,69,216,97,109,147,142,137,109,100,16,116,180,96,213,61,113,65,240,250,182,194,43,208,107,49,232,2,186,175,81,229,86,176,148,156,166,233,5,203,52,72,21,186,49,216,45,147,53,108,168,115,158,128,122,154,144,75,131,105,247,38,123,156,109,40,203,230,105,17,145,144,99,169,116,158,150,186,49,57,42,160,34,68,13,237,115,140,134,107,240,209,175,76,175,111,168,196,121,118,108,62,24,139,77,78,37,83,130,223,238,114,156,196,39,67,179,9,25,157,149,116,163,73,147,122,60,158,254,103,42,7,23,140,190,85,132,11,72,88,142,205,211,11,95,223,113,21,152,167,199,87,20,237,102,25,42,249,30,157,199,69,6,74,172,189,120,87,224,181,208,179,23,166,180,242,175,195,125,212,110,108,106,226,187,14,243,60,29,53,121,22,226,57,22,6,79,203,73,231,188,52,7,165,108,125,217,243,88,100,102,195,7,122,94,118,180,202,179,126,10,163,207,153,202,51,186,251,66,51,3,161,155,13,207,47,180,7,192,198,225,152,106,154,232,81,67,95,133,18,142,62,49,254,8,169,231,180,85,236,77,170,75,29,72,248,135,102,85,88,111,218,177,175,204,129,67,209,12,19,85,84,143,75,193,110,215,196,129,149,38,246,0,102,47,185,4,165,236,49,245,153,141,192,137,159,199,222,55,197,240,248,136,23,219,193,10,61,214,164,16,83,56,215,37,136,112,150,112,78,236,1,142,174,225,217,254,135,123,77,230,240,76,122,42,138,119,237,250,2,231,83,179,134,94,89,46,239,117,111,3,250,246,94,130,238,5,195,146,108,75,101,81,96,105,85,103,91,70,205,111,113,2,232,10,100,132,144,115,119,229,36,112,182,187,198,173,16,214,11,230,150,202,21,224,188,70,113,38,56,32,17,85,45,81,211,138,23,13,194,218,246,26,19,22,166,151,150,224,158,63,77,55,140,47,216,106,173,21,126,245,64,51,5,222,6,15,40,65,27,201,45,230,223,173,243,254,93,179,101,82,227,38,43,68,97,139,178,226,222,192,170,203,123,40,252,211,29,190,119,218,237,192,236,109,202,180,189,37,148,221,9,117,176,188,86,220,121,105,113,215,180,93,51,162,138,168,46,36,236,180,120,252,134,99,62,218,14,186,152,253,253,6,169,65,143,149,75,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be891925-d6a7-cb43-0fa0-d901c94a7c9d"));
		}

		#endregion

	}

	#endregion

}

