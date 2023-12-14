﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTypePostProcessSchema

	/// <exclude/>
	public class EventTypePostProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTypePostProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTypePostProcessSchema(EventTypePostProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56c02107-d8dd-4eec-92f9-a7d0a311d526");
			Name = "EventTypePostProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,86,75,111,219,56,16,62,171,64,255,3,161,94,100,52,43,163,215,214,86,224,36,222,32,219,20,49,106,119,123,150,165,177,195,93,73,116,73,202,169,81,244,191,239,80,148,100,146,166,157,164,41,86,7,91,154,199,55,79,14,167,74,75,16,155,52,3,178,0,206,83,193,86,50,190,100,213,138,174,107,158,74,202,170,120,186,133,74,46,118,27,152,49,33,103,156,101,32,196,235,87,63,94,191,10,106,65,171,53,153,239,132,132,242,131,243,141,32,69,1,153,66,16,241,53,84,192,105,182,151,49,109,149,37,171,252,28,14,199,232,182,139,71,165,174,46,144,133,204,55,28,214,40,71,46,139,84,136,247,196,31,17,202,13,135,67,50,18,117,89,166,124,151,180,223,74,134,128,210,32,18,85,72,166,48,58,217,161,33,188,169,151,5,205,136,144,232,83,166,197,142,88,10,126,52,214,122,183,62,129,188,103,57,58,54,107,32,52,211,245,165,33,204,193,242,69,50,34,121,154,253,171,66,23,192,183,52,131,184,215,29,186,202,163,77,202,211,146,84,88,241,113,88,163,60,38,177,210,37,10,147,47,214,119,60,26,54,194,141,174,29,216,150,209,92,249,209,135,22,217,170,196,70,30,16,213,41,65,176,77,57,41,168,216,171,145,49,169,224,129,220,34,109,212,19,147,104,240,161,17,215,229,140,174,46,166,223,33,171,37,227,36,95,246,175,99,199,70,60,173,68,205,225,234,98,79,138,6,157,225,96,14,170,15,137,76,151,5,180,239,218,180,254,136,28,127,181,82,160,250,183,46,171,40,156,83,9,189,127,225,25,9,111,242,112,16,79,132,195,81,84,87,245,38,71,38,93,81,224,30,158,152,160,189,45,28,114,180,91,140,119,246,46,89,14,157,69,131,165,201,174,242,87,88,10,215,97,3,192,101,219,32,127,114,86,186,1,247,204,91,88,201,187,90,2,255,139,81,215,203,78,40,136,239,60,1,52,9,187,17,211,111,117,90,120,242,105,138,155,89,116,12,30,68,102,27,245,5,254,136,97,87,69,137,147,84,180,125,161,251,176,107,68,213,190,185,234,60,163,141,98,221,144,240,25,210,28,120,180,111,208,125,239,5,15,247,180,0,18,229,60,86,82,70,87,6,193,254,36,128,115,38,246,71,171,61,13,248,244,50,241,77,142,98,8,120,13,82,87,253,239,180,168,97,116,93,211,60,241,52,165,23,161,81,241,194,8,201,49,224,196,110,94,15,198,66,205,157,79,216,62,71,220,17,203,157,132,196,215,178,30,176,143,180,202,31,193,241,119,174,7,107,162,167,144,15,107,201,88,145,152,71,143,156,147,168,49,48,32,239,200,251,254,253,143,119,61,174,53,178,226,73,158,71,189,165,222,248,79,253,175,255,244,175,53,31,237,1,115,102,143,65,141,242,243,196,204,119,47,160,255,103,232,31,232,90,94,135,137,154,219,134,87,191,237,190,56,115,111,4,39,93,198,117,34,12,208,207,240,173,6,177,159,236,242,224,12,41,13,93,187,54,121,183,108,77,85,159,224,190,130,242,18,41,106,81,145,77,171,184,53,211,21,14,167,7,250,56,96,22,108,222,156,153,163,134,102,184,9,60,48,158,191,192,86,7,241,20,115,147,13,253,8,187,23,24,211,0,79,49,133,135,114,178,217,124,225,197,11,172,245,24,150,65,242,150,132,67,179,140,231,43,198,203,84,142,255,17,216,184,218,29,79,253,99,84,185,72,5,205,38,181,188,143,14,203,125,230,175,204,224,36,96,251,170,183,180,40,156,221,205,23,225,9,141,62,255,158,170,28,215,234,9,205,193,26,219,93,127,66,77,95,65,145,191,44,214,112,121,3,85,174,23,206,230,91,83,29,162,179,40,155,5,56,186,32,119,71,175,25,0,128,247,181,32,15,176,236,70,147,133,17,159,216,155,245,194,108,74,227,68,198,90,98,168,66,94,22,20,137,35,90,201,228,112,125,198,189,122,3,92,82,112,54,232,126,14,169,150,34,109,89,244,248,88,131,236,115,106,230,168,85,113,71,144,93,156,211,16,191,144,102,59,199,86,62,12,214,51,195,86,251,0,193,75,245,73,1,55,23,31,49,239,244,167,169,233,212,118,251,196,51,76,181,55,254,51,52,218,123,253,197,201,71,154,122,254,3,39,204,41,209,248,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56c02107-d8dd-4eec-92f9-a7d0a311d526"));
		}

		#endregion

	}

	#endregion

}

