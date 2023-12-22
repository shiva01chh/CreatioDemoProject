﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAudienceQueueManagerSchema

	/// <exclude/>
	public class BaseAudienceQueueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAudienceQueueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAudienceQueueManagerSchema(BaseAudienceQueueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c4116d3-fa0e-44ac-8a08-8230e66b90b7");
			Name = "BaseAudienceQueueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,88,75,111,219,56,16,62,183,64,255,3,161,189,72,104,32,167,135,189,52,182,139,60,187,193,182,105,26,187,219,195,98,15,180,52,78,136,72,162,74,82,73,141,160,255,189,195,151,37,202,86,236,0,91,160,104,45,205,124,243,250,56,51,84,69,75,144,53,205,128,204,65,8,42,249,82,165,167,188,90,178,219,70,80,197,120,245,230,245,211,155,215,175,26,201,170,91,50,91,73,5,229,81,239,55,202,23,5,100,90,88,166,31,161,2,193,178,13,153,79,172,250,209,62,236,218,42,75,94,109,127,35,96,232,121,122,118,130,175,240,229,31,2,110,209,46,57,45,168,148,239,201,9,149,112,220,228,12,170,12,190,54,208,192,103,90,209,91,16,70,118,52,26,145,177,108,202,146,138,213,212,253,198,80,21,101,149,36,37,168,59,158,75,162,56,121,228,226,158,60,50,117,71,126,104,136,212,137,126,169,1,51,2,210,190,26,75,0,146,9,88,78,34,109,212,26,3,41,209,90,52,154,122,157,241,168,99,175,110,22,5,203,8,93,72,37,104,166,72,166,125,30,116,121,60,159,18,27,208,156,202,251,254,155,199,59,16,88,50,39,209,181,142,134,158,76,184,109,110,176,46,74,52,153,226,2,83,116,109,188,176,18,253,140,248,148,120,113,178,196,191,189,72,183,249,234,34,222,12,217,62,169,169,160,37,169,144,105,147,168,145,32,208,66,101,249,18,77,199,35,243,214,8,187,4,13,89,137,191,5,186,36,132,74,48,23,11,212,140,251,143,159,126,185,116,64,149,219,140,132,233,185,22,28,43,171,24,232,228,8,174,80,15,242,103,242,131,76,190,135,156,8,200,184,200,145,55,38,235,36,227,69,83,86,38,200,129,84,212,30,187,101,0,254,163,185,125,99,160,78,13,194,21,2,144,39,114,11,234,136,236,112,252,179,165,172,246,154,61,32,51,237,219,218,254,32,172,82,228,35,168,115,169,88,137,191,243,57,43,33,214,15,107,46,153,203,140,150,127,245,64,5,145,205,98,6,250,12,147,9,169,224,145,216,31,189,132,39,70,252,85,58,231,117,188,6,113,207,172,243,113,20,152,139,146,244,88,110,60,115,26,23,130,151,49,58,56,203,238,160,164,58,236,120,73,11,9,137,23,248,34,114,16,39,171,51,144,89,28,97,136,92,48,181,138,122,111,143,245,203,83,1,26,254,75,21,37,132,74,231,252,81,27,220,222,145,185,40,46,154,42,75,47,229,85,83,20,246,255,179,166,140,35,204,81,116,64,250,209,28,16,171,148,94,107,26,131,66,154,30,38,73,16,228,58,185,54,29,26,39,177,222,89,207,210,89,13,25,91,174,174,248,39,158,221,255,133,53,146,177,19,16,160,26,81,185,8,210,243,159,144,53,10,102,25,45,168,24,163,220,212,201,253,10,75,127,198,76,84,72,188,241,199,134,229,7,154,11,83,77,6,221,73,228,101,133,44,191,21,200,219,56,160,192,75,179,212,103,237,14,42,12,151,29,155,13,86,125,207,140,104,87,209,247,166,240,174,110,13,54,14,225,92,226,110,128,34,105,98,65,38,83,23,184,129,99,57,66,9,156,92,202,186,254,15,45,26,48,96,211,205,32,143,90,61,80,116,155,162,177,223,143,222,169,89,207,211,227,60,143,181,171,136,224,222,252,10,11,110,229,186,181,221,163,9,236,110,93,55,6,93,118,91,250,101,133,53,86,216,192,245,176,19,43,130,179,186,46,52,137,112,16,66,101,6,160,239,113,251,182,120,38,237,168,212,85,41,190,106,212,104,122,81,208,91,13,201,170,156,101,26,158,183,34,68,209,69,1,216,206,181,141,238,60,48,200,54,35,114,58,236,51,234,120,161,176,207,242,7,92,26,88,14,196,42,232,19,96,255,231,70,165,241,109,238,2,142,23,156,23,100,211,247,238,25,97,22,103,98,6,77,250,60,220,22,164,160,196,22,203,157,138,25,168,14,101,110,248,163,60,229,77,165,176,223,104,138,27,237,182,191,12,8,98,183,194,246,116,89,41,208,19,121,221,130,66,104,195,198,29,168,78,230,93,128,214,229,226,86,110,93,176,162,144,228,65,31,1,105,246,6,203,167,218,27,112,123,147,227,84,59,56,235,245,248,221,155,95,182,252,207,48,98,27,121,55,136,213,133,116,66,209,20,129,20,197,189,131,240,101,247,148,204,53,180,247,184,5,15,64,183,240,238,129,99,111,193,2,132,169,150,49,98,122,78,218,96,14,112,149,115,240,158,111,134,98,3,186,94,201,171,180,173,177,147,238,137,19,107,39,147,180,114,173,140,166,240,201,202,52,225,109,164,74,82,211,209,16,201,39,113,83,104,47,72,183,12,120,180,120,24,142,140,200,159,135,135,9,121,75,222,237,100,220,150,110,102,231,86,192,3,220,164,72,214,8,1,8,238,118,54,220,187,85,203,63,183,201,96,182,218,125,127,31,26,90,176,203,60,154,126,171,24,106,226,28,65,27,108,201,64,104,246,120,252,66,175,139,194,153,222,171,189,245,130,24,108,111,110,99,195,132,127,194,128,252,198,236,154,209,181,11,203,77,114,61,205,136,247,120,96,243,179,13,99,215,248,223,53,255,215,239,53,208,119,236,247,252,209,80,88,47,82,26,38,118,98,198,16,214,253,170,41,23,32,66,145,228,96,45,164,187,90,87,195,8,90,11,231,63,107,189,197,104,133,238,10,184,22,55,43,226,25,19,214,125,220,189,50,156,161,184,111,39,118,15,179,182,247,223,71,191,235,43,87,119,19,197,21,241,252,71,67,139,120,99,3,60,131,37,197,249,237,75,225,52,146,103,183,211,23,102,223,236,165,159,233,207,54,142,231,118,206,153,222,57,131,56,54,170,55,28,205,154,54,27,254,191,108,127,221,251,64,175,143,36,30,163,224,172,234,177,226,206,240,255,124,90,119,29,207,235,151,184,52,116,96,31,152,80,152,97,127,53,211,167,214,227,94,112,97,43,50,124,82,181,217,173,135,27,59,234,94,61,96,13,26,212,102,16,118,231,117,99,247,74,186,235,83,131,235,255,90,41,167,184,77,119,218,38,102,45,211,135,27,175,199,58,197,97,7,127,121,209,47,131,106,171,59,216,89,241,121,83,23,102,13,0,63,164,172,143,241,198,192,32,180,202,9,202,152,205,96,1,4,108,222,242,196,99,110,9,160,71,17,251,225,195,243,35,184,166,155,11,141,185,41,116,174,243,251,49,70,133,215,61,203,147,141,59,96,103,121,240,145,77,134,233,217,35,17,91,118,18,50,153,144,67,111,223,211,171,231,67,234,63,184,253,13,171,22,203,245,182,15,36,198,165,179,167,241,175,151,250,207,139,189,39,241,225,1,90,114,55,167,181,251,208,93,55,108,12,225,215,143,245,71,139,163,32,69,173,173,115,115,163,235,187,108,214,22,105,62,2,132,71,167,47,136,49,73,253,221,128,171,243,178,86,171,216,57,252,161,147,162,183,122,173,14,29,125,187,233,132,83,124,223,42,246,148,158,59,135,246,105,248,208,60,235,254,249,13,217,80,178,103,247,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c4116d3-fa0e-44ac-8a08-8230e66b90b7"));
		}

		#endregion

	}

	#endregion

}

