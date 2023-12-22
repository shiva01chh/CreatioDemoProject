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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,149,75,107,219,64,16,128,207,10,228,63,12,206,69,130,32,229,220,56,134,226,38,33,208,148,180,73,218,67,41,101,43,141,156,5,105,101,239,35,69,45,249,239,157,221,213,219,142,147,30,74,125,16,222,209,60,191,153,29,9,86,162,90,179,20,225,14,165,100,170,202,117,188,172,68,206,87,70,50,205,43,113,120,240,251,240,32,48,138,139,21,220,214,74,99,121,58,57,147,126,81,96,106,149,85,124,137,2,37,79,183,116,222,115,177,233,133,195,88,18,159,147,199,231,66,115,205,81,145,2,169,28,73,92,81,12,88,22,76,169,55,214,241,210,20,218,72,188,215,188,112,122,78,109,109,126,20,60,133,212,106,237,86,10,108,69,157,187,11,142,69,70,254,110,100,165,169,10,204,156,151,32,73,18,152,43,83,150,76,214,139,94,128,8,169,196,252,108,118,175,80,18,40,225,11,159,37,11,224,66,105,38,82,140,59,237,100,104,191,110,253,131,68,150,85,162,168,97,236,3,190,155,209,217,87,29,28,161,200,124,170,205,185,197,64,184,181,52,169,174,164,205,222,85,189,39,245,43,65,213,179,194,252,66,16,248,19,82,79,5,140,195,82,55,184,94,40,193,73,214,76,178,18,4,205,205,217,108,156,240,108,225,42,130,180,147,196,243,196,169,247,214,18,41,172,80,139,121,210,254,115,108,124,207,118,116,43,156,48,26,71,140,192,181,50,152,144,131,51,216,66,25,4,79,251,121,94,163,126,168,252,32,240,71,166,113,15,203,75,212,144,97,206,40,215,14,100,46,171,178,61,168,125,252,218,186,223,77,28,24,193,55,6,121,134,52,244,57,71,25,79,16,249,172,224,210,240,204,38,208,152,55,188,46,40,122,79,47,108,185,56,101,137,105,37,179,171,140,168,216,115,124,94,174,117,237,136,4,143,76,130,234,204,206,213,134,116,236,116,184,139,87,223,166,15,88,178,143,6,101,29,78,8,199,67,141,107,38,216,10,229,49,204,250,20,102,81,31,129,103,180,33,76,105,219,50,10,22,191,205,154,55,225,88,254,169,170,180,119,77,251,68,83,63,44,65,175,249,129,230,46,140,162,83,112,222,199,102,23,188,208,40,149,123,19,88,231,19,183,75,186,120,26,189,214,23,174,31,110,236,104,162,53,9,189,112,89,149,52,174,92,85,226,174,94,211,250,217,24,86,80,85,13,234,217,49,208,125,195,40,218,201,174,89,85,91,53,82,1,158,85,191,37,167,48,27,135,60,135,112,219,33,109,66,35,52,44,224,164,109,170,139,156,115,169,26,199,227,144,141,217,215,147,111,222,107,48,104,255,192,200,230,101,139,108,26,240,153,54,3,206,237,120,44,194,182,93,177,101,221,228,246,228,158,126,30,187,129,26,222,170,191,187,39,202,125,20,64,161,214,180,246,255,219,117,185,109,226,119,247,165,41,48,180,86,209,228,99,52,250,42,198,3,107,139,210,241,155,246,149,70,167,157,221,209,165,120,245,34,122,105,167,239,224,251,47,80,250,229,188,155,228,243,171,230,165,21,213,15,125,111,53,220,80,221,184,191,194,105,223,200,87,142,235,132,189,151,142,133,36,27,252,254,0,5,7,127,81,40,9,0,0 };
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

