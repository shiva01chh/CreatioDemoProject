﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailUriHelperSchema

	/// <exclude/>
	public class BulkEmailUriHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailUriHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailUriHelperSchema(BulkEmailUriHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("25ee4cc9-8f18-4d53-9302-1f7428dce92f");
			Name = "BulkEmailUriHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("047a9257-bd59-41e6-8705-ec422d051419");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,89,79,28,71,16,126,94,75,254,15,21,44,89,179,242,102,214,207,129,221,8,3,54,200,216,16,142,228,193,178,80,51,83,187,180,232,57,232,238,1,77,44,254,123,170,143,57,119,118,141,99,161,132,151,165,123,234,252,170,190,170,78,89,130,42,103,17,194,5,74,201,84,182,208,225,94,150,46,248,178,144,76,243,44,125,249,226,219,203,23,163,66,241,116,9,231,165,210,152,108,247,206,36,47,4,70,70,88,133,31,48,69,201,163,141,50,231,57,70,156,9,254,55,198,43,114,199,60,189,107,46,15,181,206,47,53,23,92,151,48,171,68,254,194,235,176,245,129,164,73,254,149,196,37,25,135,61,193,148,250,13,222,21,226,246,32,97,92,92,74,126,136,34,71,105,165,166,211,41,236,168,34,73,152,44,231,254,236,62,67,100,20,97,145,73,120,200,228,45,60,112,125,3,164,28,86,90,211,150,90,94,92,11,30,129,210,132,80,228,53,135,60,142,190,89,175,117,112,159,80,223,100,49,133,119,42,249,61,211,232,190,230,238,80,153,251,76,21,249,147,137,2,27,200,224,148,73,133,127,20,40,75,250,143,190,107,148,42,32,71,80,72,62,6,83,160,209,72,162,46,100,218,134,44,108,212,206,181,36,60,3,18,15,237,121,108,48,30,61,14,6,160,172,44,244,220,93,100,109,67,222,247,100,48,218,187,174,102,21,224,61,147,70,231,93,193,69,76,128,207,32,197,7,3,177,191,48,193,185,176,70,141,148,139,150,100,123,54,195,139,204,71,226,85,124,246,43,154,111,218,87,239,37,91,38,152,234,239,39,111,53,40,182,159,72,215,91,202,101,22,161,82,24,87,153,108,196,213,58,233,27,220,110,219,203,36,95,242,148,137,202,92,187,222,151,82,236,99,148,197,216,20,218,1,80,103,62,108,203,164,183,201,210,137,151,115,65,122,27,124,1,193,47,206,80,120,164,62,23,66,156,200,131,36,215,101,208,9,113,92,225,49,234,122,107,157,194,51,204,5,141,160,174,226,196,215,34,180,70,189,211,199,118,177,219,6,223,88,178,94,166,168,34,150,227,62,211,204,35,218,197,191,211,247,175,48,141,29,51,215,209,212,242,220,125,236,143,14,123,113,134,73,118,143,10,242,186,88,176,144,89,2,250,6,45,236,181,226,180,175,185,99,85,32,37,181,217,150,202,10,25,33,37,176,53,55,89,236,76,237,199,97,217,198,213,214,188,233,17,208,25,72,27,204,170,182,67,75,121,211,213,201,246,126,103,142,249,166,112,57,53,166,223,83,66,164,26,248,207,117,172,19,151,181,242,122,95,190,182,80,168,106,238,121,211,106,24,19,196,133,44,247,36,18,233,130,218,24,241,249,56,123,160,33,48,158,152,66,126,228,105,28,238,94,171,76,20,26,39,144,21,218,78,186,186,149,124,3,212,234,237,230,120,2,69,169,253,6,39,106,51,129,108,172,253,153,115,200,212,71,44,85,240,180,56,104,149,32,139,110,160,2,174,70,7,120,58,0,213,168,239,205,213,33,168,37,27,136,134,184,208,27,88,235,231,200,227,134,118,254,128,122,165,149,159,169,141,111,9,200,31,109,224,51,247,107,26,164,29,230,117,9,198,90,8,71,11,251,15,48,122,200,148,192,21,160,153,28,240,43,120,3,254,28,213,125,177,145,14,251,220,202,80,182,59,174,130,213,64,154,27,156,254,13,63,76,112,131,204,48,155,81,162,42,132,110,245,172,219,143,235,163,8,198,207,69,171,126,40,207,194,174,239,147,171,38,144,129,135,176,51,188,105,67,232,112,187,55,193,168,129,23,2,21,201,6,170,2,82,90,33,143,11,194,41,255,30,30,99,186,164,247,222,28,222,54,198,71,125,24,194,221,56,54,182,38,222,231,151,183,95,107,99,14,28,255,211,33,230,32,152,155,72,72,94,58,11,133,136,241,159,172,19,22,199,63,189,75,40,151,246,75,103,152,38,27,136,182,58,38,77,213,90,224,204,136,37,244,242,120,210,64,126,242,50,250,127,172,160,186,253,137,22,214,216,41,227,114,61,66,107,182,74,127,249,152,208,200,119,179,85,200,250,246,176,168,117,218,145,181,55,94,122,112,67,238,10,97,72,28,238,166,101,112,5,179,57,12,63,16,175,198,240,250,117,69,179,171,240,224,174,96,66,5,157,24,39,224,54,217,94,150,208,61,87,68,191,19,25,155,215,222,209,50,37,100,246,152,194,113,83,141,149,237,105,184,218,51,216,77,172,162,238,0,101,127,116,151,246,222,145,238,182,123,105,239,232,239,31,16,134,208,119,111,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25ee4cc9-8f18-4d53-9302-1f7428dce92f"));
		}

		#endregion

	}

	#endregion

}

