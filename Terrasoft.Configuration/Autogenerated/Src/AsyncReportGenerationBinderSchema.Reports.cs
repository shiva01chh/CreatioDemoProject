﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncReportGenerationBinderSchema

	/// <exclude/>
	public class AsyncReportGenerationBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncReportGenerationBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncReportGenerationBinderSchema(AsyncReportGenerationBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e9b579b-4224-407d-ac46-c9544808f4a9");
			Name = "AsyncReportGenerationBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,85,75,111,26,49,16,62,19,41,255,193,34,23,35,33,171,82,111,208,164,106,80,72,35,165,73,197,134,246,80,245,96,118,7,106,105,215,94,141,189,180,168,202,127,207,236,218,176,56,176,192,5,60,207,111,190,121,160,101,1,182,148,41,176,23,64,148,214,44,157,152,24,189,84,171,10,165,83,70,95,94,252,191,188,232,85,86,233,21,75,54,214,65,49,222,189,87,185,89,200,124,52,154,152,162,48,90,60,154,213,138,196,173,126,170,114,160,96,107,64,7,40,38,185,2,237,78,107,197,87,231,202,214,100,31,19,66,151,92,76,101,234,12,42,176,199,44,126,194,66,120,128,164,37,253,21,194,138,234,98,147,92,90,59,98,95,236,70,167,51,40,13,186,123,208,224,139,190,85,58,3,108,204,203,106,145,171,148,165,181,245,41,99,70,161,202,242,110,77,69,60,42,162,137,180,183,210,2,69,168,249,107,179,26,109,157,212,142,50,127,71,181,150,14,154,44,189,210,63,88,90,235,153,117,120,192,16,145,159,128,115,36,159,152,12,216,53,235,7,85,2,184,86,41,204,49,239,251,10,123,87,160,51,159,47,188,67,242,111,224,254,152,172,43,245,218,168,140,205,200,146,208,99,148,154,207,45,32,189,52,164,117,193,172,138,158,3,214,84,216,91,75,100,203,8,241,14,24,161,109,26,21,77,150,104,43,178,226,30,220,15,153,87,192,227,216,195,83,28,12,3,79,226,174,40,221,102,48,110,80,168,37,227,65,252,96,159,170,60,127,198,70,205,59,160,13,182,240,123,8,174,66,237,163,188,30,175,200,15,233,22,52,85,165,225,111,140,176,158,223,22,254,206,50,164,168,39,194,211,81,59,206,81,117,162,26,122,135,23,85,128,169,28,57,212,191,146,82,106,49,69,83,36,64,115,146,89,254,241,195,192,195,29,159,194,219,137,179,209,242,19,21,6,78,155,85,241,75,182,17,245,184,127,122,152,30,58,221,112,62,96,215,55,199,16,248,56,175,39,230,237,253,82,209,198,150,57,120,14,235,245,226,180,92,123,19,40,247,95,251,3,136,80,52,235,232,189,66,229,221,193,103,145,57,143,195,182,164,106,227,212,82,165,178,197,115,54,242,211,129,11,15,1,15,131,9,226,59,169,210,20,172,53,200,227,18,58,91,112,142,177,109,59,14,211,69,221,56,127,43,154,3,24,90,231,143,161,161,222,162,202,66,11,159,53,245,38,113,18,29,223,94,64,34,209,193,63,87,95,179,250,123,219,160,5,141,191,216,51,223,170,91,162,163,6,16,199,193,66,144,75,30,106,248,213,143,70,161,255,155,73,203,34,81,27,46,62,38,20,47,138,255,89,248,63,180,248,186,121,239,227,119,240,221,225,139,77,207,142,240,145,233,58,222,4,47,141,133,36,163,207,27,190,184,225,8,175,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e9b579b-4224-407d-ac46-c9544808f4a9"));
		}

		#endregion

	}

	#endregion

}
