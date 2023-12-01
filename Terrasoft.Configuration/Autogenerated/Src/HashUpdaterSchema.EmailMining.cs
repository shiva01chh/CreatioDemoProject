﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HashUpdaterSchema

	/// <exclude/>
	public class HashUpdaterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HashUpdaterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HashUpdaterSchema(HashUpdaterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c86e600-6c0c-41af-8383-74740626294f");
			Name = "HashUpdater";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,73,115,219,54,20,62,43,51,249,15,168,123,161,166,26,38,109,111,94,148,113,98,39,85,234,173,141,147,30,58,157,12,45,62,89,108,73,208,1,64,59,138,199,255,189,239,1,32,9,128,164,172,172,109,14,49,9,188,125,249,240,64,241,164,0,121,149,204,129,157,131,16,137,44,23,42,126,86,242,69,118,89,137,68,101,37,143,15,139,36,203,143,51,158,241,203,135,15,110,31,62,24,85,18,31,217,171,149,84,80,236,4,239,200,155,231,48,39,70,25,191,0,14,34,155,119,104,14,18,149,116,22,143,50,254,174,93,188,204,203,139,36,223,222,126,86,22,5,218,112,84,94,94,226,114,187,223,26,123,200,81,197,178,0,174,226,25,87,32,22,232,139,108,9,79,224,70,161,45,68,249,82,150,188,79,130,209,209,191,35,96,104,61,62,120,138,91,184,249,189,128,75,116,151,61,203,19,41,183,217,47,137,92,190,190,74,19,52,69,111,63,122,244,136,237,202,170,40,18,177,154,218,247,243,37,176,57,145,179,69,41,88,69,212,164,160,172,20,241,165,108,137,50,64,178,114,193,138,140,227,59,58,151,169,12,87,84,201,20,242,38,115,85,37,57,43,57,200,184,86,241,200,209,113,85,93,228,217,220,170,240,12,26,221,106,163,66,163,207,225,189,58,36,37,43,202,141,33,185,18,217,53,50,89,41,33,197,136,36,141,70,181,170,23,85,150,178,67,5,179,116,199,93,150,74,144,99,184,65,193,175,243,222,179,77,70,14,108,25,219,211,14,133,81,9,233,128,74,72,215,170,132,52,148,123,103,35,3,60,53,193,241,35,245,60,131,60,197,80,157,153,176,248,49,146,10,51,56,103,2,146,180,228,249,138,157,175,174,224,207,191,216,219,66,183,141,137,27,173,73,182,199,76,220,20,190,149,139,8,91,77,97,54,13,197,120,226,111,21,69,197,179,185,238,194,62,130,83,113,153,240,236,195,224,254,126,138,142,72,217,183,245,178,188,176,203,218,243,157,245,222,204,176,253,216,219,28,255,219,99,248,120,156,240,228,18,4,182,183,162,190,4,17,109,57,24,177,53,14,164,53,98,94,75,16,232,47,55,240,192,222,86,222,251,206,250,240,35,33,166,174,154,171,82,80,18,116,50,173,30,147,88,167,204,163,64,147,175,104,108,51,16,232,71,223,58,6,221,91,20,199,160,150,229,96,85,92,151,84,161,239,97,94,41,136,40,253,140,194,95,235,207,184,178,141,252,6,132,52,22,28,59,245,66,241,37,167,236,110,164,121,77,45,103,11,22,5,172,123,236,113,45,120,36,64,85,194,216,79,14,224,255,71,153,84,187,126,11,79,153,242,222,169,52,127,171,64,172,78,74,181,175,101,55,244,136,60,90,123,124,130,135,197,196,55,218,90,100,56,178,15,208,42,33,219,163,64,199,132,57,94,152,108,29,92,208,78,151,208,211,98,248,180,254,177,155,23,47,210,67,54,108,226,252,132,117,242,131,208,12,201,124,201,34,159,53,224,100,25,15,101,53,121,176,88,3,45,250,97,140,125,226,184,3,141,58,185,14,75,60,147,152,145,147,42,207,79,197,97,113,165,86,209,184,81,48,186,78,132,57,28,86,40,57,114,171,103,76,252,88,204,215,32,84,124,0,88,217,153,142,205,233,197,223,88,222,174,2,47,39,86,189,17,249,221,30,227,168,183,85,55,234,26,239,160,40,154,0,94,229,70,141,80,83,133,245,159,58,46,45,68,247,196,37,196,111,99,88,187,186,54,46,110,233,182,146,51,141,191,107,3,179,235,114,78,93,125,94,128,60,145,247,135,201,59,108,92,95,145,253,158,96,221,245,84,123,111,65,175,233,93,27,111,74,179,233,224,14,244,212,182,111,136,19,28,110,122,141,168,125,160,178,148,64,115,32,149,229,43,253,52,38,38,243,24,5,208,59,182,142,211,240,88,21,60,218,194,234,220,154,176,173,89,186,53,142,247,37,30,47,52,88,108,13,145,213,25,106,137,219,149,1,22,10,120,75,110,222,6,72,113,190,156,47,245,249,70,18,91,147,104,240,232,97,130,180,207,164,182,140,106,150,248,185,40,139,200,72,111,163,104,233,73,117,35,122,134,97,18,47,203,140,71,129,45,53,49,144,77,167,107,45,158,201,195,119,152,237,198,190,214,244,248,143,37,8,104,120,9,5,29,122,227,86,124,150,8,172,27,58,89,235,26,26,55,230,237,243,212,11,171,173,40,45,228,8,199,143,174,12,191,242,2,65,157,248,97,73,71,36,139,58,189,174,47,51,143,71,7,79,205,225,138,51,116,122,209,60,238,133,147,5,94,17,100,37,224,224,105,187,228,96,133,149,53,35,117,191,227,168,2,40,172,125,220,179,117,28,219,99,220,44,71,173,58,7,116,110,150,89,14,44,106,185,99,250,227,194,82,0,12,50,198,17,45,162,190,8,142,152,134,126,164,43,31,173,112,132,34,94,152,144,190,73,242,10,118,105,12,158,54,45,50,113,57,29,116,29,230,55,224,48,13,250,198,147,99,81,107,51,25,166,153,28,126,106,148,141,60,48,29,229,113,126,164,7,221,54,67,236,92,131,171,118,82,10,17,110,112,194,240,38,150,205,198,138,14,212,78,88,0,199,117,121,216,101,188,142,75,28,175,159,151,162,72,8,62,117,83,153,59,34,232,235,34,241,177,219,199,119,49,187,253,241,206,110,164,116,51,188,182,179,224,237,79,119,219,236,246,231,187,173,157,102,206,20,229,141,220,95,44,176,144,129,114,97,252,8,176,231,158,17,204,134,145,174,1,8,73,139,210,24,24,121,230,78,156,51,166,3,109,157,145,206,53,202,74,31,182,243,76,148,120,175,151,144,246,77,139,159,102,155,39,242,51,205,107,224,246,203,152,214,98,252,6,102,5,149,74,249,238,181,108,147,130,117,47,39,2,230,165,72,93,135,31,27,103,102,135,188,42,64,36,23,57,236,254,10,43,221,133,103,73,38,116,39,215,245,61,157,50,168,85,203,206,124,39,237,233,99,7,130,84,247,248,84,15,22,195,18,53,89,172,113,98,194,234,103,103,178,170,207,146,248,0,61,205,56,202,253,10,231,69,115,45,24,182,179,117,156,110,7,109,20,218,131,192,246,250,210,78,205,53,69,172,5,178,39,79,172,164,88,15,182,53,126,233,9,175,70,2,51,132,25,231,195,121,170,91,69,13,26,98,192,85,100,198,159,9,235,156,204,75,39,136,53,237,113,153,102,139,12,210,83,222,199,129,210,225,60,43,32,126,173,230,39,229,141,195,108,231,10,111,252,232,176,183,158,99,52,199,13,82,135,149,247,195,158,117,187,62,134,221,3,120,103,16,214,3,49,27,52,139,143,50,95,172,97,104,30,166,216,234,244,126,122,51,152,162,8,219,193,28,185,117,67,120,55,178,177,63,228,93,161,16,18,76,127,41,224,116,115,209,207,90,197,127,215,60,129,95,109,168,168,125,218,184,181,237,243,209,157,224,67,125,83,164,182,196,253,239,5,67,141,161,141,176,161,10,37,124,102,147,4,6,172,105,152,214,144,255,71,195,56,227,195,39,206,67,27,53,208,87,169,193,96,232,134,141,190,233,132,208,61,248,49,228,75,129,184,123,57,12,170,206,189,110,245,148,93,255,61,235,227,206,128,111,114,8,120,49,156,165,223,178,172,239,255,176,235,124,105,14,127,202,209,11,38,123,210,249,205,38,201,115,246,15,47,111,56,51,159,255,155,159,111,226,70,136,251,99,77,253,1,219,251,90,220,253,8,73,83,127,248,115,2,21,106,247,55,134,166,86,107,97,33,197,216,249,52,220,31,7,179,234,47,234,53,252,247,47,150,235,56,154,50,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c86e600-6c0c-41af-8383-74740626294f"));
		}

		#endregion

	}

	#endregion

}

