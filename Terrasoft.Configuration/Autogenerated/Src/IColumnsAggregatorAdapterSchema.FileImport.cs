namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnsAggregatorAdapterSchema

	/// <exclude/>
	public class IColumnsAggregatorAdapterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnsAggregatorAdapterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnsAggregatorAdapterSchema(IColumnsAggregatorAdapterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e345191c-d19b-4e05-ac17-16031da58852");
			Name = "IColumnsAggregatorAdapter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,205,170,194,64,12,133,215,22,250,14,65,183,210,217,139,10,34,8,221,136,11,95,96,110,205,148,129,78,50,36,211,133,200,125,247,27,127,174,8,162,89,37,249,114,78,66,200,39,212,236,59,132,35,138,120,229,80,154,45,83,136,253,40,190,68,166,102,23,7,108,83,102,41,117,117,169,171,186,154,204,4,123,35,0,45,21,148,96,226,5,180,91,30,198,68,186,233,123,163,190,176,108,78,62,27,190,41,156,115,176,212,49,37,47,231,245,163,126,138,33,176,128,96,30,174,185,96,64,65,234,80,193,54,44,21,17,58,235,173,166,15,255,131,176,49,101,153,186,117,243,239,236,94,172,243,248,51,196,14,226,211,253,227,101,96,87,239,153,14,40,26,181,32,149,183,193,57,180,95,40,92,224,247,254,15,164,211,253,37,215,242,214,179,248,3,73,138,125,235,90,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e345191c-d19b-4e05-ac17-16031da58852"));
		}

		#endregion

	}

	#endregion

}

