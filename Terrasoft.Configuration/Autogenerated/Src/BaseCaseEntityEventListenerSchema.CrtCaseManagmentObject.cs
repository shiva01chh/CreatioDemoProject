﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCaseEntityEventListenerSchema

	/// <exclude/>
	public class BaseCaseEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCaseEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCaseEntityEventListenerSchema(BaseCaseEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6");
			Name = "BaseCaseEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,89,91,111,219,54,20,126,118,129,254,7,86,29,10,25,48,148,108,195,94,150,38,67,226,164,153,129,220,86,39,219,195,48,20,140,68,219,218,100,202,35,41,183,110,155,255,190,195,155,68,74,180,163,165,9,208,54,34,207,253,124,231,240,144,173,120,78,231,104,186,225,130,44,15,94,190,168,156,207,228,34,167,255,214,107,183,132,49,204,203,153,72,198,229,114,89,210,224,6,35,91,150,147,51,42,114,145,19,254,216,126,114,182,38,84,72,178,151,47,40,94,18,190,194,41,241,136,233,44,159,87,12,139,188,164,47,95,124,121,249,98,224,217,60,46,139,130,164,114,147,39,231,132,18,150,167,7,109,154,91,242,73,40,5,131,215,140,204,129,20,141,11,204,249,207,232,4,115,50,134,63,202,152,141,178,228,34,7,22,16,163,200,255,12,108,196,211,116,65,150,248,10,108,69,135,40,146,236,209,240,47,32,94,85,247,69,158,162,84,138,222,37,25,105,189,65,157,3,233,223,96,197,242,53,22,4,221,113,194,192,127,170,253,67,31,42,239,251,192,37,213,210,208,135,20,36,123,27,231,85,158,193,114,197,24,40,2,102,129,83,49,201,2,36,101,145,93,127,4,35,130,155,148,124,108,54,229,182,13,228,37,17,139,50,131,80,222,104,122,189,107,153,185,96,50,13,231,68,92,148,41,46,242,207,248,190,32,83,181,24,155,189,127,200,102,136,148,215,3,70,68,197,40,2,93,168,75,222,114,62,249,163,100,255,40,172,36,239,9,47,43,150,2,97,201,240,156,140,148,172,193,32,218,145,130,104,132,190,139,58,58,120,242,5,172,121,72,126,199,69,5,57,85,97,120,144,14,185,46,173,75,136,7,80,228,25,124,77,1,149,124,134,149,69,23,100,77,138,216,250,146,207,80,220,217,29,47,48,157,147,12,136,222,188,65,175,218,30,157,158,76,9,228,73,218,74,231,57,37,0,103,49,198,244,236,19,172,10,114,189,34,186,6,98,128,28,213,146,164,119,29,37,209,208,218,48,48,33,94,107,107,129,224,146,112,14,33,146,245,0,216,125,174,64,75,51,110,96,1,162,26,10,106,199,194,219,124,229,197,120,48,16,11,86,126,84,246,156,125,74,201,74,185,25,180,218,48,60,212,169,105,18,115,95,150,5,218,17,114,15,99,170,78,84,128,245,62,116,145,106,73,149,81,60,30,38,199,116,19,167,232,240,200,120,8,63,113,156,38,186,228,161,230,59,90,38,89,36,83,154,38,215,69,166,132,160,87,135,240,165,126,29,54,66,190,126,69,59,197,200,70,11,40,141,26,14,137,147,88,7,50,153,240,171,170,40,174,217,217,114,37,192,188,70,23,230,166,208,134,30,227,22,182,54,143,252,57,8,196,83,1,125,74,196,132,66,159,198,197,41,22,56,46,239,255,6,84,32,78,104,70,152,13,169,138,37,192,41,214,133,54,212,187,58,81,45,48,1,149,142,252,93,183,147,109,81,127,195,202,20,242,127,131,25,132,77,16,198,227,70,111,171,169,73,233,45,240,142,53,137,84,151,248,205,111,224,52,188,218,44,0,196,237,102,69,50,8,173,131,136,183,178,7,30,197,145,161,182,168,117,154,98,71,192,163,220,65,111,55,52,133,66,160,249,103,242,158,44,115,154,201,242,169,221,93,99,134,114,126,69,72,118,91,78,33,196,154,68,106,118,28,1,216,249,189,218,48,202,156,220,150,215,134,176,203,36,109,76,20,66,36,142,219,18,131,167,135,35,247,202,104,68,158,246,128,92,127,179,155,192,128,238,182,55,178,177,6,194,0,165,165,51,48,225,19,122,74,10,34,36,182,109,35,148,76,143,64,195,44,203,236,73,189,114,89,254,158,76,167,55,210,172,184,21,65,89,202,93,133,1,7,154,8,12,155,198,60,184,97,100,133,25,9,103,220,145,48,10,159,157,145,181,195,180,198,104,104,59,233,67,227,176,159,155,190,186,155,120,111,211,109,37,110,209,29,234,205,10,222,59,245,170,49,163,180,138,205,193,181,212,26,222,149,108,137,133,117,192,76,58,204,242,154,239,110,237,235,13,61,173,93,98,10,130,152,172,207,9,229,2,211,148,156,108,100,35,142,163,218,136,200,180,207,100,204,8,24,173,217,219,176,25,54,216,151,217,239,87,250,77,207,144,124,180,90,222,235,90,217,202,167,253,7,206,43,69,235,114,167,37,24,107,122,169,60,48,79,115,101,23,102,27,195,53,66,186,75,31,217,132,219,188,71,199,21,204,106,114,246,233,213,37,77,78,71,53,110,34,179,5,2,76,162,186,36,83,53,32,0,69,29,85,96,226,130,39,245,183,166,208,166,132,36,24,143,71,38,76,30,178,156,190,35,152,241,95,163,242,164,202,11,56,116,98,19,168,25,220,48,112,186,64,246,192,90,171,51,47,167,77,244,244,49,200,221,81,41,57,94,173,160,100,98,69,236,14,26,118,142,90,96,190,0,173,239,242,130,220,137,188,208,215,23,72,223,229,233,79,191,194,22,156,127,105,41,93,76,238,104,14,191,169,212,158,108,4,76,20,82,58,180,43,93,64,246,188,29,180,32,156,192,105,119,74,102,254,40,178,149,210,33,139,35,27,206,190,185,237,41,182,166,111,82,222,147,83,103,89,49,246,68,66,79,193,154,251,54,95,146,71,124,149,179,157,254,132,201,133,72,134,216,198,221,164,83,86,223,180,210,0,233,85,140,134,216,86,163,207,239,124,37,23,132,206,197,2,29,161,31,247,247,209,47,222,22,252,171,229,197,251,35,185,61,132,219,160,179,239,32,92,47,140,241,202,20,187,102,75,116,51,140,189,214,56,250,63,173,100,228,234,235,155,78,207,24,136,188,111,93,171,41,234,150,251,244,142,172,175,212,61,45,219,112,87,170,66,92,99,67,114,215,31,177,218,163,90,64,111,70,89,250,192,35,155,195,54,14,188,38,177,55,246,189,134,62,163,47,208,219,110,211,234,45,65,111,238,237,237,161,183,188,90,46,161,199,31,217,5,176,130,219,44,32,104,119,104,85,50,129,11,101,122,82,115,237,185,108,230,125,98,157,51,81,1,101,61,96,43,198,113,131,9,111,226,228,223,80,32,114,8,121,197,67,183,16,35,117,168,198,182,39,207,101,117,243,214,151,58,183,99,107,40,10,50,47,217,166,223,25,61,174,169,189,211,214,172,54,101,168,46,229,156,156,251,27,113,163,204,225,190,119,248,28,107,192,13,41,194,244,67,245,171,217,156,18,182,206,83,248,44,224,74,9,157,35,60,128,153,48,159,108,244,66,36,123,200,78,74,232,18,150,212,29,221,141,46,199,179,169,183,22,59,212,115,249,108,2,86,102,77,199,243,27,82,244,101,255,1,125,249,30,254,252,240,128,84,13,121,1,26,53,193,24,181,84,219,235,148,202,208,150,178,4,129,109,11,188,130,10,214,200,185,170,17,173,11,236,81,202,182,212,134,90,209,48,226,71,239,245,191,29,214,183,123,150,34,80,78,205,83,87,59,136,110,53,233,173,137,32,203,126,168,156,186,12,129,236,253,86,17,182,49,147,144,219,7,213,122,231,202,19,232,191,35,228,234,176,26,92,233,201,113,102,44,131,51,4,250,115,192,10,9,6,151,3,28,10,79,207,35,63,2,78,159,168,37,129,47,208,40,90,165,109,177,166,186,135,91,231,118,91,115,63,114,0,54,198,63,138,26,139,222,62,176,89,201,167,9,36,223,174,15,163,166,202,163,163,73,6,109,44,159,229,48,235,151,179,90,34,160,72,49,108,135,93,71,119,79,220,133,218,146,186,86,57,189,201,193,162,93,125,14,8,185,61,172,25,143,28,249,187,64,84,251,123,232,219,180,11,70,157,118,43,49,212,8,122,18,136,234,12,61,7,138,244,249,188,1,85,229,146,35,81,34,177,32,79,56,156,167,70,130,247,174,28,60,82,251,28,207,70,88,228,188,68,124,235,25,191,173,109,91,85,245,168,24,122,185,213,62,151,107,194,88,158,153,87,130,107,10,227,146,60,188,188,183,198,145,129,230,9,145,87,59,245,150,127,204,230,28,17,235,200,189,180,162,230,181,76,246,26,215,122,198,52,239,151,245,94,224,141,209,153,96,218,37,32,39,86,254,142,96,0,13,57,163,242,184,205,226,232,78,255,95,195,132,202,191,175,139,236,93,69,83,231,37,222,75,229,65,189,22,152,189,92,96,238,248,111,134,131,94,113,4,203,130,97,60,158,129,151,59,163,8,156,157,32,134,159,39,123,88,98,159,199,158,150,211,154,251,185,178,218,195,145,214,128,174,87,253,69,88,115,127,254,3,144,210,241,254,88,29,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSubjectForStringLocalizableString());
			LocalizableStrings.Add(CreateSubjectByStringLocalizableString());
			LocalizableStrings.Add(CreateOldOwnerMessageLocalizableString());
			LocalizableStrings.Add(CreateNewOwnerMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSubjectForStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d3a13680-abcb-12c3-31da-bf60fe6628dc"),
				Name = "SubjectForString",
				CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1"),
				CreatedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6"),
				ModifiedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectByStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b5046b6d-54a0-43d1-92a1-0cdd1da59b03"),
				Name = "SubjectByString",
				CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1"),
				CreatedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6"),
				ModifiedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOldOwnerMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("955cb2c0-c05a-deec-62ae-06848a2683df"),
				Name = "OldOwnerMessage",
				CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1"),
				CreatedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6"),
				ModifiedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewOwnerMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4dfa3618-3fc4-f748-7954-cab76c535b50"),
				Name = "NewOwnerMessage",
				CreatedInPackageId = new Guid("0d3d36e6-4bde-4001-82d8-c1ab3fe448d1"),
				CreatedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6"),
				ModifiedInSchemaUId = new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("340f9ea9-6303-4440-9e7d-04b2cce5b1f6"));
		}

		#endregion

	}

	#endregion

}

