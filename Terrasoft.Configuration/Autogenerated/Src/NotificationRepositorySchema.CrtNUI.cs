﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationRepositorySchema

	/// <exclude/>
	public class NotificationRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationRepositorySchema(NotificationRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d740bb45-cf82-4737-a258-74ecf82e9dfd");
			Name = "NotificationRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,203,110,219,56,20,93,171,64,255,129,227,110,100,192,144,247,137,99,32,13,156,194,64,147,6,233,96,182,6,45,93,43,234,200,164,74,82,105,140,169,255,125,46,41,82,38,101,197,143,12,10,76,179,112,36,242,220,231,57,226,37,163,107,144,21,77,129,252,9,66,80,201,87,42,185,225,108,85,228,181,160,170,224,236,253,187,127,222,191,139,106,89,176,156,124,221,72,5,235,203,206,59,226,203,18,82,13,150,201,39,96,32,138,116,135,241,221,174,215,156,237,118,242,146,47,105,121,113,209,172,39,159,121,158,227,50,238,35,98,60,30,147,137,172,215,107,42,54,83,251,126,83,82,41,201,138,11,146,81,69,9,77,83,192,119,198,85,177,42,82,147,107,226,44,199,158,105,85,47,203,34,37,169,177,190,247,208,143,80,113,89,40,46,54,228,130,204,251,119,208,94,151,31,125,16,144,227,6,185,45,160,204,228,5,121,16,197,51,85,96,114,141,170,230,133,8,160,25,103,229,38,116,118,75,83,19,99,177,106,30,46,143,155,124,69,28,144,133,212,255,250,225,124,249,13,59,78,22,37,79,255,6,65,174,8,131,31,118,49,30,6,38,82,161,203,212,11,132,125,214,118,57,26,225,227,29,101,52,7,129,188,41,77,0,136,120,224,103,34,7,195,134,144,232,3,176,172,105,130,125,183,29,65,177,40,81,235,202,116,91,76,175,27,64,151,194,134,67,116,105,225,73,11,26,119,81,147,138,10,186,38,12,181,121,53,48,93,24,76,39,99,179,216,143,177,173,13,81,150,248,126,98,227,158,134,155,72,163,126,246,108,132,33,49,114,136,138,21,137,13,156,92,97,239,235,178,36,63,127,58,140,91,114,216,72,61,9,254,195,48,116,45,242,122,13,76,221,227,246,23,49,91,87,106,51,123,73,161,210,145,44,111,209,214,252,46,172,119,178,19,65,180,104,3,16,95,75,219,195,4,221,129,122,226,175,106,118,62,99,152,145,160,203,18,38,200,12,126,128,83,130,90,120,16,252,185,200,64,200,123,236,111,236,42,17,160,106,193,172,48,181,100,252,78,117,76,252,212,250,130,5,93,14,99,182,241,158,169,64,225,202,186,84,86,225,159,11,169,58,150,174,109,125,133,84,126,74,232,98,191,176,203,150,205,14,118,199,106,176,145,204,165,97,45,30,182,236,218,166,52,121,250,20,226,73,5,52,125,210,66,209,233,24,169,146,130,133,14,91,55,65,85,8,195,239,150,165,58,105,199,122,114,131,238,20,204,237,78,172,221,217,252,77,1,173,201,31,29,249,69,77,106,201,117,150,181,32,103,184,245,242,221,47,228,84,250,230,108,197,13,133,221,69,25,223,214,44,13,193,35,155,213,97,111,154,60,200,244,10,156,161,6,99,218,167,136,142,218,252,161,33,59,194,240,69,17,224,222,196,125,72,43,11,57,14,243,104,189,118,35,239,51,170,240,16,112,207,71,26,137,97,144,7,172,177,237,103,224,219,9,193,105,72,99,247,194,249,18,122,164,44,135,6,184,179,221,218,135,45,65,175,186,236,246,84,35,240,226,249,209,115,39,153,9,193,69,12,47,201,29,206,111,28,62,35,141,113,174,182,230,247,13,226,180,115,238,13,26,253,184,153,125,175,105,41,31,244,228,0,133,35,176,9,111,63,219,202,45,255,69,203,26,147,181,203,240,82,225,176,133,204,174,190,206,179,63,50,66,95,73,19,55,14,92,237,137,43,184,224,116,242,151,225,208,112,22,72,222,121,147,225,216,216,126,52,142,37,161,120,36,134,223,196,129,33,222,100,35,167,187,235,33,225,43,162,158,32,44,105,50,118,64,111,104,31,167,241,186,44,219,57,161,111,65,36,182,151,161,221,137,122,216,135,59,74,172,240,122,79,175,3,159,239,144,92,77,157,172,143,80,228,196,253,218,105,177,61,161,243,225,137,181,220,152,105,114,234,21,74,255,14,166,102,176,245,51,208,185,90,253,90,230,62,110,204,236,245,166,98,120,171,210,203,120,214,122,119,164,102,214,157,123,159,106,202,14,62,144,255,36,148,254,1,119,154,68,78,59,119,130,238,234,38,141,76,123,70,161,215,95,34,167,92,240,186,58,75,84,198,98,48,253,212,26,254,63,180,101,242,113,226,50,57,30,85,87,131,58,91,94,77,3,126,91,125,153,70,141,154,22,189,77,97,157,185,130,171,102,3,255,254,5,4,41,163,56,86,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d740bb45-cf82-4737-a258-74ecf82e9dfd"));
		}

		#endregion

	}

	#endregion

}

