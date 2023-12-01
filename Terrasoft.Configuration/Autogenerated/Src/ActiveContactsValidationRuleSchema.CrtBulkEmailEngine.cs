﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationRuleSchema

	/// <exclude/>
	public class ActiveContactsValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationRuleSchema(ActiveContactsValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df11bcd7-a33a-4244-bbc8-b2cfc61e31b4");
			Name = "ActiveContactsValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,143,218,48,16,61,7,105,255,195,40,189,176,42,74,182,87,32,72,43,68,91,36,168,170,101,183,151,170,7,175,51,9,145,130,29,217,14,165,101,249,239,29,219,9,4,40,85,115,72,50,31,126,111,230,205,88,176,13,234,138,113,132,103,84,138,105,153,153,104,42,69,86,228,181,98,166,144,226,174,183,191,235,5,181,46,68,14,83,169,112,116,215,35,59,142,99,24,235,122,179,97,234,215,164,177,159,176,82,168,81,24,13,102,141,192,184,41,182,8,92,10,67,191,176,101,101,145,58,68,80,117,137,81,11,18,119,80,170,250,181,44,56,240,146,105,13,143,238,252,212,31,215,223,142,199,159,232,52,12,97,190,100,69,73,69,173,12,51,120,30,37,164,189,171,50,120,167,48,183,140,132,162,141,30,194,87,85,108,41,221,7,43,111,216,10,181,1,109,148,109,113,81,240,169,172,133,249,34,205,76,200,58,95,47,117,62,149,41,66,2,225,76,41,169,92,180,173,138,130,225,168,161,66,145,122,54,107,117,201,151,104,214,50,181,236,174,61,159,126,41,160,117,4,179,29,242,154,42,234,104,149,73,117,169,100,43,223,181,126,222,83,49,197,54,32,104,176,73,168,173,58,225,228,153,230,225,126,29,222,9,62,26,199,46,251,116,88,161,169,149,208,147,57,105,194,4,173,133,204,168,78,36,118,133,89,18,118,132,166,181,33,225,48,140,39,160,78,147,239,142,25,117,93,26,77,28,45,168,83,221,207,248,26,168,117,97,191,59,89,95,246,61,216,37,12,130,38,98,229,199,157,113,138,216,111,226,179,162,198,63,114,185,110,146,34,45,44,199,146,38,88,2,241,206,69,38,33,113,241,224,124,193,62,99,89,161,138,62,161,57,247,47,252,161,126,195,21,189,104,164,29,16,2,185,5,190,247,92,69,6,253,6,61,90,178,221,145,215,45,11,36,9,60,192,219,27,220,206,24,31,99,206,110,219,109,251,125,49,244,49,5,234,104,33,243,200,173,225,71,169,54,204,244,195,239,255,186,38,81,43,233,143,161,93,108,180,42,115,71,40,164,1,116,251,29,65,8,239,61,91,16,62,110,137,144,189,150,56,132,253,195,97,0,212,108,74,191,31,14,225,224,118,245,131,139,226,189,36,129,31,58,8,252,249,183,97,55,13,6,171,154,115,164,219,158,64,198,74,141,131,198,189,224,191,87,238,66,54,119,239,214,181,244,233,7,79,121,112,239,255,226,61,209,26,85,123,20,15,114,184,190,205,100,59,47,189,232,249,3,227,143,167,113,49,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df11bcd7-a33a-4244-bbc8-b2cfc61e31b4"));
		}

		#endregion

	}

	#endregion

}
