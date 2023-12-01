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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,193,74,196,48,16,134,207,91,232,59,12,61,173,151,246,1,172,5,21,41,189,236,97,245,5,210,56,169,129,52,41,147,228,80,196,119,55,137,118,221,174,162,40,200,150,16,72,242,255,153,111,254,84,179,17,237,196,56,194,3,18,49,107,132,43,111,141,22,114,240,196,156,52,58,207,158,243,108,227,173,212,3,220,207,214,225,24,206,149,66,30,15,109,217,162,70,146,252,50,104,194,168,170,10,106,235,199,145,209,220,188,175,59,237,144,68,172,32,12,193,35,115,12,24,231,104,45,104,227,164,144,60,149,41,23,119,117,100,159,124,175,36,7,121,184,161,219,29,89,246,56,25,43,157,161,57,72,35,228,167,242,105,99,143,206,147,182,192,148,90,85,180,229,193,82,157,122,106,122,51,53,31,173,130,17,224,158,240,228,138,186,90,148,209,218,221,105,63,34,177,94,97,189,66,237,180,48,13,180,232,174,149,218,94,196,176,54,63,242,174,10,65,63,131,14,79,245,29,243,196,136,141,73,117,85,196,185,104,118,97,254,138,59,96,39,241,255,247,123,51,71,134,173,117,20,255,159,72,245,215,238,7,50,126,250,85,6,201,81,52,237,193,120,238,40,18,201,146,69,162,75,97,188,228,89,24,121,22,190,87,114,232,159,59,142,3,0,0 };
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

