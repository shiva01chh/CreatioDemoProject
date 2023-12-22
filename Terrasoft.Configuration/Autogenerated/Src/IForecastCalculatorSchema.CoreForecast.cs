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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,75,75,3,49,16,62,183,208,255,48,180,23,189,108,192,163,214,189,20,132,30,4,15,226,125,204,78,74,32,143,101,38,17,68,252,239,166,105,215,141,182,33,135,121,124,143,73,38,160,39,25,81,19,188,18,51,74,52,169,219,197,96,236,33,51,38,27,67,247,20,153,52,74,122,187,131,175,213,114,81,238,134,233,80,58,176,15,137,216,20,238,61,236,39,212,14,157,206,14,83,228,213,178,64,149,82,176,149,236,61,242,103,127,206,103,8,216,73,1,76,201,204,89,3,116,116,217,7,233,38,1,213,40,140,249,221,89,221,48,175,90,47,142,163,94,184,255,177,39,249,111,8,31,232,50,85,219,75,223,83,101,68,70,15,161,124,218,227,186,198,84,198,144,117,255,242,27,119,91,85,27,51,135,41,101,14,210,63,199,193,26,75,3,140,45,120,234,30,225,237,75,170,162,204,211,222,92,105,206,66,183,15,133,255,93,191,124,67,97,56,45,168,110,171,20,219,243,3,223,55,168,117,240,1,0,0 };
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

