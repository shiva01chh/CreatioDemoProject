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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,207,10,194,48,12,198,207,14,246,14,65,175,178,222,69,5,17,132,93,196,131,47,80,103,58,10,107,82,146,238,32,226,187,219,249,103,8,162,57,37,249,229,251,18,66,54,160,70,219,32,28,81,196,42,187,84,109,153,156,111,123,177,201,51,85,59,223,97,29,34,75,42,139,107,89,148,197,100,38,216,102,2,80,83,66,113,89,188,128,122,203,93,31,72,55,109,155,169,77,44,155,179,141,25,63,20,198,24,88,106,31,130,149,203,250,85,143,98,112,44,32,24,187,33,23,116,40,72,13,42,228,13,75,69,132,38,247,86,211,151,255,65,56,51,101,153,154,117,245,118,54,31,214,177,63,117,190,1,63,186,255,188,12,242,213,123,166,3,138,122,77,72,233,107,112,14,245,31,10,87,184,61,255,129,116,126,190,100,40,31,189,207,184,3,179,244,90,148,99,1,0,0 };
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

