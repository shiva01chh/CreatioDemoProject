﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseManagementAppEventListenerSchema

	/// <exclude/>
	public class CaseManagementAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseManagementAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseManagementAppEventListenerSchema(CaseManagementAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81dc8eb1-4280-47b8-a6c1-1fb8e19b46a7");
			Name = "CaseManagementAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c518bb39-9bfc-496d-965e-2a76de806780");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,75,79,219,64,16,62,7,137,255,48,114,47,137,26,57,92,122,41,36,82,26,81,218,170,1,164,64,57,84,61,108,236,73,226,98,239,90,251,8,68,136,255,206,120,119,157,172,77,72,185,52,72,33,59,143,111,190,157,25,207,152,179,2,85,201,18,132,27,148,146,41,177,208,241,68,240,69,182,52,146,233,76,240,227,163,167,227,163,142,81,25,95,194,68,20,133,224,167,193,89,98,243,20,207,146,21,166,38,71,185,147,223,225,60,110,123,206,54,74,99,49,67,173,233,164,96,216,136,78,48,13,10,49,89,215,166,4,81,253,117,62,72,92,146,10,38,57,83,10,62,195,132,41,156,50,206,150,88,32,215,227,178,60,95,211,255,159,25,133,225,40,173,203,96,48,128,51,101,138,130,201,205,200,159,201,48,207,18,27,5,148,102,82,43,192,202,17,114,239,9,11,33,33,33,112,40,182,232,113,13,54,8,208,74,51,39,36,72,44,159,195,108,136,110,91,244,133,28,8,228,201,18,237,148,50,91,51,141,144,8,174,52,100,68,103,70,20,213,130,37,21,209,27,166,238,175,81,102,34,157,102,220,144,217,16,62,157,58,199,58,43,95,51,204,211,42,45,215,82,104,76,52,166,53,176,63,194,173,66,73,73,230,104,33,219,199,170,228,157,206,18,245,169,253,81,243,81,94,240,236,163,33,79,93,192,102,244,41,234,149,216,23,190,93,1,43,184,64,74,186,161,248,213,117,107,2,11,41,10,96,65,113,92,85,200,66,227,163,45,192,235,10,56,73,201,36,43,128,83,91,15,35,111,30,141,198,111,34,157,13,172,195,206,95,162,54,146,171,209,109,147,17,25,214,154,131,137,164,219,52,37,221,186,212,19,23,177,142,220,243,73,94,51,89,93,52,128,24,110,201,5,180,127,71,227,208,40,250,3,76,65,67,228,74,149,45,160,219,130,27,2,55,121,94,199,235,232,149,20,15,192,241,1,198,114,105,170,254,188,36,245,149,60,47,74,189,57,127,76,176,180,180,91,241,122,14,254,217,126,187,76,52,105,199,238,145,110,94,126,215,45,111,150,191,30,24,10,24,20,182,159,243,13,80,122,19,164,231,232,175,152,191,183,214,100,122,73,63,162,209,15,49,183,162,215,165,13,205,125,4,231,114,237,195,189,195,205,62,119,223,185,123,242,148,139,86,179,117,74,122,94,253,69,84,3,107,215,50,235,76,106,195,114,88,139,44,221,222,223,115,32,188,174,210,178,154,145,254,70,125,240,231,128,114,223,14,133,22,153,176,163,200,247,66,10,83,86,198,212,80,30,10,62,66,100,197,209,174,89,90,32,48,130,147,109,171,80,11,108,231,249,118,178,79,125,145,2,194,91,166,97,216,126,131,176,3,108,118,71,124,39,228,189,93,62,177,115,104,169,39,70,74,106,207,74,234,13,90,100,251,182,179,251,160,165,193,176,65,223,63,159,236,208,62,208,157,223,24,79,109,111,182,247,196,127,26,65,126,139,136,53,173,195,44,69,215,34,87,188,42,68,21,245,95,195,100,78,107,36,14,204,107,181,203,77,107,84,13,247,12,171,166,195,158,222,140,194,77,116,91,166,180,22,118,218,168,15,111,235,73,121,104,139,29,8,89,109,211,43,202,72,106,176,126,15,240,193,246,104,130,104,141,119,140,152,46,251,139,229,6,187,205,43,183,80,38,43,76,238,233,101,164,32,128,147,94,239,192,186,115,210,80,72,18,250,188,0,216,37,115,76,82,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81dc8eb1-4280-47b8-a6c1-1fb8e19b46a7"));
		}

		#endregion

	}

	#endregion

}

