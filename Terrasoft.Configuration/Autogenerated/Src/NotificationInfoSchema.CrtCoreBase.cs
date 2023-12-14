namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoSchema

	/// <exclude/>
	public class NotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoSchema(NotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("026063fa-ed79-499f-833f-fe2eb2fb3566");
			Name = "NotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,205,106,3,33,16,62,39,144,119,152,39,200,222,155,82,104,211,18,22,218,28,154,237,3,88,157,221,12,172,186,56,227,97,41,125,247,186,118,3,75,123,136,17,149,25,253,254,64,157,178,200,131,210,8,13,134,160,216,183,178,221,123,215,82,23,131,18,242,110,179,254,218,172,87,145,201,117,112,26,89,208,238,82,159,102,85,85,112,207,209,90,21,198,135,185,223,247,138,25,90,31,128,92,218,109,86,0,223,130,156,17,156,23,106,73,231,179,237,69,160,90,40,12,241,179,39,13,58,139,28,23,232,58,137,221,65,253,247,40,81,166,108,23,30,75,152,66,54,36,61,66,190,88,117,40,187,92,240,92,124,255,199,63,121,51,150,192,15,145,12,212,86,117,88,155,98,252,139,19,146,177,140,48,231,249,165,156,244,25,173,58,166,215,41,246,122,67,230,107,233,22,156,103,37,216,80,210,127,71,75,206,228,178,136,56,231,124,245,202,96,184,41,97,250,63,143,38,153,125,56,146,155,188,14,193,199,225,154,85,90,153,60,141,31,99,91,221,188,215,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("026063fa-ed79-499f-833f-fe2eb2fb3566"));
		}

		#endregion

	}

	#endregion

}

