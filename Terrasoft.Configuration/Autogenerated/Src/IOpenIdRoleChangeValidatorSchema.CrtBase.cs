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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,79,77,11,194,48,12,61,111,176,255,80,240,162,32,251,1,122,146,29,164,39,193,175,123,183,102,181,176,165,35,109,15,34,254,119,211,109,138,94,12,57,228,189,228,37,121,168,122,240,131,106,64,156,129,72,121,215,134,178,114,216,90,19,73,5,235,176,60,12,128,82,239,98,184,21,249,163,200,179,232,45,26,113,186,251,0,253,246,131,191,213,4,137,231,92,16,24,94,33,36,6,160,150,143,108,132,156,214,29,93,7,213,77,161,129,171,234,172,86,193,81,145,179,98,136,117,103,27,97,223,130,191,243,89,122,39,171,157,235,68,165,112,106,95,60,144,196,52,190,76,37,91,65,104,146,15,17,127,224,90,236,163,213,35,41,245,12,136,85,82,175,210,243,207,217,0,160,158,60,140,152,89,142,23,136,166,82,223,51,1,0,0 };
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

