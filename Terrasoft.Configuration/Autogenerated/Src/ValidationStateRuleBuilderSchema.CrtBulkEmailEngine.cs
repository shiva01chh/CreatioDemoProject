namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationStateRuleBuilderSchema

	/// <exclude/>
	public class ValidationStateRuleBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationStateRuleBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationStateRuleBuilderSchema(ValidationStateRuleBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65");
			Name = "ValidationStateRuleBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,193,110,194,48,12,134,207,32,241,14,22,187,192,165,189,67,135,180,77,19,66,26,18,26,108,247,208,26,136,148,164,200,118,64,8,237,221,151,180,176,1,98,82,215,83,99,255,254,252,59,177,83,22,121,171,114,132,5,18,41,46,87,146,188,148,110,165,215,158,148,232,210,117,218,199,78,187,229,89,187,53,204,15,44,104,67,222,24,204,99,146,147,49,58,36,157,15,59,237,160,74,211,20,50,246,214,42,58,140,78,231,25,149,59,93,32,131,69,217,148,5,72,9,107,20,32,111,66,108,85,18,176,40,65,216,41,163,11,37,37,37,103,78,122,1,218,250,165,209,57,228,70,49,195,103,45,13,237,231,177,244,61,144,158,189,54,5,18,12,96,50,85,218,4,175,85,234,87,121,18,4,212,177,114,218,122,32,92,135,56,76,43,87,60,128,89,213,162,78,222,206,81,5,198,40,12,178,193,11,235,182,238,117,61,66,160,38,63,144,244,150,146,17,138,39,199,163,140,17,33,39,92,61,118,39,175,206,91,36,181,52,152,253,225,63,14,57,234,166,35,216,107,217,212,14,146,44,61,179,34,252,116,69,59,77,226,149,129,166,204,56,86,252,225,94,31,226,67,183,90,7,141,166,128,26,13,14,247,240,20,158,122,135,97,41,68,229,194,215,245,189,254,240,126,209,7,35,205,144,172,102,142,123,210,176,106,190,53,90,22,200,18,173,250,198,85,255,17,207,194,69,52,229,162,43,130,250,77,91,45,119,75,190,78,187,20,116,245,58,85,231,16,173,18,225,251,6,44,85,114,145,94,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba59d1f0-c429-42e9-8b97-e960f4125c65"));
		}

		#endregion

	}

	#endregion

}

