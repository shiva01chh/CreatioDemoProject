﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportBackgroundProcessorSchema

	/// <exclude/>
	public class FileImportBackgroundProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportBackgroundProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportBackgroundProcessorSchema(FileImportBackgroundProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9711bf07-aff1-4f11-9cef-3bf614f18263");
			Name = "FileImportBackgroundProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,223,111,219,54,16,126,118,129,253,15,87,111,15,50,224,40,91,156,1,169,147,180,112,60,39,240,218,2,70,156,180,143,5,35,157,109,174,50,41,144,84,18,33,205,255,222,19,73,73,150,98,53,152,158,196,187,227,125,119,31,239,135,96,91,212,41,139,16,110,80,41,166,229,202,132,83,41,86,124,157,41,102,184,20,225,37,79,112,190,77,165,50,240,244,219,155,94,166,185,88,195,50,215,6,183,167,173,51,221,76,18,140,138,107,58,188,66,129,138,71,181,205,46,128,194,46,121,184,80,50,66,173,107,253,58,145,119,44,25,143,167,114,187,165,120,62,201,245,154,196,164,39,139,223,21,174,9,13,96,154,48,173,199,80,7,123,193,162,239,87,74,102,34,246,14,165,178,55,210,236,46,225,17,68,133,125,203,124,221,52,135,49,204,255,149,119,179,71,140,50,67,199,39,123,191,130,188,228,152,196,99,88,40,126,207,12,58,93,234,14,160,144,197,82,36,57,92,101,60,134,111,171,10,102,129,74,115,162,74,152,27,166,191,195,185,53,8,23,76,105,12,250,71,211,227,147,147,201,232,175,131,119,151,199,163,131,227,209,236,239,131,201,244,232,228,224,207,201,104,50,154,77,142,142,79,222,77,251,131,211,93,32,109,232,145,162,26,111,78,236,192,183,132,40,66,69,222,233,244,153,9,70,7,122,14,243,201,138,131,126,157,245,36,77,81,196,168,172,87,155,28,29,93,126,205,100,63,163,217,200,88,119,164,235,163,184,151,148,236,87,197,13,94,35,137,148,161,103,114,56,51,165,164,34,248,224,35,230,95,88,146,225,130,113,117,86,228,62,4,79,12,83,84,137,134,232,121,15,169,123,129,150,98,8,179,199,8,211,162,184,0,7,182,22,123,61,159,106,104,1,130,63,250,19,210,21,191,32,163,40,83,24,195,195,134,146,37,126,202,120,128,187,82,126,224,102,227,161,151,132,69,78,231,49,60,237,71,14,109,200,97,203,250,185,63,164,56,236,107,60,55,233,176,60,120,10,110,69,36,183,105,66,110,98,119,63,184,213,168,168,195,132,235,19,200,26,199,151,116,248,128,43,65,153,249,61,83,37,81,51,65,13,129,244,220,77,95,101,39,57,245,105,251,22,229,123,222,118,190,211,236,139,210,202,93,244,199,242,50,93,109,128,211,197,170,115,46,242,219,121,28,84,40,225,141,92,26,69,212,7,131,33,24,149,121,206,122,124,5,165,81,184,164,2,202,200,233,57,120,31,78,224,158,21,126,252,128,215,12,231,130,81,206,247,85,93,244,20,154,76,9,135,244,92,165,142,9,110,169,247,234,232,109,220,151,137,124,152,57,205,69,190,140,54,184,101,254,88,36,210,217,189,3,96,186,12,99,82,160,115,147,215,169,121,168,15,101,200,111,219,33,95,103,66,20,5,249,139,144,125,47,169,76,20,189,211,46,4,103,217,124,134,169,47,54,55,180,10,210,125,28,33,165,50,124,81,75,157,213,219,68,254,63,53,73,235,68,211,192,33,138,235,90,42,198,144,19,207,30,137,61,109,247,195,148,134,150,193,125,70,193,62,225,77,158,210,110,72,152,192,248,26,137,187,218,166,35,173,106,54,204,197,74,6,62,172,70,198,175,15,59,187,43,156,242,240,240,16,206,184,216,208,78,51,177,164,5,162,112,117,222,223,93,16,253,195,247,150,71,183,96,44,141,78,133,175,246,252,63,220,254,49,149,159,105,219,43,67,144,119,255,145,154,134,97,197,250,46,203,10,83,169,57,129,230,68,180,192,135,23,99,227,186,50,8,154,104,131,23,131,0,219,243,174,232,238,26,160,216,28,95,105,90,150,3,161,26,104,129,119,181,162,173,205,162,13,4,187,195,165,233,17,184,232,70,171,26,192,80,54,254,183,215,57,62,219,220,253,106,100,251,0,123,207,16,49,83,68,184,103,131,84,93,214,177,177,186,150,81,237,188,110,216,253,117,229,164,77,161,149,209,247,19,255,94,63,241,127,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9711bf07-aff1-4f11-9cef-3bf614f18263"));
		}

		#endregion

	}

	#endregion

}

