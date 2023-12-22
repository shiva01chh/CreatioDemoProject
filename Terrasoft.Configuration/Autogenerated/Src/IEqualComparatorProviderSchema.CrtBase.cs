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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,10,130,80,16,69,215,10,254,195,131,54,181,241,3,106,105,18,238,2,251,129,151,142,54,160,51,175,113,94,96,209,191,103,74,20,66,209,236,238,112,239,185,92,178,45,116,206,22,96,14,32,98,59,174,52,78,152,42,172,189,88,69,166,56,37,69,237,243,158,138,147,48,225,117,252,70,225,45,10,163,48,88,8,212,131,52,25,41,72,53,96,214,38,75,207,222,54,9,183,206,14,4,150,189,240,5,75,144,209,239,252,177,193,194,224,203,254,195,29,76,13,193,172,57,225,198,183,244,14,152,29,104,174,130,84,207,72,203,213,230,111,192,214,42,124,137,223,167,157,64,229,52,245,41,199,223,231,61,0,65,95,206,102,70,1,0,0 };
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

