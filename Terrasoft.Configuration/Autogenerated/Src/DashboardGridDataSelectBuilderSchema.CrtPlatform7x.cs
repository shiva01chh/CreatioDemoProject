﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DashboardGridDataSelectBuilderSchema

	/// <exclude/>
	public class DashboardGridDataSelectBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DashboardGridDataSelectBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DashboardGridDataSelectBuilderSchema(DashboardGridDataSelectBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c7cb493a-cf28-49fb-a507-0f063406ee55");
			Name = "DashboardGridDataSelectBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,221,79,227,56,16,127,238,74,251,63,120,123,210,110,42,85,225,157,2,18,180,128,224,118,129,187,178,247,112,8,157,76,227,20,159,18,167,216,14,208,69,252,239,55,254,74,108,39,109,197,241,2,25,207,252,230,211,51,99,24,46,137,88,225,5,65,183,132,115,44,170,92,166,211,138,229,116,89,115,44,105,197,62,127,122,251,252,105,80,11,202,150,104,190,22,146,148,147,232,27,248,139,130,44,20,179,72,207,9,35,156,46,58,60,51,44,113,135,120,75,94,101,75,156,86,101,89,49,255,155,147,244,148,73,42,41,17,45,249,138,188,72,208,164,12,189,20,21,75,191,83,246,212,158,250,94,40,56,205,211,127,204,201,38,122,58,59,129,35,56,252,141,147,37,184,133,166,5,22,98,31,205,176,120,124,168,48,207,206,57,205,148,71,115,162,28,63,169,105,145,17,174,37,86,245,67,65,23,104,161,4,118,240,163,125,116,130,5,105,152,46,32,36,17,224,224,77,131,54,118,156,81,82,100,96,200,13,167,207,88,18,115,184,50,31,232,242,24,124,88,163,127,22,85,81,151,76,76,172,40,97,153,145,14,161,32,201,66,242,122,33,43,14,120,218,106,11,103,60,216,110,123,242,83,16,14,16,204,228,29,213,193,231,24,1,180,10,171,88,60,146,18,95,65,141,141,17,101,18,73,90,146,191,43,70,174,243,92,16,57,118,38,91,139,71,74,253,96,31,61,64,84,146,14,162,7,21,195,176,186,40,70,232,77,139,207,27,62,116,232,9,77,244,161,139,13,28,181,81,26,12,222,183,135,234,134,87,43,194,85,21,134,145,218,219,219,67,7,162,46,75,204,215,71,142,160,11,118,109,53,35,6,170,211,134,119,207,103,182,113,182,145,106,205,86,103,198,149,37,145,198,108,151,97,97,9,59,236,253,65,228,99,181,177,76,158,43,154,161,57,145,83,29,128,107,174,178,121,121,253,240,47,4,218,6,69,21,226,216,58,98,236,250,163,38,124,109,4,44,143,11,183,53,191,82,48,51,202,109,57,28,122,72,233,95,184,168,201,129,97,60,74,134,33,235,112,100,92,164,57,74,190,24,158,244,66,92,65,66,175,249,105,185,146,235,36,228,31,57,197,3,163,33,189,142,53,39,33,101,116,202,234,50,189,193,28,106,74,174,87,164,202,99,134,177,193,27,68,138,38,93,53,55,149,160,155,252,131,242,118,206,57,54,231,219,187,151,51,151,133,77,209,61,206,50,239,179,55,49,54,228,134,116,131,229,163,11,73,75,1,3,155,251,171,238,238,79,73,11,145,78,11,130,249,180,97,154,215,121,78,95,19,15,103,226,167,52,167,133,132,120,128,244,214,116,194,53,165,184,160,191,72,118,166,5,134,33,10,94,46,161,42,245,36,185,133,232,111,133,138,120,29,210,113,4,97,0,98,234,33,138,40,233,21,116,136,93,197,21,169,140,171,171,171,36,137,72,61,229,21,115,184,250,138,117,121,197,49,216,126,217,90,47,250,205,250,210,239,60,250,250,21,245,187,221,230,182,245,184,99,2,18,245,131,254,35,184,9,16,131,83,241,148,66,157,218,18,109,235,103,220,159,154,244,182,154,131,17,11,153,140,198,168,170,101,131,235,174,216,51,230,40,243,203,21,116,48,242,178,99,58,70,35,104,220,129,13,32,149,193,166,64,79,214,106,37,240,67,96,19,129,72,33,72,152,255,45,206,58,45,255,163,182,92,79,153,155,105,16,220,139,40,118,86,201,187,87,42,81,235,246,59,131,109,205,70,136,19,89,243,160,130,222,123,6,65,216,111,68,226,140,36,186,26,44,245,7,94,217,148,204,168,14,54,88,109,175,45,100,84,119,168,163,196,170,245,203,8,17,255,227,16,133,25,75,125,214,31,152,225,37,225,176,63,202,11,88,76,48,91,144,147,181,26,135,73,59,25,195,206,2,110,168,232,205,168,88,21,216,90,106,199,190,175,54,61,163,44,187,217,192,155,244,66,254,78,182,192,129,129,22,109,23,140,57,63,46,40,86,251,134,45,17,93,26,134,59,135,77,19,47,30,81,79,147,135,101,169,217,227,154,178,233,244,253,254,46,127,238,234,67,177,120,229,225,23,108,156,93,181,242,75,76,153,0,215,253,26,247,75,22,68,88,29,22,228,142,182,165,122,114,56,206,186,197,234,95,165,205,197,133,74,93,129,96,105,0,228,4,99,119,238,90,236,123,16,3,97,207,119,63,126,135,189,41,111,189,238,205,100,98,140,27,1,236,221,240,89,141,48,125,50,188,239,185,172,74,97,23,36,106,20,35,213,168,251,12,81,124,149,12,88,55,183,107,27,250,24,167,211,194,122,61,222,20,200,62,230,251,32,19,49,199,71,118,30,211,144,17,84,44,148,47,129,33,42,13,37,233,112,158,190,174,56,17,66,237,94,38,127,45,193,188,44,50,11,160,87,138,112,121,117,216,70,101,205,116,145,93,48,208,3,201,83,194,250,15,23,88,53,140,158,124,78,219,249,118,34,38,16,230,113,3,55,238,216,105,3,163,240,205,236,233,1,246,162,146,152,95,240,138,93,97,78,133,29,165,167,79,117,107,234,224,59,201,165,23,153,13,120,45,71,18,56,102,158,91,239,221,182,29,71,156,211,229,99,168,167,195,157,78,161,151,233,160,64,129,128,217,158,206,32,51,54,8,38,0,233,159,33,176,80,85,154,68,218,194,105,102,4,63,246,8,234,190,109,171,103,120,238,211,140,32,179,80,32,189,81,52,163,175,51,18,3,11,212,227,52,181,2,190,29,189,143,65,128,18,214,230,4,26,57,116,124,215,26,85,84,16,100,86,2,125,195,3,81,83,86,42,162,250,25,121,56,204,109,69,40,128,225,145,189,222,10,83,29,152,255,214,28,236,105,129,109,242,58,15,195,163,185,110,98,52,167,36,67,151,243,235,43,219,106,209,11,133,198,168,187,154,216,10,166,28,184,133,119,248,89,197,75,44,135,71,51,231,144,128,103,170,98,148,0,252,176,70,223,38,223,124,28,155,1,183,123,68,247,62,120,122,24,7,155,247,142,103,125,67,11,141,8,223,164,119,247,209,177,234,221,33,37,157,175,10,42,19,48,177,115,57,181,30,152,203,170,223,219,249,60,210,255,110,154,145,230,197,147,120,172,61,219,207,174,198,101,59,179,185,57,70,100,26,177,36,126,36,70,209,218,160,141,213,126,168,117,33,242,181,233,17,102,185,246,174,32,168,13,93,244,31,176,6,207,141,131,143,119,209,141,43,137,19,119,18,145,166,160,43,118,231,65,183,231,71,253,190,233,226,206,114,8,172,145,53,77,197,96,247,204,166,168,125,24,106,72,212,52,248,249,15,186,141,61,179,43,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c7cb493a-cf28-49fb-a507-0f063406ee55"));
		}

		#endregion

	}

	#endregion

}
