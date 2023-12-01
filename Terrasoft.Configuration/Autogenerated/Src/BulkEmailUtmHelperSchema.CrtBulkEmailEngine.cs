﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailUtmHelperSchema

	/// <exclude/>
	public class BulkEmailUtmHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailUtmHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailUtmHelperSchema(BulkEmailUtmHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16ccd8b5-68a6-4f4c-bd06-4e6ab647037e");
			Name = "BulkEmailUtmHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c79d6b8e-4dfb-4af0-8a52-3dfabe5c47b0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,90,123,115,219,184,17,255,91,157,233,119,64,152,214,166,98,154,178,115,233,205,212,182,164,38,182,47,241,92,156,228,98,187,153,169,165,120,40,17,146,89,243,161,128,96,108,213,209,125,246,46,158,4,31,18,233,78,47,147,73,68,0,139,93,44,126,251,36,99,47,194,233,194,155,98,116,137,9,241,210,100,70,221,227,36,158,5,243,140,120,52,72,98,244,248,231,63,117,178,52,136,231,232,98,153,82,28,29,150,158,97,121,24,226,41,91,155,186,111,113,140,73,48,173,172,121,31,196,223,42,131,151,248,129,186,159,241,60,11,61,114,250,176,32,56,77,217,38,249,58,83,164,40,74,226,250,25,130,221,211,152,6,52,192,6,233,59,74,23,87,52,8,3,186,68,125,197,240,11,158,184,198,4,172,134,245,207,9,158,179,115,30,135,94,154,30,160,55,89,120,119,26,121,65,120,69,163,19,143,122,124,205,34,155,132,193,20,77,217,146,202,10,174,33,181,100,146,36,33,186,74,49,204,161,71,52,199,244,16,165,236,159,149,177,38,165,132,137,120,146,192,38,113,218,180,12,118,186,72,50,2,55,212,188,240,28,251,65,214,200,24,22,30,123,209,194,11,230,113,139,165,160,234,86,59,38,49,197,49,109,90,121,137,163,69,232,81,124,156,248,213,3,173,196,133,224,216,23,119,210,116,63,239,112,184,192,132,175,234,245,122,232,40,205,162,200,35,203,129,124,230,20,104,150,16,116,159,144,59,116,31,208,91,38,41,162,222,60,117,21,77,207,32,90,123,205,130,17,187,104,118,34,45,17,128,149,122,49,5,169,62,145,224,59,156,74,204,47,196,3,154,178,121,117,240,79,30,165,152,196,96,8,119,0,72,203,62,242,174,191,14,198,47,134,215,95,119,199,183,4,207,70,163,244,69,255,122,100,141,182,199,93,123,120,20,194,186,193,245,87,254,188,211,181,213,4,163,217,233,14,7,214,97,51,171,79,30,241,162,51,201,145,45,238,88,176,49,72,76,232,64,113,103,92,53,119,246,79,46,1,27,150,18,140,70,195,231,76,138,225,209,183,12,147,229,141,224,51,128,97,49,207,38,135,48,59,35,222,60,2,16,220,4,254,224,185,22,158,205,192,149,14,184,236,131,238,70,209,255,233,133,129,127,69,66,166,162,235,93,111,247,63,163,81,182,247,234,167,189,93,254,255,171,217,235,221,127,241,95,251,114,228,229,108,111,247,239,255,56,248,171,123,51,26,237,252,254,188,63,126,124,233,188,252,219,207,171,209,200,189,174,82,179,89,54,55,177,159,178,55,219,218,253,253,249,112,171,215,235,143,95,112,249,59,157,38,229,11,227,214,122,191,254,122,48,222,57,232,245,184,50,124,62,55,168,17,176,86,132,113,219,133,187,55,227,199,125,231,231,253,85,123,2,119,252,184,231,172,186,54,8,214,6,82,96,10,239,189,9,22,215,51,220,26,219,25,141,110,82,238,157,126,176,159,83,233,86,248,67,196,157,17,255,9,180,226,199,84,120,137,110,127,35,55,110,118,159,207,124,142,96,12,196,31,224,63,198,115,2,54,121,131,217,236,13,9,124,181,71,201,97,212,218,39,183,108,201,82,90,121,253,249,56,239,51,95,31,179,200,178,223,196,243,28,211,219,196,95,231,17,64,28,170,130,196,89,250,5,135,225,47,9,1,61,93,145,224,130,11,98,75,121,152,249,119,69,96,233,124,247,8,162,56,165,210,117,176,41,247,44,246,241,195,199,153,189,61,220,238,162,126,31,237,238,163,33,159,65,7,98,193,69,54,17,91,217,123,78,149,164,123,168,119,142,60,58,189,85,104,69,16,141,241,131,123,206,198,112,106,43,174,142,182,75,71,172,248,184,16,225,254,108,30,67,248,61,246,82,140,126,20,103,142,179,144,102,4,159,197,192,35,128,59,144,28,9,134,209,216,100,10,1,60,131,176,49,64,123,124,197,74,25,87,11,5,39,20,210,14,236,139,249,114,0,16,17,128,96,80,123,138,132,197,129,30,82,234,234,197,189,242,234,163,5,195,27,138,1,108,125,75,144,164,214,64,92,140,136,30,114,208,246,113,24,68,1,240,22,195,219,206,54,130,40,179,125,184,221,117,143,122,124,151,124,83,113,228,116,240,30,152,163,100,166,246,56,234,169,9,1,16,121,24,5,17,182,250,72,250,89,244,22,83,161,44,54,170,32,34,247,49,81,178,16,40,134,123,20,107,92,134,46,143,218,214,215,199,189,213,95,44,167,232,156,12,16,64,234,5,247,5,116,246,140,36,145,82,23,252,149,76,220,139,5,36,76,118,140,239,175,199,16,181,225,188,14,59,45,90,117,249,22,240,7,65,20,103,89,96,9,65,130,222,189,36,65,100,119,29,37,224,90,20,233,237,96,191,32,166,137,9,20,99,234,254,22,19,92,3,34,48,132,125,99,153,148,200,88,119,189,55,118,223,146,36,91,164,215,242,130,173,177,11,216,206,112,215,189,76,184,118,139,64,21,138,81,200,92,139,179,207,226,42,17,191,122,64,28,81,126,133,37,31,25,132,51,14,19,112,128,187,42,247,104,5,65,72,46,173,1,79,49,21,61,207,93,214,66,204,132,234,66,249,206,84,9,209,128,56,41,49,96,13,188,32,247,188,210,37,85,242,93,38,151,130,157,164,202,36,73,21,122,121,132,232,3,8,183,242,192,208,127,220,23,143,42,104,244,31,95,174,44,71,220,31,99,225,234,204,183,52,40,178,220,210,160,202,104,229,253,5,51,100,63,147,162,156,165,31,178,48,252,72,78,163,5,93,218,138,128,229,181,93,117,140,142,62,192,14,248,252,45,21,179,250,22,218,65,38,129,216,124,213,146,133,204,137,55,113,145,1,177,192,72,146,153,188,36,28,21,253,255,9,144,9,4,194,185,71,19,178,212,216,106,139,205,137,2,5,132,105,107,160,33,130,224,241,143,134,231,27,131,181,137,83,112,24,200,20,107,61,68,215,68,251,157,2,57,56,4,185,113,209,37,180,190,3,102,1,140,177,199,227,14,115,253,44,14,167,204,173,222,223,6,211,91,180,76,50,20,99,56,34,56,58,112,178,152,208,167,187,8,21,165,46,111,177,102,163,156,118,229,34,76,74,106,20,98,130,156,39,57,72,141,111,166,86,74,176,6,58,71,83,55,164,93,93,200,148,218,32,69,22,167,144,168,76,73,48,193,231,222,148,36,233,235,48,128,56,32,15,52,213,157,5,118,44,79,76,177,159,20,38,53,41,143,34,224,229,25,121,115,248,133,170,6,130,71,60,197,45,47,162,1,150,39,1,151,15,46,72,70,107,7,25,81,155,37,79,41,224,224,51,6,157,78,177,93,136,234,242,154,20,1,50,111,68,58,55,158,40,102,188,155,160,151,41,213,235,1,130,191,101,1,129,36,82,79,156,157,198,89,132,137,55,9,177,230,182,78,211,102,254,112,187,132,42,87,128,180,15,10,185,223,112,58,101,20,96,188,216,3,21,218,60,226,139,88,203,19,85,80,110,57,153,52,142,103,150,195,235,179,1,237,55,153,171,205,133,99,13,42,202,84,247,43,94,218,154,163,97,175,57,97,135,249,215,32,206,176,144,86,122,83,126,88,182,213,59,64,3,28,53,223,67,37,7,108,82,165,6,146,84,165,93,120,10,7,240,25,37,159,5,114,163,165,228,66,142,124,194,87,216,230,232,59,26,169,97,197,86,229,224,128,82,116,250,48,13,51,31,215,98,147,242,92,39,0,216,199,88,67,95,91,151,1,147,32,101,254,236,129,193,188,156,199,151,101,118,202,245,92,99,66,150,103,233,232,199,15,244,76,64,242,176,192,93,187,229,51,255,233,82,152,126,184,73,152,162,44,181,1,184,108,18,221,162,168,70,151,161,190,10,43,139,90,162,191,202,109,137,91,17,236,83,166,208,24,181,173,23,63,174,62,92,92,189,177,212,38,218,100,36,162,184,95,99,23,222,100,162,194,14,214,115,226,27,25,216,239,212,74,74,137,134,52,28,8,68,185,83,79,171,130,141,48,94,53,27,128,202,109,3,106,91,91,53,87,223,229,32,201,245,220,100,142,218,16,142,111,241,244,46,47,110,16,175,217,226,59,67,249,98,66,64,202,47,158,166,169,154,93,139,63,177,126,61,236,14,115,133,212,214,28,12,135,74,161,207,84,240,125,29,47,101,245,131,250,131,118,53,136,123,250,45,243,66,85,52,57,72,128,241,56,129,196,150,4,105,18,187,31,137,31,196,94,104,122,200,92,181,101,205,204,96,171,90,61,51,61,73,93,156,107,119,93,244,98,134,191,170,245,175,101,141,179,249,19,12,40,12,211,117,106,215,172,156,154,254,100,123,221,27,156,140,162,47,215,130,81,244,123,136,119,43,165,135,144,243,210,230,248,140,204,71,251,149,51,152,87,100,118,60,75,17,65,84,0,117,240,215,22,120,198,179,137,223,114,110,54,139,56,6,119,167,18,190,187,37,115,84,92,76,147,43,220,245,211,216,101,235,216,24,154,99,161,159,55,147,74,185,92,81,135,162,54,150,232,41,85,125,80,234,65,121,55,132,138,238,241,167,213,227,43,93,215,117,58,155,116,205,123,211,74,201,154,162,12,204,211,184,8,204,154,141,88,239,90,87,246,77,27,25,234,233,182,18,211,104,115,87,132,221,68,135,99,189,94,107,223,200,106,94,251,126,173,181,57,134,166,187,5,131,46,212,134,249,78,141,149,137,128,73,202,115,9,246,66,68,220,174,232,184,240,177,207,239,243,2,77,93,109,203,138,196,208,166,53,248,205,48,192,63,174,160,80,9,250,105,161,128,169,161,219,152,201,127,79,2,31,213,27,80,213,105,84,178,113,101,132,235,155,2,38,204,180,201,22,253,80,213,136,182,192,138,180,237,232,204,95,62,27,196,238,5,51,157,244,11,28,217,182,134,86,23,13,81,97,86,119,131,247,157,194,196,123,28,207,65,75,187,204,133,30,152,51,18,104,43,4,154,195,245,210,22,10,97,129,197,85,219,230,184,209,142,175,69,232,235,197,2,246,72,121,91,194,104,21,72,124,150,42,213,39,181,211,228,187,84,246,192,210,233,34,131,205,24,45,246,60,224,31,149,143,235,0,240,63,214,186,199,133,58,151,237,104,212,186,6,89,99,145,187,198,2,138,39,44,88,129,122,57,91,234,177,152,175,105,25,168,84,161,80,223,12,116,80,185,247,34,33,250,148,66,148,149,156,96,46,165,174,141,112,125,133,183,198,125,209,40,51,199,4,4,235,170,107,88,93,236,158,115,90,249,234,93,130,188,218,32,170,54,65,121,207,243,176,40,89,49,110,11,178,117,205,169,66,99,42,111,81,174,87,70,81,27,157,77,90,131,104,45,100,130,96,99,54,13,55,244,38,10,149,126,77,163,66,247,38,42,170,150,67,226,19,7,167,216,214,172,38,51,206,250,162,166,208,84,51,195,224,124,14,238,2,184,217,213,187,151,252,236,105,70,160,78,166,78,78,215,101,89,182,28,118,213,41,244,172,251,43,94,26,139,101,12,238,182,104,163,70,201,119,92,113,67,252,37,73,70,194,182,158,7,150,90,3,168,131,214,27,174,152,108,180,76,33,15,40,247,23,144,0,202,85,85,66,102,121,141,37,21,154,219,41,9,196,215,11,174,32,214,225,53,85,123,100,236,181,94,237,43,87,7,25,237,123,203,65,66,251,150,217,180,183,228,26,214,45,87,191,101,79,91,61,138,118,191,213,172,109,40,100,191,243,188,4,179,207,121,150,204,219,51,197,115,188,181,212,180,160,180,6,167,98,135,100,242,111,240,171,79,106,132,42,223,201,82,195,13,247,165,228,218,116,105,21,95,41,15,120,153,200,1,91,138,41,164,174,109,4,150,174,149,217,122,253,247,71,157,142,252,234,168,143,228,126,46,243,227,0,121,31,194,75,22,197,28,243,71,172,136,30,216,150,88,107,169,124,247,68,59,203,13,164,170,243,103,201,213,154,58,255,66,169,29,189,94,111,238,32,63,93,106,189,195,185,68,85,190,131,254,166,169,245,30,138,194,220,133,127,238,212,122,7,182,186,32,131,252,10,170,189,8,210,86,212,30,165,72,103,66,65,120,118,211,138,74,121,86,245,243,41,24,129,63,255,5,22,119,71,255,228,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16ccd8b5-68a6-4f4c-bd06-4e6ab647037e"));
		}

		#endregion

	}

	#endregion

}

