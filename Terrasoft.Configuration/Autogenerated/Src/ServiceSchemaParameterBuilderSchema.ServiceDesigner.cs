namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceSchemaParameterBuilderSchema

	/// <exclude/>
	public class ServiceSchemaParameterBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceSchemaParameterBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceSchemaParameterBuilderSchema(ServiceSchemaParameterBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f037ecb-feb6-462e-a7ed-458ad1f12252");
			Name = "ServiceSchemaParameterBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,219,106,194,64,16,125,94,193,127,24,232,75,2,146,15,240,74,213,182,8,82,4,165,47,165,15,235,102,162,91,226,38,157,221,164,72,241,223,187,201,42,137,23,226,139,121,201,101,103,206,156,115,230,68,241,29,234,148,11,132,21,18,113,157,68,38,152,36,42,146,155,140,184,145,137,10,150,72,185,20,184,20,91,220,241,118,235,175,221,106,183,88,166,165,218,192,114,175,13,238,108,125,28,163,40,138,117,240,134,10,73,138,222,101,205,92,170,159,234,99,125,22,97,240,202,133,73,72,162,238,149,224,79,132,27,11,6,51,101,144,34,203,173,11,179,51,22,11,78,150,182,61,28,103,50,14,145,202,174,52,91,199,82,128,60,53,221,237,97,86,10,99,83,89,50,231,180,239,107,67,150,92,7,146,245,183,149,51,132,178,210,155,189,168,108,135,196,215,49,246,111,35,14,33,61,61,106,191,16,121,112,50,80,133,78,137,125,169,201,154,196,92,235,46,220,87,244,57,197,136,103,177,25,75,21,90,98,158,217,167,152,68,94,179,46,223,255,170,204,16,197,168,230,73,112,223,92,230,118,206,82,146,57,55,8,218,216,100,8,120,176,115,157,98,68,227,62,180,195,88,84,102,67,185,66,22,217,16,113,177,5,47,231,84,33,218,40,212,23,115,172,101,14,13,114,30,103,8,131,170,34,120,71,155,212,176,66,31,217,232,23,185,246,212,249,1,12,134,14,137,57,153,23,199,29,80,248,219,96,142,231,251,126,176,74,230,82,27,207,135,209,168,198,224,163,224,212,115,224,87,98,131,231,48,244,170,218,73,18,98,199,169,240,93,203,1,202,27,161,201,72,93,155,85,22,29,142,155,116,241,120,116,246,143,22,31,25,56,136,218,130,239,27,115,226,120,227,15,106,183,236,183,226,250,7,121,123,20,172,178,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f037ecb-feb6-462e-a7ed-458ad1f12252"));
		}

		#endregion

	}

	#endregion

}

