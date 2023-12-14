﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GeneratedEntityDataSaverSchema

	/// <exclude/>
	public class GeneratedEntityDataSaverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GeneratedEntityDataSaverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GeneratedEntityDataSaverSchema(GeneratedEntityDataSaverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("678673e6-2668-4246-813e-89c3c779f1e2");
			Name = "GeneratedEntityDataSaver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5931fdb4-cda3-48d2-808d-e41a5d931036");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,219,110,219,56,16,125,118,129,254,3,139,5,10,9,16,244,1,185,1,77,210,164,198,166,221,96,157,246,165,40,22,140,52,118,216,200,146,151,164,28,24,11,255,251,14,111,34,69,73,142,31,98,4,177,76,14,103,206,220,206,80,53,93,131,216,208,2,200,3,112,78,69,179,148,249,85,83,47,217,170,229,84,178,166,206,111,161,254,52,127,255,238,191,247,239,102,173,96,245,138,44,118,66,194,250,52,250,141,167,170,10,10,117,68,168,51,192,89,49,144,185,99,245,191,126,49,180,200,97,106,61,255,92,75,38,25,136,73,129,27,90,200,134,79,72,124,174,17,200,211,26,106,153,207,107,9,124,137,190,10,227,20,138,227,129,77,251,88,177,130,48,183,73,230,26,61,149,80,106,203,187,107,42,233,130,110,129,163,176,138,194,108,219,176,146,168,21,181,147,220,49,33,207,180,62,47,126,65,74,252,159,145,120,239,130,128,117,38,85,88,247,26,192,207,107,88,210,182,146,151,172,46,17,123,34,119,27,104,150,201,36,140,52,253,229,97,23,21,21,130,76,137,146,147,215,189,217,112,182,197,109,171,233,174,105,158,219,205,23,42,158,240,236,53,211,249,164,124,119,150,8,201,85,96,141,146,111,88,53,25,177,75,215,76,108,42,186,251,65,171,22,210,140,220,182,172,188,80,138,181,118,227,226,168,17,44,152,118,93,139,239,27,140,21,168,72,161,69,29,176,3,182,204,153,222,210,223,176,12,5,149,181,153,194,64,230,229,56,196,1,184,63,56,172,208,77,114,195,160,42,197,9,185,55,96,251,200,57,208,178,169,171,29,249,46,128,99,135,212,166,214,201,63,109,239,247,169,85,9,117,105,180,246,77,160,32,66,106,85,189,42,67,58,135,214,142,201,231,84,182,146,200,108,223,106,74,180,63,179,8,12,57,39,3,116,222,235,8,162,115,84,72,236,251,130,60,54,77,69,30,248,238,22,164,9,186,14,94,210,60,254,70,85,100,229,96,234,213,140,4,53,110,164,73,161,191,178,176,160,170,238,49,211,104,103,77,43,137,85,184,213,169,177,110,232,31,8,190,110,171,74,67,158,137,23,38,139,39,146,24,173,249,3,182,136,19,158,21,84,192,16,128,18,201,49,124,240,192,214,112,114,148,228,235,82,129,174,25,91,146,164,31,6,194,4,113,22,21,1,232,135,31,161,99,129,111,189,253,83,183,203,65,182,188,38,88,34,221,218,62,176,231,180,231,152,152,123,202,5,36,182,87,210,56,33,42,180,3,44,233,1,28,199,64,120,196,38,120,62,125,53,74,38,229,97,156,124,230,115,83,82,166,152,92,58,177,133,129,67,93,64,216,200,227,158,165,153,195,169,171,71,55,186,209,62,47,199,220,115,123,199,187,103,24,100,86,26,82,118,94,56,125,125,52,78,195,64,169,81,105,151,151,180,18,16,182,158,107,181,110,144,248,102,79,162,73,98,6,134,126,60,52,78,108,84,198,155,109,146,111,141,140,95,112,241,11,76,40,135,187,231,243,206,94,126,195,184,144,127,113,59,186,18,202,156,200,5,113,207,185,202,35,57,63,15,92,200,125,130,83,19,40,219,69,222,132,233,250,46,147,38,132,97,80,173,32,56,72,17,231,89,19,139,226,9,214,244,43,173,233,10,56,142,123,105,150,47,181,237,100,20,81,22,171,178,16,117,141,225,223,185,174,182,252,27,188,168,239,196,238,26,85,249,2,36,198,34,96,74,17,9,224,80,89,227,32,13,36,80,33,179,117,105,199,212,198,200,132,211,170,199,130,75,188,237,80,69,131,127,130,217,189,167,140,159,153,195,153,101,210,11,242,188,197,203,76,24,244,16,85,23,88,107,178,232,6,42,90,122,222,230,168,217,22,245,20,165,155,38,112,91,86,249,160,32,80,86,213,2,126,117,101,224,77,217,200,232,228,59,165,81,222,103,69,131,250,235,174,197,246,254,196,112,40,33,110,75,123,110,234,132,213,63,152,50,222,72,88,43,214,73,24,46,185,10,206,205,106,224,114,93,218,130,26,250,166,161,142,41,139,29,141,61,237,232,200,87,86,232,235,80,101,102,221,10,13,91,98,157,139,251,94,73,89,12,31,63,146,96,144,42,72,227,68,190,48,12,236,161,142,23,168,99,234,109,72,137,251,65,222,142,50,105,168,202,155,140,41,42,255,84,150,201,84,255,250,44,184,231,241,209,194,74,123,79,196,143,3,239,106,40,77,123,21,183,239,53,57,82,117,162,217,60,96,175,177,152,124,136,146,236,203,241,231,20,246,17,53,233,175,128,34,246,83,243,195,198,70,91,176,204,115,44,223,79,220,206,28,236,142,110,182,148,219,237,171,229,74,145,203,212,224,208,1,249,48,53,237,59,21,121,116,103,247,27,209,187,196,161,17,63,78,16,150,214,160,211,222,221,1,148,122,111,212,158,122,187,97,114,104,130,152,176,216,34,186,1,188,201,222,240,102,125,125,25,68,68,189,172,152,202,122,205,195,55,227,44,111,252,106,148,153,143,33,175,113,136,199,51,87,151,215,211,254,201,184,209,194,234,119,239,82,95,65,62,53,229,248,107,212,155,188,162,119,111,35,60,104,14,53,144,225,37,104,28,55,231,189,88,208,113,161,240,160,31,221,201,174,207,226,187,223,42,250,141,157,167,64,119,225,143,174,142,145,120,230,111,135,189,121,56,104,222,240,118,53,194,38,67,214,8,168,226,192,27,165,94,213,255,212,231,127,23,178,218,151,105,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("678673e6-2668-4246-813e-89c3c779f1e2"));
		}

		#endregion

	}

	#endregion

}

