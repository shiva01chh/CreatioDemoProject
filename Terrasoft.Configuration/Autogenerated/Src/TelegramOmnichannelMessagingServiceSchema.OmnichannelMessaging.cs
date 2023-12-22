﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TelegramOmnichannelMessagingServiceSchema

	/// <exclude/>
	public class TelegramOmnichannelMessagingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TelegramOmnichannelMessagingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TelegramOmnichannelMessagingServiceSchema(TelegramOmnichannelMessagingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c62c8978-e085-4eda-b1ff-82133386db45");
			Name = "TelegramOmnichannelMessagingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,89,111,227,54,16,126,246,2,253,15,132,246,69,1,12,165,251,234,196,89,228,220,186,232,38,65,156,52,15,65,81,208,210,216,22,34,137,90,146,242,38,13,242,223,59,188,36,74,62,147,69,129,182,11,100,45,145,195,153,225,204,55,151,10,154,131,40,105,12,228,22,56,167,130,77,101,116,202,138,105,58,171,56,149,41,43,162,171,188,72,227,57,45,10,200,162,175,32,4,157,165,197,236,167,15,47,63,125,232,85,2,31,137,71,80,239,71,183,144,193,140,211,252,96,21,217,53,103,139,52,1,46,162,51,150,211,180,136,206,11,153,202,20,196,22,234,175,44,129,204,35,26,63,11,9,121,247,29,245,207,50,136,149,242,34,250,2,5,240,52,94,162,185,169,80,100,14,209,24,119,105,150,254,165,239,186,68,133,187,139,52,6,45,119,227,102,116,140,242,22,219,153,68,247,48,105,8,102,25,155,208,108,48,56,101,121,142,150,254,141,205,148,237,154,125,223,37,138,98,245,14,135,117,235,209,217,201,170,45,212,97,3,195,102,215,105,126,195,42,185,70,47,69,252,139,148,101,116,60,17,146,83,99,244,174,5,198,32,213,121,65,134,68,107,213,198,23,210,56,2,60,136,71,63,114,152,225,6,57,205,168,16,3,226,144,116,106,208,112,131,155,74,148,58,123,131,208,69,121,160,143,61,156,81,73,145,181,86,227,15,92,40,171,73,150,198,36,86,108,118,225,66,6,164,165,153,187,125,45,164,247,162,5,213,10,34,48,75,224,10,183,3,114,173,133,153,253,253,253,125,114,40,170,60,167,252,249,200,45,140,18,64,196,77,145,152,200,57,149,181,66,68,178,71,40,72,42,200,2,113,152,68,53,131,125,159,131,190,220,87,200,39,192,213,213,220,221,38,140,101,100,36,110,21,139,223,213,113,242,66,102,32,15,136,80,255,189,162,193,167,52,19,112,240,67,122,193,19,154,234,253,122,157,171,227,63,160,23,39,108,218,104,101,115,130,98,164,33,243,54,189,190,84,104,34,135,182,81,199,90,27,148,185,129,146,131,64,133,4,41,48,97,174,210,232,109,138,32,246,84,124,88,52,94,42,158,187,234,210,54,140,179,71,90,212,26,189,75,19,119,120,181,81,62,66,145,24,208,235,119,179,218,89,92,19,182,171,170,131,141,44,125,172,123,71,245,110,247,201,148,113,84,163,72,148,130,180,72,8,135,24,210,133,122,203,53,43,196,236,148,179,188,241,133,90,134,98,6,60,114,156,125,19,60,88,190,126,146,120,56,22,229,37,72,76,120,37,6,253,36,205,82,249,124,3,223,170,148,67,174,252,29,250,47,42,133,35,118,183,28,81,84,145,93,72,246,180,144,51,152,210,42,147,94,62,133,181,25,106,131,193,48,67,109,52,231,198,4,197,153,196,162,8,137,33,41,185,42,87,80,75,69,132,51,145,74,198,159,201,159,188,126,62,48,164,246,228,42,98,239,81,117,4,189,30,98,199,62,245,56,200,138,23,62,63,52,158,255,246,249,51,41,224,251,10,182,225,157,0,142,110,42,76,25,223,211,122,40,216,245,122,171,17,217,160,15,83,181,228,85,140,92,58,89,217,26,123,7,51,135,123,104,232,9,21,234,225,101,115,44,22,216,182,168,246,1,145,168,110,146,162,112,90,196,58,65,28,10,0,18,115,152,14,131,29,100,6,251,71,107,226,246,13,122,183,173,70,170,182,17,221,165,186,203,47,59,152,245,43,200,57,75,52,140,52,110,218,32,90,48,76,171,167,115,136,31,155,98,62,78,37,220,241,236,184,72,46,210,44,195,226,84,193,104,58,146,35,113,9,144,64,18,90,185,189,5,197,24,55,180,136,142,118,195,128,221,155,212,39,59,55,235,147,192,178,15,250,54,129,69,231,121,41,159,45,80,210,41,9,237,50,202,171,178,236,138,235,237,208,10,218,115,194,123,170,119,81,233,0,158,36,153,123,207,67,226,237,28,199,49,90,154,113,165,206,200,122,56,180,162,122,141,238,216,11,221,73,149,13,48,222,20,233,9,26,251,184,44,209,121,186,157,64,162,208,19,161,51,4,8,233,248,116,110,142,15,152,52,182,95,222,94,200,50,169,179,120,17,179,28,12,62,224,158,241,71,204,136,227,90,81,123,104,57,168,90,254,84,110,179,245,105,148,88,115,18,193,42,30,67,159,212,208,179,50,92,66,118,134,29,131,234,192,93,117,178,111,67,29,35,230,165,27,225,70,255,232,150,149,225,39,251,210,83,141,124,149,23,97,48,74,2,71,112,129,249,62,12,172,94,245,234,253,28,56,132,193,88,107,23,236,161,215,207,191,85,52,11,13,131,232,154,162,77,64,2,15,141,254,123,181,4,132,39,178,23,186,123,223,120,16,115,10,30,35,84,88,253,141,241,90,247,139,206,159,32,198,204,126,3,20,167,149,144,235,31,50,60,114,88,179,38,138,106,163,162,65,12,145,66,139,145,168,29,126,168,218,148,35,115,109,180,200,88,155,222,1,238,213,252,238,28,175,219,250,82,211,9,227,116,213,174,162,218,185,91,122,27,189,82,42,19,233,174,104,24,232,150,49,56,58,220,215,139,13,141,41,4,226,8,91,105,172,130,126,219,194,189,62,60,58,220,119,132,186,95,185,194,218,165,55,252,122,221,123,192,48,27,21,11,148,20,154,75,162,21,131,235,171,241,45,70,131,13,169,11,198,115,42,77,68,90,124,154,165,232,87,161,226,231,132,37,207,99,249,156,65,139,164,94,141,238,57,45,75,72,44,183,190,54,187,155,2,54,243,222,243,59,171,93,70,14,103,125,75,227,194,76,27,210,197,210,91,19,235,65,157,87,185,19,51,108,213,217,13,10,133,94,6,213,74,168,4,202,164,159,67,155,228,41,235,162,223,100,30,7,238,98,202,156,147,109,110,234,117,238,58,150,84,86,2,211,183,254,25,54,218,101,41,118,81,23,84,149,240,231,200,229,219,168,107,41,173,93,159,96,43,229,228,184,36,216,195,57,58,58,131,73,53,51,158,9,131,219,57,88,164,97,64,90,129,56,216,188,252,252,26,185,22,156,140,206,6,228,229,211,171,46,40,138,192,11,188,190,147,240,57,26,37,181,20,241,61,149,241,92,21,26,69,94,27,5,147,2,93,118,172,185,108,52,174,116,41,25,56,210,158,243,80,212,26,226,134,68,165,155,131,101,42,111,116,25,214,193,217,44,174,56,225,79,24,205,145,139,148,11,169,214,86,156,240,38,129,230,128,207,123,130,73,235,241,96,135,219,34,112,244,125,244,205,182,223,217,141,132,111,21,163,153,96,226,86,115,230,251,77,219,154,86,187,84,109,93,18,211,205,15,86,111,191,154,223,87,130,101,95,225,227,252,41,134,82,247,99,240,212,160,164,150,219,108,15,145,192,135,240,57,231,140,59,8,235,23,242,125,158,102,13,148,253,185,173,246,20,49,148,41,6,224,64,33,28,1,13,79,234,207,126,188,131,26,192,182,61,119,154,216,101,163,254,43,1,116,70,211,200,175,80,86,101,148,99,62,171,212,204,227,229,135,154,36,180,229,192,111,222,87,202,212,59,27,234,83,206,22,234,227,196,110,243,246,114,77,170,225,28,28,181,71,231,154,99,46,102,205,247,4,191,120,253,231,75,144,110,228,140,5,187,21,166,54,139,195,228,150,252,123,87,240,110,6,110,88,248,45,201,26,47,234,194,174,71,146,203,183,125,65,89,242,168,168,243,93,215,163,235,191,18,173,109,73,234,35,78,179,255,91,23,98,253,141,29,230,157,189,97,168,191,130,53,86,116,0,176,177,217,76,225,145,127,200,163,223,193,219,234,59,13,6,109,251,51,77,138,131,207,204,24,147,208,50,221,213,223,150,73,112,116,87,40,79,39,142,235,27,67,245,142,167,183,144,151,153,26,112,208,89,230,91,18,4,125,242,79,57,240,132,114,208,110,35,228,253,161,171,149,180,164,161,53,192,154,153,107,205,76,230,45,152,164,221,165,11,243,86,97,104,207,125,206,214,168,73,90,170,196,208,95,98,235,181,140,221,173,102,214,217,212,71,142,16,23,188,160,153,189,237,18,151,21,159,127,222,236,238,18,217,181,124,253,229,252,95,227,106,27,162,215,186,217,108,7,99,112,205,80,239,118,153,220,225,99,44,174,121,255,254,6,141,81,240,210,228,27,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c62c8978-e085-4eda-b1ff-82133386db45"));
		}

		#endregion

	}

	#endregion

}

