﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CachedSysModuleVisaRepositorySchema

	/// <exclude/>
	public class CachedSysModuleVisaRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CachedSysModuleVisaRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CachedSysModuleVisaRepositorySchema(CachedSysModuleVisaRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d0ab175-e346-431a-bedf-5f0ada28b57d");
			Name = "CachedSysModuleVisaRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,148,77,111,226,48,16,134,207,84,234,127,24,101,47,84,170,194,157,0,210,42,75,171,61,116,191,104,123,169,86,43,147,12,224,85,98,167,254,64,138,42,254,251,142,237,4,8,4,54,55,219,243,206,204,251,76,108,193,74,212,21,203,16,158,81,41,166,229,202,196,169,20,43,190,182,138,25,46,197,237,205,199,237,205,192,106,46,214,144,74,133,73,103,21,207,133,225,134,163,166,109,58,248,164,112,77,26,72,11,166,245,24,22,181,126,146,185,45,240,149,107,246,133,25,230,131,70,163,17,76,180,45,75,166,234,89,179,94,96,230,138,1,171,42,37,183,172,0,141,198,80,17,13,57,201,32,147,194,40,150,153,184,149,143,78,244,19,141,200,10,45,33,83,184,154,70,23,188,132,110,107,215,73,4,35,167,173,236,178,224,25,100,174,223,243,118,97,12,7,5,69,59,18,103,237,251,141,71,52,26,164,114,109,107,64,175,1,157,109,176,100,32,136,112,12,123,229,113,231,109,121,109,148,3,234,202,46,188,232,27,105,224,3,214,104,18,151,50,129,29,69,239,2,98,20,121,160,220,71,60,101,164,207,59,70,126,97,37,53,55,82,213,23,233,63,111,16,212,62,12,86,100,228,108,16,189,232,59,248,174,214,134,182,183,0,244,112,48,57,163,62,107,73,239,189,73,161,13,19,134,252,253,240,5,189,145,3,60,154,109,70,253,179,92,138,162,110,97,118,210,250,210,143,74,218,202,147,157,66,212,57,142,194,223,123,202,118,223,192,3,199,34,119,213,21,223,50,131,77,249,176,104,254,144,48,183,159,22,85,157,202,194,150,2,254,108,247,227,12,59,174,244,127,10,121,167,202,102,4,166,223,236,85,198,195,23,141,138,82,136,230,50,217,206,242,206,165,25,140,97,201,52,14,187,71,247,167,60,238,175,225,187,3,63,157,221,117,43,79,104,54,50,64,147,134,202,96,222,98,107,150,32,183,116,75,121,222,67,208,93,167,176,73,228,138,208,227,92,191,15,155,202,131,45,83,128,250,157,230,232,204,196,151,162,19,31,220,59,7,146,82,130,248,115,158,135,189,97,244,70,142,67,212,248,229,107,62,62,220,69,90,253,142,157,38,106,18,42,52,86,9,167,79,142,56,244,248,58,127,79,82,250,75,13,126,95,254,165,200,7,37,203,208,246,112,222,60,24,134,173,241,216,35,55,88,182,38,47,72,131,38,52,230,194,227,147,71,100,26,178,58,70,207,117,133,141,221,87,86,88,156,132,155,50,27,246,18,242,150,187,142,93,254,228,194,232,123,94,39,218,57,254,254,1,6,216,232,209,106,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d0ab175-e346-431a-bedf-5f0ada28b57d"));
		}

		#endregion

	}

	#endregion

}

