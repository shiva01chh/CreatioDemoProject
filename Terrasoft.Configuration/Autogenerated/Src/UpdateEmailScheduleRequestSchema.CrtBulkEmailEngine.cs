﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UpdateEmailScheduleRequestSchema

	/// <exclude/>
	public class UpdateEmailScheduleRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UpdateEmailScheduleRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UpdateEmailScheduleRequestSchema(UpdateEmailScheduleRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ad67b8c-ff6f-49ab-aea3-b1fc5bc33529");
			Name = "UpdateEmailScheduleRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,149,77,107,219,64,16,134,207,49,228,63,12,201,161,237,69,186,215,73,12,141,77,232,33,197,216,110,15,45,69,172,165,145,189,32,173,212,253,72,171,152,254,247,206,172,62,234,8,211,88,246,169,96,48,187,122,223,87,251,236,206,172,0,148,200,209,148,34,70,88,161,214,194,20,169,13,238,11,149,202,141,211,194,202,66,93,142,118,151,163,11,103,164,218,192,178,50,22,243,113,111,28,44,156,178,50,199,96,137,90,138,76,62,123,31,169,72,23,134,33,220,24,151,231,66,87,119,205,120,129,165,70,131,202,26,72,132,21,16,23,202,106,17,91,72,11,13,174,164,57,206,198,92,200,236,141,1,19,111,49,113,25,6,109,90,184,23,247,109,74,1,247,141,255,59,77,148,110,157,201,24,226,76,24,3,159,57,11,103,28,180,108,82,22,248,195,161,177,164,220,249,245,93,92,107,220,208,106,97,174,139,18,181,149,104,222,195,220,135,212,207,251,0,126,226,1,105,237,180,88,195,255,118,139,176,230,253,64,122,37,239,3,160,74,130,206,27,246,205,55,79,34,115,216,13,87,175,216,255,170,61,236,35,230,107,212,111,63,209,177,193,45,92,181,206,136,157,17,57,175,222,241,54,180,251,64,14,92,113,230,135,70,199,131,153,74,96,7,27,180,99,6,24,195,239,211,73,141,21,218,158,195,218,15,24,66,235,189,71,240,46,89,119,58,113,130,153,124,66,93,117,149,72,85,91,153,97,208,175,102,252,155,187,181,71,173,61,98,251,75,116,99,53,183,205,180,145,182,5,63,37,225,105,236,78,73,234,21,144,9,117,170,76,37,106,40,82,191,33,190,51,135,241,123,203,94,212,209,228,222,24,201,94,89,63,56,153,128,239,235,143,103,148,114,226,248,24,44,194,207,45,170,102,137,185,51,22,214,8,177,80,49,102,56,176,143,219,196,227,241,126,149,178,190,102,35,246,29,46,230,9,204,58,25,207,253,55,196,253,166,124,137,241,133,117,112,123,215,167,155,76,58,71,240,40,149,151,141,135,80,150,90,22,90,218,138,235,117,54,188,86,91,251,209,135,216,26,14,151,233,188,121,122,78,165,82,12,247,30,239,225,115,161,208,127,40,233,3,154,80,195,15,99,163,155,144,150,176,151,116,66,75,214,25,245,21,204,25,135,177,87,94,197,135,248,149,52,135,225,175,9,161,254,252,250,49,205,210,111,52,250,3,129,22,214,66,149,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ad67b8c-ff6f-49ab-aea3-b1fc5bc33529"));
		}

		#endregion

	}

	#endregion

}

