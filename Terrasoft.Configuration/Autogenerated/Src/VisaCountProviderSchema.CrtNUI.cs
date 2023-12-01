﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: VisaCountProviderSchema

	/// <exclude/>
	public class VisaCountProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public VisaCountProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public VisaCountProviderSchema(VisaCountProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f7eb7049-3302-470f-a43a-704b62a292d6");
			Name = "VisaCountProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("61be812f-b09a-4a44-9ef0-5c4c5cd6d152");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,219,110,219,48,12,125,118,128,253,131,224,189,216,64,225,15,104,186,2,93,110,200,195,182,96,89,219,135,97,24,84,153,73,52,40,114,38,74,201,130,161,255,62,202,178,29,219,77,183,12,240,11,41,30,242,28,94,172,249,22,112,199,5,176,47,96,12,199,98,101,179,81,161,87,114,237,12,183,178,208,236,247,155,65,228,80,234,117,39,194,64,54,126,63,108,158,150,71,180,176,37,191,82,32,60,12,179,25,104,48,82,12,95,129,247,177,100,147,231,173,129,181,47,58,82,28,241,154,61,72,228,163,194,105,187,48,197,94,230,96,40,132,190,157,123,82,82,48,225,131,94,198,92,179,249,199,194,202,149,20,165,128,22,212,75,241,248,166,204,84,130,202,169,206,194,200,61,183,80,63,239,130,201,198,178,212,194,205,241,6,173,33,174,87,172,120,250,65,2,111,217,142,27,234,156,5,131,195,54,226,30,193,80,251,116,104,2,251,238,58,246,176,169,15,58,15,20,250,140,40,152,74,57,97,11,227,121,149,66,27,90,65,246,11,193,201,69,60,211,114,146,81,100,55,18,179,37,216,69,243,146,180,130,74,138,207,255,230,249,1,236,166,200,95,163,40,181,101,51,176,37,203,164,46,60,115,50,103,120,196,187,124,43,245,189,150,118,158,179,119,44,241,238,180,36,117,162,241,53,238,198,197,223,74,94,209,158,27,38,124,210,37,248,61,35,184,134,3,11,70,210,107,118,234,183,209,109,117,50,117,90,100,129,74,252,112,240,221,139,175,88,76,73,211,52,27,75,180,82,19,56,45,243,71,217,212,20,219,38,172,118,62,110,192,0,121,201,247,233,64,91,237,177,217,28,39,63,29,87,73,168,146,53,237,76,186,212,211,58,201,157,206,147,120,142,35,174,5,241,253,107,134,21,87,8,93,224,210,114,235,48,20,214,73,120,137,46,16,95,234,172,85,17,255,144,167,86,118,210,54,199,169,212,92,93,204,42,101,28,171,218,97,52,126,228,6,208,41,63,149,214,140,178,201,47,16,206,194,82,112,197,205,13,133,221,38,97,203,34,3,214,25,93,161,186,139,87,237,81,216,102,191,74,159,129,58,154,147,129,205,62,85,240,16,147,77,182,59,123,60,155,164,218,21,74,50,209,86,90,9,88,245,172,151,72,59,165,206,38,216,23,180,184,221,139,249,255,139,59,185,169,63,189,191,71,212,155,158,63,139,238,159,36,109,223,70,55,184,186,141,243,55,251,28,126,152,109,31,185,6,131,63,74,8,22,71,247,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7eb7049-3302-470f-a43a-704b62a292d6"));
		}

		#endregion

	}

	#endregion

}
