﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProjectDataProviderSchema

	/// <exclude/>
	public class ProjectDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProjectDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProjectDataProviderSchema(ProjectDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2e9b2b9-482d-4da6-8f00-ce08f69a1dc8");
			Name = "ProjectDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,83,193,110,219,48,12,61,167,64,255,129,240,118,72,209,33,186,183,169,47,45,54,244,48,32,104,210,243,160,218,116,162,213,150,60,74,78,151,5,249,247,209,146,226,218,89,16,100,192,230,147,45,145,239,61,190,71,107,89,161,173,101,134,176,64,34,105,77,225,38,247,70,23,106,217,144,116,202,232,201,130,100,246,170,244,242,242,98,123,121,49,106,44,191,194,124,99,29,86,183,221,119,191,151,144,207,249,230,3,225,146,251,225,190,148,214,222,112,137,150,218,61,72,39,103,100,214,42,71,242,85,66,8,152,218,166,170,36,109,210,248,29,11,64,233,194,80,229,85,64,65,166,130,154,204,119,204,28,88,164,181,202,112,178,239,23,61,128,186,121,41,85,6,89,203,218,34,181,13,125,86,216,75,153,7,144,161,162,209,214,171,234,196,127,86,88,230,172,126,70,106,45,29,134,203,58,124,0,161,204,141,46,55,96,29,181,46,124,139,250,102,210,173,230,77,81,168,159,112,7,137,144,181,18,81,72,114,27,225,81,231,129,97,72,199,206,51,86,147,57,67,45,169,31,37,84,28,250,228,15,122,229,96,10,144,97,234,73,87,47,14,27,166,181,36,89,129,230,208,239,146,134,109,100,4,205,186,152,59,73,31,25,76,106,222,4,134,122,30,220,77,166,194,55,122,156,104,240,17,107,199,195,46,24,18,92,181,205,163,209,13,188,72,139,227,131,59,216,194,238,180,53,95,209,173,76,126,150,43,156,139,67,219,109,203,155,114,171,56,57,97,17,135,143,151,143,121,34,210,115,13,123,239,73,227,244,192,99,107,167,10,133,52,240,200,183,18,186,134,180,77,159,248,7,227,160,48,236,176,91,97,183,191,83,177,175,233,25,219,119,180,107,13,51,69,214,241,151,70,229,208,169,97,243,188,181,107,73,188,146,63,26,180,238,153,74,94,189,176,231,237,251,245,177,221,188,230,221,204,60,110,187,150,12,16,196,192,156,19,88,152,87,212,234,23,230,51,99,221,83,0,157,30,83,150,142,223,41,63,129,198,55,78,114,182,87,198,26,58,149,176,187,242,44,187,19,201,61,96,137,189,228,254,115,46,115,39,93,99,33,51,121,140,166,141,5,59,15,255,34,157,160,251,159,197,242,49,17,185,71,20,219,14,109,119,34,163,64,127,110,74,93,12,127,252,107,33,154,225,161,63,227,231,55,106,219,194,45,40,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2e9b2b9-482d-4da6-8f00-ce08f69a1dc8"));
		}

		#endregion

	}

	#endregion

}

