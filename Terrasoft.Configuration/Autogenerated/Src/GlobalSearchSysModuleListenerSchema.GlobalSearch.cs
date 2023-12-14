﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchSysModuleListenerSchema

	/// <exclude/>
	public class GlobalSearchSysModuleListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchSysModuleListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchSysModuleListenerSchema(GlobalSearchSysModuleListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf0d6e76-8f98-46a6-b3c4-3ce12f68d464");
			Name = "GlobalSearchSysModuleListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30c103fe-34c6-441e-895c-acadc354f737");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,81,111,211,48,16,126,206,164,253,135,83,121,73,36,228,190,183,107,167,18,198,52,105,3,68,25,47,8,33,55,185,180,70,142,29,108,39,34,170,246,223,113,236,36,13,83,179,77,133,7,250,80,197,190,251,238,187,251,238,206,32,104,142,186,160,9,194,103,84,138,106,153,25,18,75,145,177,109,169,168,97,82,144,107,46,55,148,175,145,170,100,119,126,182,63,63,11,74,205,196,22,214,181,54,152,147,91,38,126,206,251,203,97,16,133,228,74,24,102,24,234,103,29,200,85,133,194,140,251,189,163,137,145,106,36,210,48,67,114,35,82,252,101,237,214,209,186,190,82,184,181,69,64,204,169,214,51,24,122,218,252,239,100,90,114,188,101,182,16,129,202,1,166,211,41,92,232,50,207,169,170,151,237,217,129,161,80,178,98,41,106,232,129,128,77,246,53,160,203,29,118,84,164,220,50,147,46,204,116,16,231,171,171,180,118,101,118,132,225,58,217,97,78,223,219,22,192,2,38,125,220,73,244,205,34,138,114,195,89,2,137,35,127,50,113,152,193,27,170,241,8,131,13,179,119,101,245,66,124,84,178,64,213,72,62,179,223,172,162,6,189,67,225,15,176,170,40,227,116,195,177,19,178,107,17,124,167,99,166,249,203,2,140,91,22,141,68,65,48,206,0,151,151,206,35,124,194,101,225,27,229,71,165,38,215,104,46,70,25,151,97,20,205,91,101,80,164,94,156,230,52,212,234,14,205,78,166,99,66,85,146,165,240,9,185,164,233,40,77,248,120,86,34,216,187,58,42,170,128,233,216,142,204,22,211,97,115,251,80,95,40,47,155,177,240,184,166,154,214,59,150,188,204,133,51,235,48,114,209,2,178,18,117,88,121,196,18,220,7,241,126,196,79,215,2,154,69,151,89,216,133,59,70,233,36,177,209,88,6,225,11,146,235,106,9,70,203,39,49,183,184,152,218,49,239,136,239,53,42,251,190,8,76,154,199,37,154,59,193,131,135,230,255,161,215,127,208,145,227,253,112,171,225,141,143,23,182,189,64,132,68,97,182,152,140,108,6,249,32,110,132,205,197,96,58,153,30,112,195,149,237,54,80,86,246,165,177,155,239,59,126,192,133,114,243,195,150,1,218,166,139,234,53,120,150,85,102,80,57,170,149,218,106,232,85,218,216,60,6,164,97,135,194,86,244,231,38,233,48,74,145,135,122,220,195,223,170,112,95,164,244,4,17,90,216,73,26,116,216,255,69,130,183,200,241,4,9,90,216,73,18,116,216,127,39,193,209,213,241,210,252,121,233,238,154,223,111,201,229,70,136,252,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf0d6e76-8f98-46a6-b3c4-3ce12f68d464"));
		}

		#endregion

	}

	#endregion

}

