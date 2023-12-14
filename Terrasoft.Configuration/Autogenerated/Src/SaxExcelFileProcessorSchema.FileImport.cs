﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SaxExcelFileProcessorSchema

	/// <exclude/>
	public class SaxExcelFileProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SaxExcelFileProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SaxExcelFileProcessorSchema(SaxExcelFileProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("39fc7d38-40e5-48dc-b7df-e48db49fb156");
			Name = "SaxExcelFileProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,91,107,27,57,20,126,118,161,255,225,52,11,69,3,97,76,247,177,137,93,82,55,233,26,218,38,196,217,11,44,203,162,204,200,182,200,140,52,43,105,146,152,226,255,190,71,151,185,122,108,135,133,174,31,98,143,116,238,231,59,151,137,160,57,211,5,77,24,220,49,165,168,150,75,19,207,164,88,242,85,169,168,225,82,196,87,60,99,243,188,144,202,188,126,245,253,245,171,81,169,185,88,193,39,153,148,57,19,230,74,170,156,154,248,186,96,226,143,60,59,59,114,31,223,208,228,129,174,144,224,40,229,162,80,140,166,122,205,152,105,104,23,27,109,88,222,127,70,131,179,140,37,214,90,29,127,102,130,41,158,236,208,204,175,119,142,190,112,241,79,115,216,246,95,177,125,231,241,21,77,140,84,156,105,164,64,154,159,20,91,161,94,152,101,84,235,247,176,160,207,151,207,9,203,108,208,110,148,76,152,214,82,57,194,241,120,12,231,186,204,115,170,54,211,240,12,23,2,184,208,134,10,140,191,92,130,89,115,13,137,149,4,248,67,97,98,208,35,126,159,49,88,74,5,133,151,103,109,162,2,156,26,88,162,30,240,118,106,250,12,57,51,107,153,198,149,186,113,75,223,159,159,216,146,150,153,249,200,69,138,228,196,108,10,38,151,100,142,22,119,140,141,78,225,27,98,2,38,32,240,11,41,6,93,138,162,191,80,102,81,222,103,60,9,22,15,210,193,123,111,232,71,170,171,195,83,216,209,137,162,190,187,32,213,225,188,226,44,75,49,158,55,138,63,82,195,252,101,225,31,96,238,225,120,67,21,90,104,152,210,183,172,144,154,99,90,54,240,55,223,123,119,22,84,48,145,122,45,93,149,104,77,193,148,193,204,254,7,181,7,174,38,54,250,163,209,1,195,224,195,7,71,66,14,209,76,60,196,60,252,54,8,115,115,126,192,160,41,113,18,71,130,61,1,150,179,54,170,180,124,23,106,229,106,141,156,148,154,41,188,16,190,108,78,78,225,215,206,65,20,69,71,194,213,146,106,3,230,144,16,226,229,81,49,136,7,210,85,3,93,51,34,103,244,123,184,71,180,144,222,21,124,135,237,97,139,190,58,240,247,179,215,175,59,119,16,236,97,26,86,252,145,9,208,77,179,129,52,244,163,184,230,30,247,217,207,11,27,114,87,32,147,147,22,111,213,202,78,166,139,33,129,231,99,199,55,109,131,234,119,169,30,28,25,102,209,84,118,45,118,69,146,129,51,24,80,141,113,114,65,180,114,239,165,124,112,98,39,67,148,113,155,228,204,49,41,102,74,37,0,177,213,49,139,180,41,35,71,186,61,16,92,100,7,15,100,64,53,220,108,96,169,100,14,74,62,189,52,164,72,138,33,148,165,194,182,232,69,116,98,183,67,239,105,78,166,215,165,129,203,61,244,222,55,61,253,134,21,177,199,186,243,113,69,212,206,16,58,158,89,159,188,96,114,43,159,44,241,41,72,84,230,11,208,223,4,113,85,2,130,112,108,163,101,150,249,240,206,47,5,70,94,81,108,232,231,158,19,7,87,153,139,223,104,86,178,41,36,205,131,70,190,128,5,212,71,80,159,15,251,200,25,195,181,231,211,158,246,50,47,156,162,249,192,49,105,11,13,50,248,18,200,144,136,202,242,10,6,75,154,105,230,89,182,61,151,48,134,109,215,73,205,58,235,250,208,214,126,234,41,208,159,185,72,217,51,222,218,152,87,143,177,35,242,202,58,96,196,30,195,142,66,238,22,193,109,197,225,220,20,192,234,201,248,82,188,245,219,238,60,69,248,217,81,139,93,101,158,238,199,18,26,63,140,153,118,166,145,104,234,12,188,200,50,252,173,201,231,146,167,176,171,178,138,161,159,230,100,97,176,98,115,208,254,107,114,96,194,216,89,96,155,172,231,32,3,146,235,244,84,178,95,214,75,80,235,0,165,219,208,136,183,235,212,131,164,81,80,105,120,164,10,44,39,83,40,36,172,116,183,238,57,158,225,185,97,228,64,171,27,106,107,45,21,163,167,181,221,122,136,151,31,91,177,164,125,237,0,30,46,47,51,102,217,239,112,217,129,55,19,8,75,15,166,161,195,48,74,36,226,88,4,160,185,207,182,254,149,202,54,165,115,12,91,192,4,156,148,160,230,139,164,233,172,84,10,85,5,141,36,58,235,50,33,38,15,151,118,109,122,77,25,95,136,77,215,179,209,104,99,23,35,8,181,129,204,45,222,198,228,45,236,134,232,27,123,54,11,220,37,237,238,23,53,42,43,166,240,189,109,202,253,197,211,182,53,250,247,206,131,181,51,68,219,37,247,255,43,207,47,92,87,154,97,167,223,246,187,189,95,90,246,181,232,169,245,226,23,239,196,177,2,182,217,94,114,165,205,173,195,73,187,244,7,152,240,253,10,73,175,85,88,207,43,220,88,33,222,244,73,163,154,84,98,91,68,237,22,91,35,107,198,178,76,19,207,31,117,218,105,32,8,242,118,167,195,161,46,59,91,179,228,1,95,82,168,241,239,29,182,106,40,190,191,212,217,165,194,119,225,31,157,216,59,156,9,22,74,87,182,249,12,39,242,81,98,142,156,193,115,109,155,35,250,200,211,151,100,206,77,145,227,89,187,163,15,140,252,140,223,210,162,140,180,70,171,11,128,171,92,120,251,54,60,246,114,140,77,113,10,170,158,125,182,51,189,139,236,95,187,43,52,5,223,3,146,147,180,192,250,205,216,126,81,19,43,234,172,225,79,108,8,2,112,225,0,148,182,192,48,150,149,102,179,182,61,206,142,121,183,25,124,162,134,218,93,190,176,155,120,111,133,119,107,164,251,15,2,182,25,237,118,182,5,78,37,186,98,209,217,78,51,217,63,188,105,150,213,3,188,121,181,141,225,90,100,27,208,15,188,240,145,112,59,3,252,96,120,213,43,228,139,26,132,167,246,35,222,253,198,55,200,99,64,195,215,121,70,147,117,152,147,24,106,244,250,24,226,22,24,4,242,174,65,135,197,218,155,102,47,61,184,147,54,51,164,55,233,66,219,239,76,21,207,179,155,188,222,36,240,167,221,67,60,179,159,127,1,203,23,82,231,85,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("39fc7d38-40e5-48dc-b7df-e48db49fb156"));
		}

		#endregion

	}

	#endregion

}

