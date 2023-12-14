﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseTouchQueueMessageProcessorSchema

	/// <exclude/>
	public class BaseTouchQueueMessageProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseTouchQueueMessageProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseTouchQueueMessageProcessorSchema(BaseTouchQueueMessageProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aa70af8-d87d-47b6-96a6-1b7d6c78bd6b");
			Name = "BaseTouchQueueMessageProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,86,77,111,219,56,16,61,187,64,255,195,192,189,200,128,97,239,217,31,42,186,78,186,40,182,9,178,104,122,90,44,10,90,30,43,68,37,210,32,41,183,110,145,255,190,67,82,148,40,201,118,146,67,44,81,243,249,222,227,144,130,149,168,15,44,67,120,68,165,152,150,123,51,219,72,177,231,121,165,152,225,82,188,125,243,251,237,155,81,165,185,200,225,203,73,27,44,151,189,119,178,47,10,204,172,177,158,253,133,2,21,207,90,155,56,172,194,118,61,47,228,150,21,139,197,70,150,165,20,179,207,50,207,105,249,146,223,236,35,203,140,84,28,53,89,144,205,59,133,57,229,131,77,193,180,94,192,159,76,227,163,172,178,167,127,42,172,240,14,181,102,57,62,40,153,209,147,84,206,99,62,159,195,74,87,101,201,212,41,173,223,107,11,212,96,83,22,8,230,116,192,29,148,222,31,246,74,150,228,131,8,153,194,253,122,220,102,24,207,211,89,136,57,143,130,30,170,109,193,51,96,91,109,20,21,12,153,45,239,133,234,192,151,127,254,219,111,87,123,219,46,65,108,84,101,161,160,174,31,92,54,111,209,111,207,45,124,18,220,112,86,240,95,212,33,3,129,63,128,147,63,19,196,182,220,131,121,194,184,187,235,85,82,199,190,155,89,147,109,222,79,183,58,48,197,74,16,36,169,245,184,210,168,168,92,225,133,49,78,55,149,82,40,12,216,117,200,154,15,179,213,220,121,185,32,53,124,215,43,73,190,118,34,67,55,209,132,224,220,146,127,210,95,182,42,30,141,172,204,40,255,26,232,225,142,9,138,171,72,178,198,47,39,158,225,7,201,133,209,227,201,210,121,220,75,195,247,220,249,88,0,7,117,133,239,253,132,222,219,50,240,133,180,96,48,63,37,126,237,185,166,20,197,206,179,218,165,152,250,60,160,50,164,244,133,125,54,20,14,119,222,228,16,94,225,134,187,36,4,254,234,145,36,59,133,143,149,200,86,131,218,166,196,183,73,83,8,21,44,175,106,165,85,70,95,243,183,71,98,206,99,100,117,96,36,20,50,167,31,250,4,7,207,139,221,178,104,205,46,9,228,160,248,145,138,128,126,64,248,134,237,203,178,219,230,145,43,83,177,98,232,19,63,123,98,115,52,176,78,59,193,224,253,123,72,58,11,107,103,58,114,67,195,15,148,147,101,127,213,143,159,38,150,234,104,179,125,80,121,85,210,231,164,47,235,41,116,213,56,153,212,196,235,51,245,172,225,200,138,10,95,163,130,59,52,79,114,55,148,192,139,219,92,123,170,73,62,23,121,8,232,54,83,234,40,249,14,6,74,189,96,76,63,150,107,130,205,1,118,79,155,61,25,8,47,140,208,215,199,185,65,157,41,126,176,24,94,14,231,244,12,10,117,85,152,97,232,160,22,215,14,65,126,45,206,13,245,249,200,75,164,50,152,50,246,45,142,77,76,253,49,133,219,159,25,186,130,0,155,39,26,2,85,81,132,105,114,100,202,139,222,162,64,223,58,160,68,16,144,41,223,67,18,133,233,198,105,3,69,48,68,241,98,112,154,22,90,24,108,132,72,189,179,79,98,47,147,166,174,105,220,99,207,123,58,200,26,226,41,52,149,18,254,229,217,253,143,51,220,42,69,131,248,124,138,166,203,105,171,130,81,36,249,150,48,121,164,51,158,239,208,33,95,207,247,154,169,196,157,1,76,127,63,171,170,8,254,82,231,4,84,56,177,153,30,14,232,26,255,134,220,101,227,219,20,77,17,130,32,102,95,77,118,47,127,120,35,163,78,129,161,70,24,97,143,252,75,153,237,240,176,243,55,153,252,71,160,31,229,119,98,93,231,53,132,207,144,49,67,3,50,137,117,212,48,110,245,73,182,231,145,91,88,203,154,8,243,164,66,57,207,225,8,27,120,118,180,224,169,139,187,125,245,176,121,233,66,113,131,123,46,104,202,144,154,253,213,38,99,34,156,0,13,9,116,128,104,89,250,203,212,107,111,11,181,239,56,189,118,12,197,172,218,27,88,124,117,112,17,125,231,58,93,205,195,83,116,171,8,227,97,43,101,1,27,38,122,130,187,60,195,236,28,15,172,219,187,177,97,116,139,250,27,79,97,43,182,42,8,51,169,7,180,135,191,187,232,214,236,223,255,8,80,139,203,129,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aa70af8-d87d-47b6-96a6-1b7d6c78bd6b"));
		}

		#endregion

	}

	#endregion

}

