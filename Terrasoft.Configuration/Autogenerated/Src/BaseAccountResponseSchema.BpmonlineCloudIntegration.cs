namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAccountResponseSchema

	/// <exclude/>
	public class BaseAccountResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAccountResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAccountResponseSchema(BaseAccountResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c");
			Name = "BaseAccountResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,203,106,195,48,16,60,199,224,127,88,210,187,117,239,35,208,134,28,11,161,244,7,84,121,237,8,226,149,217,149,8,33,244,223,187,150,236,96,74,116,16,204,104,118,52,59,64,118,64,25,173,67,248,70,102,43,161,139,205,62,80,231,251,196,54,250,64,117,117,171,171,186,218,60,49,246,10,97,127,182,34,207,240,97,5,223,157,11,137,226,151,26,4,18,204,50,99,12,188,74,26,6,203,215,221,140,23,1,184,105,22,186,192,42,65,133,140,221,219,246,129,211,214,236,192,82,11,158,78,200,62,98,91,38,81,154,229,7,179,250,98,76,63,103,239,102,243,135,185,54,101,133,251,14,71,14,35,114,244,168,139,28,243,116,121,255,31,62,19,218,70,180,158,4,180,31,77,174,117,137,237,17,46,39,36,152,108,114,75,224,5,40,68,144,228,156,10,154,187,219,58,232,146,84,34,123,234,225,48,249,125,206,118,55,232,49,190,128,76,215,239,156,22,169,45,129,51,46,236,154,84,102,125,254,0,236,24,229,230,204,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d366b9-fe0c-4c17-99b3-f6cd244e3e7c"));
		}

		#endregion

	}

	#endregion

}

