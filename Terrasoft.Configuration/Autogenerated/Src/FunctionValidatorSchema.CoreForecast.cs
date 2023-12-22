﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FunctionValidatorSchema

	/// <exclude/>
	public class FunctionValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FunctionValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FunctionValidatorSchema(FunctionValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49542b1b-3711-45f6-a2cc-fa746ff320bf");
			Name = "FunctionValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,75,115,219,54,16,62,43,51,249,15,136,154,3,53,118,233,76,143,181,165,142,235,177,51,154,137,107,79,163,186,135,76,15,48,5,73,156,146,160,2,128,178,21,199,255,189,187,32,0,2,124,72,74,156,250,32,139,224,126,251,248,118,177,88,136,211,156,201,53,77,24,153,49,33,168,44,22,42,190,40,248,34,93,150,130,170,180,224,241,85,33,88,66,165,186,251,229,245,171,167,215,175,6,165,76,249,146,124,220,74,197,242,211,198,51,64,179,140,37,136,147,241,123,198,153,72,147,150,204,135,148,127,174,23,125,179,121,94,112,120,3,239,126,18,108,9,74,200,69,70,165,252,149,92,149,92,43,5,207,164,162,92,73,45,116,114,114,66,206,100,153,231,84,108,39,230,249,86,20,155,116,206,36,89,24,8,73,44,38,182,144,19,15,179,46,239,179,52,33,32,161,224,95,130,230,186,172,13,48,242,150,65,189,240,158,41,233,140,144,69,33,8,72,56,243,177,195,249,86,173,89,13,3,227,66,211,3,176,49,25,126,252,235,122,88,145,112,168,61,186,97,130,46,217,247,216,60,223,44,209,230,249,221,123,99,243,185,162,159,241,121,149,129,93,217,152,242,69,241,13,137,72,65,92,228,212,122,216,151,138,48,7,149,13,164,31,67,176,142,128,242,53,19,42,101,224,205,173,134,237,35,204,121,1,180,9,5,190,204,217,35,124,34,127,121,153,209,221,148,165,64,244,71,196,77,17,54,229,87,21,136,60,145,37,83,167,100,45,210,13,85,140,72,124,120,62,216,147,20,55,195,78,187,198,206,20,4,29,33,47,52,122,95,204,183,187,141,78,47,121,153,67,65,221,103,236,204,115,96,66,126,7,232,11,173,99,214,40,159,203,239,244,224,198,192,95,232,133,40,51,182,135,120,35,250,39,72,18,253,209,99,113,48,208,101,25,110,151,122,191,224,86,19,101,162,10,113,72,161,78,121,170,82,154,165,95,216,28,74,14,247,119,210,231,167,94,89,83,65,115,194,161,131,143,135,139,154,39,57,156,216,2,197,18,147,241,217,137,150,236,1,154,80,235,250,6,120,199,102,9,180,52,104,194,77,26,245,102,205,119,237,88,239,165,182,205,17,209,13,118,112,7,225,207,129,224,115,177,4,101,208,122,163,16,221,129,60,213,64,228,238,64,217,189,105,187,102,106,85,204,49,99,85,182,171,183,54,245,155,34,157,235,84,253,152,136,187,250,202,184,67,190,10,115,67,69,149,84,148,241,172,196,179,226,67,42,85,100,216,112,9,28,87,210,159,218,250,254,169,36,117,113,143,131,130,191,162,88,176,91,56,191,21,62,70,246,221,168,118,1,118,225,146,93,20,37,68,54,214,139,3,16,190,166,143,231,27,154,102,200,135,211,231,4,163,170,22,171,239,163,174,236,28,235,157,22,91,40,168,251,192,248,82,173,140,93,221,126,76,60,218,55,84,29,117,169,169,189,51,80,215,55,198,186,137,197,127,175,152,96,218,33,50,158,84,125,120,182,93,3,15,99,191,229,226,18,14,52,101,206,27,133,99,75,1,51,123,64,224,32,165,189,214,143,125,245,16,174,215,193,155,50,193,151,185,103,103,234,20,122,213,226,80,167,14,99,95,93,62,174,97,46,99,243,75,62,215,230,58,107,140,28,245,169,186,47,138,140,164,210,70,7,90,110,74,117,179,192,154,211,145,122,234,90,150,38,99,47,124,227,217,130,68,59,180,217,160,7,189,17,215,10,201,207,189,155,69,231,107,32,152,42,5,239,33,207,230,181,181,193,219,141,232,135,236,246,96,207,94,172,88,242,175,53,240,71,153,101,17,182,228,98,17,244,177,209,168,166,172,35,99,103,228,157,99,75,173,68,241,64,56,123,32,86,233,229,99,194,214,136,136,222,14,237,26,121,178,86,218,94,62,147,132,114,194,11,69,238,25,201,24,204,97,106,197,56,249,194,68,17,15,71,62,171,105,53,123,162,155,174,10,131,216,170,125,190,211,247,73,160,225,255,10,99,72,142,42,189,131,183,195,165,96,144,83,81,69,245,212,197,54,64,209,153,48,218,206,19,67,175,30,60,43,155,122,42,196,254,129,57,175,142,31,61,218,187,153,101,83,225,43,203,135,141,206,158,201,151,207,207,178,92,175,11,1,219,186,118,73,65,127,220,51,201,153,107,21,176,62,47,120,182,13,38,187,234,6,50,129,107,143,209,140,253,22,91,52,102,30,91,129,149,136,108,101,180,238,101,49,92,153,142,123,94,193,205,70,167,206,92,165,246,159,245,251,104,184,131,203,236,98,11,77,144,72,104,112,233,2,226,170,47,21,54,134,131,199,53,131,196,152,135,147,217,138,133,180,182,71,182,170,139,73,183,48,19,37,156,63,139,221,46,248,160,48,35,186,159,79,93,7,70,55,92,30,34,115,55,244,125,180,41,48,205,52,204,25,254,96,160,40,76,172,81,0,241,123,107,55,163,166,199,122,183,19,42,161,194,224,75,200,198,55,146,138,227,168,55,196,250,247,206,94,94,53,159,15,216,22,194,45,7,131,10,205,100,243,21,182,22,253,58,238,36,89,179,107,163,115,243,19,186,69,124,31,221,161,224,173,237,56,20,124,164,233,78,38,29,117,34,175,169,74,86,76,222,82,5,109,142,135,24,63,31,223,55,250,54,170,166,97,108,111,156,56,57,250,205,214,27,26,116,232,56,155,253,214,152,100,245,209,17,96,160,65,0,43,228,235,215,206,3,135,188,105,40,237,153,41,237,97,99,24,212,73,246,207,55,237,171,65,153,0,155,238,106,205,230,221,169,61,221,73,164,71,116,144,125,119,10,255,206,154,74,220,193,72,210,163,35,231,133,127,209,199,209,102,86,184,189,17,158,171,159,82,51,183,7,144,250,112,104,187,106,86,106,32,50,250,102,42,181,1,68,71,161,193,227,182,182,145,243,179,131,46,195,87,48,107,193,157,151,117,77,86,166,126,106,211,253,113,31,7,63,126,172,43,71,240,187,27,136,113,132,12,32,213,12,15,249,247,164,99,191,121,245,38,187,79,87,199,125,192,93,134,26,58,251,122,105,67,45,124,41,217,168,105,219,119,88,75,96,20,88,229,77,43,93,218,226,203,207,37,4,212,86,18,152,233,201,76,163,15,116,253,250,167,215,252,191,255,0,50,44,7,94,51,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49542b1b-3711-45f6-a2cc-fa746ff320bf"));
		}

		#endregion

	}

	#endregion

}

