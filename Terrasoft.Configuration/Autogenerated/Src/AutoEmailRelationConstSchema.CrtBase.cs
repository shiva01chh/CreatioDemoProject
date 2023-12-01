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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,203,142,219,48,12,69,215,19,32,255,96,204,108,218,5,7,164,245,176,140,65,23,142,227,20,93,21,152,153,126,128,34,209,169,1,91,54,252,64,97,20,253,247,170,105,87,233,203,130,22,210,21,201,131,43,50,216,142,167,193,58,78,94,121,28,237,212,215,243,99,217,135,186,185,44,163,157,155,62,60,22,203,220,87,157,109,218,103,110,175,202,126,247,117,191,187,91,166,38,92,146,151,117,154,185,123,138,247,184,31,70,190,196,247,164,108,237,52,37,191,229,197,178,211,188,223,197,192,97,57,183,141,75,166,57,234,46,113,255,12,191,251,1,187,201,24,217,250,62,180,107,242,126,105,124,82,117,67,219,175,204,31,124,242,46,9,252,229,170,190,185,215,152,9,81,157,74,56,9,125,0,146,132,80,24,35,128,244,209,136,178,56,96,110,240,254,237,211,255,170,127,92,198,178,239,6,27,214,215,117,184,101,168,76,82,122,42,142,160,68,165,225,120,34,130,60,163,3,32,210,81,99,149,11,83,234,13,140,104,117,182,110,126,113,159,185,179,159,110,24,164,207,44,180,34,48,53,167,32,73,229,96,188,71,176,6,133,151,218,8,239,197,6,70,225,92,191,132,191,48,82,229,51,71,246,12,228,25,65,42,36,56,75,76,1,83,70,86,54,75,189,230,237,62,226,127,117,75,104,220,181,141,127,6,34,74,155,83,74,144,82,109,64,90,98,48,57,197,147,114,88,103,74,179,149,180,221,212,6,160,33,39,133,212,4,168,41,7,41,189,7,131,89,180,153,165,177,133,6,141,114,191,58,245,237,58,162,15,28,252,207,113,222,239,162,18,215,119,169,106,128,149,42,3,0,0 };
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

