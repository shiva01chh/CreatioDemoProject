﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceNavigationPanelServiceSchema

	/// <exclude/>
	public class WorkplaceNavigationPanelServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceNavigationPanelServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceNavigationPanelServiceSchema(WorkplaceNavigationPanelServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e8b0c49d-e048-4383-a8d4-1c931f68d4c8");
			Name = "WorkplaceNavigationPanelService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,219,78,219,64,16,125,222,72,253,135,21,125,113,164,200,31,16,10,8,40,160,84,13,160,132,138,7,84,161,141,61,49,22,155,93,119,118,157,214,66,252,123,103,47,78,28,32,73,251,144,200,123,230,178,103,102,206,172,18,11,48,149,200,128,223,1,162,48,122,110,211,115,173,230,101,81,163,176,165,86,233,181,88,150,133,255,28,131,170,63,245,94,62,245,88,109,74,85,240,105,99,44,44,14,223,156,211,41,224,178,204,96,172,115,144,59,141,233,105,102,203,165,79,189,219,239,30,102,239,28,8,35,39,99,40,120,106,133,133,181,67,33,245,76,200,225,240,92,47,22,196,255,187,46,10,130,215,246,110,161,8,233,165,200,172,198,18,204,86,143,46,23,234,141,69,138,248,200,217,81,10,151,238,182,182,9,39,186,182,129,25,185,63,124,133,185,168,165,237,216,224,167,195,167,166,122,143,5,160,37,227,177,83,83,93,131,165,27,42,234,232,172,148,165,109,38,240,171,46,17,22,160,172,73,186,7,87,10,63,226,123,66,156,87,26,129,188,239,46,169,234,153,44,51,158,73,97,12,191,215,248,92,73,146,206,90,33,183,66,129,140,228,248,144,159,9,3,241,52,224,163,9,136,252,70,201,166,59,53,202,249,226,203,103,159,17,10,66,249,101,9,50,55,67,126,139,78,26,16,140,85,56,240,17,13,147,63,74,237,167,185,137,186,223,209,177,55,242,147,19,158,248,143,35,7,143,133,18,5,96,122,5,214,105,1,48,177,77,5,122,158,236,41,160,223,239,111,92,131,196,95,19,127,62,218,22,120,139,122,89,230,128,252,81,125,108,56,140,181,130,202,67,185,155,181,211,60,141,197,218,233,145,26,224,123,29,235,15,125,223,67,56,233,115,183,156,140,109,187,158,250,113,238,70,23,36,223,184,142,124,217,91,204,113,226,115,50,5,191,187,4,79,177,168,157,74,146,131,218,0,146,65,65,230,98,15,6,252,199,6,16,187,248,250,95,149,236,111,241,150,18,255,161,5,219,103,227,89,50,182,107,68,99,176,79,218,235,179,51,158,135,155,10,194,107,217,221,72,246,64,43,63,82,75,253,12,73,8,163,203,15,174,46,238,168,69,103,58,111,166,182,145,110,11,201,107,76,43,65,26,93,161,233,61,138,170,130,220,45,31,24,59,240,37,197,195,165,198,133,176,27,113,1,74,191,25,173,6,124,66,239,57,141,9,118,251,249,117,110,167,65,58,216,124,229,175,80,215,149,105,51,57,123,64,86,10,91,10,164,125,136,102,106,41,105,99,79,146,36,200,128,89,108,98,14,214,38,72,87,195,54,148,107,219,228,232,33,23,121,155,229,149,103,194,102,79,201,197,159,12,42,231,202,161,165,198,72,161,238,229,165,135,87,99,44,156,210,66,26,191,67,2,70,79,65,122,225,92,146,174,99,76,191,166,54,173,51,162,229,120,205,133,52,240,214,236,51,140,212,92,199,38,172,207,145,12,235,48,232,220,19,140,175,177,24,255,143,96,107,84,171,174,118,151,230,141,24,9,245,134,94,239,47,85,205,175,132,190,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8b0c49d-e048-4383-a8d4-1c931f68d4c8"));
		}

		#endregion

	}

	#endregion

}
