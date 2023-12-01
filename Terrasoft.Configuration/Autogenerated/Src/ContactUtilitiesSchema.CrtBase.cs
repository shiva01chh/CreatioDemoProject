﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactUtilitiesSchema

	/// <exclude/>
	public class ContactUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactUtilitiesSchema(ContactUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed9513e0-8962-4ef7-9da0-fa9db5e93539");
			Name = "ContactUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,28,203,146,219,54,242,60,169,202,63,96,153,11,85,81,56,246,213,158,81,162,121,101,181,107,123,198,150,157,28,178,57,112,72,72,194,134,15,133,32,199,86,54,249,247,237,198,131,4,72,80,162,164,177,157,212,110,170,82,35,130,141,238,70,119,163,95,4,156,133,41,229,235,48,162,228,45,45,138,144,231,139,50,184,204,179,5,91,86,69,88,178,60,251,242,139,255,124,249,197,73,197,89,182,36,243,13,47,105,250,188,245,12,240,73,66,35,4,230,193,247,52,163,5,139,58,48,87,97,25,118,6,95,176,236,215,206,224,91,250,161,12,222,208,101,149,132,197,245,135,117,65,57,71,204,13,156,201,104,154,230,153,251,77,65,251,198,131,171,139,222,87,215,89,201,74,70,157,212,230,155,12,215,5,111,190,42,232,18,120,34,151,73,200,249,51,2,242,42,195,168,124,87,178,68,76,22,48,167,167,167,228,140,87,105,26,22,155,137,122,190,43,242,7,22,83,14,47,40,37,81,65,23,231,158,154,236,157,78,72,37,16,108,72,74,203,85,30,243,64,99,57,53,208,172,171,251,132,69,132,151,160,156,136,68,200,128,131,254,9,234,236,4,255,215,172,190,148,56,159,1,15,236,33,44,169,126,223,102,83,12,188,161,101,85,100,22,155,66,48,155,70,211,200,111,190,112,44,4,117,82,101,44,10,53,212,253,134,208,52,100,9,9,227,24,149,25,212,100,79,219,116,207,214,97,17,166,36,3,155,60,247,42,78,11,192,153,41,122,19,131,212,59,251,21,16,97,25,72,36,139,104,112,118,42,112,184,81,10,62,188,201,181,197,206,214,25,145,92,212,44,126,93,209,2,151,95,165,217,43,120,227,77,212,114,9,139,201,175,248,142,68,226,165,152,55,8,39,162,233,197,138,144,67,240,22,82,83,147,199,208,20,96,215,232,16,255,90,26,138,54,181,54,90,242,61,45,93,136,248,197,70,200,215,183,149,68,108,117,142,1,109,129,219,75,168,100,140,244,78,78,242,170,212,195,125,114,31,147,46,144,67,144,35,34,54,192,201,67,88,16,42,24,159,71,43,32,245,50,204,194,37,45,200,121,139,29,112,91,165,5,225,43,49,90,131,222,136,132,156,56,94,60,175,137,69,14,137,72,80,193,33,16,206,232,123,11,133,24,247,29,76,142,137,91,81,35,73,173,79,66,64,98,7,19,193,52,142,37,188,175,41,4,179,216,27,5,56,221,66,238,144,236,97,232,133,113,59,8,236,131,227,178,160,96,142,241,45,72,32,184,45,98,90,92,108,166,60,242,71,141,240,23,44,41,133,114,119,97,151,168,110,4,248,143,172,92,221,225,166,162,240,192,125,57,8,51,97,163,49,158,103,111,55,107,136,10,191,86,97,2,250,120,85,165,247,96,6,202,92,79,132,237,142,134,45,72,226,229,184,48,95,242,169,38,202,45,183,147,101,48,208,246,14,244,109,27,150,248,254,16,193,199,237,214,239,10,10,171,130,240,179,94,229,25,37,153,88,13,89,228,5,120,26,22,253,66,56,13,139,104,133,14,59,102,75,86,114,146,103,201,102,168,187,22,56,189,201,157,137,186,204,201,186,200,35,240,178,189,142,235,13,125,0,177,208,216,230,169,92,133,165,20,9,56,118,147,155,173,46,74,185,5,181,204,185,88,141,84,153,175,94,9,34,218,57,68,171,176,248,233,103,57,118,37,72,76,33,212,227,30,133,236,131,126,128,28,100,157,64,98,228,11,128,49,249,206,251,215,149,7,70,0,230,247,54,191,132,185,2,90,219,159,120,8,212,106,252,54,78,91,215,232,2,36,67,61,128,74,137,95,209,44,150,225,91,61,27,177,60,206,49,150,139,100,96,139,198,127,128,92,108,1,25,1,8,148,18,250,129,65,130,5,65,18,195,1,14,40,155,35,28,18,155,85,145,103,236,55,97,118,96,7,101,9,204,29,28,169,167,117,56,174,41,85,69,1,46,78,120,93,36,171,221,238,214,56,137,108,93,177,66,99,173,127,34,210,22,203,3,131,184,55,153,197,173,197,247,135,212,155,36,92,26,50,27,32,36,203,52,173,60,237,62,207,19,50,227,152,65,42,119,118,141,136,119,197,200,185,41,1,98,201,99,76,190,175,32,245,168,151,166,141,90,142,74,113,223,22,203,16,248,165,5,172,186,19,241,46,37,12,114,16,92,106,44,210,76,231,20,61,12,145,127,166,235,117,206,178,50,69,245,157,75,199,135,246,43,95,182,93,144,114,140,39,39,129,242,222,55,85,22,193,239,42,43,125,143,115,220,62,24,105,12,184,155,34,79,125,111,10,211,31,48,0,194,18,231,74,176,176,207,166,92,204,50,192,103,64,170,248,7,48,228,123,47,193,249,222,231,31,28,83,82,107,202,109,38,70,20,233,96,198,133,55,215,236,56,176,32,152,147,34,20,40,211,56,101,217,187,140,149,154,187,176,77,10,70,58,164,144,188,53,219,38,241,227,138,22,84,207,172,117,97,32,144,194,12,234,48,229,55,106,23,41,137,84,134,84,30,91,16,223,178,20,114,126,110,27,82,240,110,157,228,97,109,49,39,14,61,119,117,31,76,179,88,203,12,170,178,188,40,149,206,192,187,108,227,180,44,42,218,101,242,15,66,19,78,15,102,96,150,10,6,154,151,135,176,96,122,228,46,181,235,15,52,170,74,58,143,66,40,67,207,96,116,226,143,200,132,60,209,254,121,75,245,116,156,211,37,239,33,33,169,29,166,72,49,62,179,31,222,207,125,246,213,91,71,59,218,237,130,121,116,223,107,187,87,187,94,209,91,167,223,81,146,93,62,210,233,32,219,14,64,195,74,39,57,196,225,13,118,87,135,248,170,227,28,149,194,33,182,177,244,199,115,200,111,104,33,172,99,42,139,241,109,168,164,228,59,251,248,200,29,108,219,138,82,50,86,131,29,222,246,51,24,109,34,166,217,128,89,200,199,224,58,93,151,27,43,216,114,241,231,90,129,237,176,30,72,64,215,254,211,45,150,212,47,95,133,224,207,97,81,143,27,249,100,191,206,199,74,48,190,151,218,207,29,165,254,117,198,171,130,94,93,52,67,254,168,142,133,10,199,12,219,149,111,104,8,226,35,113,243,243,220,84,147,54,48,249,206,111,72,54,216,68,48,110,230,7,248,199,32,166,42,72,64,107,192,136,182,10,46,250,135,48,169,232,153,52,152,137,175,107,79,85,73,232,248,165,254,88,193,76,32,61,58,78,137,16,33,92,174,40,198,164,95,47,232,162,19,20,78,39,127,217,248,196,150,89,94,208,59,200,37,194,4,119,55,7,12,48,29,242,133,177,217,47,179,204,254,116,34,165,50,159,223,145,102,49,216,38,80,198,1,181,44,24,166,166,223,136,166,39,250,233,129,143,80,110,224,146,46,54,71,4,61,105,98,2,91,71,84,96,181,139,16,146,184,86,44,148,50,48,37,118,84,48,236,70,193,237,62,200,112,86,186,177,46,97,162,220,225,167,92,30,7,33,21,97,59,234,53,227,7,231,229,29,33,214,174,192,41,182,238,160,74,130,53,243,134,241,53,245,4,112,247,42,47,123,24,244,33,14,142,144,180,232,107,129,13,239,72,140,29,44,28,145,25,191,161,224,205,232,3,173,183,7,39,9,88,165,238,244,160,235,21,207,216,174,110,249,27,225,212,248,231,119,54,138,143,9,153,214,172,90,95,55,168,227,131,130,222,168,47,212,4,189,248,118,195,221,218,195,87,76,112,3,235,59,195,93,169,19,208,137,209,119,215,173,246,157,169,9,18,214,145,68,178,91,91,158,210,243,69,200,105,251,51,82,224,162,212,70,173,176,237,236,61,246,169,254,126,99,119,254,64,60,97,182,33,37,154,231,231,213,180,96,75,69,93,84,247,186,213,217,148,221,210,71,210,182,208,16,234,185,165,95,209,78,29,248,41,197,96,216,252,254,81,203,91,250,225,134,146,217,58,151,139,153,75,68,231,206,22,170,137,222,104,53,24,19,209,243,84,73,114,91,136,244,214,72,116,236,30,55,175,253,76,77,94,224,70,151,228,226,82,99,193,71,116,101,156,250,86,155,28,231,129,56,56,136,248,101,126,207,18,42,132,6,62,120,60,120,222,45,88,73,177,255,180,191,231,105,77,76,174,233,185,177,40,233,59,247,8,127,238,239,61,118,156,178,98,161,251,251,208,182,80,120,107,60,117,18,245,225,228,85,72,52,237,99,91,88,52,141,196,46,4,59,146,149,28,101,29,28,220,111,108,196,66,1,107,90,211,236,34,201,163,95,28,12,245,71,66,179,18,171,27,146,193,109,209,65,2,40,252,145,50,109,191,6,188,76,114,78,37,85,53,230,174,70,174,46,234,74,228,216,162,4,109,170,176,11,145,33,53,200,251,21,108,9,226,23,61,37,72,237,158,240,203,84,225,172,65,228,62,180,26,19,187,171,16,107,179,15,139,12,91,82,110,22,227,23,82,168,86,138,255,205,148,97,160,104,14,206,40,68,54,250,241,211,9,155,204,225,185,68,154,91,153,196,2,188,97,175,25,104,40,33,171,133,88,12,215,133,45,51,144,136,218,235,224,111,94,179,71,172,100,193,86,28,201,195,159,175,142,181,205,235,33,135,218,81,170,70,240,160,147,152,93,214,212,107,150,122,237,123,149,161,232,36,197,185,153,38,114,52,7,2,120,160,194,48,43,105,74,206,39,34,50,191,182,160,197,171,224,159,20,98,66,240,54,71,53,216,105,18,78,215,132,119,126,7,171,3,123,167,220,212,0,3,106,218,65,69,237,222,85,237,182,222,91,230,183,36,120,80,49,171,165,100,60,125,186,242,245,147,68,95,185,166,227,67,176,221,117,1,244,67,195,176,142,194,77,16,151,251,207,232,67,244,7,234,33,49,185,191,78,119,6,219,61,98,237,254,71,241,30,205,227,30,91,160,221,176,44,110,213,197,190,117,154,141,108,245,120,67,66,165,139,132,194,189,239,161,159,90,149,97,146,24,193,78,132,90,172,190,63,70,99,247,49,131,33,182,117,149,40,8,84,10,224,153,140,140,103,184,114,213,138,119,235,184,219,102,25,150,20,185,63,255,12,107,175,244,228,67,173,93,60,72,203,73,8,235,134,253,84,127,103,150,169,230,255,21,237,254,204,247,2,196,37,206,26,54,122,248,40,138,118,209,121,12,117,219,171,70,53,107,189,67,32,217,166,113,18,102,49,137,115,152,149,117,224,228,176,105,22,144,77,42,216,44,47,201,34,175,96,50,203,180,23,1,205,103,68,9,64,216,95,36,143,106,30,119,122,225,51,218,150,137,65,9,99,114,37,215,175,87,221,111,144,151,230,198,27,98,134,134,179,63,192,0,235,246,159,100,84,219,163,82,215,57,241,190,243,200,215,234,165,76,6,118,126,146,150,93,195,110,203,75,44,235,156,24,141,177,158,59,35,65,95,195,76,172,175,206,74,234,92,253,18,118,141,202,167,95,235,103,191,3,148,103,49,147,7,154,12,72,61,232,219,143,242,216,110,22,227,233,222,58,211,122,65,23,101,115,163,196,70,131,105,86,243,174,249,220,90,183,245,224,143,205,70,240,134,45,87,6,62,217,65,113,84,20,74,49,35,19,9,44,16,193,33,7,207,102,80,112,248,54,234,49,233,100,190,222,83,175,139,225,26,10,31,107,65,221,105,79,188,78,249,50,164,35,105,30,48,168,203,152,154,176,172,62,102,178,196,99,153,220,26,94,167,234,49,78,108,183,95,89,226,29,212,206,84,229,138,171,184,217,125,234,100,123,183,177,31,141,123,15,212,253,71,117,12,253,138,242,168,87,28,54,144,33,146,207,119,124,225,175,113,114,97,91,240,19,183,147,236,12,39,102,124,157,132,27,242,128,196,31,241,142,17,146,96,159,232,146,145,197,128,46,245,129,240,44,30,24,110,90,82,176,131,143,154,6,210,248,165,25,16,186,194,59,0,105,88,18,198,137,39,110,30,157,9,108,19,47,168,133,45,209,179,58,207,146,55,148,34,125,68,31,232,177,88,151,63,26,119,94,127,124,18,151,12,68,187,77,226,193,44,162,211,111,51,89,235,203,215,204,56,121,37,215,42,86,112,224,109,35,119,46,103,150,226,34,216,25,177,113,199,253,36,23,144,227,22,205,246,11,67,216,53,217,117,187,202,217,59,149,183,163,250,120,211,215,86,12,24,215,213,41,201,27,40,140,134,209,138,248,242,214,137,147,79,76,134,156,252,215,126,194,148,164,11,18,125,6,58,214,184,219,231,232,91,133,118,35,93,25,239,67,67,59,167,157,114,208,116,194,108,153,80,117,138,14,179,170,51,204,170,164,49,127,77,188,137,167,160,89,86,234,61,255,130,165,226,20,199,75,26,179,42,197,91,173,232,149,5,121,145,157,224,200,156,253,70,201,55,228,169,77,75,109,98,181,38,147,199,224,5,205,150,229,138,76,44,34,58,200,125,107,74,35,152,87,247,234,146,201,147,177,205,211,55,214,106,20,78,141,228,153,137,68,241,229,104,248,163,235,111,216,148,233,160,117,90,82,203,207,116,237,92,29,238,17,231,69,200,183,74,126,207,116,10,10,246,12,42,243,13,188,99,226,17,111,108,177,59,114,156,82,25,22,55,110,88,2,124,247,20,69,232,102,189,155,42,73,196,176,71,160,48,72,98,34,227,169,99,202,3,45,32,67,216,163,114,214,100,122,60,252,176,208,210,16,54,209,204,20,158,27,100,249,210,224,141,176,116,157,80,60,12,219,189,36,227,232,221,163,124,80,232,2,143,47,188,181,14,46,138,251,49,113,211,34,53,99,122,231,99,250,80,15,226,13,132,12,68,219,58,15,96,42,82,17,8,154,125,44,167,26,77,18,124,37,210,107,245,60,95,166,245,5,2,192,102,57,128,64,141,232,79,249,236,129,182,110,47,6,245,152,130,121,201,226,56,161,45,160,102,80,242,186,187,50,31,96,100,172,224,50,124,98,27,28,27,3,245,131,36,103,90,32,151,38,104,91,195,227,91,98,127,29,247,167,179,80,80,187,64,195,63,177,133,26,86,23,53,63,221,166,10,111,124,211,162,237,59,162,65,199,92,1,94,15,218,144,14,195,69,216,122,216,134,118,153,48,130,55,227,123,231,214,210,13,54,107,220,98,99,237,132,180,61,117,91,39,164,71,105,102,18,164,198,182,39,122,90,127,249,253,191,169,52,10,57,107,22,203,60,247,188,253,239,61,216,230,62,223,112,125,14,30,181,41,51,203,118,166,229,185,141,217,56,19,213,37,43,173,139,252,254,187,14,117,246,73,169,246,4,40,191,229,97,25,40,185,218,135,168,16,145,105,151,58,133,213,8,236,6,205,54,204,78,134,145,215,38,231,221,69,92,52,21,86,249,123,180,45,76,77,231,175,123,111,184,119,202,88,215,133,247,121,131,75,11,212,70,31,220,21,12,205,206,72,214,64,150,211,228,125,136,170,83,221,13,252,240,221,78,196,229,250,172,123,236,45,204,246,149,115,173,85,227,206,186,66,198,241,104,92,8,213,242,64,100,115,13,111,35,179,225,205,235,225,174,247,135,222,88,135,154,114,108,90,135,214,122,231,95,115,48,233,181,223,117,86,55,244,50,186,60,33,216,143,89,166,131,228,140,60,221,101,104,109,69,58,164,222,194,253,211,147,159,119,101,254,109,155,48,153,222,186,77,5,240,64,150,107,115,57,142,93,135,213,25,236,254,173,181,187,126,204,161,144,198,127,213,7,86,80,255,158,114,78,211,251,100,51,203,88,201,160,94,255,141,198,67,246,183,17,36,219,189,168,134,76,135,136,106,126,73,187,213,173,252,150,4,177,3,230,246,252,14,215,212,19,162,59,44,11,113,56,213,87,139,112,100,214,167,42,58,205,77,53,233,223,174,139,254,237,67,110,6,195,238,107,251,114,212,30,20,99,95,126,1,255,253,23,118,4,18,72,128,73,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed9513e0-8962-4ef7-9da0-fa9db5e93539"));
		}

		#endregion

	}

	#endregion

}
