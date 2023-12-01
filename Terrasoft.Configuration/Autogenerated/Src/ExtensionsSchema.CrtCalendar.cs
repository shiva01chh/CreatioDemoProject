﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExtensionsSchema

	/// <exclude/>
	public class ExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExtensionsSchema(ExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a70d10ae-7bfd-454b-886f-2ca9d01b2a41");
			Name = "Extensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,75,111,219,70,16,62,43,64,254,195,88,1,2,170,182,169,246,84,32,122,0,137,236,22,2,236,56,168,93,248,80,228,176,38,151,50,109,114,169,112,151,177,21,195,255,189,179,239,229,202,114,220,162,189,36,135,132,59,59,243,205,99,231,165,48,82,83,190,38,25,133,11,218,182,132,55,133,72,23,13,43,202,85,215,18,81,54,44,93,144,138,178,156,180,60,61,190,23,148,113,164,241,215,175,30,94,191,26,116,188,100,43,56,223,112,65,235,73,116,70,144,170,162,153,68,224,233,239,148,209,182,204,182,120,78,74,246,5,137,72,126,211,210,21,178,194,162,34,156,195,59,8,85,225,245,120,60,134,41,239,234,154,180,155,185,57,159,175,105,86,22,101,6,212,242,66,77,197,117,147,115,40,154,22,196,102,77,57,148,12,50,99,63,160,151,183,100,69,83,139,55,14,0,215,221,85,133,80,92,160,207,25,100,202,138,208,134,193,131,178,195,217,121,106,52,189,131,79,74,82,223,198,102,42,130,114,158,8,234,13,201,201,134,195,213,198,19,238,40,189,5,12,200,186,66,190,212,33,141,99,168,233,154,180,164,6,134,111,54,27,90,233,225,252,226,218,131,167,211,177,98,122,90,38,71,252,139,178,166,90,70,158,64,224,241,121,33,105,29,95,52,29,19,195,249,199,174,190,162,45,52,133,178,153,131,104,96,101,252,219,6,105,169,232,90,198,29,97,17,6,32,112,51,230,155,210,251,140,174,101,234,64,214,210,98,54,60,182,231,225,252,79,70,174,42,42,245,22,37,203,37,146,53,70,190,117,47,144,211,177,195,81,208,253,55,94,30,179,174,70,195,17,109,186,180,150,29,145,205,220,61,216,165,244,48,17,215,37,7,199,16,177,218,168,31,192,145,137,44,216,16,31,72,149,131,146,9,240,241,27,193,131,163,202,24,156,21,197,146,125,194,210,104,114,152,193,207,19,117,249,213,102,200,12,24,189,131,147,146,139,190,214,100,52,9,81,20,50,50,187,12,144,118,95,216,100,82,183,154,95,86,69,34,209,75,165,12,255,153,6,182,193,62,156,18,113,157,46,104,89,97,137,38,73,142,229,85,147,106,20,27,58,134,95,71,40,188,191,111,189,241,192,55,26,248,6,129,173,97,120,10,56,7,161,35,146,103,98,232,46,124,153,187,199,220,156,185,104,166,239,243,28,69,120,114,131,118,58,167,127,130,114,52,217,129,140,38,135,65,57,82,20,110,152,7,233,111,101,203,197,89,123,68,11,210,85,34,193,248,207,33,79,23,129,118,165,86,155,49,235,153,165,136,78,111,89,64,98,212,237,225,139,117,85,229,189,29,200,244,156,65,18,218,54,210,204,233,162,106,24,77,28,204,32,10,243,254,190,189,121,4,90,113,234,49,77,126,156,21,242,157,119,189,187,101,222,229,232,145,7,216,114,206,220,120,211,156,139,86,32,55,96,61,191,2,183,7,226,186,109,238,84,250,186,210,77,134,255,160,116,135,94,249,227,119,99,41,173,138,195,105,165,144,97,235,81,161,239,241,196,179,114,153,102,210,85,139,163,97,244,223,186,75,169,210,84,183,143,207,246,124,193,129,100,162,35,85,249,141,230,113,195,251,207,251,122,38,203,1,7,120,109,132,84,117,8,60,255,15,227,224,43,169,58,35,161,62,119,247,253,247,62,0,253,217,151,185,221,32,237,119,255,151,183,104,161,186,193,11,155,243,7,194,233,194,134,8,92,176,116,139,222,238,220,32,59,171,242,205,230,180,19,73,255,192,249,207,133,94,141,162,30,229,187,114,208,85,103,94,29,174,65,226,210,221,36,79,214,237,129,214,139,77,238,23,147,131,187,131,96,134,132,195,233,207,45,239,77,48,127,38,145,55,238,133,84,52,113,214,42,208,3,231,146,17,248,1,83,31,83,172,21,90,68,125,62,207,141,118,104,94,252,248,97,242,93,249,29,108,46,40,108,243,221,60,120,144,90,90,191,135,178,210,9,50,192,161,62,141,228,240,224,62,119,191,147,38,64,106,245,88,56,4,88,195,14,239,154,246,86,254,54,168,75,214,9,92,221,113,251,19,170,43,169,49,145,161,75,208,6,197,247,210,156,146,15,48,156,247,87,207,103,223,186,141,42,92,10,71,186,85,125,236,206,131,143,255,194,155,231,242,66,182,20,140,23,194,94,106,212,83,13,106,210,225,217,6,17,188,111,236,152,125,236,222,230,148,5,223,51,29,173,120,131,144,55,10,188,191,69,196,240,91,155,132,92,35,66,120,179,46,193,219,183,176,23,208,211,37,247,158,186,165,98,169,246,96,67,93,50,44,112,108,148,115,25,26,245,197,123,67,125,147,70,140,220,204,243,136,12,119,209,121,6,118,171,179,130,177,247,165,99,245,202,101,121,44,185,244,249,3,21,216,109,89,178,21,106,187,80,200,24,236,69,90,211,227,47,216,54,176,99,27,21,145,145,163,96,179,146,153,128,187,19,189,71,75,189,137,75,73,57,43,146,8,215,45,67,121,211,201,197,203,164,226,57,86,139,255,181,97,182,119,5,236,127,22,40,29,253,37,127,48,8,229,247,3,253,127,149,159,211,19,202,86,248,227,225,162,17,164,50,217,25,175,98,50,7,207,215,132,57,65,205,39,183,114,42,231,228,86,254,72,129,179,66,102,202,97,168,76,154,246,57,61,151,13,199,170,216,97,89,168,224,73,211,76,155,147,222,143,194,240,244,182,191,62,87,152,100,114,158,235,144,75,83,237,242,217,223,22,125,218,244,122,226,27,4,209,255,149,160,206,154,218,39,34,13,255,252,13,30,189,20,105,160,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a70d10ae-7bfd-454b-886f-2ca9d01b2a41"));
		}

		#endregion

	}

	#endregion

}
