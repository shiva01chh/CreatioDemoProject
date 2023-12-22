namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFolderManagerServiceSchema

	/// <exclude/>
	public class IFolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFolderManagerServiceSchema(IFolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13");
			Name = "IFolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,193,106,227,48,16,61,187,208,127,16,233,37,133,224,15,232,210,75,119,183,197,11,105,75,157,165,135,144,131,42,141,83,177,178,228,142,228,44,166,236,191,239,200,178,157,184,155,20,22,82,168,241,69,111,102,222,60,189,177,199,240,18,92,197,5,176,5,32,114,103,11,159,126,181,166,80,235,26,185,87,214,164,215,86,75,192,57,55,124,13,152,3,110,148,128,211,147,215,211,147,164,118,202,172,89,222,56,15,229,151,55,103,34,209,26,68,96,112,233,13,24,64,37,254,201,233,216,230,86,130,126,55,152,62,194,211,54,97,87,41,194,40,145,164,123,228,194,83,50,165,159,33,172,73,0,203,140,7,44,232,146,23,44,219,127,157,132,222,101,119,234,57,166,183,228,13,187,100,147,125,37,147,243,21,149,84,245,147,86,130,169,158,255,32,125,176,107,144,51,7,255,108,165,187,96,247,109,121,43,53,89,222,85,16,29,239,251,175,90,152,110,158,153,141,253,5,211,88,22,4,221,223,229,139,201,140,253,68,181,128,178,210,220,183,50,169,110,3,232,163,2,10,95,89,217,228,190,209,33,72,44,115,112,142,68,13,104,250,136,188,170,64,206,88,232,147,60,192,75,13,142,170,177,228,126,84,17,161,244,135,179,102,198,30,232,107,161,145,194,251,121,173,57,201,198,42,201,70,170,166,55,53,65,6,126,199,99,70,205,91,164,226,8,198,111,65,231,49,12,154,48,229,155,92,60,67,201,195,48,206,195,55,144,28,213,173,133,205,61,241,136,207,227,218,21,119,208,231,179,189,42,143,224,226,113,60,204,140,208,181,132,239,161,129,2,151,153,255,117,177,179,111,246,81,94,142,54,89,247,55,14,222,30,80,63,237,108,115,182,70,1,91,219,6,63,37,137,84,38,82,110,163,237,21,70,142,211,6,172,75,19,130,61,117,219,170,233,166,85,188,157,83,161,52,173,17,23,53,31,111,72,223,64,131,135,207,54,153,93,85,195,68,118,193,195,99,8,238,45,87,12,65,88,148,174,55,234,12,140,140,251,149,78,127,226,250,31,32,250,89,9,218,125,254,2,171,23,102,120,248,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13"));
		}

		#endregion

	}

	#endregion

}

