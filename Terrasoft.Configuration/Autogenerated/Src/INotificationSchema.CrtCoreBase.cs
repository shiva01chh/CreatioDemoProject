namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationSchema

	/// <exclude/>
	public class INotificationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationSchema(INotificationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc959941-3df6-44cb-bc9f-61641c97b720");
			Name = "INotification";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,77,106,196,48,12,133,215,19,200,29,180,108,55,246,1,18,178,41,37,100,51,148,182,23,240,184,114,48,36,114,144,237,194,16,122,247,218,153,31,60,45,29,106,208,194,210,247,222,19,34,53,163,95,148,70,120,71,102,229,157,9,226,201,145,177,99,100,21,172,163,186,90,235,106,23,189,165,17,222,142,62,224,156,230,211,132,58,15,189,232,145,144,173,110,234,42,81,82,74,104,125,156,103,197,199,238,252,31,40,32,155,28,96,28,3,185,96,141,213,155,51,44,236,62,237,7,178,184,72,101,161,93,226,97,178,26,236,85,62,236,11,109,2,214,45,242,87,230,214,120,197,16,153,252,77,156,184,210,242,39,222,242,137,239,202,8,209,202,75,59,115,195,51,197,25,89,29,38,108,111,86,25,200,184,14,122,12,101,211,63,60,54,119,246,235,217,197,5,40,221,254,143,173,124,224,124,240,19,183,194,136,161,129,175,59,134,47,231,83,254,195,115,159,136,194,114,151,10,160,174,54,247,252,190,1,62,66,6,203,18,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc959941-3df6-44cb-bc9f-61641c97b720"));
		}

		#endregion

	}

	#endregion

}

