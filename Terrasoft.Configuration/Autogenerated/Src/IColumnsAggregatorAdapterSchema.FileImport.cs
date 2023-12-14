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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,207,10,194,48,12,198,207,14,246,14,65,175,178,222,69,5,17,132,93,100,7,95,160,206,116,20,214,164,36,221,65,196,119,183,243,31,130,104,78,73,126,249,190,132,144,13,168,209,182,8,7,20,177,202,46,85,91,38,231,187,65,108,242,76,213,206,247,88,135,200,146,202,226,82,22,101,49,153,9,118,153,0,212,148,80,92,22,47,160,222,114,63,4,210,77,215,101,106,19,203,230,100,99,198,119,133,49,6,150,58,132,96,229,188,126,214,111,49,56,22,16,140,253,152,11,58,20,164,22,21,242,134,165,34,66,155,123,171,233,211,191,17,206,76,89,166,102,93,189,156,205,135,117,28,142,189,111,193,191,221,127,94,6,249,234,61,83,131,162,94,19,82,250,26,156,67,253,135,194,5,174,143,127,32,157,30,47,25,203,123,111,140,27,45,130,60,61,91,1,0,0 };
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

