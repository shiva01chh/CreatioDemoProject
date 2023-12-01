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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,205,106,195,48,12,62,183,208,119,208,19,52,247,181,12,182,110,148,192,214,67,155,61,128,23,43,169,32,182,131,37,31,194,216,187,79,245,82,8,219,161,169,177,141,100,127,127,96,123,227,144,123,83,35,84,24,163,225,208,200,122,23,124,67,109,138,70,40,248,213,242,107,181,92,36,38,223,194,105,96,65,183,209,94,103,81,20,176,229,228,156,137,195,227,216,239,58,195,12,77,136,64,94,119,151,21,32,52,32,103,4,31,132,26,170,243,217,250,42,80,76,20,250,244,217,81,13,117,22,57,76,208,165,138,61,64,249,247,72,41,151,108,87,30,75,188,132,172,72,58,132,124,177,104,81,54,185,224,177,248,254,143,127,14,118,152,3,223,39,178,80,58,211,98,105,103,227,95,189,144,12,243,8,99,158,95,202,169,62,163,51,7,125,157,217,94,239,200,124,43,221,132,243,98,4,43,82,253,35,58,242,54,151,179,136,99,206,183,96,44,198,187,18,234,255,121,178,106,246,225,73,238,242,218,199,144,250,91,86,186,50,89,199,15,157,9,178,180,214,2,0,0 };
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

