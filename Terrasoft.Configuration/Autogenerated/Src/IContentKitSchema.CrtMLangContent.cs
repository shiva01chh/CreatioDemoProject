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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,110,131,48,16,60,19,169,127,88,37,151,86,170,224,158,164,185,84,81,132,218,168,81,210,15,184,176,80,171,96,163,245,114,136,162,254,189,182,193,40,180,73,84,78,236,48,59,51,30,172,68,141,166,17,25,194,59,18,9,163,11,142,159,181,42,100,217,146,96,169,213,221,228,116,55,137,90,35,85,9,135,163,97,172,23,195,124,190,66,24,175,21,75,150,104,44,193,82,102,132,165,221,135,84,49,82,97,29,230,144,90,101,70,197,47,146,61,37,73,18,88,154,182,174,5,29,87,253,188,199,134,208,88,146,129,47,201,80,104,130,186,173,88,86,66,149,173,40,17,178,78,35,14,251,201,153,64,211,126,84,50,3,25,44,199,142,209,201,187,14,201,118,164,27,36,151,120,14,59,191,217,125,255,29,203,3,175,193,95,90,109,193,154,226,129,122,158,32,74,3,49,237,121,240,7,112,133,70,81,137,188,240,47,166,127,249,190,225,222,31,3,12,187,162,175,56,247,164,131,227,192,104,184,237,56,67,149,119,149,140,251,217,34,127,234,252,63,229,236,145,91,82,38,252,27,64,119,19,142,87,114,122,164,17,36,106,80,246,246,61,77,59,118,154,79,87,111,36,75,169,68,213,11,12,122,50,119,64,33,145,226,101,226,87,47,43,17,102,154,114,167,180,238,4,58,224,230,62,117,217,87,219,75,183,44,156,100,153,4,154,219,235,197,55,200,125,203,247,155,86,230,16,206,241,8,126,12,97,30,22,23,107,238,202,31,131,22,115,207,15,31,180,104,194,149,3,0,0 };
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

