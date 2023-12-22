namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailRelationConstSchema

	/// <exclude/>
	public class AutoEmailRelationConstSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailRelationConstSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailRelationConstSchema(AutoEmailRelationConstSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd");
			Name = "AutoEmailRelationConst";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,139,220,48,12,134,207,59,48,255,193,236,94,218,131,22,41,118,28,135,165,135,76,38,83,122,42,116,183,63,192,99,43,211,64,226,132,124,80,66,233,127,175,59,237,161,76,191,98,124,176,95,75,122,120,45,5,219,241,52,88,199,226,133,199,209,78,125,61,63,150,125,168,155,203,50,218,185,233,195,99,177,204,125,213,217,166,253,192,237,85,217,239,190,236,119,119,203,212,132,139,120,94,167,153,187,167,120,143,251,97,228,75,124,23,101,107,167,73,252,150,23,203,78,243,126,23,3,135,229,220,54,78,76,115,212,157,112,255,12,191,251,14,187,201,24,217,250,62,180,171,120,187,52,94,84,221,208,246,43,243,59,47,222,136,192,159,175,234,171,123,141,153,148,213,169,132,147,212,7,32,69,8,133,49,18,72,31,141,44,139,3,230,6,239,95,63,253,175,250,251,101,44,251,110,176,97,125,89,135,91,70,154,41,74,78,197,17,82,89,105,56,158,136,32,207,232,0,136,116,212,88,229,210,148,122,3,35,90,157,173,155,159,221,39,238,236,199,27,6,233,51,75,157,18,152,154,19,80,148,230,96,188,71,176,6,165,87,218,72,239,229,6,70,225,92,191,132,191,48,146,212,103,142,236,25,200,51,130,74,145,224,172,48,1,76,24,57,181,89,226,53,111,247,17,255,171,91,66,227,174,109,252,51,16,81,217,156,18,130,132,106,3,202,18,131,201,41,158,82,135,117,150,106,182,138,182,155,218,0,52,228,148,84,154,0,53,229,160,148,247,96,48,139,54,179,36,182,208,160,73,221,207,78,125,189,142,232,3,7,255,99,156,247,187,168,252,186,190,1,145,103,61,25,51,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd"));
		}

		#endregion

	}

	#endregion

}

