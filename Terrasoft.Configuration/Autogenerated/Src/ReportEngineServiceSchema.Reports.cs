﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportEngineServiceSchema

	/// <exclude/>
	public class ReportEngineServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportEngineServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportEngineServiceSchema(ReportEngineServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91106b62-dfb2-27a6-b997-c2a8feac87b2");
			Name = "ReportEngineService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a721d4de-7c48-45cc-b19d-676727a40f20");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,87,223,111,218,72,16,126,166,82,255,135,17,125,56,144,42,243,158,4,164,132,43,17,167,166,137,128,234,30,162,211,105,177,7,178,58,123,237,238,174,169,184,168,255,251,205,238,218,198,54,107,18,154,147,154,7,34,175,191,249,181,51,243,205,88,176,4,85,198,66,132,21,74,201,84,186,209,193,52,21,27,190,205,37,211,60,21,239,223,61,191,127,215,203,21,23,91,88,238,149,198,228,178,245,28,44,114,161,121,130,193,18,37,103,49,255,215,202,29,161,232,237,142,135,120,151,70,24,159,124,25,92,135,154,239,94,86,18,252,137,235,3,160,238,190,196,174,243,96,198,66,157,74,142,202,135,32,133,132,74,18,143,225,105,26,199,24,26,159,84,112,139,130,34,13,143,48,159,185,248,70,135,116,252,65,226,150,160,48,141,153,82,23,176,192,44,149,122,46,54,233,156,112,22,49,26,141,224,74,229,73,194,228,126,82,60,59,24,112,194,1,39,32,132,70,60,40,209,163,26,252,241,119,166,25,229,73,75,138,231,47,58,200,242,117,204,67,39,81,40,90,97,146,197,76,227,193,110,239,217,218,174,220,123,144,105,134,82,211,109,92,192,131,85,224,222,183,157,107,120,23,33,101,123,195,81,6,21,180,238,153,115,237,14,147,53,202,193,23,170,46,24,67,159,71,253,161,241,178,116,243,54,231,17,204,35,120,134,45,234,75,80,230,231,199,203,182,67,150,153,12,156,97,184,144,104,90,87,90,154,172,77,221,187,115,157,208,251,12,207,240,192,192,155,230,139,236,208,57,216,159,215,218,183,26,211,13,232,39,4,233,124,49,169,208,123,80,225,19,38,236,12,167,156,220,210,138,153,51,239,253,124,106,129,124,142,126,64,17,185,98,106,86,214,29,234,167,52,122,77,89,77,37,82,141,42,96,32,240,59,213,190,210,76,132,85,156,87,10,17,66,137,155,113,223,95,212,253,209,4,152,136,72,144,107,75,62,164,138,235,223,20,100,174,182,247,176,99,113,78,135,223,185,126,50,42,43,71,50,38,89,66,154,65,80,108,227,190,60,82,79,170,143,245,116,92,242,65,99,183,186,201,181,56,21,223,252,56,64,19,156,45,183,171,145,213,125,48,37,81,231,82,168,201,188,10,59,250,185,187,43,212,151,250,26,85,64,20,28,118,112,9,204,100,154,28,104,109,224,113,30,142,175,96,8,102,150,244,122,206,154,77,120,135,122,135,235,17,69,140,61,122,130,121,244,209,1,202,30,246,162,138,151,5,212,246,154,23,103,222,20,160,163,154,247,10,180,81,86,246,135,153,7,61,127,95,184,211,214,97,107,72,220,162,118,151,161,22,52,145,105,206,96,231,160,32,104,225,150,162,255,14,252,211,195,162,178,91,134,88,217,135,11,104,172,2,197,240,61,184,247,166,121,114,152,168,45,82,51,243,175,171,207,124,100,214,76,144,106,114,217,103,174,244,149,191,200,38,173,226,83,231,16,28,93,12,209,100,110,150,137,215,4,59,175,209,211,139,76,215,157,17,211,177,37,145,117,48,152,137,78,17,174,180,76,252,181,163,153,29,157,71,92,78,203,100,69,102,98,186,193,110,186,170,104,42,173,81,112,59,68,227,114,205,254,129,203,202,117,160,51,96,67,44,44,186,23,241,222,38,210,67,51,19,168,121,92,18,76,59,177,227,58,136,150,72,83,120,3,127,85,4,77,102,27,6,171,212,152,30,12,223,216,222,78,229,140,199,72,93,18,162,50,139,99,209,80,47,45,132,27,18,50,121,44,164,168,62,173,152,191,215,11,157,245,118,127,188,86,217,23,212,180,217,102,212,199,107,30,19,121,45,240,91,206,37,38,180,9,168,65,253,193,172,214,116,95,47,136,24,84,80,28,68,195,142,5,244,147,216,114,129,133,67,68,38,55,76,97,21,114,155,59,102,28,99,187,48,72,179,251,187,59,233,101,238,129,178,199,162,148,138,0,230,117,205,240,183,172,61,217,252,252,170,150,245,4,92,77,87,127,227,53,150,193,134,224,160,172,226,70,120,148,19,91,73,238,3,102,79,31,33,85,59,56,192,164,89,162,191,34,166,35,50,201,169,84,233,218,133,227,249,254,228,43,61,67,88,29,4,30,46,240,93,200,215,134,26,104,106,29,218,187,186,128,53,85,215,160,245,234,255,184,200,183,175,184,11,183,92,1,219,49,30,179,117,92,78,186,147,203,100,185,145,93,31,9,53,183,181,199,123,26,185,118,60,215,91,190,247,72,223,178,115,177,75,255,193,129,115,212,76,202,135,251,229,170,255,17,76,223,162,210,179,84,38,76,211,57,65,239,136,90,216,22,221,81,240,135,162,173,9,110,210,104,191,212,251,24,27,144,234,52,184,97,178,88,155,74,182,62,173,177,249,5,216,189,117,28,191,170,58,98,199,100,107,31,51,220,222,72,111,224,19,191,108,175,157,39,38,78,75,255,185,188,111,207,204,223,127,80,252,17,185,90,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91106b62-dfb2-27a6-b997-c2a8feac87b2"));
		}

		#endregion

	}

	#endregion

}

