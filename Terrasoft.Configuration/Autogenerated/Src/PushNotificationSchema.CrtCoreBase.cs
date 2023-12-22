﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PushNotificationSchema

	/// <exclude/>
	public class PushNotificationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PushNotificationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PushNotificationSchema(PushNotificationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7933308-4a2e-4831-9e68-33433e9c1b4a");
			Name = "PushNotification";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d653ba80-e9e2-4f78-8775-8ba14502d8a8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,75,111,219,56,16,62,187,64,255,3,235,94,100,192,80,122,217,75,155,164,72,220,184,235,69,147,180,72,178,61,22,180,52,182,185,43,81,46,73,57,245,110,251,223,119,248,146,72,70,110,26,96,123,136,203,225,240,155,7,191,25,142,56,173,65,110,105,1,228,22,132,160,178,89,169,124,214,240,21,91,183,130,42,214,240,231,207,254,125,254,108,212,74,198,215,228,102,47,21,212,111,146,53,234,87,21,20,90,89,230,239,129,131,96,69,175,19,194,10,56,36,207,223,157,31,220,186,224,138,41,6,242,160,194,156,22,170,17,145,198,21,220,43,116,71,171,252,33,27,62,124,180,174,205,14,238,189,20,176,70,247,201,172,162,82,190,38,31,91,185,185,106,20,91,177,194,229,0,117,142,142,142,200,177,108,235,154,138,253,169,91,107,69,194,3,205,220,43,30,5,154,219,118,89,177,130,20,26,124,0,123,164,19,220,187,128,110,43,209,234,136,140,39,250,168,177,239,97,82,128,236,78,130,192,83,220,94,1,105,163,229,132,24,244,209,151,88,76,78,18,61,157,161,209,15,107,232,37,240,210,122,227,214,206,181,57,131,170,212,78,9,182,163,10,156,87,118,65,4,208,178,225,213,158,36,238,124,121,96,39,53,49,26,133,70,46,65,109,154,131,86,150,77,83,145,25,229,31,154,117,230,67,219,81,65,64,115,100,127,83,108,160,166,24,91,98,212,82,200,109,95,82,78,215,32,242,57,227,229,2,115,77,121,1,231,251,43,172,131,108,124,217,44,89,5,97,118,209,208,120,242,102,208,206,221,162,68,83,161,228,109,142,50,171,204,86,36,123,145,104,231,191,83,249,39,173,90,32,223,191,167,72,185,217,200,23,242,162,222,170,125,54,241,193,141,4,168,86,112,178,162,149,4,11,253,195,252,117,114,164,10,132,119,231,19,133,28,50,116,23,45,199,64,32,115,235,157,182,50,37,140,43,82,211,111,31,128,175,213,198,155,210,46,91,53,116,227,170,173,170,107,97,157,49,135,30,120,100,164,3,30,25,121,110,161,201,241,73,111,135,188,181,123,228,181,211,185,105,151,214,94,246,106,26,184,243,43,84,12,88,210,40,188,100,40,125,248,110,73,118,76,168,150,86,100,145,214,11,158,216,177,18,4,153,33,101,21,248,165,167,130,207,148,169,86,205,138,169,207,165,4,165,240,87,134,188,187,111,196,223,166,125,222,238,183,29,20,178,194,52,18,219,151,246,216,19,213,241,226,243,144,230,105,230,184,165,133,214,164,249,223,201,48,176,70,210,235,172,115,206,29,63,28,228,54,9,15,161,57,94,109,79,210,222,232,11,187,213,221,179,11,27,183,161,94,86,251,79,152,77,196,135,82,219,69,152,238,96,126,54,164,97,45,140,6,236,71,185,153,55,162,0,147,160,67,33,156,102,131,30,76,45,254,136,195,125,216,51,207,196,186,173,177,182,178,177,191,174,241,180,191,185,201,0,95,83,15,227,106,74,233,180,107,88,73,176,41,188,163,138,102,169,203,90,72,74,252,19,82,132,55,247,31,169,64,143,149,97,134,246,247,83,11,98,223,9,179,49,170,160,151,120,26,110,89,13,249,157,42,174,154,251,41,25,123,73,216,129,138,86,8,140,207,117,89,133,105,92,148,143,225,7,103,22,229,216,101,46,237,145,179,94,41,239,144,3,195,235,150,233,126,247,30,127,114,124,94,245,175,103,175,182,137,233,3,161,178,4,117,98,109,229,11,174,154,131,237,213,233,220,0,222,154,246,15,239,179,106,107,158,247,17,104,219,147,72,207,22,111,121,205,81,61,204,240,144,210,249,222,160,254,52,115,209,185,203,166,52,60,251,57,186,215,122,50,252,45,83,21,12,133,217,117,107,205,161,220,168,77,201,111,175,38,113,232,151,32,37,190,96,143,3,56,69,13,145,98,224,228,118,86,214,140,223,113,166,134,83,110,16,98,181,24,226,172,44,153,190,66,90,105,218,15,65,232,201,11,83,177,67,94,224,17,193,176,122,255,129,235,229,95,72,13,11,31,67,244,46,94,124,131,162,197,40,158,248,20,184,89,201,206,19,110,90,138,234,246,6,33,50,77,92,34,163,192,186,22,175,108,202,221,170,182,249,243,197,108,78,167,7,221,137,218,167,218,116,208,168,133,252,111,126,96,135,96,166,168,112,172,60,182,91,94,229,148,208,56,149,193,147,254,34,45,116,236,182,11,57,199,202,104,5,92,112,186,172,160,204,198,72,91,91,157,105,79,147,227,244,229,15,123,104,56,88,17,249,148,241,75,123,145,76,95,169,105,228,204,142,21,81,247,3,249,213,245,184,16,211,244,187,204,154,119,202,15,182,45,59,187,167,192,45,79,52,162,230,161,93,99,97,248,87,227,17,156,238,5,62,4,52,243,10,30,73,239,207,89,133,133,33,181,94,166,215,182,65,89,233,103,166,54,93,237,200,204,10,241,35,101,75,5,195,66,50,47,237,197,87,228,16,62,12,238,218,176,232,244,252,55,137,124,237,191,198,220,140,25,8,172,151,152,250,84,245,65,223,238,83,174,43,213,229,124,232,189,235,198,240,81,220,44,240,72,66,110,171,101,186,26,110,90,138,91,153,107,84,40,245,84,183,242,184,63,224,118,204,114,203,67,235,233,10,63,4,105,177,33,153,118,153,225,87,41,206,184,15,226,239,92,213,74,158,9,8,171,245,253,108,229,46,208,140,227,174,202,78,179,152,53,121,48,121,217,55,217,223,245,175,96,37,204,137,192,158,52,199,29,152,95,195,193,213,207,61,7,134,177,220,52,34,51,176,132,69,173,187,134,255,198,234,82,230,103,158,84,123,184,59,91,105,44,68,89,248,239,63,13,158,28,218,122,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7933308-4a2e-4831-9e68-33433e9c1b4a"));
		}

		#endregion

	}

	#endregion

}

