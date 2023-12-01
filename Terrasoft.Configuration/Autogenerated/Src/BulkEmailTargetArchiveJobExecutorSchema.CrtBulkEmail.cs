﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTargetArchiveJobExecutorSchema

	/// <exclude/>
	public class BulkEmailTargetArchiveJobExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTargetArchiveJobExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTargetArchiveJobExecutorSchema(BulkEmailTargetArchiveJobExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4709ab3d-141d-7767-6071-db3a4e280825");
			Name = "BulkEmailTargetArchiveJobExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,87,91,111,219,54,20,126,118,129,254,7,194,45,10,25,83,133,14,93,246,144,52,25,234,216,217,60,52,109,16,123,219,67,17,4,180,116,236,112,149,37,131,162,220,120,129,255,251,14,111,18,169,75,18,108,121,136,77,242,92,191,243,157,67,58,163,27,40,182,52,6,178,0,206,105,145,175,68,116,158,103,43,182,46,57,21,44,207,94,190,120,120,249,98,80,22,44,91,147,171,60,77,247,39,213,114,190,47,4,108,154,107,84,79,83,136,165,110,17,253,10,25,112,22,215,50,174,23,14,125,251,209,100,92,31,201,13,52,61,7,33,112,89,144,211,166,176,23,111,228,136,214,54,214,105,190,164,233,241,241,121,190,217,160,204,167,124,189,198,109,60,71,137,87,28,214,168,72,206,83,90,20,199,100,92,166,223,166,27,202,210,5,229,107,16,31,121,124,199,118,240,123,190,156,222,67,92,138,156,43,165,109,185,76,89,76,98,169,243,180,10,57,38,51,207,194,224,65,89,169,125,35,88,130,102,2,253,95,113,182,163,2,244,249,86,47,72,44,207,73,33,184,76,70,219,199,111,11,186,76,225,51,86,16,49,25,210,214,238,240,164,215,196,24,196,5,227,133,240,44,140,167,11,19,186,58,83,181,83,152,62,110,104,14,184,147,244,88,210,135,207,53,229,27,241,81,125,68,115,82,3,141,122,73,181,122,68,229,26,227,226,73,177,200,175,120,30,67,81,156,231,101,38,164,54,239,58,120,196,144,201,115,34,15,170,42,168,101,151,18,67,39,215,32,248,222,250,123,239,9,33,7,4,178,138,3,77,242,44,221,147,25,18,149,220,166,248,239,148,224,215,75,154,209,53,112,236,42,33,25,12,60,24,94,34,62,24,198,112,164,236,188,130,44,209,140,242,233,117,193,32,77,250,184,213,205,94,78,110,19,42,168,93,121,97,202,44,110,87,146,35,87,216,221,121,242,185,220,44,129,127,89,77,232,190,104,11,50,97,106,63,103,255,128,119,140,243,132,197,123,114,187,85,159,222,17,54,132,128,123,212,230,26,45,181,106,219,46,20,189,158,136,226,143,2,56,90,200,244,80,34,183,165,183,62,49,80,245,64,119,9,226,46,239,197,206,20,108,151,179,132,124,201,84,101,3,27,122,172,63,67,21,169,74,99,102,145,8,201,244,62,134,173,10,7,236,183,17,145,147,118,48,8,140,226,215,154,214,55,132,22,100,50,182,203,209,47,209,53,14,217,37,141,191,45,56,205,10,170,18,9,52,7,6,146,47,209,95,148,103,23,57,223,80,17,168,205,193,240,107,79,157,163,9,164,32,192,44,63,193,14,210,136,76,57,199,102,250,126,199,82,32,213,96,105,50,37,34,54,10,34,234,48,34,50,36,63,104,159,175,135,205,54,59,38,15,54,187,206,14,188,57,184,218,213,160,35,66,14,6,146,225,100,112,44,180,231,160,86,39,175,135,21,210,40,238,67,127,136,134,161,131,185,130,236,224,23,85,85,211,224,17,216,170,184,248,204,233,10,2,119,92,133,237,129,26,246,118,136,41,83,151,193,166,137,246,116,13,251,57,255,100,46,181,43,51,187,138,188,228,49,56,182,205,190,80,229,117,246,37,131,43,26,104,207,22,151,43,14,91,202,225,218,105,211,160,101,183,169,107,136,170,251,62,210,180,134,0,177,62,61,35,138,209,43,224,110,208,109,139,141,16,71,161,230,140,55,46,250,1,153,101,76,48,154,226,60,170,56,84,21,218,68,133,19,87,143,167,232,55,154,37,41,124,168,58,246,44,24,105,103,145,238,247,122,158,135,36,168,152,21,182,90,222,208,86,37,105,103,69,53,35,154,194,53,67,45,88,222,24,197,232,26,207,34,121,41,252,73,211,18,130,198,124,11,157,235,24,5,103,174,25,108,133,31,223,225,159,245,209,195,88,114,170,19,254,47,46,155,111,9,109,29,29,191,255,249,200,186,237,99,244,255,242,219,124,121,84,142,127,58,58,234,103,70,39,157,77,183,196,119,176,161,117,67,108,149,65,213,121,134,58,59,202,9,245,222,3,242,99,193,54,16,45,242,132,238,163,143,137,146,15,222,58,186,6,3,151,184,168,152,193,119,123,7,6,195,101,231,228,214,244,196,132,164,236,132,41,4,40,223,127,208,225,134,36,95,254,141,176,156,153,216,6,15,29,239,198,208,73,138,28,66,43,216,57,154,67,210,184,202,15,36,244,45,171,164,67,15,129,131,146,56,244,227,221,221,237,238,120,154,59,176,123,243,169,62,176,248,235,183,126,80,95,148,36,113,95,134,13,182,68,211,172,40,57,76,198,245,86,48,178,166,252,130,120,87,241,169,99,245,196,8,187,79,37,83,189,158,235,54,168,149,77,233,7,150,36,13,238,4,118,127,228,199,226,128,125,99,44,40,58,234,90,65,98,170,103,142,146,220,102,52,168,61,71,115,132,80,116,188,29,100,117,124,51,18,55,55,187,200,94,140,237,234,52,203,226,81,161,114,224,68,33,127,141,177,238,48,252,148,187,223,10,18,35,204,124,244,44,217,183,125,0,29,244,51,39,120,190,169,51,242,142,188,121,211,178,39,247,77,252,7,135,238,79,63,44,213,79,73,211,27,250,103,165,106,13,123,45,54,158,175,205,145,55,123,164,245,113,148,97,29,176,105,171,17,213,232,1,132,176,245,26,70,169,206,251,209,123,182,4,94,75,55,114,212,187,254,166,218,195,191,127,1,98,4,63,240,113,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4709ab3d-141d-7767-6071-db3a4e280825"));
		}

		#endregion

	}

	#endregion

}
