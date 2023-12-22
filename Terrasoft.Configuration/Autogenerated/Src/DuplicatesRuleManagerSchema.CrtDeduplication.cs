﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesRuleManagerSchema

	/// <exclude/>
	public class DuplicatesRuleManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesRuleManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesRuleManagerSchema(DuplicatesRuleManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb76e6bf-9b75-4ef4-88d8-6718cee3fe1e");
			Name = "DuplicatesRuleManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,109,111,26,57,16,254,76,165,254,7,31,39,85,139,20,45,247,153,148,68,73,128,10,41,125,81,104,116,31,78,167,202,217,29,192,170,215,230,108,47,23,148,230,191,119,252,178,97,215,236,230,202,165,141,20,136,237,153,199,243,60,51,30,59,130,22,160,55,52,3,242,25,148,162,90,46,77,122,37,197,146,173,74,69,13,147,34,157,64,94,110,56,203,220,232,245,171,135,215,175,122,165,102,98,69,22,59,109,160,56,141,198,232,205,57,100,214,88,167,239,64,128,98,217,129,205,53,19,255,236,39,87,92,222,81,62,26,93,201,162,192,13,175,229,106,133,211,251,245,122,100,10,186,230,211,25,205,140,84,12,52,90,160,205,239,10,86,24,4,201,56,213,122,68,38,129,4,232,155,146,195,123,42,232,10,148,51,28,14,135,228,173,46,139,130,170,221,89,24,127,82,114,203,114,208,164,0,179,150,185,38,75,169,72,97,157,236,198,121,93,18,162,16,79,19,42,114,178,100,220,128,210,105,5,58,172,161,254,53,129,37,45,185,185,100,34,71,140,196,236,54,32,151,201,188,53,174,193,224,111,116,217,148,119,184,228,9,180,199,79,70,164,29,0,189,31,28,185,39,25,48,169,218,80,97,80,138,79,138,109,209,222,175,111,252,128,100,118,157,104,163,44,193,107,160,249,34,91,67,65,63,96,125,144,49,233,219,153,254,105,128,4,145,123,212,230,22,51,6,60,239,194,199,205,13,146,81,136,35,5,223,145,57,166,153,216,223,177,253,12,97,99,193,24,155,126,80,73,191,81,119,253,193,105,29,236,9,229,86,131,66,102,194,23,28,249,82,54,198,237,62,145,98,55,176,145,154,97,229,236,200,151,188,99,229,63,136,59,109,85,105,203,207,210,119,105,11,236,125,10,91,115,148,88,131,94,196,160,73,224,196,153,116,7,220,21,239,128,60,56,207,72,15,212,186,69,160,94,39,109,180,127,70,145,94,239,241,121,89,222,251,179,211,84,196,29,12,38,214,216,23,76,46,177,186,21,44,199,253,136,226,213,26,178,175,190,28,230,122,178,47,3,187,54,189,103,218,244,135,103,53,121,239,164,228,164,211,54,121,87,178,156,128,48,204,236,124,81,223,178,188,82,104,75,21,209,110,18,201,70,114,165,211,154,79,85,161,51,60,191,115,119,148,50,184,220,221,206,243,36,70,246,162,42,48,165,18,21,246,111,99,34,74,206,201,155,55,54,206,11,206,155,124,117,50,72,47,196,46,185,39,227,51,114,159,214,143,222,56,64,164,118,56,168,203,126,188,146,23,72,107,11,199,232,217,237,145,132,86,161,159,98,173,36,13,204,159,227,105,91,166,165,106,191,211,106,23,43,142,155,104,163,255,255,216,215,218,202,97,44,77,206,243,169,40,11,80,244,142,195,219,166,225,228,243,199,179,46,54,77,202,157,7,201,6,16,251,70,197,118,114,80,125,11,208,26,191,175,40,10,240,34,234,241,206,62,115,131,99,249,183,195,28,93,0,206,164,151,254,137,225,67,179,16,186,242,142,133,225,157,122,137,110,152,68,215,212,121,84,79,35,63,198,14,123,97,22,116,139,241,213,128,92,240,104,251,1,143,229,71,53,45,54,198,151,37,202,78,85,182,94,212,88,125,251,70,90,87,162,234,252,5,57,58,33,63,57,87,178,84,25,236,25,84,248,68,31,144,126,89,42,107,103,58,40,142,88,45,57,142,226,57,52,111,147,60,142,245,231,233,62,243,15,184,31,85,219,155,183,107,30,160,252,229,99,185,204,27,119,78,179,83,216,187,231,185,222,113,216,44,2,162,191,107,216,146,36,17,96,184,112,170,45,171,68,54,173,82,251,113,41,243,221,121,26,194,61,71,197,237,235,221,101,211,207,217,156,10,248,151,116,80,175,54,232,225,187,191,44,68,120,47,238,221,211,253,252,73,176,108,188,44,107,150,181,186,12,150,55,82,26,63,235,81,116,211,225,96,185,242,195,135,0,24,202,120,23,190,149,39,146,98,191,232,49,30,131,182,143,238,19,31,165,233,84,41,169,102,82,21,212,36,125,55,64,12,119,122,80,92,252,191,99,235,254,68,44,159,29,130,121,127,248,227,177,31,229,42,36,194,38,231,37,117,123,89,242,175,47,188,207,90,32,90,122,186,133,252,241,94,112,108,95,239,236,22,191,188,65,71,143,86,63,219,156,196,185,250,207,119,77,36,233,6,43,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb76e6bf-9b75-4ef4-88d8-6718cee3fe1e"));
		}

		#endregion

	}

	#endregion

}

