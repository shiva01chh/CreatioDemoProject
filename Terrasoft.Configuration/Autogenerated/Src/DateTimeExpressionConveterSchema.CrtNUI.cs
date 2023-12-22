namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExpressionConveterSchema

	/// <exclude/>
	public class DateTimeExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExpressionConveterSchema(DateTimeExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35da4edf-d91a-423a-87ed-e938ea1f0686");
			Name = "DateTimeExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,79,177,10,194,64,12,157,45,244,31,66,39,5,57,112,18,117,180,157,29,236,38,14,215,154,214,64,123,87,46,57,81,212,127,55,213,197,165,225,45,121,239,229,61,226,108,143,60,216,26,161,196,16,44,251,70,204,222,187,134,218,24,172,144,119,105,242,76,147,89,100,114,45,28,31,44,216,239,116,87,156,14,21,251,14,5,231,217,218,108,204,10,94,144,123,112,94,32,50,130,92,137,161,238,44,243,18,200,233,153,189,124,249,137,22,147,91,193,146,122,44,238,67,64,102,165,84,191,97,16,12,217,226,172,117,67,172,58,170,127,145,48,225,86,51,108,167,196,49,74,115,198,111,222,105,162,248,159,15,201,239,188,171,7,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35da4edf-d91a-423a-87ed-e938ea1f0686"));
		}

		#endregion

	}

	#endregion

}

