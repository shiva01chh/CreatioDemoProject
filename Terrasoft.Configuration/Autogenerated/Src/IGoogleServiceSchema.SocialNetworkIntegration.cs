namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IGoogleServiceSchema

	/// <exclude/>
	public class IGoogleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IGoogleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IGoogleServiceSchema(IGoogleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c");
			Name = "IGoogleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,79,107,194,64,16,197,207,10,126,135,193,94,20,36,185,171,21,90,161,146,130,85,26,193,131,120,88,147,73,92,154,236,166,251,71,8,210,239,222,113,215,136,214,98,110,251,230,237,111,231,205,68,176,18,117,197,18,132,21,42,197,180,204,76,48,149,34,227,185,85,204,112,41,130,88,38,156,21,157,246,177,211,110,89,205,69,14,113,173,13,150,65,140,234,192,19,156,203,20,139,209,163,98,240,146,24,126,112,180,199,190,53,238,200,64,150,39,133,57,185,33,18,6,85,70,221,13,33,154,73,153,23,120,246,59,215,230,124,160,126,141,98,137,233,125,80,24,120,134,238,141,181,219,223,146,183,178,187,130,39,192,27,224,29,175,117,116,204,203,211,115,52,123,153,234,33,44,221,77,95,12,195,16,198,218,150,37,83,245,164,17,62,209,88,37,52,36,82,80,9,21,61,146,73,85,186,188,192,118,210,26,200,221,91,160,247,76,97,10,172,170,136,232,167,123,161,134,127,177,99,229,185,147,233,63,220,96,28,54,229,147,127,179,168,208,175,171,153,197,214,201,52,208,72,28,228,23,246,124,156,211,112,150,139,120,213,29,80,215,223,22,181,121,115,68,210,201,58,71,173,89,142,94,10,222,181,20,3,120,149,105,29,155,186,192,27,203,69,13,214,138,210,96,122,226,233,138,26,197,199,64,183,139,150,31,125,147,43,162,88,205,109,152,161,185,214,123,253,209,121,45,40,82,191,25,119,254,241,191,201,141,72,218,245,247,11,160,147,39,99,218,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("956a9445-e36a-4d6f-9741-e5836ee6b58c"));
		}

		#endregion

	}

	#endregion

}

