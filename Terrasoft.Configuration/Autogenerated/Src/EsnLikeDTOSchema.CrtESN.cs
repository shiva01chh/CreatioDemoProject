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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,110,194,48,12,134,207,32,241,14,17,92,182,75,31,96,104,167,130,80,165,193,170,149,157,166,29,66,106,42,107,77,90,217,201,129,161,189,251,156,86,108,99,42,18,228,16,233,183,127,127,78,156,56,109,129,91,109,64,109,129,72,115,179,247,73,218,184,61,86,129,180,199,198,37,203,98,51,25,31,39,227,81,96,116,149,42,14,236,193,206,255,233,228,37,56,143,22,146,2,8,117,141,159,93,173,184,196,55,35,168,68,168,180,214,204,15,106,201,238,9,63,96,177,125,238,178,111,11,237,181,116,244,164,141,127,151,64,27,118,53,26,101,162,251,204,60,138,135,248,161,229,212,180,64,30,65,144,121,87,210,225,122,222,26,236,14,232,110,35,151,83,143,106,138,229,244,62,162,79,236,85,192,82,101,165,58,170,10,252,92,113,220,190,46,151,115,99,228,78,107,96,214,21,100,67,172,226,220,113,45,56,48,208,32,239,181,75,92,139,49,50,61,25,222,32,41,61,229,110,132,69,121,142,99,79,241,189,211,223,252,141,200,156,208,106,58,100,246,210,20,211,33,223,80,147,25,184,178,255,6,162,250,216,223,144,68,100,125,3,92,213,131,239,218,2,0,0 };
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

