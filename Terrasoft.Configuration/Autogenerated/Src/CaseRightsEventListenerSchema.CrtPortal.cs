﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseRightsEventListenerSchema

	/// <exclude/>
	public class CaseRightsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseRightsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseRightsEventListenerSchema(CaseRightsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce1c541d-1f3a-4161-afe5-3ed520df46e0");
			Name = "CaseRightsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,91,111,219,54,20,126,86,129,254,7,78,3,10,25,112,228,164,5,178,165,174,83,248,154,25,216,86,175,78,186,135,97,24,104,233,216,214,32,145,30,73,185,243,138,252,247,29,146,186,80,138,237,22,201,67,12,30,126,231,254,29,30,49,154,129,220,209,8,200,61,8,65,37,95,171,112,204,217,58,217,228,130,170,132,179,151,47,190,188,124,225,229,50,97,27,178,60,72,5,89,191,58,187,42,89,198,217,241,27,199,88,248,49,217,108,149,92,130,216,39,17,28,135,139,147,242,112,50,58,121,53,101,42,81,9,200,175,2,194,233,30,152,114,112,54,169,37,40,133,39,73,6,109,197,102,2,136,46,161,104,2,141,124,47,96,131,23,100,156,82,41,223,146,49,149,96,147,52,126,126,78,208,56,3,97,160,189,94,143,188,147,121,150,81,113,184,45,206,37,128,172,185,32,17,42,19,97,180,195,18,223,115,20,254,48,73,28,26,150,131,101,180,133,140,254,138,125,196,216,125,237,223,239,252,137,224,93,190,74,147,136,68,58,174,83,97,145,183,100,132,55,71,204,162,129,47,38,232,42,193,89,2,105,140,25,46,68,178,167,10,236,229,206,30,136,0,26,115,150,30,200,93,158,196,228,47,46,54,148,37,255,153,146,97,197,134,113,150,176,7,150,168,121,140,49,50,248,108,96,129,63,153,221,188,153,140,71,55,23,215,163,201,15,23,147,217,213,213,197,205,232,245,240,226,242,242,106,114,125,57,189,121,243,227,248,218,239,244,139,56,128,197,54,148,102,92,11,193,119,32,116,107,49,54,147,115,17,154,205,223,102,253,19,164,8,106,28,190,98,246,23,80,91,238,228,235,121,205,140,87,156,167,228,94,28,238,64,45,229,238,131,147,240,60,14,30,36,8,228,13,131,72,11,72,222,56,118,109,145,34,206,20,141,176,36,93,194,115,101,101,188,97,166,67,244,232,121,94,83,138,21,212,216,112,154,237,212,161,111,0,201,154,4,54,148,177,53,58,140,34,158,51,180,29,180,93,31,243,74,75,116,167,244,232,45,33,69,13,34,205,207,111,57,136,67,209,56,123,209,50,219,177,74,158,135,195,146,230,25,11,252,121,236,215,194,153,224,89,224,127,250,140,117,170,152,224,92,255,190,5,1,129,191,224,66,209,180,138,220,239,132,115,57,253,39,167,105,96,141,134,11,42,144,228,10,41,239,4,92,89,25,50,36,148,203,181,251,195,14,26,97,180,204,97,248,82,5,103,168,90,25,167,178,72,219,86,219,115,170,18,78,255,133,40,87,176,196,7,33,133,143,16,113,17,191,211,69,189,13,244,72,32,229,6,183,133,21,123,14,77,147,116,0,159,104,154,67,129,53,245,178,29,105,81,160,112,41,64,229,130,181,46,201,119,79,169,240,104,254,23,240,53,77,165,121,77,181,248,4,121,159,48,230,185,220,173,155,82,144,168,18,28,97,236,243,248,85,209,203,97,73,121,101,73,86,100,83,139,11,114,157,231,83,149,78,205,167,86,207,159,213,242,179,29,119,82,176,69,172,235,215,119,123,88,87,241,105,183,31,191,245,9,115,158,197,246,18,42,4,0,36,18,176,30,248,39,246,65,248,129,205,25,54,69,65,236,247,106,61,119,59,149,47,46,223,227,2,77,98,32,123,142,180,168,245,2,190,250,219,54,157,97,89,186,196,122,25,174,177,3,198,213,80,224,250,133,146,61,43,140,195,113,26,148,90,80,148,199,106,19,176,63,3,18,88,65,199,226,44,166,201,85,4,89,180,238,136,126,29,226,35,109,25,151,104,191,240,99,70,197,157,187,106,149,78,25,93,165,160,205,54,63,33,180,121,99,51,40,220,61,180,70,200,191,19,148,41,109,103,1,34,75,164,68,169,156,113,97,95,64,119,149,248,93,59,195,157,250,157,63,27,202,171,87,78,186,13,190,232,171,83,219,234,68,152,223,176,160,170,125,209,216,178,131,230,210,125,255,222,76,182,43,59,238,178,124,236,116,154,46,218,76,16,101,227,45,101,27,28,56,26,219,79,30,59,122,6,24,216,239,158,110,217,96,220,217,154,149,78,127,235,80,27,177,134,216,52,215,78,51,191,202,94,253,141,117,198,69,120,207,151,74,32,3,2,156,232,203,46,121,221,233,235,143,6,175,122,149,31,79,207,172,149,54,133,70,134,127,255,3,161,160,63,123,163,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce1c541d-1f3a-4161-afe5-3ed520df46e0"));
		}

		#endregion

	}

	#endregion

}
