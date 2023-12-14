﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DelayedNotificationWorkerSchema

	/// <exclude/>
	public class DelayedNotificationWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DelayedNotificationWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DelayedNotificationWorkerSchema(DelayedNotificationWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d88f3381-ce5e-4136-ab47-76b6f077f281");
			Name = "DelayedNotificationWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,88,75,111,219,56,16,62,187,64,255,3,215,5,10,25,48,148,197,30,155,196,139,52,117,10,3,77,218,230,209,30,22,123,96,164,113,66,68,34,29,146,74,226,46,242,223,119,248,144,68,201,146,237,52,233,98,115,137,69,14,135,195,111,190,121,144,156,230,160,22,52,1,114,14,82,82,37,230,58,62,20,124,206,174,10,73,53,19,252,245,171,127,94,191,26,20,138,241,43,114,182,84,26,242,221,214,55,202,103,25,36,70,88,197,31,129,131,100,201,138,204,39,198,111,235,193,112,175,60,23,188,123,70,66,223,120,252,225,125,239,212,148,107,166,25,40,20,64,145,55,18,174,208,48,114,152,81,165,222,145,15,144,209,37,164,39,66,179,57,75,236,1,191,11,121,3,210,10,239,236,236,144,61,85,228,57,149,203,137,255,190,208,44,99,122,73,18,163,128,204,133,36,247,184,128,220,51,125,77,82,167,141,240,64,93,92,234,217,9,20,45,138,203,140,37,94,199,26,27,6,6,235,202,230,47,82,44,64,154,179,188,35,95,172,6,107,229,138,153,118,96,198,149,166,28,253,40,230,56,9,64,18,9,243,253,225,133,2,137,254,228,206,63,195,157,9,209,203,5,196,149,154,208,202,210,204,230,154,246,167,53,113,112,5,122,151,44,36,187,163,26,136,194,15,51,250,232,236,123,3,60,117,71,240,223,165,15,144,32,90,22,137,22,178,117,34,191,113,47,50,209,200,109,251,184,22,0,116,59,205,216,15,32,148,112,184,39,44,64,68,95,67,136,74,239,70,6,32,235,165,30,132,236,200,130,74,154,19,142,145,179,63,44,154,248,78,206,113,35,51,70,146,106,48,222,219,177,43,38,91,157,180,133,118,83,191,135,97,208,18,218,111,137,109,227,140,99,208,215,34,53,126,112,78,244,142,240,30,253,90,128,92,146,131,197,34,91,30,23,153,102,159,40,191,42,232,21,156,67,190,200,80,224,136,101,26,141,117,98,197,34,197,33,251,187,52,48,24,50,214,213,95,241,103,25,117,193,63,28,147,225,52,167,44,43,119,152,165,195,145,85,53,136,103,60,50,254,60,3,147,101,90,0,121,25,148,194,44,84,228,60,26,214,11,113,240,72,138,60,114,138,181,87,108,142,18,72,124,191,6,9,81,223,222,126,123,167,59,254,98,220,8,120,112,21,29,82,5,103,32,239,88,2,150,214,42,62,5,133,82,198,166,240,92,231,139,108,150,142,189,178,213,69,83,165,89,110,5,79,225,182,0,165,173,252,104,52,178,46,28,72,208,133,228,33,126,79,116,173,208,8,19,164,107,194,230,194,234,238,76,101,106,108,34,27,113,231,233,7,148,217,54,36,66,21,195,137,77,199,75,19,131,29,94,111,132,198,138,162,4,225,66,87,76,12,108,132,165,192,205,66,144,43,139,200,158,195,73,77,18,81,112,109,246,114,136,165,68,66,34,100,170,112,73,41,226,88,238,113,33,119,76,234,130,102,152,43,180,71,162,195,202,217,124,166,167,15,76,233,200,31,38,60,225,152,124,44,88,74,156,173,37,253,239,40,38,128,66,74,52,217,32,135,33,96,254,157,179,28,226,11,157,156,136,251,221,74,204,89,138,18,134,226,206,132,22,197,49,50,186,2,166,140,142,51,208,209,176,244,17,134,81,155,171,81,96,72,124,144,166,199,140,23,26,84,228,57,217,168,93,31,65,159,99,121,72,157,142,111,52,43,96,15,161,153,248,144,29,34,49,203,109,125,220,28,58,31,141,226,153,154,222,34,146,43,161,18,121,100,202,117,7,60,237,136,182,106,185,65,193,18,189,86,176,209,66,227,128,73,135,210,230,158,21,68,102,179,147,34,203,162,174,32,139,167,15,144,32,62,126,114,93,193,65,83,136,221,147,228,148,99,110,148,150,182,182,69,8,253,181,196,30,229,87,135,206,42,161,177,208,154,222,8,109,60,80,10,242,203,203,108,249,21,199,77,0,165,199,206,220,19,220,178,139,209,37,137,61,46,27,225,191,20,34,67,248,103,234,107,129,86,124,150,236,138,113,154,89,100,134,35,242,167,243,129,233,58,196,60,154,62,104,116,3,164,118,246,59,246,80,199,52,145,66,121,139,70,177,51,54,176,213,24,73,222,145,51,123,156,120,154,47,244,114,163,99,14,37,152,144,50,84,234,235,208,254,119,121,108,213,131,119,2,211,138,59,202,9,220,135,187,189,116,26,242,92,201,107,90,160,228,70,230,52,40,83,231,51,236,186,176,103,245,249,108,102,63,58,75,54,150,85,45,186,91,129,70,102,243,9,102,76,58,50,67,43,181,88,121,151,168,58,197,159,154,234,66,181,43,196,12,160,232,222,45,128,179,169,170,157,167,126,206,214,141,73,239,89,117,225,201,85,129,80,229,189,237,168,224,104,208,157,77,55,247,45,155,46,59,219,55,45,68,11,194,49,217,219,180,172,4,82,187,236,3,183,110,241,183,10,95,215,214,55,99,55,3,42,75,59,142,132,172,27,196,210,95,81,79,204,62,179,39,232,115,189,237,57,35,131,134,39,201,79,22,113,91,79,253,207,207,11,224,239,51,145,220,252,76,87,255,159,183,213,158,155,115,210,130,211,80,124,166,142,48,215,22,18,166,156,94,102,80,118,41,199,160,20,198,113,227,22,132,101,237,237,91,242,219,179,116,124,251,3,227,198,251,124,80,57,124,227,141,203,73,250,131,60,6,119,173,248,48,19,10,156,43,252,244,147,59,154,151,191,11,252,186,22,190,25,112,166,127,55,182,29,100,153,167,161,5,94,245,69,152,63,226,84,221,250,40,115,37,245,44,185,134,156,218,84,220,102,72,40,224,115,127,95,16,58,244,235,45,76,118,45,111,167,117,23,186,219,52,198,9,248,226,219,189,214,103,219,216,8,5,5,55,221,98,169,141,238,230,186,185,37,148,114,231,255,235,239,146,138,193,122,215,124,56,226,153,94,45,136,83,55,120,40,114,116,35,83,24,143,230,81,201,230,14,4,197,56,27,35,223,163,62,94,171,183,91,147,107,208,81,85,13,151,35,252,10,180,110,185,50,103,61,197,136,129,200,31,171,13,175,39,68,253,84,217,132,10,99,215,57,184,22,104,119,45,181,194,45,90,42,172,54,64,147,107,18,181,13,64,166,246,24,84,37,131,151,184,21,62,251,90,88,131,108,172,236,111,1,90,220,173,47,136,85,113,217,116,189,219,184,143,235,116,66,154,87,239,35,221,41,206,231,69,127,127,233,70,27,139,33,230,153,167,92,37,90,217,80,84,78,2,243,52,240,210,9,177,177,168,108,89,106,243,81,65,205,100,243,190,89,53,53,27,187,18,123,162,14,234,68,237,0,32,171,219,246,222,50,210,85,125,72,222,85,5,158,20,178,200,144,220,19,231,67,243,177,174,197,61,197,249,11,83,63,13,147,200,254,62,49,216,249,66,111,207,97,88,110,5,140,134,81,71,0,134,174,11,2,240,164,227,210,235,2,220,112,195,190,248,180,14,180,197,19,81,243,82,230,145,242,108,53,141,71,159,238,125,242,123,101,195,160,251,218,183,78,245,99,77,252,117,124,70,211,49,232,8,197,134,184,179,202,219,54,217,104,30,147,123,227,41,44,250,60,37,150,230,76,217,70,250,197,137,46,177,160,202,27,53,153,62,36,176,208,100,14,144,94,210,228,6,235,190,237,220,154,206,163,220,52,4,101,71,136,115,213,12,216,236,26,198,65,169,56,140,4,19,1,14,131,39,116,10,80,101,98,183,180,251,9,218,191,53,175,187,208,62,235,205,44,120,191,66,229,81,253,138,101,174,94,206,176,170,58,66,95,219,23,94,189,252,88,56,132,35,230,239,95,251,207,137,11,21,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d88f3381-ce5e-4136-ab47-76b6f077f281"));
		}

		#endregion

	}

	#endregion

}

