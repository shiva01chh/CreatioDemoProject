﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupProcessedValuesSchema

	/// <exclude/>
	public class LookupProcessedValuesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupProcessedValuesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupProcessedValuesSchema(LookupProcessedValuesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94b93491-ce12-4ffa-a5f9-c6804f9fa194");
			Name = "LookupProcessedValues";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,75,111,219,56,16,62,187,64,255,195,172,187,7,25,48,228,123,98,59,104,147,38,48,54,105,3,59,221,75,17,20,140,52,118,184,213,107,73,202,133,214,240,127,223,17,169,7,245,112,109,23,187,57,36,33,53,243,205,124,243,224,144,17,11,81,38,204,67,120,66,33,152,140,215,202,189,142,163,53,223,164,130,41,30,71,238,45,15,112,17,38,177,80,111,223,236,222,190,25,164,146,71,27,88,101,82,97,120,217,90,147,106,16,160,151,235,73,247,14,35,20,220,235,200,44,211,72,241,16,221,21,125,101,1,255,71,155,169,165,174,227,48,108,174,5,210,138,214,239,4,110,72,20,224,58,96,82,94,192,125,28,127,79,147,71,17,123,40,37,250,127,178,32,69,169,37,147,244,37,224,30,120,185,92,191,24,92,192,162,181,69,203,45,247,81,144,126,206,179,54,119,203,49,240,201,222,163,224,91,166,80,91,24,36,102,81,160,19,239,52,140,12,206,244,134,235,8,48,145,77,165,18,196,97,12,119,41,247,231,115,248,38,80,166,129,146,134,207,224,29,70,190,49,82,172,11,139,148,0,82,76,61,21,139,220,172,38,83,88,53,196,122,41,57,95,36,10,82,141,76,2,32,109,44,71,48,155,67,75,98,214,146,57,226,22,217,75,80,40,142,237,88,76,38,19,152,202,52,12,137,242,188,220,88,26,170,110,37,48,177,37,126,41,124,5,36,49,201,33,6,131,50,156,112,117,5,78,181,152,65,132,63,206,2,118,238,80,253,129,217,104,116,86,0,98,69,81,67,191,44,135,98,217,142,113,107,185,131,13,170,75,216,255,220,208,3,170,215,184,83,114,189,97,38,215,37,4,154,44,32,53,150,202,128,235,110,5,79,115,135,136,58,252,64,18,244,78,194,4,11,181,212,108,232,163,84,60,210,13,57,156,47,26,48,214,39,119,58,209,74,53,134,64,149,138,72,206,239,143,248,49,157,148,146,118,13,152,100,228,76,110,106,35,198,186,201,223,39,82,117,236,13,75,206,118,108,4,186,113,7,91,38,10,31,86,222,43,134,236,203,194,167,170,32,252,37,174,81,96,228,97,181,239,216,234,151,189,218,164,218,76,162,251,209,250,250,192,34,182,65,65,167,157,90,80,215,50,2,255,144,229,192,45,7,44,112,222,162,70,6,236,232,222,242,200,239,176,183,212,37,6,186,210,26,0,38,134,238,66,126,74,131,224,179,248,24,38,42,115,218,134,70,166,109,6,87,13,126,185,235,84,103,121,85,220,112,153,4,44,179,237,22,42,23,29,175,141,67,38,159,61,62,233,207,251,230,89,89,39,154,186,205,201,123,175,157,166,113,41,227,213,78,231,7,215,239,195,93,75,114,255,109,87,203,236,135,151,199,90,164,91,198,32,202,106,0,105,18,157,70,252,239,20,129,134,0,217,90,115,202,234,175,244,205,245,25,13,179,60,238,66,127,207,232,224,245,87,244,153,141,34,173,22,105,151,97,15,122,81,136,124,13,206,111,149,42,213,157,169,184,81,137,92,21,70,41,98,212,246,149,89,209,132,62,208,7,203,174,84,163,21,138,6,45,138,244,196,54,165,75,200,135,76,67,245,56,81,160,219,81,49,255,187,21,137,94,106,39,159,232,221,105,190,141,41,151,239,125,255,212,142,24,195,161,73,86,8,153,121,87,166,162,28,196,185,133,14,184,141,218,80,182,73,245,118,85,158,30,9,73,121,7,129,109,174,247,127,15,26,27,195,114,183,141,97,124,57,216,117,143,45,167,91,45,102,178,18,191,252,69,117,164,105,106,27,183,177,88,177,237,73,115,104,12,182,144,214,182,131,251,223,141,169,158,73,114,100,138,246,227,108,205,157,120,86,93,218,8,69,187,218,45,152,206,76,169,81,190,99,70,16,22,81,215,252,126,138,239,227,31,40,156,145,251,68,99,166,113,130,24,195,180,159,85,22,9,101,12,113,170,64,19,244,59,39,74,68,3,206,62,76,138,109,222,104,67,187,179,136,19,93,164,113,165,232,220,116,122,111,206,15,24,18,207,24,66,243,183,180,152,123,88,108,185,213,213,115,166,29,104,57,101,251,179,38,91,204,123,5,71,251,79,103,13,240,8,90,48,149,122,177,254,154,203,185,52,20,159,41,128,250,127,237,152,5,187,63,126,255,47,89,228,85,106,200,234,209,89,95,134,15,200,55,93,169,139,64,155,237,185,17,23,190,180,78,186,147,30,103,133,73,173,240,245,134,41,70,167,181,18,204,83,207,249,70,245,32,124,9,240,249,164,87,92,133,215,124,177,53,238,233,214,121,171,77,146,206,11,21,99,209,46,195,130,236,112,244,108,197,183,231,124,61,254,42,217,233,155,189,212,215,123,208,49,53,47,145,179,192,156,190,55,72,79,196,245,14,253,252,11,230,170,107,170,192,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94b93491-ce12-4ffa-a5f9-c6804f9fa194"));
		}

		#endregion

	}

	#endregion

}

