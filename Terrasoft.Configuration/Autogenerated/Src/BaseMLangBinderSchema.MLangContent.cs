namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMLangBinderSchema

	/// <exclude/>
	public class BaseMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMLangBinderSchema(BaseMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4367ba23-e656-4615-8c59-3352d06c36d8");
			Name = "BaseMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,91,107,194,48,20,126,86,240,63,28,220,75,7,210,190,171,8,211,57,144,41,27,40,236,57,109,143,93,32,151,146,156,202,68,246,223,119,154,198,77,101,99,121,41,249,110,57,249,26,35,52,250,90,20,8,59,116,78,120,187,167,116,97,205,94,86,141,19,36,173,25,244,79,131,126,175,241,210,84,87,18,135,233,147,40,200,58,137,126,242,139,226,13,115,86,105,109,13,179,204,223,57,172,56,14,22,74,120,63,134,185,240,184,89,11,83,205,165,41,209,5,73,150,101,48,245,141,214,194,29,103,113,223,234,64,55,138,164,98,113,35,42,132,162,77,128,60,248,210,179,45,187,240,213,77,174,100,17,117,55,7,193,24,30,234,122,121,64,67,107,233,9,13,186,86,193,174,83,152,225,123,206,13,210,187,45,121,210,215,144,214,145,49,217,30,248,154,178,68,56,88,89,194,139,225,196,45,9,71,201,57,154,27,36,252,32,40,186,239,61,180,29,246,122,57,159,148,94,200,207,244,36,176,161,153,174,211,99,218,78,59,93,133,28,67,207,146,70,16,46,241,3,204,146,127,109,91,134,112,4,75,45,164,218,213,234,18,157,37,195,14,70,93,43,65,56,252,59,108,29,123,95,17,242,139,176,110,4,143,184,23,252,71,110,9,206,140,76,76,251,140,141,162,41,187,82,195,190,67,175,65,198,218,245,5,73,65,67,244,141,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4367ba23-e656-4615-8c59-3352d06c36d8"));
		}

		#endregion

	}

	#endregion

}

