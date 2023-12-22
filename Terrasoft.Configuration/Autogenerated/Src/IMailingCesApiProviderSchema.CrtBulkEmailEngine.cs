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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,219,106,131,64,16,125,54,144,127,24,146,215,162,239,73,27,104,172,20,161,133,128,253,129,141,25,237,82,221,149,217,213,18,36,255,222,241,46,141,17,68,103,230,236,185,204,42,145,163,41,68,140,240,133,68,194,232,196,186,190,86,137,76,75,18,86,106,181,94,213,235,149,83,26,169,82,136,174,198,98,190,31,107,95,19,78,213,3,2,215,15,34,6,49,108,75,152,114,3,66,101,145,18,214,220,65,248,41,100,198,135,125,52,175,133,60,145,174,228,5,169,69,123,158,7,207,166,204,115,65,215,67,95,247,0,3,114,160,0,171,65,23,200,82,8,191,210,126,67,200,114,76,197,8,99,133,138,209,29,168,188,25,87,81,158,51,25,207,88,150,125,76,254,38,103,78,221,186,27,195,240,132,229,173,68,179,131,83,75,219,76,155,247,127,128,182,17,246,182,64,39,60,68,132,152,48,121,217,28,203,236,39,200,89,43,168,80,217,15,157,166,72,27,239,240,4,197,144,56,227,94,179,101,206,123,7,6,43,206,25,114,28,120,59,186,163,244,60,176,179,36,112,79,212,52,107,72,209,238,225,214,197,92,12,241,142,214,128,38,48,205,87,46,39,234,239,129,67,44,27,26,238,41,66,170,100,140,205,111,167,124,27,246,183,69,117,233,150,220,90,233,12,205,155,220,153,63,127,30,21,43,168,203,2,0,0 };
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

