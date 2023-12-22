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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,81,107,194,48,16,126,174,224,127,200,20,164,130,244,7,232,220,96,69,164,48,65,166,219,123,108,78,23,104,147,238,146,8,101,236,191,47,105,171,198,186,250,176,188,221,119,119,223,119,247,93,140,226,226,64,54,165,210,144,207,250,61,227,133,209,43,23,95,103,108,11,136,84,201,189,142,98,137,208,1,71,11,161,185,230,160,108,190,223,19,52,7,85,208,20,174,170,196,158,31,12,82,205,165,232,247,190,93,93,48,68,56,216,144,196,25,85,106,234,170,243,152,102,169,201,168,150,24,27,165,101,14,184,1,60,242,20,170,134,194,236,50,158,146,212,213,223,47,39,109,58,219,109,69,131,139,166,20,74,163,73,109,202,74,175,43,226,74,227,36,114,151,62,124,87,128,150,66,64,234,22,34,230,42,156,144,165,225,140,168,186,54,177,158,38,172,193,10,228,18,185,46,19,54,38,78,44,152,146,29,85,16,182,9,90,189,126,91,181,198,79,61,235,16,4,171,23,114,145,191,223,10,244,167,100,110,53,148,218,178,2,107,182,59,133,68,30,237,117,56,131,122,176,37,104,187,173,165,163,152,176,176,81,9,16,180,65,65,54,151,105,200,195,156,8,147,101,100,52,242,225,200,246,111,203,2,88,44,51,147,139,15,154,25,120,116,196,79,225,224,194,59,24,187,118,7,71,139,188,208,101,165,17,60,255,135,168,110,173,221,139,90,195,207,58,28,250,219,159,219,211,159,157,121,179,255,216,254,19,216,242,28,156,67,43,46,124,40,244,131,122,94,85,127,116,130,85,134,221,36,78,198,94,49,55,199,62,97,100,126,222,170,45,216,73,59,243,207,117,219,248,82,174,155,31,20,182,196,38,221,163,118,217,216,96,62,100,17,239,253,2,195,124,207,144,93,4,0,0 };
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

