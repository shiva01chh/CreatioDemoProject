﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationConfigureServiceSchema

	/// <exclude/>
	public class TranslationConfigureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationConfigureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationConfigureServiceSchema(TranslationConfigureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53f3ae78-0e82-479a-84e5-de5828e991cf");
			Name = "TranslationConfigureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,75,111,218,64,16,62,27,41,255,97,228,94,64,66,230,206,75,162,52,141,144,66,84,145,84,61,68,61,44,203,64,86,178,215,206,238,154,150,34,254,123,103,215,54,182,1,59,185,32,118,30,223,60,190,143,65,178,8,117,194,56,194,11,42,197,116,188,53,193,60,150,91,177,75,21,51,34,150,193,139,98,82,135,238,251,93,231,120,215,241,82,45,228,14,158,15,218,96,52,186,120,83,110,24,34,183,193,58,120,64,137,74,240,171,152,71,33,223,175,140,171,84,26,17,97,240,76,41,44,20,255,92,193,171,40,242,238,5,199,101,188,193,48,152,81,157,253,69,92,117,10,133,193,119,198,77,172,4,234,91,17,191,112,77,81,81,228,242,201,255,69,225,142,192,96,30,50,173,135,80,25,60,47,235,162,94,103,58,121,66,67,137,9,249,214,34,20,230,176,194,247,84,40,140,80,26,221,173,62,108,163,48,129,15,82,108,84,144,27,54,189,223,84,36,73,215,161,224,192,109,39,213,70,10,106,48,239,8,134,240,149,233,226,213,135,69,75,44,193,30,221,4,231,65,151,104,222,226,13,141,250,67,217,69,102,243,121,73,246,128,197,189,76,35,84,108,29,226,184,6,27,166,81,9,62,133,7,52,196,206,85,132,62,135,108,186,61,176,194,241,188,61,83,96,26,3,25,81,69,203,114,235,207,136,59,144,134,204,120,209,10,111,179,166,93,7,239,73,252,3,100,215,70,165,54,125,166,118,169,93,112,215,79,53,42,114,200,76,154,126,31,126,214,12,189,222,200,1,40,52,169,146,31,180,104,123,106,159,214,129,157,242,93,163,220,100,235,110,218,189,163,58,115,14,6,3,24,235,52,138,152,58,76,75,3,34,112,133,219,137,223,70,175,63,40,51,6,85,140,92,75,109,45,175,232,6,208,218,208,114,89,90,111,174,189,198,165,42,242,38,96,87,255,153,18,249,118,60,163,14,57,144,87,160,4,181,36,194,252,140,178,130,151,248,81,104,83,192,158,128,51,195,223,186,247,127,57,38,54,5,176,119,85,167,116,78,0,243,188,42,255,69,96,11,143,153,245,194,216,124,64,26,215,225,242,46,105,183,239,51,37,60,150,164,71,110,96,75,191,14,158,3,228,39,177,82,129,92,174,68,80,224,85,53,240,250,141,25,54,207,129,218,239,75,147,50,134,80,251,91,200,69,87,142,225,29,27,5,92,75,132,13,181,210,175,138,186,249,182,144,164,131,219,154,118,3,45,49,90,163,234,62,209,95,24,17,233,215,122,247,221,25,45,230,180,10,105,189,97,117,229,29,97,135,102,4,218,126,156,26,200,118,182,78,231,63,81,158,95,255,64,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53f3ae78-0e82-479a-84e5-de5828e991cf"));
		}

		#endregion

	}

	#endregion

}
