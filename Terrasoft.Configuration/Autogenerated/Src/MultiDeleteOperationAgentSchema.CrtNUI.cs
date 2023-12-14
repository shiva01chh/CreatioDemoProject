﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiDeleteOperationAgentSchema

	/// <exclude/>
	public class MultiDeleteOperationAgentSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiDeleteOperationAgentSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiDeleteOperationAgentSchema(MultiDeleteOperationAgentSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a98b7dda-3fdc-4b5f-8b53-2a4cee318865");
			Name = "MultiDeleteOperationAgent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,91,235,111,219,56,18,255,236,5,246,127,96,125,31,86,190,250,212,238,61,62,92,94,69,18,59,123,198,229,181,142,211,197,161,27,24,138,197,56,218,202,146,75,74,105,141,110,254,247,27,114,72,137,164,40,217,237,117,129,43,144,70,162,56,195,225,204,143,243,32,153,44,90,81,190,142,22,148,204,40,99,17,207,31,138,240,52,207,30,146,101,201,162,34,201,179,239,191,251,252,253,119,189,146,39,217,146,220,108,120,65,87,251,206,59,244,79,83,186,16,157,121,248,19,205,40,75,22,141,62,163,168,136,26,141,231,73,246,161,110,52,5,88,173,242,204,255,133,209,182,246,112,116,82,127,90,166,249,125,148,238,237,33,171,240,60,95,46,161,25,190,67,143,63,49,186,4,97,201,105,26,113,190,71,174,214,20,167,122,188,164,89,33,123,172,203,251,52,89,144,133,232,64,46,202,180,72,70,52,165,5,181,187,146,61,50,177,91,134,100,50,165,139,156,197,215,44,95,80,206,105,252,175,40,139,83,202,128,231,103,201,185,26,124,156,149,43,24,28,58,22,160,59,26,227,215,119,103,105,180,228,119,226,113,173,191,16,10,93,107,41,111,138,168,160,162,131,176,75,175,247,75,148,20,228,144,252,56,148,111,192,110,201,96,96,104,249,43,182,140,25,203,25,188,254,13,95,71,121,70,225,237,239,248,118,26,101,11,152,88,12,45,255,16,13,207,74,70,154,197,40,166,45,51,0,131,23,81,86,72,185,147,39,41,7,138,42,95,200,66,124,39,188,96,194,2,23,183,231,179,201,124,52,62,31,207,198,243,159,111,199,183,99,24,165,111,40,243,231,146,150,180,191,191,27,131,209,248,242,63,243,233,248,248,230,234,210,97,51,162,217,102,74,1,6,153,143,87,2,102,26,141,207,142,129,215,252,242,246,226,100,60,157,79,102,227,139,27,224,53,187,157,94,142,71,66,119,175,95,183,80,78,199,167,87,211,209,124,114,137,19,152,159,79,206,198,179,201,133,152,201,143,45,36,227,233,244,106,58,87,132,70,255,127,190,222,239,86,238,89,66,211,184,77,179,160,246,2,0,201,104,20,231,89,186,33,19,0,52,153,167,240,223,33,129,199,139,40,139,150,148,193,234,43,4,210,41,11,76,13,245,7,150,172,21,147,252,254,55,0,24,153,3,188,238,41,155,192,138,228,231,249,226,61,176,204,232,71,245,53,216,66,155,107,88,238,76,121,203,41,3,32,101,232,49,200,188,180,222,253,52,147,81,34,191,70,108,115,128,232,24,170,81,142,200,124,29,49,112,98,5,101,220,79,140,4,239,238,200,156,209,15,101,194,104,124,93,81,128,196,159,73,191,90,91,255,166,155,254,144,244,111,22,143,116,21,93,66,159,62,121,182,152,10,11,207,63,8,224,158,230,101,86,52,191,49,90,148,44,163,177,254,188,117,57,177,114,81,228,76,216,93,250,28,101,118,244,63,173,158,39,112,148,104,235,112,216,169,175,90,93,3,130,46,196,49,1,232,196,99,147,158,161,103,232,225,40,189,247,54,74,147,24,180,80,171,86,217,127,139,75,1,135,5,51,43,18,138,190,112,109,248,194,218,1,42,244,75,208,139,31,20,123,73,11,245,212,67,173,203,5,129,226,60,27,67,107,251,252,84,38,177,1,88,176,245,190,61,140,236,96,98,161,57,80,242,64,2,139,69,56,254,80,70,41,15,98,250,16,129,181,2,193,99,48,208,154,5,173,153,157,65,111,216,193,208,229,59,27,125,119,40,63,78,160,158,88,67,106,239,12,149,227,156,3,66,146,98,83,163,120,223,192,148,234,51,118,186,180,235,212,101,70,222,188,1,29,52,90,15,9,56,31,151,107,48,24,116,219,227,141,205,255,118,18,239,91,43,0,251,140,237,46,187,201,42,58,54,68,21,141,66,82,230,176,236,20,212,183,154,132,96,224,123,86,190,56,196,29,92,181,211,123,195,24,111,159,159,127,56,156,102,203,55,105,23,239,56,157,115,190,207,243,20,140,147,240,105,158,23,38,126,196,7,50,145,205,173,114,6,162,211,32,80,212,40,158,122,54,96,130,76,64,10,143,24,59,185,11,211,97,154,62,216,136,103,83,229,142,205,25,136,62,151,205,46,254,197,254,194,199,205,93,244,192,209,92,243,218,90,109,114,84,171,59,21,49,51,112,227,175,225,60,60,28,80,131,30,249,149,191,109,184,142,86,41,176,31,175,231,187,77,28,161,143,167,40,45,41,57,34,175,235,230,54,49,101,87,37,83,239,153,208,148,131,125,30,236,1,118,212,104,135,38,70,72,209,165,16,173,145,231,157,97,118,65,139,199,188,53,25,123,202,33,78,248,2,158,146,247,1,138,145,104,241,72,2,229,107,43,103,47,29,101,146,249,18,145,129,13,186,58,62,136,106,172,136,146,140,131,231,15,44,78,134,126,102,143,44,255,120,204,150,229,10,156,221,101,153,166,227,79,11,186,22,62,199,33,217,111,211,196,118,95,215,238,70,148,24,79,17,35,156,138,74,16,45,115,35,159,33,203,103,27,195,33,105,171,40,120,98,167,241,39,186,40,33,13,10,144,126,136,134,213,52,3,20,58,156,229,181,112,65,2,166,38,135,71,68,252,14,65,55,67,98,181,188,21,224,179,50,16,39,72,122,163,149,57,19,51,180,41,75,218,113,219,200,18,239,172,57,113,59,240,122,60,107,211,9,26,35,67,253,6,122,134,81,31,96,69,168,5,36,215,77,11,40,250,200,163,95,227,161,226,128,142,216,146,90,117,190,51,125,128,146,27,201,124,50,203,204,200,23,53,213,136,218,215,216,121,99,104,118,55,74,148,137,172,34,23,244,100,35,181,238,154,97,16,98,26,160,164,19,63,175,94,189,34,7,188,92,173,192,242,71,186,1,215,57,39,24,223,9,200,42,62,67,41,150,150,171,140,100,192,41,172,104,95,185,196,7,40,50,63,186,246,144,29,188,210,95,253,192,81,52,167,146,164,129,28,51,223,0,27,124,35,165,88,8,51,135,8,45,105,194,54,216,25,176,215,190,1,7,210,111,132,234,39,61,25,1,186,170,145,28,66,113,7,158,101,224,196,122,228,27,142,87,235,194,204,76,81,19,154,120,182,89,139,101,84,189,139,9,139,54,199,25,88,253,91,103,162,192,104,56,8,64,98,199,52,212,204,169,57,109,149,135,88,154,168,9,45,161,252,57,154,181,2,45,214,202,91,189,105,33,124,103,117,190,195,206,123,70,36,107,248,87,71,46,169,13,191,62,252,244,127,128,106,20,29,148,91,51,186,90,167,66,138,67,210,63,134,66,52,123,159,229,31,141,145,246,228,138,218,251,225,243,235,231,31,126,101,191,170,61,154,30,84,113,225,36,123,200,207,114,182,138,138,192,96,52,180,165,49,94,119,49,203,187,126,37,184,114,113,110,124,19,251,110,80,75,221,167,244,96,118,228,132,31,104,9,176,133,232,64,116,86,102,139,131,137,216,189,132,17,98,202,134,4,168,214,16,186,147,5,176,51,151,253,162,218,5,85,219,32,231,9,47,4,71,37,119,193,116,61,169,182,40,3,65,21,223,235,193,189,174,130,151,140,142,78,234,166,192,8,250,6,23,38,101,3,14,40,118,136,60,41,138,28,212,99,152,41,213,199,199,36,165,36,64,210,80,116,53,153,59,161,168,154,177,234,95,165,86,189,94,61,239,240,56,142,3,36,169,191,63,123,115,48,2,188,68,134,100,98,179,26,92,128,67,110,91,2,238,194,11,202,57,248,72,129,3,205,180,16,217,78,229,107,76,80,212,178,248,108,47,18,255,182,220,89,187,60,232,98,132,193,158,218,230,170,2,232,219,58,167,245,38,119,176,10,60,236,251,254,32,62,99,27,16,71,178,180,211,180,33,201,75,119,80,95,116,23,89,178,79,52,149,108,187,253,119,202,150,159,43,81,145,174,59,51,255,194,196,115,199,116,67,38,216,29,172,125,170,183,34,112,29,180,228,74,220,93,64,19,122,58,86,25,8,180,61,145,196,97,221,218,1,185,46,181,219,41,148,60,200,176,14,96,194,155,13,191,161,69,1,51,22,199,43,10,47,115,119,203,175,223,62,70,127,216,189,5,238,77,147,149,31,180,243,248,51,150,175,48,51,177,115,229,13,63,142,87,73,118,155,37,133,220,96,113,29,217,105,201,24,232,95,236,90,134,42,183,51,82,37,181,114,220,148,167,238,182,118,243,45,4,179,39,13,179,66,132,48,61,10,239,170,107,0,181,196,58,240,168,74,5,239,94,136,76,3,149,84,85,117,90,224,100,192,131,65,120,204,131,190,211,218,119,217,52,38,128,100,120,86,228,233,223,24,214,214,176,26,245,198,106,220,206,196,220,104,84,44,172,189,199,221,25,200,51,168,80,28,61,105,81,68,195,118,6,88,124,40,26,93,182,104,162,17,196,203,36,19,7,7,170,222,19,104,11,106,136,124,13,76,127,73,138,71,48,123,156,200,21,111,6,127,44,106,153,178,0,223,161,136,53,193,255,63,99,83,5,234,95,30,41,163,62,120,76,154,218,227,65,45,237,128,68,92,205,125,91,150,131,19,189,142,196,249,167,71,3,117,200,28,74,111,5,213,51,218,216,113,76,70,152,191,121,159,172,131,170,31,249,179,111,55,13,86,88,244,158,122,151,152,79,224,219,117,44,83,89,90,224,147,84,184,4,149,3,58,121,22,64,29,217,196,66,71,186,166,95,108,30,67,106,120,129,83,213,192,29,146,230,138,147,227,236,46,44,174,101,142,50,119,0,109,72,186,38,36,16,85,34,251,67,175,54,176,183,5,37,236,175,38,133,128,50,60,203,78,72,194,97,190,110,174,178,252,208,252,254,31,102,87,77,110,219,220,188,190,67,243,230,254,125,173,142,152,178,195,78,205,53,163,79,73,94,114,219,237,86,217,84,155,227,201,217,105,196,23,144,119,87,73,154,149,224,181,144,85,51,17,78,16,245,235,75,195,120,171,23,241,251,86,67,152,237,62,211,35,131,19,68,100,182,133,183,17,122,158,195,49,175,198,238,116,25,138,78,244,56,139,131,190,185,27,0,184,184,20,155,106,225,132,203,236,181,9,145,182,234,241,6,234,36,6,30,222,168,34,7,62,199,109,170,107,135,77,100,235,142,71,125,48,244,148,176,2,196,243,43,218,218,51,253,66,40,58,113,184,47,85,34,99,110,51,77,232,159,230,49,85,159,241,209,12,191,109,151,48,182,41,165,57,73,48,156,76,93,175,163,132,53,183,150,141,253,10,163,218,86,133,173,119,119,84,76,191,157,103,96,44,199,23,170,198,157,240,209,137,40,1,116,205,11,195,94,177,56,201,0,32,82,49,245,66,20,3,37,34,145,173,123,162,182,228,104,232,210,145,102,191,38,88,128,242,90,73,80,184,35,173,226,125,167,52,219,50,25,193,26,194,115,188,107,25,229,234,94,4,246,73,6,24,41,220,251,55,223,44,39,178,51,173,154,71,157,41,37,82,0,53,89,148,166,19,190,224,219,139,60,216,18,191,221,204,27,10,161,42,58,136,155,28,118,138,60,244,220,245,80,9,128,147,142,74,244,43,241,112,238,54,226,113,50,122,163,37,24,252,17,250,71,235,19,231,252,250,155,20,94,40,190,188,164,2,84,120,253,169,62,183,178,66,186,56,176,106,64,162,205,160,205,66,107,23,35,54,172,180,181,254,49,169,13,123,119,164,2,38,133,131,129,45,133,210,78,233,162,183,52,234,6,106,131,135,107,104,237,37,76,99,189,60,244,67,207,246,9,6,69,55,48,187,83,160,182,160,141,89,29,24,222,51,107,21,202,37,132,156,187,47,2,38,162,189,222,103,20,222,217,238,116,40,123,224,113,66,5,54,135,207,149,255,50,76,207,218,186,237,14,144,91,234,255,42,54,186,21,186,39,40,90,112,86,9,170,42,135,219,243,15,85,93,232,80,44,51,24,59,41,108,167,205,61,232,84,44,26,251,16,237,92,26,27,25,78,69,41,109,163,236,236,53,116,51,107,53,211,49,237,77,219,5,208,123,1,238,184,158,228,52,132,48,77,217,201,230,152,47,32,128,130,147,2,8,95,101,253,214,34,216,69,185,62,33,209,214,236,72,49,148,235,211,59,166,21,22,191,44,155,168,97,227,217,182,237,204,41,106,202,175,12,245,114,239,244,52,165,17,107,132,26,235,180,2,3,195,8,215,177,248,53,75,86,52,188,45,22,151,122,111,29,179,45,41,78,38,25,156,39,15,180,72,228,14,135,65,46,118,253,71,209,134,7,127,105,187,45,107,228,0,84,100,251,56,199,109,220,188,23,105,13,86,177,156,153,90,230,56,205,182,68,98,167,69,91,173,36,192,122,118,34,238,194,84,77,102,155,137,63,192,192,57,229,188,181,2,181,213,86,173,85,189,90,107,47,1,213,74,203,42,241,85,75,53,163,240,52,205,57,109,8,203,190,94,114,143,129,58,228,254,102,66,91,109,106,173,65,180,67,27,235,52,5,223,220,192,231,28,37,246,17,10,156,200,35,71,5,96,78,30,0,2,68,94,220,13,33,244,26,124,119,186,165,234,92,243,135,210,78,68,14,110,93,85,212,11,80,222,239,184,128,84,234,248,41,74,19,145,215,153,55,203,136,190,42,81,95,34,38,47,14,221,123,195,196,186,154,99,243,111,38,140,226,76,139,126,42,100,32,171,22,185,186,204,101,221,207,182,178,183,109,21,123,117,125,170,35,67,5,234,246,11,60,154,83,149,198,200,51,165,138,18,175,19,144,223,127,39,47,170,86,192,215,198,60,133,180,213,34,242,91,231,238,117,237,27,5,51,213,244,92,79,178,101,183,201,218,192,106,221,154,11,245,95,83,84,7,143,245,17,110,15,57,187,96,220,114,178,185,245,104,211,60,219,212,243,112,148,240,242,176,214,127,40,155,130,186,156,84,97,66,125,54,66,136,31,75,50,88,160,94,148,181,96,33,185,59,122,29,247,7,36,142,84,46,216,184,41,66,222,184,250,148,127,124,178,231,182,74,125,160,168,106,183,241,75,172,54,36,230,166,97,87,210,130,110,72,155,66,78,50,54,54,141,244,1,169,113,169,196,61,240,211,70,151,9,189,178,158,55,145,119,207,14,7,62,6,214,142,149,135,139,41,156,117,71,214,186,74,224,133,225,183,60,95,239,196,206,56,251,176,235,46,66,75,78,178,191,155,183,170,143,27,170,114,85,70,136,134,63,136,243,106,177,117,29,118,0,27,117,36,98,44,255,106,144,151,47,171,5,41,16,101,146,25,110,203,188,249,96,251,45,181,18,53,15,125,7,194,244,31,61,35,0,28,182,109,14,212,35,212,119,89,187,29,204,118,15,99,185,152,74,52,51,30,129,135,105,186,89,55,204,2,132,221,24,91,228,117,132,173,25,212,158,81,221,56,49,70,18,247,136,119,3,26,254,29,157,243,199,117,129,186,158,193,33,108,139,171,57,206,231,241,19,196,234,99,182,228,36,130,255,180,142,26,238,78,124,12,167,149,59,145,175,99,207,157,43,59,61,80,109,102,147,186,153,37,254,253,23,10,240,230,227,87,57,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a98b7dda-3fdc-4b5f-8b53-2a4cee318865"));
		}

		#endregion

	}

	#endregion

}

