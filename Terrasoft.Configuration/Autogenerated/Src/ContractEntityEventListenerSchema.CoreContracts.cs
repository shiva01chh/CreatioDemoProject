﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContractEntityEventListenerSchema

	/// <exclude/>
	public class ContractEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContractEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContractEntityEventListenerSchema(ContractEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dc1c550-b00c-4bed-b991-26641e373489");
			Name = "ContractEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d07c15be-3f83-4fdc-a9ea-aad9ed069b01");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,106,219,64,16,61,59,144,127,24,148,139,12,70,186,39,78,160,49,38,4,218,36,144,180,151,208,195,90,26,219,106,165,93,117,102,165,98,66,254,189,163,221,149,99,153,200,213,109,181,51,239,189,121,243,86,171,10,185,86,25,194,11,18,41,54,107,155,44,140,94,23,155,134,148,45,140,62,63,123,59,63,155,52,92,232,205,160,132,48,89,106,91,216,2,249,234,127,5,201,178,69,109,199,235,158,200,100,200,60,36,150,106,169,191,32,220,200,1,22,165,98,190,4,169,176,164,50,235,144,119,14,246,107,193,22,53,146,43,79,211,20,230,220,84,149,162,221,77,56,187,86,168,201,180,69,142,12,89,128,0,12,234,0,157,58,216,42,157,151,162,46,233,113,210,35,160,57,35,170,146,13,100,132,235,235,232,244,176,201,173,98,252,68,102,4,105,135,247,250,201,85,252,156,109,177,82,15,178,18,184,134,168,159,53,154,254,148,134,186,89,149,69,6,153,27,230,132,13,112,9,35,204,240,230,44,218,91,250,13,237,214,228,98,234,19,21,173,178,232,111,107,127,0,179,250,133,98,210,93,215,41,231,103,252,211,160,102,124,104,170,149,40,245,240,222,194,221,180,67,158,76,38,173,34,216,32,117,245,134,100,2,141,127,71,250,191,51,210,139,226,223,177,7,72,186,179,204,164,133,81,148,77,175,28,28,161,109,72,127,32,38,35,90,2,134,55,111,6,39,32,223,135,35,174,140,41,225,158,61,204,178,170,237,110,124,46,66,110,74,43,67,5,248,59,180,47,187,26,243,133,41,155,74,255,80,101,131,115,182,36,241,185,137,35,143,24,13,231,240,183,73,199,87,150,143,129,207,195,14,212,93,160,206,253,134,198,214,229,146,224,47,143,243,190,207,105,200,232,72,20,146,71,125,47,6,146,21,69,81,250,209,120,152,248,62,113,166,149,156,203,203,129,214,20,57,28,52,198,33,34,44,130,145,102,224,121,110,113,45,175,193,177,125,161,141,60,174,222,197,149,72,57,228,141,251,62,12,62,117,54,123,119,197,230,176,137,169,47,242,5,197,26,226,225,186,194,158,122,10,7,193,131,116,8,212,201,216,4,238,73,31,34,180,7,27,221,111,114,118,132,26,186,222,199,215,230,255,14,127,186,127,135,223,63,121,109,254,171,125,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dc1c550-b00c-4bed-b991-26641e373489"));
		}

		#endregion

	}

	#endregion

}

