﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DuplicatesRuleServiceSchema

	/// <exclude/>
	public class DuplicatesRuleServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DuplicatesRuleServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DuplicatesRuleServiceSchema(DuplicatesRuleServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a40564cc-484e-41c7-ad98-72531a036970");
			Name = "DuplicatesRuleService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,87,223,111,219,54,16,126,118,129,254,15,55,15,40,228,33,149,138,21,88,81,199,118,208,57,63,230,97,142,3,39,67,31,140,109,160,165,179,195,69,18,85,146,114,231,21,249,223,119,36,37,91,150,101,39,221,219,150,135,216,228,221,125,199,187,251,200,59,167,44,65,149,177,16,225,14,165,100,74,44,180,63,20,233,130,47,115,201,52,23,169,127,142,81,158,197,60,180,171,151,47,190,188,124,209,202,21,79,151,112,187,86,26,147,211,218,154,172,227,24,67,163,172,252,43,76,81,242,112,79,231,22,229,138,135,56,22,17,198,71,133,254,7,66,90,89,215,199,245,62,226,124,171,112,141,159,53,185,55,177,252,172,170,150,213,24,37,250,151,44,212,66,114,84,164,65,58,223,74,92,146,35,24,198,76,169,46,156,23,97,163,186,228,177,70,169,206,239,38,86,47,203,231,36,128,208,168,29,208,106,153,52,149,138,87,57,143,96,20,193,23,88,162,62,5,101,254,61,86,228,191,112,165,123,91,156,105,30,163,195,26,64,129,185,103,250,232,14,140,105,228,206,124,252,252,91,196,50,132,153,201,203,100,254,39,21,202,27,99,50,71,73,217,228,44,230,127,187,162,79,50,61,74,59,191,29,14,182,6,105,226,53,17,149,71,184,145,34,35,153,166,220,118,225,198,66,56,5,235,216,72,73,184,246,202,47,215,196,66,232,67,91,133,247,152,48,179,106,91,231,165,119,165,165,45,252,70,92,79,200,211,208,161,136,243,36,61,8,61,220,136,247,203,244,52,184,20,66,187,195,57,28,181,235,195,22,216,57,26,192,180,174,251,245,177,112,117,142,154,241,120,215,203,92,136,24,70,133,168,9,180,70,151,77,177,198,168,239,69,84,43,84,1,42,86,116,101,120,132,14,253,226,83,206,98,229,9,75,28,160,143,14,88,162,183,36,234,92,166,112,133,250,39,166,238,135,116,37,189,14,244,251,70,197,223,217,52,119,177,96,239,158,11,158,234,26,130,3,207,83,74,87,248,128,81,177,110,173,152,132,251,66,139,242,225,85,120,241,77,31,210,60,142,225,172,66,150,221,19,64,23,222,184,99,180,90,124,1,94,165,242,133,113,233,183,213,170,58,217,124,255,14,222,190,127,215,129,223,155,76,201,239,118,243,176,223,71,192,88,225,115,221,236,51,102,235,109,79,118,196,169,251,56,238,172,228,79,67,213,54,85,46,173,220,238,99,165,162,53,134,125,253,43,85,188,233,86,49,8,2,232,169,60,73,152,92,15,138,245,20,51,137,10,83,173,128,80,51,97,40,179,16,18,162,13,10,72,130,81,16,137,132,241,212,135,18,39,168,0,205,10,47,212,231,180,164,22,96,46,209,236,131,202,174,81,15,69,146,209,11,56,231,49,215,235,41,126,202,185,196,196,184,243,170,139,177,75,223,19,38,70,203,47,54,162,167,222,210,77,224,77,47,233,230,33,149,66,211,197,195,168,184,63,210,180,70,132,209,46,212,152,165,108,137,18,254,136,154,182,79,157,101,1,116,200,182,121,183,63,176,21,111,6,134,179,51,240,14,136,250,174,218,174,223,174,13,183,122,205,142,7,94,167,115,250,47,94,171,58,87,236,198,208,188,26,192,13,85,52,213,6,92,119,129,168,58,208,88,186,0,254,69,47,180,242,55,72,65,29,170,151,49,201,18,72,233,86,247,219,14,206,221,186,95,121,212,30,92,236,224,83,183,247,123,129,53,216,218,187,171,163,6,163,231,159,166,23,148,70,182,35,76,136,6,86,169,74,219,214,140,6,159,81,186,18,15,232,185,196,152,254,112,51,185,189,107,159,192,143,34,90,223,234,117,108,184,74,106,99,84,138,114,188,217,245,63,74,150,101,24,77,105,0,164,105,9,79,108,113,13,97,81,233,75,33,19,166,119,12,221,150,157,168,78,160,52,58,174,231,250,211,204,197,209,133,66,225,198,164,6,105,60,240,182,13,237,194,198,220,208,208,108,17,233,85,218,38,201,208,197,170,123,69,239,174,213,163,222,147,76,61,238,228,154,188,42,244,106,186,39,32,114,13,166,159,228,198,240,213,171,102,230,27,198,30,56,131,177,171,54,181,70,38,78,93,33,97,81,140,115,49,89,194,124,109,203,61,138,158,73,59,167,220,30,24,223,192,163,131,20,179,114,227,225,127,67,160,130,15,163,139,52,79,40,134,121,140,141,227,50,77,162,3,51,64,52,201,84,73,22,151,197,163,28,113,42,91,106,24,102,184,6,120,118,152,30,205,78,201,212,89,118,109,195,174,18,229,191,95,15,123,63,111,217,10,171,17,55,253,30,130,72,139,50,227,196,212,187,201,249,164,11,60,201,98,219,40,65,17,68,209,182,239,181,206,186,65,160,85,72,191,207,94,107,166,30,130,185,20,159,21,6,195,233,248,245,219,119,239,127,248,190,90,183,5,77,163,88,77,234,51,6,16,218,171,254,253,3,123,207,16,22,1,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a40564cc-484e-41c7-ad98-72531a036970"));
		}

		#endregion

	}

	#endregion

}

