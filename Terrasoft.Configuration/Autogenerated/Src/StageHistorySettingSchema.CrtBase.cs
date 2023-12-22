﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StageHistorySettingSchema

	/// <exclude/>
	public class StageHistorySettingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StageHistorySettingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StageHistorySettingSchema(StageHistorySettingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42688b4c-cf7a-4a15-b9ff-7de341cf3dd5");
			Name = "StageHistorySetting";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,88,203,110,219,58,16,93,171,64,255,129,208,221,216,128,32,239,175,99,7,173,219,180,94,52,13,224,182,155,162,8,24,137,118,136,234,97,144,148,11,223,32,255,126,41,81,15,14,69,201,148,155,69,82,82,115,206,12,201,225,225,76,51,156,18,126,196,17,65,223,8,99,152,231,123,17,110,242,108,79,15,5,195,130,230,217,219,55,47,111,223,120,5,167,217,1,237,206,92,144,116,217,142,55,57,35,112,20,126,204,4,21,148,240,110,90,231,77,211,60,147,95,228,183,127,24,57,72,118,180,73,48,231,255,162,157,192,7,242,153,114,145,179,243,142,8,33,129,149,217,207,29,97,20,39,244,63,252,148,144,95,114,226,88,60,37,52,66,71,204,132,156,71,81,9,183,163,189,151,138,161,245,116,71,73,18,75,87,15,140,158,176,32,234,227,81,13,16,35,56,206,179,228,140,184,96,101,208,143,49,217,87,172,155,60,41,210,236,94,238,18,90,33,191,154,242,151,78,200,45,191,163,25,78,32,193,199,44,118,134,239,138,40,34,156,239,11,131,163,155,119,164,250,202,98,194,32,199,125,145,62,17,230,136,111,118,86,200,77,255,32,45,123,123,162,166,167,177,125,40,72,159,171,158,156,198,164,254,208,200,220,235,110,126,242,58,71,206,253,231,125,158,53,73,73,226,95,58,113,149,251,231,93,244,76,82,140,30,137,54,154,134,228,165,183,171,129,205,42,156,240,223,121,153,25,89,70,162,242,174,163,199,2,140,151,245,13,34,89,172,46,17,188,81,210,80,110,97,17,73,119,242,90,85,23,179,190,85,234,146,90,174,229,204,112,8,253,205,81,169,53,158,103,24,173,80,47,44,207,123,29,143,237,129,229,71,194,74,37,42,111,124,46,36,146,196,205,157,175,135,112,247,192,96,181,134,7,136,110,111,171,200,102,112,118,101,108,96,168,147,124,193,153,92,63,11,165,12,196,91,185,83,56,139,200,251,243,247,109,60,211,173,228,120,62,95,142,70,182,235,242,161,10,76,203,143,46,46,125,242,202,176,52,63,174,81,129,100,235,130,131,211,48,70,3,242,23,161,2,38,61,98,167,164,232,231,171,145,118,198,80,165,230,129,136,250,95,30,35,162,96,182,59,227,85,217,41,127,243,206,248,132,147,130,132,155,103,18,253,126,199,14,69,42,211,232,190,72,146,153,15,209,254,92,225,61,131,85,238,83,197,160,177,191,130,216,63,21,52,70,219,24,189,32,25,225,18,241,242,151,197,194,200,188,75,230,48,35,156,172,205,67,113,2,73,181,117,53,237,158,85,119,4,120,73,93,97,205,171,57,117,225,218,43,57,17,218,61,137,19,129,224,5,156,136,253,130,105,166,178,226,170,181,58,156,221,83,158,39,104,203,223,201,68,62,145,17,187,250,57,214,83,84,189,191,107,48,119,27,150,179,75,27,84,75,215,6,169,77,93,2,130,204,5,120,240,229,18,141,94,57,152,145,171,111,188,18,52,77,200,212,22,206,43,98,169,150,182,234,115,216,159,165,206,52,150,61,224,21,220,164,214,121,37,48,195,69,236,88,28,246,130,213,53,24,243,146,14,70,100,115,51,28,86,175,248,117,139,71,187,253,3,129,24,196,151,243,202,86,62,175,43,78,91,146,13,196,101,87,153,129,16,135,61,95,140,214,82,158,95,27,43,144,53,75,146,15,121,188,24,163,189,240,191,54,76,83,68,199,247,212,230,251,98,192,64,107,255,58,96,83,185,231,142,250,214,19,169,235,115,112,68,186,236,222,6,10,180,197,98,129,110,120,145,166,152,157,215,205,196,29,77,18,94,62,20,101,227,192,209,158,229,41,82,213,119,216,98,22,38,232,230,136,25,78,81,38,125,173,124,158,23,44,34,254,90,237,82,120,179,168,62,174,181,253,57,81,38,10,156,160,83,46,159,182,210,225,157,244,162,204,235,42,29,41,146,166,53,145,47,221,170,158,10,31,24,45,125,171,213,253,232,202,179,246,173,107,45,63,17,241,237,124,36,177,102,122,83,62,139,235,153,175,76,155,186,207,172,207,70,25,202,247,88,50,24,152,134,202,168,221,92,152,32,4,16,245,202,58,103,62,19,233,171,42,189,163,174,11,8,103,66,101,15,162,131,69,161,51,19,128,25,132,189,154,113,2,171,137,5,212,122,93,233,204,169,129,252,166,203,241,134,52,254,170,227,129,120,219,217,195,242,116,170,3,128,182,209,247,138,216,169,30,76,2,155,147,94,181,59,213,137,73,96,189,36,215,100,117,31,219,30,244,235,69,145,84,178,136,254,80,241,220,9,102,213,48,114,87,173,84,20,147,180,18,234,164,34,104,116,178,22,234,29,17,218,130,103,190,92,85,32,219,212,122,211,6,140,106,73,12,218,166,97,220,220,212,191,192,236,114,199,225,134,232,5,70,211,235,0,238,41,92,96,111,133,53,225,27,163,171,79,63,208,91,99,135,40,160,152,5,150,110,217,137,164,167,93,193,80,23,237,64,167,203,86,208,107,171,91,33,115,217,92,67,159,130,177,166,219,253,204,160,42,5,195,237,184,59,101,79,134,130,209,94,221,157,184,39,61,193,104,35,63,33,113,251,89,103,41,241,154,255,117,173,229,72,47,225,228,140,254,243,63,172,233,227,193,84,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42688b4c-cf7a-4a15-b9ff-7de341cf3dd5"));
		}

		#endregion

	}

	#endregion

}

