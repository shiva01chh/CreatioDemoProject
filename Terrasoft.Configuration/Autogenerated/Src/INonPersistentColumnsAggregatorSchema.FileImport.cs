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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,142,77,10,131,64,12,133,215,21,188,67,192,109,241,0,238,90,161,48,155,226,194,11,76,167,113,24,208,68,146,184,146,222,189,163,181,171,54,187,60,190,247,67,126,66,157,125,64,232,81,196,43,15,86,183,76,67,138,139,120,75,76,245,45,141,232,166,153,197,202,98,45,139,83,37,24,179,14,142,12,101,200,206,6,92,203,227,50,145,118,194,1,85,89,202,34,131,243,242,24,83,128,244,229,192,221,153,58,20,77,106,72,118,120,46,49,230,64,111,44,208,252,37,142,208,51,184,171,87,252,113,229,162,21,94,123,97,133,244,252,140,219,222,93,219,238,13,171,60,108,151,227,0,0,0 };
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

