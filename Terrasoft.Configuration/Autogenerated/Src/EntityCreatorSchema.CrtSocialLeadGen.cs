﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityCreatorSchema

	/// <exclude/>
	public class EntityCreatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityCreatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityCreatorSchema(EntityCreatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("420dd940-d3d3-435c-84c7-f48acd934670");
			Name = "EntityCreator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,219,78,227,48,16,125,14,18,255,96,178,43,148,138,202,31,64,149,69,108,105,17,18,237,94,10,203,11,18,50,201,164,181,54,177,139,237,116,85,161,254,251,250,146,132,184,109,160,43,45,47,193,158,235,57,51,227,41,35,5,200,37,73,0,221,129,16,68,242,76,225,33,103,25,157,151,130,40,202,25,158,241,132,146,252,22,72,122,13,236,248,232,245,248,40,40,37,101,115,52,91,75,5,5,190,165,236,101,208,92,182,189,20,5,103,251,37,2,186,238,241,136,41,170,40,72,173,160,85,62,9,152,235,36,208,48,39,82,158,35,43,92,15,5,16,197,133,85,88,150,207,57,77,144,84,58,217,4,37,70,109,91,43,120,181,154,141,175,49,133,60,213,206,190,11,186,34,10,156,112,233,14,181,35,169,132,201,237,137,113,53,33,203,37,164,206,104,66,18,193,37,138,81,168,5,79,133,149,60,101,86,20,14,222,113,147,240,188,44,216,221,122,9,87,68,17,99,159,234,239,129,38,111,65,11,251,95,56,168,240,0,75,29,36,31,223,4,212,130,127,4,112,197,105,138,102,160,126,145,188,132,59,62,180,209,34,199,220,44,89,64,65,144,180,159,126,69,39,2,251,233,215,9,186,163,179,155,234,38,106,4,43,227,177,135,76,159,4,193,138,8,79,83,163,112,110,177,59,75,60,166,44,253,186,54,30,162,109,151,189,65,227,67,105,30,82,155,171,246,96,56,52,196,220,43,154,219,94,193,86,114,41,205,101,100,227,247,189,168,78,110,164,149,75,39,196,26,191,83,176,114,47,126,191,21,210,25,109,186,121,28,211,60,111,57,146,7,241,104,38,106,202,21,205,214,15,240,188,224,252,55,250,227,190,53,119,213,17,27,69,215,126,23,248,97,1,2,162,12,197,95,80,134,13,32,20,199,59,237,117,122,138,78,92,49,240,141,156,150,121,254,77,140,138,165,90,71,25,30,109,83,220,195,99,46,70,36,89,68,182,141,141,99,23,61,216,105,142,26,71,13,192,26,236,120,172,239,91,204,5,155,131,24,156,250,179,246,127,72,52,205,227,232,209,56,183,34,232,86,122,159,99,71,196,94,162,221,80,58,5,205,119,134,171,230,140,59,222,140,70,243,240,202,56,238,104,134,162,78,0,39,49,74,33,35,101,174,76,209,187,212,240,37,91,71,189,154,17,75,201,86,142,51,55,186,113,53,195,216,38,229,226,127,212,134,135,194,65,150,165,142,150,237,185,80,65,211,140,126,126,173,174,12,130,253,169,159,197,40,218,79,237,94,253,30,186,64,97,63,68,231,30,226,58,141,32,56,67,159,195,199,240,213,183,173,86,225,15,61,225,102,51,26,88,155,71,227,99,87,211,118,131,22,134,21,137,245,8,184,122,254,75,162,77,217,58,171,219,53,192,193,238,251,126,232,8,239,79,165,66,128,26,44,27,55,221,173,217,254,120,39,217,125,93,61,4,222,238,126,230,60,71,118,105,67,212,57,214,125,116,47,65,232,31,40,12,18,83,3,84,122,199,62,226,165,242,223,136,246,67,224,224,235,54,247,173,112,251,165,153,16,70,230,32,240,53,168,27,166,83,99,9,84,235,169,30,132,182,118,107,77,185,112,173,5,103,161,56,229,200,15,184,179,133,174,32,243,246,71,165,176,179,87,182,235,87,63,118,111,234,219,143,232,251,22,2,84,41,24,170,19,33,43,187,62,169,254,113,2,63,225,165,164,2,210,115,148,145,92,250,59,112,171,202,238,214,191,180,119,250,239,47,32,105,101,218,96,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("420dd940-d3d3-435c-84c7-f48acd934670"));
		}

		#endregion

	}

	#endregion

}
