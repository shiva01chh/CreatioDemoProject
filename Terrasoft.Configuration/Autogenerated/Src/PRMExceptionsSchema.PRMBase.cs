namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMExceptionsSchema

	/// <exclude/>
	public class PRMExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMExceptionsSchema(PRMExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3");
			Name = "PRMExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,79,111,194,48,12,197,207,32,241,29,172,238,2,210,212,222,25,112,97,76,154,180,13,196,208,238,38,117,33,82,155,84,113,34,198,208,190,251,220,63,48,96,98,189,229,245,249,151,103,59,6,11,226,18,21,193,138,156,67,182,153,143,167,214,100,122,19,28,122,109,77,188,88,190,246,186,135,94,183,19,88,155,205,133,173,40,172,121,232,117,229,223,157,163,141,152,97,154,35,243,16,158,130,73,87,251,146,30,67,153,107,133,158,102,159,138,202,10,87,187,147,36,129,17,135,162,64,183,159,180,231,185,82,193,49,236,182,100,32,48,57,240,78,19,131,183,128,105,10,153,0,97,167,253,22,188,96,197,165,213,22,182,200,128,185,35,76,247,149,137,210,248,200,78,206,224,101,88,75,6,80,85,178,127,130,193,16,222,66,158,207,221,172,40,253,254,44,111,231,80,103,254,109,209,26,246,46,40,111,157,116,186,168,233,141,227,186,173,90,152,74,62,47,141,104,169,66,35,115,182,89,211,195,136,137,64,57,202,198,209,237,84,81,50,137,79,232,228,154,61,42,209,97,1,70,118,56,142,88,2,225,134,162,201,146,216,6,39,55,181,74,60,74,106,95,93,214,78,227,246,141,253,231,99,253,123,83,126,196,12,100,66,107,100,234,87,152,142,161,29,188,88,133,185,254,194,117,46,94,39,143,163,223,90,239,33,146,87,115,66,114,36,194,31,51,199,183,67,196,31,152,7,138,6,3,168,30,94,231,187,221,0,153,180,89,66,125,110,212,75,177,214,170,239,7,209,217,220,195,216,2,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFundTypeDuplicateExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFundTypeDuplicateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("28e5b2ac-8529-4669-a3f6-90792e6f311c"),
				Name = "FundTypeDuplicateException",
				CreatedInPackageId = new Guid("83b9dda3-84f4-4c2e-b329-54cd69be3f63"),
				CreatedInSchemaUId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3"),
				ModifiedInSchemaUId = new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ed693a9-5407-4385-87e0-d7a39b259ee3"));
		}

		#endregion

	}

	#endregion

}

