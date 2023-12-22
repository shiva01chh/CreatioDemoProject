﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseSysSettingsEventListenerSchema

	/// <exclude/>
	public class BaseSysSettingsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseSysSettingsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseSysSettingsEventListenerSchema(BaseSysSettingsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4d60ddd2-9b0e-424d-b70f-0c08ecaab2fc");
			Name = "BaseSysSettingsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,219,110,219,48,12,125,118,129,254,3,209,189,56,128,225,188,47,77,129,44,107,139,14,221,5,104,218,61,43,54,237,104,176,37,79,146,179,102,69,254,125,146,37,95,148,75,87,100,235,67,42,145,60,135,60,52,69,70,74,148,21,73,16,22,40,4,145,60,83,241,156,179,140,230,181,32,138,114,118,126,246,114,126,22,212,146,178,28,30,54,82,97,57,217,185,199,247,148,253,236,141,67,158,178,228,236,176,71,224,49,123,124,205,20,85,20,229,95,3,226,235,53,50,101,226,116,228,59,129,185,46,23,230,5,145,242,61,124,32,18,117,121,15,168,148,102,144,77,228,61,213,229,50,20,77,252,120,60,134,75,89,151,37,17,155,43,119,111,176,80,9,190,166,41,74,88,106,14,40,120,78,19,224,25,160,161,128,21,97,105,97,106,202,184,0,217,232,7,233,146,196,45,237,120,192,91,213,203,66,19,144,165,84,130,36,10,146,38,199,107,229,93,46,140,202,70,228,230,10,172,20,123,219,81,17,4,191,86,40,244,151,235,227,117,184,61,104,239,75,163,179,107,204,103,84,43,158,234,214,124,19,116,77,20,90,111,101,47,176,230,52,133,89,162,106,82,208,223,24,242,229,15,212,197,74,94,139,4,35,199,57,215,226,115,92,108,42,4,220,49,140,192,76,73,16,208,12,194,219,130,47,73,49,171,170,86,93,124,131,68,213,2,31,125,205,44,167,172,3,6,107,34,92,58,167,100,10,161,61,141,172,121,210,199,213,18,133,30,82,166,75,52,202,166,30,48,126,244,188,14,54,236,81,210,31,167,48,23,186,56,236,189,161,79,62,114,120,47,195,45,170,57,47,234,146,61,145,162,198,47,230,9,133,35,27,23,196,223,205,55,9,147,198,111,92,48,189,242,235,187,147,3,240,61,39,41,166,131,240,81,71,244,137,83,22,246,181,30,206,26,193,179,73,240,28,193,198,252,223,68,16,154,243,168,49,118,84,55,92,92,147,100,181,83,213,128,251,193,227,30,196,69,240,138,114,175,236,182,83,221,16,29,237,105,52,200,28,237,143,146,229,217,154,223,173,27,97,100,169,157,98,115,59,50,212,92,105,118,76,219,177,118,215,254,225,13,39,96,239,163,251,51,3,251,51,112,132,212,127,54,111,37,140,160,145,120,120,38,223,242,218,38,251,125,57,220,149,102,249,88,231,238,194,115,6,68,72,4,102,211,139,35,107,38,254,202,238,152,174,94,203,190,24,247,184,225,138,107,119,28,95,235,61,173,55,167,237,74,143,235,182,137,46,23,69,171,111,150,41,20,77,170,153,200,37,116,155,192,108,221,65,210,176,69,181,131,209,47,41,159,175,111,79,220,98,45,98,251,175,250,31,171,148,156,32,223,193,78,82,223,98,79,16,239,160,255,73,251,71,44,240,4,237,14,118,146,246,22,123,130,118,7,245,180,239,60,18,107,245,141,218,166,95,228,240,239,15,158,212,66,125,23,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4d60ddd2-9b0e-424d-b70f-0c08ecaab2fc"));
		}

		#endregion

	}

	#endregion

}

