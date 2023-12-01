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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,141,65,10,195,32,16,69,215,21,188,131,7,40,57,64,187,107,160,224,46,208,94,192,202,24,6,116,70,102,116,17,66,238,94,179,45,244,47,255,127,188,79,161,128,214,16,193,189,65,36,40,167,54,205,76,9,215,46,161,33,211,244,196,12,190,84,150,102,205,110,205,165,43,210,234,94,155,54,40,119,107,70,83,251,39,99,116,72,13,36,157,42,191,128,40,14,128,218,204,185,23,90,132,35,168,178,220,254,110,87,231,31,65,225,135,31,246,221,29,214,28,231,209,200,23,110,29,222,249,175,0,0,0 };
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

