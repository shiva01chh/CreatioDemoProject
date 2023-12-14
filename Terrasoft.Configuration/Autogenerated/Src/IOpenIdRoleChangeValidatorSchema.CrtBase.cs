namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOpenIdRoleChangeValidatorSchema

	/// <exclude/>
	public class IOpenIdRoleChangeValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOpenIdRoleChangeValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOpenIdRoleChangeValidatorSchema(IOpenIdRoleChangeValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27d79e02-b230-4aff-9431-c743373f79e9");
			Name = "IOpenIdRoleChangeValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5daf09f1-167a-4d95-90ab-547ed370e530");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,79,77,11,194,48,12,61,111,176,255,80,240,162,32,251,1,122,146,29,164,39,193,175,123,182,102,181,176,165,35,109,15,34,254,119,219,109,138,94,12,57,228,189,228,37,121,4,61,186,1,26,20,103,100,6,103,91,95,86,150,90,163,3,131,55,150,202,195,128,36,213,46,248,91,145,63,138,60,11,206,144,22,167,187,243,216,111,63,248,91,205,152,248,152,11,70,29,87,8,73,30,185,141,71,54,66,78,235,142,182,195,234,6,164,241,10,157,81,224,45,23,121,84,12,161,238,76,35,204,91,240,119,62,75,239,100,181,181,157,168,128,166,246,197,33,75,74,227,203,84,70,43,132,77,242,33,194,15,92,139,125,48,106,36,165,154,1,71,149,84,171,244,252,115,54,128,164,38,15,35,142,108,138,23,39,95,107,209,52,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27d79e02-b230-4aff-9431-c743373f79e9"));
		}

		#endregion

	}

	#endregion

}

