﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapSyncJobSchedulerSchema

	/// <exclude/>
	public class ImapSyncJobSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapSyncJobSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapSyncJobSchedulerSchema(ImapSyncJobSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("183063be-c838-4c18-9571-10db5f203784");
			Name = "ImapSyncJobScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,93,111,219,54,20,125,118,129,254,7,78,123,145,129,64,238,246,232,216,6,50,39,41,92,52,75,80,167,235,67,81,20,52,125,109,179,145,72,129,164,146,122,134,255,251,46,41,74,214,151,147,180,93,177,229,33,137,168,195,123,207,253,56,151,148,160,9,232,148,50,32,183,160,20,213,114,101,162,43,202,227,151,47,118,47,95,244,50,205,197,154,172,99,185,160,241,112,56,149,73,34,69,244,86,174,215,184,124,90,190,159,111,181,129,164,249,28,77,101,28,3,51,92,10,29,189,6,1,138,179,3,230,224,109,42,21,28,91,143,46,41,51,82,113,208,71,17,115,182,129,101,22,131,66,4,98,126,85,176,70,143,100,26,83,173,135,100,150,208,116,190,21,236,141,92,148,64,135,27,12,6,100,164,179,36,161,106,59,241,207,179,36,141,33,1,97,168,37,77,228,10,17,0,132,41,88,141,131,89,151,169,96,48,137,10,99,131,138,181,143,231,176,162,89,108,254,224,98,137,156,67,179,77,65,174,194,78,27,253,254,39,220,145,102,139,152,51,194,44,237,78,214,24,75,119,48,189,157,11,232,16,57,230,219,12,201,141,226,247,212,64,254,46,205,31,8,179,239,136,54,202,38,18,205,252,137,213,39,99,18,88,171,214,122,112,122,20,237,29,191,86,50,75,139,109,179,171,179,155,39,182,220,40,201,64,235,166,35,219,98,193,169,39,14,98,153,115,175,7,114,201,33,94,234,35,145,40,160,75,41,226,45,153,97,59,146,207,49,254,26,19,252,247,138,10,186,6,133,13,103,108,159,130,10,3,23,88,255,9,103,87,96,54,178,229,173,217,37,110,1,77,107,162,49,144,141,146,130,255,157,55,203,23,185,32,2,131,140,202,109,131,230,190,81,74,21,77,28,106,28,100,26,20,86,74,228,2,9,38,239,241,217,102,207,47,68,163,129,67,119,111,118,255,131,1,165,131,201,188,65,228,240,174,109,67,129,201,148,208,173,61,37,249,209,160,128,84,115,237,203,137,113,251,38,176,213,12,223,215,34,32,245,128,78,236,254,94,111,118,206,221,35,166,97,148,91,57,33,114,241,5,49,147,10,81,172,156,200,226,184,79,118,110,215,91,174,141,71,79,92,158,189,199,27,170,140,195,194,3,169,98,194,190,107,193,94,19,26,157,45,151,161,95,240,16,190,34,97,197,239,47,117,199,189,156,26,209,216,35,160,46,18,236,81,52,161,176,125,243,221,141,237,209,173,218,98,78,254,162,113,6,97,48,111,109,10,48,214,172,203,90,191,116,216,205,185,189,35,186,149,115,23,108,216,247,145,244,246,238,207,254,120,228,245,130,68,211,76,41,28,109,182,106,209,108,217,54,152,23,222,215,58,122,35,185,8,131,207,24,66,211,118,14,223,63,87,77,110,172,61,34,166,233,6,216,29,193,196,90,63,174,17,225,43,214,86,127,175,142,42,19,187,222,160,56,170,9,199,225,68,5,131,231,171,11,35,175,54,42,43,143,180,227,226,26,177,201,173,202,96,52,96,19,27,87,37,36,114,109,54,160,30,184,182,227,203,129,9,130,87,52,214,14,221,84,95,126,34,44,164,140,201,185,4,237,181,119,97,109,61,33,62,242,93,186,243,50,175,20,28,1,13,209,55,29,29,140,213,219,232,44,77,203,35,42,178,236,75,230,21,243,39,173,67,165,214,92,157,253,242,14,18,121,15,157,243,247,255,58,122,125,33,239,37,95,122,250,62,236,159,88,197,143,159,170,117,44,166,102,249,206,143,159,71,139,219,63,121,6,168,214,1,249,68,58,173,54,147,81,246,106,57,46,198,202,69,146,154,109,14,48,106,91,208,184,167,10,1,148,221,221,122,180,229,234,47,145,231,156,174,133,212,134,51,29,205,75,76,232,68,83,140,194,131,147,226,125,101,188,229,152,61,97,212,176,13,217,145,124,98,174,240,234,72,241,57,236,104,122,46,106,185,43,135,181,189,100,68,23,74,73,117,41,85,66,77,24,228,213,180,51,130,81,28,12,203,33,169,76,89,178,123,181,47,59,220,25,222,253,182,143,136,227,55,36,187,223,247,129,79,112,239,145,73,157,203,164,166,25,23,109,17,122,77,103,37,157,231,136,44,63,58,30,147,218,20,83,100,254,75,169,225,23,131,92,206,196,21,23,25,242,104,235,141,11,108,187,123,26,255,84,197,230,89,120,166,98,145,17,105,208,254,145,155,144,187,111,212,205,145,209,152,188,42,91,210,96,48,15,78,46,103,106,157,217,79,151,235,204,92,175,222,81,177,134,139,175,12,82,235,50,108,101,178,218,1,189,250,72,122,114,192,255,43,167,68,91,74,69,23,231,20,227,237,183,136,170,16,210,183,232,200,19,169,233,167,131,195,227,74,58,105,126,226,116,19,249,32,213,157,251,198,246,52,158,228,217,108,161,86,2,187,175,95,249,106,125,17,215,240,231,31,234,179,89,147,230,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("183063be-c838-4c18-9571-10db5f203784"));
		}

		#endregion

	}

	#endregion

}

