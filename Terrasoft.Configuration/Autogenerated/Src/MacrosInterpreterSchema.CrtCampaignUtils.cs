﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosInterpreterSchema

	/// <exclude/>
	public class MacrosInterpreterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosInterpreterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosInterpreterSchema(MacrosInterpreterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8501fc06-b5d4-49b1-bf38-e7357ec6d8c9");
			Name = "MacrosInterpreter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,91,109,115,219,54,18,254,172,206,244,63,32,204,77,135,154,42,116,154,155,251,18,91,78,83,219,73,60,109,210,76,236,36,51,141,51,29,90,132,100,52,34,169,144,144,42,213,209,127,191,197,27,185,0,65,82,106,210,185,187,206,245,67,106,130,216,103,95,177,187,0,161,44,78,105,185,136,39,148,92,210,162,136,203,124,202,163,147,60,155,178,217,178,136,57,203,179,232,36,78,23,49,155,101,229,215,95,221,126,253,213,96,89,178,108,70,46,54,37,167,233,161,243,12,148,243,57,157,8,178,50,122,74,51,90,176,73,231,156,159,175,127,131,63,159,231,9,157,55,230,61,157,231,215,241,156,253,33,165,104,188,253,137,101,31,27,131,151,116,205,163,87,116,182,156,199,197,217,122,81,208,178,20,108,234,121,88,199,52,197,176,109,218,191,230,108,222,2,80,208,182,241,232,73,60,225,121,193,168,160,132,57,119,11,58,3,48,114,50,143,203,242,33,121,30,79,138,188,60,207,56,45,64,70,248,87,78,58,56,56,32,71,229,50,77,227,98,115,172,159,79,105,57,41,216,53,45,201,68,144,18,158,19,102,200,72,42,97,200,52,47,200,196,248,40,210,132,79,41,7,154,124,190,76,51,178,138,231,75,90,142,200,148,101,73,169,169,70,53,78,73,224,223,132,194,91,154,152,183,26,5,205,161,25,103,124,83,78,110,104,26,27,206,113,150,16,120,185,44,50,248,123,54,3,37,99,14,24,147,202,193,36,159,170,185,74,6,146,10,71,87,50,130,161,121,204,128,118,178,44,121,158,54,197,192,72,160,121,190,2,35,179,132,54,232,83,202,111,242,68,90,71,65,177,63,168,48,75,26,115,33,65,201,11,225,34,36,72,37,194,209,1,50,248,98,121,61,103,19,109,105,143,143,6,183,210,79,181,55,33,180,120,156,113,240,232,203,130,173,64,119,245,126,161,30,64,122,120,111,184,43,188,151,49,7,168,140,140,73,240,238,238,237,253,237,221,247,193,97,43,201,41,155,49,94,83,124,31,132,87,201,240,219,46,2,24,185,100,41,149,188,48,225,213,187,187,138,255,85,100,230,92,69,225,201,178,40,192,173,98,228,211,85,242,237,105,188,41,31,79,129,198,60,252,64,193,134,116,24,144,111,5,199,193,247,193,247,134,68,0,136,89,207,242,101,81,211,200,39,69,244,41,124,240,238,254,119,15,254,249,254,19,252,239,253,85,2,175,135,15,223,221,191,247,47,248,123,120,247,170,83,107,24,233,83,96,119,225,187,121,245,25,203,54,84,175,214,61,220,206,214,144,21,188,44,125,214,10,141,185,174,174,131,67,29,120,52,75,84,236,121,2,177,88,138,148,35,98,81,134,177,154,225,230,20,179,110,204,116,153,60,142,74,10,146,22,116,58,14,26,81,31,28,28,71,21,208,129,139,116,180,136,139,56,37,25,212,144,113,176,44,105,1,208,153,90,176,193,177,182,26,17,227,194,16,250,69,116,116,32,169,36,136,94,114,13,182,225,107,11,140,216,216,67,114,43,35,210,153,52,118,166,73,79,108,187,77,247,178,200,23,180,224,144,169,197,34,206,57,80,210,164,211,118,56,183,53,51,150,72,137,211,101,54,81,153,122,149,127,160,93,230,211,201,243,216,70,229,155,5,197,78,57,101,242,21,80,222,62,158,179,24,114,247,19,224,112,153,159,75,252,237,86,248,232,232,192,96,225,240,171,41,143,84,12,42,210,234,65,218,253,141,200,136,178,4,31,31,131,13,140,70,202,39,130,139,169,55,227,99,34,205,158,209,223,255,4,178,114,217,224,214,155,165,70,162,96,213,188,205,20,9,64,182,35,76,218,67,230,146,244,112,66,92,36,197,182,103,169,125,94,188,180,22,186,255,150,176,209,10,145,21,43,248,50,158,255,9,55,159,72,21,187,195,232,115,162,136,236,229,161,190,84,120,46,43,56,52,191,96,63,100,58,59,177,180,231,64,157,190,156,60,228,60,222,146,25,229,135,100,219,21,37,186,125,35,28,194,145,252,145,103,212,231,80,17,171,191,192,187,243,108,154,99,153,128,159,238,2,115,200,184,147,170,49,172,186,183,216,132,136,89,87,118,103,40,130,174,140,87,148,48,46,136,200,233,15,36,124,125,121,50,108,83,90,39,23,44,14,249,149,235,167,159,167,211,18,212,69,214,177,230,93,90,211,116,82,152,169,228,226,96,144,71,143,72,232,142,141,45,56,232,206,39,67,201,107,80,250,49,198,74,71,92,10,246,9,4,21,189,207,232,28,66,234,205,131,142,64,208,54,177,231,147,95,83,244,140,109,98,214,151,51,31,63,58,182,193,72,202,50,214,200,88,164,53,76,30,14,29,195,56,211,63,203,44,38,94,207,228,166,224,66,110,10,20,243,183,121,241,65,118,13,246,86,69,237,30,136,181,125,232,49,101,31,15,163,145,122,242,25,183,23,193,122,240,153,91,191,66,230,214,35,210,220,6,31,195,180,152,189,34,107,152,189,45,141,61,87,123,154,150,173,133,19,55,13,223,107,109,92,167,203,253,167,218,155,110,96,127,206,143,108,156,227,80,11,111,209,69,141,54,235,117,179,205,26,168,58,226,137,248,173,45,121,175,83,90,13,171,117,210,140,68,249,232,197,210,61,71,143,2,163,106,214,227,36,101,217,43,54,187,129,68,56,38,208,35,211,170,41,104,40,114,126,150,45,83,90,196,215,115,122,100,250,215,105,126,92,251,162,174,206,33,158,123,34,83,175,44,106,199,58,15,203,135,210,40,184,138,11,189,66,80,125,31,43,133,171,1,204,210,120,13,131,69,79,242,226,44,158,220,132,58,211,143,171,6,140,77,137,30,140,84,227,115,7,176,151,243,185,97,63,24,60,78,18,37,164,226,241,19,43,121,8,203,94,11,59,106,8,167,217,15,116,7,53,180,2,194,157,236,51,229,42,103,9,105,227,138,236,101,36,80,236,252,198,104,74,135,204,90,194,94,109,66,107,6,96,86,188,2,162,179,53,47,96,117,184,254,123,82,228,169,56,90,178,236,246,40,186,204,47,100,159,82,173,121,253,250,89,92,42,4,37,244,184,201,86,155,156,124,243,77,227,93,244,56,219,24,135,186,239,30,85,94,93,35,135,10,197,98,209,224,9,78,82,32,49,45,141,121,104,157,57,140,200,58,146,125,160,113,151,8,132,59,174,181,36,251,84,160,167,106,118,116,246,17,114,105,25,74,14,195,97,29,37,26,13,152,202,87,26,116,208,4,76,146,112,237,13,145,190,5,133,26,63,82,181,143,200,178,165,140,143,182,117,232,10,162,163,230,233,146,137,19,170,140,131,159,207,147,230,154,83,200,45,235,13,73,100,124,36,194,214,219,242,34,17,27,162,144,122,84,175,253,10,236,11,193,52,83,226,94,64,35,100,34,207,114,86,147,58,151,114,159,77,246,116,155,206,4,109,222,0,5,202,229,156,99,119,170,189,214,115,219,169,214,222,207,146,169,133,111,239,118,166,50,143,224,47,130,253,85,156,205,232,249,244,69,206,207,214,176,102,203,176,41,136,55,252,141,229,254,147,54,75,155,155,181,186,158,161,225,142,40,210,160,135,21,230,194,171,207,14,190,64,252,70,93,231,18,253,30,240,139,176,127,18,106,151,120,79,207,236,191,239,93,168,36,110,233,141,28,167,148,215,89,75,148,138,214,124,229,74,164,4,170,10,139,58,36,175,139,203,64,156,107,194,11,18,74,95,234,51,75,216,36,118,8,84,201,52,163,107,45,210,43,241,119,168,105,162,31,233,198,20,4,93,134,228,220,232,28,234,38,55,66,232,98,133,64,7,34,39,177,76,247,207,117,57,193,193,107,74,174,97,37,159,35,117,228,97,225,186,252,85,240,64,241,147,165,117,109,23,63,75,32,44,81,29,116,97,205,126,216,148,239,26,140,248,193,12,235,81,167,81,82,80,93,153,161,51,167,255,37,185,97,68,250,202,229,151,205,21,180,69,195,170,79,83,125,125,244,212,233,3,60,9,195,173,95,78,133,151,106,10,220,54,150,122,93,92,80,33,177,10,138,19,112,162,62,127,172,49,194,181,8,103,209,92,41,223,247,103,163,134,20,187,37,34,119,123,225,154,248,47,47,14,213,110,222,228,62,176,158,86,19,91,201,238,50,91,118,1,209,219,27,90,80,69,112,167,1,28,153,47,123,161,1,243,154,72,156,4,93,44,226,76,216,68,29,247,156,178,233,20,112,179,9,13,171,163,174,146,199,5,196,67,245,12,251,109,107,75,32,94,55,14,151,212,128,136,179,215,124,162,30,66,57,211,10,214,100,39,58,193,208,50,70,77,120,15,179,247,169,232,184,165,227,148,60,196,95,57,197,102,165,185,239,177,79,213,173,35,12,243,234,69,254,123,136,84,84,238,117,233,60,104,152,196,205,250,190,243,126,107,81,66,202,151,161,36,74,0,42,0,82,9,221,208,46,22,243,141,192,129,192,72,152,220,82,215,249,195,18,100,164,240,162,167,69,190,92,148,239,190,123,31,225,148,44,248,137,3,66,48,38,155,50,154,0,91,9,45,200,247,133,126,96,67,139,50,130,161,135,120,123,150,59,209,169,140,223,136,89,143,97,71,62,73,76,129,241,187,199,51,42,11,148,43,132,70,217,162,165,32,34,8,69,135,90,141,6,233,162,126,29,122,205,99,61,254,200,178,164,250,216,140,204,191,228,19,87,96,235,68,23,220,176,162,133,252,76,122,153,195,34,242,179,178,215,155,189,188,252,105,186,10,169,81,67,132,17,214,220,155,105,122,151,97,255,18,76,170,111,83,237,11,79,218,171,111,41,125,249,101,84,137,214,191,120,26,33,34,208,112,96,84,88,123,250,4,201,240,89,206,248,31,200,135,159,153,11,191,100,14,251,238,239,159,195,118,200,92,123,134,170,215,172,125,65,171,122,120,255,250,171,90,147,21,198,146,75,226,36,94,128,80,212,56,66,56,8,13,155,237,73,128,46,195,4,245,254,68,41,228,90,40,17,183,138,192,54,250,172,243,9,43,74,46,111,26,85,167,156,152,241,161,159,111,150,148,111,25,191,9,131,234,222,13,226,187,210,214,95,25,183,137,73,161,228,91,123,221,21,173,155,133,186,95,211,203,227,30,102,178,245,184,225,58,207,231,109,203,165,197,13,98,65,120,220,128,134,93,55,8,144,134,27,200,20,166,80,215,25,212,92,9,122,213,72,19,222,219,66,200,31,54,105,181,119,198,226,86,34,72,141,43,64,141,37,149,214,186,98,170,195,126,177,251,99,168,9,216,48,90,229,224,250,62,85,151,131,229,44,43,138,182,4,54,79,148,244,0,247,135,142,66,110,198,142,49,129,248,14,228,91,211,85,192,180,21,14,167,252,227,4,103,230,137,47,216,48,215,202,64,109,253,144,48,174,232,136,146,184,183,23,106,205,62,222,32,216,61,242,253,21,173,43,84,219,202,90,51,64,196,204,27,225,10,152,9,91,194,232,101,92,148,226,204,166,187,35,73,89,182,228,180,131,230,129,75,131,189,47,52,175,67,64,114,31,138,231,231,10,53,212,232,94,163,2,191,142,5,96,108,232,182,129,98,18,88,237,108,189,176,59,59,116,215,19,105,39,167,171,242,5,211,17,177,177,162,128,143,80,203,161,67,168,182,5,66,216,169,155,242,151,63,220,76,233,203,68,151,155,5,77,16,225,170,250,211,243,165,214,229,98,242,146,254,130,132,112,213,139,55,216,75,146,68,41,169,95,95,184,85,94,13,212,92,66,36,141,90,208,95,84,247,92,94,91,71,39,142,245,154,1,135,168,112,251,114,70,64,108,124,234,87,44,219,21,213,194,233,118,168,78,22,50,82,237,213,143,107,92,215,169,134,154,108,74,159,57,138,137,126,161,69,222,40,125,238,149,157,232,148,149,139,121,188,121,17,167,141,210,34,15,68,46,54,233,53,20,234,238,115,21,45,238,17,177,152,147,71,36,184,23,144,135,36,208,55,165,81,243,42,212,221,9,180,254,180,27,220,220,92,93,61,76,211,192,110,18,255,17,220,34,65,183,183,53,254,54,192,14,216,225,118,71,255,29,194,87,250,138,189,246,98,65,197,15,27,160,207,168,174,117,93,231,107,115,149,80,231,181,10,171,251,202,174,156,28,28,255,224,210,203,155,244,170,240,88,215,117,173,219,135,23,109,226,96,65,250,46,24,214,145,217,88,194,253,9,70,196,168,155,33,200,88,127,91,255,244,201,124,13,63,47,95,192,192,207,197,219,27,198,69,160,76,104,131,202,250,152,239,134,175,134,57,75,23,124,227,182,172,8,72,200,75,88,89,85,83,248,127,44,193,229,11,83,180,197,131,203,160,243,168,165,145,2,45,168,72,156,179,248,154,22,151,12,41,136,3,244,207,5,156,157,50,118,141,54,171,111,9,142,165,127,93,168,253,163,77,160,114,12,176,107,192,181,155,92,167,247,85,203,177,22,249,192,236,51,100,183,185,83,107,8,66,161,58,161,126,36,11,128,65,10,195,42,97,14,77,194,97,147,15,229,16,210,86,149,142,213,27,229,217,242,119,38,58,168,16,51,30,76,226,146,182,156,185,61,84,51,80,124,249,206,105,26,123,241,22,68,241,212,68,116,141,182,15,162,25,241,203,185,19,114,66,167,49,108,195,29,4,107,170,27,242,214,142,176,51,240,19,84,52,255,166,209,239,6,68,37,137,109,109,187,139,105,49,111,144,4,35,114,2,222,128,102,94,214,248,243,12,150,5,139,51,174,7,119,79,57,92,125,178,249,59,91,222,13,239,207,178,60,255,191,229,247,139,249,253,172,223,60,82,108,115,196,108,39,71,88,253,99,5,187,37,225,173,191,55,183,133,218,14,247,108,46,251,126,254,32,183,136,230,39,161,100,10,123,87,231,151,1,248,23,158,158,159,117,150,232,231,148,187,196,3,190,161,26,56,63,95,105,252,36,161,250,44,220,12,17,27,83,127,232,175,127,113,102,126,13,75,96,30,103,19,6,117,150,155,11,1,100,153,177,143,162,58,39,226,203,255,148,209,162,61,2,159,99,29,145,254,110,200,169,107,231,125,87,135,172,27,11,170,108,237,116,47,184,255,18,134,117,79,216,119,255,216,186,102,108,5,98,251,189,202,230,149,13,231,74,133,63,10,213,168,61,40,199,196,127,255,6,20,39,29,121,109,62,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8501fc06-b5d4-49b1-bf38-e7357ec6d8c9"));
		}

		#endregion

	}

	#endregion

}

