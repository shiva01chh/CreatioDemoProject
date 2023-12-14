namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermCalculatorSchema

	/// <exclude/>
	public class ITermCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermCalculatorSchema(ITermCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4");
			Name = "ITermCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,145,207,78,3,33,16,198,207,146,240,14,164,39,189,44,15,208,117,47,245,226,181,219,23,160,56,219,144,44,127,50,3,38,141,241,221,203,180,178,181,154,168,23,9,7,134,249,126,124,243,133,66,46,28,212,120,164,12,126,45,133,20,193,120,160,100,44,168,29,32,26,138,83,238,54,49,76,238,80,208,100,23,67,55,2,190,58,11,181,237,165,120,147,226,78,107,173,122,42,222,27,60,14,31,245,22,18,2,65,200,164,232,162,87,185,2,202,154,217,150,217,228,136,93,35,245,39,52,149,253,236,172,114,161,138,39,30,226,153,109,54,11,84,37,236,248,205,242,124,209,100,160,170,117,138,129,64,189,212,170,91,0,253,149,232,147,65,227,21,103,126,92,81,54,152,159,42,176,26,70,62,94,224,94,159,53,87,4,33,23,12,52,108,111,60,122,221,238,89,200,175,236,156,135,235,72,77,205,157,251,165,189,88,62,172,255,144,138,226,92,248,7,254,51,213,120,227,241,91,170,166,254,41,213,187,20,117,243,58,1,128,24,205,187,108,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf14023c-5dd2-42fc-a1c9-2ee0dcd85fa4"));
		}

		#endregion

	}

	#endregion

}

