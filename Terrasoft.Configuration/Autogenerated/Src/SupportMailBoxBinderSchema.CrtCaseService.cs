namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportMailBoxBinderSchema

	/// <exclude/>
	public class SupportMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportMailBoxBinderSchema(SupportMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3");
			Name = "SupportMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,209,106,2,49,16,124,86,240,31,22,251,98,161,220,189,171,61,232,73,11,133,74,75,45,244,57,151,219,187,6,188,108,216,228,68,145,254,123,247,46,90,20,53,47,33,59,147,217,153,177,170,65,239,148,70,248,66,102,229,169,10,201,130,108,101,234,150,85,48,100,71,195,253,104,56,104,189,177,245,25,133,49,121,81,58,16,27,244,179,43,140,111,44,132,213,52,100,5,21,252,142,177,22,57,88,172,149,247,83,88,181,206,17,135,165,50,235,156,182,185,177,37,114,207,75,211,20,230,190,109,26,197,187,236,240,142,48,84,196,2,33,130,102,172,30,199,175,231,26,159,232,200,27,49,180,27,167,89,114,84,74,79,164,92,91,172,141,6,221,57,184,106,0,166,240,228,220,243,6,109,120,51,62,160,69,206,149,71,249,186,239,189,253,135,88,98,248,161,82,98,124,244,146,17,60,200,211,70,58,48,37,194,134,76,9,239,86,20,87,65,113,152,28,165,165,222,128,219,0,58,222,247,208,21,60,24,20,178,41,57,161,31,225,89,143,246,181,197,194,119,73,231,118,126,51,254,3,220,66,178,201,248,178,172,184,224,247,16,16,109,25,51,246,239,56,61,31,202,236,228,252,1,19,108,20,25,64,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bc5ec1ee-8ee0-40d6-ba02-de9f93ecefc3"));
		}

		#endregion

	}

	#endregion

}

