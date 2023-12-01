﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: QuartzJobTriggerManagerSchema

	/// <exclude/>
	public class QuartzJobTriggerManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public QuartzJobTriggerManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public QuartzJobTriggerManagerSchema(QuartzJobTriggerManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17998df5-3de6-4007-ab26-adbd4f0f1f38");
			Name = "QuartzJobTriggerManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,75,111,219,56,16,62,187,64,255,195,192,123,113,128,84,185,175,227,20,69,210,13,188,64,30,187,78,209,99,65,203,35,155,137,36,10,20,25,55,27,248,191,119,248,146,40,203,143,228,178,104,14,145,196,121,125,243,224,204,184,100,5,214,21,75,17,30,80,74,86,139,76,37,151,162,204,248,82,75,166,184,40,63,126,120,253,248,97,160,107,94,46,97,246,82,43,44,198,91,223,196,159,231,152,26,230,58,185,198,18,37,79,91,158,127,52,147,234,191,237,239,100,90,84,121,242,32,249,114,137,178,110,169,49,136,162,16,229,110,138,196,100,150,174,112,161,115,148,196,65,60,127,72,92,146,125,184,204,89,93,255,9,127,139,185,115,194,18,43,61,207,121,10,169,161,197,164,193,171,37,183,194,228,128,98,165,34,5,247,146,63,51,133,142,94,185,15,72,13,29,106,37,13,30,210,115,45,133,174,102,58,203,248,79,152,192,208,126,14,199,94,39,150,11,167,182,103,67,73,157,42,33,141,21,11,204,27,113,32,27,120,163,19,48,129,31,108,246,144,61,140,74,138,20,235,250,150,210,120,26,160,173,133,124,178,57,237,156,234,26,165,59,152,94,113,155,45,38,95,206,29,241,20,196,252,145,82,120,1,21,147,196,163,40,41,222,254,32,178,144,92,174,48,125,250,34,151,186,192,82,221,234,60,191,147,95,139,74,189,140,134,17,215,240,100,108,5,59,48,14,136,118,248,130,112,64,123,64,46,176,4,145,251,22,2,165,35,2,228,200,51,84,33,103,35,47,241,61,182,76,50,29,36,142,229,155,55,66,212,96,207,91,107,2,101,140,53,31,227,40,103,251,106,128,128,86,40,21,199,173,18,56,59,59,131,243,90,23,5,37,230,194,123,3,165,9,194,249,89,56,142,106,193,231,53,118,251,21,150,168,198,80,155,127,155,158,202,135,21,90,117,32,50,80,244,190,52,177,0,37,96,189,226,233,202,30,81,132,96,142,185,40,151,245,65,163,33,146,71,44,26,117,71,29,32,166,62,120,10,234,181,230,139,228,22,215,230,57,58,73,30,196,204,242,251,228,117,236,52,137,4,94,122,111,124,254,161,208,116,103,231,72,198,168,239,224,226,32,146,110,61,28,15,166,169,8,16,198,162,168,145,140,172,88,158,53,134,215,60,207,223,106,184,169,178,195,54,167,148,55,169,233,6,135,84,225,79,76,53,41,135,76,138,194,229,54,213,82,210,77,177,216,118,219,156,11,145,195,180,118,205,219,88,126,131,167,109,129,147,109,166,26,231,42,106,169,100,158,106,200,64,242,174,239,54,123,168,235,68,151,105,11,75,15,77,123,128,228,172,196,108,50,164,72,220,85,118,252,12,207,46,124,155,95,115,181,130,71,10,17,177,216,57,22,185,144,52,58,186,56,125,155,111,213,193,143,199,230,125,220,237,194,129,35,122,117,237,146,208,195,228,34,150,132,207,159,97,20,127,79,34,169,228,10,51,166,115,229,59,82,221,151,158,192,51,203,53,190,165,177,220,160,90,137,197,190,241,245,44,248,2,58,93,208,67,110,46,243,196,215,163,217,0,82,166,70,247,241,112,233,14,188,147,3,120,220,233,214,225,214,132,118,107,0,233,244,59,192,13,43,25,61,250,243,122,47,227,192,130,143,221,255,139,99,190,215,123,186,134,138,148,82,53,44,68,153,191,248,210,131,92,164,79,119,238,117,2,37,174,253,185,111,50,91,194,123,176,192,15,110,23,135,20,143,12,255,55,53,254,75,91,176,212,20,130,82,211,211,204,10,148,163,178,101,172,168,134,75,96,37,93,187,149,113,231,83,205,50,132,66,44,246,182,217,131,224,167,193,76,91,191,238,109,192,51,170,219,6,197,132,226,67,227,55,20,205,96,96,66,7,163,54,128,45,229,152,228,96,16,17,109,212,247,128,11,131,218,252,73,84,154,252,142,99,237,8,27,255,226,159,254,177,155,125,243,190,91,36,20,249,133,139,80,104,85,56,128,41,65,189,66,197,120,14,215,168,220,61,161,163,81,179,159,153,222,227,222,130,219,30,208,151,170,106,118,215,196,230,26,253,53,51,242,141,84,226,167,226,41,116,142,236,13,140,207,226,43,234,28,111,105,223,187,123,96,75,248,214,172,130,145,162,166,61,198,167,241,152,216,130,226,251,83,167,17,68,1,242,137,52,225,241,175,97,101,85,238,179,179,156,218,85,196,157,112,26,94,5,175,51,46,209,148,166,89,150,201,206,86,20,77,205,204,56,253,134,64,175,220,252,158,24,117,52,55,42,73,20,110,122,10,169,240,250,86,96,243,190,54,187,239,14,255,171,169,113,51,80,172,126,130,76,72,224,69,129,11,110,58,137,40,241,147,226,133,95,11,204,38,182,123,104,90,117,118,100,217,177,62,25,54,177,31,94,180,109,196,42,79,253,207,53,12,107,1,169,178,146,113,19,120,230,82,105,150,187,33,64,240,124,216,142,212,108,167,88,35,145,223,161,76,59,133,215,143,190,137,69,192,110,86,37,19,169,176,154,185,181,137,82,249,63,7,61,194,179,43,234,199,106,255,153,73,187,210,76,154,158,157,116,154,79,155,190,113,195,31,93,137,163,43,117,44,16,22,130,126,90,123,172,91,120,194,109,239,92,198,88,235,233,46,23,199,253,122,107,148,198,97,35,60,141,182,247,238,32,246,140,254,126,1,237,38,228,201,244,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17998df5-3de6-4007-ab26-adbd4f0f1f38"));
		}

		#endregion

	}

	#endregion

}
