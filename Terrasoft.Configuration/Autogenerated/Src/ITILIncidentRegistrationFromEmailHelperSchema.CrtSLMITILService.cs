﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITILIncidentRegistrationFromEmailHelperSchema

	/// <exclude/>
	public class ITILIncidentRegistrationFromEmailHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITILIncidentRegistrationFromEmailHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITILIncidentRegistrationFromEmailHelperSchema(ITILIncidentRegistrationFromEmailHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5e5743f-4160-4ea2-ae07-18b17d70fcc4");
			Name = "ITILIncidentRegistrationFromEmailHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("828aae12-9105-4428-91be-95ccb167b0a7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,91,107,226,64,20,126,78,161,255,225,212,133,18,65,226,123,171,46,226,218,174,80,216,82,219,237,195,178,15,99,60,218,129,100,98,231,210,42,91,255,251,158,201,76,98,140,201,82,86,84,50,231,242,157,239,220,38,130,165,168,54,44,70,120,68,41,153,202,86,58,154,100,98,197,215,70,50,205,51,113,126,246,231,252,44,48,138,139,53,204,119,74,99,122,93,59,147,125,146,96,108,141,85,116,139,2,37,143,79,108,238,184,120,61,17,62,226,86,71,15,184,54,9,147,211,237,70,162,82,22,228,96,87,229,148,166,153,104,214,72,108,147,71,83,161,185,230,168,78,66,63,227,162,217,169,146,122,52,71,249,198,99,188,103,177,246,143,173,129,110,200,38,147,71,145,106,22,247,50,139,41,65,171,167,239,23,137,107,10,1,147,132,41,117,5,179,199,217,221,76,196,124,137,66,83,65,184,210,142,194,141,204,210,105,202,120,242,29,147,13,74,114,236,247,251,48,80,38,77,153,220,141,252,121,12,177,133,1,253,194,52,176,36,201,222,21,112,143,6,178,2,7,43,194,3,180,128,81,129,213,175,128,253,250,241,70,164,201,239,55,29,54,102,145,240,216,67,127,146,32,80,42,159,74,195,14,213,161,8,212,116,45,141,173,32,213,226,62,143,107,245,246,231,89,124,50,126,216,133,28,121,255,159,238,79,10,37,177,17,110,156,193,28,29,187,22,48,184,90,48,133,97,77,83,139,250,5,197,210,229,118,126,102,207,245,166,229,130,7,212,70,10,5,12,98,66,132,119,174,95,128,197,113,102,168,105,76,44,33,206,132,166,169,130,197,14,148,155,62,160,69,213,81,9,216,175,35,14,54,76,178,20,4,237,244,176,99,65,243,241,223,117,70,19,27,0,243,67,52,232,231,86,45,78,46,230,108,73,62,62,60,95,254,219,197,83,182,46,99,207,190,201,69,186,108,107,84,10,105,222,42,153,105,42,39,46,33,243,83,8,142,63,220,162,182,110,207,84,161,202,74,134,94,123,72,180,7,183,134,151,133,155,45,253,185,100,232,219,20,240,85,88,218,192,197,48,183,138,166,233,134,192,46,47,15,230,199,170,194,57,120,99,178,104,136,165,241,13,53,202,148,11,124,210,60,81,48,116,43,237,238,131,29,221,135,122,48,111,51,30,133,14,49,16,248,94,93,130,177,92,155,148,106,20,118,142,199,172,211,131,227,1,237,118,175,29,194,108,42,200,67,178,69,130,131,185,225,218,62,84,194,142,64,157,10,45,215,214,60,44,241,6,32,85,101,220,164,127,192,87,131,74,23,181,10,130,73,89,232,97,165,49,133,118,92,214,122,120,168,187,87,238,139,228,26,226,64,154,169,146,95,37,9,130,17,38,73,188,35,95,65,216,148,120,52,22,187,176,91,54,52,104,7,107,246,94,175,105,185,153,198,48,140,141,45,89,15,182,93,24,142,160,200,202,139,97,232,216,192,199,7,108,163,34,192,29,190,97,2,3,112,54,53,241,87,216,210,21,234,84,101,115,247,135,108,218,152,94,184,72,135,148,14,75,65,111,49,77,111,104,147,138,159,44,49,24,118,42,185,208,210,246,218,74,25,209,190,28,17,112,255,110,99,43,75,119,93,220,124,123,255,102,171,220,125,36,162,207,95,31,191,56,123,100,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5e5743f-4160-4ea2-ae07-18b17d70fcc4"));
		}

		#endregion

	}

	#endregion

}
