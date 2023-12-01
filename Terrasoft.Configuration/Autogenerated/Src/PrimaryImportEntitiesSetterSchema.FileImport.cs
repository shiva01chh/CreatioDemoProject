﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrimaryImportEntitiesSetterSchema

	/// <exclude/>
	public class PrimaryImportEntitiesSetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrimaryImportEntitiesSetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrimaryImportEntitiesSetterSchema(PrimaryImportEntitiesSetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0015edbc-7f2c-44cd-8e97-b3d34bab3466");
			Name = "PrimaryImportEntitiesSetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,118,129,254,15,156,7,20,18,96,200,239,77,162,194,113,146,194,104,214,6,115,182,151,162,15,180,124,118,184,200,146,75,82,105,141,52,255,251,142,95,18,41,203,178,177,117,243,139,229,211,241,62,126,188,223,241,232,130,110,64,108,105,6,228,30,56,167,162,92,201,100,90,22,43,182,174,56,149,172,44,146,27,150,195,108,179,45,185,124,253,234,249,245,171,65,37,88,177,38,243,157,144,176,57,107,253,198,165,121,14,153,90,39,146,247,80,0,103,217,158,206,45,43,190,238,9,239,225,187,108,132,126,44,28,14,201,147,235,66,50,201,64,28,84,184,161,153,44,185,209,64,157,95,57,172,49,52,50,205,169,16,111,201,29,103,27,202,119,38,57,103,107,14,82,2,215,234,227,241,152,156,139,106,163,148,82,251,123,82,16,86,8,73,11,68,172,92,17,249,192,4,201,148,57,130,15,28,161,196,204,217,34,7,178,42,57,17,104,75,69,181,53,142,8,211,158,8,88,87,137,243,49,246,156,124,190,130,21,173,114,121,201,138,37,174,141,228,110,11,229,42,154,245,4,27,143,200,71,220,70,114,65,10,252,66,229,62,221,248,11,58,217,86,139,156,101,54,240,30,237,183,164,207,47,26,122,214,64,53,192,98,246,146,87,10,116,133,175,246,98,52,218,88,106,193,148,3,149,32,66,68,49,95,212,4,32,25,135,213,197,176,199,255,112,156,38,181,237,113,219,248,249,150,114,186,209,144,92,12,179,50,175,54,133,184,227,101,6,66,148,124,152,78,141,4,247,198,138,146,243,177,94,161,13,88,128,122,156,71,179,143,101,113,7,92,48,172,223,66,90,115,147,245,26,161,160,152,63,105,187,140,201,69,74,166,45,33,238,89,91,239,204,66,10,197,210,160,26,66,140,122,91,224,42,14,85,192,165,68,182,193,178,15,227,189,60,187,33,219,58,91,228,88,98,123,57,60,147,53,200,51,242,210,31,248,111,32,31,202,165,161,221,19,110,123,79,204,239,65,10,195,146,29,121,132,221,169,155,108,86,12,83,189,81,187,96,63,181,46,7,89,241,66,216,247,218,242,249,216,9,13,6,58,50,130,53,172,104,139,97,24,213,15,176,139,236,34,227,99,68,102,215,69,181,1,78,145,234,231,70,61,117,59,169,184,40,70,202,222,224,166,42,50,251,122,68,202,197,95,8,176,251,118,234,127,210,188,130,187,82,72,139,39,170,78,116,3,85,116,174,242,60,38,207,218,212,92,91,185,172,88,190,4,236,44,11,245,26,190,145,64,28,197,103,90,215,196,58,207,30,96,67,205,110,53,125,153,8,79,44,208,138,201,40,49,218,137,149,27,59,216,195,128,102,15,36,178,128,152,136,117,175,97,69,144,174,139,178,195,117,224,16,253,5,254,241,144,144,151,59,101,34,106,140,219,44,6,6,40,31,39,251,130,173,72,116,20,189,16,190,193,192,91,208,100,141,238,167,141,60,242,99,115,81,188,16,200,5,28,48,115,36,10,47,169,209,41,46,107,159,230,75,44,146,201,118,139,124,242,179,181,58,70,197,84,47,150,67,114,95,154,82,136,98,124,188,45,191,213,213,240,114,140,104,200,3,71,54,187,165,154,79,226,84,218,233,103,192,150,40,134,169,233,148,164,17,237,179,208,95,138,174,109,33,12,83,36,153,243,127,152,186,31,14,197,218,77,228,46,150,98,206,104,197,212,233,212,43,225,200,196,126,87,135,238,101,97,216,236,91,51,202,102,125,74,154,60,92,189,221,98,247,236,108,12,150,183,254,123,71,219,154,110,190,113,187,88,17,110,223,75,247,146,43,16,56,118,232,233,141,44,189,231,154,179,137,167,209,216,210,180,250,197,91,96,123,194,31,179,101,114,253,181,162,185,136,188,125,253,189,44,101,253,62,38,63,126,144,96,233,76,32,200,141,105,164,13,2,94,212,12,118,21,62,240,161,73,38,203,101,228,27,153,238,181,132,151,253,218,247,45,28,45,248,185,62,89,190,51,161,231,50,55,136,17,89,118,205,102,255,113,241,59,87,120,96,181,3,250,73,172,217,159,128,14,118,42,55,16,145,39,221,217,182,168,226,70,6,21,24,213,74,225,136,100,57,246,84,178,165,194,213,206,74,110,74,234,165,83,64,76,67,197,180,78,222,144,237,36,182,141,200,79,60,97,3,202,218,220,97,233,242,65,160,251,184,219,213,105,30,187,218,12,218,56,216,129,124,132,60,178,183,186,67,48,137,40,82,59,224,106,186,217,227,26,220,240,98,124,54,179,140,27,98,58,3,28,29,131,45,246,78,225,78,152,212,5,82,82,28,234,163,58,130,216,63,135,131,78,240,210,217,200,108,142,44,248,81,248,212,186,110,39,237,178,246,215,152,220,125,73,98,192,63,0,245,104,111,184,29,53,13,236,36,80,52,42,173,16,92,247,108,208,32,111,222,132,81,249,228,217,237,207,46,131,62,101,187,207,46,128,193,2,145,124,108,245,89,251,213,189,93,170,237,54,177,121,227,133,237,164,142,233,248,214,228,79,25,175,57,119,69,37,213,210,123,188,184,165,159,191,144,122,190,17,193,171,176,108,93,106,182,135,27,225,187,214,16,154,204,65,13,173,106,248,81,119,39,69,189,19,66,80,234,137,153,184,212,83,240,50,86,195,209,132,115,186,11,135,163,227,119,150,246,85,150,21,15,192,153,92,150,153,189,167,246,93,148,241,162,234,93,42,93,195,252,95,58,164,3,250,137,114,91,113,26,140,155,146,111,168,249,115,226,194,252,29,98,254,42,209,252,176,198,90,138,105,164,54,192,187,225,79,248,26,221,23,18,247,220,214,233,1,133,200,93,191,213,22,12,71,7,43,164,62,253,110,24,23,242,19,183,255,132,68,113,28,155,154,180,181,217,113,216,248,200,213,40,5,196,238,76,94,101,27,178,217,41,204,233,19,252,11,119,6,143,96,252,247,71,120,85,206,255,32,160,131,246,222,5,227,63,6,27,197,7,235,219,202,194,146,71,25,126,254,6,72,212,25,56,13,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0015edbc-7f2c-44cd-8e97-b3d34bab3466"));
		}

		#endregion

	}

	#endregion

}

