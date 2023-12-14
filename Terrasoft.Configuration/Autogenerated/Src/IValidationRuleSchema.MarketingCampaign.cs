namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IValidationRuleSchema

	/// <exclude/>
	public class IValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IValidationRuleSchema(IValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263");
			Name = "IValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,193,10,194,48,12,134,207,14,246,14,57,234,197,62,128,226,65,241,224,85,196,123,54,179,89,236,218,145,164,130,12,223,221,174,168,8,162,189,53,253,254,124,63,245,216,145,244,88,19,28,136,25,37,52,58,223,4,223,216,54,50,170,13,190,44,134,178,152,24,99,96,41,177,235,144,111,171,231,125,141,66,112,69,103,79,25,4,142,142,230,47,214,124,192,125,172,156,173,193,122,37,110,70,213,238,248,78,237,83,40,33,163,227,75,146,7,169,140,162,245,160,103,130,212,48,48,116,40,130,45,129,109,210,202,236,127,171,191,221,19,81,182,190,133,109,142,14,208,146,46,224,94,22,191,125,103,170,47,217,246,103,105,158,48,105,100,47,171,227,199,23,144,68,167,75,243,122,26,217,42,4,7,79,134,166,179,69,154,37,127,174,48,158,7,79,226,103,119,129,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4b8f6e9b-17b0-478d-8b69-e7bce7da0263"));
		}

		#endregion

	}

	#endregion

}

