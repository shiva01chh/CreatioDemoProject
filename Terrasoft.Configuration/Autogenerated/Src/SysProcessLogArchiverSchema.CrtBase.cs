﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessLogArchiverSchema

	/// <exclude/>
	public class SysProcessLogArchiverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessLogArchiverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessLogArchiverSchema(SysProcessLogArchiverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2d19de-199d-4977-9d50-3cf2588d6d21");
			Name = "SysProcessLogArchiver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("920a417a-9c96-40b0-b7b5-e7da9902441a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,221,111,219,54,16,127,118,129,254,15,132,247,34,3,142,146,180,88,186,54,113,6,127,165,245,144,166,89,147,174,15,195,80,48,18,29,11,149,37,149,164,146,122,69,254,247,29,191,36,82,162,28,7,67,251,144,90,212,125,223,239,142,119,202,240,154,176,2,71,4,93,19,74,49,203,151,60,156,230,217,50,185,45,41,230,73,158,61,127,246,227,249,179,94,201,146,236,22,93,109,24,39,235,227,198,51,208,167,41,137,4,49,11,223,146,140,208,36,170,105,108,177,148,116,157,135,243,140,39,60,33,172,147,96,54,105,233,61,79,178,111,112,8,199,191,80,114,11,234,209,34,227,132,46,193,155,55,104,33,37,110,198,52,90,37,119,132,74,178,162,188,73,147,8,37,134,170,77,212,251,33,9,123,251,251,251,232,132,149,235,53,166,155,83,115,32,201,200,29,97,136,72,54,68,73,148,211,152,133,21,199,190,205,114,151,39,49,210,162,131,129,50,244,65,153,75,178,88,89,236,88,63,77,49,99,111,132,119,151,52,143,8,99,231,249,173,207,254,72,208,249,201,144,199,113,227,83,165,6,242,196,113,198,65,213,37,77,238,48,39,234,125,161,30,80,36,222,35,198,169,8,245,187,132,241,156,110,46,33,169,121,12,42,175,8,231,112,62,205,99,130,70,168,223,180,0,94,41,210,254,113,91,36,196,29,205,200,18,151,41,119,196,206,240,134,129,176,151,7,30,30,109,134,71,207,71,21,252,105,94,130,88,191,41,54,201,35,6,117,137,253,245,96,139,85,160,107,82,46,151,16,118,208,47,243,17,105,199,170,55,62,181,154,219,73,96,37,193,28,244,143,117,214,92,172,84,89,60,75,72,26,119,165,144,18,28,231,89,186,65,159,24,161,144,239,76,149,39,250,82,58,207,199,94,158,217,100,254,157,68,37,184,129,190,196,55,230,119,7,109,34,5,1,228,79,148,87,67,237,221,41,250,130,21,2,175,162,21,89,227,247,184,120,196,33,9,75,90,70,160,75,184,37,161,174,189,82,176,247,2,62,176,172,173,141,29,32,209,180,122,61,203,126,8,112,195,153,94,35,26,64,97,209,135,159,218,161,234,181,124,2,158,140,220,111,11,131,50,164,247,163,153,222,97,27,49,125,244,48,244,80,171,122,174,25,212,179,102,235,226,73,201,26,154,148,163,104,158,58,170,36,215,131,244,235,97,123,102,222,19,190,202,59,177,38,219,156,2,123,242,47,52,58,237,241,159,37,161,27,196,136,184,25,212,239,17,122,75,116,225,3,97,125,105,200,183,1,188,243,84,176,44,195,96,48,20,172,234,80,94,74,87,28,83,62,3,237,193,96,160,50,179,152,77,166,57,244,222,44,134,170,134,204,241,43,169,89,231,103,97,29,5,141,180,15,84,248,66,184,59,242,160,170,91,115,10,253,46,112,51,183,136,101,72,225,1,152,225,193,80,158,209,124,173,53,88,94,107,243,108,155,66,5,49,18,88,104,27,216,121,112,34,91,5,76,97,46,208,205,131,201,167,11,184,189,77,192,239,48,117,92,55,225,24,33,101,96,21,65,162,2,94,75,24,182,107,245,239,250,237,63,50,248,234,13,36,173,92,103,76,28,51,75,192,192,227,165,86,255,52,103,167,41,193,212,137,118,96,187,23,73,245,78,102,207,33,60,186,230,78,5,45,234,67,74,144,130,181,228,137,129,154,19,131,64,21,10,89,178,242,188,11,12,34,153,129,99,136,121,243,121,69,40,113,95,13,165,210,1,32,40,168,131,44,36,168,64,55,104,109,39,76,224,44,35,119,14,152,14,131,79,99,11,35,67,180,176,3,165,109,16,71,118,120,221,98,21,65,234,168,24,101,244,18,198,50,28,173,144,81,167,132,2,6,61,226,123,150,236,80,161,200,1,160,226,208,130,85,107,178,57,100,58,44,188,133,99,7,126,225,231,132,175,222,193,109,206,2,249,55,188,200,207,243,232,235,160,70,193,87,178,81,90,23,162,32,106,86,52,26,53,238,225,223,21,130,222,216,221,116,161,199,25,199,166,63,242,36,11,196,159,235,77,65,32,247,48,247,14,235,137,160,211,38,13,163,15,89,221,107,134,168,213,97,0,76,108,254,173,196,169,19,37,203,11,23,142,142,168,186,51,85,66,20,87,120,137,41,200,129,225,183,153,209,176,98,50,136,164,132,151,52,179,33,177,189,104,149,250,70,247,119,107,15,144,106,145,42,164,254,15,252,139,225,109,235,165,161,77,209,158,52,214,9,103,199,9,235,193,150,233,184,130,228,191,112,90,182,26,196,240,177,81,116,184,117,162,244,122,226,148,102,71,175,181,43,90,84,131,83,183,242,84,69,88,13,7,230,174,168,201,143,27,77,84,232,172,42,65,87,36,11,117,189,3,9,26,201,46,161,223,200,80,168,82,187,206,5,107,224,194,164,150,233,243,79,92,212,215,9,20,91,231,37,174,157,17,41,197,106,201,146,20,106,61,80,142,117,110,26,13,83,140,178,240,19,143,46,242,251,112,28,203,253,34,216,107,11,126,34,172,140,186,159,132,171,45,155,214,176,115,109,242,186,96,99,160,141,137,174,249,193,166,122,143,51,124,11,107,205,90,255,63,106,110,14,225,184,40,236,246,33,23,114,119,98,14,61,2,157,76,105,225,34,36,11,185,145,70,100,178,17,22,217,173,253,105,243,169,181,52,120,55,248,143,82,51,211,151,63,250,38,59,19,207,97,163,134,190,132,110,212,46,199,241,77,42,63,84,120,118,122,121,162,236,103,167,39,251,230,151,181,165,168,110,231,237,117,46,112,118,28,66,90,19,233,79,234,248,15,59,132,77,141,209,117,216,244,212,136,88,65,162,100,153,144,216,244,147,45,193,43,132,69,40,3,171,70,253,186,63,245,79,53,92,45,169,75,56,63,217,151,244,219,216,175,243,254,233,216,24,194,105,78,1,84,218,142,22,183,201,151,189,15,120,179,104,19,160,214,228,220,108,198,102,219,67,198,162,199,231,45,11,4,59,47,39,70,186,189,155,88,146,219,123,136,119,54,180,172,182,152,119,7,65,161,58,35,74,97,88,74,160,234,153,30,18,68,37,86,200,88,153,173,101,27,20,76,220,165,97,219,139,169,115,109,172,174,140,234,226,31,214,247,13,51,55,140,115,91,114,204,75,38,231,64,17,125,41,166,46,19,113,244,182,76,226,160,63,159,189,24,207,95,188,122,181,55,57,154,191,216,155,157,29,30,238,189,126,117,56,217,59,56,56,156,29,29,204,95,191,252,109,122,212,31,88,23,171,51,62,215,139,70,71,98,225,34,45,2,215,114,157,193,158,25,144,251,238,231,130,122,215,172,40,158,82,229,98,102,238,88,91,27,155,142,164,180,116,63,54,203,158,147,37,255,0,35,27,149,35,177,79,22,166,36,227,187,75,148,227,113,155,171,218,179,116,143,107,196,71,209,91,174,169,78,217,160,186,210,233,151,114,46,114,174,167,108,125,90,25,48,206,226,38,39,108,180,133,104,215,2,80,146,251,28,222,125,160,74,128,7,74,53,250,26,82,187,253,186,40,211,52,216,109,2,87,5,226,126,99,214,40,231,0,64,189,118,217,31,180,228,188,117,77,113,198,176,4,135,81,212,179,62,222,232,147,230,71,7,55,167,29,68,254,207,79,187,80,171,15,92,134,210,247,17,192,126,101,86,141,227,182,139,226,163,67,226,243,241,1,69,152,139,93,117,254,61,34,133,236,85,196,252,26,248,130,245,17,250,204,13,142,190,250,226,197,87,52,191,175,249,173,165,213,63,168,180,63,250,195,137,245,239,63,168,57,74,136,132,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2d19de-199d-4977-9d50-3cf2588d6d21"));
		}

		#endregion

	}

	#endregion

}

