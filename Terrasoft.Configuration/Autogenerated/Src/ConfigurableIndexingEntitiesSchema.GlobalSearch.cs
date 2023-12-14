﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConfigurableIndexingEntitiesSchema

	/// <exclude/>
	public class ConfigurableIndexingEntitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConfigurableIndexingEntitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConfigurableIndexingEntitiesSchema(ConfigurableIndexingEntitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("038b9caa-f7fe-470a-90af-7d12780d49ad");
			Name = "ConfigurableIndexingEntities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("30c103fe-34c6-441e-895c-acadc354f737");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,219,110,27,55,16,125,150,1,255,3,171,230,97,85,8,235,247,56,182,225,58,23,168,136,99,163,114,242,82,20,1,181,59,146,88,80,164,74,114,93,171,138,254,189,195,37,185,90,238,197,82,220,4,1,228,37,103,206,204,156,185,145,8,186,2,189,166,25,144,7,80,138,106,57,55,233,141,20,115,182,40,20,53,76,138,244,3,151,51,202,167,64,85,182,60,61,217,158,158,12,10,205,196,130,76,55,218,192,234,188,241,157,126,100,226,239,214,225,3,60,153,244,119,88,20,156,170,119,79,107,5,90,35,180,222,203,213,141,175,86,104,245,55,45,69,247,181,130,190,243,244,157,48,204,48,176,184,40,242,179,130,5,90,33,55,156,106,253,154,84,81,205,56,76,68,14,79,8,16,20,80,26,255,175,139,25,103,25,201,172,252,179,226,228,53,153,44,4,90,204,203,147,205,71,166,13,234,111,75,179,123,187,24,161,161,194,160,237,123,197,30,169,1,119,191,118,31,36,179,247,68,27,101,35,185,230,252,150,102,74,106,114,65,134,191,12,207,61,20,136,220,161,217,175,58,248,123,6,60,239,67,86,64,115,41,248,134,124,214,160,208,13,1,153,77,37,249,90,68,223,7,141,220,43,185,6,101,35,182,134,164,65,53,200,131,80,48,230,3,248,202,44,73,144,191,165,134,58,238,48,247,95,40,47,202,116,161,180,87,15,242,147,62,113,98,75,108,48,88,128,241,127,13,216,156,36,101,126,227,194,68,133,41,24,131,96,58,125,80,155,15,96,74,253,164,17,229,152,12,235,37,220,178,59,28,59,43,3,89,24,34,103,127,161,22,121,180,64,163,81,112,96,208,31,28,166,43,113,17,141,30,171,96,7,131,29,1,174,225,56,125,81,112,30,212,220,143,2,83,40,113,136,82,39,189,139,83,223,10,175,3,165,145,144,182,202,39,105,218,135,157,105,105,131,147,159,92,68,123,242,122,163,137,131,54,106,243,12,95,200,147,29,9,233,91,192,228,50,202,217,191,240,166,229,227,101,210,91,85,163,42,49,25,53,217,178,233,220,119,228,32,230,222,55,76,173,133,90,35,64,21,153,145,202,182,80,57,95,170,254,113,211,230,185,57,147,52,250,55,46,236,192,112,163,222,145,169,86,155,31,225,234,45,152,165,140,38,74,220,230,51,41,57,153,104,63,247,110,36,47,86,226,215,205,109,193,13,91,115,152,58,83,58,113,3,113,154,45,97,69,137,46,127,198,164,126,232,52,113,248,217,159,16,194,35,85,132,114,30,80,34,35,247,212,24,80,194,14,70,108,241,235,3,82,137,79,180,79,223,33,80,151,235,244,90,108,146,181,59,34,23,151,24,166,147,186,181,165,226,69,147,16,140,243,124,76,188,252,104,20,243,27,143,197,63,254,60,206,233,26,15,57,204,41,178,26,9,218,224,5,252,179,7,221,146,157,139,211,54,97,87,187,70,19,177,90,46,99,98,135,156,181,162,157,63,78,120,63,233,60,109,209,237,85,218,240,229,234,170,219,201,90,103,4,160,126,185,22,97,190,192,58,152,255,190,154,26,135,13,131,9,90,222,169,107,206,168,246,72,117,154,179,144,129,37,114,251,106,184,117,184,233,39,124,15,237,210,173,187,117,95,195,243,134,82,9,105,203,177,182,86,156,11,159,13,227,58,45,51,142,34,73,229,80,137,61,218,227,48,253,30,231,202,36,152,199,151,17,60,165,19,93,70,157,236,61,27,119,196,48,118,210,119,235,178,156,124,106,110,168,134,14,248,224,104,23,126,121,247,18,3,62,179,81,8,223,190,197,54,67,134,251,7,136,95,154,158,26,203,115,149,55,231,159,61,10,249,58,170,200,235,72,63,160,202,237,99,195,80,38,66,22,29,240,180,116,17,223,168,107,170,64,165,119,42,103,130,242,26,71,182,57,230,20,119,127,71,51,236,207,119,237,151,87,247,44,246,27,195,94,158,157,157,145,55,76,44,113,253,153,92,226,51,85,193,252,98,216,122,135,218,234,107,140,233,225,217,101,109,225,200,71,124,52,179,220,39,164,45,253,194,17,222,151,35,114,209,120,15,120,50,102,200,86,135,175,141,49,59,170,211,232,74,219,139,79,171,109,87,7,241,167,73,212,113,214,181,166,94,211,29,220,210,208,107,171,189,231,208,236,225,93,216,25,74,228,76,91,233,144,95,254,184,214,71,251,185,21,44,149,31,141,181,244,146,234,241,62,29,91,62,129,251,142,250,249,97,69,210,153,223,93,133,29,137,150,34,65,242,255,241,90,45,208,81,95,251,150,44,187,243,232,248,244,164,60,180,255,254,3,152,189,132,154,108,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("038b9caa-f7fe-470a-90af-7d12780d49ad"));
		}

		#endregion

	}

	#endregion

}

