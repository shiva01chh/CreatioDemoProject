﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegerColumnProcessorSchema

	/// <exclude/>
	public class IntegerColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegerColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegerColumnProcessorSchema(IntegerColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2041887-39e3-41a7-a400-517b34bdbd2a");
			Name = "IntegerColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bdeb1980-c322-4103-af7f-58bfe7162080");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,77,143,218,48,16,61,179,210,254,135,41,189,36,18,74,238,124,85,45,43,42,14,93,161,46,244,82,245,224,77,38,96,41,177,211,177,141,132,208,254,247,142,157,176,75,82,216,203,114,0,123,244,230,205,204,123,99,148,168,208,212,34,67,216,32,145,48,186,176,201,66,171,66,238,28,9,43,181,74,150,178,196,85,85,107,178,247,119,167,251,187,129,51,82,237,224,233,104,44,86,147,215,251,101,54,225,173,120,178,20,153,213,36,209,48,130,49,159,9,119,92,3,22,165,48,102,12,43,101,113,135,180,208,165,171,212,154,116,134,198,104,10,200,52,77,97,42,213,30,73,218,92,103,144,17,22,179,225,163,86,107,36,35,185,23,101,123,105,167,205,79,52,174,180,47,195,116,126,38,48,174,170,4,29,207,247,175,10,164,50,86,40,30,95,23,96,247,210,64,230,91,1,62,16,235,162,149,145,207,37,66,161,9,234,134,216,15,213,246,9,89,168,8,7,81,58,52,201,185,72,122,81,229,247,3,22,130,155,248,38,85,206,153,145,61,214,168,139,104,213,235,53,30,193,35,27,1,51,80,252,227,1,87,149,136,227,63,204,89,187,231,82,102,109,163,215,129,48,134,247,164,97,33,237,151,249,8,250,109,48,249,41,168,253,102,12,43,96,201,121,211,216,159,117,168,220,32,62,108,200,127,142,132,192,130,80,88,52,93,95,88,52,70,34,182,69,174,207,204,172,201,43,109,218,231,157,214,130,68,21,228,157,13,157,241,217,74,97,230,55,124,56,223,154,96,230,57,144,76,211,128,14,201,173,218,215,107,70,219,14,19,116,137,99,182,225,89,24,140,250,97,255,140,6,47,173,210,168,242,70,236,174,242,92,163,70,178,252,84,198,254,108,57,23,243,11,233,251,3,62,8,43,154,77,108,244,114,74,254,229,179,204,217,8,89,72,164,27,226,212,103,110,208,7,126,171,140,135,239,78,230,129,239,151,167,219,48,219,118,149,195,108,222,141,37,173,36,125,224,228,253,185,126,160,221,235,252,198,80,31,218,167,43,147,248,61,247,59,204,119,27,122,140,154,127,178,134,41,68,218,71,28,206,173,51,3,111,90,210,73,187,4,77,2,70,22,16,125,98,254,100,67,199,181,32,211,193,36,225,123,4,218,89,223,67,227,203,82,211,147,56,96,28,135,252,1,161,117,164,64,185,178,108,24,219,192,37,118,114,123,81,154,104,55,200,49,254,252,3,183,244,92,158,211,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2041887-39e3-41a7-a400-517b34bdbd2a"));
		}

		#endregion

	}

	#endregion

}
