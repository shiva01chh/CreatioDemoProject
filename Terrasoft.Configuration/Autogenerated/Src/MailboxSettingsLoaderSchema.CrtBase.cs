﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailboxSettingsLoaderSchema

	/// <exclude/>
	public class MailboxSettingsLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailboxSettingsLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailboxSettingsLoaderSchema(MailboxSettingsLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1745e006-0dd7-4498-9d93-610c2cbcffef");
			Name = "MailboxSettingsLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,85,203,110,26,49,20,93,131,196,63,88,89,13,18,26,101,79,169,148,87,219,69,72,169,134,182,139,170,138,156,153,11,177,228,177,39,126,36,25,85,252,123,175,199,158,103,128,146,69,81,64,177,125,238,241,185,79,91,205,196,150,36,165,54,144,207,39,99,219,89,198,183,76,60,13,247,214,240,106,134,123,87,146,115,72,13,147,66,199,159,65,128,98,233,16,114,77,13,29,238,221,129,137,151,148,241,102,127,13,74,81,45,55,6,25,21,236,221,206,115,41,14,224,227,235,203,67,39,55,194,48,195,64,227,249,100,44,104,14,186,160,41,244,80,98,195,182,86,81,231,196,100,252,103,50,30,21,246,129,179,148,164,156,106,77,156,204,7,249,154,128,49,72,175,111,37,205,64,17,7,235,227,146,220,20,53,200,31,215,231,218,40,39,236,139,212,134,252,33,91,48,115,162,221,207,174,11,98,194,144,149,84,71,16,129,230,187,6,117,135,126,156,4,92,161,178,23,169,178,195,224,7,41,185,131,38,201,237,113,113,9,168,103,80,107,150,131,180,123,84,238,230,238,183,138,138,98,207,212,0,81,64,51,41,120,89,9,193,40,11,95,39,228,222,246,214,173,157,191,107,111,188,163,1,71,159,98,26,226,205,54,36,234,159,144,197,130,8,203,121,141,24,153,71,37,95,136,128,23,114,161,182,54,7,97,238,240,248,230,53,133,194,225,163,179,190,253,217,180,146,55,218,141,188,198,209,253,144,159,236,241,102,55,112,169,87,26,206,161,122,113,89,222,228,232,110,20,50,6,110,81,75,125,166,138,184,245,69,150,41,192,250,90,84,170,151,237,78,228,225,243,6,13,250,41,160,170,162,47,147,244,17,33,223,44,168,50,26,232,142,187,136,37,21,116,11,106,70,206,234,216,151,34,173,37,214,17,64,242,24,47,198,126,183,57,134,169,174,194,35,199,117,237,29,128,184,187,124,77,197,201,114,189,242,255,6,215,78,51,113,237,242,111,164,175,237,141,84,9,136,12,61,122,143,156,80,237,149,73,19,102,206,180,249,196,184,193,41,112,32,218,254,180,29,141,17,222,53,195,196,111,89,74,249,215,2,252,172,73,48,233,169,137,47,68,22,20,181,196,78,152,51,138,175,176,137,12,248,205,159,204,60,174,168,194,160,227,66,71,245,37,121,65,21,211,82,172,203,2,220,48,51,148,9,76,101,147,160,89,183,138,92,52,212,244,127,220,119,52,157,125,13,110,16,78,59,89,240,204,186,18,209,106,234,20,118,138,35,106,225,202,27,159,24,227,163,221,9,238,160,180,131,157,155,5,104,135,10,45,14,47,28,3,231,205,12,80,96,172,18,213,92,8,221,221,182,80,69,142,151,161,233,175,243,223,173,4,20,110,185,9,9,239,246,115,133,8,196,213,132,95,4,18,167,213,197,40,84,216,15,202,45,124,240,141,254,177,91,110,247,123,170,127,230,249,170,247,224,40,31,14,230,183,100,190,47,2,71,243,92,156,166,171,237,235,142,125,243,138,156,206,209,54,127,203,227,158,152,163,12,238,45,234,187,243,182,121,3,93,255,53,122,127,140,6,253,237,203,160,238,242,80,32,62,231,205,68,199,47,254,117,63,127,1,21,208,94,64,65,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1745e006-0dd7-4498-9d93-610c2cbcffef"));
		}

		#endregion

	}

	#endregion

}

