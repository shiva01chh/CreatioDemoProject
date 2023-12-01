﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessageValidatorSchema

	/// <exclude/>
	public class BaseMessageValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessageValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessageValidatorSchema(BaseMessageValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64b8264c-aa5b-4010-95c0-f6c2d5985b5b");
			Name = "BaseMessageValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,223,79,227,56,16,126,238,74,251,63,120,179,251,80,36,148,222,51,208,34,40,176,135,196,47,93,129,125,88,173,78,110,50,109,125,155,216,57,219,41,20,212,255,253,198,142,147,56,105,90,64,58,36,74,109,143,191,249,60,254,102,60,112,154,130,202,104,4,228,30,164,164,74,204,116,56,22,124,198,230,185,164,154,9,254,249,211,235,231,79,189,92,49,62,39,147,149,210,144,30,182,198,104,159,36,16,25,99,21,126,7,14,146,69,27,54,87,140,255,91,79,250,190,210,84,240,238,21,143,69,56,62,159,116,27,73,192,121,92,249,42,97,142,134,100,156,80,165,14,200,41,85,112,13,74,209,57,60,210,132,197,84,11,105,237,6,131,1,57,82,121,154,82,185,26,185,241,88,2,213,160,8,229,49,73,41,199,61,248,157,68,11,202,56,17,51,50,205,147,223,4,82,202,18,178,44,177,84,88,98,13,60,176,44,159,38,44,34,116,170,180,164,145,38,145,33,179,133,75,207,196,181,103,126,75,234,23,12,146,24,185,223,73,182,68,62,150,110,47,43,6,157,32,228,111,14,207,186,61,91,196,163,247,21,120,92,0,187,177,243,114,39,69,6,82,51,176,158,132,198,155,131,184,48,105,199,198,78,92,114,165,41,71,129,96,36,244,2,208,0,128,68,18,102,195,160,121,15,225,131,2,137,183,198,11,45,4,131,17,209,171,12,194,10,217,143,20,158,203,185,38,205,109,237,225,43,153,131,62,36,202,124,172,119,210,212,82,196,121,132,87,119,114,119,73,102,24,157,113,34,242,152,156,219,139,155,128,92,178,232,109,50,151,40,180,147,140,149,246,230,235,123,25,124,7,173,108,132,50,161,20,155,178,132,233,21,209,130,48,174,49,78,121,166,107,69,53,101,180,147,80,165,165,169,16,9,185,84,39,83,33,245,45,119,183,237,69,104,189,251,218,175,65,47,68,252,206,59,183,71,241,100,207,248,76,144,153,20,41,137,167,91,24,219,153,140,74,154,18,142,53,101,24,152,237,54,246,151,113,48,58,245,176,226,163,129,181,171,183,73,208,185,228,170,97,133,30,143,6,229,66,51,36,167,37,178,225,89,13,46,144,222,217,105,255,123,206,98,226,249,222,35,54,207,122,75,42,235,105,50,36,28,158,106,160,126,83,116,123,135,213,150,25,232,104,81,217,253,5,42,79,52,238,174,144,194,11,99,224,124,7,120,212,125,223,249,190,197,233,161,175,159,191,28,143,94,175,176,10,110,159,176,82,154,47,55,24,46,243,247,30,210,44,193,84,63,21,241,202,140,145,211,131,78,205,183,137,166,82,159,225,146,25,140,241,239,92,72,107,114,38,208,15,87,193,126,9,141,27,38,34,151,145,181,196,193,53,196,44,79,221,96,76,211,140,178,57,119,67,204,222,106,69,160,70,185,246,89,76,242,233,63,24,141,26,122,130,194,2,89,146,45,70,246,152,102,120,146,199,12,176,72,76,162,5,222,159,153,65,153,45,153,191,33,195,124,184,7,165,131,2,112,237,130,204,102,253,174,24,151,215,214,43,36,80,7,181,216,181,182,159,215,56,198,247,224,65,155,92,195,130,22,94,137,121,248,131,74,126,33,100,74,117,191,64,8,126,98,78,27,83,99,91,210,10,55,165,243,235,128,120,151,89,139,227,128,188,254,177,38,51,252,166,194,230,245,186,35,232,133,20,79,86,80,231,207,17,100,70,65,206,245,183,255,193,183,231,175,98,81,56,222,85,140,170,39,141,36,34,194,90,241,66,167,9,148,117,199,212,131,180,120,53,222,155,205,73,244,98,111,114,100,62,189,18,102,160,176,186,9,185,53,169,175,118,250,223,150,227,88,244,204,75,143,145,186,138,94,38,118,128,37,47,135,190,91,112,124,252,236,246,14,90,108,176,84,135,228,91,112,213,94,81,225,171,3,88,135,22,54,56,220,14,227,138,197,6,72,171,104,132,63,132,252,109,91,169,16,37,108,147,112,130,21,30,207,232,82,40,112,82,240,148,128,114,234,100,237,21,160,165,161,135,20,54,236,10,226,228,248,184,64,223,92,199,216,141,49,147,114,9,69,228,108,107,70,147,22,185,240,12,102,206,108,31,229,149,168,210,185,75,60,235,255,77,185,185,231,8,26,175,198,7,37,102,55,217,74,244,172,131,209,25,190,156,79,76,47,48,246,145,193,145,171,246,131,180,85,113,143,27,42,35,108,70,184,208,68,229,81,4,16,135,219,84,87,61,182,78,101,229,177,250,85,66,58,126,196,39,187,247,70,199,85,63,189,182,61,220,17,198,137,121,119,77,79,215,217,115,226,169,109,127,97,219,136,247,70,117,129,77,109,130,74,27,221,24,216,10,107,107,240,218,102,141,64,21,237,109,103,43,138,212,205,214,126,231,162,35,81,102,107,103,219,138,26,119,102,13,253,249,115,187,20,120,253,129,190,253,227,106,172,255,197,105,2,43,171,68,181,53,154,205,125,155,229,79,117,6,120,201,164,206,41,118,123,231,60,79,49,103,49,167,143,10,69,142,200,159,54,30,181,196,223,144,166,139,120,171,169,30,182,187,236,227,227,198,182,86,43,95,92,136,215,18,15,253,254,184,189,183,94,106,84,49,199,183,106,161,108,77,101,74,151,39,235,239,117,153,59,149,160,125,149,139,237,212,179,77,4,233,127,217,216,20,94,170,155,60,73,110,177,77,201,244,170,191,87,245,20,109,54,225,73,28,247,55,182,59,108,11,222,209,119,87,104,94,165,108,160,186,237,107,175,97,49,80,91,196,143,1,65,174,237,182,167,27,115,93,5,202,96,61,118,4,171,211,73,184,161,157,142,80,58,199,95,58,145,219,17,45,184,30,111,208,12,31,184,129,239,196,112,155,14,186,207,214,253,95,76,49,219,156,180,115,248,243,31,16,132,26,49,194,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64b8264c-aa5b-4010-95c0-f6c2d5985b5b"));
		}

		#endregion

	}

	#endregion

}
