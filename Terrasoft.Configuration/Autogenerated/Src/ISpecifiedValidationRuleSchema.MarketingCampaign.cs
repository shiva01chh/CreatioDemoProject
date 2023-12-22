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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,61,110,195,48,12,133,231,24,240,29,136,76,237,18,29,32,170,151,162,67,214,214,200,206,56,180,35,84,127,160,164,0,65,144,187,87,18,98,35,104,208,106,19,223,35,223,71,130,69,67,193,227,64,208,19,51,6,55,198,205,187,179,163,154,18,99,84,206,182,205,181,109,86,66,8,144,33,25,131,124,233,238,255,47,79,131,26,213,0,103,212,234,88,205,192,73,211,102,246,139,95,13,50,94,60,121,100,52,80,98,223,214,253,186,91,134,24,119,36,45,197,98,41,77,62,29,116,150,148,141,196,99,97,220,205,246,253,18,249,153,19,101,95,220,133,243,9,180,22,242,66,17,149,133,120,34,200,91,58,6,131,33,224,68,160,198,60,189,242,47,232,207,236,171,16,89,217,9,62,106,235,21,38,138,91,184,181,205,223,121,39,26,190,107,218,63,67,107,133,41,38,182,161,219,63,156,144,66,210,81,138,89,42,222,131,115,26,238,30,122,233,161,94,136,242,85,194,235,54,235,153,165,226,60,190,31,5,61,226,31,218,1,0,0 };
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

