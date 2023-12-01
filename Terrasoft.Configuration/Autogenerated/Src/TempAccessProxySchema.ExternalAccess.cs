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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,221,111,219,56,18,127,118,129,253,31,8,245,176,39,227,124,242,98,31,155,216,7,111,190,214,216,182,41,226,4,125,40,130,64,145,199,9,175,178,228,37,233,164,190,32,255,251,13,191,36,82,150,100,57,155,219,197,1,221,135,109,76,206,12,135,243,249,35,169,44,94,2,95,197,9,144,75,96,44,230,249,66,68,71,121,182,160,119,107,22,11,154,103,209,201,55,1,44,139,211,73,146,0,231,159,226,228,107,124,7,63,188,121,250,225,77,111,205,105,118,71,102,27,46,96,121,80,249,141,82,210,20,18,41,130,71,103,144,1,163,201,22,205,123,154,253,94,14,94,0,23,179,251,152,173,202,33,87,169,229,50,207,234,103,24,52,141,71,167,113,34,114,70,129,215,81,156,79,214,226,126,154,9,184,211,123,237,66,19,29,95,158,35,29,82,190,101,112,135,3,68,78,178,5,154,240,29,153,94,194,114,101,12,197,242,111,27,69,55,28,14,201,33,95,47,151,49,219,140,205,111,53,75,22,57,35,37,7,225,192,30,40,122,98,178,162,145,229,27,58,140,171,245,109,74,19,66,237,122,53,203,245,158,212,146,133,110,31,64,220,231,115,254,142,124,82,188,122,178,170,144,26,56,99,113,38,56,17,247,64,98,37,49,42,72,135,85,218,195,85,204,226,37,201,48,118,70,1,3,158,175,89,2,31,241,87,48,150,255,39,249,66,201,177,51,209,225,80,49,52,241,163,161,179,96,124,169,56,228,223,237,244,240,109,69,181,43,142,99,1,154,175,28,35,115,28,108,23,112,39,119,154,51,12,193,201,124,73,179,171,140,138,233,92,203,49,83,132,171,240,36,177,156,39,107,36,32,116,222,46,148,114,212,38,158,242,60,85,106,156,100,241,109,10,70,234,67,156,174,1,221,54,167,9,78,98,116,61,222,163,91,128,73,93,99,66,45,15,89,230,115,36,227,4,52,243,142,245,116,10,157,175,64,111,156,203,236,193,28,19,59,87,53,155,203,11,78,18,51,229,44,195,190,219,120,0,71,41,133,12,205,198,29,187,1,144,68,13,163,177,184,103,173,135,156,206,117,128,233,96,13,229,82,168,145,27,58,3,82,12,202,24,24,16,233,221,75,186,116,157,43,135,6,228,108,141,210,106,157,56,144,139,245,110,243,60,37,245,254,24,16,51,217,108,60,171,199,151,107,82,221,107,255,160,37,127,78,178,245,82,74,179,198,152,155,52,34,41,229,162,107,46,37,107,46,114,20,83,24,214,14,72,147,146,208,212,9,179,119,222,111,15,201,196,232,29,140,125,190,191,243,210,79,17,153,46,176,238,136,129,209,22,184,77,222,59,250,0,153,37,124,164,105,74,110,177,50,204,231,184,49,145,219,245,76,150,175,83,33,133,120,234,188,199,109,31,158,129,241,184,252,117,44,242,49,241,70,194,194,212,206,198,139,64,176,250,147,17,201,214,105,218,106,253,11,248,125,141,46,180,54,23,249,87,200,186,26,93,243,56,118,170,228,186,81,167,208,252,82,10,183,33,108,153,173,118,111,33,155,235,218,171,126,63,235,78,225,15,182,55,142,99,192,150,69,31,98,244,212,126,237,99,110,25,165,236,151,244,16,111,229,253,59,73,193,14,186,141,240,21,36,116,65,203,76,208,101,161,147,47,76,248,123,140,149,80,103,32,214,44,227,227,201,98,1,137,147,111,73,190,206,100,40,218,121,201,128,219,37,165,122,101,216,21,203,253,81,247,77,231,24,170,84,108,102,186,133,235,146,113,138,197,23,186,56,209,114,23,8,192,164,221,66,9,216,195,151,173,106,236,239,209,25,196,44,185,7,91,47,56,185,221,248,21,9,117,47,75,201,174,218,166,101,156,210,20,213,13,198,250,95,84,126,145,147,208,75,127,155,247,3,2,34,137,250,152,204,104,23,169,136,85,195,139,133,169,42,52,179,251,156,9,187,123,83,176,81,242,152,232,45,132,210,6,254,180,81,132,120,106,189,36,12,102,130,173,19,241,142,84,107,93,163,223,177,215,172,176,229,0,65,34,229,126,143,147,44,149,91,218,28,206,213,138,91,11,146,138,127,49,190,176,191,9,196,190,93,224,31,8,229,78,14,30,8,68,191,74,163,97,22,179,182,114,170,176,70,241,243,114,7,123,73,93,110,72,214,210,137,201,70,242,68,238,64,28,72,93,14,200,243,62,74,95,93,188,223,79,77,159,161,73,177,43,150,190,92,167,57,240,132,209,149,58,59,236,165,91,61,99,147,142,199,37,245,203,117,173,226,232,189,244,109,102,222,210,185,192,118,39,30,182,123,185,226,78,85,178,1,71,194,163,233,113,127,191,45,116,17,211,228,128,163,162,134,189,108,27,241,75,207,9,251,109,209,136,199,85,247,150,190,181,115,5,166,167,181,72,251,213,109,176,235,212,242,71,173,176,135,252,38,59,52,31,42,234,172,177,79,143,57,74,99,142,85,188,235,237,194,49,44,98,137,201,87,47,185,101,208,2,1,226,148,231,36,97,176,24,5,123,93,13,69,213,91,137,128,12,165,220,47,70,171,95,164,237,179,187,80,108,86,144,47,194,42,117,191,127,221,137,216,1,171,237,44,45,152,72,51,26,39,38,210,198,85,19,147,237,59,157,65,3,100,30,236,9,191,208,148,92,200,59,23,191,59,91,109,228,172,45,45,23,200,129,161,197,244,154,179,4,131,148,227,169,40,96,102,252,38,127,204,110,236,97,154,184,90,32,207,138,6,7,77,130,37,114,168,10,197,64,45,100,221,200,195,235,62,2,75,232,229,11,212,40,235,70,161,189,61,196,73,219,25,184,86,202,147,168,248,198,34,210,46,194,36,250,215,38,212,113,43,59,79,190,22,31,164,180,159,127,194,255,26,215,247,13,175,1,179,84,225,252,49,131,249,133,49,18,31,90,63,116,49,116,163,16,105,234,102,1,23,176,204,31,96,98,14,233,141,66,230,144,130,128,78,6,45,101,152,129,161,52,108,80,143,128,139,168,61,165,144,170,51,3,83,71,41,19,179,250,135,188,186,153,231,89,186,177,171,221,112,229,21,132,79,7,173,100,22,241,119,161,154,1,214,36,177,67,75,149,91,18,36,231,172,11,248,157,102,84,208,56,165,255,1,217,130,50,120,196,144,145,185,153,20,87,153,178,32,22,197,208,175,110,195,177,46,29,93,175,27,10,155,232,35,46,117,207,126,216,135,36,34,237,120,173,163,112,246,106,149,170,86,153,103,222,81,108,167,0,109,71,115,203,164,25,185,26,242,152,77,12,85,246,108,47,63,138,173,108,221,217,84,6,244,98,125,121,66,233,245,122,5,91,116,116,15,201,215,9,187,91,47,145,232,227,58,77,207,217,231,123,42,96,38,95,36,66,169,46,86,240,130,188,223,87,1,210,179,139,116,99,183,212,150,187,12,74,140,125,63,64,123,55,206,157,147,23,148,61,47,250,138,217,34,24,123,189,250,174,190,243,48,102,163,125,42,193,130,78,68,34,203,175,249,219,196,249,151,243,91,196,87,152,217,215,221,33,177,20,82,92,36,228,234,22,129,36,113,154,182,6,234,54,82,114,196,180,65,32,87,127,231,79,237,112,236,0,230,175,30,93,144,208,217,31,25,153,203,61,59,223,243,38,85,46,250,226,222,162,132,143,39,151,167,23,147,15,39,159,207,47,126,51,108,189,95,98,14,218,167,165,131,145,26,82,14,219,36,82,236,21,163,97,73,218,151,180,8,28,22,134,248,249,96,91,159,104,50,159,27,144,241,43,22,39,96,97,128,133,70,224,204,63,47,17,108,4,3,18,56,233,56,252,183,124,214,48,65,39,195,67,254,163,47,165,42,30,46,166,121,105,39,223,12,202,220,14,229,115,37,120,42,192,227,51,67,61,176,150,220,208,218,113,183,59,52,177,54,12,215,251,179,126,153,26,223,54,17,146,179,52,191,69,28,185,90,205,64,72,216,207,163,83,136,209,84,112,197,97,6,178,30,97,86,155,169,211,156,169,71,185,159,127,178,142,253,151,6,200,250,173,111,19,97,42,28,54,236,107,28,6,62,104,13,250,86,200,187,61,132,52,120,181,197,220,158,223,154,138,196,247,215,186,239,175,117,127,253,107,157,169,12,127,238,163,221,255,240,213,206,148,31,87,239,110,200,193,229,176,232,225,33,102,136,185,168,69,220,166,151,76,202,17,121,246,177,5,79,165,215,200,183,152,158,57,166,124,149,198,155,130,64,89,79,79,149,72,193,8,63,166,234,43,10,76,233,67,189,73,187,217,113,81,88,159,72,224,223,164,97,47,242,61,16,93,230,104,110,236,117,60,78,165,131,194,62,142,204,148,152,48,200,131,62,121,30,148,178,218,174,50,80,114,155,35,74,169,85,145,181,25,55,104,112,121,147,152,74,25,24,212,135,84,19,183,237,210,37,156,13,200,179,91,201,77,215,175,47,251,178,253,91,47,135,78,12,12,106,31,138,139,98,255,253,181,216,174,215,242,90,108,106,206,235,63,26,155,20,145,48,197,33,143,166,92,39,253,201,114,37,54,24,37,63,254,88,112,86,231,10,248,34,238,89,254,168,211,221,43,28,138,238,228,91,2,234,242,61,252,91,240,100,79,30,229,130,253,103,137,205,159,170,71,146,103,139,15,159,139,226,98,139,133,126,12,26,53,0,49,9,79,46,92,202,208,13,234,1,169,125,80,115,75,88,249,222,52,242,151,140,102,32,63,219,250,16,103,27,171,167,172,104,163,49,41,127,69,197,210,134,58,164,178,71,141,198,218,80,210,68,117,143,83,42,13,139,71,158,17,145,76,145,83,20,123,26,156,59,235,232,140,66,164,110,41,220,87,14,35,192,41,165,150,170,242,170,96,8,253,81,75,235,92,219,251,75,23,227,150,178,225,162,123,100,1,164,90,4,107,4,85,213,58,45,235,184,140,168,92,84,3,110,55,155,60,92,196,52,227,191,193,38,108,42,160,174,36,217,37,163,79,49,227,16,54,10,253,210,36,232,186,95,238,179,229,34,251,79,219,109,75,7,122,201,158,91,196,93,155,35,192,115,95,246,68,149,76,38,83,12,174,47,147,101,103,93,127,157,239,80,188,7,212,230,47,31,252,111,28,252,215,168,29,95,171,20,152,72,109,176,185,198,184,50,220,79,93,234,173,176,243,11,16,213,221,254,154,79,64,202,143,37,118,124,9,210,201,52,250,58,182,68,3,238,119,36,245,182,249,127,248,150,194,222,9,188,234,39,21,110,7,118,39,156,10,219,210,143,11,226,215,239,206,77,202,232,94,29,144,127,152,26,211,200,210,210,197,23,229,61,187,108,126,26,200,215,125,74,28,53,155,209,108,236,168,68,52,245,235,155,186,237,236,96,155,180,156,115,113,110,123,140,59,111,5,161,191,159,190,109,251,30,64,40,155,127,67,232,20,24,96,107,75,78,179,47,251,173,254,109,142,72,91,116,110,191,247,81,129,67,234,76,116,239,247,182,27,248,205,160,251,171,45,142,189,121,243,95,12,150,226,221,88,47,0,0 };
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
