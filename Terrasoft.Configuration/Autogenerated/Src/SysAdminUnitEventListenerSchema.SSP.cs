﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysAdminUnitEventListenerSchema

	/// <exclude/>
	public class SysAdminUnitEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysAdminUnitEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysAdminUnitEventListenerSchema(SysAdminUnitEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("020aa647-daf1-4077-a5db-bbe8dad8c008");
			Name = "SysAdminUnitEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,223,107,219,48,16,126,118,161,255,195,205,131,214,134,97,191,231,87,105,67,183,6,186,173,52,233,94,198,30,20,235,156,104,216,82,144,228,140,80,250,191,87,146,127,212,246,146,180,12,6,245,131,65,167,239,238,59,221,125,119,156,228,168,54,36,65,88,160,148,68,137,84,71,83,193,83,182,42,36,209,76,240,211,147,199,211,19,175,80,140,175,58,16,137,209,53,215,76,51,84,195,215,0,209,245,22,185,182,56,131,252,40,113,101,226,194,52,35,74,13,96,190,83,151,52,103,252,129,51,237,96,183,76,105,228,40,29,56,142,99,24,169,34,207,137,220,77,170,115,13,128,84,72,56,111,251,159,3,90,198,29,160,227,139,234,0,113,47,194,72,33,146,76,9,72,36,166,99,255,120,214,209,21,81,232,108,187,78,126,62,196,54,222,207,61,87,193,60,89,99,78,190,153,218,194,24,252,118,138,126,248,203,56,109,138,101,198,18,72,108,9,14,87,0,6,112,128,219,132,120,116,245,105,170,121,39,197,6,165,77,123,0,119,46,122,121,95,49,205,246,51,220,96,102,188,224,216,229,176,226,65,78,75,170,46,239,87,212,107,65,45,169,100,91,162,177,98,45,15,160,180,209,80,2,75,33,50,152,169,7,133,114,177,219,96,80,190,8,72,77,27,130,213,152,231,177,20,130,198,24,125,65,61,83,83,145,21,57,255,65,178,2,111,5,161,72,131,78,57,109,56,119,233,135,112,118,230,130,120,94,39,132,69,208,86,148,17,227,122,114,56,200,120,236,106,110,70,64,153,214,219,140,247,34,235,140,61,137,186,144,28,180,44,112,232,44,79,238,95,153,83,163,178,210,254,244,214,50,182,122,215,23,191,51,220,16,78,51,84,181,210,103,220,164,168,145,150,146,143,26,183,184,239,55,218,16,73,114,224,70,147,99,95,153,52,140,130,39,174,223,80,158,162,81,236,32,251,61,208,159,44,214,232,38,167,158,154,193,193,185,113,169,93,166,26,165,35,184,148,43,101,167,5,152,41,42,225,102,215,36,130,107,194,184,93,25,122,141,53,161,123,2,80,162,73,39,151,74,194,98,107,232,24,69,216,10,70,225,59,175,95,30,136,229,111,76,234,87,124,130,125,236,208,52,108,105,154,27,181,156,107,47,12,203,246,245,165,105,230,183,146,107,88,66,75,216,209,113,26,31,29,40,184,184,0,142,127,142,98,130,240,117,154,104,142,250,30,19,33,233,61,91,173,245,103,33,27,244,203,16,133,109,241,189,69,79,115,178,181,93,121,119,106,186,66,179,237,241,63,202,169,124,248,126,49,245,200,255,82,83,229,251,143,90,178,91,239,67,107,59,190,52,175,183,101,218,11,230,157,8,176,185,159,218,22,36,122,70,15,104,175,183,248,74,107,215,232,108,230,123,6,0,138,115,201,147,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("020aa647-daf1-4077-a5db-bbe8dad8c008"));
		}

		#endregion

	}

	#endregion

}

