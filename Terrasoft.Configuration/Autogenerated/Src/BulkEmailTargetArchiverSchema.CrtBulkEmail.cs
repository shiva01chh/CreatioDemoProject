﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTargetArchiverSchema

	/// <exclude/>
	public class BulkEmailTargetArchiverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTargetArchiverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTargetArchiverSchema(BulkEmailTargetArchiverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0bc21173-1172-49a1-077e-ba1d098ab0a0");
			Name = "BulkEmailTargetArchiver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,203,110,27,55,20,93,43,64,254,129,117,55,35,192,24,184,139,110,234,170,128,31,138,43,64,78,220,74,105,150,6,77,94,75,68,102,72,133,228,40,81,130,252,123,47,31,163,225,188,108,7,69,181,24,105,200,251,58,135,231,94,74,210,18,204,142,50,32,107,208,154,26,245,104,243,43,37,31,197,166,210,212,10,37,95,191,250,246,250,213,164,50,66,110,200,234,96,44,148,231,157,119,180,47,10,96,206,216,228,55,32,65,11,214,179,89,10,249,169,89,76,115,105,24,91,207,175,47,71,183,230,210,10,43,192,160,1,154,252,172,97,131,233,201,85,65,141,249,141,92,86,197,199,121,73,69,177,166,122,3,246,66,179,173,216,131,246,166,187,234,161,16,140,48,103,57,110,56,249,230,141,143,129,223,8,40,56,70,190,211,98,79,45,132,205,93,120,33,26,40,87,178,56,144,235,203,249,23,96,149,85,154,220,243,135,250,247,249,160,237,123,3,26,137,150,129,56,114,95,181,222,135,125,132,180,228,254,129,90,182,93,137,175,64,102,228,215,179,179,179,243,88,41,72,30,138,109,87,142,49,141,213,21,195,66,92,253,30,125,44,63,48,49,194,65,150,128,105,176,76,137,83,195,100,146,192,195,50,58,88,39,29,48,104,145,216,231,239,251,72,191,63,141,225,22,236,86,141,210,191,2,167,62,114,3,118,16,10,138,231,175,10,244,33,67,26,156,144,140,170,52,131,21,219,66,73,223,162,250,79,73,220,176,222,41,217,240,88,174,49,197,90,148,64,104,32,230,14,229,173,248,41,89,10,99,127,15,158,127,16,166,138,170,148,110,169,38,104,79,53,49,190,48,159,28,41,144,240,57,150,154,117,248,153,6,214,30,81,215,148,109,73,93,104,8,138,135,62,16,126,146,196,118,253,135,219,217,137,57,57,141,166,49,226,119,255,76,77,215,106,151,53,10,138,102,169,193,27,173,202,172,75,209,52,191,48,46,252,52,255,32,236,246,79,148,161,201,252,51,127,171,150,138,125,156,134,154,242,15,91,208,16,234,56,185,85,92,60,10,224,239,36,186,45,204,18,140,121,167,231,159,42,90,100,142,9,159,237,142,106,140,110,81,108,45,114,167,117,188,11,201,179,41,230,176,248,156,127,65,248,38,123,130,197,232,20,217,8,95,121,147,226,151,99,88,143,177,123,218,1,163,61,233,96,177,14,203,130,31,151,23,38,96,8,32,221,70,36,81,131,173,180,76,207,60,85,118,173,213,150,106,110,234,252,161,86,227,202,48,71,153,54,149,197,51,247,35,239,16,60,110,169,164,27,208,164,140,223,179,238,0,201,7,172,207,27,101,250,101,244,138,254,56,182,237,2,231,4,149,12,46,15,46,105,150,228,111,252,26,33,162,111,176,136,124,155,60,158,10,154,144,153,239,136,184,243,15,45,42,8,12,175,149,115,205,218,140,53,49,135,8,219,43,193,201,53,134,182,16,39,211,18,246,80,252,112,51,215,36,186,17,186,211,138,161,28,129,255,13,76,105,110,66,57,92,213,189,229,144,114,159,50,237,221,80,68,79,117,35,29,19,34,29,101,228,132,146,47,228,243,242,69,151,78,143,30,215,211,54,79,36,89,11,122,180,105,143,102,161,150,151,183,210,139,186,105,188,161,154,253,144,184,55,95,219,40,6,123,43,74,101,210,61,50,119,233,52,39,148,135,187,5,15,39,185,169,226,8,36,159,183,162,0,146,245,34,252,52,35,103,211,33,201,57,137,96,51,128,182,255,73,113,167,100,248,234,72,111,136,86,63,13,143,131,30,173,77,55,170,130,119,110,188,120,21,206,2,105,207,223,136,61,44,125,16,157,107,47,185,138,154,66,132,103,43,36,191,82,37,14,21,30,155,102,145,236,140,13,236,133,180,106,96,28,175,192,15,147,58,155,23,89,12,52,6,188,61,88,6,170,26,23,202,139,255,129,244,255,64,57,189,68,165,252,47,34,9,56,128,95,169,74,58,157,12,105,243,71,15,50,50,53,52,88,159,13,53,196,114,172,238,9,42,195,106,123,209,175,165,159,127,1,199,35,169,17,142,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bc21173-1172-49a1-077e-ba1d098ab0a0"));
		}

		#endregion

	}

	#endregion

}

