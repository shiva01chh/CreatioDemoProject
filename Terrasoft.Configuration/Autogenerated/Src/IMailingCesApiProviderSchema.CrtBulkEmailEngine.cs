namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingCesApiProviderSchema

	/// <exclude/>
	public class IMailingCesApiProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingCesApiProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingCesApiProviderSchema(IMailingCesApiProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f92e69c-eee5-45ac-b699-e41c1b0f5a69");
			Name = "IMailingCesApiProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3e4ee87-43fa-403d-acda-7e0e57f41b53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,219,106,131,64,16,125,78,32,255,48,36,175,69,223,147,54,208,88,41,66,11,1,251,3,27,51,218,165,186,43,179,171,37,72,254,189,179,222,34,141,17,68,103,230,236,185,204,42,81,160,41,69,130,240,133,68,194,232,212,122,129,86,169,204,42,18,86,106,181,90,54,171,229,162,50,82,101,16,95,140,197,98,55,214,129,38,188,85,15,8,188,32,140,25,196,176,13,97,198,13,136,148,69,74,89,115,11,209,167,144,57,31,14,208,188,150,242,72,186,150,103,164,22,237,251,62,60,155,170,40,4,93,246,125,221,3,12,200,129,2,172,6,93,34,75,33,252,74,251,13,17,203,49,21,35,140,21,42,65,111,160,242,39,92,101,117,202,101,50,97,153,247,113,243,119,115,182,104,90,119,99,24,158,176,188,149,104,182,112,108,105,221,212,189,255,3,180,141,168,183,5,58,229,33,34,36,132,233,203,250,80,229,63,97,193,90,97,141,202,126,232,44,67,90,251,251,39,40,135,196,57,247,220,150,57,239,29,24,172,56,229,200,113,224,237,224,141,210,211,192,139,57,129,123,34,215,108,32,67,187,131,107,23,115,54,196,59,90,3,154,192,184,175,156,79,212,223,3,135,152,55,52,220,83,140,84,203,4,221,111,167,124,29,246,183,65,117,238,150,220,90,233,12,77,155,220,113,207,31,35,206,30,216,195,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f92e69c-eee5-45ac-b699-e41c1b0f5a69"));
		}

		#endregion

	}

	#endregion

}

