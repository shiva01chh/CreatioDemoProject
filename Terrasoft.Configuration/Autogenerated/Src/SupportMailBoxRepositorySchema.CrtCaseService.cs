﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupportMailBoxRepositorySchema

	/// <exclude/>
	public class SupportMailBoxRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupportMailBoxRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupportMailBoxRepositorySchema(SupportMailBoxRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45ce99dc-bbf7-4b2f-be72-31b2e29b841f");
			Name = "SupportMailBoxRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,77,111,219,48,12,61,59,64,255,3,225,93,18,160,176,239,109,26,160,11,146,34,64,51,116,117,215,29,7,197,102,18,1,182,228,234,35,173,87,236,191,143,178,156,196,118,155,174,216,201,16,245,244,72,62,62,201,130,21,168,75,150,34,60,160,82,76,203,181,137,166,82,172,249,198,42,102,184,20,103,131,215,179,65,96,53,23,27,72,42,109,176,184,236,173,9,159,231,152,58,176,142,110,80,160,226,233,27,204,45,23,79,199,96,59,151,194,83,241,104,38,12,55,28,117,159,45,65,99,104,165,225,170,127,162,83,122,68,232,61,148,40,136,228,139,194,13,109,192,52,103,90,95,64,98,203,82,42,179,100,60,255,42,95,238,177,148,154,27,169,170,26,27,199,49,140,181,45,10,166,170,73,179,190,83,114,199,51,212,32,87,134,113,225,42,146,107,208,158,6,10,226,89,201,23,212,209,254,120,220,58,95,218,85,206,83,72,93,234,147,153,225,2,22,167,171,10,94,235,202,14,109,204,57,230,25,245,113,167,248,142,25,244,155,165,95,128,66,150,73,145,87,240,67,163,34,93,132,31,17,252,178,157,245,101,67,137,34,243,172,221,20,4,212,70,217,148,10,112,137,234,30,60,162,175,79,29,88,8,26,24,203,249,111,4,129,207,192,233,48,19,100,46,82,105,172,17,33,85,184,190,10,79,117,24,198,147,232,64,29,247,185,199,37,83,172,0,65,142,189,10,187,77,132,19,215,36,164,135,64,52,142,107,116,125,184,81,254,84,214,97,79,160,46,245,8,156,255,131,160,39,27,89,239,141,142,65,240,231,99,49,151,104,182,50,251,140,142,55,104,244,91,95,193,51,55,91,200,153,216,88,182,193,143,164,82,104,172,18,122,146,252,131,98,28,239,145,45,161,22,51,97,11,84,108,149,227,184,190,130,213,196,21,180,220,115,12,247,154,236,152,2,212,79,164,133,27,182,135,38,233,22,11,246,221,34,9,219,211,44,106,35,150,76,80,1,234,28,194,134,119,46,213,66,164,116,187,132,185,39,185,200,117,245,37,14,71,181,178,1,229,137,174,179,140,222,26,91,136,97,56,37,139,111,156,101,222,223,110,56,147,74,164,251,23,32,106,98,223,200,63,225,40,114,31,42,60,108,71,63,79,133,90,83,245,183,123,25,23,89,155,177,187,73,123,71,222,57,207,13,42,237,248,135,110,61,165,91,106,208,71,127,210,100,238,156,105,209,65,134,62,56,149,5,25,153,107,41,30,170,146,94,196,39,203,242,243,154,46,120,183,178,132,172,55,115,211,214,143,156,61,108,185,190,78,83,105,133,9,207,129,174,49,142,26,185,252,212,221,240,232,197,54,126,46,199,103,188,63,184,81,219,220,159,246,43,172,149,44,64,215,47,54,104,95,224,127,120,246,125,143,146,61,220,235,123,180,229,156,146,117,254,14,7,151,54,189,118,127,29,174,237,71,150,91,28,123,166,73,191,103,50,102,83,72,130,106,199,83,172,85,37,25,61,62,154,21,165,169,70,31,220,122,31,237,6,41,54,24,252,5,255,36,248,61,115,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45ce99dc-bbf7-4b2f-be72-31b2e29b841f"));
		}

		#endregion

	}

	#endregion

}

