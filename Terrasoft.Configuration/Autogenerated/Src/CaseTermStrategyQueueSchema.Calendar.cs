﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermStrategyQueueSchema

	/// <exclude/>
	public class CaseTermStrategyQueueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermStrategyQueueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermStrategyQueueSchema(CaseTermStrategyQueueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cbaf17cd-f74c-41e6-afd1-9a0adcb5d9df");
			Name = "CaseTermStrategyQueue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,109,79,219,48,16,254,92,36,254,131,97,18,74,68,149,242,153,87,161,2,27,210,120,25,101,251,50,77,200,75,174,109,52,199,41,126,41,202,16,255,125,231,216,14,73,154,116,133,47,197,231,231,124,119,207,61,62,135,211,12,228,130,198,64,30,65,8,42,243,169,138,198,57,159,166,51,45,168,74,115,190,189,245,186,189,53,208,50,229,51,50,41,164,130,236,168,90,215,93,178,44,231,221,59,2,250,236,209,37,87,169,74,65,246,2,174,104,172,114,177,14,49,81,54,0,238,127,18,48,195,140,201,152,81,41,15,201,152,74,64,112,54,81,88,9,204,138,111,26,52,148,192,209,104,68,142,165,206,50,42,138,83,183,246,40,242,108,97,22,52,170,161,126,222,45,49,116,154,192,47,92,44,244,111,150,198,36,54,161,250,34,13,94,203,104,85,94,247,34,95,128,48,245,30,146,251,210,223,238,183,211,41,13,223,37,8,18,231,156,67,108,218,16,85,192,122,74,62,13,3,30,87,216,246,210,52,112,48,152,129,58,42,255,89,136,116,137,105,18,233,12,111,46,75,224,137,77,116,77,214,34,87,120,40,36,107,18,119,36,32,222,82,217,151,185,63,202,169,10,187,201,152,77,88,70,37,129,164,65,231,123,21,238,191,65,58,13,158,100,3,114,114,66,184,102,44,244,136,65,123,159,124,6,213,56,53,8,45,39,134,4,243,35,64,105,193,73,211,207,66,222,54,224,234,42,5,150,32,79,142,98,187,233,249,238,173,179,35,154,247,17,64,147,156,179,194,168,62,27,83,22,107,86,222,202,175,249,172,20,62,121,138,87,141,71,235,147,68,101,96,64,109,46,86,75,136,78,77,157,114,14,28,171,111,27,64,91,250,211,141,165,239,78,11,116,210,130,89,210,187,202,67,104,15,27,215,28,167,9,101,233,95,16,81,217,105,180,5,173,232,155,72,254,6,212,60,79,54,212,251,131,149,140,220,76,246,165,197,170,76,158,174,92,149,227,145,223,106,94,145,101,42,148,166,172,95,66,171,186,118,44,47,169,32,32,159,145,51,14,47,164,156,183,197,36,158,67,70,17,39,138,86,171,162,58,224,134,114,58,3,49,36,187,23,168,66,150,114,48,148,219,61,185,235,46,14,150,109,134,178,87,240,45,62,39,24,11,35,70,231,73,130,121,234,140,7,187,198,186,27,70,230,167,225,53,167,60,97,32,186,157,190,216,205,46,63,202,20,8,142,173,95,194,100,109,224,243,119,224,131,102,16,245,37,146,192,148,106,166,186,15,185,176,155,13,63,203,211,123,31,42,2,106,38,123,16,118,166,13,110,145,238,152,52,157,242,167,160,239,234,129,209,85,202,147,160,150,234,144,224,53,6,231,158,114,133,207,133,230,149,14,240,140,3,187,213,171,154,246,116,52,18,233,3,251,73,249,50,79,25,144,160,25,106,167,51,223,177,193,144,189,189,247,178,118,90,3,186,145,0,138,175,188,5,129,183,26,238,30,139,5,184,78,252,160,76,195,177,237,216,105,80,211,78,232,135,120,215,180,56,139,106,131,194,39,108,196,32,77,143,3,83,114,15,160,122,69,188,177,252,174,112,26,249,112,142,195,214,97,31,57,167,126,187,66,247,94,249,154,55,144,76,221,125,184,62,226,196,69,236,185,97,21,211,141,246,239,239,215,94,72,255,132,174,190,105,27,15,221,255,125,26,185,137,27,107,33,0,5,86,49,48,21,121,246,225,225,91,184,111,56,142,229,181,231,175,125,227,220,140,184,128,231,198,100,117,117,6,141,185,235,52,127,74,14,140,238,119,172,107,116,45,111,81,245,119,226,50,91,168,162,229,112,15,240,39,8,163,199,220,82,31,132,97,72,156,84,206,154,95,64,81,149,65,13,77,14,203,27,213,71,112,217,147,186,1,215,248,247,15,77,70,96,194,246,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cbaf17cd-f74c-41e6-afd1-9a0adcb5d9df"));
		}

		#endregion

	}

	#endregion

}
