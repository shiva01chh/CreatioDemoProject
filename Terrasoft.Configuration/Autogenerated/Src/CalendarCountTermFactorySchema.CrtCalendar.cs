namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarCountTermFactorySchema

	/// <exclude/>
	public class CalendarCountTermFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarCountTermFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarCountTermFactorySchema(CalendarCountTermFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8");
			Name = "CalendarCountTermFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,203,110,219,48,16,60,43,64,254,97,225,94,156,139,116,79,28,3,173,210,199,197,64,129,58,232,121,77,173,100,34,18,41,240,97,87,8,242,239,93,189,104,197,73,107,69,7,9,92,206,204,14,87,220,85,88,145,173,81,16,108,201,24,180,58,119,113,170,85,46,11,111,208,73,173,226,20,75,82,25,26,123,125,245,124,125,21,121,43,85,1,191,26,235,168,186,11,235,41,217,80,252,13,133,211,70,146,61,33,130,204,86,86,244,168,164,131,251,203,41,227,17,204,58,172,244,201,80,193,251,144,150,104,45,220,6,205,84,123,229,88,172,234,243,54,29,56,73,18,88,89,95,85,104,154,245,176,30,9,32,90,6,56,166,64,222,115,226,145,146,76,56,181,223,149,82,128,232,242,253,59,91,244,220,101,12,254,54,228,246,58,107,29,254,236,4,250,221,115,67,93,224,59,57,16,88,10,95,118,71,135,138,196,30,149,180,21,236,26,40,228,129,20,56,174,1,120,46,66,28,84,146,115,153,85,141,6,43,80,252,55,239,23,110,40,218,98,189,13,212,85,210,33,78,4,67,206,27,101,215,233,123,201,25,62,238,183,132,161,12,7,105,156,199,18,190,160,165,80,132,246,4,97,177,124,251,151,71,51,55,208,222,158,40,178,71,233,196,30,150,231,241,72,176,234,219,91,18,111,164,242,142,110,123,76,212,187,234,47,192,80,254,152,13,172,122,84,240,177,94,222,220,253,87,245,183,54,79,124,43,231,137,191,2,207,207,241,67,123,115,73,186,197,124,216,245,28,225,9,116,190,254,3,54,151,116,25,242,97,191,51,100,79,200,119,212,51,202,209,151,110,212,56,112,255,242,224,208,102,67,214,98,65,60,72,22,143,10,119,37,129,211,32,12,161,35,64,110,113,99,120,180,105,149,181,227,231,212,240,49,132,174,0,105,249,107,107,18,50,151,148,197,139,33,97,228,246,70,31,65,209,17,62,155,194,87,164,220,215,63,130,234,182,73,150,211,212,131,195,151,246,253,50,204,0,174,65,63,6,186,117,31,125,29,228,216,244,249,11,90,190,65,88,131,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8"));
		}

		#endregion

	}

	#endregion

}

