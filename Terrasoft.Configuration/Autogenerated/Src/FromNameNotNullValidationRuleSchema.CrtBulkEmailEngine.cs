namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromNameNotNullValidationRuleSchema

	/// <exclude/>
	public class FromNameNotNullValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromNameNotNullValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromNameNotNullValidationRuleSchema(FromNameNotNullValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50");
			Name = "FromNameNotNullValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,75,111,219,48,12,62,167,64,255,3,215,1,69,10,12,242,189,141,123,88,208,21,193,150,96,72,135,222,21,155,78,136,202,146,39,202,25,140,162,255,125,148,252,88,146,195,124,48,172,79,226,247,160,104,171,107,228,70,23,8,191,208,123,205,174,10,106,233,108,69,251,214,235,64,206,194,245,213,251,245,213,172,101,178,123,120,233,56,96,45,7,140,193,34,238,178,122,70,139,158,138,135,203,51,63,200,254,22,80,224,207,30,247,145,104,105,52,243,61,192,55,239,234,141,200,110,92,216,180,198,188,106,67,101,146,218,182,6,83,69,150,101,176,224,182,174,181,239,30,135,245,22,27,143,140,54,48,132,3,66,17,201,224,15,133,3,120,41,99,112,21,28,39,38,168,156,7,43,26,80,137,24,212,186,240,142,97,215,1,214,77,232,212,40,145,157,104,52,237,206,80,49,240,254,215,34,220,195,87,205,120,1,10,197,123,50,63,229,93,99,56,184,82,18,255,244,46,72,187,176,236,247,47,211,37,96,96,195,62,157,228,44,241,52,65,4,71,83,235,152,70,77,76,217,37,213,162,209,94,215,169,56,191,241,88,80,67,210,182,155,199,237,248,25,123,181,107,205,155,116,67,147,81,139,44,21,164,250,102,180,10,238,40,243,64,37,194,209,81,9,43,27,208,91,61,118,2,231,171,53,50,235,61,78,164,43,91,57,152,212,238,32,14,205,108,118,212,62,94,75,139,163,121,200,225,25,67,138,240,58,226,19,199,124,170,255,2,107,177,38,227,36,179,200,129,213,89,246,239,216,221,61,36,122,170,96,126,78,255,41,7,43,55,6,183,183,231,186,42,169,169,127,194,144,231,192,193,139,132,122,138,67,49,58,158,77,30,212,202,82,32,109,182,242,131,136,11,92,186,50,218,159,147,196,27,220,157,110,169,165,182,5,26,44,95,210,229,241,48,63,169,99,189,219,143,248,254,24,134,68,14,245,115,146,214,61,122,14,10,38,207,95,6,197,250,136,161,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50"));
		}

		#endregion

	}

	#endregion

}

