namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TimeUnitEnumSchema

	/// <exclude/>
	public class TimeUnitEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TimeUnitEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TimeUnitEnumSchema(TimeUnitEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2edcc60c-6562-466a-beae-9495a7f738b1");
			Name = "TimeUnitEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,75,195,64,16,61,55,208,255,48,224,69,65,18,239,181,130,84,161,30,212,131,21,15,226,97,19,39,113,113,63,194,204,174,16,108,255,187,179,73,154,86,208,37,75,230,189,125,51,243,102,215,41,139,220,170,10,97,131,68,138,125,29,242,149,119,181,110,34,169,160,189,203,87,202,160,123,87,196,243,236,123,158,205,34,107,215,192,83,199,1,237,98,158,9,115,66,216,136,16,110,93,180,220,51,69,81,192,37,71,107,21,117,87,35,190,254,82,218,168,210,32,4,109,17,162,211,129,161,246,4,1,201,50,84,202,84,209,12,29,247,21,138,163,18,109,44,141,174,0,165,7,108,164,192,179,228,11,157,28,205,30,188,67,88,194,197,121,2,247,218,197,128,125,184,246,145,250,224,70,117,253,255,197,211,167,184,63,146,140,204,164,28,177,36,8,218,201,150,239,245,177,100,111,48,224,219,193,7,7,177,90,65,101,20,243,228,103,141,166,69,218,187,250,173,44,189,55,112,199,251,203,76,242,211,240,161,15,201,253,181,164,224,12,250,244,25,97,136,228,38,26,150,203,73,155,139,63,216,110,255,62,75,179,252,123,56,140,190,72,13,118,195,132,233,1,197,210,240,134,9,10,39,235,7,19,41,107,99,24,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2edcc60c-6562-466a-beae-9495a7f738b1"));
		}

		#endregion

	}

	#endregion

}

