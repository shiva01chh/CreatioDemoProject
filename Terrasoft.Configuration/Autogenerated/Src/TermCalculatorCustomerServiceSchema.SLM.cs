namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorCustomerServiceSchema

	/// <exclude/>
	public class TermCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorCustomerServiceSchema(TermCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620");
			Name = "TermCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,81,107,194,48,16,126,174,224,127,200,20,164,3,233,15,208,185,193,202,24,133,9,50,221,222,99,115,115,129,54,233,46,137,80,198,254,251,46,109,213,90,87,31,150,183,251,238,238,251,238,190,139,51,82,237,216,186,52,22,242,249,112,224,90,97,244,34,213,215,17,219,0,34,55,250,195,70,177,70,232,129,163,39,101,165,149,96,40,63,28,40,158,131,41,120,10,103,85,234,67,238,28,114,43,181,26,14,190,125,93,48,70,216,81,200,226,140,27,51,243,213,121,204,179,212,101,220,106,140,157,177,58,7,92,3,238,101,10,85,67,225,182,153,76,89,234,235,175,151,179,46,29,117,147,104,112,210,212,202,88,116,41,165,72,122,85,17,87,26,7,145,171,244,225,155,1,36,10,5,169,95,136,185,179,112,202,158,157,20,204,212,181,9,121,154,136,6,43,80,106,148,182,76,196,45,243,98,193,140,109,185,129,176,75,208,233,109,183,85,107,252,212,179,142,65,137,122,33,31,181,247,91,130,253,212,194,175,134,218,18,43,136,102,187,67,200,244,158,174,35,5,212,131,61,131,165,109,137,142,99,34,194,70,37,64,176,14,21,91,159,166,97,55,11,166,92,150,177,201,164,13,71,212,191,41,11,16,177,206,92,174,222,121,230,224,206,19,223,135,163,19,239,232,214,183,123,56,122,202,11,91,86,26,193,195,127,136,234,214,218,189,168,51,252,188,199,161,191,253,185,60,253,209,153,87,250,199,244,79,96,35,115,240,14,45,165,106,67,97,59,168,231,53,245,71,103,88,101,196,69,226,96,236,25,115,115,236,3,198,22,199,173,186,130,189,180,243,246,185,46,27,31,203,85,243,131,194,142,216,180,127,212,62,27,27,172,13,17,66,239,23,1,153,129,8,85,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620"));
		}

		#endregion

	}

	#endregion

}

