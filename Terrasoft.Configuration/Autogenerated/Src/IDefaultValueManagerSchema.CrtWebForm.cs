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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,77,79,195,48,12,134,207,84,234,127,176,118,2,105,106,127,0,163,23,38,166,29,184,48,62,206,94,235,84,65,173,51,57,201,80,133,248,239,56,235,216,7,91,20,41,137,29,63,126,243,134,177,39,191,193,154,224,149,68,208,59,19,138,71,199,198,182,81,48,88,199,197,130,152,116,75,205,7,173,159,156,244,43,146,173,173,41,207,190,243,236,38,122,203,45,172,6,31,168,191,255,119,86,78,215,81,157,32,126,164,216,250,120,231,180,157,80,138,235,44,203,18,102,62,246,61,202,80,237,207,47,20,162,176,135,134,12,198,46,192,22,187,72,30,140,19,104,237,150,24,58,228,38,17,117,1,226,96,195,80,252,161,202,19,214,38,174,59,91,131,229,64,98,210,131,151,243,145,248,158,128,207,200,216,146,232,189,244,172,11,33,187,192,138,194,53,21,199,158,151,77,199,200,6,5,123,96,181,250,97,18,61,137,26,204,163,49,147,106,201,62,32,171,28,103,32,229,160,62,36,139,89,185,171,188,14,250,26,191,99,217,40,163,73,26,140,213,106,165,236,253,56,171,158,219,29,81,85,205,124,16,205,78,193,173,63,181,77,5,11,26,29,240,183,139,104,27,56,96,167,240,118,38,21,206,149,223,165,47,251,201,51,157,121,118,58,126,1,155,213,18,56,82,2,0,0 };
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

