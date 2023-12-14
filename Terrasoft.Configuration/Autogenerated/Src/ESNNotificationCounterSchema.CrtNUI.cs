﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESNNotificationCounterSchema

	/// <exclude/>
	public class ESNNotificationCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESNNotificationCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESNNotificationCounterSchema(ESNNotificationCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b5a5a03a-ef2c-4bb6-b02a-d536cf42f5bf");
			Name = "ESNNotificationCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,111,219,48,12,61,167,192,254,3,225,94,100,32,112,238,109,18,32,77,211,46,135,117,69,187,143,227,160,218,76,98,212,150,50,125,164,11,134,253,247,81,146,237,56,78,188,161,189,164,162,201,71,242,241,145,130,151,168,183,60,69,248,130,74,113,45,87,38,153,75,177,202,215,86,113,147,75,241,225,226,247,135,139,129,213,185,88,195,243,94,27,44,175,59,111,242,47,10,76,157,179,78,238,81,160,202,211,19,159,91,110,248,193,216,206,85,150,82,156,255,162,176,207,158,220,222,208,39,250,120,169,112,77,121,97,94,112,173,175,96,241,252,240,32,77,190,202,83,95,251,92,90,97,80,121,207,209,104,4,99,109,203,146,171,253,180,122,63,42,185,203,51,212,192,161,68,179,145,25,24,9,107,52,96,54,8,194,150,47,168,64,174,28,42,136,22,172,78,106,188,81,7,112,172,17,121,161,37,164,10,87,147,168,135,210,100,121,166,200,8,70,14,101,107,95,138,60,133,212,245,211,211,14,92,193,57,0,10,118,147,106,40,185,203,177,200,136,147,71,149,239,184,65,79,194,96,27,30,160,144,103,82,20,123,248,170,81,81,113,34,204,15,126,216,163,119,32,121,112,137,34,11,168,213,187,102,157,184,48,202,166,70,42,151,200,151,94,229,9,109,156,111,128,117,146,30,231,140,193,183,49,56,182,38,243,13,166,175,51,181,182,37,10,243,96,139,130,9,146,174,92,177,78,116,124,237,163,59,141,192,4,78,58,27,12,254,252,187,189,79,94,19,125,20,238,100,158,193,19,45,15,145,128,31,185,200,10,234,108,233,116,254,68,228,210,152,148,255,25,194,242,54,247,41,73,39,99,162,139,212,60,132,92,152,41,57,104,91,152,186,223,29,87,144,58,130,168,214,16,74,203,100,104,183,108,41,190,241,194,226,216,5,177,200,147,24,85,109,6,136,100,150,101,172,77,244,189,146,118,235,167,147,116,70,48,12,57,226,119,246,47,13,209,134,89,205,64,245,132,93,174,140,229,5,60,163,59,0,224,235,37,244,240,100,247,150,24,74,165,48,60,53,203,172,221,167,14,254,19,96,193,53,6,129,111,21,10,235,140,46,246,81,131,36,48,193,238,172,72,19,159,133,5,75,50,163,3,163,114,253,202,226,56,166,71,195,80,21,119,167,100,201,162,14,13,205,215,239,27,84,200,162,207,111,116,182,150,89,20,39,75,189,248,73,45,213,224,143,92,145,204,156,104,15,141,212,177,51,145,177,104,169,221,184,79,3,61,251,108,69,215,0,143,3,230,52,92,226,238,102,95,165,163,178,254,159,177,158,182,177,74,84,236,189,111,130,173,221,236,94,66,111,120,242,208,250,232,206,5,169,160,210,240,178,175,231,152,52,8,163,46,196,120,235,42,7,183,150,147,168,169,61,154,206,195,191,64,151,86,56,112,18,246,120,228,125,15,161,161,51,221,24,14,43,51,132,55,55,34,120,197,61,228,26,214,78,217,238,40,135,85,161,181,131,157,91,14,247,205,155,90,5,182,65,171,131,212,187,139,36,221,147,75,213,35,224,198,112,124,147,22,229,214,236,235,163,116,50,58,167,250,176,172,164,122,39,246,158,66,88,203,191,217,146,206,94,29,192,131,111,240,75,22,191,48,181,6,195,245,97,225,132,192,100,122,114,163,234,187,84,157,159,99,109,5,99,159,182,42,91,219,68,22,247,247,23,65,169,131,124,72,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b5a5a03a-ef2c-4bb6-b02a-d536cf42f5bf"));
		}

		#endregion

	}

	#endregion

}

