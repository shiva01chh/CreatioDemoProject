﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoServiceSchema

	/// <exclude/>
	public class NotificationInfoServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoServiceSchema(NotificationInfoServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a6f8b77-e1cf-41ad-8745-4b6205a383e6");
			Name = "NotificationInfoService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,75,143,219,54,16,62,59,64,254,3,171,92,100,192,160,219,94,10,172,31,128,227,108,182,46,176,235,205,58,69,14,70,15,180,52,242,178,149,72,149,164,182,81,211,252,247,12,31,178,101,91,246,110,142,245,193,18,135,51,195,111,102,190,25,74,176,2,116,201,18,32,31,65,41,166,101,102,232,92,138,140,111,43,197,12,151,226,245,171,47,175,95,245,42,205,197,150,172,106,109,160,24,29,173,81,63,207,33,177,202,154,222,128,0,197,147,19,157,135,74,24,94,0,93,225,46,203,249,191,206,247,137,22,238,62,241,4,110,101,10,249,197,77,58,195,243,158,158,119,66,63,193,230,68,1,101,168,164,53,26,175,12,51,176,87,104,231,64,157,149,211,247,44,49,82,113,208,93,26,214,251,92,22,133,67,134,251,111,20,108,241,36,50,207,153,214,87,228,78,26,158,241,196,65,95,136,76,6,180,78,117,56,28,146,177,174,138,130,169,122,26,214,206,140,200,140,152,71,32,41,51,140,104,111,65,50,169,136,104,121,35,28,221,169,194,189,211,198,219,176,229,110,29,206,194,250,26,133,33,252,97,101,51,93,222,129,65,192,37,26,110,120,206,77,253,0,127,87,92,65,1,194,232,184,189,176,41,37,19,242,140,137,213,162,65,144,246,237,33,101,181,201,121,66,18,23,202,153,4,144,43,242,150,105,8,171,1,89,60,0,75,151,34,175,219,149,66,95,150,141,151,114,58,151,200,52,80,58,56,122,64,118,35,47,125,126,207,3,57,99,133,160,14,154,225,196,105,207,227,217,1,186,87,178,4,101,144,26,87,228,222,29,230,15,238,173,223,97,233,110,161,216,128,138,239,176,231,48,141,81,23,128,200,37,108,135,116,241,142,187,198,194,10,142,181,81,200,180,1,150,217,76,59,193,147,47,100,11,102,132,4,193,191,175,225,224,55,32,82,15,206,46,131,180,45,108,231,243,22,204,163,76,143,176,31,179,210,9,156,130,126,188,72,192,83,6,122,73,201,20,43,136,192,44,76,162,173,146,85,105,19,18,77,111,236,171,19,143,135,78,101,111,161,192,84,74,232,233,120,216,188,217,173,245,18,115,29,50,176,103,116,111,141,29,184,16,79,242,47,136,125,60,54,215,247,203,213,199,104,64,222,202,180,94,153,58,183,249,71,181,91,228,22,219,194,78,74,63,41,86,150,144,14,92,234,44,135,65,155,247,46,166,3,3,47,162,191,105,41,6,164,97,195,101,61,95,215,245,114,163,101,14,6,226,232,119,164,215,47,244,167,159,233,143,228,191,144,120,194,53,73,161,84,128,249,132,148,18,171,114,99,59,45,212,151,11,156,95,44,13,28,9,20,185,68,208,166,76,199,61,23,123,46,145,93,246,17,181,168,242,188,79,60,157,187,104,39,55,127,226,144,159,18,87,26,112,120,188,209,200,153,60,49,69,180,155,175,136,90,33,40,225,175,4,84,58,20,208,89,89,182,86,171,14,155,189,71,213,4,130,71,193,63,23,99,141,251,222,140,103,36,254,193,131,166,11,125,135,0,151,234,186,40,77,29,239,162,237,55,113,246,14,131,193,19,206,7,222,248,111,217,208,89,154,198,145,169,75,64,106,69,155,218,49,56,186,164,119,223,200,208,96,15,199,27,124,117,255,70,213,13,184,227,170,225,29,138,151,43,81,254,49,241,211,207,223,69,53,69,170,37,128,100,25,119,91,77,99,239,179,103,81,200,44,238,214,234,211,153,214,56,164,242,250,67,133,183,116,198,33,181,0,7,193,54,148,0,19,83,217,67,103,106,91,217,137,31,71,213,65,249,48,182,46,38,244,159,117,179,207,24,186,216,47,250,77,70,125,228,246,91,34,62,200,25,134,145,60,146,248,250,115,2,165,227,28,124,222,85,184,97,16,222,248,230,90,41,169,28,255,81,97,231,192,61,253,92,217,241,109,212,26,150,255,195,49,19,70,195,75,110,184,214,124,137,155,164,117,116,222,11,92,53,53,177,214,73,165,20,150,212,38,12,243,117,58,3,230,126,223,74,105,80,90,164,222,124,209,113,84,32,57,201,194,243,144,251,190,208,212,146,255,130,241,52,126,57,125,143,136,219,63,135,236,87,38,210,28,123,241,49,60,191,3,87,48,189,128,42,4,139,112,194,91,131,163,53,34,206,126,31,36,205,157,49,33,161,235,2,70,11,167,171,152,241,97,201,6,7,21,119,131,205,129,164,51,188,37,70,71,173,213,249,49,50,217,97,248,238,86,221,239,78,112,191,109,126,166,77,123,189,227,175,154,208,188,109,17,74,240,247,13,230,74,141,43,241,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a6f8b77-e1cf-41ad-8745-4b6205a383e6"));
		}

		#endregion

	}

	#endregion

}
