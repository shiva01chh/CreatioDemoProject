namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NumberDigitExpressionConveterSchema

	/// <exclude/>
	public class NumberDigitExpressionConveterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NumberDigitExpressionConveterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NumberDigitExpressionConveterSchema(NumberDigitExpressionConveterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5ab4edf-58fd-4173-bee4-f6489fa39530");
			Name = "NumberDigitExpressionConveter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("14a29563-3c13-443c-a7aa-8d0c90d831c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,49,11,194,64,12,133,103,15,250,31,66,39,5,57,112,18,117,180,174,58,232,38,14,215,154,214,64,123,87,46,57,81,212,255,110,170,179,134,76,47,239,125,143,120,215,33,247,174,66,56,96,140,142,67,45,118,29,124,77,77,138,78,40,248,204,60,50,51,74,76,190,129,253,157,5,187,85,102,84,57,238,74,14,45,10,142,243,185,93,216,25,60,161,8,224,131,64,98,4,185,16,67,213,58,230,41,144,215,148,59,127,244,31,37,118,155,186,18,99,65,13,201,230,214,71,100,86,85,45,87,140,130,49,159,156,180,177,79,101,75,213,151,10,191,3,234,135,229,159,251,0,4,197,13,111,189,50,163,171,243,6,106,242,98,230,7,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5ab4edf-58fd-4173-bee4-f6489fa39530"));
		}

		#endregion

	}

	#endregion

}

