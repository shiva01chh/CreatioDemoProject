namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryTypeConstsSchema

	/// <exclude/>
	public class AnniversaryTypeConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryTypeConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryTypeConstsSchema(AnniversaryTypeConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a51c8b1b-32d7-45c3-a82d-781a607be12f");
			Name = "AnniversaryTypeConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,77,75,195,64,16,134,207,9,236,127,24,122,210,195,182,249,168,169,161,120,208,138,226,217,254,129,233,126,212,133,100,54,236,135,178,72,255,187,73,14,69,17,169,115,124,231,153,225,121,163,55,116,132,215,228,131,234,183,44,103,57,97,175,252,128,66,193,94,57,135,222,234,176,220,89,210,230,24,29,6,99,137,229,159,44,207,134,120,232,140,0,31,198,76,128,232,208,123,184,39,50,239,202,121,116,105,159,6,53,94,249,224,71,118,226,179,213,234,251,30,194,8,0,135,7,227,194,155,196,52,17,63,95,58,133,210,82,151,224,57,26,121,230,94,36,220,1,169,143,57,189,90,148,155,90,222,52,178,226,90,10,228,82,151,37,111,15,21,242,162,40,101,83,168,182,190,21,205,226,122,238,245,151,193,206,246,3,82,2,109,35,201,185,32,252,195,231,233,76,63,254,146,170,218,245,186,169,213,230,162,84,118,98,249,105,114,155,230,11,98,38,222,189,137,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a51c8b1b-32d7-45c3-a82d-781a607be12f"));
		}

		#endregion

	}

	#endregion

}

