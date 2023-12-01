﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadDefaultValueManagerSchema

	/// <exclude/>
	public class LeadDefaultValueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadDefaultValueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadDefaultValueManagerSchema(LeadDefaultValueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("31a5b04c-75df-4d8d-a75d-7cce68df40cf");
			Name = "LeadDefaultValueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30ff16fc-9eaa-40ad-9611-33924da6f041");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,219,110,218,64,16,125,38,82,254,97,234,190,16,9,76,162,164,205,133,4,137,66,64,81,147,166,10,109,243,188,120,199,206,182,246,26,237,174,65,40,202,191,103,118,215,24,135,139,84,94,176,103,103,206,156,157,115,198,146,101,168,103,44,66,248,133,74,49,157,199,38,28,228,50,22,73,161,152,17,185,12,199,40,145,30,145,63,227,116,148,171,108,130,106,46,34,60,60,120,61,60,104,20,90,200,4,38,75,109,48,235,110,188,19,78,154,98,100,65,180,71,17,209,58,167,222,78,33,197,233,228,179,194,132,178,97,144,50,173,175,224,30,25,31,98,204,138,212,252,97,105,129,15,76,178,4,149,75,237,116,58,112,173,139,44,99,106,217,43,223,159,208,20,74,106,224,190,6,230,182,72,67,156,43,72,196,28,37,164,76,114,219,155,254,0,165,17,102,25,174,160,58,53,172,89,49,77,69,4,145,101,177,143,4,92,193,227,244,47,221,110,39,193,134,157,205,22,71,23,176,120,96,239,73,35,82,144,161,121,201,57,180,43,106,51,2,8,171,226,58,171,198,76,137,57,233,64,197,140,231,50,93,194,184,16,220,225,61,149,112,15,14,109,144,115,132,27,144,184,112,25,205,224,91,255,248,242,124,112,218,111,159,158,12,70,237,179,139,254,121,187,127,114,249,181,125,113,54,234,15,191,28,223,142,110,47,134,193,81,119,103,15,109,148,165,181,217,33,45,50,73,61,130,143,241,59,30,120,33,9,39,55,52,28,228,144,207,73,104,65,140,74,164,73,94,168,8,203,169,233,73,244,130,25,251,65,38,4,55,178,70,130,6,94,169,189,85,18,130,123,63,149,154,6,58,232,194,155,205,124,243,141,86,150,241,4,200,52,63,157,120,254,112,167,0,255,235,146,61,42,184,200,140,41,150,129,36,218,55,65,161,81,209,198,72,239,244,160,119,39,181,97,146,22,42,143,193,158,65,84,29,134,215,29,87,185,27,104,225,247,139,134,216,187,227,214,158,177,160,106,66,89,17,218,170,246,99,210,189,161,112,240,68,17,22,194,188,80,71,167,143,133,5,166,225,31,46,157,229,203,176,187,176,141,187,7,66,93,193,56,225,188,247,43,213,214,208,215,94,192,22,228,206,247,61,24,163,119,189,110,58,35,86,244,91,240,251,195,72,224,227,132,142,74,165,231,76,145,206,218,74,112,3,83,166,49,92,3,214,176,54,138,187,85,109,186,177,152,186,244,252,126,198,205,85,235,198,43,4,207,213,180,91,107,234,222,90,141,55,223,69,196,208,252,228,41,218,111,162,97,66,234,239,184,108,238,90,134,163,10,123,139,87,216,231,124,103,77,107,207,242,150,151,244,92,30,80,37,232,243,61,220,51,41,252,72,242,44,148,48,216,220,234,214,42,135,90,130,148,155,228,99,221,250,226,160,228,126,119,232,205,199,234,33,23,161,223,59,19,10,171,42,32,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("31a5b04c-75df-4d8d-a75d-7cce68df40cf"));
		}

		#endregion

	}

	#endregion

}
