﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysAppIconsComporatorSchema

	/// <exclude/>
	public class SysAppIconsComporatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysAppIconsComporatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysAppIconsComporatorSchema(SysAppIconsComporatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c8e6dcdc-d9ad-4ba0-b89d-7abdd0701ccd");
			Name = "SysAppIconsComporator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,219,110,219,56,16,125,118,129,254,3,171,125,145,129,66,198,190,38,118,138,248,210,66,192,182,201,198,221,221,135,162,88,208,210,216,17,32,137,50,73,37,43,164,254,247,29,94,116,163,101,59,241,131,1,145,156,153,51,103,206,112,72,72,78,51,16,5,141,128,124,7,206,169,96,91,25,44,88,190,77,118,37,167,50,97,249,251,119,47,239,223,141,74,145,228,59,178,174,132,132,236,218,249,14,254,72,242,125,187,216,245,195,225,212,122,176,156,159,220,90,229,50,145,9,136,147,7,62,211,72,50,110,78,224,153,223,56,236,16,41,9,115,9,124,139,185,92,145,16,161,221,22,69,24,177,92,44,88,86,48,76,134,113,125,122,50,153,144,169,40,179,140,242,234,198,126,55,150,100,203,56,161,69,145,38,145,206,158,36,202,3,137,26,23,129,181,184,231,236,41,137,65,144,12,228,35,139,5,145,140,108,147,60,38,176,47,147,39,154,66,46,73,76,37,173,207,79,39,157,144,69,185,193,0,36,105,162,158,130,59,122,209,144,143,48,235,133,7,144,37,71,112,28,82,42,33,62,130,77,146,152,108,42,34,42,65,146,140,238,0,191,131,198,217,196,245,54,45,40,167,153,214,195,204,67,155,80,153,132,177,119,179,238,218,79,39,250,152,182,250,82,98,128,47,32,31,76,124,5,126,94,173,173,165,175,119,91,63,99,83,170,131,250,87,37,131,60,54,85,235,85,112,145,82,33,174,200,133,226,37,249,35,240,68,198,44,34,19,133,228,199,18,182,180,76,229,28,249,71,181,248,178,42,128,109,253,97,82,199,227,159,109,5,34,21,111,56,220,105,13,213,69,105,64,227,190,164,185,68,224,247,28,107,47,193,236,23,230,131,40,123,73,132,228,74,201,232,36,74,97,185,249,134,60,147,25,241,238,244,247,234,63,136,74,116,238,93,95,52,252,74,115,36,52,238,219,219,197,174,27,141,176,207,114,31,49,47,85,19,41,208,154,139,51,66,235,28,127,173,128,74,1,28,205,114,136,148,28,189,155,169,0,204,135,195,118,230,253,213,223,154,220,96,31,40,254,34,232,169,203,86,104,176,6,126,223,7,233,71,27,19,117,99,141,70,206,161,153,115,76,83,125,56,79,20,118,121,1,92,221,69,78,109,7,121,122,93,146,195,12,214,53,119,64,59,159,47,100,7,242,154,8,245,119,1,250,87,115,47,157,208,228,64,239,30,117,172,165,49,217,18,63,20,70,103,107,224,79,192,253,113,189,55,226,250,14,34,159,177,243,172,43,91,45,237,196,24,249,253,91,96,164,89,191,104,123,100,117,232,103,176,97,44,37,46,46,11,203,122,118,100,130,35,167,110,144,239,120,67,4,166,133,102,253,150,252,245,203,36,246,54,211,78,83,14,130,213,212,158,39,233,4,251,79,148,235,57,242,55,77,75,80,177,77,40,142,114,246,151,3,235,99,7,56,70,178,59,118,98,241,0,203,110,151,124,111,200,133,103,171,164,66,139,2,3,229,240,76,214,152,58,196,232,35,130,184,228,224,80,251,145,120,82,20,255,162,231,182,95,195,184,157,6,181,75,81,4,255,36,242,241,94,117,57,72,5,96,221,78,154,143,228,72,40,246,252,93,41,139,82,246,173,154,40,104,55,68,144,74,51,180,61,55,175,84,101,124,79,113,236,141,173,111,243,178,240,53,193,155,186,186,152,173,67,224,42,23,152,239,114,222,46,117,228,143,248,140,37,248,173,15,235,223,240,215,0,109,208,99,8,52,107,62,69,160,116,81,35,236,37,54,254,20,232,172,8,21,118,10,88,207,170,37,63,152,149,32,20,223,202,52,189,227,171,172,144,149,63,16,175,69,171,17,233,27,54,140,109,89,21,35,131,70,54,82,221,74,214,202,174,30,142,187,88,57,10,52,134,183,234,255,156,242,65,236,17,104,79,86,98,29,61,66,70,255,44,129,87,190,133,137,199,144,197,84,179,121,27,199,190,250,94,112,192,72,102,181,167,57,225,155,69,53,78,40,79,4,203,117,75,175,246,37,77,81,199,63,106,69,94,169,222,208,127,63,3,87,157,157,14,1,245,88,173,22,44,77,155,57,163,194,35,230,149,179,227,244,204,145,15,101,233,152,96,86,92,200,59,110,31,56,117,190,150,115,107,246,1,75,137,18,32,159,236,66,128,55,190,154,43,232,166,204,114,163,160,171,11,5,50,88,59,212,158,35,253,168,64,74,73,71,30,220,219,183,123,192,246,40,210,221,137,225,53,66,125,96,207,11,86,226,11,122,70,126,55,82,107,235,108,147,211,33,76,134,216,2,183,233,51,173,196,26,20,109,104,132,143,21,232,51,37,246,175,25,247,237,204,116,159,68,238,147,179,126,158,188,237,13,220,31,79,237,134,17,159,240,219,26,141,177,154,237,190,42,95,127,86,159,24,142,78,98,135,129,183,182,94,195,223,255,68,232,169,161,251,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c8e6dcdc-d9ad-4ba0-b89d-7abdd0701ccd"));
		}

		#endregion

	}

	#endregion

}

