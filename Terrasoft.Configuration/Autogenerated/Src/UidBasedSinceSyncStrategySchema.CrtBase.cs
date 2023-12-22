﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UidBasedSinceSyncStrategySchema

	/// <exclude/>
	public class UidBasedSinceSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UidBasedSinceSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UidBasedSinceSyncStrategySchema(UidBasedSinceSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25a423ba-ef87-4ede-853f-5adb10273007");
			Name = "UidBasedSinceSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,219,110,155,64,16,125,38,82,254,97,68,95,64,178,112,158,147,218,82,227,75,100,169,118,47,216,79,85,85,173,97,112,86,130,93,180,187,164,161,137,255,189,179,128,29,112,76,162,248,1,195,236,220,206,57,51,43,88,134,58,103,17,194,26,149,98,90,38,38,88,50,158,94,94,60,93,94,56,133,230,98,7,97,169,13,102,55,39,223,193,93,42,183,44,229,255,152,225,82,188,156,190,228,153,72,145,240,93,161,222,112,80,216,103,15,102,194,112,195,81,247,58,204,89,100,164,170,61,200,231,147,194,29,213,129,73,202,180,190,134,13,143,111,153,198,56,228,34,194,176,20,81,104,168,17,220,149,149,243,112,56,132,207,186,200,50,166,202,241,241,27,17,34,133,201,200,93,180,3,220,225,24,120,150,167,152,161,48,132,197,72,49,128,24,83,254,128,10,99,72,148,204,218,177,199,194,221,20,193,161,202,176,85,246,215,20,19,86,164,230,150,139,152,16,122,166,204,81,38,94,167,188,63,128,21,137,4,35,112,123,49,185,254,111,202,150,23,219,148,71,16,89,2,250,241,67,139,155,14,45,206,83,69,205,145,200,239,74,230,168,172,4,215,246,221,96,100,48,174,93,78,233,171,12,33,50,21,221,3,62,230,10,181,182,25,104,74,242,148,178,7,199,152,54,120,39,63,36,5,73,84,42,30,35,104,163,172,210,27,161,169,181,165,222,213,57,127,20,168,74,176,3,233,56,59,52,205,155,163,208,20,74,16,45,171,233,207,47,243,53,208,255,236,235,108,61,155,66,184,88,77,102,240,116,181,119,111,42,215,189,125,238,27,120,40,226,26,97,23,46,77,43,85,47,236,76,89,192,21,151,111,160,157,40,36,100,26,4,254,61,171,254,43,137,236,20,81,5,70,246,30,62,42,75,206,20,203,64,144,226,35,183,208,168,168,45,65,36,81,135,238,120,67,223,16,29,13,193,231,97,229,125,62,216,50,24,162,49,196,167,118,199,173,22,237,122,111,229,99,216,62,111,55,215,206,218,140,84,47,42,111,211,105,17,186,29,15,160,90,226,18,218,189,248,149,34,215,176,165,132,222,169,127,199,177,214,249,29,217,150,104,238,101,252,150,98,125,123,29,220,161,57,55,104,68,198,201,156,214,36,156,14,105,79,184,215,244,237,240,4,188,218,53,88,232,85,145,166,223,212,44,203,77,233,77,10,165,232,42,89,210,150,176,29,18,183,11,49,151,105,140,202,135,231,103,232,61,133,17,93,1,87,238,33,189,51,37,20,107,78,55,67,42,89,60,203,72,85,61,167,187,200,154,233,178,160,238,42,176,86,49,107,242,252,155,206,214,208,249,156,66,44,168,147,254,95,167,243,91,91,116,136,183,242,245,49,216,212,218,127,80,140,158,126,14,56,253,15,8,243,78,42,208,7,90,14,108,54,168,26,189,230,82,101,204,120,231,176,13,94,98,131,181,12,43,127,239,15,207,88,110,77,117,224,128,68,76,41,31,46,68,34,131,133,120,96,138,51,97,26,163,223,97,231,100,174,107,107,219,88,89,90,191,255,11,57,100,112,178,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25a423ba-ef87-4ede-853f-5adb10273007"));
		}

		#endregion

	}

	#endregion

}

