﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadPostProcessSchema

	/// <exclude/>
	public class LeadPostProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadPostProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadPostProcessSchema(LeadPostProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("73bc41cd-133a-489f-9525-2cbb0f0913f0");
			Name = "LeadPostProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,77,83,219,64,12,61,135,25,254,131,234,94,146,41,117,14,61,180,3,36,29,62,2,205,64,75,166,9,237,129,225,176,216,74,216,98,239,186,187,235,208,12,244,191,87,187,27,27,39,196,129,150,230,144,177,100,189,39,173,164,149,44,88,138,58,99,17,194,8,149,98,90,142,77,120,32,197,152,79,114,197,12,151,34,60,70,129,244,136,241,119,188,58,146,42,29,162,154,242,8,55,55,238,54,55,26,185,230,98,2,195,153,54,152,238,148,114,149,74,97,157,62,236,9,195,13,71,93,107,176,16,8,89,145,221,107,133,19,18,224,32,97,90,111,67,111,138,194,140,20,139,110,8,62,144,218,12,148,140,80,107,103,219,110,183,97,87,231,105,202,212,172,59,151,235,0,160,48,75,88,100,131,136,44,117,88,224,219,21,130,44,191,74,120,228,13,234,153,182,161,191,156,179,202,235,79,76,196,9,42,98,187,115,65,150,39,250,140,230,90,198,116,166,129,226,83,194,250,183,153,23,96,42,121,12,125,97,80,9,150,88,186,253,140,42,161,53,33,251,113,243,92,163,162,100,9,140,108,166,32,95,16,183,192,37,122,6,9,178,216,63,182,192,22,175,209,152,50,5,186,96,129,78,197,130,202,110,70,179,12,227,3,153,228,169,248,198,146,28,119,143,115,30,119,155,65,213,117,208,218,41,153,110,132,188,21,243,55,95,241,103,142,218,16,167,192,91,56,121,252,166,89,1,98,53,149,167,114,194,5,225,168,169,134,104,12,105,180,13,198,69,208,92,58,153,99,104,4,189,71,248,160,21,142,228,208,40,146,107,29,13,168,138,183,82,197,47,240,85,80,60,199,221,94,198,79,112,246,2,103,158,224,57,174,168,235,246,178,236,92,37,47,240,86,114,172,112,200,199,208,212,78,19,246,245,151,60,73,206,84,47,205,204,172,249,184,144,45,184,191,135,167,109,139,68,90,115,31,205,211,24,159,143,103,58,40,143,211,42,122,191,161,208,228,74,248,19,253,118,255,53,73,124,211,129,160,77,73,172,118,241,199,49,93,107,102,58,63,180,20,129,231,88,209,254,33,161,246,153,230,209,94,110,174,87,100,103,107,117,71,182,214,18,206,31,253,188,104,6,131,179,225,40,88,131,40,251,110,69,242,214,249,121,152,10,229,132,168,55,239,253,194,40,55,88,151,115,7,116,57,118,19,15,69,236,135,94,169,121,52,3,221,164,245,35,112,121,140,59,133,29,129,16,73,121,195,17,140,4,51,119,73,177,186,237,20,150,192,246,50,114,55,99,138,165,32,104,241,117,130,197,139,16,116,23,7,105,184,219,118,198,171,177,15,195,50,232,158,210,51,160,159,156,85,208,197,217,149,150,9,82,102,130,247,225,135,240,29,220,3,185,248,219,93,27,214,237,154,34,239,65,235,210,45,11,191,159,220,174,248,111,59,162,118,233,44,51,84,160,69,189,107,203,55,143,91,131,185,70,200,108,45,51,127,34,91,67,186,90,160,51,140,248,152,99,12,9,45,76,171,205,216,228,159,203,58,34,47,86,71,29,243,204,218,122,167,180,223,28,182,136,129,199,182,198,20,150,90,15,183,195,225,144,25,230,209,86,130,152,68,24,43,153,130,189,176,111,213,252,226,172,165,241,13,85,4,225,165,186,24,170,181,47,110,227,19,37,183,235,28,202,147,110,129,237,184,35,142,73,172,109,236,23,151,80,28,99,110,90,132,83,253,122,120,40,250,124,213,219,155,176,212,26,149,173,241,170,242,133,113,132,38,186,62,162,140,28,238,55,75,234,53,211,249,165,141,88,29,59,36,123,237,162,210,233,232,247,7,131,223,171,143,22,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("73bc41cd-133a-489f-9525-2cbb0f0913f0"));
		}

		#endregion

	}

	#endregion

}
