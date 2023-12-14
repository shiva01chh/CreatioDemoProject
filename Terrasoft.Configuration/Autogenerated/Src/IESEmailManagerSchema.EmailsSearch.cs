namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESEmailManagerSchema

	/// <exclude/>
	public class IESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESEmailManagerSchema(IESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe");
			Name = "IESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,203,78,195,48,16,60,83,169,255,176,42,23,144,170,132,115,155,230,82,42,84,137,138,138,242,3,110,186,73,45,197,118,240,218,69,85,197,191,227,87,10,20,16,185,68,30,207,204,238,236,90,50,129,212,177,10,225,5,181,102,164,106,147,205,149,172,121,99,53,51,92,201,108,33,24,111,105,131,76,87,251,225,224,52,28,92,89,226,178,129,205,145,12,10,71,110,91,172,60,147,178,7,148,168,121,53,29,14,28,235,90,99,227,80,88,74,131,186,118,21,38,176,92,108,130,219,138,73,214,160,14,180,60,207,161,32,43,4,211,199,50,157,215,90,29,248,14,9,4,154,189,218,17,212,74,3,122,37,80,232,195,213,207,122,109,254,69,220,217,109,203,43,224,125,201,159,21,175,78,161,234,185,187,85,172,48,129,117,144,198,203,203,158,2,16,39,16,219,160,236,76,203,47,121,69,199,52,19,32,221,96,103,35,141,175,22,201,140,202,71,78,6,84,157,250,7,50,218,101,160,172,200,3,251,15,177,122,155,43,43,157,58,252,188,220,65,228,226,129,70,99,181,132,3,107,45,254,107,66,79,117,77,232,108,158,189,90,133,131,55,105,252,186,88,235,204,168,115,235,251,197,40,150,161,242,158,135,13,187,152,190,137,52,130,34,239,175,61,127,185,144,86,56,187,109,139,197,39,189,136,65,199,41,112,89,166,49,198,71,117,227,167,146,40,37,164,89,141,253,250,160,207,14,51,184,59,35,41,136,199,110,167,105,143,40,119,113,149,225,252,30,159,222,55,208,97,254,251,0,226,164,179,250,234,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe"));
		}

		#endregion

	}

	#endregion

}

