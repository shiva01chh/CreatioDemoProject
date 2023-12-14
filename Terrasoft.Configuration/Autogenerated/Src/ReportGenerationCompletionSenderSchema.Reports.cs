﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationCompletionSenderSchema

	/// <exclude/>
	public class ReportGenerationCompletionSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationCompletionSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationCompletionSenderSchema(ReportGenerationCompletionSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("796ba3b1-67e9-4cd7-8749-45333ce9cc0b");
			Name = "ReportGenerationCompletionSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,86,219,106,219,64,16,125,118,32,255,48,117,32,56,80,228,247,36,246,139,33,33,208,64,105,220,231,178,150,71,242,210,213,174,152,93,37,77,67,160,191,209,223,235,151,116,118,117,177,108,171,150,2,237,91,3,9,214,104,231,204,204,153,179,199,209,34,67,155,139,24,97,137,68,194,154,196,69,11,163,19,153,22,36,156,52,250,244,228,229,244,100,84,88,169,83,72,149,89,9,117,121,185,48,89,102,116,244,193,164,41,135,175,154,247,55,82,33,39,63,34,57,164,104,161,36,106,23,45,133,253,202,71,248,208,25,97,202,136,176,80,194,90,248,132,185,33,119,139,26,203,66,12,154,43,244,159,30,80,175,145,66,202,116,58,133,107,91,100,153,160,231,121,245,204,137,132,150,161,45,8,88,9,139,32,86,214,145,136,125,46,152,4,108,200,247,159,40,212,128,180,41,2,113,83,37,170,225,167,45,252,188,88,41,25,55,128,16,15,108,117,228,73,106,6,188,145,168,214,246,18,62,146,124,20,14,195,36,163,188,124,232,5,131,47,182,136,99,180,214,80,73,219,232,140,227,37,114,245,92,243,104,52,183,89,196,206,80,40,102,28,198,14,215,229,161,125,230,66,224,78,75,39,133,146,223,209,115,167,241,9,36,67,8,205,235,103,182,220,6,57,5,17,98,194,100,54,238,107,116,60,157,151,252,68,77,189,54,149,60,112,213,80,239,200,147,11,8,252,141,88,81,48,3,254,123,47,180,72,89,67,183,232,188,202,248,200,65,59,227,11,47,188,209,235,113,142,152,149,156,229,40,113,32,67,92,208,6,34,84,40,219,41,162,222,121,31,37,185,66,40,184,243,243,248,223,23,206,118,87,208,211,235,61,186,141,89,15,108,212,51,231,151,200,215,215,50,85,44,89,83,184,150,188,223,210,121,136,228,130,68,6,154,253,96,54,78,154,139,108,57,203,223,224,241,124,201,164,16,102,220,25,56,14,120,124,127,140,75,214,231,162,235,105,0,233,198,164,189,253,109,81,149,137,153,172,26,84,116,180,125,0,76,232,10,210,118,190,164,2,65,38,111,99,193,27,4,111,195,240,154,233,73,178,127,36,66,89,228,34,53,234,238,54,27,51,88,25,163,2,239,247,101,181,59,205,54,167,133,154,220,28,208,5,135,12,190,135,207,22,105,95,197,225,112,23,53,23,61,151,127,43,150,96,89,71,149,82,73,90,227,55,119,212,18,107,231,124,218,200,120,3,210,242,179,3,145,240,148,33,63,46,136,188,163,15,20,81,99,99,229,150,135,86,63,178,108,239,79,225,29,251,211,65,17,118,163,97,232,59,91,46,253,190,215,147,153,195,135,186,210,164,247,116,211,84,237,107,91,75,103,123,107,219,59,191,43,219,217,139,190,254,245,155,95,165,249,61,214,137,206,108,101,81,109,158,175,82,44,244,175,31,63,203,8,72,7,207,166,32,139,42,249,239,29,195,189,163,84,213,190,95,252,27,159,168,36,198,131,76,186,188,169,171,64,39,78,13,84,11,146,255,179,192,82,161,175,109,157,182,164,252,110,6,186,80,10,206,207,91,209,168,61,240,224,226,127,250,42,175,98,187,38,200,49,255,243,27,14,139,98,102,187,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("796ba3b1-67e9-4cd7-8749-45333ce9cc0b"));
		}

		#endregion

	}

	#endregion

}

