namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationGroupConstSchema

	/// <exclude/>
	public class NotificationGroupConstSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationGroupConstSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationGroupConstSchema(NotificationGroupConstSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b4de5f4-8161-4ca8-921e-9f19f6876f8d");
			Name = "NotificationGroupConst";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,79,75,196,64,12,197,207,91,232,119,8,235,125,123,95,255,128,44,226,109,17,21,239,177,157,150,192,52,83,146,169,176,136,223,221,204,232,234,80,16,219,203,244,101,222,239,37,19,198,209,233,132,173,131,103,39,130,26,250,184,59,4,238,105,152,5,35,5,174,171,247,186,218,92,136,27,76,192,193,163,234,30,142,33,82,79,109,54,220,75,152,39,67,52,214,149,57,155,166,129,43,157,199,17,229,116,243,173,243,45,114,84,8,61,12,201,175,192,69,196,238,204,53,5,56,205,175,158,90,48,48,218,209,166,198,127,246,221,164,25,127,135,60,183,219,195,67,14,201,131,45,2,197,97,23,216,159,76,11,241,0,47,164,8,215,176,77,231,246,242,127,255,163,27,137,187,244,103,208,143,88,67,150,143,72,112,169,215,240,119,79,199,101,196,162,180,38,229,150,153,222,156,168,109,59,37,20,114,21,237,125,166,188,79,238,188,124,199,221,215,254,77,125,228,90,89,202,149,242,251,4,69,184,207,8,121,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b4de5f4-8161-4ca8-921e-9f19f6876f8d"));
		}

		#endregion

	}

	#endregion

}

