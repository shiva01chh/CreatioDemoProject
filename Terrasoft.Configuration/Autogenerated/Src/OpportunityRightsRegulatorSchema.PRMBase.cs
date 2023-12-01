﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityRightsRegulatorSchema

	/// <exclude/>
	public class OpportunityRightsRegulatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityRightsRegulatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityRightsRegulatorSchema(OpportunityRightsRegulatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f85e969-5663-4fc5-857b-99942ce033c3");
			Name = "OpportunityRightsRegulator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6efc2b6b-5901-4b9d-a21e-e587e5c1977b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,85,77,111,218,64,16,61,59,82,254,195,136,94,176,132,204,61,80,36,132,72,196,33,37,10,105,175,213,214,30,214,43,217,187,214,126,64,221,40,255,189,203,174,49,182,131,85,26,20,110,243,245,230,205,99,102,205,73,142,170,32,49,194,11,74,73,148,216,234,104,33,248,150,81,35,137,102,130,223,222,188,222,222,4,70,49,78,97,83,42,141,249,164,182,155,37,121,46,248,249,136,196,62,127,180,228,154,105,134,42,154,171,146,199,235,2,125,79,245,223,5,209,138,107,148,91,59,71,127,237,61,137,181,144,204,101,216,156,47,18,169,45,133,69,70,148,186,131,117,81,8,169,13,103,186,124,102,52,213,234,25,169,201,136,173,112,217,227,241,24,166,202,228,57,145,229,172,178,93,37,236,83,22,167,128,191,49,54,26,21,136,35,39,216,10,9,113,74,56,61,112,145,14,19,172,91,156,26,69,112,68,30,55,160,11,243,43,99,49,196,14,253,29,45,55,120,205,13,238,96,229,52,41,151,59,228,186,173,138,197,122,117,228,235,89,239,25,102,137,29,246,73,178,29,209,232,131,133,55,96,163,10,15,213,153,31,126,202,182,99,82,129,34,79,60,110,187,201,35,234,84,244,118,217,9,150,192,35,225,132,98,99,182,181,164,132,179,63,142,182,111,63,236,29,107,46,169,2,34,169,201,109,72,133,112,216,207,32,232,146,140,124,15,143,114,6,190,6,240,59,85,174,146,145,195,9,186,129,133,200,76,206,127,144,204,216,181,123,64,253,82,22,152,56,115,250,96,88,50,27,14,158,136,212,28,229,42,25,132,239,48,214,89,242,1,152,240,176,196,193,219,69,202,237,109,205,103,72,214,192,61,47,204,21,138,57,240,107,245,170,65,194,9,28,245,186,100,43,221,121,85,210,250,83,115,202,46,253,5,15,191,43,148,246,5,228,24,187,43,54,45,115,4,87,106,12,95,253,179,225,31,163,242,48,217,180,239,240,102,149,240,28,247,96,41,40,45,205,161,104,94,245,24,14,218,220,6,163,14,217,112,4,255,0,64,215,118,19,167,152,147,111,246,75,96,33,186,127,230,41,88,109,101,112,201,241,158,116,232,171,105,172,87,39,249,237,236,243,226,189,109,167,243,217,223,95,26,44,246,4,197,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f85e969-5663-4fc5-857b-99942ce033c3"));
		}

		#endregion

	}

	#endregion

}

