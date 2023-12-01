﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueueMessageNotifierSchema

	/// <exclude/>
	public class BaseQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueueMessageNotifierSchema(BaseQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("26232705-edfd-4420-a62d-2624a06495f2");
			Name = "BaseQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,91,79,219,48,20,126,46,18,255,193,235,94,82,9,165,239,244,130,160,219,16,15,48,70,65,60,78,38,57,109,61,18,187,179,157,110,21,234,127,223,241,37,169,147,166,45,172,18,165,62,62,215,239,124,199,54,167,57,168,37,77,128,60,130,148,84,137,153,142,39,130,207,216,188,144,84,51,193,79,79,222,78,79,58,133,98,124,78,166,107,165,33,31,84,235,208,68,194,62,121,252,141,38,90,72,6,10,53,80,231,179,132,57,58,38,147,140,42,117,78,174,168,130,31,5,20,112,11,74,209,57,220,9,205,102,12,164,213,237,247,251,100,168,138,60,167,114,61,246,107,171,76,114,167,77,150,82,36,248,211,132,229,222,50,46,13,251,129,229,178,120,201,88,66,232,139,210,18,243,33,137,137,126,32,120,231,205,38,176,205,86,112,180,44,76,37,152,244,189,245,230,52,154,57,90,65,160,78,102,248,55,84,0,36,145,48,27,117,247,197,236,246,199,46,171,184,242,218,111,186,29,46,169,164,57,225,216,181,81,183,80,32,49,14,135,196,52,170,59,30,246,237,174,85,246,229,238,139,21,61,213,108,73,221,85,143,152,158,119,58,13,165,81,67,205,52,188,179,241,48,1,79,29,82,117,216,238,165,88,130,212,216,252,115,243,91,163,37,164,7,112,187,195,202,136,152,17,189,64,184,10,41,129,235,90,95,91,112,89,150,110,183,205,197,127,134,16,101,181,214,233,27,153,131,30,144,205,59,131,75,200,25,79,141,23,76,129,233,53,81,201,2,114,250,225,28,30,74,63,83,107,223,146,202,187,160,59,198,183,75,78,24,50,142,242,164,170,32,160,92,189,145,199,136,230,185,211,232,126,99,233,107,80,199,48,109,36,22,36,85,33,243,164,89,198,76,157,85,98,68,11,163,68,117,208,135,189,217,74,182,50,138,187,238,200,79,185,35,27,4,5,182,88,180,136,220,40,96,177,100,52,110,243,72,46,46,72,212,38,31,185,19,206,157,126,235,248,26,244,112,215,253,56,234,245,108,78,29,181,63,194,136,172,104,86,192,123,230,237,22,244,66,164,118,216,44,44,110,183,196,104,37,88,74,38,22,216,42,149,232,186,64,161,42,94,126,97,103,111,210,51,98,215,137,224,154,186,181,39,114,10,42,145,108,25,158,15,43,42,253,116,56,114,63,221,164,152,107,157,40,241,215,64,225,150,114,60,132,164,193,226,6,111,146,171,181,25,135,168,101,68,122,49,250,26,84,65,252,73,48,41,147,218,141,50,113,26,70,26,87,106,91,7,21,168,238,110,67,123,14,127,182,221,118,210,168,81,75,89,102,231,178,64,80,165,13,219,204,228,204,105,132,153,37,141,189,105,9,45,238,109,97,118,123,95,182,160,226,110,0,177,221,222,184,2,118,89,19,55,123,88,71,227,172,89,111,239,131,212,169,157,211,45,103,155,165,8,54,177,42,45,50,23,205,35,85,175,225,101,83,222,209,189,193,94,71,158,91,232,202,157,213,137,125,115,4,168,28,116,92,113,211,28,148,214,242,1,84,145,233,221,128,43,38,117,65,51,55,0,54,212,250,153,233,197,22,192,255,10,19,140,129,10,154,92,3,38,192,192,171,166,181,158,31,40,189,10,223,82,158,225,92,131,3,193,8,123,203,216,208,194,172,195,217,13,169,176,7,160,41,50,228,25,94,166,34,121,5,237,193,56,220,225,16,137,208,10,11,44,115,121,20,83,139,98,228,211,191,85,243,201,130,34,101,179,45,173,239,133,42,45,31,197,101,150,69,225,13,126,86,119,253,65,78,31,187,64,125,36,133,220,20,133,38,191,247,61,50,165,109,193,123,159,104,222,65,119,124,211,126,7,182,129,106,110,65,243,100,228,1,45,226,240,109,183,19,197,229,212,29,223,187,52,177,157,21,99,124,190,68,195,95,29,183,60,16,91,6,227,200,44,132,82,31,208,209,210,135,42,185,192,102,36,250,228,209,154,178,12,15,205,234,60,109,27,192,202,191,55,249,222,202,249,141,253,110,229,103,126,156,22,78,90,23,90,25,126,254,1,120,4,63,45,9,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("26232705-edfd-4420-a62d-2624a06495f2"));
		}

		#endregion

	}

	#endregion

}

