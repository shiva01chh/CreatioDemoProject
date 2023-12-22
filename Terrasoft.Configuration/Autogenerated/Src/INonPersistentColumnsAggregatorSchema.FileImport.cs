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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,142,77,10,131,64,12,133,215,21,188,67,192,109,241,0,238,90,161,48,155,226,194,11,76,109,28,6,52,145,36,179,146,222,189,83,107,161,208,102,151,199,247,126,200,207,168,139,31,16,122,20,241,202,163,213,45,211,24,67,18,111,145,169,190,196,9,221,188,176,88,89,172,101,113,168,4,67,214,193,145,161,140,217,217,128,107,121,74,51,105,39,60,160,42,75,89,100,112,73,183,41,14,16,63,28,184,43,83,135,162,81,13,201,118,207,41,132,28,232,141,5,154,191,196,30,122,4,119,246,138,63,174,92,180,194,99,43,172,144,238,239,113,175,119,211,190,239,9,211,195,93,71,235,0,0,0 };
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

