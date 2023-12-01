﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StrategySchema

	/// <exclude/>
	public class StrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StrategySchema(StrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5288f9fa-e366-4934-a4ae-e4bebb5faf18");
			Name = "Strategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,75,143,218,48,16,62,179,210,254,7,43,189,36,18,10,247,229,81,45,236,82,113,96,251,96,247,84,85,43,19,6,136,154,56,200,118,182,77,171,254,247,142,237,24,156,132,4,122,104,110,177,231,241,205,55,223,216,102,52,5,113,160,17,144,103,224,156,138,108,43,195,37,141,147,219,155,223,183,55,189,92,196,108,71,86,133,144,144,14,143,255,39,203,89,150,166,25,59,191,195,161,109,61,124,100,50,150,49,136,86,131,57,141,100,198,141,5,218,188,227,176,139,51,70,102,9,21,226,142,172,36,167,18,118,133,222,27,12,6,100,36,242,52,165,188,152,148,255,139,244,144,64,10,76,82,169,220,178,45,90,0,144,136,195,118,236,45,172,187,55,176,246,163,129,19,224,235,3,108,105,158,200,105,204,54,8,205,151,197,1,178,173,127,116,11,130,111,104,117,200,215,73,28,145,72,33,58,2,34,119,100,113,2,215,251,173,1,158,208,103,76,72,202,36,86,240,137,199,111,104,101,246,235,21,232,133,41,21,64,68,193,162,61,207,88,252,203,20,34,108,30,134,93,11,143,190,46,250,222,193,132,38,145,202,166,60,20,189,175,107,12,183,194,104,22,221,19,6,32,99,226,189,196,27,149,105,227,238,121,195,18,55,176,141,129,94,173,99,30,67,178,185,170,8,135,245,23,1,28,9,96,16,169,74,144,122,18,107,54,162,75,117,112,160,155,140,37,5,169,70,32,175,121,229,127,216,1,227,216,158,181,105,41,249,14,197,181,89,45,129,194,33,238,2,63,186,207,60,87,10,86,44,105,161,24,139,82,52,22,143,95,43,169,90,81,223,230,118,83,7,68,141,101,175,87,171,30,91,217,160,67,89,137,106,187,107,69,244,122,127,186,43,89,130,220,103,215,181,250,3,72,45,215,147,70,205,104,108,245,36,95,67,189,94,225,32,115,206,196,100,214,234,60,26,88,27,183,95,37,85,136,194,85,184,111,233,50,46,213,46,134,11,241,148,39,201,71,254,152,30,100,129,166,239,91,198,228,174,209,253,35,113,109,84,8,146,226,25,186,206,126,54,71,24,164,68,164,194,157,13,125,28,22,238,76,144,53,42,15,155,2,156,128,138,68,232,6,27,36,196,53,212,117,6,110,161,207,24,42,228,75,131,91,147,80,66,53,155,190,85,163,134,245,168,80,221,27,80,150,228,55,202,109,217,232,110,189,87,209,30,75,64,241,213,36,107,46,129,194,108,47,41,163,59,224,33,2,88,148,72,167,166,131,222,25,64,94,48,236,72,88,214,50,110,197,18,206,112,186,37,148,101,213,96,149,161,219,194,134,115,144,209,126,206,179,244,97,234,123,171,6,23,94,255,12,65,125,20,114,34,160,12,93,106,177,45,195,69,121,125,49,253,171,94,105,238,241,173,218,93,189,0,143,178,218,102,156,140,14,148,211,20,253,244,45,50,246,154,120,49,66,151,208,180,127,187,243,100,105,165,127,78,192,163,129,118,239,148,237,181,229,180,136,185,226,238,30,9,215,73,184,118,102,54,142,20,71,123,226,36,182,238,209,105,38,172,104,65,159,118,230,205,83,168,25,24,85,74,152,248,46,164,62,97,240,195,189,99,238,249,46,87,220,248,94,85,201,40,197,186,182,251,58,105,175,53,128,112,135,172,127,170,47,8,254,237,182,112,174,60,221,227,152,237,129,199,114,147,69,245,55,88,232,208,251,57,7,110,123,20,152,199,153,189,49,155,199,187,107,124,169,161,174,28,198,85,65,92,104,140,235,170,160,190,48,181,178,20,187,21,80,30,237,13,136,160,49,178,221,245,206,49,91,246,6,252,92,41,125,242,128,107,207,49,222,244,109,12,116,185,159,61,124,108,68,130,47,237,8,212,223,127,98,199,34,171,241,115,74,219,161,34,179,90,93,212,107,248,253,5,144,115,253,245,164,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5288f9fa-e366-4934-a4ae-e4bebb5faf18"));
		}

		#endregion

	}

	#endregion

}
