﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationLogStoreSchema

	/// <exclude/>
	public class TermCalculationLogStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationLogStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationLogStoreSchema(TermCalculationLogStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bffebbb7-b396-415e-b803-c1ae3b9ac25c");
			Name = "TermCalculationLogStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28322dfd-15f8-434e-b343-12da0b1a75f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,90,109,111,219,54,16,254,236,0,253,15,172,247,197,6,2,231,123,19,103,232,220,174,8,154,190,32,118,86,96,67,81,200,210,217,230,34,75,46,73,37,112,211,254,247,30,41,81,22,41,74,22,29,175,3,138,52,166,142,167,231,142,207,189,240,156,36,88,3,223,4,33,144,25,48,22,240,116,33,70,147,52,89,208,101,198,2,65,211,228,217,201,227,179,147,94,198,105,178,36,211,45,23,176,62,183,62,163,124,28,67,40,133,249,232,13,36,192,104,88,147,121,19,167,243,32,166,223,148,206,218,211,107,154,124,173,45,222,100,137,160,107,24,77,81,161,99,107,3,222,209,228,245,244,93,26,65,204,81,20,133,127,99,176,196,101,50,137,3,206,95,200,93,235,73,16,135,89,172,164,175,211,229,84,164,12,148,232,217,217,25,185,224,217,122,29,176,237,101,241,89,61,229,36,2,17,208,24,34,66,147,69,202,214,106,47,9,230,105,38,136,64,141,36,220,169,28,105,77,103,21,85,255,148,70,204,99,248,44,23,94,5,34,64,224,130,5,161,144,11,155,108,30,211,144,132,18,102,51,202,222,163,66,186,179,10,125,46,130,68,160,101,31,149,130,252,177,109,73,213,148,59,216,146,116,129,136,195,21,218,83,1,78,34,132,52,42,183,87,225,151,232,228,235,8,23,76,30,128,9,112,34,245,189,71,54,145,49,233,235,71,32,13,225,234,197,253,243,110,122,94,39,210,69,145,161,238,138,155,10,119,98,253,243,194,31,144,68,185,75,76,255,124,100,233,6,152,160,80,58,168,215,235,224,34,154,68,185,143,10,100,136,82,30,115,131,115,212,89,190,131,245,28,216,64,67,150,226,111,81,77,127,248,185,98,247,36,224,202,130,169,64,83,120,213,242,89,33,79,30,201,18,196,57,225,242,199,143,253,80,51,14,140,160,18,145,49,104,63,187,73,46,116,133,4,38,183,184,171,248,124,190,255,29,33,162,38,155,128,161,105,104,22,39,9,64,132,212,153,111,157,220,239,232,160,202,174,143,165,106,211,91,87,175,147,108,13,76,30,244,133,244,220,196,177,229,175,32,206,224,146,184,30,113,95,95,110,24,77,25,21,244,27,26,23,83,36,104,149,2,72,38,228,43,30,219,18,201,116,152,157,211,124,255,246,38,139,193,50,245,26,95,119,49,113,139,26,214,25,58,76,3,241,109,9,60,180,171,26,12,59,156,55,102,36,122,15,68,38,95,204,119,232,201,251,32,230,185,51,120,19,201,92,166,231,122,102,168,230,74,107,113,88,141,92,140,12,153,75,242,178,190,177,217,212,250,254,78,70,86,15,182,52,242,176,115,109,179,110,82,23,51,206,179,131,129,46,21,165,137,200,217,123,60,94,157,75,191,104,88,232,19,140,205,243,174,94,64,198,171,88,142,96,131,153,20,15,59,169,39,65,92,83,50,23,28,128,132,12,22,227,190,35,129,245,207,46,15,240,98,14,215,244,159,85,30,114,17,34,187,145,94,15,93,85,252,214,99,128,105,44,113,90,222,251,161,126,242,157,176,37,133,16,176,130,222,99,133,64,108,240,39,75,215,50,51,74,54,253,157,38,48,75,241,221,232,142,160,92,25,220,203,116,51,172,40,239,144,86,194,140,49,72,132,44,175,101,80,17,173,153,104,213,62,78,203,21,74,200,114,183,219,107,166,140,111,42,172,183,57,170,208,72,244,223,154,193,22,16,180,73,101,169,49,22,28,72,52,137,13,57,121,84,134,243,229,234,94,66,59,250,179,2,115,193,229,220,235,15,43,26,174,164,77,178,163,51,40,142,82,45,165,222,101,161,77,146,220,202,22,154,186,173,170,147,149,46,200,192,41,79,158,143,73,206,68,45,218,115,203,21,98,231,133,208,13,22,47,85,196,208,80,201,12,111,250,219,10,134,90,179,77,183,49,185,226,31,80,113,148,1,249,254,157,60,119,100,244,209,203,100,59,24,146,223,73,13,213,139,26,170,217,196,1,198,122,167,198,242,195,43,56,25,172,3,154,168,6,79,222,53,252,26,60,249,218,27,165,192,74,253,88,80,84,15,95,17,240,139,64,247,133,3,255,41,202,154,149,217,3,116,86,212,74,137,205,179,38,223,186,182,30,189,42,43,203,124,91,237,2,149,105,135,198,186,251,165,235,1,200,86,147,176,10,41,85,230,246,0,196,44,66,59,19,116,141,245,5,188,178,160,119,204,212,28,228,221,27,73,81,116,167,91,130,124,121,74,99,174,21,234,190,209,190,193,56,27,75,50,181,118,61,189,224,148,185,186,229,90,218,208,82,168,125,242,145,69,9,243,86,61,169,8,18,227,67,87,236,47,9,167,75,236,138,86,1,150,153,21,168,24,217,197,70,128,97,44,130,59,80,253,101,218,94,80,230,105,26,99,202,172,42,216,245,61,181,40,91,160,122,176,26,64,165,225,11,45,179,238,78,170,3,248,7,216,117,130,36,45,52,96,110,165,98,123,74,120,170,91,24,213,193,80,94,227,110,39,219,52,48,101,140,93,21,75,220,69,41,36,213,158,173,106,84,181,158,201,250,104,149,193,122,29,178,177,26,85,162,7,232,162,150,205,206,210,142,197,55,201,226,24,43,87,167,50,165,213,141,110,69,248,62,125,24,205,210,169,202,0,131,225,16,43,93,243,211,198,114,214,52,235,80,179,32,150,133,24,80,29,166,65,87,9,222,116,229,68,10,184,202,218,84,13,146,66,213,38,85,58,252,134,73,84,115,151,175,86,212,176,128,36,24,145,227,134,139,254,101,229,154,46,210,122,190,186,56,83,58,246,170,44,175,29,151,111,27,238,43,134,42,119,38,208,86,13,172,41,3,174,47,129,221,192,215,12,184,32,78,67,78,237,153,142,3,219,169,49,123,201,118,179,23,205,91,247,244,98,236,126,227,104,247,107,78,17,71,87,87,178,10,101,57,12,220,122,106,205,92,141,124,174,249,212,216,101,97,46,94,153,42,161,88,102,204,152,156,225,181,135,252,123,248,254,14,196,42,141,228,96,47,79,129,206,11,177,95,127,91,108,146,121,78,159,205,125,94,129,106,144,115,207,70,187,38,184,72,101,213,84,49,42,222,46,215,6,90,201,105,237,74,116,234,204,51,149,227,232,47,251,134,71,246,216,232,76,67,191,198,52,67,4,79,213,219,52,243,176,113,37,95,183,56,96,13,245,27,154,146,94,227,84,95,14,222,177,41,199,27,173,108,150,56,198,190,244,141,179,7,177,167,127,219,99,204,247,27,0,63,171,205,247,15,155,95,203,44,41,83,225,209,90,194,66,143,252,236,108,102,167,21,1,223,206,47,247,200,127,5,89,49,100,47,238,82,202,5,222,226,94,23,66,214,110,63,79,102,98,195,189,239,169,68,116,0,237,64,193,142,247,56,141,212,243,46,167,177,152,39,166,179,147,126,74,140,15,158,156,59,20,158,222,130,181,62,207,183,78,86,93,217,82,190,240,116,48,168,47,94,176,45,19,153,223,100,154,195,84,109,106,228,253,196,16,241,133,199,55,114,156,169,39,153,7,184,81,41,144,231,119,139,77,168,250,6,167,62,62,153,214,100,142,20,155,142,113,250,81,235,196,81,227,211,9,118,127,132,182,246,253,17,13,85,167,90,94,91,163,96,43,111,117,15,41,187,67,243,124,194,129,127,202,247,188,10,172,49,65,113,231,219,61,246,229,152,196,132,17,240,0,112,231,1,8,119,125,88,124,194,61,78,214,191,210,79,125,193,148,45,107,101,132,124,216,68,162,101,96,111,9,253,63,65,169,73,230,8,202,40,197,255,33,143,75,67,236,72,113,217,50,157,241,140,207,218,228,232,200,127,142,97,66,235,61,238,59,247,150,52,188,19,112,121,177,169,66,202,62,186,81,233,172,34,96,43,237,152,32,91,190,106,63,66,170,244,249,99,130,250,201,217,7,85,59,74,43,127,182,218,242,164,76,170,230,196,97,26,103,235,68,85,108,159,140,160,118,185,57,145,43,244,26,86,23,32,212,44,204,3,197,125,61,200,211,249,191,16,10,210,24,215,123,49,68,148,111,98,204,221,190,88,138,125,142,188,163,147,119,69,160,51,178,107,154,220,201,241,82,62,202,68,218,45,125,48,197,184,219,137,69,169,221,147,245,14,9,53,115,222,212,33,212,30,168,88,17,86,200,119,10,42,18,171,119,116,139,173,182,80,50,177,190,32,127,200,150,18,139,2,13,161,88,236,116,149,104,187,75,84,102,97,79,188,13,6,108,153,173,145,4,135,255,129,209,1,127,85,84,157,175,253,210,175,144,60,11,49,174,157,156,252,4,187,94,108,169,8,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bffebbb7-b396-415e-b803-c1ae3b9ac25c"));
		}

		#endregion

	}

	#endregion

}
