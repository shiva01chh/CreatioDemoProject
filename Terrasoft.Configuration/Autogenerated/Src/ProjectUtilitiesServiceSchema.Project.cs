﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProjectUtilitiesServiceSchema

	/// <exclude/>
	public class ProjectUtilitiesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProjectUtilitiesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProjectUtilitiesServiceSchema(ProjectUtilitiesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229");
			Name = "ProjectUtilitiesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,223,79,219,48,16,126,14,18,255,195,169,123,73,37,148,190,15,90,9,216,64,76,43,155,40,140,135,106,154,220,228,90,60,18,59,179,29,88,64,253,223,119,182,147,38,109,19,88,31,42,217,254,238,215,119,223,93,4,203,80,231,44,70,184,69,165,152,150,75,19,157,75,177,228,171,66,49,195,165,56,60,120,61,60,8,10,205,197,10,102,165,54,152,29,239,156,163,155,66,24,158,97,52,67,197,89,202,95,156,221,30,138,94,159,120,140,83,153,96,250,230,99,116,26,27,254,244,190,147,232,30,23,13,160,157,190,194,232,130,197,70,42,142,186,11,65,134,132,202,50,23,128,222,63,40,92,81,52,56,79,153,214,31,225,92,230,229,119,37,127,99,108,110,136,28,41,52,58,216,104,52,130,19,93,100,25,83,229,164,58,91,44,200,28,61,89,160,42,60,196,214,85,84,27,141,90,86,121,177,72,121,236,1,93,161,192,38,208,106,64,85,114,147,73,96,27,178,151,140,207,70,33,51,152,64,238,93,2,79,144,90,179,228,168,54,38,237,84,130,249,39,102,216,20,179,5,170,240,154,148,0,99,24,84,62,170,172,174,146,193,240,167,133,86,105,95,22,60,129,93,8,188,194,10,205,49,104,251,183,38,244,218,211,138,34,241,204,118,177,92,89,223,25,158,114,67,141,170,234,108,152,230,226,129,4,101,18,25,195,104,210,67,127,101,4,207,220,60,64,81,187,130,12,205,131,76,52,44,165,170,227,128,101,194,148,157,45,153,87,110,136,119,163,72,56,182,224,249,169,206,175,209,144,76,114,106,195,194,122,46,111,240,79,193,21,102,228,74,135,237,131,213,35,113,247,142,137,69,69,213,69,226,88,221,210,66,15,33,164,135,51,166,113,67,143,111,127,77,230,5,199,52,113,108,218,145,241,236,5,185,63,144,26,89,34,69,90,194,87,246,82,158,84,254,173,228,166,76,176,21,170,9,252,138,155,147,159,133,221,174,53,109,35,245,25,85,216,177,178,241,92,230,30,209,45,197,6,30,117,139,175,42,190,167,236,112,8,174,208,160,157,34,113,44,240,185,183,156,208,25,4,100,58,158,120,153,249,53,80,70,151,104,222,48,8,172,211,86,194,167,106,85,216,142,133,131,66,163,162,7,65,118,196,193,224,8,238,182,46,134,195,161,221,47,149,222,123,169,155,122,57,254,23,107,180,78,234,233,117,162,102,105,10,186,88,72,149,112,97,123,250,44,213,163,238,97,212,221,228,76,177,12,4,77,243,120,144,111,134,120,242,125,111,37,156,140,28,212,47,130,111,245,10,107,207,64,48,167,77,121,37,158,228,35,134,119,138,223,98,150,167,54,7,187,37,154,197,117,79,105,206,28,115,133,66,162,168,222,84,23,82,101,204,16,152,156,76,81,107,98,220,95,69,95,180,20,71,142,250,51,153,148,51,83,166,184,5,219,220,70,247,138,229,57,38,118,104,80,155,173,77,212,181,58,251,178,10,221,218,218,176,81,75,171,203,197,102,131,123,169,117,65,188,113,48,43,226,152,242,37,32,133,65,119,183,118,106,8,140,42,107,80,237,46,218,219,153,227,173,225,139,126,176,180,32,84,95,1,77,238,62,196,26,98,102,226,7,8,63,255,141,49,119,223,30,28,238,5,109,82,92,178,84,227,241,206,115,99,59,134,234,113,237,254,21,82,208,230,107,214,167,241,142,61,191,134,195,3,251,251,7,2,147,2,110,88,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoRightsToCopyProjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoRightsToCopyProjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("df1db353-f52f-401e-a2a5-76847c4bb6fe"),
				Name = "NoRightsToCopyProject",
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305"),
				CreatedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"),
				ModifiedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"));
		}

		#endregion

	}

	#endregion

}

