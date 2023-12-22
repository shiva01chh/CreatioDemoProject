﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SymptomsGeneratorSchema

	/// <exclude/>
	public class SymptomsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SymptomsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SymptomsGeneratorSchema(SymptomsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("329987ff-77ba-409b-96ae-cbb425a36b31");
			Name = "SymptomsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,77,79,27,49,16,61,7,137,255,96,45,151,32,69,27,169,71,8,161,40,138,104,84,65,105,72,123,41,61,56,187,147,101,219,181,189,29,219,41,43,196,127,239,216,222,47,22,21,218,28,80,102,242,230,205,243,204,179,145,92,128,46,121,2,108,3,136,92,171,157,137,23,74,238,242,204,34,55,185,146,135,7,143,135,7,35,171,115,153,177,219,74,27,16,167,131,152,240,69,1,137,3,235,248,18,36,96,158,188,192,108,224,193,196,107,200,108,193,113,249,80,34,104,237,240,29,110,161,132,80,178,31,35,60,143,226,165,52,185,201,193,21,209,15,71,8,25,81,176,69,193,181,62,161,62,162,52,74,104,47,128,27,133,30,84,218,109,145,39,44,113,152,151,16,118,194,86,87,60,65,165,87,114,175,126,242,109,1,84,227,206,219,178,95,129,185,87,169,38,228,13,42,67,167,132,212,19,143,166,211,41,155,105,43,4,199,106,222,36,46,193,104,150,112,13,44,79,217,14,149,96,28,51,43,64,26,166,182,63,168,58,110,75,167,195,218,89,201,145,11,38,105,33,103,81,83,22,205,47,6,4,179,169,199,117,101,8,198,162,212,243,53,36,10,83,106,76,144,38,231,64,101,163,155,237,115,52,150,23,236,210,146,58,146,186,32,161,171,116,28,136,91,165,199,204,15,96,180,231,200,208,115,182,18,206,186,227,112,205,62,66,245,149,23,22,110,120,142,51,109,144,246,52,241,220,243,243,83,207,16,84,12,72,226,15,92,251,50,118,62,252,197,167,195,95,154,183,99,138,151,180,177,202,179,61,133,177,31,129,76,195,106,234,184,222,19,109,167,4,116,238,112,171,242,91,127,101,79,95,52,32,75,148,148,193,182,127,217,74,109,30,7,94,180,216,97,24,134,149,129,9,103,214,245,151,55,228,246,108,245,150,214,117,216,37,11,19,102,123,63,158,29,153,87,120,231,254,175,163,116,103,41,253,15,158,210,182,48,117,235,161,175,194,116,106,89,100,167,112,147,252,250,134,158,210,141,169,188,245,18,239,59,114,83,231,193,14,120,218,154,15,244,47,194,72,248,205,252,197,175,110,147,123,16,252,179,5,172,198,207,151,16,247,1,87,92,242,12,112,194,34,199,29,213,132,68,22,95,164,41,61,85,86,200,113,212,60,5,81,175,159,147,21,136,168,173,195,147,188,16,15,218,77,234,19,244,106,117,205,71,149,29,141,35,216,84,37,212,93,253,100,234,139,50,127,41,33,223,177,113,67,19,175,244,181,50,215,182,40,62,161,191,2,227,227,102,130,163,94,43,122,79,225,129,94,213,178,160,7,188,45,158,176,247,209,183,59,188,147,223,31,223,77,158,34,26,132,11,154,54,253,250,182,93,67,17,144,84,49,219,34,155,206,163,227,120,131,185,88,202,116,220,100,226,141,90,220,115,188,160,255,21,78,84,224,124,234,95,247,134,244,149,107,16,178,207,147,148,235,125,254,0,211,102,234,53,151,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("329987ff-77ba-409b-96ae-cbb425a36b31"));
		}

		#endregion

	}

	#endregion

}

