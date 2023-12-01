namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEqualComparatorProviderSchema

	/// <exclude/>
	public class IEqualComparatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEqualComparatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEqualComparatorProviderSchema(IEqualComparatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16767ff9-f891-4a8b-8bb0-10d7f21c7208");
			Name = "IEqualComparatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,10,130,80,16,69,215,10,254,195,131,54,181,241,3,106,105,18,238,2,251,129,151,142,54,160,51,58,206,11,44,250,247,94,74,4,66,209,236,238,112,239,185,92,178,45,12,157,45,192,156,64,196,14,92,105,156,48,85,88,59,177,138,76,113,74,138,58,230,35,21,23,97,194,219,244,141,194,123,20,70,97,176,18,168,189,52,25,41,72,229,49,91,147,165,189,179,77,194,109,103,61,129,229,40,124,197,18,100,242,119,238,220,96,97,240,109,255,225,14,230,134,96,209,156,112,227,90,250,4,204,1,52,87,65,170,23,164,245,102,247,55,96,111,21,190,196,31,243,78,160,114,158,250,146,211,207,223,19,12,113,58,137,61,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16767ff9-f891-4a8b-8bb0-10d7f21c7208"));
		}

		#endregion

	}

	#endregion

}

