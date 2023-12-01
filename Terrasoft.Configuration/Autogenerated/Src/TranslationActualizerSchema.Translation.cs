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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,89,91,111,219,54,20,126,118,128,253,7,214,219,131,12,120,74,247,176,151,56,118,80,164,201,102,244,146,34,206,182,135,97,40,88,137,118,180,202,84,64,82,238,188,212,255,125,71,36,37,147,34,41,41,93,135,189,36,18,117,120,248,157,11,207,205,20,111,9,127,192,9,65,119,132,49,204,139,181,136,47,11,186,206,54,37,195,34,43,104,124,199,48,229,185,124,254,230,228,241,155,147,81,201,51,186,65,171,61,23,100,59,107,189,195,222,60,39,73,69,204,227,159,8,37,44,75,28,154,187,123,70,112,10,11,199,47,230,225,219,109,65,253,95,24,137,175,168,200,68,70,120,144,224,26,39,162,96,93,20,134,64,64,3,84,223,50,178,129,23,116,153,99,206,207,208,111,44,19,228,117,145,224,60,251,27,127,200,201,175,56,47,201,213,142,80,241,130,109,184,220,241,80,126,200,179,4,37,213,134,30,122,116,134,140,189,163,71,185,191,102,176,124,33,85,117,75,120,153,11,164,254,41,76,7,133,140,208,84,129,243,1,53,4,1,62,101,117,62,97,46,62,47,25,192,90,6,246,215,24,235,211,174,104,185,61,67,53,133,36,95,9,44,74,174,69,97,217,14,11,130,8,144,249,169,70,21,199,209,104,180,164,239,88,177,97,132,243,169,124,127,91,8,32,97,130,164,213,235,65,159,106,139,124,148,25,60,74,96,42,64,238,119,234,68,251,248,164,250,142,184,96,210,226,174,100,53,34,38,222,0,0,188,33,119,100,251,144,87,59,231,18,204,216,216,131,176,185,9,152,194,46,52,71,191,63,62,63,160,232,241,135,195,228,143,241,236,201,103,95,209,84,159,12,172,58,78,3,249,191,128,251,234,99,246,48,136,61,7,194,14,254,109,63,230,131,245,103,236,68,59,185,245,95,169,177,27,136,173,204,222,163,181,78,187,252,235,58,35,121,26,114,46,128,46,224,62,85,97,171,160,249,30,21,31,254,132,32,87,97,252,120,163,30,231,136,146,79,122,61,154,244,156,37,125,153,149,85,160,226,86,60,240,222,200,200,188,168,112,131,118,89,10,247,87,184,107,234,86,141,150,16,102,47,33,144,148,140,44,233,186,104,118,112,239,242,212,138,3,175,139,205,198,102,174,86,38,72,93,97,31,146,185,15,139,52,236,40,128,100,30,192,50,107,159,161,225,204,93,64,14,233,21,99,5,251,25,211,52,15,65,66,152,91,178,154,59,102,70,4,234,182,5,4,233,162,100,9,105,184,178,214,130,173,208,255,203,94,138,245,25,18,247,25,143,124,103,7,217,7,109,255,190,45,41,168,185,189,52,27,16,201,129,246,129,176,42,137,119,223,54,79,46,65,239,147,146,177,42,155,122,190,205,125,59,226,99,146,153,13,60,227,50,124,132,82,196,134,8,253,52,202,33,2,160,232,24,7,106,93,141,70,140,128,106,105,23,96,229,194,149,182,154,191,124,8,231,110,29,200,248,231,178,62,216,42,126,153,201,194,3,179,253,185,138,183,83,29,119,23,232,61,84,75,5,37,69,201,111,73,82,176,148,235,216,22,222,210,27,239,108,139,23,2,196,169,114,190,9,200,189,87,142,187,105,251,233,237,158,29,206,130,99,174,218,40,142,39,95,92,160,200,231,223,178,210,82,37,229,30,234,89,113,238,156,10,210,79,102,30,61,55,48,125,193,192,183,214,128,85,220,26,71,213,11,46,227,64,216,8,44,63,153,189,27,101,220,149,129,76,117,177,27,138,214,129,245,99,225,216,119,64,200,239,100,225,93,249,156,4,96,129,33,213,39,69,160,143,59,239,174,227,23,129,58,191,2,220,227,254,111,136,184,47,156,218,226,244,244,20,157,243,114,187,133,27,181,168,23,86,120,7,197,139,17,130,227,134,244,212,164,173,21,177,43,178,84,1,51,148,24,45,13,148,75,232,184,16,124,223,214,1,164,229,55,173,60,0,62,239,119,160,248,22,138,159,40,147,61,158,254,154,78,156,44,220,80,59,152,228,206,87,100,223,78,60,102,59,6,205,99,185,165,111,161,37,157,74,200,177,84,241,196,52,181,87,107,242,48,142,242,118,25,24,80,158,92,121,192,12,111,17,133,179,230,227,143,100,63,94,152,37,51,44,196,231,167,146,196,191,67,178,31,47,36,190,110,202,164,22,53,37,127,141,23,90,112,148,85,175,221,27,183,69,154,173,51,146,222,208,241,226,141,124,78,20,184,20,12,111,109,117,157,161,237,165,145,46,170,63,74,253,171,103,41,2,232,25,174,129,137,113,138,94,2,175,187,108,75,208,17,193,87,241,29,243,20,237,57,94,71,213,249,166,245,41,146,216,53,232,150,11,45,211,169,1,118,138,214,56,231,164,62,194,106,177,153,250,55,119,114,69,236,215,155,188,56,138,145,86,155,226,112,108,62,212,123,188,228,171,50,73,96,21,93,56,75,241,93,177,146,155,163,9,180,221,250,171,230,16,40,121,227,74,174,232,187,49,92,152,51,244,8,162,31,180,236,240,38,255,195,187,169,79,88,54,95,15,166,62,224,219,241,229,128,190,215,8,96,217,146,229,48,214,130,234,17,206,85,171,12,144,186,152,234,205,154,20,180,87,9,232,213,157,210,120,100,210,183,138,16,233,175,161,211,188,174,49,69,62,115,214,222,153,173,81,84,27,24,124,168,204,115,244,249,179,107,32,88,83,110,118,164,113,106,158,106,6,38,112,70,57,24,160,9,93,147,137,93,71,24,105,127,228,114,120,145,166,70,208,179,173,30,86,199,138,136,37,191,188,199,116,67,210,72,14,187,246,102,58,112,239,235,127,117,53,43,101,182,120,60,83,10,107,180,96,166,41,192,173,162,183,142,55,173,11,90,139,100,70,120,232,128,137,183,116,50,212,113,67,59,71,57,81,19,171,234,126,159,92,179,162,73,117,29,149,188,191,89,56,78,168,58,239,165,10,5,241,117,193,182,88,68,79,25,54,77,109,160,186,3,180,214,226,87,144,28,38,97,15,9,171,228,138,166,209,23,139,222,234,147,66,162,247,79,183,186,144,15,152,46,69,158,81,131,9,64,105,204,182,192,211,135,86,199,44,23,255,34,146,183,197,39,109,137,214,170,105,11,207,21,191,204,9,102,209,151,11,108,26,44,32,238,208,49,216,83,48,14,168,83,91,61,90,221,20,72,169,6,4,253,190,40,253,172,29,148,155,152,178,195,12,17,93,1,244,12,214,235,126,248,182,206,233,138,169,110,125,117,11,124,67,195,101,123,84,107,205,163,124,69,96,37,59,127,127,183,203,88,101,16,165,154,37,21,132,81,156,55,3,35,179,2,110,98,85,53,70,52,195,148,83,139,84,49,217,49,124,84,111,155,58,5,127,203,3,189,208,58,21,209,163,105,98,218,46,204,166,206,168,29,105,178,3,67,53,169,154,34,242,68,79,53,58,59,111,107,208,88,98,72,87,229,212,224,86,96,134,22,225,158,200,234,27,137,66,79,179,237,49,243,186,10,223,86,101,174,154,77,105,128,110,159,240,230,175,74,221,93,129,188,47,137,53,134,248,116,159,65,79,244,117,120,141,212,207,119,241,42,39,228,33,250,241,249,243,250,18,29,66,119,169,51,113,24,63,92,212,247,12,17,40,223,235,227,250,42,0,91,113,179,186,50,217,31,225,122,186,83,185,134,101,140,138,32,2,207,23,13,245,168,243,10,123,15,27,29,26,13,160,117,6,91,243,227,225,61,201,58,56,167,235,243,101,167,213,229,161,65,129,207,3,221,216,82,91,119,96,138,86,184,95,103,92,156,183,234,206,133,81,120,242,1,149,167,59,66,48,71,64,23,64,196,137,108,14,24,247,208,90,188,116,137,105,124,230,81,11,204,212,159,83,250,64,84,83,25,141,193,73,176,157,160,0,187,7,85,117,183,72,27,154,230,227,228,130,198,104,181,248,131,138,138,222,145,9,212,235,86,68,148,3,241,193,3,19,99,163,53,56,9,6,63,217,214,152,147,158,96,135,211,241,75,83,192,202,170,167,224,218,147,205,102,73,95,66,107,116,96,207,58,204,17,199,49,10,88,77,152,213,125,121,26,165,67,87,198,242,253,140,47,215,78,78,254,1,229,182,66,213,122,33,0,0 };
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
