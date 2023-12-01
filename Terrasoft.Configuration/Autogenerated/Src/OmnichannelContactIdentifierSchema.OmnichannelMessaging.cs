﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OmnichannelContactIdentifierSchema

	/// <exclude/>
	public class OmnichannelContactIdentifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OmnichannelContactIdentifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OmnichannelContactIdentifierSchema(OmnichannelContactIdentifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74");
			Name = "OmnichannelContactIdentifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,90,91,111,220,184,21,126,158,5,246,63,48,179,197,86,131,157,202,109,31,109,143,3,59,182,131,105,99,199,141,147,238,67,81,24,178,196,25,19,209,101,34,74,78,166,89,255,247,158,195,139,68,82,212,197,155,244,161,11,100,61,146,200,195,195,115,249,206,133,204,163,140,242,93,20,83,242,158,150,101,196,139,77,21,190,42,242,13,219,214,101,84,177,34,15,223,102,57,139,31,162,60,167,105,120,69,57,143,182,44,223,254,248,195,215,31,127,152,213,28,126,146,109,90,220,71,233,225,225,171,34,203,96,252,155,98,139,35,142,154,239,6,129,102,190,247,235,77,89,60,178,132,150,60,60,47,178,136,229,225,69,94,177,138,81,62,50,122,157,87,180,220,192,30,140,129,183,123,94,209,204,125,134,173,165,41,141,113,95,28,183,25,215,101,73,243,106,112,216,107,154,211,146,197,157,49,111,88,254,169,125,105,74,15,197,224,255,82,210,190,247,225,249,89,239,167,174,24,156,1,183,149,164,12,223,127,42,233,22,216,38,175,210,136,243,67,83,94,176,221,42,138,171,117,2,27,102,27,70,75,49,254,224,224,128,28,243,58,203,162,114,127,162,158,197,92,82,61,68,21,97,122,52,39,177,156,79,238,247,4,76,134,211,124,75,203,246,123,25,106,98,7,6,181,93,125,159,178,152,196,130,224,48,47,51,52,168,150,125,144,124,21,229,21,108,225,70,208,16,204,106,122,240,169,18,127,74,20,134,34,198,207,246,45,189,87,81,252,64,255,78,247,100,69,230,221,117,97,232,43,249,226,52,79,218,73,115,41,194,217,79,52,79,36,31,234,89,49,5,22,183,163,37,106,2,184,42,217,99,84,81,197,150,124,32,37,141,146,34,79,247,154,179,187,156,126,86,75,94,131,159,33,51,215,214,155,55,69,28,165,236,63,209,125,74,111,197,20,205,130,166,168,118,122,95,20,41,185,99,252,154,210,228,125,241,97,151,192,55,177,197,181,16,83,172,148,63,107,77,250,156,9,243,5,61,28,75,102,150,228,117,205,146,19,114,23,15,202,224,200,92,125,2,185,97,137,18,161,212,217,150,86,234,215,140,109,72,48,180,145,133,30,56,27,97,148,172,212,184,217,7,14,250,46,96,128,96,49,60,221,237,192,70,4,118,9,202,224,192,213,63,163,180,166,199,227,219,57,9,134,140,105,113,164,89,27,216,0,40,121,19,165,156,170,177,79,132,194,195,244,77,141,233,135,188,124,73,70,54,172,229,242,253,55,254,100,232,112,108,35,43,146,215,105,218,170,115,157,3,134,161,177,83,223,74,129,179,68,73,171,186,204,39,25,171,156,242,212,227,137,50,226,208,95,139,242,35,45,47,129,84,1,91,95,131,39,111,88,74,207,163,42,210,97,4,60,99,215,125,171,102,28,121,105,43,42,235,12,22,120,83,68,48,188,161,97,188,123,22,168,20,21,40,149,38,114,136,139,205,226,5,42,31,177,88,107,191,25,104,226,46,240,170,40,57,198,226,60,206,26,255,60,50,132,232,93,247,152,83,74,226,146,110,86,243,53,132,248,249,193,9,97,217,46,165,25,40,67,216,30,97,202,3,122,89,178,32,13,137,144,187,180,216,30,217,252,154,159,241,95,7,65,180,105,192,84,116,134,64,252,88,225,216,171,40,7,169,151,104,247,152,132,128,85,121,176,223,128,251,197,162,107,64,125,106,18,1,169,172,209,26,156,152,228,149,86,107,237,156,68,4,194,64,35,29,82,108,32,180,82,83,158,131,76,130,156,69,248,108,165,186,139,202,40,35,57,132,143,213,188,182,212,57,63,89,247,175,98,107,30,232,134,199,7,130,212,73,143,190,100,172,29,98,46,112,140,203,230,70,251,190,51,104,229,12,147,58,24,112,62,152,129,2,156,238,201,129,195,135,189,130,233,174,146,114,215,143,157,141,45,142,38,88,200,21,173,30,138,164,47,53,120,44,88,66,198,48,80,9,108,60,72,32,215,227,160,174,65,117,82,188,8,111,105,245,182,124,71,179,226,145,138,168,49,24,17,150,99,208,220,136,108,54,51,197,128,124,17,240,207,155,135,162,42,214,73,96,168,79,39,152,248,123,169,51,168,184,205,149,180,116,30,163,146,236,228,116,144,4,18,12,47,178,93,37,49,90,196,38,131,208,203,80,173,32,22,36,47,156,168,212,210,241,88,71,120,27,61,202,103,147,162,69,112,105,49,168,208,68,70,124,100,228,133,220,69,184,230,215,176,234,219,82,240,217,207,222,135,50,93,76,100,13,69,104,204,92,39,103,123,152,221,203,39,124,243,178,42,254,175,0,85,45,104,154,186,101,188,231,52,165,144,235,64,244,3,152,86,182,17,8,125,198,26,23,52,243,104,158,114,184,235,72,202,214,46,203,34,11,230,138,200,92,191,253,245,129,150,52,152,175,147,249,2,68,118,241,169,142,82,48,194,180,206,242,240,6,129,10,232,149,65,187,152,158,118,241,133,198,53,44,181,232,101,29,80,17,66,172,52,206,106,175,97,44,223,20,14,255,75,210,20,168,10,109,68,169,3,127,245,206,68,41,182,111,103,72,138,160,36,199,199,228,184,91,112,150,44,82,97,73,113,11,154,211,32,125,182,71,93,52,114,208,212,26,121,72,89,75,82,94,68,154,57,124,160,15,75,129,73,15,110,41,207,151,134,150,38,206,149,94,221,112,181,212,178,128,145,57,216,224,122,115,17,63,20,207,37,102,144,105,222,77,164,177,230,175,107,202,43,20,132,65,197,120,219,71,7,220,56,16,57,185,26,0,201,65,120,78,239,235,237,101,81,102,81,213,81,0,249,28,113,12,154,104,232,135,164,249,184,250,250,231,167,37,113,196,178,250,250,151,167,229,156,252,34,85,54,111,63,175,190,254,245,201,148,186,95,124,189,210,120,114,235,64,1,135,175,81,36,141,23,7,26,36,229,84,124,229,2,167,1,200,51,149,236,41,119,87,208,164,69,0,123,35,1,236,133,252,137,0,227,11,224,28,157,184,83,159,58,102,24,98,52,22,237,163,240,29,229,69,93,198,20,123,17,176,159,165,18,200,96,110,179,36,243,206,10,60,4,105,118,42,231,95,200,60,20,102,0,208,240,190,80,188,44,150,68,174,98,9,160,187,115,159,64,117,32,186,248,194,120,5,196,52,160,141,1,128,13,24,24,128,26,149,52,129,80,219,70,160,230,46,73,81,87,178,134,215,133,163,116,109,199,238,22,157,16,134,43,172,72,66,55,81,157,74,176,93,144,159,127,110,109,198,222,170,140,233,157,32,215,199,173,61,45,24,36,170,203,179,65,254,129,62,164,200,212,140,45,246,94,94,52,123,193,93,12,203,66,115,223,143,221,93,215,242,133,181,102,212,144,21,244,106,176,207,28,12,149,174,185,195,122,67,69,216,22,55,243,22,202,63,169,236,205,12,16,255,168,105,233,2,188,47,130,128,187,116,66,133,22,19,204,62,77,50,150,191,99,219,135,138,235,38,132,20,135,148,10,172,13,57,1,195,252,94,44,168,34,235,154,159,166,159,163,61,191,165,216,241,180,84,136,51,78,147,68,14,52,194,181,255,171,220,179,249,245,146,165,21,246,103,97,84,128,207,82,209,242,237,175,172,122,104,130,58,15,228,203,87,69,6,21,9,227,69,254,126,191,163,161,200,0,52,144,76,12,71,106,121,20,182,210,124,219,203,133,205,33,27,232,245,202,152,244,23,127,116,53,136,180,246,103,16,235,44,160,50,152,128,85,52,91,144,21,84,200,216,40,134,245,112,59,137,17,204,142,101,126,110,132,69,19,214,208,231,251,130,228,152,181,181,108,117,89,198,164,74,100,160,138,150,237,33,198,184,211,28,198,144,151,158,47,151,172,228,85,176,24,220,83,147,115,44,200,161,141,93,147,92,208,129,37,163,184,241,34,19,178,161,163,222,73,211,143,86,168,213,7,218,93,174,4,82,217,179,195,247,229,94,183,208,130,222,181,67,72,176,115,133,7,42,246,238,240,205,117,157,221,67,236,81,17,106,6,120,103,188,198,138,160,168,204,162,96,49,10,215,55,237,244,192,92,65,35,115,15,210,202,61,182,125,56,47,44,106,204,252,6,228,52,217,243,201,193,74,62,212,172,15,21,75,197,201,70,216,82,226,138,148,227,146,75,139,154,180,195,183,229,185,218,99,127,234,127,83,243,135,70,119,16,107,176,126,109,242,166,166,152,117,202,24,149,41,13,247,182,255,165,167,255,219,244,185,255,97,197,61,204,142,87,4,34,64,73,51,110,132,128,181,87,143,24,208,134,253,162,176,245,214,195,130,229,48,54,85,167,248,232,244,5,132,174,100,55,93,164,243,87,69,66,123,138,75,68,229,90,140,84,161,84,78,235,216,75,111,89,5,98,119,139,137,78,149,137,65,112,177,144,125,116,187,58,53,224,205,45,82,69,143,208,44,80,9,212,17,146,59,105,22,146,109,127,193,58,161,173,100,53,135,219,142,233,35,43,43,224,130,152,189,148,86,225,248,216,159,213,42,245,34,120,76,74,42,91,52,27,28,62,17,58,101,194,110,32,39,54,53,23,237,26,248,56,4,149,202,42,141,30,158,216,173,113,232,128,32,234,173,187,212,0,129,35,234,108,14,87,83,96,232,166,176,190,98,211,101,2,56,52,167,137,54,149,234,72,26,77,28,79,127,19,193,79,118,53,207,246,87,250,100,53,112,18,0,163,107,163,251,53,138,138,209,11,66,226,0,159,170,93,148,4,191,167,226,28,183,195,238,121,172,112,84,153,221,181,231,155,163,70,103,164,87,194,102,87,174,213,218,89,189,211,217,235,148,57,157,170,254,117,209,224,14,1,191,139,14,201,6,181,125,39,58,231,162,150,103,137,93,190,67,253,190,131,116,163,46,233,93,93,166,118,5,47,122,106,141,185,216,175,177,4,25,104,189,217,141,193,62,118,175,11,139,91,178,41,234,60,153,91,37,141,89,19,232,193,234,105,74,7,106,160,247,164,215,177,251,91,109,96,147,116,38,116,164,172,156,89,247,103,193,40,240,111,96,55,104,16,136,33,128,27,41,36,247,140,176,91,64,190,70,214,100,240,26,45,157,191,75,198,247,123,19,190,206,102,175,138,123,105,68,57,157,219,233,143,139,51,70,103,23,68,238,247,18,224,39,240,154,178,135,53,242,219,111,150,61,191,137,122,135,66,153,96,237,194,166,141,125,27,130,253,28,31,53,168,14,156,126,150,7,243,6,187,142,206,81,64,123,172,96,29,37,116,251,222,104,49,122,222,11,243,12,97,84,39,106,1,169,15,252,101,233,162,111,22,46,61,247,49,210,76,240,181,40,177,201,225,116,40,201,103,40,155,137,16,30,54,236,162,60,33,176,5,108,219,25,45,75,123,165,174,191,84,229,254,91,154,43,144,47,86,241,3,9,46,190,196,116,39,220,171,189,180,225,61,35,112,215,119,43,28,183,5,247,156,102,142,204,206,188,71,176,146,11,78,44,63,198,230,46,138,112,147,70,91,194,218,104,174,250,30,13,49,243,140,85,241,131,135,171,113,145,161,187,107,147,156,116,128,42,82,91,201,140,88,206,225,231,91,58,142,109,136,215,39,125,78,6,237,138,94,155,85,240,135,57,216,40,217,226,64,146,193,72,82,21,66,0,16,117,26,56,33,95,155,233,79,115,43,71,240,202,27,216,106,47,137,61,178,136,48,120,238,187,41,54,32,101,45,134,13,212,41,154,94,87,210,210,32,248,137,118,12,131,252,241,129,254,56,168,23,167,130,5,89,142,37,44,118,107,93,226,81,79,126,233,15,134,158,182,131,24,210,94,86,235,228,102,45,118,74,242,61,39,24,152,235,168,185,100,215,180,213,14,137,156,228,156,92,56,73,15,166,61,183,162,119,111,103,60,114,174,39,95,52,48,89,76,51,80,213,127,226,217,205,56,49,28,189,232,45,76,251,106,71,173,136,231,33,200,72,67,189,173,22,6,65,87,169,27,97,23,176,54,255,99,165,18,180,113,113,53,215,198,76,174,59,217,178,195,179,186,7,229,109,95,180,226,113,253,187,155,98,246,238,7,227,134,220,139,220,8,97,185,52,68,188,224,249,17,140,17,140,196,62,191,138,237,219,96,227,189,162,113,152,72,24,223,165,209,158,60,98,156,108,64,67,196,49,86,120,33,227,160,115,47,201,4,145,134,141,185,31,24,70,64,196,98,199,193,145,230,234,169,115,16,119,46,231,200,72,239,239,88,252,31,164,237,182,26,195,75,10,33,94,29,22,8,11,2,215,60,63,11,108,170,234,187,204,116,76,91,108,59,199,122,140,18,146,145,20,65,242,167,160,162,189,188,49,100,54,178,77,214,90,14,211,225,92,134,9,113,209,115,162,145,176,137,214,49,116,207,202,189,133,103,78,182,47,41,139,240,47,185,215,33,191,5,58,97,47,12,124,107,210,69,42,217,162,214,87,43,49,73,175,157,171,85,78,73,44,181,218,83,45,240,206,77,172,190,62,229,247,190,71,106,224,49,239,148,241,200,33,192,143,113,144,193,85,235,45,198,19,149,88,30,3,227,86,1,187,67,121,106,165,63,25,87,85,59,17,82,170,160,241,78,148,36,134,197,69,107,73,38,250,65,232,20,248,167,144,27,85,164,204,245,111,5,203,3,60,185,94,138,113,250,192,105,134,15,120,154,126,1,84,130,143,130,31,205,62,196,57,185,122,240,81,70,52,220,99,34,82,229,100,49,192,48,175,12,115,231,8,208,54,175,115,31,83,205,170,178,162,110,232,143,168,250,185,205,104,189,140,38,63,114,37,218,57,23,30,242,244,203,20,98,94,107,164,207,114,237,111,116,83,177,180,222,183,244,208,73,142,249,157,101,43,252,65,93,90,156,40,86,127,243,78,190,181,95,194,59,248,239,191,179,19,162,177,247,51,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNewContactNameLocalizableStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNewContactNameLocalizableStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6ba8ceef-adcd-4763-8a4a-dd632777ed25"),
				Name = "NewContactNameLocalizableString",
				CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949"),
				CreatedInSchemaUId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74"),
				ModifiedInSchemaUId = new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6696f936-fc7d-4f49-8def-bcea193b8c74"));
		}

		#endregion

	}

	#endregion

}
