﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BpmonlineCloudServiceSchema

	/// <exclude/>
	public class BpmonlineCloudServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BpmonlineCloudServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BpmonlineCloudServiceSchema(BpmonlineCloudServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09b18195-8cb5-49e5-9ecd-05a1c8e2f698");
			Name = "BpmonlineCloudService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48c79191-1a42-4c6e-9843-1938fdf8bec4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,203,110,219,58,16,93,187,64,255,129,112,55,50,96,200,251,198,54,224,184,73,111,110,145,198,136,211,155,69,112,81,208,210,216,22,34,145,42,73,37,16,130,252,123,135,34,149,232,101,89,110,218,162,45,154,141,165,121,113,102,206,225,144,10,163,17,200,152,122,64,174,64,8,42,249,90,185,115,206,214,193,38,17,84,5,156,189,126,245,240,250,85,47,145,1,219,144,101,42,21,68,168,15,67,240,180,82,186,239,129,129,8,188,163,170,205,18,196,93,224,193,57,247,33,108,85,186,215,176,106,55,152,225,82,119,89,46,53,59,244,69,91,41,81,183,84,84,193,179,65,177,26,177,67,94,168,210,157,159,44,179,213,100,39,211,75,236,25,86,15,59,172,5,184,167,212,83,92,4,205,22,58,237,57,143,162,172,34,212,191,17,176,193,200,100,30,82,41,223,146,227,24,53,97,192,96,30,242,196,183,189,200,12,111,236,11,38,164,4,174,240,191,150,205,100,252,17,20,198,139,49,191,85,16,6,42,189,132,47,73,32,32,2,166,164,83,124,209,53,146,9,217,227,162,173,92,43,240,7,122,145,56,89,133,129,71,60,157,96,115,126,4,243,166,18,236,219,144,156,93,2,245,47,88,152,22,241,193,72,15,89,33,79,37,159,6,16,250,88,243,66,104,140,77,149,189,216,188,84,22,58,97,27,124,36,159,189,231,151,163,178,253,39,9,2,91,195,12,57,201,231,164,244,110,141,223,0,243,205,226,229,76,208,80,42,145,104,216,116,62,89,193,54,188,41,190,177,108,103,64,30,200,99,7,187,74,110,229,212,48,136,14,208,171,100,140,72,213,74,232,245,30,219,235,88,8,30,131,80,72,189,67,186,90,124,54,185,108,64,217,167,94,176,38,78,177,237,100,50,33,44,9,195,60,109,76,188,164,53,68,54,91,32,197,17,161,198,77,107,78,29,235,220,99,112,95,108,255,76,108,18,205,67,167,95,174,190,63,172,32,60,24,28,153,16,143,230,71,128,74,4,171,50,36,215,239,233,219,57,168,45,247,43,208,143,70,35,50,150,73,20,81,145,78,115,193,101,182,140,36,212,243,120,194,20,9,216,154,187,79,214,163,170,249,216,164,37,167,179,162,253,120,148,139,181,221,205,5,98,150,141,151,226,214,238,221,224,164,56,99,119,252,22,28,147,30,246,182,191,184,88,94,233,86,136,224,10,162,56,212,144,162,212,6,63,195,216,168,60,230,126,186,84,105,168,85,24,227,28,247,32,221,192,147,212,189,22,52,142,193,31,102,221,209,59,29,164,58,229,34,162,170,228,96,68,238,191,146,179,33,201,135,94,187,221,192,36,110,138,123,75,172,193,130,10,60,104,20,8,231,35,254,86,243,53,62,118,251,20,20,197,103,39,39,155,5,185,64,36,183,100,86,220,35,141,240,205,124,95,18,137,44,0,65,124,30,209,0,161,220,7,97,172,243,39,12,115,159,244,141,79,127,250,46,251,69,32,51,101,29,238,101,195,18,47,70,189,43,176,164,27,168,22,255,239,9,172,105,139,172,3,107,199,161,110,74,193,70,195,81,20,58,56,5,244,105,105,218,214,6,122,197,207,58,124,51,252,100,205,5,81,91,32,177,224,119,1,106,187,242,129,250,245,170,108,247,251,211,43,12,136,6,77,11,234,206,234,193,35,140,237,79,38,82,117,124,148,139,64,220,23,182,13,191,197,52,121,33,233,10,229,58,179,221,112,146,22,168,15,96,106,91,148,189,244,197,211,84,18,111,11,222,45,248,4,208,63,148,100,45,120,116,48,109,141,111,127,122,194,240,176,21,116,133,232,242,181,141,248,119,168,85,248,133,93,159,155,158,159,152,182,149,73,86,80,229,235,146,170,139,115,246,220,233,177,25,114,83,219,238,22,238,212,162,88,143,189,60,201,47,41,7,30,116,63,115,230,212,54,193,31,57,106,106,146,182,155,76,131,241,75,144,38,171,180,116,164,101,91,191,235,128,144,173,135,218,175,126,160,225,198,169,53,243,56,253,163,15,181,246,146,157,157,167,218,46,160,219,199,82,157,170,59,227,236,165,240,167,216,71,216,100,246,181,139,233,40,133,195,81,118,229,233,61,172,254,225,252,118,22,199,239,236,205,252,218,72,240,11,45,142,45,203,118,147,241,135,126,149,153,194,244,87,235,210,86,245,91,48,175,211,199,89,189,182,252,238,94,69,100,72,172,130,38,106,251,1,210,22,98,53,4,173,71,203,195,116,187,44,141,37,0,241,4,172,39,246,196,249,143,134,129,159,193,154,21,56,154,146,251,64,109,145,119,154,33,136,155,189,85,1,30,215,157,73,248,247,54,117,0,189,44,0,96,202,47,51,172,9,34,82,118,248,182,155,84,37,70,195,61,170,242,159,33,35,45,11,51,25,254,125,5,231,113,70,247,55,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09b18195-8cb5-49e5-9ecd-05a1c8e2f698"));
		}

		#endregion

	}

	#endregion

}

