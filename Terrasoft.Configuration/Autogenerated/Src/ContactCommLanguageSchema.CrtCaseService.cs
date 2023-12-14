﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactCommLanguageSchema

	/// <exclude/>
	public class ContactCommLanguageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactCommLanguageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactCommLanguageSchema(ContactCommLanguageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("68ffb092-baa1-47a4-868e-862c4c2fed50");
			Name = "ContactCommLanguage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,77,79,219,64,16,61,27,137,255,48,117,47,142,132,156,59,36,57,64,2,138,4,18,45,165,61,86,139,61,78,86,90,175,195,126,64,83,212,255,222,253,178,179,54,6,37,135,216,59,158,121,51,243,230,121,204,73,141,114,71,10,132,31,40,4,145,77,165,242,171,134,87,116,163,5,81,180,225,167,39,111,167,39,137,150,148,111,224,97,47,21,214,23,131,115,190,36,138,28,140,49,78,93,55,124,252,137,192,143,236,249,242,114,152,225,1,149,50,39,9,243,161,111,175,212,220,120,183,174,6,194,128,124,21,184,49,15,224,138,17,41,207,193,120,43,82,40,91,215,45,225,27,77,54,232,220,166,211,41,204,164,174,107,34,246,139,112,190,23,205,11,45,81,182,65,192,66,68,222,6,76,163,136,157,126,98,180,128,194,230,25,75,3,231,176,30,205,158,188,185,10,186,74,175,41,178,210,148,122,47,232,11,81,190,188,100,231,15,32,144,148,13,103,123,120,148,40,12,28,199,194,246,13,191,117,239,124,17,32,145,151,30,181,159,194,56,74,37,116,161,26,97,19,185,202,189,199,144,7,103,88,115,170,40,97,244,47,2,199,87,160,38,152,112,163,151,166,50,190,136,80,8,172,230,233,72,115,233,116,145,119,168,211,33,236,108,71,4,169,129,27,253,205,211,126,253,233,194,246,7,69,103,152,77,157,179,139,13,76,143,228,203,6,172,244,65,39,96,117,156,36,3,174,140,164,222,145,151,36,255,62,103,240,14,213,182,41,143,33,239,6,15,194,1,35,39,174,104,69,77,111,2,153,25,104,9,175,84,109,109,163,182,151,99,201,10,238,235,50,93,180,218,60,32,231,49,87,46,84,160,210,130,203,197,237,251,50,140,115,251,52,162,246,70,211,210,22,158,185,155,46,91,75,160,179,182,61,173,75,67,160,181,228,171,122,167,246,142,188,228,1,153,225,18,164,187,124,211,40,246,214,9,149,183,103,7,68,239,78,43,200,98,223,47,115,224,154,177,54,95,216,4,217,242,114,245,7,11,109,84,11,229,147,189,53,160,131,97,230,43,46,181,192,229,229,193,148,77,58,156,22,104,109,247,213,119,243,42,185,57,184,203,60,46,54,247,121,208,187,100,62,89,4,147,188,110,41,67,200,124,108,110,221,226,44,73,210,35,39,120,153,246,175,26,166,107,254,147,48,141,51,75,217,34,75,111,59,207,52,144,145,56,241,197,87,127,241,255,126,90,17,251,177,90,63,16,32,71,97,119,135,111,16,158,29,197,170,233,214,154,44,182,88,147,207,180,215,74,36,122,219,253,36,205,11,222,173,131,113,41,5,37,28,102,63,46,169,81,193,216,101,19,162,6,99,158,120,98,114,79,104,159,197,240,232,90,52,117,214,46,165,206,250,107,139,2,15,230,51,72,109,72,190,150,171,103,77,88,230,241,114,183,31,35,149,78,128,200,80,201,69,60,133,168,220,35,198,160,36,148,88,17,205,162,133,80,153,42,65,186,79,156,65,115,31,174,99,6,177,28,226,28,251,70,135,192,172,229,61,52,210,255,200,90,169,58,145,14,105,55,116,5,128,59,148,210,228,237,22,253,89,219,154,155,239,100,242,201,14,245,214,216,104,44,246,247,31,61,199,228,61,137,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68ffb092-baa1-47a4-868e-862c4c2fed50"));
		}

		#endregion

	}

	#endregion

}

