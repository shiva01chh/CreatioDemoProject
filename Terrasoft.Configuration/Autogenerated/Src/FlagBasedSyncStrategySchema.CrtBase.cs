﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FlagBasedSyncStrategySchema

	/// <exclude/>
	public class FlagBasedSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FlagBasedSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FlagBasedSyncStrategySchema(FlagBasedSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("98cc9dd8-f9b3-410b-8e74-93b385331101");
			Name = "FlagBasedSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,109,111,219,54,16,254,236,2,253,15,156,250,69,6,60,185,159,155,38,64,18,219,131,209,38,233,98,7,69,49,12,3,35,157,29,45,18,165,145,148,83,55,200,127,223,29,169,23,218,146,19,39,221,128,20,40,18,145,188,187,135,207,221,61,36,35,120,10,42,231,33,176,57,72,201,85,182,208,193,25,143,147,183,111,238,223,190,233,21,42,22,75,54,91,43,13,233,65,253,221,172,60,205,36,236,26,15,70,39,59,167,102,218,26,226,252,59,9,203,56,19,236,52,225,74,125,96,147,132,47,79,184,130,104,182,22,225,76,75,174,97,185,54,11,135,195,33,251,168,138,52,229,114,125,84,127,3,176,80,194,226,208,155,186,6,222,240,136,197,105,158,64,10,66,243,88,103,98,192,34,72,226,21,72,136,216,66,102,169,107,186,101,25,84,206,135,219,209,36,224,231,173,170,190,59,177,178,2,7,152,206,152,130,4,66,205,120,146,48,145,233,95,35,201,23,122,96,127,197,25,141,139,144,121,197,151,160,6,165,63,156,99,20,0,167,174,215,46,192,206,64,1,125,208,12,109,246,22,214,119,153,140,26,232,14,212,188,184,78,226,144,229,92,234,152,39,44,36,162,119,96,255,192,54,105,239,221,27,234,155,36,101,66,105,46,52,38,234,139,140,87,184,138,102,233,255,118,118,204,192,231,44,188,101,217,245,223,196,195,34,147,76,161,115,182,192,200,44,22,177,230,73,252,131,107,116,27,212,14,92,198,123,185,141,192,48,162,70,252,18,120,148,137,100,93,57,252,75,149,251,167,40,23,118,236,144,9,184,43,23,248,125,91,96,221,208,102,53,20,158,231,72,143,1,194,66,30,222,0,145,249,4,164,144,120,64,96,146,106,187,6,114,74,214,159,96,141,48,188,105,202,115,234,35,138,131,67,94,137,229,29,136,200,114,185,73,236,36,134,36,114,89,221,13,28,184,12,111,24,124,207,37,150,15,217,98,111,230,9,26,61,129,185,230,175,134,109,60,253,94,128,92,207,243,132,64,95,157,143,46,143,39,115,134,63,199,159,199,243,241,8,127,251,52,254,246,245,226,114,196,238,223,63,208,38,108,182,221,109,148,35,173,141,100,26,147,0,81,103,129,48,55,13,55,50,19,241,143,166,31,220,98,238,220,79,233,185,197,255,19,28,155,226,149,69,136,218,67,0,77,87,216,21,101,135,116,246,132,127,165,64,162,169,192,152,228,165,216,248,236,51,146,201,94,175,198,128,52,254,6,122,156,150,169,175,246,70,83,254,150,169,97,243,161,139,82,23,245,25,232,155,108,191,210,184,4,93,72,161,156,54,91,241,164,0,211,122,49,214,99,69,240,14,98,205,8,170,4,79,153,192,83,225,208,219,196,235,29,57,138,180,73,138,145,91,163,12,33,4,31,135,198,71,227,82,90,88,29,173,247,8,176,109,35,87,123,107,47,147,102,143,138,78,148,8,81,116,244,51,23,17,139,184,230,215,152,219,0,43,84,82,239,214,201,177,43,211,2,7,113,111,212,41,133,136,255,65,151,198,241,160,138,71,78,76,16,22,235,61,194,184,59,105,128,55,146,102,42,119,103,165,236,85,115,43,46,109,228,200,106,14,122,43,213,102,130,7,156,17,163,206,146,235,197,11,230,255,98,33,4,83,117,94,36,201,133,28,167,185,94,251,181,187,126,21,164,103,19,209,4,178,46,30,106,4,209,117,87,244,209,201,115,67,27,63,77,216,89,237,110,158,217,173,152,5,131,109,46,14,54,80,154,53,46,194,132,78,32,191,227,168,168,3,189,136,193,231,81,184,131,195,18,162,97,113,9,2,72,111,42,32,69,28,5,231,112,71,63,253,126,48,207,102,38,148,95,133,119,217,65,170,93,235,93,12,181,9,221,199,170,68,238,46,117,232,173,197,235,121,114,68,215,175,86,251,188,26,81,218,19,164,235,160,221,214,173,50,218,171,163,167,35,148,15,115,55,46,165,230,112,107,97,112,220,32,162,181,54,23,101,146,140,201,31,173,219,200,159,140,171,18,217,193,79,38,173,67,221,94,101,174,58,85,120,207,116,97,59,237,173,190,120,3,43,18,186,117,150,74,96,20,224,160,158,46,95,0,246,82,58,51,31,219,114,98,187,12,31,69,73,145,10,223,59,71,218,188,106,144,208,248,94,235,128,160,219,100,181,228,66,70,32,79,214,199,42,244,189,83,115,120,69,23,194,235,83,198,109,60,11,198,190,193,124,43,215,227,239,16,22,88,42,237,226,26,11,85,72,24,157,52,67,126,35,98,142,15,186,73,2,217,219,13,6,214,35,92,154,97,191,137,224,40,32,233,165,53,11,104,153,227,151,202,183,100,177,92,64,249,176,114,247,190,146,161,74,42,31,28,105,47,171,222,90,239,81,217,40,128,237,178,198,119,218,139,149,200,120,240,142,182,170,177,93,190,255,109,71,84,197,187,202,226,136,181,69,189,172,105,123,119,97,255,167,234,236,148,155,67,27,253,39,82,242,92,157,121,101,153,64,9,121,65,26,168,179,48,14,200,74,49,166,230,163,91,49,122,193,84,232,236,113,117,232,5,8,170,212,148,1,179,18,19,124,33,248,160,177,79,13,182,126,117,47,51,177,170,78,246,31,121,155,108,62,247,154,215,137,243,156,218,200,245,174,63,209,80,155,95,9,74,254,153,90,206,154,167,40,210,189,245,222,179,143,179,108,5,82,198,145,171,218,93,230,126,69,103,125,40,26,101,158,100,50,229,218,223,122,243,14,154,183,99,189,227,214,126,237,152,59,132,35,238,191,127,1,228,28,100,128,67,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("98cc9dd8-f9b3-410b-8e74-93b385331101"));
		}

		#endregion

	}

	#endregion

}

