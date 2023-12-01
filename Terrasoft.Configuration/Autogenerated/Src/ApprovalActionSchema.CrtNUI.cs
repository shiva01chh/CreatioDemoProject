﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalActionSchema

	/// <exclude/>
	public class ApprovalActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalActionSchema(ApprovalActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b8e060c-eca2-44fa-9ba3-99cc638d437f");
			Name = "ApprovalAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,77,111,27,55,16,61,43,64,254,3,163,94,118,1,97,125,151,29,3,145,100,185,66,27,195,128,156,228,80,244,64,115,103,37,54,43,82,229,135,20,193,241,127,239,240,99,87,187,235,149,133,6,104,15,69,125,144,151,228,155,225,204,155,55,36,5,221,128,222,82,6,228,1,148,162,90,22,38,155,74,81,240,149,85,212,112,41,222,190,121,122,251,102,96,53,23,43,178,60,104,3,155,203,206,24,241,101,9,204,129,117,118,11,2,20,103,71,204,84,42,200,110,132,225,134,131,62,78,55,119,83,112,106,62,155,77,78,46,205,41,51,82,5,167,136,249,73,193,10,35,32,11,97,64,21,152,208,152,44,62,108,183,74,238,104,249,129,133,76,16,182,181,143,37,103,132,87,168,151,160,129,203,119,240,40,101,73,166,107,42,86,80,1,18,109,148,139,3,92,50,135,59,36,110,68,110,45,207,9,207,71,100,198,189,57,85,135,171,0,27,17,249,248,7,178,114,77,104,158,115,191,86,34,81,118,35,62,211,210,130,78,67,216,125,27,125,225,102,253,171,100,158,254,155,111,12,182,238,227,181,221,157,159,193,15,69,48,120,14,228,129,200,3,127,45,46,167,37,213,122,76,122,104,188,184,184,32,87,218,110,54,184,221,117,28,183,97,132,57,99,82,72,69,246,82,125,117,161,239,49,175,26,69,42,77,84,222,46,26,238,126,155,65,65,109,105,38,92,228,104,153,152,195,22,100,145,116,106,149,166,191,31,43,26,182,107,3,122,36,224,170,235,232,170,83,68,209,26,101,157,148,198,228,222,187,10,128,232,182,109,159,124,210,160,208,68,4,185,19,219,26,166,196,75,103,208,1,189,239,192,28,237,145,247,46,241,117,88,247,74,110,65,57,122,198,238,219,160,37,228,49,176,106,72,58,251,116,134,79,100,5,230,146,156,217,232,35,152,181,204,251,118,225,59,106,128,120,121,222,130,89,232,57,71,253,44,13,53,86,39,94,120,218,127,47,242,42,237,29,85,100,199,53,13,152,37,184,51,1,147,23,176,39,97,208,97,47,245,86,131,44,104,50,25,198,45,134,213,252,92,201,77,50,252,92,123,172,23,190,172,65,1,226,243,97,154,45,244,205,159,22,123,51,56,201,238,169,194,206,192,222,78,234,232,82,66,117,12,224,50,196,217,137,49,91,110,129,241,226,112,39,177,233,190,254,140,71,131,78,210,0,85,96,172,18,47,178,202,110,190,1,179,6,150,140,150,84,93,57,142,174,163,201,15,211,93,21,117,199,149,193,132,2,241,109,214,125,199,28,226,9,208,100,189,202,21,217,14,139,120,12,155,7,236,153,188,209,239,87,174,104,215,201,112,25,193,195,118,142,47,106,92,19,248,247,242,122,217,66,173,140,254,209,35,53,82,18,120,90,178,53,108,104,116,29,7,239,59,77,146,53,161,31,169,160,43,80,142,187,5,30,10,84,48,152,248,152,146,99,120,145,179,86,37,106,214,131,155,108,170,0,59,39,64,186,146,15,230,188,32,201,187,88,169,57,24,182,118,82,159,77,18,142,189,244,253,123,167,234,177,220,85,114,85,189,10,90,106,8,238,158,253,111,244,183,4,211,224,4,203,13,102,134,225,12,145,79,252,247,192,55,144,125,50,236,78,238,99,44,167,205,38,7,20,201,168,203,216,212,42,133,54,110,214,61,20,12,222,194,149,70,124,94,253,165,33,239,240,32,176,101,89,103,129,247,2,80,182,38,137,211,47,199,87,4,94,201,103,202,122,42,86,103,157,253,2,135,145,247,147,249,201,24,80,164,230,185,41,244,202,9,221,65,187,103,207,203,245,223,186,152,255,3,58,174,139,102,214,74,238,253,37,224,78,242,59,105,230,210,138,252,200,94,218,212,176,115,248,186,250,219,238,26,200,19,30,255,239,138,51,93,209,172,97,232,137,30,174,221,130,227,59,180,195,41,174,99,131,225,115,10,78,221,25,175,191,55,221,22,85,175,213,123,232,230,187,61,188,242,122,149,68,198,228,248,253,244,220,111,213,39,152,179,134,167,178,239,51,108,103,230,231,240,239,47,234,0,235,248,102,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b8e060c-eca2-44fa-9ba3-99cc638d437f"));
		}

		#endregion

	}

	#endregion

}

