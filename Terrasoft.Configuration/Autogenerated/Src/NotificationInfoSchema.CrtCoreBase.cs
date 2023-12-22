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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,205,106,3,33,16,62,39,144,119,152,39,200,222,155,80,104,211,18,22,218,28,146,237,3,88,157,221,12,172,186,56,227,97,41,125,247,26,187,129,165,61,196,136,202,140,126,127,160,78,89,228,65,105,132,6,67,80,236,91,89,239,188,107,169,139,65,9,121,183,90,126,173,150,139,200,228,58,56,141,44,104,55,169,79,179,170,42,216,114,180,86,133,241,113,234,119,189,98,134,214,7,32,151,118,155,21,192,183,32,103,4,231,133,90,210,249,108,125,21,168,102,10,67,252,236,73,131,206,34,135,25,186,78,98,15,80,255,61,74,148,75,182,43,143,37,92,66,54,36,61,66,190,88,116,40,155,92,240,84,124,255,199,63,123,51,150,192,247,145,12,212,86,117,88,155,98,252,171,19,146,177,140,48,229,249,165,156,244,25,173,58,164,215,41,246,122,71,230,91,233,102,156,23,37,216,80,210,63,162,37,103,114,89,68,156,114,190,121,101,48,220,149,48,253,159,39,147,204,62,28,201,93,94,251,224,227,112,203,42,173,76,158,143,31,255,51,136,199,223,2,0,0 };
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

