﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MarketingEventFailoverHandlerSchema

	/// <exclude/>
	public class MarketingEventFailoverHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MarketingEventFailoverHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MarketingEventFailoverHandlerSchema(MarketingEventFailoverHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e62f685-91fb-4e5c-a9ea-211a9479852d");
			Name = "MarketingEventFailoverHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,75,111,226,48,16,62,167,210,254,135,17,123,1,9,133,211,94,202,163,90,209,199,82,137,170,219,118,213,99,101,146,9,184,77,236,172,31,116,81,213,255,190,227,24,72,2,133,116,165,229,130,237,25,127,30,127,243,205,56,130,101,168,115,22,33,60,160,82,76,203,196,132,99,41,18,62,183,138,25,46,197,151,147,183,47,39,129,213,92,204,225,126,165,13,102,100,79,83,140,156,81,135,87,40,80,241,168,191,245,169,194,40,60,180,94,63,227,160,215,125,180,192,216,166,168,250,213,24,238,209,24,26,106,231,2,195,163,200,97,197,157,48,8,229,171,194,57,25,96,156,50,173,79,97,202,212,11,58,243,197,18,133,185,100,60,149,75,84,63,152,136,233,212,98,67,175,215,131,129,182,89,198,212,106,180,158,223,42,185,228,49,106,200,208,44,100,172,193,72,152,163,129,153,146,47,40,32,219,128,2,58,84,120,150,51,29,110,160,122,21,172,220,206,82,30,65,228,98,57,30,10,156,194,100,47,186,224,173,136,176,188,19,101,196,48,97,232,94,183,138,47,153,65,111,207,253,4,34,103,7,78,17,61,229,148,53,25,79,196,148,11,107,232,34,67,248,214,95,131,161,136,61,94,29,252,146,99,26,31,66,254,165,81,209,233,194,203,2,158,108,109,222,128,76,108,82,56,134,163,67,47,24,241,246,93,230,139,133,43,52,26,164,2,237,254,205,2,247,200,254,109,209,162,163,28,98,78,202,54,36,33,21,110,118,79,10,130,72,237,50,33,104,36,74,20,38,195,86,157,250,159,14,225,90,206,206,183,251,91,189,209,22,162,150,192,45,1,77,8,240,148,53,120,244,11,56,47,136,70,180,70,7,87,180,65,224,52,57,28,53,159,93,56,7,103,103,208,110,116,37,165,8,124,253,108,0,65,176,163,140,225,174,54,194,239,121,94,153,249,22,83,223,228,145,222,59,5,67,129,254,228,157,232,168,37,75,109,209,130,130,247,227,10,156,250,50,254,132,252,72,171,17,106,141,94,123,101,121,187,14,144,112,17,131,180,6,168,62,65,161,46,27,130,20,168,75,1,229,76,177,12,4,117,222,97,171,78,70,107,244,64,168,110,205,213,234,134,147,65,175,216,49,250,16,160,24,163,65,165,91,35,186,63,148,243,253,125,117,229,122,169,45,37,143,225,226,15,70,212,6,218,59,201,170,7,215,133,201,57,47,70,4,49,208,70,17,247,93,144,179,103,50,143,42,231,118,214,185,223,73,52,229,99,175,43,144,87,147,144,194,7,181,186,67,189,126,8,200,212,238,84,51,250,97,146,198,10,153,107,106,174,9,80,94,50,41,184,161,150,145,80,255,252,159,105,56,72,167,63,223,197,122,148,208,127,35,138,42,195,161,77,68,34,33,178,74,17,91,110,190,231,29,142,75,227,186,98,138,84,57,54,174,148,180,249,13,221,152,118,53,18,127,93,241,247,64,51,41,83,224,186,172,81,130,49,106,93,98,193,146,41,200,184,78,184,194,91,73,92,172,200,74,197,189,125,195,167,222,230,90,176,178,62,212,50,177,55,242,245,145,155,197,29,102,140,11,10,234,14,115,226,112,44,173,48,30,189,138,180,253,46,240,175,87,186,162,80,7,71,159,207,81,187,122,251,238,46,101,143,82,189,20,95,65,97,97,246,13,167,66,178,95,222,123,53,187,32,108,154,118,107,148,116,235,28,116,142,180,31,191,90,95,44,214,232,247,23,226,176,197,95,152,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e62f685-91fb-4e5c-a9ea-211a9479852d"));
		}

		#endregion

	}

	#endregion

}
