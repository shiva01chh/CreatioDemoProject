﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkingMinuteCountTermSchema

	/// <exclude/>
	public class WorkingMinuteCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkingMinuteCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkingMinuteCountTermSchema(WorkingMinuteCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9414e2d-d5e0-4e34-b831-120e710f3280");
			Name = "WorkingMinuteCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,87,223,111,219,54,16,126,86,128,254,15,151,12,40,36,212,147,251,188,88,2,178,36,43,2,36,219,0,123,232,51,99,157,109,33,18,229,145,148,83,163,232,255,190,227,47,73,166,108,183,193,48,96,47,73,68,126,119,247,241,248,221,29,195,89,141,114,203,150,8,11,20,130,201,102,165,210,219,134,175,202,117,43,152,42,27,158,222,178,10,121,193,132,124,119,241,245,221,69,212,202,146,175,225,254,139,66,46,105,91,94,119,107,243,189,84,88,135,223,228,173,170,112,169,93,201,244,19,114,20,229,114,132,121,44,249,223,253,226,9,38,4,32,200,79,2,215,244,1,183,21,147,18,126,129,207,141,120,33,163,167,146,183,10,111,155,150,43,50,175,13,116,58,157,194,76,182,117,205,196,62,119,223,6,1,138,32,240,188,135,87,107,12,181,177,150,169,55,154,14,172,182,237,115,85,46,97,105,226,29,143,70,52,70,241,163,175,134,67,199,247,9,213,166,41,52,227,63,69,185,99,10,237,246,214,126,64,73,172,62,161,154,147,243,10,239,216,126,81,214,248,23,47,149,140,31,252,5,208,42,20,108,63,129,59,50,208,251,64,203,9,232,75,137,162,29,19,64,176,181,218,64,6,5,174,88,91,169,88,131,230,91,198,147,107,131,121,184,231,109,141,148,204,70,204,220,65,30,56,165,98,199,170,156,124,249,61,237,128,237,211,0,161,47,79,245,14,98,231,179,92,65,124,121,20,126,195,247,113,233,190,32,203,193,255,173,253,60,72,125,134,95,81,189,34,242,88,31,35,241,7,137,4,170,86,112,248,104,253,127,51,63,95,55,101,133,16,247,28,211,167,102,135,191,227,23,21,39,240,254,61,92,14,118,110,91,33,144,171,19,97,124,20,151,171,15,25,28,49,125,52,155,67,2,103,225,11,209,242,37,5,210,17,38,160,68,139,201,129,11,119,34,157,141,196,58,74,23,141,98,149,213,140,169,32,29,198,168,133,92,88,193,156,86,79,163,168,156,176,176,128,80,227,102,129,142,46,129,213,70,234,205,10,148,214,74,171,197,4,43,209,212,160,54,8,59,20,123,18,204,74,233,187,182,136,109,163,69,216,110,65,53,6,50,219,50,193,106,129,43,224,212,36,178,43,162,118,53,205,211,46,234,52,12,107,13,28,154,220,202,171,220,107,87,71,145,233,108,106,16,199,13,180,251,92,223,23,48,94,88,70,154,251,198,200,124,108,106,147,42,243,69,127,56,123,98,130,250,61,91,96,46,95,176,43,133,106,73,139,174,212,6,21,230,100,253,92,225,108,88,109,185,97,125,188,222,138,134,218,2,130,64,73,133,102,43,70,90,101,165,11,246,130,159,181,96,99,157,218,204,120,73,123,183,214,87,106,78,58,51,103,211,127,38,206,120,222,214,67,51,226,233,10,75,27,197,137,175,228,97,79,160,198,164,244,111,75,34,253,173,20,82,253,33,238,92,15,248,46,135,44,235,73,244,53,237,157,94,246,221,100,24,180,47,36,157,205,10,9,77,241,143,55,48,231,106,98,210,119,237,139,220,228,141,234,201,216,14,75,109,88,45,22,246,198,2,49,253,250,76,117,220,20,132,11,197,237,38,0,9,92,207,133,117,185,67,110,210,233,53,184,116,103,255,207,228,239,9,228,174,43,232,42,100,197,25,225,147,239,101,91,49,173,236,98,88,53,161,254,237,248,162,118,41,68,89,96,47,230,206,254,187,250,215,87,236,232,13,199,77,175,125,39,16,239,218,93,178,43,17,205,233,81,55,154,204,59,177,219,207,77,83,193,11,226,214,15,21,125,141,153,105,159,227,113,53,166,117,31,204,171,19,243,201,77,142,67,139,96,122,4,36,58,105,135,147,215,5,186,31,77,0,39,234,179,243,213,143,191,144,247,15,206,89,147,241,215,190,21,56,227,176,63,56,176,174,224,46,239,249,208,174,59,92,212,237,255,156,13,1,206,131,113,161,95,50,94,38,148,152,199,102,61,39,74,168,155,2,111,171,170,247,21,113,124,133,49,122,141,226,148,143,196,91,70,212,176,170,234,240,93,213,195,125,86,98,243,240,25,158,195,243,180,77,35,250,6,88,73,236,8,253,31,217,251,132,135,212,189,70,199,10,249,65,157,70,81,160,33,232,223,93,71,116,23,168,182,43,84,143,244,13,168,183,117,175,153,241,171,229,136,214,2,47,3,146,7,138,11,96,157,183,224,30,187,73,145,157,158,96,29,52,74,169,181,119,105,76,231,138,9,149,28,238,186,112,241,232,46,162,104,220,138,86,84,141,216,51,11,4,55,30,89,227,105,245,198,215,25,125,177,170,114,211,199,190,201,232,223,37,61,214,104,38,189,117,2,121,252,85,190,24,206,175,179,67,200,133,179,38,238,227,95,60,189,130,209,51,126,120,249,251,12,250,187,39,59,129,225,104,242,151,222,247,84,199,208,107,204,93,131,231,125,179,94,211,227,64,15,184,143,19,136,217,114,57,113,91,9,61,136,236,37,210,34,124,56,228,212,37,138,86,137,12,73,101,83,74,111,105,53,213,125,221,211,131,230,224,35,57,243,84,177,171,135,139,180,118,113,241,15,217,169,54,162,131,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9414e2d-d5e0-4e34-b831-120e710f3280"));
		}

		#endregion

	}

	#endregion

}
