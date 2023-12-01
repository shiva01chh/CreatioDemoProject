﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailAddressSchema

	/// <exclude/>
	public class EmailAddressSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailAddressSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailAddressSchema(EmailAddressSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f82b21b-805d-4119-96db-e57d6168ef63");
			Name = "EmailAddress";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,86,77,107,219,64,16,61,39,144,255,48,40,23,7,140,76,233,33,80,199,41,197,49,33,135,180,33,113,79,33,152,181,52,114,22,164,93,117,119,148,214,77,251,223,59,187,114,100,73,113,234,143,22,218,82,31,44,118,102,222,236,155,55,163,93,41,145,161,205,69,132,48,70,99,132,213,9,133,67,173,18,57,43,140,32,169,85,56,28,221,92,234,24,83,123,176,255,120,176,191,87,88,169,102,112,51,183,132,89,191,181,14,175,11,69,50,195,240,6,141,20,169,252,234,51,112,20,199,29,26,156,241,2,134,169,176,246,13,140,50,33,211,119,113,108,208,90,239,239,245,122,112,98,139,44,19,102,126,186,88,143,239,17,208,5,130,40,35,195,167,192,94,45,242,246,76,144,96,206,100,68,68,119,108,200,139,105,42,35,136,220,78,173,141,246,30,253,102,75,54,90,89,50,69,68,218,48,169,43,15,44,35,218,124,188,225,66,73,242,133,161,5,1,10,63,131,100,188,80,44,159,78,128,152,238,137,69,132,200,96,50,8,234,59,7,208,59,45,9,133,85,242,122,13,79,156,235,152,206,17,60,194,247,63,194,198,91,114,97,68,6,138,7,100,16,248,46,4,149,175,106,76,13,239,195,95,172,133,85,118,115,226,65,92,151,11,219,163,123,105,195,178,191,131,210,211,247,118,183,37,91,74,72,56,202,114,154,123,199,95,162,133,140,151,66,92,196,46,189,193,72,230,18,21,173,148,227,247,139,121,94,200,24,100,220,133,23,85,101,255,128,35,250,255,178,206,91,201,244,12,237,254,155,96,103,217,105,94,43,157,93,134,117,195,235,237,11,101,221,227,191,84,244,25,150,230,121,11,235,44,191,222,141,106,225,210,237,212,154,210,234,224,108,117,143,122,195,14,81,197,229,77,209,188,54,174,140,206,209,144,196,77,46,141,115,36,11,218,128,117,79,249,226,129,81,135,249,43,237,18,179,41,154,206,251,146,176,59,118,142,238,106,2,45,14,1,190,35,102,72,125,151,189,255,211,219,162,65,131,86,180,126,29,129,114,122,26,28,234,125,217,157,72,107,140,214,241,240,115,184,138,134,111,237,166,44,220,12,222,163,136,209,248,174,3,105,40,44,66,194,196,28,167,170,67,93,136,49,17,69,234,184,106,8,72,7,32,19,80,154,32,55,250,65,198,24,63,101,212,10,117,210,33,221,133,40,234,194,52,138,142,54,175,201,191,31,171,106,242,220,118,111,241,151,92,150,159,113,16,11,170,14,20,254,228,179,98,182,141,230,203,68,19,151,104,65,245,246,195,212,234,20,9,59,193,113,248,234,56,124,13,223,224,35,139,200,175,237,24,179,60,229,200,107,252,84,160,165,112,84,37,56,115,68,220,17,199,226,135,205,154,157,107,204,223,143,111,161,181,223,198,10,92,99,206,137,4,191,23,91,20,103,74,208,100,229,27,182,116,238,222,134,106,152,88,121,51,67,120,16,102,27,122,81,78,19,15,156,48,176,73,177,233,107,47,87,16,110,157,104,165,181,105,244,54,254,253,0,58,174,7,39,27,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f82b21b-805d-4119-96db-e57d6168ef63"));
		}

		#endregion

	}

	#endregion

}

