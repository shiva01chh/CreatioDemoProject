﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelationshipDesignerServiceSchema

	/// <exclude/>
	public class RelationshipDesignerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelationshipDesignerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelationshipDesignerServiceSchema(RelationshipDesignerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17c63eff-c94a-9f36-745a-db9fa702576c");
			Name = "RelationshipDesignerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d70c770b-1ab7-4b01-9c96-cb0b33162e8e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,109,79,227,56,16,254,220,149,248,15,22,247,37,149,170,252,0,10,172,128,46,168,167,99,23,149,93,237,7,116,90,185,201,208,250,46,111,103,59,220,117,17,255,253,28,219,41,182,243,210,164,11,244,78,91,62,160,120,226,121,102,198,207,120,50,137,155,224,24,88,134,3,64,159,129,82,204,210,123,238,95,164,201,61,89,228,20,115,146,38,254,12,34,121,193,150,36,155,0,35,139,4,232,193,187,199,131,119,131,156,145,100,129,110,87,140,67,60,94,143,27,112,198,142,130,63,203,19,78,98,240,111,129,18,28,145,239,245,179,196,221,7,18,192,117,26,66,212,122,211,63,11,56,121,216,12,226,127,133,121,189,179,20,154,228,254,37,14,120,74,9,176,186,25,2,80,204,138,227,26,195,23,105,20,65,32,87,207,191,2,177,112,36,16,115,196,172,95,40,44,132,20,93,68,152,177,35,100,174,177,118,86,78,187,211,3,177,146,156,10,31,126,47,100,103,44,251,8,92,88,204,132,206,156,68,132,175,102,240,87,78,40,196,144,112,230,153,131,34,100,116,130,54,168,20,179,124,45,8,135,133,145,44,159,71,36,64,65,225,30,170,203,0,237,24,58,66,231,152,193,218,231,193,163,244,123,29,223,37,129,40,20,1,222,208,130,27,21,212,32,83,3,52,181,128,9,94,80,28,159,231,36,10,129,162,111,212,184,167,133,227,77,202,215,56,193,139,66,57,180,198,27,245,174,104,154,103,174,178,41,28,235,168,32,9,85,96,118,148,130,30,198,105,94,228,72,17,171,92,59,29,170,90,199,150,21,244,134,98,13,231,98,13,197,197,35,122,234,172,246,133,1,21,118,19,149,94,40,183,134,195,2,100,160,113,157,91,168,216,186,131,167,246,136,110,104,154,1,229,34,227,183,224,110,86,165,14,157,156,74,151,6,117,188,162,247,239,145,87,123,227,68,109,16,181,253,86,98,11,241,227,22,195,167,158,178,49,72,224,111,147,147,51,186,200,139,60,247,14,237,165,56,28,33,123,21,135,195,225,120,115,152,101,162,56,67,29,161,147,123,42,54,71,214,49,44,61,189,12,235,117,163,178,246,64,157,204,137,207,186,103,6,105,43,117,139,212,212,121,185,112,155,146,251,26,248,50,13,157,157,122,247,73,36,188,244,203,44,182,131,59,81,221,167,201,67,250,39,120,74,77,132,116,120,243,233,246,179,176,91,84,76,96,252,50,165,49,230,66,46,166,94,3,99,34,8,37,242,127,101,105,50,66,231,105,184,186,229,171,8,172,41,107,169,255,149,226,44,131,80,163,141,100,244,51,241,80,22,177,67,59,182,44,213,117,197,66,23,137,18,5,137,117,215,43,237,93,229,36,68,20,130,148,134,211,112,132,196,242,22,207,43,22,44,33,198,31,69,51,160,235,195,128,211,149,190,26,60,96,138,52,185,211,228,62,21,222,212,236,112,223,176,97,192,63,227,142,43,96,170,63,216,8,167,166,121,37,0,5,158,211,4,21,233,209,18,178,103,56,60,178,13,106,160,39,20,96,30,44,145,247,225,159,0,50,89,68,215,193,119,53,82,70,245,100,148,212,255,125,34,89,109,155,155,73,19,136,128,195,7,209,186,241,149,202,37,144,215,211,176,38,113,236,58,230,91,186,107,181,42,173,109,14,120,61,217,107,197,250,249,232,187,160,32,30,0,207,197,210,51,179,91,49,99,52,21,224,8,54,83,92,193,175,64,236,233,126,67,186,191,100,225,171,210,93,193,223,211,189,251,226,108,208,33,11,116,176,30,119,47,210,6,134,165,190,37,157,242,255,158,210,205,141,155,108,132,153,217,183,41,201,4,115,236,53,180,102,11,57,67,152,170,105,166,125,7,161,189,135,178,173,123,10,120,11,14,91,48,127,106,6,133,126,199,206,169,31,175,207,184,45,93,213,158,232,55,233,173,228,50,120,77,239,184,138,212,230,42,108,113,108,2,42,189,125,249,221,73,3,245,130,156,154,128,123,78,119,216,37,41,10,100,29,150,60,180,245,70,22,131,166,122,169,185,231,112,39,181,86,61,244,166,73,227,254,180,38,148,207,91,53,234,85,131,109,67,54,206,158,251,157,212,228,55,224,190,206,208,158,251,255,64,237,182,41,177,122,233,17,218,186,164,215,18,45,0,247,69,254,109,222,156,102,242,212,160,100,225,62,53,223,161,220,123,157,94,160,168,163,244,252,42,101,188,69,85,144,59,190,66,53,121,235,185,86,127,240,181,170,209,78,93,62,56,39,94,74,234,8,91,126,122,224,156,49,151,166,212,79,17,138,23,77,51,203,26,127,34,224,238,217,163,214,188,62,168,252,102,160,215,105,122,101,215,117,59,77,119,213,44,66,52,2,244,131,152,24,39,100,20,88,30,113,211,23,149,159,75,194,252,137,117,146,166,102,142,13,14,187,155,210,231,103,129,58,213,106,51,182,62,105,83,115,183,51,103,68,54,66,189,93,168,198,219,213,67,247,24,87,102,226,53,196,115,160,94,113,178,88,20,55,241,160,198,135,86,101,49,205,154,215,202,179,5,240,49,98,96,45,124,29,174,242,166,22,89,123,108,143,26,209,251,110,197,166,109,223,115,47,54,214,212,87,221,148,141,53,171,227,238,108,212,223,98,155,54,98,77,39,68,126,213,198,116,117,172,78,193,71,40,157,255,1,1,63,173,60,57,234,51,219,133,150,233,109,139,250,230,177,171,111,103,94,155,203,21,103,94,44,21,237,15,123,61,19,208,249,28,250,170,105,231,124,129,236,152,108,142,214,22,41,230,32,252,70,24,63,110,250,88,116,170,63,235,214,103,212,85,249,201,87,77,234,155,61,74,203,206,153,13,222,104,139,189,146,69,202,196,223,191,120,79,91,51,60,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17c63eff-c94a-9f36-745a-db9fa702576c"));
		}

		#endregion

	}

	#endregion

}
