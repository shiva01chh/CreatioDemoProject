﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FullPipelineQueryBuilderSchema

	/// <exclude/>
	public class FullPipelineQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FullPipelineQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FullPipelineQueryBuilderSchema(FullPipelineQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1");
			Name = "FullPipelineQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,90,75,115,219,54,16,62,43,51,253,15,168,219,3,57,163,97,218,107,148,164,35,191,82,117,236,216,137,220,230,208,233,116,104,18,146,56,37,9,5,32,237,168,30,255,247,46,94,196,131,160,40,231,209,28,98,145,4,118,23,187,223,126,187,0,89,167,21,102,219,52,195,232,6,83,154,50,178,106,146,19,82,175,138,117,75,211,166,32,245,119,207,30,190,123,54,105,89,81,175,209,114,199,26,92,205,188,107,24,95,150,56,227,131,89,242,6,215,152,22,89,111,204,69,81,127,52,55,79,72,85,145,218,190,166,216,189,74,78,143,189,27,103,117,83,52,5,102,230,246,219,182,72,150,152,222,21,25,190,36,57,46,147,179,79,13,174,25,183,195,12,178,151,5,82,206,211,172,33,84,138,129,49,63,80,188,134,241,232,164,76,25,123,129,206,219,178,188,46,182,184,44,106,252,174,197,116,119,220,22,101,142,169,24,251,252,249,115,244,146,181,85,149,210,221,107,117,125,77,201,93,145,99,134,42,220,108,72,142,200,10,125,228,243,208,45,159,136,86,132,162,21,200,68,91,37,20,229,105,147,38,90,216,115,75,218,159,167,120,149,182,101,115,92,212,57,216,29,53,187,45,38,171,104,49,100,82,28,255,5,179,182,237,109,89,100,40,227,230,15,90,143,94,160,65,49,32,227,65,172,174,115,197,121,129,203,28,124,113,77,139,187,180,193,242,225,86,94,32,138,211,156,212,229,14,253,206,48,5,156,212,50,238,232,239,214,185,158,5,231,44,222,224,230,61,222,18,86,64,8,118,50,18,187,151,18,11,203,38,93,227,83,112,206,107,244,55,227,191,123,3,7,100,2,190,32,248,109,137,133,132,95,11,198,199,154,201,74,218,18,55,13,120,149,153,7,142,184,197,89,221,86,152,166,183,37,126,105,123,74,96,110,39,243,1,12,219,6,110,51,71,144,109,132,210,169,44,112,111,14,106,31,240,134,171,133,53,84,10,206,54,184,74,223,66,10,207,84,12,113,157,203,48,186,49,5,152,110,49,229,217,195,227,74,26,136,18,206,229,144,49,235,67,247,94,189,14,46,10,253,242,11,226,226,38,81,240,233,43,4,241,15,136,139,150,221,50,226,120,230,226,77,173,212,140,64,15,66,195,26,55,210,10,219,3,112,159,193,125,57,98,50,96,67,13,225,157,217,35,152,127,211,232,122,133,238,210,178,85,162,31,249,255,143,174,121,123,35,183,148,210,141,193,202,176,98,133,162,78,181,212,29,235,103,147,187,148,34,15,255,96,198,64,74,36,78,66,69,1,223,198,106,85,214,90,61,81,92,198,188,44,35,61,242,81,254,161,184,105,105,237,160,207,241,192,16,210,32,41,32,102,45,55,143,99,77,208,147,242,153,164,170,33,34,138,60,70,113,9,101,42,173,58,144,65,194,222,210,50,198,24,99,128,48,116,140,92,195,146,147,13,206,254,153,211,53,224,160,110,222,194,226,162,26,160,3,204,237,142,139,149,127,7,2,57,40,37,60,222,145,214,55,117,68,92,96,109,74,158,71,227,128,150,0,175,79,6,208,216,199,150,205,220,147,33,34,214,211,6,40,122,4,111,151,162,238,14,149,171,16,121,13,144,144,98,26,147,253,58,222,78,38,4,124,13,242,34,107,214,44,64,19,119,164,200,209,124,187,45,119,215,208,28,145,252,188,40,27,64,252,18,243,182,9,49,241,103,138,134,10,15,10,149,29,5,230,208,2,3,188,167,215,194,169,39,36,45,1,57,180,57,229,182,126,239,49,18,39,36,209,210,192,200,188,80,168,168,241,61,122,231,220,140,220,203,27,232,94,146,55,80,165,97,157,87,244,236,99,155,90,28,119,129,87,205,217,167,45,197,140,245,196,149,109,85,155,103,81,96,45,137,179,230,206,241,83,164,164,79,70,231,232,181,74,109,34,106,138,251,20,7,186,235,77,22,204,93,73,36,39,38,215,41,133,185,60,146,92,218,77,81,97,126,139,225,17,23,199,58,219,38,50,242,201,60,207,141,31,93,221,83,116,65,214,69,150,150,87,80,191,69,63,158,204,235,60,182,248,120,56,166,167,45,254,218,17,189,128,176,252,79,225,252,134,209,180,86,241,121,161,84,158,253,186,129,244,56,67,145,195,41,206,8,140,199,31,138,102,35,105,131,125,25,111,160,207,34,142,62,121,105,237,97,37,33,81,179,253,112,85,171,131,248,240,130,117,69,63,108,138,6,47,249,214,52,138,59,176,41,50,150,202,237,44,224,160,94,73,9,128,192,160,2,32,106,237,65,101,11,159,132,217,199,243,110,158,146,144,136,158,228,76,63,9,194,86,138,150,128,253,125,145,43,188,122,5,212,210,35,224,32,229,153,253,50,168,180,244,167,12,217,82,223,133,102,24,39,6,5,194,38,183,173,27,222,86,254,116,152,207,64,189,202,216,158,234,200,91,140,179,228,203,180,6,159,208,96,164,157,129,118,41,157,64,143,55,207,171,162,126,95,172,55,141,112,120,90,50,44,77,146,150,129,61,9,148,114,190,43,182,40,4,64,49,47,239,211,29,83,208,127,133,160,199,196,35,190,232,17,31,151,173,81,230,103,35,136,12,59,212,31,56,235,203,2,196,146,102,80,128,120,170,102,173,8,20,146,108,131,162,197,64,160,23,13,174,20,10,81,81,135,37,26,230,181,141,0,238,137,228,68,183,147,127,68,24,92,28,114,1,159,97,208,23,135,179,169,115,56,159,201,91,39,113,29,196,135,5,246,204,170,44,182,156,164,227,67,57,182,27,151,56,117,6,102,5,138,207,113,73,178,127,102,118,79,22,162,221,108,132,113,121,150,45,77,42,120,172,43,213,166,224,176,19,81,242,231,235,53,52,154,98,118,247,40,10,214,54,36,109,250,131,111,24,117,132,76,165,229,18,237,194,200,197,216,36,84,231,64,200,13,248,147,39,133,220,56,38,31,54,152,226,8,243,125,46,6,20,157,129,241,50,136,137,180,191,123,164,203,72,167,138,123,4,102,215,28,77,209,97,149,93,178,110,7,173,39,212,244,64,37,25,169,233,99,51,84,121,245,11,250,227,212,241,177,201,126,203,123,16,226,157,85,46,212,110,90,60,122,122,183,179,168,63,171,201,121,186,67,126,60,122,24,157,196,127,27,143,60,46,242,35,175,205,233,173,51,17,44,107,12,19,25,111,93,190,79,235,53,238,53,64,204,118,103,215,224,132,161,213,83,25,138,208,163,135,77,88,221,25,48,146,229,48,101,130,56,58,136,126,210,58,85,142,119,19,67,233,170,216,73,150,235,79,224,41,38,217,76,242,211,147,26,35,59,103,157,35,160,112,51,239,157,59,241,89,155,3,143,187,252,205,162,84,169,121,150,227,74,229,183,207,175,42,251,207,41,169,6,182,24,70,178,26,43,93,235,122,248,231,88,63,93,128,104,250,27,41,234,104,115,8,92,245,180,171,3,199,79,17,0,123,207,200,203,180,168,181,253,1,96,115,206,19,61,250,200,90,167,232,136,79,242,136,93,227,39,212,64,239,239,93,55,129,182,117,188,57,191,166,248,174,32,45,147,178,130,59,124,185,172,65,84,86,224,14,253,160,143,201,172,195,193,210,70,103,127,82,162,16,131,115,110,86,114,18,152,103,96,183,85,86,131,8,35,129,31,56,6,143,186,53,0,11,202,154,43,170,94,88,68,21,174,110,161,93,129,90,36,127,89,161,73,68,0,89,20,50,62,182,235,159,200,93,145,181,160,124,32,157,131,182,218,187,138,208,115,215,27,253,150,208,81,60,26,79,107,248,52,236,187,222,214,124,52,64,162,225,1,187,108,92,72,47,153,208,137,114,4,45,247,238,134,240,255,67,230,171,82,194,123,156,144,206,192,206,122,28,58,27,136,131,54,197,219,92,91,217,25,116,123,64,31,144,193,168,74,40,67,184,110,124,157,130,20,102,129,118,182,217,80,114,47,40,19,122,236,69,181,45,49,63,240,196,0,158,12,111,69,89,119,226,225,181,141,224,169,56,145,56,179,35,59,210,34,170,156,22,220,41,144,42,209,233,212,15,77,230,80,1,56,201,41,62,183,0,175,28,241,45,115,46,156,105,228,14,154,225,178,20,219,68,213,149,238,233,116,253,186,161,95,178,168,94,94,212,150,255,185,221,73,230,44,234,189,67,16,6,50,41,97,145,91,96,13,25,124,222,214,153,220,39,247,214,23,239,147,126,37,93,167,76,227,254,59,64,207,178,117,58,112,175,85,244,163,17,199,7,172,242,164,165,60,73,22,245,30,75,248,150,40,45,179,182,132,200,42,127,152,178,215,3,159,69,162,189,103,35,4,58,74,153,99,74,157,204,220,87,172,123,2,166,161,227,253,61,231,239,33,151,124,201,81,26,211,78,232,118,245,34,193,186,19,5,216,191,7,167,37,198,140,110,107,218,201,18,65,232,100,36,102,239,122,67,46,200,61,248,211,63,148,81,104,224,111,207,224,119,9,110,196,177,166,128,163,180,226,232,56,50,27,34,14,140,121,37,225,86,102,10,168,122,245,157,90,239,4,97,143,71,123,178,60,135,6,150,106,169,113,218,27,111,59,189,111,135,165,142,48,173,14,208,120,236,38,165,107,220,79,8,174,35,173,14,99,61,223,150,207,205,110,163,79,49,75,32,174,251,218,75,175,122,216,5,38,200,175,250,232,224,32,50,54,41,255,189,58,111,232,111,157,75,146,165,101,241,47,127,189,221,85,212,75,88,28,12,231,245,202,67,34,152,123,97,38,44,197,251,180,232,104,232,125,239,145,174,6,71,111,137,52,224,134,44,55,228,126,209,53,8,186,228,59,85,62,60,212,212,123,249,26,47,57,39,180,74,155,104,207,2,166,168,95,32,205,225,215,83,183,99,225,128,244,247,89,189,103,98,55,21,158,45,182,79,99,1,29,217,67,153,54,173,183,95,82,182,201,83,166,33,11,198,212,203,63,252,148,109,79,135,216,123,199,34,78,125,227,110,28,111,196,190,192,5,161,94,1,92,174,219,206,192,9,135,2,124,239,24,173,171,190,111,40,105,183,199,187,175,109,213,192,22,149,245,122,205,241,183,221,253,15,43,236,179,16,217,146,30,246,85,83,38,171,210,20,13,190,1,55,119,250,31,22,56,239,105,244,71,6,189,196,202,116,229,27,250,46,65,13,208,227,29,78,243,191,241,9,247,201,48,48,179,62,200,210,190,237,181,233,123,220,44,239,122,55,189,47,4,71,25,72,76,114,62,203,27,157,242,66,124,27,0,73,196,47,44,65,254,151,121,163,223,214,28,74,143,176,105,16,28,24,191,64,183,188,224,233,75,244,128,14,245,140,184,99,255,251,15,115,171,61,95,73,42,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoStagesToShowInPipelineLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoStagesToShowInPipelineLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86098e23-8c70-4d26-bad8-b983bdebbc16"),
				Name = "NoStagesToShowInPipeline",
				CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7"),
				CreatedInSchemaUId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1"),
				ModifiedInSchemaUId = new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe83c678-9553-40bc-8c8c-067a00abb8a1"));
		}

		#endregion

	}

	#endregion

}

