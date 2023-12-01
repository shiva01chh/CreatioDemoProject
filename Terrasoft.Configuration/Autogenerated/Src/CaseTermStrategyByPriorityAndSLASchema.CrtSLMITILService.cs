﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermStrategyByPriorityAndSLASchema

	/// <exclude/>
	public class CaseTermStrategyByPriorityAndSLASchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermStrategyByPriorityAndSLASchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermStrategyByPriorityAndSLASchema(CaseTermStrategyByPriorityAndSLASchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99e2e60e-c28a-44b3-b5a6-f027322df2c4");
			Name = "CaseTermStrategyByPriorityAndSLA";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("914c52f8-7161-4b32-82f6-d4cef8b3a889");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,223,111,218,48,16,126,166,82,255,135,91,246,18,36,20,246,220,2,18,163,45,66,106,59,38,216,246,48,237,193,36,7,120,74,236,212,118,152,178,138,255,125,231,56,52,33,208,178,105,191,250,80,197,231,243,247,221,125,223,217,8,150,160,78,89,136,48,71,165,152,150,75,19,140,164,88,242,85,166,152,225,82,156,159,61,158,159,181,50,205,197,10,102,185,54,152,92,54,214,148,31,199,24,218,100,29,140,81,160,226,97,149,83,135,77,18,41,142,239,40,124,46,30,92,11,195,13,71,77,9,148,242,90,225,138,136,96,20,51,173,225,2,70,76,35,29,72,102,134,202,197,85,254,54,159,42,46,21,55,249,80,68,179,219,97,113,168,219,237,66,79,103,73,194,84,62,40,215,67,208,229,17,48,107,102,32,66,67,48,92,160,6,195,19,4,187,210,176,200,33,45,241,128,137,8,8,49,216,1,118,107,136,105,182,136,121,8,97,81,213,169,154,94,44,155,192,30,91,69,213,85,175,36,172,81,89,104,164,178,45,79,11,46,151,210,236,172,8,76,4,9,198,98,254,157,122,97,32,240,27,112,2,96,130,76,150,75,234,22,233,8,34,132,10,151,125,239,84,177,94,119,224,218,10,158,248,186,77,194,94,202,20,75,64,208,44,245,61,166,86,218,27,204,137,133,190,178,4,133,209,65,175,91,100,20,7,74,169,78,241,250,31,52,42,234,92,184,201,130,108,111,217,129,43,94,124,80,25,61,18,135,230,166,3,114,241,149,118,7,150,87,183,45,85,235,2,22,68,227,55,207,22,9,96,231,186,181,45,165,70,17,57,181,247,165,191,67,179,150,81,161,186,226,27,42,212,109,167,110,1,11,41,99,152,171,124,134,102,196,98,194,96,234,70,201,100,134,106,195,67,156,136,242,99,202,66,227,147,218,48,206,120,4,97,153,57,137,202,26,90,27,166,0,245,3,244,11,179,138,129,207,103,225,26,19,246,62,67,149,55,164,8,234,9,119,76,176,21,170,14,120,199,72,189,246,229,19,65,69,75,247,53,75,196,61,185,69,140,196,27,12,163,50,230,123,187,54,130,73,228,181,3,155,227,16,108,218,13,143,233,86,232,224,86,174,56,161,189,75,209,61,17,132,210,12,145,171,228,79,64,86,30,30,39,54,223,174,71,10,73,67,23,253,196,205,122,106,71,196,222,66,237,187,32,61,24,52,54,92,75,49,207,83,122,8,30,50,22,215,26,165,167,199,235,192,110,126,174,152,97,54,20,212,182,73,225,246,95,227,47,244,125,158,223,110,87,252,206,178,234,161,132,176,250,116,30,140,209,52,147,26,190,151,80,124,9,126,117,58,152,232,123,105,174,147,212,228,126,123,55,79,173,202,107,66,175,146,63,191,249,98,121,108,55,165,225,31,89,156,97,207,142,229,192,63,54,32,37,231,182,248,175,208,100,74,212,6,9,94,245,233,221,92,178,44,54,190,197,112,217,219,147,119,228,63,92,139,63,123,27,28,21,232,10,187,233,98,163,184,147,115,82,121,91,7,37,125,69,22,199,199,125,173,37,254,59,87,127,230,161,148,134,154,198,104,55,6,229,18,228,134,126,216,121,132,206,238,113,53,14,147,200,175,91,190,215,228,97,33,133,72,191,240,230,214,230,234,73,199,131,158,235,130,28,226,255,54,100,185,105,127,140,130,70,227,47,136,235,162,251,65,138,209,223,15,31,176,250,61,182,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99e2e60e-c28a-44b3-b5a6-f027322df2c4"));
		}

		#endregion

	}

	#endregion

}

