﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationEventListenerSchema

	/// <exclude/>
	public class DeduplicationEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationEventListenerSchema(DeduplicationEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5977cffb-468d-4a86-a1e4-3fa810cbe99a");
			Name = "DeduplicationEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,77,111,226,48,16,61,83,169,255,193,162,23,42,161,228,94,218,72,11,108,37,164,69,187,91,144,122,118,227,33,120,113,236,200,30,71,155,173,246,191,175,243,1,33,77,72,179,85,185,36,158,143,247,102,38,126,131,164,49,152,132,134,64,182,160,53,53,106,135,222,66,201,29,143,172,166,200,149,244,150,192,108,34,120,88,156,174,175,94,175,175,70,214,112,25,145,39,48,184,217,83,157,204,78,166,115,12,13,222,35,13,81,105,14,166,43,226,25,94,92,84,28,43,233,188,206,127,163,33,114,12,100,33,168,49,119,164,65,251,53,5,137,223,184,65,144,160,139,104,223,247,201,189,177,113,76,117,22,84,231,70,10,161,73,253,14,121,62,17,21,128,119,204,247,207,0,18,251,226,194,73,152,179,247,144,147,59,242,37,73,26,166,57,53,224,0,94,139,186,234,54,148,52,72,37,186,86,126,20,208,165,187,162,113,46,116,15,13,148,41,41,50,119,214,249,116,150,21,43,152,39,43,96,177,135,240,0,122,75,35,242,64,198,157,190,241,108,8,236,220,138,67,163,165,252,211,45,4,119,77,84,224,61,17,31,164,216,82,115,120,159,166,21,117,100,187,1,201,202,73,54,199,250,200,65,176,124,166,154,167,110,22,85,105,229,129,132,249,204,79,179,60,231,105,92,233,77,168,121,130,115,203,5,171,167,59,44,250,189,242,214,128,123,85,214,167,16,66,4,118,172,176,58,146,148,107,180,84,144,84,113,70,86,146,35,167,130,255,129,6,255,18,18,135,15,50,204,86,242,151,75,115,166,181,98,32,38,183,36,151,223,104,84,104,164,84,87,230,205,185,100,247,171,133,53,168,226,203,149,79,135,14,36,152,20,20,163,225,243,187,157,93,42,170,129,177,166,146,70,173,66,42,107,48,233,65,233,186,249,211,55,98,57,225,92,210,208,192,42,55,64,117,184,255,105,65,103,221,147,107,7,244,213,94,95,238,41,169,223,131,73,191,36,63,1,175,165,172,203,152,157,185,27,164,26,243,230,91,222,55,95,236,239,80,69,156,109,193,98,251,114,185,7,205,145,41,183,117,53,236,30,198,93,139,213,251,46,157,185,40,102,236,7,103,123,72,165,238,159,132,51,40,133,84,71,77,142,40,238,202,34,252,198,124,41,228,207,163,116,254,91,114,61,77,150,214,166,177,176,185,223,63,182,114,17,243,89,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5977cffb-468d-4a86-a1e4-3fa810cbe99a"));
		}

		#endregion

	}

	#endregion

}

