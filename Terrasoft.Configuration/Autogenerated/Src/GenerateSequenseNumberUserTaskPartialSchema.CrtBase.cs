﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GenerateSequenseNumberUserTaskPartialSchema

	/// <exclude/>
	public class GenerateSequenseNumberUserTaskPartialSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GenerateSequenseNumberUserTaskPartialSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GenerateSequenseNumberUserTaskPartialSchema(GenerateSequenseNumberUserTaskPartialSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0d33972-393e-498c-8a2a-f1f0b8ee7fe8");
			Name = "GenerateSequenseNumberUserTaskPartial";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,75,79,219,64,16,62,7,137,255,176,164,23,71,68,142,212,222,26,18,137,188,16,82,161,136,208,222,55,246,36,177,106,239,186,187,99,32,66,253,239,157,245,110,236,117,226,136,82,14,65,59,207,111,190,121,88,240,12,116,206,35,96,79,160,20,215,114,141,225,84,42,8,31,148,140,64,107,122,136,117,178,41,20,199,68,138,243,179,183,243,179,78,161,19,177,97,203,157,70,200,134,213,219,247,207,50,41,218,53,10,78,201,195,217,228,164,106,46,48,193,4,244,73,3,135,182,214,27,41,33,92,2,34,61,53,27,29,122,52,234,10,61,83,138,65,81,62,41,216,144,130,77,83,174,245,87,118,3,2,200,20,150,240,187,0,161,225,190,200,86,160,126,104,80,79,92,255,42,61,6,131,1,187,210,69,150,113,181,27,187,247,35,228,10,52,8,212,172,32,91,134,100,204,80,178,141,11,199,164,138,19,193,83,38,202,120,225,62,204,192,139,147,23,171,52,137,88,206,21,38,100,25,25,64,239,226,233,188,149,152,170,50,238,0,183,50,166,66,136,40,132,8,33,182,250,50,91,34,182,160,18,140,101,196,6,38,99,39,223,27,49,249,76,172,37,49,176,149,148,41,187,21,8,138,224,206,95,33,42,16,2,199,186,125,18,119,196,41,194,43,178,200,254,239,49,51,45,157,78,178,102,65,217,193,221,50,218,66,198,217,197,136,10,78,211,189,190,243,204,21,3,223,96,212,116,232,249,143,97,237,67,121,4,225,52,5,142,246,73,67,67,194,180,82,56,235,71,208,69,138,83,73,149,140,78,144,23,248,8,250,94,236,158,141,241,167,252,85,128,133,18,12,85,81,14,178,145,150,60,131,136,45,213,167,120,47,187,232,145,238,117,216,141,138,9,172,153,46,65,209,62,214,35,113,60,19,86,66,35,193,51,38,104,131,71,93,31,124,119,108,249,98,186,124,134,87,131,210,178,221,177,174,179,59,54,212,121,133,31,59,218,234,245,120,137,202,44,25,110,57,50,85,207,56,175,6,59,62,170,227,106,176,119,46,39,204,14,245,115,162,176,160,161,214,54,222,137,198,52,102,167,217,165,102,179,253,166,185,217,114,145,125,175,123,170,155,166,192,23,133,70,54,244,29,34,26,149,59,90,37,119,21,90,124,74,209,37,235,78,157,101,183,225,79,91,138,22,254,251,17,190,85,182,205,24,186,62,74,251,36,20,193,42,195,121,150,227,206,154,155,85,240,108,141,221,45,157,102,178,21,240,114,120,9,131,99,142,58,196,226,117,156,37,226,49,217,108,209,220,202,53,79,53,244,173,210,45,77,11,33,118,45,134,213,142,95,180,128,8,23,128,209,118,161,100,54,155,4,37,87,221,126,91,172,94,5,6,183,74,190,148,200,141,255,189,196,133,44,68,60,127,141,32,55,160,131,54,103,127,67,13,146,54,32,183,250,1,148,150,116,190,170,84,237,4,7,150,225,222,1,113,225,13,224,79,158,22,224,49,216,94,138,67,195,128,72,252,239,84,51,88,127,40,91,85,251,77,42,87,60,189,206,243,42,26,181,119,54,89,186,125,108,28,221,253,146,222,241,220,77,203,178,150,4,71,39,176,225,99,70,177,54,54,144,39,59,3,232,187,34,232,156,174,109,208,186,3,251,80,238,144,186,105,94,72,149,113,12,90,88,234,87,89,76,138,123,186,240,150,150,94,179,112,129,254,10,212,27,69,40,233,62,208,87,12,195,39,73,223,175,47,159,131,127,37,187,29,190,75,123,121,217,154,206,42,15,51,44,63,146,161,223,94,136,203,251,1,218,78,71,105,255,104,89,105,83,72,50,255,239,47,118,249,239,13,46,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0d33972-393e-498c-8a2a-f1f0b8ee7fe8"));
		}

		#endregion

	}

	#endregion

}

