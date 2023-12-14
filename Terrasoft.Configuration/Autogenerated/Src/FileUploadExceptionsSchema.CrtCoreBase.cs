namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileUploadExceptionsSchema

	/// <exclude/>
	public class FileUploadExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileUploadExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileUploadExceptionsSchema(FileUploadExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69");
			Name = "FileUploadExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,77,107,195,48,12,134,207,45,236,63,136,236,210,194,72,238,93,219,75,217,96,176,194,88,183,221,213,68,105,13,137,29,44,103,253,24,251,239,147,147,180,13,43,237,14,251,242,197,88,150,30,189,178,95,141,57,113,129,49,193,19,89,139,108,82,23,78,140,78,213,162,180,232,148,209,225,173,202,232,185,200,12,38,23,221,183,139,110,167,100,165,23,48,219,176,163,252,122,127,110,87,231,185,209,114,35,119,151,150,22,194,128,73,134,204,3,152,226,218,211,102,106,75,55,235,152,40,161,196,239,133,239,83,229,71,81,4,67,46,243,28,237,102,220,156,159,150,4,180,203,2,183,68,7,138,101,183,102,165,97,181,36,13,169,48,129,5,234,47,168,1,135,59,92,212,226,21,229,60,83,49,196,94,206,89,53,48,128,150,178,142,159,251,48,140,209,236,108,25,59,99,101,166,135,10,89,169,63,146,95,5,38,150,208,17,131,146,42,212,242,208,38,5,183,41,72,50,137,32,182,148,142,130,115,82,130,104,28,238,225,209,103,250,176,64,139,57,104,249,198,81,192,34,9,23,20,140,31,137,77,105,165,87,19,9,135,81,149,87,149,53,143,112,174,103,239,110,71,152,213,128,29,168,239,1,157,206,0,230,200,212,211,180,130,123,19,99,166,182,56,23,148,179,98,133,94,147,122,5,193,193,58,123,50,7,87,53,34,56,42,228,240,156,164,41,49,251,73,94,48,43,41,232,247,161,250,147,247,250,225,47,73,39,245,239,200,169,142,181,67,199,78,188,211,175,210,60,105,119,251,81,23,170,154,255,181,9,79,9,249,99,3,158,146,241,91,230,59,213,239,159,140,119,74,206,119,76,39,17,191,62,0,172,170,100,167,97,5,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMaxFileSizeExceededExceptionMessageLocalizableString());
			LocalizableStrings.Add(CreateInvalidFileSizeExceptionMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMaxFileSizeExceededExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4f2e8a1b-07d3-4f66-9213-287d5ef48032"),
				Name = "MaxFileSizeExceededExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"),
				ModifiedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateInvalidFileSizeExceptionMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5880e243-dfed-417c-ae92-4c19a2d2bc78"),
				Name = "InvalidFileSizeExceptionMessage",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"),
				ModifiedInSchemaUId = new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("743fae56-f4dc-4ba5-9266-2ebf40deeb69"));
		}

		#endregion

	}

	#endregion

}

