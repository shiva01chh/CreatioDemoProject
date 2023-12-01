﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HierarchyDataStructureObtainerContextSchema

	/// <exclude/>
	public class HierarchyDataStructureObtainerContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HierarchyDataStructureObtainerContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HierarchyDataStructureObtainerContextSchema(HierarchyDataStructureObtainerContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("957695b4-45df-4a95-b697-38f30da67709");
			Name = "HierarchyDataStructureObtainerContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f6d1296c-7e61-436c-80dc-2684cfa4b28a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,88,75,111,227,54,16,62,123,129,253,15,172,247,226,160,129,124,95,63,128,188,107,96,219,13,234,180,215,5,45,209,54,11,137,210,146,148,187,218,160,255,189,195,151,158,148,228,36,104,139,230,16,152,212,204,112,56,243,205,199,33,25,78,136,200,112,72,208,19,225,28,139,116,47,131,155,148,237,233,33,231,88,210,148,189,127,247,252,254,221,36,23,148,29,208,182,16,146,36,139,214,24,228,227,152,132,74,88,4,15,132,17,78,195,142,204,39,202,190,86,147,245,181,146,36,101,254,47,156,244,205,7,119,76,82,73,137,232,21,184,199,161,76,185,145,0,153,15,156,28,192,63,116,19,99,33,62,162,159,40,225,152,135,199,226,22,75,188,149,60,15,101,206,201,61,141,37,225,90,126,62,159,163,165,200,147,4,243,98,109,199,90,23,133,41,147,152,50,129,136,114,161,64,123,173,20,56,157,121,77,41,203,119,49,13,81,168,245,134,151,156,60,235,101,75,63,31,121,154,17,174,118,248,17,61,106,51,230,123,219,47,227,88,26,231,9,67,25,150,199,160,20,170,59,226,60,17,146,171,80,25,249,71,16,71,42,183,147,201,129,200,5,202,56,61,97,73,144,128,129,154,253,107,96,197,223,113,156,147,225,181,54,119,44,79,96,203,187,152,44,211,221,31,128,143,181,81,19,74,232,149,235,154,112,65,14,146,12,115,42,32,80,178,200,70,28,49,58,55,165,202,19,104,160,214,112,216,157,201,164,215,161,79,233,129,134,56,70,42,91,186,92,134,125,177,226,159,157,52,224,128,134,178,51,125,94,132,62,16,22,25,184,52,177,3,229,43,52,190,82,126,30,122,74,241,30,231,245,12,132,11,39,136,1,93,172,166,97,9,160,233,186,14,190,229,92,75,249,149,78,58,249,211,181,1,1,228,208,145,198,176,90,216,200,148,90,175,153,251,65,229,184,21,216,233,186,155,176,186,1,155,166,161,90,157,217,34,170,98,112,233,197,186,217,238,165,206,226,196,139,193,230,206,208,202,139,212,224,238,107,142,99,107,166,7,62,237,93,130,41,191,100,112,197,162,11,11,246,26,9,172,106,155,209,0,155,216,28,173,236,46,22,86,163,229,111,115,3,70,168,189,48,136,181,221,27,192,176,153,173,79,78,94,70,222,15,60,205,179,94,6,215,95,209,62,229,232,232,108,160,8,140,32,225,172,88,58,23,111,227,115,235,133,169,225,49,90,31,96,23,99,173,81,43,103,115,238,144,127,235,210,242,51,234,48,12,26,34,224,127,134,239,250,220,176,193,251,207,120,206,130,97,186,246,36,226,223,230,29,141,169,217,249,25,182,190,95,122,171,242,45,196,225,98,177,114,75,188,184,240,187,105,213,51,221,226,63,183,246,71,90,182,99,26,71,162,86,227,233,190,172,127,157,19,69,1,175,45,120,87,229,205,14,107,27,30,73,130,127,1,44,44,234,213,64,133,92,26,137,181,109,194,76,240,188,120,221,236,81,152,115,14,109,102,221,117,125,186,160,40,5,118,102,169,68,71,124,34,8,195,233,171,229,128,217,8,61,48,103,65,42,152,104,68,34,121,196,12,29,9,88,96,132,68,72,166,104,71,80,150,75,9,3,150,199,241,89,125,227,163,94,197,56,94,238,205,79,19,176,83,21,102,8,112,28,85,238,139,17,182,80,241,241,135,121,141,202,159,3,33,211,203,214,24,188,127,169,209,74,115,12,185,24,3,38,101,32,182,135,11,212,71,180,241,91,253,188,83,23,134,129,139,197,198,153,64,17,17,33,167,59,72,110,206,232,158,66,114,254,196,133,202,22,208,99,235,164,178,186,187,2,48,97,236,171,111,192,158,135,2,225,248,0,119,31,121,76,6,207,177,210,243,49,199,209,243,0,173,110,24,253,78,113,76,191,131,211,206,147,115,249,53,23,170,221,97,204,80,234,116,189,20,4,218,34,78,246,171,233,111,205,79,243,117,157,46,79,41,141,212,194,82,175,59,107,202,162,166,213,139,197,128,243,15,68,250,121,193,246,5,59,215,31,164,57,15,77,41,13,237,141,19,176,195,68,125,31,254,200,194,126,182,131,116,212,88,113,57,119,134,213,74,126,139,200,36,171,28,207,46,70,145,59,72,169,46,247,16,72,73,190,201,94,236,222,90,196,86,40,4,170,1,172,18,192,86,2,227,6,119,41,9,69,36,14,168,175,37,221,142,115,237,235,243,61,37,64,249,208,20,152,134,194,124,116,221,69,11,46,95,154,120,89,12,95,174,42,203,169,4,5,18,57,219,118,232,184,178,116,81,109,67,145,229,29,139,212,252,10,245,64,194,41,76,23,94,123,87,66,144,100,23,23,165,61,101,169,231,201,38,152,142,108,162,191,115,26,164,199,86,216,71,234,206,182,11,173,240,130,219,157,120,143,222,104,127,38,242,152,118,242,233,173,232,235,92,157,56,123,56,210,58,200,83,15,7,26,84,250,68,132,210,22,250,148,30,173,234,58,99,101,80,212,244,27,220,66,43,67,102,170,219,15,186,154,189,87,190,212,22,134,114,239,122,214,170,241,178,17,54,201,7,154,234,224,201,221,67,69,217,106,184,136,27,67,30,196,252,88,19,134,65,15,68,95,152,144,70,25,120,83,242,196,203,35,172,218,184,10,127,70,66,115,114,68,85,134,74,226,136,94,74,190,245,52,85,251,156,174,111,187,116,218,147,169,183,211,118,39,141,174,138,123,72,251,42,203,226,98,107,217,240,186,24,206,171,123,120,168,49,128,31,24,149,166,105,205,205,107,131,251,110,47,239,160,170,126,109,152,197,9,220,73,103,165,140,59,52,39,116,143,102,45,205,149,110,24,157,83,14,109,106,206,172,102,161,51,57,97,94,229,187,108,37,86,230,216,49,207,179,69,0,94,52,237,95,32,44,198,250,145,133,11,71,115,58,168,58,130,47,254,30,192,57,219,85,245,158,158,131,79,145,91,162,28,132,166,71,189,66,65,47,5,126,187,56,158,125,189,132,152,149,105,155,182,137,226,44,156,234,55,49,213,28,249,97,167,51,230,203,180,197,82,195,3,151,82,117,139,192,225,17,205,84,6,237,174,10,181,67,64,235,109,154,64,156,130,27,115,49,177,35,88,160,102,250,34,248,149,156,160,115,134,32,150,32,81,150,164,193,157,51,24,88,183,102,77,31,76,110,53,238,180,194,15,45,184,185,20,202,242,197,201,220,40,237,255,54,26,207,230,177,177,215,131,219,178,161,81,29,185,122,66,2,62,147,42,134,158,222,205,193,232,255,70,87,230,240,63,81,46,115,144,56,175,209,188,46,92,17,57,30,107,50,24,243,29,77,62,218,171,73,191,232,133,16,102,224,239,111,87,63,170,175,200,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("957695b4-45df-4a95-b697-38f30da67709"));
		}

		#endregion

	}

	#endregion

}

