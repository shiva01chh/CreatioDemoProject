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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,193,110,219,48,12,61,39,64,255,129,245,46,54,208,217,247,54,9,144,21,221,16,160,93,139,165,221,101,216,65,181,233,84,131,45,121,146,156,205,104,243,239,163,37,219,177,211,164,93,177,157,226,72,124,143,143,143,164,4,203,81,23,44,70,184,69,165,152,150,169,9,207,165,72,249,170,84,204,112,41,194,37,198,245,239,209,248,241,104,60,42,53,23,171,65,168,194,240,66,24,110,56,234,179,215,2,194,185,174,68,124,93,160,163,126,59,32,92,8,131,42,37,185,127,129,189,88,163,48,135,227,62,178,216,72,229,100,83,204,59,133,43,74,1,231,25,211,250,20,150,149,190,146,73,153,225,114,121,99,137,46,185,54,40,80,217,224,40,138,96,162,203,60,103,170,154,53,255,45,16,10,37,215,60,65,189,37,0,172,5,85,128,86,14,60,48,145,100,36,39,108,105,162,30,207,55,43,190,26,36,244,151,241,3,230,236,51,53,10,166,224,117,188,94,240,157,16,69,121,159,241,24,98,155,252,160,104,56,133,15,76,227,30,118,162,120,180,37,117,6,92,161,121,144,9,89,112,163,164,161,222,99,226,238,119,107,182,7,95,8,67,68,74,131,118,99,2,172,254,204,210,247,26,213,154,211,88,21,82,25,150,1,79,97,82,48,197,114,133,41,8,170,101,234,233,174,146,104,6,166,42,200,169,159,37,203,52,101,65,132,152,2,167,94,51,124,183,116,91,71,81,93,97,167,37,218,21,227,18,60,99,159,245,248,156,3,53,21,23,218,48,17,99,56,137,44,108,63,75,141,126,73,182,109,42,48,181,42,115,219,221,189,172,69,107,36,172,37,79,58,207,154,218,230,122,169,11,223,9,131,142,252,4,220,201,60,165,72,219,177,185,90,105,192,0,234,53,28,141,214,76,65,73,30,211,174,138,198,249,233,22,29,222,13,174,206,44,132,90,224,31,111,67,62,161,89,232,115,153,149,185,248,202,178,18,47,37,75,48,241,61,235,117,0,79,79,22,52,26,13,16,245,101,210,3,77,184,48,179,14,115,60,5,159,14,130,94,215,66,106,89,171,121,164,208,148,170,81,179,233,202,96,245,142,95,252,198,184,164,125,164,42,236,34,185,237,172,234,156,147,69,111,110,231,253,224,153,47,240,23,80,157,218,168,178,142,159,55,141,240,189,161,55,222,201,142,89,65,112,214,229,151,237,243,98,29,158,66,205,185,155,241,186,31,227,247,186,132,13,209,160,136,208,125,160,133,78,158,109,229,144,113,230,15,4,56,190,77,179,147,40,18,183,150,135,118,212,174,255,11,11,218,155,253,3,47,64,120,45,22,130,204,161,249,164,137,222,191,93,205,43,35,215,244,132,210,235,230,230,120,139,243,229,253,15,242,149,22,95,36,168,94,27,221,123,210,209,75,234,183,168,214,202,189,251,209,44,72,176,19,188,249,215,210,239,138,132,109,43,216,47,61,120,171,47,67,210,183,217,210,98,255,131,43,59,211,227,78,135,135,246,108,60,254,3,252,64,228,71,6,8,0,0 };
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
