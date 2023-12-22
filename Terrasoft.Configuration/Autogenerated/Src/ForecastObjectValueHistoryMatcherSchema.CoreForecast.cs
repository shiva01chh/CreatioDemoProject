﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastObjectValueHistoryMatcherSchema

	/// <exclude/>
	public class ForecastObjectValueHistoryMatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastObjectValueHistoryMatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastObjectValueHistoryMatcherSchema(ForecastObjectValueHistoryMatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cdc37d9-7e92-22a7-f203-41f2f84b377c");
			Name = "ForecastObjectValueHistoryMatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,85,223,107,219,48,16,126,118,161,255,131,200,160,56,80,100,216,99,27,7,186,180,217,2,109,87,218,210,151,177,7,213,62,39,218,108,41,147,228,150,48,242,191,239,36,203,142,237,164,36,27,244,109,129,36,232,252,125,247,227,187,59,89,176,2,244,146,37,64,30,65,41,166,101,102,232,68,138,140,207,75,197,12,151,130,78,165,130,132,105,243,244,145,252,62,62,58,62,10,74,205,197,156,60,172,180,129,2,177,121,14,137,5,106,250,25,4,40,158,156,247,49,215,92,252,218,24,219,113,138,66,138,221,79,20,208,41,75,140,84,28,244,185,11,251,65,193,28,195,144,153,48,160,50,155,241,25,153,213,201,125,125,254,129,89,60,177,188,132,47,92,35,109,117,195,76,178,0,229,168,81,20,145,145,46,139,130,169,213,216,159,61,140,72,199,36,47,150,170,73,81,177,8,175,131,208,154,30,181,248,203,242,57,231,201,6,116,64,30,94,187,166,138,27,48,11,153,234,51,114,231,124,85,15,251,121,58,131,115,208,73,147,96,44,169,82,77,27,78,212,39,141,150,76,177,130,8,236,110,60,200,33,51,155,62,13,198,143,11,32,214,70,146,198,72,140,196,83,129,44,160,232,206,177,119,59,83,124,190,216,242,230,140,7,187,83,96,74,37,244,120,164,1,72,162,32,139,7,15,11,0,51,136,198,163,168,126,104,209,179,43,81,22,160,216,115,14,35,47,103,75,224,123,167,194,184,18,40,108,99,119,128,186,26,156,90,239,193,30,74,175,210,161,29,212,192,245,16,68,90,181,209,181,109,141,95,59,159,93,107,221,232,73,206,52,182,249,157,6,117,231,120,126,187,132,140,149,185,249,196,69,138,123,21,154,213,18,100,22,238,31,210,225,41,185,197,38,147,152,12,188,139,193,240,251,102,222,19,91,202,254,74,14,218,203,255,251,240,15,251,224,251,240,126,107,65,220,94,252,237,98,216,94,34,171,235,139,78,22,144,252,188,80,115,244,36,204,109,153,231,161,21,12,231,176,139,27,86,123,21,244,156,190,77,239,71,247,252,23,166,136,146,175,26,135,87,192,43,185,70,93,222,22,39,244,164,12,199,148,225,52,133,91,16,167,204,12,223,94,120,203,247,84,170,235,117,33,49,214,189,124,245,65,223,138,23,214,206,124,216,192,38,74,47,210,52,172,232,181,217,213,96,203,115,129,227,190,208,116,202,21,174,148,242,187,25,114,135,26,251,166,5,246,72,239,33,187,18,134,155,213,44,37,113,220,84,209,177,159,156,180,25,232,191,44,68,15,222,24,187,216,59,124,191,203,180,135,109,140,93,236,206,52,106,163,7,214,133,243,140,132,173,194,81,77,108,120,163,115,80,169,68,189,188,15,134,25,123,71,181,143,244,18,114,48,144,122,127,107,247,87,253,86,11,228,102,195,61,93,251,139,103,235,18,223,186,195,209,214,254,252,1,64,95,235,218,43,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cdc37d9-7e92-22a7-f203-41f2f84b377c"));
		}

		#endregion

	}

	#endregion

}

