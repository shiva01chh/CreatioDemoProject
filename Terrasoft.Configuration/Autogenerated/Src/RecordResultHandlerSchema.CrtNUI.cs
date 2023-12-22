﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordResultHandlerSchema

	/// <exclude/>
	public class RecordResultHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordResultHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordResultHandlerSchema(RecordResultHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3cc9b82-4b8f-420c-906e-b09255f2a307");
			Name = "RecordResultHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,87,91,111,219,54,20,126,246,128,253,7,206,219,131,140,24,194,158,227,166,64,155,184,173,182,58,9,226,228,169,8,2,90,162,29,174,50,233,146,148,91,207,240,127,223,225,77,162,104,58,11,154,7,71,34,207,225,249,206,119,110,20,195,107,34,55,184,36,232,158,8,129,37,95,170,252,146,179,37,93,53,2,43,202,25,218,255,250,203,160,145,148,173,208,124,39,21,89,79,162,119,16,175,107,82,106,89,153,127,36,140,8,90,30,201,124,166,236,91,183,24,154,18,36,181,62,35,82,226,21,172,129,196,122,205,89,39,115,77,190,43,176,164,133,254,146,225,198,170,230,11,92,159,159,91,133,252,51,95,105,125,216,7,137,223,5,89,105,95,46,107,44,229,57,186,35,37,23,213,29,145,77,173,62,97,86,213,68,24,177,77,179,168,105,137,74,45,149,18,66,231,168,72,44,143,253,234,173,224,37,0,39,149,151,223,155,99,99,243,214,57,98,247,190,204,129,48,92,211,127,241,162,38,143,102,69,251,117,179,248,7,56,205,102,100,189,32,162,21,209,36,231,55,27,85,176,145,17,221,8,174,64,140,84,14,179,59,217,219,109,13,127,160,164,174,192,242,173,160,91,172,156,101,208,54,111,136,50,133,158,20,87,184,158,28,175,111,188,79,137,61,249,149,110,54,241,206,199,134,86,232,137,111,136,205,159,191,201,110,226,209,16,86,89,64,17,60,72,56,169,68,83,42,46,52,72,19,5,143,209,134,196,57,150,141,76,58,14,6,135,244,182,70,101,28,25,27,128,45,118,251,234,224,142,45,196,16,161,63,118,96,105,64,23,40,160,99,208,113,0,27,17,31,3,79,2,108,245,232,24,244,40,128,221,136,145,192,137,147,188,64,62,129,146,162,36,102,197,164,136,219,221,101,254,225,26,106,25,12,13,13,246,161,205,16,207,144,246,255,222,248,230,60,93,17,133,246,72,16,213,8,230,163,143,14,118,79,154,189,150,139,45,174,27,226,55,15,175,130,208,178,148,128,209,86,73,26,74,71,112,4,39,140,194,79,64,114,209,73,0,154,187,8,38,225,248,160,70,96,186,168,255,4,148,48,21,34,60,38,53,111,194,204,73,162,234,37,83,4,45,202,187,36,62,103,141,111,161,227,210,138,32,40,63,211,128,249,220,60,180,117,54,112,6,181,59,80,165,32,174,114,223,141,136,235,81,234,153,202,209,203,25,237,214,227,229,94,253,99,166,226,14,229,91,74,169,247,61,198,249,244,250,106,122,167,105,156,65,11,166,87,164,38,138,12,39,47,91,72,54,64,127,188,32,184,226,172,222,161,7,73,4,96,97,118,154,161,167,166,247,62,73,234,20,87,212,236,98,177,123,99,17,142,17,55,196,188,133,148,197,2,66,174,136,144,105,229,100,175,76,200,217,3,209,83,205,203,175,48,86,46,16,35,223,221,98,54,154,244,189,1,38,21,132,182,3,8,147,80,107,174,64,13,30,103,152,65,167,20,48,169,149,30,145,68,100,61,30,71,255,67,228,233,86,237,82,42,49,31,179,136,215,62,173,227,23,41,236,24,244,41,25,69,5,188,74,132,105,16,80,175,155,118,63,14,71,189,57,211,129,24,5,58,95,134,97,13,14,31,39,175,200,226,94,183,246,131,185,31,155,104,210,118,227,59,110,207,166,218,109,5,210,37,202,172,78,62,253,214,224,90,102,21,89,98,96,87,79,187,209,168,173,212,110,118,65,104,109,20,138,74,94,242,134,217,28,25,216,250,12,138,58,156,249,135,192,193,62,172,160,93,35,128,53,65,109,162,233,151,164,74,219,80,79,43,156,34,113,70,212,51,63,89,169,250,240,132,119,142,130,45,22,168,34,27,56,153,48,39,99,37,128,147,63,39,173,136,240,218,58,240,197,148,53,107,136,52,92,190,222,232,36,120,219,207,130,214,146,75,1,27,141,78,66,223,149,21,166,76,66,150,100,195,171,148,241,97,23,162,83,224,76,36,123,118,211,39,61,6,177,242,65,108,189,201,61,25,103,105,18,94,147,194,1,251,188,234,229,175,15,239,150,10,5,73,232,155,49,4,227,61,175,118,241,245,76,211,188,118,119,81,219,172,188,196,189,189,157,221,118,55,179,185,191,149,245,138,210,101,172,115,210,157,149,119,243,105,146,204,87,143,110,203,161,175,222,114,169,188,89,7,87,106,90,224,190,238,94,23,0,189,109,43,208,33,243,130,45,121,246,199,80,107,182,248,161,159,194,208,67,123,171,123,120,218,107,173,195,208,1,52,29,92,238,228,187,106,77,217,3,163,58,156,81,135,202,47,27,33,32,24,186,11,230,133,187,30,22,51,185,186,124,198,32,83,163,210,253,191,64,221,162,111,211,133,153,140,37,201,63,80,86,21,240,41,245,126,247,80,84,89,104,113,212,101,102,123,18,144,222,212,117,119,173,213,206,77,133,224,2,188,243,31,9,94,120,201,5,194,250,48,212,104,252,251,240,236,3,162,210,28,149,123,135,93,72,194,76,212,209,150,116,189,169,201,172,23,243,121,184,214,93,41,10,115,87,14,140,140,237,186,78,36,216,209,244,218,149,131,53,210,59,58,255,4,115,13,120,153,155,104,232,131,204,131,149,116,30,229,189,200,135,218,206,135,147,177,134,179,78,69,250,213,149,115,60,18,123,89,25,125,41,246,74,102,97,25,136,139,202,130,14,157,178,119,160,177,77,224,94,41,36,44,218,41,28,219,117,87,10,95,17,209,246,116,11,9,251,78,172,36,194,240,227,49,234,235,7,180,63,123,11,105,227,217,42,157,157,77,186,145,165,245,242,233,143,146,108,204,148,254,45,202,200,129,43,251,86,231,16,169,250,206,27,15,61,51,169,131,169,119,27,124,21,220,7,31,109,238,188,35,186,143,199,93,20,82,187,218,95,52,107,225,223,127,131,215,132,73,55,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3cc9b82-4b8f-420c-906e-b09255f2a307"));
		}

		#endregion

	}

	#endregion

}

