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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,77,111,194,48,12,134,207,32,237,63,88,229,2,18,106,239,12,184,160,77,66,26,210,52,216,238,166,117,33,82,155,84,113,58,62,166,253,247,185,31,64,53,4,59,236,43,151,40,142,253,248,117,242,106,76,137,51,12,9,22,100,45,178,137,157,63,49,58,86,171,220,162,83,70,251,247,42,161,231,44,49,24,221,180,223,110,218,173,156,149,94,193,124,199,142,210,219,227,185,89,157,166,70,203,141,220,117,44,173,132,1,147,4,153,7,48,195,109,65,155,171,61,221,109,67,162,136,162,98,207,138,62,101,126,16,4,48,228,60,77,209,238,198,245,121,177,38,160,67,22,184,53,58,80,44,187,53,27,13,155,53,105,136,133,9,44,208,226,130,106,176,127,192,5,13,94,150,47,19,21,66,88,200,185,170,6,6,208,80,214,42,230,62,13,99,52,59,155,135,206,88,153,233,177,68,150,234,207,228,151,129,137,37,116,196,160,164,10,181,60,180,137,193,237,50,146,76,34,8,45,197,35,239,154,20,47,24,251,71,120,240,153,62,204,208,98,10,90,190,113,228,177,72,194,21,121,227,39,98,147,91,233,85,71,252,97,80,230,149,101,245,35,92,235,217,157,30,8,243,10,112,0,245,10,64,171,53,128,37,50,117,53,109,224,193,132,152,168,61,46,5,229,172,88,161,91,167,246,193,59,89,231,72,102,175,95,33,188,179,66,246,175,73,154,17,115,49,201,11,38,57,121,189,30,148,127,242,94,61,124,135,116,84,253,142,156,170,88,51,116,238,196,169,126,149,230,81,179,219,143,186,80,85,252,175,77,120,73,200,31,27,240,146,140,223,50,223,165,126,255,100,188,75,114,190,99,58,137,200,250,0,200,189,230,12,96,5,0,0 };
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

