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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,143,65,139,194,48,20,132,207,13,228,63,60,220,139,123,136,174,216,178,17,241,96,99,118,241,228,65,255,64,76,163,4,218,164,228,37,44,69,252,239,27,69,5,135,185,204,188,143,129,151,208,186,51,236,7,140,166,91,82,66,137,83,157,193,94,105,3,7,19,130,66,127,138,19,225,221,201,158,83,80,209,122,71,201,133,146,162,79,199,214,106,192,152,59,13,186,85,136,176,214,218,39,23,51,141,17,51,115,227,138,233,20,62,158,2,6,247,240,106,110,192,251,82,48,170,241,174,29,224,55,217,6,118,41,8,223,245,202,13,143,237,109,3,43,112,230,239,126,30,143,228,252,139,215,223,124,198,230,162,170,89,41,69,205,248,66,254,176,74,204,228,166,220,172,75,206,229,232,51,255,85,92,41,201,206,250,7,250,187,160,160,241,0,0,0 };
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

