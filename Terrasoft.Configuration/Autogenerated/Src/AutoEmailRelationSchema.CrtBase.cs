﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailRelationSchema

	/// <exclude/>
	public class AutoEmailRelationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailRelationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailRelationSchema(AutoEmailRelationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("678b6b87-59e3-448c-be04-0c7ab1f1df91");
			Name = "AutoEmailRelation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa5a4ea1-d5a6-4cdb-bf8a-922751325e62");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,219,110,219,70,246,89,5,250,15,99,21,8,36,64,160,251,156,68,90,56,174,18,8,104,18,215,118,183,15,69,16,80,212,216,38,74,145,202,12,105,71,72,252,239,59,103,110,156,43,73,217,78,178,11,108,80,36,22,117,110,115,238,231,112,220,50,221,98,186,75,51,140,46,49,33,41,173,174,234,228,180,42,175,242,235,134,164,117,94,149,201,73,83,87,203,109,154,23,231,184,224,79,126,254,233,203,207,63,141,26,154,151,215,232,98,79,107,188,125,225,124,102,20,138,2,103,0,76,147,55,184,196,36,207,60,152,223,243,242,147,247,240,18,127,174,147,115,124,221,20,41,89,126,222,17,76,41,16,105,225,76,41,9,142,61,183,143,16,133,90,150,117,94,231,24,200,51,144,95,8,190,102,208,232,180,72,41,69,129,99,51,152,227,227,99,244,146,54,219,109,74,246,11,249,249,242,38,167,40,227,72,59,82,221,230,27,76,209,22,215,55,213,134,162,186,66,25,193,105,141,17,150,188,16,145,244,104,34,241,21,3,42,65,55,72,8,75,154,2,211,25,98,228,50,146,175,217,227,245,158,241,198,24,192,174,230,227,213,57,251,94,225,190,173,54,184,24,31,47,80,190,221,21,120,203,152,217,60,94,30,27,66,239,154,117,145,103,82,228,192,57,71,96,95,173,142,215,57,46,54,244,57,58,35,249,45,147,142,171,193,211,131,124,160,133,251,147,98,194,108,80,10,39,224,130,149,180,78,203,12,39,26,218,20,105,180,19,212,145,141,136,62,54,214,231,23,29,220,133,49,107,67,195,66,131,40,211,206,216,195,123,181,44,155,45,38,233,186,192,47,125,237,46,208,71,98,60,107,93,188,75,168,22,10,85,87,32,73,179,101,118,94,231,229,134,89,152,25,151,29,111,3,78,114,149,23,5,74,55,155,28,64,211,2,21,57,173,1,195,114,150,128,232,252,9,193,236,243,63,52,100,7,56,5,87,204,30,148,248,74,240,85,206,210,146,52,41,132,180,17,39,195,180,130,221,47,60,213,252,130,203,141,240,38,249,89,186,214,25,169,118,152,64,84,48,247,226,78,57,88,149,96,138,214,208,88,217,62,102,97,225,241,125,6,62,15,218,23,241,112,24,93,227,90,254,52,34,184,110,72,217,225,15,12,230,30,254,190,239,62,63,211,25,173,73,147,213,21,25,164,1,158,30,40,42,241,157,31,182,125,1,198,159,236,82,146,110,81,201,114,254,124,108,71,214,120,225,68,158,38,247,242,152,99,153,238,6,167,167,139,14,17,192,163,4,144,161,125,15,126,226,176,180,37,154,74,109,59,41,0,205,145,151,19,0,170,195,11,25,202,27,92,123,254,219,2,76,166,146,72,216,160,2,63,236,28,18,245,254,191,223,108,38,17,158,24,199,11,35,81,120,130,37,17,101,64,46,191,77,139,166,135,131,50,7,79,120,82,225,189,28,59,108,216,193,246,59,249,227,172,55,125,200,130,45,114,196,208,244,25,84,212,129,190,31,117,91,46,209,160,0,9,138,241,98,64,14,123,43,58,157,33,253,129,10,4,252,224,74,109,217,251,97,133,223,197,246,170,231,57,199,165,44,39,179,210,156,151,86,81,64,53,216,211,162,214,93,56,67,110,210,145,75,164,217,127,103,213,63,236,97,152,54,69,205,204,5,185,36,6,165,178,217,109,74,16,166,159,36,180,240,191,139,236,134,73,252,71,131,201,126,226,56,87,98,66,188,77,203,244,26,147,25,26,155,244,199,38,101,3,250,207,213,70,120,206,59,22,251,224,76,244,83,114,178,145,207,38,227,165,13,58,158,38,0,23,38,37,112,14,32,168,17,58,201,94,224,148,100,55,7,144,213,8,3,200,30,44,179,131,230,177,0,247,237,162,5,54,177,144,156,239,207,42,154,11,123,37,239,201,6,147,87,251,19,154,77,60,227,217,9,128,145,48,170,164,246,73,199,75,36,145,43,22,29,105,118,51,1,98,44,244,182,16,40,46,81,229,205,163,55,77,190,9,91,131,241,5,108,96,124,185,223,97,121,128,127,67,158,127,9,88,139,73,143,17,165,56,62,139,131,137,7,201,194,241,82,86,38,78,43,24,171,106,44,114,195,188,179,231,77,254,186,193,4,79,100,143,143,230,11,65,106,52,146,79,146,203,148,92,43,69,27,194,206,61,249,159,61,115,81,47,170,134,100,184,7,85,171,73,157,194,207,17,162,125,158,203,140,12,95,135,21,61,243,79,175,136,2,133,196,147,196,61,67,12,88,251,254,97,70,10,68,90,84,30,211,201,130,135,235,70,124,160,132,209,140,96,201,121,46,212,31,165,203,166,2,102,238,197,196,78,4,154,4,175,2,16,240,28,96,106,12,28,106,52,17,32,131,91,211,3,215,10,104,157,194,220,202,126,16,61,31,67,180,218,62,55,133,30,47,134,118,183,97,252,133,48,15,162,252,57,98,143,226,93,96,96,8,30,114,164,72,135,160,107,186,31,66,70,236,196,19,220,108,240,24,237,7,154,76,159,166,107,162,148,165,152,219,246,227,220,93,144,132,138,56,120,216,74,118,194,175,246,224,72,147,241,137,164,163,42,122,126,133,194,25,0,146,139,215,40,243,185,21,118,108,53,147,135,9,189,109,202,60,227,223,232,192,215,201,223,250,218,215,98,38,136,188,206,139,66,6,5,52,43,221,72,147,177,100,61,158,169,4,217,45,162,150,74,195,143,255,14,73,255,92,62,124,190,218,124,72,24,196,22,2,115,189,119,97,140,79,0,224,63,249,144,88,143,198,135,176,125,215,108,215,152,140,103,49,173,47,153,139,84,123,140,193,183,180,30,84,102,224,45,97,151,151,73,117,159,4,106,154,110,41,59,240,85,15,97,59,101,102,106,249,225,62,233,30,38,38,43,79,124,32,109,92,80,221,73,179,63,145,114,235,132,82,98,122,135,143,98,86,3,7,81,206,76,201,107,198,191,13,175,172,106,74,118,20,139,108,164,122,219,250,235,193,48,5,177,241,122,229,16,68,239,29,245,170,200,75,66,62,17,51,129,46,68,188,216,56,148,100,57,66,184,160,24,61,36,177,72,169,31,151,88,82,65,228,192,196,162,20,214,151,88,36,92,40,177,132,164,127,46,31,126,195,196,210,203,182,47,177,188,111,8,216,56,45,247,192,137,167,23,237,62,67,211,139,84,250,163,211,139,99,188,160,111,198,120,217,190,233,80,178,124,211,222,230,170,140,98,123,68,172,255,53,215,187,170,73,104,79,37,18,159,112,68,107,245,40,135,42,222,48,228,27,187,196,187,136,214,176,31,4,121,218,73,223,101,161,204,14,147,225,25,201,161,105,227,228,68,162,73,86,244,164,184,75,247,244,2,195,224,195,120,215,164,49,102,88,186,167,78,166,19,120,254,52,123,225,65,154,123,134,204,110,165,125,116,99,140,110,229,101,246,174,49,17,165,2,62,139,102,77,60,253,43,175,111,206,160,121,196,0,50,17,78,32,190,226,1,64,114,42,162,45,89,126,106,210,66,198,88,68,11,144,103,37,68,46,50,236,244,41,231,236,54,125,26,3,230,41,120,52,90,160,95,167,173,11,243,137,192,215,164,185,217,147,232,127,255,250,161,99,150,137,153,45,225,64,252,228,39,69,158,82,103,22,49,203,210,97,12,29,251,198,249,184,115,77,36,138,155,162,136,71,232,208,102,188,239,117,129,185,167,235,162,227,239,235,6,100,191,167,142,102,201,196,12,143,211,148,65,175,216,244,41,247,75,62,52,135,24,63,38,1,176,64,98,158,16,143,91,55,221,156,73,120,43,248,111,242,98,51,156,196,169,0,247,215,148,223,107,211,21,78,228,181,209,78,90,203,252,80,105,232,217,53,216,90,245,162,197,238,207,93,65,168,209,78,62,86,16,203,52,81,57,32,127,69,142,127,52,231,193,138,158,61,139,201,37,33,218,94,62,30,60,104,203,255,158,163,190,185,64,202,53,226,240,177,85,92,196,98,129,252,218,71,206,204,139,17,162,26,196,166,21,27,22,194,186,234,21,173,123,146,136,16,245,68,51,54,79,156,172,82,231,253,131,55,80,231,98,217,98,188,171,129,183,251,189,203,27,22,149,222,238,137,234,246,97,248,190,169,197,113,118,76,204,199,227,59,166,211,131,132,117,223,62,30,246,154,136,190,174,136,16,77,116,141,212,29,132,158,230,101,17,4,42,109,221,140,165,4,208,192,114,187,171,247,83,167,196,90,53,56,154,35,35,47,37,53,49,96,200,83,76,96,155,237,157,209,242,60,192,58,200,241,148,198,111,43,166,63,70,193,126,233,43,150,119,240,8,102,158,208,139,4,249,148,224,172,34,155,86,168,22,81,209,226,177,196,21,247,14,223,193,191,74,187,214,186,196,66,121,236,210,196,58,203,216,98,103,51,130,194,231,51,150,141,177,116,176,112,5,180,208,146,11,92,255,134,175,140,122,64,39,49,56,3,104,50,102,33,54,115,181,53,8,113,41,76,163,176,135,98,57,19,197,204,53,234,32,42,231,210,228,12,93,91,63,136,151,222,226,201,85,202,218,209,105,200,241,214,85,85,160,21,93,126,102,65,72,87,229,111,175,66,78,231,186,215,19,181,129,33,255,56,188,161,59,112,166,234,152,166,164,72,134,57,31,54,182,117,178,8,217,205,158,41,31,218,14,234,149,151,63,141,161,127,113,133,161,231,136,123,66,200,17,184,161,33,177,183,155,23,216,156,9,119,144,171,138,213,38,180,249,231,118,122,2,127,112,86,58,135,123,130,199,88,54,231,59,65,69,158,200,239,213,207,172,239,57,255,31,58,173,107,109,183,67,251,15,24,219,185,51,29,54,48,219,138,142,204,203,86,69,108,75,249,16,159,148,30,34,124,82,174,118,191,173,79,58,139,255,167,243,73,105,99,223,25,205,40,248,161,94,168,245,251,191,230,133,82,181,15,119,191,254,251,100,67,175,195,166,108,136,220,85,148,230,107,227,74,48,13,142,8,226,140,7,191,143,214,195,129,186,80,56,67,119,55,121,118,131,238,224,218,246,26,163,34,47,255,17,23,185,211,178,170,111,48,209,215,253,67,67,132,125,223,108,41,33,185,192,16,70,64,140,106,210,148,191,48,209,191,20,208,59,25,69,46,189,25,215,212,196,237,71,222,12,159,145,42,195,120,51,81,13,35,255,71,57,198,160,235,142,122,58,105,47,201,26,19,139,32,152,180,111,182,236,165,10,154,168,219,78,48,49,216,244,236,219,67,153,49,172,198,47,147,200,161,64,220,158,144,56,234,6,149,37,137,122,87,198,36,126,181,103,136,237,22,210,188,85,101,19,226,158,222,82,234,186,182,209,114,86,115,202,219,180,230,183,66,84,40,111,225,51,127,141,193,79,195,136,189,21,79,38,6,51,115,137,34,17,2,225,107,217,137,7,167,118,62,163,247,87,108,132,222,244,240,35,201,206,220,241,67,239,73,204,209,78,156,124,181,209,43,48,131,133,241,194,21,196,61,178,186,221,14,149,153,55,104,148,117,116,171,160,179,229,116,166,153,79,13,78,35,111,152,211,223,140,158,128,103,75,76,92,218,145,76,156,209,98,230,242,84,111,90,33,161,43,53,202,140,168,255,53,230,214,33,247,115,172,20,151,150,27,243,87,69,254,159,241,252,140,119,18,82,143,162,111,255,150,213,208,95,150,121,80,98,213,126,249,189,19,44,159,56,115,170,238,191,112,141,94,52,89,134,41,189,130,165,235,220,152,81,20,240,123,48,163,145,50,12,8,157,175,99,87,9,227,233,27,178,1,147,251,52,45,207,27,254,198,157,223,89,155,117,8,103,68,248,225,185,255,233,146,255,19,102,255,199,165,255,190,252,239,253,170,129,178,207,89,154,19,86,12,62,215,172,213,106,125,145,122,213,96,233,66,244,151,5,38,211,196,35,44,132,155,76,29,241,116,13,113,101,211,177,41,148,11,85,197,37,105,146,17,87,163,219,141,162,124,37,212,109,91,62,198,76,45,70,237,90,187,61,142,116,53,155,250,0,155,139,82,98,163,153,84,193,116,65,162,193,5,171,89,184,156,85,148,77,100,134,66,231,98,118,36,233,185,249,200,20,101,116,201,122,116,227,54,131,12,191,247,68,13,124,130,241,12,61,1,43,126,236,142,11,185,143,188,83,40,153,116,165,183,118,56,180,235,239,0,233,142,30,118,49,201,184,174,221,246,12,135,114,56,236,252,110,198,238,56,116,251,99,251,147,242,52,103,121,105,2,249,237,202,232,66,165,13,94,227,40,101,227,131,242,28,71,34,73,206,220,57,200,18,153,147,154,77,201,98,47,106,23,135,72,129,153,161,158,138,166,116,35,103,206,111,97,223,175,95,165,82,142,58,196,120,17,63,45,111,12,250,130,208,106,20,102,200,47,117,94,120,90,137,75,132,162,212,133,159,124,18,81,16,231,198,206,197,26,179,244,82,76,54,27,206,74,136,132,2,30,184,180,120,71,102,98,131,119,187,189,201,83,45,99,224,189,125,44,47,134,115,162,129,57,51,182,167,254,171,161,14,123,4,188,217,49,65,168,59,82,146,201,239,222,177,86,79,226,119,151,11,128,103,39,94,153,24,230,21,236,35,139,150,179,161,49,87,43,156,49,171,171,25,102,7,176,217,95,192,138,172,174,225,247,247,64,6,147,241,71,247,55,26,199,175,125,18,76,151,102,50,176,215,128,67,170,161,242,173,246,34,134,231,91,7,57,69,168,163,149,95,27,185,111,210,202,104,251,224,215,175,40,226,158,134,226,163,132,153,7,187,121,150,61,58,10,168,94,91,43,226,172,182,209,109,37,71,83,177,125,199,105,32,101,40,3,189,132,35,171,56,249,204,217,206,217,255,107,140,224,229,18,6,197,254,203,203,26,19,24,187,178,78,200,47,70,56,114,231,8,220,92,251,130,174,113,253,130,77,131,236,175,123,23,190,189,188,224,130,249,242,179,39,240,231,63,214,15,145,60,234,68,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("678b6b87-59e3-448c-be04-0c7ab1f1df91"));
		}

		#endregion

	}

	#endregion

}

