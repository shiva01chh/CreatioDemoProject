﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationServiceSchema

	/// <exclude/>
	public class TermCalculationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationServiceSchema(TermCalculationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a10a692-749d-4236-a578-c1816f7dfa6e");
			Name = "TermCalculationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,91,111,26,57,20,126,38,82,254,131,151,188,12,18,50,239,205,69,162,172,26,177,106,182,8,88,85,218,168,15,102,230,64,102,59,99,207,218,30,86,108,149,255,222,99,123,204,216,192,132,164,111,45,15,100,124,124,252,157,251,199,56,181,202,249,134,44,118,74,67,121,125,121,81,7,75,122,95,136,21,43,242,255,153,206,5,63,220,156,215,92,231,37,208,5,200,188,83,9,55,183,121,10,15,34,131,226,165,61,58,78,117,190,61,11,65,63,195,234,112,63,20,45,65,74,166,196,90,211,137,144,208,33,166,31,88,170,133,204,65,157,84,224,235,124,83,203,216,149,118,31,173,161,78,89,218,205,203,11,206,74,80,21,75,161,11,130,162,188,156,176,34,173,11,187,110,162,185,188,248,118,121,209,187,146,176,65,25,153,20,76,169,119,164,75,181,55,26,141,200,141,170,203,146,201,221,93,179,190,50,31,247,109,255,250,199,248,129,28,203,61,222,40,0,124,108,108,161,235,90,98,118,190,24,217,88,85,127,130,198,96,43,116,103,149,23,185,222,205,225,223,58,151,80,2,215,42,9,23,166,58,228,150,156,57,98,180,104,35,200,6,198,72,85,175,138,60,37,169,73,64,71,252,239,200,123,166,160,77,134,73,220,62,115,15,160,159,68,134,185,155,89,32,179,117,152,44,43,152,8,236,86,69,36,96,112,230,156,233,92,194,120,70,24,81,162,168,91,153,22,164,223,216,154,98,119,245,135,251,229,12,143,154,229,76,230,216,60,122,215,167,116,111,110,116,104,239,166,98,146,149,196,180,199,109,95,98,196,160,116,255,110,238,30,200,90,72,162,210,39,200,234,2,50,146,1,203,138,156,131,162,55,35,123,172,69,145,160,107,201,213,221,152,19,177,250,7,82,77,244,19,211,36,197,50,177,156,43,92,193,137,152,162,136,16,212,163,24,216,199,79,21,184,206,12,107,221,123,196,190,158,242,173,248,10,137,75,41,22,179,63,251,180,88,98,196,239,69,182,91,232,93,97,10,140,106,15,160,20,219,192,94,74,63,75,86,85,144,13,73,19,222,7,33,75,116,50,84,118,34,250,135,18,124,104,204,245,230,56,53,130,43,120,89,215,182,136,239,145,166,12,166,73,252,105,114,15,58,16,39,145,138,75,117,147,251,1,177,109,211,219,50,73,106,5,18,131,231,224,210,118,75,254,138,4,215,123,69,29,244,35,86,236,214,205,169,99,143,29,69,219,55,203,72,99,186,156,126,108,92,184,75,44,74,175,199,225,63,108,62,174,180,172,205,177,177,220,212,102,20,146,126,236,5,166,57,22,12,134,231,0,84,219,150,211,12,207,55,145,210,69,40,127,53,140,105,246,83,48,78,126,30,166,106,166,34,194,152,237,133,3,119,126,224,146,251,59,211,176,52,221,106,166,24,177,108,63,90,193,45,241,123,116,198,164,130,196,67,205,15,52,143,145,220,20,52,40,113,233,168,127,52,120,49,206,144,56,207,14,184,199,198,200,144,50,208,112,11,60,193,193,42,185,114,4,127,232,129,159,186,31,244,160,211,129,69,128,123,202,1,55,221,196,84,230,212,136,184,190,239,205,227,252,132,233,106,106,187,136,253,15,195,177,10,207,214,220,179,249,58,71,179,142,150,74,164,40,243,227,105,121,105,5,72,122,96,119,170,130,97,151,35,239,97,54,222,76,161,99,223,92,150,68,91,67,25,72,34,214,158,241,58,104,180,233,20,239,152,121,129,41,44,134,102,114,3,218,121,244,171,240,101,33,48,68,36,169,185,141,87,45,243,244,171,249,205,110,23,47,80,164,203,145,213,66,91,166,181,12,90,50,184,126,59,137,166,172,0,158,49,137,150,177,74,17,157,118,189,50,77,58,142,4,252,74,39,216,193,26,166,118,72,144,165,218,157,36,246,172,37,163,9,190,69,32,17,57,207,242,117,210,233,216,111,24,113,93,20,62,31,225,132,215,50,133,253,178,147,171,22,145,94,99,177,119,116,218,252,249,91,112,12,98,45,76,6,182,32,181,145,37,177,230,225,47,3,157,212,82,34,231,154,132,83,143,225,105,172,215,188,20,71,216,31,5,198,234,221,136,75,155,152,186,14,186,82,65,93,251,160,204,224,45,42,198,143,124,243,49,79,177,157,60,101,12,168,133,119,6,159,67,146,10,140,191,141,77,66,206,56,152,252,61,197,152,241,71,105,234,210,243,99,244,178,180,176,45,193,48,103,145,173,145,206,73,197,176,18,221,236,50,11,121,237,87,97,145,125,191,98,43,152,231,177,201,196,204,36,226,181,92,242,106,166,200,34,120,84,124,161,239,209,155,102,233,29,12,201,233,231,231,156,163,92,188,52,162,254,151,251,160,62,237,171,83,91,167,142,129,61,49,170,177,7,237,180,94,161,27,238,242,133,43,35,137,4,199,151,218,227,119,114,119,1,61,190,209,218,3,190,157,195,251,17,122,162,232,169,107,107,211,163,56,143,58,103,69,115,139,60,105,48,186,52,206,164,192,113,212,57,68,247,198,78,26,106,0,209,76,170,59,8,229,17,83,207,30,160,92,129,12,135,231,190,206,51,18,189,143,147,111,142,168,241,109,195,229,92,53,15,123,38,60,151,223,103,243,111,135,224,243,29,76,225,175,62,192,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a10a692-749d-4236-a578-c1816f7dfa6e"));
		}

		#endregion

	}

	#endregion

}

