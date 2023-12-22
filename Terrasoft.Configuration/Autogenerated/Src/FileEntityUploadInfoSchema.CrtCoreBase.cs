﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileEntityUploadInfoSchema

	/// <exclude/>
	public class FileEntityUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileEntityUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileEntityUploadInfoSchema(FileEntityUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d770075c-2aa0-4a74-8063-064d78bec922");
			Name = "FileEntityUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,77,111,218,64,16,61,19,41,255,97,69,47,137,132,140,122,13,1,137,18,136,44,69,41,42,36,61,47,246,216,108,187,222,181,118,215,74,17,202,127,239,236,7,96,140,129,150,3,194,51,111,222,190,157,121,99,4,45,64,151,52,1,178,4,165,168,150,153,137,38,82,100,44,175,20,53,76,138,104,198,56,188,149,92,210,244,246,102,123,123,211,169,52,19,57,89,108,180,129,98,208,120,198,82,206,33,177,117,58,122,6,1,138,37,39,152,248,251,33,116,56,212,30,19,141,87,218,40,234,235,219,64,63,97,53,46,75,204,96,238,139,130,28,113,100,194,169,214,15,196,214,79,133,97,102,227,197,198,34,147,14,87,86,43,206,18,146,88,88,43,138,60,144,248,112,73,95,215,217,186,218,253,33,115,79,130,157,65,129,85,98,164,210,30,16,216,219,120,239,16,106,229,131,139,47,146,53,20,244,21,219,221,35,207,21,75,73,134,37,113,218,35,1,101,31,93,214,178,118,58,43,41,57,97,122,178,174,196,111,72,61,41,25,146,140,114,141,4,33,59,99,74,27,7,193,20,234,130,123,178,117,229,211,198,145,152,110,170,24,56,224,204,137,176,196,238,199,33,24,170,118,170,124,2,167,91,21,34,164,186,79,212,208,174,79,196,39,66,27,210,119,176,35,197,245,11,120,192,114,83,122,57,86,130,107,182,118,198,176,241,183,157,188,119,80,218,206,100,72,190,186,192,103,24,21,136,212,79,171,117,116,115,37,75,80,134,193,241,224,66,247,191,109,12,252,160,34,199,139,141,136,89,43,249,65,4,124,144,87,105,226,162,228,80,96,247,32,157,254,73,160,180,222,188,187,31,180,145,212,218,179,37,57,152,1,209,246,235,243,8,187,48,10,104,97,157,100,144,244,2,240,137,185,61,160,106,243,232,249,123,68,174,126,225,114,141,200,56,77,153,203,241,57,85,180,208,23,88,130,180,19,67,156,175,112,230,12,190,184,202,187,183,202,121,164,243,106,211,32,87,225,53,163,180,96,251,253,62,121,100,98,141,239,23,147,74,92,110,5,217,176,219,216,226,40,214,47,52,144,116,251,163,211,51,246,217,235,247,196,62,227,180,254,163,139,71,117,255,100,12,215,247,58,254,157,242,234,82,65,10,9,43,40,39,75,105,40,183,87,127,1,145,155,245,181,35,194,142,157,71,49,180,229,110,199,206,245,94,87,69,129,206,28,237,2,49,174,42,21,248,47,34,51,92,31,64,0,64,152,202,133,87,124,228,38,134,179,137,246,196,253,58,115,16,228,80,206,106,109,122,26,123,239,163,199,65,23,171,127,254,2,14,129,249,140,246,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d770075c-2aa0-4a74-8063-064d78bec922"));
		}

		#endregion

	}

	#endregion

}

