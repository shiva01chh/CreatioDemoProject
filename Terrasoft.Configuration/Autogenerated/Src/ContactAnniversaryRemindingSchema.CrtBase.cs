﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactAnniversaryRemindingSchema

	/// <exclude/>
	public class ContactAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactAnniversaryRemindingSchema(ContactAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c4b1b64-b27c-4328-a268-9f3a28a907bf");
			Name = "ContactAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,88,221,111,219,54,16,127,118,129,254,15,156,250,34,3,158,188,143,151,45,78,12,56,78,82,100,91,219,52,78,251,82,244,129,145,206,9,81,137,116,73,42,173,23,244,127,223,145,71,201,146,45,43,201,128,110,65,144,136,34,239,238,119,199,251,148,228,5,152,21,79,129,93,129,214,220,168,165,77,230,74,46,197,77,169,185,21,74,62,127,118,255,252,217,160,52,66,222,176,185,42,10,37,39,245,122,177,54,22,138,237,53,210,231,57,164,142,216,36,47,65,130,22,233,164,193,67,67,123,149,156,28,111,94,52,81,224,214,169,180,194,10,48,120,0,143,188,208,112,131,92,217,60,231,198,28,32,177,180,60,181,51,41,197,29,104,195,245,250,18,10,33,51,228,227,143,143,199,99,118,104,202,162,192,157,105,88,7,26,150,113,203,89,105,32,99,215,107,60,4,192,82,13,203,163,168,135,103,52,174,152,28,142,27,92,87,229,117,46,82,150,58,76,125,144,206,229,82,177,123,15,108,7,89,11,154,200,88,170,242,178,144,236,142,231,37,36,53,65,83,106,37,246,101,137,199,207,51,118,207,110,192,78,152,113,127,190,61,66,200,213,122,5,231,79,22,20,168,30,43,236,18,108,169,165,97,86,151,192,196,146,165,165,214,32,45,74,37,16,22,217,49,97,216,105,177,202,213,26,30,64,112,39,180,45,121,206,174,149,202,217,185,169,136,156,77,7,131,1,34,66,92,218,75,172,112,30,29,85,250,226,63,99,77,82,209,208,190,7,63,24,244,105,112,46,209,253,120,46,254,6,131,188,63,151,66,163,199,120,223,89,106,85,48,112,238,185,102,2,153,115,153,194,136,41,77,27,238,200,53,55,164,117,195,198,78,91,169,44,203,21,207,32,219,163,175,127,179,226,154,23,76,98,120,30,69,193,94,62,24,214,209,244,112,236,55,91,182,81,206,13,106,176,49,29,101,45,194,97,176,84,235,101,50,191,133,244,211,76,223,148,5,42,243,186,204,243,120,75,220,112,226,169,156,57,219,252,146,11,45,28,230,185,215,239,189,83,143,142,210,246,34,189,133,130,51,67,255,182,105,105,119,247,60,49,99,171,38,107,36,38,46,109,137,19,182,143,218,249,213,54,41,173,77,114,134,209,120,188,126,141,118,141,35,231,6,168,31,241,193,155,138,127,104,131,124,9,246,220,52,212,251,203,223,90,188,97,63,172,108,186,101,212,51,176,233,237,25,58,194,201,113,220,5,125,132,33,59,98,18,190,124,248,200,238,87,237,157,13,247,111,193,244,222,75,7,149,79,179,29,140,110,39,107,192,60,116,177,58,109,194,156,4,63,15,190,254,2,100,70,169,244,223,164,213,199,38,60,118,192,142,49,4,186,249,12,66,38,172,100,95,104,181,194,66,1,40,31,31,45,150,15,200,232,196,170,90,98,0,242,76,201,124,253,96,150,13,251,238,121,18,196,180,53,222,168,236,242,130,46,83,171,52,10,246,138,245,39,207,234,116,210,25,168,88,80,52,30,146,84,253,162,233,187,214,186,206,19,73,51,130,247,230,187,30,45,227,45,198,109,185,195,3,230,114,79,188,245,54,184,42,69,138,11,0,244,165,170,222,69,228,105,13,195,225,38,250,231,67,166,142,131,139,46,84,169,83,114,207,122,63,228,220,192,129,94,87,231,106,135,28,252,15,198,110,50,17,89,52,157,135,178,164,33,85,218,85,211,239,124,63,35,42,166,34,195,139,178,183,194,236,185,168,75,15,199,219,84,100,59,247,147,52,55,30,168,248,255,133,29,17,210,198,146,105,163,203,250,238,198,124,40,27,56,104,67,202,241,131,94,131,187,131,93,245,208,235,22,28,189,121,41,116,11,93,145,35,40,243,212,23,179,47,253,188,2,123,171,50,159,243,196,29,183,208,115,141,11,176,117,182,69,241,190,203,192,71,84,153,185,190,123,150,161,202,239,176,1,96,248,203,13,70,97,10,206,28,117,143,247,216,94,195,128,235,221,183,154,12,66,71,93,6,2,217,48,119,53,110,230,81,84,173,149,137,23,158,3,35,70,149,109,199,227,43,117,162,14,48,198,10,133,144,249,210,130,102,243,203,87,63,254,250,219,207,63,253,142,24,145,28,104,222,160,106,106,144,131,213,174,140,232,32,141,106,217,44,23,168,30,102,174,13,136,144,188,222,150,80,85,209,211,175,43,13,198,56,19,183,169,93,63,224,113,109,245,3,158,107,220,33,41,92,123,69,164,149,49,127,40,33,227,168,105,243,104,152,204,76,28,25,94,86,110,34,40,157,16,64,153,193,215,93,193,254,245,155,229,150,208,64,191,131,154,30,18,202,159,180,32,129,163,58,135,163,33,58,169,147,202,100,29,234,181,181,35,100,31,90,192,63,238,16,182,104,102,50,171,113,144,35,160,49,176,57,255,140,157,122,28,228,95,56,71,2,188,240,216,13,2,195,225,94,6,13,69,146,215,202,198,142,147,15,193,94,146,16,197,212,204,57,10,101,247,136,119,137,196,29,75,22,139,139,46,24,85,49,68,190,212,109,245,233,210,55,89,12,135,205,232,223,14,31,7,48,28,63,19,185,227,213,25,50,13,100,67,202,94,201,155,21,200,227,92,165,159,58,177,210,161,65,175,9,250,81,87,28,222,232,125,198,160,235,8,112,230,185,50,64,120,134,79,76,119,173,22,175,119,120,36,51,176,47,194,222,50,158,231,108,233,77,102,216,18,103,173,106,160,164,57,172,187,188,85,9,45,216,216,145,225,172,104,93,102,225,155,146,225,18,19,213,140,254,58,247,217,37,25,106,86,221,40,230,115,14,78,43,180,110,97,10,215,247,120,110,201,159,128,28,27,101,172,26,47,195,8,229,72,158,192,205,143,2,209,244,234,22,54,248,50,231,3,168,39,78,179,126,246,86,75,172,135,128,175,177,168,249,175,61,187,112,105,162,54,211,87,42,19,75,129,93,248,19,238,227,112,92,81,239,169,253,117,107,143,53,65,107,145,1,11,183,116,66,136,128,150,237,248,24,49,52,148,215,238,130,11,125,72,85,98,20,170,197,148,181,172,80,151,118,28,238,218,109,4,13,119,103,192,17,32,156,74,126,157,227,100,23,97,224,160,150,169,183,197,251,95,162,205,124,215,25,182,33,94,195,148,198,32,167,129,63,110,181,105,245,135,138,38,175,254,10,218,230,27,82,186,255,176,65,59,237,228,178,99,195,250,99,192,219,134,41,112,180,138,43,4,110,58,72,58,15,144,200,89,150,53,119,214,205,100,64,102,118,153,3,173,219,19,244,187,147,166,127,131,63,255,0,142,117,216,18,115,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c4b1b64-b27c-4328-a268-9f3a28a907bf"));
		}

		#endregion

	}

	#endregion

}
