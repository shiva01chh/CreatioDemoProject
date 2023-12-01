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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,219,106,194,64,16,125,78,192,127,216,42,72,4,201,7,104,109,161,65,36,80,65,170,237,251,154,29,237,66,178,155,206,238,10,161,244,223,187,155,139,198,216,248,208,199,57,51,115,206,156,153,49,138,139,35,217,22,74,67,54,31,248,166,21,134,175,92,124,157,177,29,32,82,37,15,58,140,36,66,15,28,46,133,230,154,131,178,249,129,47,104,6,42,167,9,92,85,137,3,63,26,164,154,75,49,240,191,93,157,55,66,56,218,144,68,41,85,106,230,170,179,136,166,137,73,169,150,24,25,165,101,6,184,5,60,241,4,202,134,220,236,83,158,144,196,213,223,47,39,93,58,219,109,69,189,139,166,20,74,163,73,108,202,74,111,74,226,82,163,17,185,75,31,188,43,64,75,33,32,113,134,136,185,10,167,100,101,56,35,170,170,141,237,78,99,86,99,57,114,137,92,23,49,155,16,39,230,205,200,158,42,8,186,4,157,222,118,91,105,227,167,154,117,4,130,85,134,92,212,246,183,6,253,41,153,179,134,82,91,86,96,181,187,38,36,242,100,175,195,25,84,131,173,64,91,183,150,142,98,204,130,90,197,67,208,6,5,217,94,166,33,15,11,34,76,154,146,241,184,13,135,182,127,87,228,192,34,153,154,76,124,208,212,192,163,35,126,10,134,23,222,225,196,181,59,56,92,102,185,46,74,13,239,249,63,68,85,107,181,189,176,51,252,188,103,67,127,239,231,246,244,231,205,188,217,63,182,127,2,59,158,129,219,208,154,139,54,20,180,131,106,94,85,61,58,193,50,195,110,18,205,98,175,152,235,99,55,24,89,156,93,117,5,123,105,231,237,115,221,54,190,20,155,250,131,130,142,216,180,127,212,190,53,214,88,27,178,136,239,255,2,97,92,206,227,84,4,0,0 };
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

