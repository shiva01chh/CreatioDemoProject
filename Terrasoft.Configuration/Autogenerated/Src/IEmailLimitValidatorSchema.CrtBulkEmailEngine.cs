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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,193,74,195,64,16,61,183,208,127,24,210,139,130,36,119,77,115,41,34,5,5,105,213,251,154,76,210,129,236,110,156,221,173,148,226,191,59,219,166,161,182,106,200,37,47,51,111,222,123,51,70,105,116,157,42,17,94,144,89,57,91,251,116,110,77,77,77,96,229,201,154,201,120,55,25,143,130,35,211,192,106,235,60,234,187,201,88,144,41,99,35,191,97,97,60,114,45,4,183,176,184,215,138,218,71,210,228,223,84,75,149,242,150,165,82,222,44,203,32,119,65,107,197,219,162,255,126,102,187,161,10,29,104,244,107,91,57,240,22,54,135,54,4,140,76,240,73,126,13,14,77,21,135,183,145,215,165,71,182,236,132,174,11,239,45,149,64,71,41,127,41,217,237,149,95,168,217,3,125,157,232,137,86,219,94,66,58,212,103,231,13,121,167,88,105,48,18,224,44,145,16,157,106,112,81,37,197,171,161,143,128,32,214,140,167,154,144,193,214,224,215,8,125,77,154,103,251,206,223,137,24,75,234,72,90,221,220,6,227,147,98,57,0,80,70,228,71,76,181,229,243,124,46,216,25,125,96,227,138,222,96,220,25,163,11,173,79,101,119,206,43,35,121,137,194,220,33,66,201,88,207,146,31,251,95,33,111,168,196,165,92,137,53,14,147,172,144,17,71,206,56,228,191,234,33,213,167,131,247,171,135,64,21,12,97,221,196,149,193,153,229,107,185,175,209,215,225,110,166,226,237,112,103,113,115,2,158,62,223,230,102,134,75,187,2,0,0 };
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

