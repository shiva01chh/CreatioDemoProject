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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,93,111,155,64,16,124,38,82,254,195,149,188,96,169,130,247,216,70,74,163,196,178,148,84,81,227,244,165,170,170,11,44,248,36,184,163,247,145,150,86,254,239,221,59,56,131,177,29,213,15,182,89,205,204,238,206,205,193,105,13,170,161,25,144,13,72,73,149,40,116,124,43,120,193,74,35,169,102,130,95,94,252,189,188,8,140,98,188,36,207,173,210,80,207,39,207,136,175,42,200,44,88,197,43,224,32,89,118,132,121,96,252,231,80,28,247,146,16,223,211,76,11,201,64,157,67,156,101,222,113,205,116,71,68,200,149,132,18,167,32,183,21,85,234,154,60,155,230,145,178,234,147,248,253,64,121,249,36,197,27,203,65,58,100,146,36,100,193,248,22,103,213,185,200,72,146,98,177,49,175,21,203,72,102,217,103,200,228,154,172,207,201,6,214,168,253,12,247,12,170,28,135,120,146,236,141,106,112,93,131,166,123,112,26,141,144,186,215,249,2,141,80,12,45,104,201,143,122,90,154,143,137,110,223,246,219,247,61,206,175,30,92,1,207,187,214,253,179,247,2,79,69,75,99,13,182,211,184,21,59,132,243,64,153,186,166,178,77,125,97,205,209,79,90,177,63,64,56,252,34,12,201,148,99,58,68,129,88,0,146,73,40,150,225,105,11,194,36,141,247,194,201,84,121,209,80,73,107,194,49,112,203,208,40,144,56,25,239,98,19,166,47,248,76,178,125,33,94,36,14,125,154,44,33,99,13,3,174,85,152,62,48,165,237,112,67,13,103,38,96,221,57,16,233,207,246,244,224,209,203,193,56,228,112,186,25,113,7,27,140,156,188,145,165,169,177,217,4,185,47,47,157,121,39,8,209,116,243,143,211,102,243,174,151,205,96,119,45,218,120,35,219,21,32,245,40,45,200,22,70,159,200,204,84,213,183,239,213,89,65,162,99,18,249,128,99,155,170,242,251,6,67,198,112,161,99,60,222,117,23,224,87,139,136,102,241,70,220,224,221,108,163,190,201,206,126,239,222,15,231,35,232,173,200,79,229,114,122,55,253,1,174,12,203,9,54,182,199,103,104,9,145,13,192,2,109,198,151,67,58,74,129,95,226,63,87,45,240,101,66,179,45,137,58,165,65,200,166,233,88,117,68,232,110,36,233,91,88,248,96,219,0,119,115,12,162,203,165,39,88,19,55,109,3,57,190,68,77,205,191,210,202,128,95,167,59,113,180,247,51,198,62,156,141,212,2,103,67,133,30,172,115,242,190,150,69,90,37,80,10,237,242,182,173,243,176,63,38,63,92,47,134,198,88,70,124,87,55,186,29,119,12,36,104,35,121,223,116,224,238,252,63,255,167,255,221,13,33,240,212,65,120,126,62,27,93,245,176,136,53,252,252,3,34,72,131,141,171,6,0,0 };
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

