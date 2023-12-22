﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SchemaDataBindingStructureObtainerContextSchema

	/// <exclude/>
	public class SchemaDataBindingStructureObtainerContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SchemaDataBindingStructureObtainerContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SchemaDataBindingStructureObtainerContextSchema(SchemaDataBindingStructureObtainerContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("064c3c14-ac3c-46c2-b969-a866bddca8f1");
			Name = "SchemaDataBindingStructureObtainerContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f6d1296c-7e61-436c-80dc-2684cfa4b28a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,203,142,219,54,20,93,79,128,252,3,235,108,108,52,144,247,25,143,129,120,156,9,140,166,109,80,39,171,162,40,104,233,202,38,42,75,42,73,57,35,4,243,239,185,124,201,148,100,61,166,14,90,160,89,4,150,196,251,60,231,62,56,41,61,130,200,105,8,228,19,112,78,69,22,203,224,62,75,99,182,47,56,149,44,75,95,190,248,250,242,197,77,33,88,186,39,219,82,72,56,222,54,158,241,124,146,64,168,14,139,224,61,164,192,89,216,58,243,129,165,127,159,95,250,182,56,116,189,15,30,104,40,51,206,64,224,9,60,243,138,195,30,141,144,251,132,10,241,134,108,195,3,28,233,154,74,186,98,105,132,226,91,201,139,80,22,28,208,161,226,152,106,153,249,124,78,22,162,56,30,41,47,151,246,217,8,146,8,37,201,206,136,146,80,139,144,156,103,57,112,137,38,3,39,60,247,164,243,98,151,176,144,132,202,129,17,246,111,190,106,31,42,199,31,24,36,17,122,254,81,171,49,223,154,14,234,23,70,1,73,17,156,160,58,228,59,226,60,17,146,43,239,127,193,131,183,61,250,54,194,5,24,103,28,177,46,114,12,30,162,126,221,187,44,75,80,242,65,73,124,214,2,227,76,80,242,23,148,163,84,255,4,165,85,249,10,210,200,36,169,158,49,164,162,208,89,205,248,184,188,85,199,59,28,208,111,114,202,233,81,103,247,110,162,254,159,44,253,132,47,230,250,187,239,239,16,212,83,139,131,146,159,17,85,48,55,55,10,19,114,167,95,221,234,23,181,84,226,151,152,38,162,250,132,169,168,189,122,250,55,163,108,29,103,190,171,147,101,23,125,6,116,96,76,190,172,225,197,149,217,125,109,184,83,115,176,122,135,6,71,103,159,53,136,237,161,192,44,49,43,20,26,236,52,111,27,47,71,55,167,238,182,228,78,168,44,19,209,110,82,215,180,164,43,154,145,78,101,22,19,72,37,147,37,145,25,217,129,118,105,168,129,88,216,222,105,57,227,218,80,163,250,72,229,1,132,178,113,38,28,137,89,34,129,219,4,12,153,251,253,15,140,76,157,55,220,49,10,7,26,87,10,16,217,184,4,61,225,111,150,146,44,133,86,242,7,27,218,170,72,163,164,55,64,175,4,5,73,152,144,218,46,154,232,215,255,1,79,46,134,234,100,105,181,247,134,171,52,41,52,195,3,75,34,34,156,6,113,149,253,37,217,164,56,247,171,231,81,30,68,144,99,9,9,195,43,118,181,7,107,163,174,229,195,115,138,119,147,34,113,98,220,134,222,144,77,183,173,95,119,146,50,12,183,179,146,43,53,24,163,8,57,219,33,214,148,124,161,165,166,243,30,164,84,117,113,161,194,207,120,244,213,58,171,212,143,114,210,21,254,69,48,222,131,60,27,213,238,133,5,231,8,137,43,119,227,101,223,156,225,128,178,169,88,46,4,0,9,57,196,119,147,110,183,38,243,229,98,238,36,148,138,238,163,196,132,80,61,79,63,11,85,213,72,52,189,107,146,162,246,56,187,253,14,189,217,37,13,213,74,120,148,157,0,99,75,227,37,201,51,68,162,14,105,229,59,242,251,59,119,240,150,111,157,13,157,179,19,206,180,30,208,85,34,177,193,186,212,117,21,158,209,67,26,105,255,179,158,247,129,5,238,236,84,38,81,0,162,17,131,6,243,0,199,93,210,185,67,58,85,110,192,188,181,231,237,204,159,116,220,100,130,73,95,87,90,67,76,139,68,90,24,84,127,38,162,136,99,246,216,154,198,30,200,22,146,177,142,86,16,42,27,91,163,29,253,29,198,124,242,143,215,228,193,21,171,65,171,129,34,179,219,85,131,3,24,68,139,20,93,203,83,229,243,207,32,15,217,56,190,174,10,53,171,226,34,73,46,36,223,71,108,135,69,137,13,136,61,142,221,139,205,105,220,140,207,58,172,130,214,110,235,154,214,131,114,195,179,169,42,189,205,136,122,147,115,165,100,121,128,77,183,70,5,69,92,183,228,26,243,46,209,70,73,157,225,63,218,51,248,227,2,161,158,153,250,225,170,172,79,8,115,79,223,81,161,131,193,152,246,93,101,218,202,53,52,246,192,201,242,157,63,98,58,174,37,215,77,151,115,9,246,204,153,183,121,158,148,43,12,105,107,35,114,88,52,61,118,168,156,40,215,41,112,233,71,254,107,4,204,223,43,202,0,83,182,208,250,6,171,110,57,157,221,250,64,251,90,131,198,252,91,121,158,76,27,21,248,186,237,235,224,53,114,13,184,70,28,209,18,249,114,96,225,161,194,83,109,164,168,157,208,52,34,84,165,134,48,105,151,53,149,20,228,15,180,113,251,95,112,192,225,191,42,253,138,236,99,65,232,202,23,41,112,177,170,47,195,162,101,93,175,248,84,230,86,92,253,218,164,182,216,113,35,158,86,234,173,24,139,201,180,46,134,87,92,236,71,206,165,170,95,180,24,221,225,199,83,203,155,11,92,174,153,156,225,120,30,179,119,214,104,157,117,80,186,73,227,97,210,110,129,242,80,95,17,85,248,120,79,163,85,182,198,114,80,205,145,10,160,73,179,159,143,98,159,74,68,15,207,52,52,151,240,180,140,170,121,224,176,195,53,3,40,150,225,84,161,225,86,32,21,33,130,185,206,142,152,182,224,222,172,230,246,9,13,120,170,103,193,111,112,2,46,96,58,171,216,160,52,73,195,174,106,167,178,110,77,235,62,24,180,52,191,180,192,15,13,94,57,32,213,71,123,246,201,35,144,253,170,68,158,55,127,134,254,246,160,135,207,133,123,210,129,1,87,68,96,33,77,26,247,151,209,247,150,255,188,47,153,213,236,196,184,44,48,138,241,23,161,85,57,118,80,249,237,160,209,220,122,231,197,136,59,179,126,231,255,251,6,233,240,138,51,74,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("064c3c14-ac3c-46c2-b969-a866bddca8f1"));
		}

		#endregion

	}

	#endregion

}

