namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IForecastCalculatorSchema

	/// <exclude/>
	public class IForecastCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IForecastCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IForecastCalculatorSchema(IForecastCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f");
			Name = "IForecastCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,75,75,3,49,16,62,183,208,255,48,180,23,189,108,192,163,214,189,20,132,30,10,30,196,251,152,157,148,64,30,203,76,82,16,241,191,155,77,187,238,106,27,114,152,199,247,152,100,2,122,146,30,53,193,27,49,163,68,147,154,93,12,198,30,51,99,178,49,52,47,145,73,163,164,247,7,248,90,45,23,229,110,152,142,165,3,251,144,136,77,225,62,194,126,68,237,208,233,236,48,69,94,45,11,84,41,5,91,201,222,35,127,182,151,124,130,128,29,21,192,148,204,92,52,64,71,151,125,144,102,20,80,51,133,62,127,56,171,103,204,155,214,139,97,212,43,247,63,246,36,255,13,225,132,46,83,181,189,246,61,87,122,100,244,16,202,167,61,175,107,76,101,12,89,183,175,191,113,179,85,181,49,113,152,82,230,32,237,33,118,214,88,234,160,159,131,199,238,0,159,191,164,42,202,52,237,221,141,230,36,116,255,84,248,223,245,203,55,20,186,243,130,234,182,74,113,56,63,92,24,30,200,232,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7ec2b165-5e49-4298-bc0b-1de925207e9f"));
		}

		#endregion

	}

	#endregion

}

