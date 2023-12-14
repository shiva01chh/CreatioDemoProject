﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormulaColumnCalculatorSchema

	/// <exclude/>
	public class FormulaColumnCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormulaColumnCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormulaColumnCalculatorSchema(FormulaColumnCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33798c1b-c2b3-469c-b5b4-8a4c497120e5");
			Name = "FormulaColumnCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,75,111,219,56,16,62,171,64,255,3,215,91,96,101,172,33,47,246,24,63,138,54,47,24,219,118,131,38,237,165,45,2,86,162,29,98,101,201,37,169,180,222,192,255,125,103,248,144,72,74,78,246,210,28,146,104,56,156,231,199,153,33,43,186,101,114,71,115,70,110,152,16,84,214,107,149,157,214,213,154,111,26,65,21,175,171,236,162,22,44,167,82,125,252,243,249,179,135,231,207,146,70,242,106,67,174,247,82,177,237,44,250,134,173,101,201,114,220,39,179,75,86,49,193,243,30,207,27,94,125,235,136,190,218,237,182,174,134,87,4,59,70,207,46,104,174,106,193,153,236,41,186,44,235,175,180,228,255,106,63,186,213,141,38,159,156,24,125,217,155,122,179,1,50,172,3,199,116,58,37,115,217,108,183,84,236,151,246,251,148,150,121,83,82,197,36,89,215,98,11,255,146,188,46,155,45,184,232,118,76,163,45,115,201,24,45,101,77,114,193,214,139,209,211,161,205,86,238,127,167,173,22,35,50,69,121,159,206,216,154,54,165,122,205,171,2,236,76,213,126,199,234,117,58,176,97,60,33,239,32,157,100,65,218,53,200,131,146,168,7,205,62,213,86,223,192,126,100,27,127,1,225,187,230,107,201,115,146,151,84,74,18,176,117,98,201,9,25,80,70,30,116,192,146,95,5,219,128,47,68,171,18,13,230,66,158,144,43,45,215,112,196,49,213,132,85,197,21,199,228,64,84,41,169,216,119,194,97,63,173,0,136,245,154,168,59,166,99,104,227,119,196,176,209,116,105,44,207,90,53,211,88,207,124,71,5,221,146,10,28,94,140,26,201,4,216,89,25,132,142,150,55,160,6,105,144,79,71,204,230,83,189,67,11,176,209,57,162,62,253,16,136,35,161,244,49,6,40,73,146,136,105,17,177,33,44,147,131,13,37,171,10,19,205,48,180,23,156,149,5,6,85,240,123,128,161,89,220,153,15,2,65,83,96,163,96,180,168,171,114,79,86,128,103,114,91,194,175,5,129,127,223,210,138,110,152,128,195,168,16,232,76,204,173,55,215,38,80,157,59,203,116,60,243,5,251,41,191,194,144,72,114,171,67,195,20,19,50,96,237,224,161,67,244,158,237,106,201,65,228,158,220,230,17,37,220,119,5,5,162,46,124,254,93,68,25,214,115,125,199,152,242,183,201,144,112,196,58,86,150,129,109,193,119,236,60,6,233,131,226,37,224,20,48,122,187,142,40,1,187,182,199,90,17,234,62,175,154,45,19,244,107,201,230,198,217,165,243,81,206,30,207,250,149,168,129,17,85,157,152,255,115,197,10,151,251,90,233,79,18,161,43,250,124,32,27,176,135,180,80,193,143,67,44,226,120,242,122,132,133,62,21,73,47,169,228,229,75,146,246,169,11,114,138,167,211,20,232,61,66,112,126,84,217,50,213,162,19,172,4,94,41,121,37,54,16,191,74,165,241,217,157,68,190,142,199,227,89,207,179,30,188,122,4,231,81,12,59,227,81,143,58,228,81,44,243,167,120,114,12,248,241,183,243,39,58,15,198,157,152,248,88,126,34,193,63,213,169,232,92,70,159,45,232,66,178,129,92,196,250,24,224,2,214,159,225,143,41,2,230,247,98,73,188,68,120,225,7,27,163,208,162,153,154,148,122,229,181,29,13,86,197,80,228,6,170,138,249,43,35,68,75,31,200,176,216,59,1,168,221,233,178,34,2,59,44,109,98,172,182,159,56,66,12,26,214,43,155,61,130,51,47,46,167,198,206,30,117,32,163,177,72,232,91,227,39,74,233,91,166,238,234,163,29,244,190,230,144,60,122,207,16,34,50,245,131,139,20,152,49,144,238,250,121,136,163,108,85,1,46,148,217,169,67,52,177,236,126,99,119,154,144,141,128,15,237,68,89,32,229,152,198,73,144,103,235,246,10,6,219,165,155,67,241,163,53,236,158,10,114,79,203,70,71,13,113,125,198,53,84,161,201,207,1,223,48,58,78,136,249,235,58,125,2,98,24,205,239,72,138,123,61,153,48,139,13,170,72,248,154,164,222,66,134,64,200,206,191,53,48,235,166,158,129,154,108,42,252,184,221,171,55,27,3,113,12,86,20,6,190,191,216,62,144,247,17,151,189,45,9,12,102,138,87,13,155,89,194,193,254,69,131,97,52,100,130,193,196,104,52,173,10,235,247,101,195,139,1,169,51,111,43,198,23,184,117,152,179,11,46,164,250,91,216,49,59,229,24,0,56,191,220,222,103,180,104,231,100,79,231,184,149,91,176,156,111,105,105,239,6,90,39,168,248,99,230,121,175,213,254,2,86,54,101,25,56,233,239,64,38,99,114,223,105,29,188,87,197,128,123,19,95,111,118,83,95,235,76,167,167,224,81,35,216,170,90,215,0,85,112,157,211,74,89,98,107,186,145,111,126,59,47,238,173,53,241,105,203,90,236,250,54,0,86,141,113,86,100,155,106,178,128,16,180,174,10,6,122,43,237,254,204,211,169,209,135,73,64,81,171,234,82,212,205,46,204,142,3,172,19,128,85,27,99,105,229,186,208,105,149,19,67,59,7,224,168,189,6,69,44,59,115,107,150,245,125,253,125,152,79,47,24,67,135,142,179,46,28,171,10,234,100,69,75,23,23,56,113,169,115,56,58,191,222,224,163,143,176,247,173,43,93,52,18,97,181,179,171,166,180,100,0,55,19,135,94,86,192,106,184,83,178,224,166,34,211,72,135,117,215,37,206,30,80,196,186,131,98,84,220,206,88,9,93,32,40,110,109,63,128,28,124,250,2,19,102,32,140,28,130,99,22,157,22,57,132,167,75,236,133,33,91,207,238,80,73,171,162,133,226,235,189,107,93,1,227,164,103,128,221,122,24,172,206,58,157,3,50,195,204,145,188,75,180,83,243,88,158,123,38,120,229,218,61,39,12,132,229,140,65,95,49,23,100,187,150,246,20,15,85,113,211,233,177,128,91,243,219,195,231,234,158,107,15,111,184,84,166,221,184,211,149,172,186,231,27,215,136,26,1,198,155,254,134,16,13,240,97,211,160,113,234,99,196,65,195,218,114,24,200,3,84,40,212,223,106,70,227,54,120,230,76,75,68,93,190,234,76,159,199,215,123,83,65,23,166,65,154,227,233,36,4,81,208,162,48,8,190,204,113,0,243,54,143,102,149,44,188,178,148,36,10,166,201,174,62,199,156,253,22,174,245,100,215,12,163,151,82,180,144,142,91,216,182,128,61,128,82,133,54,158,255,200,217,78,95,209,216,15,175,17,192,13,61,148,219,242,245,147,63,177,225,157,160,136,184,83,232,102,19,90,61,208,118,2,6,59,218,233,66,104,36,67,185,153,29,225,245,58,110,207,176,96,155,78,30,54,172,80,64,108,176,253,211,13,97,222,12,101,22,135,206,234,35,225,122,250,204,26,119,219,32,14,101,4,95,81,178,115,33,106,145,190,24,233,191,164,104,176,173,182,197,219,23,140,112,51,61,152,124,231,234,78,63,57,145,207,163,135,158,238,151,25,62,191,29,62,143,200,136,252,110,28,127,49,162,21,28,218,226,8,63,204,31,109,71,31,227,70,107,134,61,96,190,17,129,106,179,254,132,62,199,20,43,25,117,200,122,226,125,170,27,175,159,122,245,59,250,148,250,155,180,3,196,255,125,202,235,174,40,163,229,85,119,93,241,95,239,244,30,51,49,200,150,240,182,46,248,154,195,85,197,187,227,116,42,99,238,57,107,97,97,94,34,237,203,242,187,90,173,182,187,146,225,93,145,21,45,118,70,203,249,180,221,17,189,32,198,111,105,221,28,53,176,216,25,231,176,56,120,53,204,78,239,88,254,143,187,180,158,111,119,106,159,98,120,234,117,122,252,42,137,192,238,86,241,180,135,143,122,201,224,68,19,204,95,209,142,97,120,104,42,252,194,159,255,0,247,63,119,250,102,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33798c1b-c2b3-469c-b5b4-8a4c497120e5"));
		}

		#endregion

	}

	#endregion

}

