﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityConstsSchema

	/// <exclude/>
	public class ActivityConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityConstsSchema(ActivityConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9102873-6482-491c-9f75-f0552ec9bba6");
			Name = "ActivityConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,152,223,111,163,56,16,199,159,91,169,255,3,202,83,87,90,167,24,27,3,218,109,37,48,176,138,116,183,187,218,246,238,157,18,183,199,29,224,8,204,158,162,83,255,247,27,126,36,144,180,73,26,146,187,62,208,0,51,95,127,198,30,143,109,170,50,201,159,181,251,101,169,68,246,233,234,178,26,220,78,185,76,83,17,171,68,230,229,244,139,200,69,145,196,107,147,7,81,20,81,41,159,212,52,200,162,36,245,37,92,115,120,123,117,153,71,153,40,23,81,44,6,54,92,230,79,201,115,85,68,181,216,213,229,63,87,151,23,55,55,55,218,231,178,202,178,168,88,222,117,247,96,166,64,166,212,98,104,82,69,185,42,181,39,89,104,46,48,252,76,212,82,147,143,127,2,207,116,229,125,51,112,95,84,143,105,18,107,224,165,224,95,156,70,101,185,246,227,181,90,9,70,117,187,175,26,238,30,8,161,197,133,120,186,157,172,188,190,71,5,72,37,11,192,248,33,83,49,185,185,211,30,228,116,237,48,108,124,171,245,66,68,115,153,167,75,237,75,149,204,181,29,122,15,82,187,109,12,166,240,162,20,215,19,226,50,219,33,60,64,46,11,48,242,67,140,145,99,97,15,233,58,246,153,30,56,196,230,108,242,161,233,226,147,130,224,252,124,65,240,120,59,8,254,255,4,225,157,51,10,47,222,14,195,115,177,107,185,190,255,95,135,17,22,50,59,95,28,181,218,86,32,204,101,196,209,57,29,31,200,111,179,185,22,173,38,96,25,255,33,178,232,4,226,32,87,112,189,111,100,106,229,91,45,23,127,55,38,215,19,78,169,227,219,196,64,46,229,28,81,79,199,200,115,124,19,217,46,54,56,53,92,39,180,157,253,172,235,66,81,51,84,165,134,160,162,100,139,84,40,49,63,30,121,237,122,223,136,181,180,179,92,137,231,182,140,181,85,101,218,23,153,13,243,217,252,72,208,40,143,69,58,138,179,243,28,98,246,157,106,232,152,135,158,107,35,211,14,216,168,4,120,205,250,21,212,219,155,227,105,193,247,109,80,98,83,159,122,54,61,39,232,44,255,94,200,231,66,148,35,64,123,223,87,164,206,217,72,213,114,33,128,179,89,66,143,71,108,220,30,64,98,87,110,174,13,222,153,141,29,206,67,84,254,117,60,77,237,181,15,230,87,33,20,236,28,142,199,225,81,58,162,115,106,175,30,167,31,189,0,219,4,251,1,71,60,228,122,59,122,158,174,135,39,140,222,239,73,153,168,227,1,27,183,55,9,201,169,132,205,184,175,187,79,206,5,232,79,102,121,44,51,24,128,201,152,185,208,186,14,242,105,131,216,10,29,31,135,54,67,33,97,30,194,20,235,72,103,54,71,134,206,67,162,123,196,33,22,105,136,47,46,142,99,254,86,169,103,57,142,121,229,186,155,153,249,36,116,232,65,230,221,196,168,65,46,69,62,175,119,196,131,53,167,133,191,135,23,98,62,2,189,117,108,192,87,139,201,238,233,13,198,234,61,75,206,33,218,175,82,213,237,142,192,237,60,183,121,135,107,16,135,45,8,211,17,195,186,133,2,29,18,218,101,148,33,204,96,185,231,174,167,59,182,62,166,171,135,137,178,128,243,201,24,248,214,113,55,187,69,77,199,164,166,139,28,195,112,16,13,2,11,121,38,236,76,116,226,217,174,169,7,6,100,202,137,236,253,74,51,106,106,174,156,119,199,192,0,214,101,110,56,190,255,215,37,47,142,32,9,101,177,172,119,1,112,206,171,241,219,248,70,160,55,192,235,237,83,39,188,47,213,123,155,177,172,238,98,1,53,65,101,48,103,70,0,15,188,223,196,238,123,156,26,220,162,156,58,7,183,8,123,10,226,190,56,224,240,56,151,35,34,168,215,232,29,200,161,137,97,142,82,114,134,93,205,162,63,150,104,73,14,143,4,96,148,11,24,201,182,182,231,79,73,145,137,249,136,99,196,240,192,211,41,174,229,182,39,46,100,53,183,29,3,17,26,16,68,93,2,103,210,80,183,17,199,46,38,78,200,136,97,188,55,233,247,199,227,139,56,77,242,115,133,179,82,219,62,27,113,195,100,150,105,35,170,155,24,46,6,140,14,135,95,6,102,1,177,24,49,97,236,206,18,205,44,135,204,170,30,213,121,162,153,229,126,45,182,21,12,148,77,219,177,12,216,64,27,134,143,40,101,1,242,2,7,35,108,152,212,246,96,212,8,245,15,5,19,203,10,248,99,153,86,89,174,213,159,156,142,3,46,85,81,23,227,168,213,225,141,204,106,114,53,95,161,98,53,217,63,61,59,171,147,17,226,86,103,19,161,139,239,0,194,55,168,71,133,170,242,166,72,156,136,33,123,173,77,148,65,35,7,112,124,25,87,117,109,60,153,101,222,9,109,130,172,228,15,80,244,101,243,228,220,104,132,196,246,200,180,242,147,79,218,158,252,108,172,91,128,250,99,230,234,51,42,204,183,193,41,117,196,183,20,237,151,164,84,159,91,192,59,45,133,155,13,186,122,138,13,45,174,63,104,205,39,207,139,87,121,254,177,121,252,42,247,218,199,111,230,66,251,234,245,208,124,236,26,216,238,172,250,241,203,187,10,18,84,159,42,85,218,66,194,121,40,249,41,250,245,14,14,70,99,202,80,167,179,210,255,209,200,239,88,245,176,111,4,212,14,13,196,205,16,74,17,182,124,228,152,80,87,137,30,88,56,36,166,31,146,117,41,122,185,186,124,169,127,212,127,255,2,177,238,227,145,55,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9102873-6482-491c-9f75-f0552ec9bba6"));
		}

		#endregion

	}

	#endregion

}

