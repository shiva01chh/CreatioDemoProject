﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageProcessorSchema

	/// <exclude/>
	public class TouchQueueMessageProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageProcessorSchema(TouchQueueMessageProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df156054-a09a-4b76-826d-896d4920eed5");
			Name = "TouchQueueMessageProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,77,111,218,64,16,61,131,148,255,48,162,23,231,2,247,240,17,165,8,85,145,146,52,85,211,115,180,152,193,172,186,222,165,187,107,90,26,229,191,119,246,195,6,27,12,164,23,176,103,103,222,140,223,155,25,91,178,28,205,154,165,8,47,168,53,51,106,105,251,83,37,151,60,43,52,179,92,201,171,238,219,85,183,83,24,46,51,248,190,53,22,115,58,23,2,83,119,104,250,95,80,162,230,233,176,242,217,135,201,115,37,143,159,104,220,217,51,161,230,76,220,220,4,255,254,131,202,50,50,211,57,121,124,210,152,81,30,152,10,102,204,13,188,168,34,93,125,43,176,192,71,52,134,101,248,172,85,74,87,74,123,239,193,96,0,35,83,228,57,211,219,73,188,143,30,104,128,9,1,121,8,51,176,212,42,39,95,68,72,53,46,199,189,29,114,111,48,233,151,88,131,61,176,117,49,23,60,133,212,85,114,178,144,206,155,47,102,87,59,241,100,117,145,90,165,233,17,158,61,76,240,104,214,235,13,247,146,91,206,4,255,75,85,74,252,13,156,162,153,36,129,212,18,236,10,67,1,253,42,124,208,140,31,173,153,102,57,72,18,118,220,43,12,106,202,47,131,92,189,201,15,186,135,180,50,84,224,253,209,192,135,121,148,248,164,237,207,152,252,168,193,66,61,203,53,184,142,233,116,26,78,227,134,155,107,128,206,123,164,10,229,34,176,85,167,142,50,174,81,91,142,142,56,205,55,204,98,112,88,135,27,184,159,201,34,71,205,230,2,71,159,153,193,246,154,39,240,154,55,76,102,186,98,92,14,255,31,177,105,9,128,48,246,44,118,90,242,193,237,45,36,109,103,99,120,80,108,129,154,230,202,238,206,146,235,235,225,7,136,58,215,97,119,242,160,169,246,38,161,46,27,77,195,201,142,139,189,178,225,218,22,76,64,67,243,198,237,27,100,104,135,96,220,207,251,137,2,221,10,32,14,90,50,150,66,145,23,188,10,239,58,220,43,197,219,3,66,108,68,74,74,154,148,190,129,255,120,237,248,206,30,153,100,89,224,60,196,37,97,29,60,43,46,173,233,121,242,9,198,212,97,198,176,97,162,192,253,54,190,132,237,163,59,39,54,210,147,178,124,201,81,87,164,131,85,32,157,113,11,108,174,10,11,235,208,19,180,31,207,176,211,138,13,175,182,58,42,109,195,83,83,95,5,86,23,117,86,15,225,2,195,71,236,99,191,208,90,51,52,214,74,147,247,163,128,151,105,112,127,161,0,213,200,133,41,116,58,144,2,238,73,221,203,131,109,24,23,110,49,148,175,145,82,14,26,209,143,202,209,200,228,186,202,253,7,37,180,178,68,1,46,170,177,58,27,30,255,154,253,238,141,177,223,253,117,139,2,13,184,51,66,84,88,7,228,183,173,167,71,180,43,181,104,91,226,27,197,23,36,145,69,45,153,136,165,36,7,53,150,164,151,175,151,37,125,68,176,116,5,201,134,233,157,16,52,107,45,107,185,140,235,240,37,36,149,127,127,202,100,116,140,97,73,153,167,10,232,236,188,203,234,74,159,97,244,208,104,11,45,227,221,187,255,123,255,16,47,231,118,246,139,166,221,238,154,49,214,2,126,26,224,151,35,168,100,230,210,143,130,232,222,155,180,140,197,108,131,210,238,83,239,62,137,246,63,16,60,34,254,73,113,237,215,122,136,186,211,25,189,56,165,125,42,132,248,170,103,249,218,110,103,165,139,75,5,41,189,77,125,38,15,68,49,141,114,104,216,56,125,242,80,56,37,171,208,143,189,101,124,195,92,220,40,37,59,211,21,166,63,247,171,76,170,212,81,199,102,15,214,84,62,46,101,176,214,141,222,214,237,254,3,241,243,70,106,91,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df156054-a09a-4b76-826d-896d4920eed5"));
		}

		#endregion

	}

	#endregion

}
