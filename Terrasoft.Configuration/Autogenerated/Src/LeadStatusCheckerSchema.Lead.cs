﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadStatusCheckerSchema

	/// <exclude/>
	public class LeadStatusCheckerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadStatusCheckerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadStatusCheckerSchema(LeadStatusCheckerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b701b48f-b9bc-46c6-93b5-8a978c339785");
			Name = "LeadStatusChecker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,77,111,218,64,16,61,59,82,254,195,200,185,24,169,50,247,6,124,128,20,100,137,84,173,160,189,86,155,245,24,175,186,94,147,253,104,101,69,249,239,157,245,7,177,13,148,219,14,111,222,123,243,102,172,88,137,230,196,56,194,1,181,102,166,202,109,188,174,84,46,142,78,51,43,42,117,127,247,118,127,23,56,35,212,17,246,181,177,88,62,78,222,132,151,18,185,7,155,120,139,10,181,224,23,152,157,80,175,31,197,161,150,198,91,245,248,105,117,243,175,47,202,10,43,208,16,128,32,15,26,143,36,15,107,201,140,249,12,59,100,217,222,50,235,204,186,64,254,27,181,7,17,236,228,94,164,224,192,61,234,26,40,240,163,158,201,54,2,101,70,108,223,180,248,195,44,54,12,193,169,125,128,166,238,74,201,26,126,24,212,20,152,106,3,128,95,110,244,110,237,5,15,168,178,150,181,123,247,126,41,50,171,29,183,149,38,157,198,93,39,211,58,189,240,24,77,228,198,106,51,104,6,8,108,33,76,60,113,2,75,184,176,22,4,239,255,247,247,140,182,168,154,12,6,222,230,243,57,44,140,43,75,166,235,164,47,164,42,19,156,130,49,32,114,144,100,27,132,130,92,40,38,193,52,3,196,231,214,249,180,119,113,98,154,149,160,232,20,151,161,60,143,156,102,97,226,3,232,8,64,100,72,75,207,5,234,120,49,111,90,62,24,52,90,167,149,73,14,218,161,119,208,183,152,214,3,53,244,136,65,186,47,85,37,33,53,94,35,85,27,143,107,133,163,173,19,25,12,141,244,193,54,87,87,239,121,129,37,131,87,199,164,200,235,22,211,213,150,211,3,136,135,45,207,76,177,35,217,223,162,77,105,241,76,113,92,213,95,105,236,40,252,62,36,11,103,143,3,185,177,80,87,91,94,147,143,215,116,150,22,91,72,52,113,210,113,94,33,139,233,194,253,66,232,59,118,165,250,201,36,101,184,28,205,127,187,117,131,150,23,27,93,149,79,171,72,225,95,216,9,99,23,116,211,244,201,38,240,6,97,106,154,96,67,120,255,4,57,147,6,59,27,237,58,174,141,230,211,57,212,39,204,6,118,22,126,85,73,116,102,155,221,58,222,174,54,190,231,166,70,191,127,72,93,54,93,236,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b701b48f-b9bc-46c6-93b5-8a978c339785"));
		}

		#endregion

	}

	#endregion

}
