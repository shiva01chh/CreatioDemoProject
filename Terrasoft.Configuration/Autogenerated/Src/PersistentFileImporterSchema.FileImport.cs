﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PersistentFileImporterSchema

	/// <exclude/>
	public class PersistentFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PersistentFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PersistentFileImporterSchema(PersistentFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebe6b7f5-a56a-4b4c-b200-113925999bd8");
			Name = "PersistentFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,91,111,219,54,20,126,118,129,254,7,214,123,145,1,67,121,79,99,23,169,155,116,6,146,52,200,101,125,24,134,130,145,104,91,171,68,9,36,149,11,138,252,247,29,94,44,81,20,169,216,93,86,172,40,18,155,60,60,215,143,31,15,25,138,11,194,43,156,16,116,67,24,195,188,92,137,120,81,210,85,182,174,25,22,89,73,227,211,44,39,203,162,42,153,64,111,223,252,120,251,102,84,243,140,174,209,245,19,23,164,120,239,124,135,181,121,78,18,185,144,199,159,9,37,44,75,122,50,55,27,70,112,10,3,237,140,109,156,145,208,120,124,138,19,81,178,140,240,86,98,157,151,119,56,63,60,92,148,69,1,222,158,149,235,117,80,179,148,128,25,152,59,56,56,64,71,25,221,128,127,34,45,19,148,48,178,154,141,63,98,78,218,112,9,27,31,204,65,246,207,79,100,133,235,92,124,204,168,116,58,18,79,21,41,87,209,242,146,48,158,65,64,84,216,107,38,83,116,1,57,69,51,68,225,23,200,5,196,38,127,129,234,170,190,203,51,176,158,99,206,145,95,16,29,34,215,173,41,10,216,6,141,178,64,163,223,24,89,67,5,208,105,70,242,148,31,162,75,150,221,99,65,84,228,163,165,150,190,196,12,252,131,69,252,138,84,37,207,32,175,79,232,91,22,156,147,25,29,85,90,17,50,58,174,5,94,19,93,147,102,173,61,214,93,3,165,65,223,114,168,15,97,186,8,163,223,8,77,181,171,230,187,241,251,146,149,21,97,2,234,236,248,238,216,247,198,48,48,53,155,15,69,136,62,124,144,54,70,209,144,204,12,45,100,177,76,128,0,113,113,52,224,204,60,186,229,132,193,126,162,122,79,192,39,46,88,45,215,30,179,245,100,242,190,27,86,119,186,46,160,188,104,72,129,12,136,146,7,223,186,104,92,119,22,142,167,142,38,215,182,175,164,158,161,217,92,229,104,228,169,54,228,15,69,190,241,112,206,108,177,121,212,203,135,130,204,153,66,140,170,157,6,143,182,99,62,207,228,252,57,166,160,135,73,205,90,58,26,183,219,226,184,170,0,102,176,153,27,245,33,216,89,105,4,220,169,173,169,5,20,91,240,186,40,48,184,185,29,88,0,137,9,194,81,6,139,48,5,2,45,87,72,82,3,72,18,98,8,197,191,77,199,232,96,30,55,122,15,92,197,71,149,68,146,162,143,153,91,197,185,44,34,74,154,129,248,232,64,73,171,197,134,77,252,70,29,36,162,174,226,137,174,234,33,186,3,174,137,156,57,244,3,61,15,103,238,156,136,77,217,99,154,109,25,239,203,44,69,215,68,88,53,143,220,61,131,170,230,35,216,83,222,220,99,134,44,52,65,169,91,153,216,210,165,88,102,148,173,80,212,145,158,161,84,243,118,212,166,65,77,241,19,90,23,147,173,149,81,215,132,79,54,190,100,4,76,19,103,78,219,125,70,36,231,4,185,230,231,33,77,101,66,56,135,83,178,46,40,119,68,246,115,105,64,145,241,76,253,92,108,48,93,219,147,81,155,197,169,157,223,137,90,245,236,41,221,39,146,131,184,91,177,232,115,13,115,70,1,184,2,56,88,166,219,16,194,148,24,107,109,145,187,48,104,189,31,192,0,118,166,222,108,33,110,167,215,143,34,72,52,111,115,55,224,255,109,149,98,17,72,232,86,225,54,170,169,177,188,13,110,212,139,238,43,52,32,22,176,128,190,162,206,183,115,80,5,26,110,36,177,20,237,231,105,239,152,11,108,32,179,166,3,163,86,237,201,35,208,4,87,205,154,166,51,159,80,212,177,107,153,209,169,210,140,27,47,233,170,220,74,182,241,190,98,192,10,110,220,5,218,127,18,35,239,162,114,143,16,123,85,249,188,165,189,118,236,107,38,54,26,56,67,59,72,6,214,230,26,98,243,104,242,111,162,145,67,181,189,138,49,34,106,70,45,237,3,123,143,36,223,151,92,107,91,200,83,14,186,251,116,23,242,150,124,104,237,11,233,124,79,141,211,144,52,244,183,7,68,98,173,173,157,158,122,14,9,39,61,163,0,159,189,188,80,108,88,249,160,58,174,47,208,159,170,235,145,182,79,210,147,199,132,84,114,32,154,88,236,251,60,208,63,156,60,146,164,134,68,139,13,116,11,53,99,178,217,83,108,129,48,77,145,169,145,156,164,228,81,24,148,104,129,166,119,88,174,90,1,189,52,227,136,214,121,14,196,46,96,91,96,202,149,0,116,95,91,129,7,204,17,209,150,211,64,15,210,96,185,123,239,208,44,105,206,29,67,196,62,9,19,139,53,180,19,89,13,159,83,125,165,177,250,217,212,102,31,204,192,202,198,179,222,230,144,251,78,38,116,123,40,244,45,127,136,59,73,232,105,216,199,149,19,154,134,28,49,8,104,124,177,55,233,14,125,88,41,96,91,145,212,2,224,142,215,93,168,191,89,139,202,123,184,60,103,41,64,193,244,25,199,235,53,88,194,242,158,145,226,74,222,78,53,165,246,166,163,73,115,83,144,219,165,109,73,67,138,92,50,120,255,58,142,43,22,211,98,187,176,214,222,40,242,19,143,5,165,62,124,0,83,253,203,143,57,154,134,187,10,13,148,110,162,166,200,100,212,96,178,100,198,248,195,6,92,139,60,230,223,205,20,69,52,108,27,224,248,94,52,35,111,40,157,173,224,219,250,61,61,207,123,103,122,81,22,149,100,236,125,88,254,249,213,241,179,164,32,73,113,62,120,106,203,235,83,236,200,251,15,105,3,74,103,18,202,169,43,160,14,151,155,242,59,161,241,69,73,221,230,188,191,65,93,108,159,150,44,33,190,150,225,165,158,195,125,251,80,93,21,77,119,108,61,218,107,144,173,193,65,156,199,132,36,137,29,77,12,245,230,199,105,218,51,223,129,157,33,85,87,166,147,93,125,139,30,72,173,47,29,251,92,134,252,230,71,130,61,13,100,104,32,106,40,115,32,87,207,40,193,34,217,160,104,41,72,113,81,138,211,178,166,109,171,50,88,16,40,216,190,137,11,108,159,107,124,223,111,182,118,32,227,23,239,96,61,142,218,249,116,124,233,109,103,103,202,8,188,224,232,108,241,249,209,193,246,147,15,89,134,185,207,113,85,101,116,125,69,120,5,151,20,34,27,253,238,204,142,48,115,134,99,69,236,219,247,192,147,162,18,79,145,121,146,118,21,88,231,213,79,94,57,156,118,223,248,31,47,249,5,224,232,11,211,214,219,14,255,138,172,24,225,27,45,102,162,12,65,216,134,159,162,215,161,252,12,189,42,184,133,181,42,232,22,208,248,135,18,101,7,21,218,206,174,111,118,142,19,227,249,210,52,239,122,4,65,237,169,200,86,25,92,41,61,207,119,221,205,227,205,212,32,10,160,18,239,186,61,130,190,125,157,66,131,81,51,114,66,241,157,60,223,199,183,85,94,226,244,12,179,181,2,246,199,167,197,166,166,223,199,109,145,84,178,247,168,148,41,146,93,182,127,129,168,62,154,204,49,113,6,141,228,145,233,86,212,196,60,178,240,187,130,80,154,86,200,251,242,124,141,31,79,109,161,23,222,232,181,234,142,218,120,73,51,113,85,150,226,58,217,144,2,219,192,111,71,111,135,35,233,42,4,199,126,39,56,29,184,210,251,56,52,64,127,59,50,90,224,111,72,65,98,51,240,180,94,4,229,50,141,197,85,123,7,116,241,232,153,26,96,38,159,162,78,195,52,240,164,168,220,241,41,8,176,91,176,69,10,235,176,43,77,56,81,137,251,132,5,142,254,159,101,50,173,189,92,247,7,206,179,244,215,21,235,103,183,162,119,187,245,194,8,22,168,121,143,251,5,201,53,13,188,143,139,61,93,60,18,242,103,176,35,124,137,36,219,55,195,23,217,178,115,145,179,28,152,105,23,58,183,143,33,104,246,78,74,239,249,212,188,53,126,185,251,27,248,51,144,14,91,196,204,234,47,175,214,187,216,74,187,171,101,7,210,93,108,76,239,205,11,59,166,222,132,57,235,4,186,109,147,162,87,57,154,253,135,163,211,178,95,247,67,208,135,140,89,226,249,67,144,201,223,173,211,57,217,13,181,28,131,255,240,239,31,222,100,85,206,59,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebe6b7f5-a56a-4b4c-b200-113925999bd8"));
		}

		#endregion

	}

	#endregion

}

