﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventElementHandlerSchema

	/// <exclude/>
	public class EventElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventElementHandlerSchema(EventElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e94994e-d25d-4626-bbd7-7f0a3ee55e37");
			Name = "EventElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,95,111,219,54,16,127,118,129,126,7,34,123,152,12,36,10,146,101,41,86,39,14,98,199,206,60,164,203,208,180,216,195,48,12,180,116,178,9,72,162,70,210,78,140,160,223,125,71,82,148,37,89,138,61,44,205,186,98,121,177,121,119,60,222,223,223,157,147,210,4,100,70,3,32,31,64,8,42,121,164,252,33,79,35,54,91,8,170,24,79,95,191,122,124,253,170,179,144,44,157,145,187,149,84,144,244,106,103,148,143,99,8,180,176,244,175,33,5,193,130,13,153,43,170,232,6,241,134,165,127,174,137,101,3,146,132,167,205,28,1,254,165,82,130,77,23,10,100,171,200,144,38,25,101,179,118,29,78,192,31,45,33,85,63,210,52,140,65,172,165,181,140,19,185,11,230,144,80,114,78,170,23,171,108,188,138,151,191,17,48,195,48,144,97,76,165,124,75,140,238,81,12,201,250,9,35,118,120,120,72,206,228,34,73,168,88,245,243,51,6,93,81,150,74,146,128,154,243,80,146,136,11,146,32,69,83,181,73,160,149,17,176,218,36,97,41,9,156,41,78,229,97,73,103,182,152,198,44,32,18,104,12,33,9,180,65,77,246,144,70,43,7,84,194,62,153,220,166,206,201,33,207,86,21,194,101,164,64,220,209,37,224,83,143,198,169,194,249,95,4,207,64,40,6,24,1,252,174,176,52,32,180,34,153,59,18,190,196,124,176,16,136,196,92,162,119,213,247,127,198,170,36,231,125,146,226,39,143,188,6,11,187,189,252,81,72,67,251,110,213,136,119,54,138,187,88,48,25,165,139,4,4,157,198,112,86,77,106,254,100,159,92,131,42,219,32,189,134,250,144,230,163,75,116,187,116,58,2,212,66,164,57,209,31,199,252,222,221,245,111,163,15,171,108,253,148,142,117,89,121,223,211,190,117,58,159,172,193,245,90,49,132,247,128,81,195,130,144,121,85,160,27,169,98,17,195,124,70,130,39,68,205,161,168,14,87,50,126,161,173,92,38,77,1,185,94,176,176,112,121,18,122,141,65,113,106,157,195,75,42,172,49,142,127,238,36,8,149,164,205,217,94,57,88,213,235,231,36,93,196,177,225,119,46,140,77,254,40,201,212,202,82,222,86,164,253,220,212,114,224,182,87,134,233,144,39,162,252,49,11,41,130,12,9,120,154,218,16,9,8,184,8,117,243,69,156,120,239,205,105,18,18,44,73,98,131,243,17,79,152,134,56,148,93,66,117,139,172,211,48,199,48,76,1,176,109,121,198,32,108,73,199,111,183,34,4,225,29,119,127,55,201,177,77,188,228,152,144,91,211,132,158,139,183,237,3,75,218,90,47,159,201,19,137,253,223,230,72,213,244,2,46,106,246,151,232,79,228,206,82,107,196,26,214,222,41,42,212,179,2,174,212,26,159,3,118,219,76,123,89,236,109,44,140,252,205,111,165,129,90,19,130,152,207,102,232,254,238,112,177,11,130,183,133,224,235,129,241,13,15,191,106,28,223,240,246,127,32,111,6,242,163,255,60,144,231,142,28,124,215,228,201,231,199,245,22,132,220,14,235,83,148,218,178,76,235,32,253,19,148,167,83,196,62,26,168,246,245,90,155,138,48,239,218,166,252,99,195,122,81,7,240,177,201,148,198,59,182,196,76,59,180,51,7,219,208,127,24,91,215,185,197,246,130,123,195,242,246,190,31,156,140,175,198,195,55,7,71,199,131,211,131,19,60,29,92,254,48,184,58,24,156,142,143,6,167,163,147,147,147,55,227,189,109,152,251,130,51,164,8,96,251,12,121,36,51,80,61,178,51,22,52,197,109,183,209,240,142,135,26,122,195,234,136,40,227,98,176,16,162,196,195,208,111,78,148,138,122,91,252,29,22,145,26,195,159,164,76,49,26,187,223,150,22,35,221,91,14,71,107,239,89,101,159,10,115,152,213,177,187,57,213,87,115,227,180,38,137,145,46,169,169,41,246,127,226,44,245,106,198,236,91,75,59,185,172,158,245,249,87,31,171,210,113,243,75,154,155,127,45,115,189,252,198,190,99,118,181,160,87,26,89,185,64,87,71,168,68,118,226,235,139,93,171,210,255,117,14,2,188,7,173,231,193,159,40,72,142,28,231,14,244,63,41,202,172,227,110,101,106,213,28,244,71,15,1,100,202,43,199,166,2,102,174,186,12,20,90,96,30,58,88,182,134,34,36,123,59,212,158,131,29,151,126,236,32,160,193,156,120,102,22,231,99,148,165,27,114,182,8,66,82,9,141,27,231,189,181,8,88,150,78,108,232,79,164,25,190,88,215,23,166,230,244,84,215,224,113,129,48,197,194,252,86,238,77,110,174,142,85,225,89,62,97,180,107,110,33,209,25,173,195,210,190,123,181,91,170,218,221,155,120,59,234,140,89,140,35,70,18,138,46,68,184,151,173,193,91,163,186,77,169,52,11,84,204,164,34,60,170,97,124,11,54,25,74,70,5,77,12,154,157,239,217,213,111,175,239,130,145,239,130,228,158,169,121,245,97,255,236,208,92,92,235,201,173,232,223,84,44,168,47,116,250,162,147,108,129,199,231,221,109,123,47,189,145,22,126,236,184,145,150,252,120,210,216,127,99,175,91,123,101,250,190,188,189,229,109,169,196,170,220,160,88,160,127,123,96,116,90,225,164,164,205,117,22,122,160,52,90,88,188,210,141,4,15,5,68,56,245,55,56,145,65,248,35,33,184,24,115,145,80,229,109,14,91,108,218,135,125,82,155,25,35,204,191,90,21,141,220,81,115,193,239,55,155,250,75,89,87,27,243,179,185,166,214,146,148,184,217,95,201,84,203,70,176,45,71,117,101,95,86,162,118,216,193,145,86,254,251,11,82,198,68,107,36,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e94994e-d25d-4626-bbd7-7f0a3ee55e37"));
		}

		#endregion

	}

	#endregion

}

