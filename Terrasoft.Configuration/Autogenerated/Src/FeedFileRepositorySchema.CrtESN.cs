﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeedFileRepositorySchema

	/// <exclude/>
	public class FeedFileRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeedFileRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeedFileRepositorySchema(FeedFileRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("86353532-be37-4ce2-bb23-83d28c6a0dc6");
			Name = "FeedFileRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,75,107,227,48,16,199,207,41,244,59,12,217,139,3,193,190,183,137,203,110,104,74,96,95,108,26,246,184,40,246,56,21,196,146,25,201,45,38,236,119,223,145,148,135,237,164,15,214,55,253,103,230,55,47,89,74,148,104,42,145,33,60,34,145,48,186,176,241,76,171,66,110,106,18,86,106,117,125,181,187,190,26,212,70,170,13,44,27,99,177,188,237,157,227,197,143,147,244,10,37,158,203,45,174,170,173,22,249,101,95,194,215,244,120,46,50,171,73,162,121,63,203,253,242,59,59,177,219,39,194,13,11,48,219,10,99,110,96,142,152,187,10,126,97,165,141,100,90,227,189,170,122,189,149,25,100,206,233,130,15,199,245,98,6,59,31,119,196,207,37,110,115,230,255,36,249,44,44,6,99,21,14,71,224,87,110,26,9,254,20,157,243,237,158,132,42,15,176,255,39,247,142,211,180,159,11,238,238,32,234,107,211,48,156,48,221,38,126,64,59,233,130,210,72,225,11,240,128,141,165,218,57,125,166,77,93,162,178,209,176,54,72,108,80,152,185,177,15,199,176,234,8,163,209,232,157,246,90,84,215,164,223,67,240,72,146,4,38,166,46,75,65,77,122,16,102,132,220,183,1,201,81,66,241,101,213,5,216,166,66,246,68,132,140,176,152,14,207,247,55,76,210,248,136,76,250,204,73,37,72,148,160,248,7,152,246,27,74,91,220,110,107,204,60,86,17,79,18,207,240,200,253,93,58,175,34,234,2,160,155,106,4,55,176,22,6,163,190,188,131,191,111,143,240,27,218,39,157,127,100,122,110,157,6,10,174,234,163,227,224,37,75,219,44,179,39,44,197,106,145,15,211,123,47,128,241,202,105,13,108,235,12,225,12,228,146,186,120,55,18,144,185,227,22,18,233,237,160,181,84,92,217,111,146,22,105,31,154,105,101,57,24,130,9,94,188,237,156,66,104,107,82,38,245,23,56,247,45,115,177,133,166,50,188,15,147,228,224,209,90,153,126,230,215,132,107,131,197,233,145,90,112,144,159,155,147,162,135,90,230,208,155,201,24,188,26,26,28,195,151,86,205,208,110,128,55,233,114,13,66,226,222,191,26,31,83,156,209,15,224,14,203,189,128,131,203,247,34,168,109,209,43,237,239,31,13,166,59,215,236,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86353532-be37-4ce2-bb23-83d28c6a0dc6"));
		}

		#endregion

	}

	#endregion

}

