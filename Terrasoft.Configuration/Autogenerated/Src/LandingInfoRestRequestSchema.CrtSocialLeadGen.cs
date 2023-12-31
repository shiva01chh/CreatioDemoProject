﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestRequestSchema

	/// <exclude/>
	public class LandingInfoRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestRequestSchema(LandingInfoRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8");
			Name = "LandingInfoRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,203,106,195,48,16,69,215,49,248,31,6,186,183,247,77,233,198,165,33,16,104,72,2,93,203,214,216,29,208,195,29,73,148,96,250,239,149,37,39,184,133,106,33,49,87,71,151,35,35,52,186,81,116,8,23,100,22,206,246,190,106,172,233,105,8,44,60,89,83,157,109,71,66,29,80,200,29,154,178,152,202,98,19,28,153,1,206,87,231,81,111,203,34,38,15,140,67,132,161,81,194,185,71,56,8,35,35,178,55,189,61,161,243,39,252,12,241,72,100,93,215,240,228,130,214,130,175,207,203,220,40,27,36,112,166,224,229,242,6,95,228,63,128,226,115,214,201,2,68,107,131,7,149,123,171,91,79,189,42,26,67,171,168,131,110,54,248,87,96,51,37,137,187,239,145,237,136,236,9,163,244,49,21,228,251,191,150,41,88,74,129,100,117,103,214,6,55,133,93,32,9,13,227,108,254,142,237,107,252,196,94,194,4,3,250,45,184,121,251,94,44,208,200,44,146,230,156,254,14,83,182,94,63,190,102,80,162,177,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5fd23eb-b854-0a9b-4281-cb8f7bee4cd8"));
		}

		#endregion

	}

	#endregion

}

