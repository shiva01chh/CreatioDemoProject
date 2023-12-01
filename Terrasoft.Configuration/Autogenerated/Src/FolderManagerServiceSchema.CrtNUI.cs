﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FolderManagerServiceSchema

	/// <exclude/>
	public class FolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FolderManagerServiceSchema(FolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2bec5c05-e607-4c38-b513-0c2f1b93db25");
			Name = "FolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,91,111,219,54,20,126,214,128,253,7,194,123,145,1,67,126,79,98,23,94,234,100,6,150,52,72,210,237,33,8,6,89,58,182,133,234,226,146,84,82,175,200,127,223,225,77,22,41,74,14,138,62,173,15,169,73,158,235,119,46,60,84,25,23,192,246,113,2,228,17,40,141,89,181,225,209,101,85,110,178,109,77,99,158,85,101,116,85,229,41,208,155,184,140,183,64,31,128,190,100,72,252,253,215,95,130,154,101,229,150,60,28,24,135,226,220,89,163,140,60,135,68,8,96,209,53,148,64,179,164,67,243,103,86,126,237,108,222,215,37,207,10,136,80,83,22,231,217,191,210,136,14,149,182,227,166,74,33,143,22,168,231,197,161,107,123,83,20,125,39,93,63,217,162,76,175,105,85,239,153,159,131,66,223,126,116,21,39,188,162,25,244,114,70,119,180,74,128,245,159,183,189,66,227,56,69,137,62,226,191,97,125,116,11,207,127,163,176,69,23,72,146,199,140,145,143,144,3,7,229,206,61,6,23,67,0,146,236,233,99,204,99,35,247,25,55,246,245,58,207,146,1,54,114,70,44,144,180,129,205,177,72,3,35,197,199,31,142,201,119,242,118,138,104,249,45,129,189,16,79,96,124,70,214,49,110,65,195,40,141,190,129,98,13,52,188,197,100,37,51,50,42,1,210,207,251,52,70,73,241,11,66,206,65,133,108,52,126,110,233,90,87,85,78,110,123,72,81,252,22,248,57,97,226,143,80,244,166,144,132,50,85,96,90,192,94,10,132,206,136,175,20,36,221,116,58,37,23,172,46,138,152,30,230,122,109,74,101,83,81,242,90,209,47,228,53,227,59,178,149,218,13,203,180,197,243,180,96,251,91,224,24,215,61,98,189,206,242,140,31,238,225,107,157,81,40,160,228,44,108,47,68,138,32,18,39,88,4,85,164,55,210,113,39,226,222,202,62,35,191,99,0,244,106,66,86,62,162,137,41,67,145,136,15,152,209,34,53,56,98,28,173,238,33,78,63,149,249,161,189,139,122,101,162,24,52,175,50,200,83,132,243,142,138,178,85,8,6,123,181,208,70,97,214,189,0,229,64,201,63,27,123,227,188,77,124,77,179,244,51,23,126,99,217,105,227,254,136,203,52,23,140,219,246,161,222,85,245,226,134,249,24,103,204,71,78,107,81,199,104,158,196,74,91,167,112,243,129,17,154,156,197,148,213,89,52,72,254,153,73,111,74,213,29,73,109,45,141,44,103,87,21,195,144,229,216,90,246,136,15,122,218,131,107,203,181,5,221,214,34,63,136,109,138,77,65,102,115,82,194,171,143,47,28,217,230,141,38,142,164,241,9,152,109,99,43,142,92,144,26,115,245,178,147,8,238,26,237,115,115,131,144,15,31,72,216,217,157,169,250,85,253,249,128,215,17,191,112,132,205,195,33,40,198,227,115,219,180,161,180,187,246,100,157,180,213,151,142,218,96,239,145,199,234,1,189,239,240,96,40,34,55,192,119,85,171,38,137,157,60,171,85,153,228,117,10,75,188,155,133,238,85,169,0,92,126,131,164,70,21,228,146,2,210,25,42,189,27,42,162,133,52,232,46,166,216,189,17,107,70,246,205,207,49,34,35,244,4,29,87,79,105,28,246,119,210,159,186,71,229,152,182,45,75,12,66,198,229,151,42,75,137,210,6,162,139,101,137,147,51,250,50,15,175,107,36,68,117,234,120,149,78,136,220,65,209,168,239,184,137,150,136,75,28,132,63,135,135,100,7,69,44,174,179,177,186,67,3,45,109,89,110,179,18,200,222,90,205,156,242,138,44,98,153,155,193,202,236,153,136,236,157,245,140,216,82,35,135,65,137,249,152,73,13,120,37,93,40,131,141,225,243,35,86,127,197,121,13,12,5,10,140,7,24,148,99,193,211,232,246,8,206,232,89,241,153,117,244,88,61,72,242,112,60,49,228,119,22,114,146,195,6,211,199,180,116,112,149,108,46,216,146,248,77,121,234,224,19,233,80,135,35,111,176,219,185,162,252,87,61,225,68,87,62,150,85,235,46,113,135,5,185,113,149,229,57,34,39,84,171,25,129,172,15,36,61,148,113,209,108,108,178,28,181,55,18,166,174,136,11,105,33,65,22,152,141,90,24,143,230,24,0,162,154,34,201,210,139,169,164,243,179,217,64,143,230,42,22,239,100,118,225,30,205,85,84,8,147,91,146,170,45,64,223,146,178,210,52,210,74,243,79,170,41,39,134,145,254,21,90,130,93,153,29,97,237,56,123,67,135,47,22,83,90,132,239,98,78,18,165,135,53,241,211,240,241,74,71,56,250,31,5,81,10,160,192,107,90,178,185,24,29,155,199,129,156,119,41,176,58,231,164,218,16,144,5,38,170,2,23,26,175,139,169,225,108,229,131,37,68,199,76,84,252,177,44,127,82,126,112,122,48,77,234,61,141,254,7,210,38,8,148,127,178,85,182,253,10,245,249,27,73,98,158,236,136,245,6,50,70,245,240,154,227,224,161,78,100,210,205,200,38,206,25,232,94,24,44,41,173,232,170,220,84,186,69,31,215,134,49,184,65,54,156,73,69,139,140,244,111,195,29,32,6,201,151,71,42,62,9,136,227,227,82,19,188,169,255,117,27,125,59,85,29,139,52,197,71,86,174,6,39,208,183,185,40,5,149,142,239,45,5,86,213,52,129,118,90,14,102,113,10,140,103,165,122,179,190,151,71,133,240,178,202,235,162,20,228,205,200,33,247,79,48,111,154,106,27,38,147,61,156,169,71,181,77,171,179,127,240,189,221,51,20,133,58,209,93,144,154,10,240,194,49,33,50,130,86,145,244,121,175,11,108,227,150,150,229,143,73,92,175,182,232,114,7,201,23,51,135,221,214,121,254,137,46,139,61,63,132,2,153,106,19,122,185,244,232,29,184,158,157,148,230,50,24,65,195,110,158,20,59,204,110,148,24,152,108,113,150,32,67,210,176,180,129,60,105,134,13,187,25,93,131,151,152,138,134,171,114,101,102,102,224,222,116,50,77,72,176,225,216,43,138,79,121,214,76,120,190,199,140,24,207,239,186,212,87,180,42,174,148,89,29,240,39,78,158,180,237,205,84,74,183,158,7,202,112,255,219,33,108,154,163,59,240,33,155,63,203,219,228,125,129,107,102,197,222,252,87,82,76,191,23,45,87,255,108,102,202,198,163,221,241,1,231,125,21,117,60,214,97,48,145,139,238,171,87,182,216,108,84,203,156,25,121,205,132,234,9,85,35,65,94,24,70,80,123,114,25,248,254,102,109,246,183,18,209,0,158,158,81,120,82,209,148,153,56,120,5,90,6,72,76,82,73,38,190,89,162,51,190,167,109,91,142,38,155,135,10,244,31,254,10,161,81,105,93,243,78,113,120,141,55,151,100,239,151,195,153,237,77,19,151,46,100,6,43,115,183,30,47,108,244,5,236,123,116,120,16,56,105,118,120,164,118,231,130,238,125,221,151,40,65,224,121,204,116,63,140,202,29,252,247,31,151,6,194,95,60,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2bec5c05-e607-4c38-b513-0c2f1b93db25"));
		}

		#endregion

	}

	#endregion

}
