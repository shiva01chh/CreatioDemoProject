namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationProviderSchema

	/// <exclude/>
	public class INotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationProviderSchema(INotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aabdace1-2a9b-4be1-a035-cadae80c10e3");
			Name = "INotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,106,195,64,12,69,215,41,244,14,130,110,18,8,62,64,82,186,104,82,66,22,41,6,247,2,147,177,236,168,56,35,163,145,3,161,244,238,213,140,83,211,64,103,55,255,63,73,95,10,238,140,177,119,30,225,3,69,92,228,70,139,13,135,134,218,65,156,18,7,248,122,124,152,13,145,66,123,71,8,22,219,215,245,100,85,215,168,120,54,189,235,208,167,178,88,236,48,160,144,55,198,168,39,193,54,53,219,7,69,105,108,220,10,246,239,172,212,144,207,83,74,225,11,213,40,25,238,135,99,71,30,232,151,253,31,77,193,12,158,90,31,80,79,92,199,21,148,185,124,52,173,7,236,80,55,60,4,157,47,82,222,89,133,41,98,82,223,130,146,18,198,81,185,217,23,166,26,42,212,210,137,157,198,18,196,249,150,242,74,78,174,207,81,197,214,93,2,31,63,173,228,5,250,137,90,172,111,113,48,212,99,162,252,255,30,215,191,19,77,251,251,126,0,145,202,252,210,131,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aabdace1-2a9b-4be1-a035-cadae80c10e3"));
		}

		#endregion

	}

	#endregion

}

