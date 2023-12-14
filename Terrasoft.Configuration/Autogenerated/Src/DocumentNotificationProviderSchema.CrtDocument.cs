﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DocumentNotificationProviderSchema

	/// <exclude/>
	public class DocumentNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DocumentNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DocumentNotificationProviderSchema(DocumentNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9278ff4-42d2-4749-a9fd-a9f59f42dd6d");
			Name = "DocumentNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,219,110,219,48,12,125,246,128,253,131,224,190,88,64,161,15,104,186,2,93,147,22,30,186,37,104,82,236,97,24,6,85,102,18,13,182,148,233,146,45,24,250,239,163,44,219,181,221,180,219,2,231,65,20,15,121,72,30,74,241,10,236,142,11,32,43,48,134,91,189,118,236,74,171,181,220,120,195,157,212,138,252,126,251,38,241,86,170,205,192,195,0,155,190,159,116,87,203,131,117,80,161,189,44,65,4,152,101,55,160,192,72,49,121,1,62,198,226,25,45,39,6,54,33,233,85,201,173,61,35,83,45,124,5,202,125,210,78,174,165,168,9,45,140,222,203,2,12,122,227,183,243,15,165,20,68,4,255,87,221,207,72,126,204,76,48,70,168,176,203,124,45,161,44,48,245,194,200,61,119,16,174,194,127,23,143,100,42,235,242,184,57,156,91,103,144,254,41,209,15,223,177,230,11,178,227,6,155,233,192,216,73,31,113,111,193,96,71,85,236,11,249,230,7,231,73,155,224,4,84,17,41,116,150,182,23,216,77,103,188,112,218,4,94,117,193,29,173,88,254,107,133,103,255,68,153,214,115,78,18,183,149,150,45,193,45,186,155,172,231,84,179,125,252,59,229,143,224,182,186,120,137,173,84,142,220,128,187,210,94,185,172,77,124,227,101,65,236,193,94,22,149,84,247,74,186,188,32,239,72,22,204,180,38,245,68,227,75,58,244,75,191,214,188,146,41,182,123,37,43,32,69,232,59,130,91,195,243,0,133,135,112,217,34,247,220,16,17,232,44,33,232,23,177,10,126,146,120,200,70,19,163,65,229,190,82,217,181,87,130,197,34,210,59,64,54,5,246,54,61,37,41,50,162,148,77,165,117,82,33,158,214,41,18,118,109,116,213,247,108,237,183,176,118,115,143,188,62,104,169,178,116,217,171,45,165,108,174,70,209,145,137,227,34,148,77,89,110,103,63,60,47,71,160,161,83,147,37,71,254,77,134,86,45,199,162,47,125,45,141,97,244,14,208,20,215,132,252,188,5,3,45,62,244,185,198,220,130,181,115,19,145,177,83,172,19,83,22,38,195,86,26,105,238,113,14,188,12,168,140,210,54,226,165,42,178,52,183,119,192,251,249,159,69,89,243,210,194,16,52,108,64,154,191,138,31,202,135,82,194,109,51,236,40,135,32,80,3,214,151,65,9,61,93,176,217,47,16,56,169,165,224,37,55,231,232,118,145,197,157,72,12,56,111,84,131,26,174,73,163,250,184,123,65,248,93,195,109,167,254,6,30,125,216,172,218,185,195,209,32,141,62,49,200,76,57,233,36,216,70,164,163,64,202,151,229,209,0,123,141,107,54,220,239,255,127,31,158,204,216,159,209,179,151,140,214,37,236,225,240,9,164,253,69,28,58,55,251,120,252,133,121,140,47,126,223,134,166,240,251,3,196,26,109,230,197,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9278ff4-42d2-4749-a9fd-a9f59f42dd6d"));
		}

		#endregion

	}

	#endregion

}

