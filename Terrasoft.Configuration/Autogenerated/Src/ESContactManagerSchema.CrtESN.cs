﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESContactManagerSchema

	/// <exclude/>
	public class ESContactManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESContactManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESContactManagerSchema(ESContactManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4c04a1d-8512-4528-8069-4ce26dec0aeb");
			Name = "ESContactManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,75,111,219,56,16,62,187,64,255,3,225,94,100,192,96,246,156,198,46,242,112,2,239,38,77,54,78,183,135,162,8,24,105,108,115,87,34,29,146,106,42,4,254,239,59,124,217,180,37,55,187,57,88,209,112,102,248,205,55,47,9,86,129,94,177,28,200,3,40,197,180,156,27,122,46,197,156,47,106,197,12,151,130,78,102,159,223,191,123,125,255,174,87,107,46,22,100,214,104,3,213,199,189,119,180,41,75,200,173,129,166,87,32,64,241,188,165,115,205,197,115,75,248,176,84,192,10,20,208,7,166,255,209,219,243,69,41,159,88,121,124,124,46,171,10,97,92,203,197,2,197,219,243,3,120,223,84,160,87,206,241,12,152,202,151,221,218,10,14,201,233,68,24,110,56,232,131,10,151,44,55,82,121,13,212,249,160,96,129,151,146,188,100,90,31,147,201,108,82,49,94,222,48,193,22,160,156,198,183,11,152,179,186,52,103,92,88,26,50,211,172,64,206,179,233,100,134,176,13,122,11,202,131,193,119,212,94,213,79,37,207,189,59,178,175,114,76,90,86,104,98,115,183,193,129,167,218,48,97,16,203,157,226,63,152,1,7,162,183,242,47,196,38,67,138,178,33,83,36,156,60,46,180,125,140,8,254,6,135,152,93,99,115,1,42,235,167,76,246,7,62,224,222,7,16,133,191,236,128,231,47,26,20,194,16,190,92,200,99,237,42,165,3,193,13,8,171,113,15,43,169,57,146,218,144,199,106,95,116,192,116,50,11,198,127,214,160,154,179,154,151,5,40,242,248,156,188,69,184,41,49,170,182,201,179,220,56,154,67,0,158,242,125,102,179,1,121,37,235,95,171,116,132,0,152,57,195,115,79,218,86,62,180,110,122,7,112,167,176,135,251,252,213,59,175,8,202,121,66,86,49,109,187,103,31,253,73,234,13,117,246,56,177,26,45,150,81,237,0,110,103,177,238,206,124,164,246,6,204,82,22,135,42,110,58,17,117,5,138,61,149,112,18,232,187,148,42,208,48,38,151,188,52,160,206,154,123,200,165,42,238,249,98,105,178,107,174,77,151,110,238,69,122,43,139,116,252,96,42,158,206,242,37,84,12,35,66,138,124,59,55,94,148,20,248,212,53,73,14,103,205,103,156,143,89,63,220,229,106,60,120,3,253,140,62,4,188,144,212,135,75,91,118,192,243,144,116,57,66,30,42,166,26,28,160,117,37,44,209,250,153,158,22,133,127,207,118,64,211,187,84,151,90,108,137,163,124,147,232,7,28,33,7,252,245,191,225,220,61,45,42,46,190,8,110,142,3,158,239,244,124,199,56,226,179,182,62,1,218,250,200,236,251,57,118,153,1,47,253,202,205,242,142,41,196,97,85,50,103,211,235,249,51,156,219,43,166,184,246,30,233,228,185,102,229,48,104,188,21,213,158,94,146,80,58,3,187,103,50,172,238,49,201,228,211,223,248,50,200,233,180,24,208,7,121,138,147,184,201,6,222,216,63,18,126,230,14,22,20,113,132,7,110,48,221,62,87,219,21,102,19,24,188,160,215,11,238,132,136,48,6,8,246,114,176,150,54,180,64,237,95,172,172,225,228,170,230,197,56,91,181,243,52,124,219,150,11,51,206,186,178,232,61,132,176,124,64,115,220,53,44,95,146,172,29,89,67,184,104,5,27,27,33,237,132,45,171,72,69,7,213,151,92,105,115,171,194,126,242,148,91,170,201,104,180,127,37,253,3,154,128,172,215,242,190,87,92,164,109,237,226,71,170,103,70,217,21,24,60,173,221,175,2,83,43,209,133,239,235,18,125,120,88,251,225,82,87,216,92,104,196,149,185,242,24,252,207,73,37,13,34,134,194,158,255,55,139,100,99,28,29,29,17,204,38,194,227,166,144,184,173,21,204,71,253,214,110,166,126,152,6,161,118,99,237,85,59,10,214,67,76,162,113,63,131,254,209,56,217,49,76,55,34,39,246,91,233,228,215,147,115,76,118,221,159,90,67,63,58,253,29,99,55,250,145,172,80,154,120,23,81,242,229,92,214,248,207,136,20,62,237,14,131,149,235,219,249,92,67,114,18,75,202,224,126,72,138,43,44,10,55,9,237,148,77,247,11,117,79,63,36,237,232,76,151,93,244,209,139,0,34,150,216,57,155,251,183,96,226,81,188,204,7,70,127,151,28,39,29,233,15,99,132,177,251,214,177,70,19,160,247,248,253,139,187,223,150,37,123,97,220,116,124,100,216,110,117,244,157,68,114,179,52,202,212,105,187,76,183,187,51,222,68,47,100,94,219,75,116,156,102,133,173,97,75,72,43,141,27,86,220,119,163,37,159,222,186,161,71,157,32,18,48,45,146,147,105,177,17,87,88,103,182,97,183,135,119,75,105,36,138,62,125,34,118,86,161,155,149,105,162,190,157,51,169,242,5,215,171,146,53,174,61,35,131,216,166,182,136,98,147,246,248,156,100,29,205,25,178,56,34,191,109,70,79,108,101,27,232,129,21,190,241,234,123,63,90,116,125,4,116,44,251,48,54,72,206,140,29,141,147,159,57,172,28,137,176,193,224,191,104,233,68,41,137,31,176,238,65,100,158,215,10,135,199,144,188,44,65,16,237,218,102,147,73,59,77,67,2,253,9,197,186,138,123,183,103,150,88,141,201,184,234,30,48,94,186,43,68,153,253,251,23,64,100,68,239,129,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4c04a1d-8512-4528-8069-4ce26dec0aeb"));
		}

		#endregion

	}

	#endregion

}

