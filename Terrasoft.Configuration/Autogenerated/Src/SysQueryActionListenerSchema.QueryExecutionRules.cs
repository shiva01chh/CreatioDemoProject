﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysQueryActionListenerSchema

	/// <exclude/>
	public class SysQueryActionListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysQueryActionListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysQueryActionListenerSchema(SysQueryActionListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7212a6e-0918-4845-a171-8318a9732c02");
			Name = "SysQueryActionListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da177164-c77f-4e70-8b5f-3d14e4f140b9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,93,79,219,48,20,125,46,18,255,225,46,188,180,210,148,188,67,139,84,74,247,33,193,216,40,60,77,123,48,201,77,235,45,177,59,219,233,22,33,254,251,174,237,164,144,208,148,161,177,13,250,84,95,223,47,31,31,159,27,193,114,212,75,22,35,92,160,82,76,203,212,132,19,41,82,62,47,20,51,92,138,240,83,129,170,156,254,196,184,176,203,243,34,67,189,187,115,189,187,211,43,52,23,115,152,149,218,96,126,208,90,83,142,44,195,216,70,232,240,45,10,84,60,190,231,115,194,197,247,123,198,25,21,82,220,148,183,27,119,27,203,115,41,54,239,40,236,178,135,199,71,157,91,83,97,184,225,168,31,116,8,167,43,20,166,219,239,13,139,141,84,219,50,109,192,145,124,201,123,79,225,156,44,48,201,152,214,251,22,7,231,58,118,232,157,112,66,133,224,115,158,81,20,193,80,23,121,206,84,121,88,173,233,178,140,146,153,6,179,64,72,51,249,3,100,10,177,66,186,60,234,129,137,4,114,153,240,180,172,32,190,147,58,172,51,70,173,148,67,141,200,50,45,109,154,116,20,108,71,36,60,98,26,157,173,116,134,186,225,0,34,155,239,243,134,173,254,44,94,96,206,62,16,245,96,4,65,179,171,96,240,133,194,150,197,85,198,99,136,45,36,29,136,192,62,116,148,166,248,107,135,215,26,218,83,52,11,153,16,184,31,21,95,49,131,126,119,233,23,176,146,60,129,201,2,227,111,227,36,231,226,108,137,158,250,231,124,190,48,186,127,169,81,17,202,194,211,25,138,198,114,0,246,41,244,122,43,166,32,185,170,201,59,21,115,46,236,225,154,206,196,196,166,199,129,139,229,41,244,95,181,131,233,213,152,9,19,158,48,184,238,169,31,144,241,148,9,54,199,153,204,10,143,88,221,68,239,94,18,119,170,237,105,28,180,142,142,193,192,247,115,99,83,217,127,55,93,56,189,23,116,46,179,1,173,103,8,150,239,149,8,162,74,179,160,87,112,7,174,238,59,111,245,93,225,178,21,147,203,101,66,134,151,129,137,239,245,239,99,114,140,25,190,20,76,124,175,79,141,201,30,138,196,139,80,151,34,57,165,243,155,109,125,119,134,119,164,225,244,56,91,42,8,51,182,194,4,208,234,94,184,142,141,218,193,195,37,83,44,7,65,82,59,10,52,245,66,194,124,232,196,18,252,42,28,70,206,101,115,4,6,135,23,52,86,236,64,168,135,193,126,231,56,112,66,60,78,13,42,87,96,172,230,218,14,1,224,66,27,38,232,11,35,166,81,197,184,176,147,136,134,85,93,208,29,1,136,143,172,209,75,53,1,36,221,135,226,73,69,170,179,234,53,83,138,190,188,250,74,168,87,199,120,13,190,252,17,166,212,212,186,62,32,221,97,37,102,142,77,45,16,71,208,111,90,6,62,157,191,199,173,28,165,216,214,56,109,186,251,20,15,168,101,155,62,77,221,125,12,29,220,139,182,200,62,59,70,180,174,164,139,18,117,53,251,25,243,56,74,212,71,255,125,70,252,95,58,116,15,138,167,163,131,19,179,127,67,135,218,254,135,180,120,148,80,220,158,231,65,118,212,72,188,20,118,116,143,204,237,236,104,13,26,111,109,26,157,141,126,191,0,212,123,218,178,244,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7212a6e-0918-4845-a171-8318a9732c02"));
		}

		#endregion

	}

	#endregion

}

