﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastDataMapperSchema

	/// <exclude/>
	public class ForecastDataMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastDataMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastDataMapperSchema(ForecastDataMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f49ba06-6712-4c2c-9ad3-21e060b91318");
			Name = "ForecastDataMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,91,111,219,54,20,126,118,129,254,7,206,5,58,25,11,100,96,143,75,236,97,115,46,117,215,180,65,108,244,101,24,2,70,162,19,14,146,168,146,84,130,160,200,127,223,225,225,85,146,157,110,67,251,160,154,60,23,158,235,119,78,26,90,51,213,210,130,145,45,147,146,42,177,211,249,74,52,59,126,215,73,170,185,104,242,115,33,89,65,149,254,252,243,235,87,95,95,191,154,116,138,55,119,100,243,164,52,171,143,7,103,16,173,42,86,24,57,149,95,176,134,73,94,140,120,62,240,230,75,188,76,159,173,107,209,0,5,104,243,249,156,156,168,174,174,169,124,90,186,243,149,20,15,188,100,138,212,76,223,139,82,17,45,72,77,91,178,115,6,146,146,106,154,123,225,121,34,221,118,183,21,47,72,81,81,165,136,247,231,20,184,47,105,219,50,9,28,198,177,201,27,201,238,192,114,2,254,43,77,27,173,126,129,55,249,3,213,12,109,154,180,246,64,10,67,39,74,75,180,95,50,246,81,128,89,27,214,82,8,153,144,100,65,166,55,55,103,167,23,103,55,55,83,235,206,228,13,107,74,171,221,157,221,83,151,214,149,3,15,61,8,94,146,115,94,85,16,214,174,110,62,211,170,99,42,91,199,32,159,108,233,109,197,44,117,9,118,153,255,213,17,185,22,143,68,138,199,35,52,14,89,140,179,107,8,62,225,240,153,17,116,119,98,2,71,139,123,146,37,90,156,18,194,253,47,229,185,15,176,223,243,170,140,220,249,202,156,37,107,130,212,228,129,74,162,81,130,85,21,196,166,97,143,100,27,206,158,107,98,245,173,32,146,192,131,90,115,60,252,4,193,156,194,215,235,135,187,163,190,204,186,12,18,235,50,208,46,164,232,90,175,110,143,44,210,173,168,165,38,178,251,53,94,179,66,200,18,105,16,92,160,56,194,243,177,251,129,14,21,214,75,195,97,206,234,87,47,158,159,115,169,244,39,121,202,118,180,171,116,6,28,54,34,75,226,126,230,87,208,47,2,94,200,207,190,116,180,82,89,176,108,230,149,76,222,190,13,220,222,251,192,237,12,158,205,188,65,124,71,50,180,231,7,8,123,87,85,49,41,147,144,145,28,171,10,44,206,74,1,109,194,102,69,184,244,106,172,30,212,190,125,106,153,137,192,34,180,17,54,139,202,63,221,254,13,37,137,98,214,46,203,153,188,152,60,249,142,42,27,76,5,239,106,153,188,244,236,99,234,61,112,160,18,170,63,255,173,44,179,160,201,123,106,217,241,251,220,111,161,113,7,92,48,61,186,204,92,199,120,115,37,211,157,108,108,169,142,20,56,143,146,66,200,183,98,131,104,144,205,92,181,140,106,197,221,175,104,107,250,214,93,163,75,142,178,86,88,145,94,192,158,188,84,18,0,215,65,31,184,210,39,161,141,150,153,173,16,91,138,131,16,56,160,130,132,213,40,96,156,88,151,217,69,199,203,63,255,34,0,90,12,160,110,93,2,110,152,43,34,157,233,62,22,38,249,145,201,164,190,87,74,46,84,94,42,9,197,113,76,10,130,0,47,175,168,212,198,129,168,206,204,154,130,234,204,184,4,198,124,245,106,158,157,180,211,110,93,200,223,11,222,100,99,192,61,242,170,103,169,251,223,134,92,156,10,150,216,155,55,80,33,48,92,238,25,78,23,172,53,143,133,121,111,172,88,41,99,68,77,26,152,163,139,169,153,64,211,229,22,68,251,67,233,100,142,92,81,200,250,165,150,17,202,137,216,129,5,12,158,146,108,183,152,38,24,59,157,47,79,230,94,0,19,107,199,217,193,57,0,246,195,96,75,174,84,150,14,61,52,201,231,207,36,6,220,116,124,227,226,178,42,125,50,195,8,112,216,211,236,68,50,48,208,213,213,96,106,152,7,90,196,181,62,24,91,172,203,63,66,220,242,107,214,86,176,130,100,83,50,61,50,112,239,219,26,171,198,180,220,34,177,113,136,163,212,32,40,69,112,247,72,24,223,11,88,104,170,216,170,26,66,161,123,32,142,37,235,79,192,173,116,70,56,163,147,161,224,156,138,47,70,74,104,245,177,199,145,201,141,203,195,129,143,67,73,157,75,138,217,166,149,169,246,119,188,44,89,162,126,63,125,56,163,146,56,26,36,197,117,160,7,162,14,114,157,93,200,116,40,52,251,167,103,63,205,251,192,113,28,154,45,215,85,8,202,90,129,233,169,10,60,71,234,89,201,109,83,70,241,67,83,201,179,166,35,201,43,50,180,203,158,173,254,38,62,245,127,34,238,165,189,81,125,35,93,168,123,224,232,64,46,166,38,133,177,23,144,9,128,208,193,147,233,60,236,148,239,135,80,169,144,67,191,129,92,196,196,255,12,110,195,153,250,175,32,110,40,20,128,110,72,216,3,119,54,41,132,28,6,205,193,182,235,112,113,35,58,89,160,226,94,135,142,76,25,1,164,91,40,2,44,194,185,143,137,14,118,246,110,35,102,19,113,77,57,218,254,195,146,143,11,126,218,191,61,115,135,221,61,172,180,200,121,176,216,252,133,89,28,212,158,61,168,136,233,221,73,81,251,73,105,150,222,60,40,123,185,26,145,25,202,42,145,124,177,16,227,226,224,133,236,194,240,163,242,59,197,225,106,252,174,5,182,62,107,186,154,73,115,153,108,97,214,5,7,0,163,253,138,244,39,143,41,2,200,161,185,182,158,227,198,247,251,147,221,216,23,86,89,238,23,201,89,190,97,198,208,236,78,182,248,119,133,225,248,246,126,58,92,250,210,109,207,107,202,255,96,79,123,246,214,148,188,127,15,13,28,91,97,218,194,239,160,179,112,238,237,112,198,215,67,251,153,189,195,15,252,251,7,11,18,52,13,148,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f49ba06-6712-4c2c-9ad3-21e060b91318"));
		}

		#endregion

	}

	#endregion

}

