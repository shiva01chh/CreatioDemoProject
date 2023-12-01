﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordOperationsNotificatorSchema

	/// <exclude/>
	public class RecordOperationsNotificatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordOperationsNotificatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordOperationsNotificatorSchema(RecordOperationsNotificatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6bf47883-2258-4b36-adb5-ae0afbec3862");
			Name = "RecordOperationsNotificator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,219,110,227,54,16,125,246,2,251,15,172,218,7,9,48,228,247,77,108,160,185,86,197,218,9,214,123,121,40,138,130,150,198,14,91,137,116,73,42,169,155,205,191,119,120,209,213,182,226,69,55,200,131,69,206,229,204,153,153,35,113,90,128,218,210,20,200,71,144,146,42,177,214,241,165,224,107,182,41,37,213,76,240,183,111,158,223,190,25,149,138,241,13,89,192,147,22,220,218,252,170,4,63,171,47,150,59,165,161,232,63,99,160,60,135,212,68,81,241,45,112,144,44,221,179,121,207,248,223,205,97,27,68,81,180,83,180,111,36,28,59,143,175,46,142,94,93,115,205,52,3,117,212,224,134,166,90,200,35,22,115,80,138,110,240,172,65,134,86,147,201,132,156,51,254,128,165,233,76,164,36,149,176,158,6,201,7,72,133,204,238,182,224,56,84,11,161,217,154,165,20,195,7,147,25,250,253,118,5,107,90,230,250,130,241,12,99,134,122,183,5,177,14,135,28,163,232,119,116,220,150,171,156,97,158,156,42,69,6,172,201,59,50,20,12,35,61,219,2,70,63,74,216,224,37,185,97,144,103,234,29,185,151,236,145,106,112,151,182,60,85,22,5,149,187,89,115,0,224,11,253,164,64,226,180,112,215,100,44,141,48,174,52,229,41,196,181,245,164,237,191,117,209,137,4,154,9,158,239,72,55,2,249,163,236,60,159,121,140,192,51,7,179,139,25,13,149,150,165,233,154,65,110,169,25,0,30,27,195,35,192,236,201,150,74,90,16,142,43,49,13,186,64,130,217,105,85,159,79,108,12,87,171,107,213,64,23,194,94,245,221,156,17,49,155,55,26,245,56,33,83,178,71,210,104,244,50,204,212,28,244,131,56,173,189,183,160,109,2,146,92,41,178,218,145,84,112,141,139,113,42,111,222,92,5,179,102,251,137,88,87,97,8,203,84,135,37,27,64,130,46,37,87,61,23,139,194,217,87,6,237,25,74,174,121,89,32,171,171,28,206,111,75,150,205,12,116,195,168,74,178,240,61,83,218,159,86,136,42,62,31,169,196,249,83,184,125,72,101,19,35,190,46,182,122,231,124,194,200,146,58,98,107,18,86,238,113,162,22,101,158,223,73,107,23,70,85,184,145,195,230,67,58,191,151,58,145,169,65,45,193,84,133,217,56,60,17,247,16,246,186,26,185,88,70,50,203,130,135,65,146,5,81,124,133,69,48,142,198,213,237,141,20,69,24,160,114,254,156,21,140,127,226,76,7,213,213,23,212,32,8,131,75,135,214,186,39,60,116,225,226,123,67,55,104,132,82,151,131,248,169,242,96,28,232,154,147,22,230,248,250,31,72,75,13,13,77,161,89,93,236,203,116,70,220,47,84,118,237,210,124,166,121,233,91,225,10,136,170,192,125,130,94,94,153,191,194,138,45,16,35,139,100,37,178,29,89,163,164,41,176,98,121,234,36,170,244,1,10,186,192,223,193,204,106,255,142,184,35,123,127,124,8,231,62,185,205,107,17,120,251,67,67,136,250,99,222,19,8,218,187,93,160,215,71,116,50,121,67,127,219,32,169,134,198,83,242,83,240,220,220,189,56,165,184,124,160,124,3,193,171,60,45,145,13,66,107,170,196,35,54,133,146,39,88,17,37,210,191,224,228,133,85,172,216,230,224,209,7,117,245,134,240,39,69,224,17,184,222,231,170,175,148,184,238,118,243,112,93,209,30,245,13,193,164,245,50,119,101,209,51,247,40,88,102,139,88,90,184,62,111,184,108,195,33,29,112,227,3,43,111,147,183,55,187,80,155,57,229,104,141,35,74,230,106,99,232,228,144,251,51,220,9,167,212,110,50,27,227,248,94,40,29,218,104,227,110,214,232,219,244,181,255,18,250,166,143,131,216,240,209,30,3,171,99,207,166,212,151,177,159,181,49,49,143,99,226,70,218,153,153,129,139,220,151,69,245,218,169,233,221,11,215,149,197,36,83,85,100,2,54,228,178,158,72,151,10,23,215,68,72,14,228,68,71,108,101,69,191,81,203,31,122,186,102,212,33,81,55,64,113,222,81,69,76,231,178,48,24,250,62,138,200,215,175,46,46,153,78,247,50,198,11,193,161,39,189,7,53,55,201,176,255,173,23,66,83,110,75,219,189,229,43,210,222,143,95,173,156,211,115,111,250,193,147,132,167,53,95,238,102,233,106,113,53,185,80,103,117,172,206,168,85,111,136,206,153,143,111,116,5,239,205,119,55,178,139,203,174,113,88,36,163,57,251,23,238,86,127,154,87,138,199,21,141,219,73,58,9,226,95,156,100,155,185,176,11,50,216,137,129,0,109,149,115,60,31,146,191,254,60,121,230,247,151,190,183,230,190,45,209,158,6,254,207,101,114,139,243,29,214,200,174,69,61,81,223,115,127,234,160,102,248,141,183,251,44,25,152,200,61,112,102,132,154,61,15,209,181,129,74,80,70,246,81,54,0,29,158,1,197,195,83,252,199,191,255,0,184,126,83,247,57,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6bf47883-2258-4b36-adb5-ae0afbec3862"));
		}

		#endregion

	}

	#endregion

}

