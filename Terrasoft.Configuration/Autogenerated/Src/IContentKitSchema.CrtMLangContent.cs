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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,65,110,131,48,16,60,19,169,127,88,37,151,86,170,224,158,164,185,84,81,132,218,168,81,210,15,184,176,80,171,96,208,122,125,136,162,254,189,54,216,40,180,73,84,78,236,48,59,51,30,172,68,141,186,21,25,194,59,18,9,221,20,28,63,55,170,144,165,33,193,178,81,119,147,211,221,36,50,90,170,18,14,71,205,88,47,134,249,124,133,48,94,43,150,44,81,91,130,165,204,8,75,187,15,169,98,164,194,58,204,33,181,202,140,138,95,36,119,148,36,73,96,169,77,93,11,58,174,252,188,199,150,80,91,146,134,47,201,80,52,4,181,169,88,86,66,149,70,148,8,89,175,17,135,253,228,76,160,53,31,149,204,64,6,203,177,99,116,234,92,135,100,59,106,90,36,151,120,14,187,110,179,255,254,59,86,7,188,6,127,105,181,5,55,20,15,212,243,4,81,26,136,169,231,193,31,192,21,26,69,37,242,162,123,209,254,229,251,134,187,63,6,104,118,69,95,113,246,164,131,227,192,104,184,237,56,67,149,247,149,140,251,217,34,127,54,249,127,202,217,35,27,82,58,252,27,64,119,19,142,87,114,118,72,43,72,212,160,236,237,123,154,246,236,52,159,174,222,72,150,82,137,202,11,12,122,50,119,64,33,145,226,101,210,173,94,86,34,204,26,202,157,210,186,23,232,129,155,251,212,103,95,109,47,221,178,112,146,101,18,104,110,207,139,111,144,125,203,247,27,35,115,8,231,120,132,110,12,97,30,22,23,107,238,203,31,131,22,179,207,15,144,200,33,176,148,3,0,0 };
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

