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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,203,78,195,48,16,69,215,177,148,127,24,117,5,11,183,121,148,180,17,98,1,69,32,214,244,7,166,126,20,75,137,29,121,108,144,133,250,239,36,89,84,69,8,193,44,239,156,25,157,27,201,216,35,188,38,10,170,191,205,89,206,44,246,138,6,20,10,246,202,123,36,167,195,114,231,172,54,199,232,49,24,103,115,246,153,179,108,136,135,206,8,160,48,102,2,68,135,68,112,111,173,121,87,158,208,167,125,26,212,120,69,129,70,118,226,179,213,234,114,15,97,4,128,195,131,241,225,77,98,154,136,239,47,189,66,233,108,151,224,57,26,121,230,94,36,220,129,85,31,115,122,181,40,55,181,188,105,100,197,181,20,200,165,46,75,222,30,42,228,69,81,202,166,80,109,189,21,205,226,122,238,245,155,193,206,245,3,218,4,218,69,43,231,130,240,15,159,167,51,253,248,67,170,106,215,235,166,86,155,63,165,178,83,206,78,147,219,229,124,1,148,217,105,61,145,1,0,0 };
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

