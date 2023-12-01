﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SelectQueryBuilderSchema

	/// <exclude/>
	public class SelectQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SelectQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SelectQueryBuilderSchema(SelectQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d1a47978-299c-4f69-8d99-15b0e768777c");
			Name = "SelectQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,26,219,114,219,184,245,89,59,179,255,128,104,59,91,106,70,165,211,215,216,86,198,178,157,172,182,113,226,70,206,230,193,147,241,80,36,36,177,161,72,25,0,109,171,30,255,123,15,110,36,0,130,148,28,79,19,207,182,251,144,181,200,115,191,227,16,121,180,194,116,29,197,24,93,96,66,34,90,204,89,120,92,228,243,116,81,146,136,165,69,254,243,79,247,63,255,212,43,105,154,47,208,116,67,25,94,237,59,191,1,62,203,112,204,129,105,248,22,231,152,164,113,3,230,93,154,95,215,15,77,94,171,85,145,251,223,16,220,246,60,60,25,183,190,58,205,89,202,82,76,91,1,222,68,49,43,72,11,196,251,50,13,167,152,220,164,49,62,43,18,156,133,39,17,139,192,32,140,0,214,78,8,167,119,12,231,148,27,163,6,23,50,109,166,241,18,175,34,116,216,38,113,104,130,1,50,160,255,66,240,2,72,161,73,206,48,153,131,155,94,161,201,20,115,107,255,179,196,100,51,46,211,44,193,68,128,238,237,237,161,3,90,174,86,17,217,140,212,239,223,112,182,166,136,21,104,198,1,17,190,75,41,227,242,28,80,140,81,76,240,252,176,47,169,245,247,70,232,154,83,68,183,41,91,162,28,223,162,184,200,202,85,78,135,240,71,158,164,194,187,8,179,56,212,172,246,12,94,235,114,150,165,49,74,181,148,126,33,123,247,66,208,74,169,51,204,150,69,66,95,161,115,129,46,95,186,106,136,7,71,73,66,181,64,168,152,35,182,196,136,10,14,127,165,136,20,5,67,88,152,14,81,97,187,176,34,180,231,82,58,88,71,36,90,161,28,194,254,176,47,41,126,154,36,180,63,154,36,156,196,60,197,68,112,208,204,192,118,81,146,132,7,123,2,175,38,67,48,43,73,78,71,199,37,33,128,8,170,83,22,229,160,57,224,26,214,245,216,1,76,125,176,167,209,57,61,15,12,87,248,88,74,16,76,78,243,114,133,73,52,203,240,193,219,50,77,70,168,22,123,176,255,163,140,118,122,183,38,152,138,48,239,143,164,168,16,94,213,179,231,98,176,99,71,88,109,60,67,252,237,54,228,134,155,167,25,196,54,221,213,72,18,252,20,242,134,215,143,254,232,2,72,196,89,10,138,255,109,22,81,156,40,122,8,3,4,74,0,164,221,96,250,193,55,24,14,237,141,12,129,119,48,225,27,169,101,48,219,48,124,249,5,217,90,60,87,67,53,201,209,243,136,155,74,149,54,65,83,6,62,154,23,132,231,51,175,129,70,89,155,147,98,165,25,109,231,17,151,148,21,171,115,176,122,122,167,4,22,79,80,148,165,17,69,107,241,66,112,90,240,102,24,49,208,226,247,34,237,74,138,103,227,227,33,154,42,67,53,13,57,228,68,123,148,17,97,61,195,8,157,129,241,22,51,25,24,171,104,189,230,152,51,204,110,49,206,209,34,189,129,127,227,70,233,64,81,158,136,126,197,60,109,10,180,213,40,194,218,208,52,181,209,52,195,153,82,149,46,139,18,122,222,12,43,98,51,12,46,193,224,19,38,90,32,91,166,20,221,68,89,137,187,66,213,117,208,153,82,34,73,197,188,3,176,67,116,187,196,64,247,43,222,32,160,184,93,228,161,228,202,129,133,9,106,203,85,152,110,213,234,183,250,248,164,146,227,64,58,102,136,154,37,15,92,224,62,84,122,4,157,174,19,65,3,77,159,15,52,9,4,177,24,16,30,99,173,137,63,140,107,195,180,104,165,98,80,240,175,68,252,5,132,144,131,131,248,253,32,231,35,251,161,158,44,142,179,136,210,199,141,74,2,5,162,34,98,104,249,157,166,166,203,19,60,143,202,140,141,211,156,87,164,128,109,214,184,152,7,30,169,7,131,47,245,148,21,11,73,61,201,221,162,176,59,118,193,52,203,221,194,248,224,69,210,27,168,79,242,253,90,254,224,146,83,134,84,158,203,12,135,153,181,127,117,213,247,123,162,34,252,38,197,89,210,70,149,224,40,41,242,108,163,11,204,149,172,200,251,94,24,79,88,155,179,177,208,111,132,174,48,189,30,111,164,132,126,58,191,69,116,57,197,76,205,77,87,245,224,4,10,113,111,89,239,69,164,117,11,227,166,145,71,44,9,82,49,211,5,227,80,20,79,206,243,155,200,237,32,155,54,148,252,63,8,64,240,58,131,89,92,205,69,71,178,92,42,197,219,241,218,242,205,14,31,82,242,51,212,46,163,251,36,135,44,128,194,247,111,224,29,9,222,102,115,227,141,161,145,86,206,240,39,3,126,215,129,130,170,166,127,170,179,86,62,8,209,5,47,248,197,236,95,60,248,110,211,44,227,157,97,85,36,124,228,79,80,52,231,189,95,244,4,153,94,43,121,54,1,97,111,138,175,56,49,184,215,45,92,229,99,83,232,64,197,184,100,61,64,247,178,115,74,65,142,151,56,254,122,68,22,48,163,230,236,125,153,101,1,23,28,242,94,65,75,79,247,84,126,128,191,140,68,233,153,33,223,238,202,102,174,168,248,121,232,118,109,125,32,243,101,48,120,141,129,186,55,69,154,200,113,91,23,56,173,46,139,8,116,87,53,44,32,21,190,10,200,168,135,218,30,233,28,5,38,74,88,1,195,95,37,76,65,35,244,82,195,246,110,34,130,224,208,190,72,243,40,171,57,43,19,216,172,90,136,42,187,246,218,88,102,56,34,129,6,106,178,10,63,147,104,61,206,138,248,107,176,133,18,216,38,104,226,239,128,212,84,69,107,223,123,87,44,210,56,202,62,172,177,220,202,128,226,238,163,240,40,79,36,244,195,14,188,98,87,176,7,241,47,206,40,214,76,45,236,207,124,200,105,193,122,240,198,73,75,41,227,161,115,74,175,229,143,224,19,197,4,4,203,229,250,8,149,214,79,57,112,246,220,42,217,56,194,121,2,30,65,158,152,113,230,162,132,146,232,121,196,150,225,132,190,47,68,34,126,32,167,171,53,219,4,131,42,234,228,80,194,137,133,213,1,179,139,150,101,75,47,223,250,207,11,232,246,232,240,176,41,187,13,18,158,243,122,131,161,60,89,185,176,214,79,33,18,26,76,42,148,253,14,53,42,10,225,31,124,30,29,214,36,67,24,24,249,97,128,179,15,108,151,12,44,13,217,146,20,183,34,3,193,130,147,213,58,195,188,166,225,228,244,46,198,107,145,138,86,217,217,61,64,62,226,27,56,124,224,163,197,2,42,147,136,238,167,196,11,222,53,82,184,97,213,168,126,232,88,11,251,220,61,52,72,135,134,176,194,111,23,197,20,202,113,204,130,193,16,21,37,67,156,56,45,103,130,169,178,162,254,25,74,121,68,139,174,106,187,49,215,136,80,50,88,77,203,153,58,197,241,0,202,33,116,221,136,149,90,152,190,50,217,75,100,174,163,143,102,40,186,24,228,168,252,29,84,82,126,44,10,38,37,13,97,134,26,186,214,87,18,43,47,120,176,132,126,174,234,154,41,47,74,182,124,10,178,169,145,19,78,170,251,188,213,181,106,172,240,121,8,111,9,24,228,63,4,43,13,228,4,76,42,249,223,67,122,232,57,201,62,0,43,235,91,107,94,108,239,124,109,206,214,170,247,44,202,163,133,76,59,125,98,26,111,56,179,192,230,173,12,50,105,196,176,212,119,194,176,222,98,240,198,40,55,235,159,88,154,201,229,50,48,135,164,98,199,98,185,82,91,232,162,168,60,77,3,111,62,185,27,2,83,49,25,8,238,50,64,133,27,100,16,200,1,90,53,4,14,76,12,155,226,160,142,120,189,74,2,10,74,67,101,29,26,12,160,106,119,20,235,42,22,36,55,167,134,89,13,15,160,205,16,252,81,86,83,66,169,88,6,169,166,122,252,219,85,159,90,253,105,61,48,58,169,210,172,126,94,239,120,66,220,174,156,182,199,140,62,107,206,167,225,5,217,0,121,209,93,28,135,235,122,24,71,64,129,151,154,134,23,171,55,110,13,147,65,197,123,78,83,110,159,84,189,201,34,47,8,62,73,41,156,134,54,66,24,158,29,112,130,193,202,83,190,226,107,138,43,5,216,175,194,5,134,99,126,252,48,90,22,4,227,31,41,77,103,25,86,148,155,195,250,165,73,241,139,116,171,235,55,159,199,196,180,253,105,157,192,223,99,56,191,73,215,138,109,98,224,198,138,233,135,234,161,234,86,84,141,212,208,46,254,142,126,253,21,53,223,139,243,18,29,111,132,29,130,254,36,233,15,56,224,139,26,18,14,203,245,48,109,187,203,116,146,183,108,130,194,234,64,19,78,139,146,196,216,152,86,106,168,125,63,1,33,82,23,5,1,96,33,87,82,75,88,77,161,86,198,79,3,189,126,221,5,227,74,170,5,154,64,42,18,238,20,183,96,135,71,52,240,137,50,144,198,11,63,152,24,149,4,110,199,17,206,224,5,239,186,140,50,47,61,5,99,75,37,119,206,124,154,138,242,5,54,66,66,188,104,153,204,132,245,32,107,121,215,54,22,7,85,73,16,143,132,110,250,84,251,28,220,77,45,47,111,53,169,133,27,215,90,2,238,95,250,247,50,71,31,238,13,162,15,87,247,181,230,15,253,186,69,25,200,225,59,156,47,216,18,78,173,39,227,186,127,156,140,207,162,59,81,117,228,235,42,113,108,182,38,29,152,196,164,104,193,203,97,55,45,51,237,172,49,169,182,144,175,156,84,83,45,223,132,5,86,249,174,55,100,252,88,212,113,38,50,89,119,206,88,134,35,109,184,22,239,127,215,240,249,62,3,27,255,238,0,237,12,5,124,205,88,127,189,69,105,110,174,36,43,3,55,82,141,23,46,115,122,208,37,27,216,143,55,128,26,84,68,6,234,157,8,146,218,70,210,183,212,46,248,71,249,198,56,83,160,195,145,90,53,224,174,195,170,209,244,156,99,170,52,179,81,50,160,123,52,41,90,229,184,153,169,188,51,185,192,38,201,195,67,179,2,85,22,131,100,2,251,228,186,239,170,176,124,82,113,240,87,7,79,97,52,228,81,152,254,197,235,101,13,248,197,78,120,141,102,249,39,160,102,117,55,152,240,150,98,32,119,236,97,68,174,159,97,178,192,159,83,182,132,81,170,74,245,167,36,172,53,225,201,113,42,124,83,144,83,8,240,64,204,102,35,115,77,65,42,107,169,246,91,133,159,92,40,165,252,204,82,133,94,143,255,12,91,150,50,106,108,49,79,161,154,214,155,52,79,84,2,86,20,6,232,133,58,26,43,226,112,32,127,7,35,78,181,189,83,195,228,163,231,108,141,104,169,229,12,83,82,185,234,185,90,108,128,105,156,71,106,234,0,73,101,143,119,68,172,185,84,38,86,6,171,34,223,54,178,138,239,218,46,132,178,15,68,125,102,10,244,106,163,50,183,124,32,189,104,20,72,35,201,171,180,19,118,53,35,78,22,21,131,245,11,103,19,161,188,217,145,58,53,178,20,65,240,181,121,180,37,83,59,42,79,174,154,177,166,243,224,108,70,27,197,208,152,146,212,51,13,234,31,190,235,169,91,37,224,35,23,236,127,218,27,79,59,220,223,81,223,77,158,114,239,73,5,153,57,175,84,46,180,175,71,213,163,17,255,186,99,58,233,127,235,210,212,227,141,190,203,221,41,229,7,94,181,118,128,231,96,158,125,53,125,237,20,62,223,230,156,191,223,50,147,214,30,126,14,131,233,247,153,45,183,236,217,58,54,108,16,95,31,241,116,25,145,53,191,245,148,82,238,115,84,240,224,58,47,168,88,102,112,91,127,196,115,104,101,57,215,84,237,244,5,178,215,59,186,71,185,47,141,126,101,127,21,191,116,33,191,120,162,195,93,172,243,70,227,238,218,223,23,57,86,149,254,117,231,247,3,119,255,219,252,148,196,63,7,40,82,175,236,111,85,187,225,90,237,224,241,165,231,79,120,215,176,187,242,116,95,57,84,113,163,204,104,128,187,235,85,62,122,232,47,16,131,231,108,234,31,123,91,81,131,60,230,214,34,82,243,163,134,225,183,220,226,17,191,15,116,176,23,143,188,55,35,158,117,80,117,222,113,236,250,188,83,127,147,208,164,30,219,144,158,220,84,220,67,139,255,163,151,191,175,13,27,118,112,22,141,106,49,213,252,152,227,110,148,237,107,26,112,58,120,185,77,113,251,190,136,199,240,252,28,174,196,30,34,15,175,111,168,167,255,191,121,250,223,188,121,170,18,240,201,23,80,141,79,239,218,79,173,247,154,26,148,3,119,195,198,201,124,189,89,27,171,53,197,168,10,208,182,91,7,213,193,15,216,3,5,121,172,84,71,192,173,55,80,20,206,63,240,198,88,184,85,20,121,30,154,223,159,234,35,178,210,248,178,6,53,225,236,67,173,203,211,222,117,213,87,23,140,111,29,254,19,178,185,19,244,158,174,237,15,119,245,155,250,187,157,70,147,135,117,115,15,103,74,96,65,217,226,174,172,1,112,139,142,42,201,117,242,43,220,173,249,255,195,174,47,91,247,2,245,45,102,101,35,103,247,46,21,180,151,116,86,165,51,175,201,250,151,11,190,139,208,226,25,252,247,31,35,25,122,168,222,55,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1a47978-299c-4f69-8d99-15b0e768777c"));
		}

		#endregion

	}

	#endregion

}
