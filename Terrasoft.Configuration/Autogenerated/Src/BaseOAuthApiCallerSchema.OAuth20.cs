﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseOAuthApiCallerSchema

	/// <exclude/>
	public class BaseOAuthApiCallerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseOAuthApiCallerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseOAuthApiCallerSchema(BaseOAuthApiCallerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9843273-15ff-08e6-8b05-996518be7c54");
			Name = "BaseOAuthApiCaller";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c966bd43-e9f4-4f60-86c2-6f60723d4eee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,87,223,111,219,54,16,126,118,129,254,15,172,186,7,25,48,132,97,143,73,147,192,113,157,204,88,147,20,117,178,61,12,67,65,75,103,155,27,77,10,36,229,88,13,242,191,239,248,67,178,36,255,106,129,1,211,67,18,74,199,227,119,223,125,119,199,8,186,2,157,211,20,200,35,40,69,181,156,155,100,36,197,156,45,10,69,13,147,34,121,24,22,102,249,203,207,111,223,188,188,125,211,43,52,19,11,178,224,114,70,249,217,217,72,174,86,104,241,73,46,22,248,250,188,254,62,45,181,129,85,119,141,126,57,135,212,58,213,201,45,8,80,44,221,218,52,143,183,94,247,127,81,112,232,125,50,22,134,25,6,250,164,65,50,94,131,48,135,237,110,104,106,164,58,224,233,14,180,166,54,218,45,76,130,79,215,204,145,54,17,6,22,158,197,125,174,186,54,201,120,147,66,30,172,209,254,189,130,5,46,200,136,83,173,207,200,53,213,224,182,12,115,54,162,200,164,114,86,121,49,227,44,37,116,166,141,66,224,36,181,214,123,140,137,247,224,72,40,29,3,159,24,102,69,88,55,61,155,218,250,188,27,6,60,195,3,63,43,182,166,6,220,41,189,220,47,136,54,136,53,37,10,104,38,5,47,201,4,147,79,190,114,252,113,65,240,207,59,42,232,2,20,166,215,88,85,128,138,163,160,159,168,239,163,234,189,7,145,249,147,194,122,231,88,105,80,37,144,85,7,135,37,249,200,156,118,168,42,63,60,150,57,12,16,139,66,70,47,201,87,168,136,243,217,129,47,160,101,161,82,248,13,74,125,226,84,212,58,186,41,108,198,237,217,142,204,112,176,39,118,151,201,248,32,144,99,56,250,196,145,220,59,10,22,73,60,17,75,175,247,122,60,32,164,47,7,101,117,126,132,202,201,36,3,39,132,41,168,53,75,225,15,69,115,220,69,14,188,190,184,36,183,174,228,135,121,62,5,99,48,88,157,220,0,53,133,130,39,13,83,200,41,74,24,170,79,55,82,213,77,131,132,167,119,229,117,236,139,171,180,2,249,112,0,197,101,173,153,70,113,68,253,173,47,251,156,253,128,187,83,202,187,3,179,148,7,21,191,150,44,35,247,210,176,121,137,177,170,225,76,22,166,174,212,216,190,66,13,9,223,215,176,15,52,151,3,82,27,110,243,90,9,129,205,73,252,238,78,47,70,75,138,246,188,170,156,137,254,82,8,129,52,86,118,61,5,200,179,235,32,46,249,248,115,77,21,73,253,54,84,204,30,31,168,105,42,82,108,101,76,100,19,108,189,215,229,211,36,139,219,224,146,81,161,20,18,102,35,72,38,89,255,188,70,85,187,190,32,162,224,252,4,16,205,86,57,135,160,86,132,35,224,153,76,91,239,194,246,107,153,149,77,129,95,33,78,108,63,91,138,174,174,182,31,7,126,207,36,195,29,183,5,203,146,123,120,182,191,227,190,63,222,163,104,157,157,252,138,77,9,99,177,231,216,186,188,199,209,134,187,163,97,106,85,249,32,156,168,70,156,97,204,168,99,172,109,47,172,35,158,166,40,24,43,127,130,242,178,30,227,126,242,40,167,174,216,227,192,87,224,42,249,44,181,9,187,227,150,175,254,247,20,109,67,129,7,42,214,169,112,180,132,244,159,17,21,62,207,83,201,11,167,65,57,251,27,141,136,118,104,171,108,217,212,248,114,64,252,177,111,251,125,111,114,94,27,180,21,97,147,227,236,146,182,170,189,125,71,61,31,175,167,144,22,202,14,19,129,243,16,146,10,220,120,131,239,13,60,96,233,57,130,227,104,7,113,212,34,165,17,36,83,166,160,220,7,27,252,132,182,27,15,61,68,234,151,3,114,170,240,92,32,215,48,199,137,238,166,221,80,45,52,129,138,29,223,177,9,206,98,169,26,210,69,181,251,96,183,162,148,20,85,179,93,54,141,140,42,43,109,7,88,149,42,124,117,160,192,210,37,137,49,2,219,145,154,74,135,77,93,84,93,8,88,61,159,100,74,57,251,70,103,28,130,216,58,220,87,51,97,138,189,15,183,13,26,250,180,162,15,181,115,124,212,252,105,112,131,156,239,65,215,255,43,68,209,219,137,29,54,199,226,171,16,174,173,40,246,197,26,88,215,206,250,73,49,244,232,110,92,237,11,39,222,22,235,33,131,129,253,78,121,1,113,55,191,245,136,104,244,124,235,147,71,213,56,78,198,171,28,37,127,190,151,230,96,130,147,106,69,77,252,255,145,190,151,50,76,192,96,75,210,143,37,227,123,52,246,95,4,31,237,222,139,162,138,130,104,199,157,78,158,4,108,114,87,229,227,6,152,196,37,55,194,112,97,147,180,26,230,201,120,237,160,234,152,188,235,204,43,192,97,58,178,115,144,131,29,35,120,205,131,224,219,94,88,19,7,36,254,41,122,105,210,243,122,70,94,218,110,95,163,10,209,193,75,64,87,156,109,7,253,46,236,86,58,186,160,31,151,74,62,111,93,55,109,155,142,118,122,103,253,15,128,107,158,29,47,123,218,221,190,75,81,240,218,124,133,111,236,243,47,136,135,21,6,39,14,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUnexpectedErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUnexpectedErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e3601f79-2863-4171-936b-d3f3c49536ef"),
				Name = "UnexpectedErrorMessage",
				CreatedInPackageId = new Guid("49af2168-effb-4b7f-bce2-28e45d430d96"),
				CreatedInSchemaUId = new Guid("b9843273-15ff-08e6-8b05-996518be7c54"),
				ModifiedInSchemaUId = new Guid("b9843273-15ff-08e6-8b05-996518be7c54")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9843273-15ff-08e6-8b05-996518be7c54"));
		}

		#endregion

	}

	#endregion

}

