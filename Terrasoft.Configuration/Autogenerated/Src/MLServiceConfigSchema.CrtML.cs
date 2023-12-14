﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLServiceConfigSchema

	/// <exclude/>
	public class MLServiceConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLServiceConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLServiceConfigSchema(MLServiceConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aca94478-630a-47b4-8800-875db0556c01");
			Name = "MLServiceConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,85,77,83,219,48,16,61,155,25,254,195,226,30,106,207,100,156,59,36,57,0,1,50,147,20,90,160,61,116,58,29,97,175,131,166,178,228,74,114,74,6,242,223,187,178,236,128,13,129,92,98,75,187,251,222,190,253,176,100,5,154,146,165,8,55,168,53,51,42,183,201,137,146,57,95,86,154,89,174,100,178,152,239,239,61,238,239,5,149,225,114,9,215,107,99,177,56,218,190,191,244,42,10,37,223,190,209,184,235,60,57,61,222,121,117,198,82,171,52,71,67,22,100,243,243,20,115,86,9,123,204,101,70,214,145,93,151,168,242,104,182,152,95,163,94,241,20,61,239,56,254,69,198,101,117,39,120,10,169,96,198,64,207,226,16,250,62,228,240,88,99,4,159,52,46,41,107,56,227,40,50,115,8,87,154,175,152,69,127,89,250,23,208,200,50,37,197,26,110,13,106,138,32,49,117,82,193,239,170,243,126,212,132,68,153,249,168,93,8,50,52,86,87,46,71,7,84,19,110,112,60,249,30,201,168,135,214,5,139,193,21,41,8,122,28,96,12,175,72,5,193,230,125,102,11,180,247,42,235,145,26,14,135,48,50,85,81,48,189,158,180,7,39,247,152,254,1,158,131,241,76,33,109,122,7,51,200,149,6,163,196,202,85,214,222,35,44,249,10,37,133,64,178,210,152,143,195,197,252,74,171,59,129,197,13,85,50,28,78,146,45,204,176,143,51,42,153,102,5,72,234,214,113,88,62,123,205,178,112,210,4,1,215,15,201,104,88,91,190,237,152,58,182,55,154,113,73,156,194,201,44,135,81,58,161,18,224,104,152,78,160,190,53,46,25,110,63,155,126,38,182,113,235,32,52,133,186,83,74,192,204,116,170,229,28,163,243,138,103,208,161,59,240,198,29,38,84,163,156,9,131,109,9,175,81,80,173,72,210,250,111,12,145,63,136,37,254,3,255,24,245,170,28,215,126,1,141,141,48,81,216,240,184,213,34,28,64,216,162,76,101,86,42,46,173,59,187,34,114,188,246,220,158,182,33,206,180,42,162,94,105,218,187,31,247,168,49,10,73,244,56,153,153,233,223,138,137,200,145,250,90,161,94,95,57,85,208,162,142,58,9,199,113,221,113,65,157,54,55,94,156,233,3,55,214,80,106,62,199,100,250,128,105,101,241,154,104,10,252,134,169,210,89,228,134,12,53,140,39,224,32,188,50,193,115,106,228,236,45,146,115,180,148,119,85,200,239,76,80,41,105,166,40,204,164,35,67,60,240,238,125,45,62,14,242,74,189,54,212,107,9,63,14,182,83,246,205,0,84,101,97,197,52,133,48,180,227,26,209,168,23,163,131,174,104,109,147,4,26,109,165,165,239,28,111,189,217,250,248,32,201,179,2,84,174,47,149,16,151,122,90,148,118,29,197,240,244,212,32,37,175,73,245,141,63,132,108,206,15,186,93,77,16,7,13,70,95,197,62,194,203,165,180,123,207,212,179,105,93,15,210,120,210,220,161,52,8,86,185,5,71,187,18,154,108,119,108,145,151,163,122,193,204,220,187,71,109,110,77,10,189,185,74,200,236,2,69,233,107,74,110,151,244,88,127,22,91,255,197,188,94,227,198,89,110,47,79,84,134,241,59,139,150,78,55,176,191,231,126,255,1,156,120,4,91,128,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aca94478-630a-47b4-8800-875db0556c01"));
		}

		#endregion

	}

	#endregion

}

