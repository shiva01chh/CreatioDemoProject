namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecificationTermParametersSchema

	/// <exclude/>
	public class ISpecificationTermParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecificationTermParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecificationTermParametersSchema(ISpecificationTermParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7a9ce83e-fd98-4d67-b241-16d384aff5e3");
			Name = "ISpecificationTermParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,78,75,10,194,48,16,93,183,208,59,100,169,155,230,0,150,110,92,136,59,177,189,64,12,19,9,216,52,204,36,130,20,239,238,164,90,105,173,33,132,201,155,247,115,170,3,242,74,131,104,1,81,81,111,66,185,239,157,177,215,136,42,216,222,149,13,224,221,106,224,117,87,228,67,145,103,82,74,81,81,236,58,133,143,250,243,63,131,71,32,112,129,132,18,228,65,91,99,245,168,23,129,133,194,43,228,32,30,169,156,28,228,204,194,199,203,205,106,97,29,51,76,42,115,108,230,30,41,251,244,117,96,254,144,241,179,42,50,2,7,8,255,34,215,153,111,4,33,68,116,84,183,63,146,74,78,155,68,93,22,72,25,75,100,179,221,49,237,89,228,124,211,121,1,27,118,89,32,86,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a9ce83e-fd98-4d67-b241-16d384aff5e3"));
		}

		#endregion

	}

	#endregion

}

