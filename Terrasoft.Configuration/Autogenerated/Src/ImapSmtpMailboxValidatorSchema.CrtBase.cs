﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapSmtpMailboxValidatorSchema

	/// <exclude/>
	public class ImapSmtpMailboxValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapSmtpMailboxValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapSmtpMailboxValidatorSchema(ImapSmtpMailboxValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc6e3865-0e37-42ce-a08e-3cabc6196187");
			Name = "ImapSmtpMailboxValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,201,110,219,48,16,61,43,64,254,129,80,47,18,106,200,247,56,49,144,56,105,43,160,110,2,216,237,165,237,129,145,70,54,1,137,20,72,42,75,131,254,123,135,139,108,122,81,225,248,96,208,51,111,182,55,139,57,109,64,181,180,0,178,4,41,169,18,149,206,102,130,87,108,213,73,170,153,224,231,103,111,231,103,81,167,24,95,145,187,134,178,26,181,90,210,66,103,183,203,251,201,70,149,115,13,43,103,113,221,178,108,142,192,71,241,114,43,208,130,159,134,202,140,82,86,152,138,58,209,96,46,74,168,183,216,176,0,9,67,242,236,19,230,46,36,11,163,108,17,38,192,144,60,91,0,47,65,162,26,1,31,36,172,48,41,50,171,169,82,23,36,111,104,187,104,116,235,19,252,65,107,86,82,12,99,177,227,241,152,92,170,174,105,168,124,157,110,126,3,144,66,66,117,21,231,251,70,241,120,74,88,211,214,208,0,215,182,118,82,9,105,99,252,50,65,136,105,3,81,32,159,64,218,55,26,131,202,122,207,227,32,212,207,91,168,104,87,235,27,198,75,172,40,209,175,45,136,42,57,8,153,142,200,55,156,4,114,69,226,161,82,226,244,55,58,108,187,199,154,21,164,48,101,15,86,77,46,200,13,85,176,47,30,145,131,184,232,241,205,114,180,37,84,112,165,101,103,122,132,188,62,216,112,14,225,67,15,5,77,190,35,35,104,205,161,176,148,117,69,122,65,30,49,141,4,95,196,12,113,244,215,135,194,62,186,104,187,161,231,160,215,162,52,81,165,208,232,5,74,167,183,172,50,190,6,201,116,41,10,223,182,99,21,102,159,65,187,37,169,25,246,206,141,218,43,246,211,230,223,123,37,2,27,39,89,9,36,63,4,147,163,46,18,95,65,36,65,119,210,143,157,215,153,160,151,135,38,211,132,195,115,72,231,181,92,117,102,162,146,184,219,97,42,30,89,207,209,46,127,105,58,121,23,101,65,163,142,243,117,208,251,204,191,96,241,202,139,181,20,156,253,177,195,222,211,229,218,61,147,80,98,210,140,214,202,227,17,146,243,74,144,1,243,196,199,233,55,163,103,238,137,74,66,185,122,198,157,185,34,150,154,65,207,206,32,202,157,28,225,200,32,88,217,95,75,74,164,177,79,30,100,220,22,91,79,222,183,201,33,240,223,131,45,199,126,209,124,122,217,87,177,98,124,20,232,31,176,181,207,66,150,1,166,23,245,48,119,137,108,207,175,75,108,140,82,1,248,80,217,155,125,17,74,7,64,156,155,133,61,34,30,150,164,61,240,65,200,163,64,35,223,162,48,217,133,170,3,156,19,108,146,212,84,234,101,189,147,154,23,57,132,39,211,82,200,112,171,221,248,34,252,96,186,243,124,163,158,38,241,125,93,218,234,130,63,135,126,134,35,66,6,167,62,232,82,60,10,123,150,158,96,140,11,43,228,28,73,162,43,48,230,6,184,247,247,96,114,188,11,97,73,122,138,231,253,101,36,123,123,120,130,139,218,140,16,90,154,49,245,123,107,22,23,191,11,170,139,53,73,108,106,47,5,180,246,50,66,255,234,87,35,114,123,145,109,7,190,66,90,96,178,163,244,85,153,246,184,228,150,194,13,197,140,58,183,31,183,142,123,112,152,138,191,92,206,219,132,4,199,229,189,247,194,54,223,76,249,123,47,197,198,112,232,70,248,28,13,100,9,74,251,42,146,30,245,159,139,232,164,187,66,148,153,207,63,181,57,18,213,99,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc6e3865-0e37-42ce-a08e-3cabc6196187"));
		}

		#endregion

	}

	#endregion

}

