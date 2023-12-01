﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicateDeletionManagerSchema

	/// <exclude/>
	public class DuplicateDeletionManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicateDeletionManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicateDeletionManagerSchema(DuplicateDeletionManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b6ef42d-5e61-48bb-b57c-5b5c66f26a7f");
			Name = "DuplicateDeletionManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,85,77,111,218,64,16,61,19,41,255,97,234,244,96,36,107,105,123,204,151,68,192,105,211,64,18,1,85,14,81,14,139,119,12,91,153,93,178,187,78,131,16,255,189,179,182,193,124,20,149,3,120,102,103,222,188,153,125,99,20,159,161,157,243,4,97,132,198,112,171,83,199,58,90,165,114,146,27,238,164,86,172,139,34,159,103,50,41,172,211,147,229,233,73,35,183,82,77,96,184,176,14,103,23,123,54,101,103,25,38,62,216,178,199,241,111,122,236,107,129,217,65,92,79,170,183,3,231,3,186,218,183,83,57,206,184,117,50,97,207,56,110,207,165,231,232,12,79,156,101,3,124,203,209,58,91,231,13,200,28,78,185,153,215,174,237,230,12,30,243,179,91,66,212,70,162,7,163,152,51,131,19,42,13,29,170,109,207,161,91,177,193,46,102,232,57,245,185,226,19,52,69,236,75,23,83,158,103,238,70,42,65,200,161,91,204,81,167,225,221,177,164,102,243,149,178,230,249,152,78,33,241,5,142,226,195,57,220,112,139,59,227,168,142,34,56,90,128,208,151,5,179,186,13,63,179,220,119,72,205,60,21,149,203,128,138,197,49,164,240,151,69,67,201,170,188,86,200,119,204,38,209,27,19,189,112,207,237,129,189,88,26,171,138,5,42,81,18,217,101,213,71,55,213,98,143,81,171,213,130,75,169,166,104,164,19,154,6,100,48,189,10,142,246,202,10,27,131,214,245,86,59,239,90,10,40,15,66,235,140,191,110,84,78,186,197,3,105,62,130,239,185,20,47,175,144,43,73,250,25,96,162,141,184,19,182,9,5,231,70,79,79,8,116,156,79,194,207,193,0,103,250,221,167,175,231,143,22,4,119,156,65,92,224,129,34,192,115,88,214,232,171,8,164,111,105,89,214,101,63,181,84,97,16,5,209,65,185,85,208,188,40,10,190,115,3,162,32,187,105,210,86,210,134,43,80,248,167,106,229,240,180,36,220,184,83,2,63,124,113,10,223,60,71,229,217,80,231,38,193,120,195,143,66,182,70,81,198,108,128,203,48,34,87,213,173,23,250,210,207,236,58,220,235,129,141,116,79,90,23,54,139,43,111,172,234,126,204,14,127,191,150,21,231,176,91,43,185,80,165,47,97,158,184,155,70,149,30,88,55,238,197,163,120,125,29,141,42,241,86,155,25,247,128,93,154,127,105,176,159,214,75,170,170,124,38,83,120,136,71,183,131,118,63,126,126,28,220,23,7,21,15,214,22,226,70,139,69,120,100,206,254,38,206,48,179,184,159,228,43,252,63,145,246,62,45,50,125,163,157,76,210,132,89,252,129,73,238,176,109,23,42,9,43,196,136,230,98,231,244,122,164,107,184,94,247,39,211,112,237,101,67,199,93,110,59,244,214,132,79,87,240,195,185,121,237,97,143,247,155,153,20,34,141,141,209,166,156,68,24,116,184,82,218,17,62,9,22,233,199,223,144,133,84,27,176,213,238,46,191,172,128,43,1,210,43,4,150,95,87,12,70,83,4,250,19,176,180,72,32,45,44,191,173,130,74,18,141,198,246,194,212,162,218,52,80,188,134,41,166,210,176,95,117,255,93,154,255,222,251,210,187,235,36,31,125,254,2,160,238,129,149,139,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b6ef42d-5e61-48bb-b57c-5b5c66f26a7f"));
		}

		#endregion

	}

	#endregion

}
