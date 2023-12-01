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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,75,107,2,49,16,62,43,248,31,6,189,180,151,13,244,104,237,94,132,130,135,66,15,210,251,152,157,72,32,143,101,146,20,74,233,127,119,140,110,119,91,13,57,204,227,123,76,50,1,61,165,30,53,193,158,152,49,69,147,155,109,12,198,30,11,99,182,49,52,175,145,73,99,202,31,79,240,189,152,207,228,174,152,142,210,129,93,200,196,70,184,107,216,13,168,45,58,93,28,230,200,139,185,64,149,82,176,73,197,123,228,175,246,154,143,16,176,131,2,24,201,204,85,3,116,116,197,135,212,12,2,106,162,208,151,131,179,122,194,188,107,61,59,143,122,227,254,199,158,210,127,67,248,68,87,168,218,222,250,94,42,61,50,122,8,242,105,47,203,26,147,140,145,150,237,251,111,220,108,84,109,140,28,166,92,56,164,246,45,118,214,88,234,160,159,130,135,238,25,62,125,73,85,76,227,180,15,119,154,163,208,227,179,240,127,234,151,175,40,116,151,5,213,109,73,81,206,9,30,172,35,198,231,1,0,0 };
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

