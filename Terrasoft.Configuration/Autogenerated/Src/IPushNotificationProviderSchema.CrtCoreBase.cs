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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,207,107,194,48,20,62,87,240,127,120,184,139,194,104,7,187,12,21,135,40,136,135,109,50,245,52,118,136,205,107,247,88,155,148,188,84,144,177,255,125,73,91,197,137,202,214,67,72,210,239,7,223,247,162,68,142,92,136,24,97,133,198,8,214,137,13,39,90,37,148,150,70,88,210,170,221,250,106,183,130,146,73,165,176,220,177,197,124,112,114,118,248,44,195,216,131,57,156,161,66,67,177,195,56,212,141,193,212,221,194,92,89,52,137,51,233,195,124,81,242,199,179,182,148,80,92,233,47,140,222,146,68,83,17,162,40,130,33,151,121,46,204,110,212,156,15,100,208,9,20,142,13,234,136,14,69,195,231,112,207,143,142,4,138,114,147,81,12,116,208,184,226,31,248,160,193,86,147,132,37,42,217,61,69,78,133,21,32,221,210,243,13,124,215,9,29,176,14,249,43,240,36,19,204,125,56,167,112,49,231,43,22,6,25,149,229,51,41,189,237,181,128,177,55,188,224,87,231,122,123,217,176,206,208,98,183,51,245,78,14,129,18,220,24,93,41,15,225,93,120,31,194,154,209,143,116,44,115,82,107,69,118,46,93,113,110,194,66,118,122,239,94,163,49,99,107,252,244,87,250,19,21,84,226,65,138,118,80,109,184,217,212,245,236,25,179,146,228,227,169,246,159,152,123,47,178,25,254,139,241,132,204,34,253,35,103,74,213,243,117,157,14,107,250,109,35,51,130,177,148,84,253,203,170,249,95,150,59,251,34,220,157,255,126,0,23,26,32,145,102,3,0,0 };
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

