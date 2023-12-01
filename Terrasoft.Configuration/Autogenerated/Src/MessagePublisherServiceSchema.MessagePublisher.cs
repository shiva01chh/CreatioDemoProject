﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagePublisherServiceSchema

	/// <exclude/>
	public class MessagePublisherServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagePublisherServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagePublisherServiceSchema(MessagePublisherServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1192546-2c29-47d8-beae-ba5a9aac7785");
			Name = "MessagePublisherService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48b30807-c97e-44a3-a527-bc988772a6ce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,85,75,111,219,48,12,190,23,232,127,224,188,139,3,4,202,122,26,208,38,1,250,218,208,1,105,131,166,67,15,197,14,138,205,36,194,108,217,147,228,116,65,214,255,62,202,242,51,79,96,216,46,243,161,141,40,242,227,235,35,37,121,140,58,229,1,194,19,42,197,117,50,51,236,58,145,51,49,207,20,55,34,145,167,39,235,211,19,160,47,211,66,206,97,178,210,6,227,139,109,17,89,69,17,6,214,68,179,207,40,81,137,96,151,218,4,213,82,4,56,74,66,140,142,221,179,75,194,91,230,97,28,85,125,198,105,75,167,78,135,110,40,184,56,206,65,156,202,123,133,115,2,133,235,136,107,125,14,35,212,154,207,113,156,77,35,161,23,168,10,224,82,251,165,56,83,93,140,226,129,249,86,136,47,117,122,143,134,160,83,10,113,42,34,97,86,143,248,35,19,10,99,148,70,251,205,131,13,18,6,112,196,196,106,177,66,16,118,10,63,169,13,43,128,192,198,186,47,84,56,135,43,174,177,10,220,218,173,203,248,155,25,143,208,44,146,144,114,30,43,91,89,108,234,164,78,4,203,68,132,112,39,13,42,201,163,194,83,225,215,215,70,217,234,230,193,220,19,119,186,112,35,242,166,115,181,234,187,203,46,184,255,67,152,9,140,66,125,195,13,239,192,186,246,99,63,49,3,255,157,211,99,119,250,62,139,162,7,117,27,167,102,229,87,208,157,45,35,251,45,185,130,120,163,8,35,46,233,168,168,190,18,95,183,74,84,220,250,95,53,42,106,161,116,36,237,92,108,99,239,193,101,133,192,111,100,221,72,109,3,232,173,62,190,181,58,128,50,116,77,56,220,151,188,219,77,149,151,135,169,78,34,52,232,123,31,217,217,25,251,0,191,128,114,129,118,103,64,72,26,10,30,50,175,228,141,179,77,209,205,241,6,121,243,75,154,140,59,185,76,190,163,239,220,83,1,189,241,195,228,201,235,194,85,18,174,38,102,21,89,210,146,90,225,164,146,178,103,197,211,20,195,46,88,182,162,54,159,18,21,115,211,82,118,34,246,69,39,178,219,46,209,35,173,28,90,19,120,216,168,153,71,49,3,57,51,203,110,252,45,42,238,97,250,209,102,183,186,219,235,245,160,175,179,56,38,231,195,182,184,192,45,217,5,92,134,176,160,63,84,91,252,25,96,106,67,102,27,72,189,221,80,253,148,43,30,131,164,168,6,94,21,160,55,164,230,6,138,24,226,234,100,169,91,172,11,171,201,250,189,220,236,16,86,157,161,55,28,91,57,129,41,13,179,164,26,54,208,196,95,59,173,123,208,200,125,166,164,30,150,189,133,87,97,22,101,60,182,79,218,112,147,105,70,229,134,128,219,251,5,74,42,128,113,5,0,179,80,201,171,4,7,83,23,166,116,79,110,75,15,27,142,107,85,42,193,108,224,221,150,103,111,248,100,49,181,243,196,9,84,41,202,39,9,130,76,209,122,37,177,136,176,25,97,237,170,194,28,254,183,163,212,122,228,139,119,163,234,221,63,90,250,7,125,170,242,135,219,226,135,116,253,205,157,107,212,106,215,91,241,167,147,157,79,55,177,212,4,11,240,43,62,17,41,119,190,72,101,224,172,214,28,144,238,254,103,193,25,229,60,47,109,247,173,149,237,71,163,186,110,95,145,152,190,223,26,251,141,247,206,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1192546-2c29-47d8-beae-ba5a9aac7785"));
		}

		#endregion

	}

	#endregion

}

