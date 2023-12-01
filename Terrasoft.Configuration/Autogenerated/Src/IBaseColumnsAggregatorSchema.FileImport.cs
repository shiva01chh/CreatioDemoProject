namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBaseColumnsAggregatorSchema

	/// <exclude/>
	public class IBaseColumnsAggregatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBaseColumnsAggregatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBaseColumnsAggregatorSchema(IBaseColumnsAggregatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84");
			Name = "IBaseColumnsAggregator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,77,107,195,48,12,61,47,144,255,32,122,218,96,196,247,45,11,108,101,133,220,198,24,187,171,169,18,12,177,29,36,187,80,202,254,251,156,56,105,179,206,232,34,233,125,232,217,162,33,25,176,33,248,34,102,20,215,250,98,235,108,171,187,192,232,181,179,197,78,247,84,155,193,177,207,179,115,158,221,41,165,160,148,96,12,242,169,154,251,79,26,152,132,172,23,216,163,16,180,193,54,35,25,123,237,79,208,58,134,198,245,193,88,1,236,58,166,14,189,227,69,74,173,180,134,176,239,117,3,218,122,226,118,60,170,126,139,114,219,196,125,189,80,225,9,234,15,118,13,137,208,225,27,251,64,18,219,163,62,16,63,66,125,61,56,17,103,228,59,179,187,89,51,161,95,212,163,251,152,238,95,188,105,144,144,2,122,226,205,97,138,11,92,221,226,203,1,25,13,216,248,185,47,155,132,158,206,220,84,201,13,142,99,87,148,106,194,93,105,76,62,176,149,170,254,227,83,170,101,62,2,215,209,96,29,225,126,189,153,236,96,101,253,240,28,201,63,121,22,43,190,95,205,151,144,196,247,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bf20cba9-3c75-48fd-bbc1-dd610d81de84"));
		}

		#endregion

	}

	#endregion

}

