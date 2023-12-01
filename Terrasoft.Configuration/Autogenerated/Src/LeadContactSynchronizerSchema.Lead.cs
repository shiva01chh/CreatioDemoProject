﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadContactSynchronizerSchema

	/// <exclude/>
	public class LeadContactSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadContactSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadContactSynchronizerSchema(LeadContactSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2496d37e-0f16-41c9-a9d2-9160f644dc75");
			Name = "LeadContactSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,219,114,219,54,16,125,86,102,242,15,91,230,133,154,209,64,239,209,37,227,139,236,81,107,183,110,228,180,143,25,136,92,137,104,72,128,1,65,59,108,198,255,94,220,40,129,148,232,38,126,240,8,216,221,131,179,139,163,3,113,90,96,85,210,4,225,17,165,164,149,216,41,114,37,248,142,237,107,73,21,19,252,237,155,239,111,223,140,234,138,241,61,108,154,74,97,49,235,173,117,126,158,99,98,146,43,114,139,28,37,75,78,114,238,24,255,122,220,12,207,146,56,180,79,174,47,7,67,43,174,152,98,88,253,111,2,185,168,26,158,252,81,162,107,231,231,11,200,154,43,148,59,61,34,83,171,171,223,73,220,235,0,92,229,180,170,222,195,29,210,84,79,76,209,68,109,116,97,38,5,103,255,162,180,169,211,233,20,230,85,93,20,84,54,75,191,54,73,46,7,18,87,6,74,23,61,67,174,129,160,148,66,31,84,1,126,195,164,86,154,38,105,97,166,1,78,89,111,115,150,64,98,24,12,19,24,153,155,59,208,189,97,152,167,154,239,131,100,79,84,161,229,55,42,221,2,62,85,40,53,6,119,215,8,159,235,206,122,22,166,74,125,156,224,121,3,119,172,82,243,74,73,77,114,9,159,243,35,11,173,135,186,224,191,27,101,185,137,141,222,33,79,29,13,191,110,71,168,231,171,100,157,40,33,53,49,219,148,231,229,26,28,104,45,238,209,237,178,29,131,237,123,212,107,2,22,112,166,171,209,0,113,157,205,241,185,219,227,119,136,124,98,52,129,232,94,108,89,142,15,153,224,104,150,171,130,178,220,124,248,85,108,215,105,4,47,22,254,229,245,254,239,81,101,98,240,82,158,4,75,225,83,153,234,207,127,214,52,103,59,134,45,211,248,182,214,177,175,189,221,117,58,113,140,127,195,230,47,154,215,248,64,153,244,244,39,32,182,255,232,198,151,75,45,59,211,166,77,168,218,97,89,245,55,155,36,195,130,182,186,244,171,69,95,14,36,76,190,167,156,238,81,234,47,190,90,235,203,164,60,193,203,198,140,48,62,12,107,60,11,142,104,193,253,106,209,61,140,92,105,121,41,116,193,184,119,174,199,97,59,136,59,32,228,6,85,146,221,72,81,92,95,198,167,51,25,183,61,142,194,198,201,141,144,43,154,100,113,176,9,139,165,75,28,117,241,55,232,165,97,179,194,10,162,39,61,9,7,74,236,255,177,167,218,195,209,178,189,72,11,198,63,178,125,166,140,196,118,52,175,240,108,234,134,62,97,108,195,30,234,37,144,83,43,144,31,184,235,91,67,61,16,183,107,62,94,175,120,93,104,135,219,230,56,119,39,6,225,165,181,162,171,140,242,61,166,93,153,72,84,181,228,167,113,215,2,249,59,67,169,231,19,68,244,72,135,188,129,216,45,198,171,78,1,49,177,241,216,3,110,208,188,44,241,61,45,31,197,153,62,198,228,81,152,33,196,227,217,153,241,188,54,25,24,130,140,79,198,1,33,189,118,16,14,14,190,160,149,112,159,63,44,22,71,175,128,15,16,153,205,8,222,159,102,206,194,177,26,199,121,141,116,252,197,170,45,196,112,164,126,206,107,2,159,237,63,80,135,23,202,91,173,123,148,156,190,171,9,60,103,44,201,128,74,243,116,73,169,127,56,8,158,98,10,207,76,101,71,51,106,107,108,247,228,112,202,180,127,204,188,164,146,22,192,245,20,22,145,169,137,150,198,239,1,221,55,96,62,181,241,243,233,133,72,253,151,252,120,115,190,188,13,181,172,59,64,254,93,177,206,26,180,233,175,234,154,42,234,239,223,54,49,129,19,49,28,127,235,192,57,14,173,60,6,236,89,107,197,224,26,179,124,108,202,78,233,220,148,44,227,168,239,244,250,45,9,124,239,12,228,47,11,48,165,100,85,148,170,57,88,221,15,88,131,86,155,71,113,220,53,185,1,183,56,219,169,183,45,195,170,143,68,46,120,19,31,109,119,52,240,134,157,123,190,250,80,237,49,47,39,38,24,234,220,239,117,165,111,247,244,223,127,135,215,103,7,227,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2496d37e-0f16-41c9-a9d2-9160f644dc75"));
		}

		#endregion

	}

	#endregion

}
