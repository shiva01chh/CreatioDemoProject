namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationRepositorySchema

	/// <exclude/>
	public class INotificationRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationRepositorySchema(INotificationRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c3d2ee1-fb37-4416-8019-d5f16be32ce0");
			Name = "INotificationRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,193,74,196,48,16,134,207,91,232,59,12,61,173,151,246,1,172,5,21,89,122,217,195,234,11,164,113,82,3,105,82,38,201,161,136,239,110,18,109,221,174,162,40,200,150,16,72,242,255,153,111,254,84,179,1,237,200,56,194,3,18,49,107,132,43,111,141,22,178,247,196,156,52,58,207,158,243,108,227,173,212,61,220,79,214,225,16,206,149,66,30,15,109,185,67,141,36,249,101,208,132,81,85,21,212,214,15,3,163,169,121,95,183,218,33,137,88,65,24,130,71,230,24,48,206,209,90,208,198,73,33,121,42,83,206,238,234,200,62,250,78,73,14,114,185,161,221,31,89,14,56,26,43,157,161,41,72,35,228,167,242,105,227,128,206,147,182,192,148,90,85,180,229,98,169,78,61,53,189,153,154,143,86,193,8,112,79,120,114,69,93,205,202,104,109,239,180,31,144,88,167,176,94,161,182,90,152,6,118,232,174,149,218,94,196,176,54,63,242,174,10,65,55,129,14,79,245,29,243,200,136,13,73,117,85,196,185,104,246,97,254,138,59,96,39,241,255,247,123,51,69,134,173,117,20,255,159,72,245,215,238,123,50,126,252,85,6,201,81,52,187,197,120,238,40,18,201,156,69,162,75,97,188,228,89,24,121,118,252,189,2,107,166,241,44,151,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c3d2ee1-fb37-4416-8019-d5f16be32ce0"));
		}

		#endregion

	}

	#endregion

}

