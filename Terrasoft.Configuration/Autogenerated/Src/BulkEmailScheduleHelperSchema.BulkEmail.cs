﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailScheduleHelperSchema

	/// <exclude/>
	public class BulkEmailScheduleHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailScheduleHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailScheduleHelperSchema(BulkEmailScheduleHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8ac6184-3c79-4854-84a1-2432be668ae9");
			Name = "BulkEmailScheduleHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("46753b0a-c766-4331-8bea-51b5327e67bb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,87,109,111,219,54,16,254,236,2,253,15,156,250,69,198,60,25,251,90,199,6,226,216,205,220,37,67,26,39,205,135,97,8,104,235,108,179,149,40,135,47,73,189,33,255,125,71,145,212,155,37,103,11,2,88,34,239,142,119,207,221,61,71,113,154,130,220,211,53,144,59,16,130,202,108,163,162,139,140,111,216,86,11,170,88,198,223,191,251,231,253,187,158,150,140,111,201,242,32,21,164,163,198,59,202,39,9,172,141,176,140,46,129,131,96,235,35,153,25,85,244,104,241,138,241,167,114,241,139,166,66,253,93,190,87,29,74,211,140,183,239,8,232,90,175,199,209,41,53,155,118,110,205,185,98,138,129,236,20,88,174,119,16,235,4,4,74,160,204,112,56,36,103,82,167,41,21,135,137,123,255,13,146,61,8,178,78,168,148,68,101,228,37,19,223,201,11,83,59,34,157,114,76,82,202,18,180,46,35,111,99,88,49,178,215,171,132,173,157,129,169,78,190,207,141,184,63,217,154,71,49,147,165,222,7,1,91,140,149,96,228,82,201,143,228,70,176,103,170,32,119,174,183,183,47,100,109,54,137,84,194,4,244,57,91,93,138,76,239,255,192,58,32,99,18,92,91,87,130,209,9,157,37,240,248,70,100,107,144,210,171,153,165,194,55,183,215,110,131,113,69,238,4,219,110,65,216,64,20,102,29,171,3,150,59,182,81,104,235,87,167,246,1,77,218,112,220,123,53,54,161,215,42,19,38,194,28,29,43,209,132,63,95,168,136,71,133,208,176,41,117,182,167,130,166,132,99,56,227,64,75,16,168,198,109,77,7,147,5,90,160,28,91,36,219,16,179,103,34,113,155,209,217,48,215,108,55,68,247,123,116,46,47,191,123,145,4,147,249,15,5,130,211,132,208,24,67,195,116,162,65,181,3,50,189,185,206,56,194,14,164,162,81,51,237,138,160,35,253,225,125,205,99,82,15,96,224,243,86,119,167,79,242,146,233,53,116,199,13,237,81,46,116,94,83,69,161,186,173,92,232,245,116,222,176,42,208,85,211,78,29,117,217,112,164,241,106,157,221,130,178,14,73,247,240,90,183,225,34,109,184,123,90,183,203,225,107,80,187,44,238,242,214,157,116,9,10,91,200,180,65,120,169,89,76,192,80,198,97,17,123,116,5,40,45,120,163,65,30,3,242,115,33,25,221,101,203,220,86,216,143,110,97,159,32,23,135,193,47,193,128,4,143,65,255,68,140,246,228,249,15,88,107,172,237,220,3,127,168,147,248,86,223,198,172,213,49,141,46,180,16,232,134,89,141,140,132,133,135,109,72,120,66,112,17,147,159,198,100,74,37,88,150,137,44,153,155,189,50,236,222,51,21,68,130,25,11,95,52,136,3,158,205,225,5,153,195,172,52,172,247,173,70,207,204,17,157,242,48,48,174,4,197,234,39,145,165,97,128,135,156,199,41,227,247,156,169,114,239,97,7,2,209,90,196,126,41,90,200,249,147,166,73,104,109,69,55,166,131,0,187,46,236,114,184,79,168,116,126,217,240,29,211,135,179,169,7,143,196,5,142,199,24,206,185,212,2,102,211,114,41,236,23,40,120,91,11,51,254,110,129,198,72,30,194,254,140,171,240,68,214,62,88,145,176,60,175,98,42,207,139,85,142,140,92,245,152,94,239,56,215,78,20,203,196,98,241,149,38,26,206,108,105,76,60,200,35,111,224,213,61,184,95,251,243,90,45,225,198,9,109,149,249,156,97,7,120,106,90,164,41,196,12,151,177,74,195,178,34,141,238,128,180,246,74,103,217,182,149,186,245,124,198,114,200,145,202,93,100,3,146,173,190,33,172,19,178,247,169,151,174,248,186,101,189,181,82,37,58,143,227,48,168,211,8,182,100,125,161,67,171,104,115,44,203,65,91,155,247,11,78,45,238,15,209,17,106,110,136,26,240,10,212,170,195,122,208,28,195,3,155,185,70,121,62,224,117,35,191,223,69,86,169,1,238,160,2,83,43,217,216,148,154,209,220,58,180,45,233,173,202,136,7,249,128,143,233,65,94,100,154,43,159,90,67,7,71,9,249,29,14,121,81,222,80,38,154,41,249,243,47,95,220,111,73,134,193,45,172,51,17,231,104,87,60,233,15,254,171,254,204,123,139,6,74,207,109,7,216,84,185,91,209,108,117,175,240,193,204,48,223,177,75,4,18,108,26,98,228,129,6,181,33,137,43,185,127,236,198,47,120,51,1,139,57,215,41,8,186,74,224,204,128,61,49,221,80,148,152,52,236,104,10,1,105,68,151,3,192,192,13,242,201,225,156,95,99,15,166,194,82,154,211,77,147,222,171,2,215,148,83,116,19,61,255,250,82,94,55,240,132,7,138,129,227,205,208,85,47,154,143,62,103,140,223,178,237,78,97,60,202,52,234,209,213,58,202,207,43,228,174,224,25,146,104,198,164,9,39,30,85,187,30,227,53,55,50,203,85,174,239,205,25,216,82,126,46,24,154,175,204,41,235,117,249,241,97,91,13,115,227,52,17,167,166,72,115,242,88,67,87,76,42,135,45,222,202,116,162,42,54,45,130,165,132,167,138,13,198,71,215,59,18,218,35,92,155,99,241,23,94,20,236,92,227,58,227,91,254,104,220,187,59,236,33,174,178,179,61,226,8,10,79,211,77,239,114,190,41,88,116,116,204,217,77,133,255,119,237,121,235,106,237,57,75,230,109,71,192,84,10,217,96,65,226,104,227,49,121,50,37,105,62,121,240,77,117,220,189,221,189,182,54,56,222,42,238,227,142,168,116,189,180,227,162,211,70,35,123,245,220,96,246,170,166,138,12,214,167,87,49,144,242,65,212,128,191,183,192,141,25,40,3,197,183,226,105,76,28,131,20,132,95,18,201,39,198,227,78,150,247,86,205,236,47,205,225,253,139,235,36,41,231,63,126,144,96,111,106,215,24,126,136,159,160,109,239,245,224,196,183,152,63,187,117,160,23,222,182,149,95,75,133,153,53,252,175,254,253,11,84,138,191,209,123,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8ac6184-3c79-4854-84a1-2432be668ae9"));
		}

		#endregion

	}

	#endregion

}

