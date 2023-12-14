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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,106,195,64,12,69,215,9,244,14,130,108,18,40,62,64,82,186,104,82,66,22,45,6,247,2,147,177,236,170,56,35,163,145,3,33,228,238,213,140,83,67,160,179,155,255,159,164,47,5,119,194,216,59,143,240,133,34,46,114,163,197,150,67,67,237,32,78,137,3,92,159,230,179,33,82,104,31,8,193,98,247,182,153,172,234,18,21,79,166,119,29,250,84,22,139,61,6,20,242,198,24,181,16,108,83,179,67,80,148,198,198,173,225,240,201,74,13,249,60,165,20,62,83,141,146,225,126,56,118,228,129,254,216,255,209,20,204,224,169,245,7,234,55,215,113,13,101,46,31,77,235,1,123,212,45,15,65,151,171,148,119,86,97,138,152,212,247,160,164,132,113,84,238,246,153,169,134,10,181,116,98,167,177,4,113,185,163,188,146,147,203,75,84,177,117,159,129,143,63,86,242,10,253,68,173,54,247,56,24,234,49,81,254,223,198,245,31,68,211,210,251,5,170,85,0,199,123,1,0,0 };
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

