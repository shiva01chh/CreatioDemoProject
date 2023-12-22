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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,91,107,194,48,20,126,86,240,63,28,220,139,3,105,223,85,132,233,28,200,148,13,20,246,156,182,199,46,144,75,73,78,101,34,251,239,59,77,227,86,101,99,121,41,249,110,57,249,26,35,52,250,74,228,8,123,116,78,120,123,160,100,105,205,65,150,181,19,36,173,25,244,207,131,126,175,246,210,148,87,18,135,201,147,200,201,58,137,126,250,139,226,13,51,86,105,109,13,179,204,223,57,44,57,14,150,74,120,63,129,133,240,184,221,8,83,46,164,41,208,5,73,154,166,48,243,181,214,194,157,230,113,223,232,64,215,138,164,98,113,45,74,132,188,73,128,44,248,146,139,45,237,248,170,58,83,50,143,186,155,131,96,2,15,85,181,58,162,161,141,244,132,6,93,163,96,215,57,204,240,61,231,22,233,221,22,60,233,107,72,107,201,152,108,143,124,77,89,32,28,173,44,224,197,112,226,142,132,163,209,37,154,27,36,252,32,200,219,239,61,52,29,246,122,25,159,148,116,228,23,122,26,216,208,76,219,233,41,105,166,157,173,67,142,161,103,73,99,8,151,248,1,230,163,127,109,59,134,112,12,43,45,164,218,87,170,139,206,71,195,22,70,93,41,65,56,252,59,108,19,123,95,19,242,139,176,110,12,143,120,16,252,71,110,9,206,140,76,76,251,140,141,162,41,218,82,195,190,69,175,65,198,186,235,11,90,234,127,35,149,2,0,0 };
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

