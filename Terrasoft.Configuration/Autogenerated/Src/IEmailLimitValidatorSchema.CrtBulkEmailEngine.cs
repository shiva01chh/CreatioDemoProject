namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailLimitValidatorSchema

	/// <exclude/>
	public class IEmailLimitValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailLimitValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailLimitValidatorSchema(IEmailLimitValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45824530-29b2-4569-b8ff-91a6519d7e62");
			Name = "IEmailLimitValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,193,74,195,64,16,61,183,208,127,24,210,139,130,36,119,109,115,41,34,5,5,105,213,251,154,76,210,129,236,110,156,221,173,148,226,191,59,219,164,193,182,106,200,37,47,51,111,222,123,51,70,105,116,173,42,16,94,144,89,57,91,249,116,97,77,69,117,96,229,201,154,201,120,63,25,143,130,35,83,195,122,231,60,234,187,201,88,144,41,99,45,191,97,105,60,114,37,4,183,176,188,215,138,154,71,210,228,223,84,67,165,242,150,165,82,222,44,203,96,230,130,214,138,119,121,255,253,204,118,75,37,58,208,232,55,182,116,224,45,108,187,54,4,140,76,240,73,126,3,14,77,25,135,55,145,215,165,71,182,236,7,93,27,222,27,42,128,142,82,254,82,178,63,40,191,80,115,0,250,58,209,19,173,54,189,132,116,168,207,206,27,102,173,98,165,193,72,128,243,68,66,116,170,198,101,153,228,175,134,62,2,130,88,51,158,42,66,6,91,129,223,32,244,53,233,44,59,116,254,78,196,88,80,75,210,234,22,54,24,159,228,171,1,128,34,34,39,49,85,150,207,243,185,96,103,244,129,141,203,123,131,113,103,140,46,52,62,149,221,57,175,140,228,37,10,103,14,17,10,198,106,158,156,236,127,141,188,165,2,87,114,37,214,56,76,178,92,70,28,57,227,144,255,170,135,84,159,58,239,87,15,129,74,24,194,186,137,43,131,51,203,215,114,95,163,175,238,110,166,226,173,187,179,184,57,1,229,249,6,190,187,211,215,178,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45824530-29b2-4569-b8ff-91a6519d7e62"));
		}

		#endregion

	}

	#endregion

}

