﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RootAccountServiceApiSchema

	/// <exclude/>
	public class RootAccountServiceApiSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RootAccountServiceApiSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RootAccountServiceApiSchema(RootAccountServiceApiSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d294795-ef7f-44dc-97ec-0ad55ecac586");
			Name = "RootAccountServiceApi";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edc99e2c-9094-4ed6-903f-e907a7c24faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,77,143,218,48,16,61,131,180,255,97,148,246,192,74,136,220,249,146,182,28,42,14,149,16,187,252,0,19,28,176,148,216,233,216,70,66,43,254,123,253,69,20,111,2,75,209,74,109,110,25,207,123,243,230,121,60,156,148,84,86,36,163,240,70,17,137,20,185,26,45,4,207,217,94,35,81,76,240,167,254,251,83,191,167,37,227,251,40,5,233,228,169,111,78,210,52,133,169,212,101,73,240,52,15,255,43,20,71,182,163,192,120,46,176,116,52,144,163,40,129,100,153,208,92,129,164,120,100,25,29,93,240,105,131,160,210,219,130,101,6,171,40,230,86,216,114,45,132,122,241,200,87,15,124,169,152,201,180,194,90,245,93,96,129,148,40,42,65,29,40,160,65,215,133,183,39,64,250,91,83,169,70,53,56,253,136,158,86,4,73,9,220,88,51,75,2,114,105,90,89,123,100,50,127,51,180,23,70,219,99,205,57,77,29,212,49,253,32,146,6,213,107,99,177,224,146,6,93,33,58,104,244,213,160,135,118,197,103,111,117,119,175,63,169,106,55,122,171,59,164,74,35,151,174,139,8,51,77,47,71,54,183,165,46,244,96,234,53,142,6,55,181,109,170,221,127,121,15,94,215,67,247,208,59,219,126,193,124,223,144,238,237,100,47,10,34,229,24,174,76,169,207,117,237,48,126,160,200,212,78,100,144,33,205,103,73,247,100,39,233,220,131,194,75,200,44,127,55,61,140,161,21,27,222,124,48,214,145,90,184,241,66,161,206,148,64,163,127,229,170,221,184,204,70,58,136,28,136,23,118,239,253,105,243,230,13,3,167,153,93,7,201,124,105,200,8,55,207,219,80,109,162,179,232,246,90,60,50,19,21,245,87,111,3,22,110,86,13,87,76,157,192,157,69,240,96,97,167,33,131,184,44,196,10,135,96,154,181,75,207,145,62,91,178,222,24,182,102,152,6,173,68,151,1,110,29,157,131,197,148,239,188,203,177,229,191,168,58,136,93,151,219,119,14,199,40,90,33,110,84,234,46,191,114,227,248,110,122,71,130,160,177,128,25,124,79,222,99,49,27,44,206,41,169,88,26,208,105,230,74,37,147,26,136,23,17,51,120,53,126,172,132,84,129,126,218,33,117,62,48,133,134,215,94,93,175,231,119,83,77,58,105,184,253,87,6,198,251,43,118,240,222,157,247,128,59,229,157,206,92,145,16,220,225,186,40,190,216,143,104,23,126,62,80,143,174,206,7,44,211,174,212,191,24,168,15,207,215,71,227,160,139,153,239,15,159,6,47,22,65,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d294795-ef7f-44dc-97ec-0ad55ecac586"));
		}

		#endregion

	}

	#endregion

}

