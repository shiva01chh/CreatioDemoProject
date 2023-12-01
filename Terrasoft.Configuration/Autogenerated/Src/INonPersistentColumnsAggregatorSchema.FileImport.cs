namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INonPersistentColumnsAggregatorSchema

	/// <exclude/>
	public class INonPersistentColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INonPersistentColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INonPersistentColumnsAggregatorSchema(INonPersistentColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("872298ee-2333-4faf-aa08-02b8773d99f5");
			Name = "INonPersistentColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,142,77,10,194,64,12,133,215,22,122,135,64,183,210,3,116,167,5,97,54,210,133,23,24,107,102,24,152,38,37,73,87,197,187,59,214,186,210,236,242,248,222,15,249,9,117,246,35,194,13,69,188,114,176,182,103,10,41,46,226,45,49,181,151,148,209,77,51,139,213,213,90,87,135,70,48,22,29,28,25,74,40,206,14,92,207,121,153,72,7,225,17,85,89,234,170,128,243,114,207,105,132,244,229,192,93,153,6,20,77,106,72,182,123,78,49,150,64,111,44,208,253,37,246,208,35,184,179,87,252,113,149,162,21,158,91,97,131,244,248,140,123,191,155,86,238,5,39,83,143,177,226,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("872298ee-2333-4faf-aa08-02b8773d99f5"));
		}

		#endregion

	}

	#endregion

}

