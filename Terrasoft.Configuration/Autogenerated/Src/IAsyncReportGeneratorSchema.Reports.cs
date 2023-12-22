namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAsyncReportGeneratorSchema

	/// <exclude/>
	public class IAsyncReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAsyncReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAsyncReportGeneratorSchema(IAsyncReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe187b0f-b6a6-426e-8401-a8fc548ff6d0");
			Name = "IAsyncReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,79,194,64,16,61,75,226,127,152,192,69,19,67,239,138,36,198,3,225,96,66,0,127,192,210,78,97,35,221,109,102,103,53,13,241,191,59,221,165,216,98,37,244,212,157,143,55,111,222,219,214,168,2,93,169,82,132,53,18,41,103,115,30,191,90,147,235,173,39,197,218,154,219,193,225,118,112,227,157,54,91,88,85,142,177,120,58,157,219,45,132,18,151,204,136,112,43,109,48,55,140,148,11,240,35,204,151,88,90,226,25,26,20,76,75,47,174,50,105,40,78,146,4,38,206,23,133,162,106,122,60,47,200,126,234,12,29,168,186,108,71,214,88,239,246,21,80,0,129,109,68,169,199,231,222,164,53,69,181,215,92,141,27,184,164,133,87,250,205,94,167,160,27,46,48,15,179,207,248,72,225,33,208,57,145,127,67,222,217,204,61,194,34,0,196,228,57,217,16,88,177,34,22,174,231,244,4,132,149,251,24,159,26,147,243,206,73,169,72,21,96,196,128,231,161,119,72,34,187,193,176,208,112,186,222,33,212,49,72,79,65,96,219,160,227,113,218,120,146,4,144,126,204,180,109,99,132,236,132,174,2,36,100,79,198,197,110,66,41,205,194,98,96,243,191,43,75,123,83,95,3,116,100,150,244,186,238,11,130,245,101,238,222,59,26,64,87,146,7,232,115,174,115,83,187,219,221,63,93,112,109,134,71,207,156,223,115,239,42,113,201,77,37,85,174,196,84,231,90,22,151,107,105,184,126,165,107,125,173,81,162,244,255,76,8,30,240,145,201,101,249,127,217,170,63,48,95,154,119,192,82,20,167,19,230,45,2,243,108,152,76,219,228,47,219,180,140,115,68,163,254,204,93,175,175,113,80,163,250,8,77,22,191,165,112,254,142,191,134,78,48,196,218,207,15,89,24,188,79,139,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe187b0f-b6a6-426e-8401-a8fc548ff6d0"));
		}

		#endregion

	}

	#endregion

}

