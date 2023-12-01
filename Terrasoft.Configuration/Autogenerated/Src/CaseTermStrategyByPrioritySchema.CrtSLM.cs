﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermStrategyByPrioritySchema

	/// <exclude/>
	public class CaseTermStrategyByPrioritySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermStrategyByPrioritySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermStrategyByPrioritySchema(CaseTermStrategyByPrioritySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b1c0be72-62da-4bc6-a6d2-aef9ebc51481");
			Name = "CaseTermStrategyByPriority";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,87,75,147,26,55,16,62,227,42,255,7,153,92,160,10,15,247,93,160,42,198,222,13,85,89,103,179,224,220,197,76,3,74,102,36,44,105,72,198,46,255,247,180,94,140,70,44,44,107,46,32,169,31,95,183,186,191,22,156,86,160,246,52,7,178,2,41,169,18,27,157,205,5,223,176,109,45,169,102,130,191,125,243,253,237,155,94,173,24,223,146,101,163,52,84,183,201,26,229,203,18,114,35,172,178,123,224,32,89,222,202,204,69,85,9,30,175,37,116,87,217,39,174,153,102,160,218,237,51,88,178,57,45,129,23,84,94,33,186,252,253,225,211,127,26,184,50,176,34,135,193,194,138,85,240,133,51,77,166,237,94,22,54,211,16,151,160,53,174,148,17,54,136,19,87,141,10,2,168,136,170,191,72,216,226,1,153,151,84,169,27,180,175,0,97,86,75,141,10,176,109,62,52,143,146,9,201,116,99,165,199,227,49,153,168,186,170,168,108,102,126,253,1,85,72,110,212,201,70,72,178,247,242,68,57,19,152,44,162,119,84,147,2,52,26,102,220,172,17,59,49,43,69,214,77,171,65,121,65,20,200,3,203,33,11,206,198,145,183,125,189,46,89,238,125,157,71,74,110,44,166,248,112,18,164,23,28,221,30,104,57,138,244,81,66,25,243,223,109,136,105,70,130,137,143,84,83,39,144,38,193,110,124,6,76,126,225,176,189,207,5,215,20,35,149,54,35,106,15,57,219,32,112,159,145,134,20,104,43,59,154,138,67,236,237,165,208,88,160,193,84,226,190,103,64,246,122,33,19,247,53,43,72,8,123,81,16,119,216,219,130,173,10,252,168,240,235,199,137,218,210,37,122,129,37,243,115,154,143,52,215,47,107,254,240,73,197,170,117,121,237,38,249,142,65,89,96,150,31,67,216,23,82,188,252,185,60,198,25,236,44,22,142,32,46,193,195,230,65,103,117,174,133,188,18,228,2,91,146,209,146,125,195,50,167,132,195,191,132,161,9,202,145,181,196,6,27,1,80,5,176,95,36,108,166,253,243,53,220,31,207,92,1,156,9,207,238,236,169,164,21,225,72,139,211,126,141,141,131,104,185,35,183,254,108,133,158,204,30,201,143,155,217,100,108,53,158,55,64,229,86,57,53,252,85,87,192,181,234,40,180,9,61,143,122,240,165,131,130,116,65,141,200,71,102,127,96,16,19,76,43,146,208,136,136,245,223,120,58,51,78,213,208,150,205,13,89,163,131,65,87,119,232,235,44,189,63,100,57,163,153,173,196,31,214,208,36,22,152,13,134,183,87,212,224,3,232,157,112,69,200,14,168,236,78,247,110,225,74,254,30,180,161,148,192,190,119,82,84,17,147,14,2,58,9,186,150,60,33,98,156,51,250,47,90,214,144,100,103,116,36,115,91,101,42,139,61,204,69,1,35,164,204,13,173,75,61,48,24,134,157,88,2,58,51,5,204,93,24,132,230,123,96,7,84,67,192,126,141,136,75,179,37,92,51,44,112,252,213,21,255,140,23,222,57,178,240,162,51,27,140,13,60,247,120,22,69,136,241,64,165,165,110,204,188,169,238,0,192,167,218,29,123,111,198,22,138,57,44,38,13,171,102,15,133,243,99,93,250,42,152,13,78,241,121,115,167,51,80,71,115,175,215,99,27,130,33,215,85,182,146,205,35,138,193,32,118,142,229,85,183,26,195,16,66,207,224,207,12,24,68,215,181,231,216,206,158,91,132,151,225,51,174,29,246,36,129,30,188,53,51,63,102,16,109,181,233,188,141,11,198,9,10,126,0,169,87,226,129,241,26,71,210,171,139,247,101,114,194,24,148,229,160,128,131,176,194,132,183,97,32,47,17,141,131,169,102,243,83,53,178,193,94,32,202,86,60,14,111,95,242,147,113,80,137,108,160,205,127,212,108,185,19,117,89,144,181,165,167,130,224,195,192,0,66,179,86,201,201,116,249,230,192,164,174,105,121,236,196,54,163,105,227,189,212,166,175,75,168,29,121,23,178,249,228,66,116,175,25,230,31,22,118,226,235,29,83,199,41,117,45,131,43,243,16,233,207,12,187,186,6,179,27,167,164,221,94,70,16,12,190,147,180,251,153,45,176,170,36,94,24,73,223,64,129,51,194,122,208,125,18,57,255,113,219,75,80,200,70,190,241,83,107,129,0,18,218,64,233,228,202,218,198,141,165,166,9,217,133,86,245,55,235,92,199,61,106,0,129,250,234,209,56,218,91,230,59,172,160,63,107,144,233,40,202,98,129,7,202,233,22,228,136,216,1,124,28,185,30,153,231,69,9,212,106,174,78,168,201,112,130,250,154,253,90,120,46,24,244,159,18,217,204,208,119,127,152,25,233,179,70,19,206,184,108,213,10,63,103,81,161,240,181,48,151,137,236,89,152,177,209,23,97,46,83,225,142,197,206,60,242,202,88,16,110,251,100,34,166,227,61,107,31,183,81,221,188,115,157,241,27,85,119,37,221,38,101,107,120,212,60,190,213,19,254,89,196,193,10,113,45,153,34,202,194,129,157,155,83,119,212,11,243,51,12,206,243,215,63,186,116,139,163,120,98,198,229,250,42,220,162,60,60,11,219,236,95,68,125,190,26,70,151,46,245,44,234,211,238,123,158,61,221,110,119,19,247,240,243,63,157,57,81,114,181,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1c0be72-62da-4bc6-a6d2-aef9ebc51481"));
		}

		#endregion

	}

	#endregion

}
