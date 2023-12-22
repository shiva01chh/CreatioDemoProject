﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GridUtilitiesServiceSchema

	/// <exclude/>
	public class GridUtilitiesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GridUtilitiesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GridUtilitiesServiceSchema(GridUtilitiesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f");
			Name = "GridUtilitiesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5af8fc1f-99e6-4265-b65c-5e9401c4c7dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,89,91,79,235,70,16,126,78,165,254,135,109,42,85,70,138,204,233,107,79,136,20,32,80,90,110,37,80,30,16,66,142,61,129,61,199,177,195,238,58,135,244,136,255,222,217,155,189,235,75,200,105,169,84,94,136,215,51,179,51,223,92,118,102,157,69,11,224,203,40,6,114,13,140,69,60,159,139,240,32,207,230,244,177,96,145,160,121,246,253,119,95,191,255,174,87,112,154,61,146,233,154,11,88,124,172,61,35,125,154,66,44,137,121,120,12,25,48,26,55,104,166,16,23,140,138,117,203,11,182,162,49,156,229,9,164,27,95,134,183,48,219,76,48,70,29,86,74,233,6,221,41,205,158,171,197,115,248,34,80,89,105,235,111,220,165,118,49,88,44,54,189,217,192,200,160,107,61,156,100,130,10,10,188,147,96,26,63,65,82,164,192,218,40,206,11,234,27,60,121,17,144,113,137,123,27,57,226,85,153,129,239,127,100,240,136,180,228,32,141,56,255,133,28,51,154,220,8,154,42,133,140,216,95,163,44,193,205,21,249,178,152,165,52,38,177,164,222,76,220,147,17,82,137,71,117,68,148,9,220,226,146,73,127,128,18,215,91,234,7,18,203,247,132,11,38,181,61,56,29,79,167,15,231,227,179,9,217,35,253,182,93,250,31,155,204,52,19,228,112,114,52,190,57,189,126,56,191,57,219,159,92,61,156,92,79,206,166,15,87,147,235,155,171,243,201,33,10,251,249,195,7,109,118,239,71,200,18,173,155,121,174,20,21,172,136,69,206,164,170,202,90,163,169,182,124,131,205,193,13,7,134,252,153,14,123,82,120,143,59,68,1,210,123,240,151,81,41,127,65,89,214,155,130,184,2,158,23,44,6,30,236,168,181,215,205,138,31,81,72,147,46,120,13,176,15,159,242,217,57,230,246,101,36,4,176,236,99,7,201,49,203,139,101,23,93,205,200,135,134,246,117,37,123,61,87,205,51,16,79,121,167,158,171,156,38,196,183,221,194,230,171,142,176,29,131,56,205,227,40,165,127,69,179,20,166,74,253,160,10,157,1,233,159,21,169,160,135,144,130,128,223,60,238,190,70,180,215,102,236,63,144,92,23,209,223,202,97,14,18,185,64,244,32,177,88,152,71,178,162,76,20,81,106,93,211,170,150,121,167,18,82,170,48,176,212,204,64,40,23,45,136,171,136,145,180,46,2,13,214,44,225,81,206,22,145,8,250,141,93,120,248,245,195,107,248,103,148,22,208,31,248,146,53,144,213,158,8,12,10,204,224,11,105,234,90,139,149,208,122,121,138,217,22,61,194,64,137,234,57,166,52,116,53,219,49,16,5,122,74,111,231,98,93,97,119,114,72,213,38,17,91,15,181,118,3,146,207,62,225,203,145,4,242,50,98,184,3,58,139,27,4,239,238,9,6,225,2,201,241,224,42,22,153,50,150,87,104,230,185,144,101,120,17,25,45,91,196,235,255,35,89,142,240,164,116,49,247,112,113,56,167,134,243,66,43,86,6,123,239,43,233,95,65,156,179,228,36,225,136,120,139,102,228,117,80,146,106,197,36,100,210,59,165,166,228,85,81,188,106,204,232,156,4,90,51,121,148,139,136,102,252,119,88,7,253,124,9,250,76,199,167,254,78,169,129,84,219,125,133,202,107,238,59,159,227,94,75,239,105,19,195,113,146,4,253,11,151,96,160,140,62,46,104,18,184,140,59,198,149,175,219,41,231,104,54,117,189,87,110,117,189,94,66,208,208,176,127,63,48,224,111,181,221,146,193,138,230,5,191,104,199,196,181,241,178,141,212,177,213,170,210,42,242,222,90,239,137,60,225,186,162,140,211,20,37,225,41,4,158,210,91,4,189,45,24,182,140,118,225,100,130,186,132,105,64,54,100,139,193,207,128,32,161,43,249,200,15,24,210,69,154,150,8,121,111,75,108,131,254,77,150,210,236,179,3,101,205,112,243,222,179,218,152,221,41,243,32,226,113,148,64,183,80,75,208,38,245,245,155,10,116,179,13,168,149,102,237,56,157,178,223,92,81,220,74,1,252,217,148,9,213,21,174,53,197,31,5,176,117,163,124,186,20,103,81,134,21,148,185,233,111,12,70,137,18,16,12,42,189,172,149,177,77,133,218,212,83,243,136,166,24,48,168,132,100,60,96,128,199,178,94,186,165,226,201,41,155,122,17,91,201,101,196,40,215,129,21,78,158,17,148,129,98,189,42,21,9,47,93,249,161,46,237,45,208,56,10,107,225,92,121,178,69,59,67,169,1,168,6,13,2,166,147,54,218,99,157,175,147,212,65,52,146,102,121,158,18,202,15,103,101,158,76,94,98,88,154,6,109,30,165,28,60,66,59,184,116,80,25,23,131,125,123,6,156,163,123,136,206,22,71,18,47,98,108,114,184,207,45,93,146,168,128,74,78,112,76,225,246,60,165,92,12,101,109,25,5,214,78,204,134,34,179,165,237,203,19,77,129,212,222,145,17,249,80,230,135,6,67,163,36,11,122,73,122,68,25,23,250,124,55,89,34,216,186,204,42,77,31,234,24,183,113,211,235,185,42,42,71,25,186,203,134,103,75,150,202,92,153,145,54,33,73,28,137,248,137,4,109,232,87,185,221,233,29,71,84,111,134,241,250,185,46,183,225,44,87,104,155,39,223,148,120,146,173,176,47,73,90,212,129,151,74,120,139,251,225,37,52,15,27,229,191,151,60,231,244,208,109,136,60,65,116,179,97,130,202,158,169,165,99,140,139,108,151,227,135,161,235,114,67,113,210,138,96,11,174,37,125,135,27,219,253,107,184,38,109,166,251,75,110,175,99,142,74,57,141,99,170,175,128,9,57,34,83,217,75,130,54,63,112,177,240,218,245,45,10,252,152,175,179,248,191,238,27,255,65,13,169,226,214,78,5,5,99,152,149,114,100,147,85,23,73,234,103,200,65,69,161,10,179,207,110,59,113,41,27,203,123,62,15,156,193,103,242,130,46,198,206,125,199,97,148,81,246,41,207,212,64,132,76,83,111,174,104,155,182,6,213,38,166,74,156,116,247,199,100,89,30,63,122,74,115,142,163,86,39,56,232,91,116,77,51,140,149,49,43,22,51,96,42,150,175,84,48,96,3,181,71,212,133,139,119,215,21,78,215,24,205,66,168,57,8,55,85,194,235,231,8,206,132,135,48,143,16,157,243,166,88,236,64,54,94,76,24,165,156,154,43,123,158,22,139,194,83,200,30,197,19,25,238,181,106,255,211,79,228,135,10,34,191,181,117,155,75,167,99,146,14,91,52,125,106,170,67,139,183,171,250,223,194,22,234,31,45,232,84,106,149,125,24,1,60,241,74,69,198,203,101,121,205,133,131,225,34,95,201,201,58,216,20,118,99,206,97,49,75,215,127,96,158,210,57,133,68,119,22,54,254,74,69,61,209,215,140,62,98,163,132,178,135,45,66,71,129,229,30,52,82,229,54,103,159,213,165,168,238,96,140,240,90,138,181,90,170,75,211,198,226,222,218,8,108,85,241,197,19,203,191,124,252,215,149,126,139,10,107,40,47,252,169,176,178,247,206,31,252,238,223,171,34,239,238,238,146,33,47,22,50,27,70,118,65,7,61,39,17,99,209,154,228,115,91,133,49,207,101,190,144,149,158,146,231,44,95,144,185,233,38,75,97,187,117,105,67,101,5,201,208,146,189,126,85,53,250,35,217,197,18,174,199,105,249,54,28,238,42,210,118,206,185,233,137,101,245,224,253,81,105,97,98,85,48,85,168,41,69,27,207,71,195,93,251,171,243,44,194,19,71,150,190,102,117,56,66,91,77,227,28,116,29,63,102,221,83,20,131,144,148,145,99,21,221,243,124,117,8,220,247,214,112,195,5,244,97,36,34,117,141,26,197,194,118,242,163,192,223,178,58,46,56,164,85,144,110,43,117,170,152,212,88,100,3,187,154,55,204,137,213,176,253,168,52,205,24,105,214,49,119,237,93,149,211,0,186,209,91,77,102,90,219,112,191,160,105,50,225,207,29,227,68,99,168,50,42,213,230,162,186,27,37,85,240,238,179,141,73,189,178,217,215,216,5,47,100,111,68,94,164,28,57,185,37,78,32,153,198,100,20,52,76,216,217,9,175,243,177,204,184,238,59,105,85,133,106,35,245,22,31,25,20,221,157,121,176,126,150,37,228,110,204,151,231,32,212,160,41,232,76,114,173,175,224,185,160,12,22,104,19,15,220,7,25,42,8,208,27,44,146,42,52,11,201,142,220,228,205,207,26,228,23,178,31,113,40,149,149,95,55,222,188,43,184,43,235,161,107,80,239,238,22,102,56,65,228,159,33,208,108,242,43,199,229,197,244,26,251,132,27,70,175,97,177,76,229,101,248,158,236,41,156,182,19,95,239,231,201,122,42,214,169,124,137,82,76,97,46,87,195,91,22,45,209,153,58,176,165,133,192,133,238,190,60,6,189,164,190,86,13,176,146,242,101,158,113,216,76,167,96,178,56,189,247,173,71,97,209,182,13,216,81,36,191,192,168,41,86,186,68,63,174,101,176,14,55,124,128,25,5,126,200,151,98,67,95,211,55,122,69,47,180,223,217,135,106,116,248,127,59,242,223,76,55,102,221,235,211,229,184,82,114,152,202,171,143,1,226,223,30,254,23,145,32,101,198,229,102,254,237,123,109,254,178,44,170,247,174,12,168,95,113,150,210,36,152,238,193,56,236,22,61,10,26,93,97,117,17,237,67,82,223,174,237,234,127,207,137,236,183,91,1,119,8,242,246,106,187,93,238,72,25,29,19,223,52,99,189,91,254,84,159,189,236,41,117,16,169,182,244,127,84,16,55,76,245,221,234,55,155,52,247,3,30,166,158,110,101,185,247,37,169,250,186,179,87,251,20,219,118,31,44,195,227,68,125,121,143,97,127,173,250,11,127,55,47,77,212,110,167,241,95,91,167,202,28,51,52,146,51,77,197,79,104,86,215,219,124,110,177,210,189,185,84,47,59,3,41,134,16,78,218,213,229,160,77,186,146,91,222,52,234,199,1,49,8,238,48,175,167,114,239,185,143,48,151,12,222,251,235,203,72,60,149,59,182,4,127,181,203,134,239,183,122,213,95,84,107,238,223,223,125,244,80,162,65,35,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMultiDeleteJobNamePatternLocalizableString());
			LocalizableStrings.Add(CreateMultiDeleteJobGroupNamePatternLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMultiDeleteJobNamePatternLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b7874ffc-d9da-4d23-869e-d27017c68308"),
				Name = "MultiDeleteJobNamePattern",
				CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed"),
				CreatedInSchemaUId = new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f"),
				ModifiedInSchemaUId = new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateMultiDeleteJobGroupNamePatternLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("bec1fb00-e907-42da-9b6b-6f74f3e97dcc"),
				Name = "MultiDeleteJobGroupNamePattern",
				CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed"),
				CreatedInSchemaUId = new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f"),
				ModifiedInSchemaUId = new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6934cff2-4b16-48f9-abe5-323bd5db3a8f"));
		}

		#endregion

	}

	#endregion

}

