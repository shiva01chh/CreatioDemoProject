﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeEventsProcessorSchema

	/// <exclude/>
	public class ExchangeEventsProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeEventsProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeEventsProcessorSchema(ExchangeEventsProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5918b317-f3eb-4f95-90fb-5f4a75c9d44e");
			Name = "ExchangeEventsProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,86,77,111,219,56,16,61,167,64,255,195,64,189,40,128,32,223,83,91,11,55,245,102,13,108,131,2,78,182,192,22,61,208,210,200,230,174,68,106,73,202,137,27,248,191,239,144,250,176,36,75,217,0,155,67,32,145,195,199,55,111,222,140,12,130,229,168,11,22,35,60,160,82,76,203,212,132,183,82,164,124,87,42,102,184,20,239,223,189,188,127,119,85,106,46,118,176,57,106,131,249,199,193,59,197,103,25,198,54,88,135,119,40,80,241,248,28,179,22,6,119,21,212,178,224,225,42,103,60,59,239,118,47,205,115,41,198,119,20,78,173,135,191,178,216,72,197,81,143,69,124,195,109,248,155,49,69,184,220,106,163,88,69,145,2,41,244,131,194,29,189,193,109,198,180,190,129,213,115,188,103,98,135,171,3,10,163,191,42,25,163,214,82,185,208,217,108,6,115,93,230,57,83,199,168,126,119,199,160,80,242,192,19,212,144,163,217,203,68,67,42,21,96,13,5,232,176,108,144,5,35,102,97,3,54,235,160,125,255,140,41,43,51,243,137,139,132,98,124,115,44,80,166,254,122,130,209,117,0,247,84,50,88,128,55,17,225,93,255,32,216,162,220,102,60,134,216,241,156,136,132,27,248,196,52,186,146,12,182,2,152,34,64,216,47,78,150,179,132,36,170,81,165,173,3,41,249,213,93,92,69,212,36,38,144,252,101,81,208,89,81,89,7,88,247,237,154,184,153,61,215,126,111,53,0,91,77,122,55,248,108,194,206,243,50,174,213,1,107,214,171,83,117,253,176,112,110,97,45,184,225,44,227,63,17,4,62,1,39,238,76,144,253,101,74,177,136,16,43,76,23,147,218,194,44,10,91,232,217,16,123,94,48,197,114,176,61,181,240,122,204,189,168,3,222,203,219,155,69,45,137,112,62,115,8,209,255,19,143,138,55,162,13,176,70,164,27,216,82,217,135,210,178,81,13,63,160,72,170,58,247,139,254,165,114,60,213,91,73,67,16,152,188,162,249,198,48,69,157,128,214,104,26,244,81,196,123,37,5,255,233,166,194,91,245,44,53,170,9,65,31,251,91,83,138,94,64,186,103,52,168,180,23,109,250,172,224,188,215,175,74,147,46,28,184,50,37,203,224,32,121,82,101,56,128,240,251,180,160,159,0,21,233,51,119,79,148,241,156,26,136,154,63,0,185,253,139,182,163,206,237,117,57,174,254,32,207,38,204,84,62,240,135,88,157,248,143,46,124,48,38,31,152,254,91,187,255,161,163,122,143,79,223,184,217,247,25,206,91,175,181,19,97,245,140,113,105,220,60,152,102,27,249,195,235,223,108,158,206,176,24,117,78,237,119,26,177,182,89,207,163,213,18,172,6,108,107,159,91,133,36,143,30,237,226,139,124,186,30,1,38,18,130,182,27,116,252,137,100,169,93,66,24,141,247,4,255,167,196,117,226,189,189,253,177,189,211,139,238,167,184,143,244,187,179,83,157,54,157,115,212,253,203,68,224,140,223,56,228,192,148,243,88,253,125,56,7,132,244,157,94,38,57,23,143,52,251,236,110,101,145,187,146,110,178,65,91,249,108,173,187,65,99,168,172,122,157,208,105,43,183,13,240,59,48,235,164,54,87,115,83,199,220,139,90,255,190,163,252,134,79,208,165,243,192,115,252,83,10,210,51,24,191,191,190,166,178,25,104,114,17,42,151,250,50,33,63,209,7,109,1,119,104,190,84,71,235,181,139,150,120,13,217,38,112,246,108,157,238,43,237,88,9,124,245,2,222,230,130,140,23,140,49,60,5,237,145,53,253,70,90,39,54,174,163,193,99,237,168,94,164,219,178,234,144,49,243,162,127,160,221,219,216,61,56,185,67,167,42,29,163,142,13,197,209,65,244,159,211,226,4,41,23,44,203,90,152,254,137,95,194,219,76,210,23,99,99,127,199,72,177,18,73,213,193,225,239,114,39,75,19,64,202,50,141,13,214,244,0,168,86,251,139,180,70,127,255,2,78,93,83,2,136,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5918b317-f3eb-4f95-90fb-5f4a75c9d44e"));
		}

		#endregion

	}

	#endregion

}

