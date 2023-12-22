﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportParametersRepositorySchema

	/// <exclude/>
	public class ImportParametersRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportParametersRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportParametersRepositorySchema(ImportParametersRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("138540f3-e1a4-4dff-bbbc-5b6b0f62eaea");
			Name = "ImportParametersRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,111,227,182,18,126,118,129,254,7,194,167,15,52,96,40,231,188,21,73,236,34,23,167,112,145,189,116,237,109,31,138,162,80,36,218,209,169,44,58,20,149,196,93,228,191,119,200,161,36,138,162,108,57,219,237,57,15,205,75,34,138,51,28,206,124,243,113,56,74,22,110,88,190,13,35,70,150,76,136,48,231,43,25,92,241,108,149,172,11,17,202,132,103,193,77,146,178,249,102,203,133,252,250,171,79,95,127,53,40,242,36,91,147,43,190,217,240,236,204,122,22,172,249,20,92,95,58,3,55,97,36,185,72,88,94,143,47,118,185,100,27,247,25,44,72,83,22,169,229,243,224,123,150,49,145,68,173,57,215,161,12,189,131,193,226,33,189,74,19,150,201,214,235,249,187,214,208,109,146,61,180,6,151,236,217,18,126,203,158,36,88,162,92,243,67,110,111,122,157,242,187,48,61,61,69,103,4,183,124,189,134,97,120,15,51,254,37,216,26,236,39,228,42,13,243,252,148,160,11,223,135,2,28,46,153,200,63,176,45,207,19,240,199,78,79,63,57,57,33,231,73,118,15,91,149,49,143,200,201,20,6,127,185,102,171,176,72,229,101,146,197,160,152,202,221,150,241,21,157,119,235,26,141,126,5,185,109,113,151,38,17,137,212,202,123,22,38,96,213,158,183,160,232,147,182,173,218,11,0,35,151,97,38,97,59,239,69,242,24,74,134,239,183,248,64,4,11,99,158,165,59,242,49,103,2,38,103,24,67,242,91,209,120,62,243,202,228,82,40,159,254,150,56,22,45,162,123,182,9,223,194,19,153,144,97,141,198,122,198,240,204,152,201,178,24,45,245,152,45,10,5,62,101,185,118,142,49,28,29,213,237,4,234,236,164,185,145,17,153,76,221,205,129,145,173,221,238,51,238,13,147,247,60,238,242,232,82,25,255,200,132,92,242,119,119,255,5,133,231,203,41,189,219,73,246,203,175,228,49,76,11,54,34,79,128,25,53,241,212,196,91,229,232,96,32,152,44,68,134,115,200,100,66,178,34,77,245,139,193,119,214,223,167,68,1,218,44,17,92,51,48,60,9,211,228,15,86,47,54,203,34,174,192,23,124,92,222,124,11,201,40,23,58,78,20,87,31,233,88,190,52,141,118,221,73,64,202,29,163,115,149,170,31,32,248,76,0,6,34,46,226,145,49,253,49,20,100,91,11,79,90,46,112,117,77,41,42,80,214,1,115,20,155,236,39,101,220,57,250,105,74,135,45,192,140,70,228,59,240,3,123,106,217,74,113,71,131,218,128,0,167,44,88,158,67,188,230,49,24,228,95,238,251,34,137,213,98,241,176,83,135,12,215,172,83,190,134,182,158,151,207,178,98,3,250,244,131,71,229,44,147,137,4,50,245,56,232,54,201,75,47,233,89,187,105,79,23,149,58,135,38,176,37,140,234,101,125,241,166,106,231,100,43,120,4,62,154,199,227,54,0,220,129,145,15,18,63,39,242,254,125,169,228,127,141,143,127,80,96,161,64,123,188,140,204,161,157,87,33,244,88,187,96,178,142,112,165,177,137,53,106,1,169,22,245,18,205,143,5,19,59,52,97,246,188,21,24,27,178,40,73,236,34,139,43,159,120,167,42,126,91,118,241,232,100,170,173,66,153,160,2,71,155,16,47,193,123,57,181,137,116,209,164,209,146,43,71,103,77,243,63,110,99,245,235,10,142,64,201,240,193,69,162,54,27,243,43,105,36,64,84,8,1,21,14,172,40,161,170,210,81,113,14,162,224,10,167,168,19,44,168,230,157,185,26,32,205,216,50,209,135,235,62,5,42,214,77,1,218,12,155,34,83,220,3,117,244,140,247,157,233,35,60,136,20,50,232,240,13,56,118,149,176,248,93,54,28,147,150,227,29,131,71,94,209,203,29,0,175,91,184,242,67,37,253,179,10,59,230,107,48,207,103,15,69,152,210,150,52,248,126,68,194,220,108,208,7,197,5,83,5,171,162,53,252,11,3,167,11,4,229,25,28,116,61,131,54,4,184,28,218,224,140,180,136,201,247,190,206,215,230,91,195,25,56,120,35,248,134,238,11,132,3,206,71,14,152,187,6,179,37,187,10,179,8,254,136,43,242,51,128,108,50,162,141,206,88,203,1,164,212,222,81,137,127,239,198,174,97,131,93,135,199,197,198,49,195,192,18,77,8,102,207,44,42,100,9,86,183,80,201,192,36,29,52,252,171,97,69,199,38,77,64,81,160,35,160,243,76,242,214,158,2,205,146,80,96,32,96,253,48,245,109,198,67,25,96,177,205,23,189,44,238,74,78,175,239,95,233,122,39,71,250,213,189,86,61,238,189,5,149,85,186,70,228,69,12,165,129,91,94,184,168,254,255,36,74,165,43,65,196,77,14,98,200,128,168,47,115,238,67,211,251,206,34,166,73,161,120,14,125,14,249,190,66,212,44,122,52,109,127,30,233,107,105,164,199,35,220,166,230,55,85,180,248,121,124,68,245,209,90,199,167,187,226,246,207,210,92,149,137,37,59,74,184,223,99,142,12,16,146,14,81,14,94,72,20,202,232,158,208,197,67,58,123,142,216,86,223,109,115,235,161,76,50,141,235,148,175,215,80,168,79,200,45,95,191,9,51,112,148,206,132,91,61,76,173,91,251,197,118,11,132,192,68,89,28,106,233,13,152,173,107,98,28,26,212,211,149,58,124,57,123,150,44,203,117,71,8,49,227,155,68,141,2,175,134,229,110,203,2,204,185,218,51,51,33,184,24,183,25,196,88,135,251,10,244,44,106,204,28,55,221,96,102,202,123,193,159,140,239,172,163,230,48,163,153,227,81,115,183,155,159,159,113,164,246,96,142,94,28,223,162,140,61,199,235,160,171,94,112,149,156,245,245,144,175,149,112,208,85,121,93,129,129,191,220,146,12,45,181,230,216,126,40,185,215,120,67,249,90,207,169,253,49,116,14,189,225,184,101,138,205,247,142,253,179,103,184,148,169,203,154,189,190,113,226,2,46,21,41,251,160,239,86,212,115,63,30,19,94,72,226,211,106,22,76,86,173,196,199,245,170,84,53,181,186,59,203,130,45,226,24,143,39,201,54,111,185,188,225,69,22,87,112,167,223,12,63,237,129,214,11,121,130,91,188,235,17,242,201,25,120,25,246,135,128,78,18,83,188,28,117,242,23,88,43,77,122,92,176,14,30,148,255,156,27,78,105,55,64,239,250,235,235,190,241,180,252,83,222,113,199,196,215,0,81,120,180,157,249,202,40,151,157,134,74,198,108,98,127,88,157,181,191,136,39,234,237,207,175,19,77,230,161,216,157,99,75,28,242,94,183,17,166,36,186,15,179,53,139,241,34,81,58,161,78,88,72,86,48,52,101,27,168,121,152,149,178,205,187,143,181,246,101,145,254,94,102,150,114,51,19,225,93,106,26,57,228,119,182,171,63,195,124,121,187,246,31,3,150,117,173,238,158,98,248,139,52,165,237,35,160,147,253,13,15,226,172,50,114,245,26,62,246,29,5,75,174,58,106,181,213,120,191,217,107,183,229,51,229,212,118,103,84,27,111,55,62,179,136,43,87,41,28,249,182,115,168,151,80,223,254,247,144,180,186,243,85,103,93,95,1,127,39,226,56,113,167,81,209,87,216,238,99,180,154,31,229,189,21,230,89,157,199,190,149,80,112,145,247,169,148,230,224,101,241,3,79,90,171,106,5,254,238,197,32,120,231,51,178,81,109,245,13,82,85,162,236,217,114,0,105,70,149,234,183,133,74,6,35,8,156,127,156,119,65,158,203,238,234,167,132,167,150,210,213,143,143,175,33,70,56,205,121,137,228,137,0,126,117,38,54,190,19,140,2,52,124,201,235,92,163,82,245,60,100,96,53,146,205,72,43,169,29,6,234,76,228,133,132,211,101,163,146,85,237,8,159,14,118,193,30,26,190,51,217,123,184,156,116,53,162,163,76,131,177,15,19,216,21,110,149,45,202,110,245,73,165,127,110,180,111,9,78,117,220,220,95,121,182,234,47,227,84,95,89,238,76,60,133,167,103,50,203,242,66,176,235,203,122,136,142,170,58,213,86,82,127,6,154,56,48,193,97,90,47,163,20,16,3,228,100,69,104,45,27,168,95,212,126,95,34,207,154,131,31,55,33,178,250,32,179,93,102,238,120,166,68,54,191,94,26,237,111,72,186,222,199,217,29,231,169,238,58,230,141,132,46,239,77,7,129,213,7,4,85,94,108,233,127,202,135,18,11,185,69,71,121,185,234,176,156,229,237,200,106,158,203,171,39,156,105,209,162,247,187,60,74,233,143,56,149,140,34,69,28,41,201,208,232,50,160,106,24,87,191,54,40,244,191,60,174,65,121,144,126,22,81,152,134,226,92,69,105,122,108,57,135,222,236,211,150,245,148,176,29,109,93,63,33,216,181,171,21,69,79,1,43,69,245,165,94,167,133,91,176,170,255,15,248,119,163,157,83,181,41,59,90,227,126,139,202,86,210,145,38,117,117,160,94,125,161,168,63,49,250,60,63,38,205,207,213,127,109,36,234,3,217,179,235,122,205,191,59,26,199,153,213,55,34,121,177,217,192,121,59,45,7,176,253,67,86,192,5,100,5,44,2,39,64,80,77,62,113,103,159,107,26,32,25,88,49,105,29,131,83,220,34,49,9,79,230,113,112,126,162,5,106,121,86,245,37,35,193,86,147,161,183,97,49,156,46,213,69,36,83,223,119,129,166,185,36,43,245,222,160,194,254,71,2,221,185,112,236,128,69,171,85,58,58,119,138,249,250,167,120,223,94,196,62,140,85,231,82,21,75,253,31,78,84,157,65,135,144,21,227,127,148,209,36,147,245,113,251,101,122,62,206,70,202,158,79,3,70,246,215,33,51,102,15,233,17,251,231,79,159,98,216,239,175,40,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("138540f3-e1a4-4dff-bbbc-5b6b0f62eaea"));
		}

		#endregion

	}

	#endregion

}

