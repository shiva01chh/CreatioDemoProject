namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCResolverTemplateValidatorSchema

	/// <exclude/>
	public class DCResolverTemplateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCResolverTemplateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCResolverTemplateValidatorSchema(DCResolverTemplateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27");
			Name = "DCResolverTemplateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,77,111,219,48,12,61,187,64,255,3,231,93,98,160,80,176,235,218,164,200,146,174,43,208,2,235,146,173,103,213,161,19,97,182,228,74,114,62,86,244,191,143,146,108,55,113,211,92,154,139,33,145,122,124,252,120,140,228,5,154,146,167,8,51,212,154,27,149,89,54,86,50,19,139,74,115,43,148,100,147,173,228,133,72,233,210,162,180,167,39,207,167,39,81,101,132,92,192,116,107,44,22,228,158,231,152,58,95,195,174,81,162,22,233,121,215,231,86,200,167,215,203,221,80,69,161,228,97,203,251,36,216,157,154,99,110,14,63,211,248,222,61,155,124,35,19,25,63,107,92,16,42,140,115,110,204,87,152,140,127,161,81,249,10,245,12,139,50,231,22,255,240,92,204,185,85,218,187,247,251,125,184,48,85,81,112,189,29,214,231,218,3,13,89,16,33,213,152,13,226,201,184,1,240,4,227,254,16,50,165,193,224,162,32,214,62,19,40,181,74,209,24,214,224,246,119,128,203,234,49,23,41,164,142,214,113,86,209,179,103,214,102,114,135,118,169,230,148,203,79,45,86,228,26,172,101,56,192,173,48,246,98,138,174,75,67,184,70,251,93,228,22,181,233,117,248,130,173,79,103,240,219,160,166,98,203,208,87,168,246,142,9,12,28,219,40,106,252,47,217,200,90,45,30,43,170,199,37,123,88,162,198,222,134,156,96,195,110,76,8,214,75,18,255,36,98,129,71,99,159,169,218,222,9,145,144,197,209,238,37,231,251,185,172,148,152,183,213,159,62,229,31,206,229,217,243,90,113,215,39,199,204,192,96,183,70,175,56,157,135,231,254,157,200,160,247,169,126,200,70,114,75,121,214,136,145,70,91,105,25,220,94,90,231,198,119,191,12,83,85,233,20,175,54,165,166,217,112,3,63,202,5,55,9,155,80,9,132,36,191,132,38,184,146,244,133,33,124,105,67,56,214,164,95,195,23,72,172,37,174,225,86,165,84,155,127,252,49,199,41,181,68,46,58,133,101,15,74,255,245,130,103,110,188,92,212,41,77,20,1,156,5,200,40,62,50,120,241,25,196,111,34,24,246,131,155,137,200,50,106,187,180,158,56,154,171,77,138,165,11,56,195,141,101,4,80,97,156,132,111,168,72,100,151,90,173,61,231,27,185,114,1,238,43,212,91,130,172,82,170,27,182,0,189,58,193,100,167,146,47,245,244,163,156,7,1,188,167,6,47,168,96,236,170,184,43,227,146,107,94,144,140,129,54,13,14,226,166,239,141,136,231,97,3,65,26,86,80,163,99,202,159,181,232,253,46,124,0,237,34,14,155,186,122,224,85,77,129,93,244,189,247,225,199,251,93,140,135,35,9,66,26,203,37,109,110,149,129,93,226,238,34,242,219,110,127,238,41,143,183,17,176,41,114,253,238,120,39,136,184,235,153,129,245,18,37,112,11,57,114,99,193,174,85,43,157,6,121,201,87,8,243,102,38,32,12,26,112,55,27,196,162,13,235,153,212,91,111,79,216,31,149,243,129,5,113,92,200,135,39,202,223,186,63,140,189,107,186,117,191,255,135,55,171,102,59,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHasDifferentAliasesExceptionTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHasDifferentAliasesExceptionTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0516f4b9-03c3-4a08-80ae-8affa9b34e2b"),
				Name = "HasDifferentAliasesExceptionText",
				CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead"),
				CreatedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"),
				ModifiedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"));
		}

		#endregion

	}

	#endregion

}

