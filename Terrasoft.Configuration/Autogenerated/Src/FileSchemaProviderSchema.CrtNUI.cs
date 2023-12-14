﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileSchemaProviderSchema

	/// <exclude/>
	public class FileSchemaProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileSchemaProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileSchemaProviderSchema(FileSchemaProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21114814-b450-4a7a-a713-5a6d91d22e20");
			Name = "FileSchemaProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,219,110,219,56,16,125,118,129,254,3,235,46,10,9,240,42,251,28,199,54,26,111,210,26,200,13,77,139,62,20,69,65,75,35,155,187,50,229,165,168,22,222,32,255,190,195,139,110,20,101,103,251,208,68,195,51,51,135,115,227,132,211,29,20,123,26,3,249,12,66,208,34,79,101,180,204,121,202,54,165,160,146,229,252,245,171,167,215,175,70,101,193,248,134,60,30,10,9,187,169,243,141,248,44,131,88,129,139,232,3,112,16,44,62,138,185,95,255,133,191,222,230,9,100,61,220,13,227,255,244,132,159,74,46,217,14,162,71,52,77,51,246,175,38,214,160,218,204,119,187,161,19,1,67,242,232,10,205,75,6,197,32,224,154,198,50,23,6,129,152,183,2,54,200,128,44,51,90,20,231,228,154,101,240,24,111,97,71,87,60,205,53,226,219,159,84,82,140,163,20,168,249,29,5,251,114,157,177,152,196,74,163,167,48,122,210,74,181,221,7,145,239,65,40,70,231,228,65,43,154,115,109,245,22,118,107,16,193,29,38,142,204,200,152,227,207,113,168,92,84,62,10,41,212,21,20,96,58,172,23,211,189,138,162,87,117,105,206,142,104,11,136,115,145,96,82,203,29,191,27,98,240,201,1,157,180,103,98,114,194,94,3,178,246,222,2,79,76,224,244,247,179,73,81,87,56,152,49,12,245,79,150,128,208,168,179,179,51,114,193,248,22,176,28,146,28,179,37,32,157,141,87,125,244,248,108,174,147,12,41,45,51,121,201,120,130,252,2,121,216,67,158,6,30,124,56,33,246,166,42,93,136,241,64,194,35,101,82,129,200,57,241,88,239,23,208,53,131,44,81,197,35,216,79,42,193,28,238,205,7,17,64,147,156,103,135,42,172,63,210,218,98,149,14,229,99,60,245,42,125,41,64,96,97,115,211,204,228,71,217,249,246,167,164,9,63,182,191,20,165,106,38,167,180,237,197,251,151,11,28,135,93,127,33,81,211,105,52,114,104,224,29,122,188,70,182,50,6,201,117,186,206,23,56,61,38,14,134,222,45,229,116,131,9,241,201,102,115,55,44,145,7,118,34,84,183,32,183,249,96,14,215,121,158,145,229,22,226,191,63,210,226,129,10,224,210,24,15,62,148,44,33,133,254,253,203,42,153,16,253,189,111,33,80,90,69,173,25,202,23,10,54,39,91,6,130,138,120,123,192,0,122,40,227,116,183,70,62,86,192,160,118,21,234,24,143,4,200,82,240,198,18,14,109,229,35,240,153,187,198,198,89,225,128,191,60,40,253,232,61,63,4,12,63,85,0,213,207,69,132,98,50,155,245,232,183,179,89,69,68,223,179,230,135,168,192,150,119,81,87,118,136,134,125,213,226,203,142,186,170,161,166,52,131,150,17,69,106,218,245,221,157,231,138,69,87,18,172,58,182,149,221,139,182,207,185,37,89,229,197,50,239,245,165,65,69,118,246,53,192,184,61,98,27,177,59,84,205,33,75,73,224,90,174,231,18,62,184,138,122,88,49,25,53,166,137,11,138,204,60,174,51,63,114,253,161,70,215,145,193,61,19,200,10,168,28,156,84,194,236,36,197,87,38,183,129,51,168,66,99,96,180,112,21,30,203,181,137,64,240,199,196,61,187,1,190,145,91,242,187,59,245,236,65,101,243,188,103,83,82,33,143,210,56,198,227,184,179,158,183,169,39,246,191,141,159,220,80,61,175,146,177,13,169,254,191,93,82,45,139,168,252,210,130,199,233,76,121,12,182,232,157,123,250,202,71,151,78,153,101,97,147,78,221,254,74,54,68,205,44,4,164,189,66,116,146,174,199,66,27,122,121,120,160,24,119,247,250,45,66,93,91,61,74,189,10,51,105,137,174,118,123,121,232,20,239,255,160,211,100,39,124,97,93,183,93,96,243,164,128,83,45,182,94,22,173,174,126,110,15,82,14,191,220,249,98,61,120,187,101,98,206,236,6,215,204,12,43,176,199,238,38,85,147,107,137,22,139,78,152,58,154,203,118,101,182,175,101,174,225,234,154,91,249,166,246,234,138,151,59,124,41,214,25,92,116,111,57,87,99,244,125,150,53,210,34,168,82,234,123,211,144,72,103,250,187,93,218,121,157,142,12,124,244,98,110,26,125,221,98,130,236,228,87,79,146,141,164,242,245,166,247,38,145,119,239,252,239,113,163,53,233,189,99,149,39,251,68,246,222,141,46,147,180,91,5,200,200,145,188,49,133,175,168,116,79,34,55,107,209,170,184,203,229,29,130,239,133,206,80,16,134,47,89,145,154,165,164,181,186,213,91,179,48,91,179,222,141,171,133,238,134,21,114,32,179,77,86,103,222,100,71,159,115,165,29,132,211,23,248,113,90,164,233,217,96,224,49,172,151,1,159,231,107,38,10,121,47,236,126,127,50,242,81,191,159,250,13,21,250,23,62,223,159,43,90,166,254,253,7,234,27,175,198,158,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21114814-b450-4a7a-a713-5a6d91d22e20"));
		}

		#endregion

	}

	#endregion

}

