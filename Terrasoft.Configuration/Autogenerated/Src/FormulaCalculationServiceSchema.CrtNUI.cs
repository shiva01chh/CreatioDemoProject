namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormulaCalculationServiceSchema

	/// <exclude/>
	public class FormulaCalculationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormulaCalculationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormulaCalculationServiceSchema(FormulaCalculationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb");
			Name = "FormulaCalculationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,91,111,226,70,20,126,102,165,253,15,35,250,98,36,228,31,144,155,148,100,147,44,109,19,34,156,106,165,166,171,106,176,15,224,238,216,227,206,140,97,217,108,254,123,207,153,25,219,128,185,36,234,166,42,15,128,207,253,246,157,227,156,103,160,11,30,3,123,0,165,184,150,19,19,94,202,124,146,78,75,197,77,42,243,240,90,170,172,20,252,253,187,167,247,239,58,165,78,243,41,139,150,218,64,118,188,241,140,122,66,64,76,74,58,188,129,28,84,26,183,100,238,192,180,104,163,50,55,105,6,97,132,26,92,164,223,172,223,150,20,114,231,105,12,183,50,1,177,151,25,126,130,241,126,129,115,12,114,190,225,165,73,31,213,49,149,44,219,206,189,148,10,170,154,28,226,135,31,184,225,247,74,206,211,4,148,94,123,114,53,214,187,45,240,216,72,149,194,30,9,239,227,234,107,12,133,45,250,254,100,170,18,140,100,105,80,166,17,190,131,133,65,109,146,254,89,219,164,145,245,147,130,41,218,100,151,130,107,125,196,188,179,75,46,98,252,33,111,149,53,156,30,84,6,171,244,72,25,98,102,70,97,244,159,145,80,148,99,145,198,44,38,35,135,109,176,35,182,54,122,45,23,157,39,235,166,14,238,58,5,145,96,116,247,138,218,233,98,232,20,238,129,201,241,95,56,140,236,79,5,186,20,230,216,107,66,158,56,229,117,75,232,87,27,85,82,205,209,156,141,218,91,115,25,28,140,61,232,177,39,246,252,74,157,186,117,12,170,127,61,50,208,57,98,99,142,252,134,218,24,223,149,1,14,86,1,202,224,196,172,39,96,123,114,11,217,24,84,112,135,96,103,167,172,235,74,210,237,125,94,137,214,151,107,100,89,236,201,134,49,5,252,199,20,152,82,229,117,33,41,16,228,105,168,164,58,233,132,5,115,46,74,96,169,102,232,14,30,16,205,189,138,219,241,138,232,152,198,11,43,61,199,56,107,176,195,208,58,118,6,250,44,135,133,21,171,217,42,2,67,243,170,107,123,29,114,65,197,229,230,35,207,19,65,51,124,202,218,196,112,160,101,67,245,202,207,189,112,4,133,192,133,23,116,255,232,118,251,12,219,78,178,87,89,97,150,189,99,39,245,204,64,224,56,182,19,176,65,86,66,246,199,126,111,111,141,163,110,16,95,138,43,143,39,152,112,244,188,130,92,160,158,61,70,186,104,211,28,97,21,126,143,231,186,192,133,139,248,47,208,246,56,21,169,89,142,224,239,50,85,144,65,110,116,176,250,64,171,17,83,60,160,66,82,161,39,36,189,151,99,28,177,125,129,35,93,103,183,9,229,91,48,51,185,19,203,174,73,236,134,2,91,89,16,87,74,73,117,11,90,243,41,4,94,230,11,44,171,209,243,131,251,155,182,235,54,119,167,9,47,147,249,85,198,246,206,140,5,68,86,43,232,238,12,28,71,132,76,30,175,244,185,138,234,240,66,67,95,53,198,107,212,123,181,33,194,21,39,213,225,65,83,54,91,182,193,122,38,4,142,195,91,165,165,221,177,117,26,228,19,137,253,173,134,218,151,13,41,181,124,24,205,164,50,158,177,54,228,63,48,251,45,89,86,32,100,194,247,133,136,191,52,125,156,115,213,8,215,214,79,223,168,28,123,135,108,51,194,118,149,170,94,181,2,62,222,189,41,182,160,96,117,131,219,73,33,83,171,216,238,60,226,105,31,228,115,249,5,2,167,70,155,253,126,24,61,224,196,18,64,65,27,183,249,144,142,162,62,3,71,178,135,158,196,92,104,7,228,108,90,23,50,89,70,102,41,96,77,172,166,134,159,20,47,10,191,18,94,124,1,89,197,170,225,59,113,42,245,72,224,206,193,13,20,197,51,200,56,157,175,62,187,41,211,4,111,82,44,85,50,72,92,108,31,82,11,109,174,150,39,78,173,239,207,217,25,139,103,60,159,2,162,76,148,89,174,171,17,48,106,89,117,158,134,171,222,239,118,43,187,87,175,37,45,138,147,193,70,10,82,157,5,190,233,157,250,61,25,2,154,68,231,162,253,142,23,172,239,159,254,150,148,234,108,54,195,109,92,213,117,242,5,170,78,213,107,54,67,61,236,163,42,95,151,184,31,98,103,241,153,197,220,196,51,22,180,205,109,93,80,139,25,228,172,1,89,56,192,68,85,35,73,111,4,41,85,227,98,249,59,40,121,213,2,227,46,112,111,93,30,43,43,163,218,216,22,158,228,130,86,168,115,210,173,138,99,102,74,46,108,109,112,98,175,233,146,214,38,79,14,86,235,44,104,133,213,247,245,251,104,76,17,25,110,74,125,73,231,112,144,27,80,57,23,100,0,115,167,128,122,111,85,204,33,122,152,8,185,104,136,223,191,179,125,10,231,106,90,210,229,30,150,102,56,25,209,116,189,81,15,34,124,89,35,105,72,32,249,255,118,224,53,87,247,223,70,191,191,124,189,29,185,92,240,196,175,239,205,20,246,133,250,67,90,136,231,4,175,91,114,245,181,192,197,64,197,249,175,251,216,206,253,117,175,215,150,70,159,127,0,220,144,177,56,215,16,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFormulaErrorDivisionByZeroLocalizableString());
			LocalizableStrings.Add(CreateFormulaErrorInvalidExpressionLocalizableString());
			LocalizableStrings.Add(CreateFormulaErrorSizeExceededLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorDivisionByZeroLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2803ac41-a52f-49a0-9401-5d8ea0a163c6"),
				Name = "FormulaErrorDivisionByZero",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorInvalidExpressionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("dc7e4609-6ddd-4c7b-8ad4-b56900b4b4d5"),
				Name = "FormulaErrorInvalidExpression",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFormulaErrorSizeExceededLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9e2fbf3c-ae0a-4801-aa90-f7fb21b38026"),
				Name = "FormulaErrorSizeExceeded",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"),
				ModifiedInSchemaUId = new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dbc5a0bb-9cca-4395-8de4-81203bdde4cb"));
		}

		#endregion

	}

	#endregion

}

