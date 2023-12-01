﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoalDataProviderSchema

	/// <exclude/>
	public class GoalDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoalDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoalDataProviderSchema(GoalDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("12dbef5e-d14d-4dc5-8135-2057c5909f7a");
			Name = "GoalDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("120fd877-7905-4e7f-9414-1956e0c20629");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,86,219,110,27,55,16,125,222,0,249,135,129,210,7,5,49,180,105,147,39,235,2,180,182,147,184,104,28,195,178,147,199,130,222,157,149,153,172,72,133,23,185,142,224,127,207,240,178,171,221,181,100,169,69,145,232,65,16,135,115,57,195,115,56,148,96,115,212,11,150,33,92,162,82,76,203,194,12,142,164,40,248,204,42,102,184,20,131,75,197,178,47,92,204,158,62,89,61,125,146,88,77,63,225,12,111,141,20,222,249,79,45,197,176,222,152,222,105,131,243,245,186,153,84,33,217,105,231,153,194,25,37,134,163,146,105,125,8,111,37,43,143,153,97,231,74,46,121,142,202,251,164,105,10,35,109,231,115,166,238,38,113,29,29,128,139,66,170,185,7,7,133,146,115,48,40,152,48,48,163,68,160,81,45,121,134,131,42,71,218,72,178,176,215,37,207,32,115,117,31,148,133,67,2,235,242,76,67,134,54,164,100,229,97,213,216,79,132,157,31,194,201,18,133,57,163,19,124,195,75,131,234,242,110,129,58,248,197,82,72,110,91,188,18,151,50,73,146,51,41,16,198,240,242,192,175,78,190,90,106,98,12,191,134,37,49,97,24,23,154,44,191,5,203,31,84,95,124,226,230,134,76,175,98,140,200,163,225,181,91,223,71,164,40,242,0,118,43,242,143,172,180,27,160,43,190,100,6,27,216,31,250,253,76,240,16,209,31,73,109,246,0,255,192,109,47,236,127,161,214,31,84,101,140,240,223,147,132,215,198,87,123,224,109,72,124,138,198,208,141,232,224,92,107,113,189,95,1,140,26,210,70,185,155,228,155,113,45,132,102,96,5,51,52,67,210,59,125,69,20,85,196,38,193,109,50,62,150,163,89,117,29,229,46,197,206,202,93,185,108,180,238,91,187,17,182,87,241,14,221,155,140,143,229,40,74,201,76,55,104,83,225,157,212,191,225,88,230,196,253,121,96,186,77,187,66,150,75,81,222,85,173,254,237,102,215,57,51,55,83,91,20,252,31,82,87,47,101,11,158,58,97,244,134,59,52,70,131,216,40,155,25,169,92,57,223,71,240,232,14,81,111,104,184,131,44,128,5,9,14,106,255,180,27,48,90,48,197,230,32,72,4,227,158,165,249,74,25,4,102,110,252,246,38,167,148,140,9,122,61,40,213,85,107,111,48,74,125,224,164,49,14,187,51,183,223,14,129,118,246,231,158,152,228,16,174,153,198,126,103,143,248,216,65,192,123,52,55,114,43,3,205,43,7,199,72,201,57,43,249,55,108,218,251,145,29,29,215,84,212,67,82,104,172,18,224,94,62,66,180,68,101,6,141,12,31,174,63,19,198,81,51,209,164,95,165,8,131,36,17,120,235,195,167,85,144,170,177,172,224,204,150,165,151,253,59,38,242,210,1,24,63,180,13,78,103,130,198,17,220,63,31,238,33,198,245,89,236,148,7,73,211,208,189,241,143,233,173,155,204,158,69,164,107,240,168,72,194,153,232,201,5,253,155,32,133,97,124,153,111,176,126,145,71,105,229,211,80,68,83,13,117,104,192,208,127,107,121,238,113,156,230,7,224,23,10,181,180,42,67,103,184,150,178,4,174,127,39,57,44,241,0,182,80,181,100,138,162,190,90,212,230,74,185,169,29,222,120,247,251,69,247,214,13,155,228,78,233,36,47,229,23,20,68,78,126,78,163,224,34,100,25,109,66,60,233,175,107,28,128,35,55,84,79,78,115,42,25,91,8,150,139,186,5,218,105,244,19,253,99,63,180,87,183,22,118,106,125,140,183,171,181,234,221,71,180,133,177,145,235,171,69,254,211,185,14,24,218,92,255,80,106,237,255,197,236,143,229,238,24,75,226,201,35,216,119,118,7,180,189,137,43,12,212,164,48,188,224,168,90,131,186,197,239,212,48,99,53,100,50,143,20,59,122,177,62,245,127,193,114,64,219,100,249,191,176,72,150,95,122,233,42,36,184,239,109,39,53,148,219,151,215,199,38,104,176,182,141,222,70,159,239,79,141,42,31,59,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12dbef5e-d14d-4dc5-8135-2057c5909f7a"));
		}

		#endregion

	}

	#endregion

}

