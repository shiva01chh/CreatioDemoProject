namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDefaultValueManagerSchema

	/// <exclude/>
	public class IDefaultValueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDefaultValueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDefaultValueManagerSchema(IDefaultValueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("823db1cb-37ea-4cab-bf5f-dc43956066ce");
			Name = "IDefaultValueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,77,79,195,48,12,134,207,84,234,127,176,118,2,105,106,127,0,99,23,38,166,29,184,48,62,206,110,235,84,65,173,83,57,201,208,132,248,239,56,235,216,7,91,20,41,137,29,63,126,243,134,177,39,63,96,77,240,74,34,232,157,9,197,163,99,99,219,40,24,172,227,98,73,76,186,165,230,131,170,39,39,253,154,100,99,107,202,179,239,60,187,137,222,114,11,235,173,15,212,223,255,59,43,167,235,168,78,16,63,82,108,125,188,115,218,78,40,197,117,150,101,9,51,31,251,30,101,59,223,159,95,40,68,97,15,13,25,140,93,128,13,118,145,60,24,39,208,218,13,49,116,200,77,34,234,2,196,193,134,109,241,135,42,79,88,67,172,58,91,131,229,64,98,210,131,87,139,145,248,158,128,207,200,216,146,232,189,244,172,11,33,187,192,154,194,53,21,199,158,151,77,199,200,128,130,61,176,90,253,48,137,158,68,13,230,209,152,201,124,197,62,32,171,28,103,32,229,160,62,36,139,89,185,171,188,14,250,26,191,99,213,40,163,73,26,140,213,106,165,236,253,56,171,94,216,29,81,85,205,124,16,205,78,193,85,159,218,102,14,75,26,29,240,183,203,104,27,56,96,167,240,118,38,21,206,149,223,165,47,251,201,51,157,121,150,198,47,197,151,127,149,74,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("823db1cb-37ea-4cab-bf5f-dc43956066ce"));
		}

		#endregion

	}

	#endregion

}

