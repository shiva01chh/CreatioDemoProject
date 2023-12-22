﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TempAccessProxySchema

	/// <exclude/>
	public class TempAccessProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TempAccessProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TempAccessProxySchema(TempAccessProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab9902f3-3f23-45b2-8eeb-977ed3edfb77");
			Name = "TempAccessProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("386ac9f6-07c1-4d11-8d16-e4e9424ba4e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,221,111,227,54,18,127,118,129,254,15,132,246,208,202,56,159,92,244,113,19,251,224,230,171,70,119,55,139,56,193,62,44,130,64,145,199,9,111,101,201,37,233,100,125,65,254,247,27,126,73,164,44,201,114,154,182,56,96,247,161,141,201,153,225,112,62,127,36,149,197,75,224,171,56,1,114,9,140,197,60,95,136,232,40,207,22,244,110,205,98,65,243,44,58,249,42,128,101,113,58,73,18,224,252,99,156,124,137,239,224,251,239,158,190,255,174,183,230,52,187,35,179,13,23,176,60,168,252,70,41,105,10,137,20,193,163,51,200,128,209,100,139,230,29,205,126,47,7,47,128,139,217,125,204,86,229,144,171,212,114,153,103,245,51,12,154,198,163,211,56,17,57,163,192,235,40,206,39,107,113,63,205,4,220,233,189,118,161,137,142,47,207,145,14,41,223,48,184,195,1,34,39,217,2,77,248,150,76,47,97,185,50,134,98,249,215,141,162,27,14,135,228,144,175,151,203,152,109,198,230,183,154,37,139,156,145,146,131,112,96,15,20,61,49,89,209,200,242,13,29,198,213,250,54,165,9,161,118,189,154,229,122,79,106,201,66,183,247,32,238,243,57,127,75,62,42,94,61,89,85,72,13,156,177,56,19,156,136,123,32,177,146,24,21,164,195,42,237,225,42,102,241,146,100,24,59,163,128,1,207,215,44,129,15,248,43,24,203,255,146,124,161,228,216,153,232,112,168,24,154,248,209,208,89,48,190,84,28,242,239,118,122,248,186,162,218,21,199,177,0,205,87,142,145,57,14,182,11,184,147,59,205,25,134,224,100,190,164,217,85,70,197,116,174,229,152,41,194,85,120,146,88,206,147,53,18,16,58,111,23,74,57,106,19,79,121,158,42,53,78,178,248,54,5,35,245,33,78,215,128,110,155,211,4,39,49,186,30,239,209,45,192,164,174,49,161,150,135,44,243,57,146,113,2,154,121,199,122,58,133,206,87,160,55,206,101,246,96,142,137,157,171,154,205,229,5,39,137,153,114,150,97,223,109,60,128,163,148,66,134,102,227,142,221,0,72,162,134,209,88,220,179,214,67,78,231,58,192,116,176,134,114,41,212,200,13,157,1,41,6,101,12,12,136,244,238,37,93,186,206,149,67,3,114,182,70,105,181,78,28,200,197,122,183,121,158,146,122,127,12,136,153,108,54,158,213,227,243,53,169,238,181,127,208,146,63,39,217,122,41,165,89,99,204,77,26,145,148,114,209,53,151,146,53,23,57,138,41,12,107,7,164,73,73,104,234,132,217,59,239,183,135,100,98,244,14,198,62,223,143,188,244,83,68,166,11,172,59,98,96,180,5,110,147,247,142,62,64,102,9,31,105,154,146,91,172,12,243,57,110,76,228,118,61,147,229,235,84,72,33,158,58,239,112,219,135,103,96,60,46,127,29,139,124,76,188,145,176,48,181,179,241,34,16,172,254,100,68,178,117,154,182,90,255,2,126,95,163,11,173,205,69,254,5,178,174,70,215,60,142,157,42,185,110,212,41,52,191,148,194,109,8,91,102,171,221,27,200,230,186,246,170,223,207,186,83,248,131,237,141,227,24,176,101,209,135,24,61,181,95,251,152,91,70,41,251,37,61,196,91,121,255,78,82,176,131,110,35,124,5,9,93,208,50,19,116,89,232,228,11,19,254,30,99,37,212,25,136,53,203,248,120,178,88,64,226,228,91,146,175,51,25,138,118,94,50,224,118,73,169,94,25,118,197,114,127,212,125,211,57,134,42,21,155,153,110,225,186,100,156,98,241,133,46,78,180,220,5,2,48,105,183,80,2,246,240,101,171,26,251,123,116,6,49,75,238,193,214,11,78,110,55,126,69,66,221,203,82,178,171,182,105,25,167,52,69,117,131,177,254,63,42,191,200,73,232,165,191,205,251,1,1,145,68,125,76,102,180,139,84,196,170,225,197,194,84,21,154,217,125,206,132,221,189,41,216,40,121,76,244,22,66,105,3,127,218,40,66,60,181,94,18,6,51,193,214,137,120,75,170,181,174,209,239,216,107,86,216,114,128,32,145,114,191,199,73,150,202,45,109,14,231,106,197,173,5,73,197,191,24,95,216,223,4,98,223,46,240,15,132,114,39,7,15,4,162,95,165,209,48,139,89,91,57,85,88,163,248,121,185,131,189,164,46,55,36,107,233,196,100,35,121,34,119,32,14,164,46,7,228,121,31,165,175,46,222,237,167,166,207,208,164,216,21,75,95,174,211,28,120,194,232,74,157,29,246,210,173,158,177,73,199,227,146,250,229,186,86,113,244,94,250,54,51,111,233,92,96,187,19,15,219,189,92,113,167,42,217,128,35,225,209,244,184,191,223,22,186,136,105,114,192,81,81,195,94,182,141,248,165,231,132,253,182,104,196,227,170,123,75,223,218,185,2,211,211,90,164,253,234,54,216,117,106,249,163,86,216,67,126,147,29,154,15,21,117,214,216,167,199,28,165,49,199,42,222,245,118,225,24,22,177,196,228,171,151,220,50,104,129,0,113,202,115,146,48,88,140,130,189,174,134,162,234,173,68,64,134,82,238,103,163,213,47,210,246,217,93,40,54,43,200,23,97,149,186,223,191,238,68,236,128,213,118,150,22,76,164,25,141,19,19,105,227,170,137,201,246,157,206,160,1,50,15,246,132,95,104,74,46,228,157,139,223,157,173,54,114,214,150,150,11,228,192,208,98,122,205,89,130,65,202,241,84,20,48,51,126,147,63,102,55,246,48,77,92,45,144,103,69,131,131,38,193,18,57,84,133,98,160,22,178,110,228,225,117,31,129,37,244,242,5,106,148,117,163,208,222,30,226,164,237,12,92,43,229,73,84,124,99,17,105,23,97,18,253,107,19,234,184,149,157,39,95,139,247,82,218,207,63,225,191,198,245,125,195,107,192,44,85,56,127,204,96,126,97,140,196,135,214,15,93,12,221,40,68,154,186,89,192,5,44,243,7,152,152,67,122,163,144,57,164,32,160,147,65,75,25,102,96,40,13,27,212,35,224,34,106,79,41,164,234,204,192,212,81,202,196,172,254,33,175,110,230,121,150,110,236,106,55,92,121,5,225,211,65,43,153,69,252,93,168,102,128,53,73,236,208,82,229,150,4,201,57,235,2,126,167,25,21,52,78,233,127,65,182,160,12,30,49,100,100,110,38,197,85,166,44,136,69,49,244,171,219,112,172,75,71,215,235,134,194,38,250,136,75,221,179,31,246,33,137,72,59,94,235,40,156,189,90,165,170,85,230,153,119,20,219,41,64,219,209,220,50,105,70,174,134,60,102,19,67,149,61,219,203,143,98,43,91,119,54,149,1,189,88,95,158,80,122,189,94,193,22,29,221,67,242,101,194,238,214,75,36,250,176,78,211,115,246,233,158,10,152,201,23,137,80,170,139,21,188,32,239,247,85,128,244,236,34,221,216,45,181,229,46,131,18,99,223,15,208,222,141,115,231,228,5,101,207,139,190,98,182,8,198,94,175,190,171,239,60,140,217,104,159,74,176,160,19,145,200,242,107,254,54,113,254,249,252,22,241,21,102,246,117,119,72,44,133,20,23,9,185,186,69,32,73,156,166,173,129,186,141,148,28,49,109,16,200,213,223,249,83,59,28,59,128,249,171,71,23,36,116,246,71,70,230,114,207,206,247,188,73,149,139,190,184,55,40,225,195,201,229,233,197,228,253,201,167,243,139,223,12,91,239,151,152,131,246,105,233,96,164,134,148,195,54,137,20,123,197,104,88,146,246,37,45,2,135,133,33,126,62,216,214,39,154,204,231,6,100,252,138,197,9,88,24,96,161,17,56,243,175,75,4,27,193,128,4,78,58,14,255,35,159,53,76,208,201,240,144,255,211,151,82,21,15,23,211,188,180,147,111,6,101,110,135,242,185,18,60,21,224,241,137,161,30,88,75,110,104,237,184,219,29,154,88,27,134,235,253,89,191,76,141,111,155,8,201,89,154,223,34,142,92,173,102,32,36,236,231,209,41,196,104,42,184,226,48,3,89,143,48,171,205,212,105,206,212,163,220,207,63,89,199,254,91,3,100,253,214,183,137,48,21,14,27,246,53,14,3,31,180,6,125,43,228,237,30,66,26,188,218,98,110,207,111,77,69,226,219,107,221,183,215,186,191,255,181,206,84,134,191,246,209,238,79,124,181,51,229,199,213,187,27,114,112,57,44,122,120,136,25,98,46,106,17,183,233,37,147,114,68,158,125,108,193,83,233,53,242,45,166,103,142,41,95,165,241,166,32,80,214,211,83,37,82,48,194,143,169,250,138,2,83,250,80,111,210,110,118,92,20,214,39,18,248,55,105,216,139,124,15,68,151,57,154,27,123,29,143,83,233,160,176,143,35,51,37,38,12,242,160,79,158,7,165,172,182,171,12,148,220,230,136,82,106,85,100,109,198,13,26,92,222,36,166,82,6,6,245,33,213,196,109,187,116,9,103,3,242,236,86,114,211,245,235,203,190,108,255,214,203,161,19,3,131,218,135,226,162,216,127,123,45,182,235,181,188,22,155,154,243,250,143,198,38,69,36,76,113,200,163,41,215,73,127,178,92,137,13,70,201,15,63,20,156,213,185,2,190,136,123,150,63,234,116,247,10,135,162,59,249,154,128,186,124,15,255,17,60,217,147,71,185,96,255,89,98,243,167,234,145,228,217,226,195,231,162,184,216,98,161,31,131,70,13,64,76,194,147,11,151,50,116,131,122,64,106,31,212,220,18,86,190,55,141,252,37,163,25,200,207,182,222,199,217,198,234,41,43,218,104,76,202,95,81,177,180,161,14,169,236,81,163,177,54,148,52,81,221,227,148,74,195,226,145,103,68,36,83,228,20,197,158,6,231,206,58,58,163,16,169,91,10,247,149,195,8,112,74,169,165,170,188,42,24,66,127,212,210,58,215,246,254,210,197,184,165,108,184,232,30,89,0,169,22,193,26,65,85,181,78,203,58,46,35,42,23,213,128,219,205,38,15,23,49,205,248,111,176,9,155,10,168,43,73,118,201,232,99,204,56,132,141,66,63,55,9,186,238,151,251,108,185,200,254,203,118,219,210,129,94,178,231,22,113,215,230,8,240,220,151,61,81,37,147,201,20,131,235,203,100,217,89,215,95,231,59,20,239,1,181,249,203,7,255,27,7,255,53,106,199,215,42,5,38,82,27,108,174,49,174,12,247,83,151,122,43,236,252,2,68,117,183,191,231,19,144,242,99,137,29,95,130,116,50,141,190,142,45,209,128,251,29,73,189,109,254,31,190,165,176,119,2,175,250,73,133,219,129,221,9,167,194,182,244,227,130,248,245,187,115,147,50,186,87,7,228,159,166,198,52,178,180,116,241,69,121,207,46,155,159,6,242,117,159,18,71,205,102,52,27,59,42,17,77,253,250,166,110,59,59,216,38,45,231,92,156,219,30,227,206,91,65,232,239,167,111,219,190,7,16,202,230,223,16,58,5,6,216,218,146,211,236,203,126,171,127,155,35,210,22,157,219,239,125,84,224,144,58,19,221,251,189,237,6,126,51,232,254,106,139,99,206,191,255,1,250,116,232,224,97,47,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab9902f3-3f23-45b2-8eeb-977ed3edfb77"));
		}

		#endregion

	}

	#endregion

}

