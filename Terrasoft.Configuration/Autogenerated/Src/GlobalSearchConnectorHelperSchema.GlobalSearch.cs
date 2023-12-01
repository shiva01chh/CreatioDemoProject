﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchConnectorHelperSchema

	/// <exclude/>
	public class GlobalSearchConnectorHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchConnectorHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchConnectorHelperSchema(GlobalSearchConnectorHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("738ef869-ce49-48e8-922a-76c4abd2eeec");
			Name = "GlobalSearchConnectorHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e4ec28be-5265-4264-b9ed-412a48548efb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,75,115,219,54,16,62,43,51,249,15,24,38,7,42,81,165,166,211,233,33,182,212,113,20,59,241,180,77,61,150,219,28,156,199,192,226,90,98,67,145,44,0,218,81,60,254,239,93,60,40,18,224,83,73,166,58,137,224,62,62,236,126,187,88,48,166,27,224,41,93,2,185,0,198,40,79,174,197,120,158,196,215,225,42,99,84,132,73,252,240,193,221,195,7,131,140,135,241,138,44,182,92,192,230,192,121,70,249,40,130,165,20,230,227,87,16,3,11,151,21,153,55,32,42,107,23,240,185,126,113,124,14,171,44,162,236,248,115,202,128,115,105,184,144,59,7,46,22,107,202,210,98,169,12,157,1,174,227,155,71,12,86,168,72,230,17,229,252,57,121,21,37,87,52,90,0,101,203,53,238,47,70,188,9,123,13,81,10,76,137,167,217,85,20,46,201,82,74,183,11,15,100,60,10,243,136,77,208,88,160,139,51,22,222,80,1,202,220,96,50,153,144,67,158,109,54,148,109,103,249,194,25,21,2,88,76,174,19,70,82,202,20,246,165,182,47,109,113,193,228,202,109,40,214,228,22,109,66,64,110,104,148,1,31,239,44,78,202,38,83,237,80,154,224,34,215,254,91,106,228,142,166,196,251,48,126,114,247,227,253,212,191,252,112,240,254,233,112,252,228,177,39,227,54,104,196,248,18,162,112,19,162,54,34,212,70,146,107,34,214,80,5,186,15,170,157,213,18,50,255,96,232,29,180,68,235,55,216,126,87,12,104,175,236,253,146,254,240,5,35,50,85,129,57,248,181,21,202,66,86,8,255,174,104,180,201,18,160,119,239,248,211,28,196,35,136,3,77,48,243,108,216,118,18,66,20,244,162,218,33,7,116,200,224,122,234,253,197,129,205,119,80,189,201,140,132,138,179,75,232,192,203,128,6,73,28,109,137,109,129,124,204,172,231,182,192,157,33,203,145,198,28,132,192,77,243,60,114,128,101,38,194,37,87,21,182,119,28,119,184,94,134,74,11,223,31,106,197,145,49,48,35,31,141,11,93,196,11,227,191,35,188,170,152,89,38,171,93,6,89,181,132,126,49,110,233,24,50,224,203,194,112,195,222,212,10,246,4,186,33,49,182,228,169,103,199,216,155,89,77,153,36,87,255,224,11,25,206,101,198,24,196,130,72,121,66,211,20,33,107,17,174,59,231,248,112,162,204,234,8,234,46,215,130,214,119,114,109,195,24,18,213,252,6,14,3,144,190,21,74,72,169,218,28,160,240,43,16,199,117,175,252,161,82,188,111,207,210,25,75,16,168,8,161,87,33,28,101,98,157,176,144,235,160,172,145,58,24,39,76,90,128,65,11,105,196,219,169,102,138,213,24,249,162,140,188,86,54,230,133,9,19,148,21,8,243,111,96,212,84,78,26,183,235,171,28,123,122,207,59,157,20,15,160,219,132,5,109,122,185,140,171,155,111,11,75,34,146,113,54,213,116,146,176,13,21,190,135,231,192,243,187,103,247,222,72,1,27,237,92,57,86,174,40,135,95,126,46,239,111,42,43,227,6,99,62,190,72,94,168,183,11,37,234,31,199,203,36,144,46,142,22,243,211,83,60,252,197,139,173,0,238,91,64,134,185,125,6,34,99,177,139,10,13,34,37,17,27,226,170,184,54,170,247,251,210,162,171,116,173,184,98,63,12,224,179,236,238,107,146,177,168,169,251,232,218,49,65,178,12,156,74,253,51,169,222,200,4,22,181,18,129,69,21,30,36,76,180,114,0,223,187,58,122,31,45,74,74,192,107,207,135,97,201,228,238,39,197,20,22,141,20,150,145,182,94,147,144,222,1,54,237,254,27,227,172,255,214,71,187,113,71,19,205,251,250,172,141,136,55,249,168,193,121,123,16,238,15,192,166,208,239,52,198,132,232,81,142,92,109,155,39,191,190,71,131,178,244,6,255,122,51,53,237,169,229,221,80,9,204,106,249,21,237,194,173,46,98,117,180,56,64,42,6,116,96,249,236,109,105,44,69,169,124,185,166,101,226,150,21,184,19,150,108,230,142,75,223,200,236,54,146,159,219,196,5,151,31,56,187,230,152,143,75,118,138,203,67,239,168,48,107,146,137,183,9,100,31,91,201,210,136,225,150,168,103,63,205,197,213,227,159,169,190,191,156,174,98,188,66,204,177,15,25,101,67,41,212,198,91,73,26,225,208,230,187,32,145,63,143,159,121,195,241,5,11,55,246,17,214,72,134,79,176,229,251,142,145,223,55,147,11,156,20,100,42,219,145,180,165,248,242,189,220,138,155,91,156,178,185,223,145,77,157,144,160,122,39,40,178,227,94,24,172,84,126,42,79,242,133,78,49,224,91,210,220,153,180,11,5,107,6,55,58,46,102,84,112,129,182,19,129,120,205,150,10,224,93,100,106,52,97,237,166,205,74,27,14,119,169,76,221,126,242,201,239,201,45,78,139,118,145,216,216,20,195,42,200,122,141,120,165,214,154,8,212,134,160,163,158,172,73,179,60,222,245,40,169,156,225,199,93,54,220,98,48,208,200,77,200,68,70,163,82,231,179,76,149,198,25,63,175,0,19,48,103,142,30,31,165,105,233,169,201,74,175,14,147,234,155,87,245,243,66,126,23,251,95,186,204,89,23,138,166,152,182,92,237,112,119,218,172,219,122,118,215,136,94,135,9,182,47,87,64,246,46,61,62,213,118,181,122,42,15,90,160,186,26,165,59,144,236,66,205,154,121,97,225,161,14,20,217,232,223,80,38,187,7,78,82,181,168,135,206,188,169,135,141,105,251,41,140,246,70,213,32,153,225,176,9,250,248,40,8,180,166,242,81,158,151,114,86,55,169,238,195,91,167,160,191,138,197,14,9,251,154,252,58,74,54,92,104,77,94,100,250,172,143,30,246,245,170,181,101,88,45,182,155,252,77,110,246,108,188,93,55,168,106,215,53,241,51,195,97,207,238,130,76,242,102,198,0,254,111,238,36,199,45,190,156,140,89,23,136,166,187,144,121,141,62,243,28,133,215,196,175,255,100,33,191,136,11,26,198,28,75,77,114,127,56,116,46,28,245,106,151,40,250,190,166,62,226,44,138,58,107,1,143,2,204,145,117,12,137,132,172,133,72,9,131,127,51,224,162,111,136,141,184,55,123,45,149,207,141,114,205,103,161,155,36,12,140,223,50,1,165,218,91,184,50,138,185,247,226,36,211,246,244,87,17,221,30,60,235,123,9,222,187,218,191,159,116,143,204,245,193,56,47,193,217,59,24,150,114,255,96,72,181,142,72,96,4,244,22,191,41,14,229,10,53,107,229,37,92,193,223,127,1,75,116,77,190,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("738ef869-ce49-48e8-922a-76c4abd2eeec"));
		}

		#endregion

	}

	#endregion

}
