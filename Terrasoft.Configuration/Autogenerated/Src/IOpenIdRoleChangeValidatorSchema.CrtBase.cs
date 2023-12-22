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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,79,77,11,194,48,12,61,111,176,255,80,240,162,32,251,1,122,146,29,164,39,193,175,123,183,102,93,161,75,71,218,30,68,252,239,182,219,148,121,49,228,144,247,146,151,228,161,232,193,13,162,1,118,5,34,225,108,235,203,202,98,171,85,32,225,181,197,242,52,0,114,121,8,190,43,242,103,145,103,193,105,84,236,242,112,30,250,253,23,47,213,4,137,143,185,34,80,113,5,227,232,129,218,120,100,199,248,180,238,108,13,84,157,64,5,119,97,180,20,222,82,145,71,197,16,106,163,27,166,63,130,191,243,89,122,39,171,173,53,172,18,56,181,111,14,136,99,26,95,167,50,90,65,104,146,15,22,126,224,150,29,131,150,35,201,229,12,40,170,184,220,164,231,95,179,1,64,57,121,24,113,100,151,241,6,111,152,33,51,60,1,0,0 };
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

