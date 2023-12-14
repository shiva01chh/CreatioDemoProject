﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SLMExtensionsSchema

	/// <exclude/>
	public class SLMExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SLMExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SLMExtensionsSchema(SLMExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e");
			Name = "SLMExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,193,110,219,48,12,61,187,64,255,129,232,46,233,48,216,247,38,205,37,27,176,2,203,48,160,222,118,86,109,38,22,106,75,134,40,165,11,138,254,251,40,201,178,155,164,107,177,75,125,35,249,200,247,72,63,91,137,14,169,23,21,66,137,198,8,210,27,155,175,180,218,200,173,51,194,74,173,242,219,111,235,47,127,44,42,226,128,206,207,30,207,207,50,71,82,109,255,213,48,127,11,144,175,68,139,170,22,134,38,104,74,149,178,195,159,74,90,184,126,187,59,79,96,30,195,131,62,24,220,114,29,86,173,32,130,43,56,210,205,136,162,40,96,65,174,235,132,217,47,135,248,182,199,74,110,100,229,225,128,30,239,73,160,67,219,232,154,242,212,85,60,107,235,221,93,203,13,100,89,79,5,85,160,59,34,203,30,3,225,168,105,29,199,177,170,31,161,57,86,143,245,132,4,47,187,67,99,9,42,103,12,171,1,203,91,130,69,211,129,213,96,27,132,74,115,129,122,173,106,127,185,169,252,32,109,3,157,84,206,98,204,58,190,77,62,18,21,199,76,139,94,24,209,129,98,7,92,95,248,9,23,203,85,226,228,104,81,132,250,4,55,104,157,81,180,44,19,99,190,40,82,206,131,14,239,226,81,165,151,53,44,84,234,117,144,70,51,219,72,154,202,126,208,37,120,87,101,217,78,24,224,213,92,235,223,191,194,135,17,53,187,156,7,64,44,142,22,184,169,25,23,148,76,153,8,36,62,70,213,192,44,20,203,125,143,137,34,171,4,225,137,221,242,175,218,153,171,8,72,36,190,139,199,159,64,227,26,243,67,240,47,209,58,76,98,98,240,113,108,229,11,144,165,161,145,110,148,39,75,253,119,6,197,253,252,53,105,191,181,185,231,23,253,31,10,135,142,247,22,250,89,236,223,245,132,167,101,159,229,34,11,121,73,117,141,27,193,68,135,26,7,194,23,240,79,207,29,247,157,61,189,195,209,180,135,238,76,214,122,205,150,159,34,100,184,200,104,203,33,125,186,123,148,144,92,239,63,178,225,203,8,169,167,225,247,194,195,227,31,38,196,49,123,152,228,156,127,254,2,115,94,147,177,231,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e"));
		}

		#endregion

	}

	#endregion

}

