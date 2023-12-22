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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,49,11,194,64,12,133,103,15,238,63,132,78,10,114,224,36,234,104,93,117,208,77,28,174,53,173,129,246,174,92,238,68,81,255,187,169,46,46,53,100,122,121,239,123,196,217,22,185,179,37,194,1,67,176,236,171,104,214,222,85,84,167,96,35,121,167,213,67,171,81,98,114,53,236,239,28,177,93,105,37,202,113,87,176,111,48,226,56,155,155,133,153,193,19,114,15,206,71,72,140,16,47,196,80,54,150,121,10,228,36,101,207,31,125,160,196,108,83,91,96,200,169,166,184,185,117,1,153,69,21,203,21,67,196,144,77,78,210,216,165,162,161,242,75,133,225,128,248,97,249,231,222,3,65,112,253,91,47,173,100,127,231,13,9,63,155,125,16,1,0,0 };
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

