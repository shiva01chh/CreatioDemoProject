﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileListAppTemplateMacrosProviderSchema

	/// <exclude/>
	public class FileListAppTemplateMacrosProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileListAppTemplateMacrosProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileListAppTemplateMacrosProviderSchema(FileListAppTemplateMacrosProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c766e73-342a-4424-a677-e0afb0c20d36");
			Name = "FileListAppTemplateMacrosProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("13b9c287-707b-4588-95dc-f40709dfb679");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,77,111,219,48,12,61,167,64,255,3,215,93,28,32,112,238,105,147,162,107,146,34,64,219,13,107,119,26,134,65,177,233,70,128,45,121,146,220,45,40,242,223,71,73,246,18,127,37,107,15,65,77,241,227,241,241,81,18,44,67,157,179,8,225,25,149,98,90,38,38,188,149,34,225,47,133,98,134,75,113,126,246,118,126,54,40,52,23,47,240,180,213,6,51,58,79,83,140,236,161,14,239,80,160,226,209,101,211,231,158,139,95,123,227,97,238,44,147,162,251,68,97,159,61,188,201,243,148,71,204,215,188,89,107,163,88,9,224,86,161,51,247,134,46,201,83,42,142,154,60,200,231,163,194,23,114,135,219,148,105,61,129,27,99,88,180,201,80,24,77,53,158,49,203,83,102,240,129,69,74,234,47,74,190,242,24,149,139,27,143,199,112,165,139,44,99,106,59,43,191,75,7,13,44,142,185,5,193,82,200,92,40,36,82,65,194,83,132,148,107,3,145,20,70,201,20,184,0,182,239,4,214,104,241,70,182,3,140,33,81,50,3,83,34,8,171,146,227,131,154,223,231,152,176,34,53,159,184,136,41,50,48,219,28,101,18,172,122,145,15,135,63,40,44,47,214,84,18,34,219,49,44,9,212,61,97,234,141,129,9,244,39,164,108,111,142,142,61,143,52,4,195,136,190,9,209,193,95,41,194,159,231,254,195,182,78,4,208,192,108,171,182,248,66,24,110,182,143,164,59,151,26,166,112,81,55,95,92,254,71,252,87,140,164,138,73,137,69,38,122,114,53,93,142,228,45,121,173,227,176,217,72,205,214,248,158,208,102,89,155,198,219,86,241,197,101,73,30,138,216,243,87,39,115,201,49,141,251,152,36,153,196,82,164,91,88,217,98,79,209,6,51,246,111,104,63,147,150,237,68,45,55,56,85,216,229,176,21,157,70,202,130,94,47,39,149,18,116,1,105,227,24,130,189,65,6,131,14,136,196,77,219,24,46,132,46,20,206,49,39,228,40,162,237,163,52,143,69,154,6,130,216,36,185,119,84,24,186,249,236,142,55,252,128,102,35,123,217,37,17,27,106,122,206,221,189,66,11,119,229,7,60,42,7,61,131,59,60,152,178,103,34,40,69,144,212,132,51,114,237,14,90,103,77,101,84,196,40,52,133,18,32,240,247,177,242,222,119,240,214,181,68,163,6,2,216,141,218,222,157,43,51,58,130,175,202,178,59,100,247,93,124,181,150,163,164,109,8,211,153,75,221,197,105,231,50,142,78,47,218,240,132,224,247,243,63,208,186,187,99,185,216,208,35,102,98,25,193,120,118,176,1,199,155,107,237,69,237,34,94,137,68,218,145,146,201,254,91,205,122,45,233,25,40,52,46,254,208,102,81,38,223,138,151,51,109,195,62,32,252,156,251,23,165,74,56,103,134,93,135,223,250,66,167,64,203,236,30,208,193,128,39,16,124,232,41,82,1,169,84,119,108,74,62,219,206,253,150,106,198,131,84,229,237,118,2,115,184,104,132,248,172,251,171,195,49,149,212,63,167,93,23,90,184,164,119,207,155,130,38,142,18,107,217,84,35,27,215,32,232,2,241,125,95,31,109,217,251,76,58,151,189,158,53,244,178,108,24,187,68,217,119,51,121,107,221,232,108,244,247,23,40,169,80,115,152,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c766e73-342a-4424-a677-e0afb0c20d36"));
		}

		#endregion

	}

	#endregion

}

