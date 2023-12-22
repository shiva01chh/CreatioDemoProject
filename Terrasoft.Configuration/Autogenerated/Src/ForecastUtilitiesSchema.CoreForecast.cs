namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastUtilitiesSchema

	/// <exclude/>
	public class ForecastUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastUtilitiesSchema(ForecastUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8");
			Name = "ForecastUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,77,107,195,48,12,134,207,41,244,63,136,156,186,75,12,59,174,105,160,4,186,235,88,187,221,61,87,246,12,177,29,252,145,81,202,254,251,236,164,89,63,15,173,137,5,145,244,232,149,100,77,21,186,150,50,132,13,90,75,157,225,190,168,141,230,82,4,75,189,52,186,88,25,139,140,58,255,249,60,157,236,167,147,44,56,169,197,89,182,82,70,207,167,147,24,35,132,64,233,130,82,212,238,170,195,255,155,53,157,220,162,3,126,40,4,193,203,70,122,137,174,24,17,114,194,180,225,171,145,12,156,143,242,12,88,67,157,131,177,135,143,145,140,121,251,94,241,74,178,119,188,163,15,86,187,88,196,74,230,129,10,97,81,244,227,128,223,181,88,252,131,228,146,44,91,106,169,2,29,215,178,200,121,208,172,54,91,204,171,100,193,240,171,74,37,233,243,143,184,29,148,171,245,109,101,232,104,19,176,116,136,192,44,242,69,190,60,38,108,98,124,192,114,82,149,100,172,148,74,159,239,228,38,3,175,232,107,218,176,85,236,57,69,102,105,246,248,80,227,12,79,144,30,47,203,220,143,244,236,27,102,151,254,44,238,23,33,143,251,200,95,6,71,54,116,112,91,174,88,7,53,63,5,153,9,218,223,135,214,41,245,12,166,157,184,15,93,118,226,0,110,145,211,208,248,199,122,253,77,54,153,120,227,119,122,254,0,200,89,64,133,9,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91be19b7-738e-4443-9fd0-37cbba5954a8"));
		}

		#endregion

	}

	#endregion

}

