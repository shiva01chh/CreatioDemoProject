namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationManagerSchema

	/// <exclude/>
	public class IDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationManagerSchema(IDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d");
			Name = "IDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,77,111,194,48,12,61,23,137,255,96,177,11,147,166,246,14,93,47,99,76,28,144,38,216,31,8,173,219,69,106,210,206,73,38,33,180,255,62,147,126,1,98,27,135,245,210,218,126,239,217,126,77,180,80,104,106,145,34,188,33,145,48,85,110,195,167,74,231,178,112,36,172,172,116,184,192,204,213,165,76,125,52,30,29,198,163,192,25,169,11,216,238,141,69,53,191,136,153,93,150,152,30,193,38,124,65,141,36,83,198,48,234,142,176,224,44,172,180,69,202,185,229,12,86,103,226,107,161,69,129,228,193,81,20,65,108,156,82,130,246,73,27,159,129,65,53,232,176,3,71,39,232,218,237,24,7,178,235,244,83,163,224,224,155,245,163,173,209,190,87,153,153,193,171,23,104,138,151,163,248,196,82,234,204,64,167,137,6,152,109,196,39,134,61,35,186,164,196,181,32,161,64,179,227,143,147,156,249,139,158,189,193,15,135,198,78,146,246,35,140,35,15,30,184,132,214,145,54,201,192,129,180,55,154,225,93,253,72,88,61,107,167,144,196,174,196,120,33,61,130,231,136,141,37,254,77,15,208,188,147,196,239,48,232,77,151,215,70,130,171,131,222,207,255,180,198,72,37,75,65,64,152,86,196,113,78,149,226,214,21,97,6,168,173,180,251,91,173,162,155,205,217,182,61,189,190,252,47,139,90,213,77,179,200,146,247,216,250,53,166,191,21,59,251,104,48,44,8,252,81,67,157,53,167,205,91,248,213,92,141,179,36,231,78,159,111,105,185,69,0,163,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3e391f5-bea4-4635-974c-b28b77b1e29d"));
		}

		#endregion

	}

	#endregion

}

