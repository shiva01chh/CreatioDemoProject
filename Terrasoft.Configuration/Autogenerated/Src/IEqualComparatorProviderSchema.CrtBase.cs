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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,205,10,130,80,16,133,215,10,190,195,133,54,181,241,1,106,105,18,238,2,123,129,155,142,54,160,51,183,113,110,96,209,187,231,15,17,8,69,179,59,195,57,223,225,144,109,161,115,182,0,115,2,17,219,113,165,113,194,84,97,237,197,42,50,197,41,41,106,159,247,84,92,132,9,239,211,55,10,31,81,24,133,193,74,160,30,164,201,72,65,170,1,179,53,89,122,245,182,73,184,117,118,32,176,28,133,111,88,130,76,126,231,207,13,22,6,223,246,31,238,96,110,8,22,205,9,55,190,165,79,192,28,64,115,21,164,122,65,90,111,118,127,3,246,86,225,75,252,57,239,4,42,231,169,163,156,126,227,189,0,201,112,232,59,62,1,0,0 };
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

