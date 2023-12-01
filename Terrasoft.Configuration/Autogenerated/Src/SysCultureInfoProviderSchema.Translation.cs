﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureInfoProviderSchema

	/// <exclude/>
	public class SysCultureInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureInfoProviderSchema(SysCultureInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af876c35-af7e-49b1-8172-53e76666f2a2");
			Name = "SysCultureInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,91,107,219,48,20,126,118,160,255,65,100,47,14,12,231,189,77,92,186,244,66,160,219,202,210,238,117,40,214,113,38,176,229,84,151,172,165,244,191,79,87,59,118,226,36,108,133,66,165,115,253,190,79,199,39,12,151,32,214,56,3,244,8,156,99,81,229,50,153,85,44,167,43,197,177,164,21,75,30,57,102,162,176,231,179,193,219,217,32,82,130,178,21,90,188,10,9,229,69,231,174,115,139,2,50,19,44,146,59,96,192,105,182,19,115,79,217,115,99,220,238,91,150,21,219,239,225,208,103,79,174,191,104,151,118,126,226,176,210,125,209,172,192,66,156,155,102,51,85,72,197,97,206,242,234,129,87,27,74,128,219,200,181,90,22,52,67,153,9,236,137,67,231,104,222,87,33,122,179,85,154,134,154,172,228,42,147,21,215,125,31,108,113,23,225,27,237,47,20,63,9,224,58,151,57,189,144,106,93,71,200,104,29,69,157,160,105,39,204,168,18,189,123,60,192,136,131,212,198,167,27,174,129,75,10,6,29,167,27,44,193,195,115,23,212,233,209,185,58,28,43,144,182,87,36,252,193,55,29,143,199,104,34,84,89,98,254,154,6,195,213,6,211,2,47,11,64,153,227,45,146,58,118,188,29,28,16,220,83,33,39,29,193,83,244,43,100,95,28,143,245,23,209,192,245,167,136,131,118,176,166,24,186,188,68,113,115,155,162,59,144,33,59,30,141,28,203,247,19,116,253,10,242,119,69,186,162,238,21,68,183,16,8,159,170,138,181,56,216,34,13,208,146,201,56,152,142,171,209,162,228,133,216,96,142,182,88,51,248,179,63,57,246,18,152,120,81,187,22,96,190,107,157,231,68,53,217,206,212,25,227,145,243,71,102,19,168,146,197,195,57,25,238,218,24,129,151,96,78,110,121,85,198,195,6,197,112,132,176,240,213,253,204,117,96,36,55,47,144,41,9,63,0,155,15,137,96,137,221,17,77,211,240,236,119,138,18,164,255,166,168,113,39,70,23,139,225,39,46,20,76,76,76,234,32,186,70,17,101,18,81,131,238,96,158,142,74,107,22,62,179,126,211,43,66,98,43,79,75,214,152,146,207,174,114,61,98,254,191,159,207,214,172,159,60,121,91,203,166,127,240,132,221,187,161,131,70,145,87,188,116,219,253,192,0,174,49,199,37,98,250,7,98,58,164,100,152,46,58,85,8,48,73,115,170,213,153,140,109,108,186,181,242,58,67,133,140,142,177,127,146,48,144,158,120,61,224,183,148,11,249,157,95,67,142,181,41,14,141,244,147,250,99,50,39,201,205,179,194,133,208,106,122,25,15,173,161,143,34,111,223,121,135,191,177,158,76,189,158,171,255,32,111,27,6,254,91,147,116,84,130,143,93,60,142,229,254,189,99,185,246,80,60,13,43,83,229,82,127,199,85,254,143,168,191,29,202,223,203,196,60,205,172,82,76,246,1,79,172,247,192,119,233,172,109,163,181,13,6,127,1,49,56,217,132,96,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af876c35-af7e-49b1-8172-53e76666f2a2"));
		}

		#endregion

	}

	#endregion

}
