﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingProviderBuilderSchema

	/// <exclude/>
	public class MailingProviderBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingProviderBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingProviderBuilderSchema(MailingProviderBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9e76c21-5d0d-409f-9d5a-64c9ba072fa6");
			Name = "MailingProviderBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,223,79,219,48,16,126,14,18,255,131,97,123,72,164,42,127,0,93,39,173,133,162,62,192,208,70,197,3,66,147,73,156,98,45,137,35,199,161,171,16,255,251,206,63,146,58,142,83,24,90,31,218,218,177,239,190,251,238,238,187,148,184,32,117,133,19,130,110,9,231,184,102,153,136,23,172,204,232,166,225,88,80,86,30,31,189,28,31,5,77,77,203,13,250,185,171,5,41,166,221,218,190,194,137,127,223,50,21,95,97,154,195,243,49,3,241,18,39,130,113,74,234,169,227,50,254,65,178,156,36,210,8,60,130,135,159,56,217,192,2,45,114,92,215,103,200,24,190,225,236,153,166,132,207,27,154,195,143,58,121,127,78,50,220,228,98,78,203,20,142,132,98,87,17,150,133,43,255,149,40,122,128,59,85,243,152,211,4,37,210,248,136,109,116,134,70,76,192,253,23,229,185,3,185,164,36,79,1,229,13,167,207,88,16,253,176,210,11,196,9,78,89,153,239,208,186,38,28,232,42,117,152,232,87,211,91,79,141,73,82,166,218,106,223,5,28,172,5,111,36,125,210,145,194,111,252,232,88,252,88,67,199,105,223,103,132,100,234,131,192,129,130,102,104,128,45,8,94,15,3,188,34,226,137,141,146,224,82,169,203,70,151,195,14,45,128,35,65,122,123,33,68,43,203,35,211,75,85,6,215,80,202,45,100,154,33,115,36,94,213,215,77,158,127,231,23,69,37,118,225,224,66,123,35,224,68,52,188,68,37,28,86,1,201,136,224,251,25,115,180,101,252,183,106,146,91,40,158,22,35,208,160,172,24,68,241,37,17,95,86,119,190,147,95,195,72,91,148,155,45,100,245,127,230,55,45,109,201,245,16,237,180,139,174,103,102,166,96,191,21,138,217,254,6,73,3,214,25,143,53,177,43,40,29,92,38,196,54,25,33,92,31,206,138,157,244,177,52,154,204,181,203,206,145,2,93,153,93,185,152,40,124,135,171,32,177,87,109,168,3,143,133,179,158,89,44,88,77,178,42,51,102,44,130,56,61,230,196,122,6,119,108,108,50,25,214,211,176,36,219,251,135,150,105,163,38,253,54,138,38,104,68,101,122,17,69,58,53,86,78,199,0,157,56,249,29,4,169,183,131,209,204,246,184,118,165,101,226,82,235,73,189,41,35,68,242,154,180,40,92,58,107,90,84,31,32,18,249,57,68,45,49,186,151,7,182,93,78,134,164,140,23,250,65,58,14,196,239,16,240,81,151,135,60,184,54,227,181,171,189,195,193,16,116,29,222,235,243,194,227,192,105,88,152,174,110,3,65,146,218,255,135,167,195,4,93,54,52,237,50,188,74,219,84,72,197,172,172,254,35,91,143,159,208,33,125,223,4,39,237,221,120,73,68,242,180,228,172,56,159,135,150,155,119,202,92,229,137,251,237,233,52,156,156,3,137,81,179,51,124,175,2,105,100,14,85,64,139,185,182,22,240,35,224,149,71,118,135,170,158,189,92,166,161,91,154,218,152,39,107,22,223,118,2,7,157,110,209,184,103,124,127,217,233,41,51,100,139,122,3,118,63,159,46,88,147,167,168,100,2,229,12,239,195,65,41,22,24,101,144,39,116,62,143,81,135,105,189,74,207,208,203,222,227,235,169,169,85,241,196,217,86,213,197,197,159,132,84,18,89,8,62,34,119,236,218,61,3,0,90,13,81,147,177,43,18,223,108,236,93,116,133,226,31,166,140,28,241,158,119,143,189,111,123,219,5,226,81,135,145,113,216,151,163,190,24,27,91,146,14,123,58,88,70,93,55,82,91,22,214,81,191,206,184,227,166,187,62,208,85,223,169,238,189,158,180,175,54,173,0,245,4,114,180,126,104,9,53,47,5,168,171,33,106,200,248,95,245,243,182,6,58,90,160,119,251,155,176,103,127,254,2,173,11,16,42,44,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9e76c21-5d0d-409f-9d5a-64c9ba072fa6"));
		}

		#endregion

	}

	#endregion

}

