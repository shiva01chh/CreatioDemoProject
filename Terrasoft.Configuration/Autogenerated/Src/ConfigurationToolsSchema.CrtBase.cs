﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConfigurationToolsSchema

	/// <exclude/>
	public class ConfigurationToolsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConfigurationToolsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConfigurationToolsSchema(ConfigurationToolsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9fe36f04-c24b-4f75-aa9d-6a42504bab4c");
			Name = "ConfigurationTools";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,91,111,219,54,20,126,86,128,252,7,214,123,168,140,10,236,251,140,1,203,181,112,47,73,214,184,203,67,22,12,180,76,39,106,101,74,37,169,180,198,144,255,190,195,59,37,75,182,187,182,111,51,16,199,60,151,239,59,60,60,60,164,212,136,130,221,163,25,229,156,136,106,41,241,73,197,41,190,226,85,78,133,128,1,91,22,247,13,39,178,168,216,228,240,160,233,49,246,226,235,181,144,116,133,103,244,171,236,200,6,60,241,25,147,133,44,168,232,213,175,86,21,195,175,69,196,123,65,191,200,138,105,245,54,57,126,91,176,207,160,60,60,168,155,121,89,228,40,47,137,16,168,53,151,89,85,149,226,240,224,159,195,131,164,230,197,35,145,20,113,74,22,21,43,215,232,131,160,28,140,25,205,149,37,250,187,105,141,39,202,197,224,118,12,59,67,133,157,220,83,105,126,36,156,202,134,247,162,37,79,240,165,254,146,0,189,25,108,218,129,111,227,140,13,75,7,29,253,134,54,233,20,83,32,18,146,171,20,190,162,242,250,161,250,114,67,56,131,225,59,88,123,114,79,175,115,94,212,50,181,38,43,35,84,203,107,217,30,9,71,98,14,36,140,126,65,215,218,234,184,41,202,5,229,233,120,226,12,62,55,84,232,73,16,241,201,154,254,97,69,106,70,74,220,153,90,240,205,73,109,167,17,163,96,27,229,137,209,106,107,49,199,71,117,77,217,2,214,158,166,163,179,175,18,219,73,28,87,95,177,13,61,29,141,251,140,159,143,208,11,79,245,2,141,158,103,91,236,162,44,224,247,180,46,73,174,53,25,250,125,244,215,243,209,120,155,127,39,168,203,55,251,217,221,28,189,191,152,94,188,26,48,94,54,76,39,45,157,75,85,4,147,39,21,228,104,192,88,62,20,162,95,51,158,88,185,45,83,80,207,42,179,164,102,45,219,85,243,88,21,11,116,94,148,37,108,211,121,5,81,30,175,255,36,101,67,223,22,66,94,231,15,116,69,210,176,149,63,76,241,13,157,195,250,74,14,117,140,163,31,198,247,108,81,72,148,71,131,12,117,192,188,214,12,109,249,45,161,133,144,252,1,165,186,84,90,22,83,104,58,168,96,29,41,86,98,97,189,147,216,75,177,106,31,83,160,187,99,87,177,41,135,84,67,37,155,236,216,86,103,214,19,25,160,46,162,244,154,196,39,113,44,38,82,124,180,88,164,221,16,199,173,150,17,150,164,154,127,132,237,163,54,178,79,222,25,107,86,122,112,188,14,228,192,157,118,211,251,216,30,103,232,85,3,235,219,145,90,231,12,205,214,53,69,20,176,213,143,168,21,244,216,67,62,59,82,59,51,8,243,120,173,66,233,39,9,45,160,71,175,163,223,68,214,153,213,58,237,108,243,193,169,104,74,9,214,42,25,248,138,112,65,83,23,123,54,136,190,177,58,197,18,165,207,52,196,84,156,210,37,236,153,69,4,99,72,198,227,118,171,103,77,89,78,116,83,55,221,221,138,141,241,230,158,210,57,135,188,168,26,35,185,60,202,243,170,97,82,229,72,107,114,35,86,201,9,41,39,222,8,102,168,204,240,217,170,150,235,208,64,141,211,70,89,183,142,23,108,25,135,219,176,209,235,211,218,86,18,32,182,173,113,172,125,71,24,52,47,174,86,121,202,132,36,44,135,18,188,32,43,104,52,150,107,180,21,253,138,23,43,194,215,39,85,217,172,152,242,3,186,30,51,133,191,97,154,238,143,60,128,106,148,182,70,53,228,62,33,198,180,218,127,86,157,83,9,237,201,228,62,246,53,78,183,119,182,92,246,139,97,100,11,98,52,214,5,229,171,210,122,99,77,118,206,171,213,233,241,206,120,179,168,154,178,78,188,190,138,91,181,229,88,108,16,211,197,164,91,214,193,124,224,184,80,165,221,112,78,193,198,84,142,174,114,182,128,99,160,38,76,79,82,164,85,35,221,149,196,82,42,121,134,90,114,111,15,161,154,253,21,201,66,176,118,100,220,162,141,241,99,55,135,157,247,14,20,155,183,13,20,117,120,252,191,205,190,105,155,133,132,217,212,255,144,132,249,221,213,93,216,93,9,235,49,219,149,176,93,200,3,168,155,9,219,39,196,113,171,230,25,72,78,126,78,127,82,223,113,115,114,116,54,179,63,149,53,251,206,70,170,203,120,163,57,153,214,215,169,167,168,135,185,222,96,187,225,119,116,227,62,234,108,56,123,190,71,183,59,157,35,87,195,73,184,227,198,224,186,77,110,107,233,122,22,182,174,90,179,216,85,107,89,63,81,214,83,114,62,252,78,223,118,180,33,254,167,254,187,174,61,9,206,43,190,130,43,50,92,168,132,189,173,249,35,2,96,248,58,115,134,156,222,235,171,184,83,195,12,252,128,24,0,8,9,189,124,137,102,151,167,151,191,162,95,212,199,124,247,253,64,65,20,201,162,207,222,15,199,15,68,216,9,128,225,51,123,82,77,197,5,220,28,47,185,62,177,82,23,95,236,115,2,19,24,116,80,179,107,89,191,215,179,31,180,55,201,105,227,155,252,13,83,24,125,116,4,0,231,121,193,133,58,6,37,183,55,112,165,48,224,189,42,11,210,209,185,141,20,50,227,138,197,63,177,182,83,146,196,220,109,186,14,195,146,148,130,134,123,139,101,81,185,116,20,250,150,239,241,124,149,6,102,120,206,183,39,132,193,136,84,33,237,201,127,136,194,172,81,43,142,8,229,219,34,137,23,52,217,47,7,118,61,91,105,136,28,191,49,19,113,117,60,249,67,47,222,168,234,90,214,125,195,224,47,146,177,225,36,217,242,198,234,164,17,18,122,19,145,91,222,54,92,233,247,88,170,91,185,238,10,98,84,131,52,180,131,178,128,182,53,61,13,2,143,251,134,186,164,248,78,98,31,39,245,195,157,159,155,168,21,15,136,21,48,62,178,67,34,134,223,36,40,3,237,255,250,210,60,168,194,163,103,173,40,99,108,75,234,84,16,13,104,71,110,56,242,167,142,229,199,33,33,230,104,42,152,0,159,52,242,247,173,55,162,219,244,190,141,60,238,212,52,108,144,225,132,240,238,207,76,184,190,66,220,133,16,38,57,11,20,206,252,214,229,250,206,64,249,51,51,54,15,144,238,118,108,113,229,226,147,123,246,239,248,220,182,150,204,129,155,72,157,83,55,82,131,249,209,33,166,125,111,145,241,107,173,30,59,16,7,156,248,58,48,254,184,251,214,192,25,154,189,97,255,249,211,108,232,85,0,124,195,231,95,118,3,243,39,146,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9fe36f04-c24b-4f75-aa9d-6a42504bab4c"));
		}

		#endregion

	}

	#endregion

}
