namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPushNotificationProviderSchema

	/// <exclude/>
	public class IPushNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPushNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPushNotificationProviderSchema(IPushNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e415681b-39a4-4c62-9fc4-58927242174a");
			Name = "IPushNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,207,107,194,48,20,62,87,240,127,120,184,139,194,104,7,187,12,21,135,40,136,135,109,50,245,52,118,136,205,107,23,214,38,37,47,21,100,236,127,223,75,91,197,137,202,214,67,72,210,239,7,223,247,162,69,142,84,136,24,97,133,214,10,50,137,11,39,70,39,42,45,173,112,202,232,118,235,171,221,10,74,82,58,133,229,142,28,230,131,147,51,227,179,12,99,15,166,112,134,26,173,138,25,195,168,27,139,41,223,194,92,59,180,9,155,244,97,190,40,233,227,217,56,149,168,184,210,95,88,179,85,18,109,69,136,162,8,134,84,230,185,176,187,81,115,62,144,193,36,80,48,27,244,17,29,138,134,79,225,158,31,29,9,20,229,38,83,49,168,131,198,21,255,192,7,13,182,70,73,88,162,150,221,83,228,84,56,1,146,151,158,111,224,187,78,200,192,58,228,175,192,147,76,16,245,225,156,194,197,156,175,88,88,36,212,142,206,164,244,182,215,2,198,222,240,130,95,157,235,237,101,67,38,67,135,221,206,212,59,49,2,37,240,24,185,148,135,240,46,188,15,97,77,232,71,58,150,185,210,107,173,220,92,114,113,60,97,33,59,189,119,175,209,152,145,179,126,250,43,243,137,26,42,241,32,69,55,168,54,212,108,234,122,246,140,89,169,228,227,169,246,159,152,123,47,229,50,252,23,227,9,137,68,250,71,206,84,85,207,151,59,29,214,244,219,70,102,4,99,41,85,245,47,171,230,127,89,238,236,139,224,59,254,126,0,98,240,28,75,101,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e415681b-39a4-4c62-9fc4-58927242174a"));
		}

		#endregion

	}

	#endregion

}

