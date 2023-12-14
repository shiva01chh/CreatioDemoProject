﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineProviderSchema

	/// <exclude/>
	public class FullPipelineProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineProviderSchema(FullPipelineProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9c364ef-0938-41c8-b1b7-1356928fe099");
			Name = "FullPipelineProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,27,219,118,219,184,241,89,123,206,254,3,234,190,80,141,74,59,125,180,101,249,36,190,100,221,174,147,52,118,219,7,31,159,28,90,132,108,108,40,82,11,144,118,212,172,254,189,131,59,64,2,20,149,203,91,243,32,75,224,204,96,238,51,24,48,101,182,196,108,149,205,49,186,193,148,102,172,90,212,233,105,85,46,200,67,67,179,154,84,229,207,63,125,249,249,167,81,195,72,249,128,174,215,172,198,203,163,214,111,128,47,10,60,231,192,44,125,131,75,76,201,188,3,243,43,41,127,239,44,126,104,202,154,44,113,122,13,40,89,65,254,43,54,180,80,111,241,115,13,52,57,75,127,103,238,3,151,85,138,99,235,233,69,54,175,43,74,48,11,67,44,151,97,154,111,27,194,57,122,34,115,124,85,229,184,72,207,178,58,3,157,212,20,232,1,2,160,252,153,226,7,96,21,93,150,53,166,11,208,222,33,186,188,104,138,226,61,89,225,130,148,248,61,173,158,72,142,41,18,208,251,251,251,104,202,154,229,50,163,235,153,250,173,32,24,90,226,250,177,202,25,90,84,20,173,52,90,181,64,11,32,135,86,138,30,202,129,133,84,147,218,119,104,173,154,251,130,204,17,209,140,132,249,0,64,110,197,14,39,98,225,3,174,27,90,50,148,193,134,12,136,1,83,124,187,46,19,247,107,64,198,24,205,41,94,28,239,185,251,156,131,29,235,181,244,155,189,253,89,106,246,218,111,111,54,93,101,52,91,162,18,220,238,120,15,115,52,176,143,66,156,157,171,223,104,238,122,96,58,221,23,72,150,6,149,28,207,206,98,108,42,49,34,220,94,243,167,156,205,233,190,166,196,73,187,32,151,229,162,66,111,112,253,170,40,4,52,227,91,37,151,191,18,86,79,99,130,207,144,47,207,88,250,202,70,122,12,46,115,233,52,158,3,157,22,25,99,135,40,108,179,126,215,217,197,75,110,207,240,34,107,138,250,53,41,115,112,246,164,94,175,112,181,72,130,190,50,30,223,89,191,154,115,254,130,236,69,60,94,122,26,87,167,17,17,66,184,206,202,26,196,124,79,201,83,86,99,249,124,37,127,112,91,179,26,229,120,78,150,89,129,62,222,103,12,95,215,217,3,6,188,39,76,25,39,113,140,94,30,28,44,143,20,93,95,147,102,159,11,130,139,60,182,9,197,89,94,149,197,26,253,139,97,10,148,75,153,175,208,199,198,251,125,228,226,120,242,113,251,67,160,64,54,1,166,208,199,220,253,233,99,129,215,124,192,171,138,17,200,61,107,153,130,214,83,153,109,132,92,156,210,12,125,100,252,123,7,208,39,5,105,18,50,80,83,72,133,252,2,206,7,32,22,71,17,233,172,31,5,37,63,35,66,68,240,136,105,39,24,110,192,31,38,136,129,60,37,184,241,71,92,224,37,248,242,191,179,162,193,111,33,82,175,178,21,216,128,83,29,149,248,121,7,74,34,233,140,70,95,80,16,14,114,48,20,128,9,218,19,127,47,165,122,246,208,102,178,13,75,59,198,77,37,80,4,133,214,218,110,100,46,8,101,117,136,150,125,96,8,110,182,248,161,240,119,218,112,115,114,111,20,113,164,156,81,198,84,40,108,146,150,95,250,110,57,86,138,244,87,211,211,71,60,255,244,138,62,52,220,88,111,129,106,194,211,42,196,117,11,123,44,28,98,212,242,117,176,104,192,249,55,253,194,1,191,43,76,121,142,11,138,214,19,50,254,47,41,207,3,174,181,139,200,68,220,10,44,116,114,130,146,214,210,49,79,203,30,177,68,11,184,17,159,204,18,37,139,14,250,159,142,81,9,60,106,141,142,70,245,35,173,158,17,119,235,75,104,73,94,21,60,94,214,231,159,33,166,206,63,207,241,138,43,70,171,213,219,85,111,170,118,29,61,241,96,137,155,36,140,219,145,77,80,113,164,217,248,234,29,150,91,174,131,169,37,174,243,112,42,146,202,143,60,19,86,8,239,179,197,28,17,130,223,98,151,48,31,59,26,104,11,145,184,34,182,152,108,91,14,143,44,247,27,171,11,111,141,213,125,102,141,117,141,235,26,18,51,179,15,135,88,171,75,241,155,173,213,33,249,53,214,138,19,137,107,34,98,173,88,190,187,146,221,121,164,171,232,73,119,221,36,165,116,229,225,252,179,193,116,253,186,33,5,111,231,238,213,95,97,46,181,152,40,137,148,245,69,187,168,92,15,142,90,245,52,206,193,44,145,170,224,54,113,74,146,86,102,178,231,39,255,189,73,187,23,26,79,182,16,80,252,2,166,250,166,212,191,233,81,146,39,176,43,166,214,206,176,12,23,13,198,112,20,75,29,110,13,69,22,14,17,77,54,220,103,13,51,141,43,247,143,183,76,88,61,123,147,136,222,134,209,235,42,70,19,236,62,137,120,194,54,3,244,165,41,116,60,147,29,104,87,209,91,200,126,187,190,213,73,110,215,30,191,167,68,130,52,17,97,6,145,254,254,34,201,142,157,179,124,222,106,254,95,175,77,207,156,4,59,105,121,218,230,223,116,20,235,90,21,56,71,220,26,224,187,160,139,156,151,32,1,205,238,11,60,21,226,50,126,18,183,170,228,191,88,226,66,13,62,141,43,222,158,50,10,103,34,6,135,97,136,107,174,63,113,166,119,246,210,41,119,81,65,17,155,63,162,132,99,96,135,50,34,101,132,246,136,148,53,90,102,159,223,54,203,123,145,200,229,70,242,156,163,74,147,216,46,156,208,152,76,253,82,10,201,81,226,110,156,94,207,31,241,50,227,154,28,171,186,155,190,163,144,81,94,175,147,37,150,91,206,144,252,150,74,30,198,233,77,197,119,212,66,113,169,80,194,217,36,176,217,193,17,252,153,170,205,21,151,136,188,120,97,235,58,151,93,60,6,104,9,118,75,238,20,169,145,146,238,85,158,39,92,145,86,135,6,125,116,153,107,196,244,50,159,232,85,163,31,130,94,88,125,153,199,103,132,173,138,108,45,220,198,160,187,139,6,210,42,4,224,34,170,82,176,27,191,193,216,184,142,42,5,217,230,143,161,248,246,108,165,98,136,89,43,57,62,231,118,36,58,191,69,43,11,79,5,137,67,231,200,144,33,98,152,50,199,209,90,151,122,9,36,9,109,235,247,20,154,98,42,199,93,73,48,117,63,85,36,71,96,232,211,172,152,55,5,172,228,246,36,152,116,166,98,70,71,42,151,64,44,202,47,108,226,157,126,63,64,207,200,79,64,90,79,188,229,20,163,199,227,86,127,41,89,117,27,85,49,234,10,113,147,94,84,244,28,226,54,249,132,181,7,217,237,141,175,246,113,171,55,85,110,165,233,164,255,192,107,229,120,218,51,205,35,241,41,185,11,151,62,61,222,2,29,219,241,66,210,214,197,188,161,20,24,80,131,136,246,83,51,25,115,213,229,162,68,212,134,196,232,204,104,142,99,25,82,26,5,253,241,135,165,159,190,3,6,179,162,16,9,129,67,28,180,41,186,187,118,161,151,232,132,127,28,6,135,121,71,221,240,75,226,228,246,35,92,141,209,95,248,76,112,91,200,118,234,149,172,36,98,162,251,122,205,171,80,188,152,152,250,54,83,227,100,1,238,133,180,156,50,59,101,164,187,95,176,154,16,56,35,241,42,18,160,59,146,107,97,71,229,143,76,110,21,165,247,88,208,210,249,80,204,195,99,236,152,188,149,168,226,177,25,7,108,33,183,15,233,213,37,246,134,86,205,10,231,226,192,81,61,223,222,113,173,190,167,120,149,81,156,223,84,58,44,249,133,144,156,155,71,84,12,184,51,145,0,164,0,177,226,207,52,235,174,242,127,171,128,64,174,36,94,208,106,41,193,68,249,225,170,213,56,186,84,140,4,134,42,102,240,69,94,113,148,22,11,10,20,194,191,55,89,193,84,197,145,13,71,206,239,86,42,129,236,147,19,123,234,101,157,58,128,176,94,74,213,204,253,114,113,190,92,213,107,173,117,142,202,48,191,47,67,109,251,250,90,181,69,20,48,140,245,116,61,228,28,79,28,0,245,172,197,143,221,114,227,229,124,171,60,211,64,200,60,153,154,141,156,6,226,21,165,217,58,92,23,134,6,219,80,23,216,238,3,147,254,61,135,5,108,39,9,184,8,82,83,136,35,172,148,79,43,237,246,123,185,144,194,113,86,91,180,23,102,138,12,68,92,154,183,7,119,38,61,116,218,50,23,80,54,103,96,3,175,61,227,180,253,2,224,83,55,173,90,27,80,201,227,46,157,136,107,78,219,37,218,108,37,116,99,211,149,109,14,117,81,19,235,186,38,234,98,3,153,76,182,67,170,246,10,1,204,73,64,117,186,61,71,13,65,52,149,167,138,23,234,138,96,207,144,126,38,53,103,207,5,50,225,50,135,138,209,119,225,112,104,162,194,99,188,173,159,147,212,189,150,224,3,54,43,218,104,116,15,10,250,116,52,104,203,214,205,132,221,94,121,216,19,169,26,22,180,223,85,86,63,166,87,217,231,228,96,2,30,241,87,244,114,124,119,20,102,222,239,43,218,162,76,252,109,164,169,199,150,20,111,236,12,182,244,180,46,137,160,29,199,223,168,17,123,191,18,177,202,54,193,108,104,253,120,161,212,104,114,180,67,191,187,181,26,27,12,227,190,67,219,211,145,233,80,135,71,146,173,24,230,112,101,148,173,31,105,41,55,90,236,88,219,111,123,250,182,94,141,2,229,214,34,129,245,118,222,86,38,93,116,253,120,116,202,146,115,140,60,183,74,214,188,12,56,236,197,59,28,115,200,105,185,77,95,155,126,166,146,190,72,117,89,13,127,239,155,26,187,135,191,118,151,46,228,109,15,208,219,0,193,163,205,173,71,255,46,144,179,188,30,249,107,166,220,206,149,222,255,223,21,233,121,87,36,112,149,251,93,94,25,137,13,169,218,27,233,99,197,214,182,10,240,189,107,129,212,253,149,116,95,88,25,57,211,10,33,145,189,60,146,179,183,32,138,154,4,93,119,250,43,183,41,18,45,171,144,6,14,12,202,239,251,222,11,232,135,104,191,3,48,20,218,86,28,117,94,247,37,176,51,44,167,209,246,122,231,238,176,168,21,86,187,190,240,195,119,16,48,183,238,139,102,189,47,225,72,20,249,78,151,192,186,18,67,191,68,21,132,61,233,211,123,226,77,30,115,19,217,223,170,43,219,153,123,199,35,56,165,120,82,6,247,49,234,138,239,229,118,241,157,17,97,96,163,33,234,179,116,6,40,206,5,142,171,140,228,190,8,111,26,40,6,80,136,118,83,72,238,76,41,125,122,170,68,120,179,205,221,104,151,226,64,230,83,229,71,6,53,77,221,209,114,102,184,24,100,211,25,172,90,186,178,156,241,55,13,75,222,245,219,77,118,118,121,225,108,59,250,188,194,137,91,144,191,212,230,11,19,190,174,16,31,95,144,209,20,234,179,39,44,249,52,123,6,43,242,16,222,162,188,187,110,236,228,98,55,253,56,19,143,120,98,144,237,85,192,213,117,227,53,80,49,186,225,26,170,28,211,231,154,166,237,187,233,201,204,58,190,78,93,118,84,18,213,90,25,11,19,25,32,195,52,246,212,205,9,250,0,173,178,193,55,42,196,109,44,118,84,134,143,218,227,62,195,179,198,48,165,204,229,141,36,206,255,67,234,199,120,240,26,254,44,176,186,139,243,214,6,239,106,154,235,119,208,90,203,17,78,188,128,157,118,161,103,40,176,216,113,233,158,32,164,252,237,144,136,18,245,211,193,57,170,193,81,98,103,242,217,80,82,11,82,64,118,103,65,82,23,242,89,136,148,182,152,130,128,238,79,125,77,90,55,194,146,84,122,201,248,187,60,239,168,28,140,42,216,49,58,145,173,174,65,61,68,252,181,127,217,188,213,233,25,102,234,191,9,224,119,247,191,129,205,167,10,114,102,40,236,84,143,2,22,28,16,53,65,172,120,192,84,26,40,168,82,67,98,168,125,192,53,30,248,64,164,104,150,101,52,10,111,90,64,223,47,177,180,163,239,107,179,76,151,206,87,87,117,145,113,236,123,13,59,23,248,31,149,209,128,151,235,126,210,167,1,192,161,155,240,17,33,28,251,149,240,189,222,240,62,8,58,88,154,71,82,228,131,246,57,13,65,14,115,189,168,195,248,23,34,218,75,2,110,192,167,50,193,230,75,3,59,7,15,103,232,20,102,78,5,2,175,0,135,91,157,205,21,0,3,198,0,4,41,197,25,161,252,14,232,24,29,136,163,235,7,126,56,103,92,231,47,197,239,171,172,92,223,84,252,19,150,254,182,45,104,3,188,234,118,183,159,65,11,37,185,82,151,184,138,169,240,185,217,240,216,57,132,247,176,42,214,248,191,255,1,127,135,226,225,113,54,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9c364ef-0938-41c8-b1b7-1356928fe099"));
		}

		#endregion

	}

	#endregion

}

