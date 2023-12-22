﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SynchronizationControllerManagerSchema

	/// <exclude/>
	public class SynchronizationControllerManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SynchronizationControllerManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SynchronizationControllerManagerSchema(SynchronizationControllerManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af354f5d-2f09-4bd9-b70f-5f73c0e5e4af");
			Name = "SynchronizationControllerManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,223,111,219,54,16,126,118,128,252,15,87,245,69,6,12,233,61,145,61,4,174,91,24,69,218,98,77,55,96,195,30,24,234,108,179,144,40,131,164,220,122,65,254,247,29,73,89,162,20,43,193,54,244,165,70,96,71,199,251,249,221,125,71,129,100,37,234,61,227,8,119,168,20,211,213,198,36,203,74,110,196,182,86,204,136,74,94,94,60,92,94,76,106,45,228,22,62,31,181,193,242,122,240,76,250,69,129,220,42,235,228,29,74,84,130,119,58,161,91,133,99,242,100,37,141,48,2,117,114,163,143,146,127,220,163,143,174,255,181,65,178,150,6,213,134,42,26,183,125,203,184,169,148,240,26,244,247,90,225,150,108,97,89,48,173,175,168,44,201,119,170,146,226,111,231,146,224,48,202,150,168,110,153,100,91,84,151,23,100,147,166,41,100,186,46,75,166,142,139,230,217,217,131,54,76,25,250,233,123,1,159,73,166,17,129,43,220,204,163,245,104,156,40,93,128,40,247,5,150,40,77,83,214,41,100,26,196,220,215,247,133,224,192,93,216,151,178,134,43,88,59,208,142,171,3,185,237,195,70,206,30,92,89,45,22,183,104,118,85,78,104,124,82,149,161,238,98,238,207,135,117,59,193,175,104,106,37,53,40,44,24,105,2,186,56,112,91,229,98,35,48,255,40,129,87,69,93,74,56,176,162,198,164,213,207,248,226,13,25,220,137,18,147,47,134,127,168,190,101,41,167,218,55,99,166,32,43,3,140,254,21,236,190,192,164,77,40,29,102,148,237,153,98,37,216,241,158,71,181,70,69,120,72,63,164,209,34,104,194,151,254,145,5,94,82,3,37,199,36,75,157,143,243,46,153,218,214,182,59,58,90,44,119,76,110,187,162,135,125,71,139,182,126,234,77,121,12,22,99,32,101,233,73,195,154,236,79,93,128,19,96,240,14,77,103,187,116,166,191,89,203,184,95,19,244,171,159,185,65,25,29,132,27,181,213,208,22,55,5,75,254,201,132,26,18,191,106,165,158,123,199,32,164,182,59,195,48,130,238,61,30,227,168,75,43,154,158,92,76,124,53,48,232,247,181,59,124,116,223,7,166,160,236,208,152,67,124,82,158,62,23,251,207,48,222,95,222,97,19,172,243,150,188,23,50,135,249,188,141,111,159,109,14,240,75,24,243,10,236,217,31,149,196,181,220,84,182,170,3,42,99,101,119,21,41,199,157,234,108,128,107,178,172,149,162,12,45,248,201,201,201,212,101,243,248,12,115,150,10,41,33,13,110,56,144,54,151,182,83,208,172,83,216,84,234,201,60,241,150,216,26,240,59,242,218,69,255,25,152,240,233,127,98,48,198,152,131,80,166,102,5,188,17,206,35,129,147,105,163,104,27,207,160,186,255,74,58,11,203,165,193,254,116,201,232,31,192,165,102,52,37,126,123,46,161,134,52,15,16,121,247,235,60,154,193,144,5,235,28,30,103,3,197,207,124,135,37,251,64,64,158,49,232,14,67,195,128,62,179,241,173,50,44,61,40,44,240,101,1,185,241,19,52,131,88,72,19,80,215,203,67,237,6,93,67,247,241,160,192,222,73,104,18,50,255,76,133,225,49,248,181,242,24,146,240,53,202,220,223,112,99,215,157,187,83,159,97,108,120,131,143,182,62,89,185,169,68,162,209,121,102,54,87,247,161,18,57,52,186,47,205,218,127,217,217,131,29,69,205,93,235,183,180,113,106,133,43,105,175,208,60,142,86,223,185,227,237,146,21,4,14,83,191,11,130,162,54,132,8,203,153,97,79,86,248,112,101,15,200,233,178,161,221,253,34,53,186,201,184,110,125,5,107,112,62,78,202,33,50,103,50,240,155,119,66,203,3,25,223,65,108,157,119,91,195,49,64,200,115,134,73,247,226,212,66,57,233,91,83,106,238,77,207,191,70,30,45,170,217,248,203,220,34,238,199,109,50,155,116,210,211,176,60,169,171,67,99,26,128,126,126,146,189,180,47,116,178,224,243,15,195,150,245,134,238,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af354f5d-2f09-4bd9-b70f-5f73c0e5e4af"));
		}

		#endregion

	}

	#endregion

}

