namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFragmentSynchronizableSchema

	/// <exclude/>
	public class IFragmentSynchronizableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFragmentSynchronizableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFragmentSynchronizableSchema(IFragmentSynchronizableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709");
			Name = "IFragmentSynchronizable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,78,195,48,16,133,215,141,148,59,140,202,6,54,201,190,132,108,90,129,178,168,132,128,11,76,220,113,98,41,25,71,99,103,81,16,119,199,249,43,161,8,188,176,244,198,227,207,239,141,25,91,114,29,42,130,55,18,65,103,181,79,246,150,181,169,122,65,111,44,199,209,71,28,197,209,230,70,168,10,18,10,246,36,58,92,216,65,241,40,88,181,196,254,245,204,170,22,203,230,29,203,134,198,246,52,77,33,115,125,219,162,156,243,89,31,200,41,49,37,57,112,29,41,163,141,130,198,86,97,215,86,64,97,219,161,169,24,58,20,111,148,233,144,125,104,252,38,15,102,146,133,156,174,208,93,95,54,1,98,22,99,127,251,218,76,81,46,89,142,228,107,123,114,59,120,30,17,211,225,181,243,177,240,66,190,23,254,229,7,90,100,172,72,192,215,232,193,172,130,141,145,122,145,224,2,168,161,193,77,114,161,167,215,248,76,38,126,94,176,243,200,33,131,213,193,4,17,40,33,253,176,45,246,243,116,214,201,142,211,219,219,60,201,210,229,254,0,252,175,25,158,104,45,111,239,238,231,137,16,159,166,161,140,250,115,250,242,31,197,177,182,94,95,111,137,222,179,59,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d438be3-42dd-4256-9b99-40dbca5fc709"));
		}

		#endregion

	}

	#endregion

}

