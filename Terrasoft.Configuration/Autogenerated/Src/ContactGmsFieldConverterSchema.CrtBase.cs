﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactGmsFieldConverterSchema

	/// <exclude/>
	public class ContactGmsFieldConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactGmsFieldConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactGmsFieldConverterSchema(ContactGmsFieldConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38e33501-07b6-4a67-afaf-0520cc19d370");
			Name = "ContactGmsFieldConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,86,219,78,27,49,16,125,94,36,254,97,148,62,52,17,116,3,60,66,130,68,41,32,36,110,106,242,134,80,229,236,206,38,22,123,171,237,13,141,162,252,123,199,151,221,117,66,34,129,90,144,72,60,151,51,51,103,198,99,114,150,161,44,89,132,48,70,33,152,44,18,21,94,22,121,194,167,149,96,138,23,57,44,247,247,246,247,130,74,242,124,10,163,133,84,152,157,109,156,195,59,158,255,126,39,28,227,31,213,10,125,244,44,43,242,51,131,250,69,224,84,199,184,76,153,148,167,64,129,21,139,212,77,38,175,57,166,49,29,231,40,20,10,99,219,239,247,97,32,171,44,99,98,113,238,206,206,1,58,215,85,154,66,78,181,116,32,209,174,16,213,190,16,105,236,208,57,140,176,100,84,23,202,53,23,169,132,206,209,102,218,185,225,115,204,141,6,158,239,121,28,167,104,14,47,48,170,132,181,23,85,138,53,226,160,239,229,84,86,147,148,71,54,228,206,106,224,20,110,157,110,179,204,192,146,221,240,242,36,138,146,84,28,137,156,39,131,109,245,155,92,236,36,67,218,122,11,162,97,70,95,34,138,34,129,81,43,22,97,131,227,23,16,148,130,207,137,31,99,254,252,2,191,90,128,33,44,225,43,253,174,206,140,157,171,212,154,141,26,171,165,86,6,83,84,238,91,32,80,17,109,30,144,113,15,86,230,175,108,237,214,34,205,89,90,161,103,184,114,180,96,30,91,102,214,105,186,71,53,139,139,143,112,52,144,72,181,9,76,134,157,237,61,8,111,80,57,197,104,154,117,250,231,219,105,50,18,129,116,126,149,141,224,34,209,221,149,101,202,149,210,147,52,208,5,101,20,204,52,99,216,49,45,233,159,211,132,10,169,0,83,204,48,87,240,198,169,91,19,164,233,195,24,152,244,83,108,19,9,205,80,62,88,128,195,58,32,141,89,139,179,211,181,30,91,114,4,164,42,23,106,166,179,195,84,226,110,39,59,248,46,160,55,43,126,205,173,249,142,129,94,39,179,235,174,153,78,166,231,218,62,103,68,24,249,15,33,199,55,240,108,123,182,251,60,1,231,22,222,202,7,154,235,71,113,149,149,106,209,53,32,189,141,33,35,36,127,186,52,184,153,117,13,79,246,225,72,183,166,219,12,235,33,140,12,180,17,63,150,122,219,201,240,39,102,197,28,77,144,171,156,212,40,93,42,242,141,171,104,6,93,123,123,238,48,159,170,89,147,64,196,136,204,163,83,123,120,151,142,85,31,215,106,233,247,147,114,51,136,207,71,47,206,56,152,8,100,175,190,231,201,71,61,101,219,238,70,123,188,21,55,198,132,85,169,250,23,96,159,8,248,6,109,28,203,234,247,138,167,177,190,15,19,215,221,53,113,221,224,32,72,232,198,119,117,171,56,217,29,159,209,199,192,69,104,177,79,72,124,112,208,176,77,249,76,194,139,178,164,117,112,93,136,140,169,110,103,121,180,130,206,161,203,140,191,52,232,43,175,128,118,166,225,96,72,121,133,227,194,230,212,237,133,99,193,179,54,39,143,41,11,176,209,81,179,143,254,203,146,113,55,236,19,91,102,203,195,85,175,16,138,73,187,59,254,252,67,182,229,114,187,5,239,34,172,39,220,245,110,62,81,226,95,102,122,119,35,166,46,233,89,160,110,54,55,45,188,214,43,239,81,252,176,83,87,19,237,88,165,225,160,55,100,9,107,67,120,8,235,45,179,231,122,6,87,250,159,20,10,116,155,60,20,202,110,132,54,178,215,215,94,219,174,119,207,135,149,250,194,96,127,143,132,244,243,23,245,22,201,38,22,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38e33501-07b6-4a67-afaf-0520cc19d370"));
		}

		#endregion

	}

	#endregion

}
