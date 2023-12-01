﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PartnershipPrmBaseEventListenerSchema

	/// <exclude/>
	public class PartnershipPrmBaseEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PartnershipPrmBaseEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PartnershipPrmBaseEventListenerSchema(PartnershipPrmBaseEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ec40417-7c1e-4576-891b-39fe06427885");
			Name = "PartnershipPrmBaseEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,193,142,218,48,16,61,179,210,254,195,40,189,4,9,37,119,22,144,88,186,162,43,181,93,4,180,151,170,135,33,30,18,87,201,56,178,29,42,186,234,191,215,113,8,155,32,232,230,230,153,55,243,222,60,143,195,88,144,41,49,33,216,146,214,104,212,222,70,11,197,123,153,86,26,173,84,124,127,247,122,127,55,168,140,228,20,54,71,99,169,120,56,159,187,37,69,161,248,122,70,83,191,227,77,212,199,199,155,169,39,182,210,74,50,239,2,162,167,3,177,173,113,14,249,65,83,234,8,97,145,163,49,99,88,161,182,76,218,100,178,92,233,226,17,13,121,240,103,233,166,114,113,95,18,199,49,76,76,85,20,168,143,179,211,185,5,192,94,233,110,19,160,154,244,8,228,41,163,182,58,190,40,159,24,34,204,141,130,68,211,126,26,252,95,120,228,101,249,190,61,113,1,196,117,191,31,87,82,225,38,201,168,192,175,238,38,97,10,65,71,96,48,252,233,106,202,106,151,203,4,146,218,132,247,60,128,49,220,16,224,26,189,122,135,206,174,126,33,155,41,81,251,234,9,154,228,165,127,62,240,9,89,228,100,90,191,158,217,144,182,36,26,227,162,115,89,124,89,55,41,81,99,1,236,38,155,6,134,88,56,31,102,94,21,52,167,104,18,123,200,245,10,10,102,219,140,188,255,173,247,227,155,238,123,105,243,189,37,237,9,230,58,53,181,231,32,217,88,100,247,62,18,197,22,37,215,187,103,51,106,9,253,8,32,208,98,79,203,201,115,117,112,116,82,16,28,148,20,240,194,237,228,161,218,253,162,164,157,98,4,215,216,129,134,80,63,189,193,96,231,110,36,234,20,183,85,52,124,240,249,3,106,112,212,78,85,179,150,83,8,155,134,195,6,249,134,210,50,205,172,89,83,90,229,104,221,50,79,129,233,55,108,76,217,224,215,253,116,216,105,26,125,115,228,238,25,179,147,237,46,127,212,37,140,222,22,240,164,232,130,39,90,106,100,251,162,83,100,249,199,255,3,214,132,162,97,235,145,172,180,172,23,96,161,242,170,224,239,152,87,52,242,253,156,161,29,212,146,236,246,88,146,232,192,38,203,74,138,89,24,204,147,68,85,108,159,69,48,108,164,252,61,237,172,51,162,89,91,127,110,162,253,160,143,185,239,31,91,174,124,181,18,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ec40417-7c1e-4576-891b-39fe06427885"));
		}

		#endregion

	}

	#endregion

}

