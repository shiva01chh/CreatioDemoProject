﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichActivityInfoSchema

	/// <exclude/>
	public class EnrichActivityInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichActivityInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichActivityInfoSchema(EnrichActivityInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1");
			Name = "EnrichActivityInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,83,223,107,219,48,16,126,78,161,255,195,145,66,137,25,216,239,203,15,24,94,233,250,208,173,44,121,27,123,80,236,115,162,97,75,153,36,23,178,210,255,125,39,89,182,229,204,43,105,217,76,176,115,159,238,199,119,223,157,4,171,80,31,88,134,176,65,165,152,150,133,137,83,41,10,190,171,21,51,92,138,203,139,167,203,139,73,173,185,216,193,250,168,13,86,243,19,59,254,90,11,195,43,140,215,168,56,43,249,47,23,71,94,228,119,165,112,71,6,164,37,211,250,61,220,8,197,179,253,135,204,240,71,110,142,119,162,144,228,67,191,36,73,96,161,235,170,98,234,184,242,118,227,139,57,96,197,120,9,156,156,85,229,82,199,109,68,18,132,124,251,200,12,35,230,70,177,204,124,39,224,80,111,75,158,65,102,43,143,23,126,114,20,59,142,15,74,30,80,25,142,68,244,161,9,110,28,78,217,57,96,179,71,207,140,249,172,192,115,36,33,10,142,42,238,194,66,138,13,199,123,172,182,168,102,159,73,120,88,194,180,141,190,203,167,145,165,221,242,190,173,121,14,29,225,124,254,2,149,78,169,140,218,167,124,111,35,226,131,71,121,164,237,217,171,104,8,202,252,122,2,214,28,82,208,70,217,109,75,251,115,79,227,10,69,222,12,111,56,201,123,52,123,153,159,53,198,133,70,132,76,97,177,156,250,109,254,178,253,129,153,137,111,126,214,172,212,51,233,172,104,154,172,198,27,241,20,229,35,221,30,146,29,182,82,150,48,136,5,250,68,96,47,209,100,194,11,176,40,44,151,32,234,178,108,225,137,66,83,43,1,5,69,217,222,8,121,118,239,63,215,214,102,219,200,84,86,7,166,172,106,54,27,27,219,239,121,88,48,136,56,179,178,199,251,5,12,4,233,178,197,253,113,4,215,215,253,154,140,58,119,167,145,43,244,252,255,167,18,14,99,92,202,183,14,230,37,121,206,81,229,159,136,113,139,230,19,211,251,84,230,56,251,187,22,14,105,248,234,213,34,105,255,141,45,47,23,6,6,73,189,12,190,219,89,208,238,70,174,221,173,36,159,119,65,135,61,28,13,233,133,93,158,92,219,6,29,130,14,11,159,223,183,23,203,155,168,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32631f18-b4d5-4b3a-96de-3aa147def4d1"));
		}

		#endregion

	}

	#endregion

}

