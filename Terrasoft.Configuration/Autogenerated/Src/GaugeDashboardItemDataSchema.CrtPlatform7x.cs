﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GaugeDashboardItemDataSchema

	/// <exclude/>
	public class GaugeDashboardItemDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GaugeDashboardItemDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GaugeDashboardItemDataSchema(GaugeDashboardItemDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9852edbf-1397-42e5-8fae-e1519b394a2e");
			Name = "GaugeDashboardItemData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e488ac0-fe51-4dc3-8d9a-11caac414976");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,88,75,111,219,56,16,62,187,64,255,3,215,123,145,1,65,185,199,117,22,113,236,4,9,218,36,141,221,61,108,209,3,45,209,14,119,37,202,33,169,36,70,224,255,222,225,67,166,72,201,118,138,110,3,84,17,57,243,205,251,161,48,92,16,177,198,41,65,115,194,57,22,229,82,38,23,37,91,210,85,197,177,164,37,251,248,225,237,227,135,94,37,40,91,161,217,70,72,82,12,131,119,160,207,115,146,42,98,145,92,17,70,56,77,91,52,19,44,177,59,188,40,139,162,100,205,119,78,146,41,147,84,82,34,220,241,45,121,145,0,170,116,186,17,37,75,62,83,246,228,110,155,10,115,178,239,60,153,140,225,74,253,244,254,228,100,5,74,162,139,28,11,113,138,174,112,181,34,19,44,30,23,37,230,217,140,40,27,198,21,205,51,194,53,249,186,90,228,52,69,169,162,14,136,175,193,36,143,1,157,162,49,22,7,8,0,239,77,163,58,45,192,50,201,171,84,150,252,20,221,107,89,134,192,202,61,34,49,250,38,8,7,12,102,60,143,42,239,53,70,128,173,156,33,210,71,82,224,91,136,114,140,40,147,72,210,130,252,83,50,114,183,92,10,34,99,116,51,47,255,35,12,173,49,7,18,73,184,24,40,21,122,167,104,1,230,68,45,208,6,90,136,212,128,64,42,101,122,91,107,47,97,153,49,217,183,255,158,151,107,194,85,192,59,205,159,80,45,19,243,205,39,99,74,140,202,197,191,160,200,25,210,137,178,129,172,171,10,246,5,175,135,30,31,24,249,23,50,119,42,231,254,198,121,69,230,155,53,25,30,214,230,11,145,143,101,214,173,74,249,12,25,69,51,130,76,0,144,142,64,100,173,236,89,71,167,90,228,61,150,143,104,132,238,119,190,72,180,2,214,132,179,168,143,87,43,144,168,43,203,40,217,31,12,53,12,93,162,200,80,37,215,226,182,202,243,59,62,45,214,114,19,57,224,65,45,178,231,9,155,138,167,228,161,44,229,76,7,39,185,231,180,0,175,25,244,196,60,180,18,42,108,70,214,86,255,111,220,104,184,190,86,132,111,166,175,107,78,132,80,238,48,2,26,7,35,212,34,79,46,56,193,146,152,147,139,128,33,50,138,250,186,197,13,47,89,179,67,65,201,183,235,12,132,93,85,52,75,160,252,213,51,178,164,231,206,117,42,160,22,43,60,29,161,224,4,92,80,49,57,108,198,10,183,120,222,21,48,69,219,12,215,31,157,241,10,24,194,160,181,245,141,130,163,193,148,85,69,2,26,65,1,74,120,47,151,45,138,216,32,246,66,89,205,240,62,99,142,158,84,156,46,43,102,90,196,8,49,242,226,197,177,129,251,181,73,26,117,234,154,204,203,25,88,156,202,168,86,32,140,94,172,146,209,106,209,81,131,42,176,68,118,92,68,33,144,197,80,233,115,158,101,134,35,242,172,169,41,252,94,96,109,220,223,60,162,110,190,239,253,103,165,203,121,78,177,232,255,0,20,79,86,162,157,163,47,247,112,103,77,107,52,64,43,177,155,117,146,132,173,201,229,230,146,230,144,134,234,254,96,90,58,178,58,35,193,79,151,250,112,188,81,195,50,114,20,150,128,19,89,113,166,27,123,98,91,216,112,79,159,182,103,65,179,60,56,63,213,128,82,194,52,229,201,201,9,250,36,170,66,53,162,51,251,126,205,50,154,98,152,118,40,171,121,208,11,205,86,68,38,53,199,73,131,229,123,11,57,234,107,137,253,193,143,227,195,89,251,175,99,38,27,13,123,111,191,55,136,181,54,54,94,76,15,195,155,59,157,94,16,117,181,58,197,232,200,112,110,79,98,111,236,26,204,26,43,100,14,24,189,97,251,27,42,219,203,5,133,56,177,85,99,110,252,191,214,116,225,255,138,133,239,90,39,120,41,1,139,100,214,41,245,171,155,228,159,169,144,117,49,33,229,27,199,174,56,76,199,134,212,212,79,219,191,61,158,204,227,129,82,213,101,229,35,153,178,235,249,164,170,159,61,96,182,2,191,64,163,242,48,223,80,223,116,13,53,169,251,49,106,205,30,180,181,165,92,215,114,214,33,111,251,14,103,185,109,135,211,103,152,225,181,159,244,139,109,149,170,85,235,172,57,182,250,102,157,43,116,61,246,206,215,235,124,51,51,145,29,155,216,155,54,21,237,225,51,86,216,85,75,152,199,104,143,16,175,143,217,245,63,82,131,47,91,76,95,73,90,169,110,51,10,210,23,190,51,68,197,201,100,236,142,34,55,164,45,198,181,178,252,129,96,99,223,238,215,145,85,40,49,232,196,28,71,78,154,3,210,27,130,99,77,212,163,33,167,215,179,94,214,115,199,12,70,93,13,99,55,86,26,236,241,62,7,4,147,168,206,143,93,134,104,248,250,208,44,6,246,177,109,14,5,6,11,204,190,97,112,116,77,14,187,189,62,120,208,192,66,123,15,45,33,14,180,163,255,83,245,105,184,131,104,182,255,214,238,93,183,43,240,147,30,111,181,39,235,115,5,101,127,181,197,184,163,172,247,145,245,198,213,74,228,232,143,45,224,128,51,219,125,247,64,8,119,49,180,190,115,72,205,245,235,88,213,8,239,77,199,223,255,190,179,106,181,211,196,180,242,142,154,113,138,116,45,36,30,71,210,253,133,228,129,168,78,165,155,212,141,117,219,38,210,176,208,153,180,54,131,14,177,5,101,90,88,107,113,81,159,101,176,182,168,251,78,182,44,203,201,37,47,139,35,220,59,178,189,32,243,242,29,16,64,212,5,128,95,15,243,194,125,7,91,201,193,161,19,202,77,47,57,136,16,144,250,139,89,144,71,219,119,20,23,133,205,5,179,20,90,246,178,110,149,11,27,224,131,85,245,76,185,172,112,126,244,175,26,237,164,180,185,95,183,13,200,142,95,251,59,69,140,130,114,138,209,60,248,67,130,115,222,222,253,116,207,134,10,103,240,239,39,125,248,186,29,211,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9852edbf-1397-42e5-8fae-e1519b394a2e"));
		}

		#endregion

	}

	#endregion

}

