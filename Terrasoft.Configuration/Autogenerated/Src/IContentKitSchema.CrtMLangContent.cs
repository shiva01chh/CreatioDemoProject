namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContentKitSchema

	/// <exclude/>
	public class IContentKitSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContentKitSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContentKitSchema(IContentKitSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("37dac048-4167-4f6c-9dc9-b9ea768da408");
			Name = "IContentKit";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,110,131,48,16,60,19,169,127,88,37,151,86,170,224,158,164,185,84,81,132,218,168,81,210,15,184,176,80,171,96,163,245,114,136,162,254,189,182,193,136,180,73,84,78,236,48,59,51,30,172,68,141,166,17,25,194,59,18,9,163,11,142,159,181,42,100,217,146,96,169,213,221,228,116,55,137,90,35,85,9,135,163,97,172,23,195,60,94,33,140,215,138,37,75,52,150,96,41,51,194,210,238,67,170,24,169,176,14,115,72,173,50,163,226,23,201,158,146,36,9,44,77,91,215,130,142,171,126,222,99,67,104,44,201,192,151,100,40,52,65,221,86,44,43,161,202,86,148,8,89,167,17,135,253,100,36,208,180,31,149,204,64,6,203,115,199,232,228,93,135,100,59,210,13,146,75,60,135,157,223,236,190,255,142,229,129,215,224,47,173,182,96,77,241,64,29,39,136,210,64,76,123,30,252,1,92,161,81,84,34,47,252,139,233,95,190,111,184,247,199,0,195,174,232,43,206,61,233,224,56,112,54,220,118,156,161,202,187,74,206,251,217,34,127,234,252,63,229,236,145,91,82,38,252,27,64,119,19,142,87,114,122,164,17,36,106,80,246,246,61,77,59,118,154,79,87,111,36,75,169,68,213,11,12,122,50,119,64,33,145,226,101,226,87,47,43,17,102,154,114,167,180,238,4,58,224,230,62,117,217,87,219,75,183,44,156,100,153,4,154,219,235,197,55,200,125,203,247,155,86,230,16,206,241,8,126,12,97,30,22,23,107,238,202,63,7,45,54,126,126,0,182,189,122,197,157,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37dac048-4167-4f6c-9dc9-b9ea768da408"));
		}

		#endregion

	}

	#endregion

}

