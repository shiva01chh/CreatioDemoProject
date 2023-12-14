﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PeriodRepositorySchema

	/// <exclude/>
	public class PeriodRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PeriodRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PeriodRepositorySchema(PeriodRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("03639823-c45c-421b-8135-21982a3be4e0");
			Name = "PeriodRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,88,89,111,219,70,16,126,86,128,254,135,5,83,4,20,32,208,69,31,125,168,176,229,35,6,210,58,141,157,20,69,80,4,107,114,100,109,193,43,187,75,165,130,225,255,222,217,139,228,82,36,45,37,1,146,7,71,156,157,123,118,102,62,50,167,25,136,146,198,64,238,128,115,42,138,165,140,22,69,190,100,15,21,167,146,21,121,116,89,112,136,169,144,31,126,253,233,197,227,79,47,38,149,96,249,3,89,32,245,200,123,138,46,114,201,36,3,209,33,95,210,88,22,220,163,223,110,132,132,172,251,140,118,211,20,98,101,84,68,87,144,3,103,241,22,207,27,150,127,110,136,109,159,179,172,200,251,79,90,190,69,23,107,200,165,24,228,187,149,38,46,60,127,201,225,1,93,33,139,148,10,113,72,222,162,59,69,162,79,14,14,14,200,177,168,178,140,242,205,220,62,191,131,146,131,80,186,201,249,221,13,89,22,220,74,16,80,166,55,145,147,59,104,9,150,213,125,202,98,18,43,11,142,253,144,104,95,55,231,84,82,100,121,212,22,107,103,222,242,162,4,174,34,65,143,180,180,57,239,186,164,9,127,96,109,73,177,36,165,214,28,213,124,109,23,156,15,66,114,149,14,45,242,72,30,64,30,17,161,254,60,141,232,191,78,84,108,75,6,188,177,66,228,166,132,113,83,87,21,75,108,180,119,200,124,157,236,108,208,166,72,72,202,37,73,168,124,198,16,166,16,238,24,6,116,171,4,212,211,190,150,146,10,246,177,115,94,193,94,86,22,69,178,111,129,180,200,201,156,96,87,102,234,119,168,42,54,61,26,49,162,56,133,171,78,172,196,151,188,200,28,33,87,5,95,211,180,26,138,81,83,74,202,105,166,121,79,2,205,28,204,223,110,201,31,31,104,182,70,138,131,172,120,46,28,171,178,141,76,142,234,197,134,163,166,14,177,14,205,62,107,237,83,162,102,207,100,98,164,13,237,183,8,187,46,197,217,21,6,36,152,145,224,83,160,18,49,153,216,148,191,132,60,49,109,163,159,13,181,67,116,125,117,157,75,224,75,84,117,72,174,141,187,168,186,16,12,199,193,102,176,231,107,161,173,118,199,254,36,188,86,48,214,251,172,214,209,99,119,242,56,88,213,43,144,132,166,169,45,163,32,95,152,92,17,81,66,172,250,113,180,11,183,10,90,182,90,177,174,171,82,64,88,221,224,94,113,175,47,242,42,3,78,239,83,56,54,236,115,229,143,249,41,66,221,223,109,165,163,215,243,71,6,178,165,97,3,148,7,243,191,241,239,140,124,89,177,120,133,151,54,151,148,229,234,30,230,0,9,184,200,196,55,101,100,166,234,78,148,181,111,201,77,19,149,216,47,69,215,137,112,249,17,158,150,61,98,106,31,171,248,230,164,214,173,187,112,180,221,188,157,186,67,167,53,44,125,173,214,219,95,31,207,97,73,171,84,158,177,60,193,234,133,234,30,20,203,112,171,203,166,211,127,250,55,113,203,230,33,89,208,120,5,137,217,204,205,129,203,203,108,168,121,219,171,27,81,21,206,57,4,8,24,55,103,107,220,19,230,188,52,15,234,166,9,217,222,195,8,135,170,44,39,39,36,80,79,193,209,32,115,179,75,27,145,134,54,34,88,239,197,70,174,38,141,136,217,53,215,8,89,66,112,212,59,120,253,12,240,74,193,193,14,124,177,233,239,38,49,124,47,128,163,84,110,80,33,169,188,199,169,94,8,135,228,158,10,8,253,163,153,75,64,48,211,76,19,227,185,194,178,25,149,225,59,68,106,82,151,212,112,105,80,24,153,223,154,124,7,25,46,22,9,179,142,201,104,81,113,142,188,202,47,252,157,226,46,130,72,111,96,187,159,250,87,79,157,129,223,65,174,176,121,6,110,192,64,199,221,240,4,56,36,13,58,62,219,212,85,10,251,100,226,154,179,179,53,155,131,72,43,61,219,132,26,76,40,220,107,21,78,163,187,226,13,19,50,28,91,165,125,241,20,18,53,67,82,79,179,99,150,175,208,31,153,20,49,57,48,203,222,241,144,98,141,168,27,231,142,133,186,183,152,241,140,254,89,1,182,26,198,107,136,77,184,23,226,115,232,2,89,83,78,64,124,198,75,167,170,30,13,113,107,223,39,200,24,157,38,137,185,167,97,211,82,189,199,221,38,234,101,234,52,76,47,143,215,29,150,195,230,31,25,219,89,221,53,75,118,220,45,56,160,222,155,251,127,241,248,18,33,156,137,60,52,255,217,215,140,118,158,44,194,179,169,26,144,182,98,198,77,139,67,61,108,126,226,94,96,48,215,138,100,195,252,160,0,152,25,252,225,207,193,99,55,123,79,184,129,125,165,250,205,98,84,153,233,209,249,118,161,172,134,6,197,143,170,113,104,124,62,80,45,171,205,97,245,29,117,141,84,213,40,252,154,194,174,11,196,5,151,44,77,77,49,84,89,76,129,252,162,206,220,13,96,248,6,236,42,172,139,218,43,235,132,52,183,189,161,38,196,91,156,122,77,116,91,87,222,136,120,229,31,149,239,228,215,138,55,163,100,76,214,203,167,149,180,180,61,39,143,255,22,220,147,119,179,91,246,6,173,173,78,106,230,38,94,23,20,58,77,211,112,26,253,133,134,192,13,80,191,103,78,182,240,111,115,93,158,155,232,173,233,253,252,157,250,186,216,90,240,243,251,69,105,22,237,171,87,237,109,18,41,40,173,24,29,212,253,145,105,24,67,172,54,13,175,169,88,225,69,237,30,35,9,83,146,195,23,226,49,132,62,226,221,49,139,109,173,234,83,155,122,189,16,33,68,120,79,190,75,134,246,121,237,181,56,188,23,15,13,130,241,215,52,79,82,124,193,85,72,92,125,243,146,36,86,162,173,175,24,91,96,220,168,1,160,169,40,72,204,97,121,18,140,127,160,139,206,112,188,153,201,166,9,10,146,168,47,130,129,169,248,199,158,163,208,192,8,187,103,28,254,219,70,247,189,193,34,196,31,176,56,14,228,183,49,108,15,50,247,32,101,227,155,38,95,241,162,42,63,61,254,242,244,28,120,30,135,142,122,147,52,145,133,133,94,5,68,160,50,240,154,220,76,99,116,194,174,152,169,97,105,238,175,15,120,155,245,232,67,113,195,127,206,244,3,22,89,55,196,204,134,141,8,212,64,99,129,226,230,195,236,123,201,82,83,95,188,213,22,56,11,85,42,209,65,238,182,5,156,130,72,111,11,161,128,251,5,6,22,90,186,41,242,220,198,165,253,126,80,137,180,197,247,209,126,47,174,111,41,178,38,39,29,168,127,90,150,88,79,253,13,92,203,70,23,255,149,140,155,130,133,181,53,43,252,244,77,75,139,12,142,52,31,42,220,228,183,116,13,137,95,221,153,69,209,167,75,9,92,95,221,83,254,32,8,120,64,193,73,58,17,231,119,235,202,216,187,210,25,182,187,187,118,14,41,200,175,116,206,201,238,231,222,14,147,78,211,212,191,255,1,193,176,73,205,232,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("03639823-c45c-421b-8135-21982a3be4e0"));
		}

		#endregion

	}

	#endregion

}

