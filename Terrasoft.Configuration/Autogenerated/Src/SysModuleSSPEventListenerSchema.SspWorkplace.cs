﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleSSPEventListenerSchema

	/// <exclude/>
	public class SysModuleSSPEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleSSPEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleSSPEventListenerSchema(SysModuleSSPEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8");
			Name = "SysModuleSSPEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,193,110,219,48,12,61,167,64,255,129,245,46,54,208,217,247,54,9,144,21,217,16,160,93,139,165,221,101,216,65,181,233,68,131,45,121,146,156,205,104,251,239,163,37,219,177,211,164,93,177,229,146,68,226,123,36,31,249,36,88,142,186,96,49,194,45,42,197,180,76,77,120,33,69,202,87,165,98,134,75,17,46,49,174,191,143,143,30,142,143,70,165,230,98,53,8,85,24,206,133,225,134,163,62,127,45,32,156,233,74,196,215,5,58,234,183,3,194,133,48,168,82,42,247,47,176,243,13,10,115,56,238,35,139,141,84,174,108,138,121,167,112,69,41,224,34,99,90,159,193,178,210,87,50,41,51,92,46,111,44,209,37,215,6,5,42,27,28,69,17,140,117,153,231,76,85,211,230,191,5,66,161,228,134,39,168,183,4,128,117,65,21,160,45,7,214,76,36,25,149,19,182,52,81,143,231,155,45,190,26,36,244,151,241,26,115,246,153,6,5,19,240,58,94,47,248,78,136,162,188,207,120,12,177,77,126,176,104,56,131,15,76,227,30,118,162,120,176,45,117,2,92,161,89,203,132,36,184,81,210,208,236,49,113,247,187,61,219,131,47,132,33,34,165,65,187,53,1,86,255,204,210,247,26,213,134,211,90,21,82,25,150,1,79,97,92,48,197,114,133,41,8,234,101,226,233,174,147,104,10,166,42,72,169,159,37,203,52,101,65,132,152,2,39,94,179,124,183,116,91,71,81,95,97,87,75,180,91,140,75,240,140,125,218,227,115,10,212,84,92,104,195,68,140,225,56,178,176,253,44,53,250,165,178,237,80,129,169,85,153,219,233,238,101,45,90,33,97,35,121,210,105,214,244,54,211,75,93,248,174,48,232,200,79,193,157,204,82,138,180,19,155,169,149,6,12,160,182,225,104,180,97,10,74,210,152,188,42,26,229,39,91,116,120,55,184,58,183,16,26,129,127,178,13,249,132,102,161,47,100,86,230,226,43,203,74,188,148,44,193,196,247,172,214,1,60,62,90,208,104,52,64,212,151,73,15,52,230,194,76,59,204,201,4,124,58,8,122,83,11,105,100,109,205,35,133,166,84,77,53,79,93,27,172,246,248,252,55,198,37,249,145,186,176,70,114,238,172,234,156,227,69,111,111,103,253,224,169,47,240,23,80,159,218,168,178,142,159,53,131,240,189,161,54,222,233,142,88,65,112,222,229,151,237,243,98,21,158,64,205,185,155,241,186,31,227,247,166,132,13,209,160,137,208,253,64,11,29,63,115,229,144,113,234,15,10,112,124,79,141,39,81,36,206,150,135,60,106,237,255,130,65,123,187,127,224,5,8,175,197,66,144,56,180,159,180,209,251,221,213,188,50,114,67,79,40,189,110,110,143,183,56,95,222,255,32,93,201,248,34,65,245,218,234,222,83,29,189,164,126,139,106,165,220,235,143,198,32,193,78,240,211,191,182,126,87,36,108,219,193,254,210,131,183,234,50,36,125,155,44,45,246,63,168,178,179,61,238,116,120,104,207,122,159,63,228,200,65,105,15,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8"));
		}

		#endregion

	}

	#endregion

}

