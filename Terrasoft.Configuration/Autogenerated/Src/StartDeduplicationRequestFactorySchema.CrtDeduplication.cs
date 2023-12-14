﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StartDeduplicationRequestFactorySchema

	/// <exclude/>
	public class StartDeduplicationRequestFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StartDeduplicationRequestFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StartDeduplicationRequestFactorySchema(StartDeduplicationRequestFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94b338e5-9f87-4e1a-bc99-0f16f404e4a3");
			Name = "StartDeduplicationRequestFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,219,110,219,56,16,125,118,129,254,3,235,125,145,129,64,222,231,250,2,36,113,178,8,208,238,22,137,139,62,44,22,5,35,141,108,98,37,210,229,37,173,145,246,223,59,188,200,38,45,169,110,252,96,128,228,204,153,153,51,135,67,113,218,128,218,209,2,200,26,164,164,74,84,58,191,22,188,98,27,35,169,102,130,231,43,40,205,174,102,133,91,189,126,245,252,250,213,200,40,198,55,228,97,175,52,52,179,147,53,122,215,53,20,214,88,229,127,1,7,201,138,142,205,59,198,191,28,55,147,8,55,53,85,154,21,249,74,52,148,157,68,207,239,77,13,103,252,62,193,227,229,142,217,26,180,164,133,86,249,61,124,49,160,180,58,250,197,149,74,24,218,207,111,209,93,72,6,214,19,109,254,144,176,193,56,228,26,3,169,183,228,65,83,169,147,12,66,32,239,182,119,62,211,233,148,204,149,105,26,42,247,203,176,94,65,69,77,173,9,107,118,53,52,192,181,115,38,162,66,75,0,82,72,168,22,227,187,115,240,227,105,139,55,159,70,1,254,13,232,87,140,151,88,82,166,247,59,16,85,118,22,110,50,249,15,189,119,230,17,143,73,97,43,60,91,32,121,75,206,194,34,230,179,35,226,192,222,45,131,186,68,250,62,72,246,68,53,248,195,157,95,16,9,180,20,188,222,35,48,80,89,108,81,74,166,225,127,163,68,63,72,241,196,74,144,228,179,26,56,153,245,3,173,66,106,160,172,118,222,83,78,55,22,165,236,219,158,133,84,129,151,62,219,52,117,148,148,210,210,216,194,108,1,142,171,144,191,231,237,28,27,217,71,5,18,81,184,191,30,196,36,203,9,177,87,107,52,122,162,242,228,36,10,124,41,55,198,106,134,44,8,135,175,164,231,36,27,167,206,227,139,211,56,142,169,209,32,145,8,237,36,30,146,198,59,172,231,131,253,88,102,14,108,116,54,225,54,106,47,241,189,33,123,59,247,194,120,63,126,221,209,247,160,183,98,80,141,119,55,28,161,36,125,172,97,158,118,21,243,89,18,76,178,179,171,50,204,195,142,18,229,19,179,84,93,248,140,19,180,164,180,213,250,159,37,57,240,226,96,90,45,84,56,135,104,177,37,153,21,69,98,66,24,31,240,113,2,146,184,115,37,202,61,50,155,88,185,9,106,15,124,59,70,172,34,217,193,246,13,138,202,212,245,1,104,180,183,151,21,47,147,54,146,247,214,155,197,117,30,130,134,94,91,246,219,255,31,41,181,177,156,44,112,188,190,149,162,185,101,181,6,217,146,41,133,208,15,197,22,26,26,241,153,114,232,29,72,217,179,217,150,19,202,176,215,38,14,231,206,66,193,71,125,199,188,69,88,249,209,34,164,113,204,107,200,165,147,249,61,84,32,129,23,144,248,246,22,185,198,241,61,132,107,207,60,193,179,30,134,59,173,26,232,223,144,92,83,122,157,60,202,206,86,60,178,42,151,149,234,100,107,237,114,159,178,242,186,176,154,59,88,123,201,145,239,223,91,0,164,216,216,249,182,32,127,30,132,216,182,14,45,103,71,77,185,176,133,107,136,10,243,240,29,83,122,238,107,90,102,65,134,201,29,242,65,236,229,9,225,146,91,19,143,68,68,252,133,48,99,217,123,164,86,244,167,56,161,189,131,227,54,63,137,98,207,178,216,184,5,14,149,230,151,101,153,157,130,77,98,90,34,161,119,27,30,80,94,56,30,163,183,206,125,114,48,190,197,239,58,93,138,226,119,191,87,242,43,195,234,210,127,181,156,125,47,201,53,182,76,195,224,249,176,108,195,1,126,253,192,55,71,76,164,208,71,83,255,159,202,218,202,166,255,69,178,93,185,234,218,199,141,15,156,183,211,86,121,193,244,61,9,177,88,122,146,152,248,212,243,79,200,41,184,105,188,88,218,255,55,11,55,141,243,181,176,178,110,229,220,78,236,222,139,162,183,82,124,117,157,191,249,86,192,206,134,205,198,107,139,75,152,34,92,16,168,217,134,225,19,228,83,30,15,233,102,144,249,120,90,222,181,36,99,229,7,194,219,177,40,140,44,224,134,107,166,247,193,164,219,172,182,5,46,151,238,40,59,145,165,223,141,55,113,199,254,126,2,76,100,55,112,195,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94b338e5-9f87-4e1a-bc99-0f16f404e4a3"));
		}

		#endregion

	}

	#endregion

}

