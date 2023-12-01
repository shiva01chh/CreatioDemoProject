﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseExcelCellWriterSchema

	/// <exclude/>
	public class BaseExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseExcelCellWriterSchema(BaseExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("acec43bc-1f29-4705-8c11-d53a80c87fab");
			Name = "BaseExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,123,111,219,54,16,255,59,5,250,29,174,46,86,72,104,166,180,197,214,1,121,184,200,60,183,48,144,44,67,146,174,5,138,98,160,37,218,214,38,145,30,73,217,49,186,124,247,29,95,146,40,203,110,10,12,43,208,214,58,30,239,249,187,7,25,41,169,92,146,148,194,45,21,130,72,62,83,201,136,179,89,62,175,4,81,57,103,201,248,110,201,133,186,229,227,187,148,22,143,31,125,121,252,232,160,146,57,155,195,205,70,42,90,158,116,190,147,107,58,43,104,170,175,110,29,141,120,225,142,100,242,142,50,42,242,116,139,231,34,103,127,55,196,95,120,90,149,148,169,183,92,148,68,37,87,75,202,62,150,197,215,206,147,155,165,160,36,147,11,74,85,195,59,47,248,148,20,199,199,35,94,150,232,215,5,159,207,145,220,156,183,3,32,232,46,122,242,150,164,138,139,156,74,228,64,158,167,130,206,209,33,24,21,68,202,99,248,153,72,106,34,53,162,69,97,173,82,84,24,206,163,163,35,56,149,85,89,18,177,25,186,111,205,14,84,243,3,254,45,96,45,114,100,79,60,247,81,139,125,89,77,139,60,5,50,149,74,160,9,144,106,133,161,190,15,230,54,242,234,36,213,150,253,38,248,146,10,133,22,31,235,223,10,51,64,51,99,209,193,210,127,2,10,213,190,186,0,222,168,77,65,39,44,163,119,231,10,15,166,149,162,112,54,132,129,28,156,236,191,168,173,64,0,80,65,89,74,195,187,194,223,237,198,193,16,198,66,112,1,5,230,196,186,191,237,63,234,204,87,4,133,77,48,115,240,7,178,158,132,150,24,186,254,139,218,244,49,188,121,3,145,249,113,166,201,151,132,17,45,252,29,85,23,70,77,52,48,129,27,196,177,51,236,41,101,153,141,153,251,238,11,160,201,194,30,71,92,206,117,76,212,102,73,119,249,210,73,102,7,50,91,223,95,96,142,80,134,251,253,134,94,82,181,224,153,73,179,9,149,207,149,141,155,84,88,208,169,79,24,134,193,42,225,69,85,178,95,177,13,68,239,39,76,189,254,1,82,75,169,202,41,21,49,24,40,29,172,136,128,44,95,229,25,106,198,112,182,89,76,22,14,156,212,180,150,134,92,55,134,150,140,203,165,218,88,174,245,34,47,40,68,181,164,33,188,240,26,140,138,146,103,85,193,241,106,195,242,61,188,140,225,59,120,245,218,74,56,8,52,96,167,90,97,102,146,91,62,90,16,17,189,254,17,158,59,25,49,254,106,88,221,221,150,7,109,5,254,198,81,173,229,222,252,43,168,170,4,235,138,185,15,163,186,226,121,6,166,240,116,186,198,5,213,237,40,114,229,96,11,18,238,252,175,67,208,76,166,212,15,129,79,255,68,224,194,138,20,21,109,199,153,219,187,117,245,72,52,23,179,117,213,37,71,49,250,125,145,75,21,197,214,234,173,139,201,121,150,69,140,174,161,123,55,218,91,174,135,192,42,109,160,54,51,9,88,98,167,169,118,40,49,255,221,40,34,148,119,221,57,215,181,197,221,212,14,106,142,223,181,215,232,152,220,194,72,62,131,200,196,4,158,156,25,67,106,132,180,239,217,186,48,95,150,59,110,103,174,99,159,55,77,135,98,228,133,68,181,184,29,94,141,89,230,47,198,237,204,63,160,250,130,38,219,219,38,174,13,182,36,130,203,32,24,219,151,245,89,113,95,160,36,77,185,200,76,31,225,110,68,236,105,40,134,178,36,130,148,192,16,169,103,3,35,110,48,52,14,38,167,71,230,168,225,180,208,150,195,81,168,30,25,253,73,216,91,235,70,229,140,107,135,63,192,241,190,30,239,125,110,208,232,240,173,22,216,226,228,130,87,5,106,98,140,43,93,88,205,84,220,231,178,55,119,151,225,171,92,168,138,20,48,25,51,92,20,4,153,22,244,180,91,13,195,29,229,245,149,154,212,104,210,229,215,35,207,1,118,95,233,245,140,88,95,119,81,148,51,21,119,103,128,174,118,219,81,163,56,182,88,63,105,183,169,45,19,191,13,179,95,155,107,62,121,5,122,12,124,6,4,251,216,214,226,34,235,84,77,102,152,85,108,26,144,99,122,215,220,159,3,234,228,140,26,36,35,131,224,107,105,164,44,205,170,249,237,121,182,99,212,77,182,118,142,123,246,34,147,230,243,162,69,9,115,188,230,226,47,179,10,223,162,113,88,195,122,62,8,61,100,244,162,101,183,190,141,222,30,78,39,31,250,56,135,81,171,197,77,183,213,107,200,244,170,208,50,245,55,90,99,97,115,144,124,208,161,139,202,141,38,235,117,198,254,74,38,210,216,2,207,158,193,147,154,116,238,75,19,169,53,241,166,154,154,253,240,106,22,233,80,243,89,212,19,144,216,55,190,25,238,181,36,93,232,190,43,108,106,114,214,235,66,221,138,55,57,197,90,117,200,235,149,13,231,184,232,227,132,228,34,25,161,116,133,88,199,52,225,12,49,6,181,187,245,253,30,212,25,97,210,245,70,172,10,174,81,101,17,103,151,243,102,97,126,72,83,180,220,246,125,51,24,142,187,240,213,221,24,79,130,118,233,32,22,142,249,168,227,173,149,8,109,241,1,178,172,244,179,128,193,14,25,209,96,102,229,70,91,192,100,90,108,56,58,93,235,49,118,184,56,110,79,106,187,51,212,102,214,244,40,144,62,106,237,113,135,161,226,107,190,118,43,160,85,177,181,226,172,221,70,99,231,125,107,6,255,239,249,28,12,117,79,133,143,151,23,254,250,214,188,123,208,100,252,116,53,149,188,160,216,163,7,239,241,89,246,83,242,242,85,242,2,254,113,77,82,119,178,140,226,195,50,69,48,103,9,104,150,58,40,176,206,213,2,122,81,49,136,63,239,198,81,184,39,250,144,238,218,12,119,100,255,191,73,141,111,240,182,169,51,147,123,152,217,231,7,169,95,114,72,128,121,190,194,112,27,62,173,193,241,216,5,226,129,137,163,225,108,11,106,49,144,183,115,115,25,239,51,179,187,199,4,99,194,220,180,216,182,218,155,119,170,47,25,75,191,164,154,167,153,220,221,71,89,199,137,118,166,58,71,182,143,131,107,197,221,193,222,148,247,172,165,23,249,123,164,232,97,97,207,163,206,105,123,61,8,22,131,104,183,195,113,160,241,211,139,207,90,252,168,146,138,151,141,219,109,171,251,165,28,194,140,20,242,193,24,131,86,178,69,221,176,244,188,201,244,126,96,223,91,184,8,226,128,225,107,151,226,135,2,171,253,50,29,12,109,127,243,34,246,118,5,225,251,221,96,120,221,104,221,189,56,7,198,239,131,91,247,189,29,116,227,158,39,247,33,56,98,109,145,7,150,203,103,207,203,61,124,178,63,111,174,182,64,177,103,29,180,212,54,17,41,248,231,95,136,200,82,81,29,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("acec43bc-1f29-4705-8c11-d53a80c87fab"));
		}

		#endregion

	}

	#endregion

}
