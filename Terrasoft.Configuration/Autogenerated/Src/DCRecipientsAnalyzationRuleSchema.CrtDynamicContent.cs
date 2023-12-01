﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCRecipientsAnalyzationRuleSchema

	/// <exclude/>
	public class DCRecipientsAnalyzationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCRecipientsAnalyzationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCRecipientsAnalyzationRuleSchema(DCRecipientsAnalyzationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7eaca092-814b-49a0-a417-a3c4e5a28a41");
			Name = "DCRecipientsAnalyzationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,77,111,219,70,16,61,51,64,254,195,148,5,2,26,48,40,247,208,139,35,9,80,228,38,61,52,69,96,185,201,121,181,26,73,139,44,119,137,253,176,173,4,249,239,157,253,160,40,49,146,98,157,196,229,236,155,55,111,102,30,21,107,208,182,140,35,60,160,49,204,234,181,171,231,90,173,197,198,27,230,132,86,245,221,78,177,70,112,58,116,168,220,235,87,223,95,191,42,188,21,106,3,139,157,117,216,188,221,63,31,34,24,172,239,222,209,43,122,249,187,193,13,1,193,92,50,107,111,225,110,126,143,92,180,130,192,236,76,49,185,251,22,243,220,123,137,49,124,52,26,193,216,250,166,97,102,55,205,207,115,131,204,161,5,131,86,203,71,52,96,29,177,195,205,14,132,178,142,41,162,191,194,22,213,42,208,160,84,102,159,161,238,16,71,7,144,173,95,74,193,129,7,66,151,248,64,96,187,200,169,238,115,238,68,180,248,30,201,246,197,105,34,98,60,119,218,80,141,159,98,130,20,49,172,39,21,212,135,131,211,208,26,108,153,65,32,66,14,248,150,9,5,74,175,16,158,132,219,106,239,128,129,194,103,7,38,112,90,210,115,56,167,138,215,204,75,215,231,64,4,110,112,61,41,137,52,110,26,42,40,86,210,21,240,142,89,44,71,211,189,100,245,254,230,104,72,111,76,108,88,3,212,120,156,148,60,116,254,217,149,211,153,234,229,214,235,243,9,231,249,2,229,138,18,215,227,81,196,59,13,159,203,232,88,150,211,47,66,74,88,34,53,209,121,163,112,5,98,77,106,244,45,183,45,245,107,45,112,117,132,155,123,122,161,155,213,73,150,144,203,187,134,243,170,193,128,227,85,72,88,20,183,176,164,151,213,30,96,24,5,97,85,138,31,121,80,104,58,211,172,28,15,206,39,163,91,52,78,96,24,27,35,30,233,234,133,185,249,200,158,69,227,27,176,226,91,236,1,83,192,252,138,170,165,150,172,195,44,109,145,234,248,96,180,111,105,21,58,38,103,58,221,166,116,212,84,23,128,123,225,222,107,51,132,72,181,20,27,116,249,95,241,200,12,60,50,233,17,38,16,247,253,216,54,200,28,22,232,28,65,216,250,3,186,207,33,178,202,154,215,255,89,52,244,95,33,15,177,215,9,176,40,127,69,162,188,134,63,111,232,119,245,54,221,72,19,66,220,221,182,166,187,85,164,115,13,221,251,31,47,144,255,35,210,134,173,134,218,31,42,67,228,31,180,99,178,103,86,45,80,18,115,176,218,27,142,179,172,127,110,119,212,197,166,128,9,173,237,19,164,232,234,56,122,32,65,158,40,210,208,43,71,50,73,223,168,122,70,246,106,132,253,90,93,117,175,223,27,221,12,128,174,40,172,42,7,12,203,172,64,226,81,47,226,198,236,254,213,255,104,254,245,111,17,74,200,1,89,193,28,247,215,51,114,239,112,193,153,100,102,76,113,211,28,247,98,17,95,224,123,228,24,65,217,166,149,184,95,182,56,202,201,222,194,20,179,126,217,147,227,211,12,92,114,171,84,133,125,177,65,13,29,145,82,30,196,42,47,37,157,146,187,116,184,7,254,162,233,11,96,196,10,47,185,5,77,76,247,60,107,91,186,197,150,18,31,116,244,160,195,41,233,191,82,177,237,52,46,127,164,174,144,225,237,87,101,113,212,109,248,141,102,138,248,117,48,197,207,24,39,230,245,52,214,225,150,20,150,62,41,124,11,213,0,111,159,135,135,194,194,58,240,152,230,105,139,42,255,29,79,224,230,54,111,112,30,167,108,132,213,121,141,186,13,62,15,59,133,27,120,243,166,207,241,43,111,24,80,8,139,247,179,17,118,74,116,233,51,209,147,119,231,186,89,10,117,254,242,5,119,73,167,199,135,241,140,126,255,3,69,248,56,132,113,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7eaca092-814b-49a0-a417-a3c4e5a28a41"));
		}

		#endregion

	}

	#endregion

}

