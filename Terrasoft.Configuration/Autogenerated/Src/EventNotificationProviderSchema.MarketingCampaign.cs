﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventNotificationProviderSchema

	/// <exclude/>
	public class EventNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventNotificationProviderSchema(EventNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7b18c7cf-a1d7-40df-99b6-582b695ddf20");
			Name = "EventNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,86,129,254,15,156,10,20,50,22,200,235,107,156,26,112,155,52,240,214,54,65,236,108,15,109,81,48,210,57,225,38,75,26,73,101,240,138,254,239,59,126,41,164,44,201,30,48,172,15,141,73,222,239,190,239,120,84,73,183,32,106,154,1,89,3,231,84,84,27,153,190,173,202,13,187,111,56,149,172,42,159,63,251,246,252,89,212,8,86,222,7,36,28,210,243,55,179,246,104,181,19,18,182,184,95,20,144,41,156,72,47,161,4,206,178,217,0,188,139,197,53,238,188,224,112,143,104,242,182,160,66,156,146,139,71,40,229,199,74,178,13,203,180,58,215,188,122,100,57,112,77,60,157,78,201,153,104,182,91,202,119,115,187,214,8,82,122,16,82,91,76,234,32,83,15,83,55,119,5,203,72,166,228,13,139,35,167,228,13,21,208,119,116,66,150,253,10,70,202,113,173,65,239,24,20,57,90,116,205,217,35,149,160,245,143,106,179,32,25,250,75,18,33,185,114,199,229,205,213,237,245,215,143,139,15,23,228,53,137,125,222,241,108,16,228,200,181,5,177,241,101,244,2,202,220,136,183,107,231,92,133,228,77,38,43,174,52,210,30,176,10,25,111,12,250,33,185,21,192,17,94,154,32,147,38,88,78,20,139,232,148,220,161,171,146,206,17,209,222,248,126,164,152,115,166,81,24,163,51,99,224,9,169,238,126,71,86,115,82,83,142,57,43,129,139,64,156,183,29,136,26,242,1,138,170,129,75,6,29,15,116,115,74,111,92,242,170,169,73,137,2,210,150,198,79,34,103,144,139,160,38,215,90,68,247,32,237,175,136,131,108,120,233,197,87,135,83,41,218,106,219,43,189,77,194,163,21,248,136,132,131,242,251,37,15,249,233,3,200,135,202,36,110,37,49,0,144,187,212,181,75,82,61,98,93,163,126,228,177,98,57,89,228,57,54,129,102,91,138,100,5,170,23,16,161,255,216,168,68,102,101,20,74,13,101,18,223,192,150,149,57,106,30,159,144,120,153,199,147,116,33,18,253,99,140,208,44,214,108,11,22,224,111,140,1,49,45,37,205,100,43,168,61,244,14,198,240,231,32,50,206,106,93,146,134,67,176,211,129,154,146,244,13,211,59,61,66,90,74,21,63,75,187,102,178,216,55,7,91,230,42,123,128,45,237,80,95,148,146,201,157,57,50,219,29,160,95,109,98,5,82,162,73,66,49,65,142,203,45,189,135,39,239,187,213,204,47,220,129,168,255,92,177,114,77,239,10,56,38,234,239,97,35,175,26,44,85,133,210,182,44,114,244,238,109,201,36,202,190,26,139,214,82,92,252,217,208,162,3,10,137,172,148,37,182,30,43,193,248,181,135,245,170,209,77,37,100,29,196,107,80,101,235,254,62,166,59,225,135,97,79,239,167,192,221,14,75,232,143,147,37,142,254,165,208,177,160,251,168,219,99,195,173,139,28,101,107,134,253,17,87,77,57,13,233,44,193,204,203,136,116,81,230,29,75,124,101,215,187,26,252,144,90,131,76,50,167,215,174,229,39,126,1,11,41,210,46,143,246,124,153,79,14,25,24,220,230,203,114,83,145,75,144,55,144,85,60,239,158,36,70,175,158,203,202,252,157,147,188,61,50,58,255,74,139,6,220,13,21,93,54,232,75,102,234,108,214,238,164,107,190,67,211,240,78,235,71,127,106,75,243,11,222,138,141,116,28,172,99,109,151,47,225,47,178,167,175,19,28,233,174,130,243,194,144,4,211,117,190,156,24,234,55,85,190,27,33,246,155,159,131,88,21,17,101,181,179,251,38,221,244,129,210,80,217,59,104,166,107,147,95,38,1,248,169,187,141,232,180,215,8,157,98,31,64,8,167,218,65,13,124,225,126,199,57,6,235,211,251,124,244,112,96,181,215,191,205,85,236,103,229,225,187,248,208,192,178,168,107,208,9,175,103,6,82,109,112,90,212,151,50,217,84,156,100,28,168,234,1,158,247,20,137,124,192,242,214,218,15,12,25,122,71,15,90,154,237,235,216,50,141,231,11,84,1,64,49,222,188,142,223,51,33,207,214,115,196,2,204,227,233,220,201,78,207,166,26,236,15,44,97,95,193,222,228,134,7,205,196,149,145,101,224,210,215,241,195,246,98,166,132,217,254,182,119,33,244,156,250,147,66,207,177,189,23,222,82,123,163,15,147,12,240,15,230,1,63,180,189,209,186,209,37,43,116,0,184,238,52,248,71,52,133,60,54,14,253,57,216,9,203,112,155,138,157,135,77,248,131,56,105,89,166,167,136,144,223,74,114,236,216,115,164,118,199,125,113,117,35,177,235,161,55,218,176,190,1,255,184,158,105,249,201,3,13,44,232,73,51,31,201,242,17,152,42,212,128,154,183,137,50,130,242,178,41,68,223,141,55,206,78,154,133,88,225,18,236,48,131,39,173,31,41,39,127,128,146,137,102,254,72,226,175,49,254,255,100,195,76,157,215,85,141,175,19,211,193,174,213,239,115,42,233,254,213,160,61,28,94,0,202,156,253,62,222,42,58,220,165,237,76,229,117,58,173,41,190,16,25,45,216,223,112,109,85,210,170,165,43,183,157,132,87,154,113,76,250,174,226,91,42,147,248,115,252,237,167,239,159,227,83,242,237,213,119,28,28,208,236,147,14,199,227,43,207,79,107,61,152,196,170,33,130,182,36,157,206,71,202,176,191,52,12,15,108,125,12,231,17,90,102,112,160,74,236,8,133,85,162,189,135,175,82,179,211,134,197,18,64,112,170,130,216,20,133,113,18,219,16,239,17,76,126,48,103,228,229,75,239,197,156,234,174,136,58,253,2,187,36,22,225,13,53,25,163,205,27,192,52,193,110,217,230,137,30,94,66,22,168,79,162,182,39,79,92,62,117,165,216,68,141,20,55,93,86,185,250,150,129,64,183,17,128,157,88,135,218,183,31,147,216,186,234,182,231,91,196,216,27,115,148,224,136,183,229,145,143,203,189,151,201,0,206,127,139,40,156,183,30,197,29,245,24,29,151,217,222,115,142,248,28,47,95,86,170,244,115,59,239,120,181,245,193,237,193,255,242,152,251,111,95,115,81,250,219,3,112,8,99,138,136,247,56,26,94,241,129,39,134,74,211,116,93,161,138,88,179,130,22,10,149,76,38,45,75,253,144,89,138,27,160,190,248,61,54,27,90,8,232,160,186,230,47,71,57,132,245,132,245,72,133,173,0,239,163,142,107,153,97,189,28,221,14,253,207,167,99,51,136,107,105,254,67,163,191,211,45,47,202,102,11,92,125,34,56,219,123,97,205,85,227,11,30,169,109,223,115,223,204,58,231,10,37,146,201,208,208,108,247,252,45,189,163,254,253,3,98,42,96,157,242,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b18c7cf-a1d7-40df-99b6-582b695ddf20"));
		}

		#endregion

	}

	#endregion

}

