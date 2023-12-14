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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,203,78,195,48,16,60,131,196,63,172,218,11,72,168,185,67,169,132,56,160,30,144,16,45,31,224,38,155,214,162,177,163,245,26,20,85,252,59,107,187,41,73,9,85,115,138,247,49,59,59,227,196,168,10,93,173,114,132,37,18,41,103,75,158,60,89,83,234,181,39,197,218,154,171,203,221,213,229,133,119,218,172,97,209,56,198,234,254,112,238,182,16,74,92,50,99,194,181,180,193,220,48,82,41,192,119,48,127,195,218,18,63,163,65,193,180,244,232,26,147,199,226,44,203,96,234,124,85,41,106,102,251,243,43,217,79,93,160,3,21,202,54,100,141,245,110,219,0,69,16,88,39,148,48,190,244,38,15,20,213,86,115,51,105,225,178,14,94,237,87,91,157,131,110,185,192,60,206,62,226,35,133,187,72,231,64,254,5,121,99,11,119,7,175,17,32,37,143,201,198,192,130,21,177,112,61,166,39,32,172,220,199,228,208,152,29,119,78,107,69,170,2,35,6,60,140,188,67,18,217,13,198,133,70,179,229,6,33,196,32,63,4,129,109,139,142,251,105,147,105,22,65,134,49,243,174,141,9,178,23,58,11,144,144,61,25,151,186,9,165,180,136,139,129,45,255,174,44,237,109,125,0,232,201,44,233,101,232,139,130,13,101,174,223,123,26,64,95,146,91,24,114,174,119,83,251,219,221,220,159,112,237,25,247,158,57,191,229,193,85,210,146,171,70,170,92,141,185,46,181,44,46,215,210,112,120,165,115,125,13,40,73,250,127,38,68,15,120,207,228,180,252,191,108,213,31,152,47,205,27,96,41,74,211,9,203,14,129,121,49,202,102,93,242,167,109,122,75,115,68,163,225,204,245,160,175,105,80,171,250,24,77,145,190,165,120,254,78,191,134,94,48,198,194,243,3,203,219,55,111,131,4,0,0 };
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

