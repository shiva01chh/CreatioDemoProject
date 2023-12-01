﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SuppMailBoxLangProviderSchema

	/// <exclude/>
	public class SuppMailBoxLangProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SuppMailBoxLangProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SuppMailBoxLangProviderSchema(SuppMailBoxLangProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ccf2d10-4665-4a9d-a0d3-e1d36ccb25ec");
			Name = "SuppMailBoxLangProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,93,111,155,64,16,124,198,82,254,195,149,188,96,169,130,247,216,70,74,163,196,178,228,84,81,227,244,165,170,170,11,44,248,36,184,163,247,145,150,86,254,239,221,3,206,96,140,163,190,216,176,154,153,221,157,155,131,211,18,84,69,19,32,59,144,146,42,145,233,240,78,240,140,229,70,82,205,4,191,154,253,189,154,121,70,49,158,147,231,90,105,40,23,163,119,196,23,5,36,22,172,194,53,112,144,44,57,195,108,25,255,217,23,135,189,36,132,15,52,209,66,50,80,151,16,23,153,247,92,51,221,18,17,114,45,33,199,41,200,93,65,149,186,33,207,166,122,164,172,248,36,126,111,41,207,159,164,120,99,41,200,6,25,69,17,89,50,190,199,89,117,42,18,18,197,88,172,204,107,193,18,146,88,246,5,50,185,33,155,75,178,158,53,234,56,195,3,131,34,197,33,158,36,123,163,26,154,174,94,213,190,52,26,149,144,186,211,249,2,149,80,12,45,168,201,143,114,92,90,12,137,205,190,245,183,239,71,156,91,221,187,6,158,182,173,187,119,231,5,158,138,150,198,26,108,167,105,86,108,17,141,7,202,148,37,149,117,236,10,27,142,126,210,130,253,1,194,225,23,97,72,166,28,211,33,50,196,2,144,68,66,182,242,167,45,240,163,56,60,10,71,99,229,101,69,37,45,9,199,192,173,124,163,64,226,100,188,141,141,31,191,224,59,73,142,133,112,25,53,232,105,178,132,132,85,12,184,86,126,188,101,74,219,225,250,26,206,76,192,186,115,34,210,157,237,244,224,193,203,201,56,228,116,186,57,105,14,214,27,56,121,43,115,83,98,179,17,242,88,94,53,230,77,16,130,241,230,31,199,205,22,109,47,155,193,246,90,212,225,78,214,107,64,234,89,90,144,45,140,158,200,204,88,213,181,239,212,89,70,130,115,18,249,128,99,155,162,112,251,122,125,198,112,161,115,60,222,245,38,192,175,22,17,204,195,157,184,197,187,89,7,93,147,131,253,61,188,31,206,71,208,123,145,78,229,114,124,55,221,1,174,13,75,9,54,182,199,103,104,14,129,13,192,18,109,198,143,67,60,72,129,91,226,63,87,205,240,99,66,147,61,9,90,165,94,200,166,233,92,117,64,104,111,36,233,90,88,120,111,91,15,111,230,232,69,87,43,71,176,38,238,234,10,82,252,136,154,146,127,165,133,1,183,78,123,226,104,239,103,140,189,63,31,168,121,141,13,5,122,176,73,201,251,90,22,105,149,64,41,180,203,217,182,73,253,238,152,220,112,157,24,26,99,25,225,125,89,233,122,216,209,147,160,141,228,93,211,158,123,112,79,238,161,251,63,244,33,112,212,94,120,113,57,27,109,245,180,136,181,217,236,31,51,167,47,132,170,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ccf2d10-4665-4a9d-a0d3-e1d36ccb25ec"));
		}

		#endregion

	}

	#endregion

}

