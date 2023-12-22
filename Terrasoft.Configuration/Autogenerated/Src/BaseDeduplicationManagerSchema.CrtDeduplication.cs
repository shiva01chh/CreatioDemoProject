﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseDeduplicationManagerSchema

	/// <exclude/>
	public class BaseDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseDeduplicationManagerSchema(BaseDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("00133a85-e0a2-47ec-acb7-14740d0e4b0f");
			Name = "BaseDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,93,79,219,48,20,125,46,210,254,131,233,144,150,110,44,157,246,8,226,129,149,130,144,54,54,209,178,61,76,3,153,228,54,88,115,237,236,218,102,173,16,255,125,215,73,218,124,144,16,134,4,138,237,115,143,239,215,185,70,241,37,152,148,71,192,230,128,200,141,94,216,112,162,213,66,36,14,185,21,90,133,39,16,187,84,138,40,91,189,218,121,120,181,51,112,70,168,132,205,214,198,194,242,176,177,14,231,176,178,225,37,36,78,114,156,174,82,4,99,200,208,148,184,68,234,91,46,15,14,38,122,185,36,254,207,58,73,104,187,60,191,4,99,103,119,28,211,114,171,234,27,66,215,126,221,241,78,212,41,143,172,70,1,222,37,194,188,70,72,8,206,38,146,27,115,192,62,113,3,181,144,191,112,197,19,192,12,155,186,91,218,102,145,135,62,131,28,60,100,232,45,245,169,0,25,19,247,55,212,22,34,11,113,126,156,110,150,12,129,199,90,201,53,51,22,189,199,53,218,57,55,191,41,50,139,90,74,192,111,220,222,177,35,54,228,169,24,199,85,216,216,18,110,60,60,236,97,46,13,58,56,43,140,155,111,248,15,214,51,212,46,237,167,78,60,236,165,180,96,38,218,41,251,60,43,152,156,212,140,35,15,238,227,190,82,226,143,131,126,71,93,134,235,99,59,3,155,19,94,66,164,49,54,189,174,182,211,26,75,151,70,37,251,57,137,131,249,223,35,255,183,232,175,144,46,243,162,1,12,134,181,70,25,142,250,242,89,69,255,128,219,227,84,92,161,36,242,252,60,156,46,83,187,238,139,52,83,239,12,56,70,119,189,198,87,6,144,82,161,104,229,117,80,95,30,22,34,1,21,231,58,169,139,134,196,146,2,90,210,105,139,112,196,61,101,113,227,210,141,80,49,172,46,104,146,61,73,103,118,126,190,57,102,126,120,13,6,9,216,226,107,32,22,65,105,205,118,143,152,114,82,142,54,167,3,4,235,80,53,47,24,12,30,183,214,69,240,231,230,130,12,191,98,150,132,160,145,163,81,73,72,117,11,167,136,154,74,215,76,164,48,12,188,117,88,148,145,126,42,174,181,164,185,223,191,154,189,130,191,52,90,19,88,5,195,235,32,124,59,26,7,63,175,199,191,222,141,246,134,35,26,215,169,164,55,160,233,248,62,27,238,125,220,186,211,113,89,118,215,99,189,48,231,126,134,79,164,0,101,217,13,110,191,27,229,169,162,42,159,173,69,42,73,186,171,212,184,104,155,134,123,142,204,114,47,162,154,0,166,247,132,252,44,232,209,82,36,170,79,78,254,174,29,151,30,205,121,114,184,245,100,55,123,39,242,55,100,29,206,113,77,106,12,136,125,159,105,87,11,182,82,117,123,135,250,111,86,128,99,76,220,146,14,125,183,76,87,17,164,254,166,96,175,174,99,230,73,232,145,201,162,125,207,30,136,253,145,41,109,253,190,150,247,16,151,45,82,68,88,52,186,203,244,216,174,114,114,85,44,167,42,14,222,140,223,120,235,215,98,193,46,166,243,217,252,248,226,228,248,242,228,227,205,135,156,170,12,59,244,15,92,46,113,239,250,21,138,128,46,200,108,65,26,120,6,78,176,12,165,98,177,168,247,78,179,68,213,230,233,26,4,217,44,117,62,223,126,18,100,47,112,209,109,249,107,220,245,14,7,141,233,227,106,203,77,117,26,160,163,6,44,119,179,115,112,210,255,60,51,176,150,146,111,252,88,254,206,165,131,198,189,36,162,118,243,225,126,77,211,69,73,187,102,74,59,71,217,100,149,201,210,225,237,147,1,147,55,207,211,129,254,178,160,26,118,173,209,180,87,54,223,173,111,210,94,245,231,31,67,49,139,67,151,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("00133a85-e0a2-47ec-acb7-14740d0e4b0f"));
		}

		#endregion

	}

	#endregion

}

