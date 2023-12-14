﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationProviderSchema

	/// <exclude/>
	public class TranslationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationProviderSchema(TranslationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36c3c063-8e5c-4c70-8dd5-c7fd6b9b2f6a");
			Name = "TranslationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("78785e02-81e9-4a6c-b0c2-c299c97e7bb9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,90,221,115,219,184,17,127,214,205,220,255,128,168,51,55,212,84,67,231,30,250,18,91,74,157,68,201,121,206,142,83,75,233,117,166,237,100,104,18,146,217,80,164,14,32,109,171,55,254,223,187,192,2,36,0,130,20,21,167,121,136,37,124,252,176,223,216,93,40,143,182,148,239,162,152,146,21,101,44,226,197,186,12,223,22,249,58,221,84,44,42,211,34,15,87,44,202,121,38,63,255,248,195,31,63,254,48,170,120,154,111,200,114,207,75,186,61,117,190,195,222,44,163,177,88,204,195,15,52,167,44,141,91,107,86,244,177,12,111,232,166,202,34,182,120,220,49,202,185,88,223,172,51,73,217,110,139,220,63,195,104,215,184,205,65,231,170,119,111,58,167,22,121,153,150,41,21,52,193,146,63,49,186,1,32,242,54,139,56,127,69,12,137,124,98,197,125,154,80,38,151,237,170,219,44,141,73,44,86,249,22,145,87,228,194,51,60,181,70,23,140,21,236,151,40,79,50,129,58,250,67,34,55,20,128,156,202,40,47,129,138,79,44,189,143,74,138,243,59,252,66,98,49,79,120,201,36,79,13,234,85,145,164,235,148,38,215,57,40,168,218,230,31,65,237,100,70,198,205,248,248,180,141,147,230,37,185,58,255,199,151,197,205,205,245,205,213,98,185,60,255,176,248,114,185,248,248,97,245,11,108,254,203,203,151,167,138,58,154,39,72,96,15,181,69,9,118,65,19,77,175,250,218,73,241,50,190,163,219,72,211,9,150,99,204,105,90,15,97,252,74,247,54,187,48,48,116,175,212,131,189,91,14,93,129,181,70,27,58,30,194,58,171,226,178,96,130,123,105,25,138,117,180,18,143,33,4,159,57,133,35,243,28,29,136,84,214,87,219,76,46,139,205,6,44,170,116,71,38,68,184,232,104,228,64,205,28,48,41,132,81,27,111,214,70,148,75,159,250,185,125,159,210,44,233,178,73,70,163,164,200,179,61,1,151,167,143,228,139,113,194,219,42,43,43,70,47,242,132,62,226,236,140,228,244,1,87,6,127,29,95,70,249,166,2,105,7,175,207,228,154,249,191,146,63,79,198,147,3,178,111,168,233,176,185,119,111,22,143,52,174,64,55,228,75,114,171,63,31,64,5,180,29,101,34,40,116,240,249,46,149,162,141,216,254,12,205,105,74,62,239,18,152,153,91,60,227,216,223,42,8,141,50,190,12,2,88,117,236,87,218,222,208,82,125,26,49,10,18,205,187,79,36,175,95,147,160,123,22,229,223,77,73,48,153,160,237,60,25,102,209,195,192,69,14,118,87,218,18,192,177,129,18,208,0,171,142,253,131,36,96,239,112,37,96,207,118,74,64,81,226,149,192,48,163,233,48,71,199,87,157,175,53,127,120,170,22,21,87,3,79,46,154,39,74,180,71,134,129,118,113,117,69,203,187,162,229,239,39,39,39,228,140,87,219,45,8,109,174,7,62,208,146,155,49,133,196,232,242,112,183,128,63,135,245,190,19,119,227,217,46,98,209,150,228,16,123,103,227,184,142,195,227,185,193,12,249,74,247,225,217,137,92,217,177,209,8,48,227,57,230,31,14,9,173,253,104,63,188,25,136,231,16,201,233,217,73,60,159,146,116,77,228,114,90,130,20,241,40,70,215,190,211,78,230,228,33,226,112,8,36,18,81,150,254,151,38,167,2,106,29,101,92,98,145,162,188,163,236,33,229,212,144,130,121,182,86,202,109,81,100,160,194,61,136,114,229,15,157,129,186,190,26,49,77,73,81,225,253,109,210,164,47,135,171,168,140,239,200,86,254,63,235,15,200,161,92,27,52,200,202,248,65,14,193,11,137,16,46,171,56,134,75,81,131,143,204,19,1,254,229,169,229,150,146,127,195,129,70,31,88,81,237,80,23,87,138,34,196,149,19,252,159,99,20,231,191,113,143,66,1,206,32,49,221,127,138,24,167,65,179,55,252,123,148,85,138,121,139,113,219,85,80,174,24,209,136,45,214,38,26,238,181,84,193,200,166,196,35,97,107,72,30,92,95,190,136,44,228,218,66,53,196,215,21,212,67,84,182,132,12,92,157,122,65,39,181,240,189,211,100,134,147,163,0,7,39,34,194,225,71,39,231,152,250,83,176,137,218,63,10,151,180,180,72,18,72,242,140,79,218,43,236,233,42,203,38,122,119,248,27,24,60,13,186,18,180,73,120,193,23,191,87,81,22,120,64,187,54,233,35,78,123,216,15,47,106,31,172,1,121,160,183,116,106,225,60,73,44,94,252,146,55,77,217,127,58,136,172,62,22,117,218,205,12,216,154,66,28,138,101,82,104,154,162,229,46,221,150,232,248,4,222,113,142,79,52,247,227,51,124,66,33,55,148,24,168,126,159,176,174,229,129,62,97,128,250,124,194,152,174,125,66,24,27,142,59,190,80,155,237,69,94,22,193,0,191,232,177,209,227,13,250,121,30,215,114,7,131,243,193,238,96,43,160,219,29,76,161,251,221,193,60,253,185,238,208,143,117,164,59,184,70,232,184,195,146,138,102,134,112,135,183,119,80,138,208,196,32,149,227,100,112,153,242,242,236,2,82,139,250,238,92,23,115,194,235,239,92,12,104,91,84,128,28,255,40,19,20,26,85,96,29,22,136,50,49,5,229,43,232,123,150,219,129,22,215,133,239,89,177,237,176,107,20,151,148,11,238,107,250,52,36,53,75,113,37,151,90,11,112,123,227,134,176,49,79,145,61,41,68,153,203,164,28,88,76,82,177,29,140,10,82,214,153,153,21,172,11,40,24,33,13,8,28,153,26,34,149,95,211,188,75,200,35,21,133,224,28,164,206,42,227,109,24,184,115,90,139,148,39,160,146,28,153,58,187,77,73,116,234,193,67,135,246,54,17,243,92,113,212,108,40,10,194,107,230,133,168,175,203,94,133,232,147,158,8,5,17,187,208,120,35,63,31,125,228,209,169,80,187,62,220,136,10,202,7,145,0,159,211,221,23,105,66,0,228,134,242,218,239,150,37,204,32,117,60,104,165,87,92,46,149,214,10,101,218,34,175,182,148,69,183,25,29,236,150,247,17,35,76,96,200,115,100,196,240,25,178,180,82,197,178,131,20,190,47,216,2,204,214,49,16,50,155,127,95,163,244,50,45,239,8,15,240,212,101,74,135,103,111,62,220,35,119,165,217,255,135,232,253,12,181,50,69,167,29,215,152,103,75,73,40,231,112,177,221,149,123,125,17,10,253,198,200,145,110,41,53,246,10,226,135,0,175,199,13,102,93,138,155,52,165,27,235,197,12,111,224,118,238,97,178,119,158,39,221,24,61,13,22,14,234,72,99,162,226,178,62,211,79,253,183,40,195,1,142,107,52,130,108,53,210,100,233,230,174,52,46,133,254,176,127,180,179,72,133,25,10,170,147,158,154,184,192,254,186,218,239,104,40,45,162,9,159,151,116,109,147,104,160,216,119,154,27,214,61,254,55,153,42,212,27,155,115,33,26,125,224,200,145,138,26,126,82,65,208,136,249,166,100,29,139,25,217,82,31,196,248,155,172,136,191,118,68,250,26,46,188,44,54,105,28,101,215,59,138,15,35,0,239,14,193,93,99,133,108,131,24,149,0,58,70,106,39,86,205,234,35,219,72,29,157,49,209,192,192,246,172,42,201,47,222,189,17,79,66,81,158,144,223,101,190,169,216,212,61,191,166,155,171,61,145,188,198,149,161,194,9,140,53,19,242,202,153,156,28,71,183,209,214,247,118,191,126,99,105,73,173,254,215,208,142,23,100,190,227,57,68,140,162,98,49,29,208,231,234,104,144,225,184,92,52,4,64,94,18,94,132,123,49,99,65,168,119,140,251,148,149,224,117,120,123,72,126,141,221,207,110,161,84,248,103,214,211,165,145,216,253,105,191,48,35,86,60,240,243,245,26,237,106,102,91,21,158,98,196,119,107,241,25,249,185,118,78,85,197,166,248,199,37,203,44,148,7,144,53,178,136,64,76,79,240,247,90,22,214,11,92,223,106,118,139,21,243,36,212,25,31,106,113,84,60,121,130,209,201,167,207,3,230,38,158,116,208,11,186,141,133,128,27,139,190,160,80,240,86,174,245,154,143,48,155,27,128,107,23,88,42,221,147,18,227,1,146,69,144,74,21,139,207,101,149,84,55,232,245,95,80,247,148,188,3,141,174,210,45,157,147,134,216,186,23,97,92,141,136,251,182,81,206,92,203,212,24,19,145,24,79,14,155,90,208,156,215,229,115,93,188,180,96,61,168,162,132,241,156,85,27,27,98,96,85,134,11,180,128,103,158,125,170,218,176,46,25,121,35,127,22,239,149,205,253,168,69,105,226,54,75,206,147,251,40,143,161,8,177,238,163,50,205,157,92,126,228,246,150,141,115,95,244,55,171,21,89,77,251,198,234,212,30,58,87,133,140,123,149,163,171,8,51,241,200,67,254,111,144,133,33,236,130,127,132,91,225,154,201,252,48,152,144,159,126,210,154,93,194,141,0,80,50,229,213,162,82,99,215,183,255,1,111,195,153,143,244,97,40,145,16,3,44,195,17,18,54,73,84,150,59,239,174,212,21,172,54,102,178,173,203,254,126,224,218,250,15,246,12,234,238,188,118,18,140,92,247,216,72,55,85,51,53,78,31,26,166,132,103,123,131,148,17,150,204,192,226,36,138,199,71,163,174,245,86,236,59,28,123,248,176,182,206,51,227,144,211,13,234,239,51,249,171,17,85,199,171,155,68,48,3,153,55,220,102,17,126,108,215,159,104,147,205,10,25,208,190,155,73,118,227,30,109,145,223,161,15,84,183,155,148,253,245,209,39,150,206,135,212,1,117,199,67,68,186,26,187,57,211,13,9,58,38,184,145,235,176,10,6,245,154,244,41,29,14,236,50,212,225,200,186,67,99,229,191,29,30,205,169,63,239,224,178,60,165,3,29,219,126,139,21,239,164,160,240,45,230,200,199,120,47,247,251,140,160,228,155,74,96,81,121,122,139,118,85,140,29,245,108,134,194,237,235,101,117,116,82,252,206,126,160,57,115,20,150,149,123,122,119,30,182,5,133,193,73,132,63,85,72,177,181,206,241,171,223,16,112,110,60,199,152,121,132,170,87,13,114,128,155,213,177,90,115,248,67,62,179,190,3,149,217,122,10,23,57,7,57,136,34,82,15,5,205,101,110,236,132,100,32,98,165,121,100,243,164,178,175,93,221,153,178,0,68,153,154,122,17,158,72,44,223,185,131,197,99,76,119,146,17,218,132,15,19,227,166,200,178,219,40,254,234,67,105,255,120,43,148,61,178,160,9,9,229,29,212,49,237,14,172,238,41,25,178,93,70,247,84,238,230,129,231,135,47,42,30,17,10,43,114,90,84,96,35,113,193,146,58,81,117,199,235,246,142,152,96,159,162,212,115,13,201,169,85,33,14,6,45,45,229,224,231,50,205,228,175,46,33,212,85,121,44,220,172,70,208,47,251,29,63,71,212,60,11,239,253,124,184,102,108,96,127,21,177,178,187,207,56,53,9,213,135,32,146,211,51,112,155,170,110,144,82,226,117,234,91,214,76,213,100,127,227,227,188,251,4,217,226,164,255,17,178,189,220,120,134,28,212,143,253,88,148,131,90,178,36,226,138,63,221,59,114,100,208,251,64,217,94,221,251,160,216,98,203,162,165,11,114,72,59,8,71,237,65,57,6,255,254,7,35,184,243,42,86,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36c3c063-8e5c-4c70-8dd5-c7fd6b9b2f6a"));
		}

		#endregion

	}

	#endregion

}

