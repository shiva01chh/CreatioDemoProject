﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QueuesFolderUtilitiesSchema

	/// <exclude/>
	public class QueuesFolderUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QueuesFolderUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QueuesFolderUtilitiesSchema(QueuesFolderUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bd89a439-a54b-4744-a2ec-e5c890a87733");
			Name = "QueuesFolderUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,89,73,111,219,70,20,62,171,64,255,195,148,190,80,168,68,203,137,172,216,137,45,64,214,146,170,112,236,38,114,218,67,209,195,152,28,89,108,40,82,158,25,218,81,3,255,247,190,89,57,92,228,216,64,90,160,168,14,177,56,124,251,242,189,55,74,138,215,132,109,112,72,208,21,161,20,179,108,201,131,113,150,46,227,155,156,98,30,103,41,250,254,187,47,223,127,215,202,89,156,222,160,197,150,113,178,126,83,121,6,134,36,33,161,160,102,193,91,146,18,26,135,53,154,43,242,153,23,135,174,178,245,58,75,119,191,9,126,102,187,94,83,178,235,60,152,156,237,124,53,77,121,204,99,194,154,8,46,242,56,88,16,122,23,135,228,93,22,145,36,152,96,142,33,28,156,226,176,209,250,26,195,244,51,39,41,19,145,0,114,96,216,163,228,70,68,113,156,96,198,94,163,247,57,201,9,155,101,73,68,232,71,30,39,210,18,73,184,191,191,143,78,88,190,94,99,186,29,234,103,69,177,69,161,96,70,203,140,162,251,140,126,66,247,49,95,161,91,41,9,14,133,168,192,8,216,119,36,108,242,235,36,14,53,115,163,98,244,69,170,46,140,4,179,57,78,57,24,250,11,141,239,48,39,234,125,213,54,121,240,150,102,249,6,241,237,134,160,56,34,16,212,101,76,40,242,38,219,20,175,227,208,11,44,163,107,83,107,163,228,34,74,112,148,165,201,22,189,205,227,8,45,8,166,225,74,89,119,5,18,231,17,58,69,41,185,151,111,125,239,203,224,112,60,234,29,247,7,221,94,239,168,223,237,31,189,234,119,207,14,14,94,117,199,7,47,15,142,143,71,179,151,103,199,135,15,94,251,205,243,205,93,112,168,242,103,90,43,75,28,39,187,205,61,158,140,15,103,131,233,160,251,98,52,56,232,246,39,211,163,238,168,119,120,220,157,76,95,246,102,253,233,171,254,236,69,255,223,51,247,130,220,203,236,207,161,13,5,127,206,170,246,190,56,123,217,63,24,29,76,186,131,217,8,236,61,30,244,186,199,227,163,195,238,108,58,27,244,38,7,103,103,227,177,99,239,30,73,35,85,48,229,234,153,197,36,137,158,84,58,39,140,16,20,82,178,60,245,62,50,66,161,236,82,5,31,222,254,16,197,178,6,67,242,84,31,203,18,42,143,95,49,89,22,60,205,67,158,81,97,184,108,152,71,236,22,116,59,204,146,39,27,76,241,26,65,253,147,83,47,47,59,54,20,118,161,208,30,4,39,251,146,90,249,164,58,181,177,71,253,138,127,101,185,109,209,194,173,86,171,66,116,90,33,19,208,213,122,120,60,22,239,8,95,101,79,203,223,40,138,152,2,32,20,67,81,1,10,209,108,141,248,138,160,236,250,79,208,136,110,68,245,254,19,145,170,49,43,252,147,152,190,245,134,151,174,250,71,249,136,228,88,132,43,178,198,23,112,226,13,175,192,124,38,159,37,9,202,150,210,35,229,166,242,235,113,145,146,114,30,121,195,247,42,50,182,109,235,108,148,240,156,166,108,120,145,175,175,193,89,80,5,180,84,32,50,142,34,18,1,131,161,112,75,62,78,185,8,253,204,113,217,54,54,243,213,1,114,3,210,65,80,221,98,96,85,189,237,40,100,208,22,155,34,226,116,171,191,181,166,14,195,59,156,226,27,176,146,52,156,157,86,250,45,104,96,124,163,68,222,97,16,193,110,53,242,184,116,224,4,221,250,13,226,59,53,195,219,90,24,8,10,160,78,69,81,73,110,216,64,242,117,26,204,217,175,49,139,175,19,2,90,160,175,137,166,150,206,46,203,112,237,198,9,150,22,46,94,68,74,204,175,56,201,201,137,96,26,250,158,139,242,94,187,46,176,46,76,219,229,200,210,92,241,18,249,101,43,78,27,38,159,201,70,171,117,189,229,228,247,63,16,147,36,98,19,105,48,251,12,104,152,84,226,123,11,75,104,13,109,233,2,128,36,197,56,137,255,34,209,44,78,184,76,220,52,13,179,8,222,5,31,175,102,71,66,212,66,146,250,133,186,14,234,117,28,237,193,57,73,111,248,202,138,22,238,84,229,66,6,46,242,36,185,164,211,245,134,111,253,118,225,76,75,85,52,234,25,246,7,253,23,250,225,234,114,114,137,246,198,227,238,224,213,17,218,43,62,104,15,57,223,75,31,251,136,244,250,5,147,45,252,36,150,204,159,72,178,81,27,145,248,40,179,0,161,244,223,83,36,246,201,96,66,172,229,39,154,100,88,115,198,122,58,175,85,171,34,16,141,39,106,122,102,133,107,53,193,89,30,39,209,212,188,241,235,253,87,110,27,171,73,52,201,109,161,160,88,172,65,182,163,8,179,122,3,85,57,220,52,53,138,132,117,56,7,68,129,34,236,61,33,77,187,197,236,78,185,232,82,109,114,0,192,229,23,30,88,135,31,16,73,24,105,102,57,207,110,226,16,39,151,144,78,172,99,208,108,65,149,240,77,147,52,48,51,227,59,69,200,183,150,15,86,109,130,195,21,242,31,205,188,74,54,192,114,179,76,39,16,181,72,44,203,5,102,163,172,255,234,168,52,1,70,195,242,89,40,106,8,120,48,6,87,56,81,167,191,193,205,225,23,49,138,136,32,241,141,197,107,24,79,49,180,133,16,23,76,111,115,156,116,140,97,10,63,130,89,70,215,152,251,222,239,95,122,15,243,84,41,127,13,223,95,207,163,63,2,245,232,53,160,117,199,130,100,219,248,170,61,92,16,17,37,64,23,249,71,22,183,196,32,249,172,6,66,115,139,88,14,245,69,219,25,40,180,245,197,104,145,220,214,75,223,123,175,231,114,199,206,187,246,19,184,204,166,12,108,77,11,116,33,99,148,70,126,59,128,234,129,127,167,159,99,198,153,148,167,60,169,58,97,194,106,52,123,98,168,24,73,51,216,162,140,185,160,202,43,168,127,91,17,74,26,80,68,178,67,237,202,156,185,172,240,74,85,238,7,18,102,52,114,180,40,131,203,164,38,66,133,40,61,79,139,120,216,208,181,5,248,40,231,156,193,14,75,59,161,58,123,122,194,207,157,163,29,97,8,230,41,207,154,60,134,59,53,20,91,197,3,199,208,14,42,242,83,10,159,86,167,106,195,148,140,134,52,215,70,200,20,9,115,78,124,77,243,128,66,204,69,195,79,63,135,100,35,193,134,216,182,82,123,185,221,200,5,220,76,41,205,168,95,110,14,109,135,240,253,60,11,197,32,193,176,137,232,169,90,89,147,62,16,150,229,84,76,173,140,194,166,99,92,171,46,255,158,237,67,175,38,18,16,45,189,203,62,17,181,183,75,131,222,17,198,64,90,32,247,1,200,230,85,166,181,183,141,28,111,231,254,40,218,55,208,2,160,111,237,166,197,87,52,187,215,65,122,214,45,226,107,151,169,230,75,132,202,28,137,212,14,207,158,122,135,48,48,195,188,225,57,180,160,216,168,139,253,155,153,93,190,42,252,63,112,67,24,57,171,155,185,93,201,223,127,226,116,41,203,78,4,29,95,103,57,151,182,164,205,23,10,132,211,8,17,81,34,104,173,82,204,170,119,12,117,5,189,139,41,135,254,55,247,6,200,145,115,195,16,145,61,81,54,12,45,176,179,103,94,50,190,253,205,226,155,92,44,208,143,72,175,250,102,119,126,214,21,67,16,67,176,12,170,215,55,241,10,65,49,190,93,130,111,51,186,229,84,40,38,47,51,163,119,199,239,160,58,176,206,170,73,244,155,98,44,87,73,154,103,179,72,132,44,183,247,57,86,151,209,83,179,71,42,28,146,91,177,200,183,3,86,76,231,173,68,97,96,217,238,97,250,114,171,178,38,54,46,99,163,5,105,231,242,218,170,26,81,126,254,241,145,75,180,82,96,81,183,94,210,166,154,205,54,243,216,220,104,149,252,12,70,155,13,128,230,121,156,194,36,183,72,91,218,138,30,108,24,41,97,121,98,38,169,22,39,189,48,89,211,187,123,217,53,109,119,53,188,101,51,138,161,160,116,42,11,244,140,220,113,153,90,24,12,242,149,97,109,247,7,165,70,116,135,17,20,71,10,157,0,140,54,182,112,193,179,219,60,166,0,73,60,19,11,116,130,176,6,80,9,255,216,249,65,251,127,141,251,78,252,74,184,221,12,219,26,129,53,19,177,245,93,84,182,132,142,111,4,225,165,2,245,60,7,133,197,13,176,0,41,93,190,82,167,82,48,52,141,93,220,108,64,253,206,27,100,69,158,196,69,39,229,109,103,45,145,18,171,230,63,79,112,45,241,53,249,58,14,98,75,126,138,64,147,246,154,156,31,170,228,187,236,212,105,209,185,23,151,158,210,198,217,188,106,122,213,255,66,51,91,164,103,65,42,24,209,155,124,13,14,59,106,61,187,36,42,57,197,190,11,64,15,40,231,87,140,182,55,186,134,204,127,104,128,175,102,252,234,25,165,85,208,210,62,107,120,180,155,188,150,251,85,156,106,52,168,148,8,141,120,74,228,35,63,144,171,211,242,161,60,19,159,191,1,31,189,191,55,63,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInvokeMethodErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInvokeMethodErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d761adac-fc20-4315-80e7-de4204775d57"),
				Name = "InvokeMethodErrorMessage",
				CreatedInPackageId = new Guid("a8569787-b88e-4075-aa85-f8031253bd51"),
				CreatedInSchemaUId = new Guid("bd89a439-a54b-4744-a2ec-e5c890a87733"),
				ModifiedInSchemaUId = new Guid("bd89a439-a54b-4744-a2ec-e5c890a87733")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bd89a439-a54b-4744-a2ec-e5c890a87733"));
		}

		#endregion

	}

	#endregion

}

