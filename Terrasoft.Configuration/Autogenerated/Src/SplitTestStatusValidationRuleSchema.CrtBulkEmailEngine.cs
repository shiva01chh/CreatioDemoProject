namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SplitTestStatusValidationRuleSchema

	/// <exclude/>
	public class SplitTestStatusValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SplitTestStatusValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SplitTestStatusValidationRuleSchema(SplitTestStatusValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("219a848e-eacd-4e66-a390-448dd194d011");
			Name = "SplitTestStatusValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,193,110,155,64,16,61,19,41,255,48,162,7,219,82,5,61,59,198,135,36,110,132,212,40,85,236,244,190,129,1,175,10,11,218,157,109,226,90,254,247,14,187,96,104,221,67,56,0,59,243,230,205,188,153,89,37,106,52,173,200,16,118,168,181,48,77,65,209,93,163,10,89,90,45,72,54,234,250,234,120,125,21,88,35,85,9,219,131,33,172,111,206,231,105,136,198,104,163,72,146,68,195,0,134,196,113,12,43,99,235,90,232,195,186,63,63,99,171,209,160,34,3,180,71,216,182,149,164,29,26,2,67,130,172,129,95,162,146,185,75,11,218,86,24,13,52,241,132,167,181,175,149,204,32,171,132,49,35,195,214,17,252,56,199,63,115,56,44,33,125,20,178,226,82,59,55,254,237,101,170,163,43,52,248,164,177,236,82,62,34,237,155,220,44,225,187,75,225,157,255,202,232,12,193,230,29,51,75,56,173,183,104,244,165,158,65,196,165,10,111,105,133,22,53,40,158,65,18,118,33,24,174,119,220,23,247,235,24,199,4,209,42,118,232,49,88,35,89,173,204,58,85,140,87,60,193,166,224,74,17,33,211,88,36,225,68,45,79,184,81,6,195,120,13,122,156,192,180,217,104,108,69,134,115,12,164,93,150,190,211,151,68,131,9,231,211,246,250,178,23,208,237,75,16,244,30,222,37,194,119,130,172,255,38,30,21,245,246,27,135,117,139,115,128,87,91,253,220,212,28,199,168,30,31,221,14,54,143,241,120,89,192,252,12,142,30,144,118,135,22,243,187,166,178,181,226,210,44,174,30,172,204,215,243,112,139,101,221,105,245,219,145,230,225,2,146,4,198,210,12,107,238,49,30,242,210,118,74,85,153,230,131,142,65,200,11,241,167,219,238,232,91,83,70,169,42,154,175,141,174,5,205,61,42,8,207,149,194,155,164,61,164,249,18,142,95,78,144,9,53,35,40,209,237,132,38,204,35,232,51,14,75,34,13,204,134,188,179,40,252,220,19,126,72,160,147,180,240,93,225,173,216,61,221,63,129,200,243,233,108,171,236,55,103,210,76,238,81,126,194,160,240,237,127,147,237,69,7,91,155,101,200,23,44,129,66,84,6,189,245,228,19,157,220,251,67,60,35,13,105,235,89,60,201,169,191,122,168,114,127,251,220,153,173,206,209,61,127,0,238,174,249,23,154,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("219a848e-eacd-4e66-a390-448dd194d011"));
		}

		#endregion

	}

	#endregion

}

