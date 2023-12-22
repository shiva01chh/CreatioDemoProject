﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastEditColumnCalculatorSchema

	/// <exclude/>
	public class ForecastEditColumnCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastEditColumnCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastEditColumnCalculatorSchema(ForecastEditColumnCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("708ae3de-3a3f-43e7-b680-88ba2d6188bb");
			Name = "ForecastEditColumnCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,203,110,219,58,16,93,187,64,255,129,112,187,144,129,64,1,238,210,175,34,117,157,92,3,77,144,214,105,187,40,138,128,145,70,50,81,154,82,72,42,133,96,228,223,59,36,245,150,236,6,184,183,89,4,214,112,94,231,112,30,20,116,15,42,165,1,144,59,144,146,170,36,210,254,42,17,17,139,51,73,53,75,132,127,153,72,8,168,210,95,255,121,253,234,240,250,213,40,83,76,196,100,155,43,13,123,255,35,19,143,179,74,24,243,228,129,242,233,116,149,236,247,104,249,49,137,99,20,215,231,205,16,70,99,248,68,194,49,185,191,22,154,105,6,234,168,194,37,13,116,34,157,6,234,188,145,16,35,6,178,226,84,169,41,41,161,172,67,166,87,9,207,246,98,69,121,144,113,138,54,86,255,251,7,136,104,198,245,123,38,66,244,238,233,60,133,36,242,54,165,97,173,62,57,35,55,72,29,89,84,78,145,53,165,149,111,124,211,7,14,206,255,29,58,48,122,147,31,232,61,205,30,56,11,72,96,146,57,153,11,153,146,129,144,232,225,96,179,172,96,93,50,224,33,226,186,149,236,137,106,112,135,169,251,104,120,176,222,63,67,154,40,134,110,114,114,31,116,36,179,35,150,87,50,201,210,21,112,174,110,101,242,196,66,144,228,62,238,201,142,89,111,119,0,186,25,86,181,5,133,221,27,16,161,195,211,246,163,52,214,95,64,36,208,48,17,60,39,27,44,39,114,207,241,223,130,224,207,107,42,104,12,210,191,2,109,234,12,228,252,20,163,75,111,50,107,115,103,175,75,102,166,92,12,131,246,106,138,4,220,53,157,114,231,125,81,32,209,131,128,192,244,8,201,90,159,19,98,250,100,52,234,40,45,58,106,166,136,71,207,195,36,148,89,34,199,41,72,83,242,230,150,19,141,150,16,150,60,21,159,39,110,186,39,88,44,109,102,189,10,32,239,222,17,175,47,93,184,206,113,93,149,27,174,231,71,131,45,61,235,122,36,224,87,147,220,11,25,103,123,16,218,27,183,209,143,207,72,155,159,201,100,50,59,138,108,160,18,7,68,37,186,126,141,58,124,3,242,83,8,251,17,254,42,198,110,191,116,191,75,116,157,54,114,208,186,194,83,184,58,142,255,6,168,78,233,119,62,15,36,6,61,35,85,167,155,143,63,52,194,53,232,93,114,116,214,217,189,144,111,131,29,236,233,167,12,16,255,149,65,24,149,251,98,189,253,228,89,212,196,242,84,54,232,19,149,36,42,73,177,198,200,91,59,87,191,233,186,49,115,54,200,19,21,1,188,207,191,108,66,207,122,173,54,165,51,217,8,83,58,120,58,177,141,62,66,94,205,194,106,199,43,118,72,91,232,27,233,172,202,80,66,228,122,13,21,93,32,140,239,98,32,68,144,128,105,56,133,206,88,106,7,230,76,252,188,131,125,202,13,97,11,242,118,252,253,208,207,229,121,122,168,194,249,78,176,9,127,248,227,58,27,80,143,104,109,106,165,71,186,247,127,81,103,72,155,212,33,119,12,36,149,193,46,111,18,240,111,41,220,224,59,68,121,133,58,102,231,99,133,236,169,204,109,74,5,146,141,186,224,191,104,174,182,192,49,55,67,56,229,10,106,147,77,44,48,129,15,76,33,59,249,87,202,51,80,168,132,141,208,212,81,120,174,153,176,246,245,81,149,156,193,176,166,193,206,99,152,16,54,107,81,99,214,246,34,12,139,27,50,135,190,251,125,75,245,174,72,251,185,145,254,37,227,26,164,50,54,158,249,94,225,6,212,224,164,223,152,222,221,82,137,247,98,84,60,39,196,183,84,74,37,83,137,125,109,248,235,199,140,242,51,188,223,67,243,198,159,109,249,99,239,58,2,107,130,143,135,220,168,155,140,115,119,230,117,221,181,183,192,248,63,122,187,5,201,146,176,242,34,65,103,82,152,82,123,201,142,172,71,67,99,137,159,159,159,147,185,202,246,166,18,150,165,160,92,224,120,187,101,233,19,183,243,200,147,189,116,191,50,61,239,218,206,83,195,59,17,200,253,98,156,86,119,48,94,214,247,225,207,207,237,65,109,227,128,168,229,117,18,178,136,225,92,76,155,202,229,233,192,163,195,100,106,29,171,58,105,111,224,176,246,87,206,180,70,132,213,14,130,159,229,24,55,236,123,38,123,124,207,54,172,10,198,205,187,202,223,136,40,241,198,167,222,61,211,42,27,67,60,182,177,196,97,63,110,180,170,99,211,52,79,247,121,96,122,214,201,84,35,126,213,248,213,152,52,94,236,158,174,227,27,119,133,99,255,219,14,7,158,23,152,254,10,106,151,91,208,216,153,177,154,151,175,239,66,128,207,62,236,219,171,210,93,17,130,69,196,235,134,64,181,245,62,213,185,55,41,137,124,57,39,55,137,203,152,0,30,87,20,68,73,38,42,110,202,146,174,145,23,141,95,97,182,125,137,64,59,203,217,96,180,162,147,164,25,68,71,39,227,0,180,147,217,244,151,169,155,249,253,149,234,150,105,107,83,185,117,84,42,161,149,153,0,213,190,66,238,184,91,14,195,171,170,166,252,237,31,56,191,52,236,146,67,47,34,206,214,12,223,44,147,103,119,37,138,232,132,24,63,69,15,149,247,209,127,218,249,159,107,173,250,212,65,60,179,251,110,80,161,238,254,146,91,87,109,53,1,189,20,91,19,255,229,136,155,157,23,49,193,48,179,170,188,134,239,115,120,110,58,105,91,104,101,205,191,223,188,124,116,180,23,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("708ae3de-3a3f-43e7-b680-88ba2d6188bb"));
		}

		#endregion

	}

	#endregion

}

