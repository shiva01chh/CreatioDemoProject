﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateEmailScheduleCloudRequestSchema

	/// <exclude/>
	public class UpdateEmailScheduleCloudRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateEmailScheduleCloudRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateEmailScheduleCloudRequestSchema(UpdateEmailScheduleCloudRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deb86ebb-b3f3-4b2f-84b4-86a9af7d4a21");
			Name = "UpdateEmailScheduleCloudRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,111,218,64,16,61,7,41,255,97,148,28,218,94,204,189,180,149,82,64,81,84,165,66,64,47,169,42,107,177,7,88,213,222,117,247,35,173,131,250,223,59,179,182,41,80,90,176,83,9,9,237,240,222,99,222,206,199,130,18,57,218,66,36,8,115,52,70,88,189,116,209,80,171,165,92,121,35,156,212,42,26,142,103,247,58,197,204,94,246,54,151,189,11,111,165,90,193,172,180,14,243,193,193,57,154,122,229,100,142,209,12,141,20,153,124,10,10,132,34,92,191,223,135,55,214,231,185,48,229,187,250,60,197,194,160,69,229,44,164,194,9,72,180,114,70,36,14,150,218,128,47,40,198,218,152,11,153,189,176,96,147,53,166,62,195,168,81,235,239,200,125,30,145,192,176,230,127,161,64,225,23,153,76,32,201,132,181,240,137,181,112,204,66,179,90,101,152,105,159,78,241,155,71,235,8,190,9,73,94,92,27,92,81,202,48,49,186,64,227,36,218,215,48,9,74,213,239,135,46,66,224,22,201,0,101,108,249,219,173,17,110,38,119,240,21,203,104,203,216,205,180,74,245,30,243,5,154,151,31,233,250,225,45,92,17,250,234,21,167,221,228,109,157,97,239,55,133,252,128,37,108,96,133,110,192,127,48,128,159,109,50,89,112,121,144,110,128,203,2,168,210,191,228,20,34,143,34,243,184,61,206,79,208,127,163,143,25,106,152,49,51,99,98,238,219,203,52,153,123,95,99,230,4,25,171,244,127,185,180,78,24,247,28,159,135,2,109,156,6,238,9,175,51,198,116,119,75,179,40,31,209,148,219,129,160,225,41,109,59,195,39,53,254,237,185,161,199,13,61,102,250,209,14,30,213,208,102,238,70,4,236,230,221,43,73,211,10,50,165,133,33,151,18,13,232,101,184,144,176,32,218,249,15,148,29,169,179,157,7,98,44,15,218,249,214,203,20,194,122,185,123,70,27,167,158,203,224,16,190,175,81,213,41,230,222,58,88,32,36,66,37,152,97,203,249,109,20,207,183,247,163,144,213,222,143,153,183,239,146,240,200,253,11,227,45,138,67,221,13,23,70,106,35,93,201,133,28,183,47,98,67,63,219,93,67,216,183,37,149,163,125,95,103,210,217,11,53,0,183,35,95,207,147,86,24,158,48,122,218,82,154,129,118,174,104,57,80,10,59,74,29,186,180,210,168,54,18,107,252,209,176,245,112,206,3,142,107,250,64,168,227,189,123,77,38,170,87,49,156,41,74,159,94,239,23,43,54,231,138,58,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deb86ebb-b3f3-4b2f-84b4-86a9af7d4a21"));
		}

		#endregion

	}

	#endregion

}
