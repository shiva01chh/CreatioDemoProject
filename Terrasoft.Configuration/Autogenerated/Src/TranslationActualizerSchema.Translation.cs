﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationActualizerSchema

	/// <exclude/>
	public class TranslationActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationActualizerSchema(TranslationActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f124d613-6807-421d-a5f8-5319edc7d6c6");
			Name = "TranslationActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d72ca66-8680-4c3f-b4a0-15ba7a19db7c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,89,91,111,219,54,20,126,118,129,253,7,214,219,131,12,120,74,247,176,151,56,118,80,164,201,102,244,146,34,206,182,135,97,40,88,137,118,180,200,82,64,82,238,188,212,255,125,135,23,201,164,72,74,74,215,97,121,136,45,234,240,240,59,23,158,155,11,188,37,236,1,39,4,221,18,74,49,43,215,60,190,40,139,117,182,169,40,230,89,89,196,183,20,23,44,151,223,191,121,246,248,205,179,81,197,178,98,131,86,123,198,201,118,214,122,134,189,121,78,18,65,204,226,159,72,65,104,150,56,52,183,119,148,224,20,22,142,111,204,195,183,219,178,240,191,161,36,190,44,120,198,51,194,130,4,87,56,225,37,237,162,48,4,2,26,160,250,150,146,13,60,160,139,28,51,118,138,126,163,25,39,111,202,4,231,217,223,248,99,78,126,197,121,69,46,119,164,224,47,233,134,201,29,15,213,199,60,75,80,34,54,244,208,163,83,100,236,29,61,202,253,53,131,229,75,169,170,27,194,170,156,35,245,161,48,29,20,50,82,164,10,156,15,168,33,8,240,169,196,249,132,186,248,188,100,0,107,25,216,95,99,172,79,187,44,170,237,41,170,41,36,249,138,99,94,49,45,10,205,118,152,19,68,128,204,79,53,18,28,71,163,209,178,120,79,203,13,37,140,77,229,243,187,146,3,9,229,36,21,143,7,125,170,45,242,81,102,240,40,142,11,14,114,191,87,39,218,199,39,226,61,98,156,74,139,187,146,213,136,40,127,11,0,240,134,220,146,237,67,46,118,206,37,152,177,177,7,97,115,19,48,133,93,104,142,126,127,124,113,64,209,227,15,135,201,31,227,217,147,207,190,44,82,125,50,176,234,56,13,228,255,2,238,171,251,236,97,16,123,6,132,29,252,219,126,204,6,235,207,216,137,118,114,235,191,82,99,55,16,91,153,189,71,107,157,118,249,215,85,70,242,52,228,92,0,157,195,125,18,97,171,44,242,61,42,63,254,9,65,78,96,188,191,86,95,231,168,32,159,244,122,52,233,57,75,250,50,173,68,160,98,86,60,240,222,200,200,188,168,112,131,118,89,10,247,151,187,107,234,86,141,150,16,102,47,32,144,84,148,44,139,117,217,236,96,222,229,169,21,7,222,148,155,141,205,92,173,76,144,186,194,62,36,115,31,22,105,216,81,0,201,60,128,101,214,62,67,195,153,187,128,28,210,75,74,75,250,51,46,210,60,4,9,97,102,201,106,238,152,25,17,168,219,22,16,164,203,138,38,164,225,74,91,11,182,66,255,47,123,41,214,167,136,223,101,44,242,157,29,100,31,180,253,135,182,164,160,230,246,210,108,64,36,7,218,7,66,69,18,239,190,109,158,92,130,62,36,21,165,34,155,122,222,205,125,59,226,99,146,153,13,60,227,34,124,132,82,196,134,112,253,109,148,67,4,64,209,49,14,212,186,26,141,40,1,213,22,93,128,149,11,11,109,53,255,217,16,206,221,58,144,241,207,101,125,176,85,252,42,147,133,7,166,251,51,21,111,167,58,238,46,208,7,168,150,202,130,148,21,187,33,73,73,83,166,99,91,120,75,111,188,179,45,94,114,16,71,228,124,19,144,123,175,28,119,211,246,211,219,61,59,156,5,199,92,181,81,28,79,62,63,71,145,207,191,101,165,165,74,202,61,212,179,252,204,57,21,164,159,204,60,122,110,96,250,130,129,111,173,1,171,184,53,142,170,23,92,198,129,176,17,88,126,50,123,55,202,184,43,3,153,234,98,55,20,173,3,235,199,194,177,239,128,144,223,201,194,91,248,156,4,96,129,33,226,149,34,208,199,157,117,215,241,139,64,157,47,0,247,184,255,91,194,239,74,167,182,56,57,57,65,103,172,218,110,225,70,45,234,133,21,222,65,241,98,132,224,184,33,61,49,105,107,69,236,202,44,85,192,12,37,70,75,3,229,18,58,46,4,239,183,117,0,105,249,77,43,15,128,207,251,29,40,190,129,226,39,202,100,143,167,223,166,19,39,11,55,212,14,38,185,243,53,217,183,19,143,217,142,65,243,88,109,139,119,208,146,78,37,228,88,170,120,98,154,218,171,53,121,24,67,121,187,12,12,40,79,174,60,96,138,183,168,128,179,230,227,123,178,31,47,204,146,25,22,226,179,19,73,226,223,33,217,143,23,18,95,55,101,82,139,154,146,191,198,11,45,56,202,196,99,247,198,109,153,102,235,140,164,215,197,120,241,86,126,79,20,184,20,12,111,109,117,157,161,237,165,145,46,170,239,165,254,213,119,41,2,232,25,174,129,137,113,138,94,1,175,219,108,75,208,17,193,87,241,29,243,20,237,57,94,71,213,249,166,245,42,146,216,53,232,150,11,45,211,169,1,118,138,214,56,103,164,62,194,106,177,169,250,152,59,185,34,246,235,77,94,28,197,72,171,77,113,56,54,31,234,57,94,178,85,149,36,176,138,206,157,165,248,182,92,201,205,209,4,218,110,253,86,115,8,148,188,177,144,43,250,110,12,23,230,20,61,130,232,7,45,59,60,201,79,120,54,245,9,203,230,227,193,212,7,188,59,62,28,208,247,26,1,44,91,178,28,198,90,80,61,194,185,108,149,1,82,23,83,189,89,147,130,246,132,128,94,221,41,141,71,38,125,171,8,145,254,26,58,205,235,26,83,228,51,103,237,157,217,26,69,181,129,193,135,170,60,71,159,63,187,6,130,53,229,102,71,26,167,230,17,51,48,142,179,130,129,1,154,208,53,153,216,117,132,145,246,71,46,135,151,105,106,4,61,219,234,97,117,172,8,95,178,139,59,92,108,72,26,201,97,215,222,76,7,238,125,253,175,174,166,80,102,139,199,115,165,176,70,11,102,154,2,220,42,122,235,120,211,186,160,181,72,102,132,135,14,152,120,75,39,67,29,215,69,231,40,39,106,98,85,221,239,147,43,90,54,169,174,163,146,247,55,11,199,9,85,231,189,84,161,32,190,42,233,22,243,232,41,195,166,169,13,84,119,128,214,90,252,26,146,195,36,236,33,97,149,92,22,105,244,197,162,183,250,164,144,232,253,211,173,46,228,3,166,75,145,103,212,96,2,80,26,179,45,240,244,161,213,49,203,197,191,240,228,93,249,73,91,162,181,106,218,194,115,197,47,114,130,105,244,229,2,155,6,11,136,59,116,12,246,20,140,3,234,212,86,143,86,55,5,82,170,1,65,191,47,74,63,111,7,229,38,166,236,48,69,68,87,0,61,131,245,186,31,190,169,115,186,98,170,91,95,221,2,95,23,225,178,61,170,181,230,81,190,34,176,146,157,191,191,219,101,84,24,68,169,102,89,112,66,11,156,55,3,35,179,2,110,98,149,24,35,154,97,202,169,69,68,76,118,12,31,213,219,166,78,193,223,242,64,47,180,78,69,244,104,154,152,182,11,179,169,51,106,71,154,236,192,32,38,85,83,68,158,232,169,70,103,231,109,13,26,75,12,233,170,156,26,220,10,204,208,34,220,17,89,125,35,94,234,105,182,61,102,94,139,240,109,85,230,170,217,148,6,232,246,9,111,254,18,234,238,10,228,125,73,172,49,196,167,187,12,122,162,175,195,107,164,126,190,139,87,57,33,15,209,143,47,94,212,151,232,16,186,75,157,137,195,248,225,162,190,103,136,64,249,94,31,215,87,1,216,138,155,213,149,201,254,8,215,211,157,202,53,44,99,84,4,17,120,190,104,168,71,157,87,216,123,216,232,208,104,0,173,51,216,154,31,15,239,73,214,193,57,93,159,47,59,173,46,11,13,10,124,30,232,198,150,218,186,3,83,180,194,253,38,99,252,172,85,119,46,140,194,147,13,168,60,221,17,130,57,2,58,7,34,70,100,115,64,153,135,214,226,165,75,76,227,53,139,90,96,166,254,156,210,7,66,76,101,52,6,39,193,118,130,2,236,30,84,226,110,145,54,52,205,199,201,5,141,209,106,241,7,21,21,189,35,19,168,215,173,136,40,7,226,131,7,38,198,70,107,112,18,12,126,178,173,49,39,61,193,14,167,227,151,166,128,149,85,79,193,180,39,155,205,146,190,132,214,232,192,158,117,152,35,142,99,20,176,154,48,171,251,242,52,74,135,174,140,229,251,25,95,174,25,127,255,0,31,112,243,36,131,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f124d613-6807-421d-a5f8-5319edc7d6c6"));
		}

		#endregion

	}

	#endregion

}

