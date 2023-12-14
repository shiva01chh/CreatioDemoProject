﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailMacroParserSchema

	/// <exclude/>
	public class BulkEmailMacroParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailMacroParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailMacroParserSchema(BulkEmailMacroParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b568a253-649b-4a3e-93ef-966c259b9c1f");
			Name = "BulkEmailMacroParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,89,91,83,27,57,22,126,246,84,205,127,80,204,212,76,59,120,154,204,62,6,76,42,16,146,184,54,4,10,227,201,3,97,82,77,183,140,85,233,139,87,82,19,92,132,255,190,71,151,110,93,172,110,179,153,221,135,229,5,183,90,231,162,79,223,185,72,93,38,5,102,171,36,197,232,18,83,154,176,106,193,227,227,170,92,144,219,154,38,156,84,229,207,63,61,252,252,211,160,102,164,188,69,179,53,227,184,216,247,158,97,126,158,227,84,76,102,241,59,92,98,74,210,141,57,31,72,249,175,141,193,75,124,207,131,131,241,5,190,173,243,132,158,220,175,40,102,76,104,222,152,247,9,223,152,49,219,249,162,168,202,240,27,138,205,248,156,147,92,40,133,129,29,138,111,193,4,58,206,19,198,94,162,163,58,255,122,82,36,36,63,77,82,90,157,39,148,97,42,231,237,237,237,161,3,86,23,69,66,215,135,250,249,156,86,119,36,195,12,21,152,47,171,140,161,69,69,17,95,98,180,2,57,97,167,16,74,24,250,70,248,146,148,8,11,189,8,220,95,229,9,199,113,163,116,207,210,186,170,111,114,146,162,84,56,211,225,203,224,65,250,99,28,7,124,120,82,114,112,254,156,146,59,208,172,222,175,212,3,74,197,123,196,56,21,14,125,169,75,86,223,176,148,146,27,44,181,126,4,10,160,9,26,206,63,206,230,71,95,230,23,31,134,251,221,194,55,171,66,187,194,57,166,165,144,187,218,121,120,241,184,115,221,39,117,155,87,55,137,90,195,44,93,2,8,237,186,132,130,246,161,79,69,138,153,111,248,249,119,48,252,253,121,159,84,77,243,147,50,173,50,156,249,194,115,154,131,244,112,95,35,137,203,76,129,233,34,251,150,224,60,179,97,29,12,108,99,20,39,89,85,230,107,4,124,197,247,104,238,90,99,175,115,146,48,245,106,130,74,252,77,77,139,134,127,193,196,248,249,47,195,209,126,143,50,223,247,191,167,172,104,118,58,160,225,243,231,171,157,232,234,175,207,159,175,175,159,143,118,224,95,151,46,133,234,213,53,250,66,202,187,36,39,217,220,80,9,188,56,167,120,65,132,238,135,225,146,243,213,203,189,189,225,24,201,159,76,252,126,236,83,138,190,228,164,252,138,179,147,146,19,190,134,140,82,23,101,67,204,15,214,155,225,211,149,40,166,9,37,97,25,181,71,239,113,190,194,244,207,127,104,136,244,243,147,105,81,113,200,124,56,107,226,77,63,26,35,115,8,88,8,207,82,229,71,239,113,139,21,25,214,180,78,121,69,133,45,153,23,212,12,63,19,201,129,99,48,202,33,19,17,153,12,32,163,87,11,152,132,33,36,96,95,38,195,80,42,25,238,29,170,68,19,183,90,237,84,212,228,162,144,104,228,193,103,163,55,66,162,102,12,6,14,164,176,147,30,194,48,195,131,199,157,242,42,222,128,107,48,120,252,191,64,96,220,48,50,76,200,17,122,9,69,130,176,40,136,90,88,6,192,233,97,247,99,63,149,78,85,117,234,168,15,218,215,75,186,126,135,249,27,194,160,56,173,255,76,242,26,171,56,140,244,251,162,77,67,141,171,119,9,69,120,211,79,51,17,77,38,157,145,253,170,43,92,1,28,163,65,241,132,44,144,246,34,158,178,143,117,158,159,209,79,75,194,241,76,180,46,145,239,194,168,241,111,64,49,175,33,223,151,32,161,20,61,6,253,6,159,93,170,197,182,79,167,73,153,220,98,26,191,37,101,54,213,212,58,90,11,67,155,150,149,21,109,214,126,251,74,138,3,252,130,90,26,99,3,70,52,178,119,209,219,23,216,20,73,53,53,29,106,216,82,83,111,90,46,42,5,85,179,96,129,147,28,136,129,163,96,126,154,161,103,19,244,174,38,89,124,82,172,248,218,7,70,205,53,138,125,144,178,138,159,87,140,216,193,25,203,109,137,167,101,134,239,207,22,209,48,134,36,63,147,142,66,235,5,93,15,97,0,223,25,205,72,153,228,46,28,182,50,240,234,247,63,128,2,182,202,25,212,18,169,40,178,103,238,162,63,68,184,116,146,211,210,16,4,81,44,190,133,176,65,229,135,1,68,223,191,107,159,167,236,157,236,106,194,144,54,210,62,160,171,70,171,173,116,191,125,77,171,138,159,228,184,128,57,210,67,15,244,217,42,39,60,250,45,254,109,116,245,226,90,73,49,232,44,211,37,138,124,201,214,173,52,97,216,171,161,47,213,155,129,229,204,41,228,54,185,133,192,111,22,203,84,119,169,187,84,5,149,90,144,82,208,44,107,48,184,129,140,251,117,223,54,4,26,120,146,242,191,97,67,107,8,26,121,180,249,180,178,49,246,118,253,166,170,114,52,101,51,200,135,152,74,237,157,91,30,220,55,145,184,158,232,175,162,65,175,27,110,249,232,244,228,199,24,160,253,223,20,156,244,53,222,33,111,239,42,8,149,105,73,148,2,102,206,117,209,244,164,172,11,76,147,155,28,31,24,239,15,117,205,179,253,151,35,50,57,128,231,47,148,135,112,38,194,137,32,105,59,1,74,180,39,59,112,163,10,132,221,221,211,64,65,248,109,192,169,94,237,219,106,76,70,19,129,182,153,63,3,34,146,162,205,79,240,67,70,102,52,130,28,37,3,245,35,254,38,254,71,163,166,58,197,45,65,125,230,108,102,155,128,57,133,162,56,236,130,128,46,109,111,43,90,36,60,242,15,89,99,155,1,174,22,93,100,209,47,195,211,215,199,23,103,179,7,3,255,227,208,158,41,135,118,119,173,40,234,172,53,115,239,124,40,109,108,97,128,161,138,205,5,121,210,116,88,108,77,132,122,72,25,63,163,111,240,34,169,115,30,89,206,162,201,33,50,155,242,132,64,116,207,33,211,108,180,239,250,208,192,164,113,182,146,174,200,247,150,155,144,235,69,175,208,146,50,36,221,236,146,119,34,29,91,203,117,182,202,201,89,70,97,103,0,190,37,247,83,235,120,165,86,248,100,252,155,98,124,84,147,28,130,71,59,173,159,58,55,167,115,219,55,182,183,179,31,83,241,98,180,250,77,152,95,9,55,143,144,106,89,224,77,223,241,82,169,140,103,88,56,20,49,156,47,4,91,180,47,192,144,52,81,163,246,118,140,70,241,101,245,154,210,100,173,251,44,55,35,105,107,167,77,98,234,242,172,93,144,131,105,124,129,129,137,208,133,218,106,28,235,221,65,39,247,91,203,207,153,111,239,127,180,231,254,30,255,208,246,247,236,190,175,164,143,8,97,36,131,106,198,91,227,47,120,179,53,10,54,133,54,178,74,237,161,4,129,230,186,132,178,79,132,47,85,121,209,153,145,209,212,134,114,9,108,148,109,40,51,157,141,184,83,132,166,21,179,88,158,16,223,243,34,127,223,78,139,132,2,167,98,27,21,241,167,37,166,56,186,23,84,246,174,106,0,225,211,4,58,188,232,62,188,146,15,132,113,135,28,114,25,196,185,135,178,10,249,198,116,181,195,98,184,61,179,122,43,133,227,206,178,162,13,46,154,45,65,160,218,5,202,70,6,51,72,235,250,166,233,13,145,230,225,232,163,225,30,35,203,137,96,84,122,125,130,240,176,37,82,251,254,156,86,64,3,134,69,213,93,36,57,195,186,230,137,91,88,21,219,178,11,65,207,188,217,191,254,10,111,14,188,165,65,250,168,75,14,206,32,178,187,219,218,242,49,16,75,242,228,244,143,215,60,34,77,121,150,25,210,150,138,101,91,75,74,29,83,86,253,31,9,111,158,41,184,226,127,226,53,243,167,122,81,164,60,2,84,155,228,45,0,54,104,186,205,198,96,208,76,140,59,202,88,248,138,116,140,92,57,163,79,57,122,101,185,118,173,124,144,179,219,105,27,219,195,105,221,236,142,14,126,253,207,169,143,26,6,29,22,151,149,216,246,240,225,216,206,157,167,170,197,105,88,201,89,212,147,16,199,193,232,175,13,163,199,118,150,71,85,222,164,116,61,208,44,213,185,4,209,162,151,149,246,8,22,108,105,180,227,251,222,108,111,163,122,20,226,191,17,23,65,176,97,192,141,133,42,35,11,130,51,19,150,142,253,54,177,154,181,180,139,216,239,43,105,70,197,56,96,227,137,133,237,168,202,214,91,10,26,135,48,80,207,79,42,101,225,60,97,148,56,216,52,43,13,183,218,27,69,36,208,106,135,177,241,195,120,236,88,122,106,209,167,249,22,104,234,102,70,47,50,38,119,87,53,53,228,112,121,212,155,187,149,92,95,30,110,61,249,47,195,219,25,195,222,10,237,8,69,255,49,250,219,111,70,183,221,175,203,154,206,52,194,146,109,80,7,196,85,191,72,92,12,165,109,145,21,215,206,11,40,37,153,46,93,29,87,203,114,100,149,208,164,64,37,84,251,201,16,234,231,240,112,102,212,199,7,123,242,181,153,173,109,29,170,117,67,130,60,216,107,134,36,195,212,101,245,29,161,188,134,35,116,23,165,154,227,169,221,23,132,75,191,41,189,162,43,87,79,234,178,58,14,42,105,27,128,224,37,130,85,200,173,243,153,215,171,104,99,253,93,140,211,180,180,70,205,104,60,45,25,166,252,34,41,111,113,244,98,28,52,226,246,98,70,118,235,87,6,205,87,214,124,218,205,224,88,82,170,187,74,136,18,155,30,98,4,162,46,145,55,55,79,37,129,148,223,194,3,91,32,201,117,88,14,15,143,29,10,106,242,117,146,200,20,103,109,164,135,74,154,30,118,168,178,200,73,57,227,78,186,181,14,122,89,169,61,238,181,19,156,54,184,243,243,167,233,136,155,206,200,176,201,212,0,71,239,201,125,138,87,60,50,25,204,72,56,73,70,55,83,78,162,117,83,227,70,222,182,242,179,159,145,3,114,86,45,180,107,158,91,229,148,68,248,26,160,93,83,88,168,251,44,185,69,80,135,129,91,234,46,43,133,132,105,192,244,231,111,69,14,189,255,106,151,90,68,100,235,230,124,50,98,226,48,211,86,168,230,72,89,114,209,66,216,55,159,178,245,211,47,172,11,35,249,108,174,29,186,63,178,183,196,48,86,237,179,167,171,253,61,231,43,117,94,91,199,226,114,33,225,75,165,54,114,29,12,220,225,56,170,122,190,190,169,81,123,16,70,196,223,191,1,31,83,173,232,117,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b568a253-649b-4a3e-93ef-966c259b9c1f"));
		}

		#endregion

	}

	#endregion

}

