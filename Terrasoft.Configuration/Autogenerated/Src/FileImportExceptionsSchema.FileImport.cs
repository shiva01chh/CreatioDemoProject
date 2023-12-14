namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImportExceptionsSchema

	/// <exclude/>
	public class FileImportExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImportExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImportExceptionsSchema(FileImportExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065");
			Name = "FileImportExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,82,77,107,194,64,16,61,43,248,31,134,244,162,80,146,187,85,47,214,210,66,191,168,210,251,24,39,186,144,221,13,59,27,172,45,253,239,157,172,241,179,57,20,74,105,46,97,103,223,123,243,102,246,25,212,196,5,166,4,51,114,14,217,102,62,30,91,147,169,101,233,208,43,107,226,27,149,211,157,46,172,243,157,246,71,167,221,42,89,153,37,76,55,236,73,95,237,207,199,108,173,173,145,27,185,187,112,180,20,13,24,231,200,220,135,137,46,252,230,150,112,65,110,242,150,82,81,233,7,92,146,36,48,224,82,107,116,155,81,125,158,173,8,104,135,2,191,66,15,138,229,239,236,218,192,122,69,6,50,113,6,11,75,12,198,122,72,173,241,168,12,32,172,66,135,120,167,155,28,9,23,229,60,87,41,164,149,159,70,59,208,135,199,50,207,159,92,184,60,114,217,250,8,78,15,35,89,195,222,149,169,183,78,38,123,14,186,91,196,249,48,161,48,118,132,94,156,42,97,161,145,117,219,12,252,166,32,65,18,65,234,40,27,70,77,126,162,100,20,239,69,147,115,213,65,129,14,53,24,121,196,97,196,98,5,151,20,141,94,136,109,233,164,71,93,137,7,73,192,5,90,189,129,166,94,221,187,29,115,186,37,238,4,122,21,177,213,135,57,50,117,13,173,225,222,166,152,171,119,156,231,2,117,242,254,221,26,121,9,209,33,47,123,97,142,164,254,141,195,113,147,137,7,98,174,60,191,98,94,82,212,235,65,149,185,214,103,189,124,50,139,237,254,195,121,91,61,43,54,101,238,26,61,254,93,226,22,162,254,195,180,157,24,249,247,172,157,184,249,211,164,157,116,250,159,156,157,88,248,109,202,164,86,125,95,90,235,103,183,62,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyHeaderExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateEmptyDataExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyHeaderExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e8ba9ed7-7f74-43c3-9ac9-e0f6b8e886fc"),
				Name = "EmptyHeaderExceptionMessage",
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065"),
				ModifiedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateEmptyDataExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1d2b6f72-8681-4848-a93e-39afafa9f2f2"),
				Name = "EmptyDataExceptionMessage",
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065"),
				ModifiedInSchemaUId = new Guid("d8637c44-884d-415b-8ad0-91caafbca065")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8637c44-884d-415b-8ad0-91caafbca065"));
		}

		#endregion

	}

	#endregion

}

