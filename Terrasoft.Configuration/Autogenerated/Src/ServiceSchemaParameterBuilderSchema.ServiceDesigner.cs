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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,219,106,194,64,16,125,222,128,255,48,208,151,4,36,31,224,149,170,109,17,164,8,74,95,74,31,214,205,68,183,36,155,116,118,99,145,226,191,119,147,85,18,47,232,139,121,201,101,103,206,156,115,230,68,241,20,117,206,5,194,18,137,184,206,98,19,142,51,21,203,117,65,220,200,76,133,11,164,173,20,184,16,27,76,121,203,251,107,121,45,143,21,90,170,53,44,118,218,96,106,235,147,4,69,89,172,195,55,84,72,82,116,207,107,102,82,253,212,31,155,179,8,195,87,46,76,70,18,117,183,2,127,34,92,91,48,152,42,131,20,91,110,29,152,158,176,152,115,178,180,237,225,168,144,73,132,84,117,229,197,42,145,2,228,177,233,110,15,179,82,24,155,200,138,57,167,93,79,27,178,228,218,144,173,190,173,156,1,84,149,254,244,69,21,41,18,95,37,216,187,142,56,128,252,248,168,131,82,228,222,201,64,21,57,37,246,165,33,107,156,112,173,59,112,95,209,231,4,99,94,36,102,36,85,100,137,249,102,151,99,22,251,183,117,5,193,87,109,134,40,71,221,158,4,247,205,101,110,231,44,39,185,229,6,65,27,155,12,1,15,118,174,93,142,184,185,15,237,48,230,181,217,80,173,144,197,54,68,92,108,192,223,114,170,17,109,20,154,139,57,212,50,135,6,91,158,20,8,253,186,34,124,71,155,212,168,70,31,218,232,151,185,246,213,233,1,244,7,14,137,57,153,103,199,109,80,248,123,195,28,63,8,130,112,153,205,164,54,126,0,195,97,131,193,71,201,169,235,192,47,196,134,207,81,228,215,181,227,44,194,182,83,17,184,150,61,84,55,66,83,144,186,52,171,42,218,31,54,233,226,241,232,236,31,44,62,48,112,16,141,5,223,55,230,200,241,202,31,212,242,236,183,230,245,15,126,255,73,179,186,4,0,0 };
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

