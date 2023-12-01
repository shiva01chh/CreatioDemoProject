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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,203,78,195,48,16,69,215,177,228,127,24,117,5,11,183,121,148,148,168,98,1,69,32,214,244,7,166,126,20,75,137,29,249,1,178,80,255,29,39,139,10,132,80,153,229,157,51,163,115,163,215,230,8,175,201,7,57,108,41,161,196,224,32,253,136,92,194,94,58,135,222,170,176,220,89,163,244,49,58,12,218,26,74,62,41,41,198,120,232,53,7,31,114,198,129,247,232,61,220,27,163,223,165,243,232,210,62,141,50,95,249,224,51,59,241,197,106,245,125,15,33,3,192,224,65,187,240,38,48,77,196,207,151,78,162,176,166,79,240,28,181,56,115,47,2,238,192,200,143,57,189,90,84,155,70,220,180,162,102,74,112,100,66,85,21,235,14,53,178,178,172,68,91,202,174,185,229,237,226,122,238,245,151,193,206,14,35,154,4,202,70,35,230,130,240,15,159,167,51,253,248,75,170,238,214,235,182,145,155,139,82,197,137,146,211,228,150,231,11,220,14,190,108,136,1,0,0 };
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

