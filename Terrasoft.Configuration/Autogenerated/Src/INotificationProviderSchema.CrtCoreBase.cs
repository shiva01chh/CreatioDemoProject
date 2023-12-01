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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,106,195,64,12,69,215,9,244,14,130,108,18,40,62,64,82,186,104,82,66,22,45,6,247,2,147,177,236,170,56,26,163,145,3,33,228,238,213,140,83,67,160,179,155,255,159,164,47,177,59,97,236,157,71,248,66,17,23,67,163,197,54,112,67,237,32,78,41,48,92,159,230,179,33,18,183,15,132,96,177,123,219,76,86,117,137,138,39,211,187,14,125,42,139,197,30,25,133,188,49,70,45,4,219,212,236,192,138,210,216,184,53,28,62,131,82,67,62,79,41,37,156,169,70,201,112,63,28,59,242,64,127,236,255,104,10,102,240,212,250,3,245,59,212,113,13,101,46,31,77,235,1,123,212,109,24,88,151,171,148,119,86,97,138,152,212,119,86,82,194,56,42,119,251,28,168,134,10,181,116,98,167,177,4,113,185,163,188,146,147,203,75,84,177,117,159,33,28,127,172,228,21,250,137,90,109,238,113,144,235,49,81,254,223,198,245,31,68,211,236,253,2,87,110,151,216,122,1,0,0 };
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

