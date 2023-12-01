﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchEventLoggerSchema

	/// <exclude/>
	public class TouchEventLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchEventLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchEventLoggerSchema(TouchEventLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e4fea546-0344-4861-aec6-1bcb06d76140");
			Name = "TouchEventLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,88,77,111,227,54,16,61,59,192,254,7,86,205,65,70,93,57,40,122,114,98,7,109,226,110,3,108,22,89,36,123,43,16,48,242,216,17,34,137,46,73,121,99,4,254,239,29,146,34,69,201,178,226,6,217,98,211,54,64,96,145,28,14,231,227,205,227,72,57,205,64,44,105,12,228,6,56,167,130,205,101,116,198,242,121,178,40,56,149,9,203,223,29,60,189,59,232,21,34,201,23,228,122,45,36,100,199,110,236,111,201,50,150,183,175,112,216,53,31,157,255,90,45,45,82,118,71,211,209,200,168,138,62,176,197,2,167,113,29,37,190,231,176,64,91,200,89,74,133,24,145,27,86,196,247,211,21,228,82,73,1,215,50,195,225,144,156,136,34,203,40,95,79,202,241,21,103,171,100,6,130,100,32,239,217,76,16,201,72,202,22,248,131,10,8,141,149,131,34,178,155,135,222,238,101,113,151,38,49,137,213,129,45,231,245,84,80,156,89,191,37,144,206,208,174,43,158,172,168,4,109,78,111,105,6,132,3,157,177,60,93,147,207,2,56,134,54,7,125,44,185,45,106,227,227,214,61,73,46,201,109,70,31,207,65,210,36,21,31,32,95,200,123,50,38,63,31,225,95,215,150,36,119,178,63,25,81,109,48,228,51,99,115,57,182,113,197,48,72,94,196,146,113,229,134,246,221,72,52,163,170,39,60,113,50,199,255,19,1,64,98,14,243,113,208,12,85,48,156,68,78,207,176,169,232,100,73,57,205,72,142,32,28,7,245,120,4,147,147,161,94,213,194,101,58,154,218,195,70,76,235,42,250,68,103,169,215,136,52,134,164,37,244,155,238,8,33,146,150,192,101,2,251,196,199,24,247,242,208,216,156,94,160,32,185,77,181,244,177,23,6,61,95,30,98,92,92,128,36,227,137,149,37,167,167,36,180,207,99,37,121,73,115,138,131,232,61,216,200,25,115,174,24,194,69,4,253,190,86,223,19,117,53,99,178,162,105,1,251,196,231,210,20,216,142,26,88,177,100,70,46,114,9,60,167,41,26,16,34,124,84,205,131,138,198,71,204,254,128,248,51,55,235,101,53,131,229,27,243,100,169,18,53,32,231,168,237,38,201,0,23,41,151,106,52,208,134,247,20,234,105,198,138,92,14,200,251,2,79,147,156,198,15,184,255,98,54,32,211,199,24,180,2,2,238,105,76,242,34,77,45,68,36,95,151,79,189,21,229,88,67,8,16,169,100,224,11,218,173,6,97,3,69,253,8,253,97,161,130,46,155,135,181,220,246,251,70,83,47,186,6,217,42,17,41,159,251,3,44,164,180,200,242,232,74,225,28,48,58,161,11,136,74,97,16,236,161,233,218,6,162,77,157,139,210,30,138,46,65,8,196,136,138,125,167,117,74,96,111,235,126,209,41,105,211,101,146,181,135,138,243,42,255,109,122,60,120,88,171,142,75,72,204,73,88,229,251,187,122,194,77,158,241,54,98,188,228,86,204,54,86,199,212,155,169,118,91,149,61,3,140,221,198,254,78,133,214,32,218,76,69,202,132,254,222,170,124,75,90,147,225,219,94,247,124,83,5,160,42,131,232,66,124,100,114,154,45,229,58,236,87,97,120,206,140,27,167,160,221,37,183,218,60,220,232,157,62,66,92,72,8,203,213,13,137,169,196,171,55,244,74,210,217,98,152,201,56,30,30,6,250,87,147,104,106,122,129,242,218,182,103,26,174,24,145,39,87,52,155,242,89,65,20,159,29,250,55,65,233,236,15,228,48,64,25,123,246,169,5,189,137,223,166,182,132,133,21,63,40,239,113,251,0,173,44,29,240,184,112,39,187,233,8,126,42,160,0,171,63,51,191,117,154,171,17,159,79,115,198,218,22,174,35,62,205,61,207,106,26,226,174,102,199,214,10,117,11,216,50,183,137,81,162,85,50,27,178,229,188,149,245,93,245,28,241,168,187,198,217,158,249,214,116,159,156,27,69,214,136,109,25,157,102,101,182,248,238,59,141,39,226,141,56,245,194,226,196,144,182,115,224,213,18,102,222,173,85,161,40,189,199,141,13,85,22,49,149,104,76,211,84,99,165,69,184,194,80,37,239,78,171,120,231,48,40,181,142,158,202,131,55,127,228,103,168,87,168,253,163,39,119,196,38,48,122,56,200,130,99,219,118,15,241,131,233,243,194,166,218,174,104,250,251,202,41,44,177,62,94,253,90,59,62,71,101,247,56,217,238,62,13,56,79,209,232,39,37,120,93,220,25,21,225,209,192,235,59,251,27,114,18,69,17,135,140,173,96,134,79,19,210,16,247,78,249,177,182,177,44,214,145,178,233,153,190,181,234,58,246,104,201,132,161,123,245,14,176,171,43,251,27,221,170,3,126,48,209,42,12,252,245,98,228,119,174,91,27,93,57,4,19,125,172,169,15,50,195,153,238,141,46,195,184,209,33,172,115,71,9,38,107,225,159,138,145,28,180,49,12,75,206,98,28,69,45,157,182,230,52,195,196,219,148,213,198,76,45,21,57,32,59,137,208,97,205,231,18,71,146,91,236,24,233,107,171,70,37,71,13,230,248,63,243,91,54,42,46,182,71,233,183,94,28,127,189,92,55,27,120,228,53,108,73,218,242,220,126,103,116,101,90,117,244,118,229,149,179,174,27,12,215,82,8,253,133,131,136,37,196,201,60,65,226,250,23,97,162,186,116,131,9,94,241,108,222,116,251,155,131,84,243,69,206,92,12,95,19,104,59,27,147,110,160,137,34,86,68,106,191,40,189,89,162,121,201,133,177,165,196,52,121,193,196,82,126,185,137,112,16,69,42,73,172,86,187,53,120,237,163,245,192,155,218,137,183,139,124,206,246,132,91,71,135,94,181,216,8,172,163,58,230,252,151,205,157,168,107,187,198,186,27,226,255,14,192,246,35,145,55,9,169,86,90,122,5,56,189,236,13,171,186,49,95,27,92,111,245,194,252,71,174,191,55,137,220,173,239,165,223,22,148,189,111,76,237,175,131,230,37,183,62,137,115,7,7,127,1,213,194,251,225,221,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e4fea546-0344-4861-aec6-1bcb06d76140"));
		}

		#endregion

	}

	#endregion

}
