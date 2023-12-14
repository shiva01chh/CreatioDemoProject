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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,221,106,220,48,16,133,175,215,176,239,32,178,55,237,197,52,94,253,89,38,244,66,214,72,37,16,104,72,218,7,112,189,74,48,236,218,70,178,91,66,233,187,87,206,166,108,13,91,216,30,116,55,163,249,14,115,164,41,182,221,51,121,124,137,163,63,220,172,179,117,214,213,7,31,135,186,241,228,139,15,161,142,253,211,248,193,244,221,83,251,60,133,122,108,251,110,157,253,92,103,171,97,250,182,111,27,210,236,235,24,211,245,174,73,61,113,140,36,149,230,242,234,250,122,243,38,178,249,91,100,67,238,80,223,207,45,111,35,226,152,198,54,36,248,122,215,119,251,23,242,105,106,119,228,110,87,15,243,212,207,131,63,82,111,119,228,35,233,252,143,215,242,187,43,195,153,102,162,50,192,152,211,192,81,230,80,110,141,5,83,33,21,37,69,90,112,117,245,254,102,53,115,142,118,46,33,126,141,62,60,250,240,189,109,252,237,97,232,195,248,47,60,22,21,162,170,36,8,199,18,94,58,3,154,114,3,220,81,87,148,140,231,198,22,9,127,162,47,54,240,170,75,252,28,77,96,27,124,51,155,88,88,208,204,9,170,116,1,74,83,6,156,51,1,202,50,7,21,173,20,71,199,173,102,118,185,129,147,3,248,147,201,69,49,76,77,227,99,124,240,113,218,143,11,11,206,150,66,24,41,193,150,185,5,174,209,64,133,41,14,38,115,230,92,81,104,203,205,249,45,252,159,3,27,66,31,206,240,81,82,71,75,75,65,115,33,129,43,220,66,105,153,132,42,223,162,102,134,106,131,120,142,159,232,151,191,193,249,99,44,168,42,151,233,160,0,99,172,2,46,76,138,0,233,22,80,10,158,22,175,74,105,220,137,250,107,157,165,147,244,27,108,253,8,155,105,3,0,0 };
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

