﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureUtilitiesSchema

	/// <exclude/>
	public class SysCultureUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureUtilitiesSchema(SysCultureUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35f8ebef-8b39-4002-b651-4d41d56d3661");
			Name = "SysCultureUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,149,73,107,219,64,20,128,207,50,228,63,12,202,69,130,32,229,220,216,134,226,38,33,208,148,180,73,218,67,41,101,42,61,57,3,210,200,158,37,69,45,249,239,125,179,104,181,227,164,135,210,75,200,60,191,245,123,139,56,173,64,110,104,6,228,14,132,160,178,46,84,178,170,121,193,214,90,80,197,106,126,52,251,125,52,11,180,100,124,77,110,27,169,160,58,155,188,81,191,44,33,51,202,50,185,4,14,130,101,59,58,239,25,223,246,194,97,44,1,207,201,147,115,174,152,98,32,81,1,85,142,5,172,49,6,89,149,84,202,55,198,241,74,151,74,11,184,87,172,180,122,86,109,163,127,148,44,35,153,209,218,175,20,152,138,58,119,23,12,202,28,253,221,136,90,97,21,144,91,47,65,154,166,100,46,117,85,81,209,44,123,1,0,201,4,20,139,240,94,130,64,80,220,21,30,166,75,194,184,84,148,103,144,116,218,233,208,126,211,250,39,2,104,94,243,178,33,99,31,228,187,30,189,93,213,193,49,240,220,165,234,223,45,6,196,173,132,206,84,45,76,246,182,234,3,169,95,113,172,158,150,250,23,16,14,63,73,230,168,16,109,177,52,30,215,11,37,88,201,134,10,90,17,142,115,179,8,199,9,135,75,91,17,201,58,73,50,79,173,122,111,45,0,195,114,185,156,167,237,127,150,141,235,217,158,110,69,19,70,227,136,49,177,173,12,38,228,200,130,236,160,12,130,167,195,60,175,65,61,212,110,16,216,35,85,112,128,229,37,40,146,67,65,49,215,14,100,33,234,170,125,200,67,252,218,186,223,77,28,104,206,182,26,88,14,56,244,5,3,145,76,16,185,172,200,165,102,185,73,192,155,123,94,23,24,189,167,23,181,92,172,178,128,172,22,249,85,142,84,204,59,57,175,54,170,177,68,130,71,42,136,236,204,206,229,22,117,204,116,216,197,107,110,179,7,168,232,71,13,162,137,38,132,147,161,198,53,229,116,13,226,132,132,125,10,97,220,71,96,57,94,8,93,153,182,140,130,37,111,115,255,75,52,150,127,170,107,229,92,227,61,81,216,15,67,208,105,126,192,185,139,226,248,140,88,239,99,179,11,86,42,16,210,254,18,24,231,19,183,43,92,60,5,78,235,11,83,15,55,102,52,193,152,68,78,184,170,43,28,87,38,107,126,215,108,240,252,108,53,45,177,42,143,58,60,33,184,111,16,199,123,217,249,83,181,83,35,22,224,88,245,87,114,10,211,59,100,5,137,118,29,226,37,212,92,145,37,57,109,155,106,35,23,76,72,239,120,28,210,155,125,61,253,230,188,6,131,246,15,140,76,94,166,72,223,128,207,120,25,96,110,198,99,25,181,237,74,12,107,159,219,147,253,235,230,177,27,168,225,86,253,221,158,72,251,81,32,18,148,194,179,255,223,214,229,214,199,239,246,197,23,24,25,171,120,242,49,26,125,21,147,129,181,65,105,249,77,251,138,163,211,206,238,104,41,94,125,136,94,186,233,123,248,254,11,148,238,56,239,39,249,252,169,121,233,68,245,67,223,91,13,47,84,55,238,175,112,218,55,242,149,227,58,97,239,164,99,33,202,102,179,63,138,83,65,133,31,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35f8ebef-8b39-4002-b651-4d41d56d3661"));
		}

		#endregion

	}

	#endregion

}

