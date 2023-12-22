namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnLikeDTOSchema

	/// <exclude/>
	public class EsnLikeDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnLikeDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnLikeDTOSchema(EsnLikeDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9ba4548-db18-453f-afd7-0da2ee2c2296");
			Name = "EsnLikeDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,110,194,48,12,134,207,32,241,14,17,92,182,75,31,96,104,167,130,166,74,131,85,43,59,77,59,132,212,84,214,154,180,178,147,3,67,123,247,57,69,108,116,42,18,228,16,233,183,127,127,78,156,56,109,129,91,109,64,109,128,72,115,179,243,73,218,184,29,86,129,180,199,198,37,203,98,61,25,31,38,227,81,96,116,149,42,246,236,193,206,255,233,228,53,56,143,22,146,2,8,117,141,95,93,173,184,196,55,35,168,68,168,180,214,204,15,106,201,238,25,63,97,177,121,233,178,239,11,237,181,116,244,164,141,255,144,64,27,182,53,26,101,162,187,103,30,197,67,252,210,114,106,90,32,143,32,200,188,43,233,112,71,222,10,236,22,232,110,45,151,83,143,106,138,229,244,62,162,79,236,167,128,165,202,74,117,80,21,248,185,226,184,125,95,46,231,198,200,157,86,192,172,43,200,134,88,69,223,113,45,56,48,208,32,239,173,75,92,139,49,50,61,25,222,32,41,61,229,110,132,69,217,199,177,167,248,222,233,95,254,70,100,78,104,53,237,51,123,105,138,233,144,111,168,201,12,92,121,252,6,162,142,177,243,144,68,206,215,15,117,17,219,81,227,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9ba4548-db18-453f-afd7-0da2ee2c2296"));
		}

		#endregion

	}

	#endregion

}

