namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISpecifiedValidationRuleSchema

	/// <exclude/>
	public class ISpecifiedValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISpecifiedValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISpecifiedValidationRuleSchema(ISpecifiedValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09a3c370-1a84-44b1-9af8-a13146a5503c");
			Name = "ISpecifiedValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,61,110,195,48,12,133,231,24,240,29,136,76,237,18,29,32,170,151,162,67,215,214,200,206,56,148,35,84,127,160,164,2,65,208,187,87,18,98,163,104,208,106,19,223,35,223,71,130,67,75,49,224,68,48,18,51,70,175,210,238,217,59,165,231,204,152,180,119,125,119,237,187,141,16,2,100,204,214,34,95,134,219,255,61,208,164,149,158,224,19,141,62,53,51,112,54,180,91,252,226,87,131,76,151,64,1,25,45,212,216,167,237,184,29,214,33,214,159,200,72,177,90,106,83,200,71,83,36,237,18,177,170,140,175,139,253,176,70,190,149,68,57,86,119,229,188,3,109,133,178,80,66,237,32,157,9,202,150,158,193,98,140,56,19,104,85,166,55,254,21,253,158,125,19,19,107,55,195,75,107,189,194,76,105,15,95,125,247,119,222,153,166,143,150,246,207,208,86,97,74,153,93,28,14,63,78,72,49,155,36,197,34,85,239,209,123,3,55,15,61,140,208,46,68,229,42,241,113,95,244,194,210,112,202,251,6,252,26,177,38,209,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09a3c370-1a84-44b1-9af8-a13146a5503c"));
		}

		#endregion

	}

	#endregion

}

