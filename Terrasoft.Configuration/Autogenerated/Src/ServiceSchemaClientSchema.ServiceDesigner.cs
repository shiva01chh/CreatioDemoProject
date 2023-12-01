namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceSchemaClientSchema

	/// <exclude/>
	public class ServiceSchemaClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceSchemaClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceSchemaClientSchema(ServiceSchemaClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c738511-5733-4fc5-9114-2b98f15b5f10");
			Name = "ServiceSchemaClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73951534-6fa4-4e40-b925-a1e2e4e079e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,193,78,194,64,16,61,151,132,127,216,224,165,36,164,31,128,226,1,80,195,65,99,64,79,198,195,178,76,97,77,187,173,179,91,34,49,254,187,179,221,22,186,182,132,216,75,211,153,55,111,222,188,153,42,158,130,206,185,0,246,2,136,92,103,177,137,102,153,138,229,182,64,110,100,166,162,21,224,94,10,88,137,29,164,188,223,251,238,247,130,66,75,181,101,171,131,54,144,18,58,73,64,88,168,142,30,64,1,74,113,125,196,52,73,17,206,197,163,123,46,76,134,18,116,23,162,18,96,115,148,189,66,216,82,47,182,80,6,48,38,225,99,182,240,36,206,18,9,202,148,216,188,88,39,82,48,89,67,207,32,3,59,83,80,231,92,116,73,174,208,68,192,238,190,64,20,6,66,11,9,94,53,32,185,163,220,188,172,240,62,71,172,196,104,131,86,191,118,108,79,228,175,159,72,193,236,178,77,35,62,151,101,57,199,195,141,131,140,88,182,254,32,206,91,150,115,36,28,169,215,67,235,204,143,115,0,212,198,153,64,31,13,71,102,9,215,122,204,206,153,241,54,135,152,23,137,153,74,181,161,38,161,57,228,144,197,97,151,37,195,225,251,201,61,97,105,187,88,217,57,231,157,159,85,249,5,91,47,56,218,101,102,219,199,127,216,200,74,109,193,158,35,75,185,226,91,64,54,41,35,65,216,190,56,255,246,31,29,126,232,107,164,155,55,94,62,28,116,85,13,202,5,186,198,186,153,95,40,109,184,162,219,156,212,130,44,99,29,157,30,236,128,97,99,254,54,79,181,141,73,55,111,52,67,224,6,188,45,132,254,8,109,202,37,124,22,160,27,156,174,174,226,170,178,225,105,3,21,131,95,29,85,239,231,163,251,196,119,90,133,43,65,48,5,170,63,109,234,227,240,249,92,147,159,206,255,160,223,163,24,61,191,152,84,237,178,207,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c738511-5733-4fc5-9114-2b98f15b5f10"));
		}

		#endregion

	}

	#endregion

}

