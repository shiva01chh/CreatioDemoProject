namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentColumnProcessorSchema

	/// <exclude/>
	public class IPersistentColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentColumnProcessorSchema(IPersistentColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9d8cf2ba-6149-493d-80f4-bea4d4b996f5");
			Name = "IPersistentColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,141,65,10,194,48,16,69,215,6,114,135,28,64,122,0,221,89,16,178,43,232,5,98,152,148,129,100,38,204,36,11,41,189,187,233,78,4,255,242,255,199,251,20,10,104,13,17,220,19,68,130,114,106,211,204,148,112,237,18,26,50,77,119,204,224,75,101,105,214,108,214,156,186,34,173,238,241,214,6,229,106,205,104,106,127,101,140,14,169,129,164,67,229,23,16,197,1,80,155,57,247,66,139,112,4,85,150,203,223,237,236,252,45,40,252,240,195,190,185,221,154,253,56,250,206,7,82,204,210,111,184,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9d8cf2ba-6149-493d-80f4-bea4d4b996f5"));
		}

		#endregion

	}

	#endregion

}

