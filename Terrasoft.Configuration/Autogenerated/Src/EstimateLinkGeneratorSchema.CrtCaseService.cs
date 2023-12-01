﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EstimateLinkGeneratorSchema

	/// <exclude/>
	public class EstimateLinkGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EstimateLinkGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EstimateLinkGeneratorSchema(EstimateLinkGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35e65be3-4578-4856-9860-746fde29c505");
			Name = "EstimateLinkGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,77,111,227,54,16,61,107,129,253,15,83,247,98,3,134,212,94,227,88,70,26,108,19,163,205,54,136,55,219,67,81,20,180,52,114,216,72,148,74,82,110,83,35,255,125,135,164,104,75,138,236,100,123,104,14,14,52,156,55,243,248,230,67,18,172,64,85,177,4,225,19,74,201,84,153,233,240,178,20,25,223,212,146,105,94,138,247,239,118,239,223,5,181,226,98,3,171,39,165,177,152,245,158,201,63,207,49,49,206,42,188,66,129,146,39,47,124,62,225,63,250,96,108,231,42,138,82,12,159,72,28,178,255,138,235,19,40,115,122,173,117,21,94,172,149,150,204,177,234,179,89,161,214,244,164,96,14,38,75,247,194,33,249,120,7,2,18,244,91,137,27,58,128,203,156,41,117,6,31,148,230,5,211,248,51,23,143,202,222,151,233,82,90,207,40,138,224,92,213,69,193,228,83,220,60,175,40,170,202,28,19,200,113,139,57,228,132,132,141,71,134,30,24,181,144,85,189,206,121,2,137,73,217,201,184,79,8,103,176,188,97,137,44,213,82,108,203,71,182,206,145,112,59,203,227,64,153,110,175,153,208,68,251,86,242,45,197,112,231,149,123,128,196,156,3,41,101,85,44,31,81,152,28,63,150,146,210,145,58,163,221,119,207,209,10,229,150,39,120,83,166,152,71,151,76,225,29,51,226,220,48,193,54,88,160,208,141,67,168,182,73,228,169,26,191,232,183,133,249,183,76,231,187,239,159,23,191,143,172,154,150,29,138,212,17,28,96,43,235,132,110,103,8,91,9,156,71,95,88,107,88,10,174,57,203,249,191,168,128,129,192,191,129,219,219,82,51,151,25,232,7,36,8,210,29,37,102,243,209,160,134,163,40,118,18,135,251,36,237,34,248,42,12,98,199,19,48,147,17,60,255,223,12,43,38,89,1,130,6,119,62,122,160,86,39,213,52,77,215,69,146,160,82,132,136,151,199,115,44,175,7,0,81,28,158,71,54,106,252,31,100,24,10,9,3,188,26,185,130,63,6,206,168,213,6,172,179,150,188,199,90,230,86,150,21,74,205,73,224,35,45,62,200,111,136,196,236,85,212,144,13,230,241,96,52,88,44,236,117,131,241,145,11,183,130,133,3,129,39,179,175,185,248,107,163,114,175,80,154,97,23,110,79,159,110,119,227,124,185,247,237,63,238,104,115,233,25,40,243,51,80,156,32,104,179,188,65,253,80,166,174,54,165,166,8,152,158,96,121,135,186,150,130,70,165,170,136,135,221,198,80,203,252,8,91,107,145,14,18,223,203,188,89,99,212,203,222,232,10,218,228,133,45,151,186,102,222,13,174,80,95,28,242,16,222,15,116,176,101,18,170,82,106,150,175,184,70,19,121,222,123,113,208,107,78,127,102,121,141,227,174,56,83,24,221,182,129,163,169,39,245,161,168,244,211,196,182,88,192,51,24,55,230,165,250,88,231,249,47,210,30,143,59,73,39,158,78,208,234,142,246,152,116,123,200,247,141,161,230,23,192,184,73,24,56,65,58,224,111,230,32,40,181,59,15,22,64,47,206,123,205,115,110,58,202,196,248,129,54,119,79,159,22,60,188,195,191,106,84,122,210,224,207,222,46,208,73,105,158,93,251,120,194,29,65,218,235,96,176,125,40,167,2,137,73,41,83,224,41,189,152,120,198,169,237,51,89,22,192,228,166,54,239,42,40,215,127,18,149,83,45,213,222,175,30,54,138,47,122,1,94,108,76,223,116,119,158,192,171,141,120,85,243,212,144,118,136,101,58,118,161,247,92,219,253,232,174,181,39,49,63,92,136,41,248,9,159,172,216,183,140,203,115,167,234,212,70,143,23,179,182,156,221,32,225,53,83,22,6,139,254,137,53,187,95,26,93,19,201,85,233,45,27,185,53,242,175,109,37,63,239,205,68,110,109,190,140,182,99,97,191,107,190,182,72,234,80,37,245,134,50,169,58,215,71,118,134,219,131,47,23,134,251,222,114,141,221,43,150,242,213,178,85,77,236,119,15,149,169,93,222,131,107,167,42,13,5,247,209,53,238,125,132,77,135,246,212,180,137,63,57,81,15,103,237,26,173,141,254,190,0,235,104,47,166,245,11,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSatisfactionLevelMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSatisfactionLevelMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1a6cce04-5fc6-d927-128b-2d0b02ef9fbd"),
				Name = "SatisfactionLevelMessage",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("35e65be3-4578-4856-9860-746fde29c505"),
				ModifiedInSchemaUId = new Guid("35e65be3-4578-4856-9860-746fde29c505")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35e65be3-4578-4856-9860-746fde29c505"));
		}

		#endregion

	}

	#endregion

}
