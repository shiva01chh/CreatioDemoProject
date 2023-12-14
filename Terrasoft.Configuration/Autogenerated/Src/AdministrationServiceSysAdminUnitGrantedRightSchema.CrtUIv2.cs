﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceSysAdminUnitGrantedRightSchema

	/// <exclude/>
	public class AdministrationServiceSysAdminUnitGrantedRightSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceSysAdminUnitGrantedRightSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceSysAdminUnitGrantedRightSchema(AdministrationServiceSysAdminUnitGrantedRightSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a44ddf3-c923-4ae1-a94b-e2658d99bb08");
			Name = "AdministrationServiceSysAdminUnitGrantedRight";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7787afce-ba74-4e3d-9094-6e447bc8d849");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,75,79,227,48,16,62,23,137,255,96,133,75,144,162,244,190,60,36,40,5,177,18,11,162,176,28,16,7,147,76,91,47,137,157,181,157,138,236,138,255,190,227,56,41,121,245,33,96,1,173,182,18,36,216,227,111,94,223,140,167,112,26,131,74,104,0,228,10,164,164,74,140,181,63,16,124,204,38,169,164,154,9,190,185,241,123,115,163,151,42,198,39,100,148,41,13,177,63,2,57,99,1,156,137,16,162,157,101,155,254,13,220,63,11,84,21,72,88,180,238,15,185,102,154,129,106,34,119,31,136,99,193,253,175,74,112,220,70,129,45,9,19,52,154,12,34,170,212,23,114,16,198,140,51,165,173,43,133,105,40,150,164,247,17,11,72,66,165,102,52,34,129,145,94,40,108,252,239,153,159,18,252,12,244,84,132,8,127,33,217,140,106,35,211,235,247,251,100,87,165,113,76,101,182,95,46,108,149,31,82,249,141,15,82,190,110,25,223,114,189,215,156,233,19,73,185,134,240,146,77,166,218,159,131,246,155,168,187,104,54,141,9,199,204,237,57,147,252,12,84,97,78,67,103,191,174,24,159,78,125,197,241,119,251,57,204,18,84,33,215,70,237,2,77,108,112,200,76,176,144,156,114,5,82,47,114,214,21,247,63,32,208,164,211,25,143,84,119,155,70,109,147,60,61,189,107,196,71,222,114,20,196,20,249,71,135,35,8,82,201,116,54,228,19,198,193,31,76,33,120,24,80,62,124,196,117,13,231,9,216,52,187,14,46,14,166,148,79,160,211,52,103,123,39,199,207,89,153,141,130,41,196,148,104,122,31,65,241,190,71,26,170,171,146,103,148,211,9,72,255,4,52,70,64,83,30,192,97,246,13,67,236,58,139,98,81,87,72,192,62,246,170,58,253,129,4,140,172,149,112,235,234,139,211,246,24,22,163,62,130,241,64,68,105,204,191,211,40,5,229,182,4,42,187,174,115,210,73,39,175,59,51,107,64,181,56,228,45,72,99,29,138,206,160,48,244,105,85,113,53,139,204,20,215,107,139,74,65,132,209,196,67,16,8,25,86,153,95,42,89,204,244,35,60,171,97,21,211,155,26,254,211,184,147,198,108,76,220,130,19,199,160,131,233,177,20,241,209,161,219,138,94,25,190,146,64,54,9,37,215,159,10,34,229,61,28,120,104,219,120,241,119,171,167,231,87,131,221,92,222,212,171,228,35,237,181,55,224,97,76,241,226,147,109,22,54,184,191,188,151,215,131,165,218,40,207,111,109,32,9,58,149,92,237,63,203,85,60,69,241,114,223,28,184,157,179,17,243,136,183,104,160,239,242,101,28,2,78,249,76,60,128,107,131,140,44,112,46,206,71,87,216,11,174,37,187,130,56,137,76,245,224,234,65,24,46,10,153,66,233,67,17,102,35,157,69,70,22,65,207,64,41,164,229,124,213,191,145,52,73,32,244,242,164,95,194,79,108,119,250,88,200,152,234,218,1,187,148,15,13,30,185,196,233,71,224,229,180,92,110,59,247,164,152,26,112,66,48,83,200,50,99,221,66,166,158,64,175,60,218,72,73,201,94,187,123,123,55,223,183,45,27,141,50,54,32,169,177,68,112,92,97,191,96,183,20,221,119,155,88,59,21,40,130,131,146,144,133,59,8,99,87,253,97,156,232,204,202,141,113,226,162,193,148,184,51,42,9,195,41,139,48,222,80,63,175,45,45,179,242,181,183,226,62,55,72,94,195,251,194,178,222,19,9,168,54,42,135,143,1,36,134,46,4,230,58,122,13,139,193,47,222,203,195,207,5,221,179,220,171,249,184,83,169,244,245,139,183,120,93,82,176,164,179,90,94,89,197,85,48,175,94,210,29,118,190,176,200,235,38,123,164,217,60,214,210,244,121,186,128,185,0,70,13,95,61,146,211,97,221,238,64,214,236,12,69,23,249,27,237,161,195,139,151,117,140,147,148,133,107,245,11,43,248,102,221,194,192,189,97,187,104,58,109,144,223,179,93,216,175,119,31,59,101,170,21,67,230,7,20,226,37,196,98,182,112,148,253,124,55,242,10,123,221,127,230,246,93,241,29,227,189,203,167,62,87,183,71,233,28,161,34,176,252,159,51,57,160,249,252,1,26,210,215,239,155,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a44ddf3-c923-4ae1-a94b-e2658d99bb08"));
		}

		#endregion

	}

	#endregion

}

