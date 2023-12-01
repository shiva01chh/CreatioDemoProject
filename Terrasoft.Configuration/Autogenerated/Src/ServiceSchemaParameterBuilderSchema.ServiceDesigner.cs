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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,77,107,194,64,16,61,175,224,127,24,232,37,1,201,15,208,170,84,109,139,32,165,160,244,82,122,88,55,19,221,18,55,233,236,198,34,197,255,222,73,86,73,90,69,47,230,146,143,157,121,243,222,155,23,35,55,104,115,169,16,22,72,36,109,150,184,104,156,153,68,175,10,146,78,103,38,154,35,109,181,194,185,90,227,70,182,91,63,237,86,187,37,10,171,205,10,230,59,235,112,195,245,105,138,170,44,182,209,51,26,36,173,122,255,107,102,218,124,213,31,155,179,8,163,39,169,92,70,26,109,175,2,191,35,92,49,24,76,141,67,74,152,91,23,166,127,88,188,74,98,218,124,56,42,116,26,35,85,93,121,177,76,181,2,125,108,186,218,35,88,138,16,19,93,49,151,180,187,183,142,152,92,7,178,229,39,203,25,64,85,25,76,31,77,177,65,146,203,20,239,207,35,14,32,63,62,218,176,20,185,247,50,208,196,94,9,191,52,100,141,83,105,109,23,174,43,122,159,96,34,139,212,141,180,137,153,88,224,118,57,102,73,112,89,87,24,126,212,102,168,114,212,229,73,112,221,92,225,119,46,114,210,91,233,16,172,227,100,40,184,177,115,157,114,196,197,125,88,143,241,90,155,13,213,10,69,194,33,146,106,13,193,86,82,141,200,81,104,46,230,80,43,60,26,108,101,90,32,244,235,138,232,5,57,169,113,141,62,228,232,151,185,14,204,223,3,232,15,60,146,240,50,255,29,119,192,224,247,5,115,130,48,12,163,69,54,211,214,5,33,12,135,13,6,111,37,167,158,7,63,17,27,61,196,113,80,215,142,179,24,59,94,69,232,91,246,80,221,8,93,65,230,212,172,170,104,127,216,164,143,199,173,179,127,176,248,192,192,67,52,22,124,221,152,35,199,51,127,80,187,197,223,248,250,5,7,73,232,167,177,4,0,0 };
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

