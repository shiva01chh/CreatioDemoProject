namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IRepositorySchema

	/// <exclude/>
	public class IRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IRepositorySchema(IRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949");
			Name = "IRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,75,195,64,16,61,87,240,63,12,241,82,65,146,187,198,128,74,91,122,147,54,224,121,147,76,235,194,126,132,253,80,130,248,223,157,205,54,177,86,173,10,230,182,147,55,111,222,123,59,137,98,18,109,203,106,132,18,141,97,86,111,92,122,167,213,134,111,189,97,142,107,117,122,242,114,122,50,241,150,171,45,172,59,235,80,94,29,156,9,47,4,214,1,108,211,5,42,52,188,38,12,161,206,12,110,169,10,75,229,208,108,104,200,37,44,87,216,106,203,157,54,93,15,201,178,12,114,235,165,100,166,43,118,231,18,101,43,152,195,6,204,8,6,167,129,85,214,25,86,59,176,84,97,91,76,135,254,236,128,32,119,93,139,45,51,76,130,34,127,215,73,153,20,107,234,33,70,84,142,59,98,35,64,154,103,35,46,116,182,190,18,188,6,62,136,221,215,154,151,5,60,63,162,161,152,224,18,110,153,197,192,199,42,129,179,158,144,218,67,76,159,236,244,133,21,58,111,148,29,102,87,29,240,38,29,209,217,33,60,223,87,206,155,164,136,35,66,83,158,141,106,35,212,68,234,29,132,222,15,133,128,40,97,206,85,51,93,120,222,80,243,121,188,147,175,37,222,25,164,192,71,137,92,13,25,3,83,225,26,162,1,238,236,31,164,71,174,164,232,185,195,186,224,32,242,168,137,232,115,223,71,111,32,42,156,150,59,150,163,110,86,40,245,19,254,119,224,79,154,100,68,234,223,100,58,89,35,51,245,35,134,216,80,218,160,162,165,13,228,53,217,72,225,151,106,134,142,190,43,41,238,71,130,111,67,140,83,233,202,172,23,238,32,200,229,76,121,137,253,218,134,133,126,8,11,61,157,123,85,231,229,5,84,90,139,2,62,12,252,33,228,247,173,166,239,98,239,155,252,206,216,40,113,183,90,125,46,199,37,46,208,221,8,49,13,66,38,175,241,159,130,170,137,191,149,112,164,26,61,111,101,112,53,197,197,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb47eba1-93f4-4a26-a75c-b68259fb6949"));
		}

		#endregion

	}

	#endregion

}

