namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SyncConstsSchema

	/// <exclude/>
	public class SyncConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SyncConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SyncConstsSchema(SyncConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46b057b7-14b5-4c05-b912-248362985d2b");
			Name = "SyncConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,221,106,220,48,16,133,175,215,176,239,32,178,55,237,197,52,94,253,89,38,244,66,214,72,37,16,104,72,218,7,112,189,74,48,236,218,70,178,91,66,233,187,87,206,166,108,13,91,216,14,186,155,209,124,135,115,164,41,182,221,51,121,124,137,163,63,220,172,179,117,214,213,7,31,135,186,241,228,139,15,161,142,253,211,248,193,244,221,83,251,60,133,122,108,251,110,157,253,92,103,171,97,250,182,111,27,210,236,235,24,211,245,174,73,51,113,140,36,181,230,246,234,250,122,243,86,100,243,119,145,13,185,67,125,63,143,188,173,136,99,90,219,144,224,235,93,223,237,95,200,167,169,221,145,187,93,61,204,91,63,15,254,72,189,221,145,143,164,243,63,94,219,239,174,12,103,154,137,202,0,99,78,3,71,153,67,185,53,22,76,133,84,148,20,105,193,213,213,251,155,213,204,57,202,185,132,248,53,250,240,232,195,247,182,241,183,135,161,15,227,191,240,88,84,136,170,146,32,28,75,120,233,12,104,202,13,112,71,93,81,50,158,27,91,36,252,137,190,112,224,181,46,209,115,20,129,109,240,205,44,98,33,65,51,39,168,210,5,40,77,25,112,206,4,40,203,28,84,180,82,28,29,183,154,217,165,3,39,5,240,39,147,139,98,152,154,198,199,248,224,227,180,31,23,18,156,45,133,48,82,130,45,115,11,92,163,129,10,83,28,76,230,204,185,162,208,150,155,243,46,252,159,2,27,66,31,206,240,81,82,71,75,75,65,115,33,129,43,220,66,105,153,132,42,223,162,102,134,106,131,120,142,159,232,151,191,193,249,99,44,168,42,151,233,160,0,99,172,2,46,76,138,0,233,22,80,10,158,140,87,165,52,238,68,253,181,206,210,201,178,223,236,172,85,99,104,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46b057b7-14b5-4c05-b912-248362985d2b"));
		}

		#endregion

	}

	#endregion

}

