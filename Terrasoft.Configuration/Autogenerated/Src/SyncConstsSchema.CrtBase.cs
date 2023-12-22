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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,221,106,220,48,16,133,175,215,224,119,16,217,155,246,98,26,175,254,44,19,122,33,107,164,18,8,180,52,237,3,184,94,37,24,118,237,69,178,91,66,233,187,87,206,38,108,12,91,216,30,116,55,163,249,14,115,164,41,118,253,35,185,127,138,163,223,223,228,89,158,245,205,222,199,67,211,122,242,205,135,208,196,225,97,252,96,134,254,161,123,156,66,51,118,67,159,103,191,243,108,117,152,126,236,186,150,180,187,38,198,116,189,111,83,79,28,35,73,165,185,188,186,190,94,191,136,172,223,138,172,201,29,234,47,115,203,203,136,56,166,177,45,9,190,217,14,253,238,137,124,154,186,45,185,219,54,135,121,234,231,131,63,82,111,183,228,35,233,253,175,231,242,187,43,195,153,102,162,54,192,152,211,192,81,22,80,109,140,5,83,35,21,21,69,90,114,117,245,254,102,53,115,142,118,46,33,126,143,62,220,251,240,179,107,253,237,254,48,132,241,95,120,44,107,68,85,75,16,142,37,188,116,6,52,229,6,184,163,174,172,24,47,140,45,19,254,68,95,108,224,89,151,248,57,154,192,46,248,118,54,177,176,160,153,19,84,233,18,148,166,12,56,103,2,148,101,14,106,90,43,142,142,91,205,236,114,3,39,7,240,154,201,69,49,76,109,235,99,252,234,227,180,27,23,22,156,173,132,48,82,130,173,10,11,92,163,129,26,83,28,76,22,204,185,178,212,150,155,243,91,248,63,7,54,132,33,156,225,163,164,142,86,150,130,230,66,2,87,184,129,202,50,9,117,177,65,205,12,213,6,241,28,63,209,47,127,131,243,199,88,80,85,33,211,65,1,198,88,5,92,152,20,1,210,13,160,20,60,45,94,85,210,184,19,245,79,158,165,243,70,127,1,143,185,193,11,113,3,0,0 };
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

