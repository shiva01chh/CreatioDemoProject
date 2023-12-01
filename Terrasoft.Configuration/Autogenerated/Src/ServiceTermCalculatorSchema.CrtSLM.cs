﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceTermCalculatorSchema

	/// <exclude/>
	public class ServiceTermCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceTermCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceTermCalculatorSchema(ServiceTermCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a52051c5-8c49-4dbd-ade2-111eba803475");
			Name = "ServiceTermCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,89,93,111,219,54,20,125,118,128,252,7,206,5,10,121,240,148,162,24,246,80,39,46,130,100,221,130,161,64,80,59,123,216,48,4,140,68,39,28,100,73,32,41,103,94,145,255,190,203,47,153,164,100,217,169,237,102,3,86,20,137,69,221,47,158,123,238,161,165,84,156,230,247,104,178,228,130,204,71,199,71,149,115,25,95,20,89,70,18,65,139,156,199,63,145,156,48,154,212,38,83,194,24,230,197,76,128,85,62,163,247,21,195,210,48,190,192,25,201,83,204,120,171,37,35,176,124,124,148,227,57,225,37,78,200,218,48,19,194,22,52,33,112,123,126,124,244,249,248,168,119,114,114,130,78,121,53,159,99,182,28,155,235,79,164,100,132,147,92,112,196,181,61,18,224,128,18,156,37,85,134,69,193,98,235,121,226,184,150,213,93,70,19,148,100,152,115,228,36,186,168,221,208,59,116,229,175,128,155,172,162,247,138,145,123,168,15,125,160,36,75,185,220,75,175,87,50,186,192,130,32,70,112,90,228,217,18,221,64,53,176,157,92,99,135,110,43,239,122,212,234,115,53,41,73,66,103,52,81,251,151,201,175,49,3,152,96,67,28,221,114,247,102,123,128,75,184,154,210,57,65,183,41,124,26,233,210,94,65,47,116,197,230,218,148,127,205,138,146,48,65,137,217,66,136,174,90,176,173,68,149,160,25,21,203,184,182,116,209,172,43,177,230,55,218,26,221,38,254,130,46,91,99,31,218,218,223,10,227,222,61,17,230,83,143,17,81,177,188,17,11,189,127,143,162,198,226,25,202,201,99,24,59,10,224,31,12,84,33,189,39,245,147,175,82,181,132,91,224,172,34,142,249,83,7,90,178,101,168,172,123,182,1,172,176,193,194,187,54,29,46,4,148,76,210,208,56,184,92,139,153,31,83,67,22,172,157,5,212,130,49,23,126,248,200,195,235,169,155,86,128,50,23,172,74,96,96,58,137,5,164,5,12,100,179,214,204,45,162,82,127,218,33,84,43,10,104,36,117,228,172,191,2,189,63,14,187,112,122,162,46,218,29,13,175,251,227,6,211,93,55,67,217,86,161,136,130,94,172,50,15,27,28,55,177,7,166,77,205,86,148,126,255,219,8,89,57,163,212,69,198,61,35,156,20,121,74,213,57,16,34,12,225,229,17,129,106,139,13,136,123,163,216,31,75,165,148,190,102,97,123,220,47,169,114,128,138,79,129,113,112,204,12,81,113,247,39,68,25,175,74,129,30,4,74,28,40,129,237,132,191,44,97,110,10,118,111,1,244,152,97,73,109,43,52,170,247,172,88,208,148,176,15,250,78,100,134,197,159,42,176,55,158,114,190,58,132,62,114,107,15,117,75,71,166,51,228,88,201,83,83,96,154,243,95,200,50,234,203,35,160,63,24,212,130,38,15,2,200,109,79,134,24,18,113,226,120,255,174,61,254,136,167,197,68,129,232,14,251,22,227,254,145,136,135,34,221,112,132,168,142,201,115,138,151,144,146,32,85,212,221,210,227,101,23,15,181,154,241,241,39,55,0,16,197,174,59,84,169,143,192,58,173,117,146,119,34,11,140,132,208,96,227,128,243,145,230,191,74,185,175,225,19,15,172,120,84,141,62,103,247,213,28,190,102,252,248,87,66,74,137,92,228,157,33,70,111,219,147,170,68,131,205,3,187,59,80,238,156,113,129,153,80,205,29,79,228,71,11,90,48,154,251,195,182,190,93,103,246,208,14,39,12,6,168,202,178,61,67,93,167,110,204,78,124,81,49,6,81,165,28,196,178,204,223,138,124,127,77,65,56,79,145,144,155,255,27,194,238,185,69,174,139,48,149,131,8,219,108,136,230,179,226,235,54,118,136,44,130,87,144,27,217,162,108,51,165,78,90,184,108,72,104,129,18,57,121,202,249,138,23,219,100,250,190,238,181,140,175,142,25,97,63,24,193,181,151,134,54,211,101,41,245,109,109,182,24,84,113,168,77,213,104,119,218,42,11,99,109,143,238,171,180,89,240,234,158,230,229,200,37,166,57,169,227,243,52,117,233,104,247,49,92,161,245,12,242,241,34,171,212,216,124,33,249,26,172,152,184,1,183,101,133,117,250,170,82,234,37,125,182,148,238,10,220,238,194,186,59,210,47,36,172,94,13,7,20,214,151,107,209,110,194,122,136,198,238,87,88,109,178,255,133,117,75,242,225,153,124,158,41,49,48,252,192,84,187,201,169,48,84,171,224,99,183,131,122,7,225,88,235,151,18,7,100,230,185,196,225,90,194,208,202,209,250,5,159,154,119,185,21,100,247,52,132,161,49,245,89,210,118,233,138,147,40,104,169,14,166,2,29,90,114,254,227,93,223,160,98,255,118,154,108,144,188,189,30,113,117,113,242,173,87,7,167,224,17,221,92,218,125,217,56,82,129,87,47,105,32,140,124,91,102,54,117,73,103,51,2,78,9,137,100,45,32,144,74,247,174,49,101,167,77,44,20,4,227,40,224,186,125,250,126,166,76,59,175,187,154,186,236,220,124,65,33,94,189,203,92,80,38,42,156,109,7,208,26,128,183,243,133,156,9,225,242,79,16,250,32,10,36,169,61,116,231,33,58,108,198,124,233,77,242,162,98,137,121,120,210,173,221,13,28,73,113,203,74,96,134,27,94,146,107,212,48,178,60,123,179,122,61,21,58,161,111,206,26,249,228,122,61,194,109,78,241,21,175,95,160,66,26,120,226,120,253,186,53,74,195,176,14,171,234,212,113,167,65,181,48,250,11,194,132,183,60,45,224,185,165,146,95,119,131,82,134,62,12,250,209,102,228,228,88,149,117,184,60,33,222,109,251,250,110,93,37,54,136,161,254,246,2,213,188,17,235,226,135,62,1,108,153,79,142,222,182,87,236,110,206,43,216,189,225,41,206,151,200,105,75,113,79,254,31,235,228,17,212,217,157,231,125,207,225,143,84,36,15,168,46,161,38,97,130,57,105,57,12,13,140,239,252,198,56,127,111,90,235,248,51,192,216,230,134,190,69,63,188,217,224,123,137,151,107,93,225,199,219,239,141,127,74,102,184,202,132,181,221,246,136,109,121,93,44,215,224,63,252,251,7,58,248,30,249,105,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a52051c5-8c49-4dbd-ade2-111eba803475"));
		}

		#endregion

	}

	#endregion

}

