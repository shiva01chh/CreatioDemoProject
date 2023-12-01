﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromEmailDomainValidationRuleSchema

	/// <exclude/>
	public class FromEmailDomainValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromEmailDomainValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromEmailDomainValidationRuleSchema(FromEmailDomainValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5605e8c7-c7fe-4792-915d-0862d66df188");
			Name = "FromEmailDomainValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,203,110,219,48,16,60,43,64,254,97,235,30,34,3,133,116,79,108,247,225,52,169,209,56,45,236,194,215,130,145,86,54,81,138,84,73,202,129,243,248,247,174,72,74,149,221,212,104,117,48,196,213,114,102,118,118,73,75,86,162,169,88,134,240,13,181,102,70,21,54,153,42,89,240,117,173,153,229,74,158,158,60,158,158,68,181,225,114,13,203,157,177,88,94,28,172,41,95,8,204,154,100,147,92,163,68,205,179,63,114,110,184,252,73,65,10,191,214,184,166,84,152,10,102,204,57,192,149,86,229,199,146,113,113,169,232,87,174,152,224,185,99,94,212,2,221,142,52,77,97,100,234,178,100,122,55,9,235,5,86,26,13,74,107,192,110,16,178,6,12,238,185,221,128,166,109,6,84,1,219,14,9,10,165,1,27,14,3,185,99,73,160,197,77,123,192,85,125,39,120,22,192,142,234,130,115,248,192,12,30,138,141,30,157,224,174,198,43,142,34,167,34,191,106,190,101,214,87,19,85,126,1,26,89,174,164,216,193,13,123,216,141,62,49,179,89,162,29,25,171,201,182,201,4,190,59,253,158,220,92,4,92,148,185,135,222,231,161,142,209,190,58,179,74,55,108,174,12,159,113,232,157,11,204,36,183,156,208,31,200,40,6,18,239,129,40,44,147,52,5,228,91,227,231,200,32,153,170,177,24,15,142,250,48,72,39,222,174,164,35,75,15,217,70,21,211,172,4,73,147,54,30,244,139,26,76,28,88,104,137,1,193,141,77,70,169,75,119,187,67,63,142,42,136,95,118,175,207,51,132,102,132,163,104,207,81,24,195,129,193,81,244,124,220,229,57,218,141,250,107,59,61,53,92,98,193,37,122,212,78,248,251,156,0,141,137,67,142,27,197,86,149,70,91,107,233,99,111,147,101,37,184,141,207,222,157,13,147,27,102,236,23,77,120,172,22,54,30,254,167,66,101,233,72,98,126,100,10,130,143,232,79,16,157,165,28,195,41,129,130,132,187,104,87,193,156,101,90,253,107,147,53,102,188,226,116,56,7,147,69,251,218,76,214,93,45,126,120,134,253,54,183,98,65,109,233,18,226,57,194,86,209,92,204,164,69,45,153,104,133,198,179,57,153,200,214,216,129,206,100,161,160,99,107,29,221,50,221,244,182,198,78,61,53,251,26,173,171,97,213,126,232,64,226,14,224,13,204,41,153,58,228,206,147,73,246,171,255,140,59,223,132,136,23,16,31,18,140,65,214,162,107,106,232,170,79,127,238,84,249,73,39,53,71,167,100,31,58,113,138,147,223,226,123,34,90,60,79,14,79,79,240,106,111,200,195,94,42,199,54,203,144,63,236,169,12,149,39,225,74,88,208,159,1,213,142,83,69,77,24,67,204,201,213,224,73,255,83,50,109,46,11,129,249,210,77,141,241,116,183,202,174,232,242,47,56,230,189,194,95,30,89,31,237,7,41,66,207,47,235,123,158,14,144,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5605e8c7-c7fe-4792-915d-0862d66df188"));
		}

		#endregion

	}

	#endregion

}
