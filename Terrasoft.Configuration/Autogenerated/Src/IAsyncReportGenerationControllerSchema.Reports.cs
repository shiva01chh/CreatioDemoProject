﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAsyncReportGenerationControllerSchema

	/// <exclude/>
	public class IAsyncReportGenerationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAsyncReportGenerationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAsyncReportGenerationControllerSchema(IAsyncReportGenerationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd9ad88c-6938-4742-b4f8-f46da6ad0542");
			Name = "IAsyncReportGenerationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,193,106,227,48,16,61,167,208,127,16,217,75,10,197,190,239,166,133,110,161,193,11,33,75,157,165,135,208,131,34,141,19,81,91,242,206,200,133,80,250,239,59,178,236,36,77,138,183,190,105,52,122,239,233,205,147,173,172,128,106,169,64,44,1,81,146,43,124,114,239,108,97,54,13,74,111,156,189,188,120,187,188,24,53,100,236,70,228,59,242,80,253,56,89,39,217,226,172,148,3,190,26,5,115,167,161,28,220,76,158,96,205,13,220,242,13,97,195,124,34,179,30,176,96,69,223,69,118,71,59,171,30,161,118,232,103,96,33,42,98,121,30,93,89,2,182,231,86,29,92,91,150,202,63,115,45,77,83,49,165,166,170,36,238,110,187,53,195,32,16,88,79,66,10,181,199,16,174,16,50,208,108,209,89,215,144,192,150,78,108,246,124,130,34,65,210,3,167,71,200,117,179,46,141,18,166,23,253,5,205,163,96,232,104,181,168,143,247,58,225,163,21,251,145,217,87,247,2,147,176,28,205,193,111,157,22,55,98,252,123,145,47,199,215,109,241,167,211,187,220,239,74,224,58,247,207,129,72,110,96,95,77,158,80,214,53,232,216,252,8,127,27,32,255,224,176,146,254,195,129,88,74,126,145,179,125,43,213,206,18,12,247,94,181,66,79,45,110,11,185,151,200,254,250,45,116,54,146,80,8,209,197,26,157,98,44,32,81,56,20,84,131,50,133,1,205,141,202,161,166,100,15,154,158,162,78,107,137,178,18,150,163,122,51,230,0,213,165,244,144,233,241,237,146,121,140,230,145,6,164,56,201,126,124,125,91,50,77,219,211,159,131,69,238,76,83,196,82,97,66,170,85,203,88,157,176,99,134,160,188,191,216,33,32,231,28,8,190,65,75,29,232,209,107,234,179,196,40,209,106,246,138,157,54,86,27,197,13,252,70,120,163,41,125,224,31,118,145,73,123,150,64,251,105,234,250,121,138,251,112,28,226,54,77,102,141,209,226,224,227,181,8,133,213,179,216,187,113,21,95,228,80,70,103,224,39,127,208,44,59,148,16,80,46,69,134,7,83,66,250,230,37,189,100,250,125,60,16,23,62,209,63,70,182,184,191,115,103,108,27,141,118,150,235,29,55,29,2,19,128,191,156,150,86,196,96,82,142,30,122,139,252,191,97,246,82,229,153,208,147,145,228,158,93,175,196,7,91,38,228,49,76,57,234,10,62,143,222,227,223,15,172,142,63,192,176,228,218,241,247,15,140,16,203,32,165,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd9ad88c-6938-4742-b4f8-f46da6ad0542"));
		}

		#endregion

	}

	#endregion

}

