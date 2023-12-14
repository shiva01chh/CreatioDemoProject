namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountConstsSchema

	/// <exclude/>
	public class AccountConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountConstsSchema(AccountConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a6894da9-d220-412d-8d46-9dc9c008ba69");
			Name = "AccountConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,143,193,106,195,48,16,68,207,22,232,31,150,228,210,28,212,196,216,33,42,165,135,88,86,66,79,61,180,63,160,202,74,16,216,146,209,74,4,83,250,239,145,77,91,232,48,151,153,125,12,108,66,235,174,240,62,97,52,195,51,37,148,56,53,24,28,149,54,240,97,66,80,232,47,241,81,120,119,177,215,20,84,180,222,81,242,69,73,49,166,207,222,106,192,152,59,13,186,87,136,112,212,218,39,23,51,141,17,51,51,115,197,118,11,235,95,1,131,37,252,53,51,240,127,41,24,213,121,215,79,112,78,182,131,183,20,132,31,70,229,166,159,237,215,14,94,192,153,219,114,126,88,201,106,199,155,3,47,89,37,246,13,171,165,104,24,127,146,39,182,23,165,108,235,246,88,115,46,87,155,252,87,241,77,73,246,172,59,42,189,31,111,242,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a6894da9-d220-412d-8d46-9dc9c008ba69"));
		}

		#endregion

	}

	#endregion

}

